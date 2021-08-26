using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace HomeQuarantine.Services.RequestProvider
{
	public class RequestProvider : IRequestProvider
	{
		private const string METHOD_STARTED = "- Started";

		private const string METHOD_COMPLETED = "- Completed";

		private const string RETURNED_STATUS = "Returned a status";

		private string baseUrl;

		private JsonSerializerSettings jsonSerializerOptions;

		public RequestProvider()
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			baseUrl = "https://public.api.sa.gov.au/home-quarantine/symptom-check";
			JsonSerializerSettings val = new JsonSerializerSettings();
			val.set_ContractResolver((IContractResolver)new CamelCasePropertyNamesContractResolver());
			val.set_DateTimeZoneHandling((DateTimeZoneHandling)1);
			val.set_NullValueHandling((NullValueHandling)1);
			jsonSerializerOptions = val;
			jsonSerializerOptions.get_Converters().Add((JsonConverter)new StringEnumConverter());
		}

		private void SetRequestCommon(HttpRequestMessage request, string apiUrl, string method, string authToken)
		{
			_ = "SetRequestCommon - Url: " + apiUrl + " Method: " + method;
			request.Method = new HttpMethod(method);
			request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
			request.Headers.CacheControl = new CacheControlHeaderValue
			{
				NoCache = true,
				NoStore = true
			};
			if (authToken != null)
			{
				request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
			}
			request.RequestUri = new Uri(apiUrl, UriKind.RelativeOrAbsolute);
		}

		public async Task<T> GetAsync<T>(string apiUrl, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "GetAsync<T> - Url: " + apiUrl;
			return await InternalGetAsync<T>(apiUrl, "GET", cancellationToken, authToken);
		}

		public async Task GetAsync(string apiUrl, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "GetAsync - Url: " + apiUrl;
			await InternalGetAsync(apiUrl, "GET", cancellationToken, authToken);
		}

		public async Task<T> PatchAsync<T>(string apiUrl, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PatchAsync<T> - Url: " + apiUrl;
			return await InternalGetAsync<T>(apiUrl, "PATCH", cancellationToken, authToken);
		}

		public async Task PatchAsync(string apiUrl, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PatchAsync - Url: " + apiUrl;
			await InternalGetAsync(apiUrl, "PATCH", cancellationToken, authToken);
		}

		public async Task<T> PostAsync<T, TI>(string apiUrl, TI payload, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PostAsync<T,I> - Url: " + apiUrl;
			return await InternalPostAsync<T, TI>(apiUrl, payload, "POST", cancellationToken, authToken);
		}

		public async Task PostAsync<T>(string apiUrl, T payload, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PostAsync<I> - Url: " + apiUrl;
			await InternalPostAsync(apiUrl, payload, "POST", cancellationToken, authToken);
		}

		public async Task<T> PostFormAsync<T>(string apiUrl, string payload, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PostFormAsync<I> - Url: " + apiUrl;
			return await InternalPostFormAsync<T>(apiUrl, payload, "POST", cancellationToken, authToken);
		}

		public async Task PostFormAsync(string apiUrl, string payload, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PostFormAsync - Url: " + apiUrl;
			await InternalPostFormAsync(apiUrl, payload, "POST", cancellationToken, authToken);
		}

		public async Task<T> PutAsync<T, I>(string apiUrl, I payload, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PutAsync<T, I> - Url: " + apiUrl;
			return await InternalPostAsync<T, I>(apiUrl, payload, "PUT", cancellationToken, authToken);
		}

		public async Task PutAsync<I>(string apiUrl, I payload, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "PutAsync<I> - Url: " + apiUrl;
			await InternalPostAsync(apiUrl, payload, "PUT", cancellationToken, authToken);
		}

		private async Task<T> InternalGetAsync<T>(string apiUrl, string method, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "InternalGetAsync<T> - Url: " + apiUrl + " Method:" + method;
			using HttpRequestMessage request_ = new HttpRequestMessage();
			SetRequestCommon(request_, apiUrl, method, authToken);
			using HttpClient client = CreateClient();
			return await ProcessResponse<T>(client, request_, cancellationToken);
		}

		private async Task InternalGetAsync(string apiUrl, string method, CancellationToken cancellationToken, string authToken = null)
		{
			_ = "InternalGetAsync - Url: " + apiUrl + " Method:" + method;
			using HttpRequestMessage request_ = new HttpRequestMessage();
			SetRequestCommon(request_, apiUrl, method, authToken);
			using HttpClient client = CreateClient();
			await ProcessResponse(client, request_, cancellationToken);
		}

		private async Task<T> InternalPostFormAsync<T>(string apiUrl, string payload, string method, CancellationToken cancellationToken, string authToken)
		{
			_ = "InternalPostAsync<T, I> - Url: " + apiUrl + " Method:" + method;
			using HttpRequestMessage request_ = new HttpRequestMessage();
			SetRequestCommon(request_, apiUrl, method, authToken);
			request_.Content = new StringContent(payload ?? string.Empty);
			request_.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
			using HttpClient client = CreateClient();
			return await ProcessResponse<T>(client, request_, cancellationToken);
		}

		private async Task InternalPostFormAsync(string apiUrl, string payload, string method, CancellationToken cancellationToken, string authToken)
		{
			_ = "InternalPostAsync<T, I> - Url: " + apiUrl + " Method:" + method;
			using HttpRequestMessage request_ = new HttpRequestMessage();
			SetRequestCommon(request_, apiUrl, method, authToken);
			request_.Content = new StringContent(payload ?? string.Empty);
			request_.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
			using HttpClient client = CreateClient();
			await ProcessResponse(client, request_, cancellationToken);
		}

		private async Task<T> InternalPostAsync<T, I>(string apiUrl, I payload, string method, CancellationToken cancellationToken, string authToken)
		{
			_ = "InternalPostAsync<T, I> - Url: " + apiUrl + " Method:" + method;
			using HttpRequestMessage request_ = new HttpRequestMessage();
			SetRequestCommon(request_, apiUrl, method, authToken);
			request_.Content = new StringContent(JsonConvert.SerializeObject((object)payload, jsonSerializerOptions));
			request_.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			using HttpClient client = CreateClient();
			return await ProcessResponse<T>(client, request_, cancellationToken);
		}

		private async Task InternalPostAsync<I>(string apiUrl, I payload, string method, CancellationToken cancellationToken, string authToken)
		{
			_ = "InternalPostAsync<I> - Url: " + apiUrl + " Method:" + method;
			using HttpRequestMessage request_ = new HttpRequestMessage();
			SetRequestCommon(request_, apiUrl, method, authToken);
			request_.Content = new StringContent(JsonConvert.SerializeObject((object)payload, jsonSerializerOptions));
			request_.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			using HttpClient client = CreateClient();
			try
			{
				await ProcessResponse(client, request_, cancellationToken);
			}
			catch (HttpNoContentException)
			{
				return;
			}
		}

		protected HttpClient CreateClient()
		{
			return new HttpClient
			{
				BaseAddress = new Uri(baseUrl)
			};
		}

		protected async Task ProcessResponse(HttpClient client, HttpRequestMessage request, CancellationToken cancellationToken)
		{
			client.BaseAddress = new Uri(baseUrl);
			using HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
			Dictionary<string, IEnumerable<string>> headers_ = response.Headers.ToDictionary((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response.Content != null && response.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response.Content.Headers)
				{
					headers_[header.Key] = header.Value;
				}
			}
			int status = (int)response.StatusCode;
			if (status != 204 && status != 404 && status != 400)
			{
				_ = status;
				_ = 401;
			}
			switch (status)
			{
			case 204:
				return;
			case 404:
				throw new HttpNotFoundException();
			case 400:
				throw new HttpBadFormatException(await response.Content.ReadAsStringAsync());
			case 401:
				throw new HttpUnAuthorizedException(await response.Content.ReadAsStringAsync());
			}
			string text = ((response.Content != null) ? (await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : string.Empty);
			string response2 = text;
			throw new ApiException("There was an internal server error.", status, response2, headers_);
		}

		protected async Task<T> ProcessResponse<T>(HttpClient client, HttpRequestMessage request, CancellationToken cancellationToken)
		{
			client.BaseAddress = new Uri(baseUrl);
			using HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
			Dictionary<string, IEnumerable<string>> headers_ = response.Headers.ToDictionary((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response.Content != null && response.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response.Content.Headers)
				{
					headers_[header.Key] = header.Value;
				}
			}
			int status_ = (int)response.StatusCode;
			switch (status_)
			{
			case 200:
				return (await ReadObjectResponseAsync<T>(response, headers_, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) ?? throw new ApiException("Response was null which was not expected.", status_, "", headers_);
			case 204:
				throw new HttpNoContentException();
			case 404:
				throw new HttpNotFoundException();
			case 400:
				throw new HttpBadFormatException(await response.Content.ReadAsStringAsync());
			case 401:
				throw new HttpUnAuthorizedException(await response.Content.ReadAsStringAsync());
			default:
			{
				string text = ((response.Content != null) ? (await response.Content.ReadAsStringAsync()) : string.Empty);
				string response2 = text;
				throw new ApiException("There was an internal server error.", status_, response2, headers_);
			}
			}
		}

		protected async Task<T> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
		{
			try
			{
				using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
				return JsonConvert.DeserializeObject<T>(new StreamReader(stream).ReadToEnd(), jsonSerializerOptions);
			}
			catch (JsonException val)
			{
				JsonException innerException = val;
				throw new ApiException("Could not deserialize the response body stream as " + typeof(T).FullName + ".", (int)response.StatusCode, string.Empty, headers, (Exception)(object)innerException);
			}
		}
	}
}
