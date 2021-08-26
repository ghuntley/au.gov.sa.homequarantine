using System;

namespace HomeQuarantine.Services.RequestProvider
{
	public class HttpUnAuthorizedException : Exception
	{
		public HttpUnAuthorizedException(string message)
			: base(message)
		{
		}
	}
}
