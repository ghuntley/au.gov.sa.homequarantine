using Xamarin.Forms;

namespace HomeQuarantine.Data.Models.Interfaces
{
	public interface IOnboardingContent
	{
		string Header { get; set; }

		string Text { get; set; }

		string ImageSource { get; set; }

		string ButtonText { get; set; }

		Color Colour { get; set; }
	}
}
