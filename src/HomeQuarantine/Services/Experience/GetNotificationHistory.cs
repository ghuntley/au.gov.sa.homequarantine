using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class GetNotificationHistory : IApiAction<IEnumerable<NotificationResponse>>
	{
		public async Task<IEnumerable<NotificationResponse>> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			return from n in await requestProvider.GetAsync<IEnumerable<NotificationResponse>>("https://public.api.sa.gov.au/home-quarantine/notifications/v1", default(CancellationToken), accessToken)
				where n.AppearsInHistory && n.DateRead.HasValue
				orderby n.DateCreated descending
				select n;
		}
	}
}
