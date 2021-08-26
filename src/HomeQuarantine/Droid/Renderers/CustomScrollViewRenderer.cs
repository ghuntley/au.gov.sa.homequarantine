using System;
using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace HomeQuarantine.Droid.Renderers
{
	public class CustomScrollViewRenderer : ScrollViewRenderer
	{
		private float StartX;

		private float StartY;

		private int IsHorizontal = -1;

		public CustomScrollViewRenderer(Context context)
			: this(context)
		{
		}

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Invalid comparison between Unknown and I4
			((ScrollViewRenderer)this).OnElementChanged(e);
			ScrollView val = (ScrollView)((ElementChangedEventArgs<VisualElement>)(object)e).get_NewElement();
			if ((int)val != 0 && (int)val.get_Orientation() == 1)
			{
				IsHorizontal = 1;
			}
		}

		public override bool OnInterceptTouchEvent(MotionEvent ev)
		{
			bool num = ((ScrollViewRenderer)this).OnInterceptTouchEvent(ev);
			if (!num)
			{
				((View)this).OnTouchEvent(ev);
			}
			return num;
		}

		public override bool DispatchTouchEvent(MotionEvent e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I4, but got Unknown
			MotionEventActions action = e.get_Action();
			switch ((int)action)
			{
			case 0:
				StartX = e.get_RawX();
				StartY = e.get_RawY();
				((View)this).get_Parent().RequestDisallowInterceptTouchEvent(true);
				break;
			case 2:
				if ((float)IsHorizontal * Math.Abs(StartX - e.get_RawX()) < (float)IsHorizontal * Math.Abs(StartY - e.get_RawY()))
				{
					((View)this).get_Parent().RequestDisallowInterceptTouchEvent(false);
				}
				break;
			case 1:
				((View)this).get_Parent().RequestDisallowInterceptTouchEvent(false);
				break;
			}
			return ((View)this).DispatchTouchEvent(e);
		}
	}
}
