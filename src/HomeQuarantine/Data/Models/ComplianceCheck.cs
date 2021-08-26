namespace HomeQuarantine.Data.Models
{
	public class ComplianceCheck
	{
		public string PushHandle { get; set; }

		public double? Accuracy { get; set; }

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public bool IsMock { get; set; }

		public string FacialVerificationToken { get; set; }
	}
}
