using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Input;
using HomeQuarantine.Behaviours.Base;
using Xamarin.Forms;

namespace HomeQuarantine.Behaviours
{
	public class EventToCommandBehavior : BindableBehavior<View>
	{
		public static readonly BindableProperty EventNameProperty = BindableProperty.CreateAttached("EventName", typeof(string), typeof(EventToCommandBehavior), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty CommandProperty = BindableProperty.CreateAttached("Command", typeof(ICommand), typeof(EventToCommandBehavior), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty CommandParameterProperty = BindableProperty.CreateAttached("CommandParameter", typeof(object), typeof(EventToCommandBehavior), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty EventArgsConverterProperty = BindableProperty.CreateAttached("EventArgsConverter", typeof(IValueConverter), typeof(EventToCommandBehavior), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty EventArgsConverterParameterProperty = BindableProperty.CreateAttached("EventArgsConverterParameter", typeof(object), typeof(EventToCommandBehavior), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		private Delegate handler;

		private EventInfo eventInfo;

		public string EventName
		{
			get
			{
				return (string)((BindableObject)this).GetValue(EventNameProperty);
			}
			set
			{
				((BindableObject)this).SetValue(EventNameProperty, (object)value);
			}
		}

		public ICommand Command
		{
			get
			{
				return (ICommand)((BindableObject)this).GetValue(CommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(CommandProperty, (object)value);
			}
		}

		public object CommandParameter
		{
			get
			{
				return ((BindableObject)this).GetValue(CommandParameterProperty);
			}
			set
			{
				((BindableObject)this).SetValue(CommandParameterProperty, value);
			}
		}

		public IValueConverter EventArgsConverter
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0011: Expected O, but got Unknown
				return (IValueConverter)((BindableObject)this).GetValue(EventArgsConverterProperty);
			}
			set
			{
				((BindableObject)this).SetValue(EventArgsConverterProperty, (object)value);
			}
		}

		public object EventArgsConverterParameter
		{
			get
			{
				return ((BindableObject)this).GetValue(EventArgsConverterParameterProperty);
			}
			set
			{
				((BindableObject)this).SetValue(EventArgsConverterParameterProperty, value);
			}
		}

		protected override void OnAttachedTo(View visualElement)
		{
			base.OnAttachedTo(visualElement);
			EventInfo[] source = ((object)base.AssociatedObject).GetType().GetRuntimeEvents().ToArray();
			if (source.Any())
			{
				eventInfo = source.FirstOrDefault((EventInfo e) => e.Name == EventName);
				if (eventInfo == null)
				{
					throw new ArgumentException($"EventToCommand: Can't find any event named '{EventName}' on attached type");
				}
				AddEventHandler(eventInfo, base.AssociatedObject, OnFired);
			}
		}

		protected override void OnDetachingFrom(View view)
		{
			if ((object)handler != null)
			{
				eventInfo.RemoveEventHandler(base.AssociatedObject, handler);
			}
			base.OnDetachingFrom(view);
		}

		private void AddEventHandler(EventInfo eventInfo, object item, Action<object, EventArgs> action)
		{
			ParameterExpression[] array = (from p in eventInfo.EventHandlerType.GetRuntimeMethods().First((MethodInfo m) => m.Name == "Invoke").GetParameters()
				select Expression.Parameter(p.ParameterType)).ToArray();
			MethodInfo method = action.GetType().GetRuntimeMethods().First((MethodInfo m) => m.Name == "Invoke");
			handler = Expression.Lambda(eventInfo.EventHandlerType, Expression.Call(Expression.Constant(action), method, array[0], array[1]), array).Compile();
			eventInfo.AddEventHandler(item, handler);
		}

		private void OnFired(object sender, EventArgs eventArgs)
		{
			if (Command == null)
			{
				return;
			}
			object parameter = CommandParameter;
			if (eventArgs != null && eventArgs != EventArgs.Empty)
			{
				parameter = eventArgs;
				if (EventArgsConverter != null)
				{
					parameter = EventArgsConverter.Convert((object)eventArgs, typeof(object), EventArgsConverterParameter, CultureInfo.CurrentUICulture);
				}
			}
			if (Command.CanExecute(parameter))
			{
				Command.Execute(parameter);
			}
			ListView val = (ListView)((sender is ListView) ? sender : null);
			if (val != null)
			{
				val.set_SelectedItem((object)null);
			}
		}
	}
}
