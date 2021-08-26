using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/OnboardingIndicatorView.xaml")]
	public class OnboardingIndicatorView : StackLayout
	{
		public static readonly BindableProperty CurrentPageProperty = BindableProperty.Create("CurrentPage", typeof(OnboardingType), typeof(OnboardingIndicatorView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < (int)((OnboardingType)newValue + 1); i++)
			{
				View obj = ((Layout<View>)(object)(bindable as OnboardingIndicatorView)).get_Children()[i];
				((BoxView)((obj is BoxView) ? obj : null)).set_Color((bindable as OnboardingIndicatorView).Colour);
			}
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty ColourProperty = BindableProperty.Create("Colour", typeof(Color), typeof(OnboardingIndicatorView), (object)null, (BindingMode)2, (ValidateValueDelegate)null, new BindingPropertyChangedDelegate(ForceCoerceColourValue), (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		private Color colour;

		private OnboardingType pageType;

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

		public OnboardingIndicatorView()
			: this()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			InitializeComponent();
			for (int i = 0; i < (int)(Enum.GetValues(typeof(OnboardingType)).Cast<OnboardingType>().Last() + 1); i++)
			{
				if (i == 0)
				{
					IList<View> children = ((Layout<View>)this).get_Children();
					BoxView val = new BoxView();
					val.set_Color(ColorHelper.GetResourceValue("PrimaryColor"));
					((VisualElement)val).set_HeightRequest(10.0);
					((VisualElement)val).set_WidthRequest(10.0);
					val.set_CornerRadius(CornerRadius.op_Implicit(5.0));
					children.Add((View)val);
				}
				else
				{
					IList<View> children2 = ((Layout<View>)this).get_Children();
					BoxView val2 = new BoxView();
					val2.set_Color(ColorHelper.GetResourceValue("TertiaryTextColor"));
					((VisualElement)val2).set_HeightRequest(10.0);
					((VisualElement)val2).set_WidthRequest(10.0);
					val2.set_CornerRadius(CornerRadius.op_Implicit(5.0));
					children2.Add((View)val2);
				}
			}
		}

		private static void ForceCoerceColourValue(BindableObject bindable, object oldValue, object newValue)
		{
			bindable.CoerceValue(CurrentPageProperty);
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(OnboardingIndicatorView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/OnboardingIndicatorView.xaml");
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
			OnboardingIndicatorView onboardingIndicatorView;
			NameScope val2 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(onboardingIndicatorView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)onboardingIndicatorView, (INameScope)(object)val2);
			((BindableObject)onboardingIndicatorView).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)onboardingIndicatorView).SetValue(StackLayout.SpacingProperty, (object)6.0);
			((BindableObject)onboardingIndicatorView).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 32.0));
			((BindableObject)onboardingIndicatorView).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<OnboardingIndicatorView>(this, typeof(OnboardingIndicatorView));
		}
	}
}
