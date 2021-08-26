using System;

namespace HomeQuarantine.Data.Models
{
	public class AppVersion
	{
		public string Version { get; set; }

		public DateTime? ExpiryDate { get; set; }

		public bool Expired { get; set; }

		public bool LatestVersion { get; set; }
	}
}
