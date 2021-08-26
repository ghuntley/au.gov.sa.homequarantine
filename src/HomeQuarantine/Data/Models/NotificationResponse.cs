using System;
using System.Globalization;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Models.Helpers;
using Humanizer;
using Xamarin.Forms;

namespace HomeQuarantine.Data.Models
{
	public class NotificationResponse
	{
		public Guid NotificationId { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public Color Color { get; set; } = Color.Purple;


		public bool IsFirst { get; set; }

		public bool IsLast { get; set; }

		public DateTime? DateCreated { get; set; }

		public string DateCreatedLabel
		{
			get
			{
				if (!DateCreated.HasValue)
				{
					return string.Empty;
				}
				if (!(DateCreated.Value.ToLocalTime() > DateTime.Now.AddDays(-1.0)))
				{
					return string.Format(DateCreated.Value.ToString("ddd") + ", " + DateCreated.Value.ToString("d MMM")).Replace(".", string.Empty);
				}
				return DateHumanizeExtensions.Humanize(DateCreated.Value.ToLocalTime(), (bool?)null, (DateTime?)null, (CultureInfo)null);
			}
		}

		public DateTime? DateRead { get; set; }

		public NotificationType NotificationType { get; set; }

		public string ActionLabel => NotificationHelper.GetActionLabel(NotificationType);

		public bool AppearsOnHomePage { get; set; }

		public bool AppearsInHistory { get; set; }

		public int Priority { get; set; }
	}
}
