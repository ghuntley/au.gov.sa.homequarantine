using System;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Services.RequestProvider;
using HomeQuarantine.Services.Settings;

namespace HomeQuarantine.Services.Experience
{
	public class ExperienceApiService : IExperienceApiService
	{
		private readonly IRequestProvider requestProvider;

		private readonly ISettingsService settingsService;

		public ExperienceApiService(IRequestProvider requestProvider, ISettingsService settingsService)
		{
			this.requestProvider = requestProvider;
			this.settingsService = settingsService;
		}

		public async Task<AppVersion> GetAppVersionDetails(string version)
		{
			if (string.IsNullOrWhiteSpace(version))
			{
				throw new ArgumentNullException("version");
			}
			return await requestProvider.GetAsync<AppVersion>("/v1/version/" + version, default(CancellationToken));
		}

		public async Task ValidateHealthReferenceID(string healthReferenceID)
		{
			if (healthReferenceID == null)
			{
				throw new ArgumentNullException("healthReferenceID");
			}
			await requestProvider.PutAsync<string>("https://public.api.sa.gov.au/home-quarantine/onboarding/v2?uic=" + healthReferenceID, null, default(CancellationToken), settingsService.AuthAccessToken);
		}

		public async Task<QuarantineStatusType> GetOnboardingStatus()
		{
			return (await requestProvider.GetAsync<QuarantineStatusResponse>("https://public.api.sa.gov.au/home-quarantine/quarantine-status/v1", default(CancellationToken), settingsService.AuthAccessToken)).QuarantineStatus;
		}

		public async Task CompleteOnboarding()
		{
			await requestProvider.PatchAsync("https://public.api.sa.gov.au/home-quarantine/onboarding/v1", default(CancellationToken), settingsService.AuthAccessToken);
		}

		public async Task RegisterDevice(DeviceRegistration deviceInfo)
		{
			if (deviceInfo == null)
			{
				throw new ArgumentNullException("deviceInfo");
			}
			await requestProvider.PutAsync("https://public.api.sa.gov.au/home-quarantine/device-id/v1", deviceInfo, default(CancellationToken), settingsService.AuthAccessToken);
		}

		public async Task<AppVersion> VerifyAppVersion(string appVersion)
		{
			return await requestProvider.GetAsync<AppVersion>("https://public.api.sa.gov.au/home-quarantine/version/v1?currentVersion=" + appVersion, default(CancellationToken));
		}
	}
}
