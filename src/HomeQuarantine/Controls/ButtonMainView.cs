using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using System.Xml;
using HomeQuarantine.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/ButtonMainView.xaml")]
	public class ButtonMainView : Frame
	{
		public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(string), typeof(ButtonMainView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ButtonMainView).iconLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(ButtonMainView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ButtonMainView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty OnClickCommandProperty = BindableProperty.Create("OnClickCommand", typeof(AsyncCommand), typeof(ButtonMainView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ButtonMainView).tapGesture.set_Command((ICommand)(AsyncCommand)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label iconLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label chevronIconLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TapGestureRecognizer tapGesture;

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

		public string Icon
		{
			get
			{
				return (string)((BindableObject)this).GetValue(IconProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IconProperty, (object)value);
			}
		}

		public IAsyncCommand OnClickCommand
		{
			get
			{
				return (AsyncCommand)((BindableObject)this).GetValue(OnClickCommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(OnClickCommandProperty, (object)value);
			}
		}

		public ButtonMainView()
			: this()
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
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_01fe: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected O, but got Unknown
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected O, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			//IL_027f: Expected O, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Expected O, but got Unknown
			//IL_0321: Expected O, but got Unknown
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Expected O, but got Unknown
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_0381: Expected O, but got Unknown
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Expected O, but got Unknown
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Expected O, but got Unknown
			//IL_03a3: Expected O, but got Unknown
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_050d: Expected O, but got Unknown
			//IL_0512: Expected O, but got Unknown
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_052f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0534: Unknown result type (might be due to invalid IL or missing references)
			//IL_0544: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Expected O, but got Unknown
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Expected O, but got Unknown
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Expected O, but got Unknown
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Expected O, but got Unknown
			//IL_0595: Expected O, but got Unknown
			//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Expected O, but got Unknown
			//IL_060e: Expected O, but got Unknown
			//IL_060e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0620: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0669: Expected O, but got Unknown
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_066e: Expected O, but got Unknown
			//IL_066e: Unknown result type (might be due to invalid IL or missing references)
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0687: Expected O, but got Unknown
			//IL_0682: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Expected O, but got Unknown
			//IL_0691: Expected O, but got Unknown
			//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Unknown result type (might be due to invalid IL or missing references)
			//IL_0775: Unknown result type (might be due to invalid IL or missing references)
			//IL_077a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ab: Expected O, but got Unknown
			//IL_07b0: Expected O, but got Unknown
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Expected O, but got Unknown
			//IL_0806: Unknown result type (might be due to invalid IL or missing references)
			//IL_0810: Expected O, but got Unknown
			//IL_0810: Unknown result type (might be due to invalid IL or missing references)
			//IL_081f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0829: Expected O, but got Unknown
			//IL_0824: Unknown result type (might be due to invalid IL or missing references)
			//IL_082e: Expected O, but got Unknown
			//IL_0833: Expected O, but got Unknown
			//IL_0856: Unknown result type (might be due to invalid IL or missing references)
			//IL_088a: Unknown result type (might be due to invalid IL or missing references)
			//IL_088f: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c0: Expected O, but got Unknown
			//IL_08c5: Expected O, but got Unknown
			//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0920: Expected O, but got Unknown
			//IL_091b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Expected O, but got Unknown
			//IL_0925: Unknown result type (might be due to invalid IL or missing references)
			//IL_0934: Unknown result type (might be due to invalid IL or missing references)
			//IL_093e: Expected O, but got Unknown
			//IL_0939: Unknown result type (might be due to invalid IL or missing references)
			//IL_0943: Expected O, but got Unknown
			//IL_0948: Expected O, but got Unknown
			//IL_0964: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ButtonMainView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/ButtonMainView.xaml");
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
			ColumnDefinition val5 = new ColumnDefinition();
			ColumnDefinition val6 = new ColumnDefinition();
			ColumnDefinition val7 = new ColumnDefinition();
			DynamicResourceExtension val8 = new DynamicResourceExtension();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			Label val10 = new Label();
			Label val11 = new Label();
			StaticResourceExtension val12 = new StaticResourceExtension();
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			Label val14 = new Label();
			Grid val15 = new Grid();
			ButtonMainView buttonMainView;
			NameScope val16 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(buttonMainView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)buttonMainView, (INameScope)(object)val16);
			((INameScope)val16).RegisterName("tapGesture", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("tapGesture");
			}
			((INameScope)val16).RegisterName("iconLabel", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("iconLabel");
			}
			((INameScope)val16).RegisterName("textLabel", (object)val11);
			if (((Element)val11).get_StyleId() == null)
			{
				((Element)val11).set_StyleId("textLabel");
			}
			((INameScope)val16).RegisterName("chevronIconLabel", (object)val14);
			if (((Element)val14).get_StyleId() == null)
			{
				((Element)val14).set_StyleId("chevronIconLabel");
			}
			tapGesture = val4;
			iconLabel = val10;
			textLabel = val11;
			chevronIconLabel = val14;
			((BindableObject)buttonMainView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)buttonMainView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val17 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = buttonMainView;
			SimpleValueTargetProvider val18 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val16);
			object obj = (object)val18;
			val17.Add(typeFromHandle, (object)val18);
			val17.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val19 = new XmlNamespaceResolver();
			val19.Add("", "http://xamarin.com/schemas/2014/forms");
			val19.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val17.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val19, typeof(ButtonMainView).GetTypeInfo().Assembly));
			val17.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 5)));
			DynamicResource val20 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val17);
			((IDynamicResourceHandler)buttonMainView).SetDynamicResource(VisualElement.BackgroundColorProperty, val20.get_Key());
			((BindableObject)buttonMainView).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)buttonMainView).SetValue(Frame.CornerRadiusProperty, (object)7f);
			((BindableObject)buttonMainView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			val3.set_Key("GrayColor");
			XamlServiceProvider val21 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = buttonMainView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array2, (object)Frame.BorderColorProperty, (INameScope)(object)val16);
			object obj2 = (object)val22;
			val21.Add(typeFromHandle3, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val21.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(ButtonMainView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 5)));
			DynamicResource val24 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val21);
			((IDynamicResourceHandler)buttonMainView).SetDynamicResource(Frame.BorderColorProperty, val24.get_Key());
			((BindableObject)buttonMainView).SetValue(Layout.PaddingProperty, (object)new Thickness(8.0, 14.0));
			((View)buttonMainView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((BindableObject)val15).SetValue(Layout.PaddingProperty, (object)new Thickness(4.0, 8.0, 8.0, 8.0));
			((BindableObject)val15).SetValue(Grid.ColumnSpacingProperty, (object)10.0);
			((BindableObject)val5).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("40"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val15).GetValue(Grid.ColumnDefinitionsProperty)).Add(val5);
			((BindableObject)val6).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val15).GetValue(Grid.ColumnDefinitionsProperty)).Add(val6);
			((BindableObject)val7).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val15).GetValue(Grid.ColumnDefinitionsProperty)).Add(val7);
			val8.set_Key("SecondaryColor");
			XamlServiceProvider val25 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = val10;
			array3[1] = val15;
			array3[2] = buttonMainView;
			SimpleValueTargetProvider val26 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope)(object)val16);
			object obj3 = (object)val26;
			val25.Add(typeFromHandle5, (object)val26);
			val25.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val27 = new XmlNamespaceResolver();
			val27.Add("", "http://xamarin.com/schemas/2014/forms");
			val27.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val25.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val27, typeof(ButtonMainView).GetTypeInfo().Assembly));
			val25.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 13)));
			DynamicResource val28 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val25);
			((IDynamicResourceHandler)val10).SetDynamicResource(Label.TextColorProperty, val28.get_Key());
			((BindableObject)val10).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val9.set_Key("Heading2");
			XamlServiceProvider val29 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = val10;
			array4[1] = val15;
			array4[2] = buttonMainView;
			SimpleValueTargetProvider val30 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val16);
			object obj4 = (object)val30;
			val29.Add(typeFromHandle7, (object)val30);
			val29.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val31 = new XmlNamespaceResolver();
			val31.Add("", "http://xamarin.com/schemas/2014/forms");
			val31.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val29.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val31, typeof(ButtonMainView).GetTypeInfo().Assembly));
			val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 13)));
			DynamicResource val32 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val29);
			((IDynamicResourceHandler)val10).SetDynamicResource(VisualElement.StyleProperty, val32.get_Key());
			((BindableObject)val10).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val10).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val10).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((ICollection<View>)val15.get_Children()).Add((View)(object)val10);
			((BindableObject)val11).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val11).SetValue(Label.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 0.0));
			((BindableObject)val11).SetValue(Grid.ColumnProperty, (object)1);
			((ICollection<View>)val15.get_Children()).Add((View)(object)val11);
			val12.set_Key("faChevronRight");
			XamlServiceProvider val33 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 3];
			array5[0] = val14;
			array5[1] = val15;
			array5[2] = buttonMainView;
			SimpleValueTargetProvider val34 = new SimpleValueTargetProvider(array5, (object)Label.TextProperty, (INameScope)(object)val16);
			object obj5 = (object)val34;
			val33.Add(typeFromHandle9, (object)val34);
			val33.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val35 = new XmlNamespaceResolver();
			val35.Add("", "http://xamarin.com/schemas/2014/forms");
			val35.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val33.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val35, typeof(ButtonMainView).GetTypeInfo().Assembly));
			val33.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 13)));
			object text = ((IMarkupExtension)val12).ProvideValue((IServiceProvider)val33);
			val14.set_Text((string)text);
			((BindableObject)val14).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((BindableObject)val14).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val14).SetValue(Grid.ColumnProperty, (object)2);
			val13.set_Key("GrayColor");
			XamlServiceProvider val36 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 3];
			array6[0] = val14;
			array6[1] = val15;
			array6[2] = buttonMainView;
			SimpleValueTargetProvider val37 = new SimpleValueTargetProvider(array6, (object)Label.TextColorProperty, (INameScope)(object)val16);
			object obj6 = (object)val37;
			val36.Add(typeFromHandle11, (object)val37);
			val36.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val38 = new XmlNamespaceResolver();
			val38.Add("", "http://xamarin.com/schemas/2014/forms");
			val38.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val36.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val38, typeof(ButtonMainView).GetTypeInfo().Assembly));
			val36.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(41, 13)));
			DynamicResource val39 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val36);
			((IDynamicResourceHandler)val14).SetDynamicResource(Label.TextColorProperty, val39.get_Key());
			((BindableObject)val14).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.EndAndExpand);
			((ICollection<View>)val15.get_Children()).Add((View)(object)val14);
			((BindableObject)buttonMainView).SetValue(ContentView.ContentProperty, (object)val15);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ButtonMainView>(this, typeof(ButtonMainView));
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			chevronIconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "chevronIconLabel");
			tapGesture = NameScopeExtensions.FindByName<TapGestureRecognizer>((Element)(object)this, "tapGesture");
		}
	}
}
