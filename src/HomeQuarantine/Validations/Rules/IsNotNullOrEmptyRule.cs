using System;

namespace HomeQuarantine.Validations.Rules
{
	public class IsNotNullOrEmptyRule<T> : IValidationRule<T>
	{
		public string ValidationMessage { get; set; }

		public bool Check(T value)
		{
			if (value == null)
			{
				return false;
			}
			if (value is DateTime)
			{
				return true;
			}
			return !string.IsNullOrWhiteSpace(value as string);
		}
	}
}
