using System.Threading.Tasks;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class ConnectionAlertViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private readonly IDependencyService dependencyService;

		public IAsyncCommand OpenSettingsCommand => new AsyncCommand(async delegate
		{
			await OpenSettings();
		});

		public IAsyncCommand OnResumeCommand => new AsyncCommand(async delegate
		{
			await OnResume();
		});

		public IAsyncCommand RetryCommand { get; set; }

		public ConnectionAlertViewModel(INavigationService navigationService, IDependencyService dependencyService)
		{
			this.navigationService = navigationService;
			this.dependencyService = dependencyService;
		}

		private async Task OpenSettings()
		{
			await SingleRunAsync(async delegate
			{
				dependencyService.Get<IAppSettingsService>().OpenAppSettings();
			});
		}

		private async Task OnResume()
		{
			await navigationService.PopModalAsync();
			if (RetryCommand != null)
			{
				await RetryCommand.ExecuteAsync();
			}
		}
	}
}
