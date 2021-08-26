using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views.Base
{
	[XamlFilePath("Views/Base/CustomNavigationView.xaml")]
	public class CustomNavigationView : NavigationPage
	{
		public CustomNavigationView()
			: this()
		{
			InitializeComponent();
		}

		public CustomNavigationView(Page root)
			: this(root)
		{
			InitializeComponent();
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
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00ce: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_015f: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01ae: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected O, but got Unknown
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected O, but got Unknown
			//IL_0240: Expected O, but got Unknown
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(CustomNavigationView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/Base/CustomNavigationView.xaml");
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
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			CustomNavigationView customNavigationView;
			NameScope val4 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(customNavigationView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)customNavigationView, (INameScope)(object)val4);
			val2.set_Key("NavigationBarColor");
			XamlServiceProvider val5 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = customNavigationView;
			SimpleValueTargetProvider val6 = new SimpleValueTargetProvider(array, (object)NavigationPage.BarBackgroundColorProperty, (INameScope)(object)val4);
			object obj = (object)val6;
			val5.Add(typeFromHandle, (object)val6);
			val5.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val7 = new XmlNamespaceResolver();
			val7.Add("", "http://xamarin.com/schemas/2014/forms");
			val7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val7.Add("ios", "clr-namespace:Xamarin.Forms.PlatformConfiguration.iOSSpecific;assembly=Xamarin.Forms.Core");
			val5.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val7, typeof(CustomNavigationView).GetTypeInfo().Assembly));
			val5.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 5)));
			DynamicResource val8 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val5);
			((IDynamicResourceHandler)customNavigationView).SetDynamicResource(NavigationPage.BarBackgroundColorProperty, val8.get_Key());
			val3.set_Key("PrimaryTextColor");
			XamlServiceProvider val9 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = customNavigationView;
			SimpleValueTargetProvider val10 = new SimpleValueTargetProvider(array2, (object)NavigationPage.BarTextColorProperty, (INameScope)(object)val4);
			object obj2 = (object)val10;
			val9.Add(typeFromHandle3, (object)val10);
			val9.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val11 = new XmlNamespaceResolver();
			val11.Add("", "http://xamarin.com/schemas/2014/forms");
			val11.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val11.Add("ios", "clr-namespace:Xamarin.Forms.PlatformConfiguration.iOSSpecific;assembly=Xamarin.Forms.Core");
			val9.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val11, typeof(CustomNavigationView).GetTypeInfo().Assembly));
			val9.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(9, 5)));
			DynamicResource val12 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val9);
			((IDynamicResourceHandler)customNavigationView).SetDynamicResource(NavigationPage.BarTextColorProperty, val12.get_Key());
			((BindableObject)customNavigationView).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			((BindableObject)customNavigationView).SetValue(Page.ModalPresentationStyleProperty, (object)(UIModalPresentationStyle)4);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<CustomNavigationView>(this, typeof(CustomNavigationView));
		}
	}
}
