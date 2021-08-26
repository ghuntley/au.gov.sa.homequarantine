using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Services.ComplianceCheck;
using HomeQuarantine.Services.Dialog;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.ViewModels;
using HomeQuarantine.Views;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace HomeQuarantine.Services.NotificationActions
{
	public class NotificationActionService : INotificationActionsService
	{
		private readonly Dictionary<string, PushNotificationAction> actionMappings = new Dictionary<string, PushNotificationAction>
		{
			{
				"symptom_check",
				PushNotificationAction.OpenSymptomCheck
			},
			{
				"compliance_check",
				PushNotificationAction.OpenComplianceCheck
			},
			{
				"wellness_info",
				PushNotificationAction.OpenWellnessInfo
			}
		};

		private readonly INavigationService navigationService;

		private readonly IExperienceApiService experienceApiService;

		private readonly ISettingsService settingsService;

		private readonly IDialogService dialogService;

		private readonly IComplianceCheckService complianceCheckService;

		private List<PushNotification> notificationQueue = new List<PushNotification>();

		public NotificationActionService(INavigationService navigationService, ISettingsService settingsService, IExperienceApiService experienceApiService, IDialogService dialogService, IComplianceCheckService complianceCheckService)
		{
			this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
			this.settingsService = settingsService ?? throw new ArgumentNullException("settingsService");
			this.experienceApiService = experienceApiService ?? throw new ArgumentNullException("experienceApiService");
			this.dialogService = dialogService ?? throw new ArgumentNullException("dialogService");
			this.complianceCheckService = complianceCheckService ?? throw new ArgumentNullException("complianceCheckService");
		}

		public int GetQueueCount()
		{
			return notificationQueue.Count;
		}

		public async Task TakeFromQueue()
		{
			PushNotification pushNotification = notificationQueue.FirstOrDefault();
			if (!string.IsNullOrEmpty(pushNotification?.Action))
			{
				await PerformAction(pushNotification);
			}
		}

		public async Task OpenOrAddToQueue(PushNotification notification)
		{
			RemoveSimilarFromQueue(notification);
			Application current = Application.get_Current();
			object obj;
			if (current == null)
			{
				obj = null;
			}
			else
			{
				Page mainPage = current.get_MainPage();
				if (mainPage == null)
				{
					obj = null;
				}
				else
				{
					INavigation navigation = ((NavigableElement)mainPage).get_Navigation();
					obj = ((navigation == null) ? null : navigation.get_NavigationStack()?.FirstOrDefault());
				}
			}
			if (obj is MainView && !((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().get_ModalStack().Any())
			{
				await PerformAction(notification);
			}
			else
			{
				AddToQueue(notification);
			}
		}

		private void AddToQueue(PushNotification notification)
		{
			notificationQueue.Add(notification);
		}

		private void RemoveSimilarFromQueue(PushNotification notification)
		{
			notificationQueue.RemoveAll((PushNotification n) => n?.Action == notification.Action);
		}

		private async Task PerformAction(PushNotification notification)
		{
			if (!actionMappings.TryGetValue(notification?.Action, out var action))
			{
				return;
			}
			if (!notification.ReceivedInBackground)
			{
				await ShowPrompt(notification);
			}
			try
			{
				if (await experienceApiService.GetOnboardingStatus() == QuarantineStatusType.QuarantineStarted)
				{
					switch (action)
					{
					case PushNotificationAction.OpenSymptomCheck:
						await navigationService.PushModalAsync<SymptomCheckViewModel>();
						break;
					case PushNotificationAction.OpenComplianceCheck:
						await complianceCheckService.ShowComplianceCheck();
						break;
					case PushNotificationAction.OpenWellnessInfo:
						await navigationService.PushModalAsync(null, App.Constants.WelcomeNotificationViewModel);
						break;
					}
				}
				RemoveSimilarFromQueue(notification);
			}
			catch (Exception ex)
			{
				Crashes.TrackError(ex, (IDictionary<string, string>)new Dictionary<string, string> { 
				{
					"Action",
					notification?.Action.ToString()
				} }, Array.Empty<ErrorAttachmentLog>());
			}
		}

		private async Task ShowPrompt(PushNotification notification)
		{
			if (!string.IsNullOrEmpty(notification?.Title) && !string.IsNullOrEmpty(notification?.Message))
			{
				await dialogService.DisplayAlert(notification?.Title, notification?.Message, "OK");
			}
		}
	}
}
