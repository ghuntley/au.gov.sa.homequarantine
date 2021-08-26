using System;
using System.Globalization;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class WebNavigatedEventArgsConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			object obj = ((value is WebNavigatedEventArgs) ? value : null) ?? throw new ArgumentException("Expected WebNavigatedEventArgs as value", "value");
			if (obj == null)
			{
				return null;
			}
			return ((WebNavigationEventArgs)obj).get_Url();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
