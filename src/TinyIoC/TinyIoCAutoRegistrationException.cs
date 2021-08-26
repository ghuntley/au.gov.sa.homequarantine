using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TinyIoC
{
	[Serializable]
	public class TinyIoCAutoRegistrationException : Exception
	{
		private const string ERROR_TEXT = "Duplicate implementation of type {0} found ({1}).";

		public TinyIoCAutoRegistrationException(Type registerType, IEnumerable<Type> types)
			: base($"Duplicate implementation of type {registerType} found ({GetTypesString(types)}).")
		{
		}

		public TinyIoCAutoRegistrationException(Type registerType, IEnumerable<Type> types, Exception innerException)
			: base($"Duplicate implementation of type {registerType} found ({GetTypesString(types)}).", innerException)
		{
		}

		protected TinyIoCAutoRegistrationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		private static string GetTypesString(IEnumerable<Type> types)
		{
			IEnumerable<string> source = types.Select((Type type) => type.FullName);
			return string.Join(",", source.ToArray());
		}
	}
}
