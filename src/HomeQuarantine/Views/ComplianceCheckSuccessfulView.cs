using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using FFImageLoading.Forms;
using HomeQuarantine.Controls;
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
	[XamlFilePath("Views/ComplianceCheckSuccessfulView.xaml")]
	public class ComplianceCheckSuccessfulView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		public bool ShowDismiss => true;

		public ComplianceCheckSuccessfulView()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			(((BindableObject)this).get_BindingContext() as ComplianceCheckSuccessfulViewModel).PopAllPreviousPagesCommand.Execute(null);
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
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
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
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02a6: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected O, but got Unknown
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected O, but got Unknown
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected O, but got Unknown
			//IL_0369: Expected O, but got Unknown
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Expected O, but got Unknown
			//IL_03f1: Expected O, but got Unknown
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Unknown result type (might be due to invalid IL or missing references)
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Expected O, but got Unknown
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Expected O, but got Unknown
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected O, but got Unknown
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected O, but got Unknown
			//IL_04b4: Expected O, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Expected O, but got Unknown
			//IL_0564: Expected O, but got Unknown
			//IL_0564: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Expected O, but got Unknown
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0604: Expected O, but got Unknown
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_0613: Unknown result type (might be due to invalid IL or missing references)
			//IL_061d: Expected O, but got Unknown
			//IL_0618: Unknown result type (might be due to invalid IL or missing references)
			//IL_0622: Expected O, but got Unknown
			//IL_0627: Expected O, but got Unknown
			//IL_0643: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06df: Unknown result type (might be due to invalid IL or missing references)
			//IL_070c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_0793: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0818: Unknown result type (might be due to invalid IL or missing references)
			//IL_081d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Expected O, but got Unknown
			//IL_0825: Expected O, but got Unknown
			//IL_0825: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Unknown result type (might be due to invalid IL or missing references)
			//IL_0847: Unknown result type (might be due to invalid IL or missing references)
			//IL_0857: Unknown result type (might be due to invalid IL or missing references)
			//IL_0867: Unknown result type (might be due to invalid IL or missing references)
			//IL_0877: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_0897: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c0: Expected O, but got Unknown
			//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c5: Expected O, but got Unknown
			//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08de: Expected O, but got Unknown
			//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e3: Expected O, but got Unknown
			//IL_08e8: Expected O, but got Unknown
			//IL_090b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0910: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			//IL_095a: Expected O, but got Unknown
			//IL_095f: Expected O, but got Unknown
			//IL_095f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0971: Unknown result type (might be due to invalid IL or missing references)
			//IL_097c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0981: Unknown result type (might be due to invalid IL or missing references)
			//IL_0991: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fa: Expected O, but got Unknown
			//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ff: Expected O, but got Unknown
			//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a18: Expected O, but got Unknown
			//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1d: Expected O, but got Unknown
			//IL_0a22: Expected O, but got Unknown
			//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b17: Expected O, but got Unknown
			//IL_0b1c: Expected O, but got Unknown
			//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb7: Expected O, but got Unknown
			//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbc: Expected O, but got Unknown
			//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd5: Expected O, but got Unknown
			//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bda: Expected O, but got Unknown
			//IL_0bdf: Expected O, but got Unknown
			//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/ComplianceCheckSuccessfulView.xaml");
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
			string complianceCheckInSuccessfulView_ConfirmYourLocation = Resources.ComplianceCheckInSuccessfulView_ConfirmYourLocation;
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			Label val6 = new Label();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val7 = new StackLayout();
			string complianceCheckInSuccessfulView_LocationSubmitted = Resources.ComplianceCheckInSuccessfulView_LocationSubmitted;
			Label val8 = new Label();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			DynamicResourceExtension val10 = new DynamicResourceExtension();
			string button_Close = Resources.Button_Close;
			BindingExtension val11 = new BindingExtension();
			Button val12 = new Button();
			StackLayout val13 = new StackLayout();
			DynamicResourceExtension val14 = new DynamicResourceExtension();
			BindingExtension val15 = new BindingExtension();
			ComplianceCheckIndicatorView complianceCheckIndicatorView = new ComplianceCheckIndicatorView();
			StackLayout val16 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val17 = new StackLayout();
			ScrollView val18 = new ScrollView();
			StackLayout val19 = new StackLayout();
			ComplianceCheckSuccessfulView complianceCheckSuccessfulView;
			NameScope val20 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(complianceCheckSuccessfulView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)complianceCheckSuccessfulView, (INameScope)(object)val20);
			((INameScope)val20).RegisterName("containingView", (object)val17);
			if (((Element)val17).get_StyleId() == null)
			{
				((Element)val17).set_StyleId("containingView");
			}
			((INameScope)val20).RegisterName("border", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("border");
			}
			containingView = val17;
			border = val4;
			((BindableObject)complianceCheckSuccessfulView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)complianceCheckSuccessfulView).SetValue(Page.TitleProperty, (object)livenessCheckView_Title);
			((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val18).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val17).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val21 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = shadowFrame;
			array[1] = val17;
			array[2] = val18;
			array[3] = val19;
			array[4] = complianceCheckSuccessfulView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val20);
			object obj = (object)val22;
			val21.Add(typeFromHandle, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val23.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val23.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val23.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val23.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val21.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 25)));
			DynamicResource val24 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val21);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val24.get_Key());
			((BindableObject)val4).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val3.set_Key("TertiaryColor");
			XamlServiceProvider val25 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 7];
			array2[0] = val4;
			array2[1] = val16;
			array2[2] = shadowFrame;
			array2[3] = val17;
			array2[4] = val18;
			array2[5] = val19;
			array2[6] = complianceCheckSuccessfulView;
			SimpleValueTargetProvider val26 = new SimpleValueTargetProvider(array2, (object)BoxView.ColorProperty, (INameScope)(object)val20);
			object obj2 = (object)val26;
			val25.Add(typeFromHandle3, (object)val26);
			val25.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val27 = new XmlNamespaceResolver();
			val27.Add("", "http://xamarin.com/schemas/2014/forms");
			val27.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val27.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val27.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val27.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val27.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val25.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val27, typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly));
			val25.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 29)));
			DynamicResource val28 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val25);
			((IDynamicResourceHandler)val4).SetDynamicResource(BoxView.ColorProperty, val28.get_Key());
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val4);
			((BindableObject)val13).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val6).SetValue(Label.TextProperty, (object)complianceCheckInSuccessfulView_ConfirmYourLocation);
			val5.set_Key("Heading1");
			XamlServiceProvider val29 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 8];
			array3[0] = val6;
			array3[1] = val13;
			array3[2] = val16;
			array3[3] = shadowFrame;
			array3[4] = val17;
			array3[5] = val18;
			array3[6] = val19;
			array3[7] = complianceCheckSuccessfulView;
			SimpleValueTargetProvider val30 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val20);
			object obj3 = (object)val30;
			val29.Add(typeFromHandle5, (object)val30);
			val29.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val31 = new XmlNamespaceResolver();
			val31.Add("", "http://xamarin.com/schemas/2014/forms");
			val31.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val31.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val31.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val31.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val31.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val29.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val31, typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly));
			val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 33)));
			DynamicResource val32 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val29);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val32.get_Key());
			((BindableObject)val6).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val6);
			((BindableObject)val7).SetValue(VisualElement.HeightRequestProperty, (object)250.0);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("ComplianceCheckInSuccessful"));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val7).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val7);
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 16.0));
			((BindableObject)val8).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val8).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val8).SetValue(Label.TextProperty, (object)complianceCheckInSuccessfulView_LocationSubmitted);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val8);
			val9.set_Key("LargeButtonStyle");
			XamlServiceProvider val33 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val12;
			array4[1] = val13;
			array4[2] = val16;
			array4[3] = shadowFrame;
			array4[4] = val17;
			array4[5] = val18;
			array4[6] = val19;
			array4[7] = complianceCheckSuccessfulView;
			SimpleValueTargetProvider val34 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val20);
			object obj4 = (object)val34;
			val33.Add(typeFromHandle7, (object)val34);
			val33.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val35 = new XmlNamespaceResolver();
			val35.Add("", "http://xamarin.com/schemas/2014/forms");
			val35.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val35.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val35.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val35.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val35.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val33.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val35, typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly));
			val33.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 33)));
			DynamicResource val36 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val33);
			((IDynamicResourceHandler)val12).SetDynamicResource(VisualElement.StyleProperty, val36.get_Key());
			val10.set_Key("TertiaryColor");
			XamlServiceProvider val37 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 8];
			array5[0] = val12;
			array5[1] = val13;
			array5[2] = val16;
			array5[3] = shadowFrame;
			array5[4] = val17;
			array5[5] = val18;
			array5[6] = val19;
			array5[7] = complianceCheckSuccessfulView;
			SimpleValueTargetProvider val38 = new SimpleValueTargetProvider(array5, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val20);
			object obj5 = (object)val38;
			val37.Add(typeFromHandle9, (object)val38);
			val37.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val39 = new XmlNamespaceResolver();
			val39.Add("", "http://xamarin.com/schemas/2014/forms");
			val39.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val39.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val39.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val39.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val39.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val37.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val39, typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly));
			val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 33)));
			DynamicResource val40 = ((IMarkupExtension<DynamicResource>)(object)val10).ProvideValue((IServiceProvider)val37);
			((IDynamicResourceHandler)val12).SetDynamicResource(VisualElement.BackgroundColorProperty, val40.get_Key());
			((BindableObject)val12).SetValue(Button.TextProperty, (object)button_Close);
			val11.set_Path("CloseCommand");
			BindingBase val41 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)val12).SetBinding(Button.CommandProperty, val41);
			((BindableObject)val12).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val12);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val13);
			val14.set_Key("TertiaryColor");
			XamlServiceProvider val42 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 7];
			array6[0] = complianceCheckIndicatorView;
			array6[1] = val16;
			array6[2] = shadowFrame;
			array6[3] = val17;
			array6[4] = val18;
			array6[5] = val19;
			array6[6] = complianceCheckSuccessfulView;
			SimpleValueTargetProvider val43 = new SimpleValueTargetProvider(array6, (object)ComplianceCheckIndicatorView.ColourProperty, (INameScope)(object)val20);
			object obj6 = (object)val43;
			val42.Add(typeFromHandle11, (object)val43);
			val42.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val44 = new XmlNamespaceResolver();
			val44.Add("", "http://xamarin.com/schemas/2014/forms");
			val44.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val44.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val44.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val44.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val44.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val42.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val44, typeof(ComplianceCheckSuccessfulView).GetTypeInfo().Assembly));
			val42.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(57, 29)));
			DynamicResource val45 = ((IMarkupExtension<DynamicResource>)(object)val14).ProvideValue((IServiceProvider)val42);
			((IDynamicResourceHandler)complianceCheckIndicatorView).SetDynamicResource(ComplianceCheckIndicatorView.ColourProperty, val45.get_Key());
			val15.set_Path("PageType");
			BindingBase val46 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)null);
			((BindableObject)complianceCheckIndicatorView).SetBinding(ComplianceCheckIndicatorView.CurrentPageProperty, val46);
			((BindableObject)complianceCheckIndicatorView).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 32.0));
			((Layout<View>)(object)val16).get_Children().Add((View)(object)complianceCheckIndicatorView);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val16);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)shadowFrame);
			val18.set_Content((View)(object)val17);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			((BindableObject)complianceCheckSuccessfulView).SetValue(ContentPage.ContentProperty, (object)val19);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ComplianceCheckSuccessfulView>(this, typeof(ComplianceCheckSuccessfulView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
		}
	}
}
