using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeQuarantine.Helpers
{
	public static class ErrorHelper
	{
		private static readonly IDictionary<ErrorType, ErrorStrings> Errors = new Dictionary<ErrorType, ErrorStrings>();

		private static bool initialized = false;

		public static void InitErrors()
		{
			if (!initialized)
			{
				Errors[ErrorType.Login] = new ErrorStrings
				{
					Title = "Could not log in",
					Text = "An error occurred while signing you in."
				};
				Errors[ErrorType.BarringStatusCheck] = new ErrorStrings
				{
					Title = "Barring Status Check Failed",
					Text = "An error occurred while checking the barring status."
				};
				initialized = true;
			}
		}

		public static async Task Error(ErrorType error, Exception e = null)
		{
			InitErrors();
			if (Errors.ContainsKey(error))
			{
				ErrorStrings errorStrings = Errors[error];
				await Application.get_Current().get_MainPage().DisplayAlert(errorStrings.Title, errorStrings.Text, errorStrings.Button);
				_ = e;
			}
		}
	}
}
