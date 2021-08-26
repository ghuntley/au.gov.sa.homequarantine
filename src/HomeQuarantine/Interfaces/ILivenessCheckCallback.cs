namespace HomeQuarantine.Interfaces
{
	public interface ILivenessCheckCallback
	{
		void Connecting();

		void Connected();

		void Cancelled();

		void Processing(double progress);

		void Success();

		void Failure(string feedbackCode);

		void Error();
	}
}
