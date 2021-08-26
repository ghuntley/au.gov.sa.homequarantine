using System;
using Xamarin.Forms;

namespace HomeQuarantine.Services.ThreadService
{
	public class ThreadService : IThreadService
	{
		public void BeginInvokeOnMainThread(Action action)
		{
			Device.BeginInvokeOnMainThread(action);
		}
	}
}
