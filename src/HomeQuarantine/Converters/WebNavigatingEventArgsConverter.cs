using System;
using System.Globalization;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class WebNavigatingEventArgsConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ((WebNavigationEventArgs)(((value is WebNavigatingEventArgs) ? value : null) ?? throw new ArgumentException("Expected WebNavigatingEventArgs as value", "value"))).get_Url();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
