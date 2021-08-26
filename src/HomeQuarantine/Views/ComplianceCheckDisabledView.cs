using System;
using System.CodeDom.Compiler;
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
	[XamlFilePath("Views/ComplianceCheckDisabledView.xaml")]
	public class ComplianceCheckDisabledView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TintedCachedImage image;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout descriptionStack;

		public bool ShowDismiss => true;

		public ComplianceCheckDisabledView()
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
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
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
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected O, but got Unknown
			//IL_02d8: Expected O, but got Unknown
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected O, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Expected O, but got Unknown
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected O, but got Unknown
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected O, but got Unknown
			//IL_039b: Expected O, but got Unknown
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Expected O, but got Unknown
			//IL_0478: Expected O, but got Unknown
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0513: Expected O, but got Unknown
			//IL_050e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0518: Expected O, but got Unknown
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Expected O, but got Unknown
			//IL_052c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Expected O, but got Unknown
			//IL_053b: Expected O, but got Unknown
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0620: Unknown result type (might be due to invalid IL or missing references)
			//IL_065d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0662: Unknown result type (might be due to invalid IL or missing references)
			//IL_0665: Expected O, but got Unknown
			//IL_066a: Expected O, but got Unknown
			//IL_066a: Unknown result type (might be due to invalid IL or missing references)
			//IL_067c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0687: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_069c: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0705: Expected O, but got Unknown
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_070a: Expected O, but got Unknown
			//IL_070a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0719: Unknown result type (might be due to invalid IL or missing references)
			//IL_0723: Expected O, but got Unknown
			//IL_071e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0728: Expected O, but got Unknown
			//IL_072d: Expected O, but got Unknown
			//IL_076d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_083f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0883: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ComplianceCheckDisabledView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/ComplianceCheckDisabledView.xaml");
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
			BindingExtension val3 = new BindingExtension();
			BoxView val4 = new BoxView();
			BindingExtension val5 = new BindingExtension();
			DynamicResourceExtension val6 = new DynamicResourceExtension();
			Label val7 = new Label();
			BindingExtension val8 = new BindingExtension();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			BindingExtension val10 = new BindingExtension();
			Label val11 = new Label();
			BindingExtension val12 = new BindingExtension();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val13 = new StackLayout();
			BindingExtension val14 = new BindingExtension();
			DataTemplate val15 = new DataTemplate();
			StackLayout val16 = new StackLayout();
			StackLayout val17 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val18 = new StackLayout();
			ScrollView val19 = new ScrollView();
			StackLayout val20 = new StackLayout();
			ComplianceCheckDisabledView complianceCheckDisabledView;
			NameScope val21 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(complianceCheckDisabledView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)complianceCheckDisabledView, (INameScope)(object)val21);
			((INameScope)val21).RegisterName("containingView", (object)val18);
			if (((Element)val18).get_StyleId() == null)
			{
				((Element)val18).set_StyleId("containingView");
			}
			((INameScope)val21).RegisterName("border", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("border");
			}
			((INameScope)val21).RegisterName("image", (object)tintedCachedImage);
			if (((Element)tintedCachedImage).get_StyleId() == null)
			{
				((Element)tintedCachedImage).set_StyleId("image");
			}
			((INameScope)val21).RegisterName("descriptionStack", (object)val16);
			if (((Element)val16).get_StyleId() == null)
			{
				((Element)val16).set_StyleId("descriptionStack");
			}
			containingView = val18;
			border = val4;
			image = tintedCachedImage;
			descriptionStack = val16;
			((BindableObject)complianceCheckDisabledView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)complianceCheckDisabledView).SetValue(Page.TitleProperty, (object)livenessCheckView_Title);
			((BindableObject)val20).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 32.0));
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val22 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = shadowFrame;
			array[1] = val18;
			array[2] = val19;
			array[3] = val20;
			array[4] = complianceCheckDisabledView;
			SimpleValueTargetProvider val23 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val21);
			object obj = (object)val23;
			val22.Add(typeFromHandle, (object)val23);
			val22.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val24 = new XmlNamespaceResolver();
			val24.Add("", "http://xamarin.com/schemas/2014/forms");
			val24.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val24.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val24.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val24.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val24.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val22.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val24, typeof(ComplianceCheckDisabledView).GetTypeInfo().Assembly));
			val22.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 25)));
			DynamicResource val25 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val22);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val25.get_Key());
			((BindableObject)val4).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val3.set_Path("BorderColor");
			BindingBase val26 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(BoxView.ColorProperty, val26);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val4);
			val5.set_Path("Title");
			BindingBase val27 = ((IMarkupExtension<BindingBase>)(object)val5).ProvideValue((IServiceProvider)null);
			((BindableObject)val7).SetBinding(Label.TextProperty, val27);
			val6.set_Key("Heading1");
			XamlServiceProvider val28 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 7];
			array2[0] = val7;
			array2[1] = val17;
			array2[2] = shadowFrame;
			array2[3] = val18;
			array2[4] = val19;
			array2[5] = val20;
			array2[6] = complianceCheckDisabledView;
			SimpleValueTargetProvider val29 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val21);
			object obj2 = (object)val29;
			val28.Add(typeFromHandle3, (object)val29);
			val28.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val30 = new XmlNamespaceResolver();
			val30.Add("", "http://xamarin.com/schemas/2014/forms");
			val30.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val30.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val30.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val30.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val30.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val28.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val30, typeof(ComplianceCheckDisabledView).GetTypeInfo().Assembly));
			val28.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 29)));
			DynamicResource val31 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val28);
			((IDynamicResourceHandler)val7).SetDynamicResource(VisualElement.StyleProperty, val31.get_Key());
			((BindableObject)val7).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val7).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val7).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val7);
			val8.set_Path("SubTitle");
			BindingBase val32 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)val11).SetBinding(Label.TextProperty, val32);
			((BindableObject)val11).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val9.set_Key("Small");
			XamlServiceProvider val33 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 7];
			array3[0] = val11;
			array3[1] = val17;
			array3[2] = shadowFrame;
			array3[3] = val18;
			array3[4] = val19;
			array3[5] = val20;
			array3[6] = complianceCheckDisabledView;
			SimpleValueTargetProvider val34 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val21);
			object obj3 = (object)val34;
			val33.Add(typeFromHandle5, (object)val34);
			val33.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val35 = new XmlNamespaceResolver();
			val35.Add("", "http://xamarin.com/schemas/2014/forms");
			val35.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val35.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val35.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val35.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val35.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val33.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val35, typeof(ComplianceCheckDisabledView).GetTypeInfo().Assembly));
			val33.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 29)));
			DynamicResource val36 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val33);
			((IDynamicResourceHandler)val11).SetDynamicResource(VisualElement.StyleProperty, val36.get_Key());
			val10.set_Path("TextColor");
			BindingBase val37 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)val11).SetBinding(Label.TextColorProperty, val37);
			((BindableObject)val11).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val11).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 24.0));
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val11);
			((BindableObject)val13).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			val12.set_Path("ImageSource");
			BindingBase val38 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)tintedCachedImage).SetBinding(CachedImage.SourceProperty, val38);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val13);
			((BindableObject)val16).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 8.0));
			val14.set_Path("Descriptions");
			BindingBase val39 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)val16).SetBinding(BindableLayout.ItemsSourceProperty, val39);
			object[] array4 = new object[0 + 8];
			array4[0] = val15;
			array4[1] = val16;
			array4[2] = val17;
			array4[3] = shadowFrame;
			array4[4] = val18;
			array4[5] = val19;
			array4[6] = val20;
			array4[7] = complianceCheckDisabledView;
			object[] parentValues = array4;
			ComplianceCheckDisabledView root = complianceCheckDisabledView;
			((IDataTemplate)val15).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				BindingExtension val40 = new BindingExtension();
				Label val41 = new Label();
				NameScope val42 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val41, (INameScope)(object)val42);
				val40.set_Path(".");
				BindingBase val43 = ((IMarkupExtension<BindingBase>)(object)val40).ProvideValue((IServiceProvider)null);
				((BindableObject)val41).SetBinding(Label.TextProperty, val43);
				((BindableObject)val41).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val41).SetValue(View.MarginProperty, (object)new Thickness(16.0, 8.0));
				return val41;
			});
			((BindableObject)val16).SetValue(BindableLayout.ItemTemplateProperty, (object)val15);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val16);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val17);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)shadowFrame);
			val19.set_Content((View)(object)val18);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val19);
			((BindableObject)complianceCheckDisabledView).SetValue(ContentPage.ContentProperty, (object)val20);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ComplianceCheckDisabledView>(this, typeof(ComplianceCheckDisabledView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			image = NameScopeExtensions.FindByName<TintedCachedImage>((Element)(object)this, "image");
			descriptionStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "descriptionStack");
		}
	}
}
