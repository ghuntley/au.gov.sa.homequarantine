using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class GetComplianceCheckWindowApiAction : IApiAction<bool>
	{
		public async Task<bool> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			return (await requestProvider.GetAsync<IEnumerable<NotificationResponse>>("https://public.api.sa.gov.au/home-quarantine/notifications/v1", default(CancellationToken), accessToken)).Any((NotificationResponse n) => n.NotificationType == NotificationType.ComplianceCheck);
		}
	}
}
