using System;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Models.User;
using HomeQuarantine.Helpers;

namespace HomeQuarantine.Services.Settings
{
	public class SettingsService : ISettingsService
	{
		private readonly PreferenceHelper prefs;

		private readonly EncryptedAuthTokenHelper tokenHelper;

		public string DeviceId
		{
			get
			{
				return prefs.GetValueOrDefault("device_id", string.Empty);
			}
			set
			{
				prefs.AddOrUpdateValue("device_id", value);
			}
		}

		public string AuthAccessToken { get; set; } = string.Empty;


		public string AuthIdToken { get; set; } = string.Empty;


		public DateTime AuthExpiry
		{
			get
			{
				return prefs.GetValueOrDefault("auth_expiry", DateTime.MinValue);
			}
			set
			{
				prefs.AddOrUpdateValue("auth_expiry", value);
			}
		}

		public string AuthRefreshToken
		{
			get
			{
				return Task.Run(async delegate
				{
					string valueOrDefault = prefs.GetValueOrDefault("refresh_token", string.Empty);
					return await tokenHelper.DecryptAuthToken(valueOrDefault);
				}).Result;
			}
			set
			{
				Task.Run(async delegate
				{
					string value2 = await tokenHelper.EncryptAuthToken(value);
					prefs.AddOrUpdateValue("refresh_token", value2);
				}).GetAwaiter().GetResult();
			}
		}

		public OnboardingType CurrentOnboardingPage
		{
			get
			{
				return (OnboardingType)Enum.Parse(typeof(OnboardingType), prefs.GetValueOrDefault("current_onboarding_page", OnboardingType.ReferenceNumber.ToString()));
			}
			set
			{
				prefs.AddOrUpdateValue("current_onboarding_page", value.ToString());
			}
		}

		public bool OnboardingComplete
		{
			get
			{
				return prefs.GetValueOrDefault("onboarding_complete", defaultValue: false);
			}
			set
			{
				prefs.AddOrUpdateValue("onboarding_complete", value);
			}
		}

		public UserInfo UserInfo { get; set; }

		public string HealthReferenceID { get; set; }

		public bool AreNotificationsEnabledPreviously
		{
			get
			{
				return prefs.GetValueOrDefault("notifications_enabled_previously", defaultValue: false);
			}
			set
			{
				prefs.AddOrUpdateValue("notifications_enabled_previously", value);
			}
		}

		public bool AreLocationServicesEnabledPreviously
		{
			get
			{
				return prefs.GetValueOrDefault("locationservices_enabled_previously", defaultValue: false);
			}
			set
			{
				prefs.AddOrUpdateValue("locationservices_enabled_previously", value);
			}
		}

		public string NotificationsRegistrationToken
		{
			get
			{
				return prefs.GetValueOrDefault("notification_registration_token", string.Empty);
			}
			set
			{
				prefs.AddOrUpdateValue("notification_registration_token", value);
			}
		}

		public bool AreCameraServicesEnabledPreviously
		{
			get
			{
				return prefs.GetValueOrDefault("cameraservices_enabled_previously", defaultValue: false);
			}
			set
			{
				prefs.AddOrUpdateValue("cameraservices_enabled_previously", value);
			}
		}

		public bool HasShownAppVersionOutdatedPage { get; set; }

		public SettingsService()
		{
			prefs = new PreferenceHelper();
			tokenHelper = new EncryptedAuthTokenHelper();
			SetupDeviceId();
		}

		public SettingsService(PreferenceHelper prefs, EncryptedAuthTokenHelper tokenHelper)
		{
			this.prefs = prefs ?? throw new ArgumentNullException("prefs");
			this.tokenHelper = tokenHelper ?? throw new ArgumentNullException("tokenHelper");
			this.tokenHelper = new EncryptedAuthTokenHelper();
			SetupDeviceId();
		}

		public void ClearAllUserDetails()
		{
			HealthReferenceID = null;
			AuthAccessToken = null;
			AuthExpiry = DateTime.MinValue;
			AuthIdToken = null;
			AuthRefreshToken = null;
			UserInfo = null;
			OnboardingComplete = false;
			CurrentOnboardingPage = OnboardingType.ReferenceNumber;
		}

		private void SetupDeviceId()
		{
			if (string.IsNullOrEmpty(DeviceId))
			{
				DeviceId = Guid.NewGuid().ToString();
			}
		}
	}
}
