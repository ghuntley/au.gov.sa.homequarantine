using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/ViewAllNotificationView.xaml")]
	public class ViewAllNotificationView : BaseView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BaseView allNotificationPage;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		public ViewAllNotificationView()
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
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(ViewAllNotificationView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/ViewAllNotificationView.xaml");
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
			string notifications_TitleName = Resources.Notifications_TitleName;
			BindingExtension val2 = new BindingExtension();
			DataTemplate val3 = new DataTemplate();
			StackLayout val4 = new StackLayout();
			ScrollView val5 = new ScrollView();
			StackLayout val6 = new StackLayout();
			ViewAllNotificationView viewAllNotificationView;
			NameScope val7 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(viewAllNotificationView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)viewAllNotificationView, (INameScope)(object)val7);
			((INameScope)val7).RegisterName("allNotificationPage", (object)viewAllNotificationView);
			if (((Element)viewAllNotificationView).get_StyleId() == null)
			{
				((Element)viewAllNotificationView).set_StyleId("allNotificationPage");
			}
			((INameScope)val7).RegisterName("containingView", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("containingView");
			}
			allNotificationPage = viewAllNotificationView;
			containingView = val4;
			((BindableObject)viewAllNotificationView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)viewAllNotificationView).SetValue(Page.TitleProperty, (object)notifications_TitleName);
			((BindableObject)val6).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val5).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val5).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val2.set_Path("AllNotifications");
			BindingBase val8 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(BindableLayout.ItemsSourceProperty, val8);
			((BindableObject)val4).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			object[] array = new object[0 + 5];
			array[0] = val3;
			array[1] = val4;
			array[2] = val5;
			array[3] = val6;
			array[4] = viewAllNotificationView;
			object[] parentValues = array;
			ViewAllNotificationView root = viewAllNotificationView;
			((IDataTemplate)val3).set_LoadTemplate((Func<object>)delegate
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				//IL_000d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Expected O, but got Unknown
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Expected O, but got Unknown
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Expected O, but got Unknown
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Expected O, but got Unknown
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Expected O, but got Unknown
				//IL_015e: Expected O, but got Unknown
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f9: Expected O, but got Unknown
				//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fe: Expected O, but got Unknown
				//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Expected O, but got Unknown
				//IL_0212: Unknown result type (might be due to invalid IL or missing references)
				//IL_021c: Expected O, but got Unknown
				//IL_0221: Expected O, but got Unknown
				BindingExtension val9 = new BindingExtension();
				BindingExtension val10 = new BindingExtension();
				BindingExtension val11 = new BindingExtension();
				BindingExtension val12 = new BindingExtension();
				ReferenceExtension val13 = new ReferenceExtension();
				BindingExtension val14 = new BindingExtension();
				BindingExtension val15 = new BindingExtension();
				NotificationView notificationView = new NotificationView();
				NameScope val16 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)notificationView, (INameScope)(object)val16);
				val9.set_Path("DateCreatedLabel");
				BindingBase val17 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.DateProperty, val17);
				val10.set_Path("ActionLabel");
				BindingBase val18 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.ActionLabelProperty, val18);
				val11.set_Path("Title");
				BindingBase val19 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TitleProperty, val19);
				val12.set_Path("Description");
				BindingBase val20 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.DescriptionProperty, val20);
				((BindableObject)notificationView).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
				val13.set_Name("allNotificationPage");
				XamlServiceProvider val21 = new XamlServiceProvider();
				Type typeFromHandle = typeof(IProvideValueTarget);
				int length;
				object[] array2 = new object[(length = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array2, 2, length);
				array2[0] = val14;
				array2[1] = notificationView;
				SimpleValueTargetProvider val22 = new SimpleValueTargetProvider(array2, (object)typeof(BindingExtension).GetRuntimeProperty("Source"), (INameScope)(object)val16);
				object obj = (object)val22;
				val21.Add(typeFromHandle, (object)val22);
				val21.Add(typeof(IReferenceProvider), obj);
				Type typeFromHandle2 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val23 = new XmlNamespaceResolver();
				val23.Add("", "http://xamarin.com/schemas/2014/forms");
				val23.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val23.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val23.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val23.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val23.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val21.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val23, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_12).GetTypeInfo().Assembly));
				val21.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 29)));
				object source = ((IMarkupExtension)val13).ProvideValue((IServiceProvider)val21);
				val14.set_Source(source);
				val14.set_Path("BindingContext.NotificationDetailsCommand");
				BindingBase val24 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TapCommandProperty, val24);
				val15.set_Path(".");
				BindingBase val25 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TapCommandParameterProperty, val25);
				return notificationView;
			});
			((BindableObject)val4).SetValue(BindableLayout.ItemTemplateProperty, (object)val3);
			val5.set_Content((View)(object)val4);
			((Layout<View>)(object)val6).get_Children().Add((View)(object)val5);
			((BindableObject)viewAllNotificationView).SetValue(ContentPage.ContentProperty, (object)val6);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<ViewAllNotificationView>(this, typeof(ViewAllNotificationView));
			allNotificationPage = NameScopeExtensions.FindByName<BaseView>((Element)(object)this, "allNotificationPage");
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
		}
	}
}
