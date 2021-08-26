using System.Threading.Tasks;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class ComplianceCheckSuccessfulViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private readonly IEventService eventService;

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

		public IAsyncCommand CloseCommand => new AsyncCommand(async delegate
		{
			await Close();
		});

		public IAsyncCommand PopAllPreviousPagesCommand => new AsyncCommand(async delegate
		{
			await navigationService.PopAllPreviousAsync();
		});

		public ComplianceCheckSuccessfulViewModel(INavigationService navigationService, IEventService eventService)
		{
			this.navigationService = navigationService;
			this.eventService = eventService;
		}

		private async Task Close()
		{
			eventService.GetLatestNotifications();
			await navigationService.PopModalAsync();
		}
	}
}
