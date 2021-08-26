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
	[XamlFilePath("Controls/CustomIcon.xaml")]
	public class CustomIcon : Grid
	{
		public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(string), typeof(CustomIcon), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as CustomIcon).iconLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create("FontFamily", typeof(string), typeof(CustomIcon), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as CustomIcon).iconLabel.set_FontFamily((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ColorProperty = BindableProperty.Create("FontFamily", typeof(Color), typeof(CustomIcon), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			(bindable as CustomIcon).iconLabel.set_TextColor((Color)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label iconLabel;

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

		public string FontFamily
		{
			get
			{
				return (string)((BindableObject)this).GetValue(FontFamilyProperty);
			}
			set
			{
				((BindableObject)this).SetValue(FontFamilyProperty, (object)value);
			}
		}

		public Color Color
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				return (Color)((BindableObject)this).GetValue(ColorProperty);
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				((BindableObject)this).SetValue(ColorProperty, (object)value);
			}
		}

		public CustomIcon()
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
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_016a: Expected O, but got Unknown
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected O, but got Unknown
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			//IL_01ed: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(CustomIcon).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/CustomIcon.xaml");
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
			Label val2 = new Label();
			StackLayout val3 = new StackLayout();
			CustomIcon customIcon;
			NameScope val4 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(customIcon = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)customIcon, (INameScope)(object)val4);
			((INameScope)val4).RegisterName("iconLabel", (object)val2);
			if (((Element)val2).get_StyleId() == null)
			{
				((Element)val2).set_StyleId("iconLabel");
			}
			iconLabel = val2;
			((BindableObject)customIcon).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)customIcon).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val3).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val2).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val2).SetValue(Label.TextProperty, (object)"");
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter val5 = new FontSizeConverter();
			XamlServiceProvider val6 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 3];
			array[0] = val2;
			array[1] = val3;
			array[2] = customIcon;
			SimpleValueTargetProvider val7 = new SimpleValueTargetProvider(array, (object)Label.FontSizeProperty, (INameScope)(object)val4);
			object obj = (object)val7;
			val6.Add(typeFromHandle, (object)val7);
			val6.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val8 = new XmlNamespaceResolver();
			val8.Add("", "http://xamarin.com/schemas/2014/forms");
			val8.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val6.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val8, typeof(CustomIcon).GetTypeInfo().Assembly));
			val6.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 76)));
			((BindableObject)val2).SetValue(fontSizeProperty, ((IExtendedTypeConverter)val5).ConvertFromInvariantString("50", (IServiceProvider)val6));
			((BindableObject)val2).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((Layout<View>)(object)val3).get_Children().Add((View)(object)val2);
			((ICollection<View>)((Grid)customIcon).get_Children()).Add((View)(object)val3);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<CustomIcon>(this, typeof(CustomIcon));
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
		}
	}
}
