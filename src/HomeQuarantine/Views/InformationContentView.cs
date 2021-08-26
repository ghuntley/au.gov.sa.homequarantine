using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Selectors;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/InformationContentView.xaml")]
	public class InformationContentView : BaseView, IChildView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label titleLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout frameStack;

		public InformationContentView()
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
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
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
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Expected O, but got Unknown
			//IL_027e: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Expected O, but got Unknown
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Expected O, but got Unknown
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Expected O, but got Unknown
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected O, but got Unknown
			//IL_0351: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_03b4: Expected O, but got Unknown
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_045f: Expected O, but got Unknown
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Expected O, but got Unknown
			//IL_0464: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Expected O, but got Unknown
			//IL_047b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Expected O, but got Unknown
			//IL_048a: Expected O, but got Unknown
			//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e0: Expected O, but got Unknown
			//IL_05e5: Expected O, but got Unknown
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Unknown result type (might be due to invalid IL or missing references)
			//IL_0607: Unknown result type (might be due to invalid IL or missing references)
			//IL_0617: Unknown result type (might be due to invalid IL or missing references)
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_0637: Unknown result type (might be due to invalid IL or missing references)
			//IL_0647: Unknown result type (might be due to invalid IL or missing references)
			//IL_0657: Unknown result type (might be due to invalid IL or missing references)
			//IL_0667: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Expected O, but got Unknown
			//IL_068b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0695: Expected O, but got Unknown
			//IL_0695: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ae: Expected O, but got Unknown
			//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Expected O, but got Unknown
			//IL_06b8: Expected O, but got Unknown
			//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0747: Unknown result type (might be due to invalid IL or missing references)
			//IL_074c: Unknown result type (might be due to invalid IL or missing references)
			//IL_077f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0784: Unknown result type (might be due to invalid IL or missing references)
			//IL_0787: Expected O, but got Unknown
			//IL_078c: Expected O, but got Unknown
			//IL_078c: Unknown result type (might be due to invalid IL or missing references)
			//IL_079e: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_07be: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_07de: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_080e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Expected O, but got Unknown
			//IL_0832: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Expected O, but got Unknown
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_084b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0855: Expected O, but got Unknown
			//IL_0850: Unknown result type (might be due to invalid IL or missing references)
			//IL_085a: Expected O, but got Unknown
			//IL_085f: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(InformationContentView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/InformationContentView.xaml");
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
			NotNullOrEmptyConverter notNullOrEmptyConverter = new NotNullOrEmptyConverter();
			DataTemplate val3 = new DataTemplate();
			DataTemplate val4 = new DataTemplate();
			StaticResourceExtension val5 = new StaticResourceExtension();
			StaticResourceExtension val6 = new StaticResourceExtension();
			ContentGroupDataTemplateSelector contentGroupDataTemplateSelector = new ContentGroupDataTemplateSelector();
			ResourceDictionary val7 = new ResourceDictionary();
			BindingExtension val8 = new BindingExtension();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			Label val10 = new Label();
			BindingExtension val11 = new BindingExtension();
			StaticResourceExtension val12 = new StaticResourceExtension();
			StackLayout val13 = new StackLayout();
			StackLayout val14 = new StackLayout();
			ScrollView val15 = new ScrollView();
			StackLayout val16 = new StackLayout();
			InformationContentView informationContentView;
			NameScope val17 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(informationContentView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)informationContentView, (INameScope)(object)val17);
			((INameScope)val17).RegisterName("containingView", (object)val16);
			if (((Element)val16).get_StyleId() == null)
			{
				((Element)val16).set_StyleId("containingView");
			}
			((INameScope)val17).RegisterName("titleLabel", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("titleLabel");
			}
			((INameScope)val17).RegisterName("frameStack", (object)val13);
			if (((Element)val13).get_StyleId() == null)
			{
				((Element)val13).set_StyleId("frameStack");
			}
			containingView = val16;
			titleLabel = val10;
			frameStack = val13;
			((VisualElement)informationContentView).set_Resources(val7);
			val7.Add("NotNullOrEmpty", (object)notNullOrEmptyConverter);
			object[] array = new object[0 + 3];
			array[0] = val3;
			array[1] = val7;
			array[2] = informationContentView;
			object[] parentValues2 = array;
			InformationContentView root2 = informationContentView;
			((IDataTemplate)val3).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Expected O, but got Unknown
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Expected O, but got Unknown
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Expected O, but got Unknown
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Expected O, but got Unknown
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected O, but got Unknown
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Expected O, but got Unknown
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Expected O, but got Unknown
				//IL_0157: Expected O, but got Unknown
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_0199: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Expected O, but got Unknown
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Expected O, but got Unknown
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Unknown result type (might be due to invalid IL or missing references)
				//IL_0220: Expected O, but got Unknown
				//IL_021b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Expected O, but got Unknown
				//IL_022a: Expected O, but got Unknown
				//IL_0268: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_034a: Unknown result type (might be due to invalid IL or missing references)
				//IL_034f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0352: Expected O, but got Unknown
				//IL_0357: Expected O, but got Unknown
				//IL_0357: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Unknown result type (might be due to invalid IL or missing references)
				//IL_0374: Unknown result type (might be due to invalid IL or missing references)
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_0389: Unknown result type (might be due to invalid IL or missing references)
				//IL_0399: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Expected O, but got Unknown
				//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0407: Expected O, but got Unknown
				//IL_0407: Unknown result type (might be due to invalid IL or missing references)
				//IL_0416: Unknown result type (might be due to invalid IL or missing references)
				//IL_0420: Expected O, but got Unknown
				//IL_041b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0425: Expected O, but got Unknown
				//IL_042a: Expected O, but got Unknown
				//IL_0475: Unknown result type (might be due to invalid IL or missing references)
				//IL_047a: Unknown result type (might be due to invalid IL or missing references)
				//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c5: Expected O, but got Unknown
				//IL_04ca: Expected O, but got Unknown
				//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_050c: Unknown result type (might be due to invalid IL or missing references)
				//IL_051c: Unknown result type (might be due to invalid IL or missing references)
				//IL_052c: Unknown result type (might be due to invalid IL or missing references)
				//IL_053c: Unknown result type (might be due to invalid IL or missing references)
				//IL_054c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0575: Expected O, but got Unknown
				//IL_0570: Unknown result type (might be due to invalid IL or missing references)
				//IL_057a: Expected O, but got Unknown
				//IL_057a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0589: Unknown result type (might be due to invalid IL or missing references)
				//IL_0593: Expected O, but got Unknown
				//IL_058e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0598: Expected O, but got Unknown
				//IL_059d: Expected O, but got Unknown
				//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0600: Unknown result type (might be due to invalid IL or missing references)
				BindingExtension val86 = new BindingExtension();
				DynamicResourceExtension val87 = new DynamicResourceExtension();
				Label val88 = new Label();
				BindingExtension val89 = new BindingExtension();
				StaticResourceExtension val90 = new StaticResourceExtension();
				BindingExtension val91 = new BindingExtension();
				Label val92 = new Label();
				DynamicResourceExtension val93 = new DynamicResourceExtension();
				BoxView val94 = new BoxView();
				BindingExtension val95 = new BindingExtension();
				DataTemplate val96 = new DataTemplate();
				StackLayout val97 = new StackLayout();
				StackLayout val98 = new StackLayout();
				NameScope val99 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val98, (INameScope)(object)val99);
				((BindableObject)val98).SetValue(Layout.PaddingProperty, (object)new Thickness(8.0, 0.0, 8.0, 48.0));
				((BindableObject)val98).SetValue(StackLayout.SpacingProperty, (object)0.0);
				val86.set_Path("Title");
				BindingBase val100 = ((IMarkupExtension<BindingBase>)(object)val86).ProvideValue((IServiceProvider)null);
				((BindableObject)val88).SetBinding(Label.TextProperty, val100);
				((BindableObject)val88).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
				val87.set_Key("Heading2");
				XamlServiceProvider val101 = new XamlServiceProvider();
				Type typeFromHandle17 = typeof(IProvideValueTarget);
				int length6;
				object[] array12 = new object[(length6 = parentValues2.Length) + 2];
				Array.Copy(parentValues2, 0, array12, 2, length6);
				array12[0] = val88;
				array12[1] = val98;
				SimpleValueTargetProvider val102 = new SimpleValueTargetProvider(array12, (object)VisualElement.StyleProperty, (INameScope)(object)val99);
				object obj12 = (object)val102;
				val101.Add(typeFromHandle17, (object)val102);
				val101.Add(typeof(IReferenceProvider), obj12);
				Type typeFromHandle18 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val103 = new XmlNamespaceResolver();
				val103.Add("", "http://xamarin.com/schemas/2014/forms");
				val103.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val103.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val103.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val103.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val103.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val103.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val101.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val103, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
				val101.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 25)));
				DynamicResource val104 = ((IMarkupExtension<DynamicResource>)(object)val87).ProvideValue((IServiceProvider)val101);
				((IDynamicResourceHandler)val88).SetDynamicResource(VisualElement.StyleProperty, val104.get_Key());
				((BindableObject)val88).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
				((Layout<View>)(object)val98).get_Children().Add((View)(object)val88);
				val89.set_Path("Subtitle");
				BindingBase val105 = ((IMarkupExtension<BindingBase>)(object)val89).ProvideValue((IServiceProvider)null);
				((BindableObject)val92).SetBinding(Label.TextProperty, val105);
				((BindableObject)val92).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
				val90.set_Key("NotNullOrEmpty");
				XamlServiceProvider val106 = new XamlServiceProvider();
				Type typeFromHandle19 = typeof(IProvideValueTarget);
				int length7;
				object[] array13 = new object[(length7 = parentValues2.Length) + 3];
				Array.Copy(parentValues2, 0, array13, 3, length7);
				array13[0] = val91;
				array13[1] = val92;
				array13[2] = val98;
				SimpleValueTargetProvider val107 = new SimpleValueTargetProvider(array13, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val99);
				object obj13 = (object)val107;
				val106.Add(typeFromHandle19, (object)val107);
				val106.Add(typeof(IReferenceProvider), obj13);
				Type typeFromHandle20 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val108 = new XmlNamespaceResolver();
				val108.Add("", "http://xamarin.com/schemas/2014/forms");
				val108.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val108.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val108.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val108.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val108.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val108.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val106.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val108, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
				val106.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 25)));
				object converter3 = ((IMarkupExtension)val90).ProvideValue((IServiceProvider)val106);
				val91.set_Converter((IValueConverter)converter3);
				val91.set_Path("Subtitle");
				BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val91).ProvideValue((IServiceProvider)null);
				((BindableObject)val92).SetBinding(VisualElement.IsVisibleProperty, val109);
				((Layout<View>)(object)val98).get_Children().Add((View)(object)val92);
				val93.set_Key("TertiaryTextColor");
				XamlServiceProvider val110 = new XamlServiceProvider();
				Type typeFromHandle21 = typeof(IProvideValueTarget);
				int length8;
				object[] array14 = new object[(length8 = parentValues2.Length) + 2];
				Array.Copy(parentValues2, 0, array14, 2, length8);
				array14[0] = val94;
				array14[1] = val98;
				SimpleValueTargetProvider val111 = new SimpleValueTargetProvider(array14, (object)BoxView.ColorProperty, (INameScope)(object)val99);
				object obj14 = (object)val111;
				val110.Add(typeFromHandle21, (object)val111);
				val110.Add(typeof(IReferenceProvider), obj14);
				Type typeFromHandle22 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val112 = new XmlNamespaceResolver();
				val112.Add("", "http://xamarin.com/schemas/2014/forms");
				val112.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val112.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val112.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val112.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val112.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val112.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val110.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val112, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
				val110.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(27, 25)));
				DynamicResource val113 = ((IMarkupExtension<DynamicResource>)(object)val93).ProvideValue((IServiceProvider)val110);
				((IDynamicResourceHandler)val94).SetDynamicResource(BoxView.ColorProperty, val113.get_Key());
				((BindableObject)val94).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("true"));
				((BindableObject)val94).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
				((BindableObject)val94).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
				((Layout<View>)(object)val98).get_Children().Add((View)(object)val94);
				val95.set_Path("Accordions");
				BindingBase val114 = ((IMarkupExtension<BindingBase>)(object)val95).ProvideValue((IServiceProvider)null);
				((BindableObject)val97).SetBinding(BindableLayout.ItemsSourceProperty, val114);
				int length9;
				object[] array15 = new object[(length9 = parentValues2.Length) + 3];
				Array.Copy(parentValues2, 0, array15, 3, length9);
				array15[0] = val96;
				array15[1] = val97;
				array15[2] = val98;
				object[] parentValues4 = array15;
				InformationContentView root4 = root2;
				((IDataTemplate)val96).set_LoadTemplate((Func<object>)delegate
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0007: Expected O, but got Unknown
					//IL_0007: Unknown result type (might be due to invalid IL or missing references)
					//IL_000d: Expected O, but got Unknown
					//IL_000d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0013: Expected O, but got Unknown
					//IL_0013: Unknown result type (might be due to invalid IL or missing references)
					//IL_0019: Expected O, but got Unknown
					//IL_0019: Unknown result type (might be due to invalid IL or missing references)
					//IL_0020: Expected O, but got Unknown
					//IL_0020: Unknown result type (might be due to invalid IL or missing references)
					//IL_0027: Expected O, but got Unknown
					//IL_0027: Unknown result type (might be due to invalid IL or missing references)
					//IL_002e: Expected O, but got Unknown
					//IL_0035: Unknown result type (might be due to invalid IL or missing references)
					//IL_003c: Expected O, but got Unknown
					//IL_003c: Unknown result type (might be due to invalid IL or missing references)
					//IL_0043: Expected O, but got Unknown
					BindingExtension val115 = new BindingExtension();
					BindingExtension val116 = new BindingExtension();
					BindingExtension val117 = new BindingExtension();
					BindingExtension val118 = new BindingExtension();
					BindingExtension val119 = new BindingExtension();
					BindingExtension val120 = new BindingExtension();
					BindingExtension val121 = new BindingExtension();
					AccordionView accordionView = new AccordionView();
					StackLayout val122 = new StackLayout();
					NameScope val123 = new NameScope();
					NameScope.SetNameScope((BindableObject)(object)val122, (INameScope)(object)val123);
					val115.set_Path("Heading");
					BindingBase val124 = ((IMarkupExtension<BindingBase>)(object)val115).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.HeadingProperty, val124);
					val116.set_Path("Content");
					BindingBase val125 = ((IMarkupExtension<BindingBase>)(object)val116).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.ContentProperty, val125);
					val117.set_Path("Reasons");
					BindingBase val126 = ((IMarkupExtension<BindingBase>)(object)val117).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.ReasonsProperty, val126);
					val118.set_Path("LinkGroup");
					BindingBase val127 = ((IMarkupExtension<BindingBase>)(object)val118).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.InformationResourceLinkButtonProperty, val127);
					val119.set_Path("CallButton");
					BindingBase val128 = ((IMarkupExtension<BindingBase>)(object)val119).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.CallButtonProperty, val128);
					val120.set_Path("TextMessageButton");
					BindingBase val129 = ((IMarkupExtension<BindingBase>)(object)val120).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.TextMessageButtonProperty, val129);
					val121.set_Path("OtherContent");
					BindingBase val130 = ((IMarkupExtension<BindingBase>)(object)val121).ProvideValue((IServiceProvider)null);
					((BindableObject)accordionView).SetBinding(AccordionView.OtherContentProperty, val130);
					((Layout<View>)(object)val122).get_Children().Add((View)(object)accordionView);
					return val122;
				});
				((BindableObject)val97).SetValue(BindableLayout.ItemTemplateProperty, (object)val96);
				((Layout<View>)(object)val98).get_Children().Add((View)(object)val97);
				return val98;
			});
			val7.Add("accordionGroupTemplate", (object)val3);
			object[] array2 = new object[0 + 3];
			array2[0] = val4;
			array2[1] = val7;
			array2[2] = informationContentView;
			object[] parentValues = array2;
			InformationContentView root = informationContentView;
			((IDataTemplate)val4).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Expected O, but got Unknown
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Expected O, but got Unknown
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Expected O, but got Unknown
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Expected O, but got Unknown
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected O, but got Unknown
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Expected O, but got Unknown
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Expected O, but got Unknown
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected O, but got Unknown
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Expected O, but got Unknown
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected O, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected O, but got Unknown
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Expected O, but got Unknown
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0164: Expected O, but got Unknown
				//IL_0169: Expected O, but got Unknown
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_019b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01db: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0214: Expected O, but got Unknown
				//IL_020f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0219: Expected O, but got Unknown
				//IL_0219: Unknown result type (might be due to invalid IL or missing references)
				//IL_0228: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Expected O, but got Unknown
				//IL_022d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Expected O, but got Unknown
				//IL_023c: Expected O, but got Unknown
				//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0314: Unknown result type (might be due to invalid IL or missing references)
				//IL_0336: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0383: Unknown result type (might be due to invalid IL or missing references)
				//IL_0388: Unknown result type (might be due to invalid IL or missing references)
				//IL_038b: Expected O, but got Unknown
				//IL_0390: Expected O, but got Unknown
				//IL_0390: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Unknown result type (might be due to invalid IL or missing references)
				//IL_0412: Unknown result type (might be due to invalid IL or missing references)
				//IL_043b: Expected O, but got Unknown
				//IL_0436: Unknown result type (might be due to invalid IL or missing references)
				//IL_0440: Expected O, but got Unknown
				//IL_0440: Unknown result type (might be due to invalid IL or missing references)
				//IL_044f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0459: Expected O, but got Unknown
				//IL_0454: Unknown result type (might be due to invalid IL or missing references)
				//IL_045e: Expected O, but got Unknown
				//IL_0463: Expected O, but got Unknown
				//IL_0491: Unknown result type (might be due to invalid IL or missing references)
				//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0508: Unknown result type (might be due to invalid IL or missing references)
				//IL_050d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0569: Unknown result type (might be due to invalid IL or missing references)
				//IL_056e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0571: Expected O, but got Unknown
				//IL_0576: Expected O, but got Unknown
				//IL_0576: Unknown result type (might be due to invalid IL or missing references)
				//IL_0588: Unknown result type (might be due to invalid IL or missing references)
				//IL_0593: Unknown result type (might be due to invalid IL or missing references)
				//IL_0598: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0621: Expected O, but got Unknown
				//IL_061c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0626: Expected O, but got Unknown
				//IL_0626: Unknown result type (might be due to invalid IL or missing references)
				//IL_0635: Unknown result type (might be due to invalid IL or missing references)
				//IL_063f: Expected O, but got Unknown
				//IL_063a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0644: Expected O, but got Unknown
				//IL_0649: Expected O, but got Unknown
				//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0741: Unknown result type (might be due to invalid IL or missing references)
				//IL_0746: Unknown result type (might be due to invalid IL or missing references)
				//IL_0749: Expected O, but got Unknown
				//IL_074e: Expected O, but got Unknown
				//IL_074e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0760: Unknown result type (might be due to invalid IL or missing references)
				//IL_076b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0770: Unknown result type (might be due to invalid IL or missing references)
				//IL_0780: Unknown result type (might be due to invalid IL or missing references)
				//IL_0790: Unknown result type (might be due to invalid IL or missing references)
				//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_07f9: Expected O, but got Unknown
				//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_07fe: Expected O, but got Unknown
				//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_080d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0817: Expected O, but got Unknown
				//IL_0812: Unknown result type (might be due to invalid IL or missing references)
				//IL_081c: Expected O, but got Unknown
				//IL_0821: Expected O, but got Unknown
				DynamicResourceExtension val36 = new DynamicResourceExtension();
				BindingExtension val37 = new BindingExtension();
				BoxView val38 = new BoxView();
				BindingExtension val39 = new BindingExtension();
				DynamicResourceExtension val40 = new DynamicResourceExtension();
				Label val41 = new Label();
				BindingExtension val42 = new BindingExtension();
				StaticResourceExtension val43 = new StaticResourceExtension();
				BindingExtension val44 = new BindingExtension();
				Label val45 = new Label();
				BindingExtension val46 = new BindingExtension();
				StaticResourceExtension val47 = new StaticResourceExtension();
				BindingExtension val48 = new BindingExtension();
				Label val49 = new Label();
				BindingExtension val50 = new BindingExtension();
				BindingExtension val51 = new BindingExtension();
				DataTemplate val52 = new DataTemplate();
				StackLayout val53 = new StackLayout();
				StackLayout val54 = new StackLayout();
				ShadowFrame shadowFrame = new ShadowFrame();
				NameScope val55 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)shadowFrame, (INameScope)(object)val55);
				((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 48.0));
				((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
				val36.set_Key("ElevatedBackgroundColor");
				XamlServiceProvider val56 = new XamlServiceProvider();
				Type typeFromHandle9 = typeof(IProvideValueTarget);
				int length;
				object[] array7 = new object[(length = parentValues.Length) + 1];
				Array.Copy(parentValues, 0, array7, 1, length);
				array7[0] = shadowFrame;
				SimpleValueTargetProvider val57 = new SimpleValueTargetProvider(array7, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val55);
				object obj8 = (object)val57;
				val56.Add(typeFromHandle9, (object)val57);
				val56.Add(typeof(IReferenceProvider), obj8);
				Type typeFromHandle10 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val58 = new XmlNamespaceResolver();
				val58.Add("", "http://xamarin.com/schemas/2014/forms");
				val58.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val58.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val58.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val58.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val58.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val58.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val56.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val58, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_4).GetTypeInfo().Assembly));
				val56.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 21)));
				DynamicResource val59 = ((IMarkupExtension<DynamicResource>)(object)val36).ProvideValue((IServiceProvider)val56);
				((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val59.get_Key());
				((BindableObject)val54).SetValue(StackLayout.SpacingProperty, (object)16.0);
				((BindableObject)val38).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
				val37.set_Path("BoxColor");
				BindingBase val60 = ((IMarkupExtension<BindingBase>)(object)val37).ProvideValue((IServiceProvider)null);
				((BindableObject)val38).SetBinding(BoxView.ColorProperty, val60);
				((BindableObject)val38).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
				((Layout<View>)(object)val54).get_Children().Add((View)(object)val38);
				val39.set_Path("Title");
				BindingBase val61 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)null);
				((BindableObject)val41).SetBinding(Label.TextProperty, val61);
				((BindableObject)val41).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
				val40.set_Key("Heading2");
				XamlServiceProvider val62 = new XamlServiceProvider();
				Type typeFromHandle11 = typeof(IProvideValueTarget);
				int length2;
				object[] array8 = new object[(length2 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array8, 3, length2);
				array8[0] = val41;
				array8[1] = val54;
				array8[2] = shadowFrame;
				SimpleValueTargetProvider val63 = new SimpleValueTargetProvider(array8, (object)VisualElement.StyleProperty, (INameScope)(object)val55);
				object obj9 = (object)val63;
				val62.Add(typeFromHandle11, (object)val63);
				val62.Add(typeof(IReferenceProvider), obj9);
				Type typeFromHandle12 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val64 = new XmlNamespaceResolver();
				val64.Add("", "http://xamarin.com/schemas/2014/forms");
				val64.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val64.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val64.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val64.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val64.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val64.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val62.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val64, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_4).GetTypeInfo().Assembly));
				val62.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(67, 29)));
				DynamicResource val65 = ((IMarkupExtension<DynamicResource>)(object)val40).ProvideValue((IServiceProvider)val62);
				((IDynamicResourceHandler)val41).SetDynamicResource(VisualElement.StyleProperty, val65.get_Key());
				((BindableObject)val41).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
				((Layout<View>)(object)val54).get_Children().Add((View)(object)val41);
				val42.set_Path("Subtitle");
				BindingBase val66 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)null);
				((BindableObject)val45).SetBinding(Label.TextProperty, val66);
				((BindableObject)val45).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
				val43.set_Key("NotNullOrEmpty");
				XamlServiceProvider val67 = new XamlServiceProvider();
				Type typeFromHandle13 = typeof(IProvideValueTarget);
				int length3;
				object[] array9 = new object[(length3 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array9, 4, length3);
				array9[0] = val44;
				array9[1] = val45;
				array9[2] = val54;
				array9[3] = shadowFrame;
				SimpleValueTargetProvider val68 = new SimpleValueTargetProvider(array9, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val55);
				object obj10 = (object)val68;
				val67.Add(typeFromHandle13, (object)val68);
				val67.Add(typeof(IReferenceProvider), obj10);
				Type typeFromHandle14 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val69 = new XmlNamespaceResolver();
				val69.Add("", "http://xamarin.com/schemas/2014/forms");
				val69.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val69.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val69.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val69.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val69.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val69.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val67.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val69, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_4).GetTypeInfo().Assembly));
				val67.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 29)));
				object converter = ((IMarkupExtension)val43).ProvideValue((IServiceProvider)val67);
				val44.set_Converter((IValueConverter)converter);
				val44.set_Path("Subtitle");
				BindingBase val70 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)null);
				((BindableObject)val45).SetBinding(VisualElement.IsVisibleProperty, val70);
				((Layout<View>)(object)val54).get_Children().Add((View)(object)val45);
				val46.set_Path("Description");
				BindingBase val71 = ((IMarkupExtension<BindingBase>)(object)val46).ProvideValue((IServiceProvider)null);
				((BindableObject)val49).SetBinding(Label.TextProperty, val71);
				((BindableObject)val49).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
				val47.set_Key("NotNullOrEmpty");
				XamlServiceProvider val72 = new XamlServiceProvider();
				Type typeFromHandle15 = typeof(IProvideValueTarget);
				int length4;
				object[] array10 = new object[(length4 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array10, 4, length4);
				array10[0] = val48;
				array10[1] = val49;
				array10[2] = val54;
				array10[3] = shadowFrame;
				SimpleValueTargetProvider val73 = new SimpleValueTargetProvider(array10, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val55);
				object obj11 = (object)val73;
				val72.Add(typeFromHandle15, (object)val73);
				val72.Add(typeof(IReferenceProvider), obj11);
				Type typeFromHandle16 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val74 = new XmlNamespaceResolver();
				val74.Add("", "http://xamarin.com/schemas/2014/forms");
				val74.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val74.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val74.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val74.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val74.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
				val74.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val72.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val74, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_4).GetTypeInfo().Assembly));
				val72.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(76, 29)));
				object converter2 = ((IMarkupExtension)val47).ProvideValue((IServiceProvider)val72);
				val48.set_Converter((IValueConverter)converter2);
				val48.set_Path("Description");
				BindingBase val75 = ((IMarkupExtension<BindingBase>)(object)val48).ProvideValue((IServiceProvider)null);
				((BindableObject)val49).SetBinding(VisualElement.IsVisibleProperty, val75);
				((Layout<View>)(object)val54).get_Children().Add((View)(object)val49);
				val50.set_Path("IsVisibleResourceLink");
				BindingBase val76 = ((IMarkupExtension<BindingBase>)(object)val50).ProvideValue((IServiceProvider)null);
				((BindableObject)val53).SetBinding(VisualElement.IsVisibleProperty, val76);
				val51.set_Path("Links");
				BindingBase val77 = ((IMarkupExtension<BindingBase>)(object)val51).ProvideValue((IServiceProvider)null);
				((BindableObject)val53).SetBinding(BindableLayout.ItemsSourceProperty, val77);
				((BindableObject)val53).SetValue(StackLayout.SpacingProperty, (object)0.0);
				int length5;
				object[] array11 = new object[(length5 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array11, 4, length5);
				array11[0] = val52;
				array11[1] = val53;
				array11[2] = val54;
				array11[3] = shadowFrame;
				object[] parentValues3 = array11;
				InformationContentView root3 = root;
				((IDataTemplate)val52).set_LoadTemplate((Func<object>)delegate
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0007: Expected O, but got Unknown
					//IL_0007: Unknown result type (might be due to invalid IL or missing references)
					//IL_000d: Expected O, but got Unknown
					//IL_000d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0013: Expected O, but got Unknown
					//IL_0019: Unknown result type (might be due to invalid IL or missing references)
					//IL_0020: Expected O, but got Unknown
					//IL_0020: Unknown result type (might be due to invalid IL or missing references)
					//IL_0027: Expected O, but got Unknown
					BindingExtension val78 = new BindingExtension();
					BindingExtension val79 = new BindingExtension();
					BindingExtension val80 = new BindingExtension();
					ResourceLinkView resourceLinkView = new ResourceLinkView();
					StackLayout val81 = new StackLayout();
					NameScope val82 = new NameScope();
					NameScope.SetNameScope((BindableObject)(object)val81, (INameScope)(object)val82);
					val78.set_Path("Label");
					BindingBase val83 = ((IMarkupExtension<BindingBase>)(object)val78).ProvideValue((IServiceProvider)null);
					((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.TextProperty, val83);
					val79.set_Path("IsUrl");
					BindingBase val84 = ((IMarkupExtension<BindingBase>)(object)val79).ProvideValue((IServiceProvider)null);
					((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.IsUrlProperty, val84);
					val80.set_Path("Url");
					BindingBase val85 = ((IMarkupExtension<BindingBase>)(object)val80).ProvideValue((IServiceProvider)null);
					((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.UrlProperty, val85);
					((Layout<View>)(object)val81).get_Children().Add((View)(object)resourceLinkView);
					return val81;
				});
				((BindableObject)val53).SetValue(BindableLayout.ItemTemplateProperty, (object)val52);
				((Layout<View>)(object)val54).get_Children().Add((View)(object)val53);
				((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val54);
				return shadowFrame;
			});
			val7.Add("resourceLinkGroupTemplate", (object)val4);
			val5.set_Key("accordionGroupTemplate");
			XamlServiceProvider val18 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = contentGroupDataTemplateSelector;
			array3[1] = val7;
			array3[2] = informationContentView;
			SimpleValueTargetProvider val19 = new SimpleValueTargetProvider(array3, (object)typeof(ContentGroupDataTemplateSelector).GetRuntimeProperty("AccordionTemplate"), (INameScope)(object)val17);
			object obj = (object)val19;
			val18.Add(typeFromHandle, (object)val19);
			val18.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val20 = new XmlNamespaceResolver();
			val20.Add("", "http://xamarin.com/schemas/2014/forms");
			val20.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val20.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val20.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val20.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val20.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
			val20.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val18.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val20, typeof(InformationContentView).GetTypeInfo().Assembly));
			val18.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 86)));
			object obj2 = (contentGroupDataTemplateSelector.AccordionTemplate = (DataTemplate)((IMarkupExtension)val5).ProvideValue((IServiceProvider)val18));
			val6.set_Key("resourceLinkGroupTemplate");
			XamlServiceProvider val22 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = contentGroupDataTemplateSelector;
			array4[1] = val7;
			array4[2] = informationContentView;
			SimpleValueTargetProvider val23 = new SimpleValueTargetProvider(array4, (object)typeof(ContentGroupDataTemplateSelector).GetRuntimeProperty("ResourceLinkTemplate"), (INameScope)(object)val17);
			object obj3 = (object)val23;
			val22.Add(typeFromHandle3, (object)val23);
			val22.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val24 = new XmlNamespaceResolver();
			val24.Add("", "http://xamarin.com/schemas/2014/forms");
			val24.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val24.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val24.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val24.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val24.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
			val24.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val22.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val24, typeof(InformationContentView).GetTypeInfo().Assembly));
			val22.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 146)));
			object obj4 = (contentGroupDataTemplateSelector.ResourceLinkTemplate = (DataTemplate)((IMarkupExtension)val6).ProvideValue((IServiceProvider)val22));
			val7.Add("contentGroupSelector", (object)contentGroupDataTemplateSelector);
			((BindableObject)informationContentView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Path("Title");
			BindingBase val26 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)informationContentView).SetBinding(Page.TitleProperty, val26);
			((VisualElement)informationContentView).set_Resources(val7);
			((BindableObject)val15).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 16.0));
			((BindableObject)val14).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val14).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 24.0));
			val8.set_Path("SubHeading");
			BindingBase val27 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)val10).SetBinding(Label.TextProperty, val27);
			val9.set_Key("Heading1");
			XamlServiceProvider val28 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 5];
			array5[0] = val10;
			array5[1] = val14;
			array5[2] = val15;
			array5[3] = val16;
			array5[4] = informationContentView;
			SimpleValueTargetProvider val29 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val17);
			object obj5 = (object)val29;
			val28.Add(typeFromHandle5, (object)val29);
			val28.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val30 = new XmlNamespaceResolver();
			val30.Add("", "http://xamarin.com/schemas/2014/forms");
			val30.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val30.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val30.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val30.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val30.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
			val30.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val28.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val30, typeof(InformationContentView).GetTypeInfo().Assembly));
			val28.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(114, 21)));
			DynamicResource val31 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val28);
			((IDynamicResourceHandler)val10).SetDynamicResource(VisualElement.StyleProperty, val31.get_Key());
			((BindableObject)val10).SetValue(View.MarginProperty, (object)new Thickness(24.0, 16.0, 16.0, 24.0));
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val10);
			val11.set_Path("ContentGroups");
			BindingBase val32 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)val13).SetBinding(BindableLayout.ItemsSourceProperty, val32);
			val12.set_Key("contentGroupSelector");
			XamlServiceProvider val33 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 5];
			array6[0] = val13;
			array6[1] = val14;
			array6[2] = val15;
			array6[3] = val16;
			array6[4] = informationContentView;
			SimpleValueTargetProvider val34 = new SimpleValueTargetProvider(array6, (object)BindableLayout.ItemTemplateSelectorProperty, (INameScope)(object)val17);
			object obj6 = (object)val34;
			val33.Add(typeFromHandle7, (object)val34);
			val33.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val35 = new XmlNamespaceResolver();
			val35.Add("", "http://xamarin.com/schemas/2014/forms");
			val35.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val35.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val35.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val35.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val35.Add("selectors", "clr-namespace:HomeQuarantine.Selectors");
			val35.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val33.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val35, typeof(InformationContentView).GetTypeInfo().Assembly));
			val33.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(121, 21)));
			object obj7 = ((IMarkupExtension)val12).ProvideValue((IServiceProvider)val33);
			((BindableObject)val13).SetValue(BindableLayout.ItemTemplateSelectorProperty, obj7);
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val13);
			val15.set_Content((View)(object)val14);
			((Layout<View>)(object)val16).get_Children().Add((View)(object)val15);
			((BindableObject)informationContentView).SetValue(ContentPage.ContentProperty, (object)val16);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<InformationContentView>(this, typeof(InformationContentView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			titleLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "titleLabel");
			frameStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "frameStack");
		}
	}
}
