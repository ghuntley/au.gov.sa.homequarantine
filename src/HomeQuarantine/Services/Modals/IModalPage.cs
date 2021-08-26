using System.Threading.Tasks;

namespace HomeQuarantine.Services.Modals
{
	public interface IModalPage
	{
		bool ShowDismiss { get; }

		Task Dismiss();
	}
}
