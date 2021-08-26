using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;

namespace HomeQuarantine.Services.Experience
{
	public class ExperienceApiMockService : IExperienceApiService
	{
		public async Task<AppVersion> GetAppVersionDetails(string version)
		{
			return await Task.FromResult(new AppVersion
			{
				Expired = false,
				Version = version,
				LatestVersion = true,
				ExpiryDate = null
			});
		}

		public async Task SubmitSymptomsCheck(SymptomCheck symptomCheck)
		{
			await Task.CompletedTask;
			throw new NotImplementedException();
		}

		public async Task ValidateHealthReferenceID(string healthReferenceID)
		{
			if (!App.MockUser.ValidateHealthIDWasSuccessful)
			{
				throw new Exception("Invalid Health ID");
			}
			await Task.CompletedTask;
		}

		public async Task<AddressResponse> GetUserAddress(string healthReferenceID)
		{
			return await Task.FromResult(App.MockUser.Address);
		}

		public async Task<QuarantineStatusType> GetOnboardingStatus()
		{
			return await Task.FromResult(App.MockUser.QuarantineStatus);
		}

		public async Task<(IEnumerable<NotificationResponse>, bool)> GetUnreadNotifications()
		{
			await Task.CompletedTask;
			throw new NotImplementedException();
		}

		public async Task SetNotificationRead(Guid notificationId)
		{
			if (notificationId == Guid.Empty)
			{
				throw new ArgumentNullException("notificationId");
			}
			await Task.CompletedTask;
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<NotificationResponse>> GetAllNotifications()
		{
			await Task.CompletedTask;
			throw new NotImplementedException();
		}

		public Task CompleteOnboarding()
		{
			throw new NotImplementedException();
		}

		public Task<QuarantineScheduleResponse> GetTestingScheduleData()
		{
			throw new NotImplementedException();
		}

		public Task RegisterDevice(DeviceRegistration deviceInfo)
		{
			throw new NotImplementedException();
		}

		public Task<AppVersion> VerifyAppVersion(string appVersion)
		{
			throw new NotImplementedException();
		}
	}
}
