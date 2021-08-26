using System;
using Xamarin.Forms;

namespace HomeQuarantine.Controls
{
	public class CustomDatePicker : DatePicker
	{
		public static readonly BindableProperty NullableDateProperty = BindableProperty.Create("NullableDate", typeof(DateTime?), typeof(CustomDatePicker), (object)null, (BindingMode)1, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty EmptyStateTextProperty = BindableProperty.Create("EmptyStateText", typeof(string), typeof(CustomDatePicker), (object)string.Empty, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		private static readonly DateTime DefaultDateTime = new DateTime(1970, 1, 1);

		public DateTime? NullableDate
		{
			get
			{
				return (DateTime?)((BindableObject)this).GetValue(NullableDateProperty);
			}
			set
			{
				if (value != NullableDate)
				{
					((BindableObject)this).SetValue(NullableDateProperty, (object)value);
				}
			}
		}

		public string EmptyStateText
		{
			get
			{
				return (string)((BindableObject)this).GetValue(EmptyStateTextProperty);
			}
			set
			{
				((BindableObject)this).SetValue(EmptyStateTextProperty, (object)value);
			}
		}

		protected override void OnBindingContextChanged()
		{
			((View)this).OnBindingContextChanged();
			((DatePicker)this).set_Date(DefaultDateTime);
		}

		protected override void OnPropertyChanged(string propertyName = null)
		{
			((Element)this).OnPropertyChanged(propertyName);
			if (propertyName == VisualElement.IsFocusedProperty.get_PropertyName() && !((VisualElement)this).get_IsFocused())
			{
				NullableDate = ((DatePicker)this).get_Date();
			}
		}

		public CustomDatePicker()
			: this()
		{
		}
	}
}
