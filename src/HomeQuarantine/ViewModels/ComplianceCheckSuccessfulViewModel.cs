using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class ComplianceCheckSuccessfulViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private ComplianceCheckType pageType = ComplianceCheckType.ComplianceSuccessful;

		public ComplianceCheckType PageType
		{
			get
			{
				return pageType;
			}
			set
			{
				pageType = value;
				RaisePropertyChanged(() => PageType);
			}
		}

		public IAsyncCommand CloseCommand => new AsyncCommand(() => navigationService.PopModalAsync());

		public IAsyncCommand PopAllPreviousPagesCommand => new AsyncCommand(() => navigationService.PopAllPreviousAsync());

		public ComplianceCheckSuccessfulViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}
	}
}
