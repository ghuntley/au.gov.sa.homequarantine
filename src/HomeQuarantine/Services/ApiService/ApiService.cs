using System;
using System.Threading.Tasks;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Identity;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.RequestProvider;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.ViewModels;

namespace HomeQuarantine.Services.ApiService
{
	public class ApiService : IApiService
	{
		private readonly IRequestProvider requestProvider;

		private readonly ISettingsService settingsService;

		private readonly IIdentityService identityService;

		private readonly INavigationService navigationService;

		public ApiService(IRequestProvider requestProvider, ISettingsService settingsService, IIdentityService identityService, INavigationService navigationService)
		{
			this.requestProvider = requestProvider;
			this.settingsService = settingsService;
			this.identityService = identityService;
			this.navigationService = navigationService;
		}

		public async Task CallApi<T>(IApiAction<T> call, Func<T, Task> callback, Func<Exception, Task> errorCallback)
		{
			Exception e;
			await Task.Run(async delegate
			{
				try
				{
					await WrapCall(call, callback);
				}
				catch (HttpUnAuthorizedException)
				{
					await navigationService.NavigateToAsync<LoginViewModel>();
				}
				catch (HttpBadFormatException)
				{
					await navigationService.NavigateToAsync<LoginViewModel>();
				}
				catch (Exception ex3)
				{
					e = ex3;
					ErrorViewModel connectionErrorHandlingPage = App.Constants.ConnectionErrorHandlingPage;
					connectionErrorHandlingPage.PerformWorkCommand = new AsyncCommand(async delegate
					{
						if (errorCallback != null)
						{
							await errorCallback(e);
						}
					});
					await navigationService.PushSingleErrorModal(null, connectionErrorHandlingPage);
				}
			});
		}

		public async Task ShowGeneralError(ErrorViewModel errorView, Func<Task> handler = null)
		{
			errorView.PerformWorkCommand = new AsyncCommand(async delegate
			{
				if (handler != null)
				{
					await handler();
				}
			});
			await navigationService.PushSingleErrorModal(null, errorView);
		}

		private async Task WrapCall<T>(IApiAction<T> call, Func<T, Task> callback)
		{
			try
			{
				T arg = await call.DoApiAction(requestProvider, settingsService.AuthAccessToken);
				if (callback != null)
				{
					await callback(arg);
				}
			}
			catch (HttpUnAuthorizedException)
			{
				await identityService.ExplicitlyRefreshToken();
				T arg2 = await call.DoApiAction(requestProvider, settingsService.AuthAccessToken);
				if (callback != null)
				{
					await callback(arg2);
				}
			}
		}
	}
}
