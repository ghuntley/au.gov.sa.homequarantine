using HomeQuarantine.Data.Models;
using Xamarin.Forms;

namespace HomeQuarantine.Selectors
{
	public class ContentGroupDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate AccordionTemplate { get; set; }

		public DataTemplate ResourceLinkTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			InformationContentGroupModel obj = (InformationContentGroupModel)item;
			if (obj == null || obj.GroupType != 0)
			{
				return ResourceLinkTemplate;
			}
			return AccordionTemplate;
		}

		public ContentGroupDataTemplateSelector()
			: this()
		{
		}
	}
}
