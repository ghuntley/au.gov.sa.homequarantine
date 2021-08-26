using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class OnboardingHelpViewModel : ViewModelBase
	{
		private string title;

		private IEnumerable<string> descriptions;

		private string imageSource;

		private string buttonText;

		private Color buttonColour;

		private ICommand buttonCommand;

		private bool showDismiss;

		private readonly INavigationService navigationService;

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

		public IEnumerable<string> Descriptions
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

		public ICommand ButtonCommand
		{
			get
			{
				return buttonCommand;
			}
			set
			{
				buttonCommand = value;
				RaisePropertyChanged(() => ButtonCommand);
			}
		}

		public Color ButtonColour
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return buttonColour;
			}
			set
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				buttonColour = value;
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public string ButtonText
		{
			get
			{
				return buttonText;
			}
			set
			{
				buttonText = value;
				RaisePropertyChanged(() => ButtonText);
			}
		}

		public Func<Task<bool>> IsPermissionGranted { get; set; }

		public Func<Task<bool>> AfterClosed { get; set; }

		public bool ShowDismiss
		{
			get
			{
				return showDismiss;
			}
			set
			{
				showDismiss = value;
				RaisePropertyChanged(() => ShowDismiss);
			}
		}

		public bool IsPermissionsType { get; set; } = true;


		public OnboardingHelpViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

		public OnboardingHelpViewModel()
		{
		}

		public async Task Dismiss()
		{
			await navigationService.PopModalAsync();
		}
	}
}
