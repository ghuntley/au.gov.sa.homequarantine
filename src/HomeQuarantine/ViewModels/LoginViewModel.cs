using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using HomeQuarantine.Data.Mocks.Helpers;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.DeviceSecurity;
using HomeQuarantine.Services.Dialog;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Identity;
using HomeQuarantine.Services.Language;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.Network;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Permissions;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels.Base;
using Microsoft.AppCenter.Analytics;

namespace HomeQuarantine.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{
		private readonly IDependencyService dependencyService;

		private readonly IDeviceSecurityService deviceSecurityService;

		private readonly IDialogService dialogService;

		private readonly IEventService eventService;

		private readonly IExperienceApiService experienceApiService;

		private readonly IIdentityService identityService;

		private readonly ILanguageService languageService;

		private readonly INavigationService navigationService;

		private readonly INetworkService networkService;

		private readonly ISettingsService settingsService;

		private readonly IPermissionsService permissionsService;

		private readonly IOpenUrlService openUrlService;

		private bool isRedirecting;

		private string mockUsername;

		public bool IsMock => false;

		public string MockUsername
		{
			get
			{
				return mockUsername;
			}
			set
			{
				mockUsername = value;
				RaisePropertyChanged(() => MockUsername);
			}
		}

		public string VersionNumber => Resources.Version + " " + dependencyService.Get<IEnvironmentService>().GetVersionString() + " (" + dependencyService.Get<IEnvironmentService>().GetVersionNumber() + ")";

		public bool IsRedirecting
		{
			get
			{
				return isRedirecting;
			}
			set
			{
				isRedirecting = value;
				RaisePropertyChanged(() => IsRedirecting);
			}
		}

		public IAsyncCommand PrivacyPolicyCommand => new AsyncCommand(async delegate
		{
			await OpenPrivacyPolicy();
		});

		public IAsyncCommand SignInCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await CheckAuthAndRedirect(async delegate
				{
					dependencyService.Get<IFeedbackService>().Click();
					return await identityService.Authenticate();
				});
			});
		});

		public IAsyncCommand CheckAuthCommand => new AsyncCommand(async delegate
		{
			if (!IsRedirecting)
			{
				await CheckAuthAndRedirect(async () => await identityService.CheckAndRefreshToken());
			}
		});

		public LoginViewModel(IDependencyService dependencyService, IDeviceSecurityService deviceSecurityService, IDialogService dialogService, IEventService eventService, IExperienceApiService experienceApiService, IIdentityService identityService, ILanguageService languageService, INavigationService navigationService, INetworkService networkService, ISettingsService settingsService, IPermissionsService permissionsService, IOpenUrlService openUrlService)
		{
			this.dependencyService = dependencyService;
			this.deviceSecurityService = deviceSecurityService;
			this.dialogService = dialogService;
			this.eventService = eventService;
			this.experienceApiService = experienceApiService;
			this.identityService = identityService;
			this.languageService = languageService;
			this.navigationService = navigationService;
			this.networkService = networkService;
			this.settingsService = settingsService;
			this.permissionsService = permissionsService;
			this.openUrlService = openUrlService;
			base.IsBusy = true;
		}

		private async Task CheckAuthAndRedirect(Func<Task<bool>> authAction)
		{
			try
			{
				base.IsBusy = true;
				if (!networkService.IsConnectedToInternet)
				{
					await networkService.LaunchNotConnectedAlert();
				}
				else
				{
					if (await Task.Run(async () => await GetDeviceIsBreached()) || await Task.Run(async () => await deviceSecurityService.GetAppIsExpired()))
					{
						return;
					}
					IsRedirecting = true;
					if (await authAction())
					{
						dependencyService.Get<IFeedbackService>().Success();
						QuarantineStatusType type = await Task.Run(async () => await experienceApiService.GetOnboardingStatus());
						await Navigate(authAction, type);
					}
					return;
				}
			}
			catch (Exception ex)
			{
				_ = ex;
				ErrorViewModel loginErrorHandlingPage = App.Constants.LoginErrorHandlingPage;
				loginErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
				{
					await CheckAuthAndRedirect(authAction);
				});
				dependencyService.Get<IFeedbackService>().Fail();
				await navigationService.PushSingleErrorModal(null, loginErrorHandlingPage);
			}
			finally
			{
				IsRedirecting = false;
				base.IsBusy = false;
			}
		}

		private async Task Navigate(Func<Task<bool>> authAction, QuarantineStatusType type)
		{
			switch (type)
			{
			case QuarantineStatusType.QuarantineStarted:
				if (!(await permissionsService.LaunchPermissionAlertsIfDisabled()))
				{
					await navigationService.NavigateToAsync<MainViewModel>();
					await RegisterDevice(authAction);
				}
				break;
			case QuarantineStatusType.OnboardingInProgress:
				if (settingsService.CurrentOnboardingPage == OnboardingType.ReferenceNumber)
				{
					settingsService.CurrentOnboardingPage = OnboardingType.Address;
				}
				await navigationService.NavigateToAsync<OnboardingViewModel>(settingsService.CurrentOnboardingPage);
				break;
			case QuarantineStatusType.OnboardingNotStarted:
				await navigationService.NavigateToAsync<OnboardingReferenceIDViewModel>();
				break;
			default:
				throw new InvalidDataException("QuarantineStatusType");
			}
		}

		private async Task<bool> SetupMockUser()
		{
			App.MockUser = MockUsersHelper.GetMockUser(MockUsername);
			return true;
		}

		private async Task<bool> GetDeviceIsBreached()
		{
			if (deviceSecurityService.IsBreached(out var reasons))
			{
				Analytics.TrackEvent("IsBreached", (IDictionary<string, string>)reasons);
				await dialogService.DisplayAlert(Resources.DeviceSecurity_Title, Resources.DeviceSecurity_Message_Jailbroken, Resources.DeviceSecurity_Button_Jailbroken);
				dependencyService.Get<IEnvironmentService>().CloseApplication();
				return true;
			}
			return false;
		}

		private async Task<bool> RegisterDevice(Func<Task<bool>> authAction)
		{
			try
			{
				return await Task.Run(async delegate
				{
					await permissionsService.RegisterDeviceForNotifications();
					eventService.ShouldRegisterDeviceUpdated += async delegate(bool shouldRegister)
					{
						if (shouldRegister)
						{
							await permissionsService.RegisterDeviceForNotifications();
						}
					};
					return true;
				});
			}
			catch (Exception ex)
			{
				_ = ex;
				ErrorViewModel connectionErrorHandlingPage = App.Constants.ConnectionErrorHandlingPage;
				connectionErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
				{
					await CheckAuthAndRedirect(authAction);
				});
				dependencyService.Get<IFeedbackService>().Fail();
				await navigationService.PushSingleErrorModal(null, connectionErrorHandlingPage);
				return false;
			}
		}

		private async Task OpenPrivacyPolicy()
		{
			await openUrlService.OpenUrl("https://covid-19.sa.gov.au/hqprivacy");
		}
	}
}
