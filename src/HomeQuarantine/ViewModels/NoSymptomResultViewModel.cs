using System;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class NoSymptomResultViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		public IAsyncCommand PopAllPreviousPagesCommand => new AsyncCommand(() => navigationService.PopAllPreviousAsync());

		public IAsyncCommand CloseCommand => new AsyncCommand(() => navigationService.PopModalAsync());

		public string MentalHealthSupportUrl => "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29#scrollTo-Mentalhealthsupport4";

		public string UsingTechnologyToStayConnectedUrl => "https://openyourworld.sa.gov.au/connect-with-others/using-technology-to-stay-connected";

		public string StayingActiveAndHealthyUrl => "https://openyourworld.sa.gov.au/stay-active-and-healthy/staying-active";

		public string MindfulnessUrl => "https://openyourworld.sa.gov.au/looking-after-you-your-family/mindfulness";

		public string ServicesAndSupportUrl => "https://openyourworld.sa.gov.au/looking-after-you-your-family/services-and-support";

		public NoSymptomResultViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
		}
	}
}
