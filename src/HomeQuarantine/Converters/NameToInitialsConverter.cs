using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace HomeQuarantine.Converters
{
	public class NameToInitialsConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = value as string;
			if (text != null && !string.IsNullOrEmpty(text))
			{
				string[] array = text?.Split(new char[1] { ' ' });
				if (array != null && array.Length != 0)
				{
					string[] array2 = array.Select((string word) => word[0].ToString().ToUpper()).ToArray();
					if (array2 != null && array2.Length > 2)
					{
						array2 = new string[2]
						{
							array2[0],
							array2[^1]
						};
					}
					return string.Join(string.Empty, array2);
				}
			}
			return string.Empty;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
