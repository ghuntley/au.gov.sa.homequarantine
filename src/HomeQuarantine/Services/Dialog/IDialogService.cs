using System.Threading.Tasks;

namespace HomeQuarantine.Services.Dialog
{
	public interface IDialogService
	{
		Task DisplayAlert(string title, string message, string confirm);

		Task<bool> DisplayAlert(string title, string message, string confirm, string cancel);
	}
}
