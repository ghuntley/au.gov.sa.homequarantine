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
	[XamlFilePath("Controls/CheckboxLabelView.xaml")]
	public class CheckboxLabelView : StackLayout
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CheckboxLabelView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as CheckboxLabelView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(CheckboxLabelView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as CheckboxLabelView).checkBox.set_IsChecked((bool)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private CheckBox checkBox;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

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

		public CheckboxLabelView()
			: this()
		{
			InitializeComponent();
		}

		private void SetChecked(object sender, EventArgs args)
		{
			IsChecked = !IsChecked;
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
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_0194: Expected O, but got Unknown
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected O, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			//IL_0217: Expected O, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(CheckboxLabelView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/CheckboxLabelView.xaml");
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
			CheckBox val2 = new CheckBox();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			TapGestureRecognizer val4 = new TapGestureRecognizer();
			Label val5 = new Label();
			CheckboxLabelView checkboxLabelView;
			NameScope val6 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(checkboxLabelView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)checkboxLabelView, (INameScope)(object)val6);
			((INameScope)val6).RegisterName("checkBox", (object)val2);
			if (((Element)val2).get_StyleId() == null)
			{
				((Element)val2).set_StyleId("checkBox");
			}
			((INameScope)val6).RegisterName("textLabel", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("textLabel");
			}
			checkBox = val2;
			textLabel = val5;
			((BindableObject)checkboxLabelView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)checkboxLabelView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)checkboxLabelView).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val2).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			((Layout<View>)(object)checkboxLabelView).get_Children().Add((View)(object)val2);
			val3.set_Key("Body");
			XamlServiceProvider val7 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = val5;
			array[1] = checkboxLabelView;
			SimpleValueTargetProvider val8 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val6);
			object obj = (object)val8;
			val7.Add(typeFromHandle, (object)val8);
			val7.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val9 = new XmlNamespaceResolver();
			val9.Add("", "http://xamarin.com/schemas/2014/forms");
			val9.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val7.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val9, typeof(CheckboxLabelView).GetTypeInfo().Assembly));
			val7.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 9)));
			DynamicResource val10 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val7);
			((IDynamicResourceHandler)val5).SetDynamicResource(VisualElement.StyleProperty, val10.get_Key());
			((BindableObject)val5).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val5).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val4.add_Tapped((EventHandler)checkboxLabelView.SetChecked);
			((BindableObject)val4).SetValue(TapGestureRecognizer.NumberOfTapsRequiredProperty, (object)1);
			((View)val5).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((Layout<View>)(object)checkboxLabelView).get_Children().Add((View)(object)val5);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<CheckboxLabelView>(this, typeof(CheckboxLabelView));
			checkBox = NameScopeExtensions.FindByName<CheckBox>((Element)(object)this, "checkBox");
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
		}
	}
}
