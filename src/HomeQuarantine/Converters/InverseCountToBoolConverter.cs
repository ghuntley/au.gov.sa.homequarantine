using System;
using System.Globalization;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class InverseCountToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is int)
			{
				return System.Convert.ToInt32(value) == 0;
			}
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
