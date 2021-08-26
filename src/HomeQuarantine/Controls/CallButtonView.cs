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
	[XamlFilePath("Controls/CallButtonView.xaml")]
	public class CallButtonView : Frame
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CallButtonView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as CallButtonView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ShowCallButtonProperty = BindableProperty.Create("ShowCallButton", typeof(bool), typeof(CallButtonView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label iconLabel;

		public string Text
		{
			get
			{
				return (string)((BindableObject)this).GetValue(TextProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TextProperty, (object)value);
			}
		}

		public bool ShowCallButton
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(ShowCallButtonProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ShowCallButtonProperty, (object)value);
			}
		}

		public CallButtonView()
			: this()
		{
			InitializeComponent();
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Launcher.OpenAsync("tel:" + Text);
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
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_019c: Expected O, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected O, but got Unknown
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected O, but got Unknown
			//IL_022e: Expected O, but got Unknown
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Expected O, but got Unknown
			//IL_0280: Expected O, but got Unknown
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Expected O, but got Unknown
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected O, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected O, but got Unknown
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_030d: Expected O, but got Unknown
			//IL_0312: Expected O, but got Unknown
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Expected O, but got Unknown
			//IL_047a: Expected O, but got Unknown
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e5: Expected O, but got Unknown
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected O, but got Unknown
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Expected O, but got Unknown
			//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Expected O, but got Unknown
			//IL_050d: Expected O, but got Unknown
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Unknown result type (might be due to invalid IL or missing references)
			//IL_056c: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Expected O, but got Unknown
			//IL_05a7: Expected O, but got Unknown
			//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0612: Expected O, but got Unknown
			//IL_060d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0617: Expected O, but got Unknown
			//IL_0617: Unknown result type (might be due to invalid IL or missing references)
			//IL_0626: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Expected O, but got Unknown
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Expected O, but got Unknown
			//IL_063a: Expected O, but got Unknown
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			//IL_0699: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ca: Expected O, but got Unknown
			//IL_06cf: Expected O, but got Unknown
			//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0701: Unknown result type (might be due to invalid IL or missing references)
			//IL_0711: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Expected O, but got Unknown
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Expected O, but got Unknown
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0758: Expected O, but got Unknown
			//IL_0753: Unknown result type (might be due to invalid IL or missing references)
			//IL_075d: Expected O, but got Unknown
			//IL_0762: Expected O, but got Unknown
			//IL_0774: Unknown result type (might be due to invalid IL or missing references)
			//IL_078f: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(CallButtonView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/CallButtonView.xaml");
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
			string callButton_Call = Resources.CallButton_Call;
			Label val6 = new Label();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			Label val8 = new Label();
			StackLayout val9 = new StackLayout();
			StaticResourceExtension val10 = new StaticResourceExtension();
			Label val11 = new Label();
			StackLayout val12 = new StackLayout();
			CallButtonView callButtonView;
			NameScope val13 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(callButtonView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)callButtonView, (INameScope)(object)val13);
			((INameScope)val13).RegisterName("textLabel", (object)val8);
			if (((Element)val8).get_StyleId() == null)
			{
				((Element)val8).set_StyleId("textLabel");
			}
			((INameScope)val13).RegisterName("iconLabel", (object)val11);
			if (((Element)val11).get_StyleId() == null)
			{
				((Element)val11).set_StyleId("iconLabel");
			}
			textLabel = val8;
			iconLabel = val11;
			((BindableObject)callButtonView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)callButtonView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val14 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = callButtonView;
			SimpleValueTargetProvider val15 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val13);
			object obj = (object)val15;
			val14.Add(typeFromHandle, (object)val15);
			val14.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val16 = new XmlNamespaceResolver();
			val16.Add("", "http://xamarin.com/schemas/2014/forms");
			val16.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val16.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val14.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val16, typeof(CallButtonView).GetTypeInfo().Assembly));
			val14.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(9, 5)));
			DynamicResource val17 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val14);
			((IDynamicResourceHandler)callButtonView).SetDynamicResource(VisualElement.BackgroundColorProperty, val17.get_Key());
			val3.set_Key("GrayColor");
			XamlServiceProvider val18 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = callButtonView;
			SimpleValueTargetProvider val19 = new SimpleValueTargetProvider(array2, (object)Frame.BorderColorProperty, (INameScope)(object)val13);
			object obj2 = (object)val19;
			val18.Add(typeFromHandle3, (object)val19);
			val18.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val20 = new XmlNamespaceResolver();
			val20.Add("", "http://xamarin.com/schemas/2014/forms");
			val20.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val20.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val18.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val20, typeof(CallButtonView).GetTypeInfo().Assembly));
			val18.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 5)));
			DynamicResource val21 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val18);
			((IDynamicResourceHandler)callButtonView).SetDynamicResource(Frame.BorderColorProperty, val21.get_Key());
			((BindableObject)callButtonView).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)callButtonView).SetValue(Layout.IsClippedToBoundsProperty, (object)true);
			((BindableObject)callButtonView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)callButtonView).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val4.add_Tapped((EventHandler)callButtonView.TapGestureRecognizer_Tapped);
			((View)callButtonView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((BindableObject)val12).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val12).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val9).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val9).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val9).SetValue(StackLayout.SpacingProperty, (object)6.0);
			val5.set_Key("PrimaryTextColor");
			XamlServiceProvider val22 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 4];
			array3[0] = val6;
			array3[1] = val9;
			array3[2] = val12;
			array3[3] = callButtonView;
			SimpleValueTargetProvider val23 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope)(object)val13);
			object obj3 = (object)val23;
			val22.Add(typeFromHandle5, (object)val23);
			val22.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val24 = new XmlNamespaceResolver();
			val24.Add("", "http://xamarin.com/schemas/2014/forms");
			val24.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val24.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val22.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val24, typeof(CallButtonView).GetTypeInfo().Assembly));
			val22.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 13)));
			DynamicResource val25 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val22);
			((IDynamicResourceHandler)val6).SetDynamicResource(Label.TextColorProperty, val25.get_Key());
			((BindableObject)val6).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val6).SetValue(Label.TextProperty, (object)callButton_Call);
			((Layout<View>)(object)val9).get_Children().Add((View)(object)val6);
			val7.set_Key("PrimaryTextColor");
			XamlServiceProvider val26 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 4];
			array4[0] = val8;
			array4[1] = val9;
			array4[2] = val12;
			array4[3] = callButtonView;
			SimpleValueTargetProvider val27 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val13);
			object obj4 = (object)val27;
			val26.Add(typeFromHandle7, (object)val27);
			val26.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val28 = new XmlNamespaceResolver();
			val28.Add("", "http://xamarin.com/schemas/2014/forms");
			val28.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val28.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val26.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val28, typeof(CallButtonView).GetTypeInfo().Assembly));
			val26.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 13)));
			DynamicResource val29 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val26);
			((IDynamicResourceHandler)val8).SetDynamicResource(Label.TextColorProperty, val29.get_Key());
			((BindableObject)val8).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val9).get_Children().Add((View)(object)val8);
			((Layout<View>)(object)val12).get_Children().Add((View)(object)val9);
			val10.set_Key("faPhone");
			XamlServiceProvider val30 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 3];
			array5[0] = val11;
			array5[1] = val12;
			array5[2] = callButtonView;
			SimpleValueTargetProvider val31 = new SimpleValueTargetProvider(array5, (object)Label.TextProperty, (INameScope)(object)val13);
			object obj5 = (object)val31;
			val30.Add(typeFromHandle9, (object)val31);
			val30.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val32 = new XmlNamespaceResolver();
			val32.Add("", "http://xamarin.com/schemas/2014/forms");
			val32.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val32.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val30.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val32, typeof(CallButtonView).GetTypeInfo().Assembly));
			val30.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 13)));
			object text = ((IMarkupExtension)val10).ProvideValue((IServiceProvider)val30);
			val11.set_Text((string)text);
			((BindableObject)val11).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			((BindableObject)val11).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val11).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((Layout<View>)(object)val12).get_Children().Add((View)(object)val11);
			((BindableObject)callButtonView).SetValue(ContentView.ContentProperty, (object)val12);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<CallButtonView>(this, typeof(CallButtonView));
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
		}
	}
}
