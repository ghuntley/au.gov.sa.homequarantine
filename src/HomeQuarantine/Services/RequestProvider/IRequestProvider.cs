using System.Threading;
using System.Threading.Tasks;

namespace HomeQuarantine.Services.RequestProvider
{
	public interface IRequestProvider
	{
		Task<T> GetAsync<T>(string apiUrl, CancellationToken cancellationToken, string authToken = null);

		Task GetAsync(string apiUrl, CancellationToken cancellationToken, string authToken = null);

		Task<T> PatchAsync<T>(string apiUrl, CancellationToken cancellationToken, string authToken = null);

		Task PatchAsync(string apiUrl, CancellationToken cancellationToken, string authToken = null);

		Task<T> PostAsync<T, I>(string apiUrl, I payload, CancellationToken cancellationToken, string authToken = null);

		Task PostAsync<I>(string apiUrl, I payload, CancellationToken cancellationToken, string authToken = null);

		Task<T> PostFormAsync<T>(string apiUrl, string payload, CancellationToken cancellationToken, string authToken = null);

		Task PostFormAsync(string apiUrl, string payload, CancellationToken cancellationToken, string authToken = null);

		Task<T> PutAsync<T, I>(string apiUrl, I payload, CancellationToken cancellationToken, string authToken = null);

		Task PutAsync<I>(string apiUrl, I payload, CancellationToken cancellationToken, string authToken = null);
	}
}
