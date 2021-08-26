using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.RequestProvider;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class OnboardingReferenceIDViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private readonly IExperienceApiService experienceApiService;

		private readonly IOpenUrlService openUrlService;

		private readonly ISettingsService settingsService;

		private readonly IDependencyService dependencyService;

		private string healthReferenceID;

		private bool showErrorMessage;

		private bool showValidatingMessage;

		private bool successMessage;

		private bool showBlurBackground;

		private OnboardingType pageType;

		public IAsyncCommand NextCommand => new AsyncCommand(async delegate
		{
			await OnNext();
		});

		public Color ButtonColour
		{
			get
			{
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				object obj = default(object);
				Application.get_Current().get_Resources().TryGetValue("PrimaryColor", ref obj);
				object obj2 = default(object);
				Application.get_Current().get_Resources().TryGetValue("PrimaryDisabledColor", ref obj2);
				if (!string.IsNullOrEmpty(healthReferenceID))
				{
					string text = healthReferenceID;
					if (text != null && text.Length > 6)
					{
						return (Color)obj;
					}
				}
				return (Color)obj2;
			}
		}

		public bool ShowErrorMessage
		{
			get
			{
				return showErrorMessage;
			}
			set
			{
				showErrorMessage = value;
				RaisePropertyChanged(() => ShowErrorMessage);
			}
		}

		public bool ShowValidatingMessage
		{
			get
			{
				return showValidatingMessage;
			}
			set
			{
				showValidatingMessage = value;
				RaisePropertyChanged(() => ShowValidatingMessage);
			}
		}

		public bool ShowSuccessMessage
		{
			get
			{
				return successMessage;
			}
			set
			{
				successMessage = value;
				RaisePropertyChanged(() => ShowSuccessMessage);
			}
		}

		public bool ShowBlurBackground
		{
			get
			{
				return showBlurBackground;
			}
			set
			{
				showBlurBackground = value;
				RaisePropertyChanged(() => ShowBlurBackground);
			}
		}

		public string HealthReferenceID
		{
			get
			{
				return healthReferenceID;
			}
			set
			{
				healthReferenceID = value;
				RaisePropertyChanged(() => HealthReferenceID);
				RaisePropertyChanged(() => NextAllowed);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public OnboardingType PageType
		{
			get
			{
				return pageType;
			}
			set
			{
				pageType = value;
				RaisePropertyChanged(() => PageType);
			}
		}

		public IAsyncCommand CallHelpCommand => new AsyncCommand(async delegate
		{
			await CallHelp();
		});

		public bool NextAllowed
		{
			get
			{
				if (!string.IsNullOrEmpty(healthReferenceID))
				{
					return healthReferenceID.Length > 6;
				}
				return false;
			}
		}

		public OnboardingReferenceIDViewModel(INavigationService navigationService, IExperienceApiService experienceApiService, ISettingsService settingsService, IOpenUrlService openUrlService, IDependencyService dependencyService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.experienceApiService = experienceApiService ?? throw new ArgumentNullException("experienceApiService");
			this.settingsService = settingsService ?? throw new ArgumentNullException("settingsService");
			this.openUrlService = openUrlService ?? throw new ArgumentNullException("openUrlService");
			this.dependencyService = dependencyService ?? throw new ArgumentNullException("dependencyService");
		}

		private async Task OnNext()
		{
			await SingleRunAsync(async delegate
			{
				_ = 3;
				try
				{
					base.IsBusy = true;
					if (NextAllowed)
					{
						await Task.WhenAll(new List<Task>
						{
							experienceApiService.ValidateHealthReferenceID(HealthReferenceID),
							SetPageAsValidating(),
							Task.Delay(800)
						});
						ShowValidatingMessage = false;
						ShowSuccessMessage = true;
						settingsService.HealthReferenceID = HealthReferenceID;
						dependencyService.Get<IFeedbackService>().Success();
						await Task.Delay(2000);
						await navigationService.NavigateToAsync<OnboardingViewModel>(OnboardingType.Address);
						settingsService.CurrentOnboardingPage = OnboardingType.Address;
					}
				}
				catch (HttpNotFoundException)
				{
					HandleError();
				}
				catch (Exception ex2)
				{
					HandleError();
					Console.WriteLine(ex2.Message);
					ErrorViewModel referenceIDErrorHandlingPage = App.Constants.ReferenceIDErrorHandlingPage;
					referenceIDErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
					{
						await OnNext();
					});
					dependencyService.Get<IFeedbackService>().Fail();
					await navigationService.PushSingleErrorModal(null, referenceIDErrorHandlingPage);
				}
				finally
				{
					base.IsBusy = false;
				}
			});
		}

		private Task SetPageAsValidating()
		{
			ShowValidatingMessage = true;
			ShowBlurBackground = true;
			return Task.FromResult(result: true);
		}

		private async Task CallHelp()
		{
			await openUrlService.CallTel(Resources.ReferenceIDView_ContactNumber?.Replace(" ", string.Empty));
		}

		private void HandleError()
		{
			ShowValidatingMessage = false;
			ShowBlurBackground = false;
			ShowSuccessMessage = false;
			ShowErrorMessage = true;
			HealthReferenceID = string.Empty;
		}
	}
}
