using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/NotificationDetailsView.xaml")]
	public class NotificationDetailsView : BaseView, IChildView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label titleLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout descriptionStack;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ShadowFrame frameLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label headingLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout informationStack;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout linkStack;

		public NotificationDetailsView()
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
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected O, but got Unknown
			//IL_039b: Expected O, but got Unknown
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Expected O, but got Unknown
			//IL_0431: Unknown result type (might be due to invalid IL or missing references)
			//IL_043b: Expected O, but got Unknown
			//IL_043b: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Expected O, but got Unknown
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Expected O, but got Unknown
			//IL_045e: Expected O, but got Unknown
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected O, but got Unknown
			//IL_05ef: Expected O, but got Unknown
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_0631: Unknown result type (might be due to invalid IL or missing references)
			//IL_0641: Unknown result type (might be due to invalid IL or missing references)
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_0661: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Expected O, but got Unknown
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Expected O, but got Unknown
			//IL_068f: Unknown result type (might be due to invalid IL or missing references)
			//IL_069e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a8: Expected O, but got Unknown
			//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Expected O, but got Unknown
			//IL_06b2: Expected O, but got Unknown
			//IL_0745: Unknown result type (might be due to invalid IL or missing references)
			//IL_074a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0787: Unknown result type (might be due to invalid IL or missing references)
			//IL_078c: Unknown result type (might be due to invalid IL or missing references)
			//IL_078f: Expected O, but got Unknown
			//IL_0794: Expected O, but got Unknown
			//IL_0794: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0806: Unknown result type (might be due to invalid IL or missing references)
			//IL_082f: Expected O, but got Unknown
			//IL_082a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0834: Expected O, but got Unknown
			//IL_0834: Unknown result type (might be due to invalid IL or missing references)
			//IL_0843: Unknown result type (might be due to invalid IL or missing references)
			//IL_084d: Expected O, but got Unknown
			//IL_0848: Unknown result type (might be due to invalid IL or missing references)
			//IL_0852: Expected O, but got Unknown
			//IL_0857: Expected O, but got Unknown
			//IL_0897: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(NotificationDetailsView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/NotificationDetailsView.xaml");
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
			string notifications_TitleName = Resources.Notifications_TitleName;
			BindingExtension val2 = new BindingExtension();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			Label val4 = new Label();
			BindingExtension val5 = new BindingExtension();
			DataTemplate val6 = new DataTemplate();
			StackLayout val7 = new StackLayout();
			DynamicResourceExtension val8 = new DynamicResourceExtension();
			BindingExtension val9 = new BindingExtension();
			BoxView val10 = new BoxView();
			BindingExtension val11 = new BindingExtension();
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			Label val13 = new Label();
			BindingExtension val14 = new BindingExtension();
			DataTemplate val15 = new DataTemplate();
			StackLayout val16 = new StackLayout();
			BindingExtension val17 = new BindingExtension();
			DataTemplate val18 = new DataTemplate();
			StackLayout val19 = new StackLayout();
			StackLayout val20 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val21 = new StackLayout();
			ScrollView val22 = new ScrollView();
			StackLayout val23 = new StackLayout();
			NotificationDetailsView notificationDetailsView;
			NameScope val24 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(notificationDetailsView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)notificationDetailsView, (INameScope)(object)val24);
			((INameScope)val24).RegisterName("containingView", (object)val21);
			if (((Element)val21).get_StyleId() == null)
			{
				((Element)val21).set_StyleId("containingView");
			}
			((INameScope)val24).RegisterName("titleLabel", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("titleLabel");
			}
			((INameScope)val24).RegisterName("descriptionStack", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("descriptionStack");
			}
			((INameScope)val24).RegisterName("frameLabel", (object)shadowFrame);
			if (((Element)shadowFrame).get_StyleId() == null)
			{
				((Element)shadowFrame).set_StyleId("frameLabel");
			}
			((INameScope)val24).RegisterName("border", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("border");
			}
			((INameScope)val24).RegisterName("headingLabel", (object)val13);
			if (((Element)val13).get_StyleId() == null)
			{
				((Element)val13).set_StyleId("headingLabel");
			}
			((INameScope)val24).RegisterName("informationStack", (object)val16);
			if (((Element)val16).get_StyleId() == null)
			{
				((Element)val16).set_StyleId("informationStack");
			}
			((INameScope)val24).RegisterName("linkStack", (object)val19);
			if (((Element)val19).get_StyleId() == null)
			{
				((Element)val19).set_StyleId("linkStack");
			}
			containingView = val21;
			titleLabel = val4;
			descriptionStack = val7;
			frameLabel = shadowFrame;
			border = val10;
			headingLabel = val13;
			informationStack = val16;
			linkStack = val19;
			((BindableObject)notificationDetailsView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)notificationDetailsView).SetValue(Page.TitleProperty, (object)notifications_TitleName);
			((BindableObject)val23).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val22).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 16.0));
			((BindableObject)val22).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val21).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val21).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Path("Title");
			BindingBase val25 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(Label.TextProperty, val25);
			val3.set_Key("Heading1");
			XamlServiceProvider val26 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = val4;
			array[1] = val21;
			array[2] = val22;
			array[3] = val23;
			array[4] = notificationDetailsView;
			SimpleValueTargetProvider val27 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val24);
			object obj = (object)val27;
			val26.Add(typeFromHandle, (object)val27);
			val26.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val28 = new XmlNamespaceResolver();
			val28.Add("", "http://xamarin.com/schemas/2014/forms");
			val28.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val28.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val28.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val28.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val28.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val26.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val28, typeof(NotificationDetailsView).GetTypeInfo().Assembly));
			val26.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 21)));
			DynamicResource val29 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val26);
			((IDynamicResourceHandler)val4).SetDynamicResource(VisualElement.StyleProperty, val29.get_Key());
			((BindableObject)val4).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 4.0));
			((Layout<View>)(object)val21).get_Children().Add((View)(object)val4);
			val5.set_Path("Content");
			BindingBase val30 = ((IMarkupExtension<BindingBase>)(object)val5).ProvideValue((IServiceProvider)null);
			((BindableObject)val7).SetBinding(BindableLayout.ItemsSourceProperty, val30);
			object[] array2 = new object[0 + 6];
			array2[0] = val6;
			array2[1] = val7;
			array2[2] = val21;
			array2[3] = val22;
			array2[4] = val23;
			array2[5] = notificationDetailsView;
			object[] parentValues3 = array2;
			NotificationDetailsView root3 = notificationDetailsView;
			((IDataTemplate)val6).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				BindingExtension val56 = new BindingExtension();
				Label val57 = new Label();
				NameScope val58 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val57, (INameScope)(object)val58);
				val56.set_Path(".");
				BindingBase val59 = ((IMarkupExtension<BindingBase>)(object)val56).ProvideValue((IServiceProvider)null);
				((BindableObject)val57).SetBinding(Label.TextProperty, val59);
				((BindableObject)val57).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 4.0));
				return val57;
			});
			((BindableObject)val7).SetValue(BindableLayout.ItemTemplateProperty, (object)val6);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)val7);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 0.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val8.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val31 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 5];
			array3[0] = shadowFrame;
			array3[1] = val21;
			array3[2] = val22;
			array3[3] = val23;
			array3[4] = notificationDetailsView;
			SimpleValueTargetProvider val32 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val24);
			object obj2 = (object)val32;
			val31.Add(typeFromHandle3, (object)val32);
			val31.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val33 = new XmlNamespaceResolver();
			val33.Add("", "http://xamarin.com/schemas/2014/forms");
			val33.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val33.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val33.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val33.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val33.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val31.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val33, typeof(NotificationDetailsView).GetTypeInfo().Assembly));
			val31.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 21)));
			DynamicResource val34 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val31);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val34.get_Key());
			((BindableObject)val10).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val9.set_Path("Color");
			BindingBase val35 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)null);
			((BindableObject)val10).SetBinding(BoxView.ColorProperty, val35);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val10);
			val11.set_Path("InformationTitle");
			BindingBase val36 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)val13).SetBinding(Label.TextProperty, val36);
			val12.set_Key("Heading1");
			XamlServiceProvider val37 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 7];
			array4[0] = val13;
			array4[1] = val20;
			array4[2] = shadowFrame;
			array4[3] = val21;
			array4[4] = val22;
			array4[5] = val23;
			array4[6] = notificationDetailsView;
			SimpleValueTargetProvider val38 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val24);
			object obj3 = (object)val38;
			val37.Add(typeFromHandle5, (object)val38);
			val37.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val39 = new XmlNamespaceResolver();
			val39.Add("", "http://xamarin.com/schemas/2014/forms");
			val39.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val39.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val39.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val39.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val39.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val37.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val39, typeof(NotificationDetailsView).GetTypeInfo().Assembly));
			val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(52, 29)));
			DynamicResource val40 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val37);
			((IDynamicResourceHandler)val13).SetDynamicResource(VisualElement.StyleProperty, val40.get_Key());
			((BindableObject)val13).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 4.0));
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val13);
			val14.set_Path("InformationContent");
			BindingBase val41 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)val16).SetBinding(BindableLayout.ItemsSourceProperty, val41);
			object[] array5 = new object[0 + 8];
			array5[0] = val15;
			array5[1] = val16;
			array5[2] = val20;
			array5[3] = shadowFrame;
			array5[4] = val21;
			array5[5] = val22;
			array5[6] = val23;
			array5[7] = notificationDetailsView;
			object[] parentValues2 = array5;
			NotificationDetailsView root2 = notificationDetailsView;
			((IDataTemplate)val15).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				BindingExtension val52 = new BindingExtension();
				Label val53 = new Label();
				NameScope val54 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val53, (INameScope)(object)val54);
				val52.set_Path(".");
				BindingBase val55 = ((IMarkupExtension<BindingBase>)(object)val52).ProvideValue((IServiceProvider)null);
				((BindableObject)val53).SetBinding(Label.TextProperty, val55);
				((BindableObject)val53).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 4.0));
				return val53;
			});
			((BindableObject)val16).SetValue(BindableLayout.ItemTemplateProperty, (object)val15);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val16);
			val17.set_Path("Links");
			BindingBase val42 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)null);
			((BindableObject)val19).SetBinding(BindableLayout.ItemsSourceProperty, val42);
			object[] array6 = new object[0 + 8];
			array6[0] = val18;
			array6[1] = val19;
			array6[2] = val20;
			array6[3] = shadowFrame;
			array6[4] = val21;
			array6[5] = val22;
			array6[6] = val23;
			array6[7] = notificationDetailsView;
			object[] parentValues = array6;
			NotificationDetailsView root = notificationDetailsView;
			((IDataTemplate)val18).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected O, but got Unknown
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Expected O, but got Unknown
				BindingExtension val43 = new BindingExtension();
				BindingExtension val44 = new BindingExtension();
				BindingExtension val45 = new BindingExtension();
				BindingExtension val46 = new BindingExtension();
				ResourceLinkView resourceLinkView = new ResourceLinkView();
				NameScope val47 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)resourceLinkView, (INameScope)(object)val47);
				val43.set_Path("Label");
				BindingBase val48 = ((IMarkupExtension<BindingBase>)(object)val43).ProvideValue((IServiceProvider)null);
				((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.TextProperty, val48);
				val44.set_Path("IsUrl");
				BindingBase val49 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)null);
				((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.IsUrlProperty, val49);
				val45.set_Path("Url");
				BindingBase val50 = ((IMarkupExtension<BindingBase>)(object)val45).ProvideValue((IServiceProvider)null);
				((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.UrlProperty, val50);
				val46.set_Path("OnTapCommand");
				BindingBase val51 = ((IMarkupExtension<BindingBase>)(object)val46).ProvideValue((IServiceProvider)null);
				((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.OnTapCommandProperty, val51);
				return resourceLinkView;
			});
			((BindableObject)val19).SetValue(BindableLayout.ItemTemplateProperty, (object)val18);
			((Layout<View>)(object)val20).get_Children().Add((View)(object)val19);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val20);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)shadowFrame);
			val22.set_Content((View)(object)val21);
			((Layout<View>)(object)val23).get_Children().Add((View)(object)val22);
			((BindableObject)notificationDetailsView).SetValue(ContentPage.ContentProperty, (object)val23);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<NotificationDetailsView>(this, typeof(NotificationDetailsView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			titleLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "titleLabel");
			descriptionStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "descriptionStack");
			frameLabel = NameScopeExtensions.FindByName<ShadowFrame>((Element)(object)this, "frameLabel");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			headingLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "headingLabel");
			informationStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "informationStack");
			linkStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "linkStack");
		}
	}
}
