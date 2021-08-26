using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/OtherSymptomView.xaml")]
	public class OtherSymptomView : BaseView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label otherSymptomsMainTitle;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TextAreaView description;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label errorMessage;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Button submit;

		public OtherSymptomView()
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
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
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
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b1: Expected O, but got Unknown
			//IL_03b6: Expected O, but got Unknown
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Expected O, but got Unknown
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Expected O, but got Unknown
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Expected O, but got Unknown
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_0489: Expected O, but got Unknown
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_057a: Expected O, but got Unknown
			//IL_057f: Expected O, but got Unknown
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0591: Unknown result type (might be due to invalid IL or missing references)
			//IL_059c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_062a: Expected O, but got Unknown
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Expected O, but got Unknown
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_063e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Expected O, but got Unknown
			//IL_0643: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Expected O, but got Unknown
			//IL_0652: Expected O, but got Unknown
			//IL_068f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06db: Unknown result type (might be due to invalid IL or missing references)
			//IL_06de: Expected O, but got Unknown
			//IL_06e3: Expected O, but got Unknown
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_0705: Unknown result type (might be due to invalid IL or missing references)
			//IL_0715: Unknown result type (might be due to invalid IL or missing references)
			//IL_0725: Unknown result type (might be due to invalid IL or missing references)
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Unknown result type (might be due to invalid IL or missing references)
			//IL_0755: Unknown result type (might be due to invalid IL or missing references)
			//IL_0765: Unknown result type (might be due to invalid IL or missing references)
			//IL_078e: Expected O, but got Unknown
			//IL_0789: Unknown result type (might be due to invalid IL or missing references)
			//IL_0793: Expected O, but got Unknown
			//IL_0793: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Expected O, but got Unknown
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b1: Expected O, but got Unknown
			//IL_07b6: Expected O, but got Unknown
			//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0804: Unknown result type (might be due to invalid IL or missing references)
			//IL_081f: Unknown result type (might be due to invalid IL or missing references)
			//IL_085e: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_093a: Unknown result type (might be due to invalid IL or missing references)
			//IL_097b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0980: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d0: Expected O, but got Unknown
			//IL_09d5: Expected O, but got Unknown
			//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a80: Expected O, but got Unknown
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a85: Expected O, but got Unknown
			//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9e: Expected O, but got Unknown
			//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa3: Expected O, but got Unknown
			//IL_0aa8: Expected O, but got Unknown
			//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b29: Expected O, but got Unknown
			//IL_0b2e: Expected O, but got Unknown
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd9: Expected O, but got Unknown
			//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bde: Expected O, but got Unknown
			//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf7: Expected O, but got Unknown
			//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfc: Expected O, but got Unknown
			//IL_0c01: Expected O, but got Unknown
			//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c79: Expected O, but got Unknown
			//IL_0c7e: Expected O, but got Unknown
			//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d29: Expected O, but got Unknown
			//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2e: Expected O, but got Unknown
			//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d47: Expected O, but got Unknown
			//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4c: Expected O, but got Unknown
			//IL_0d51: Expected O, but got Unknown
			//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(OtherSymptomView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/OtherSymptomView.xaml");
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
			string otherSymptomView_MonitoringSymptoms = Resources.OtherSymptomView_MonitoringSymptoms;
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			BindingExtension val2 = new BindingExtension();
			BindingExtension val3 = new BindingExtension();
			ActivityIndicator val4 = new ActivityIndicator();
			StaticResourceExtension val5 = new StaticResourceExtension();
			BindingExtension val6 = new BindingExtension();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			DynamicResourceExtension val8 = new DynamicResourceExtension();
			BoxView val9 = new BoxView();
			string otherSymptomView_DescribeYourSymptoms = Resources.OtherSymptomView_DescribeYourSymptoms;
			Label val10 = new Label();
			BindingExtension val11 = new BindingExtension();
			TextAreaView textAreaView = new TextAreaView();
			BindingExtension val12 = new BindingExtension();
			BindingExtension val13 = new BindingExtension();
			StaticResourceExtension val14 = new StaticResourceExtension();
			Label val15 = new Label();
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			DynamicResourceExtension val17 = new DynamicResourceExtension();
			string button_Submit = Resources.Button_Submit;
			BindingExtension val18 = new BindingExtension();
			Button val19 = new Button();
			StackLayout val20 = new StackLayout();
			StackLayout val21 = new StackLayout();
			Frame val22 = new Frame();
			StackLayout val23 = new StackLayout();
			StackLayout val24 = new StackLayout();
			ScrollView val25 = new ScrollView();
			StackLayout val26 = new StackLayout();
			OtherSymptomView otherSymptomView;
			NameScope val27 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(otherSymptomView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)otherSymptomView, (INameScope)(object)val27);
			((INameScope)val27).RegisterName("containingView", (object)val24);
			if (((Element)val24).get_StyleId() == null)
			{
				((Element)val24).set_StyleId("containingView");
			}
			((INameScope)val27).RegisterName("otherSymptomsMainTitle", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("otherSymptomsMainTitle");
			}
			((INameScope)val27).RegisterName("description", (object)textAreaView);
			if (((Element)textAreaView).get_StyleId() == null)
			{
				((Element)textAreaView).set_StyleId("description");
			}
			((INameScope)val27).RegisterName("errorMessage", (object)val15);
			if (((Element)val15).get_StyleId() == null)
			{
				((Element)val15).set_StyleId("errorMessage");
			}
			((INameScope)val27).RegisterName("submit", (object)val19);
			if (((Element)val19).get_StyleId() == null)
			{
				((Element)val19).set_StyleId("submit");
			}
			containingView = val24;
			otherSymptomsMainTitle = val10;
			description = textAreaView;
			errorMessage = val15;
			submit = val19;
			((BindableObject)otherSymptomView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)otherSymptomView).SetValue(Page.TitleProperty, (object)otherSymptomView_MonitoringSymptoms);
			((VisualElement)otherSymptomView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)otherSymptomView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val26).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val25).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val4).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			val2.set_Path("IsBusy");
			BindingBase val28 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(ActivityIndicator.IsRunningProperty, val28);
			val3.set_Path("IsBusy");
			BindingBase val29 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(VisualElement.IsVisibleProperty, val29);
			((BindableObject)val4).SetValue(View.MarginProperty, (object)new Thickness(0.0, 24.0, 0.0, 0.0));
			((Layout<View>)(object)val24).get_Children().Add((View)(object)val4);
			val5.set_Key("InverseBoolConverter");
			XamlServiceProvider val30 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 6];
			array[0] = val6;
			array[1] = val23;
			array[2] = val24;
			array[3] = val25;
			array[4] = val26;
			array[5] = otherSymptomView;
			SimpleValueTargetProvider val31 = new SimpleValueTargetProvider(array, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val27);
			object obj = (object)val31;
			val30.Add(typeFromHandle, (object)val31);
			val30.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val32 = new XmlNamespaceResolver();
			val32.Add("", "http://xamarin.com/schemas/2014/forms");
			val32.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val32.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val32.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val32.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val32.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val32.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val30.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val32, typeof(OtherSymptomView).GetTypeInfo().Assembly));
			val30.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 30)));
			object converter = ((IMarkupExtension)val5).ProvideValue((IServiceProvider)val30);
			val6.set_Converter((IValueConverter)converter);
			val6.set_Path("IsBusy");
			BindingBase val33 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)null);
			((BindableObject)val23).SetBinding(VisualElement.IsVisibleProperty, val33);
			((BindableObject)val23).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val22).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val22).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)val22).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0));
			val7.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val34 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 6];
			array2[0] = val22;
			array2[1] = val23;
			array2[2] = val24;
			array2[3] = val25;
			array2[4] = val26;
			array2[5] = otherSymptomView;
			SimpleValueTargetProvider val35 = new SimpleValueTargetProvider(array2, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val27);
			object obj2 = (object)val35;
			val34.Add(typeFromHandle3, (object)val35);
			val34.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val36 = new XmlNamespaceResolver();
			val36.Add("", "http://xamarin.com/schemas/2014/forms");
			val36.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val36.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val36.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val36.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val36.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val36.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val34.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val36, typeof(OtherSymptomView).GetTypeInfo().Assembly));
			val34.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 25)));
			DynamicResource val37 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val34);
			((IDynamicResourceHandler)val22).SetDynamicResource(VisualElement.BackgroundColorProperty, val37.get_Key());
			((BindableObject)val9).SetValue(VisualElement.HeightRequestProperty, (object)4.0);
			val8.set_Key("PrimaryColor");
			XamlServiceProvider val38 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 8];
			array3[0] = val9;
			array3[1] = val21;
			array3[2] = val22;
			array3[3] = val23;
			array3[4] = val24;
			array3[5] = val25;
			array3[6] = val26;
			array3[7] = otherSymptomView;
			SimpleValueTargetProvider val39 = new SimpleValueTargetProvider(array3, (object)BoxView.ColorProperty, (INameScope)(object)val27);
			object obj3 = (object)val39;
			val38.Add(typeFromHandle5, (object)val39);
			val38.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val40 = new XmlNamespaceResolver();
			val40.Add("", "http://xamarin.com/schemas/2014/forms");
			val40.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val40.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val40.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val40.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val40.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val40.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val38.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val40, typeof(OtherSymptomView).GetTypeInfo().Assembly));
			val38.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 33)));
			DynamicResource val41 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val38);
			((IDynamicResourceHandler)val9).SetDynamicResource(BoxView.ColorProperty, val41.get_Key());
			((Layout<View>)(object)val21).get_Children().Add((View)(object)val9);
			((BindableObject)val20).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val10).SetValue(Label.TextProperty, (object)otherSymptomView_DescribeYourSymptoms);
			((BindableObject)val10).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val10).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val10).SetValue(Label.PaddingProperty, (object)new Thickness(16.0, 32.0, 16.0, 24.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val10);
			val11.set_Path("DescriptionText");
			BindingBase val42 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)textAreaView).SetBinding(TextAreaView.TextProperty, val42);
			((BindableObject)textAreaView).SetValue(TextAreaView.MaxLengthProperty, (object)500);
			((BindableObject)textAreaView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)textAreaView);
			val12.set_Path("SymptomErrorMessage");
			BindingBase val43 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)val15).SetBinding(Label.TextProperty, val43);
			((BindableObject)val15).SetValue(View.MarginProperty, (object)new Thickness(16.0, 8.0, 0.0, 0.0));
			val13.set_Path("ShowErrorMessage");
			BindingBase val44 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)null);
			((BindableObject)val15).SetBinding(VisualElement.IsVisibleProperty, val44);
			val14.set_Key("ErrorTextColor");
			XamlServiceProvider val45 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 9];
			array4[0] = val15;
			array4[1] = val20;
			array4[2] = val21;
			array4[3] = val22;
			array4[4] = val23;
			array4[5] = val24;
			array4[6] = val25;
			array4[7] = val26;
			array4[8] = otherSymptomView;
			SimpleValueTargetProvider val46 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val27);
			object obj4 = (object)val46;
			val45.Add(typeFromHandle7, (object)val46);
			val45.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val47 = new XmlNamespaceResolver();
			val47.Add("", "http://xamarin.com/schemas/2014/forms");
			val47.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val47.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val47.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val47.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val47.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val47.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val45.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val47, typeof(OtherSymptomView).GetTypeInfo().Assembly));
			val45.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(61, 37)));
			object obj5 = ((IMarkupExtension)val14).ProvideValue((IServiceProvider)val45);
			val15.set_TextColor((Color)obj5);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val15);
			val16.set_Key("LargeButtonStyle");
			XamlServiceProvider val48 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 9];
			array5[0] = val19;
			array5[1] = val20;
			array5[2] = val21;
			array5[3] = val22;
			array5[4] = val23;
			array5[5] = val24;
			array5[6] = val25;
			array5[7] = val26;
			array5[8] = otherSymptomView;
			SimpleValueTargetProvider val49 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val27);
			object obj6 = (object)val49;
			val48.Add(typeFromHandle9, (object)val49);
			val48.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val50 = new XmlNamespaceResolver();
			val50.Add("", "http://xamarin.com/schemas/2014/forms");
			val50.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val50.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val50.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val50.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val50.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val50.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val48.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val50, typeof(OtherSymptomView).GetTypeInfo().Assembly));
			val48.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(66, 37)));
			DynamicResource val51 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val48);
			((IDynamicResourceHandler)val19).SetDynamicResource(VisualElement.StyleProperty, val51.get_Key());
			val17.set_Key("PrimaryColor");
			XamlServiceProvider val52 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 9];
			array6[0] = val19;
			array6[1] = val20;
			array6[2] = val21;
			array6[3] = val22;
			array6[4] = val23;
			array6[5] = val24;
			array6[6] = val25;
			array6[7] = val26;
			array6[8] = otherSymptomView;
			SimpleValueTargetProvider val53 = new SimpleValueTargetProvider(array6, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val27);
			object obj7 = (object)val53;
			val52.Add(typeFromHandle11, (object)val53);
			val52.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val54 = new XmlNamespaceResolver();
			val54.Add("", "http://xamarin.com/schemas/2014/forms");
			val54.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val54.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val54.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val54.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val54.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val54.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val52.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val54, typeof(OtherSymptomView).GetTypeInfo().Assembly));
			val52.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(67, 37)));
			DynamicResource val55 = ((IMarkupExtension<DynamicResource>)(object)val17).ProvideValue((IServiceProvider)val52);
			((IDynamicResourceHandler)val19).SetDynamicResource(VisualElement.BackgroundColorProperty, val55.get_Key());
			((BindableObject)val19).SetValue(Button.TextProperty, (object)button_Submit);
			((BindableObject)val19).SetValue(View.MarginProperty, (object)new Thickness(16.0, 40.0, 16.0, 24.0));
			val18.set_Path("SubmitCommand");
			BindingBase val56 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)null);
			((BindableObject)val19).SetBinding(Button.CommandProperty, val56);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val19);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)val20);
			((BindableObject)val22).SetValue(ContentView.ContentProperty, (object)val21);
			((Layout<View>)(object)val23).get_Children().Add((View)(object)val22);
			((Layout<View>)(object)val24).get_Children().Add((View)(object)val23);
			val25.set_Content((View)(object)val24);
			((Layout<View>)(object)val26).get_Children().Add((View)(object)val25);
			((BindableObject)otherSymptomView).SetValue(ContentPage.ContentProperty, (object)val26);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<OtherSymptomView>(this, typeof(OtherSymptomView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			otherSymptomsMainTitle = NameScopeExtensions.FindByName<Label>((Element)(object)this, "otherSymptomsMainTitle");
			description = NameScopeExtensions.FindByName<TextAreaView>((Element)(object)this, "description");
			errorMessage = NameScopeExtensions.FindByName<Label>((Element)(object)this, "errorMessage");
			submit = NameScopeExtensions.FindByName<Button>((Element)(object)this, "submit");
		}
	}
}
