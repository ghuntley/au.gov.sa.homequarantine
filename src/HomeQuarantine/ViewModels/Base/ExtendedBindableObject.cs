using System;
using System.Linq.Expressions;
using System.Reflection;
using HomeQuarantine.Services.ThreadService;
using Xamarin.Forms;

namespace HomeQuarantine.ViewModels.Base
{
	public abstract class ExtendedBindableObject : BindableObject
	{
		private readonly IThreadService threadService;

		public ExtendedBindableObject()
			: this()
		{
			threadService = ViewModelLocator.Resolve<IThreadService>();
		}

		public void RaisePropertyChanged<T>(Expression<Func<T>> property)
		{
			threadService.BeginInvokeOnMainThread(delegate
			{
				string name = GetMemberInfo(property).Name;
				((BindableObject)this).OnPropertyChanged(name);
			});
		}

		private MemberInfo GetMemberInfo(Expression expression)
		{
			LambdaExpression lambdaExpression = (LambdaExpression)expression;
			MemberExpression memberExpression = ((!(lambdaExpression.Body is UnaryExpression)) ? ((MemberExpression)lambdaExpression.Body) : ((MemberExpression)((UnaryExpression)lambdaExpression.Body).Operand));
			return memberExpression.Member;
		}
	}
}
