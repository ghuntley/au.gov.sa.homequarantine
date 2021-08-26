using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace HomeQuarantine.Helpers
{
	public static class AppCenterHelper
	{
		private static bool Initialised { get; set; }

		public static void Init()
		{
			if (!Initialised)
			{
				AppCenter.Start("ios=d5ae35e6-fa9a-4eca-84b4-dc4dc8482693;android=37bf793f-4256-4602-ab11-f1e0e9a4702d", new Type[2]
				{
					typeof(Analytics),
					typeof(Crashes)
				});
				Initialised = true;
			}
		}
	}
}
