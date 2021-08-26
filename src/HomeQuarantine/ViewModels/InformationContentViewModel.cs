using System.Collections.Generic;
using HomeQuarantine.Data.Models;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class InformationContentViewModel : ViewModelBase
	{
		private string title;

		private string heading;

		private string subHeading;

		private string subTitle;

		private List<InformationContentGroupModel> contentGroups = new List<InformationContentGroupModel>();

		public List<InformationContentGroupModel> ContentGroups
		{
			get
			{
				return contentGroups;
			}
			set
			{
				contentGroups = value;
				RaisePropertyChanged(() => ContentGroups);
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
				RaisePropertyChanged(() => Title);
			}
		}

		public string Heading
		{
			get
			{
				return heading;
			}
			set
			{
				heading = value;
				RaisePropertyChanged(() => Heading);
			}
		}

		public string SubHeading
		{
			get
			{
				return subHeading;
			}
			set
			{
				subHeading = value;
				RaisePropertyChanged(() => SubHeading);
			}
		}

		public string SubTitle
		{
			get
			{
				return subTitle;
			}
			set
			{
				subTitle = value;
				RaisePropertyChanged(() => SubTitle);
			}
		}
	}
}
