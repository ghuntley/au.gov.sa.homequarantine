using System.Threading.Tasks;
using HomeQuarantine.Data.Resources.Languages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Services.Network
{
	public class NetworkService : INetworkService
	{
		public bool IsConnectedToInternet => (int)Connectivity.get_NetworkAccess() == 4;

		public async Task LaunchNotConnectedAlert()
		{
			if (!IsConnectedToInternet)
			{
				await Application.get_Current().get_MainPage().DisplayAlert(Resources.NoConnection_Prompt_Title, Resources.NoConnection_Prompt_Body, Resources.NoConnection_Prompt_Button);
			}
		}
	}
}
