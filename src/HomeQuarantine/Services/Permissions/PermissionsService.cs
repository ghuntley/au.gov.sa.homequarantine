using System;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Services.Permissions
{
	public class PermissionsService : IPermissionsService
	{
		private readonly INavigationService navigationService;

		private readonly IExperienceApiService experienceApiService;

		private readonly ISettingsService settingsService;

		private readonly IEventService eventService;

		public PermissionsService(INavigationService navigationService, IExperienceApiService experienceApiService, ISettingsService settingsService, IEventService eventService)
		{
			this.navigationService = navigationService;
			this.experienceApiService = experienceApiService;
			this.settingsService = settingsService;
			this.eventService = eventService;
		}

		public Task<bool> AreNotificationsAllowed()
		{
			INotificationService notificationService = DependencyService.Get<INotificationService>((DependencyFetchTarget)0);
			TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
			Device.BeginInvokeOnMainThread((Action)delegate
			{
				try
				{
					bool applicationNotificationSettings = notificationService.GetApplicationNotificationSettings();
					tcs.TrySetResult(applicationNotificationSettings);
				}
				catch (Exception exception)
				{
					tcs.TrySetException(exception);
				}
			});
			return tcs.Task;
		}

		public async Task<bool> RequestNotificationsPermissionAndRegister()
		{
			INotificationService notificationService = DependencyService.Get<INotificationService>((DependencyFetchTarget)0);
			bool notificationEnabled = await notificationService.RequestPermission();
			if (!(Device.get_RuntimePlatform() == "iOS"))
			{
				await RegisterDeviceForNotifications();
			}
			else
			{
				notificationService.RegisterForRemoteNotifications();
			}
			return notificationEnabled;
		}

		public async Task RegisterDeviceForNotifications()
		{
			INotificationService notificationService = DependencyService.Get<INotificationService>((DependencyFetchTarget)0);
			if (!string.IsNullOrEmpty(settingsService.NotificationsRegistrationToken))
			{
				DeviceRegistration deviceInfo = new DeviceRegistration
				{
					DeviceId = settingsService.DeviceId,
					DeviceToken = settingsService.NotificationsRegistrationToken,
					Platform = notificationService.GetNotificationPlatform()
				};
				await experienceApiService.RegisterDevice(deviceInfo);
			}
		}

		public async Task<bool> RequestLocationServicesPermission()
		{
			return (int)(await Permissions.RequestAsync<LocationWhenInUse>()) == 3;
		}

		public async Task<bool> IsLocationPermissionAllowed()
		{
			return (int)(await Permissions.CheckStatusAsync<LocationWhenInUse>()) == 3;
		}

		public async Task LaunchNotificationHelpAlert()
		{
			await navigationService.PushModalAsync(null, App.Constants.PushNotificationsHelpViewModel);
		}

		public async Task LaunchLocationHelpAlert()
		{
			await navigationService.PushModalAsync(null, App.Constants.LocationServicesHelpViewModel);
		}

		public async Task<bool> RequestCameraServicesPermission()
		{
			return (int)(await Permissions.RequestAsync<Camera>()) == 3;
		}

		public async Task<bool> IsCameraPermissionAllowed()
		{
			return (int)(await Permissions.CheckStatusAsync<Camera>()) == 3;
		}

		public async Task LaunchCameraHelpAlert()
		{
			await navigationService.PushModalAsync(null, App.Constants.CameraServicesHelpViewModel);
		}

		public async Task<bool> LaunchPermissionAlertsIfDisabled()
		{
			_ = 9;
			try
			{
				if (!string.IsNullOrEmpty(settingsService.AuthAccessToken) && await experienceApiService.GetOnboardingStatus() == QuarantineStatusType.QuarantineStarted)
				{
					if (!(await AreNotificationsAllowed()))
					{
						if (settingsService.AreNotificationsEnabledPreviously)
						{
							await LaunchNotificationHelpAlert();
							return true;
						}
						OnboardingViewModel onboardingViewModel = new OnboardingViewModel(navigationService, experienceApiService, settingsService, ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<IDependencyService>(), ViewModelLocator.Resolve<IPermissionsService>(), ViewModelLocator.Resolve<IEventService>(), ViewModelLocator.Resolve<IApiService>())
						{
							IsIndicatorVisible = false
						};
						onboardingViewModel.AddPageTypeWithoutBackButton(OnboardingType.PushNotifications);
						await navigationService.NavigateToAsync(OnboardingType.PushNotifications, onboardingViewModel);
						return true;
					}
					if (!(await IsLocationPermissionAllowed()))
					{
						if (settingsService.AreLocationServicesEnabledPreviously)
						{
							await LaunchLocationHelpAlert();
							return true;
						}
						OnboardingViewModel onboardingViewModel2 = new OnboardingViewModel(navigationService, experienceApiService, settingsService, ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<IDependencyService>(), ViewModelLocator.Resolve<IPermissionsService>(), ViewModelLocator.Resolve<IEventService>(), ViewModelLocator.Resolve<IApiService>())
						{
							IsIndicatorVisible = false
						};
						onboardingViewModel2.AddPageTypeWithoutBackButton(OnboardingType.LocationServices);
						await navigationService.NavigateToAsync(OnboardingType.LocationServices, onboardingViewModel2);
						return true;
					}
					if (!(await IsCameraPermissionAllowed()))
					{
						if (settingsService.AreCameraServicesEnabledPreviously)
						{
							await LaunchCameraHelpAlert();
							return true;
						}
						OnboardingViewModel onboardingViewModel3 = new OnboardingViewModel(navigationService, experienceApiService, settingsService, ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<IDependencyService>(), ViewModelLocator.Resolve<IPermissionsService>(), ViewModelLocator.Resolve<IEventService>(), ViewModelLocator.Resolve<IApiService>())
						{
							IsIndicatorVisible = false
						};
						onboardingViewModel3.AddPageTypeWithoutBackButton(OnboardingType.CameraServices);
						await navigationService.NavigateToAsync(OnboardingType.CameraServices, onboardingViewModel3);
						return true;
					}
				}
				return false;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}
