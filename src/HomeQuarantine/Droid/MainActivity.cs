using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Util;
using FFImageLoading.Forms.Platform;
using Firebase;
using HomeQuarantine.Android;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Interfaces;
using WindowsAzure.Messaging.NotificationHubs;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace HomeQuarantine.Droid
{
	[Activity(/*Could not decode attribute arguments.*/)]
	[IntentFilter(new string[] { "HomeQuarantine" }, Categories = new string[] { "android.intent.category.DEFAULT" })]
	public class MainActivity : FormsAppCompatActivity
	{
		internal static readonly string CHANNEL_ID = "home_quarantine_channel";

		protected override void OnCreate(Bundle savedInstanceState)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			((FormsAppCompatActivity)this).OnCreate(savedInstanceState);
			new Intent((Context)(object)this, typeof(MainActivity)).AddFlags((ActivityFlags)67108864);
			NotificationHub.SetListener((INotificationListener)(object)new AzureListener());
			NotificationHub.Start(((Activity)this).get_Application(), "dpc-hqt-nh-prod-aue-001", "Endpoint=sb://dpc-hqt-nhns-prod-aue-001.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=BFmYF54QZyBy6wsNl5iLkz/EQmN1kSCm958uCqqxbnU=");
			AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
			Platform.Init((Activity)(object)this, savedInstanceState);
			Forms.Init((Context)(object)this, savedInstanceState);
			FirebaseApp.InitializeApp(((Context)this).get_ApplicationContext());
			CachedImageRenderer.Init((bool?)true);
			((FormsAppCompatActivity)this).LoadApplication((Application)new App());
			ProcessNotificationActions(((Activity)this).get_Intent());
		}

		protected override void OnResume()
		{
			((FormsAppCompatActivity)this).OnResume();
			Platform.OnResume((Activity)(object)this);
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
		{
			Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			((Activity)this).OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}

		protected override void OnNewIntent(Intent intent)
		{
			((FormsAppCompatActivity)this).OnNewIntent(intent);
			ProcessNotificationActions(intent);
		}

		private void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
		{
			try
			{
				Log.Error("Crash Report", (e.ExceptionObject as Exception).Message);
			}
			catch
			{
			}
		}

		public override void OnBackPressed()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			((App)Application.get_Current()).RequestCloseOnBackButton((Action<BackButtonAction>)delegate(BackButtonAction action)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Invalid comparison between Unknown and I4
				if ((int)action != 0)
				{
					if ((int)action == 1)
					{
						Process.KillProcess(Process.MyPid());
					}
				}
				else
				{
					((FormsAppCompatActivity)this).OnBackPressed();
				}
			});
		}

		private void ProcessNotificationActions(Intent intent)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			try
			{
				if (intent.HasExtra("action"))
				{
					PushNotification val = new PushNotification();
					val.set_Title(GetStringExtra(intent, "title"));
					val.set_Message(GetStringExtra(intent, "body"));
					val.set_Action(GetStringExtra(intent, "action"));
					val.set_ReceivedInBackground(true);
					PushNotification val2 = val;
					INotificationService obj = DependencyService.Get<INotificationService>((DependencyFetchTarget)0);
					if (obj != null)
					{
						obj.ReceiveNotification(val2);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private string GetStringExtra(Intent intent, string key)
		{
			if (intent != null && intent.HasExtra(key))
			{
				string stringExtra = intent.GetStringExtra(key);
				if (!string.IsNullOrEmpty(stringExtra))
				{
					return stringExtra;
				}
			}
			return string.Empty;
		}

		public MainActivity()
			: this()
		{
		}
	}
}
