using System;

namespace HomeQuarantine.Helpers
{
	public interface IErrorHandler
	{
		void HandleError(Exception ex);
	}
}
