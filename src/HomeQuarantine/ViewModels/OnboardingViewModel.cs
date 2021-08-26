using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Permissions;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class OnboardingViewModel : ViewModelBase
	{
		private readonly List<OnboardingType> pageTypesWithoutBackButton = new List<OnboardingType>
		{
			OnboardingType.Address,
			OnboardingType.LocationServices,
			OnboardingType.CameraServices,
			OnboardingType.TestResultsAndSchedule
		};

		private readonly INavigationService navigationService;

		private readonly IExperienceApiService experienceApiService;

		private readonly ISettingsService settingsService;

		private readonly IOpenUrlService openUrlService;

		private readonly IDependencyService dependencyService;

		private readonly IPermissionsService permissionsService;

		private readonly IEventService eventService;

		private readonly IApiService apiService;

		private OnboardingType pageType;

		private string header;

		private string address;

		private string description;

		private string buttonText;

		private string imageSource;

		private Color colour;

		private bool permissionEnabled;

		private string addressHelpPageDescription;

		private bool isIndicatorVisible = true;

		public static string Title => Resources.OnboardingView_Title;

		public string SettingUpYourHomeForQuarantineUrl => "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29#scrollTo-Wheretoself-isolate/self-quarantine16";

		public OnboardingType PageType
		{
			get
			{
				return pageType;
			}
			set
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				pageType = value;
				OnboardingContent onboardingContent = App.Constants.OnboardingContent[value];
				Header = onboardingContent.Header;
				Description = onboardingContent.Text;
				ButtonText = onboardingContent.ButtonText;
				ImageSource = onboardingContent.ImageSource;
				Colour = onboardingContent.Colour;
				AddressHelpPageDescription = onboardingContent.AddressHelpPage;
				RaisePropertyChanged(() => PageType);
			}
		}

		public string Header
		{
			get
			{
				return header;
			}
			set
			{
				header = value;
				RaisePropertyChanged(() => Header);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set
			{
				description = value;
				RaisePropertyChanged(() => Description);
			}
		}

		public string ButtonText
		{
			get
			{
				return buttonText;
			}
			set
			{
				buttonText = value;
				RaisePropertyChanged(() => ButtonText);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				address = value;
				RaisePropertyChanged(() => Address);
			}
		}

		public string ImageSource
		{
			get
			{
				return imageSource;
			}
			set
			{
				imageSource = value;
				RaisePropertyChanged(() => ImageSource);
			}
		}

		public Color Colour
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return colour;
			}
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				colour = value;
				RaisePropertyChanged(() => Colour);
			}
		}

		public bool PermissionEnabled
		{
			get
			{
				return permissionEnabled;
			}
			set
			{
				permissionEnabled = value;
				RaisePropertyChanged(() => PermissionEnabled);
			}
		}

		public string AddressHelpPageDescription
		{
			get
			{
				return addressHelpPageDescription;
			}
			set
			{
				addressHelpPageDescription = value;
				RaisePropertyChanged(() => AddressHelpPageDescription);
			}
		}

		public bool IsIndicatorVisible
		{
			get
			{
				return isIndicatorVisible;
			}
			set
			{
				isIndicatorVisible = value;
				RaisePropertyChanged(() => isIndicatorVisible);
			}
		}

		public IAsyncCommand NextCommand => new AsyncCommand(async delegate
		{
			await GoToNextPage();
		});

		public IAsyncCommand RemovePreviousPagesCommand => new AsyncCommand(async delegate
		{
			await RemovePreviousPages();
		});

		public IAsyncCommand CallHelpCommand => new AsyncCommand(async delegate
		{
			await CallHelp();
		});

		public IAsyncCommand AddressHelpCommand => new AsyncCommand(async delegate
		{
			await GoToHelpPage();
		});

		public OnboardingViewModel(INavigationService navigationService, IExperienceApiService experienceApiService, ISettingsService settingsService, IOpenUrlService openUrlService, IDependencyService dependencyService, IPermissionsService permissionsService, IEventService eventService, IApiService apiService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.experienceApiService = experienceApiService ?? throw new ArgumentNullException("experienceApiService");
			this.settingsService = settingsService ?? throw new ArgumentNullException("settingsService");
			this.openUrlService = openUrlService ?? throw new ArgumentNullException("openUrlService");
			this.dependencyService = dependencyService ?? throw new ArgumentNullException("dependencyService");
			this.permissionsService = permissionsService ?? throw new ArgumentNullException("permissionsService");
			this.eventService = eventService ?? throw new ArgumentNullException("eventService");
			this.apiService = apiService ?? throw new ArgumentNullException("apiService");
		}

		public override async Task InitializeAsync(object navigationData)
		{
			await base.InitializeAsync(navigationData);
			if (navigationData is OnboardingType)
			{
				OnboardingType onboardingType = (OnboardingType)navigationData;
				if (onboardingType == OnboardingType.ReferenceNumber)
				{
					throw new NotSupportedException("ReferenceNumber");
				}
				PageType = onboardingType;
				if (onboardingType == OnboardingType.Address)
				{
					await GetUserAddressInformation();
				}
				return;
			}
			throw new ArgumentNullException("OnboardingType");
		}

		public async Task CheckForAppPermissions()
		{
			if (PageType == OnboardingType.PushNotifications)
			{
				PermissionEnabled = await permissionsService.AreNotificationsAllowed();
			}
			if (PageType == OnboardingType.LocationServices)
			{
				PermissionEnabled = await permissionsService.IsLocationPermissionAllowed();
			}
			if (PageType == OnboardingType.CameraServices)
			{
				PermissionEnabled = await permissionsService.IsCameraPermissionAllowed();
			}
		}

		public void AddPageTypeWithoutBackButton(OnboardingType type)
		{
			pageTypesWithoutBackButton.Add(type);
		}

		private async Task CallHelp()
		{
			await openUrlService.CallTel(Resources.OnBoarding_Address_NotCorrect_Phone?.Replace(" ", string.Empty));
		}

		private async Task GetUserAddressInformation()
		{
			SetBusyStatus(isBusy: true, Resources.OnboardingView_GettingAddress);
			await apiService.CallApi(new GetUserAddressApiAction(), async delegate(AddressResponse address)
			{
				Address = address.OnboardingAddress;
				ClearBusyStatus();
				await Task.CompletedTask;
			}, async delegate
			{
				ClearBusyStatus();
				dependencyService.Get<IFeedbackService>().Fail();
				await apiService.ShowGeneralError(App.Constants.AddressErrorHandlingPage, GetUserAddressInformation);
			});
		}

		private async Task GoToNextPage()
		{
			await SingleRunAsync(async delegate
			{
				if (PageType != OnboardingType.Address || !base.IsBusy)
				{
					if (PageType == OnboardingType.PushNotifications)
					{
						QuarantineStatusType status3 = await experienceApiService.GetOnboardingStatus();
						eventService.ShouldRegisterDeviceUpdated += async delegate(bool shouldRegister)
						{
							if (shouldRegister)
							{
								await permissionsService.RegisterDeviceForNotifications();
							}
						};
						if (!(await permissionsService.RequestNotificationsPermissionAndRegister()))
						{
							await permissionsService.LaunchNotificationHelpAlert();
							return;
						}
						if (status3 == QuarantineStatusType.QuarantineStarted)
						{
							if (!(await permissionsService.LaunchPermissionAlertsIfDisabled()))
							{
								settingsService.CurrentOnboardingPage = OnboardingType.ReferenceNumber;
								await navigationService.NavigateToAsync<MainViewModel>();
							}
							settingsService.AreNotificationsEnabledPreviously = true;
							return;
						}
					}
					if (PageType == OnboardingType.LocationServices)
					{
						QuarantineStatusType status3 = await experienceApiService.GetOnboardingStatus();
						if (!(await permissionsService.RequestLocationServicesPermission()))
						{
							await permissionsService.LaunchLocationHelpAlert();
							return;
						}
						if (status3 == QuarantineStatusType.QuarantineStarted)
						{
							if (!(await permissionsService.LaunchPermissionAlertsIfDisabled()))
							{
								settingsService.CurrentOnboardingPage = OnboardingType.ReferenceNumber;
								await navigationService.NavigateToAsync<MainViewModel>();
							}
							settingsService.AreLocationServicesEnabledPreviously = true;
							return;
						}
					}
					if (PageType == OnboardingType.CameraServices)
					{
						QuarantineStatusType status3 = await experienceApiService.GetOnboardingStatus();
						if (!(await permissionsService.RequestCameraServicesPermission()))
						{
							await permissionsService.LaunchCameraHelpAlert();
							return;
						}
						if (status3 == QuarantineStatusType.QuarantineStarted)
						{
							if (!(await permissionsService.LaunchPermissionAlertsIfDisabled()))
							{
								settingsService.CurrentOnboardingPage = OnboardingType.ReferenceNumber;
								await navigationService.NavigateToAsync<MainViewModel>();
							}
							settingsService.AreCameraServicesEnabledPreviously = true;
							return;
						}
					}
					if (PageType < OnboardingType.MonitoringSymptoms)
					{
						OnboardingType onboardingType = (OnboardingType)Enum.ToObject(typeof(OnboardingType), PageType + 1);
						dependencyService.Get<IFeedbackService>().Click();
						await navigationService.NavigateToAsync<OnboardingViewModel>(onboardingType);
						settingsService.CurrentOnboardingPage += 1;
					}
					else
					{
						SetBusyStatus(isBusy: true, Resources.OnboardingView_SavingYourDetails);
						try
						{
							await experienceApiService.CompleteOnboarding();
							INotificationService notificationService = dependencyService.Get<INotificationService>();
							await notificationService.RequestPermission();
							notificationService.RegisterForRemoteNotifications();
							ClearBusyStatus();
						}
						catch (Exception ex)
						{
							_ = ex;
							ClearBusyStatus();
							dependencyService.Get<IFeedbackService>().Fail();
							ErrorViewModel connectionErrorHandlingPage = App.Constants.ConnectionErrorHandlingPage;
							connectionErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
							{
								await GoToNextPage();
							});
							await navigationService.PushSingleErrorModal(null, connectionErrorHandlingPage);
							return;
						}
						dependencyService.Get<IFeedbackService>().Success();
						await navigationService.NavigateToAsync<MainViewModel>();
						settingsService.CurrentOnboardingPage = OnboardingType.ReferenceNumber;
						settingsService.OnboardingComplete = true;
					}
				}
			});
		}

		private async Task RemovePreviousPages()
		{
			if (pageTypesWithoutBackButton.Contains(PageType) || ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().get_NavigationStack().FirstOrDefault() is LoginView)
			{
				await navigationService.PopAllPreviousAsync();
			}
		}

		private async Task GoToHelpPage()
		{
			await openUrlService.OpenUrl(SettingUpYourHomeForQuarantineUrl);
		}
	}
}
