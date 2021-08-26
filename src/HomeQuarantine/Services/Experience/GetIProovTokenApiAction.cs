using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class GetIProovTokenApiAction : IApiAction<IProovTokenResponse>
	{
		public async Task<IProovTokenResponse> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			return await requestProvider.GetAsync<IProovTokenResponse>("https://public.api.sa.gov.au/home-quarantine/compliance/v1", default(CancellationToken), accessToken);
		}
	}
}
