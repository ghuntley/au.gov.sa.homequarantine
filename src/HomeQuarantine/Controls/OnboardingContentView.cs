using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using System.Xml;
using FFImageLoading.Forms;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Helpers;
using HomeQuarantine.Services.Language;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/OnboardingContentView.xaml")]
	public class OnboardingContentView : StackLayout
	{
		public static readonly BindableProperty HeadingProperty = BindableProperty.Create("Heading", typeof(string), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).headingLabel.set_Text((string)newValue);
			(bindable as OnboardingContentView).permissionLabel.set_Text(ViewModelLocator.Resolve<ILanguageService>().OnboardingPermissionEnabled + (string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).textLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty AddressProperty = BindableProperty.Create("Address", typeof(string), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).addressLabel.set_Text((string)newValue);
			((VisualElement)(bindable as OnboardingContentView).addressContainer).set_IsVisible(true);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create("ButtonText", typeof(string), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).button.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ColourProperty = BindableProperty.Create("Colour", typeof(Color), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			((VisualElement)(bindable as OnboardingContentView).button).set_BackgroundColor((Color)newValue);
			(bindable as OnboardingContentView).border.set_Color((Color)newValue);
			(bindable as OnboardingContentView).indicator.Colour = (Color)newValue;
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSource", typeof(string), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			((CachedImage)(bindable as OnboardingContentView).image).set_Source(ImageSource.op_Implicit((string)newValue));
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty PermissionEnabledProperty = BindableProperty.Create("PermissionEnabled", typeof(bool), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			((VisualElement)(bindable as OnboardingContentView).permissionContainer).set_IsVisible((bool)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty CurrentPageProperty = BindableProperty.Create("CurrentPage", typeof(OnboardingType), typeof(OnboardingIndicatorView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).indicator.CurrentPage = (OnboardingType)newValue;
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty OnClickCommandProperty = BindableProperty.Create("OnClickCommand", typeof(AsyncCommand), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).button.set_Command((ICommand)(AsyncCommand)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty AddressHelpPageProperty = BindableProperty.Create("AddressHelpPage", typeof(string), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).addressPageLabel.set_Text((string)newValue);
			((VisualElement)(bindable as OnboardingContentView).addressHelpPageContainer).set_IsVisible(true);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty OnClickAddressHelpCommandProperty = BindableProperty.Create("OnClickAddressHelpCommand", typeof(AsyncCommand), typeof(OnboardingContentView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as OnboardingContentView).TapGesture.set_Command((ICommand)(AsyncCommand)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label headingLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TintedCachedImage image;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout addressContainer;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label addressLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Button button;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout permissionContainer;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label permissionLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout addressHelpPageContainer;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label addressPageLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TapGestureRecognizer TapGesture;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private OnboardingIndicatorView indicator;

		public string Heading
		{
			get
			{
				return (string)((BindableObject)this).GetValue(HeadingProperty);
			}
			set
			{
				((BindableObject)this).SetValue(HeadingProperty, (object)value);
			}
		}

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

		public string ButtonText
		{
			get
			{
				return (string)((BindableObject)this).GetValue(ButtonTextProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ButtonTextProperty, (object)value);
			}
		}

		public Color Colour
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				return (Color)((BindableObject)this).GetValue(ColourProperty);
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				((BindableObject)this).SetValue(ColourProperty, (object)value);
			}
		}

		public string ImageSource
		{
			get
			{
				return (string)((BindableObject)this).GetValue(ImageSourceProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ImageSourceProperty, (object)value);
			}
		}

		public string Address
		{
			get
			{
				return (string)((BindableObject)this).GetValue(AddressProperty);
			}
			set
			{
				((BindableObject)this).SetValue(AddressProperty, (object)value);
			}
		}

		public bool PermissionEnabled
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(PermissionEnabledProperty);
			}
			set
			{
				((BindableObject)this).SetValue(PermissionEnabledProperty, (object)value);
			}
		}

		public OnboardingType CurrentPage
		{
			get
			{
				return (OnboardingType)((BindableObject)this).GetValue(CurrentPageProperty);
			}
			set
			{
				((BindableObject)this).SetValue(CurrentPageProperty, (object)value);
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

		public string AddressHelpPage
		{
			get
			{
				return (string)((BindableObject)this).GetValue(AddressHelpPageProperty);
			}
			set
			{
				((BindableObject)this).SetValue(AddressHelpPageProperty, (object)value);
			}
		}

		public IAsyncCommand OnClickAddressHelpCommand
		{
			get
			{
				return (AsyncCommand)((BindableObject)this).GetValue(OnClickAddressHelpCommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(OnClickAddressHelpCommandProperty, (object)value);
			}
		}

		public OnboardingContentView()
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
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Expected O, but got Unknown
			//IL_041c: Expected O, but got Unknown
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Expected O, but got Unknown
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Expected O, but got Unknown
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_049b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Expected O, but got Unknown
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected O, but got Unknown
			//IL_04af: Expected O, but got Unknown
			//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Expected O, but got Unknown
			//IL_0535: Expected O, but got Unknown
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a0: Expected O, but got Unknown
			//IL_059b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Expected O, but got Unknown
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Expected O, but got Unknown
			//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c3: Expected O, but got Unknown
			//IL_05c8: Expected O, but got Unknown
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0666: Unknown result type (might be due to invalid IL or missing references)
			//IL_068e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0719: Unknown result type (might be due to invalid IL or missing references)
			//IL_073d: Unknown result type (might be due to invalid IL or missing references)
			//IL_078e: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_080a: Unknown result type (might be due to invalid IL or missing references)
			//IL_080f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Expected O, but got Unknown
			//IL_0817: Expected O, but got Unknown
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_0829: Unknown result type (might be due to invalid IL or missing references)
			//IL_0834: Unknown result type (might be due to invalid IL or missing references)
			//IL_0839: Unknown result type (might be due to invalid IL or missing references)
			//IL_0849: Unknown result type (might be due to invalid IL or missing references)
			//IL_0859: Unknown result type (might be due to invalid IL or missing references)
			//IL_0882: Expected O, but got Unknown
			//IL_087d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Expected O, but got Unknown
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a0: Expected O, but got Unknown
			//IL_089b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a5: Expected O, but got Unknown
			//IL_08aa: Expected O, but got Unknown
			//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0900: Unknown result type (might be due to invalid IL or missing references)
			//IL_0903: Expected O, but got Unknown
			//IL_0908: Expected O, but got Unknown
			//IL_0908: Unknown result type (might be due to invalid IL or missing references)
			//IL_091a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Unknown result type (might be due to invalid IL or missing references)
			//IL_092a: Unknown result type (might be due to invalid IL or missing references)
			//IL_093a: Unknown result type (might be due to invalid IL or missing references)
			//IL_094a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0973: Expected O, but got Unknown
			//IL_096e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0978: Expected O, but got Unknown
			//IL_0978: Unknown result type (might be due to invalid IL or missing references)
			//IL_0987: Unknown result type (might be due to invalid IL or missing references)
			//IL_0991: Expected O, but got Unknown
			//IL_098c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0996: Expected O, but got Unknown
			//IL_099b: Expected O, but got Unknown
			//IL_09df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a58: Expected O, but got Unknown
			//IL_0a5d: Expected O, but got Unknown
			//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac8: Expected O, but got Unknown
			//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acd: Expected O, but got Unknown
			//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae6: Expected O, but got Unknown
			//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aeb: Expected O, but got Unknown
			//IL_0af0: Expected O, but got Unknown
			//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c28: Expected O, but got Unknown
			//IL_0c2d: Expected O, but got Unknown
			//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c98: Expected O, but got Unknown
			//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9d: Expected O, but got Unknown
			//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb6: Expected O, but got Unknown
			//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbb: Expected O, but got Unknown
			//IL_0cc0: Expected O, but got Unknown
			//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d19: Expected O, but got Unknown
			//IL_0d1e: Expected O, but got Unknown
			//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d89: Expected O, but got Unknown
			//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8e: Expected O, but got Unknown
			//IL_0d8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da7: Expected O, but got Unknown
			//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dac: Expected O, but got Unknown
			//IL_0db1: Expected O, but got Unknown
			//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef0: Expected O, but got Unknown
			//IL_0ef5: Expected O, but got Unknown
			//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f60: Expected O, but got Unknown
			//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f65: Expected O, but got Unknown
			//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7e: Expected O, but got Unknown
			//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f83: Expected O, but got Unknown
			//IL_0f88: Expected O, but got Unknown
			//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
			//IL_102b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1030: Unknown result type (might be due to invalid IL or missing references)
			//IL_1033: Expected O, but got Unknown
			//IL_1038: Expected O, but got Unknown
			//IL_1038: Unknown result type (might be due to invalid IL or missing references)
			//IL_104a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1055: Unknown result type (might be due to invalid IL or missing references)
			//IL_105a: Unknown result type (might be due to invalid IL or missing references)
			//IL_106a: Unknown result type (might be due to invalid IL or missing references)
			//IL_107a: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a3: Expected O, but got Unknown
			//IL_109e: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a8: Expected O, but got Unknown
			//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c1: Expected O, but got Unknown
			//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c6: Expected O, but got Unknown
			//IL_10cb: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(OnboardingContentView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/OnboardingContentView.xaml");
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
			BoxView val3 = new BoxView();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			Label val5 = new Label();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val6 = new StackLayout();
			Label val7 = new Label();
			StaticResourceExtension val8 = new StaticResourceExtension();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			Label val10 = new Label();
			Label val11 = new Label();
			StackLayout val12 = new StackLayout();
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			Button val14 = new Button();
			StaticResourceExtension val15 = new StaticResourceExtension();
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			Label val17 = new Label();
			Label val18 = new Label();
			StackLayout val19 = new StackLayout();
			DynamicResourceExtension val20 = new DynamicResourceExtension();
			TapGestureRecognizer val21 = new TapGestureRecognizer();
			Label val22 = new Label();
			StaticResourceExtension val23 = new StaticResourceExtension();
			Label val24 = new Label();
			StackLayout val25 = new StackLayout();
			BindingExtension val26 = new BindingExtension();
			OnboardingIndicatorView onboardingIndicatorView = new OnboardingIndicatorView();
			StackLayout val27 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			OnboardingContentView onboardingContentView;
			NameScope val28 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(onboardingContentView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)onboardingContentView, (INameScope)(object)val28);
			((INameScope)val28).RegisterName("border", (object)val3);
			if (((Element)val3).get_StyleId() == null)
			{
				((Element)val3).set_StyleId("border");
			}
			((INameScope)val28).RegisterName("headingLabel", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("headingLabel");
			}
			((INameScope)val28).RegisterName("image", (object)tintedCachedImage);
			if (((Element)tintedCachedImage).get_StyleId() == null)
			{
				((Element)tintedCachedImage).set_StyleId("image");
			}
			((INameScope)val28).RegisterName("textLabel", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("textLabel");
			}
			((INameScope)val28).RegisterName("addressContainer", (object)val12);
			if (((Element)val12).get_StyleId() == null)
			{
				((Element)val12).set_StyleId("addressContainer");
			}
			((INameScope)val28).RegisterName("addressLabel", (object)val11);
			if (((Element)val11).get_StyleId() == null)
			{
				((Element)val11).set_StyleId("addressLabel");
			}
			((INameScope)val28).RegisterName("button", (object)val14);
			if (((Element)val14).get_StyleId() == null)
			{
				((Element)val14).set_StyleId("button");
			}
			((INameScope)val28).RegisterName("permissionContainer", (object)val19);
			if (((Element)val19).get_StyleId() == null)
			{
				((Element)val19).set_StyleId("permissionContainer");
			}
			((INameScope)val28).RegisterName("permissionLabel", (object)val18);
			if (((Element)val18).get_StyleId() == null)
			{
				((Element)val18).set_StyleId("permissionLabel");
			}
			((INameScope)val28).RegisterName("addressHelpPageContainer", (object)val25);
			if (((Element)val25).get_StyleId() == null)
			{
				((Element)val25).set_StyleId("addressHelpPageContainer");
			}
			((INameScope)val28).RegisterName("addressPageLabel", (object)val22);
			if (((Element)val22).get_StyleId() == null)
			{
				((Element)val22).set_StyleId("addressPageLabel");
			}
			((INameScope)val28).RegisterName("TapGesture", (object)val21);
			if (((Element)val21).get_StyleId() == null)
			{
				((Element)val21).set_StyleId("TapGesture");
			}
			((INameScope)val28).RegisterName("indicator", (object)onboardingIndicatorView);
			if (((Element)onboardingIndicatorView).get_StyleId() == null)
			{
				((Element)onboardingIndicatorView).set_StyleId("indicator");
			}
			border = val3;
			headingLabel = val5;
			image = tintedCachedImage;
			textLabel = val7;
			addressContainer = val12;
			addressLabel = val11;
			button = val14;
			permissionContainer = val19;
			permissionLabel = val18;
			addressHelpPageContainer = val25;
			addressPageLabel = val22;
			TapGesture = val21;
			indicator = onboardingIndicatorView;
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val29 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = shadowFrame;
			array[1] = onboardingContentView;
			SimpleValueTargetProvider val30 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val28);
			object obj = (object)val30;
			val29.Add(typeFromHandle, (object)val30);
			val29.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val31 = new XmlNamespaceResolver();
			val31.Add("", "http://xamarin.com/schemas/2014/forms");
			val31.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val31.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val29.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val31, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(13, 9)));
			DynamicResource val32 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val29);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val32.get_Key());
			((BindableObject)val3).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val3);
			val4.set_Key("Heading1");
			XamlServiceProvider val33 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 4];
			array2[0] = val5;
			array2[1] = val27;
			array2[2] = shadowFrame;
			array2[3] = onboardingContentView;
			SimpleValueTargetProvider val34 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val28);
			object obj2 = (object)val34;
			val33.Add(typeFromHandle3, (object)val34);
			val33.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val35 = new XmlNamespaceResolver();
			val35.Add("", "http://xamarin.com/schemas/2014/forms");
			val35.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val35.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val33.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val35, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val33.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 17)));
			DynamicResource val36 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val33);
			((IDynamicResourceHandler)val5).SetDynamicResource(VisualElement.StyleProperty, val36.get_Key());
			((BindableObject)val5).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 24.0));
			((BindableObject)val5).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val5);
			((BindableObject)val6).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)tintedCachedImage).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((Layout<View>)(object)val6).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val6);
			((BindableObject)val7).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val7).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val7);
			((BindableObject)val12).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((BindableObject)val12).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val12).SetValue(View.MarginProperty, (object)new Thickness(32.0, 8.0, 16.0, 0.0));
			((BindableObject)val12).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val10).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			val8.set_Key("faMapMarkerAlt");
			XamlServiceProvider val37 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 5];
			array3[0] = val10;
			array3[1] = val12;
			array3[2] = val27;
			array3[3] = shadowFrame;
			array3[4] = onboardingContentView;
			SimpleValueTargetProvider val38 = new SimpleValueTargetProvider(array3, (object)Label.TextProperty, (INameScope)(object)val28);
			object obj3 = (object)val38;
			val37.Add(typeFromHandle5, (object)val38);
			val37.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val39 = new XmlNamespaceResolver();
			val39.Add("", "http://xamarin.com/schemas/2014/forms");
			val39.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val39.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val37.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val39, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 21)));
			object text = ((IMarkupExtension)val8).ProvideValue((IServiceProvider)val37);
			val10.set_Text((string)text);
			val9.set_Key("PrimaryColor");
			XamlServiceProvider val40 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 5];
			array4[0] = val10;
			array4[1] = val12;
			array4[2] = val27;
			array4[3] = shadowFrame;
			array4[4] = onboardingContentView;
			SimpleValueTargetProvider val41 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val28);
			object obj4 = (object)val41;
			val40.Add(typeFromHandle7, (object)val41);
			val40.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val42 = new XmlNamespaceResolver();
			val42.Add("", "http://xamarin.com/schemas/2014/forms");
			val42.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val42.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val40.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val42, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val40.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 21)));
			DynamicResource val43 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val40);
			((IDynamicResourceHandler)val10).SetDynamicResource(Label.TextColorProperty, val43.get_Key());
			((BindableObject)val10).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
			((Layout<View>)(object)val12).get_Children().Add((View)(object)val10);
			((BindableObject)val11).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val12).get_Children().Add((View)(object)val11);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val12);
			val13.set_Key("LargeButtonStyle");
			XamlServiceProvider val44 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 4];
			array5[0] = val14;
			array5[1] = val27;
			array5[2] = shadowFrame;
			array5[3] = onboardingContentView;
			SimpleValueTargetProvider val45 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val28);
			object obj5 = (object)val45;
			val44.Add(typeFromHandle9, (object)val45);
			val44.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val46 = new XmlNamespaceResolver();
			val46.Add("", "http://xamarin.com/schemas/2014/forms");
			val46.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val46.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val44.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val46, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val44.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 17)));
			DynamicResource val47 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val44);
			((IDynamicResourceHandler)val14).SetDynamicResource(VisualElement.StyleProperty, val47.get_Key());
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(32.0));
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val14);
			((BindableObject)val19).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((BindableObject)val19).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val19).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val19).SetValue(StackLayout.SpacingProperty, (object)8.0);
			((BindableObject)val19).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 32.0));
			((BindableObject)val17).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			val15.set_Key("faCheckCircle");
			XamlServiceProvider val48 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 5];
			array6[0] = val17;
			array6[1] = val19;
			array6[2] = val27;
			array6[3] = shadowFrame;
			array6[4] = onboardingContentView;
			SimpleValueTargetProvider val49 = new SimpleValueTargetProvider(array6, (object)Label.TextProperty, (INameScope)(object)val28);
			object obj6 = (object)val49;
			val48.Add(typeFromHandle11, (object)val49);
			val48.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val50 = new XmlNamespaceResolver();
			val50.Add("", "http://xamarin.com/schemas/2014/forms");
			val50.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val50.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val48.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val50, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val48.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 42)));
			object text2 = ((IMarkupExtension)val15).ProvideValue((IServiceProvider)val48);
			val17.set_Text((string)text2);
			val16.set_Key("SuccessColor");
			XamlServiceProvider val51 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 5];
			array7[0] = val17;
			array7[1] = val19;
			array7[2] = val27;
			array7[3] = shadowFrame;
			array7[4] = onboardingContentView;
			SimpleValueTargetProvider val52 = new SimpleValueTargetProvider(array7, (object)Label.TextColorProperty, (INameScope)(object)val28);
			object obj7 = (object)val52;
			val51.Add(typeFromHandle13, (object)val52);
			val51.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val53 = new XmlNamespaceResolver();
			val53.Add("", "http://xamarin.com/schemas/2014/forms");
			val53.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val53.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val51.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val53, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val51.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 80)));
			DynamicResource val54 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val51);
			((IDynamicResourceHandler)val17).SetDynamicResource(Label.TextColorProperty, val54.get_Key());
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val17);
			((BindableObject)val18).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val19);
			((BindableObject)val25).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((BindableObject)val25).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val25).SetValue(StackLayout.SpacingProperty, (object)10.0);
			((BindableObject)val25).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 32.0));
			((BindableObject)val25).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			val20.set_Key("Small");
			XamlServiceProvider val55 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 5];
			array8[0] = val22;
			array8[1] = val25;
			array8[2] = val27;
			array8[3] = shadowFrame;
			array8[4] = onboardingContentView;
			SimpleValueTargetProvider val56 = new SimpleValueTargetProvider(array8, (object)VisualElement.StyleProperty, (INameScope)(object)val28);
			object obj8 = (object)val56;
			val55.Add(typeFromHandle15, (object)val56);
			val55.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val57 = new XmlNamespaceResolver();
			val57.Add("", "http://xamarin.com/schemas/2014/forms");
			val57.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val57.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val55.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val57, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val55.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(83, 21)));
			DynamicResource val58 = ((IMarkupExtension<DynamicResource>)(object)val20).ProvideValue((IServiceProvider)val55);
			((IDynamicResourceHandler)val22).SetDynamicResource(VisualElement.StyleProperty, val58.get_Key());
			((BindableObject)val22).SetValue(Label.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			((View)val22).get_GestureRecognizers().Add((IGestureRecognizer)(object)val21);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val22);
			((BindableObject)val24).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			val23.set_Key("faQuestionCircle");
			XamlServiceProvider val59 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 5];
			array9[0] = val24;
			array9[1] = val25;
			array9[2] = val27;
			array9[3] = shadowFrame;
			array9[4] = onboardingContentView;
			SimpleValueTargetProvider val60 = new SimpleValueTargetProvider(array9, (object)Label.TextProperty, (INameScope)(object)val28);
			object obj9 = (object)val60;
			val59.Add(typeFromHandle17, (object)val60);
			val59.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val61 = new XmlNamespaceResolver();
			val61.Add("", "http://xamarin.com/schemas/2014/forms");
			val61.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val61.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val59.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val61, typeof(OnboardingContentView).GetTypeInfo().Assembly));
			val59.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(89, 42)));
			object text3 = ((IMarkupExtension)val23).ProvideValue((IServiceProvider)val59);
			val24.set_Text((string)text3);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val24);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val25);
			val26.set_Path("IsIndicatorVisible");
			BindingBase val62 = ((IMarkupExtension<BindingBase>)(object)val26).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingIndicatorView).SetBinding(VisualElement.IsVisibleProperty, val62);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)onboardingIndicatorView);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val27);
			((Layout<View>)(object)onboardingContentView).get_Children().Add((View)(object)shadowFrame);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<OnboardingContentView>(this, typeof(OnboardingContentView));
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			headingLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "headingLabel");
			image = NameScopeExtensions.FindByName<TintedCachedImage>((Element)(object)this, "image");
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			addressContainer = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "addressContainer");
			addressLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "addressLabel");
			button = NameScopeExtensions.FindByName<Button>((Element)(object)this, "button");
			permissionContainer = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "permissionContainer");
			permissionLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "permissionLabel");
			addressHelpPageContainer = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "addressHelpPageContainer");
			addressPageLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "addressPageLabel");
			TapGesture = NameScopeExtensions.FindByName<TapGestureRecognizer>((Element)(object)this, "TapGesture");
			indicator = NameScopeExtensions.FindByName<OnboardingIndicatorView>((Element)(object)this, "indicator");
		}
	}
}
