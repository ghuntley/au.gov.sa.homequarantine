using System;
using System.Threading.Tasks;
using System.Windows.Input;
using HomeQuarantine.Extensions;

namespace HomeQuarantine.Helpers
{
	public class AsyncCommand : IAsyncCommand, ICommand
	{
		private readonly Func<Task> execute;

		private readonly Func<bool> canExecute;

		private readonly IErrorHandler errorHandler;

		private bool isExecuting;

		public event EventHandler CanExecuteChanged;

		public AsyncCommand(Func<Task> execute, Func<bool> canExecute = null, IErrorHandler errorHandler = null)
		{
			this.execute = execute;
			this.canExecute = canExecute;
			this.errorHandler = errorHandler;
		}

		public bool CanExecute()
		{
			if (!isExecuting)
			{
				return canExecute?.Invoke() ?? true;
			}
			return false;
		}

		public async Task ExecuteAsync()
		{
			if (CanExecute())
			{
				try
				{
					isExecuting = true;
					await execute();
				}
				finally
				{
					isExecuting = false;
				}
			}
			RaiseCanExecuteChanged();
		}

		public void RaiseCanExecuteChanged()
		{
			this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
		}

		bool ICommand.CanExecute(object parameter)
		{
			return CanExecute();
		}

		void ICommand.Execute(object parameter)
		{
			ExecuteAsync().FireAndForgetSafeAsync(errorHandler);
		}
	}
	public class AsyncCommand<T> : IAsyncCommand<T>, ICommand
	{
		private readonly Func<T, Task> execute;

		private readonly Func<T, bool> canExecute;

		private readonly IErrorHandler errorHandler;

		private bool isExecuting;

		public event EventHandler CanExecuteChanged;

		public AsyncCommand(Func<T, Task> execute, Func<T, bool> canExecute = null, IErrorHandler errorHandler = null)
		{
			this.execute = execute;
			this.canExecute = canExecute;
			this.errorHandler = errorHandler;
		}

		public bool CanExecute(T parameter)
		{
			if (!isExecuting)
			{
				return canExecute?.Invoke(parameter) ?? true;
			}
			return false;
		}

		public async Task ExecuteAsync(T parameter)
		{
			if (CanExecute(parameter))
			{
				try
				{
					isExecuting = true;
					await execute(parameter);
				}
				finally
				{
					isExecuting = false;
				}
			}
			RaiseCanExecuteChanged();
		}

		public void RaiseCanExecuteChanged()
		{
			this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
		}

		bool ICommand.CanExecute(object parameter)
		{
			return CanExecute((T)parameter);
		}

		void ICommand.Execute(object parameter)
		{
			ExecuteAsync((T)parameter).FireAndForgetSafeAsync(errorHandler);
		}
	}
}
