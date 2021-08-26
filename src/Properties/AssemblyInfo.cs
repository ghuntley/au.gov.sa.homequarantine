using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Android.App;
using Android.Runtime;
using HomeQuarantine.Android.Feedback;
using HomeQuarantine.Controls;
using HomeQuarantine.Droid.Renderers;
using HomeQuarantine.Droid.Services;
using Xamarin.Forms;

[assembly: ResourceDesigner("HomeQuarantine.Droid.Resource", IsApplication = true)]
[assembly: AssemblyTitle("HomeQuarantine.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("HomeQuarantines.Android")]
[assembly: AssemblyCopyright("Copyright ©  2021")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: AssemblyFileVersion("1.0.1.0")]
[assembly: UsesPermission("android.permission.INTERNET")]
[assembly: UsesPermission("android.permission.WRITE_EXTERNAL_STORAGE")]
[assembly: Application(UsesCleartextTraffic = true)]
[assembly: Dependency(typeof(LivenessCheckService))]
[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
[assembly: Dependency(typeof(EnvironmentService))]
[assembly: Dependency(typeof(NotificationService))]
[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]
[assembly: Dependency(typeof(AppSettingsService))]
[assembly: Dependency(typeof(FeedbackService))]
[assembly: ExportRenderer(typeof(ScrollView), typeof(CustomScrollViewRenderer))]
[assembly: AssemblyVersion("1.0.1.0")]
