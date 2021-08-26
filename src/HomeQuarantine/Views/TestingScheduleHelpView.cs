using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Services.Modals;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/TestingScheduleHelpView.xaml")]
	public class TestingScheduleHelpView : BaseView, IModalPage
	{
		public bool ShowDismiss => true;

		public TestingScheduleHelpView()
		{
			InitializeComponent();
		}

		public async Task Dismiss()
		{
			await ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().PopModalAsync();
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
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_0193: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected O, but got Unknown
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Expected O, but got Unknown
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected O, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected O, but got Unknown
			//IL_0245: Expected O, but got Unknown
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Expected O, but got Unknown
			//IL_02ae: Expected O, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected O, but got Unknown
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected O, but got Unknown
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Expected O, but got Unknown
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Expected O, but got Unknown
			//IL_0361: Expected O, but got Unknown
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Expected O, but got Unknown
			//IL_041a: Expected O, but got Unknown
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Expected O, but got Unknown
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected O, but got Unknown
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected O, but got Unknown
			//IL_04be: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c8: Expected O, but got Unknown
			//IL_04cd: Expected O, but got Unknown
			//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_0539: Expected O, but got Unknown
			//IL_053e: Expected O, but got Unknown
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0570: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Expected O, but got Unknown
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ce: Expected O, but got Unknown
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Expected O, but got Unknown
			//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Expected O, but got Unknown
			//IL_05f1: Expected O, but got Unknown
			//IL_060d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0631: Unknown result type (might be due to invalid IL or missing references)
			//IL_0687: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_076e: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_080d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Unknown result type (might be due to invalid IL or missing references)
			//IL_0815: Expected O, but got Unknown
			//IL_081a: Expected O, but got Unknown
			//IL_081a: Unknown result type (might be due to invalid IL or missing references)
			//IL_082c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_084c: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_086c: Unknown result type (might be due to invalid IL or missing references)
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a5: Expected O, but got Unknown
			//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08aa: Expected O, but got Unknown
			//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c3: Expected O, but got Unknown
			//IL_08be: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c8: Expected O, but got Unknown
			//IL_08cd: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(TestingScheduleHelpView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/TestingScheduleHelpView.xaml");
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
			string testingScheduleHelpView_Help = Resources.TestingScheduleHelpView_Help;
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			BoxView val5 = new BoxView();
			DynamicResourceExtension val6 = new DynamicResourceExtension();
			string testingScheduleView_WhatIfIMissACheckInOrTest = Resources.TestingScheduleView_WhatIfIMissACheckInOrTest;
			Label val7 = new Label();
			string testingScheduleHelpView_Description = Resources.TestingScheduleHelpView_Description1;
			Label val8 = new Label();
			string testingScheduleHelpView_Description2 = Resources.TestingScheduleHelpView_Description2;
			Label val9 = new Label();
			string testingScheduleHelpView_Description3 = Resources.TestingScheduleHelpView_Description3;
			Label val10 = new Label();
			string testingScheduleCalendar_ContactPerson = Resources.TestingScheduleCalendar_ContactPerson;
			Span val11 = new Span();
			string testingScheduleCalendar_ContactNumber = Resources.TestingScheduleCalendar_ContactNumber;
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			Span val13 = new Span();
			string testingScheduleCalendar_ContactTime = Resources.TestingScheduleCalendar_ContactTime;
			Span val14 = new Span();
			FormattedString val15 = new FormattedString();
			BindingExtension val16 = new BindingExtension();
			TapGestureRecognizer val17 = new TapGestureRecognizer();
			Label val18 = new Label();
			StackLayout val19 = new StackLayout();
			ScrollView val20 = new ScrollView();
			TestingScheduleHelpView testingScheduleHelpView;
			NameScope val21 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(testingScheduleHelpView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)testingScheduleHelpView, (INameScope)(object)val21);
			((BindableObject)testingScheduleHelpView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Key("BackgroundColor");
			XamlServiceProvider val22 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = testingScheduleHelpView;
			SimpleValueTargetProvider val23 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val21);
			object obj = (object)val23;
			val22.Add(typeFromHandle, (object)val23);
			val22.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val24 = new XmlNamespaceResolver();
			val24.Add("", "http://xamarin.com/schemas/2014/forms");
			val24.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val24.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val24.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val24.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val22.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val24, typeof(TestingScheduleHelpView).GetTypeInfo().Assembly));
			val22.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 5)));
			DynamicResource val25 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val22);
			((IDynamicResourceHandler)testingScheduleHelpView).SetDynamicResource(VisualElement.BackgroundColorProperty, val25.get_Key());
			((BindableObject)testingScheduleHelpView).SetValue(Page.TitleProperty, (object)testingScheduleHelpView_Help);
			val3.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val26 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 3];
			array2[0] = val19;
			array2[1] = val20;
			array2[2] = testingScheduleHelpView;
			SimpleValueTargetProvider val27 = new SimpleValueTargetProvider(array2, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val21);
			object obj2 = (object)val27;
			val26.Add(typeFromHandle3, (object)val27);
			val26.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val28 = new XmlNamespaceResolver();
			val28.Add("", "http://xamarin.com/schemas/2014/forms");
			val28.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val28.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val28.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val28.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val26.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val28, typeof(TestingScheduleHelpView).GetTypeInfo().Assembly));
			val26.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(13, 22)));
			DynamicResource val29 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val26);
			((IDynamicResourceHandler)val19).SetDynamicResource(VisualElement.BackgroundColorProperty, val29.get_Key());
			((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)val19).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0));
			((BindableObject)val5).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val4.set_Key("PrimaryColor");
			XamlServiceProvider val30 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 4];
			array3[0] = val5;
			array3[1] = val19;
			array3[2] = val20;
			array3[3] = testingScheduleHelpView;
			SimpleValueTargetProvider val31 = new SimpleValueTargetProvider(array3, (object)BoxView.ColorProperty, (INameScope)(object)val21);
			object obj3 = (object)val31;
			val30.Add(typeFromHandle5, (object)val31);
			val30.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val32 = new XmlNamespaceResolver();
			val32.Add("", "http://xamarin.com/schemas/2014/forms");
			val32.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val32.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val32.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val32.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val30.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val32, typeof(TestingScheduleHelpView).GetTypeInfo().Assembly));
			val30.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 22)));
			DynamicResource val33 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val30);
			((IDynamicResourceHandler)val5).SetDynamicResource(BoxView.ColorProperty, val33.get_Key());
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val5);
			val6.set_Key("Heading1");
			XamlServiceProvider val34 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 4];
			array4[0] = val7;
			array4[1] = val19;
			array4[2] = val20;
			array4[3] = testingScheduleHelpView;
			SimpleValueTargetProvider val35 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val21);
			object obj4 = (object)val35;
			val34.Add(typeFromHandle7, (object)val35);
			val34.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val36 = new XmlNamespaceResolver();
			val36.Add("", "http://xamarin.com/schemas/2014/forms");
			val36.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val36.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val36.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val36.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val34.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val36, typeof(TestingScheduleHelpView).GetTypeInfo().Assembly));
			val34.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 20)));
			DynamicResource val37 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val34);
			((IDynamicResourceHandler)val7).SetDynamicResource(VisualElement.StyleProperty, val37.get_Key());
			((BindableObject)val7).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val7).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val7).SetValue(Label.TextProperty, (object)testingScheduleView_WhatIfIMissACheckInOrTest);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val7);
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 8.0));
			((BindableObject)val8).SetValue(Label.TextProperty, (object)testingScheduleHelpView_Description);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val8);
			((BindableObject)val9).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 8.0));
			((BindableObject)val9).SetValue(Label.TextProperty, (object)testingScheduleHelpView_Description2);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val9);
			((BindableObject)val10).SetValue(Label.PaddingProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)val10).SetValue(Label.TextProperty, (object)testingScheduleHelpView_Description3);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val10);
			((BindableObject)val18).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val11).SetValue(Span.TextProperty, (object)testingScheduleCalendar_ContactPerson);
			val15.get_Spans().Add(val11);
			((BindableObject)val13).SetValue(Span.TextProperty, (object)testingScheduleCalendar_ContactNumber);
			((BindableObject)val13).SetValue(Span.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val12.set_Key("SecondaryLinkColor");
			XamlServiceProvider val38 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 6];
			array5[0] = val13;
			array5[1] = val15;
			array5[2] = val18;
			array5[3] = val19;
			array5[4] = val20;
			array5[5] = testingScheduleHelpView;
			SimpleValueTargetProvider val39 = new SimpleValueTargetProvider(array5, (object)Span.TextColorProperty, (INameScope)(object)val21);
			object obj5 = (object)val39;
			val38.Add(typeFromHandle9, (object)val39);
			val38.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val40 = new XmlNamespaceResolver();
			val40.Add("", "http://xamarin.com/schemas/2014/forms");
			val40.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val40.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val40.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val40.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val38.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val40, typeof(TestingScheduleHelpView).GetTypeInfo().Assembly));
			val38.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 29)));
			DynamicResource val41 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val38);
			((IDynamicResourceHandler)val13).SetDynamicResource(Span.TextColorProperty, val41.get_Key());
			val15.get_Spans().Add(val13);
			((BindableObject)val14).SetValue(Span.TextProperty, (object)testingScheduleCalendar_ContactTime);
			val15.get_Spans().Add(val14);
			((BindableObject)val18).SetValue(Label.FormattedTextProperty, (object)val15);
			val16.set_Path("CallHelpCommand");
			BindingBase val42 = ((IMarkupExtension<BindingBase>)(object)val16).ProvideValue((IServiceProvider)null);
			((BindableObject)val17).SetBinding(TapGestureRecognizer.CommandProperty, val42);
			((View)val18).get_GestureRecognizers().Add((IGestureRecognizer)(object)val17);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			val20.set_Content((View)(object)val19);
			((BindableObject)testingScheduleHelpView).SetValue(ContentPage.ContentProperty, (object)val20);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<TestingScheduleHelpView>(this, typeof(TestingScheduleHelpView));
		}
	}
}
