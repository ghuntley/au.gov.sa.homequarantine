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
	[XamlFilePath("Controls/ActivityIndicatorView.xaml")]
	public class ActivityIndicatorView : Grid
	{
		public static readonly BindableProperty IsBusyProperty = BindableProperty.Create("IsBusy", typeof(bool), typeof(ActivityIndicatorView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			((VisualElement)(bindable as ActivityIndicatorView).blurBackground).set_IsVisible((bool)newValue);
			(bindable as ActivityIndicatorView).activityIndicator.set_IsRunning((bool)newValue);
			((VisualElement)(bindable as ActivityIndicatorView).activityIndicatorContainer).set_IsVisible((bool)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty BusyMessageProperty = BindableProperty.Create("BusyMessage", typeof(string), typeof(ActivityIndicatorView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as ActivityIndicatorView).busyMessageLabel.set_Text((string)newValue);
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout blurBackground;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ShadowFrame activityIndicatorContainer;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ActivityIndicator activityIndicator;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label busyMessageLabel;

		public bool IsBusy
		{
			get
			{
				return (bool)((BindableObject)this).GetValue(IsBusyProperty);
			}
			set
			{
				((BindableObject)this).SetValue(IsBusyProperty, (object)value);
			}
		}

		public string BusyMessage
		{
			get
			{
				return (string)((BindableObject)this).GetValue(BusyMessageProperty);
			}
			set
			{
				((BindableObject)this).SetValue(BusyMessageProperty, (object)value);
			}
		}

		public ActivityIndicatorView()
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
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_0213: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Expected O, but got Unknown
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02a6: Expected O, but got Unknown
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ActivityIndicatorView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/ActivityIndicatorView.xaml");
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
			StackLayout val2 = new StackLayout();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			ActivityIndicator val4 = new ActivityIndicator();
			Label val5 = new Label();
			StackLayout val6 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			ActivityIndicatorView activityIndicatorView;
			NameScope val7 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(activityIndicatorView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)activityIndicatorView, (INameScope)(object)val7);
			((INameScope)val7).RegisterName("blurBackground", (object)val2);
			if (((Element)val2).get_StyleId() == null)
			{
				((Element)val2).set_StyleId("blurBackground");
			}
			((INameScope)val7).RegisterName("activityIndicatorContainer", (object)shadowFrame);
			if (((Element)shadowFrame).get_StyleId() == null)
			{
				((Element)shadowFrame).set_StyleId("activityIndicatorContainer");
			}
			((INameScope)val7).RegisterName("activityIndicator", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("activityIndicator");
			}
			((INameScope)val7).RegisterName("busyMessageLabel", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("busyMessageLabel");
			}
			blurBackground = val2;
			activityIndicatorContainer = shadowFrame;
			activityIndicator = val4;
			busyMessageLabel = val5;
			((BindableObject)activityIndicatorView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)activityIndicatorView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val2).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val2).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Black);
			((BindableObject)val2).SetValue(VisualElement.OpacityProperty, (object)0.4);
			((ICollection<View>)((Grid)activityIndicatorView).get_Children()).Add((View)(object)val2);
			val3.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val8 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = shadowFrame;
			array[1] = activityIndicatorView;
			SimpleValueTargetProvider val9 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val7);
			object obj = (object)val9;
			val8.Add(typeFromHandle, (object)val9);
			val8.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val10 = new XmlNamespaceResolver();
			val10.Add("", "http://xamarin.com/schemas/2014/forms");
			val10.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val10.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val8.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val10, typeof(ActivityIndicatorView).GetTypeInfo().Assembly));
			val8.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 9)));
			DynamicResource val11 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val8);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val11.get_Key());
			((BindableObject)shadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)shadowFrame).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val6).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((Layout<View>)(object)val6).get_Children().Add((View)(object)val4);
			((BindableObject)val5).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val6).get_Children().Add((View)(object)val5);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val6);
			((ICollection<View>)((Grid)activityIndicatorView).get_Children()).Add((View)(object)shadowFrame);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ActivityIndicatorView>(this, typeof(ActivityIndicatorView));
			blurBackground = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "blurBackground");
			activityIndicatorContainer = NameScopeExtensions.FindByName<ShadowFrame>((Element)(object)this, "activityIndicatorContainer");
			activityIndicator = NameScopeExtensions.FindByName<ActivityIndicator>((Element)(object)this, "activityIndicator");
			busyMessageLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "busyMessageLabel");
		}
	}
}
