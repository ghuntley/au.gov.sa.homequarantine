using Android.App;
using Xamarin.Essentials;

namespace HomeQuarantine.Droid
{
	[Activity(/*Could not decode attribute arguments.*/)]
	[IntentFilter(new string[] { "android.intent.action.VIEW" }, Categories = new string[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" }, DataScheme = "homequarantine", DataHost = "authorize")]
	public class WebAuthenticationCallbackActivity : WebAuthenticatorCallbackActivity
	{
		protected override void OnResume()
		{
			((Activity)this).OnResume();
			Platform.OnResume((Activity)(object)this);
		}

		public WebAuthenticationCallbackActivity()
			: this()
		{
		}
	}
}
