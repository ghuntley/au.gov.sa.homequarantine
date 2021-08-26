using System.Threading.Tasks;

namespace HomeQuarantine.Services.Identity
{
	public interface IIdentityService
	{
		Task<bool> Authenticate();

		Task Logout();

		Task<bool> CheckAndRefreshToken();

		Task ExplicitlyRefreshToken();
	}
}
