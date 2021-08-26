using System;

namespace HomeQuarantine.Services.ThreadService
{
	public interface IThreadService
	{
		void BeginInvokeOnMainThread(Action action);
	}
}
