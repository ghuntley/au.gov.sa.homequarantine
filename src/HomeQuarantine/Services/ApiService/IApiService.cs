using System;
using System.Threading.Tasks;
using HomeQuarantine.ViewModels;

namespace HomeQuarantine.Services.ApiService
{
	public interface IApiService
	{
		Task CallApi<TResult>(IApiAction<TResult> call, Func<TResult, Task> onSuccess = null, Func<Exception, Task> onError = null);

		Task ShowGeneralError(ErrorViewModel errorView, Func<Task> handler = null);
	}
}
