using System.Collections.Generic;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class ComplianceCheckDisabledViewModel : ViewModelBase
	{
		private string title;

		private string subTitle;

		private List<string> descriptions = new List<string>();

		private string imageSource;

		private Color textColor;

		private Color borderColor;

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

		public List<string> Descriptions
		{
			get
			{
				return descriptions;
			}
			set
			{
				descriptions = value;
				RaisePropertyChanged(() => Descriptions);
			}
		}

		public string ImageSource
		{
			get
			{
				return imageSource;
			}
			set
			{
				imageSource = value;
				RaisePropertyChanged(() => ImageSource);
			}
		}

		public Color BorderColor
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return borderColor;
			}
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				borderColor = value;
				RaisePropertyChanged(() => BorderColor);
			}
		}

		public Color TextColor
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return textColor;
			}
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				textColor = value;
				RaisePropertyChanged(() => TextColor);
			}
		}
	}
}
