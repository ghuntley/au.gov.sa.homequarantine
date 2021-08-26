using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeQuarantine.Services.Language;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels.Base
{
	public abstract class ViewModelBase : ExtendedBindableObject
	{
		private readonly ILanguageService languageService;

		private bool isBusy;

		private string busyMessage;

		private bool isRunning;

		public ILanguageService Strings => languageService;

		public bool IsBusy
		{
			get
			{
				return isBusy;
			}
			set
			{
				isBusy = value;
				RaisePropertyChanged(() => IsBusy);
			}
		}

		public string BusyMessage
		{
			get
			{
				return busyMessage;
			}
			set
			{
				busyMessage = value;
				RaisePropertyChanged(() => BusyMessage);
			}
		}

		public ViewModelBase()
		{
			languageService = ViewModelLocator.Resolve<ILanguageService>();
		}

		public virtual Task InitializeAsync(object navigationData)
		{
			return Task.FromResult(result: false);
		}

		protected async Task SingleRunAsync(Func<Task> operation)
		{
			if (!isRunning)
			{
				isRunning = true;
				await CatchExceptions(operation);
				isRunning = false;
			}
		}

		protected async Task CatchExceptions(Func<Task> operation)
		{
			try
			{
				await operation();
			}
			catch (Exception ex)
			{
				Device.BeginInvokeOnMainThread((Action)async delegate
				{
					await Application.get_Current().get_MainPage().DisplayAlert("Unknown error", "An unknown error has occurred.", "OK");
				});
				Crashes.TrackError(ex, (IDictionary<string, string>)null, Array.Empty<ErrorAttachmentLog>());
			}
		}

		protected void SetBusyStatus(bool isBusy, string message)
		{
			IsBusy = isBusy;
			BusyMessage = message;
		}

		protected void ClearBusyStatus()
		{
			IsBusy = false;
			BusyMessage = string.Empty;
		}
	}
}
