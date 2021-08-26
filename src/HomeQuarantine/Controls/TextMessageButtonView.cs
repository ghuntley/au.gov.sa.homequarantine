using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Data.Resources.Languages;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/TextMessageButtonView.xaml")]
	public class TextMessageButtonView : Frame
	{
		public static readonly BindableProperty ShowTextMessageButtonProperty = BindableProperty.Create("ShowTextMessageButton", typeof(bool), typeof(TextMessageButtonView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty NumberProperty = BindableProperty.Create("Number", typeof(string), typeof(TextMessageButtonView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label iconLabel;

		public string Number
		{
			get
			{
				return (string)((BindableObject)this).GetValue(NumberProperty);
			}
			set
			{
				((BindableObject)this).SetValue(NumberProperty, (object)value);
			}
		}

		public bool ShowTextMessageButton
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(ShowTextMessageButtonProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ShowTextMessageButtonProperty, (object)value);
			}
		}

		public TextMessageButtonView()
			: this()
		{
			InitializeComponent();
		}

		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			try
			{
				await Sms.ComposeAsync(new SmsMessage((string)null, Number));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
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
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0162: Expected O, but got Unknown
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_01f4: Expected O, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected O, but got Unknown
			//IL_0246: Expected O, but got Unknown
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Expected O, but got Unknown
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected O, but got Unknown
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected O, but got Unknown
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected O, but got Unknown
			//IL_02d8: Expected O, but got Unknown
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_043b: Expected O, but got Unknown
			//IL_0440: Expected O, but got Unknown
			//IL_0440: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Expected O, but got Unknown
			//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b0: Expected O, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Expected O, but got Unknown
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Expected O, but got Unknown
			//IL_04d3: Expected O, but got Unknown
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0540: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_05e1: Expected O, but got Unknown
			//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Expected O, but got Unknown
			//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Expected O, but got Unknown
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0604: Expected O, but got Unknown
			//IL_0609: Expected O, but got Unknown
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(TextMessageButtonView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/TextMessageButtonView.xaml");
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
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			TapGestureRecognizer val4 = new TapGestureRecognizer();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			string resource_SendATextMessage = Resources.Resource_SendATextMessage;
			Label val6 = new Label();
			StackLayout val7 = new StackLayout();
			StaticResourceExtension val8 = new StaticResourceExtension();
			Label val9 = new Label();
			StackLayout val10 = new StackLayout();
			TextMessageButtonView textMessageButtonView;
			NameScope val11 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(textMessageButtonView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)textMessageButtonView, (INameScope)(object)val11);
			((INameScope)val11).RegisterName("iconLabel", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("iconLabel");
			}
			iconLabel = val9;
			((BindableObject)textMessageButtonView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)textMessageButtonView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val12 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = textMessageButtonView;
			SimpleValueTargetProvider val13 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val11);
			object obj = (object)val13;
			val12.Add(typeFromHandle, (object)val13);
			val12.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val14 = new XmlNamespaceResolver();
			val14.Add("", "http://xamarin.com/schemas/2014/forms");
			val14.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val14.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val12.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val14, typeof(TextMessageButtonView).GetTypeInfo().Assembly));
			val12.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(9, 5)));
			DynamicResource val15 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val12);
			((IDynamicResourceHandler)textMessageButtonView).SetDynamicResource(VisualElement.BackgroundColorProperty, val15.get_Key());
			val3.set_Key("GrayColor");
			XamlServiceProvider val16 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = textMessageButtonView;
			SimpleValueTargetProvider val17 = new SimpleValueTargetProvider(array2, (object)Frame.BorderColorProperty, (INameScope)(object)val11);
			object obj2 = (object)val17;
			val16.Add(typeFromHandle3, (object)val17);
			val16.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val18 = new XmlNamespaceResolver();
			val18.Add("", "http://xamarin.com/schemas/2014/forms");
			val18.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val18.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val16.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val18, typeof(TextMessageButtonView).GetTypeInfo().Assembly));
			val16.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 5)));
			DynamicResource val19 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val16);
			((IDynamicResourceHandler)textMessageButtonView).SetDynamicResource(Frame.BorderColorProperty, val19.get_Key());
			((BindableObject)textMessageButtonView).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)textMessageButtonView).SetValue(Layout.IsClippedToBoundsProperty, (object)true);
			((BindableObject)textMessageButtonView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)textMessageButtonView).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val4.add_Tapped((EventHandler)textMessageButtonView.TapGestureRecognizer_Tapped);
			((View)textMessageButtonView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((BindableObject)val10).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val10).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val7).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val7).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val7).SetValue(StackLayout.SpacingProperty, (object)10.0);
			val5.set_Key("PrimaryTextColor");
			XamlServiceProvider val20 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 4];
			array3[0] = val6;
			array3[1] = val7;
			array3[2] = val10;
			array3[3] = textMessageButtonView;
			SimpleValueTargetProvider val21 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope)(object)val11);
			object obj3 = (object)val21;
			val20.Add(typeFromHandle5, (object)val21);
			val20.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val22 = new XmlNamespaceResolver();
			val22.Add("", "http://xamarin.com/schemas/2014/forms");
			val22.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val22.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val20.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val22, typeof(TextMessageButtonView).GetTypeInfo().Assembly));
			val20.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 13)));
			DynamicResource val23 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val20);
			((IDynamicResourceHandler)val6).SetDynamicResource(Label.TextColorProperty, val23.get_Key());
			((BindableObject)val6).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val6).SetValue(Label.TextProperty, (object)resource_SendATextMessage);
			((Layout<View>)(object)val7).get_Children().Add((View)(object)val6);
			((Layout<View>)(object)val10).get_Children().Add((View)(object)val7);
			val8.set_Key("faMobile");
			XamlServiceProvider val24 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = val9;
			array4[1] = val10;
			array4[2] = textMessageButtonView;
			SimpleValueTargetProvider val25 = new SimpleValueTargetProvider(array4, (object)Label.TextProperty, (INameScope)(object)val11);
			object obj4 = (object)val25;
			val24.Add(typeFromHandle7, (object)val25);
			val24.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val26 = new XmlNamespaceResolver();
			val26.Add("", "http://xamarin.com/schemas/2014/forms");
			val26.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val26.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val24.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val26, typeof(TextMessageButtonView).GetTypeInfo().Assembly));
			val24.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 13)));
			object text = ((IMarkupExtension)val8).ProvideValue((IServiceProvider)val24);
			val9.set_Text((string)text);
			((BindableObject)val9).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			((BindableObject)val9).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val9).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((Layout<View>)(object)val10).get_Children().Add((View)(object)val9);
			((BindableObject)textMessageButtonView).SetValue(ContentView.ContentProperty, (object)val10);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<TextMessageButtonView>(this, typeof(TextMessageButtonView));
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
		}
	}
}
