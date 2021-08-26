namespace HomeQuarantine.Data.Models
{
	public class RegisterDeviceRequest
	{
		public string DeviceId { get; set; }

		public string Platform { get; set; }

		public string DeviceToken { get; set; }
	}
}
