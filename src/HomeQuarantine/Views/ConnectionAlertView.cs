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
	[XamlFilePath("Views/ConnectionAlertView.xaml")]
	public class ConnectionAlertView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		public bool ShowDismiss => true;

		public ConnectionAlertView()
		{
			InitializeComponent();
		}

		public async Task Dismiss()
		{
			await ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().PopModalAsync();
		}

		public async Task OnResume()
		{
			await (((BindableObject)this).get_BindingContext() as ConnectionAlertViewModel).OnResumeCommand.ExecuteAsync();
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
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected O, but got Unknown
			//IL_029f: Expected O, but got Unknown
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Expected O, but got Unknown
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Expected O, but got Unknown
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected O, but got Unknown
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected O, but got Unknown
			//IL_0362: Expected O, but got Unknown
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected O, but got Unknown
			//IL_03ea: Expected O, but got Unknown
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Expected O, but got Unknown
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Expected O, but got Unknown
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Expected O, but got Unknown
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a8: Expected O, but got Unknown
			//IL_04ad: Expected O, but got Unknown
			//IL_04de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Unknown result type (might be due to invalid IL or missing references)
			//IL_050e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_0555: Unknown result type (might be due to invalid IL or missing references)
			//IL_0558: Expected O, but got Unknown
			//IL_055d: Expected O, but got Unknown
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_057a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_058f: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Expected O, but got Unknown
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Expected O, but got Unknown
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Expected O, but got Unknown
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Expected O, but got Unknown
			//IL_0620: Expected O, but got Unknown
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0705: Unknown result type (might be due to invalid IL or missing references)
			//IL_075b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0771: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Unknown result type (might be due to invalid IL or missing references)
			//IL_0825: Unknown result type (might be due to invalid IL or missing references)
			//IL_0867: Unknown result type (might be due to invalid IL or missing references)
			//IL_086c: Unknown result type (might be due to invalid IL or missing references)
			//IL_086f: Expected O, but got Unknown
			//IL_0874: Expected O, but got Unknown
			//IL_0874: Unknown result type (might be due to invalid IL or missing references)
			//IL_0886: Unknown result type (might be due to invalid IL or missing references)
			//IL_0891: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_090f: Expected O, but got Unknown
			//IL_090a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0914: Expected O, but got Unknown
			//IL_0914: Unknown result type (might be due to invalid IL or missing references)
			//IL_0923: Unknown result type (might be due to invalid IL or missing references)
			//IL_092d: Expected O, but got Unknown
			//IL_0928: Unknown result type (might be due to invalid IL or missing references)
			//IL_0932: Expected O, but got Unknown
			//IL_0937: Expected O, but got Unknown
			//IL_095a: Unknown result type (might be due to invalid IL or missing references)
			//IL_095f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a9: Expected O, but got Unknown
			//IL_09ae: Expected O, but got Unknown
			//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a49: Expected O, but got Unknown
			//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4e: Expected O, but got Unknown
			//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a67: Expected O, but got Unknown
			//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6c: Expected O, but got Unknown
			//IL_0a71: Expected O, but got Unknown
			//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ConnectionAlertView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/ConnectionAlertView.xaml");
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
			string errorView_Help = Resources.ErrorView_Help;
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			BoxView val4 = new BoxView();
			string connectionAlertView_ConnectionAlert = Resources.ConnectionAlertView_ConnectionAlert;
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			Label val6 = new Label();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val7 = new StackLayout();
			string connectionAlertView_Description = Resources.ConnectionAlertView_Description;
			Label val8 = new Label();
			string connectionAlertView_CheckYourSettings = Resources.ConnectionAlertView_CheckYourSettings;
			Label val9 = new Label();
			DynamicResourceExtension val10 = new DynamicResourceExtension();
			DynamicResourceExtension val11 = new DynamicResourceExtension();
			string button_Settings = Resources.Button_Settings;
			BindingExtension val12 = new BindingExtension();
			Button val13 = new Button();
			StackLayout val14 = new StackLayout();
			StackLayout val15 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val16 = new StackLayout();
			ScrollView val17 = new ScrollView();
			StackLayout val18 = new StackLayout();
			ConnectionAlertView connectionAlertView;
			NameScope val19 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(connectionAlertView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)connectionAlertView, (INameScope)(object)val19);
			((INameScope)val19).RegisterName("containingView", (object)val16);
			if (((Element)val16).get_StyleId() == null)
			{
				((Element)val16).set_StyleId("containingView");
			}
			((INameScope)val19).RegisterName("border", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("border");
			}
			containingView = val16;
			border = val4;
			((BindableObject)connectionAlertView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)connectionAlertView).SetValue(Page.TitleProperty, (object)errorView_Help);
			((BindableObject)val18).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val17).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val16).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val20 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = shadowFrame;
			array[1] = val16;
			array[2] = val17;
			array[3] = val18;
			array[4] = connectionAlertView;
			SimpleValueTargetProvider val21 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val19);
			object obj = (object)val21;
			val20.Add(typeFromHandle, (object)val21);
			val20.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val22 = new XmlNamespaceResolver();
			val22.Add("", "http://xamarin.com/schemas/2014/forms");
			val22.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val22.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val22.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val22.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val22.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val20.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val22, typeof(ConnectionAlertView).GetTypeInfo().Assembly));
			val20.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 25)));
			DynamicResource val23 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val20);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val23.get_Key());
			((BindableObject)val4).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val3.set_Key("QuartenaryColor");
			XamlServiceProvider val24 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 7];
			array2[0] = val4;
			array2[1] = val15;
			array2[2] = shadowFrame;
			array2[3] = val16;
			array2[4] = val17;
			array2[5] = val18;
			array2[6] = connectionAlertView;
			SimpleValueTargetProvider val25 = new SimpleValueTargetProvider(array2, (object)BoxView.ColorProperty, (INameScope)(object)val19);
			object obj2 = (object)val25;
			val24.Add(typeFromHandle3, (object)val25);
			val24.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val26 = new XmlNamespaceResolver();
			val26.Add("", "http://xamarin.com/schemas/2014/forms");
			val26.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val26.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val26.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val26.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val26.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val24.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val26, typeof(ConnectionAlertView).GetTypeInfo().Assembly));
			val24.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 29)));
			DynamicResource val27 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val24);
			((IDynamicResourceHandler)val4).SetDynamicResource(BoxView.ColorProperty, val27.get_Key());
			((Layout<View>)(object)val15).get_Children().Add((View)(object)val4);
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val6).SetValue(Label.TextProperty, (object)connectionAlertView_ConnectionAlert);
			val5.set_Key("Heading1");
			XamlServiceProvider val28 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 8];
			array3[0] = val6;
			array3[1] = val14;
			array3[2] = val15;
			array3[3] = shadowFrame;
			array3[4] = val16;
			array3[5] = val17;
			array3[6] = val18;
			array3[7] = connectionAlertView;
			SimpleValueTargetProvider val29 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val19);
			object obj3 = (object)val29;
			val28.Add(typeFromHandle5, (object)val29);
			val28.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val30 = new XmlNamespaceResolver();
			val30.Add("", "http://xamarin.com/schemas/2014/forms");
			val30.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val30.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val30.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val30.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val30.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val28.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val30, typeof(ConnectionAlertView).GetTypeInfo().Assembly));
			val28.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 33)));
			DynamicResource val31 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val28);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val31.get_Key());
			((BindableObject)val6).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val6);
			((BindableObject)val7).SetValue(VisualElement.HeightRequestProperty, (object)250.0);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("ConnectionAlert"));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val7).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val7);
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			((BindableObject)val8).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val8).SetValue(Label.TextProperty, (object)connectionAlertView_Description);
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val8);
			((BindableObject)val9).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((BindableObject)val9).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val9).SetValue(Label.TextProperty, (object)connectionAlertView_CheckYourSettings);
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val9);
			val10.set_Key("LargeButtonStyle");
			XamlServiceProvider val32 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val13;
			array4[1] = val14;
			array4[2] = val15;
			array4[3] = shadowFrame;
			array4[4] = val16;
			array4[5] = val17;
			array4[6] = val18;
			array4[7] = connectionAlertView;
			SimpleValueTargetProvider val33 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val19);
			object obj4 = (object)val33;
			val32.Add(typeFromHandle7, (object)val33);
			val32.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val34 = new XmlNamespaceResolver();
			val34.Add("", "http://xamarin.com/schemas/2014/forms");
			val34.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val34.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val34.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val34.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val34.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val32.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val34, typeof(ConnectionAlertView).GetTypeInfo().Assembly));
			val32.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(52, 33)));
			DynamicResource val35 = ((IMarkupExtension<DynamicResource>)(object)val10).ProvideValue((IServiceProvider)val32);
			((IDynamicResourceHandler)val13).SetDynamicResource(VisualElement.StyleProperty, val35.get_Key());
			val11.set_Key("QuartenaryColor");
			XamlServiceProvider val36 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 8];
			array5[0] = val13;
			array5[1] = val14;
			array5[2] = val15;
			array5[3] = shadowFrame;
			array5[4] = val16;
			array5[5] = val17;
			array5[6] = val18;
			array5[7] = connectionAlertView;
			SimpleValueTargetProvider val37 = new SimpleValueTargetProvider(array5, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val19);
			object obj5 = (object)val37;
			val36.Add(typeFromHandle9, (object)val37);
			val36.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val38 = new XmlNamespaceResolver();
			val38.Add("", "http://xamarin.com/schemas/2014/forms");
			val38.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val38.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val38.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val38.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val38.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val36.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val38, typeof(ConnectionAlertView).GetTypeInfo().Assembly));
			val36.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(53, 33)));
			DynamicResource val39 = ((IMarkupExtension<DynamicResource>)(object)val11).ProvideValue((IServiceProvider)val36);
			((IDynamicResourceHandler)val13).SetDynamicResource(VisualElement.BackgroundColorProperty, val39.get_Key());
			((BindableObject)val13).SetValue(Button.TextProperty, (object)button_Settings);
			val12.set_Path("OpenSettingsCommand");
			BindingBase val40 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)val13).SetBinding(Button.CommandProperty, val40);
			((BindableObject)val13).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val13);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)val14);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val15);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)shadowFrame);
			val17.set_Content((View)(object)val16);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val17);
			((BindableObject)connectionAlertView).SetValue(ContentPage.ContentProperty, (object)val18);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ConnectionAlertView>(this, typeof(ConnectionAlertView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
		}
	}
}
