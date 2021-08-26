using System;
using System.Collections.Generic;

namespace HomeQuarantine.Services.RequestProvider
{
	public class ApiException : Exception
	{
		public int StatusCode { get; private set; }

		public string Response { get; private set; }

		public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

		public ApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception innerException = null)
			: base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, (response.Length >= 512) ? 512 : response.Length)), innerException)
		{
			StatusCode = statusCode;
			Response = response;
			Headers = headers;
		}

		public override string ToString()
		{
			return $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
		}
	}
}
