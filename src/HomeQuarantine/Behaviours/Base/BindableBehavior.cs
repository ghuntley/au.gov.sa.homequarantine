using System;
using Xamarin.Forms;

namespace HomeQuarantine.Behaviours.Base
{
	public class BindableBehavior<T> : Behavior<T> where T : BindableObject
	{
		public T AssociatedObject { get; private set; }

		protected override void OnAttachedTo(T visualElement)
		{
			base.OnAttachedTo(visualElement);
			AssociatedObject = visualElement;
			if (((BindableObject)visualElement).get_BindingContext() != null)
			{
				((BindableObject)this).set_BindingContext(((BindableObject)visualElement).get_BindingContext());
			}
			((BindableObject)visualElement).add_BindingContextChanged((EventHandler)OnBindingContextChanged);
		}

		private void OnBindingContextChanged(object sender, EventArgs e)
		{
			((BindableObject)this).OnBindingContextChanged();
		}

		protected override void OnDetachingFrom(T view)
		{
			((BindableObject)view).remove_BindingContextChanged((EventHandler)OnBindingContextChanged);
		}

		protected override void OnBindingContextChanged()
		{
			((BindableObject)this).OnBindingContextChanged();
			((BindableObject)this).set_BindingContext(((BindableObject)AssociatedObject).get_BindingContext());
		}
	}
}
