using Xamarin.Essentials;

namespace HomeQuarantine.Helpers
{
	public class NetworkConnectivityHelper
	{
		public static bool InternetIsDisconnected()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Invalid comparison between Unknown and I4
			if ((int)Connectivity.get_NetworkAccess() != 4)
			{
				return true;
			}
			return false;
		}
	}
}
