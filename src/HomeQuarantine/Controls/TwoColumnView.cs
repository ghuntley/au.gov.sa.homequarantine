using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/TwoColumnView.xaml")]
	public class TwoColumnView : Grid
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(TwoColumnView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as TwoColumnView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty DetailProperty = BindableProperty.Create("Detail", typeof(string), typeof(TwoColumnView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as TwoColumnView).detailLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsInvalidProperty = BindableProperty.Create("IsInvalid", typeof(bool), typeof(TwoColumnView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			if ((bool)newValue)
			{
				(bindable as TwoColumnView).detailLabel.set_TextColor(Color.Red);
				(bindable as TwoColumnView).textLabel.set_TextColor(Color.Red);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label detailLabel;

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

		public string Detail
		{
			get
			{
				return (string)((BindableObject)this).GetValue(DetailProperty);
			}
			set
			{
				((BindableObject)this).SetValue(DetailProperty, (object)value);
			}
		}

		public bool IsInvalid
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsInvalidProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsInvalidProperty, (object)value);
			}
		}

		public TwoColumnView()
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
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_0231: Expected O, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected O, but got Unknown
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected O, but got Unknown
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected O, but got Unknown
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_02b4: Expected O, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Expected O, but got Unknown
			//IL_030b: Expected O, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Expected O, but got Unknown
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Expected O, but got Unknown
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Expected O, but got Unknown
			//IL_038e: Expected O, but got Unknown
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected O, but got Unknown
			//IL_0433: Expected O, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_0450: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_0465: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Expected O, but got Unknown
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Expected O, but got Unknown
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ac: Expected O, but got Unknown
			//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Expected O, but got Unknown
			//IL_04b6: Expected O, but got Unknown
			//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Expected O, but got Unknown
			//IL_050f: Expected O, but got Unknown
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_052c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Expected O, but got Unknown
			//IL_0565: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Expected O, but got Unknown
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_057e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Expected O, but got Unknown
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Expected O, but got Unknown
			//IL_0592: Expected O, but got Unknown
			//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(TwoColumnView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/TwoColumnView.xaml");
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
			ColumnDefinition val2 = new ColumnDefinition();
			ColumnDefinition val3 = new ColumnDefinition();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			Label val6 = new Label();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			DynamicResourceExtension val8 = new DynamicResourceExtension();
			Label val9 = new Label();
			TwoColumnView twoColumnView;
			NameScope val10 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(twoColumnView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)twoColumnView, (INameScope)(object)val10);
			((INameScope)val10).RegisterName("textLabel", (object)val6);
			if (((Element)val6).get_StyleId() == null)
			{
				((Element)val6).set_StyleId("textLabel");
			}
			((INameScope)val10).RegisterName("detailLabel", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("detailLabel");
			}
			textLabel = val6;
			detailLabel = val9;
			((BindableObject)twoColumnView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)twoColumnView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)twoColumnView).SetValue(VisualElement.MinimumHeightRequestProperty, (object)50.0);
			((BindableObject)twoColumnView).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 8.0));
			((BindableObject)val2).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)twoColumnView).GetValue(Grid.ColumnDefinitionsProperty)).Add(val2);
			((BindableObject)val3).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)twoColumnView).GetValue(Grid.ColumnDefinitionsProperty)).Add(val3);
			((BindableObject)val6).SetValue(Grid.ColumnProperty, (object)0);
			val4.set_Key("ListItemTextStyle");
			XamlServiceProvider val11 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = val6;
			array[1] = twoColumnView;
			SimpleValueTargetProvider val12 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val10);
			object obj = (object)val12;
			val11.Add(typeFromHandle, (object)val12);
			val11.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val13 = new XmlNamespaceResolver();
			val13.Add("", "http://xamarin.com/schemas/2014/forms");
			val13.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val11.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val13, typeof(TwoColumnView).GetTypeInfo().Assembly));
			val11.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 9)));
			DynamicResource val14 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val11);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val14.get_Key());
			val5.set_Key("SecondaryTextColor");
			XamlServiceProvider val15 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 2];
			array2[0] = val6;
			array2[1] = twoColumnView;
			SimpleValueTargetProvider val16 = new SimpleValueTargetProvider(array2, (object)Label.TextColorProperty, (INameScope)(object)val10);
			object obj2 = (object)val16;
			val15.Add(typeFromHandle3, (object)val16);
			val15.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val17 = new XmlNamespaceResolver();
			val17.Add("", "http://xamarin.com/schemas/2014/forms");
			val17.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val15.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val17, typeof(TwoColumnView).GetTypeInfo().Assembly));
			val15.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 9)));
			DynamicResource val18 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val15);
			((IDynamicResourceHandler)val6).SetDynamicResource(Label.TextColorProperty, val18.get_Key());
			((BindableObject)val6).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val6).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Start);
			((ICollection<View>)((Grid)twoColumnView).get_Children()).Add((View)(object)val6);
			((BindableObject)val9).SetValue(Grid.ColumnProperty, (object)1);
			val7.set_Key("ListItemTextStyle");
			XamlServiceProvider val19 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 2];
			array3[0] = val9;
			array3[1] = twoColumnView;
			SimpleValueTargetProvider val20 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val10);
			object obj3 = (object)val20;
			val19.Add(typeFromHandle5, (object)val20);
			val19.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val21 = new XmlNamespaceResolver();
			val21.Add("", "http://xamarin.com/schemas/2014/forms");
			val21.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val19.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val21, typeof(TwoColumnView).GetTypeInfo().Assembly));
			val19.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 9)));
			DynamicResource val22 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val19);
			((IDynamicResourceHandler)val9).SetDynamicResource(VisualElement.StyleProperty, val22.get_Key());
			val8.set_Key("PrimaryTextColor");
			XamlServiceProvider val23 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 2];
			array4[0] = val9;
			array4[1] = twoColumnView;
			SimpleValueTargetProvider val24 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val10);
			object obj4 = (object)val24;
			val23.Add(typeFromHandle7, (object)val24);
			val23.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val25 = new XmlNamespaceResolver();
			val25.Add("", "http://xamarin.com/schemas/2014/forms");
			val25.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val23.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val25, typeof(TwoColumnView).GetTypeInfo().Assembly));
			val23.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 9)));
			DynamicResource val26 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val23);
			((IDynamicResourceHandler)val9).SetDynamicResource(Label.TextColorProperty, val26.get_Key());
			((BindableObject)val9).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val9).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val9).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.EndAndExpand);
			((BindableObject)val9).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			((ICollection<View>)((Grid)twoColumnView).get_Children()).Add((View)(object)val9);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<TwoColumnView>(this, typeof(TwoColumnView));
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			detailLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "detailLabel");
		}
	}
}
