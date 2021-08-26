using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class ErrorViewModel : ViewModelBase
	{
		private readonly IOpenUrlService openUrlService;

		private readonly INavigationService navigationService;

		private readonly IDependencyService dependencyService;

		private string title;

		private string subTitle;

		private string suggestion;

		private List<string> reasons = new List<string>();

		private bool showTryAgainButton = true;

		public string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
				RaisePropertyChanged(() => Title);
			}
		}

		public string SubTitle
		{
			get
			{
				return subTitle;
			}
			set
			{
				subTitle = value;
				RaisePropertyChanged(() => SubTitle);
			}
		}

		public List<string> Reasons
		{
			get
			{
				return reasons;
			}
			set
			{
				reasons = value;
				RaisePropertyChanged(() => Reasons);
			}
		}

		public string Suggestion
		{
			get
			{
				return suggestion;
			}
			set
			{
				suggestion = value;
				RaisePropertyChanged(() => Suggestion);
			}
		}

		public bool ShowTryAgainButton
		{
			get
			{
				return showTryAgainButton;
			}
			set
			{
				showTryAgainButton = value;
				RaisePropertyChanged(() => ShowTryAgainButton);
			}
		}

		public IAsyncCommand PerformWorkCommand { get; set; }

		public IAsyncCommand TryAgainCommand => new AsyncCommand(async delegate
		{
			dependencyService.Get<IFeedbackService>().Click();
			await navigationService.PopModalAsync();
			if (PerformWorkCommand != null)
			{
				await PerformWorkCommand.ExecuteAsync();
			}
		});

		public IAsyncCommand CallHelpCommand => new AsyncCommand(async delegate
		{
			await CallHelp();
		});

		public ErrorViewModel(IOpenUrlService openUrlService, INavigationService navigationService, IDependencyService dependencyService)
		{
			this.openUrlService = openUrlService ?? throw new ArgumentNullException("openUrlService");
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.dependencyService = dependencyService ?? throw new ArgumentNullException("dependencyService");
		}

		private async Task CallHelp()
		{
			await openUrlService.CallTel(Resources.Errorhandling_ContactNumber?.Replace(" ", string.Empty));
		}
	}
}
