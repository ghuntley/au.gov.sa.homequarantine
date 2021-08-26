using System;
using System.Runtime.Serialization;

namespace TinyIoC
{
	[Serializable]
	public class TinyIoCWeakReferenceException : Exception
	{
		private const string ERROR_TEXT = "Unable to instantiate {0} - referenced object has been reclaimed";

		public TinyIoCWeakReferenceException(Type type)
			: base($"Unable to instantiate {type.FullName} - referenced object has been reclaimed")
		{
		}

		public TinyIoCWeakReferenceException(Type type, Exception innerException)
			: base($"Unable to instantiate {type.FullName} - referenced object has been reclaimed", innerException)
		{
		}

		protected TinyIoCWeakReferenceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
