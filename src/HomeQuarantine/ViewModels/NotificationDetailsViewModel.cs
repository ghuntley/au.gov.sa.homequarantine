using System;
using System.Collections.Generic;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class NotificationDetailsViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private string title;

		private List<string> content = new List<string>();

		private Color color;

		private string informationTitle;

		private List<string> informationContent = new List<string>();

		private List<ResourceLinkModel> links = new List<ResourceLinkModel>();

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

		public List<string> Content
		{
			get
			{
				return content;
			}
			set
			{
				content = value;
				RaisePropertyChanged(() => Content);
			}
		}

		public Color Color
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return color;
			}
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				color = value;
				RaisePropertyChanged(() => Color);
			}
		}

		public string InformationTitle
		{
			get
			{
				return informationTitle;
			}
			set
			{
				informationTitle = value;
				RaisePropertyChanged(() => InformationTitle);
			}
		}

		public List<string> InformationContent
		{
			get
			{
				return informationContent;
			}
			set
			{
				informationContent = value;
				RaisePropertyChanged(() => InformationContent);
			}
		}

		public List<ResourceLinkModel> Links
		{
			get
			{
				return links;
			}
			set
			{
				links = value;
				RaisePropertyChanged(() => Links);
			}
		}

		public NotificationDetailsViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
		}
	}
}
