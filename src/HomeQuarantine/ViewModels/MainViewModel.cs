using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.ComplianceCheck;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Dialog;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Identity;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.NotificationActions;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels.Base;
using Humanizer;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		private readonly IComplianceCheckService complianceCheckService;

		private readonly IDependencyService dependencyService;

		private readonly IDialogService dialogService;

		private readonly IEventService eventService;

		private readonly IExperienceApiService experienceApiService;

		private readonly IIdentityService identityService;

		private readonly INavigationService navigationService;

		private readonly INotificationActionsService actionService;

		private readonly IOpenUrlService openUrlService;

		private readonly ISettingsService settingsService;

		private readonly IApiService apiService;

		private TestingScheduleViewModel testingScheduleViewModel;

		private bool isDoingInitialLoad = true;

		private bool isRefreshing;

		private ICommand refreshCommand;

		private IEnumerable<NotificationResponse> unreadNotifications = new List<NotificationResponse>();

		private DateTime? expectedEndDate;

		public bool IsDebug => false;

		public string Title => "Home Quarantine";

		public IAsyncCommand PerformActionCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await PerformFirstActionFromQueue();
			});
		});

		public IAsyncCommand OpenSymptomCheckCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await OpenSymptomCheck();
			});
		});

		public IAsyncCommand GuidelinesCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await OpenGuidelines();
			});
		});

		public IAsyncCommand SupportResourcesCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await OpenSupportResources();
			});
		});

		public IAsyncCommand FAQsCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await OpenFAQs();
			});
		});

		public IAsyncCommand OpenDesignSystemCommmand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await OpenDesignSystem();
			});
		});

		public IAsyncCommand OpenTestingScheduleCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await navigationService.NavigateToAsync(null, testingScheduleViewModel);
			});
		});

		public IAsyncCommand LogoutCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await Logout();
			});
		});

		public bool AppIsNotLatestVersion => !(eventService.AppVersion?.LatestVersion ?? true);

		public bool IsDoingInitialLoad
		{
			get
			{
				return isDoingInitialLoad;
			}
			set
			{
				if (isDoingInitialLoad != value)
				{
					isDoingInitialLoad = value;
					RaisePropertyChanged(() => IsDoingInitialLoad);
				}
			}
		}

		public bool IsRefreshing
		{
			get
			{
				return isRefreshing;
			}
			set
			{
				if (isRefreshing != value)
				{
					isRefreshing = value;
					RaisePropertyChanged(() => IsRefreshing);
				}
			}
		}

		public ICommand RefreshCommand
		{
			get
			{
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				//IL_0023: Expected O, but got Unknown
				ICommand command = refreshCommand;
				if (command == null)
				{
					Command val = new Command((Action)async delegate
					{
						if (!IsDoingInitialLoad)
						{
							IsRefreshing = true;
							await RefreshContent();
							IsRefreshing = false;
						}
					});
					ICommand command2 = (ICommand)val;
					refreshCommand = (ICommand)val;
					command = command2;
				}
				return command;
			}
		}

		public string MainViewTitle => base.Strings.MainViewTitle;

		public string VersionNumber => Resources.Version + " " + dependencyService.Get<IEnvironmentService>().GetVersionString() + " (" + dependencyService.Get<IEnvironmentService>().GetVersionNumber() + ")";

		public DateTime? ExpectedEndDate
		{
			get
			{
				return expectedEndDate;
			}
			set
			{
				expectedEndDate = value;
				RaisePropertyChanged(() => ExpectedEndDayLabel);
				RaisePropertyChanged(() => ExpectedEndDateLabel);
			}
		}

		public string ExpectedEndDayLabel
		{
			get
			{
				if (!ExpectedEndDate.HasValue)
				{
					return string.Empty;
				}
				return ExpectedEndDate?.ToString("ddddd,", CultureInfo.CreateSpecificCulture("en-US"));
			}
		}

		public string ExpectedEndDateLabel
		{
			get
			{
				if (!ExpectedEndDate.HasValue)
				{
					return string.Empty;
				}
				string obj = ExpectedEndDate?.Day.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));
				DateTime? dateTime = ExpectedEndDate;
				object obj2;
				if (!dateTime.HasValue)
				{
					obj2 = null;
				}
				else
				{
					string text = OrdinalizeExtensions.Ordinalize(dateTime.GetValueOrDefault().Day);
					DateTime? dateTime2 = ExpectedEndDate;
					obj2 = text.Substring(Math.Max(0, (dateTime2.HasValue ? new int?(OrdinalizeExtensions.Ordinalize(dateTime2.GetValueOrDefault().Day).Length - 2) : null).Value));
				}
				return obj + (string?)obj2 + " " + ExpectedEndDate?.ToString("MMM ", CultureInfo.CreateSpecificCulture("en-US"));
			}
		}

		public IEnumerable<NotificationResponse> UnreadNotifications
		{
			get
			{
				return unreadNotifications;
			}
			set
			{
				unreadNotifications = value;
				RaisePropertyChanged(() => UnreadNotifications);
				RaisePropertyChanged(() => NotificationCountLabel);
				RaisePropertyChanged(() => NoUnreadNotifications);
				RaisePropertyChanged(() => ShowViewAllNotifications);
			}
		}

		public IAsyncCommand<NotificationResponse> NotificationTapCommand => new AsyncCommand<NotificationResponse>(async delegate(NotificationResponse o)
		{
			await OnNotificationTap(o);
		});

		public string NotificationCountLabel => string.Format(Resources.HomePage_NotificationsCount, UnreadNotifications.Count());

		public bool NoUnreadNotifications => UnreadNotifications.Count() == 0;

		public double NotificationWidth
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				DisplayInfo mainDisplayInfo = DeviceDisplay.get_MainDisplayInfo();
				double width = ((DisplayInfo)(ref mainDisplayInfo)).get_Width();
				mainDisplayInfo = DeviceDisplay.get_MainDisplayInfo();
				return Math.Min(600.0, width / ((DisplayInfo)(ref mainDisplayInfo)).get_Density() - 56.0);
			}
		}

		public IAsyncCommand CallHelpCommand => new AsyncCommand(async delegate
		{
			await CallHelp();
		});

		public IAsyncCommand ViewAllNotificationCommand => new AsyncCommand(async delegate
		{
			await ViewAllNotification();
		});

		public IAsyncCommand PrivacyPolicyCommand => new AsyncCommand(async delegate
		{
			await OpenPrivacyPolicy();
		});

		public IAsyncCommand CheckInCommand => new AsyncCommand(async delegate
		{
			await OpenCheckIn();
		});

		public IAsyncCommand LoadNotificationsCommand => new AsyncCommand(async delegate
		{
			await LoadNotifications();
		});

		public IAsyncCommand OpenVersionUpdateCommand => new AsyncCommand(async delegate
		{
			await OpenAppOutdatedPage();
		});

		public bool ShowViewAllNotifications { get; set; }

		public MainViewModel(IComplianceCheckService complianceCheckService, IDependencyService dependencyService, IDialogService dialogService, IEventService eventService, IExperienceApiService experienceApiService, IIdentityService identityService, INavigationService navigationService, INotificationActionsService actionService, IOpenUrlService openUrlService, ISettingsService settingsService, IApiService apiService)
		{
			this.complianceCheckService = complianceCheckService;
			this.dependencyService = dependencyService;
			this.dialogService = dialogService;
			this.eventService = eventService;
			this.experienceApiService = experienceApiService;
			this.identityService = identityService;
			this.navigationService = navigationService;
			this.actionService = actionService;
			this.openUrlService = openUrlService;
			this.settingsService = settingsService;
			this.apiService = apiService;
			this.eventService.GetLatestNotificationsEvent += async delegate
			{
				await LoadNotifications();
			};
		}

		public override async Task InitializeAsync(object navigationData)
		{
			testingScheduleViewModel = new TestingScheduleViewModel(navigationService, apiService);
			await GetTestingSchedule();
			await RefreshContent();
			IsDoingInitialLoad = false;
			eventService.AppVersionUpdated += async delegate(AppVersion appVersion)
			{
				RaisePropertyChanged(() => AppIsNotLatestVersion);
				if (!appVersion.LatestVersion)
				{
					await OpenAppOutdatedPage();
				}
			};
			if (AppIsNotLatestVersion)
			{
				await Device.InvokeOnMainThreadAsync((Func<Task>)async delegate
				{
					await OpenAppOutdatedPage();
				});
			}
		}

		private async Task RefreshContent()
		{
			base.IsBusy = true;
			await LoadNotifications();
			base.IsBusy = false;
		}

		private async Task GetTestingSchedule()
		{
			try
			{
				await testingScheduleViewModel.LoadContent();
			}
			catch (Exception ex)
			{
				_ = ex;
				ClearBusyStatus();
				ErrorViewModel connectionErrorHandlingPage = App.Constants.ConnectionErrorHandlingPage;
				connectionErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
				{
					await InitializeAsync(null);
				});
				await navigationService.PushSingleErrorModal(null, connectionErrorHandlingPage);
			}
		}

		private async Task OpenSymptomCheck()
		{
			await navigationService.PushModalAsync<SymptomCheckViewModel>();
		}

		private async Task Logout()
		{
			if (await dialogService.DisplayAlert("Log out", "Are you sure you want to log out?", "Log out", "Cancel"))
			{
				await identityService.Logout();
				settingsService.ClearAllUserDetails();
				await navigationService.NavigateToAsync<LoginViewModel>();
			}
		}

		private async Task OpenDesignSystem()
		{
			await navigationService.NavigateToAsync<DesignSystemViewModel>();
		}

		private async Task OnNotificationTap(NotificationResponse notification)
		{
			try
			{
				await HandleNotification(notification);
			}
			catch (Exception ex)
			{
				_ = ex;
				ErrorViewModel connectionErrorHandlingPage = App.Constants.ConnectionErrorHandlingPage;
				connectionErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
				{
					await InitializeAsync(null);
				});
				await navigationService.PushSingleErrorModal(null, connectionErrorHandlingPage);
			}
		}

		private async Task LoadNotifications()
		{
			await apiService.CallApi(new GetUnreadNotificationsApiAction(), async delegate(IEnumerable<NotificationResponse> notifications)
			{
				UnreadNotifications = notifications.Where((NotificationResponse n) => n.AppearsOnHomePage && !n.DateRead.HasValue);
				ShowViewAllNotifications = notifications.Any((NotificationResponse n) => n.AppearsInHistory && n.DateRead.HasValue);
				await Task.CompletedTask;
			}, async delegate
			{
				await apiService.ShowGeneralError(App.Constants.ConnectionErrorHandlingPage, async delegate
				{
					await InitializeAsync(null);
				});
			});
		}

		private async Task HandleNotification(NotificationResponse notification)
		{
			switch (notification.NotificationType)
			{
			case NotificationType.SymptomCheck:
			case NotificationType.SymptomCheckReminder:
				await navigationService.PushModalAsync<SymptomCheckViewModel>();
				break;
			case NotificationType.ComplianceCheck:
			case NotificationType.ComplianceCheckReminder:
				await complianceCheckService.ShowComplianceCheck();
				break;
			case NotificationType.HomeQuarantineStarted:
				await apiService.CallApi(new SetNotificationReadActionApi(notification.NotificationId));
				await navigationService.NavigateToAsync(null, App.Constants.WelcomeNotificationViewModel);
				break;
			}
		}

		private async Task CallHelp()
		{
			await openUrlService.CallTel(Resources.HomePage_ControlBranchNumber?.Replace(" ", string.Empty));
		}

		private async Task ViewAllNotification()
		{
			await navigationService.NavigateToAsync<ViewAllNotificationViewModel>();
		}

		private async Task OpenGuidelines()
		{
			await navigationService.NavigateToAsync(null, App.Constants.GuidelinesPage);
		}

		private async Task OpenSupportResources()
		{
			await navigationService.NavigateToAsync(null, App.Constants.SupportResourcesPage);
		}

		private async Task OpenFAQs()
		{
			await navigationService.NavigateToAsync(null, App.Constants.FAQsPage);
		}

		private async Task OpenPrivacyPolicy()
		{
			await openUrlService.OpenUrl("https://covid-19.sa.gov.au/hqprivacy");
		}

		private async Task PerformFirstActionFromQueue()
		{
			await actionService.TakeFromQueue();
		}

		private async Task OpenCheckIn()
		{
			await complianceCheckService.ShowComplianceCheck();
		}

		private async Task OpenAppOutdatedPage()
		{
			await navigationService.PushModalAsync(null, App.Constants.AppVersionOutdatedViewModel);
		}
	}
}
