using System.Collections.Generic;
using System.Linq;
using HomeQuarantine.ViewModels.Base;

namespace HomeQuarantine.Validations
{
	public class ValidatableObject<T> : ExtendedBindableObject, IValidity
	{
		private readonly List<IValidationRule<T>> _validations;

		private List<string> _errors;

		private T _value;

		private bool _isValid;

		public List<IValidationRule<T>> Validations => _validations;

		public List<string> Errors
		{
			get
			{
				return _errors;
			}
			set
			{
				_errors = value;
				RaisePropertyChanged(() => Errors);
			}
		}

		public T Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
				RaisePropertyChanged(() => Value);
			}
		}

		public bool IsValid
		{
			get
			{
				return _isValid;
			}
			set
			{
				_isValid = value;
				RaisePropertyChanged(() => IsValid);
			}
		}

		public ValidatableObject()
		{
			_isValid = true;
			_errors = new List<string>();
			_validations = new List<IValidationRule<T>>();
		}

		public ValidatableObject(T value)
		{
			_isValid = true;
			_errors = new List<string>();
			_value = value;
			_validations = new List<IValidationRule<T>>();
		}

		public bool Validate()
		{
			Errors.Clear();
			IEnumerable<string> source = from v in _validations
				where !v.Check(Value)
				select v.ValidationMessage;
			Errors = source.ToList();
			IsValid = !Errors.Any();
			return IsValid;
		}
	}
}
