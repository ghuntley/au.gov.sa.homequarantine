using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.ViewModels
{
	public class ViewAllNotificationViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		private readonly IApiService apiService;

		private IEnumerable<NotificationResponse> allNotifications;

		public IAsyncCommand<NotificationResponse> NotificationDetailsCommand => new AsyncCommand<NotificationResponse>(async delegate(NotificationResponse n)
		{
			await ReadNotification(n);
		});

		public IEnumerable<NotificationResponse> AllNotifications
		{
			get
			{
				return allNotifications;
			}
			set
			{
				allNotifications = value;
				RaisePropertyChanged(() => AllNotifications);
			}
		}

		public ViewAllNotificationViewModel(INavigationService navigationService, IApiService apiService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.apiService = apiService ?? throw new ArgumentNullException("apiService");
		}

		public override async Task InitializeAsync(object navigationData)
		{
			base.IsBusy = true;
			await apiService.CallApi(new GetNotificationHistory(), async delegate(IEnumerable<NotificationResponse> notifications)
			{
				AllNotifications = notifications;
				ClearBusyStatus();
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

		private async Task ReadNotification(NotificationResponse notification)
		{
			if (notification.NotificationType == NotificationType.HomeQuarantineStarted)
			{
				await navigationService.NavigateToAsync(null, App.Constants.WelcomeNotificationViewModel);
			}
		}
	}
}
