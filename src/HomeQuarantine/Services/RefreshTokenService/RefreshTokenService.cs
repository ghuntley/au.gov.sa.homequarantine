using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeQuarantine.Services.RefreshTokenService
{
	public class RefreshTokenService : IRefreshTokenService
	{
		private Timer timer;

		private Func<Task> callback;

		private bool isRunning;

		public bool IsRunning => isRunning;

		public void StartTimer(Func<Task> callback, int period)
		{
			int num = SetUpPeriod(period);
			this.callback = callback;
			timer = new Timer(new TimerCallback(RunTimerFunc), null, num, num);
			isRunning = true;
		}

		public void ResetTimer(int period)
		{
			int num = SetUpPeriod(period);
			timer?.Change(num, num);
		}

		public void StopTimer()
		{
			timer?.Change(-1, 0);
			isRunning = false;
		}

		private void RunTimerFunc(object state)
		{
			callback();
		}

		private int SetUpPeriod(int period)
		{
			return (period - 60) * 1000;
		}
	}
}
