using System;
using System.Runtime.Serialization;

namespace TinyIoC
{
	[Serializable]
	public class TinyIoCConstructorResolutionException : Exception
	{
		private const string ERROR_TEXT = "Unable to resolve constructor for {0} using provided Expression.";

		public TinyIoCConstructorResolutionException(Type type)
			: base($"Unable to resolve constructor for {type.FullName} using provided Expression.")
		{
		}

		public TinyIoCConstructorResolutionException(Type type, Exception innerException)
			: base($"Unable to resolve constructor for {type.FullName} using provided Expression.", innerException)
		{
		}

		public TinyIoCConstructorResolutionException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public TinyIoCConstructorResolutionException(string message)
			: base(message)
		{
		}

		protected TinyIoCConstructorResolutionException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
