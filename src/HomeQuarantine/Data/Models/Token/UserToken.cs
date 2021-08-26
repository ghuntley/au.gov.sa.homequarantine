using System;
using Newtonsoft.Json;

namespace HomeQuarantine.Data.Models.Token
{
	public class UserToken
	{
		[JsonProperty("id_token")]
		public string IdToken { get; set; }

		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("expires_in")]
		public int ExpiresIn { get; set; }

		[JsonProperty("token_type")]
		public string TokenType { get; set; }

		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }

		[JsonProperty("refresh_expires_in")]
		public int RefreshExpiresIn { get; set; }

		public DateTime? Expiry { get; set; }

		public UserToken()
		{
			Expiry = DateTime.Now.AddSeconds(ExpiresIn);
		}
	}
}
