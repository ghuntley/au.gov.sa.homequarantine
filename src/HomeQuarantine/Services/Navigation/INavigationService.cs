using System.Threading.Tasks;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.Services.Navigation
{
	public interface INavigationService
	{
		ViewModelBase PreviousPageViewModel { get; }

		ViewModelBase CurrentViewModel { get; }

		Task InitializeAsync();

		Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

		Task NavigateToAsync<TViewModel>(object parameter, TViewModel viewModel = null) where TViewModel : ViewModelBase;

		Task PushModalAsync<TViewModel>() where TViewModel : ViewModelBase;

		Task PushModalAsync<TViewModel>(object parameter = null, TViewModel viewModel = null) where TViewModel : ViewModelBase;

		Task PushSingleErrorModal(object parameter = null, ErrorViewModel viewModel = null);

		Task PopAsync();

		Task PopToRootAsync();

		Task PopModalAsync();

		Task PopPreviousAsync();

		Task PopAllPreviousAsync();
	}
}
