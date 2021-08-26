using System;
using Android.App;
using Android.Runtime;
using AndroidX.Core.Content;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Interfaces;
using iProov.Android;
using Java.Interop;
using Java.Lang;

namespace HomeQuarantine.Droid.Services
{
	public class LivenessCheckService : Object, ILivenessCheckService, IListener, IJavaObject, IDisposable, IJavaPeerable
	{
		private ILivenessCheckCallback callback;

		public LivenessCheckService()
			: this()
		{
			IProov.RegisterListener((IListener)(object)this);
		}

		public void Launch(string token, ILivenessCheckCallback callback)
		{
			this.callback = callback;
			IProov.Launch(Application.get_Context(), "https://au.rp.secure.iproov.me/", token, SetUpOptions());
		}

		public void OnConnected()
		{
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Connected();
			}
		}

		public void OnConnecting()
		{
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Connecting();
			}
		}

		public void OnCancelled()
		{
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Cancelled();
			}
		}

		public void OnError(IProovException error)
		{
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Error();
			}
		}

		public void OnFailure(FailureResult result)
		{
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Failure(result.get_FeedbackCode());
			}
		}

		public void OnProcessing(double progress, string message)
		{
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Processing(progress);
			}
		}

		public void OnSuccess(SuccessResult result)
		{
			result.get_Token();
			ILivenessCheckCallback obj = callback;
			if (obj != null)
			{
				obj.Success();
			}
		}

		private Options SetUpOptions()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			Options val = new Options();
			val.get_Ui().set_HeaderBackgroundColor(ContextCompat.GetColor(Application.get_Context(), 2131099773));
			val.get_Ui().set_HeaderTextColor(ContextCompat.GetColor(Application.get_Context(), 2131099761));
			val.get_Ui().set_FooterBackgroundColor(ContextCompat.GetColor(Application.get_Context(), 2131099773));
			val.get_Ui().set_FooterTextColor(ContextCompat.GetColor(Application.get_Context(), 2131099761));
			val.get_Ui().set_ProgressBarColor(ContextCompat.GetColor(Application.get_Context(), 2131099766));
			val.get_Ui().set_Title(Resources.get_LivenessCheckView_LiveFaceCheck());
			return val;
		}
	}
}
