using System.Windows.Input;

namespace HomeQuarantine.Data.Models
{
	public class ResourceLinkModel
	{
		public string Label { get; set; }

		public bool IsUrl { get; set; }

		public string Url { get; set; }

		public bool IsVisible { get; set; }

		public ICommand OnTapCommand { get; set; }
	}
}
