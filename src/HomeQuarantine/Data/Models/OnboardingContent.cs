using HomeQuarantine.Data.Models.Interfaces;
using Xamarin.Forms;

namespace HomeQuarantine.Data.Models
{
	public class OnboardingContent : IOnboardingContent
	{
		public string Header { get; set; }

		public string Text { get; set; }

		public string ImageSource { get; set; }

		public string ButtonText { get; set; }

		public Color Colour { get; set; }

		public string AddressHelpPage { get; set; }
	}
}
