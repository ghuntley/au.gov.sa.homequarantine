namespace HomeQuarantine.Services.Language
{
	public interface ILanguageService
	{
		string MainViewTitle { get; }

		string ReferenceIDViewTitle { get; }

		string SymptomErrorServiceDialogTitle { get; set; }

		string SymptomErrorServiceDialogText { get; set; }

		string SymptomErrorServiceDialogOkBtn { get; set; }

		string HeathReferenceIDErrorServiceDialogTitle { get; set; }

		string HeathReferenceIDErrorServiceDialogText { get; set; }

		string IncorrectreferenceNumber { get; set; }

		string HeathReferenceIDErrorServiceDialogOkBtn { get; set; }

		string ContactMessage { get; set; }

		string OnboardingPermissionEnabled { get; }

		string NoInternetDialogTitle { get; }

		string NoInternetDialogText { get; }

		string NoInternetDialogOkBtn { get; }
	}
}
