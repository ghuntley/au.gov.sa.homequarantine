using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Data.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/AccordionView.xaml")]
	public class AccordionView : StackLayout
	{
		public static readonly BindableProperty HeadingProperty = BindableProperty.Create("Heading", typeof(string), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as AccordionView).heading.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(List<string>), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			foreach (string item in (List<string>)newValue)
			{
				IList<View> children4 = ((Layout<View>)(object)(bindable as AccordionView).content).get_Children();
				Label val7 = new Label();
				val7.set_Text(item);
				children4.Add((View)val7);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create("IsExpanded", typeof(bool), typeof(AccordionView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as AccordionView).icon.set_Text(((bool)newValue) ? ((string)Application.get_Current().get_Resources().get_Item("faMinus")) : ((string)Application.get_Current().get_Resources().get_Item("faPlus")));
			((VisualElement)(bindable as AccordionView).contentStack).set_IsVisible((bool)newValue);
			((VisualElement)(bindable as AccordionView).borderLine).set_HeightRequest((double)((!(bool)newValue) ? 1 : 3));
			((Element)(bindable as AccordionView).heading).SetDynamicResource(Label.TextColorProperty, ((bool)newValue) ? "PrimaryTextColor" : "SecondaryTextColor");
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty InformationResourceLinkButtonProperty = BindableProperty.Create("InformationResourceLinkButton", typeof(List<InformationResourceLinkButtonModel>), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			foreach (InformationResourceLinkButtonModel item2 in (List<InformationResourceLinkButtonModel>)newValue)
			{
				IList<View> children3 = ((Layout<View>)(object)(bindable as AccordionView).linkGroupStack).get_Children();
				InformationResourceLinkButtonView obj = new InformationResourceLinkButtonView
				{
					Text = item2.Label,
					IsUrl = item2.IsUrl
				};
				((VisualElement)obj).set_IsVisible(true);
				obj.Url = item2.Url;
				children3.Add((View)(object)obj);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty CallButtonProperty = BindableProperty.Create("CallButton", typeof(CallButtonModel), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			CallButtonModel callButtonModel = (CallButtonModel)newValue;
			(bindable as AccordionView).callButton.Text = callButtonModel.Text;
			((VisualElement)(bindable as AccordionView).callButton).set_IsVisible(true);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty TextMessageButtonProperty = BindableProperty.Create("TextMessageButtonProperty", typeof(TextMessageButtonModel), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			TextMessageButtonModel textMessageButtonModel = (TextMessageButtonModel)newValue;
			(bindable as AccordionView).textButton.Number = textMessageButtonModel.Number;
			((VisualElement)(bindable as AccordionView).textButton).set_IsVisible(true);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ReasonsProperty = BindableProperty.Create("Reasons", typeof(List<string>), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			foreach (string item3 in (List<string>)newValue)
			{
				StackLayout val2 = new StackLayout();
				val2.set_Orientation((StackOrientation)1);
				((View)val2).set_Margin(new Thickness(16.0, 0.0));
				StackLayout val3 = val2;
				BoxView val4 = new BoxView();
				val4.set_CornerRadius(CornerRadius.op_Implicit(3.0));
				((VisualElement)val4).set_WidthRequest(6.0);
				((VisualElement)val4).set_HeightRequest(6.0);
				((View)val4).set_Margin(new Thickness(0.0, 14.0, 0.0, 0.0));
				((View)val4).set_VerticalOptions(LayoutOptions.Start);
				BoxView val5 = val4;
				((Element)val5).SetDynamicResource(BoxView.ColorProperty, "SecondaryTextColor");
				((Layout<View>)(object)val3).get_Children().Add((View)(object)val5);
				IList<View> children2 = ((Layout<View>)(object)val3).get_Children();
				Label val6 = new Label();
				val6.set_Text(item3);
				((View)val6).set_Margin(new Thickness(16.0, 6.0, 16.0, 0.0));
				children2.Add((View)val6);
				((Layout<View>)(object)(bindable as AccordionView).reasons).get_Children().Add((View)(object)val3);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty OtherContentProperty = BindableProperty.Create("OtherContent", typeof(List<string>), typeof(AccordionView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			foreach (string item4 in (List<string>)newValue)
			{
				IList<View> children = ((Layout<View>)(object)(bindable as AccordionView).otherContent).get_Children();
				Label val = new Label();
				val.set_Text(item4);
				((View)val).set_Margin(new Thickness(16.0, 0.0, 16.0, 16.0));
				children.Add((View)val);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Grid headingStack;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label heading;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label icon;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView borderLine;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout contentStack;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout content;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout reasons;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private CallButtonView callButton;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TextMessageButtonView textButton;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout linkGroupStack;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout otherContent;

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

		public List<string> Content
		{
			get
			{
				return (List<string>)((BindableObject)this).GetValue(ContentProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ContentProperty, (object)value);
			}
		}

		public bool IsExpanded
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsExpandedProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsExpandedProperty, (object)value);
			}
		}

		public List<InformationResourceLinkButtonModel> InformationResourceLinkButton
		{
			get
			{
				return (List<InformationResourceLinkButtonModel>)((BindableObject)this).GetValue(InformationResourceLinkButtonProperty);
			}
			set
			{
				((BindableObject)this).SetValue(InformationResourceLinkButtonProperty, (object)value);
			}
		}

		public CallButtonModel CallButton
		{
			get
			{
				return (CallButtonModel)((BindableObject)this).GetValue(CallButtonProperty);
			}
			set
			{
				((BindableObject)this).SetValue(CallButtonProperty, (object)value);
			}
		}

		public TextMessageButtonModel TextMessageButton
		{
			get
			{
				return (TextMessageButtonModel)((BindableObject)this).GetValue(TextMessageButtonProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TextMessageButtonProperty, (object)value);
			}
		}

		public List<string> Reasons
		{
			get
			{
				return (List<string>)((BindableObject)this).GetValue(ReasonsProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ReasonsProperty, (object)value);
			}
		}

		public List<string> OtherContent
		{
			get
			{
				return (List<string>)((BindableObject)this).GetValue(OtherContentProperty);
			}
			set
			{
				((BindableObject)this).SetValue(OtherContentProperty, (object)value);
			}
		}

		public AccordionView()
			: this()
		{
			InitializeComponent();
		}

		private void SetExpanded(object sender, EventArgs args)
		{
			IsExpanded = !IsExpanded;
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
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Expected O, but got Unknown
			//IL_0481: Expected O, but got Unknown
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Expected O, but got Unknown
			//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f1: Expected O, but got Unknown
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Expected O, but got Unknown
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Expected O, but got Unknown
			//IL_0514: Expected O, but got Unknown
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0585: Unknown result type (might be due to invalid IL or missing references)
			//IL_058a: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Expected O, but got Unknown
			//IL_0592: Expected O, but got Unknown
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Expected O, but got Unknown
			//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Expected O, but got Unknown
			//IL_0602: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Expected O, but got Unknown
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_0620: Expected O, but got Unknown
			//IL_0625: Expected O, but got Unknown
			//IL_0641: Unknown result type (might be due to invalid IL or missing references)
			//IL_0657: Unknown result type (might be due to invalid IL or missing references)
			//IL_069c: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d2: Expected O, but got Unknown
			//IL_06d7: Expected O, but got Unknown
			//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0709: Unknown result type (might be due to invalid IL or missing references)
			//IL_0719: Unknown result type (might be due to invalid IL or missing references)
			//IL_0742: Expected O, but got Unknown
			//IL_073d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0747: Expected O, but got Unknown
			//IL_0747: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Unknown result type (might be due to invalid IL or missing references)
			//IL_0760: Expected O, but got Unknown
			//IL_075b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0765: Expected O, but got Unknown
			//IL_076a: Expected O, but got Unknown
			//IL_079f: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d0: Expected O, but got Unknown
			//IL_07d5: Expected O, but got Unknown
			//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_0840: Expected O, but got Unknown
			//IL_083b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0845: Expected O, but got Unknown
			//IL_0845: Unknown result type (might be due to invalid IL or missing references)
			//IL_0854: Unknown result type (might be due to invalid IL or missing references)
			//IL_085e: Expected O, but got Unknown
			//IL_0859: Unknown result type (might be due to invalid IL or missing references)
			//IL_0863: Expected O, but got Unknown
			//IL_0868: Expected O, but got Unknown
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_091f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0924: Unknown result type (might be due to invalid IL or missing references)
			//IL_0927: Expected O, but got Unknown
			//IL_092c: Expected O, but got Unknown
			//IL_092c: Unknown result type (might be due to invalid IL or missing references)
			//IL_093e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0949: Unknown result type (might be due to invalid IL or missing references)
			//IL_094e: Unknown result type (might be due to invalid IL or missing references)
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_096e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0997: Expected O, but got Unknown
			//IL_0992: Unknown result type (might be due to invalid IL or missing references)
			//IL_099c: Expected O, but got Unknown
			//IL_099c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b5: Expected O, but got Unknown
			//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ba: Expected O, but got Unknown
			//IL_09bf: Expected O, but got Unknown
			//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(AccordionView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/AccordionView.xaml");
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
			TapGestureRecognizer val4 = new TapGestureRecognizer();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			Label val6 = new Label();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			StaticResourceExtension val8 = new StaticResourceExtension();
			Label val9 = new Label();
			Grid val10 = new Grid();
			DynamicResourceExtension val11 = new DynamicResourceExtension();
			BoxView val12 = new BoxView();
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			StackLayout val14 = new StackLayout();
			StackLayout val15 = new StackLayout();
			CallButtonView callButtonView = new CallButtonView();
			TextMessageButtonView textMessageButtonView = new TextMessageButtonView();
			StackLayout val16 = new StackLayout();
			StackLayout val17 = new StackLayout();
			StackLayout val18 = new StackLayout();
			StackLayout val19 = new StackLayout();
			AccordionView accordionView;
			NameScope val20 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(accordionView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)accordionView, (INameScope)(object)val20);
			((INameScope)val20).RegisterName("headingStack", (object)val10);
			if (((Element)val10).get_StyleId() == null)
			{
				((Element)val10).set_StyleId("headingStack");
			}
			((INameScope)val20).RegisterName("heading", (object)val6);
			if (((Element)val6).get_StyleId() == null)
			{
				((Element)val6).set_StyleId("heading");
			}
			((INameScope)val20).RegisterName("icon", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("icon");
			}
			((INameScope)val20).RegisterName("borderLine", (object)val12);
			if (((Element)val12).get_StyleId() == null)
			{
				((Element)val12).set_StyleId("borderLine");
			}
			((INameScope)val20).RegisterName("contentStack", (object)val19);
			if (((Element)val19).get_StyleId() == null)
			{
				((Element)val19).set_StyleId("contentStack");
			}
			((INameScope)val20).RegisterName("content", (object)val14);
			if (((Element)val14).get_StyleId() == null)
			{
				((Element)val14).set_StyleId("content");
			}
			((INameScope)val20).RegisterName("reasons", (object)val15);
			if (((Element)val15).get_StyleId() == null)
			{
				((Element)val15).set_StyleId("reasons");
			}
			((INameScope)val20).RegisterName("callButton", (object)callButtonView);
			if (((Element)callButtonView).get_StyleId() == null)
			{
				((Element)callButtonView).set_StyleId("callButton");
			}
			((INameScope)val20).RegisterName("textButton", (object)textMessageButtonView);
			if (((Element)textMessageButtonView).get_StyleId() == null)
			{
				((Element)textMessageButtonView).set_StyleId("textButton");
			}
			((INameScope)val20).RegisterName("linkGroupStack", (object)val16);
			if (((Element)val16).get_StyleId() == null)
			{
				((Element)val16).set_StyleId("linkGroupStack");
			}
			((INameScope)val20).RegisterName("otherContent", (object)val17);
			if (((Element)val17).get_StyleId() == null)
			{
				((Element)val17).set_StyleId("otherContent");
			}
			headingStack = val10;
			heading = val6;
			icon = val9;
			borderLine = val12;
			contentStack = val19;
			content = val14;
			reasons = val15;
			callButton = callButtonView;
			textButton = textMessageButtonView;
			linkGroupStack = val16;
			otherContent = val17;
			((BindableObject)accordionView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)accordionView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)accordionView).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val10).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0, 16.0, 16.0));
			((BindableObject)val10).SetValue(Grid.ColumnSpacingProperty, (object)16.0);
			((BindableObject)val2).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val10).GetValue(Grid.ColumnDefinitionsProperty)).Add(val2);
			((BindableObject)val3).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val10).GetValue(Grid.ColumnDefinitionsProperty)).Add(val3);
			val4.add_Tapped((EventHandler)accordionView.SetExpanded);
			((View)val10).get_GestureRecognizers().Add((IGestureRecognizer)(object)val4);
			((BindableObject)val6).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val6).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val5.set_Key("SecondaryTextColor");
			XamlServiceProvider val21 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 3];
			array[0] = val6;
			array[1] = val10;
			array[2] = accordionView;
			SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array, (object)Label.TextColorProperty, (INameScope)(object)val20);
			object obj = (object)val22;
			val21.Add(typeFromHandle, (object)val22);
			val21.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val23 = new XmlNamespaceResolver();
			val23.Add("", "http://xamarin.com/schemas/2014/forms");
			val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val23.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val21.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(AccordionView).GetTypeInfo().Assembly));
			val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 13)));
			DynamicResource val24 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val21);
			((IDynamicResourceHandler)val6).SetDynamicResource(Label.TextColorProperty, val24.get_Key());
			((BindableObject)val6).SetValue(Grid.ColumnProperty, (object)0);
			((ICollection<View>)val10.get_Children()).Add((View)(object)val6);
			val7.set_Key("SecondaryColor");
			XamlServiceProvider val25 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 3];
			array2[0] = val9;
			array2[1] = val10;
			array2[2] = accordionView;
			SimpleValueTargetProvider val26 = new SimpleValueTargetProvider(array2, (object)Label.TextColorProperty, (INameScope)(object)val20);
			object obj2 = (object)val26;
			val25.Add(typeFromHandle3, (object)val26);
			val25.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val27 = new XmlNamespaceResolver();
			val27.Add("", "http://xamarin.com/schemas/2014/forms");
			val27.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val27.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val25.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val27, typeof(AccordionView).GetTypeInfo().Assembly));
			val25.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(27, 13)));
			DynamicResource val28 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val25);
			((IDynamicResourceHandler)val9).SetDynamicResource(Label.TextColorProperty, val28.get_Key());
			((BindableObject)val9).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val9).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val9).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((BindableObject)val9).SetValue(Grid.ColumnProperty, (object)1);
			val8.set_Key("faPlus");
			XamlServiceProvider val29 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = val9;
			array3[1] = val10;
			array3[2] = accordionView;
			SimpleValueTargetProvider val30 = new SimpleValueTargetProvider(array3, (object)Label.TextProperty, (INameScope)(object)val20);
			object obj3 = (object)val30;
			val29.Add(typeFromHandle5, (object)val30);
			val29.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val31 = new XmlNamespaceResolver();
			val31.Add("", "http://xamarin.com/schemas/2014/forms");
			val31.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val31.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val29.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val31, typeof(AccordionView).GetTypeInfo().Assembly));
			val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 13)));
			object text = ((IMarkupExtension)val8).ProvideValue((IServiceProvider)val29);
			val9.set_Text((string)text);
			((ICollection<View>)val10.get_Children()).Add((View)(object)val9);
			((Layout<View>)(object)accordionView).get_Children().Add((View)(object)val10);
			val11.set_Key("TertiaryTextColor");
			XamlServiceProvider val32 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 2];
			array4[0] = val12;
			array4[1] = accordionView;
			SimpleValueTargetProvider val33 = new SimpleValueTargetProvider(array4, (object)BoxView.ColorProperty, (INameScope)(object)val20);
			object obj4 = (object)val33;
			val32.Add(typeFromHandle7, (object)val33);
			val32.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val34 = new XmlNamespaceResolver();
			val34.Add("", "http://xamarin.com/schemas/2014/forms");
			val34.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val34.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val32.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val34, typeof(AccordionView).GetTypeInfo().Assembly));
			val32.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 9)));
			DynamicResource val35 = ((IMarkupExtension<DynamicResource>)(object)val11).ProvideValue((IServiceProvider)val32);
			((IDynamicResourceHandler)val12).SetDynamicResource(BoxView.ColorProperty, val35.get_Key());
			((BindableObject)val12).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("true"));
			((BindableObject)val12).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
			((BindableObject)val12).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((Layout<View>)(object)accordionView).get_Children().Add((View)(object)val12);
			val13.set_Key("AccordionBackgroundColor");
			XamlServiceProvider val36 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 2];
			array5[0] = val19;
			array5[1] = accordionView;
			SimpleValueTargetProvider val37 = new SimpleValueTargetProvider(array5, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val20);
			object obj5 = (object)val37;
			val36.Add(typeFromHandle9, (object)val37);
			val36.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val38 = new XmlNamespaceResolver();
			val38.Add("", "http://xamarin.com/schemas/2014/forms");
			val38.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val38.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val36.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val38, typeof(AccordionView).GetTypeInfo().Assembly));
			val36.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(45, 9)));
			DynamicResource val39 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val36);
			((IDynamicResourceHandler)val19).SetDynamicResource(VisualElement.BackgroundColorProperty, val39.get_Key());
			((BindableObject)val19).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val19).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((BindableObject)val14).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val14);
			((BindableObject)val15).SetValue(StackLayout.SpacingProperty, (object)8.0);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val15);
			((BindableObject)val18).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)callButtonView).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)callButtonView);
			((BindableObject)textMessageButtonView).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)textMessageButtonView);
			((BindableObject)val16).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val16);
			((BindableObject)val17).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val17);
			((Layout<View>)(object)val19).get_Children().Add((View)(object)val18);
			((Layout<View>)(object)accordionView).get_Children().Add((View)(object)val19);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<AccordionView>(this, typeof(AccordionView));
			headingStack = NameScopeExtensions.FindByName<Grid>((Element)(object)this, "headingStack");
			heading = NameScopeExtensions.FindByName<Label>((Element)(object)this, "heading");
			icon = NameScopeExtensions.FindByName<Label>((Element)(object)this, "icon");
			borderLine = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "borderLine");
			contentStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "contentStack");
			content = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "content");
			reasons = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "reasons");
			callButton = NameScopeExtensions.FindByName<CallButtonView>((Element)(object)this, "callButton");
			textButton = NameScopeExtensions.FindByName<TextMessageButtonView>((Element)(object)this, "textButton");
			linkGroupStack = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "linkGroupStack");
			otherContent = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "otherContent");
		}
	}
}
