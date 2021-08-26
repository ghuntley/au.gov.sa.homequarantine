using System;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.Experience
{
	public class SetNotificationReadActionApi : IApiAction<bool>
	{
		private readonly Guid notificationId;

		public SetNotificationReadActionApi(Guid notificationId)
		{
			this.notificationId = notificationId;
		}

		public async Task<bool> DoApiAction(IRequestProvider requestProvider, string accessToken)
		{
			if (notificationId == Guid.Empty)
			{
				throw new ArgumentNullException("notificationId");
			}
			await requestProvider.PatchAsync(string.Format("{0}/v1?notificationId={1}", "https://public.api.sa.gov.au/home-quarantine/notifications", notificationId), default(CancellationToken), accessToken);
			return true;
		}
	}
}
