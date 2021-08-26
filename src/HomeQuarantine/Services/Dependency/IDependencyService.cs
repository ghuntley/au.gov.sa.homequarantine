using Xamarin.Essentials;

namespace HomeQuarantine.Services.Dependency
{
	public interface IDependencyService
	{
		DevicePlatform DevicePlatform { get; }

		T Get<T>() where T : class;
	}
}
