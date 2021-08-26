using System.Threading.Tasks;
using HomeQuarantine.Data.Models;

namespace HomeQuarantine.Interfaces
{
	public interface INotificationService
	{
		bool NotificationsSupported { get; }

		Task<bool> RequestPermission();

		string GetNotificationPlatform();

		bool GetApplicationNotificationSettings();

		Task ReceiveNotification(PushNotification action);

		void RegisterForRemoteNotifications();

		void CompleteRegistration(string deviceToken);
	}
}
