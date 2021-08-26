using System.Collections.Generic;

namespace HomeQuarantine.Data.Models
{
	public class AccordionModel
	{
		public string Heading { get; set; }

		public List<string> Content { get; set; } = new List<string>();


		public List<InformationResourceLinkButtonModel> LinkGroup { get; set; } = new List<InformationResourceLinkButtonModel>();


		public bool IsExpanded { get; set; }

		public CallButtonModel CallButton { get; set; }

		public TextMessageButtonModel TextMessageButton { get; set; }

		public List<string> Reasons { get; set; } = new List<string>();


		public List<string> OtherContent { get; set; } = new List<string>();

	}
}
