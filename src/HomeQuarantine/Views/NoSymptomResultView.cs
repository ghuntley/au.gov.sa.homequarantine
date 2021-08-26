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
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected O, but got Unknown
			//IL_0418: Expected O, but got Unknown
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected O, but got Unknown
			//IL_04be: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c8: Expected O, but got Unknown
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Expected O, but got Unknown
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Expected O, but got Unknown
			//IL_04eb: Expected O, but got Unknown
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Unknown result type (might be due to invalid IL or missing references)
			//IL_0578: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Expected O, but got Unknown
			//IL_05ed: Expected O, but got Unknown
			//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Unknown result type (might be due to invalid IL or missing references)
			//IL_060f: Unknown result type (might be due to invalid IL or missing references)
			//IL_061f: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_065f: Unknown result type (might be due to invalid IL or missing references)
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0698: Expected O, but got Unknown
			//IL_0693: Unknown result type (might be due to invalid IL or missing references)
			//IL_069d: Expected O, but got Unknown
			//IL_069d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b6: Expected O, but got Unknown
			//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bb: Expected O, but got Unknown
			//IL_06c0: Expected O, but got Unknown
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0771: Unknown result type (might be due to invalid IL or missing references)
			//IL_0776: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bb: Expected O, but got Unknown
			//IL_07c0: Expected O, but got Unknown
			//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0802: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Unknown result type (might be due to invalid IL or missing references)
			//IL_0822: Unknown result type (might be due to invalid IL or missing references)
			//IL_0832: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Unknown result type (might be due to invalid IL or missing references)
			//IL_086b: Expected O, but got Unknown
			//IL_0866: Unknown result type (might be due to invalid IL or missing references)
			//IL_0870: Expected O, but got Unknown
			//IL_0870: Unknown result type (might be due to invalid IL or missing references)
			//IL_087f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0889: Expected O, but got Unknown
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_088e: Expected O, but got Unknown
			//IL_0893: Expected O, but got Unknown
			//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0915: Unknown result type (might be due to invalid IL or missing references)
			//IL_096b: Unknown result type (might be due to invalid IL or missing references)
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
			string hasSymptomView_MonitoringSymptoms = Resources.HasSymptomView_MonitoringSymptoms;
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			string noSymptomView_NoNewSymptoms = Resources.NoSymptomView_NoNewSymptoms;
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			Label val3 = new Label();
			string noSymptomView_YouHaveSubmittedYourDailySymptomCheck = Resources.NoSymptomView_YouHaveSubmittedYourDailySymptomCheck;
			Label val4 = new Label();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			DynamicResourceExtension val6 = new DynamicResourceExtension();
			BoxView val7 = new BoxView();
			string noSymptomView_TakingCareOfYourHealthAndWellBeing = Resources.NoSymptomView_TakingCareOfYourHealthAndWellBeing;
			Label val8 = new Label();
			string noSymptomView_HealthDescription = Resources.NoSymptomView_HealthDescription;
			Label val9 = new Label();
			string noSymptomView_MentalHealthSupport = Resources.NoSymptomView_MentalHealthSupport;
			BindingExtension val10 = new BindingExtension();
			ResourceLinkView resourceLinkView = new ResourceLinkView();
			string noSymptomView_UsingtechnologyToStayConnected = Resources.NoSymptomView_UsingtechnologyToStayConnected;
			BindingExtension val11 = new BindingExtension();
			ResourceLinkView resourceLinkView2 = new ResourceLinkView();
			string noSymptomView_StayActiveAndhealthy = Resources.NoSymptomView_StayActiveAndhealthy;
			BindingExtension val12 = new BindingExtension();
			ResourceLinkView resourceLinkView3 = new ResourceLinkView();
			string noSymptomView_Mindfulness = Resources.NoSymptomView_Mindfulness;
			BindingExtension val13 = new BindingExtension();
			ResourceLinkView resourceLinkView4 = new ResourceLinkView();
			string noSymptomView_ServiceandSupport = Resources.NoSymptomView_ServiceandSupport;
			BindingExtension val14 = new BindingExtension();
			ResourceLinkView resourceLinkView5 = new ResourceLinkView();
			StackLayout val15 = new StackLayout();
			StackLayout val16 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val17 = new StackLayout();
			ScrollView val18 = new ScrollView();
			StackLayout val19 = new StackLayout();
			NoSymptomResultView noSymptomResultView;
			NameScope val20 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(noSymptomResultView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)noSymptomResultView, (INameScope)(object)val20);
			((INameScope)val20).RegisterName("containingView", (object)val17);
			if (((Element)val17).get_StyleId() == null)
			{
				((Element)val17).set_StyleId("containingView");
			}
			((INameScope)val20).RegisterName("submittedDailySymptomCheck", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("submittedDailySymptomCheck");
			}
			((INameScope)val20).RegisterName("takingCareOfYourHealthAndWellBeing", (object)val8);
			if (((Element)val8).get_StyleId() == null)
			{
				((Element)val8).set_StyleId("takingCareOfYourHealthAndWellBeing");
			}
			((INameScope)val20).RegisterName("healthDescription", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("healthDescription");
			}
			((INameScope)val20).RegisterName("mentalHealthSupport", (object)resourceLinkView);
			if (((Element)resourceLinkView).get_StyleId() == null)
			{
				((Element)resourceLinkView).set_StyleId("mentalHealthSupport");
			}
			((INameScope)val20).RegisterName("usingTechnologyToStayConnected", (object)resourceLinkView2);
			if (((Element)resourceLinkView2).get_StyleId() == null)
			{
				((Element)resourceLinkView2).set_StyleId("usingTechnologyToStayConnected");
			}
			((INameScope)val20).RegisterName("stayingActiveAndHealthy", (object)resourceLinkView3);
			if (((Element)resourceLinkView3).get_StyleId() == null)
			{
				((Element)resourceLinkView3).set_StyleId("stayingActiveAndHealthy");
			}
			((INameScope)val20).RegisterName("mindfulness", (object)resourceLinkView4);
			if (((Element)resourceLinkView4).get_StyleId() == null)
			{
				((Element)resourceLinkView4).set_StyleId("mindfulness");
			}
			((INameScope)val20).RegisterName("serviceAndSupport", (object)resourceLinkView5);
			if (((Element)resourceLinkView5).get_StyleId() == null)
			{
				((Element)resourceLinkView5).set_StyleId("serviceAndSupport");
			}
			containingView = val17;
			submittedDailySymptomCheck = val4;
			takingCareOfYourHealthAndWellBeing = val8;
			healthDescription = val9;
			mentalHealthSupport = resourceLinkView;
			usingTechnologyToStayConnected = resourceLinkView2;
			stayingActiveAndHealthy = resourceLinkView3;
			mindfulness = resourceLinkView4;
			serviceAndSupport = resourceLinkView5;
			((BindableObject)noSymptomResultView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)noSymptomResultView).SetValue(Page.TitleProperty, (object)hasSymptomView_MonitoringSymptoms);
			((VisualElement)noSymptomResultView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)noSymptomResultView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val18).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0, 16.0, 24.0));
			((BindableObject)val18).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val3).SetValue(Label.TextProperty, (object)noSymptomView_NoNewSymptoms);
			val2.set_Key("Heading1");
			XamlServiceProvider val21 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = val3;
			array[1] = val17;
			array[2] = val18;
			array[3] = val19;
			array[4] = noSymptomResultView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val20);
			object obj = (object)val22;
			val21.Add(typeFromHandle, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val23.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val23.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val23.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val23.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val23.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val21.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(NoSymptomResultView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 21)));
			DynamicResource val24 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val21);
			((IDynamicResourceHandler)val3).SetDynamicResource(VisualElement.StyleProperty, val24.get_Key());
			((BindableObject)val3).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val3);
			((BindableObject)val4).SetValue(Label.TextProperty, (object)noSymptomView_YouHaveSubmittedYourDailySymptomCheck);
			((BindableObject)val4).SetValue(View.MarginProperty, (object)new Thickness(16.0, 4.0, 16.0, 0.0));
			((BindableObject)val4).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val17).get_Children().Add((View)(object)val4);
			val5.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val25 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 5];
			array2[0] = shadowFrame;
			array2[1] = val17;
			array2[2] = val18;
			array2[3] = val19;
			array2[4] = noSymptomResultView;
			SimpleValueTargetProvider val26 = new SimpleValueTargetProvider(array2, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val20);
			object obj2 = (object)val26;
			val25.Add(typeFromHandle3, (object)val26);
			val25.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val27 = new XmlNamespaceResolver();
			val27.Add("", "http://xamarin.com/schemas/2014/forms");
			val27.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val27.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val27.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val27.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val27.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val27.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val25.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val27, typeof(NoSymptomResultView).GetTypeInfo().Assembly));
			val25.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 21)));
			DynamicResource val28 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val25);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val28.get_Key());
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0, 24.0, 0.0, 16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 24.0));
			((BindableObject)val16).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val6.set_Key("PrimaryColor");
			XamlServiceProvider val29 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 7];
			array3[0] = val7;
			array3[1] = val16;
			array3[2] = shadowFrame;
			array3[3] = val17;
			array3[4] = val18;
			array3[5] = val19;
			array3[6] = noSymptomResultView;
			SimpleValueTargetProvider val30 = new SimpleValueTargetProvider(array3, (object)BoxView.ColorProperty, (INameScope)(object)val20);
			object obj3 = (object)val30;
			val29.Add(typeFromHandle5, (object)val30);
			val29.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val31 = new XmlNamespaceResolver();
			val31.Add("", "http://xamarin.com/schemas/2014/forms");
			val31.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val31.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val31.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val31.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val31.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val31.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val29.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val31, typeof(NoSymptomResultView).GetTypeInfo().Assembly));
			val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 34)));
			DynamicResource val32 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val29);
			((IDynamicResourceHandler)val7).SetDynamicResource(BoxView.ColorProperty, val32.get_Key());
			((BindableObject)val7).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val7);
			((BindableObject)val15).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val8).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val8).SetValue(Label.TextProperty, (object)noSymptomView_TakingCareOfYourHealthAndWellBeing);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)val8);
			((BindableObject)val9).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)val9).SetValue(Label.TextProperty, (object)noSymptomView_HealthDescription);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)val9);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_MentalHealthSupport);
			val10.set_Path("MentalHealthSupportUrl");
			BindingBase val33 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.UrlProperty, val33);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)resourceLinkView);
			((BindableObject)resourceLinkView2).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_UsingtechnologyToStayConnected);
			val11.set_Path("UsingTechnologyToStayConnectedUrl");
			BindingBase val34 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView2).SetBinding(ResourceLinkView.UrlProperty, val34);
			((BindableObject)resourceLinkView2).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)resourceLinkView2);
			((BindableObject)resourceLinkView3).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_StayActiveAndhealthy);
			((BindableObject)resourceLinkView3).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			val12.set_Path("StayingActiveAndHealthyUrl");
			BindingBase val35 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView3).SetBinding(ResourceLinkView.UrlProperty, val35);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)resourceLinkView3);
			((BindableObject)resourceLinkView4).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_Mindfulness);
			val13.set_Path("MindfulnessUrl");
			BindingBase val36 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView4).SetBinding(ResourceLinkView.UrlProperty, val36);
			((BindableObject)resourceLinkView4).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)resourceLinkView4);
			((BindableObject)resourceLinkView5).SetValue(ResourceLinkView.TextProperty, (object)noSymptomView_ServiceandSupport);
			val14.set_Path("ServicesAndSupportUrl");
			BindingBase val37 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView5).SetBinding(ResourceLinkView.UrlProperty, val37);
			((BindableObject)resourceLinkView5).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val15).get_Children().Add((View)(object)resourceLinkView5);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val15);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val16);
			((Layout<View>)(object)val17).get_Children().Add((View)(object)shadowFrame);
			val18.set_Content((View)(object)val17);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			((BindableObject)noSymptomResultView).SetValue(ContentPage.ContentProperty, (object)val19);
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
