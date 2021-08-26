using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;

namespace HomeQuarantine.Data.Models.Helpers
{
	public static class NotificationHelper
	{
		public static string GetActionLabel(NotificationType notificationType)
		{
			switch (notificationType)
			{
			case NotificationType.SymptomCheck:
			case NotificationType.SymptomCheckReminder:
				return HomeQuarantine.Data.Resources.Languages.Resources.NotificationView_SubmitSymptoms;
			case NotificationType.ComplianceCheck:
			case NotificationType.ComplianceCheckReminder:
				return HomeQuarantine.Data.Resources.Languages.Resources.NotificationView_StartCheckIn;
			default:
				return HomeQuarantine.Data.Resources.Languages.Resources.NotificationView_ReadNotification;
			}
		}
	}
}
