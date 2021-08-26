using System.Threading.Tasks;
using HomeQuarantine.Services.Language;
using Xamarin.Forms;

namespace HomeQuarantine.Services.Error
{
	public class ErrorService : IErrorService
	{
		private readonly ILanguageService languageService;

		public ErrorService(ILanguageService languageService)
		{
			this.languageService = languageService;
		}

		public async Task ReportSymptomCheckFailed()
		{
			await Application.get_Current().get_MainPage().DisplayAlert(languageService.SymptomErrorServiceDialogTitle, languageService.SymptomErrorServiceDialogText, languageService.SymptomErrorServiceDialogOkBtn);
		}

		public async Task HealthReferenceIDValidationFailed()
		{
			await Application.get_Current().get_MainPage().DisplayAlert(languageService.HeathReferenceIDErrorServiceDialogTitle, languageService.HeathReferenceIDErrorServiceDialogText, languageService.HeathReferenceIDErrorServiceDialogOkBtn);
		}
	}
}
