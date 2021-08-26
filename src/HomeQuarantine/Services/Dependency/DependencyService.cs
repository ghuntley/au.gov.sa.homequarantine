using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Services.Dependency
{
	public class DependencyService : IDependencyService
	{
		public DevicePlatform DevicePlatform => DeviceInfo.get_Platform();

		public T Get<T>() where T : class
		{
			return DependencyService.Get<T>((DependencyFetchTarget)0);
		}
	}
}
