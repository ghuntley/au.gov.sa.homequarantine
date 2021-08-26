using System;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Error;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class OtherSymptomViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private readonly IApiService apiService;

		private readonly IErrorService errorService;

		private SymptomCheck symptomCheck;

		private bool showErrorMessage;

		public int MinCharacters => 3;

		public int MaxCharacters => 500;

		public string DescriptionText
		{
			get
			{
				return symptomCheck?.DescriptionOthers ?? string.Empty;
			}
			set
			{
				symptomCheck.DescriptionOthers = value;
				RaisePropertyChanged(() => DescriptionText);
			}
		}

		public IAsyncCommand SubmitCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await SubmitAsync();
			});
		});

		public bool ShowErrorMessage
		{
			get
			{
				return showErrorMessage;
			}
			set
			{
				showErrorMessage = value;
				RaisePropertyChanged(() => ShowErrorMessage);
			}
		}

		public string SymptomErrorMessage => string.Format(Resources.OtherSymptomView_SymptomsMustContainFormat, MinCharacters, MaxCharacters);

		public OtherSymptomViewModel(INavigationService navigationService, IApiService apiService, IErrorService errorService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.apiService = apiService ?? throw new ArgumentNullException("apiService");
			this.errorService = errorService ?? throw new ArgumentNullException("errorService");
		}

		public override Task InitializeAsync(object navigationData)
		{
			symptomCheck = navigationData as SymptomCheck;
			return Task.CompletedTask;
		}

		protected bool UserEnteredValidOtherSymptoms(string symptoms)
		{
			if (string.IsNullOrWhiteSpace(symptoms))
			{
				return false;
			}
			if (symptoms.Trim().Length < 3)
			{
				return false;
			}
			return true;
		}

		protected async Task SubmitAsync()
		{
			if (!UserEnteredValidOtherSymptoms(symptomCheck.DescriptionOthers))
			{
				ShowErrorMessage = true;
				return;
			}
			ShowErrorMessage = false;
			base.IsBusy = true;
			await apiService.CallApi(new SubmitSymptomCheckApiAction(symptomCheck), async delegate
			{
				base.IsBusy = false;
				await navigationService.NavigateToAsync<HasSymptomResultViewModel>(symptomCheck);
			}, async delegate
			{
				base.IsBusy = false;
				await apiService.ShowGeneralError(App.Constants.SymptomErrorHandlingPage, SubmitAsync);
			});
		}
	}
}
