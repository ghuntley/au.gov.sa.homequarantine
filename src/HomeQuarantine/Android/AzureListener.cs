using System;
using Android.Content;
using Android.Runtime;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Interfaces;
using Java.Interop;
using Java.Lang;
using WindowsAzure.Messaging.NotificationHubs;
using Xamarin.Forms;

namespace HomeQuarantine.Android
{
	public class AzureListener : Object, INotificationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		public async void OnPushNotificationReceived(Context context, INotificationMessage message)
		{
			if (message.get_Data().TryGetValue("action", out var value))
			{
				PushNotification val = new PushNotification();
				val.set_Title(message.get_Title());
				val.set_Message(message.get_Body());
				val.set_Action(value);
				val.set_ReceivedInBackground(true);
				PushNotification val2 = val;
				await DependencyService.Get<INotificationService>((DependencyFetchTarget)0).ReceiveNotification(val2);
			}
		}

		public AzureListener()
			: this()
		{
		}
	}
}
