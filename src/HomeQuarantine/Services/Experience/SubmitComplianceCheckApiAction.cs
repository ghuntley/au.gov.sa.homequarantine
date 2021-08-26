using System;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class SubmitComplianceCheckApiAction : IApiAction<bool>
	{
		private readonly HomeQuarantine.Data.Models.ComplianceCheck complianceCheck;

		public SubmitComplianceCheckApiAction(HomeQuarantine.Data.Models.ComplianceCheck complianceCheck)
		{
			this.complianceCheck = complianceCheck;
		}

		public async Task<bool> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			if (complianceCheck == null)
			{
				throw new ArgumentNullException("complianceCheck");
			}
			await requestProvider.PutAsync("https://public.api.sa.gov.au/home-quarantine/compliance/v1", complianceCheck, default(CancellationToken), accessToken);
			return true;
		}
	}
}
