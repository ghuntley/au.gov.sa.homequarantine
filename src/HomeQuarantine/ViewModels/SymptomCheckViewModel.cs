using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Error;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class SymptomCheckViewModel : ViewModelBase
	{
		protected readonly INavigationService navigationService;

		protected readonly IApiService apiService;

		protected readonly IErrorService errorService;

		protected readonly ISettingsService settingsService;

		protected readonly IOpenUrlService openUrlService;

		protected readonly IDependencyService dependencyService;

		protected SymptomCheck symptomCheck;

		protected bool showErrorMessage;

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

		public bool HasFever
		{
			get
			{
				return HasSymptomByName(SymptomType.Fever);
			}
			set
			{
				ToggleSymptomByName(SymptomType.Fever);
				RaisePropertyChanged(() => HasFever);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasCough
		{
			get
			{
				return HasSymptomByName(SymptomType.Cough);
			}
			set
			{
				ToggleSymptomByName(SymptomType.Cough);
				RaisePropertyChanged(() => HasCough);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasShortnessOfBreath
		{
			get
			{
				return HasSymptomByName(SymptomType.ShortnessOfBreath);
			}
			set
			{
				ToggleSymptomByName(SymptomType.ShortnessOfBreath);
				RaisePropertyChanged(() => HasShortnessOfBreath);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasSoreThroat
		{
			get
			{
				return HasSymptomByName(SymptomType.SoreThroat);
			}
			set
			{
				ToggleSymptomByName(SymptomType.SoreThroat);
				RaisePropertyChanged(() => HasSoreThroat);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasRunnyNose
		{
			get
			{
				return HasSymptomByName(SymptomType.RunnyNose);
			}
			set
			{
				ToggleSymptomByName(SymptomType.RunnyNose);
				RaisePropertyChanged(() => HasRunnyNose);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasLossOfSmell
		{
			get
			{
				return HasSymptomByName(SymptomType.LossOfSmell);
			}
			set
			{
				ToggleSymptomByName(SymptomType.LossOfSmell);
				RaisePropertyChanged(() => HasLossOfSmell);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasLossOfTaste
		{
			get
			{
				return HasSymptomByName(SymptomType.LossOfTaste);
			}
			set
			{
				ToggleSymptomByName(SymptomType.LossOfTaste);
				RaisePropertyChanged(() => HasLossOfTaste);
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public bool HasOtherSymptoms
		{
			get
			{
				return HasSymptomByName(SymptomType.Other);
			}
			set
			{
				ToggleSymptomByName(SymptomType.Other);
				RaisePropertyChanged(() => HasOtherSymptoms);
				RaisePropertyChanged(() => HasNoSymptoms);
			}
		}

		public bool HasNoSymptoms
		{
			get
			{
				return symptomCheck.HasNoSymptomsChecked;
			}
			set
			{
				SetHasNoSymptoms();
				RaisePropertyChanged(() => HasNoSymptoms);
				RaisePropertyChanged(() => HasFever);
				RaisePropertyChanged(() => HasCough);
				RaisePropertyChanged(() => HasShortnessOfBreath);
				RaisePropertyChanged(() => HasSoreThroat);
				RaisePropertyChanged(() => HasRunnyNose);
				RaisePropertyChanged(() => HasLossOfSmell);
				RaisePropertyChanged(() => HasLossOfTaste);
				RaisePropertyChanged(() => HasOtherSymptoms);
				RaisePropertyChanged(() => ButtonColour);
			}
		}

		public Color ButtonColour
		{
			get
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				object obj = default(object);
				Application.get_Current().get_Resources().TryGetValue("PrimaryColor", ref obj);
				object obj2 = default(object);
				Application.get_Current().get_Resources().TryGetValue("PrimaryDisabledColor", ref obj2);
				if (symptomCheck.HasNoSymptomsChecked || symptomCheck.Symptoms.Any())
				{
					return (Color)obj;
				}
				return (Color)obj2;
			}
		}

		public IAsyncCommand SubmitCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await SubmitAsync();
			});
		});

		public ICommand TapFeverCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasFever = !HasFever;
		});

		public ICommand TapCoughCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasCough = !HasCough;
		});

		public ICommand TapShortnessOfBreathCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasShortnessOfBreath = !HasShortnessOfBreath;
		});

		public ICommand TapSoreThroatCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasSoreThroat = !HasSoreThroat;
		});

		public ICommand TapRunnyNoseCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasRunnyNose = !HasRunnyNose;
		});

		public ICommand TapLossOfSmellCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasLossOfSmell = !HasLossOfSmell;
		});

		public ICommand TapLossOfTasteCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasLossOfTaste = !HasLossOfTaste;
		});

		public ICommand TapOtherSymptomsCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasOtherSymptoms = !HasOtherSymptoms;
		});

		public ICommand TapNoSymptomsCommand => (ICommand)new Command((Action<object>)delegate
		{
			HasNoSymptoms = !HasNoSymptoms;
		});

		public IAsyncCommand CallHelpCommand => new AsyncCommand(async delegate
		{
			await CallHelp();
		});

		public IAsyncCommand CallHelpWhenUnwellCommand => new AsyncCommand(async delegate
		{
			await CallHelpWhenUnwell();
		});

		public SymptomCheckViewModel(INavigationService navigationService, IApiService apiService, IErrorService errorService, IDependencyService dependencyService, ISettingsService settingsService, IOpenUrlService openUrlService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.apiService = apiService ?? throw new ArgumentNullException("apiService");
			this.errorService = errorService ?? throw new ArgumentNullException("errorService");
			this.dependencyService = dependencyService ?? throw new ArgumentNullException("dependencyService");
			this.settingsService = settingsService ?? throw new ArgumentNullException("settingsService");
			this.openUrlService = openUrlService ?? throw new ArgumentNullException("openUrlService");
			symptomCheck = new SymptomCheck();
		}

		protected async Task SubmitAsync()
		{
			if (!symptomCheck.HasNoSymptomsChecked && !symptomCheck.Symptoms.Any())
			{
				ShowErrorMessage = true;
				return;
			}
			if (HasOtherSymptoms)
			{
				ShowErrorMessage = false;
				dependencyService.Get<IFeedbackService>().Click();
				await navigationService.NavigateToAsync<OtherSymptomViewModel>(symptomCheck);
				return;
			}
			SetBusyStatus(isBusy: true, Resources.SymptomCheckView_SubmittingSymptomCheck);
			await apiService.CallApi(new SubmitSymptomCheckApiAction(symptomCheck), async delegate
			{
				ClearBusyStatus();
				dependencyService.Get<IFeedbackService>().Success();
				if (HasNoSymptoms)
				{
					await navigationService.NavigateToAsync<NoSymptomResultViewModel>();
				}
				else
				{
					await navigationService.NavigateToAsync<HasSymptomResultViewModel>(symptomCheck);
				}
			}, async delegate
			{
				ClearBusyStatus();
				dependencyService.Get<IFeedbackService>().Fail();
				await apiService.ShowGeneralError(App.Constants.SymptomErrorHandlingPage, SubmitAsync);
			});
		}

		protected void ToggleSymptomByName(SymptomType symptomType)
		{
			Symptom symptom = symptomCheck.Symptoms.FirstOrDefault((Symptom s) => s.SymptomName == symptomType);
			if (symptom != null)
			{
				symptomCheck.Symptoms.Remove(symptom);
			}
			else
			{
				symptomCheck.Symptoms.Add(new Symptom
				{
					SymptomName = symptomType
				});
			}
			if (symptomCheck.Symptoms.Any())
			{
				symptomCheck.HasNoSymptomsChecked = false;
			}
		}

		protected bool HasSymptomByName(SymptomType symptomType)
		{
			return symptomCheck.Symptoms.Any((Symptom s) => s.SymptomName == symptomType);
		}

		protected void SetHasNoSymptoms()
		{
			symptomCheck.Symptoms.Clear();
			symptomCheck.HasNoSymptomsChecked = true;
		}

		private async Task CallHelp()
		{
			await openUrlService.CallTel(Resources.MonitoringSymptoms_ContactNurseNumber?.Replace(" ", string.Empty));
		}

		private async Task CallHelpWhenUnwell()
		{
			await openUrlService.CallTel(Resources.MonitoringSymptoms_SeriouslyUnwellNumber?.Replace(" ", string.Empty));
		}
	}
}
