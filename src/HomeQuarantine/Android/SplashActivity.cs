using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;
using HomeQuarantine.Droid;

namespace HomeQuarantine.Android
{
	[Activity(/*Could not decode attribute arguments.*/)]
	public class SplashActivity : AppCompatActivity
	{
		public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
		{
			((Activity)this).OnCreate(savedInstanceState, persistentState);
		}

		protected override void OnResume()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			((Activity)this).OnResume();
			((Context)this).StartActivity(new Intent(Application.get_Context(), typeof(MainActivity)));
		}

		public SplashActivity()
			: this()
		{
		}
	}
}
