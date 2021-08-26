using System.Threading.Tasks;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.ViewModels;

namespace HomeQuarantine.Services.ComplianceCheck
{
	public class ComplianceCheckService : IComplianceCheckService
	{
		private readonly IApiService apiService;

		private readonly INavigationService navigationService;

		public ComplianceCheckService(IApiService apiService, INavigationService navigationService)
		{
			this.apiService = apiService;
			this.navigationService = navigationService;
		}

		public async Task ShowComplianceCheck()
		{
			await apiService.CallApi(new GetComplianceCheckWindowApiAction(), async delegate(bool isInComplianceCheckWindow)
			{
				if (isInComplianceCheckWindow)
				{
					await navigationService.PushModalAsync<ComplianceCheckViewModel>();
				}
				else
				{
					await navigationService.PushModalAsync(null, App.Constants.ComplianceCheckNotDuePage);
				}
			}, async delegate
			{
				await apiService.ShowGeneralError(App.Constants.ConnectionErrorHandlingPage, ShowComplianceCheck);
			});
		}
	}
}
