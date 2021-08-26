using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views.Base
{
	[XamlFilePath("Views/Base/BaseView.xaml")]
	public class BaseView : ContentPage, INotifyPropertyChanged
	{
		private readonly string internalPageName;

		private double pagewidth;

		private double pageheight;

		private bool deviceLandscape;

		public BaseView()
			: this()
		{
			internalPageName = ((object)this).GetType().Name;
			Page.SetModalPresentationStyle(((Page)this).On<iOS>(), (UIModalPresentationStyle)3);
			InitializeComponent();
		}

		public void OnLandscape()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			Thickness val = Page.SafeAreaInsets(((Page)this).On<iOS>());
			object obj = ((Element)this).FindByName("containingView");
			if (obj != null)
			{
				StackLayout val2 = (StackLayout)((obj is StackLayout) ? obj : null);
				if (val2 != null)
				{
					((Layout)val2).set_Padding(new Thickness(((Thickness)(ref val)).get_Left(), 0.0));
				}
			}
		}

		public void OnPortrait()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			StackLayout val = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			if (val != null && val != null)
			{
				StackLayout val2 = val;
				((Layout)val2).set_Padding(Thickness.op_Implicit(0.0));
			}
		}

		public void OnLandscapeLargeScreen()
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			StackLayout val = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			if (val != null && val != null)
			{
				StackLayout val2 = val;
				((Layout)val2).set_Padding(new Thickness(152.0, 80.0, 152.0, 0.0));
			}
		}

		public void OnPortraitLargeScreen()
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			StackLayout val = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			if (val != null && val != null)
			{
				StackLayout val2 = val;
				((Layout)val2).set_Padding(new Thickness(152.0, 80.0, 152.0, 0.0));
			}
		}

		protected override void OnAppearing()
		{
			((Page)this).OnAppearing();
			if (Device.get_RuntimePlatform() == "iOS")
			{
				SetInsets(deviceLandscape);
			}
			Task.Run(delegate
			{
				Analytics.TrackEvent(internalPageName, (IDictionary<string, string>)null);
			});
		}

		protected override void OnSizeAllocated(double width, double height)
		{
			((Page)this).OnSizeAllocated(width, height);
			if (width != pagewidth || height != pageheight)
			{
				pagewidth = width;
				pageheight = height;
				deviceLandscape = width > height;
				SetInsets(width > height);
			}
		}

		private void SetInsets(bool landscape)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Invalid comparison between Unknown and I4
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Invalid comparison between Unknown and I4
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Invalid comparison between Unknown and I4
			if (landscape)
			{
				Thickness val = Page.SafeAreaInsets(((Page)this).On<iOS>());
				if (((Thickness)(ref val)).get_Left() > 0.0)
				{
					Page.SetUseSafeArea(((Page)this).On<iOS>(), false);
				}
				if (Device.get_RuntimePlatform() == "iOS")
				{
					OnLandscape();
				}
				if ((int)Device.get_Idiom() == 2 || (int)Device.get_Idiom() == 3)
				{
					OnLandscapeLargeScreen();
				}
			}
			else
			{
				Page.SetUseSafeArea(((Page)this).On<iOS>(), false);
				if (Device.get_RuntimePlatform() == "iOS")
				{
					OnPortrait();
				}
				if ((int)Device.get_Idiom() == 2 || (int)Device.get_Idiom() == 3)
				{
					OnPortraitLargeScreen();
				}
			}
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00c7: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0157: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(BaseView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/Base/BaseView.xaml");
				val.set_Instance((object)this);
				if (ResourceLoader.CanProvideContentFor(val))
				{
					__InitComponentRuntime();
					return;
				}
			}
			if (XamlLoader.get_XamlFileProvider() != null && XamlLoader.get_XamlFileProvider()(((object)this).GetType()) != null)
			{
				__InitComponentRuntime();
				return;
			}
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			BaseView baseView;
			NameScope val3 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(baseView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)baseView, (INameScope)(object)val3);
			val2.set_Key("BackgroundColor");
			XamlServiceProvider val4 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = baseView;
			SimpleValueTargetProvider val5 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val3);
			object obj = (object)val5;
			val4.Add(typeFromHandle, (object)val5);
			val4.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val6 = new XmlNamespaceResolver();
			val6.Add("", "http://xamarin.com/schemas/2014/forms");
			val6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val6.Add("ios", "clr-namespace:Xamarin.Forms.PlatformConfiguration.iOSSpecific;assembly=Xamarin.Forms.Core");
			val4.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val6, typeof(BaseView).GetTypeInfo().Assembly));
			val4.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(7, 5)));
			DynamicResource val7 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val4);
			((IDynamicResourceHandler)baseView).SetDynamicResource(VisualElement.BackgroundColorProperty, val7.get_Key());
			((BindableObject)baseView).SetValue(Page.ModalPresentationStyleProperty, (object)(UIModalPresentationStyle)3);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<BaseView>(this, typeof(BaseView));
		}
	}
}
