using System;
using HomeQuarantine.Data.Models;

namespace HomeQuarantine.Services.SystemStateService
{
	public class EventService : IEventService
	{
		private AppVersion appVersion;

		private bool shouldRegisterDevice;

		public AppVersion AppVersion
		{
			get
			{
				return appVersion;
			}
			set
			{
				if (appVersion != value)
				{
					appVersion = value;
					if (this.AppVersionUpdated != null)
					{
						this.AppVersionUpdated(value);
					}
				}
			}
		}

		public bool ShouldRegisterDevice
		{
			get
			{
				return shouldRegisterDevice;
			}
			set
			{
				shouldRegisterDevice = value;
				if (this.ShouldRegisterDeviceUpdated != null)
				{
					this.ShouldRegisterDeviceUpdated(value);
				}
			}
		}

		public event Action<AppVersion> AppVersionUpdated;

		public event Action<bool> ShouldRegisterDeviceUpdated;
	}
}
