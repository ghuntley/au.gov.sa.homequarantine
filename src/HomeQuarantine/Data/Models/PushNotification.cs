namespace HomeQuarantine.Data.Models
{
	public class PushNotification
	{
		public string Title { get; set; }

		public string Message { get; set; }

		public string Action { get; set; }

		public bool ReceivedInBackground { get; set; }
	}
}
