using System;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Models.User;

namespace HomeQuarantine.Services.Settings
{
	public interface ISettingsService
	{
		string DeviceId { get; set; }

		DateTime AuthExpiry { get; set; }

		string AuthRefreshToken { get; set; }

		string AuthAccessToken { get; set; }

		string AuthIdToken { get; set; }

		OnboardingType CurrentOnboardingPage { get; set; }

		bool OnboardingComplete { get; set; }

		string HealthReferenceID { get; set; }

		UserInfo UserInfo { get; set; }

		bool AreNotificationsEnabledPreviously { get; set; }

		bool AreLocationServicesEnabledPreviously { get; set; }

		string NotificationsRegistrationToken { get; set; }

		bool AreCameraServicesEnabledPreviously { get; set; }

		bool HasShownAppVersionOutdatedPage { get; set; }

		void ClearAllUserDetails();
	}
}
