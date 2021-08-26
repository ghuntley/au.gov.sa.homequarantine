using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/SymptomView.xaml")]
	public class SymptomView : Frame
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(SymptomView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as SymptomView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(string), typeof(SymptomView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as SymptomView).icon.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IconFontFamilyProperty = BindableProperty.Create("IconFontFamily", typeof(string), typeof(SymptomView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as SymptomView).icon.set_FontFamily((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(SymptomView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as SymptomView).checkBox.set_Text(((bool)newValue) ? ((string)Application.get_Current().get_Resources().get_Item("faCheckCircle")) : ((string)Application.get_Current().get_Resources().get_Item("faCircle")));
			(bindable as SymptomView).checkBox.set_FontFamily(((bool)newValue) ? "FA-S" : "FA-R");
			if ((bool)newValue)
			{
				((Element)(bindable as SymptomView)).SetDynamicResource(Frame.BorderColorProperty, "TertiaryColor");
				((Element)(bindable as SymptomView).checkBox).SetDynamicResource(Label.TextColorProperty, "TertiaryColor");
				(bindable as SymptomView).textLabel.set_FontAttributes((FontAttributes)1);
			}
			else
			{
				((Element)(bindable as SymptomView)).SetDynamicResource(Frame.BorderColorProperty, "GrayColor");
				((Element)(bindable as SymptomView).checkBox).SetDynamicResource(Label.TextColorProperty, "GrayColor");
				(bindable as SymptomView).textLabel.set_FontAttributes((FontAttributes)0);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty OnChangeCommandProperty = BindableProperty.Create("OnChangeCommand", typeof(Command), typeof(SymptomView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			(bindable as SymptomView).tapGesture.set_Command((ICommand)(Command)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label icon;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label checkBox;

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

		public string IconFontFamily
		{
			get
			{
				return (string)((BindableObject)this).GetValue(IconFontFamilyProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IconFontFamilyProperty, (object)value);
			}
		}

		public bool IsChecked
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsCheckedProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsCheckedProperty, (object)value);
			}
		}

		public ICommand OnChangeCommand
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0011: Expected O, but got Unknown
				return (ICommand)(Command)((BindableObject)this).GetValue(OnChangeCommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(OnChangeCommandProperty, (object)value);
			}
		}

		public SymptomView()
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
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_0229: Expected O, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Expected O, but got Unknown
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Expected O, but got Unknown
			//IL_02ab: Expected O, but got Unknown
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Expected O, but got Unknown
			//IL_02fd: Expected O, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected O, but got Unknown
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected O, but got Unknown
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Expected O, but got Unknown
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Expected O, but got Unknown
			//IL_037f: Expected O, but got Unknown
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Unknown result type (might be due to invalid IL or missing references)
			//IL_052b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Expected O, but got Unknown
			//IL_0566: Expected O, but got Unknown
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_0578: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Expected O, but got Unknown
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c6: Expected O, but got Unknown
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected O, but got Unknown
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Expected O, but got Unknown
			//IL_05e9: Expected O, but got Unknown
			//IL_060c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0642: Expected O, but got Unknown
			//IL_0647: Expected O, but got Unknown
			//IL_0647: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_0669: Unknown result type (might be due to invalid IL or missing references)
			//IL_0679: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a2: Expected O, but got Unknown
			//IL_069d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a7: Expected O, but got Unknown
			//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c0: Expected O, but got Unknown
			//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c5: Expected O, but got Unknown
			//IL_06ca: Expected O, but got Unknown
			//IL_0706: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Unknown result type (might be due to invalid IL or missing references)
			//IL_073b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0764: Unknown result type (might be due to invalid IL or missing references)
			//IL_0769: Unknown result type (might be due to invalid IL or missing references)
			//IL_076c: Expected O, but got Unknown
			//IL_0771: Expected O, but got Unknown
			//IL_0771: Unknown result type (might be due to invalid IL or missing references)
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_078e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0793: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Expected O, but got Unknown
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d1: Expected O, but got Unknown
			//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Expected O, but got Unknown
			//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Expected O, but got Unknown
			//IL_07f4: Expected O, but got Unknown
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0845: Unknown result type (might be due to invalid IL or missing references)
			//IL_084a: Unknown result type (might be due to invalid IL or missing references)
			//IL_084d: Expected O, but got Unknown
			//IL_0852: Expected O, but got Unknown
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_0864: Unknown result type (might be due to invalid IL or missing references)
			//IL_086f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0874: Unknown result type (might be due to invalid IL or missing references)
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ad: Expected O, but got Unknown
			//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b2: Expected O, but got Unknown
			//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cb: Expected O, but got Unknown
			//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d0: Expected O, but got Unknown
			//IL_08d5: Expected O, but got Unknown
			//IL_0911: Unknown result type (might be due to invalid IL or missing references)
			//IL_0916: Unknown result type (might be due to invalid IL or missing references)
			//IL_093f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0944: Unknown result type (might be due to invalid IL or missing references)
			//IL_0947: Expected O, but got Unknown
			//IL_094c: Expected O, but got Unknown
			//IL_094c: Unknown result type (might be due to invalid IL or missing references)
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0969: Unknown result type (might be due to invalid IL or missing references)
			//IL_096e: Unknown result type (might be due to invalid IL or missing references)
			//IL_097e: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a7: Expected O, but got Unknown
			//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ac: Expected O, but got Unknown
			//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c5: Expected O, but got Unknown
			//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ca: Expected O, but got Unknown
			//IL_09cf: Expected O, but got Unknown
			//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(SymptomView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/SymptomView.xaml");
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
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			StaticResourceExtension val13 = new StaticResourceExtension();
			DynamicResourceExtension val14 = new DynamicResourceExtension();
			Label val15 = new Label();
			Grid val16 = new Grid();
			SymptomView symptomView;
			NameScope val17 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(symptomView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)symptomView, (INameScope)(object)val17);
			((INameScope)val17).RegisterName("tapGesture", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("tapGesture");
			}
			((INameScope)val17).RegisterName("icon", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("icon");
			}
			((INameScope)val17).RegisterName("textLabel", (object)val11);
			if (((Element)val11).get_StyleId() == null)
			{
				((Element)val11).set_StyleId("textLabel");
			}
			((INameScope)val17).RegisterName("checkBox", (object)val15);
			if (((Element)val15).get_StyleId() == null)
			{
				((Element)val15).set_StyleId("checkBox");
			}
			tapGesture = val4;
			icon = val10;
			textLabel = val11;
			checkBox = val15;
			((BindableObject)symptomView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)symptomView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)symptomView).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)symptomView).SetValue(Layout.IsClippedToBoundsProperty, (object)true);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val18 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = symptomView;
			SimpleValueTargetProvider val19 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val17);
			object obj = (object)val19;
			val18.Add(typeFromHandle, (object)val19);
			val18.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val20 = new XmlNamespaceResolver();
			val20.Add("", "http://xamarin.com/schemas/2014/forms");
			val20.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val18.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val20, typeof(SymptomView).GetTypeInfo().Assembly));
			val18.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 5)));
			DynamicResource val21 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val18);
			((IDynamicResourceHandler)symptomView).SetDynamicResource(VisualElement.BackgroundColorProperty, val21.get_Key());
			val3.set_Key("GrayColor");
			XamlServiceProvider val22 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = symptomView;
			SimpleValueTargetProvider val23 = new SimpleValueTargetProvider(array2, (object)Frame.BorderColorProperty, (INameScope)(object)val17);
			object obj2 = (object)val23;
			val22.Add(typeFromHandle3, (object)val23);
			val22.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val24 = new XmlNamespaceResolver();
			val24.Add("", "http://xamarin.com/schemas/2014/forms");
			val24.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val22.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val24, typeof(SymptomView).GetTypeInfo().Assembly));
			val22.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 5)));
			DynamicResource val25 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val22);
			((IDynamicResourceHandler)symptomView).SetDynamicResource(Frame.BorderColorProperty, val25.get_Key());
			((BindableObject)symptomView).SetValue(Frame.CornerRadiusProperty, (object)7f);
			((BindableObject)symptomView).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)symptomView).SetValue(Layout.PaddingProperty, (object)new Thickness(8.0, 10.0));
			((View)symptomView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((BindableObject)val16).SetValue(Layout.PaddingProperty, (object)new Thickness(4.0, 8.0, 8.0, 8.0));
			((BindableObject)val16).SetValue(Grid.ColumnSpacingProperty, (object)8.0);
			((BindableObject)val5).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("40"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val16).GetValue(Grid.ColumnDefinitionsProperty)).Add(val5);
			((BindableObject)val6).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val16).GetValue(Grid.ColumnDefinitionsProperty)).Add(val6);
			((BindableObject)val7).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val16).GetValue(Grid.ColumnDefinitionsProperty)).Add(val7);
			((BindableObject)val10).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val10).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val10).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val8.set_Key("Heading2");
			XamlServiceProvider val26 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = val10;
			array3[1] = val16;
			array3[2] = symptomView;
			SimpleValueTargetProvider val27 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val17);
			object obj3 = (object)val27;
			val26.Add(typeFromHandle5, (object)val27);
			val26.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val28 = new XmlNamespaceResolver();
			val28.Add("", "http://xamarin.com/schemas/2014/forms");
			val28.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val26.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val28, typeof(SymptomView).GetTypeInfo().Assembly));
			val26.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 13)));
			DynamicResource val29 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val26);
			((IDynamicResourceHandler)val10).SetDynamicResource(VisualElement.StyleProperty, val29.get_Key());
			val9.set_Key("SecondaryColor");
			XamlServiceProvider val30 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = val10;
			array4[1] = val16;
			array4[2] = symptomView;
			SimpleValueTargetProvider val31 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val17);
			object obj4 = (object)val31;
			val30.Add(typeFromHandle7, (object)val31);
			val30.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val32 = new XmlNamespaceResolver();
			val32.Add("", "http://xamarin.com/schemas/2014/forms");
			val32.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val30.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val32, typeof(SymptomView).GetTypeInfo().Assembly));
			val30.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 13)));
			DynamicResource val33 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val30);
			((IDynamicResourceHandler)val10).SetDynamicResource(Label.TextColorProperty, val33.get_Key());
			((ICollection<View>)val16.get_Children()).Add((View)(object)val10);
			((BindableObject)val11).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val11).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("None"));
			((ICollection<View>)val16.get_Children()).Add((View)(object)val11);
			val12.set_Key("GrayColor");
			XamlServiceProvider val34 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 3];
			array5[0] = val15;
			array5[1] = val16;
			array5[2] = symptomView;
			SimpleValueTargetProvider val35 = new SimpleValueTargetProvider(array5, (object)Label.TextColorProperty, (INameScope)(object)val17);
			object obj5 = (object)val35;
			val34.Add(typeFromHandle9, (object)val35);
			val34.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val36 = new XmlNamespaceResolver();
			val36.Add("", "http://xamarin.com/schemas/2014/forms");
			val36.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val34.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val36, typeof(SymptomView).GetTypeInfo().Assembly));
			val34.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(36, 13)));
			DynamicResource val37 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val34);
			((IDynamicResourceHandler)val15).SetDynamicResource(Label.TextColorProperty, val37.get_Key());
			val13.set_Key("faCircle");
			XamlServiceProvider val38 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 3];
			array6[0] = val15;
			array6[1] = val16;
			array6[2] = symptomView;
			SimpleValueTargetProvider val39 = new SimpleValueTargetProvider(array6, (object)Label.TextProperty, (INameScope)(object)val17);
			object obj6 = (object)val39;
			val38.Add(typeFromHandle11, (object)val39);
			val38.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val40 = new XmlNamespaceResolver();
			val40.Add("", "http://xamarin.com/schemas/2014/forms");
			val40.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val38.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val40, typeof(SymptomView).GetTypeInfo().Assembly));
			val38.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 13)));
			object text = ((IMarkupExtension)val13).ProvideValue((IServiceProvider)val38);
			val15.set_Text((string)text);
			((BindableObject)val15).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val15).SetValue(Grid.ColumnProperty, (object)2);
			val14.set_Key("Heading2");
			XamlServiceProvider val41 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 3];
			array7[0] = val15;
			array7[1] = val16;
			array7[2] = symptomView;
			SimpleValueTargetProvider val42 = new SimpleValueTargetProvider(array7, (object)VisualElement.StyleProperty, (INameScope)(object)val17);
			object obj7 = (object)val42;
			val41.Add(typeFromHandle13, (object)val42);
			val41.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val43 = new XmlNamespaceResolver();
			val43.Add("", "http://xamarin.com/schemas/2014/forms");
			val43.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val41.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val43, typeof(SymptomView).GetTypeInfo().Assembly));
			val41.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 13)));
			DynamicResource val44 = ((IMarkupExtension<DynamicResource>)(object)val14).ProvideValue((IServiceProvider)val41);
			((IDynamicResourceHandler)val15).SetDynamicResource(VisualElement.StyleProperty, val44.get_Key());
			((BindableObject)val15).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.EndAndExpand);
			((ICollection<View>)val16.get_Children()).Add((View)(object)val15);
			((BindableObject)symptomView).SetValue(ContentView.ContentProperty, (object)val16);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<SymptomView>(this, typeof(SymptomView));
			icon = NameScopeExtensions.FindByName<Label>((Element)(object)this, "icon");
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			checkBox = NameScopeExtensions.FindByName<Label>((Element)(object)this, "checkBox");
			tapGesture = NameScopeExtensions.FindByName<TapGestureRecognizer>((Element)(object)this, "tapGesture");
		}
	}
}
