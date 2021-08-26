using System.Threading.Tasks;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Essentials;

namespace HomeQuarantine.Services.Network
{
	public class NetworkService : INetworkService
	{
		public bool IsConnectedToInternet => (int)Connectivity.get_NetworkAccess() == 4;

		public async Task LaunchNotConnectedAlert(IAsyncCommand retryCommand = null)
		{
			if (!IsConnectedToInternet)
			{
				INavigationService navigationService = ViewModelLocator.Resolve<INavigationService>();
				await navigationService.PushModalAsync(null, new ConnectionAlertViewModel(navigationService, ViewModelLocator.Resolve<IDependencyService>())
				{
					RetryCommand = retryCommand
				});
			}
		}
	}
}
