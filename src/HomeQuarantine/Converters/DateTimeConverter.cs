using System;
using System.Globalization;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class DateTimeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is DateTime)
			{
				return ((DateTime)value).ToString("dd / MM / yyyy");
			}
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
