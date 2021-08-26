using System;
using System.Text;

namespace HomeQuarantine.Helpers
{
	public class UrlBuilder
	{
		private bool isFirst;

		private StringBuilder builder;

		public UrlBuilder(string baseUrl)
		{
			builder = new StringBuilder(baseUrl);
			isFirst = true;
		}

		public UrlBuilder AddDate(string name, DateTime? data)
		{
			if (data.HasValue)
			{
				return Add(name, data.Value.ToString("O"));
			}
			return this;
		}

		public UrlBuilder AddInt(string name, int? data)
		{
			if (data.HasValue)
			{
				return Add(name, data.ToString());
			}
			return this;
		}

		public UrlBuilder Add(string name, string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return this;
			}
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException("name", "The name must not be null");
			}
			builder.Append(isFirst ? "?" : "&");
			isFirst = false;
			builder.Append(name + "=" + value);
			return this;
		}

		public string Build()
		{
			return builder.ToString();
		}
	}
}
