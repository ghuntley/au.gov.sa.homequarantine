using System;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class SubmitSymptomCheckApiAction : IApiAction<bool>
	{
		private readonly SymptomCheck symptomCheck;

		public SubmitSymptomCheckApiAction(SymptomCheck symptomCheck)
		{
			this.symptomCheck = symptomCheck;
		}

		public async Task<bool> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			if (symptomCheck == null)
			{
				throw new ArgumentNullException("symptomCheck");
			}
			await requestProvider.PutAsync("https://public.api.sa.gov.au/home-quarantine/symptom-check/v1", symptomCheck, default(CancellationToken), accessToken);
			return true;
		}
	}
}
