using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using HomeQuarantine.Interfaces;
using Xamarin.Essentials;

namespace HomeQuarantine.Droid.Services
{
	public class EnvironmentService : IEnvironmentService
	{
		public string GetVersionString()
		{
			Context context = Application.get_Context();
			return context.get_PackageManager().GetPackageInfo(context.get_PackageName(), (PackageInfoFlags)0).get_VersionName();
		}

		public string GetVersionNumber()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Invalid comparison between Unknown and I4
			Context context = Application.get_Context();
			PackageInfo packageInfo = context.get_PackageManager().GetPackageInfo(context.get_PackageName(), (PackageInfoFlags)0);
			if ((int)VERSION.get_SdkInt() >= 28)
			{
				return packageInfo.get_LongVersionCode().ToString();
			}
			return packageInfo.get_VersionCode().ToString();
		}

		public string GetDeviceType()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			DevicePlatform platform = DeviceInfo.get_Platform();
			return ((object)(DevicePlatform)(ref platform)).ToString();
		}

		public void CloseApplication()
		{
			Process.KillProcess(Process.MyPid());
		}
	}
}
