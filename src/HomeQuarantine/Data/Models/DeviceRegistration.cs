using Newtonsoft.Json;

namespace HomeQuarantine.Data.Models
{
	public class DeviceRegistration
	{
		[JsonProperty("deviceId")]
		public string DeviceId { get; set; }

		[JsonProperty("platform")]
		public string Platform { get; set; }

		[JsonProperty("deviceToken")]
		public string DeviceToken { get; set; }
	}
}
