using System;
using System.Runtime.Serialization;

namespace TinyIoC
{
	[Serializable]
	public class TinyIoCResolutionException : Exception
	{
		private const string ERROR_TEXT = "Unable to resolve type: {0}";

		public TinyIoCResolutionException(Type type)
			: base($"Unable to resolve type: {type.FullName}")
		{
		}

		public TinyIoCResolutionException(Type type, Exception innerException)
			: base($"Unable to resolve type: {type.FullName}", innerException)
		{
		}

		protected TinyIoCResolutionException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
