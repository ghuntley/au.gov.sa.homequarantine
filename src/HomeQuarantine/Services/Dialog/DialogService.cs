using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeQuarantine.Services.Dialog
{
	public class DialogService : IDialogService
	{
		public async Task DisplayAlert(string title, string message, string confirm)
		{
			await Device.InvokeOnMainThreadAsync((Func<Task>)async delegate
			{
				await Application.get_Current().get_MainPage().DisplayAlert(title, message, confirm);
			});
		}

		public async Task<bool> DisplayAlert(string title, string message, string confirm, string cancel)
		{
			return await Device.InvokeOnMainThreadAsync<bool>((Func<Task<bool>>)(async () => await Application.get_Current().get_MainPage().DisplayAlert(title, message, confirm, cancel)));
		}
	}
}
