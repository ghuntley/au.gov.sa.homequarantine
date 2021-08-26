using System.ComponentModel;
using Android.Content;
using Android.Widget;
using HomeQuarantine.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace HomeQuarantine.Droid.Renderers
{
	public class CustomDatePickerRenderer : DatePickerRenderer
	{
		public CustomDatePickerRenderer(Context context)
			: this(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
		{
			((DatePickerRendererBase<EditText>)this).OnElementChanged(e);
			TryShowEmptyState();
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			((DatePickerRendererBase<EditText>)this).OnElementPropertyChanged(sender, e);
			if (e.PropertyName == CustomDatePicker.NullableDateProperty.get_PropertyName() || e.PropertyName == CustomDatePicker.EmptyStateTextProperty.get_PropertyName())
			{
				TryShowEmptyState();
			}
		}

		private void TryShowEmptyState()
		{
			DatePicker element = ((VisualElementRenderer<DatePicker>)this).get_Element();
			CustomDatePicker val = (CustomDatePicker)(object)((element is CustomDatePicker) ? element : null);
			if (val != null && !val.get_NullableDate().HasValue)
			{
				((TextView)((ViewRenderer<DatePicker, EditText>)this).get_Control()).set_Text(val.get_EmptyStateText());
			}
		}
	}
}
