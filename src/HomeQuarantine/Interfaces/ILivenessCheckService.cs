namespace HomeQuarantine.Interfaces
{
	public interface ILivenessCheckService
	{
		void Launch(string token, ILivenessCheckCallback callback);
	}
}
