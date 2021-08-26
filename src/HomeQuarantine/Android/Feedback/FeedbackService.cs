using System;
using Android.App;
using Android.Views;
using HomeQuarantine.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Android.Feedback
{
	public class FeedbackService : IFeedbackService
	{
		public void Success()
		{
			TryPerformHapticFeedback((FeedbackConstants)16);
		}

		public void Fail()
		{
			TryPerformHapticFeedback((FeedbackConstants)17);
		}

		public void Click()
		{
			TryPerformHapticFeedback((FeedbackConstants)6);
		}

		private void TryPerformHapticFeedback(FeedbackConstants type)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Device.BeginInvokeOnMainThread((Action)delegate
				{
					//IL_001f: Unknown result type (might be due to invalid IL or missing references)
					Activity currentActivity = Platform.get_CurrentActivity();
					if (currentActivity != null)
					{
						Window window = currentActivity.get_Window();
						if (window != null)
						{
							View decorView = window.get_DecorView();
							if (decorView != null)
							{
								decorView.PerformHapticFeedback(type);
							}
						}
					}
				});
			}
			catch (Exception)
			{
			}
		}
	}
}
