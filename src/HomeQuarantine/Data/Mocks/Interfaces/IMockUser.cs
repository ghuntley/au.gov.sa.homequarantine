using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;

namespace HomeQuarantine.Data.Mocks.Interfaces
{
	public interface IMockUser
	{
		QuarantineStatusType QuarantineStatus { get; set; }

		SymptomCheckResponse SymptomCheckResponse { get; set; }

		AddressResponse Address { get; set; }

		bool ValidateHealthIDWasSuccessful { get; set; }
	}
}
