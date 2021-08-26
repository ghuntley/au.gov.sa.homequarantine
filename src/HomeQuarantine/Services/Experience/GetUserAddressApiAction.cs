using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class GetUserAddressApiAction : IApiAction<AddressResponse>
	{
		public async Task<AddressResponse> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			return await requestProvider.GetAsync<AddressResponse>("https://public.api.sa.gov.au/home-quarantine/address/v1", default(CancellationToken), accessToken);
		}
	}
}
