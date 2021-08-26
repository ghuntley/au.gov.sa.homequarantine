using System.Threading.Tasks;
using Android.App;
using Android.Gms.Common;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.NotificationActions;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Essentials;

namespace HomeQuarantine.Droid.Services
{
	public class NotificationService : INotificationService
	{
		public bool NotificationsSupported => ((GoogleApiAvailabilityLight)GoogleApiAvailability.get_Instance()).IsGooglePlayServicesAvailable(Application.get_Context()) == 0;

		public async Task<bool> RequestPermission()
		{
			ActivityCompat.RequestPermissions(Platform.get_CurrentActivity(), new string[1] { "android.permission.ACCESS_NOTIFICATION_POLICY" }, 1);
			return await Task.Run(() => (int)ContextCompat.CheckSelfPermission(Application.get_Context(), "android.permission.ACCESS_NOTIFICATION_POLICY") == 0);
		}

		public string GetNotificationPlatform()
		{
			return "fcm";
		}

		public async Task ReceiveNotification(PushNotification notification)
		{
			await ViewModelLocator.Resolve<INotificationActionsService>().OpenOrAddToQueue(notification);
		}

		public bool GetApplicationNotificationSettings()
		{
			return NotificationManagerCompat.From(Application.get_Context()).AreNotificationsEnabled();
		}

		public void RegisterForRemoteNotifications()
		{
			IEventService obj = ViewModelLocator.Resolve<IEventService>();
			bool shouldRegisterDevice = !string.IsNullOrEmpty(ViewModelLocator.Resolve<ISettingsService>().get_NotificationsRegistrationToken());
			obj.set_ShouldRegisterDevice(shouldRegisterDevice);
		}

		public void CompleteRegistration(string deviceToken)
		{
			ViewModelLocator.Resolve<ISettingsService>().set_NotificationsRegistrationToken(deviceToken);
		}
	}
}
