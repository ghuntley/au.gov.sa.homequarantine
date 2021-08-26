namespace HomeQuarantine.Services.Language
{
	public class LanguageEnAu : ILanguageService
	{
		public string MainViewTitle { get; } = "Home Quarantine";


		public string ReferenceIDViewTitle { get; } = "Getting Started";


		public string SymptomErrorServiceDialogTitle { get; set; } = "Service Error";


		public string SymptomErrorServiceDialogText { get; set; } = "Unable to send data. Please try again later";


		public string SymptomErrorServiceDialogOkBtn { get; set; } = "Try Again";


		public string HeathReferenceIDErrorServiceDialogTitle { get; set; } = "Service Error";


		public string HeathReferenceIDErrorServiceDialogText { get; set; } = "Unable to send data. Please try again later";


		public string IncorrectreferenceNumber { get; set; } = "Incorrect reference number.";


		public string HeathReferenceIDErrorServiceDialogOkBtn { get; set; } = "Try Again";


		public string ContactMessage { get; set; } = "Please try again or contact Covid-19 information Line on 1800 100 123 for assistance from 9.00 am to 5.00 pm every day";


		public string OnboardingPermissionEnabled => "You have enabled ";

		public string NoInternetDialogTitle { get; } = "";


		public string NoInternetDialogText { get; }

		public string NoInternetDialogOkBtn { get; }
	}
}
