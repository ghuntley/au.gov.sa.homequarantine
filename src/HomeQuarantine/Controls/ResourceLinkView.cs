using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using System.Xml;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/ResourceLinkView.xaml")]
	public class ResourceLinkView : Frame
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(ResourceLinkView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ResourceLinkView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsUrlProperty = BindableProperty.Create("IsUrl", typeof(bool), typeof(ResourceLinkView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ResourceLinkView).iconLabel.set_Text(((bool)newValue) ? ((string)Application.get_Current().get_Resources().get_Item("faExternalLink")) : ((string)Application.get_Current().get_Resources().get_Item("faChevronRight")));
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty UrlProperty = BindableProperty.Create("Url", typeof(string), typeof(ResourceLinkView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)null, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty OnTapCommandProperty = BindableProperty.Create("OnTapCommand", typeof(AsyncCommand), typeof(ResourceLinkView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ResourceLinkView).tapGesture.set_Command((ICommand)(AsyncCommand)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label iconLabel;

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

		public IAsyncCommand OnTapCommand
		{
			get
			{
				return (AsyncCommand)((BindableObject)this).GetValue(OnTapCommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(OnTapCommandProperty, (object)value);
			}
		}

		public ResourceLinkView()
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
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_01b6: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected O, but got Unknown
			//IL_0237: Expected O, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_0289: Expected O, but got Unknown
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Expected O, but got Unknown
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Expected O, but got Unknown
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Expected O, but got Unknown
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Expected O, but got Unknown
			//IL_030b: Expected O, but got Unknown
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_043b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Expected O, but got Unknown
			//IL_04d8: Expected O, but got Unknown
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Expected O, but got Unknown
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Expected O, but got Unknown
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected O, but got Unknown
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Expected O, but got Unknown
			//IL_055b: Expected O, but got Unknown
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d8: Expected O, but got Unknown
			//IL_05dd: Expected O, but got Unknown
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_060f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Expected O, but got Unknown
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Expected O, but got Unknown
			//IL_063d: Unknown result type (might be due to invalid IL or missing references)
			//IL_064c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0656: Expected O, but got Unknown
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_065b: Expected O, but got Unknown
			//IL_0660: Expected O, but got Unknown
			//IL_0672: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ResourceLinkView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/ResourceLinkView.xaml");
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
			ResourceLinkView resourceLinkView;
			NameScope val12 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(resourceLinkView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)resourceLinkView, (INameScope)(object)val12);
			((INameScope)val12).RegisterName("tapGesture", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("tapGesture");
			}
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
			tapGesture = val4;
			textLabel = val8;
			iconLabel = val10;
			((BindableObject)resourceLinkView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)resourceLinkView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Key("ButtonTextColor");
			XamlServiceProvider val13 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = resourceLinkView;
			SimpleValueTargetProvider val14 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val12);
			object obj = (object)val14;
			val13.Add(typeFromHandle, (object)val14);
			val13.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val15 = new XmlNamespaceResolver();
			val15.Add("", "http://xamarin.com/schemas/2014/forms");
			val15.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val13.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val15, typeof(ResourceLinkView).GetTypeInfo().Assembly));
			val13.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 5)));
			DynamicResource val16 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val13);
			((IDynamicResourceHandler)resourceLinkView).SetDynamicResource(VisualElement.BackgroundColorProperty, val16.get_Key());
			val3.set_Key("GrayColor");
			XamlServiceProvider val17 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 1];
			array2[0] = resourceLinkView;
			SimpleValueTargetProvider val18 = new SimpleValueTargetProvider(array2, (object)Frame.BorderColorProperty, (INameScope)(object)val12);
			object obj2 = (object)val18;
			val17.Add(typeFromHandle3, (object)val18);
			val17.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val19 = new XmlNamespaceResolver();
			val19.Add("", "http://xamarin.com/schemas/2014/forms");
			val19.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val17.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val19, typeof(ResourceLinkView).GetTypeInfo().Assembly));
			val17.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(9, 5)));
			DynamicResource val20 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val17);
			((IDynamicResourceHandler)resourceLinkView).SetDynamicResource(Frame.BorderColorProperty, val20.get_Key());
			((BindableObject)resourceLinkView).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)resourceLinkView).SetValue(Layout.IsClippedToBoundsProperty, (object)true);
			((BindableObject)resourceLinkView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)resourceLinkView).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 12.0));
			val4.add_Tapped((EventHandler)resourceLinkView.TapGestureRecognizer_Tapped);
			((View)resourceLinkView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
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
			array3[2] = resourceLinkView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope)(object)val12);
			object obj3 = (object)val22;
			val21.Add(typeFromHandle5, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val21.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(ResourceLinkView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 13)));
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
			array4[2] = resourceLinkView;
			SimpleValueTargetProvider val26 = new SimpleValueTargetProvider(array4, (object)Label.TextProperty, (INameScope)(object)val12);
			object obj4 = (object)val26;
			val25.Add(typeFromHandle7, (object)val26);
			val25.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val27 = new XmlNamespaceResolver();
			val27.Add("", "http://xamarin.com/schemas/2014/forms");
			val27.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val25.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val27, typeof(ResourceLinkView).GetTypeInfo().Assembly));
			val25.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 13)));
			object text = ((IMarkupExtension)val9).ProvideValue((IServiceProvider)val25);
			val10.set_Text((string)text);
			((BindableObject)val10).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			((BindableObject)val10).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val10).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val10).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((ICollection<View>)val11.get_Children()).Add((View)(object)val10);
			((BindableObject)resourceLinkView).SetValue(ContentView.ContentProperty, (object)val11);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ResourceLinkView>(this, typeof(ResourceLinkView));
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
			tapGesture = NameScopeExtensions.FindByName<TapGestureRecognizer>((Element)(object)this, "tapGesture");
		}
	}
}
