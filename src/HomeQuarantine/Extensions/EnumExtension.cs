using System;
using System.ComponentModel;
using System.Reflection;

namespace HomeQuarantine.Extensions
{
	public static class EnumExtension
	{
		public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
		{
			if (!typeof(T).IsEnum)
			{
				return null;
			}
			string result = enumValue.ToString();
			FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());
			if (field != null)
			{
				object[] customAttributes = field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: true);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					result = ((DescriptionAttribute)customAttributes[0]).Description;
				}
			}
			return result;
		}
	}
}
