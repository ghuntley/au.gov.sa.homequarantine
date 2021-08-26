using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/InformationResourceLinkButtonView.xaml")]
	public class InformationResourceLinkButtonView : Frame
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(InformationResourceLinkButtonView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as InformationResourceLinkButtonView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsUrlProperty = BindableProperty.Create("IsUrl", typeof(bool), typeof(InformationResourceLinkButtonView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as InformationResourceLinkButtonView).iconLabel.set_Text(((bool)newValue) ? ((string)Application.get_Current().get_Resources().get_Item("faExternalLink")) : ((string)Application.get_Current().get_Resources().get_Item("faChevronRight")));
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty UrlProperty = BindableProperty.Create("Url", typeof(string), typeof(InformationResourceLinkButtonView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

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

		public bool IsUrl
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsUrlProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsUrlProperty, (object)value);
			}
		}

		public string Url
		{
			get
			{
				return (string)((BindableObject)this).GetValue(UrlProperty);
			}
			set
			{
				((BindableObject)this).SetValue(UrlProperty, (object)value);
			}
		}

		public InformationResourceLinkButtonView()
			: this()
		{
			InitializeComponent();
		}

		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			if (IsUrl && !string.IsNullOrEmpty(Url))
			{
				await ViewModelLocator.Resolve<IOpenUrlService>().OpenUrl(Url);
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
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_018e: Expected O, but got Unknown
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected O, but got Unknown
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected O, but got Unknown
			//IL_020f: Expected O, but got Unknown
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Expected O, but got Unknown
			//IL_0261: Expected O, but got Unknown
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected O, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Expected O, but got Unknown
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected O, but got Unknown
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected O, but got Unknown
			//IL_02e3: Expected O, but got Unknown
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Expected O, but got Unknown
			//IL_04c6: Expected O, but got Unknown
			//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Expected O, but got Unknown
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Expected O, but got Unknown
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Expected O, but got Unknown
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0544: Expected O, but got Unknown
			//IL_0549: Expected O, but got Unknown
			//IL_0565: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Unknown result type (might be due to invalid IL or missing references)
			//IL_0595: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c6: Expected O, but got Unknown
			//IL_05cb: Expected O, but got Unknown
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0626: Expected O, but got Unknown
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Expected O, but got Unknown
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0644: Expected O, but got Unknown
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0649: Expected O, but got Unknown
			//IL_064e: Expected O, but got Unknown
			//IL_0660: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(InformationResourceLinkButtonView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/InformationResourceLinkButtonView.xaml");
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
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			Label val8 = new Label();
			StaticResourceExtension val9 = new StaticResourceExtension();
			Label val10 = new Label();
			Grid val11 = new Grid();
			InformationResourceLinkButtonView informationResourceLinkButtonView;
			NameScope val12 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(informationResourceLinkButtonView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)informationResourceLinkButtonView, (INameScope)(object)val12);
			((INameScope)val12).RegisterName("textLabel", (object)val8);
			if (((Element)val8).get_StyleId() == null)
			{
				((Element)val8).set_StyleId("textLabel");
			}
			((INameScope)val12).RegisterName("iconLabel", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("iconLabel");
			}
			textLabel = val8;
			iconLabel = val10;
			((BindableObject)informationResourceLinkButtonView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)informationResourceLinkButtonView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val13 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = informationResourceLinkButtonView;
			SimpleValueTargetProvider val14 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val12);
			object obj = (object)val14;
			val13.Add(typeFromHandle, (object)val14);
			val13.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val15 = new XmlNamespaceResolver();
			val15.Add("", "http://xamarin.com/schemas/2014/forms");
			val15.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val13.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val15, typeof(InformationResourceLinkButtonView).GetTypeInfo().Assembly));
			val13.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 5)));
			DynamicResource val16 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val13);
			((IDynamicResourceHandler)informationResourceLinkButtonView).SetDynamicResource(VisualElement.BackgroundColorProperty, val16.get_Key());
			val3.set_Key("GrayColor");
			XamlServiceProvider val17 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = informationResourceLinkButtonView;
			SimpleValueTargetProvider val18 = new SimpleValueTargetProvider(array2, (object)Frame.BorderColorProperty, (INameScope)(object)val12);
			object obj2 = (object)val18;
			val17.Add(typeFromHandle3, (object)val18);
			val17.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val19 = new XmlNamespaceResolver();
			val19.Add("", "http://xamarin.com/schemas/2014/forms");
			val19.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val17.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val19, typeof(InformationResourceLinkButtonView).GetTypeInfo().Assembly));
			val17.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(9, 5)));
			DynamicResource val20 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val17);
			((IDynamicResourceHandler)informationResourceLinkButtonView).SetDynamicResource(Frame.BorderColorProperty, val20.get_Key());
			((BindableObject)informationResourceLinkButtonView).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)informationResourceLinkButtonView).SetValue(Frame.CornerRadiusProperty, (object)7f);
			((BindableObject)informationResourceLinkButtonView).SetValue(Layout.IsClippedToBoundsProperty, (object)true);
			((BindableObject)informationResourceLinkButtonView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)informationResourceLinkButtonView).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 8.0));
			val4.add_Tapped((EventHandler)informationResourceLinkButtonView.TapGestureRecognizer_Tapped);
			((View)informationResourceLinkButtonView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((BindableObject)val11).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 8.0));
			((BindableObject)val11).SetValue(Grid.ColumnSpacingProperty, (object)16.0);
			((BindableObject)val5).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val11).GetValue(Grid.ColumnDefinitionsProperty)).Add(val5);
			((BindableObject)val6).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val11).GetValue(Grid.ColumnDefinitionsProperty)).Add(val6);
			((BindableObject)val8).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val8).SetValue(Grid.ColumnProperty, (object)0);
			val7.set_Key("PrimaryTextColor");
			XamlServiceProvider val21 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = val8;
			array3[1] = val11;
			array3[2] = informationResourceLinkButtonView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope)(object)val12);
			object obj3 = (object)val22;
			val21.Add(typeFromHandle5, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val21.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(InformationResourceLinkButtonView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 13)));
			DynamicResource val24 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val21);
			((IDynamicResourceHandler)val8).SetDynamicResource(Label.TextColorProperty, val24.get_Key());
			((BindableObject)val8).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((ICollection<View>)val11.get_Children()).Add((View)(object)val8);
			val9.set_Key("faChevronRight");
			XamlServiceProvider val25 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = val10;
			array4[1] = val11;
			array4[2] = informationResourceLinkButtonView;
			SimpleValueTargetProvider val26 = new SimpleValueTargetProvider(array4, (object)Label.TextProperty, (INameScope)(object)val12);
			object obj4 = (object)val26;
			val25.Add(typeFromHandle7, (object)val26);
			val25.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val27 = new XmlNamespaceResolver();
			val27.Add("", "http://xamarin.com/schemas/2014/forms");
			val27.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val25.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val27, typeof(InformationResourceLinkButtonView).GetTypeInfo().Assembly));
			val25.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 13)));
			object text = ((IMarkupExtension)val9).ProvideValue((IServiceProvider)val25);
			val10.set_Text((string)text);
			((BindableObject)val10).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			((BindableObject)val10).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val10).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val10).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((ICollection<View>)val11.get_Children()).Add((View)(object)val10);
			((BindableObject)informationResourceLinkButtonView).SetValue(ContentView.ContentProperty, (object)val11);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<InformationResourceLinkButtonView>(this, typeof(InformationResourceLinkButtonView));
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
		}
	}
}
