using System;
using System.Threading.Tasks;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class TestingScheduleHelpViewModel : ViewModelBase
	{
		private readonly IOpenUrlService openUrlService;

		public IAsyncCommand CallHelpCommand => new AsyncCommand(async delegate
		{
			await CallHelp();
		});

		public TestingScheduleHelpViewModel(IOpenUrlService openUrlService)
		{
			this.openUrlService = openUrlService ?? throw new ArgumentNullException("openUrlService");
		}

		private async Task CallHelp()
		{
			await openUrlService.CallTel(Resources.TestingScheduleCalendar_ContactNumber?.Replace(" ", string.Empty));
		}
	}
}
