using System;

namespace HomeQuarantine.Interfaces
{
	public class NotificationEventArgs : EventArgs
	{
		public string Title { get; set; }

		public string Message { get; set; }

		public string DeepLink { get; set; }
	}
}
