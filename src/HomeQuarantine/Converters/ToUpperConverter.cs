using System;
using System.Globalization;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class ToUpperConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				return value.ToString()!.ToUpperInvariant();
			}
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
