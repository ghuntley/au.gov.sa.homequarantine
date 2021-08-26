using HomeQuarantine.Data.Mocks.Interfaces;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;

namespace HomeQuarantine.Data.Mocks
{
	public class User1 : IMockUser
	{
		public QuarantineStatusType QuarantineStatus { get; set; }

		public SymptomCheckResponse SymptomCheckResponse { get; set; } = new SymptomCheckResponse
		{
			Code = "SUCCESS",
			QuarantineID = "123"
		};


		public AddressResponse Address { get; set; } = new AddressResponse
		{
			OnboardingAddress = "Your address"
		};


		public bool ValidateHealthIDWasSuccessful { get; set; } = true;

	}
}
