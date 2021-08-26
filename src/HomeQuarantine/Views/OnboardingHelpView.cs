using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using FFImageLoading.Forms;
using HomeQuarantine.Controls;
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
	[XamlFilePath("Views/OnboardingHelpView.xaml")]
	public class OnboardingHelpView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label title;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TintedCachedImage image;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout descriptionStack;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Button actionButton;

		public bool ShowDismiss => (((BindableObject)this).get_BindingContext() as OnboardingHelpViewModel).ShowDismiss;

		public OnboardingHelpView()
		{
			InitializeComponent();
		}

		public async Task Dismiss()
		{
			OnboardingHelpViewModel viewModel = ((BindableObject)this).get_BindingContext() as OnboardingHelpViewModel;
			if (viewModel.IsPermissionsType)
			{
				if (await viewModel.IsPermissionGranted())
				{
					await ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().PopModalAsync();
					if (viewModel.AfterClosed != null)
					{
						await viewModel.AfterClosed();
					}
				}
			}
			else
			{
				await ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().PopModalAsync();
			}
		}

		public async Task OnResume()
		{
			OnboardingHelpViewModel onboardingHelpViewModel = ((BindableObject)this).get_BindingContext() as OnboardingHelpViewModel;
			if (onboardingHelpViewModel.IsPermissionsType)
			{
				bool flag = onboardingHelpViewModel.IsPermissionGranted != null;
				if (flag)
				{
					flag = await onboardingHelpViewModel.IsPermissionGranted();
				}
				if (flag)
				{
					await Dismiss();
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
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
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
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected O, but got Unknown
			//IL_027b: Expected O, but got Unknown
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Expected O, but got Unknown
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected O, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Expected O, but got Unknown
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected O, but got Unknown
			//IL_032d: Expected O, but got Unknown
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04df: Expected O, but got Unknown
			//IL_04e4: Expected O, but got Unknown
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Unknown result type (might be due to invalid IL or missing references)
			//IL_0516: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Expected O, but got Unknown
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Expected O, but got Unknown
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Expected O, but got Unknown
			//IL_0588: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Expected O, but got Unknown
			//IL_0597: Expected O, but got Unknown
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_0678: Unknown result type (might be due to invalid IL or missing references)
			//IL_06de: Unknown result type (might be due to invalid IL or missing references)
			//IL_081e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0823: Unknown result type (might be due to invalid IL or missing references)
			//IL_0865: Unknown result type (might be due to invalid IL or missing references)
			//IL_086a: Unknown result type (might be due to invalid IL or missing references)
			//IL_086d: Expected O, but got Unknown
			//IL_0872: Expected O, but got Unknown
			//IL_0872: Unknown result type (might be due to invalid IL or missing references)
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_088f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0894: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fd: Expected O, but got Unknown
			//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0902: Expected O, but got Unknown
			//IL_0902: Unknown result type (might be due to invalid IL or missing references)
			//IL_0911: Unknown result type (might be due to invalid IL or missing references)
			//IL_091b: Expected O, but got Unknown
			//IL_0916: Unknown result type (might be due to invalid IL or missing references)
			//IL_0920: Expected O, but got Unknown
			//IL_0925: Expected O, but got Unknown
			//IL_0965: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(OnboardingHelpView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/OnboardingHelpView.xaml");
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
			BindingExtension val3 = new BindingExtension();
			BoxView val4 = new BoxView();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			BindingExtension val6 = new BindingExtension();
			Label val7 = new Label();
			BindingExtension val8 = new BindingExtension();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val9 = new StackLayout();
			BindingExtension val10 = new BindingExtension();
			DataTemplate val11 = new DataTemplate();
			StackLayout val12 = new StackLayout();
			BindingExtension val13 = new BindingExtension();
			BindingExtension val14 = new BindingExtension();
			BindingExtension val15 = new BindingExtension();
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			Button val17 = new Button();
			StackLayout val18 = new StackLayout();
			StackLayout val19 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val20 = new StackLayout();
			ScrollView val21 = new ScrollView();
			StackLayout val22 = new StackLayout();
			OnboardingHelpView onboardingHelpView;
			NameScope val23 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(onboardingHelpView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)onboardingHelpView, (INameScope)(object)val23);
			((INameScope)val23).RegisterName("containingView", (object)val20);
			if (((Element)val20).get_StyleId() == null)
			{
				((Element)val20).set_StyleId("containingView");
			}
			((INameScope)val23).RegisterName("border", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("border");
			}
			((INameScope)val23).RegisterName("title", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("title");
			}
			((INameScope)val23).RegisterName("image", (object)tintedCachedImage);
			if (((Element)tintedCachedImage).get_StyleId() == null)
			{
				((Element)tintedCachedImage).set_StyleId("image");
			}
			((INameScope)val23).RegisterName("descriptionStack", (object)val12);
			if (((Element)val12).get_StyleId() == null)
			{
				((Element)val12).set_StyleId("descriptionStack");
			}
			((INameScope)val23).RegisterName("actionButton", (object)val17);
			if (((Element)val17).get_StyleId() == null)
			{
				((Element)val17).set_StyleId("actionButton");
			}
			containingView = val20;
			border = val4;
			title = val7;
			image = tintedCachedImage;
			descriptionStack = val12;
			actionButton = val17;
			((BindableObject)onboardingHelpView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Key("BackgroundColor");
			XamlServiceProvider val24 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = onboardingHelpView;
			SimpleValueTargetProvider val25 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val23);
			object obj = (object)val25;
			val24.Add(typeFromHandle, (object)val25);
			val24.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val26 = new XmlNamespaceResolver();
			val26.Add("", "http://xamarin.com/schemas/2014/forms");
			val26.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val26.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val26.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val26.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val24.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val26, typeof(OnboardingHelpView).GetTypeInfo().Assembly));
			val24.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 5)));
			DynamicResource val27 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val24);
			((IDynamicResourceHandler)onboardingHelpView).SetDynamicResource(VisualElement.BackgroundColorProperty, val27.get_Key());
			((BindableObject)onboardingHelpView).SetValue(Page.TitleProperty, (object)"Help");
			((BindableObject)val22).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val21).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 32.0, 16.0, 16.0));
			((BindableObject)val21).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)val4).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val3.set_Path("ButtonColour");
			BindingBase val28 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(BoxView.ColorProperty, val28);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val4);
			((BindableObject)val18).SetValue(StackLayout.SpacingProperty, (object)0.0);
			val5.set_Key("Heading1");
			XamlServiceProvider val29 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 8];
			array2[0] = val7;
			array2[1] = val18;
			array2[2] = val19;
			array2[3] = shadowFrame;
			array2[4] = val20;
			array2[5] = val21;
			array2[6] = val22;
			array2[7] = onboardingHelpView;
			SimpleValueTargetProvider val30 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val23);
			object obj2 = (object)val30;
			val29.Add(typeFromHandle3, (object)val30);
			val29.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val31 = new XmlNamespaceResolver();
			val31.Add("", "http://xamarin.com/schemas/2014/forms");
			val31.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val31.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val31.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val31.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val29.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val31, typeof(OnboardingHelpView).GetTypeInfo().Assembly));
			val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 33)));
			DynamicResource val32 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val29);
			((IDynamicResourceHandler)val7).SetDynamicResource(VisualElement.StyleProperty, val32.get_Key());
			((BindableObject)val7).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 24.0));
			val6.set_Path("Title");
			BindingBase val33 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)null);
			((BindableObject)val7).SetBinding(Label.TextProperty, val33);
			((BindableObject)val7).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val7);
			((BindableObject)val9).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((BindableObject)val9).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			val8.set_Path("ImageSource");
			BindingBase val34 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)tintedCachedImage).SetBinding(CachedImage.SourceProperty, val34);
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val9).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val9);
			val10.set_Path("Descriptions");
			BindingBase val35 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)val12).SetBinding(BindableLayout.ItemsSourceProperty, val35);
			object[] array3 = new object[0 + 9];
			array3[0] = val11;
			array3[1] = val12;
			array3[2] = val18;
			array3[3] = val19;
			array3[4] = shadowFrame;
			array3[5] = val20;
			array3[6] = val21;
			array3[7] = val22;
			array3[8] = onboardingHelpView;
			object[] parentValues = array3;
			OnboardingHelpView root = onboardingHelpView;
			((IDataTemplate)val11).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				BindingExtension val43 = new BindingExtension();
				Label val44 = new Label();
				NameScope val45 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val44, (INameScope)(object)val45);
				val43.set_Path(".");
				BindingBase val46 = ((IMarkupExtension<BindingBase>)(object)val43).ProvideValue((IServiceProvider)null);
				((BindableObject)val44).SetBinding(Label.TextProperty, val46);
				((BindableObject)val44).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val44).SetValue(View.MarginProperty, (object)new Thickness(16.0, 8.0));
				return val44;
			});
			((BindableObject)val12).SetValue(BindableLayout.ItemTemplateProperty, (object)val11);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val12);
			val13.set_Path("ButtonCommand");
			BindingBase val36 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)null);
			((BindableObject)val17).SetBinding(Button.CommandProperty, val36);
			val14.set_Path("ButtonText");
			BindingBase val37 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)val17).SetBinding(Button.TextProperty, val37);
			val15.set_Path("ButtonColour");
			BindingBase val38 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)null);
			((BindableObject)val17).SetBinding(VisualElement.BackgroundColorProperty, val38);
			val16.set_Key("LargeButtonStyle");
			XamlServiceProvider val39 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val17;
			array4[1] = val18;
			array4[2] = val19;
			array4[3] = shadowFrame;
			array4[4] = val20;
			array4[5] = val21;
			array4[6] = val22;
			array4[7] = onboardingHelpView;
			SimpleValueTargetProvider val40 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val23);
			object obj3 = (object)val40;
			val39.Add(typeFromHandle5, (object)val40);
			val39.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val41 = new XmlNamespaceResolver();
			val41.Add("", "http://xamarin.com/schemas/2014/forms");
			val41.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val41.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val41.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val41.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val39.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val41, typeof(OnboardingHelpView).GetTypeInfo().Assembly));
			val39.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(65, 33)));
			DynamicResource val42 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val39);
			((IDynamicResourceHandler)val17).SetDynamicResource(VisualElement.StyleProperty, val42.get_Key());
			((BindableObject)val17).SetValue(View.MarginProperty, (object)new Thickness(32.0, 16.0, 32.0, 32.0));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val17);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val19);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)shadowFrame);
			val21.set_Content((View)(object)val20);
			((Layout<View>)(object)val22).get_Children().Add((View)(object)val21);
			((BindableObject)onboardingHelpView).SetValue(ContentPage.ContentProperty, (object)val22);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<OnboardingHelpView>(this, typeof(OnboardingHelpView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			title = NameScopeExtensions.FindByName<Label>((Element)(object)this, "title");
			image = NameScopeExtensions.FindByName<TintedCachedImage>((Element)(object)this, "image");
			descriptionStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "descriptionStack");
			actionButton = NameScopeExtensions.FindByName<Button>((Element)(object)this, "actionButton");
		}
	}
}
