using System.Threading.Tasks;
using HomeQuarantine.Services.RequestProvider;

namespace HomeQuarantine.Services.ApiService
{
	public interface IApiAction<T>
	{
		Task<T> DoApiAction(IRequestProvider requestProvider, string accessToken);
	}
}
