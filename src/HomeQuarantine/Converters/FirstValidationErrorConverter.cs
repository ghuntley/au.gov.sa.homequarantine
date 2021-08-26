using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class FirstValidationErrorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			ICollection<string> collection = value as ICollection<string>;
			if (collection == null || collection.Count <= 0)
			{
				return null;
			}
			return collection.ElementAt(0);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
