using System.Threading.Tasks;

namespace HomeQuarantine.Services.Network
{
	public interface INetworkService
	{
		bool IsConnectedToInternet { get; }

		Task LaunchNotConnectedAlert();
	}
}
