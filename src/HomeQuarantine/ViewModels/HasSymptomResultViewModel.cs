using System;
using System.Linq;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Extensions;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class HasSymptomResultViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private SymptomCheck symptomCheck;

		public IAsyncCommand PopAllPreviousPagesCommand => new AsyncCommand(() => navigationService.PopAllPreviousAsync());

		public IAsyncCommand CloseCommand => new AsyncCommand(() => navigationService.PopModalAsync());

		public string TestingLocationsUrl => "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/testing+and+tracing/covid-19+clinics+and+testing+centres/covid-19+clinics+and+testing+centres";

		public string PossibleSymptomsTitle
		{
			get
			{
				if (symptomCheck == null)
				{
					return string.Empty;
				}
				return string.Join(", ", symptomCheck?.Symptoms?.Select((Symptom s) => s.SymptomName.GetDescription()));
			}
		}

		public string SymptomsChosenSubtitle
		{
			get
			{
				if (symptomCheck == null)
				{
					return string.Empty;
				}
				return Resources.HasSymptomView_YouHaveChosen + " " + string.Join(", ", symptomCheck?.Symptoms?.Select((Symptom s) => s.SymptomName.GetDescription())).ToLower() + " " + Resources.HasSymptomView_AndOtherSymptoms;
			}
		}

		public HasSymptomResultViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
		}

		public override Task InitializeAsync(object navigationData)
		{
			symptomCheck = navigationData as SymptomCheck;
			if (symptomCheck == null)
			{
				throw new InvalidOperationException("Object passed must be of type SymptomCheck!");
			}
			RaisePropertyChanged(() => PossibleSymptomsTitle);
			RaisePropertyChanged(() => SymptomsChosenSubtitle);
			return Task.CompletedTask;
		}
	}
}
