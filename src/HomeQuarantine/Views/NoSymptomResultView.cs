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
	[XamlFilePath("Views/NoSymptomResultView.xaml")]
	public class NoSymptomResultView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label submittedDailySymptomCheck;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label takingCareOfYourHealthAndWellBeing;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label healthDescription;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView mentalHealthSupport;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView usingTechnologyToStayConnected;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView stayingActiveAndHealthy;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView mindfulness;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView serviceAndSupport;

		public bool ShowDismiss => true;

		public NoSymptomResultView()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			(((BindableObject)this).get_BindingContext() as NoSymptomResultViewModel).PopAllPreviousPagesCommand.Execute(null);
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
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
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
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Expected O, but got Unknown
			//IL_042d: Expected O, but got Unknown
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Unknown result type (might be due to invalid IL or missing references)
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Expected O, but got Unknown
			//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dd: Expected O, but got Unknown
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Expected O, but got Unknown
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fb: Expected O, but got Unknown
			//IL_0500: Expected O, but got Unknown
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Expected O, but got Unknown
			//IL_0602: Expected O, but got Unknown
			//IL_0602: Unknown result type (might be due to invalid IL or missing references)
			//IL_0614: Unknown result type (might be due to invalid IL or missing references)
			//IL_061f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0624: Unknown result type (might be due to invalid IL or missing references)
			//IL_0634: Unknown result type (might be due to invalid IL or missing references)
			//IL_0644: Unknown result type (might be due to invalid IL or missing references)
			//IL_0654: Unknown result type (might be due to invalid IL or missing references)
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_0674: Unknown result type (might be due to invalid IL or missing references)
			//IL_0684: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Expected O, but got Unknown
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b2: Expected O, but got Unknown
			//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Expected O, but got Unknown
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d0: Expected O, but got Unknown
			//IL_06d5: Expected O, but got Unknown
			//IL_0715: Unknown result type (might be due to invalid IL or missing references)
			//IL_074f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0786: Unknown result type (might be due to invalid IL or missing references)
			//IL_078b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d0: Expected O, but got Unknown
			//IL_07d5: Expected O, but got Unknown
			//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_0827: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			//IL_0847: Unknown result type (might be due to invalid IL or missing references)
			//IL_0857: Unknown result type (might be due to invalid IL or missing references)
			//IL_0880: Expected O, but got Unknown
			//IL_087b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0885: Expected O, but got Unknown
			//IL_0885: Unknown result type (might be due to invalid IL or missing references)
			//IL_0894: Unknown result type (might be due to invalid IL or missing references)
			//IL_089e: Expected O, but got Unknown
			//IL_0899: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a3: Expected O, but got Unknown
			//IL_08a8: Expected O, but got Unknown
			//IL_0906: Unknown result type (might be due to invalid IL or missing references)
			//IL_092a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0980: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(NoSymptomResultView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/NoSymptomResultView.xaml");
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
			BindingExtension val2 = new BindingExtension();
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			string noSymptomView_NoNewSymptoms = Resources.NoSymptomView_NoNewSymptoms;
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			Label val4 = new Label();
			string noSymptomView_YouHaveSubmittedYourDailySymptomCheck = Resources.NoSymptomView_YouHaveSubmittedYourDailySymptomCheck;
			Label val5 = new Label();
			DynamicResourceExtension val6 = new DynamicResourceExtension();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			BoxView val8 = new BoxView();
			string noSymptomView_TakingCareOfYourHealthAndWellBeing = Resources.NoSymptomView_TakingCareOfYourHealthAndWellBeing;
			Label val9 = new Label();
			string noSymptomView_HealthDescription = Resources.NoSymptomView_HealthDescription;
			Label val10 = new Label();
			string noSymptomView_MentalHealthSupport = Resources.NoSymptomView_MentalHealthSupport;
			BindingExtension val11 = new BindingExtension();
			ResourceLinkView resourceLinkView = new ResourceLinkView();
			string noSymptomView_UsingtechnologyToStayConnected = Resources.NoSymptomView_UsingtechnologyToStayConnected;
			BindingExtension val12 = new BindingExtension();
			ResourceLinkView resourceLinkView2 = new ResourceLinkView();
			string noSymptomView_StayActiveAndhealthy = Resources.NoSymptomView_StayActiveAndhealthy;
			BindingExtension val13 = new BindingExtension();
			ResourceLinkView resourceLinkView3 = new ResourceLinkView();
			string noSymptomView_Mindfulness = Resources.NoSymptomView_Mindfulness;
			BindingExtension val14 = new BindingExtension();
			ResourceLinkView resourceLinkView4 = new ResourceLinkView();
			string noSymptomView_ServiceandSupport = Resources.NoSymptomView_ServiceandSupport;
			BindingExtension val15 = new BindingExtension();
			ResourceLinkView resourceLinkView5 = new ResourceLinkView();
			StackLayout val16 = new StackLayout();
			StackLayout val17 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val18 = new StackLayout();
			ScrollView val19 = new ScrollView();
			StackLayout val20 = new StackLayout();
			NoSymptomResultView noSymptomResultView;
			NameScope val21 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(noSymptomResultView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)noSymptomResultView, (INameScope)(object)val21);
			((INameScope)val21).RegisterName("containingView", (object)val18);
			if (((Element)val18).get_StyleId() == null)
			{
				((Element)val18).set_StyleId("containingView");
			}
			((INameScope)val21).RegisterName("submittedDailySymptomCheck", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("submittedDailySymptomCheck");
			}
			((INameScope)val21).RegisterName("takingCareOfYourHealthAndWellBeing", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("takingCareOfYourHealthAndWellBeing");
			}
			((INameScope)val21).RegisterName("healthDescription", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("healthDescription");
			}
			((INameScope)val21).RegisterName("mentalHealthSupport", (object)resourceLinkView);
			if (((Element)resourceLinkView).get_StyleId() == null)
			{
				((Element)resourceLinkView).set_StyleId("mentalHealthSupport");
			}
			((INameScope)val21).RegisterName("usingTechnologyToStayConnected", (object)resourceLinkView2);
			if (((Element)resourceLinkView2).get_StyleId() == null)
			{
				((Element)resourceLinkView2).set_StyleId("usingTechnologyToStayConnected");
			}
			((INameScope)val21).RegisterName("stayingActiveAndHealthy", (object)resourceLinkView3);
			if (((Element)resourceLinkView3).get_StyleId() == null)
			{
				((Element)resourceLinkView3).set_StyleId("stayingActiveAndHealthy");
			}
			((INameScope)val21).RegisterName("mindfulness", (object)resourceLinkView4);
			if (((Element)resourceLinkView4).get_StyleId() == null)
			{
				((Element)resourceLinkView4).set_StyleId("mindfulness");
			}
			((INameScope)val21).RegisterName("serviceAndSupport", (object)resourceLinkView5);
			if (((Element)resourceLinkView5).get_StyleId() == null)
			{
				((Element)resourceLinkView5).set_StyleId("serviceAndSupport");
			}
			containingView = val18;
			submittedDailySymptomCheck = val5;
			takingCareOfYourHealthAndWellBeing = val9;
			healthDescription = val10;
			mentalHealthSupport = resourceLinkView;
			usingTechnologyToStayConnected = resourceLinkView2;
			stayingActiveAndHealthy = resourceLinkView3;
			mindfulness = resourceLinkView4;
			serviceAndSupport = resourceLinkView5;
			((BindableObject)noSymptomResultView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Path("Title");
			BindingBase val22 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)noSymptomResultView).SetBinding(Page.TitleProperty, val22);
			((VisualElement)noSymptomResultView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)noSymptomResultView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val20).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val19).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0, 16.0, 24.0));
			((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val4).SetValue(Label.TextProperty, (object)noSymptomView_NoNewSymptoms);
			val3.set_Key("Heading1");
			XamlServiceProvider val23 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = val4;
			array[1] = val18;
			array[2] = val19;
			array[3] = val20;
			array[4] = noSymptomResultView;
			SimpleValueTargetProvider val24 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val21);
			object obj = (object)val24;
			val23.Add(typeFromHandle, (object)val24);
			val23.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val25 = new XmlNamespaceResolver();
			val25.Add("", "http://xamarin.com/schemas/2014/forms");
			val25.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val25.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val25.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val25.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val25.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val25.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val23.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val25, typeof(NoSymptomResultView).GetTypeInfo().Assembly));
			val23.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 21)));
			DynamicResource val26 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val23);
			((IDynamicResourceHandler)val4).SetDynamicResource(VisualElement.StyleProperty, val26.get_Key());
			((BindableObject)val4).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val4);
			((BindableObject)val5).SetValue(Label.TextProperty, (object)noSymptomView_YouHaveSubmittedYourDailySymptomCheck);
			((BindableObject)val5).SetValue(View.MarginProperty, (object)new Thickness(16.0, 4.0, 16.0, 0.0));
			((BindableObject)val5).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val5);
			val6.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val27 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 5];
			array2[0] = shadowFrame;
			array2[1] = val18;
			array2[2] = val19;
			array2[3] = val20;
			array2[4] = noSymptomResultView;
			SimpleValueTargetProvider val28 = new SimpleValueTargetProvider(array2, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val21);
			object obj2 = (object)val28;
			val27.Add(typeFromHandle3, (object)val28);
			val27.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val29 = new XmlNamespaceResolver();
			val29.Add("", "http://xamarin.com/schemas/2014/forms");
			val29.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val29.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val29.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val29.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val29.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val29.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val27.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val29, typeof(NoSymptomResultView).GetTypeInfo().Assembly));
			val27.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 21)));
			DynamicResource val30 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val27);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val30.get_Key());
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0, 24.0, 0.0, 16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 24.0));
			((BindableObject)val17).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val7.set_Key("PrimaryColor");
			XamlServiceProvider val31 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 7];
			array3[0] = val8;
			array3[1] = val17;
			array3[2] = shadowFrame;
			array3[3] = val18;
			array3[4] = val19;
			array3[5] = val20;
			array3[6] = noSymptomResultView;
			SimpleValueTargetProvider val32 = new SimpleValueTargetProvider(array3, (object)BoxView.ColorProperty, (INameScope)(object)val21);
			object obj3 = (object)val32;
			val31.Add(typeFromHandle5, (object)val32);
			val31.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val33 = new XmlNamespaceResolver();
			val33.Add("", "http://xamarin.com/schemas/2014/forms");
			val33.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val33.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val33.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val33.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val33.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val33.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val31.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val33, typeof(NoSymptomResultView).GetTypeInfo().Assembly));
			val31.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 34)));
			DynamicResource val34 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val31);
			((IDynamicResourceHandler)val8).SetDynamicResource(BoxView.ColorProperty, val34.get_Key());
			((BindableObject)val8).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val8);
			((BindableObject)val16).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val9).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val9).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val9).SetValue(Label.TextProperty, (object)noSymptomView_TakingCareOfYourHealthAndWellBeing);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val9);
			((BindableObject)val10).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)val10).SetValue(Label.TextProperty, (object)noSymptomView_HealthDescription);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val10);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_MentalHealthSupport);
			val11.set_Path("MentalHealthSupportUrl");
			BindingBase val35 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.UrlProperty, val35);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)resourceLinkView);
			((BindableObject)resourceLinkView2).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_UsingtechnologyToStayConnected);
			val12.set_Path("UsingTechnologyToStayConnectedUrl");
			BindingBase val36 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView2).SetBinding(ResourceLinkView.UrlProperty, val36);
			((BindableObject)resourceLinkView2).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)resourceLinkView2);
			((BindableObject)resourceLinkView3).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_StayActiveAndhealthy);
			((BindableObject)resourceLinkView3).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			val13.set_Path("StayingActiveAndHealthyUrl");
			BindingBase val37 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView3).SetBinding(ResourceLinkView.UrlProperty, val37);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)resourceLinkView3);
			((BindableObject)resourceLinkView4).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_Mindfulness);
			val14.set_Path("MindfulnessUrl");
			BindingBase val38 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView4).SetBinding(ResourceLinkView.UrlProperty, val38);
			((BindableObject)resourceLinkView4).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)resourceLinkView4);
			((BindableObject)resourceLinkView5).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_ServiceandSupport);
			val15.set_Path("ServicesAndSupportUrl");
			BindingBase val39 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView5).SetBinding(ResourceLinkView.UrlProperty, val39);
			((BindableObject)resourceLinkView5).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)resourceLinkView5);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val16);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val17);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)shadowFrame);
			val19.set_Content((View)(object)val18);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val19);
			((BindableObject)noSymptomResultView).SetValue(ContentPage.ContentProperty, (object)val20);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<NoSymptomResultView>(this, typeof(NoSymptomResultView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			submittedDailySymptomCheck = NameScopeExtensions.FindByName<Label>((Element)(object)this, "submittedDailySymptomCheck");
			takingCareOfYourHealthAndWellBeing = NameScopeExtensions.FindByName<Label>((Element)(object)this, "takingCareOfYourHealthAndWellBeing");
			healthDescription = NameScopeExtensions.FindByName<Label>((Element)(object)this, "healthDescription");
			mentalHealthSupport = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "mentalHealthSupport");
			usingTechnologyToStayConnected = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "usingTechnologyToStayConnected");
			stayingActiveAndHealthy = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "stayingActiveAndHealthy");
			mindfulness = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "mindfulness");
			serviceAndSupport = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "serviceAndSupport");
		}
	}
}
