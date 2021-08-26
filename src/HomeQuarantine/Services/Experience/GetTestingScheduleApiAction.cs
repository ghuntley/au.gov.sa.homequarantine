using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class GetTestingScheduleApiAction : IApiAction<QuarantineScheduleResponse>
	{
		public async Task<QuarantineScheduleResponse> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			return await requestProvider.GetAsync<QuarantineScheduleResponse>("https://public.api.sa.gov.au/home-quarantine/schedule/v1", default(CancellationToken), accessToken);
		}
	}
}
