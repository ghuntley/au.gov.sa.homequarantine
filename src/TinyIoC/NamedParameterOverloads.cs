using System.Collections.Generic;

namespace TinyIoC
{
	public sealed class NamedParameterOverloads : Dictionary<string, object>
	{
		private static readonly NamedParameterOverloads _Default = new NamedParameterOverloads();

		public static NamedParameterOverloads Default => _Default;

		public static NamedParameterOverloads FromIDictionary(IDictionary<string, object> data)
		{
			return (data as NamedParameterOverloads) ?? new NamedParameterOverloads(data);
		}

		public NamedParameterOverloads()
		{
		}

		public NamedParameterOverloads(IDictionary<string, object> data)
			: base(data)
		{
		}
	}
}
