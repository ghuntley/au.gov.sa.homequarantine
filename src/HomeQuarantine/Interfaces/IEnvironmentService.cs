namespace HomeQuarantine.Interfaces
{
	public interface IEnvironmentService
	{
		string GetVersionString();

		string GetVersionNumber();

		string GetDeviceType();

		void CloseApplication();
	}
}
