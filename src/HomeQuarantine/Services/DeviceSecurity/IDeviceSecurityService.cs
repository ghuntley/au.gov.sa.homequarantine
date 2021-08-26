using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeQuarantine.Services.DeviceSecurity
{
	public interface IDeviceSecurityService
	{
		bool IsBreached(out Dictionary<string, string> reasons);

		Task<bool> GetAppIsExpired();
	}
}
