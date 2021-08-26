using System;
using System.Collections.Generic;

namespace HomeQuarantine.Data.Models
{
	public class QuarantineScheduleResponse
	{
		public DateTime QuarantineStartDate { get; set; }

		public DateTime QuarantineEndDate { get; set; }

		public ICollection<QuarantineDayDetailResponse> ScheduleDetails { get; set; }
	}
}
