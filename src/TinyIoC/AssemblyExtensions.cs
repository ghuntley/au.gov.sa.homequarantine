using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TinyIoC
{
	public static class AssemblyExtensions
	{
		public static Type[] SafeGetTypes(this Assembly assembly)
		{
			try
			{
				return assembly.GetTypes();
			}
			catch (FileNotFoundException)
			{
				return new Type[0];
			}
			catch (NotSupportedException)
			{
				return new Type[0];
			}
			catch (ReflectionTypeLoadException ex3)
			{
				return ex3.Types.Where((Type t) => t != null).ToArray();
			}
		}
	}
}
