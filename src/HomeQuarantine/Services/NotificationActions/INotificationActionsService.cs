using System.Threading.Tasks;
using HomeQuarantine.Data.Models;

namespace HomeQuarantine.Services.NotificationActions
{
	public interface INotificationActionsService
	{
		int GetQueueCount();

		Task TakeFromQueue();

		Task OpenOrAddToQueue(PushNotification notification);
	}
}
