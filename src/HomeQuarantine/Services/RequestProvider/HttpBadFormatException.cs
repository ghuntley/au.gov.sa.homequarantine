using System;

namespace HomeQuarantine.Services.RequestProvider
{
	public class HttpBadFormatException : Exception
	{
		public HttpBadFormatException(string message)
			: base(message)
		{
		}
	}
}
