using System.Collections.Generic;
using HomeQuarantine.Data.Models.Enums;
using Xamarin.Forms;

namespace HomeQuarantine.Data.Models
{
	public class InformationContentGroupModel
	{
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Description { get; set; }

		public Color BoxColor { get; set; }

		public InformationContentGroupType GroupType { get; set; }

		public List<ResourceLinkModel> Links { get; set; } = new List<ResourceLinkModel>();


		public List<AccordionModel> Accordions { get; set; } = new List<AccordionModel>();


		public bool ShowBackground { get; set; }
	}
}
