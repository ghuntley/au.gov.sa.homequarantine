using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Services.Modals;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/HasSymptomResultView.xaml")]
	public class HasSymptomResultView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label whatHappensNext;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label symptomsChosenSubtitle;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label symptomsSubtitle2;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label symptomsSubtitle1;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label covidTestingLocations;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label testingLocationDetails;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label testingLocationDetails2;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView testingLocationsUrl;

		public bool ShowDismiss => true;

		public HasSymptomResultView()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			(((BindableObject)this).get_BindingContext() as HasSymptomResultViewModel).PopAllPreviousPagesCommand.Execute(null);
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
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Unknown result type (might be due to invalid IL or missing references)
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Expected O, but got Unknown
			//IL_0413: Expected O, but got Unknown
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_0465: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected O, but got Unknown
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected O, but got Unknown
			//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Expected O, but got Unknown
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Expected O, but got Unknown
			//IL_04e6: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Expected O, but got Unknown
			//IL_0577: Expected O, but got Unknown
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0622: Expected O, but got Unknown
			//IL_061d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0627: Expected O, but got Unknown
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Expected O, but got Unknown
			//IL_063b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Expected O, but got Unknown
			//IL_064a: Expected O, but got Unknown
			//IL_0698: Unknown result type (might be due to invalid IL or missing references)
			//IL_0704: Unknown result type (might be due to invalid IL or missing references)
			//IL_075a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07db: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0813: Unknown result type (might be due to invalid IL or missing references)
			//IL_0818: Unknown result type (might be due to invalid IL or missing references)
			//IL_081b: Expected O, but got Unknown
			//IL_0820: Expected O, but got Unknown
			//IL_0820: Unknown result type (might be due to invalid IL or missing references)
			//IL_0832: Unknown result type (might be due to invalid IL or missing references)
			//IL_083d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Unknown result type (might be due to invalid IL or missing references)
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_0862: Unknown result type (might be due to invalid IL or missing references)
			//IL_0872: Unknown result type (might be due to invalid IL or missing references)
			//IL_0882: Unknown result type (might be due to invalid IL or missing references)
			//IL_0892: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cb: Expected O, but got Unknown
			//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d0: Expected O, but got Unknown
			//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e9: Expected O, but got Unknown
			//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ee: Expected O, but got Unknown
			//IL_08f3: Expected O, but got Unknown
			//IL_0921: Unknown result type (might be due to invalid IL or missing references)
			//IL_095b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0992: Unknown result type (might be due to invalid IL or missing references)
			//IL_0997: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dc: Expected O, but got Unknown
			//IL_09e1: Expected O, but got Unknown
			//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8c: Expected O, but got Unknown
			//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a91: Expected O, but got Unknown
			//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaa: Expected O, but got Unknown
			//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaf: Expected O, but got Unknown
			//IL_0ab4: Expected O, but got Unknown
			//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b90: Expected O, but got Unknown
			//IL_0b95: Expected O, but got Unknown
			//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c40: Expected O, but got Unknown
			//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c45: Expected O, but got Unknown
			//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5e: Expected O, but got Unknown
			//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c63: Expected O, but got Unknown
			//IL_0c68: Expected O, but got Unknown
			//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(HasSymptomResultView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/HasSymptomResultView.xaml");
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
			string hasSymptomView_MonitoringSymptoms = Resources.HasSymptomView_MonitoringSymptoms;
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			string hasSymptomView_Title = Resources.HasSymptomView_Title;
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			Label val3 = new Label();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			string hasSymptomView_WhatHappensNext = Resources.HasSymptomView_WhatHappensNext;
			Label val5 = new Label();
			BindingExtension val6 = new BindingExtension();
			Label val7 = new Label();
			string hasSymptomView_FollowTheirAdviceTheyWillTellYou = Resources.HasSymptomView_FollowTheirAdviceTheyWillTellYou;
			Label val8 = new Label();
			string hasSymptomView_IfYouDevelopSymptomsWhileInHomeQuarantine = Resources.HasSymptomView_IfYouDevelopSymptomsWhileInHomeQuarantine;
			Label val9 = new Label();
			DynamicResourceExtension val10 = new DynamicResourceExtension();
			DynamicResourceExtension val11 = new DynamicResourceExtension();
			BoxView val12 = new BoxView();
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			string hasSymptomView_CovidTestingLocations = Resources.HasSymptomView_CovidTestingLocations;
			Label val14 = new Label();
			string hasSymptomView_TestingLocationSubtitle = Resources.HasSymptomView_TestingLocationSubtitle1;
			Label val15 = new Label();
			string hasSymptomView_TestingLocationSubtitle2 = Resources.HasSymptomView_TestingLocationSubtitle2;
			Label val16 = new Label();
			string hasSymptomView_TestingLocations = Resources.HasSymptomView_TestingLocations;
			BindingExtension val17 = new BindingExtension();
			ResourceLinkView resourceLinkView = new ResourceLinkView();
			StackLayout val18 = new StackLayout();
			StackLayout val19 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val20 = new StackLayout();
			ScrollView val21 = new ScrollView();
			StackLayout val22 = new StackLayout();
			HasSymptomResultView hasSymptomResultView;
			NameScope val23 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(hasSymptomResultView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)hasSymptomResultView, (INameScope)(object)val23);
			((INameScope)val23).RegisterName("containingView", (object)val22);
			if (((Element)val22).get_StyleId() == null)
			{
				((Element)val22).set_StyleId("containingView");
			}
			((INameScope)val23).RegisterName("whatHappensNext", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("whatHappensNext");
			}
			((INameScope)val23).RegisterName("symptomsChosenSubtitle", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("symptomsChosenSubtitle");
			}
			((INameScope)val23).RegisterName("symptomsSubtitle2", (object)val8);
			if (((Element)val8).get_StyleId() == null)
			{
				((Element)val8).set_StyleId("symptomsSubtitle2");
			}
			((INameScope)val23).RegisterName("symptomsSubtitle1", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("symptomsSubtitle1");
			}
			((INameScope)val23).RegisterName("covidTestingLocations", (object)val14);
			if (((Element)val14).get_StyleId() == null)
			{
				((Element)val14).set_StyleId("covidTestingLocations");
			}
			((INameScope)val23).RegisterName("testingLocationDetails", (object)val15);
			if (((Element)val15).get_StyleId() == null)
			{
				((Element)val15).set_StyleId("testingLocationDetails");
			}
			((INameScope)val23).RegisterName("testingLocationDetails2", (object)val16);
			if (((Element)val16).get_StyleId() == null)
			{
				((Element)val16).set_StyleId("testingLocationDetails2");
			}
			((INameScope)val23).RegisterName("testingLocationsUrl", (object)resourceLinkView);
			if (((Element)resourceLinkView).get_StyleId() == null)
			{
				((Element)resourceLinkView).set_StyleId("testingLocationsUrl");
			}
			containingView = val22;
			whatHappensNext = val5;
			symptomsChosenSubtitle = val7;
			symptomsSubtitle2 = val8;
			symptomsSubtitle1 = val9;
			covidTestingLocations = val14;
			testingLocationDetails = val15;
			testingLocationDetails2 = val16;
			testingLocationsUrl = resourceLinkView;
			((BindableObject)hasSymptomResultView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)hasSymptomResultView).SetValue(Page.TitleProperty, (object)hasSymptomView_MonitoringSymptoms);
			((VisualElement)hasSymptomResultView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)hasSymptomResultView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val20).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val20).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0, 16.0, 16.0));
			((BindableObject)val3).SetValue(Label.TextProperty, (object)hasSymptomView_Title);
			((BindableObject)val3).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val2.set_Key("Heading1");
			XamlServiceProvider val24 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = val3;
			array[1] = val20;
			array[2] = val21;
			array[3] = val22;
			array[4] = hasSymptomResultView;
			SimpleValueTargetProvider val25 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val23);
			object obj = (object)val25;
			val24.Add(typeFromHandle, (object)val25);
			val24.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val26 = new XmlNamespaceResolver();
			val26.Add("", "http://xamarin.com/schemas/2014/forms");
			val26.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val26.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val26.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val26.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val26.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val26.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val24.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val26, typeof(HasSymptomResultView).GetTypeInfo().Assembly));
			val24.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 21)));
			DynamicResource val27 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val24);
			((IDynamicResourceHandler)val3).SetDynamicResource(VisualElement.StyleProperty, val27.get_Key());
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val3);
			((BindableObject)val5).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val4.set_Key("Heading2");
			XamlServiceProvider val28 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 5];
			array2[0] = val5;
			array2[1] = val20;
			array2[2] = val21;
			array2[3] = val22;
			array2[4] = hasSymptomResultView;
			SimpleValueTargetProvider val29 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val23);
			object obj2 = (object)val29;
			val28.Add(typeFromHandle3, (object)val29);
			val28.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val30 = new XmlNamespaceResolver();
			val30.Add("", "http://xamarin.com/schemas/2014/forms");
			val30.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val30.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val30.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val30.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val30.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val30.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val28.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val30, typeof(HasSymptomResultView).GetTypeInfo().Assembly));
			val28.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 24)));
			DynamicResource val31 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val28);
			((IDynamicResourceHandler)val5).SetDynamicResource(VisualElement.StyleProperty, val31.get_Key());
			((BindableObject)val5).SetValue(Label.TextProperty, (object)hasSymptomView_WhatHappensNext);
			((BindableObject)val5).SetValue(View.MarginProperty, (object)new Thickness(0.0, 8.0, 0.0, 0.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val5);
			val6.set_Path("SymptomsChosenSubtitle");
			BindingBase val32 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)null);
			((BindableObject)val7).SetBinding(Label.TextProperty, val32);
			((BindableObject)val7).SetValue(View.MarginProperty, (object)new Thickness(0.0, 4.0, 0.0, 0.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val7);
			((BindableObject)val8).SetValue(Label.TextProperty, (object)hasSymptomView_FollowTheirAdviceTheyWillTellYou);
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(0.0, 4.0, 0.0, 0.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val8);
			((BindableObject)val9).SetValue(Label.TextProperty, (object)hasSymptomView_IfYouDevelopSymptomsWhileInHomeQuarantine);
			((BindableObject)val9).SetValue(View.MarginProperty, (object)new Thickness(0.0, 4.0, 0.0, 0.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val9);
			val10.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val33 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 5];
			array3[0] = shadowFrame;
			array3[1] = val20;
			array3[2] = val21;
			array3[3] = val22;
			array3[4] = hasSymptomResultView;
			SimpleValueTargetProvider val34 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val23);
			object obj3 = (object)val34;
			val33.Add(typeFromHandle5, (object)val34);
			val33.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val35 = new XmlNamespaceResolver();
			val35.Add("", "http://xamarin.com/schemas/2014/forms");
			val35.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val35.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val35.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val35.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val35.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val35.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val33.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val35, typeof(HasSymptomResultView).GetTypeInfo().Assembly));
			val33.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 21)));
			DynamicResource val36 = ((IMarkupExtension<DynamicResource>)(object)val10).ProvideValue((IServiceProvider)val33);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val36.get_Key());
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 24.0));
			((BindableObject)val19).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val11.set_Key("PrimaryColor");
			XamlServiceProvider val37 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 7];
			array4[0] = val12;
			array4[1] = val19;
			array4[2] = shadowFrame;
			array4[3] = val20;
			array4[4] = val21;
			array4[5] = val22;
			array4[6] = hasSymptomResultView;
			SimpleValueTargetProvider val38 = new SimpleValueTargetProvider(array4, (object)BoxView.ColorProperty, (INameScope)(object)val23);
			object obj4 = (object)val38;
			val37.Add(typeFromHandle7, (object)val38);
			val37.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val39 = new XmlNamespaceResolver();
			val39.Add("", "http://xamarin.com/schemas/2014/forms");
			val39.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val39.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val39.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val39.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val39.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val39.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val37.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val39, typeof(HasSymptomResultView).GetTypeInfo().Assembly));
			val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 34)));
			DynamicResource val40 = ((IMarkupExtension<DynamicResource>)(object)val11).ProvideValue((IServiceProvider)val37);
			((IDynamicResourceHandler)val12).SetDynamicResource(BoxView.ColorProperty, val40.get_Key());
			((BindableObject)val12).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val12);
			((BindableObject)val18).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val18).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val13.set_Key("Heading2");
			XamlServiceProvider val41 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 8];
			array5[0] = val14;
			array5[1] = val18;
			array5[2] = val19;
			array5[3] = shadowFrame;
			array5[4] = val20;
			array5[5] = val21;
			array5[6] = val22;
			array5[7] = hasSymptomResultView;
			SimpleValueTargetProvider val42 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val23);
			object obj5 = (object)val42;
			val41.Add(typeFromHandle9, (object)val42);
			val41.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val43 = new XmlNamespaceResolver();
			val43.Add("", "http://xamarin.com/schemas/2014/forms");
			val43.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val43.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val43.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val43.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val43.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val43.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val41.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val43, typeof(HasSymptomResultView).GetTypeInfo().Assembly));
			val41.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 33)));
			DynamicResource val44 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val41);
			((IDynamicResourceHandler)val14).SetDynamicResource(VisualElement.StyleProperty, val44.get_Key());
			((BindableObject)val14).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			((BindableObject)val14).SetValue(Label.TextProperty, (object)hasSymptomView_CovidTestingLocations);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val14);
			((BindableObject)val15).SetValue(Label.TextProperty, (object)hasSymptomView_TestingLocationSubtitle);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val15);
			((BindableObject)val16).SetValue(Label.TextProperty, (object)hasSymptomView_TestingLocationSubtitle2);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val16);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.TextProperty, (object)hasSymptomView_TestingLocations);
			val17.set_Path("TestingLocationsUrl");
			BindingBase val45 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.UrlProperty, val45);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((BindableObject)resourceLinkView).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)resourceLinkView);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val19);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)shadowFrame);
			val21.set_Content((View)(object)val20);
			((Layout<View>)(object)val22).get_Children().Add((View)(object)val21);
			((BindableObject)hasSymptomResultView).SetValue(ContentPage.ContentProperty, (object)val22);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<HasSymptomResultView>(this, typeof(HasSymptomResultView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			whatHappensNext = NameScopeExtensions.FindByName<Label>((Element)(object)this, "whatHappensNext");
			symptomsChosenSubtitle = NameScopeExtensions.FindByName<Label>((Element)(object)this, "symptomsChosenSubtitle");
			symptomsSubtitle2 = NameScopeExtensions.FindByName<Label>((Element)(object)this, "symptomsSubtitle2");
			symptomsSubtitle1 = NameScopeExtensions.FindByName<Label>((Element)(object)this, "symptomsSubtitle1");
			covidTestingLocations = NameScopeExtensions.FindByName<Label>((Element)(object)this, "covidTestingLocations");
			testingLocationDetails = NameScopeExtensions.FindByName<Label>((Element)(object)this, "testingLocationDetails");
			testingLocationDetails2 = NameScopeExtensions.FindByName<Label>((Element)(object)this, "testingLocationDetails2");
			testingLocationsUrl = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "testingLocationsUrl");
		}
	}
}
