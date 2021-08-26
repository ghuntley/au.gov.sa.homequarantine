using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using HomeQuarantine.Converters;
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
	[XamlFilePath("Views/ErrorView.xaml")]
	public class ErrorView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label titleLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label subTitleLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout reasonsLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label suggestionLabel;

		public bool ShowDismiss => true;

		public ErrorView()
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
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
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
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Expected O, but got Unknown
			//IL_02a0: Expected O, but got Unknown
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected O, but got Unknown
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected O, but got Unknown
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected O, but got Unknown
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected O, but got Unknown
			//IL_0362: Expected O, but got Unknown
			//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Expected O, but got Unknown
			//IL_0465: Expected O, but got Unknown
			//IL_0465: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Expected O, but got Unknown
			//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Expected O, but got Unknown
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Expected O, but got Unknown
			//IL_0519: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Expected O, but got Unknown
			//IL_0528: Expected O, but got Unknown
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Unknown result type (might be due to invalid IL or missing references)
			//IL_073b: Expected O, but got Unknown
			//IL_0740: Expected O, but got Unknown
			//IL_0740: Unknown result type (might be due to invalid IL or missing references)
			//IL_0752: Unknown result type (might be due to invalid IL or missing references)
			//IL_075d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_0772: Unknown result type (might be due to invalid IL or missing references)
			//IL_0782: Unknown result type (might be due to invalid IL or missing references)
			//IL_0792: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07db: Expected O, but got Unknown
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e0: Expected O, but got Unknown
			//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f9: Expected O, but got Unknown
			//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fe: Expected O, but got Unknown
			//IL_0803: Expected O, but got Unknown
			//IL_085d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0888: Unknown result type (might be due to invalid IL or missing references)
			//IL_088d: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c8: Expected O, but got Unknown
			//IL_08cd: Expected O, but got Unknown
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_090f: Unknown result type (might be due to invalid IL or missing references)
			//IL_091f: Unknown result type (might be due to invalid IL or missing references)
			//IL_092f: Unknown result type (might be due to invalid IL or missing references)
			//IL_093f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0968: Expected O, but got Unknown
			//IL_0963: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Expected O, but got Unknown
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_097c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0986: Expected O, but got Unknown
			//IL_0981: Unknown result type (might be due to invalid IL or missing references)
			//IL_098b: Expected O, but got Unknown
			//IL_0990: Expected O, but got Unknown
			//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f3: Expected O, but got Unknown
			//IL_09f8: Expected O, but got Unknown
			//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a93: Expected O, but got Unknown
			//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a98: Expected O, but got Unknown
			//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab1: Expected O, but got Unknown
			//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab6: Expected O, but got Unknown
			//IL_0abb: Expected O, but got Unknown
			//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2a: Expected O, but got Unknown
			//IL_0c2f: Expected O, but got Unknown
			//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cca: Expected O, but got Unknown
			//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ccf: Expected O, but got Unknown
			//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce8: Expected O, but got Unknown
			//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ced: Expected O, but got Unknown
			//IL_0cf2: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ErrorView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/ErrorView.xaml");
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
			NotNullOrEmptyConverter notNullOrEmptyConverter = new NotNullOrEmptyConverter();
			BindingExtension val3 = new BindingExtension();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			Label val5 = new Label();
			BindingExtension val6 = new BindingExtension();
			Label val7 = new Label();
			BindingExtension val8 = new BindingExtension();
			DataTemplate val9 = new DataTemplate();
			StackLayout val10 = new StackLayout();
			BindingExtension val11 = new BindingExtension();
			StaticResourceExtension val12 = new StaticResourceExtension();
			BindingExtension val13 = new BindingExtension();
			Label val14 = new Label();
			DynamicResourceExtension val15 = new DynamicResourceExtension();
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			string errorHandling_TryAgain = Resources.ErrorHandling_TryAgain;
			BindingExtension val17 = new BindingExtension();
			BindingExtension val18 = new BindingExtension();
			Button val19 = new Button();
			string errorhandling_ContactPerson = Resources.Errorhandling_ContactPerson;
			Span val20 = new Span();
			string errorhandling_ContactNumber = Resources.Errorhandling_ContactNumber;
			DynamicResourceExtension val21 = new DynamicResourceExtension();
			Span val22 = new Span();
			string errorhandling_ContactTime = Resources.Errorhandling_ContactTime;
			Span val23 = new Span();
			FormattedString val24 = new FormattedString();
			BindingExtension val25 = new BindingExtension();
			TapGestureRecognizer val26 = new TapGestureRecognizer();
			Label val27 = new Label();
			StackLayout val28 = new StackLayout();
			ScrollView val29 = new ScrollView();
			StackLayout val30 = new StackLayout();
			ErrorView errorView;
			NameScope val31 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(errorView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)errorView, (INameScope)(object)val31);
			((INameScope)val31).RegisterName("containingView", (object)val28);
			if (((Element)val28).get_StyleId() == null)
			{
				((Element)val28).set_StyleId("containingView");
			}
			((INameScope)val31).RegisterName("titleLabel", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("titleLabel");
			}
			((INameScope)val31).RegisterName("subTitleLabel", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("subTitleLabel");
			}
			((INameScope)val31).RegisterName("reasonsLabel", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("reasonsLabel");
			}
			((INameScope)val31).RegisterName("suggestionLabel", (object)val14);
			if (((Element)val14).get_StyleId() == null)
			{
				((Element)val14).set_StyleId("suggestionLabel");
			}
			containingView = val28;
			titleLabel = val5;
			subTitleLabel = val7;
			reasonsLabel = val10;
			suggestionLabel = val14;
			((BindableObject)errorView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Key("BackgroundColor");
			XamlServiceProvider val32 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = errorView;
			SimpleValueTargetProvider val33 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val31);
			object obj = (object)val33;
			val32.Add(typeFromHandle, (object)val33);
			val32.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val34 = new XmlNamespaceResolver();
			val34.Add("", "http://xamarin.com/schemas/2014/forms");
			val34.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val34.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val34.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val34.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val34.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val32.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val34, typeof(ErrorView).GetTypeInfo().Assembly));
			val32.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 5)));
			DynamicResource val35 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val32);
			((IDynamicResourceHandler)errorView).SetDynamicResource(VisualElement.BackgroundColorProperty, val35.get_Key());
			((BindableObject)errorView).SetValue(Page.TitleProperty, (object)"Help");
			((VisualElement)errorView).get_Resources().Add("NotNullOrEmptyConverter", (object)notNullOrEmptyConverter);
			((BindableObject)val30).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val29).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val28).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val28).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val3.set_Path("Title");
			BindingBase val36 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val5).SetBinding(Label.TextProperty, val36);
			val4.set_Key("Heading1");
			XamlServiceProvider val37 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 5];
			array2[0] = val5;
			array2[1] = val28;
			array2[2] = val29;
			array2[3] = val30;
			array2[4] = errorView;
			SimpleValueTargetProvider val38 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val31);
			object obj2 = (object)val38;
			val37.Add(typeFromHandle3, (object)val38);
			val37.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val39 = new XmlNamespaceResolver();
			val39.Add("", "http://xamarin.com/schemas/2014/forms");
			val39.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val39.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val39.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val39.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val39.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val37.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val39, typeof(ErrorView).GetTypeInfo().Assembly));
			val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 21)));
			DynamicResource val40 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val37);
			((IDynamicResourceHandler)val5).SetDynamicResource(VisualElement.StyleProperty, val40.get_Key());
			((BindableObject)val5).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 16.0));
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val5);
			val6.set_Path("SubTitle");
			BindingBase val41 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)null);
			((BindableObject)val7).SetBinding(Label.TextProperty, val41);
			((BindableObject)val7).SetValue(View.MarginProperty, (object)new Thickness(16.0, 8.0, 16.0, 4.0));
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val7);
			val8.set_Path("Reasons");
			BindingBase val42 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)val10).SetBinding(BindableLayout.ItemsSourceProperty, val42);
			((BindableObject)val10).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val10).SetValue(StackLayout.SpacingProperty, (object)16.0);
			object[] array3 = new object[0 + 6];
			array3[0] = val9;
			array3[1] = val10;
			array3[2] = val28;
			array3[3] = val29;
			array3[4] = val30;
			array3[5] = errorView;
			object[] parentValues = array3;
			ErrorView root = errorView;
			((IDataTemplate)val9).set_LoadTemplate((Func<object>)delegate
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
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Expected O, but got Unknown
				//IL_00bc: Expected O, but got Unknown
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Expected O, but got Unknown
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected O, but got Unknown
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0175: Expected O, but got Unknown
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected O, but got Unknown
				//IL_017f: Expected O, but got Unknown
				//IL_0199: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Unknown result type (might be due to invalid IL or missing references)
				//IL_021e: Unknown result type (might be due to invalid IL or missing references)
				DynamicResourceExtension val63 = new DynamicResourceExtension();
				BoxView val64 = new BoxView();
				BindingExtension val65 = new BindingExtension();
				Label val66 = new Label();
				StackLayout val67 = new StackLayout();
				NameScope val68 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val67, (INameScope)(object)val68);
				((BindableObject)val67).SetValue(StackLayout.SpacingProperty, (object)12.0);
				((BindableObject)val67).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
				val63.set_Key("QuartenaryColor");
				XamlServiceProvider val69 = new XamlServiceProvider();
				Type typeFromHandle13 = typeof(IProvideValueTarget);
				int length;
				object[] array8 = new object[(length = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array8, 2, length);
				array8[0] = val64;
				array8[1] = val67;
				SimpleValueTargetProvider val70 = new SimpleValueTargetProvider(array8, (object)BoxView.ColorProperty, (INameScope)(object)val68);
				object obj7 = (object)val70;
				val69.Add(typeFromHandle13, (object)val70);
				val69.Add(typeof(IReferenceProvider), obj7);
				Type typeFromHandle14 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val71 = new XmlNamespaceResolver();
				val71.Add("", "http://xamarin.com/schemas/2014/forms");
				val71.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val71.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val71.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val71.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val71.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val69.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val71, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_1).GetTypeInfo().Assembly));
				val69.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(45, 37)));
				DynamicResource val72 = ((IMarkupExtension<DynamicResource>)(object)val63).ProvideValue((IServiceProvider)val69);
				((IDynamicResourceHandler)val64).SetDynamicResource(BoxView.ColorProperty, val72.get_Key());
				((BindableObject)val64).SetValue(BoxView.CornerRadiusProperty, new CornerRadiusTypeConverter().ConvertFromInvariantString("3"));
				((BindableObject)val64).SetValue(VisualElement.WidthRequestProperty, (object)6.0);
				((BindableObject)val64).SetValue(VisualElement.HeightRequestProperty, (object)6.0);
				((BindableObject)val64).SetValue(View.MarginProperty, (object)new Thickness(16.0, 8.0, 0.0, 0.0));
				((BindableObject)val64).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
				((Layout<View>)(object)val67).get_Children().Add((View)(object)val64);
				val65.set_Path(".");
				BindingBase val73 = ((IMarkupExtension<BindingBase>)(object)val65).ProvideValue((IServiceProvider)null);
				((BindableObject)val66).SetBinding(Label.TextProperty, val73);
				((Layout<View>)(object)val67).get_Children().Add((View)(object)val66);
				return val67;
			});
			((BindableObject)val10).SetValue(BindableLayout.ItemTemplateProperty, (object)val9);
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val10);
			val11.set_Path("Suggestion");
			BindingBase val43 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)val14).SetBinding(Label.TextProperty, val43);
			val12.set_Key("NotNullOrEmptyConverter");
			XamlServiceProvider val44 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 6];
			array4[0] = val13;
			array4[1] = val14;
			array4[2] = val28;
			array4[3] = val29;
			array4[4] = val30;
			array4[5] = errorView;
			SimpleValueTargetProvider val45 = new SimpleValueTargetProvider(array4, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val31);
			object obj3 = (object)val45;
			val44.Add(typeFromHandle5, (object)val45);
			val44.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val46 = new XmlNamespaceResolver();
			val46.Add("", "http://xamarin.com/schemas/2014/forms");
			val46.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val46.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val46.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val46.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val46.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val44.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val46, typeof(ErrorView).GetTypeInfo().Assembly));
			val44.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 21)));
			object converter = ((IMarkupExtension)val12).ProvideValue((IServiceProvider)val44);
			val13.set_Converter((IValueConverter)converter);
			val13.set_Path("Suggestion");
			BindingBase val47 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)null);
			((BindableObject)val14).SetBinding(VisualElement.IsVisibleProperty, val47);
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val14);
			val15.set_Key("LargeButtonStyle");
			XamlServiceProvider val48 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 5];
			array5[0] = val19;
			array5[1] = val28;
			array5[2] = val29;
			array5[3] = val30;
			array5[4] = errorView;
			SimpleValueTargetProvider val49 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val31);
			object obj4 = (object)val49;
			val48.Add(typeFromHandle7, (object)val49);
			val48.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val50 = new XmlNamespaceResolver();
			val50.Add("", "http://xamarin.com/schemas/2014/forms");
			val50.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val50.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val50.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val50.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val50.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val48.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val50, typeof(ErrorView).GetTypeInfo().Assembly));
			val48.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(67, 21)));
			DynamicResource val51 = ((IMarkupExtension<DynamicResource>)(object)val15).ProvideValue((IServiceProvider)val48);
			((IDynamicResourceHandler)val19).SetDynamicResource(VisualElement.StyleProperty, val51.get_Key());
			val16.set_Key("QuartenaryColor");
			XamlServiceProvider val52 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 5];
			array6[0] = val19;
			array6[1] = val28;
			array6[2] = val29;
			array6[3] = val30;
			array6[4] = errorView;
			SimpleValueTargetProvider val53 = new SimpleValueTargetProvider(array6, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val31);
			object obj5 = (object)val53;
			val52.Add(typeFromHandle9, (object)val53);
			val52.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val54 = new XmlNamespaceResolver();
			val54.Add("", "http://xamarin.com/schemas/2014/forms");
			val54.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val54.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val54.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val54.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val54.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val52.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val54, typeof(ErrorView).GetTypeInfo().Assembly));
			val52.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 21)));
			DynamicResource val55 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val52);
			((IDynamicResourceHandler)val19).SetDynamicResource(VisualElement.BackgroundColorProperty, val55.get_Key());
			((BindableObject)val19).SetValue(Button.TextProperty, (object)errorHandling_TryAgain);
			val17.set_Path("TryAgainCommand");
			BindingBase val56 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)null);
			((BindableObject)val19).SetBinding(Button.CommandProperty, val56);
			val18.set_Path("ShowTryAgainButton");
			BindingBase val57 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)null);
			((BindableObject)val19).SetBinding(VisualElement.IsVisibleProperty, val57);
			((BindableObject)val19).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val19);
			((BindableObject)val27).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 4.0));
			((BindableObject)val20).SetValue(Span.TextProperty, (object)errorhandling_ContactPerson);
			val24.get_Spans().Add(val20);
			((BindableObject)val22).SetValue(Span.TextProperty, (object)errorhandling_ContactNumber);
			((BindableObject)val22).SetValue(Span.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val21.set_Key("SecondaryColor");
			XamlServiceProvider val58 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 7];
			array7[0] = val22;
			array7[1] = val24;
			array7[2] = val27;
			array7[3] = val28;
			array7[4] = val29;
			array7[5] = val30;
			array7[6] = errorView;
			SimpleValueTargetProvider val59 = new SimpleValueTargetProvider(array7, (object)Span.TextColorProperty, (INameScope)(object)val31);
			object obj6 = (object)val59;
			val58.Add(typeFromHandle11, (object)val59);
			val58.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val60 = new XmlNamespaceResolver();
			val60.Add("", "http://xamarin.com/schemas/2014/forms");
			val60.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val60.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val60.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val60.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val60.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val58.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val60, typeof(ErrorView).GetTypeInfo().Assembly));
			val58.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(84, 33)));
			DynamicResource val61 = ((IMarkupExtension<DynamicResource>)(object)val21).ProvideValue((IServiceProvider)val58);
			((IDynamicResourceHandler)val22).SetDynamicResource(Span.TextColorProperty, val61.get_Key());
			val24.get_Spans().Add(val22);
			((BindableObject)val23).SetValue(Span.TextProperty, (object)errorhandling_ContactTime);
			val24.get_Spans().Add(val23);
			((BindableObject)val27).SetValue(Label.FormattedTextProperty, (object)val24);
			val25.set_Path("CallHelpCommand");
			BindingBase val62 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)null);
			((BindableObject)val26).SetBinding(TapGestureRecognizer.CommandProperty, val62);
			((View)val27).get_GestureRecognizers().Add((IGestureRecognizer)(object)val26);
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val27);
			val29.set_Content((View)(object)val28);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val29);
			((BindableObject)errorView).SetValue(ContentPage.ContentProperty, (object)val30);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ErrorView>(this, typeof(ErrorView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			titleLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "titleLabel");
			subTitleLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "subTitleLabel");
			reasonsLabel = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "reasonsLabel");
			suggestionLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "suggestionLabel");
		}
	}
}
