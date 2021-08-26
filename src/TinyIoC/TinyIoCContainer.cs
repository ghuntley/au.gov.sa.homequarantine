using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace TinyIoC
{
	public sealed class TinyIoCContainer : IDisposable
	{
		public sealed class RegisterOptions
		{
			private TinyIoCContainer _Container;

			private TypeRegistration _Registration;

			public RegisterOptions(TinyIoCContainer container, TypeRegistration registration)
			{
				_Container = container;
				_Registration = registration;
			}

			public RegisterOptions AsSingleton()
			{
				ObjectFactoryBase currentFactory = _Container.GetCurrentFactory(_Registration);
				if (currentFactory == null)
				{
					throw new TinyIoCRegistrationException(_Registration.Type, "singleton");
				}
				return _Container.AddUpdateRegistration(_Registration, currentFactory.SingletonVariant);
			}

			public RegisterOptions AsMultiInstance()
			{
				ObjectFactoryBase currentFactory = _Container.GetCurrentFactory(_Registration);
				if (currentFactory == null)
				{
					throw new TinyIoCRegistrationException(_Registration.Type, "multi-instance");
				}
				return _Container.AddUpdateRegistration(_Registration, currentFactory.MultiInstanceVariant);
			}

			public RegisterOptions WithWeakReference()
			{
				ObjectFactoryBase currentFactory = _Container.GetCurrentFactory(_Registration);
				if (currentFactory == null)
				{
					throw new TinyIoCRegistrationException(_Registration.Type, "weak reference");
				}
				return _Container.AddUpdateRegistration(_Registration, currentFactory.WeakReferenceVariant);
			}

			public RegisterOptions WithStrongReference()
			{
				ObjectFactoryBase currentFactory = _Container.GetCurrentFactory(_Registration);
				if (currentFactory == null)
				{
					throw new TinyIoCRegistrationException(_Registration.Type, "strong reference");
				}
				return _Container.AddUpdateRegistration(_Registration, currentFactory.StrongReferenceVariant);
			}

			public RegisterOptions UsingConstructor<RegisterType>(Expression<Func<RegisterType>> constructor)
			{
				ConstructorInfo constructor2 = (((constructor ?? throw new TinyIoCConstructorResolutionException(typeof(RegisterType))).Body as NewExpression) ?? throw new TinyIoCConstructorResolutionException(typeof(RegisterType))).Constructor;
				if (constructor2 == null)
				{
					throw new TinyIoCConstructorResolutionException(typeof(RegisterType));
				}
				(_Container.GetCurrentFactory(_Registration) ?? throw new TinyIoCConstructorResolutionException(typeof(RegisterType))).SetConstructor(constructor2);
				return this;
			}

			public static RegisterOptions ToCustomLifetimeManager(RegisterOptions instance, ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
			{
				if (instance == null)
				{
					throw new ArgumentNullException("instance", "instance is null.");
				}
				if (lifetimeProvider == null)
				{
					throw new ArgumentNullException("lifetimeProvider", "lifetimeProvider is null.");
				}
				if (string.IsNullOrEmpty(errorString))
				{
					throw new ArgumentException("errorString is null or empty.", "errorString");
				}
				ObjectFactoryBase currentFactory = instance._Container.GetCurrentFactory(instance._Registration);
				if (currentFactory == null)
				{
					throw new TinyIoCRegistrationException(instance._Registration.Type, errorString);
				}
				return instance._Container.AddUpdateRegistration(instance._Registration, currentFactory.GetCustomObjectLifetimeVariant(lifetimeProvider, errorString));
			}
		}

		public sealed class MultiRegisterOptions
		{
			private IEnumerable<RegisterOptions> _RegisterOptions;

			public MultiRegisterOptions(IEnumerable<RegisterOptions> registerOptions)
			{
				_RegisterOptions = registerOptions;
			}

			public MultiRegisterOptions AsSingleton()
			{
				_RegisterOptions = ExecuteOnAllRegisterOptions((RegisterOptions ro) => ro.AsSingleton());
				return this;
			}

			public MultiRegisterOptions AsMultiInstance()
			{
				_RegisterOptions = ExecuteOnAllRegisterOptions((RegisterOptions ro) => ro.AsMultiInstance());
				return this;
			}

			public static MultiRegisterOptions ToCustomLifetimeManager(MultiRegisterOptions instance, ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
			{
				if (instance == null)
				{
					throw new ArgumentNullException("instance", "instance is null.");
				}
				if (lifetimeProvider == null)
				{
					throw new ArgumentNullException("lifetimeProvider", "lifetimeProvider is null.");
				}
				if (string.IsNullOrEmpty(errorString))
				{
					throw new ArgumentException("errorString is null or empty.", "errorString");
				}
				instance._RegisterOptions = instance.ExecuteOnAllRegisterOptions((RegisterOptions ro) => RegisterOptions.ToCustomLifetimeManager(ro, lifetimeProvider, errorString));
				return instance;
			}

			private IEnumerable<RegisterOptions> ExecuteOnAllRegisterOptions(Func<RegisterOptions, RegisterOptions> action)
			{
				List<RegisterOptions> list = new List<RegisterOptions>();
				foreach (RegisterOptions registerOption in _RegisterOptions)
				{
					list.Add(action(registerOption));
				}
				return list;
			}
		}

		public interface ITinyIoCObjectLifetimeProvider
		{
			object GetObject();

			void SetObject(object value);

			void ReleaseObject();
		}

		private abstract class ObjectFactoryBase
		{
			public virtual bool AssumeConstruction => false;

			public abstract Type CreatesType { get; }

			public ConstructorInfo Constructor { get; protected set; }

			public virtual ObjectFactoryBase SingletonVariant
			{
				get
				{
					throw new TinyIoCRegistrationException(GetType(), "singleton");
				}
			}

			public virtual ObjectFactoryBase MultiInstanceVariant
			{
				get
				{
					throw new TinyIoCRegistrationException(GetType(), "multi-instance");
				}
			}

			public virtual ObjectFactoryBase StrongReferenceVariant
			{
				get
				{
					throw new TinyIoCRegistrationException(GetType(), "strong reference");
				}
			}

			public virtual ObjectFactoryBase WeakReferenceVariant
			{
				get
				{
					throw new TinyIoCRegistrationException(GetType(), "weak reference");
				}
			}

			public abstract object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options);

			public virtual ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
			{
				throw new TinyIoCRegistrationException(GetType(), errorString);
			}

			public virtual void SetConstructor(ConstructorInfo constructor)
			{
				Constructor = constructor;
			}

			public virtual ObjectFactoryBase GetFactoryForChildContainer(Type type, TinyIoCContainer parent, TinyIoCContainer child)
			{
				return this;
			}
		}

		private class MultiInstanceFactory : ObjectFactoryBase
		{
			private readonly Type registerType;

			private readonly Type registerImplementation;

			public override Type CreatesType => registerImplementation;

			public override ObjectFactoryBase SingletonVariant => new SingletonFactory(registerType, registerImplementation);

			public override ObjectFactoryBase MultiInstanceVariant => this;

			public MultiInstanceFactory(Type registerType, Type registerImplementation)
			{
				if (registerImplementation.IsAbstract() || registerImplementation.IsInterface())
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "MultiInstanceFactory");
				}
				if (!IsValidAssignment(registerType, registerImplementation))
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "MultiInstanceFactory");
				}
				this.registerType = registerType;
				this.registerImplementation = registerImplementation;
			}

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				try
				{
					return container.ConstructType(requestedType, registerImplementation, base.Constructor, parameters, options);
				}
				catch (TinyIoCResolutionException innerException)
				{
					throw new TinyIoCResolutionException(registerType, innerException);
				}
			}

			public override ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
			{
				return new CustomObjectLifetimeFactory(registerType, registerImplementation, lifetimeProvider, errorString);
			}
		}

		private class DelegateFactory : ObjectFactoryBase
		{
			private readonly Type registerType;

			private Func<TinyIoCContainer, NamedParameterOverloads, object> _factory;

			public override bool AssumeConstruction => true;

			public override Type CreatesType => registerType;

			public override ObjectFactoryBase WeakReferenceVariant => new WeakDelegateFactory(registerType, _factory);

			public override ObjectFactoryBase StrongReferenceVariant => this;

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				try
				{
					return _factory(container, parameters);
				}
				catch (Exception innerException)
				{
					throw new TinyIoCResolutionException(registerType, innerException);
				}
			}

			public DelegateFactory(Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory)
			{
				if (factory == null)
				{
					throw new ArgumentNullException("factory");
				}
				_factory = factory;
				this.registerType = registerType;
			}

			public override void SetConstructor(ConstructorInfo constructor)
			{
				throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for delegate factory registrations");
			}
		}

		private class WeakDelegateFactory : ObjectFactoryBase
		{
			private readonly Type registerType;

			private WeakReference _factory;

			public override bool AssumeConstruction => true;

			public override Type CreatesType => registerType;

			public override ObjectFactoryBase StrongReferenceVariant
			{
				get
				{
					Func<TinyIoCContainer, NamedParameterOverloads, object> func = _factory.Target as Func<TinyIoCContainer, NamedParameterOverloads, object>;
					if (func == null)
					{
						throw new TinyIoCWeakReferenceException(registerType);
					}
					return new DelegateFactory(registerType, func);
				}
			}

			public override ObjectFactoryBase WeakReferenceVariant => this;

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				Func<TinyIoCContainer, NamedParameterOverloads, object> func = _factory.Target as Func<TinyIoCContainer, NamedParameterOverloads, object>;
				if (func == null)
				{
					throw new TinyIoCWeakReferenceException(registerType);
				}
				try
				{
					return func(container, parameters);
				}
				catch (Exception innerException)
				{
					throw new TinyIoCResolutionException(registerType, innerException);
				}
			}

			public WeakDelegateFactory(Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory)
			{
				if (factory == null)
				{
					throw new ArgumentNullException("factory");
				}
				_factory = new WeakReference(factory);
				this.registerType = registerType;
			}

			public override void SetConstructor(ConstructorInfo constructor)
			{
				throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for delegate factory registrations");
			}
		}

		private class InstanceFactory : ObjectFactoryBase, IDisposable
		{
			private readonly Type registerType;

			private readonly Type registerImplementation;

			private object _instance;

			public override bool AssumeConstruction => true;

			public override Type CreatesType => registerImplementation;

			public override ObjectFactoryBase MultiInstanceVariant => new MultiInstanceFactory(registerType, registerImplementation);

			public override ObjectFactoryBase WeakReferenceVariant => new WeakInstanceFactory(registerType, registerImplementation, _instance);

			public override ObjectFactoryBase StrongReferenceVariant => this;

			public InstanceFactory(Type registerType, Type registerImplementation, object instance)
			{
				if (!IsValidAssignment(registerType, registerImplementation))
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "InstanceFactory");
				}
				this.registerType = registerType;
				this.registerImplementation = registerImplementation;
				_instance = instance;
			}

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				return _instance;
			}

			public override void SetConstructor(ConstructorInfo constructor)
			{
				throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for instance factory registrations");
			}

			public void Dispose()
			{
				(_instance as IDisposable)?.Dispose();
			}
		}

		private class WeakInstanceFactory : ObjectFactoryBase, IDisposable
		{
			private readonly Type registerType;

			private readonly Type registerImplementation;

			private readonly WeakReference _instance;

			public override Type CreatesType => registerImplementation;

			public override ObjectFactoryBase MultiInstanceVariant => new MultiInstanceFactory(registerType, registerImplementation);

			public override ObjectFactoryBase WeakReferenceVariant => this;

			public override ObjectFactoryBase StrongReferenceVariant
			{
				get
				{
					object target = _instance.Target;
					if (target == null)
					{
						throw new TinyIoCWeakReferenceException(registerType);
					}
					return new InstanceFactory(registerType, registerImplementation, target);
				}
			}

			public WeakInstanceFactory(Type registerType, Type registerImplementation, object instance)
			{
				if (!IsValidAssignment(registerType, registerImplementation))
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "WeakInstanceFactory");
				}
				this.registerType = registerType;
				this.registerImplementation = registerImplementation;
				_instance = new WeakReference(instance);
			}

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				return _instance.Target ?? throw new TinyIoCWeakReferenceException(registerType);
			}

			public override void SetConstructor(ConstructorInfo constructor)
			{
				throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for instance factory registrations");
			}

			public void Dispose()
			{
				(_instance.Target as IDisposable)?.Dispose();
			}
		}

		private class SingletonFactory : ObjectFactoryBase, IDisposable
		{
			private readonly Type registerType;

			private readonly Type registerImplementation;

			private readonly object SingletonLock = new object();

			private object _Current;

			public override Type CreatesType => registerImplementation;

			public override ObjectFactoryBase SingletonVariant => this;

			public override ObjectFactoryBase MultiInstanceVariant => new MultiInstanceFactory(registerType, registerImplementation);

			public SingletonFactory(Type registerType, Type registerImplementation)
			{
				if (registerImplementation.IsAbstract() || registerImplementation.IsInterface())
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "SingletonFactory");
				}
				if (!IsValidAssignment(registerType, registerImplementation))
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "SingletonFactory");
				}
				this.registerType = registerType;
				this.registerImplementation = registerImplementation;
			}

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				if (parameters.Count != 0)
				{
					throw new ArgumentException("Cannot specify parameters for singleton types");
				}
				lock (SingletonLock)
				{
					if (_Current == null)
					{
						_Current = container.ConstructType(requestedType, registerImplementation, base.Constructor, options);
					}
				}
				return _Current;
			}

			public override ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
			{
				return new CustomObjectLifetimeFactory(registerType, registerImplementation, lifetimeProvider, errorString);
			}

			public override ObjectFactoryBase GetFactoryForChildContainer(Type type, TinyIoCContainer parent, TinyIoCContainer child)
			{
				GetObject(type, parent, NamedParameterOverloads.Default, ResolveOptions.Default);
				return this;
			}

			public void Dispose()
			{
				if (_Current != null)
				{
					(_Current as IDisposable)?.Dispose();
				}
			}
		}

		private class CustomObjectLifetimeFactory : ObjectFactoryBase, IDisposable
		{
			private readonly object SingletonLock = new object();

			private readonly Type registerType;

			private readonly Type registerImplementation;

			private readonly ITinyIoCObjectLifetimeProvider _LifetimeProvider;

			public override Type CreatesType => registerImplementation;

			public override ObjectFactoryBase SingletonVariant
			{
				get
				{
					_LifetimeProvider.ReleaseObject();
					return new SingletonFactory(registerType, registerImplementation);
				}
			}

			public override ObjectFactoryBase MultiInstanceVariant
			{
				get
				{
					_LifetimeProvider.ReleaseObject();
					return new MultiInstanceFactory(registerType, registerImplementation);
				}
			}

			public CustomObjectLifetimeFactory(Type registerType, Type registerImplementation, ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorMessage)
			{
				if (lifetimeProvider == null)
				{
					throw new ArgumentNullException("lifetimeProvider", "lifetimeProvider is null.");
				}
				if (!IsValidAssignment(registerType, registerImplementation))
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, "SingletonFactory");
				}
				if (registerImplementation.IsAbstract() || registerImplementation.IsInterface())
				{
					throw new TinyIoCRegistrationTypeException(registerImplementation, errorMessage);
				}
				this.registerType = registerType;
				this.registerImplementation = registerImplementation;
				_LifetimeProvider = lifetimeProvider;
			}

			public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
			{
				lock (SingletonLock)
				{
					object @object = _LifetimeProvider.GetObject();
					if (@object == null)
					{
						@object = container.ConstructType(requestedType, registerImplementation, base.Constructor, options);
						_LifetimeProvider.SetObject(@object);
						return @object;
					}
					return @object;
				}
			}

			public override ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
			{
				_LifetimeProvider.ReleaseObject();
				return new CustomObjectLifetimeFactory(registerType, registerImplementation, lifetimeProvider, errorString);
			}

			public override ObjectFactoryBase GetFactoryForChildContainer(Type type, TinyIoCContainer parent, TinyIoCContainer child)
			{
				GetObject(type, parent, NamedParameterOverloads.Default, ResolveOptions.Default);
				return this;
			}

			public void Dispose()
			{
				_LifetimeProvider.ReleaseObject();
			}
		}

		public sealed class TypeRegistration
		{
			private int _hashCode;

			public Type Type { get; private set; }

			public string Name { get; private set; }

			public TypeRegistration(Type type)
				: this(type, string.Empty)
			{
			}

			public TypeRegistration(Type type, string name)
			{
				Type = type;
				Name = name;
				_hashCode = (Type.FullName + "|" + Name).GetHashCode();
			}

			public override bool Equals(object obj)
			{
				TypeRegistration typeRegistration = obj as TypeRegistration;
				if (typeRegistration == null)
				{
					return false;
				}
				if (Type != typeRegistration.Type)
				{
					return false;
				}
				if (string.Compare(Name, typeRegistration.Name, StringComparison.Ordinal) != 0)
				{
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				return _hashCode;
			}
		}

		private delegate object ObjectConstructor(params object[] parameters);

		private static readonly TinyIoCContainer _Current;

		private readonly SafeDictionary<TypeRegistration, ObjectFactoryBase> _RegisteredTypes;

		private static readonly SafeDictionary<ConstructorInfo, ObjectConstructor> _ObjectConstructorCache;

		private TinyIoCContainer _Parent;

		private readonly object _AutoRegisterLock = new object();

		private bool disposed;

		public static TinyIoCContainer Current => _Current;

		public TinyIoCContainer GetChildContainer()
		{
			return new TinyIoCContainer(this);
		}

		public void AutoRegister()
		{
			AutoRegisterInternal(from a in AppDomain.CurrentDomain.GetAssemblies()
				where !IsIgnoredAssembly(a)
				select a, DuplicateImplementationActions.RegisterSingle, null);
		}

		public void AutoRegister(Func<Type, bool> registrationPredicate)
		{
			AutoRegisterInternal(from a in AppDomain.CurrentDomain.GetAssemblies()
				where !IsIgnoredAssembly(a)
				select a, DuplicateImplementationActions.RegisterSingle, registrationPredicate);
		}

		public void AutoRegister(DuplicateImplementationActions duplicateAction)
		{
			AutoRegisterInternal(from a in AppDomain.CurrentDomain.GetAssemblies()
				where !IsIgnoredAssembly(a)
				select a, duplicateAction, null);
		}

		public void AutoRegister(DuplicateImplementationActions duplicateAction, Func<Type, bool> registrationPredicate)
		{
			AutoRegisterInternal(from a in AppDomain.CurrentDomain.GetAssemblies()
				where !IsIgnoredAssembly(a)
				select a, duplicateAction, registrationPredicate);
		}

		public void AutoRegister(IEnumerable<Assembly> assemblies)
		{
			AutoRegisterInternal(assemblies, DuplicateImplementationActions.RegisterSingle, null);
		}

		public void AutoRegister(IEnumerable<Assembly> assemblies, Func<Type, bool> registrationPredicate)
		{
			AutoRegisterInternal(assemblies, DuplicateImplementationActions.RegisterSingle, registrationPredicate);
		}

		public void AutoRegister(IEnumerable<Assembly> assemblies, DuplicateImplementationActions duplicateAction)
		{
			AutoRegisterInternal(assemblies, duplicateAction, null);
		}

		public void AutoRegister(IEnumerable<Assembly> assemblies, DuplicateImplementationActions duplicateAction, Func<Type, bool> registrationPredicate)
		{
			AutoRegisterInternal(assemblies, duplicateAction, registrationPredicate);
		}

		public RegisterOptions Register(Type registerType)
		{
			return RegisterInternal(registerType, string.Empty, GetDefaultObjectFactory(registerType, registerType));
		}

		public RegisterOptions Register(Type registerType, string name)
		{
			return RegisterInternal(registerType, name, GetDefaultObjectFactory(registerType, registerType));
		}

		public RegisterOptions Register(Type registerType, Type registerImplementation)
		{
			return RegisterInternal(registerType, string.Empty, GetDefaultObjectFactory(registerType, registerImplementation));
		}

		public RegisterOptions Register(Type registerType, Type registerImplementation, string name)
		{
			return RegisterInternal(registerType, name, GetDefaultObjectFactory(registerType, registerImplementation));
		}

		public RegisterOptions Register(Type registerType, object instance)
		{
			return RegisterInternal(registerType, string.Empty, new InstanceFactory(registerType, registerType, instance));
		}

		public RegisterOptions Register(Type registerType, object instance, string name)
		{
			return RegisterInternal(registerType, name, new InstanceFactory(registerType, registerType, instance));
		}

		public RegisterOptions Register(Type registerType, Type registerImplementation, object instance)
		{
			return RegisterInternal(registerType, string.Empty, new InstanceFactory(registerType, registerImplementation, instance));
		}

		public RegisterOptions Register(Type registerType, Type registerImplementation, object instance, string name)
		{
			return RegisterInternal(registerType, name, new InstanceFactory(registerType, registerImplementation, instance));
		}

		public RegisterOptions Register(Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory)
		{
			return RegisterInternal(registerType, string.Empty, new DelegateFactory(registerType, factory));
		}

		public RegisterOptions Register(Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory, string name)
		{
			return RegisterInternal(registerType, name, new DelegateFactory(registerType, factory));
		}

		public RegisterOptions Register<RegisterType>() where RegisterType : class
		{
			return Register(typeof(RegisterType));
		}

		public RegisterOptions Register<RegisterType>(string name) where RegisterType : class
		{
			return Register(typeof(RegisterType), name);
		}

		public RegisterOptions Register<RegisterType, RegisterImplementation>() where RegisterType : class where RegisterImplementation : class, RegisterType
		{
			return Register(typeof(RegisterType), typeof(RegisterImplementation));
		}

		public RegisterOptions Register<RegisterType, RegisterImplementation>(string name) where RegisterType : class where RegisterImplementation : class, RegisterType
		{
			return Register(typeof(RegisterType), typeof(RegisterImplementation), name);
		}

		public RegisterOptions Register<RegisterType>(RegisterType instance) where RegisterType : class
		{
			return Register(typeof(RegisterType), instance);
		}

		public RegisterOptions Register<RegisterType>(RegisterType instance, string name) where RegisterType : class
		{
			return Register(typeof(RegisterType), instance, name);
		}

		public RegisterOptions Register<RegisterType, RegisterImplementation>(RegisterImplementation instance) where RegisterType : class where RegisterImplementation : class, RegisterType
		{
			return Register(typeof(RegisterType), typeof(RegisterImplementation), instance);
		}

		public RegisterOptions Register<RegisterType, RegisterImplementation>(RegisterImplementation instance, string name) where RegisterType : class where RegisterImplementation : class, RegisterType
		{
			return Register(typeof(RegisterType), typeof(RegisterImplementation), instance, name);
		}

		public RegisterOptions Register<RegisterType>(Func<TinyIoCContainer, NamedParameterOverloads, RegisterType> factory) where RegisterType : class
		{
			if (factory == null)
			{
				throw new ArgumentNullException("factory");
			}
			return Register(typeof(RegisterType), (TinyIoCContainer c, NamedParameterOverloads o) => factory(c, o));
		}

		public RegisterOptions Register<RegisterType>(Func<TinyIoCContainer, NamedParameterOverloads, RegisterType> factory, string name) where RegisterType : class
		{
			if (factory == null)
			{
				throw new ArgumentNullException("factory");
			}
			return Register(typeof(RegisterType), (TinyIoCContainer c, NamedParameterOverloads o) => factory(c, o), name);
		}

		public MultiRegisterOptions RegisterMultiple<RegisterType>(IEnumerable<Type> implementationTypes)
		{
			return RegisterMultiple(typeof(RegisterType), implementationTypes);
		}

		public MultiRegisterOptions RegisterMultiple(Type registrationType, IEnumerable<Type> implementationTypes)
		{
			if (implementationTypes == null)
			{
				throw new ArgumentNullException("types", "types is null.");
			}
			foreach (Type implementationType in implementationTypes)
			{
				if (!registrationType.IsAssignableFrom(implementationType))
				{
					throw new ArgumentException($"types: The type {registrationType.FullName} is not assignable from {implementationType.FullName}");
				}
			}
			if (implementationTypes.Count() != implementationTypes.Distinct().Count())
			{
				IEnumerable<string> source = from i in implementationTypes
					group i by i into j
					where j.Count() > 1
					select j.Key.FullName;
				string arg = string.Join(",\n", source.ToArray());
				throw new ArgumentException($"types: The same implementation type cannot be specified multiple times for {registrationType.FullName}\n\n{arg}");
			}
			List<RegisterOptions> list = new List<RegisterOptions>();
			foreach (Type implementationType2 in implementationTypes)
			{
				list.Add(Register(registrationType, implementationType2, implementationType2.FullName));
			}
			return new MultiRegisterOptions(list);
		}

		public bool Unregister<RegisterType>()
		{
			return Unregister(typeof(RegisterType), string.Empty);
		}

		public bool Unregister<RegisterType>(string name)
		{
			return Unregister(typeof(RegisterType), name);
		}

		public bool Unregister(Type registerType)
		{
			return Unregister(registerType, string.Empty);
		}

		public bool Unregister(Type registerType, string name)
		{
			TypeRegistration typeRegistration = new TypeRegistration(registerType, name);
			return RemoveRegistration(typeRegistration);
		}

		public object Resolve(Type resolveType)
		{
			return ResolveInternal(new TypeRegistration(resolveType), NamedParameterOverloads.Default, ResolveOptions.Default);
		}

		public object Resolve(Type resolveType, ResolveOptions options)
		{
			return ResolveInternal(new TypeRegistration(resolveType), NamedParameterOverloads.Default, options);
		}

		public object Resolve(Type resolveType, string name)
		{
			return ResolveInternal(new TypeRegistration(resolveType, name), NamedParameterOverloads.Default, ResolveOptions.Default);
		}

		public object Resolve(Type resolveType, string name, ResolveOptions options)
		{
			return ResolveInternal(new TypeRegistration(resolveType, name), NamedParameterOverloads.Default, options);
		}

		public object Resolve(Type resolveType, NamedParameterOverloads parameters)
		{
			return ResolveInternal(new TypeRegistration(resolveType), parameters, ResolveOptions.Default);
		}

		public object Resolve(Type resolveType, NamedParameterOverloads parameters, ResolveOptions options)
		{
			return ResolveInternal(new TypeRegistration(resolveType), parameters, options);
		}

		public object Resolve(Type resolveType, string name, NamedParameterOverloads parameters)
		{
			return ResolveInternal(new TypeRegistration(resolveType, name), parameters, ResolveOptions.Default);
		}

		public object Resolve(Type resolveType, string name, NamedParameterOverloads parameters, ResolveOptions options)
		{
			return ResolveInternal(new TypeRegistration(resolveType, name), parameters, options);
		}

		public ResolveType Resolve<ResolveType>() where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType));
		}

		public ResolveType Resolve<ResolveType>(ResolveOptions options) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), options);
		}

		public ResolveType Resolve<ResolveType>(string name) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), name);
		}

		public ResolveType Resolve<ResolveType>(string name, ResolveOptions options) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), name, options);
		}

		public ResolveType Resolve<ResolveType>(NamedParameterOverloads parameters) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), parameters);
		}

		public ResolveType Resolve<ResolveType>(NamedParameterOverloads parameters, ResolveOptions options) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), parameters, options);
		}

		public ResolveType Resolve<ResolveType>(string name, NamedParameterOverloads parameters) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), name, parameters);
		}

		public ResolveType Resolve<ResolveType>(string name, NamedParameterOverloads parameters, ResolveOptions options) where ResolveType : class
		{
			return (ResolveType)Resolve(typeof(ResolveType), name, parameters, options);
		}

		public bool CanResolve(Type resolveType)
		{
			return CanResolveInternal(new TypeRegistration(resolveType), NamedParameterOverloads.Default, ResolveOptions.Default);
		}

		private bool CanResolve(Type resolveType, string name)
		{
			return CanResolveInternal(new TypeRegistration(resolveType, name), NamedParameterOverloads.Default, ResolveOptions.Default);
		}

		public bool CanResolve(Type resolveType, ResolveOptions options)
		{
			return CanResolveInternal(new TypeRegistration(resolveType), NamedParameterOverloads.Default, options);
		}

		public bool CanResolve(Type resolveType, string name, ResolveOptions options)
		{
			return CanResolveInternal(new TypeRegistration(resolveType, name), NamedParameterOverloads.Default, options);
		}

		public bool CanResolve(Type resolveType, NamedParameterOverloads parameters)
		{
			return CanResolveInternal(new TypeRegistration(resolveType), parameters, ResolveOptions.Default);
		}

		public bool CanResolve(Type resolveType, string name, NamedParameterOverloads parameters)
		{
			return CanResolveInternal(new TypeRegistration(resolveType, name), parameters, ResolveOptions.Default);
		}

		public bool CanResolve(Type resolveType, NamedParameterOverloads parameters, ResolveOptions options)
		{
			return CanResolveInternal(new TypeRegistration(resolveType), parameters, options);
		}

		public bool CanResolve(Type resolveType, string name, NamedParameterOverloads parameters, ResolveOptions options)
		{
			return CanResolveInternal(new TypeRegistration(resolveType, name), parameters, options);
		}

		public bool CanResolve<ResolveType>() where ResolveType : class
		{
			return CanResolve(typeof(ResolveType));
		}

		public bool CanResolve<ResolveType>(string name) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), name);
		}

		public bool CanResolve<ResolveType>(ResolveOptions options) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), options);
		}

		public bool CanResolve<ResolveType>(string name, ResolveOptions options) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), name, options);
		}

		public bool CanResolve<ResolveType>(NamedParameterOverloads parameters) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), parameters);
		}

		public bool CanResolve<ResolveType>(string name, NamedParameterOverloads parameters) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), name, parameters);
		}

		public bool CanResolve<ResolveType>(NamedParameterOverloads parameters, ResolveOptions options) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), parameters, options);
		}

		public bool CanResolve<ResolveType>(string name, NamedParameterOverloads parameters, ResolveOptions options) where ResolveType : class
		{
			return CanResolve(typeof(ResolveType), name, parameters, options);
		}

		public bool TryResolve(Type resolveType, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, ResolveOptions options, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, string name, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, name);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, string name, ResolveOptions options, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, name, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, NamedParameterOverloads parameters, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, parameters);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, string name, NamedParameterOverloads parameters, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, name, parameters);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, NamedParameterOverloads parameters, ResolveOptions options, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, parameters, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve(Type resolveType, string name, NamedParameterOverloads parameters, ResolveOptions options, out object resolvedType)
		{
			try
			{
				resolvedType = Resolve(resolveType, name, parameters, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>();
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(ResolveOptions options, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(string name, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(name);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(string name, ResolveOptions options, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(name, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(NamedParameterOverloads parameters, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(parameters);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(string name, NamedParameterOverloads parameters, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(name, parameters);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(NamedParameterOverloads parameters, ResolveOptions options, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(parameters, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public bool TryResolve<ResolveType>(string name, NamedParameterOverloads parameters, ResolveOptions options, out ResolveType resolvedType) where ResolveType : class
		{
			try
			{
				resolvedType = Resolve<ResolveType>(name, parameters, options);
				return true;
			}
			catch (TinyIoCResolutionException)
			{
				resolvedType = null;
				return false;
			}
		}

		public IEnumerable<object> ResolveAll(Type resolveType, bool includeUnnamed)
		{
			return ResolveAllInternal(resolveType, includeUnnamed);
		}

		public IEnumerable<object> ResolveAll(Type resolveType)
		{
			return ResolveAll(resolveType, includeUnnamed: false);
		}

		public IEnumerable<ResolveType> ResolveAll<ResolveType>(bool includeUnnamed) where ResolveType : class
		{
			return ResolveAll(typeof(ResolveType), includeUnnamed).Cast<ResolveType>();
		}

		public IEnumerable<ResolveType> ResolveAll<ResolveType>() where ResolveType : class
		{
			return ResolveAll<ResolveType>(includeUnnamed: true);
		}

		public void BuildUp(object input)
		{
			BuildUpInternal(input, ResolveOptions.Default);
		}

		public void BuildUp(object input, ResolveOptions resolveOptions)
		{
			BuildUpInternal(input, resolveOptions);
		}

		static TinyIoCContainer()
		{
			_Current = new TinyIoCContainer();
			_ObjectConstructorCache = new SafeDictionary<ConstructorInfo, ObjectConstructor>();
		}

		public TinyIoCContainer()
		{
			_RegisteredTypes = new SafeDictionary<TypeRegistration, ObjectFactoryBase>();
			RegisterDefaultTypes();
		}

		private TinyIoCContainer(TinyIoCContainer parent)
			: this()
		{
			_Parent = parent;
		}

		private void AutoRegisterInternal(IEnumerable<Assembly> assemblies, DuplicateImplementationActions duplicateAction, Func<Type, bool> registrationPredicate)
		{
			lock (_AutoRegisterLock)
			{
				List<Type> source = (from t in assemblies.SelectMany((Assembly a) => a.SafeGetTypes())
					where !IsIgnoredType(t, registrationPredicate)
					select t).ToList();
				List<Type> list = source.Where((Type type) => type.IsClass() && !type.IsAbstract() && type != GetType() && type.DeclaringType != GetType() && !type.IsGenericTypeDefinition()).ToList();
				foreach (Type item in list)
				{
					try
					{
						RegisterInternal(item, string.Empty, GetDefaultObjectFactory(item, item));
					}
					catch (MethodAccessException)
					{
					}
				}
				foreach (Type item2 in source.Where((Type type) => (type.IsInterface() || type.IsAbstract()) && type.DeclaringType != GetType() && !type.IsGenericTypeDefinition()))
				{
					Type localType = item2;
					IEnumerable<Type> enumerable = list.Where((Type implementationType) => localType.IsAssignableFrom(implementationType));
					if (enumerable.Skip(1).Any())
					{
						switch (duplicateAction)
						{
						case DuplicateImplementationActions.Fail:
							throw new TinyIoCAutoRegistrationException(item2, enumerable);
						case DuplicateImplementationActions.RegisterMultiple:
							RegisterMultiple(item2, enumerable);
							break;
						}
					}
					Type type2 = enumerable.FirstOrDefault();
					if (type2 != null)
					{
						try
						{
							RegisterInternal(item2, string.Empty, GetDefaultObjectFactory(item2, type2));
						}
						catch (MethodAccessException)
						{
						}
					}
				}
			}
		}

		private bool IsIgnoredAssembly(Assembly assembly)
		{
			foreach (Func<Assembly, bool> item in new List<Func<Assembly, bool>>
			{
				(Assembly asm) => asm.FullName!.StartsWith("Microsoft.", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("System.", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("System,", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("CR_ExtUnitTest", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("mscorlib,", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("CR_VSTest", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("DevExpress.CodeRush", StringComparison.Ordinal),
				(Assembly asm) => asm.FullName!.StartsWith("xunit.", StringComparison.Ordinal)
			})
			{
				if (item(assembly))
				{
					return true;
				}
			}
			return false;
		}

		private bool IsIgnoredType(Type type, Func<Type, bool> registrationPredicate)
		{
			List<Func<Type, bool>> list = new List<Func<Type, bool>>
			{
				(Type t) => t.FullName!.StartsWith("System.", StringComparison.Ordinal),
				(Type t) => t.FullName!.StartsWith("Microsoft.", StringComparison.Ordinal),
				(Type t) => t.IsPrimitive(),
				(Type t) => t.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length == 0 && !t.IsInterface() && !t.IsAbstract()
			};
			if (registrationPredicate != null)
			{
				list.Add((Type t) => !registrationPredicate(t));
			}
			foreach (Func<Type, bool> item in list)
			{
				if (item(type))
				{
					return true;
				}
			}
			return false;
		}

		private void RegisterDefaultTypes()
		{
			Register(this);
		}

		private ObjectFactoryBase GetCurrentFactory(TypeRegistration registration)
		{
			ObjectFactoryBase value = null;
			_RegisteredTypes.TryGetValue(registration, out value);
			return value;
		}

		private RegisterOptions RegisterInternal(Type registerType, string name, ObjectFactoryBase factory)
		{
			TypeRegistration typeRegistration = new TypeRegistration(registerType, name);
			return AddUpdateRegistration(typeRegistration, factory);
		}

		private RegisterOptions AddUpdateRegistration(TypeRegistration typeRegistration, ObjectFactoryBase factory)
		{
			_RegisteredTypes[typeRegistration] = factory;
			return new RegisterOptions(this, typeRegistration);
		}

		private bool RemoveRegistration(TypeRegistration typeRegistration)
		{
			return _RegisteredTypes.Remove(typeRegistration);
		}

		private ObjectFactoryBase GetDefaultObjectFactory(Type registerType, Type registerImplementation)
		{
			if (registerType.IsInterface() || registerType.IsAbstract())
			{
				return new SingletonFactory(registerType, registerImplementation);
			}
			return new MultiInstanceFactory(registerType, registerImplementation);
		}

		private bool CanResolveInternal(TypeRegistration registration, NamedParameterOverloads parameters, ResolveOptions options)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			Type type = registration.Type;
			string name = registration.Name;
			if (_RegisteredTypes.TryGetValue(new TypeRegistration(type, name), out var value))
			{
				if (value.AssumeConstruction)
				{
					return true;
				}
				if (value.Constructor == null)
				{
					if (!(GetBestConstructor(value.CreatesType, parameters, options) != null))
					{
						return false;
					}
					return true;
				}
				return CanConstruct(value.Constructor, parameters, options);
			}
			if (type.IsInterface() && type.IsGenericType() && _RegisteredTypes.TryGetValue(new TypeRegistration(type.GetGenericTypeDefinition(), name), out value))
			{
				if (value.AssumeConstruction)
				{
					return true;
				}
				if (value.Constructor == null)
				{
					if (!(GetBestConstructor(value.CreatesType, parameters, options) != null))
					{
						return false;
					}
					return true;
				}
				return CanConstruct(value.Constructor, parameters, options);
			}
			if (!string.IsNullOrEmpty(name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.Fail)
			{
				if (_Parent != null)
				{
					return _Parent.CanResolveInternal(registration, parameters, options);
				}
				return false;
			}
			if (!string.IsNullOrEmpty(name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.AttemptUnnamedResolution && _RegisteredTypes.TryGetValue(new TypeRegistration(type), out value))
			{
				if (value.AssumeConstruction)
				{
					return true;
				}
				if (!(GetBestConstructor(value.CreatesType, parameters, options) != null))
				{
					return false;
				}
				return true;
			}
			if (IsAutomaticLazyFactoryRequest(type))
			{
				return true;
			}
			if (IsIEnumerableRequest(registration.Type))
			{
				return true;
			}
			if (options.UnregisteredResolutionAction == UnregisteredResolutionActions.AttemptResolve || (type.IsGenericType() && options.UnregisteredResolutionAction == UnregisteredResolutionActions.GenericsOnly))
			{
				if (!(GetBestConstructor(type, parameters, options) != null))
				{
					if (_Parent == null)
					{
						return false;
					}
					return _Parent.CanResolveInternal(registration, parameters, options);
				}
				return true;
			}
			if (_Parent != null)
			{
				return _Parent.CanResolveInternal(registration, parameters, options);
			}
			return false;
		}

		private bool IsIEnumerableRequest(Type type)
		{
			if (!type.IsGenericType())
			{
				return false;
			}
			if (type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
			{
				return true;
			}
			return false;
		}

		private bool IsAutomaticLazyFactoryRequest(Type type)
		{
			if (!type.IsGenericType())
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			if (genericTypeDefinition == typeof(Func<>))
			{
				return true;
			}
			if (genericTypeDefinition == typeof(Func<, >) && type.GetGenericArguments()[0] == typeof(string))
			{
				return true;
			}
			if (genericTypeDefinition == typeof(Func<, , >) && type.GetGenericArguments()[0] == typeof(string) && type.GetGenericArguments()[1] == typeof(IDictionary<string, object>))
			{
				return true;
			}
			return false;
		}

		private ObjectFactoryBase GetParentObjectFactory(TypeRegistration registration)
		{
			if (_Parent == null)
			{
				return null;
			}
			if (_Parent._RegisteredTypes.TryGetValue(registration, out var value))
			{
				return value.GetFactoryForChildContainer(registration.Type, _Parent, this);
			}
			return _Parent.GetParentObjectFactory(registration);
		}

		private object ResolveInternal(TypeRegistration registration, NamedParameterOverloads parameters, ResolveOptions options)
		{
			if (_RegisteredTypes.TryGetValue(registration, out var value))
			{
				try
				{
					return value.GetObject(registration.Type, this, parameters, options);
				}
				catch (TinyIoCResolutionException)
				{
					throw;
				}
				catch (Exception innerException)
				{
					throw new TinyIoCResolutionException(registration.Type, innerException);
				}
			}
			if (registration.Type.IsGenericType())
			{
				TypeRegistration key = new TypeRegistration(registration.Type.GetGenericTypeDefinition(), registration.Name);
				if (_RegisteredTypes.TryGetValue(key, out value))
				{
					try
					{
						return value.GetObject(registration.Type, this, parameters, options);
					}
					catch (TinyIoCResolutionException)
					{
						throw;
					}
					catch (Exception innerException2)
					{
						throw new TinyIoCResolutionException(registration.Type, innerException2);
					}
				}
			}
			ObjectFactoryBase parentObjectFactory = GetParentObjectFactory(registration);
			if (parentObjectFactory != null)
			{
				try
				{
					return parentObjectFactory.GetObject(registration.Type, this, parameters, options);
				}
				catch (TinyIoCResolutionException)
				{
					throw;
				}
				catch (Exception innerException3)
				{
					throw new TinyIoCResolutionException(registration.Type, innerException3);
				}
			}
			if (!string.IsNullOrEmpty(registration.Name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.Fail)
			{
				throw new TinyIoCResolutionException(registration.Type);
			}
			if (!string.IsNullOrEmpty(registration.Name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.AttemptUnnamedResolution && _RegisteredTypes.TryGetValue(new TypeRegistration(registration.Type, string.Empty), out value))
			{
				try
				{
					return value.GetObject(registration.Type, this, parameters, options);
				}
				catch (TinyIoCResolutionException)
				{
					throw;
				}
				catch (Exception innerException4)
				{
					throw new TinyIoCResolutionException(registration.Type, innerException4);
				}
			}
			if (IsAutomaticLazyFactoryRequest(registration.Type))
			{
				return GetLazyAutomaticFactoryRequest(registration.Type);
			}
			if (IsIEnumerableRequest(registration.Type))
			{
				return GetIEnumerableRequest(registration.Type);
			}
			if ((options.UnregisteredResolutionAction == UnregisteredResolutionActions.AttemptResolve || (registration.Type.IsGenericType() && options.UnregisteredResolutionAction == UnregisteredResolutionActions.GenericsOnly)) && !registration.Type.IsAbstract() && !registration.Type.IsInterface())
			{
				return ConstructType(null, registration.Type, parameters, options);
			}
			throw new TinyIoCResolutionException(registration.Type);
		}

		private object GetLazyAutomaticFactoryRequest(Type type)
		{
			if (!type.IsGenericType())
			{
				return null;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			Type[] genericArguments = type.GetGenericArguments();
			if (genericTypeDefinition == typeof(Func<>))
			{
				Type type2 = genericArguments[0];
				MethodInfo method = typeof(TinyIoCContainer).GetMethod("Resolve", new Type[0]);
				method = method.MakeGenericMethod(type2);
				return Expression.Lambda(Expression.Call(Expression.Constant(this), method)).Compile();
			}
			if (genericTypeDefinition == typeof(Func<, >) && genericArguments[0] == typeof(string))
			{
				Type type3 = genericArguments[1];
				MethodInfo method2 = typeof(TinyIoCContainer).GetMethod("Resolve", new Type[1] { typeof(string) });
				method2 = method2.MakeGenericMethod(type3);
				ParameterExpression[] array = new ParameterExpression[1] { Expression.Parameter(typeof(string), "name") };
				ConstantExpression instance = Expression.Constant(this);
				MethodInfo method3 = method2;
				Expression[] arguments = array;
				return Expression.Lambda(Expression.Call(instance, method3, arguments), array).Compile();
			}
			if (genericTypeDefinition == typeof(Func<, , >) && type.GetGenericArguments()[0] == typeof(string) && type.GetGenericArguments()[1] == typeof(IDictionary<string, object>))
			{
				Type type4 = genericArguments[2];
				ParameterExpression parameterExpression = Expression.Parameter(typeof(string), "name");
				ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IDictionary<string, object>), "parameters");
				MethodInfo method4 = typeof(TinyIoCContainer).GetMethod("Resolve", new Type[2]
				{
					typeof(string),
					typeof(NamedParameterOverloads)
				});
				method4 = method4.MakeGenericMethod(type4);
				return Expression.Lambda(Expression.Call(Expression.Constant(this), method4, parameterExpression, Expression.Call(typeof(NamedParameterOverloads), "FromIDictionary", null, parameterExpression2)), parameterExpression, parameterExpression2).Compile();
			}
			throw new TinyIoCResolutionException(type);
		}

		private object GetIEnumerableRequest(Type type)
		{
			return GetType().GetGenericMethod(BindingFlags.Instance | BindingFlags.Public, "ResolveAll", type.GetGenericArguments(), new Type[1] { typeof(bool) }).Invoke(this, new object[1] { false });
		}

		private bool CanConstruct(ConstructorInfo ctor, NamedParameterOverloads parameters, ResolveOptions options)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			ParameterInfo[] parameters2 = ctor.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters2)
			{
				if (string.IsNullOrEmpty(parameterInfo.Name))
				{
					return false;
				}
				bool flag = parameters.ContainsKey(parameterInfo.Name);
				if (parameterInfo.ParameterType.IsPrimitive() && !flag)
				{
					return false;
				}
				if (!flag && !CanResolveInternal(new TypeRegistration(parameterInfo.ParameterType), NamedParameterOverloads.Default, options))
				{
					return false;
				}
			}
			return true;
		}

		private ConstructorInfo GetBestConstructor(Type type, NamedParameterOverloads parameters, ResolveOptions options)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			if (type.IsValueType())
			{
				return null;
			}
			foreach (ConstructorInfo typeConstructor in GetTypeConstructors(type))
			{
				if (CanConstruct(typeConstructor, parameters, options))
				{
					return typeConstructor;
				}
			}
			return null;
		}

		private IEnumerable<ConstructorInfo> GetTypeConstructors(Type type)
		{
			return from ctor in type.GetConstructors()
				orderby ctor.GetParameters().Count() descending
				select ctor;
		}

		private object ConstructType(Type requestedType, Type implementationType, ResolveOptions options)
		{
			return ConstructType(requestedType, implementationType, null, NamedParameterOverloads.Default, options);
		}

		private object ConstructType(Type requestedType, Type implementationType, ConstructorInfo constructor, ResolveOptions options)
		{
			return ConstructType(requestedType, implementationType, constructor, NamedParameterOverloads.Default, options);
		}

		private object ConstructType(Type requestedType, Type implementationType, NamedParameterOverloads parameters, ResolveOptions options)
		{
			return ConstructType(requestedType, implementationType, null, parameters, options);
		}

		private object ConstructType(Type requestedType, Type implementationType, ConstructorInfo constructor, NamedParameterOverloads parameters, ResolveOptions options)
		{
			Type type = implementationType;
			if (implementationType.IsGenericTypeDefinition())
			{
				if (requestedType == null || !requestedType.IsGenericType() || !requestedType.GetGenericArguments().Any())
				{
					throw new TinyIoCResolutionException(type);
				}
				type = type.MakeGenericType(requestedType.GetGenericArguments());
			}
			if (constructor == null)
			{
				constructor = GetBestConstructor(type, parameters, options) ?? GetTypeConstructors(type).LastOrDefault();
			}
			if (constructor == null)
			{
				throw new TinyIoCResolutionException(type);
			}
			ParameterInfo[] parameters2 = constructor.GetParameters();
			object[] array = new object[parameters2.Count()];
			for (int i = 0; i < parameters2.Count(); i++)
			{
				ParameterInfo parameterInfo = parameters2[i];
				try
				{
					array[i] = (parameters.ContainsKey(parameterInfo.Name) ? parameters[parameterInfo.Name] : ResolveInternal(new TypeRegistration(parameterInfo.ParameterType), NamedParameterOverloads.Default, options));
				}
				catch (TinyIoCResolutionException innerException)
				{
					throw new TinyIoCResolutionException(type, innerException);
				}
				catch (Exception innerException2)
				{
					throw new TinyIoCResolutionException(type, innerException2);
				}
			}
			try
			{
				return CreateObjectConstructionDelegateWithCache(constructor)(array);
			}
			catch (Exception innerException3)
			{
				throw new TinyIoCResolutionException(type, innerException3);
			}
		}

		private static ObjectConstructor CreateObjectConstructionDelegateWithCache(ConstructorInfo constructor)
		{
			if (_ObjectConstructorCache.TryGetValue(constructor, out var value))
			{
				return value;
			}
			ParameterInfo[] parameters = constructor.GetParameters();
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "parameters");
			Expression[] array = new Expression[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				BinaryExpression expression = Expression.ArrayIndex(parameterExpression, Expression.Constant(i));
				array[i] = Expression.Convert(expression, parameters[i].ParameterType);
			}
			NewExpression body = Expression.New(constructor, array);
			value = (ObjectConstructor)Expression.Lambda(typeof(ObjectConstructor), body, parameterExpression).Compile();
			_ObjectConstructorCache[constructor] = value;
			return value;
		}

		private void BuildUpInternal(object input, ResolveOptions resolveOptions)
		{
			foreach (PropertyInfo item in from property in input.GetType().GetProperties()
				where property.GetGetMethod() != null && property.GetSetMethod() != null && !property.PropertyType.IsValueType()
				select property)
			{
				if (item.GetValue(input, null) == null)
				{
					try
					{
						item.SetValue(input, ResolveInternal(new TypeRegistration(item.PropertyType), NamedParameterOverloads.Default, resolveOptions), null);
					}
					catch (TinyIoCResolutionException)
					{
					}
				}
			}
		}

		private IEnumerable<TypeRegistration> GetParentRegistrationsForType(Type resolveType)
		{
			if (_Parent == null)
			{
				return new TypeRegistration[0];
			}
			return _Parent._RegisteredTypes.Keys.Where((TypeRegistration tr) => tr.Type == resolveType).Concat(_Parent.GetParentRegistrationsForType(resolveType));
		}

		private IEnumerable<object> ResolveAllInternal(Type resolveType, bool includeUnnamed)
		{
			IEnumerable<TypeRegistration> source = _RegisteredTypes.Keys.Where((TypeRegistration tr) => tr.Type == resolveType).Concat(GetParentRegistrationsForType(resolveType)).Distinct();
			if (!includeUnnamed)
			{
				source = source.Where((TypeRegistration tr) => tr.Name != string.Empty);
			}
			return source.Select((TypeRegistration registration) => ResolveInternal(registration, NamedParameterOverloads.Default, ResolveOptions.Default));
		}

		private static bool IsValidAssignment(Type registerType, Type registerImplementation)
		{
			if (!registerType.IsGenericTypeDefinition())
			{
				if (!registerType.IsAssignableFrom(registerImplementation))
				{
					return false;
				}
			}
			else if (registerType.IsInterface())
			{
				if (!registerImplementation.FindInterfaces((Type t, object o) => t.Name == registerType.Name, null).Any())
				{
					return false;
				}
			}
			else if (registerType.IsAbstract() && registerImplementation.BaseType() != registerType)
			{
				return false;
			}
			return true;
		}

		public void Dispose()
		{
			if (!disposed)
			{
				disposed = true;
				_RegisteredTypes.Dispose();
				GC.SuppressFinalize(this);
			}
		}
	}
}
