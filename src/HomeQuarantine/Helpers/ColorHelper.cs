using Xamarin.Forms;

namespace HomeQuarantine.Helpers
{
	public static class ColorHelper
	{
		public static Color GetResourceValue(string color)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			Color @default = Color.get_Default();
			Application current = Application.get_Current();
			if (((current != null) ? current.get_Resources() : null) != null)
			{
				object obj = default(object);
				if (!Application.get_Current().get_Resources().TryGetValue(color, ref obj))
				{
					return @default;
				}
				return (Color)obj;
			}
			return @default;
		}
	}
}
