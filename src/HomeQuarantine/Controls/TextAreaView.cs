using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Controls
{
	[XamlFilePath("Controls/TextAreaView.xaml")]
	public class TextAreaView : StackLayout
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(TextAreaView), (object)string.Empty, (BindingMode)1, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			TextAreaView textAreaView = bindable as TextAreaView;
			textAreaView.outerFrame.set_BorderColor(textAreaView.ValidString(newValue as string) ? ColorHelper.GetResourceValue("SuccessColor") : ColorHelper.GetResourceValue("ErrorColor"));
			textAreaView.maxCharLabel.set_Text($"Max characters: {((string)newValue).Length} / {textAreaView.MaxLength}");
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create("MaxLength", typeof(int), typeof(TextAreaView), (object)0, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			((InputView)(bindable as TextAreaView).editor).set_MaxLength((int)newValue);
			(bindable as TextAreaView).maxCharLabel.set_Text($"Max characters: {(bindable as TextAreaView).Text?.Length ?? 0} / {(int)newValue}");
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public static readonly BindableProperty MinLengthProperty = BindableProperty.Create("MaxLength", typeof(int), typeof(TextAreaView), (object)0, (BindingMode)2, (ValidateValueDelegate)null, (BindingPropertyChangedDelegate)delegate(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as TextAreaView).minLength = (int)newValue;
		}, (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		private int minLength;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Frame outerFrame;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Editor editor;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label maxCharLabel;

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

		public int MaxLength
		{
			get
			{
				return (int)((BindableObject)this).GetValue(MaxLengthProperty);
			}
			set
			{
				((BindableObject)this).SetValue(MaxLengthProperty, (object)value);
			}
		}

		public int MinLength
		{
			get
			{
				return (int)((BindableObject)this).GetValue(MinLengthProperty);
			}
			set
			{
				((BindableObject)this).SetValue(MinLengthProperty, (object)value);
			}
		}

		public TextAreaView()
			: this()
		{
			InitializeComponent();
		}

		private void OnTextChanged(object sender, TextChangedEventArgs args)
		{
			Text = args.get_NewTextValue();
		}

		private bool ValidString(string newValue)
		{
			if (string.IsNullOrWhiteSpace(newValue))
			{
				return false;
			}
			int length = newValue.Trim().Length;
			if (length >= MinLength)
			{
				return length <= MaxLength;
			}
			return false;
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
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected O, but got Unknown
			//IL_0253: Expected O, but got Unknown
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Expected O, but got Unknown
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected O, but got Unknown
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Expected O, but got Unknown
			//IL_02d6: Expected O, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(TextAreaView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Controls/TextAreaView.xaml");
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
			Editor val2 = new Editor();
			Frame val3 = new Frame();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			Label val5 = new Label();
			TextAreaView textAreaView;
			NameScope val6 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(textAreaView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)textAreaView, (INameScope)(object)val6);
			((INameScope)val6).RegisterName("outerFrame", (object)val3);
			if (((Element)val3).get_StyleId() == null)
			{
				((Element)val3).set_StyleId("outerFrame");
			}
			((INameScope)val6).RegisterName("editor", (object)val2);
			if (((Element)val2).get_StyleId() == null)
			{
				((Element)val2).set_StyleId("editor");
			}
			((INameScope)val6).RegisterName("maxCharLabel", (object)val5);
			if (((Element)val5).get_StyleId() == null)
			{
				((Element)val5).set_StyleId("maxCharLabel");
			}
			outerFrame = val3;
			editor = val2;
			maxCharLabel = val5;
			((BindableObject)textAreaView).SetValue(StackLayout.SpacingProperty, (object)2.0);
			((BindableObject)val3).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val3).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val3).SetValue(VisualElement.MinimumHeightRequestProperty, (object)100.0);
			((BindableObject)val3).SetValue(Frame.BorderColorProperty, (object)Color.LightGray);
			((BindableObject)val2).SetValue(InputView.IsSpellCheckEnabledProperty, (object)true);
			((BindableObject)val2).SetValue(Editor.IsTextPredictionEnabledProperty, (object)true);
			((InputView)val2).add_TextChanged((EventHandler<TextChangedEventArgs>)textAreaView.OnTextChanged);
			((BindableObject)val2).SetValue(VisualElement.MinimumHeightRequestProperty, (object)140.0);
			((BindableObject)val2).SetValue(VisualElement.HeightRequestProperty, (object)140.0);
			((BindableObject)val3).SetValue(ContentView.ContentProperty, (object)val2);
			((Layout<View>)(object)textAreaView).get_Children().Add((View)(object)val3);
			val4.set_Key("Caption");
			XamlServiceProvider val7 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = val5;
			array[1] = textAreaView;
			SimpleValueTargetProvider val8 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val6);
			object obj = (object)val8;
			val7.Add(typeFromHandle, (object)val8);
			val7.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val9 = new XmlNamespaceResolver();
			val9.Add("", "http://xamarin.com/schemas/2014/forms");
			val9.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val7.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val9, typeof(TextAreaView).GetTypeInfo().Assembly));
			val7.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 34)));
			DynamicResource val10 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val7);
			((IDynamicResourceHandler)val5).SetDynamicResource(VisualElement.StyleProperty, val10.get_Key());
			((BindableObject)val5).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			((Layout<View>)(object)textAreaView).get_Children().Add((View)(object)val5);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<TextAreaView>(this, typeof(TextAreaView));
			outerFrame = NameScopeExtensions.FindByName<Frame>((Element)(object)this, "outerFrame");
			editor = NameScopeExtensions.FindByName<Editor>((Element)(object)this, "editor");
			maxCharLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "maxCharLabel");
		}
	}
}
