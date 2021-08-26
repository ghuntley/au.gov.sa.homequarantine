using System;
using System.Globalization;
using System.Reflection;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.ComplianceCheck;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.DeviceSecurity;
using HomeQuarantine.Services.Dialog;
using HomeQuarantine.Services.Error;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Identity;
using HomeQuarantine.Services.Language;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.Network;
using HomeQuarantine.Services.NotificationActions;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Permissions;
using HomeQuarantine.Services.RefreshTokenService;
using HomeQuarantine.Services.RequestProvider;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.Services.SystemStateService;
using HomeQuarantine.Services.ThreadService;
using TinyIoC;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels.Base
{
	public class ViewModelLocator
	{
		private static TinyIoCContainer _container;

		public static readonly BindableProperty AutoWireViewModelProperty;

		public static bool UseMockService { get; set; }

		public static bool GetAutoWireViewModel(BindableObject bindable)
		{
			return (bool)bindable.GetValue(AutoWireViewModelProperty);
		}

		public static void SetAutoWireViewModel(BindableObject bindable, bool value)
		{
			bindable.SetValue(AutoWireViewModelProperty, (object)value);
		}

		static ViewModelLocator()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			AutoWireViewModelProperty = BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocator), (object)false, (BindingMode)2, (ValidateValueDelegate)null, new BindingPropertyChangedDelegate(OnAutoWireViewModelChanged), (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);
			_container = new TinyIoCContainer();
			_container.Register<LoginViewModel>();
			_container.Register<MainViewModel>();
			_container.Register<OnboardingViewModel>();
			_container.Register<SymptomCheckViewModel>();
			_container.Register<NoSymptomResultViewModel>();
			_container.Register<HasSymptomResultViewModel>();
			_container.Register<OtherSymptomViewModel>();
			_container.Register<OnboardingHelpViewModel>();
			_container.Register<DesignSystemViewModel>();
			_container.Register<OnboardingReferenceIDViewModel>();
			_container.Register<ViewAllNotificationViewModel>();
			_container.Register<NotificationDetailsViewModel>();
			_container.Register<ComplianceCheckViewModel>();
			_container.Register<ComplianceCheckSuccessfulViewModel>();
			_container.Register<ErrorViewModel>();
			_container.Register<InformationContentViewModel>();
			_container.Register<TestingScheduleViewModel>();
			_container.Register<TestingScheduleHelpViewModel>();
			_container.Register<ComplianceCheckDisabledViewModel>();
			_container.Register<IDependencyService, DependencyService>();
			_container.Register<INavigationService, NavigationService>();
			_container.Register<IOpenUrlService, OpenUrlService>();
			_container.Register<IRequestProvider, RequestProvider>();
			_container.Register<ISettingsService, SettingsService>();
			_container.Register<IEventService, EventService>();
			_container.Register<IErrorService, ErrorService>();
			_container.Register<IRefreshTokenService, RefreshTokenService>();
			_container.Register<IIdentityService, IdentityService>();
			_container.Register<IPermissionsService, PermissionsService>();
			_container.Register<INotificationActionsService, NotificationActionService>();
			_container.Register<IDialogService, DialogService>();
			_container.Register<IDeviceSecurityService, DeviceSecurityService>();
			_container.Register<INetworkService, NetworkService>();
			_container.Register<IThreadService, ThreadService>();
			_container.Register<IApiService, ApiService>();
			_container.Register<IExperienceApiService, ExperienceApiService>();
			_container.Register<IComplianceCheckService, ComplianceCheckService>();
			RegisterLanguageService();
		}

		public static void RegisterSingleton<TInterface, T>() where TInterface : class where T : class, TInterface
		{
			_container.Register<TInterface, T>().AsSingleton();
		}

		public static T Resolve<T>() where T : class
		{
			return _container.Resolve<T>();
		}

		private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
		{
			Element val = (Element)(object)((bindable is Element) ? bindable : null);
			if (val != null)
			{
				Type type = ((object)val).GetType();
				string arg = type.FullName!.Replace(".Views.", ".ViewModels.");
				string fullName = type.GetTypeInfo().Assembly.FullName;
				Type type2 = Type.GetType(string.Format(CultureInfo.InvariantCulture, "{0}Model, {1}", arg, fullName));
				if (!(type2 == null))
				{
					object bindingContext = _container.Resolve(type2);
					((BindableObject)val).set_BindingContext(bindingContext);
				}
			}
		}

		private static void RegisterLanguageService()
		{
			_ = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
			_container.Register<ILanguageService, LanguageEnAu>();
		}
	}
}
