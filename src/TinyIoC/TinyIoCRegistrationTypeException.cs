using System;
using System.Runtime.Serialization;

namespace TinyIoC
{
	[Serializable]
	public class TinyIoCRegistrationTypeException : Exception
	{
		private const string REGISTER_ERROR_TEXT = "Cannot register type {0} - abstract classes or interfaces are not valid implementation types for {1}.";

		public TinyIoCRegistrationTypeException(Type type, string factory)
			: base($"Cannot register type {type.FullName} - abstract classes or interfaces are not valid implementation types for {factory}.")
		{
		}

		public TinyIoCRegistrationTypeException(Type type, string factory, Exception innerException)
			: base($"Cannot register type {type.FullName} - abstract classes or interfaces are not valid implementation types for {factory}.", innerException)
		{
		}

		protected TinyIoCRegistrationTypeException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
