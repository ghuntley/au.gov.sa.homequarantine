using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HomeQuarantine.Data.Mocks.Interfaces;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.DeviceSecurity;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.Permissions;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine
{
	[XamlFilePath("App.xaml")]
	public class App : Application
	{
		public static Constants Constants;

		public static IMockUser MockUser;

		public static AppVersion CurrentVersionState;

		public App()
			: this()
		{
			InitializeComponent();
		}

		protected static void InitConstants()
		{
			Constants = new Constants();
		}

		protected override async void OnStart()
		{
			_003C_003En__0();
			AppCenterHelper.Init();
			ThemeHelper.SetTheme(AppInfo.get_RequestedTheme());
			InitConstants();
			await InitNavigation();
		}

		protected override void OnSleep()
		{
		}

		protected override async void OnResume()
		{
			_003C_003En__1();
			ThemeHelper.UpdateTheme(AppInfo.get_RequestedTheme());
			await PerformAppActions();
			await CheckAppPermissions();
			IDeviceSecurityService securityService = ViewModelLocator.Resolve<IDeviceSecurityService>();
			await Task.Run(async () => await securityService.GetAppIsExpired());
		}

		public void RequestCloseOnBackButton(Action<BackButtonAction> callback)
		{
			if (Device.get_RuntimePlatform() == "Android")
			{
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
				if (navigation2 != null && navigation2.get_ModalStack()?.Count > 0 && ((val != null) ? ((BindableObject)val).get_BindingContext() : null) is OnboardingHelpViewModel)
				{
					callback(BackButtonAction.DoNothing);
				}
				else
				{
					callback(BackButtonAction.NavigateBack);
				}
			}
		}

		private async Task InitNavigation()
		{
			await ViewModelLocator.Resolve<INavigationService>().InitializeAsync();
		}

		private async Task CheckAppPermissions()
		{
			INavigation navigation = ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation();
			Page obj = ((navigation == null) ? null : navigation.get_ModalStack()?.LastOrDefault());
			NavigationPage val = (NavigationPage)(object)((obj is NavigationPage) ? obj : null);
			OnboardingHelpView onboardingHelpView = ((val != null) ? val.get_CurrentPage() : null) as OnboardingHelpView;
			if (onboardingHelpView != null)
			{
				await onboardingHelpView.OnResume();
				return;
			}
			ConnectionAlertView connectionAlertView = ((val != null) ? val.get_CurrentPage() : null) as ConnectionAlertView;
			if (connectionAlertView != null)
			{
				await connectionAlertView.OnResume();
			}
			else if (!(((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().get_NavigationStack().FirstOrDefault() is OnboardingView))
			{
				await ViewModelLocator.Resolve<IPermissionsService>().LaunchPermissionAlertsIfDisabled();
			}
		}

		private async Task PerformAppActions()
		{
			MainView mainView = ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().get_NavigationStack()?.FirstOrDefault() as MainView;
			if (mainView != null)
			{
				await (((BindableObject)mainView).get_BindingContext() as MainViewModel).PerformActionCommand.ExecuteAsync();
			}
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(App).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("App.xaml");
				val.set_Instance((object)this);
				if (ResourceLoader.CanProvideContentFor(val))
				{
					__InitComponentRuntime();
					return;
				}
			}
			if (XamlLoader.get_XamlFileProvider() != null && XamlLoader.get_XamlFileProvider()(((object)this).GetType()) != null)
			{
				__InitComponentRuntime();
				return;
			}
			ResourceDictionary resources = new ResourceDictionary();
			App app;
			NameScope val2 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(app = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)app, (INameScope)(object)val2);
			((Application)app).set_Resources(resources);
			((Application)app).set_Resources(resources);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<App>(this, typeof(App));
		}
	}
}
