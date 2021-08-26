using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeQuarantine.Data.Models.Token;
using HomeQuarantine.Data.Models.User;
using HomeQuarantine.Services.RefreshTokenService;
using HomeQuarantine.Services.RequestProvider;
using HomeQuarantine.Services.Settings;
using IdentityModel;
using Xamarin.Essentials;

namespace HomeQuarantine.Services.Identity
{
	public class IdentityService : IIdentityService
	{
		protected IRequestProvider RequestProvider { get; private set; }

		protected ISettingsService SettingsService { get; private set; }

		protected IRefreshTokenService RefreshTokenService { get; private set; }

		public IdentityService(IRequestProvider requestProvider, ISettingsService settingsService, IRefreshTokenService refreshTokenService)
		{
			RequestProvider = requestProvider;
			SettingsService = settingsService;
			RefreshTokenService = refreshTokenService;
		}

		public virtual async Task<bool> Authenticate()
		{
			try
			{
				if (!string.IsNullOrEmpty(SettingsService.AuthAccessToken) && await CheckAndRefreshToken())
				{
					return true;
				}
				string codeVerifier = CryptoRandom.CreateUniqueId(32, (OutputFormat)0);
				SettingsService.ClearAllUserDetails();
				WebAuthenticatorResult val = await AuthenticateViaWeb(codeVerifier);
				string code = ((val != null) ? val.get_Properties()["code"] : null);
				await Task.Run(async delegate
				{
					await GetToken(code, codeVerifier);
				});
				return await CheckAndRefreshToken();
			}
			catch (TaskCanceledException)
			{
				return false;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public virtual async Task<bool> CheckAndRefreshToken()
		{
			return await Task.Run(async delegate
			{
				if (!string.IsNullOrEmpty(SettingsService.AuthRefreshToken))
				{
					if (AccessTokenRequiresRefresh())
					{
						try
						{
							await RefreshToken();
						}
						catch (HttpUnAuthorizedException)
						{
							return false;
						}
						catch (HttpBadFormatException)
						{
							return false;
						}
					}
					return true;
				}
				return false;
			});
		}

		public async Task Logout()
		{
			string payload = "client_id=" + AuthSetting.Instance.ClientId + "&refresh_token=" + SettingsService.AuthRefreshToken;
			await RequestProvider.PostFormAsync(AuthSetting.Instance.LogoutEndpoint, payload, default(CancellationToken), AuthSetting.Instance.ClientId);
			RefreshTokenService.StopTimer();
			SettingsService.ClearAllUserDetails();
		}

		protected static string EncryptCodeChallenge(string codeVerifier)
		{
			using SHA256 sHA = SHA256.Create();
			return Base64Url.Encode(sHA.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier)));
		}

		protected string CreateAuthorizationRequest(string endpoint, string codeVerifier)
		{
			AuthorizeRequest authorizeRequest = new AuthorizeRequest(endpoint);
			Dictionary<string, string> values = new Dictionary<string, string>
			{
				{ "client_id", "sagov-home-quarantine-43130474" },
				{ "redirect_uri", "homequarantine://authorize" },
				{ "response_type", "code" },
				{ "scope", "openid profile offline_access email" },
				{
					"code_challenge",
					EncryptCodeChallenge(codeVerifier)
				},
				{ "code_challenge_method", "S256" }
			};
			return authorizeRequest.Create(values);
		}

		protected virtual async Task<WebAuthenticatorResult> AuthenticateViaWeb(string codeVerifier)
		{
			WebAuthenticatorOptions val = new WebAuthenticatorOptions();
			val.set_Url(new Uri(CreateAuthorizationRequest(AuthSetting.Instance.AuthorizeEndpoint, codeVerifier)));
			val.set_CallbackUrl(new Uri("homequarantine://authorize"));
			val.set_PrefersEphemeralWebBrowserSession(true);
			return await WebAuthenticator.AuthenticateAsync(val);
		}

		protected bool AccessTokenRequiresRefresh()
		{
			return (SettingsService.AuthExpiry - DateTime.Now).TotalSeconds < 10.0;
		}

		protected async Task<UserToken> GetToken(string code, string codeVerifier)
		{
			string text = WebUtility.UrlEncode(AuthSetting.Instance.Callback);
			string payload = string.Format("grant_type=authorization_code&code=" + code + "&redirect_uri=" + text + "&client_id=" + AuthSetting.Instance.ClientId + "&code_verifier=" + codeVerifier);
			UserToken userToken = await RequestProvider.PostFormAsync<UserToken>(AuthSetting.Instance.TokenEndpoint, payload, default(CancellationToken));
			if (userToken != null)
			{
				SetToken(userToken);
				RefreshTokenService.StartTimer(AutoRefresh, userToken.ExpiresIn);
			}
			return userToken;
		}

		public async Task ExplicitlyRefreshToken()
		{
			if (SettingsService.AuthRefreshToken == null)
			{
				throw new HttpUnAuthorizedException("No refresh token available");
			}
			string payload = $"grant_type=refresh_token&refresh_token={SettingsService.AuthRefreshToken}&redirect_uri={WebUtility.UrlEncode(AuthSetting.Instance.Callback)}&client_id={AuthSetting.Instance.ClientId}";
			UserToken userToken = await RequestProvider.PostFormAsync<UserToken>(AuthSetting.Instance.TokenEndpoint, payload, default(CancellationToken));
			if (userToken != null)
			{
				SetToken(userToken);
			}
			await Task.CompletedTask;
		}

		public async Task RefreshToken()
		{
			if (SettingsService.AuthRefreshToken == null)
			{
				return;
			}
			try
			{
				string payload = $"grant_type=refresh_token&refresh_token={SettingsService.AuthRefreshToken}&redirect_uri={WebUtility.UrlEncode(AuthSetting.Instance.Callback)}&client_id={AuthSetting.Instance.ClientId}&scope=offline_access";
				UserToken userToken = await RequestProvider.PostFormAsync<UserToken>(AuthSetting.Instance.TokenEndpoint, payload, default(CancellationToken));
				if (userToken != null)
				{
					SetToken(userToken);
				}
				if (!RefreshTokenService.IsRunning)
				{
					RefreshTokenService.StartTimer(AutoRefresh, userToken.ExpiresIn);
				}
				else
				{
					RefreshTokenService.ResetTimer(userToken.ExpiresIn);
				}
			}
			catch (HttpBadFormatException)
			{
				SettingsService.ClearAllUserDetails();
			}
			catch (HttpUnAuthorizedException)
			{
				SettingsService.ClearAllUserDetails();
			}
		}

		protected async Task<UserInfo> GetUserInfo(string token)
		{
			return await RequestProvider.PostFormAsync<UserInfo>(AuthSetting.Instance.UserInfoEndpoint, null, default(CancellationToken), token);
		}

		private void SetToken(UserToken tokens)
		{
			SettingsService.AuthAccessToken = tokens.AccessToken;
			SettingsService.AuthIdToken = tokens.IdToken;
			SettingsService.AuthRefreshToken = tokens.RefreshToken;
			SettingsService.AuthExpiry = tokens.Expiry.GetValueOrDefault();
		}

		private async Task AutoRefresh()
		{
			await RefreshToken();
		}
	}
}
