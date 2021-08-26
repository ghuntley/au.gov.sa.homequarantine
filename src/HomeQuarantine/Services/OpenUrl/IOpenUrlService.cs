using System.Threading.Tasks;

namespace HomeQuarantine.Services.OpenUrl
{
	public interface IOpenUrlService
	{
		Task OpenUrl(string url);

		Task CallTel(string number);
	}
}
