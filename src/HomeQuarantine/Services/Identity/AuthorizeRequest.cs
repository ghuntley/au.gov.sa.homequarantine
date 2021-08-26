using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace HomeQuarantine.Services.Identity
{
	public class AuthorizeRequest
	{
		private readonly Uri authorizeEndpoint;

		public AuthorizeRequest(string authorizeEndpoint)
		{
			this.authorizeEndpoint = new Uri(authorizeEndpoint);
		}

		public string Create(IDictionary<string, string> values)
		{
			string arg = string.Join("&", values.Select((KeyValuePair<string, string> kvp) => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}").ToArray());
			return $"{authorizeEndpoint.AbsoluteUri}?{arg}";
		}
	}
}
