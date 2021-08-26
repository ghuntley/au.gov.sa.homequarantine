using System;
using System.Drawing;
using System.Threading.Tasks;
using HomeQuarantine.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.Services.OpenUrl
{
	public class OpenUrlService : IOpenUrlService
	{
		public async Task OpenUrl(string url)
		{
			Uri uri = new Uri(url);
			BrowserLaunchOptions val = new BrowserLaunchOptions();
			val.set_LaunchMode((BrowserLaunchMode)0);
			val.set_PreferredToolbarColor((Color?)Color.op_Implicit(ColorHelper.GetResourceValue("NavigationBarColor")));
			val.set_PreferredControlColor((Color?)Color.op_Implicit(ColorHelper.GetResourceValue("PrimaryColor")));
			val.set_TitleMode((BrowserTitleMode)1);
			if (!(await Browser.OpenAsync(uri, val)))
			{
				await Launcher.OpenAsync(new Uri(url));
			}
		}

		public async Task CallTel(string number)
		{
			await Launcher.OpenAsync("tel:" + number);
		}
	}
}
