using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;

namespace HomeQuarantine.Services.Experience
{
	public interface IExperienceApiService
	{
		Task<AppVersion> GetAppVersionDetails(string version);

		Task ValidateHealthReferenceID(string healthReferenceID);

		Task<QuarantineStatusType> GetOnboardingStatus();

		Task CompleteOnboarding();

		Task RegisterDevice(DeviceRegistration deviceInfo);

		Task<AppVersion> VerifyAppVersion(string appVersion);
	}
}
