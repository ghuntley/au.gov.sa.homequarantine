using System.Threading.Tasks;
using HomeQuarantine.Helpers;

namespace HomeQuarantine.Services.Network
{
	public interface INetworkService
	{
		bool IsConnectedToInternet { get; }

		Task LaunchNotConnectedAlert(IAsyncCommand retryCommand = null);
	}
}
