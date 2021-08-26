namespace TinyIoC
{
	public sealed class ResolveOptions
	{
		private static readonly ResolveOptions _Default = new ResolveOptions();

		private static readonly ResolveOptions _FailUnregisteredAndNameNotFound = new ResolveOptions
		{
			NamedResolutionFailureAction = NamedResolutionFailureActions.Fail,
			UnregisteredResolutionAction = UnregisteredResolutionActions.Fail
		};

		private static readonly ResolveOptions _FailUnregisteredOnly = new ResolveOptions
		{
			NamedResolutionFailureAction = NamedResolutionFailureActions.AttemptUnnamedResolution,
			UnregisteredResolutionAction = UnregisteredResolutionActions.Fail
		};

		private static readonly ResolveOptions _FailNameNotFoundOnly = new ResolveOptions
		{
			NamedResolutionFailureAction = NamedResolutionFailureActions.Fail,
			UnregisteredResolutionAction = UnregisteredResolutionActions.AttemptResolve
		};

		private UnregisteredResolutionActions _UnregisteredResolutionAction;

		private NamedResolutionFailureActions _NamedResolutionFailureAction = NamedResolutionFailureActions.Fail;

		public UnregisteredResolutionActions UnregisteredResolutionAction
		{
			get
			{
				return _UnregisteredResolutionAction;
			}
			set
			{
				_UnregisteredResolutionAction = value;
			}
		}

		public NamedResolutionFailureActions NamedResolutionFailureAction
		{
			get
			{
				return _NamedResolutionFailureAction;
			}
			set
			{
				_NamedResolutionFailureAction = value;
			}
		}

		public static ResolveOptions Default => _Default;

		public static ResolveOptions FailNameNotFoundOnly => _FailNameNotFoundOnly;

		public static ResolveOptions FailUnregisteredAndNameNotFound => _FailUnregisteredAndNameNotFound;

		public static ResolveOptions FailUnregisteredOnly => _FailUnregisteredOnly;
	}
}
