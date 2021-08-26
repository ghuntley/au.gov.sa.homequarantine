using System;
using Xamarin.Essentials;

namespace HomeQuarantine.Helpers
{
	public class PreferenceHelper
	{
		public void AddOrUpdateValue<T>(string key, T value)
		{
			if (value == null)
			{
				Preferences.Remove(key);
			}
			try
			{
				string text = value as string;
				if (text != null)
				{
					Preferences.Set(key, text);
					return;
				}
				if (value is double)
				{
					object obj = value;
					double num = (double)((obj is double) ? obj : null);
					Preferences.Set(key, num);
					return;
				}
				if (value is int)
				{
					object obj2 = value;
					int num2 = (int)((obj2 is int) ? obj2 : null);
					Preferences.Set(key, num2);
					return;
				}
				if (value is DateTime)
				{
					object obj3 = value;
					DateTime dateTime = (DateTime)((obj3 is DateTime) ? obj3 : null);
					Preferences.Set(key, dateTime);
					return;
				}
				if (value is bool)
				{
					object obj4 = value;
					bool flag = (bool)((obj4 is bool) ? obj4 : null);
					Preferences.Set(key, flag);
					return;
				}
				if (value is float)
				{
					object obj5 = value;
					float num3 = (float)((obj5 is float) ? obj5 : null);
					Preferences.Set(key, num3);
					return;
				}
				if (!(value is long))
				{
					throw new Exception("XE Preferences: The object type is not supported.");
				}
				object obj6 = value;
				long num4 = (long)((obj6 is long) ? obj6 : null);
				Preferences.Set(key, num4);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unable to save: " + key, " Message: " + ex.Message);
			}
		}

		public bool GetValueOrDefault(string key, bool defaultValue = false)
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (bool)obj;
		}

		public double GetValueOrDefault(string key, double defaultValue = 0.0)
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (double)obj;
		}

		public int GetValueOrDefault(string key, int defaultValue = 0)
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (int)obj;
		}

		public float GetValueOrDefault(string key, float defaultValue = 0f)
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (float)obj;
		}

		public long GetValueOrDefault(string key, long defaultValue = 0L)
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (long)obj;
		}

		public string GetValueOrDefault(string key, string defaultValue = null)
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (string)obj;
		}

		public DateTime GetValueOrDefault(string key, DateTime defaultValue = default(DateTime))
		{
			object obj = null;
			if (Preferences.ContainsKey(key))
			{
				obj = Preferences.Get(key, defaultValue);
			}
			if (obj == null)
			{
				return defaultValue;
			}
			return (DateTime)obj;
		}

		public void Remove(string key)
		{
			try
			{
				if (Preferences.ContainsKey(key))
				{
					Preferences.Remove(key);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unable to remove: " + key, " Message: " + ex.Message);
			}
		}

		public void Clear()
		{
			try
			{
				Preferences.Clear();
			}
			catch
			{
				Console.WriteLine("Unable to clear secure storage");
			}
		}
	}
}
