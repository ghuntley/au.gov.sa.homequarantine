using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/TwoRowView.xaml")]
	public class TwoRowView : StackLayout
	{
		public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(TwoRowView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as TwoRowView).labelLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(string), typeof(TwoRowView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as TwoRowView).valueLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ShouldCenterProperty = BindableProperty.Create("ShouldCenter", typeof(bool), typeof(TwoRowView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			if ((bool)newValue)
			{
				(bindable as TwoRowView).labelLabel.set_HorizontalTextAlignment((TextAlignment)1);
				(bindable as TwoRowView).valueLabel.set_HorizontalTextAlignment((TextAlignment)1);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label labelLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label valueLabel;

		public string Label
		{
			get
			{
				return (string)((BindableObject)this).GetValue(LabelProperty);
			}
			set
			{
				((BindableObject)this).SetValue(LabelProperty, (object)value);
			}
		}

		public string Value
		{
			get
			{
				return (string)((BindableObject)this).GetValue(ValueProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ValueProperty, (object)value);
			}
		}

		public bool? ShouldCenter
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(ShouldCenterProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ShouldCenterProperty, (object)value);
			}
		}

		public TwoRowView()
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
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_019e: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected O, but got Unknown
			//IL_0220: Expected O, but got Unknown
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
			//IL_0275: Expected O, but got Unknown
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected O, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Expected O, but got Unknown
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Expected O, but got Unknown
			//IL_02f7: Expected O, but got Unknown
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Expected O, but got Unknown
			//IL_036b: Expected O, but got Unknown
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Expected O, but got Unknown
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Expected O, but got Unknown
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected O, but got Unknown
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Expected O, but got Unknown
			//IL_03ed: Expected O, but got Unknown
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Expected O, but got Unknown
			//IL_0446: Expected O, but got Unknown
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a1: Expected O, but got Unknown
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Expected O, but got Unknown
			//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected O, but got Unknown
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected O, but got Unknown
			//IL_04c8: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(TwoRowView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/TwoRowView.xaml");
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
			Label val4 = new Label();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			DynamicResourceExtension val6 = new DynamicResourceExtension();
			Label val7 = new Label();
			TwoRowView twoRowView;
			NameScope val8 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(twoRowView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)twoRowView, (INameScope)(object)val8);
			((INameScope)val8).RegisterName("labelLabel", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("labelLabel");
			}
			((INameScope)val8).RegisterName("valueLabel", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("valueLabel");
			}
			labelLabel = val4;
			valueLabel = val7;
			((BindableObject)twoRowView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)twoRowView).SetValue(StackLayout.SpacingProperty, (object)4.0);
			((BindableObject)twoRowView).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 10.0));
			val2.set_Key("ListItemDetailTextStyle");
			XamlServiceProvider val9 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = val4;
			array[1] = twoRowView;
			SimpleValueTargetProvider val10 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val8);
			object obj = (object)val10;
			val9.Add(typeFromHandle, (object)val10);
			val9.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val11 = new XmlNamespaceResolver();
			val11.Add("", "http://xamarin.com/schemas/2014/forms");
			val11.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val9.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val11, typeof(TwoRowView).GetTypeInfo().Assembly));
			val9.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 7)));
			DynamicResource val12 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val9);
			((IDynamicResourceHandler)val4).SetDynamicResource(VisualElement.StyleProperty, val12.get_Key());
			val3.set_Key("SecondaryTextColor");
			XamlServiceProvider val13 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 2];
			array2[0] = val4;
			array2[1] = twoRowView;
			SimpleValueTargetProvider val14 = new SimpleValueTargetProvider(array2, (object)Label.TextColorProperty, (INameScope)(object)val8);
			object obj2 = (object)val14;
			val13.Add(typeFromHandle3, (object)val14);
			val13.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val15 = new XmlNamespaceResolver();
			val15.Add("", "http://xamarin.com/schemas/2014/forms");
			val15.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val13.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val15, typeof(TwoRowView).GetTypeInfo().Assembly));
			val13.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(13, 7)));
			DynamicResource val16 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val13);
			((IDynamicResourceHandler)val4).SetDynamicResource(Label.TextColorProperty, val16.get_Key());
			((Layout<View>)(object)twoRowView).get_Children().Add((View)(object)val4);
			((BindableObject)val7).SetValue(Label.TextProperty, (object)"-");
			val5.set_Key("ListItemTextStyle");
			XamlServiceProvider val17 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 2];
			array3[0] = val7;
			array3[1] = twoRowView;
			SimpleValueTargetProvider val18 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val8);
			object obj3 = (object)val18;
			val17.Add(typeFromHandle5, (object)val18);
			val17.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val19 = new XmlNamespaceResolver();
			val19.Add("", "http://xamarin.com/schemas/2014/forms");
			val19.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val17.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val19, typeof(TwoRowView).GetTypeInfo().Assembly));
			val17.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 7)));
			DynamicResource val20 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val17);
			((IDynamicResourceHandler)val7).SetDynamicResource(VisualElement.StyleProperty, val20.get_Key());
			val6.set_Key("PrimaryTextColor");
			XamlServiceProvider val21 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 2];
			array4[0] = val7;
			array4[1] = twoRowView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val8);
			object obj4 = (object)val22;
			val21.Add(typeFromHandle7, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val21.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(TwoRowView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 7)));
			DynamicResource val24 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val21);
			((IDynamicResourceHandler)val7).SetDynamicResource(Label.TextColorProperty, val24.get_Key());
			((Layout<View>)(object)twoRowView).get_Children().Add((View)(object)val7);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<TwoRowView>(this, typeof(TwoRowView));
			labelLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "labelLabel");
			valueLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "valueLabel");
		}
	}
}
