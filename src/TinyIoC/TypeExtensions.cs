using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TinyIoC
{
	public static class TypeExtensions
	{
		private sealed class GenericMethodCacheKey
		{
			private readonly Type _sourceType;

			private readonly string _methodName;

			private readonly Type[] _genericTypes;

			private readonly Type[] _parameterTypes;

			private readonly int _hashCode;

			public GenericMethodCacheKey(Type sourceType, string methodName, Type[] genericTypes, Type[] parameterTypes)
			{
				_sourceType = sourceType;
				_methodName = methodName;
				_genericTypes = genericTypes;
				_parameterTypes = parameterTypes;
				_hashCode = GenerateHashCode();
			}

			public override bool Equals(object obj)
			{
				GenericMethodCacheKey genericMethodCacheKey = obj as GenericMethodCacheKey;
				if (genericMethodCacheKey == null)
				{
					return false;
				}
				if (_sourceType != genericMethodCacheKey._sourceType)
				{
					return false;
				}
				if (!string.Equals(_methodName, genericMethodCacheKey._methodName, StringComparison.Ordinal))
				{
					return false;
				}
				if (_genericTypes.Length != genericMethodCacheKey._genericTypes.Length)
				{
					return false;
				}
				if (_parameterTypes.Length != genericMethodCacheKey._parameterTypes.Length)
				{
					return false;
				}
				for (int i = 0; i < _genericTypes.Length; i++)
				{
					if (_genericTypes[i] != genericMethodCacheKey._genericTypes[i])
					{
						return false;
					}
				}
				for (int j = 0; j < _parameterTypes.Length; j++)
				{
					if (_parameterTypes[j] != genericMethodCacheKey._parameterTypes[j])
					{
						return false;
					}
				}
				return true;
			}

			public override int GetHashCode()
			{
				return _hashCode;
			}

			private int GenerateHashCode()
			{
				int hashCode = _sourceType.GetHashCode();
				hashCode = (hashCode * 397) ^ _methodName.GetHashCode();
				for (int i = 0; i < _genericTypes.Length; i++)
				{
					hashCode = (hashCode * 397) ^ _genericTypes[i].GetHashCode();
				}
				for (int j = 0; j < _parameterTypes.Length; j++)
				{
					hashCode = (hashCode * 397) ^ _parameterTypes[j].GetHashCode();
				}
				return hashCode;
			}
		}

		private static SafeDictionary<GenericMethodCacheKey, MethodInfo> _genericMethodCache;

		static TypeExtensions()
		{
			_genericMethodCache = new SafeDictionary<GenericMethodCacheKey, MethodInfo>();
		}

		public static MethodInfo GetGenericMethod(this Type sourceType, BindingFlags bindingFlags, string methodName, Type[] genericTypes, Type[] parameterTypes)
		{
			GenericMethodCacheKey key = new GenericMethodCacheKey(sourceType, methodName, genericTypes, parameterTypes);
			if (!_genericMethodCache.TryGetValue(key, out var value))
			{
				value = GetMethod(sourceType, bindingFlags, methodName, genericTypes, parameterTypes);
				_genericMethodCache[key] = value;
			}
			return value;
		}

		private static MethodInfo GetMethod(Type sourceType, BindingFlags bindingFlags, string methodName, Type[] genericTypes, Type[] parameterTypes)
		{
			List<MethodInfo> list = (from mi in sourceType.GetMethods(bindingFlags)
				where string.Equals(methodName, mi.Name, StringComparison.Ordinal)
				where mi.ContainsGenericParameters
				where mi.GetGenericArguments().Length == genericTypes.Length
				where mi.GetParameters().Length == parameterTypes.Length
				select mi.MakeGenericMethod(genericTypes) into mi
				where (from pi in mi.GetParameters()
					select pi.ParameterType).SequenceEqual<Type>(parameterTypes)
				select mi).ToList();
			if (list.Count > 1)
			{
				throw new AmbiguousMatchException();
			}
			return list.FirstOrDefault();
		}
	}
}
