using System;
using System.Runtime.Serialization;

namespace TinyIoC
{
	[Serializable]
	public class TinyIoCRegistrationException : Exception
	{
		private const string CONVERT_ERROR_TEXT = "Cannot convert current registration of {0} to {1}";

		private const string GENERIC_CONSTRAINT_ERROR_TEXT = "Type {1} is not valid for a registration of type {0}";

		public TinyIoCRegistrationException(Type type, string method)
			: base($"Cannot convert current registration of {type.FullName} to {method}")
		{
		}

		public TinyIoCRegistrationException(Type type, string method, Exception innerException)
			: base($"Cannot convert current registration of {type.FullName} to {method}", innerException)
		{
		}

		public TinyIoCRegistrationException(Type registerType, Type implementationType)
			: base(string.Format("Type {1} is not valid for a registration of type {0}", registerType.FullName, implementationType.FullName))
		{
		}

		public TinyIoCRegistrationException(Type registerType, Type implementationType, Exception innerException)
			: base(string.Format("Type {1} is not valid for a registration of type {0}", registerType.FullName, implementationType.FullName), innerException)
		{
		}

		protected TinyIoCRegistrationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
