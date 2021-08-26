using HomeQuarantine.Behaviours.Base;
using Xamarin.Forms;

namespace HomeQuarantine.Behaviours
{
	public class EntryLineValidationBehaviour : BindableBehavior<Entry>
	{
		public static readonly BindableProperty IsValidProperty = BindableProperty.Create("IsValid", typeof(bool), typeof(EntryLineValidationBehaviour), (object)true, (BindingMode)0, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			OnIsValidChanged(bindable, newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public bool IsValid
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsValidProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsValidProperty, (object)value);
			}
		}

		private static void OnIsValidChanged(BindableObject bindable, object newValue)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			EntryLineValidationBehaviour entryLineValidationBehaviour = bindable as EntryLineValidationBehaviour;
			if (entryLineValidationBehaviour != null && newValue is bool)
			{
				bool flag = (bool)newValue;
				((InputView)entryLineValidationBehaviour.AssociatedObject).set_PlaceholderColor(flag ? Color.get_Default() : Color.Red);
			}
		}
	}
}
