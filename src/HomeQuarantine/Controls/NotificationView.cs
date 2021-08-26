using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using System.Xml;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/NotificationView.xaml")]
	public class NotificationView : StackLayout
	{
		public static readonly BindableProperty DateProperty = BindableProperty.Create("Date", typeof(string), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).dateLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).titleLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty DescriptionProperty = BindableProperty.Create("Description", typeof(string), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).descriptionLabel.set_Text((string)newValue);
			((VisualElement)(bindable as NotificationView).descriptionLabel).set_IsVisible(true);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ActionLabelProperty = BindableProperty.Create("ActionLabel", typeof(string), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).actionLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty TapCommandProperty = BindableProperty.Create("TapCommand", typeof(AsyncCommand<NotificationResponse>), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).tapGesture.set_Command((ICommand)(AsyncCommand<NotificationResponse>)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty TapCommandParameterProperty = BindableProperty.Create("TapCommandParameter", typeof(NotificationResponse), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).tapGesture.set_CommandParameter((object)(NotificationResponse)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsFirstProperty = BindableProperty.Create("IsFirst", typeof(bool), typeof(NotificationView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			Thickness padding2 = ((Layout)(bindable as NotificationView)).get_Padding();
			((Layout)(bindable as NotificationView)).set_Padding(new Thickness((double)(((bool)newValue) ? 16 : 4), ((Thickness)(ref padding2)).get_Top(), ((Thickness)(ref padding2)).get_Right(), ((Thickness)(ref padding2)).get_Bottom()));
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty IsLastProperty = BindableProperty.Create("IsLast", typeof(bool), typeof(NotificationView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			if ((bool)newValue)
			{
				Thickness padding = ((Layout)(bindable as NotificationView)).get_Padding();
				((Layout)(bindable as NotificationView)).set_Padding(new Thickness(((Thickness)(ref padding)).get_Left(), ((Thickness)(ref padding)).get_Top(), (double)(((bool)newValue) ? 16 : 4), ((Thickness)(ref padding)).get_Bottom()));
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ClickCommandProperty = BindableProperty.Create("ClickCommand", typeof(AsyncCommand), typeof(NotificationView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as NotificationView).tapGesture.set_Command((ICommand)(AsyncCommand)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ShowBorderProperty = BindableProperty.Create("ShowBorder", typeof(bool), typeof(NotificationView), (object)false, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			((VisualElement)(bindable as NotificationView).border).set_IsVisible((bool)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout notificationLayout;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label dateLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label titleLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label descriptionLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label actionLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TapGestureRecognizer tapGesture;

		public string Date
		{
			get
			{
				return (string)((BindableObject)this).GetValue(DateProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TitleProperty, (object)value);
			}
		}

		public string Title
		{
			get
			{
				return (string)((BindableObject)this).GetValue(TitleProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TitleProperty, (object)value);
			}
		}

		public string Description
		{
			get
			{
				return (string)((BindableObject)this).GetValue(DescriptionProperty);
			}
			set
			{
				((BindableObject)this).SetValue(DescriptionProperty, (object)value);
			}
		}

		public string ActionLabel
		{
			get
			{
				return (string)((BindableObject)this).GetValue(ActionLabelProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ActionLabelProperty, (object)value);
			}
		}

		public IAsyncCommand<NotificationResponse> TapCommand
		{
			get
			{
				return (AsyncCommand<NotificationResponse>)((BindableObject)this).GetValue(TapCommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TapCommandProperty, (object)value);
			}
		}

		public NotificationResponse TapCommandParameter
		{
			get
			{
				return (NotificationResponse)((BindableObject)this).GetValue(TapCommandParameterProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TapCommandParameterProperty, (object)value);
			}
		}

		public bool IsFirst
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsFirstProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsFirstProperty, (object)value);
			}
		}

		public bool IsLast
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsLastProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsLastProperty, (object)value);
			}
		}

		public IAsyncCommand ClickCommand
		{
			get
			{
				return (AsyncCommand)((BindableObject)this).GetValue(ClickCommandProperty);
			}
			set
			{
				((BindableObject)this).SetValue(TapCommandProperty, (object)value);
			}
		}

		public bool ShowBorder
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(ShowBorderProperty);
			}
			set
			{
				((BindableObject)this).SetValue(ShowBorderProperty, (object)value);
			}
		}

		public NotificationView()
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
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected O, but got Unknown
			//IL_02b8: Expected O, but got Unknown
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Expected O, but got Unknown
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected O, but got Unknown
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected O, but got Unknown
			//IL_034b: Expected O, but got Unknown
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Expected O, but got Unknown
			//IL_042a: Expected O, but got Unknown
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Expected O, but got Unknown
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Expected O, but got Unknown
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Expected O, but got Unknown
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b8: Expected O, but got Unknown
			//IL_04bd: Expected O, but got Unknown
			//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0585: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_062e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_0666: Unknown result type (might be due to invalid IL or missing references)
			//IL_066b: Unknown result type (might be due to invalid IL or missing references)
			//IL_066e: Expected O, but got Unknown
			//IL_0673: Expected O, but got Unknown
			//IL_0673: Unknown result type (might be due to invalid IL or missing references)
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_0695: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06de: Expected O, but got Unknown
			//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e3: Expected O, but got Unknown
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fc: Expected O, but got Unknown
			//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0701: Expected O, but got Unknown
			//IL_0706: Expected O, but got Unknown
			//IL_0734: Unknown result type (might be due to invalid IL or missing references)
			//IL_0761: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_081d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0822: Unknown result type (might be due to invalid IL or missing references)
			//IL_0825: Expected O, but got Unknown
			//IL_082a: Expected O, but got Unknown
			//IL_082a: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0847: Unknown result type (might be due to invalid IL or missing references)
			//IL_084c: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_086c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0895: Expected O, but got Unknown
			//IL_0890: Unknown result type (might be due to invalid IL or missing references)
			//IL_089a: Expected O, but got Unknown
			//IL_089a: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b3: Expected O, but got Unknown
			//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b8: Expected O, but got Unknown
			//IL_08bd: Expected O, but got Unknown
			//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0913: Unknown result type (might be due to invalid IL or missing references)
			//IL_0918: Unknown result type (might be due to invalid IL or missing references)
			//IL_091b: Expected O, but got Unknown
			//IL_0920: Expected O, but got Unknown
			//IL_0920: Unknown result type (might be due to invalid IL or missing references)
			//IL_0932: Unknown result type (might be due to invalid IL or missing references)
			//IL_093d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0942: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_0962: Unknown result type (might be due to invalid IL or missing references)
			//IL_098b: Expected O, but got Unknown
			//IL_0986: Unknown result type (might be due to invalid IL or missing references)
			//IL_0990: Expected O, but got Unknown
			//IL_0990: Unknown result type (might be due to invalid IL or missing references)
			//IL_099f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a9: Expected O, but got Unknown
			//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ae: Expected O, but got Unknown
			//IL_09b3: Expected O, but got Unknown
			//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(NotificationView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/NotificationView.xaml");
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
			TapGestureRecognizer val2 = new TapGestureRecognizer();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			BoxView val5 = new BoxView();
			Label val6 = new Label();
			Label val7 = new Label();
			DynamicResourceExtension val8 = new DynamicResourceExtension();
			Label val9 = new Label();
			StackLayout val10 = new StackLayout();
			DynamicResourceExtension val11 = new DynamicResourceExtension();
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			Label val13 = new Label();
			StackLayout val14 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			NotificationView notificationView;
			NameScope val15 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(notificationView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)notificationView, (INameScope)(object)val15);
			((INameScope)val15).RegisterName("notificationLayout", (object)notificationView);
			if (((Element)notificationView).get_StyleId() == null)
			{
				((Element)notificationView).set_StyleId("notificationLayout");
			}
			((INameScope)val15).RegisterName("tapGesture", (object)val2);
			if (((Element)val2).get_StyleId() == null)
			{
				((Element)val2).set_StyleId("tapGesture");
			}
			((INameScope)val15).RegisterName("border", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("border");
			}
			((INameScope)val15).RegisterName("dateLabel", (object)val6);
			if (((Element)val6).get_StyleId() == null)
			{
				((Element)val6).set_StyleId("dateLabel");
			}
			((INameScope)val15).RegisterName("titleLabel", (object)val7);
			if (((Element)val7).get_StyleId() == null)
			{
				((Element)val7).set_StyleId("titleLabel");
			}
			((INameScope)val15).RegisterName("descriptionLabel", (object)val9);
			if (((Element)val9).get_StyleId() == null)
			{
				((Element)val9).set_StyleId("descriptionLabel");
			}
			((INameScope)val15).RegisterName("actionLabel", (object)val13);
			if (((Element)val13).get_StyleId() == null)
			{
				((Element)val13).set_StyleId("actionLabel");
			}
			notificationLayout = (StackLayout)(object)notificationView;
			tapGesture = val2;
			border = val5;
			dateLabel = val6;
			titleLabel = val7;
			descriptionLabel = val9;
			actionLabel = val13;
			((BindableObject)notificationView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)notificationView).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			((BindableObject)notificationView).SetValue(Layout.PaddingProperty, (object)new Thickness(4.0, 24.0));
			((View)notificationView).get_GestureRecognizers().Add((IGestureRecognizer)(object)val2);
			val3.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val16 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = shadowFrame;
			array[1] = notificationView;
			SimpleValueTargetProvider val17 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val15);
			object obj = (object)val17;
			val16.Add(typeFromHandle, (object)val17);
			val16.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val18 = new XmlNamespaceResolver();
			val18.Add("", "http://xamarin.com/schemas/2014/forms");
			val18.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val18.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val16.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val18, typeof(NotificationView).GetTypeInfo().Assembly));
			val16.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 9)));
			DynamicResource val19 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val16);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val19.get_Key());
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((BindableObject)shadowFrame).SetValue(VisualElement.InputTransparentProperty, (object)true);
			((BindableObject)val5).SetValue(VisualElement.IsVisibleProperty, new VisibilityConverter().ConvertFromInvariantString("false"));
			((BindableObject)val5).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val4.set_Key("PrimaryColor");
			XamlServiceProvider val20 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 4];
			array2[0] = val5;
			array2[1] = val14;
			array2[2] = shadowFrame;
			array2[3] = notificationView;
			SimpleValueTargetProvider val21 = new SimpleValueTargetProvider(array2, (object)BoxView.ColorProperty, (INameScope)(object)val15);
			object obj2 = (object)val21;
			val20.Add(typeFromHandle3, (object)val21);
			val20.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val22 = new XmlNamespaceResolver();
			val22.Add("", "http://xamarin.com/schemas/2014/forms");
			val22.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val22.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val20.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val22, typeof(NotificationView).GetTypeInfo().Assembly));
			val20.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 17)));
			DynamicResource val23 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val20);
			((IDynamicResourceHandler)val5).SetDynamicResource(BoxView.ColorProperty, val23.get_Key());
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val5);
			((BindableObject)val10).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val10).SetValue(StackLayout.SpacingProperty, (object)8.0);
			((BindableObject)val6).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val6).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val6).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 8.0));
			((Layout<View>)(object)val10).get_Children().Add((View)(object)val6);
			((BindableObject)val7).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val7).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val7).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val7).SetValue(VisualElement.InputTransparentProperty, (object)true);
			((BindableObject)val7).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((Layout<View>)(object)val10).get_Children().Add((View)(object)val7);
			val8.set_Key("Small");
			XamlServiceProvider val24 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 5];
			array3[0] = val9;
			array3[1] = val10;
			array3[2] = val14;
			array3[3] = shadowFrame;
			array3[4] = notificationView;
			SimpleValueTargetProvider val25 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val15);
			object obj3 = (object)val25;
			val24.Add(typeFromHandle5, (object)val25);
			val24.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val26 = new XmlNamespaceResolver();
			val26.Add("", "http://xamarin.com/schemas/2014/forms");
			val26.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val26.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val24.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val26, typeof(NotificationView).GetTypeInfo().Assembly));
			val24.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 21)));
			DynamicResource val27 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val24);
			((IDynamicResourceHandler)val9).SetDynamicResource(VisualElement.StyleProperty, val27.get_Key());
			((BindableObject)val9).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val9).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val9).SetValue(VisualElement.InputTransparentProperty, (object)true);
			((BindableObject)val9).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((Layout<View>)(object)val10).get_Children().Add((View)(object)val9);
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val10);
			((BindableObject)val13).SetValue(Label.PaddingProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)val13).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.End);
			val11.set_Key("Small");
			XamlServiceProvider val28 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 4];
			array4[0] = val13;
			array4[1] = val14;
			array4[2] = shadowFrame;
			array4[3] = notificationView;
			SimpleValueTargetProvider val29 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val15);
			object obj4 = (object)val29;
			val28.Add(typeFromHandle7, (object)val29);
			val28.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val30 = new XmlNamespaceResolver();
			val30.Add("", "http://xamarin.com/schemas/2014/forms");
			val30.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val30.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val28.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val30, typeof(NotificationView).GetTypeInfo().Assembly));
			val28.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 17)));
			DynamicResource val31 = ((IMarkupExtension<DynamicResource>)(object)val11).ProvideValue((IServiceProvider)val28);
			((IDynamicResourceHandler)val13).SetDynamicResource(VisualElement.StyleProperty, val31.get_Key());
			val12.set_Key("SecondaryLinkColor");
			XamlServiceProvider val32 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 4];
			array5[0] = val13;
			array5[1] = val14;
			array5[2] = shadowFrame;
			array5[3] = notificationView;
			SimpleValueTargetProvider val33 = new SimpleValueTargetProvider(array5, (object)Label.TextColorProperty, (INameScope)(object)val15);
			object obj5 = (object)val33;
			val32.Add(typeFromHandle9, (object)val33);
			val32.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val34 = new XmlNamespaceResolver();
			val34.Add("", "http://xamarin.com/schemas/2014/forms");
			val34.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val34.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val32.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val34, typeof(NotificationView).GetTypeInfo().Assembly));
			val32.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 17)));
			DynamicResource val35 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val32);
			((IDynamicResourceHandler)val13).SetDynamicResource(Label.TextColorProperty, val35.get_Key());
			((BindableObject)val13).SetValue(Label.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			((Layout<View>)(object)val14).get_Children().Add((View)(object)val13);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val14);
			((Layout<View>)(object)notificationView).get_Children().Add((View)(object)shadowFrame);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<NotificationView>(this, typeof(NotificationView));
			notificationLayout = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "notificationLayout");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			dateLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "dateLabel");
			titleLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "titleLabel");
			descriptionLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "descriptionLabel");
			actionLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "actionLabel");
			tapGesture = NameScopeExtensions.FindByName<TapGestureRecognizer>((Element)(object)this, "tapGesture");
		}
	}
}
