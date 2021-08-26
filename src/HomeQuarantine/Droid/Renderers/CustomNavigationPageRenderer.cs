using System;
using Android.Content;
using Android.Views;
using AndroidX.AppCompat.Widget;
using HomeQuarantine.Services.Modals;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

namespace HomeQuarantine.Droid.Renderers
{
	public class CustomNavigationPageRenderer : NavigationPageRenderer
	{
		private Toolbar _modalToolbar;

		public CustomNavigationPageRenderer(Context context)
			: this(context)
		{
		}

		protected override void OnAttachedToWindow()
		{
			((NavigationPageRenderer)this).OnAttachedToWindow();
			Page currentPage = ((VisualElementRenderer<NavigationPage>)this).get_Element().get_CurrentPage();
			IModalPage val = (IModalPage)(object)((currentPage is IModalPage) ? currentPage : null);
			if (val != null && val.get_ShowDismiss())
			{
				Toolbar val2 = ((View)this).FindViewById<Toolbar>(2131296585);
				if (val2 != null)
				{
					_modalToolbar = val2;
					_modalToolbar.add_NavigationClick((EventHandler<NavigationClickEventArgs>)ModalToolbarOnNavigationClick);
				}
			}
		}

		protected override void OnDetachedFromWindow()
		{
			((NavigationPageRenderer)this).OnDetachedFromWindow();
			if (_modalToolbar != null)
			{
				_modalToolbar.remove_NavigationClick((EventHandler<NavigationClickEventArgs>)ModalToolbarOnNavigationClick);
			}
		}

		protected override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			((NavigationPageRenderer)this).OnLayout(changed, l, t, r, b);
			Page currentPage = ((VisualElementRenderer<NavigationPage>)this).get_Element().get_CurrentPage();
			IModalPage val = (IModalPage)(object)((currentPage is IModalPage) ? currentPage : null);
			if (val != null && val.get_ShowDismiss())
			{
				Toolbar modalToolbar = _modalToolbar;
				if (modalToolbar != null)
				{
					modalToolbar.SetNavigationIcon(2131230939);
				}
			}
		}

		protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
		{
			((View)this).OnSizeChanged(w, h, oldw, oldh);
			Page currentPage = ((VisualElementRenderer<NavigationPage>)this).get_Element().get_CurrentPage();
			IModalPage val = (IModalPage)(object)((currentPage is IModalPage) ? currentPage : null);
			if (val != null && val.get_ShowDismiss())
			{
				Toolbar modalToolbar = _modalToolbar;
				if (modalToolbar != null)
				{
					modalToolbar.SetNavigationIcon(2131230939);
				}
			}
		}

		private void ModalToolbarOnNavigationClick(object sender, NavigationClickEventArgs e)
		{
			Page currentPage = ((VisualElementRenderer<NavigationPage>)this).get_Element().get_CurrentPage();
			IModalPage val = (IModalPage)(object)((currentPage is IModalPage) ? currentPage : null);
			if (val != null && val.get_ShowDismiss())
			{
				val.Dismiss();
			}
			else
			{
				((Page)((VisualElementRenderer<NavigationPage>)this).get_Element()).SendBackButtonPressed();
			}
		}
	}
}
