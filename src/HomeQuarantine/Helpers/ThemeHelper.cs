using System.Collections.Generic;
using HomeQuarantine.Themes;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Helpers
{
	public static class ThemeHelper
	{
		private static AppTheme currentTheme;

		public static void SetTheme(AppTheme theme)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			currentTheme = theme;
			ICollection<ResourceDictionary> mergedDictionaries = Application.get_Current().get_Resources().get_MergedDictionaries();
			if (mergedDictionaries != null)
			{
				mergedDictionaries.Clear();
				mergedDictionaries.Add((ResourceDictionary)(object)new LightTheme());
				mergedDictionaries.Add((ResourceDictionary)(object)new Icons());
				mergedDictionaries.Add((ResourceDictionary)(object)new DesignSystem());
			}
		}

		public static void UpdateTheme(AppTheme theme)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			if (currentTheme != theme)
			{
				SetTheme(theme);
			}
		}
	}
}
