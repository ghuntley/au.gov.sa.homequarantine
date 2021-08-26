using System.Threading.Tasks;

namespace HomeQuarantine.Services.Error
{
	public interface IErrorService
	{
		Task ReportSymptomCheckFailed();

		Task HealthReferenceIDValidationFailed();
	}
}
