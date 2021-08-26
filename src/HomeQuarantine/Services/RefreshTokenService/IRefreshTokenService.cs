using System;
using System.Threading.Tasks;

namespace HomeQuarantine.Services.RefreshTokenService
{
	public interface IRefreshTokenService
	{
		bool IsRunning { get; }

		void StartTimer(Func<Task> callback, int period);

		void ResetTimer(int period);

		void StopTimer();
	}
}
