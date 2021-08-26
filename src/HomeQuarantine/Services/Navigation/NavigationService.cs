using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;

namespace HomeQuarantine.Services.Navigation
{
	public class NavigationService : INavigationService
	{
		public ViewModelBase PreviousPageViewModel
		{
			get
			{
				CustomNavigationView customNavigationView = Application.get_Current().get_MainPage() as CustomNavigationView;
				if (((NavigableElement)customNavigationView).get_Navigation().get_ModalStack().Any())
				{
					INavigation navigation = ((NavigableElement)customNavigationView).get_Navigation();
					object obj;
					if (navigation == null)
					{
						obj = null;
					}
					else
					{
						IReadOnlyList<Page> modalStack = navigation.get_ModalStack();
						if (modalStack == null)
						{
							obj = null;
						}
						else
						{
							INavigation navigation2 = ((NavigableElement)modalStack.LastOrDefault()).get_Navigation();
							if (navigation2 == null)
							{
								obj = null;
							}
							else
							{
								IReadOnlyList<Page> navigationStack = navigation2.get_NavigationStack();
								INavigation navigation3 = ((NavigableElement)customNavigationView).get_Navigation();
								int? obj2;
								if (navigation3 == null)
								{
									obj2 = null;
								}
								else
								{
									IReadOnlyList<Page> modalStack2 = navigation3.get_ModalStack();
									int? obj3;
									if (modalStack2 == null)
									{
										obj3 = null;
									}
									else
									{
										INavigation navigation4 = ((NavigableElement)modalStack2.LastOrDefault()).get_Navigation();
										obj3 = ((navigation4 != null) ? new int?(navigation4.get_NavigationStack().Count) : null);
									}
									obj2 = obj3 - 2;
								}
								int? num = obj2;
								Page obj4 = navigationStack[num.GetValueOrDefault()];
								obj = ((obj4 != null) ? ((BindableObject)obj4).get_BindingContext() : null);
							}
						}
					}
					return obj as ViewModelBase;
				}
				return ((BindableObject)((NavigableElement)customNavigationView).get_Navigation().get_NavigationStack()[((NavigableElement)customNavigationView).get_Navigation().get_NavigationStack().Count - 1]).get_BindingContext() as ViewModelBase;
			}
		}

		public ViewModelBase CurrentViewModel
		{
			get
			{
				CustomNavigationView customNavigationView = Application.get_Current().get_MainPage() as CustomNavigationView;
				if (((NavigableElement)customNavigationView).get_Navigation().get_ModalStack().Any())
				{
					object obj;
					if (customNavigationView == null)
					{
						obj = null;
					}
					else
					{
						INavigation navigation = ((NavigableElement)customNavigationView).get_Navigation();
						if (navigation == null)
						{
							obj = null;
						}
						else
						{
							IReadOnlyList<Page> modalStack = navigation.get_ModalStack();
							if (modalStack == null)
							{
								obj = null;
							}
							else
							{
								INavigation navigation2 = ((NavigableElement)modalStack.LastOrDefault()).get_Navigation();
								if (navigation2 == null)
								{
									obj = null;
								}
								else
								{
									Page obj2 = navigation2.get_NavigationStack().LastOrDefault();
									obj = ((obj2 != null) ? ((BindableObject)obj2).get_BindingContext() : null);
								}
							}
						}
					}
					return obj as ViewModelBase;
				}
				object obj3;
				if (customNavigationView == null)
				{
					obj3 = null;
				}
				else
				{
					INavigation navigation3 = ((NavigableElement)customNavigationView).get_Navigation();
					if (navigation3 == null)
					{
						obj3 = null;
					}
					else
					{
						IReadOnlyList<Page> navigationStack = navigation3.get_NavigationStack();
						obj3 = ((navigationStack != null) ? ((BindableObject)navigationStack.LastOrDefault()).get_BindingContext() : null);
					}
				}
				return obj3 as ViewModelBase;
			}
		}

		public Task InitializeAsync()
		{
			return NavigateToAsync<LoginViewModel>();
		}

		public async Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
		{
			await InternalNavigateToAsync(typeof(TViewModel), null);
		}

		public async Task NavigateToAsync<TViewModel>(object parameter, TViewModel viewModel) where TViewModel : ViewModelBase
		{
			await InternalNavigateToAsync(typeof(TViewModel), parameter, viewModel);
		}

		public Task PushModalAsync<TViewModel>() where TViewModel : ViewModelBase
		{
			return InternalPushModalAsync(typeof(TViewModel), null);
		}

		public Task PushModalAsync<TViewModel>(object parameter, TViewModel viewModel) where TViewModel : ViewModelBase
		{
			return InternalPushModalAsync(typeof(TViewModel), parameter, viewModel);
		}

		public Task PushSingleErrorModal(object parameter, ErrorViewModel viewModel)
		{
			return InternalPushSingleErrorModalAsync(parameter, viewModel);
		}

		public Task PopAsync()
		{
			CustomNavigationView mainPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (((NavigableElement)mainPage).get_Navigation().get_ModalStack().Any())
			{
				mainPage = ((NavigableElement)mainPage).get_Navigation().get_ModalStack().LastOrDefault() as CustomNavigationView;
			}
			if (((NavigableElement)mainPage).get_Navigation().get_NavigationStack().Any())
			{
				Device.BeginInvokeOnMainThread((Action)delegate
				{
					((NavigableElement)mainPage).get_Navigation().PopAsync();
				});
			}
			return Task.FromResult(result: true);
		}

		public Task PopToRootAsync()
		{
			CustomNavigationView mainPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (((NavigableElement)mainPage).get_Navigation().get_ModalStack().Any())
			{
				mainPage = ((NavigableElement)mainPage).get_Navigation().get_ModalStack().LastOrDefault() as CustomNavigationView;
			}
			if (((NavigableElement)mainPage).get_Navigation().get_NavigationStack().Any())
			{
				Device.BeginInvokeOnMainThread((Action)delegate
				{
					((NavigableElement)mainPage).get_Navigation().PopToRootAsync();
				});
			}
			return Task.FromResult(result: true);
		}

		public Task PopModalAsync()
		{
			CustomNavigationView mainPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (((NavigableElement)mainPage).get_Navigation().get_ModalStack().Any())
			{
				Device.BeginInvokeOnMainThread((Action)delegate
				{
					((NavigableElement)mainPage).get_Navigation().PopModalAsync();
				});
			}
			return Task.FromResult(result: true);
		}

		public Task PopPreviousAsync()
		{
			CustomNavigationView mainPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (((NavigableElement)mainPage).get_Navigation().get_ModalStack().Any())
			{
				mainPage = ((NavigableElement)mainPage).get_Navigation().get_ModalStack().LastOrDefault() as CustomNavigationView;
			}
			if (mainPage != null && ((NavigableElement)mainPage).get_Navigation().get_NavigationStack().Count > 1)
			{
				Device.BeginInvokeOnMainThread((Action)delegate
				{
					((NavigableElement)mainPage).get_Navigation().RemovePage(((NavigableElement)mainPage).get_Navigation().get_NavigationStack()[((NavigableElement)mainPage).get_Navigation().get_NavigationStack().Count - 2]);
				});
			}
			return Task.FromResult(result: true);
		}

		public Task PopAllPreviousAsync()
		{
			CustomNavigationView mainPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (((NavigableElement)mainPage).get_Navigation().get_ModalStack().Any())
			{
				mainPage = ((NavigableElement)mainPage).get_Navigation().get_ModalStack().LastOrDefault() as CustomNavigationView;
			}
			if (mainPage != null && ((NavigableElement)mainPage).get_Navigation().get_NavigationStack().Count > 1)
			{
				for (int i = 0; i < ((NavigableElement)mainPage).get_Navigation().get_NavigationStack().Count - 1; i++)
				{
					Page page = ((NavigableElement)mainPage).get_Navigation().get_NavigationStack()[i];
					Device.BeginInvokeOnMainThread((Action)delegate
					{
						((NavigableElement)mainPage).get_Navigation().RemovePage(page);
					});
				}
			}
			return Task.FromResult(result: true);
		}

		private async Task InternalNavigateToAsync(Type viewModelType, object parameter, object viewModel = null)
		{
			List<Task> list = new List<Task>();
			Page page = CreatePage(viewModelType);
			if (viewModel != null)
			{
				((BindableObject)page).set_BindingContext(viewModel);
			}
			if (page is IMainView && (!(page is OnboardingView) || !(((NavigationPage)/*isinst with value type is only supported in some contexts*/).get_RootPage() is OnboardingView)))
			{
				Application.get_Current().set_MainPage((Page)(object)new CustomNavigationView(page));
			}
			else
			{
				CustomNavigationView navigationPage = Application.get_Current().get_MainPage() as CustomNavigationView;
				CustomNavigationView customNavigationView = navigationPage;
				bool? obj;
				if (customNavigationView == null)
				{
					obj = null;
				}
				else
				{
					INavigation navigation = ((NavigableElement)customNavigationView).get_Navigation();
					obj = ((navigation == null) ? null : navigation.get_ModalStack()?.Any());
				}
				bool? flag = obj;
				if (flag.GetValueOrDefault())
				{
					INavigation navigation2 = ((NavigableElement)navigationPage).get_Navigation();
					navigationPage = ((navigation2 == null) ? null : navigation2.get_ModalStack()?.LastOrDefault()) as CustomNavigationView;
				}
				if (navigationPage != null)
				{
					list.Add(Device.InvokeOnMainThreadAsync((Func<Task>)async delegate
					{
						await ((NavigationPage)navigationPage).PushAsync(page);
					}));
				}
				else
				{
					Application.get_Current().set_MainPage((Page)(object)new CustomNavigationView(page));
				}
			}
			list.Add(Task.Run(() => (((BindableObject)page).get_BindingContext() as ViewModelBase).InitializeAsync(parameter)));
			await Task.WhenAll(list);
		}

		private async Task InternalPushModalAsync(Type viewModelType, object parameter, object viewModel = null)
		{
			Page page = CreatePage(viewModelType);
			if (viewModel != null)
			{
				((BindableObject)page).set_BindingContext(viewModel);
			}
			CustomNavigationView navigationPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (navigationPage != null)
			{
				await Device.InvokeOnMainThreadAsync((Func<Task>)async delegate
				{
					await ((NavigableElement)navigationPage).get_Navigation().PushModalAsync((Page)(object)new CustomNavigationView(page));
				});
			}
			await Task.Run(() => (((BindableObject)page).get_BindingContext() as ViewModelBase).InitializeAsync(parameter));
		}

		private async Task InternalPushSingleErrorModalAsync(object parameter, ErrorViewModel viewModel = null)
		{
			Page page = CreatePage(((object)viewModel).GetType());
			if (viewModel != null)
			{
				((BindableObject)page).set_BindingContext((object)viewModel);
			}
			CustomNavigationView navigationPage = Application.get_Current().get_MainPage() as CustomNavigationView;
			if (navigationPage != null)
			{
				if (NetworkConnectivityHelper.InternetIsDisconnected())
				{
					await PushModalAsync(null, new ConnectionAlertViewModel(ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
					{
						RetryCommand = viewModel.PerformWorkCommand
					});
					return;
				}
				if (((NavigableElement)navigationPage).get_Navigation().get_ModalStack().Any())
				{
					INavigation navigation = ((NavigableElement)navigationPage).get_Navigation();
					CustomNavigationView customNavigationView = ((navigation != null) ? navigation.get_ModalStack().Last() : null) as CustomNavigationView;
					if (customNavigationView != null && ((object)((NavigationPage)customNavigationView).get_RootPage()).GetType() == typeof(ErrorView))
					{
						return;
					}
				}
				await Device.InvokeOnMainThreadAsync((Func<Task>)async delegate
				{
					await ((NavigableElement)navigationPage).get_Navigation().PushModalAsync((Page)(object)new CustomNavigationView(page));
				});
			}
			await Task.Run(() => (((BindableObject)page).get_BindingContext() as ViewModelBase).InitializeAsync(parameter));
		}

		private Type GetPageTypeForViewModel(Type viewModelType)
		{
			string arg = viewModelType.FullName!.Replace("Model", string.Empty);
			string fullName = viewModelType.GetTypeInfo().Assembly.FullName;
			return Type.GetType(string.Format(CultureInfo.InvariantCulture, "{0}, {1}", arg, fullName));
		}

		private Page CreatePage(Type viewModelType)
		{
			Type pageTypeForViewModel = GetPageTypeForViewModel(viewModelType);
			if (pageTypeForViewModel == null)
			{
				throw new Exception($"Cannot locate page type for {viewModelType}");
			}
			object? obj = Activator.CreateInstance(pageTypeForViewModel);
			return (Page)((obj is Page) ? obj : null);
		}
	}
}
