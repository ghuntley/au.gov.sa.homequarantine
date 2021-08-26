using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Extensions;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class TestingScheduleViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private readonly IApiService apiService;

		private ObservableCollection<QuarantineDayDetailResponse> testingScheduleItems;

		private bool isDoingInitialLoad = true;

		private bool isRefreshing;

		private ICommand refreshCommand;

		public ObservableCollection<QuarantineDayDetailResponse> TestingScheduleItems
		{
			get
			{
				return testingScheduleItems;
			}
			set
			{
				if (testingScheduleItems != value)
				{
					testingScheduleItems = value;
					RaisePropertyChanged(() => TestingScheduleItems);
				}
			}
		}

		public bool IsDoingInitialLoad
		{
			get
			{
				return isDoingInitialLoad;
			}
			set
			{
				if (isDoingInitialLoad != value)
				{
					isDoingInitialLoad = value;
					RaisePropertyChanged(() => IsDoingInitialLoad);
				}
			}
		}

		public bool IsRefreshing
		{
			get
			{
				return isRefreshing;
			}
			set
			{
				if (isRefreshing != value)
				{
					isRefreshing = value;
					RaisePropertyChanged(() => IsRefreshing);
				}
			}
		}

		public ICommand RefreshCommand
		{
			get
			{
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				//IL_0023: Expected O, but got Unknown
				ICommand command = refreshCommand;
				if (command == null)
				{
					Command val = new Command((Action)async delegate
					{
						if (!IsDoingInitialLoad)
						{
							IsRefreshing = true;
							await LoadContent();
							IsRefreshing = false;
						}
					});
					ICommand command2 = (ICommand)val;
					refreshCommand = (ICommand)val;
					command = command2;
				}
				return command;
			}
		}

		public IAsyncCommand LoadContentCommand => new AsyncCommand(async delegate
		{
			await LoadContent();
		});

		public IAsyncCommand OpenHelpCommand => new AsyncCommand(async delegate
		{
			await OpenTestingScheduleHelp();
		});

		public string TestingLocationsUrl => "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/testing+and+tracing/covid-19+clinics+and+testing+centres/covid-19+clinics+and+testing+centres";

		public TestingScheduleViewModel(INavigationService navigationService, IApiService experienceApiService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			apiService = experienceApiService ?? throw new ArgumentNullException("experienceApiService");
		}

		public async Task LoadContent()
		{
			await apiService.CallApi(new GetTestingScheduleApiAction(), async delegate(QuarantineScheduleResponse schedule)
			{
				schedule.ScheduleDetails.LastOrDefault().IsLastItem = true;
				ObservableCollection<QuarantineDayDetailResponse> items = schedule.ScheduleDetails.ToObservableCollection();
				Device.BeginInvokeOnMainThread((Action)delegate
				{
					TestingScheduleItems = items;
					ClearBusyStatus();
					MainViewModel mainViewModel = ((BindableObject)((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().get_NavigationStack().FirstOrDefault()).get_BindingContext() as MainViewModel;
					if (mainViewModel != null)
					{
						mainViewModel.ExpectedEndDate = schedule.QuarantineEndDate;
					}
					IsDoingInitialLoad = false;
				});
				await Task.CompletedTask;
			}, async delegate
			{
				ClearBusyStatus();
				await apiService.ShowGeneralError(App.Constants.ConnectionErrorHandlingPage, async delegate
				{
					await InitializeAsync(null);
				});
			});
		}

		private async Task OpenTestingScheduleHelp()
		{
			await SingleRunAsync(async delegate
			{
				await navigationService.PushModalAsync<TestingScheduleHelpViewModel>();
			});
		}
	}
}
