using System;
using Android.App;
using Android.Content;
using AndroidX.Core.App;
using Firebase.Messaging;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Droid.Services
{
	[Service]
	[IntentFilter(new string[] { "com.google.firebase.MESSAGING_EVENT" })]
	public class PushNotificationFirebaseMessagingService : FirebaseMessagingService
	{
		public override void OnNewToken(string token)
		{
			((FirebaseMessagingService)this).OnNewToken(token);
			ViewModelLocator.Resolve<ISettingsService>().set_NotificationsRegistrationToken(token);
			DependencyService.Get<INotificationService>((DependencyFetchTarget)0).CompleteRegistration(token);
			ViewModelLocator.Resolve<IEventService>().set_ShouldRegisterDevice(token != null);
		}

		public override void OnMessageReceived(RemoteMessage message)
		{
			MainThread.BeginInvokeOnMainThread((Action)async delegate
			{
				Intent val = new Intent((Context)(object)this, typeof(MainActivity));
				val.AddFlags((ActivityFlags)67108864);
				PendingIntent activity = PendingIntent.GetActivity((Context)(object)this, 0, val, (PendingIntentFlags)1073741824);
				Builder val2 = new Builder((Context)(object)this, MainActivity.CHANNEL_ID);
				val2.SetContentTitle(message.GetNotification().get_Title()).SetSmallIcon(2131230974).SetContentText(message.GetNotification().get_Body())
					.SetAutoCancel(true)
					.SetShowWhen(false)
					.SetContentIntent(activity);
				NotificationManager.FromContext((Context)(object)this).Notify(0, val2.Build());
				if (message.get_Data().TryGetValue("action", out var value))
				{
					PushNotification val3 = new PushNotification();
					RemoteMessage obj = message;
					val3.set_Title((obj != null) ? obj.GetNotification().get_Title() : null);
					RemoteMessage obj2 = message;
					object message2;
					if (obj2 == null)
					{
						message2 = null;
					}
					else
					{
						Notification notification = obj2.GetNotification();
						message2 = ((notification != null) ? notification.get_Body() : null);
					}
					val3.set_Message((string)message2);
					val3.set_Action(value);
					val3.set_ReceivedInBackground(false);
					PushNotification val4 = val3;
					await DependencyService.Get<INotificationService>((DependencyFetchTarget)0).ReceiveNotification(val4);
				}
			});
		}

		public PushNotificationFirebaseMessagingService()
			: this()
		{
		}
	}
}
