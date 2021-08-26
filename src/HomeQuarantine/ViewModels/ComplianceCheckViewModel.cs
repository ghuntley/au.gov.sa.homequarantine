using System;
using System.Threading.Tasks;
using HomeQuarantine.Data.Enums;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Extensions;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.ApiService;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Experience;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.Settings;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels
{
	public class ComplianceCheckViewModel : ViewModelBase, ILivenessCheckCallback
	{
		private readonly INavigationService navigationService;

		private readonly ISettingsService settingsService;

		private readonly IDependencyService dependencyService;

		private readonly IApiService apiService;

		private double progress;

		private ComplianceCheckType pageType;

		private string facialVerificationToken;

		public ComplianceCheckType PageType
		{
			get
			{
				return pageType;
			}
			set
			{
				pageType = value;
				RaisePropertyChanged(() => PageType);
			}
		}

		public double Progress
		{
			get
			{
				return progress;
			}
			set
			{
				progress = value;
				RaisePropertyChanged(() => Progress);
				RaisePropertyChanged(() => IsInProgress);
			}
		}

		public bool IsInProgress { get; set; }

		public IAsyncCommand StartLivenessCheckCommand => new AsyncCommand(async delegate
		{
			await SingleRunAsync(async delegate
			{
				await StartLivenessCheck();
			});
		});

		public ComplianceCheckViewModel(INavigationService navigationService, ISettingsService settingsService, IDependencyService dependencyService, IApiService apiService)
		{
			this.navigationService = navigationService;
			this.settingsService = settingsService;
			this.dependencyService = dependencyService;
			this.apiService = apiService;
		}

		public void Connecting()
		{
		}

		public void Connected()
		{
			base.IsBusy = true;
		}

		public void Cancelled()
		{
			ResetState();
		}

		public void Processing(double progress)
		{
			SetBusyStatus(isBusy: true, Resources.ComplianceCheckView_VerifyingScan);
			Progress = progress;
			IsInProgress = true;
		}

		public async void Success()
		{
			ResetState();
			await SubmitComplianceCheck();
		}

		public async void Failure(string feedbackCode)
		{
			ResetState();
			if (feedbackCode == IProovFailCode.AmbiguousOutcome.GetDescription())
			{
				await SubmitComplianceCheck();
				return;
			}
			string failureReason = GetFailureReason(feedbackCode);
			await Application.get_Current().get_MainPage().DisplayAlert(Resources.LivenessCheckView_PleaseTryAgain, failureReason, Resources.Button_Ok);
		}

		public void Error()
		{
			ResetState();
		}

		private async Task StartLivenessCheck()
		{
			SetBusyStatus(isBusy: true, Resources.ComplianceCheckView_StartingScan);
			await apiService.CallApi(new GetIProovTokenApiAction(), delegate(IProovTokenResponse facialVerificationToken)
			{
				this.facialVerificationToken = facialVerificationToken.Token;
				dependencyService.Get<ILivenessCheckService>().Launch(facialVerificationToken.Token, this);
				return Task.CompletedTask;
			}, HandleComplianceCheckError);
		}

		private async Task HandleComplianceCheckError(Exception exception)
		{
			ClearBusyStatus();
			await apiService.ShowGeneralError(App.Constants.LocationCheckInErrorHandlingPage, StartLivenessCheck);
		}

		private void ResetState()
		{
			Progress = 0.0;
			IsInProgress = false;
			ClearBusyStatus();
		}

		private string GetFailureReason(string feedbackCode)
		{
			if (feedbackCode == IProovFailCode.Backlit.GetDescription())
			{
				return Resources.LivenessCheckView_Backlit;
			}
			if (feedbackCode == IProovFailCode.BrightnessTooLow.GetDescription())
			{
				return Resources.LivenessCheckView_BrightnessTooLow;
			}
			if (feedbackCode == IProovFailCode.FaceTooBright.GetDescription())
			{
				return Resources.LivenessCheckView_FaceTooBright;
			}
			if (feedbackCode == IProovFailCode.TooDark.GetDescription())
			{
				return Resources.LivenessCheckView_TooDark;
			}
			if (feedbackCode == IProovFailCode.TooMuchMouthMovement.GetDescription())
			{
				return Resources.LivenessCheckView_TooMuchMouthMovement;
			}
			if (feedbackCode == IProovFailCode.TooMuchMovement.GetDescription())
			{
				return Resources.LivenessCheckView_TooMuchMovement;
			}
			return Resources.LivenessCheckView_UnknownFailureReason;
		}

		private async Task SubmitComplianceCheck()
		{
			SetBusyStatus(isBusy: true, Resources.ComplianceCheckView_CheckingIn);
			Location val = await Geolocation.GetLocationAsync(new GeolocationRequest((GeolocationAccuracy)5));
			await apiService.CallApi(new SubmitComplianceCheckApiAction(new ComplianceCheck
			{
				PushHandle = settingsService.NotificationsRegistrationToken,
				Accuracy = val.get_Accuracy(),
				Latitude = val.get_Latitude(),
				Longitude = val.get_Longitude(),
				IsMock = val.get_IsFromMockProvider(),
				FacialVerificationToken = facialVerificationToken
			}), null, HandleComplianceCheckError);
			await navigationService.NavigateToAsync<ComplianceCheckSuccessfulViewModel>();
		}
	}
}
