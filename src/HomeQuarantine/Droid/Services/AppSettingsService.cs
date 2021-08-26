using Android.App;
using Android.Content;
using Android.Net;
using HomeQuarantine.Interfaces;
using Xamarin.Essentials;

namespace HomeQuarantine.Droid.Services
{
	public class AppSettingsService : IAppSettingsService
	{
		public void OpenAppSettings()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			string packageName = AppInfo.get_PackageName();
			Intent val = new Intent("android.settings.APPLICATION_DETAILS_SETTINGS");
			val.AddFlags((ActivityFlags)268435456);
			Uri data = Uri.FromParts("package", packageName, (string)null);
			val.SetData(data);
			Application.get_Context().StartActivity(val);
		}
	}
}
