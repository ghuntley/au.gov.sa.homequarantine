using System;
using HomeQuarantine.Data.Models;

namespace HomeQuarantine.Services.SystemStateService
{
	public interface IEventService
	{
		AppVersion AppVersion { get; set; }

		bool ShouldRegisterDevice { get; set; }

		event Action<AppVersion> AppVersionUpdated;

		event Action<bool> ShouldRegisterDeviceUpdated;

		event Action GetLatestNotificationsEvent;

		void GetLatestNotifications();
	}
}
