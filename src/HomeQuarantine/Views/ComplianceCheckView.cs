using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using FFImageLoading.Forms;
using HomeQuarantine.Controls;
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
	[XamlFilePath("Views/ComplianceCheckView.xaml")]
	public class ComplianceCheckView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TintedCachedImage image;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label verifyingIdentity;

		public bool ShowDismiss => true;

		public ComplianceCheckView()
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
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
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
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Expected O, but got Unknown
			//IL_0355: Expected O, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Expected O, but got Unknown
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Expected O, but got Unknown
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Expected O, but got Unknown
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected O, but got Unknown
			//IL_0418: Expected O, but got Unknown
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Expected O, but got Unknown
			//IL_04a5: Expected O, but got Unknown
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Unknown result type (might be due to invalid IL or missing references)
			//IL_0540: Expected O, but got Unknown
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Expected O, but got Unknown
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Expected O, but got Unknown
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_0563: Expected O, but got Unknown
			//IL_0568: Expected O, but got Unknown
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f4: Expected O, but got Unknown
			//IL_05f9: Expected O, but got Unknown
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_060b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_063b: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Unknown result type (might be due to invalid IL or missing references)
			//IL_065b: Unknown result type (might be due to invalid IL or missing references)
			//IL_066b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0694: Expected O, but got Unknown
			//IL_068f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0699: Expected O, but got Unknown
			//IL_0699: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b2: Expected O, but got Unknown
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b7: Expected O, but got Unknown
			//IL_06bc: Expected O, but got Unknown
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0717: Unknown result type (might be due to invalid IL or missing references)
			//IL_0750: Unknown result type (might be due to invalid IL or missing references)
			//IL_0755: Unknown result type (might be due to invalid IL or missing references)
			//IL_0797: Unknown result type (might be due to invalid IL or missing references)
			//IL_079c: Unknown result type (might be due to invalid IL or missing references)
			//IL_079f: Expected O, but got Unknown
			//IL_07a4: Expected O, but got Unknown
			//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0806: Unknown result type (might be due to invalid IL or missing references)
			//IL_0816: Unknown result type (might be due to invalid IL or missing references)
			//IL_083f: Expected O, but got Unknown
			//IL_083a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0844: Expected O, but got Unknown
			//IL_0844: Unknown result type (might be due to invalid IL or missing references)
			//IL_0853: Unknown result type (might be due to invalid IL or missing references)
			//IL_085d: Expected O, but got Unknown
			//IL_0858: Unknown result type (might be due to invalid IL or missing references)
			//IL_0862: Expected O, but got Unknown
			//IL_0867: Expected O, but got Unknown
			//IL_0883: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0900: Unknown result type (might be due to invalid IL or missing references)
			//IL_0924: Unknown result type (might be due to invalid IL or missing references)
			//IL_094c: Unknown result type (might be due to invalid IL or missing references)
			//IL_098c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab6: Expected O, but got Unknown
			//IL_0abb: Expected O, but got Unknown
			//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0add: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b56: Expected O, but got Unknown
			//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5b: Expected O, but got Unknown
			//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b74: Expected O, but got Unknown
			//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b79: Expected O, but got Unknown
			//IL_0b7e: Expected O, but got Unknown
			//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf0: Expected O, but got Unknown
			//IL_0bf5: Expected O, but got Unknown
			//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c90: Expected O, but got Unknown
			//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c95: Expected O, but got Unknown
			//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cae: Expected O, but got Unknown
			//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb3: Expected O, but got Unknown
			//IL_0cb8: Expected O, but got Unknown
			//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb9: Expected O, but got Unknown
			//IL_0ebe: Expected O, but got Unknown
			//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0edb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f59: Expected O, but got Unknown
			//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f5e: Expected O, but got Unknown
			//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f77: Expected O, but got Unknown
			//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7c: Expected O, but got Unknown
			//IL_0f81: Expected O, but got Unknown
			//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_100c: Unknown result type (might be due to invalid IL or missing references)
			//IL_110c: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ComplianceCheckView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/ComplianceCheckView.xaml");
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
			string livenessCheckView_Title = Resources.LivenessCheckView_Title;
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			BoxView val4 = new BoxView();
			string livenessCheckView_LivenessCheckTitle = Resources.LivenessCheckView_LivenessCheckTitle;
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			Label val6 = new Label();
			string livenessCheckView_LivenessCheckSubTitle = Resources.LivenessCheckView_LivenessCheckSubTitle;
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			Label val8 = new Label();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val9 = new StackLayout();
			string livenessCheckView_LivenessCheckDescription = Resources.LivenessCheckView_LivenessCheckDescription1;
			Label val10 = new Label();
			string livenessCheckView_LivenessCheckDescription2 = Resources.LivenessCheckView_LivenessCheckDescription2;
			Label val11 = new Label();
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			string checkIn_GoToLiveFaceCheck = Resources.CheckIn_GoToLiveFaceCheck;
			BindingExtension val14 = new BindingExtension();
			Button val15 = new Button();
			BindingExtension val16 = new BindingExtension();
			BindingExtension val17 = new BindingExtension();
			ComplianceCheckIndicatorView complianceCheckIndicatorView = new ComplianceCheckIndicatorView();
			StackLayout val18 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val19 = new StackLayout();
			ScrollView val20 = new ScrollView();
			StackLayout val21 = new StackLayout();
			BindingExtension val22 = new BindingExtension();
			StackLayout val23 = new StackLayout();
			DynamicResourceExtension val24 = new DynamicResourceExtension();
			BindingExtension val25 = new BindingExtension();
			BindingExtension val26 = new BindingExtension();
			ActivityIndicator val27 = new ActivityIndicator();
			BindingExtension val28 = new BindingExtension();
			BindingExtension val29 = new BindingExtension();
			ProgressBar val30 = new ProgressBar();
			BindingExtension val31 = new BindingExtension();
			Label val32 = new Label();
			StackLayout val33 = new StackLayout();
			ShadowFrame shadowFrame2 = new ShadowFrame();
			Grid val34 = new Grid();
			ComplianceCheckView complianceCheckView;
			NameScope val35 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(complianceCheckView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)complianceCheckView, (INameScope)(object)val35);
			((INameScope)val35).RegisterName("containingView", (object)val19);
			if (((Element)val19).get_StyleId() == null)
			{
				((Element)val19).set_StyleId("containingView");
			}
			((INameScope)val35).RegisterName("border", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("border");
			}
			((INameScope)val35).RegisterName("image", (object)tintedCachedImage);
			if (((Element)tintedCachedImage).get_StyleId() == null)
			{
				((Element)tintedCachedImage).set_StyleId("image");
			}
			((INameScope)val35).RegisterName("verifyingIdentity", (object)val32);
			if (((Element)val32).get_StyleId() == null)
			{
				((Element)val32).set_StyleId("verifyingIdentity");
			}
			containingView = val19;
			border = val4;
			image = tintedCachedImage;
			verifyingIdentity = val32;
			((BindableObject)complianceCheckView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)complianceCheckView).SetValue(Page.TitleProperty, (object)livenessCheckView_Title);
			((BindableObject)val21).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val20).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val36 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 6];
			array[0] = shadowFrame;
			array[1] = val19;
			array[2] = val20;
			array[3] = val21;
			array[4] = val34;
			array[5] = complianceCheckView;
			SimpleValueTargetProvider val37 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val35);
			object obj = (object)val37;
			val36.Add(typeFromHandle, (object)val37);
			val36.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val38 = new XmlNamespaceResolver();
			val38.Add("", "http://xamarin.com/schemas/2014/forms");
			val38.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val38.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val38.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val38.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val38.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val36.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val38, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val36.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 25)));
			DynamicResource val39 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val36);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val39.get_Key());
			((BindableObject)val4).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val3.set_Key("QuartenaryColor");
			XamlServiceProvider val40 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 8];
			array2[0] = val4;
			array2[1] = val18;
			array2[2] = shadowFrame;
			array2[3] = val19;
			array2[4] = val20;
			array2[5] = val21;
			array2[6] = val34;
			array2[7] = complianceCheckView;
			SimpleValueTargetProvider val41 = new SimpleValueTargetProvider(array2, (object)BoxView.ColorProperty, (INameScope)(object)val35);
			object obj2 = (object)val41;
			val40.Add(typeFromHandle3, (object)val41);
			val40.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val42 = new XmlNamespaceResolver();
			val42.Add("", "http://xamarin.com/schemas/2014/forms");
			val42.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val42.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val42.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val42.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val42.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val40.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val42, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val40.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 33)));
			DynamicResource val43 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val40);
			((IDynamicResourceHandler)val4).SetDynamicResource(BoxView.ColorProperty, val43.get_Key());
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val4);
			((BindableObject)val6).SetValue(Label.TextProperty, (object)livenessCheckView_LivenessCheckTitle);
			val5.set_Key("Heading1");
			XamlServiceProvider val44 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 8];
			array3[0] = val6;
			array3[1] = val18;
			array3[2] = shadowFrame;
			array3[3] = val19;
			array3[4] = val20;
			array3[5] = val21;
			array3[6] = val34;
			array3[7] = complianceCheckView;
			SimpleValueTargetProvider val45 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val35);
			object obj3 = (object)val45;
			val44.Add(typeFromHandle5, (object)val45);
			val44.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val46 = new XmlNamespaceResolver();
			val46.Add("", "http://xamarin.com/schemas/2014/forms");
			val46.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val46.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val46.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val46.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val46.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val44.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val46, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val44.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 33)));
			DynamicResource val47 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val44);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val47.get_Key());
			((BindableObject)val6).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val6).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val6);
			((BindableObject)val8).SetValue(Label.TextProperty, (object)livenessCheckView_LivenessCheckSubTitle);
			val7.set_Key("Small");
			XamlServiceProvider val48 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val8;
			array4[1] = val18;
			array4[2] = shadowFrame;
			array4[3] = val19;
			array4[4] = val20;
			array4[5] = val21;
			array4[6] = val34;
			array4[7] = complianceCheckView;
			SimpleValueTargetProvider val49 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val35);
			object obj4 = (object)val49;
			val48.Add(typeFromHandle7, (object)val49);
			val48.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val50 = new XmlNamespaceResolver();
			val50.Add("", "http://xamarin.com/schemas/2014/forms");
			val50.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val50.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val50.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val50.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val50.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val48.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val50, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val48.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 33)));
			DynamicResource val51 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val48);
			((IDynamicResourceHandler)val8).SetDynamicResource(VisualElement.StyleProperty, val51.get_Key());
			((BindableObject)val8).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 24.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val8);
			((BindableObject)val9).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((BindableObject)tintedCachedImage).SetValue(CachedImage.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("LiveFaceCheckIn"));
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val9).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val9);
			((BindableObject)val10).SetValue(Label.TextProperty, (object)livenessCheckView_LivenessCheckDescription);
			((BindableObject)val10).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val10).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val10);
			((BindableObject)val11).SetValue(Label.TextProperty, (object)livenessCheckView_LivenessCheckDescription2);
			((BindableObject)val11).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val11).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val11);
			val12.set_Key("LargeButtonStyle");
			XamlServiceProvider val52 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 8];
			array5[0] = val15;
			array5[1] = val18;
			array5[2] = shadowFrame;
			array5[3] = val19;
			array5[4] = val20;
			array5[5] = val21;
			array5[6] = val34;
			array5[7] = complianceCheckView;
			SimpleValueTargetProvider val53 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val35);
			object obj5 = (object)val53;
			val52.Add(typeFromHandle9, (object)val53);
			val52.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val54 = new XmlNamespaceResolver();
			val54.Add("", "http://xamarin.com/schemas/2014/forms");
			val54.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val54.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val54.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val54.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val54.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val52.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val54, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val52.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 33)));
			DynamicResource val55 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val52);
			((IDynamicResourceHandler)val15).SetDynamicResource(VisualElement.StyleProperty, val55.get_Key());
			val13.set_Key("QuartenaryColor");
			XamlServiceProvider val56 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 8];
			array6[0] = val15;
			array6[1] = val18;
			array6[2] = shadowFrame;
			array6[3] = val19;
			array6[4] = val20;
			array6[5] = val21;
			array6[6] = val34;
			array6[7] = complianceCheckView;
			SimpleValueTargetProvider val57 = new SimpleValueTargetProvider(array6, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val35);
			object obj6 = (object)val57;
			val56.Add(typeFromHandle11, (object)val57);
			val56.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val58 = new XmlNamespaceResolver();
			val58.Add("", "http://xamarin.com/schemas/2014/forms");
			val58.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val58.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val58.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val58.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val58.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val56.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val58, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val56.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(60, 33)));
			DynamicResource val59 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val56);
			((IDynamicResourceHandler)val15).SetDynamicResource(VisualElement.BackgroundColorProperty, val59.get_Key());
			((BindableObject)val15).SetValue(Button.TextProperty, (object)checkIn_GoToLiveFaceCheck);
			val14.set_Path("StartLivenessCheckCommand");
			BindingBase val60 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)val15).SetBinding(Button.CommandProperty, val60);
			((BindableObject)val15).SetValue(View.MarginProperty, (object)new Thickness(32.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val15);
			val16.set_Path("Colour");
			BindingBase val61 = ((IMarkupExtension<BindingBase>)(object)val16).ProvideValue((IServiceProvider)null);
			((BindableObject)complianceCheckIndicatorView).SetBinding(ComplianceCheckIndicatorView.ColourProperty, val61);
			val17.set_Path("PageType");
			BindingBase val62 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)null);
			((BindableObject)complianceCheckIndicatorView).SetBinding(ComplianceCheckIndicatorView.CurrentPageProperty, val62);
			((BindableObject)complianceCheckIndicatorView).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 32.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)complianceCheckIndicatorView);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val18);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)shadowFrame);
			val20.set_Content((View)(object)val19);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)val20);
			((ICollection<View>)val34.get_Children()).Add((View)(object)val21);
			((BindableObject)val23).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val23).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Black);
			((BindableObject)val23).SetValue(VisualElement.OpacityProperty, (object)0.4);
			val22.set_Path("IsBusy");
			BindingBase val63 = ((IMarkupExtension<BindingBase>)(object)val22).ProvideValue((IServiceProvider)null);
			((BindableObject)val23).SetBinding(VisualElement.IsVisibleProperty, val63);
			((ICollection<View>)val34.get_Children()).Add((View)(object)val23);
			val24.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val64 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 3];
			array7[0] = shadowFrame2;
			array7[1] = val34;
			array7[2] = complianceCheckView;
			SimpleValueTargetProvider val65 = new SimpleValueTargetProvider(array7, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val35);
			object obj7 = (object)val65;
			val64.Add(typeFromHandle13, (object)val65);
			val64.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val66 = new XmlNamespaceResolver();
			val66.Add("", "http://xamarin.com/schemas/2014/forms");
			val66.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val66.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val66.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val66.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val66.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val64.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val66, typeof(ComplianceCheckView).GetTypeInfo().Assembly));
			val64.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(81, 13)));
			DynamicResource val67 = ((IMarkupExtension<DynamicResource>)(object)val24).ProvideValue((IServiceProvider)val64);
			((IDynamicResourceHandler)shadowFrame2).SetDynamicResource(VisualElement.BackgroundColorProperty, val67.get_Key());
			((BindableObject)shadowFrame2).SetValue(Layout.PaddingProperty, (object)new Thickness(24.0));
			((BindableObject)shadowFrame2).SetValue(View.MarginProperty, (object)new Thickness(40.0, 40.0, 40.0, 40.0));
			((BindableObject)shadowFrame2).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)shadowFrame2).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			val25.set_Path("IsBusy");
			BindingBase val68 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)null);
			((BindableObject)shadowFrame2).SetBinding(VisualElement.IsVisibleProperty, val68);
			((BindableObject)val33).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val26.set_Path("IsBusy");
			BindingBase val69 = ((IMarkupExtension<BindingBase>)(object)val26).ProvideValue((IServiceProvider)null);
			((BindableObject)val27).SetBinding(ActivityIndicator.IsRunningProperty, val69);
			((Layout<View>)(object)val33).get_Children().Add((View)(object)val27);
			val28.set_Path("Progress");
			BindingBase val70 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)null);
			((BindableObject)val30).SetBinding(ProgressBar.ProgressProperty, val70);
			val29.set_Path("IsInProgress");
			BindingBase val71 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)null);
			((BindableObject)val30).SetBinding(VisualElement.IsVisibleProperty, val71);
			((Layout<View>)(object)val33).get_Children().Add((View)(object)val30);
			val31.set_Path("BusyMessage");
			BindingBase val72 = ((IMarkupExtension<BindingBase>)(object)val31).ProvideValue((IServiceProvider)null);
			((BindableObject)val32).SetBinding(Label.TextProperty, val72);
			((BindableObject)val32).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val33).get_Children().Add((View)(object)val32);
			((BindableObject)shadowFrame2).SetValue(ContentView.ContentProperty, (object)val33);
			((ICollection<View>)val34.get_Children()).Add((View)(object)shadowFrame2);
			((BindableObject)complianceCheckView).SetValue(ContentPage.ContentProperty, (object)val34);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ComplianceCheckView>(this, typeof(ComplianceCheckView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			image = NameScopeExtensions.FindByName<TintedCachedImage>((Element)(object)this, "image");
			verifyingIdentity = NameScopeExtensions.FindByName<Label>((Element)(object)this, "verifyingIdentity");
		}
	}
}
