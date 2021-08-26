using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.ViewModels;
using Microsoft.AppCenter.Crashes;
using Plugin.BreachDetector;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Services.DeviceSecurity
{
	public class DeviceSecurityService : IDeviceSecurityService
	{
		private const string unsupportedReason = "SecurityCheckUnsupported";

		private const string jailbrokenReason = "RootedOrJailbroken";

		private const string fromStoreAndVirtualReason = "FromStoreAndRunOnVirtualDevice";

		private const string fromStoreAndInDebugReason = "FromStoreAndInDebug";

		private readonly IDependencyService dependencyService;

		private readonly IEventService eventService;

		private readonly IExperienceApiService experienceApiService;

		private readonly INavigationService navigationService;

		private readonly ISettingsService settingsService;

		public DeviceSecurityService(IDependencyService dependencyService, IEventService eventService, IExperienceApiService experienceApiService, INavigationService navigationService, ISettingsService settingsService)
		{
			this.dependencyService = dependencyService;
			this.eventService = eventService;
			this.experienceApiService = experienceApiService;
			this.navigationService = navigationService;
			this.settingsService = settingsService;
		}

		public bool IsBreached(out Dictionary<string, string> reasons)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Invalid comparison between Unknown and I4
			reasons = new Dictionary<string, string>();
			try
			{
				bool isSupported = CrossBreachDetector.get_IsSupported();
				bool valueOrDefault = CrossBreachDetector.get_Current().IsRooted().GetValueOrDefault();
				bool flag = (int)DeviceInfo.get_DeviceType() == 2;
				bool valueOrDefault2 = CrossBreachDetector.get_Current().InDebugMode().GetValueOrDefault();
				bool valueOrDefault3 = CrossBreachDetector.get_Current().InstalledFromStore().GetValueOrDefault();
				if (!isSupported)
				{
					reasons.Add("reason", "SecurityCheckUnsupported");
				}
				if (valueOrDefault)
				{
					reasons.Add("reason", "RootedOrJailbroken");
				}
				if (valueOrDefault3 && flag)
				{
					reasons.Add("reason", "FromStoreAndRunOnVirtualDevice");
				}
				if (valueOrDefault3 && valueOrDefault2)
				{
					reasons.Add("reason", "FromStoreAndInDebug");
				}
				return reasons.Any();
			}
			catch (Exception ex)
			{
				Crashes.TrackError(ex, (IDictionary<string, string>)null, Array.Empty<ErrorAttachmentLog>());
				return true;
			}
		}

		public async Task<bool> GetAppIsExpired()
		{
			string versionString = dependencyService.Get<IEnvironmentService>().GetVersionString();
			AppVersion appVersion = await experienceApiService.VerifyAppVersion(versionString);
			if (appVersion != null)
			{
				eventService.AppVersion = appVersion;
				INavigation navigation = ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation();
				object obj;
				if (navigation == null)
				{
					obj = null;
				}
				else
				{
					Page obj2 = navigation.get_ModalStack().LastOrDefault();
					obj = ((obj2 == null) ? null : ((NavigableElement)obj2).get_Navigation().get_NavigationStack()?.LastOrDefault());
				}
				Page val = (Page)obj;
				INavigation navigation2 = ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation();
				if (navigation2 == null || !(navigation2.get_ModalStack()?.Count > 0) || !(((val != null) ? ((BindableObject)val).get_BindingContext() : null) is OnboardingHelpViewModel))
				{
					if (appVersion.Expired)
					{
						await navigationService.PushModalAsync(null, App.Constants.AppVersionExpiredViewModel);
						return true;
					}
					if (!appVersion.LatestVersion && !settingsService.HasShownAppVersionOutdatedPage)
					{
						await navigationService.PushModalAsync(null, App.Constants.AppVersionOutdatedViewModel);
						settingsService.HasShownAppVersionOutdatedPage = true;
						return true;
					}
				}
			}
			return false;
		}
	}
}
