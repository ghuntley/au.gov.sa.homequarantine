using System;
using System.Globalization;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class EqualityToBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return object.Equals(value, parameter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
