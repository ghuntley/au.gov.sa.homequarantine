using System;

namespace HomeQuarantine.Data.Models
{
	public class QuarantineDayDetailResponse
	{
		public DateTime QuarantineDate { get; set; }

		public string DateLabel => string.Format(QuarantineDate.ToString("ddd") + ", " + QuarantineDate.ToString("MMM dd")).Replace(".", string.Empty);

		public bool SymptomCheckCompleted { get; set; }

		public bool CovidTestRequired { get; set; }

		public bool CovidTestPresented { get; set; }

		public bool IsLastItem { get; set; }

		public bool IsToday => QuarantineDate == DateTime.Today;

		public bool IsCovidTestDueToday
		{
			get
			{
				if (IsToday && CovidTestRequired)
				{
					return !CovidTestPresented;
				}
				return false;
			}
		}

		public bool ShowCovidTestCircle
		{
			get
			{
				if (!CovidTestPresented)
				{
					return CovidTestRequired;
				}
				return true;
			}
		}

		public bool IsAnyDueToday
		{
			get
			{
				if (IsToday)
				{
					if (!IsCovidTestDueToday)
					{
						return !SymptomCheckCompleted;
					}
					return true;
				}
				return false;
			}
		}

		public bool IsActive => QuarantineDate >= DateTime.Today;
	}
}
