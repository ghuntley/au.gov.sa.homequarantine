using System;
using System.Windows.Input;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class DesignSystemViewModel : ViewModelBase
	{
		private INavigationService navigationService;

		public ResourceLinkModel ResourceLink1 => new ResourceLinkModel
		{
			Label = "<Useful resource link>",
			IsUrl = true
		};

		public ResourceLinkModel ResourceLink2 => new ResourceLinkModel
		{
			Label = "<Useful resource link>",
			IsUrl = true
		};

		public ICommand OpenOnboardingHelpCommand => (ICommand)new Command((Action<object>)delegate
		{
			OnboardingHelpViewModel locationServicesHelpViewModel = App.Constants.LocationServicesHelpViewModel;
			navigationService.PushModalAsync<OnboardingHelpViewModel>(locationServicesHelpViewModel);
		});

		public DesignSystemViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}
	}
}
