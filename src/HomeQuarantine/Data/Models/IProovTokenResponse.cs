using Newtonsoft.Json;

namespace HomeQuarantine.Data.Models
{
	public class IProovTokenResponse
	{
		[JsonProperty("token")]
		public string Token { get; set; }
	}
}
