using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using FFImageLoading.Forms;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Skeleton;
using Xamarin.Forms.Skeleton.Animations;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/MainView.xaml")]
	public class MainView : BaseView, IMainView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BaseView mainPage;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textMessage;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label notificationCount;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label viewAllNotificationsLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TapGestureRecognizer linkTapGesture;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label expectedDate;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label expectedDay;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label expectedDatedetails;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label iconLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label versionNumberLabel;

		public MainView()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			(((BindableObject)this).get_BindingContext() as MainViewModel).LoadNotificationsCommand.Execute(null);
			await (((BindableObject)this).get_BindingContext() as MainViewModel).PerformActionCommand.ExecuteAsync();
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
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected O, but got Unknown
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected O, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected O, but got Unknown
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected O, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Expected O, but got Unknown
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected O, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected O, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected O, but got Unknown
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected O, but got Unknown
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected O, but got Unknown
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected O, but got Unknown
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected O, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected O, but got Unknown
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Expected O, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected O, but got Unknown
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected O, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Expected O, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Expected O, but got Unknown
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected O, but got Unknown
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected O, but got Unknown
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected O, but got Unknown
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0326: Expected O, but got Unknown
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Expected O, but got Unknown
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Expected O, but got Unknown
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Expected O, but got Unknown
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Expected O, but got Unknown
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected O, but got Unknown
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Expected O, but got Unknown
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected O, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Expected O, but got Unknown
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected O, but got Unknown
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Expected O, but got Unknown
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected O, but got Unknown
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Expected O, but got Unknown
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected O, but got Unknown
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Expected O, but got Unknown
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Expected O, but got Unknown
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Expected O, but got Unknown
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected O, but got Unknown
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Expected O, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected O, but got Unknown
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Expected O, but got Unknown
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Expected O, but got Unknown
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Expected O, but got Unknown
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected O, but got Unknown
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Expected O, but got Unknown
			//IL_0406: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Expected O, but got Unknown
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Expected O, but got Unknown
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_041b: Expected O, but got Unknown
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected O, but got Unknown
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Expected O, but got Unknown
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Expected O, but got Unknown
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Expected O, but got Unknown
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Expected O, but got Unknown
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Expected O, but got Unknown
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Expected O, but got Unknown
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Expected O, but got Unknown
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Expected O, but got Unknown
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Expected O, but got Unknown
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Expected O, but got Unknown
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Expected O, but got Unknown
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Expected O, but got Unknown
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_048b: Expected O, but got Unknown
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Expected O, but got Unknown
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Expected O, but got Unknown
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a7: Expected O, but got Unknown
			//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ae: Expected O, but got Unknown
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Expected O, but got Unknown
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Expected O, but got Unknown
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected O, but got Unknown
			//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Expected O, but got Unknown
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected O, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Expected O, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Unknown result type (might be due to invalid IL or missing references)
			//IL_074a: Unknown result type (might be due to invalid IL or missing references)
			//IL_076d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0772: Unknown result type (might be due to invalid IL or missing references)
			//IL_0775: Expected O, but got Unknown
			//IL_077a: Expected O, but got Unknown
			//IL_077a: Unknown result type (might be due to invalid IL or missing references)
			//IL_078c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0797: Unknown result type (might be due to invalid IL or missing references)
			//IL_079c: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0845: Expected O, but got Unknown
			//IL_0840: Unknown result type (might be due to invalid IL or missing references)
			//IL_084a: Expected O, but got Unknown
			//IL_084a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0859: Unknown result type (might be due to invalid IL or missing references)
			//IL_0863: Expected O, but got Unknown
			//IL_085e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0868: Expected O, but got Unknown
			//IL_086d: Expected O, but got Unknown
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Unknown result type (might be due to invalid IL or missing references)
			//IL_0987: Unknown result type (might be due to invalid IL or missing references)
			//IL_098c: Unknown result type (might be due to invalid IL or missing references)
			//IL_098f: Expected O, but got Unknown
			//IL_0994: Expected O, but got Unknown
			//IL_0994: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5f: Expected O, but got Unknown
			//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a64: Expected O, but got Unknown
			//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7d: Expected O, but got Unknown
			//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a82: Expected O, but got Unknown
			//IL_0a87: Expected O, but got Unknown
			//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4f: Expected O, but got Unknown
			//IL_0b54: Expected O, but got Unknown
			//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1f: Expected O, but got Unknown
			//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c24: Expected O, but got Unknown
			//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3d: Expected O, but got Unknown
			//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c42: Expected O, but got Unknown
			//IL_0c47: Expected O, but got Unknown
			//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d17: Expected O, but got Unknown
			//IL_0d1c: Expected O, but got Unknown
			//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de7: Expected O, but got Unknown
			//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dec: Expected O, but got Unknown
			//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e05: Expected O, but got Unknown
			//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0a: Expected O, but got Unknown
			//IL_0e0f: Expected O, but got Unknown
			//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee1: Expected O, but got Unknown
			//IL_0ee6: Expected O, but got Unknown
			//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb1: Expected O, but got Unknown
			//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb6: Expected O, but got Unknown
			//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fcf: Expected O, but got Unknown
			//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd4: Expected O, but got Unknown
			//IL_0fd9: Expected O, but got Unknown
			//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
			//IL_100b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1026: Unknown result type (might be due to invalid IL or missing references)
			//IL_1041: Unknown result type (might be due to invalid IL or missing references)
			//IL_106c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1071: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b1: Expected O, but got Unknown
			//IL_10b6: Expected O, but got Unknown
			//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1108: Unknown result type (might be due to invalid IL or missing references)
			//IL_1118: Unknown result type (might be due to invalid IL or missing references)
			//IL_1128: Unknown result type (might be due to invalid IL or missing references)
			//IL_1138: Unknown result type (might be due to invalid IL or missing references)
			//IL_1148: Unknown result type (might be due to invalid IL or missing references)
			//IL_1158: Unknown result type (might be due to invalid IL or missing references)
			//IL_1181: Expected O, but got Unknown
			//IL_117c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1186: Expected O, but got Unknown
			//IL_1186: Unknown result type (might be due to invalid IL or missing references)
			//IL_1195: Unknown result type (might be due to invalid IL or missing references)
			//IL_119f: Expected O, but got Unknown
			//IL_119a: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a4: Expected O, but got Unknown
			//IL_11a9: Expected O, but got Unknown
			//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1204: Unknown result type (might be due to invalid IL or missing references)
			//IL_1207: Expected O, but got Unknown
			//IL_120c: Expected O, but got Unknown
			//IL_120c: Unknown result type (might be due to invalid IL or missing references)
			//IL_121e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1229: Unknown result type (might be due to invalid IL or missing references)
			//IL_122e: Unknown result type (might be due to invalid IL or missing references)
			//IL_123e: Unknown result type (might be due to invalid IL or missing references)
			//IL_124e: Unknown result type (might be due to invalid IL or missing references)
			//IL_125e: Unknown result type (might be due to invalid IL or missing references)
			//IL_126e: Unknown result type (might be due to invalid IL or missing references)
			//IL_127e: Unknown result type (might be due to invalid IL or missing references)
			//IL_128e: Unknown result type (might be due to invalid IL or missing references)
			//IL_129e: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d7: Expected O, but got Unknown
			//IL_12d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_12dc: Expected O, but got Unknown
			//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f5: Expected O, but got Unknown
			//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_12fa: Expected O, but got Unknown
			//IL_12ff: Expected O, but got Unknown
			//IL_132c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1342: Unknown result type (might be due to invalid IL or missing references)
			//IL_1379: Unknown result type (might be due to invalid IL or missing references)
			//IL_138f: Unknown result type (might be due to invalid IL or missing references)
			//IL_13f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_140b: Unknown result type (might be due to invalid IL or missing references)
			//IL_143a: Unknown result type (might be due to invalid IL or missing references)
			//IL_143f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1481: Unknown result type (might be due to invalid IL or missing references)
			//IL_1486: Unknown result type (might be due to invalid IL or missing references)
			//IL_1489: Expected O, but got Unknown
			//IL_148e: Expected O, but got Unknown
			//IL_148e: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1500: Unknown result type (might be due to invalid IL or missing references)
			//IL_1510: Unknown result type (might be due to invalid IL or missing references)
			//IL_1520: Unknown result type (might be due to invalid IL or missing references)
			//IL_1530: Unknown result type (might be due to invalid IL or missing references)
			//IL_1559: Expected O, but got Unknown
			//IL_1554: Unknown result type (might be due to invalid IL or missing references)
			//IL_155e: Expected O, but got Unknown
			//IL_155e: Unknown result type (might be due to invalid IL or missing references)
			//IL_156d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1577: Expected O, but got Unknown
			//IL_1572: Unknown result type (might be due to invalid IL or missing references)
			//IL_157c: Expected O, but got Unknown
			//IL_1581: Expected O, but got Unknown
			//IL_159d: Unknown result type (might be due to invalid IL or missing references)
			//IL_15db: Unknown result type (might be due to invalid IL or missing references)
			//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1622: Unknown result type (might be due to invalid IL or missing references)
			//IL_1627: Unknown result type (might be due to invalid IL or missing references)
			//IL_162a: Expected O, but got Unknown
			//IL_162f: Expected O, but got Unknown
			//IL_162f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1641: Unknown result type (might be due to invalid IL or missing references)
			//IL_164c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1651: Unknown result type (might be due to invalid IL or missing references)
			//IL_1661: Unknown result type (might be due to invalid IL or missing references)
			//IL_1671: Unknown result type (might be due to invalid IL or missing references)
			//IL_1681: Unknown result type (might be due to invalid IL or missing references)
			//IL_1691: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fa: Expected O, but got Unknown
			//IL_16f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ff: Expected O, but got Unknown
			//IL_16ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_170e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1718: Expected O, but got Unknown
			//IL_1713: Unknown result type (might be due to invalid IL or missing references)
			//IL_171d: Expected O, but got Unknown
			//IL_1722: Expected O, but got Unknown
			//IL_173e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1760: Unknown result type (might be due to invalid IL or missing references)
			//IL_1765: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_17af: Expected O, but got Unknown
			//IL_17b4: Expected O, but got Unknown
			//IL_17b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1806: Unknown result type (might be due to invalid IL or missing references)
			//IL_1816: Unknown result type (might be due to invalid IL or missing references)
			//IL_1826: Unknown result type (might be due to invalid IL or missing references)
			//IL_1836: Unknown result type (might be due to invalid IL or missing references)
			//IL_1846: Unknown result type (might be due to invalid IL or missing references)
			//IL_1856: Unknown result type (might be due to invalid IL or missing references)
			//IL_187f: Expected O, but got Unknown
			//IL_187a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1884: Expected O, but got Unknown
			//IL_1884: Unknown result type (might be due to invalid IL or missing references)
			//IL_1893: Unknown result type (might be due to invalid IL or missing references)
			//IL_189d: Expected O, but got Unknown
			//IL_1898: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a2: Expected O, but got Unknown
			//IL_18a7: Expected O, but got Unknown
			//IL_1918: Unknown result type (might be due to invalid IL or missing references)
			//IL_191d: Unknown result type (might be due to invalid IL or missing references)
			//IL_195a: Unknown result type (might be due to invalid IL or missing references)
			//IL_195f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1962: Expected O, but got Unknown
			//IL_1967: Expected O, but got Unknown
			//IL_1967: Unknown result type (might be due to invalid IL or missing references)
			//IL_1979: Unknown result type (might be due to invalid IL or missing references)
			//IL_1984: Unknown result type (might be due to invalid IL or missing references)
			//IL_1989: Unknown result type (might be due to invalid IL or missing references)
			//IL_1999: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_19c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_19d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a09: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a32: Expected O, but got Unknown
			//IL_1a2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a37: Expected O, but got Unknown
			//IL_1a37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a46: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a50: Expected O, but got Unknown
			//IL_1a4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a55: Expected O, but got Unknown
			//IL_1a5a: Expected O, but got Unknown
			//IL_1a76: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b58: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1be1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1be4: Expected O, but got Unknown
			//IL_1be9: Expected O, but got Unknown
			//IL_1be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c06: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cb4: Expected O, but got Unknown
			//IL_1caf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cb9: Expected O, but got Unknown
			//IL_1cb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd2: Expected O, but got Unknown
			//IL_1ccd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd7: Expected O, but got Unknown
			//IL_1cdc: Expected O, but got Unknown
			//IL_1dc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e16: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e33: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e38: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e70: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e78: Expected O, but got Unknown
			//IL_1e7d: Expected O, but got Unknown
			//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ebf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ecf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1edf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f48: Expected O, but got Unknown
			//IL_1f43: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f4d: Expected O, but got Unknown
			//IL_1f4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f69: Expected O, but got Unknown
			//IL_1f64: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f6e: Expected O, but got Unknown
			//IL_1f73: Expected O, but got Unknown
			//IL_1fb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2000: Unknown result type (might be due to invalid IL or missing references)
			//IL_2005: Unknown result type (might be due to invalid IL or missing references)
			//IL_2047: Unknown result type (might be due to invalid IL or missing references)
			//IL_204c: Unknown result type (might be due to invalid IL or missing references)
			//IL_204f: Expected O, but got Unknown
			//IL_2054: Expected O, but got Unknown
			//IL_2054: Unknown result type (might be due to invalid IL or missing references)
			//IL_2066: Unknown result type (might be due to invalid IL or missing references)
			//IL_2071: Unknown result type (might be due to invalid IL or missing references)
			//IL_2076: Unknown result type (might be due to invalid IL or missing references)
			//IL_2086: Unknown result type (might be due to invalid IL or missing references)
			//IL_2096: Unknown result type (might be due to invalid IL or missing references)
			//IL_20a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_211f: Expected O, but got Unknown
			//IL_211a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2124: Expected O, but got Unknown
			//IL_2124: Unknown result type (might be due to invalid IL or missing references)
			//IL_2136: Unknown result type (might be due to invalid IL or missing references)
			//IL_2140: Expected O, but got Unknown
			//IL_213b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2145: Expected O, but got Unknown
			//IL_214a: Expected O, but got Unknown
			//IL_2198: Unknown result type (might be due to invalid IL or missing references)
			//IL_2201: Unknown result type (might be due to invalid IL or missing references)
			//IL_2206: Unknown result type (might be due to invalid IL or missing references)
			//IL_2248: Unknown result type (might be due to invalid IL or missing references)
			//IL_224d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2250: Expected O, but got Unknown
			//IL_2255: Expected O, but got Unknown
			//IL_2255: Unknown result type (might be due to invalid IL or missing references)
			//IL_2267: Unknown result type (might be due to invalid IL or missing references)
			//IL_2272: Unknown result type (might be due to invalid IL or missing references)
			//IL_2277: Unknown result type (might be due to invalid IL or missing references)
			//IL_2287: Unknown result type (might be due to invalid IL or missing references)
			//IL_2297: Unknown result type (might be due to invalid IL or missing references)
			//IL_22a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2320: Expected O, but got Unknown
			//IL_231b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2325: Expected O, but got Unknown
			//IL_2325: Unknown result type (might be due to invalid IL or missing references)
			//IL_2337: Unknown result type (might be due to invalid IL or missing references)
			//IL_2341: Expected O, but got Unknown
			//IL_233c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2346: Expected O, but got Unknown
			//IL_234b: Expected O, but got Unknown
			//IL_2369: Unknown result type (might be due to invalid IL or missing references)
			//IL_236e: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b8: Expected O, but got Unknown
			//IL_23bd: Expected O, but got Unknown
			//IL_23bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_23cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_23da: Unknown result type (might be due to invalid IL or missing references)
			//IL_23df: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_240f: Unknown result type (might be due to invalid IL or missing references)
			//IL_241f: Unknown result type (might be due to invalid IL or missing references)
			//IL_242f: Unknown result type (might be due to invalid IL or missing references)
			//IL_243f: Unknown result type (might be due to invalid IL or missing references)
			//IL_244f: Unknown result type (might be due to invalid IL or missing references)
			//IL_245f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2488: Expected O, but got Unknown
			//IL_2483: Unknown result type (might be due to invalid IL or missing references)
			//IL_248d: Expected O, but got Unknown
			//IL_248d: Unknown result type (might be due to invalid IL or missing references)
			//IL_249f: Unknown result type (might be due to invalid IL or missing references)
			//IL_24a9: Expected O, but got Unknown
			//IL_24a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_24ae: Expected O, but got Unknown
			//IL_24b3: Expected O, but got Unknown
			//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_24ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_2535: Unknown result type (might be due to invalid IL or missing references)
			//IL_253a: Unknown result type (might be due to invalid IL or missing references)
			//IL_253d: Expected O, but got Unknown
			//IL_2542: Expected O, but got Unknown
			//IL_2542: Unknown result type (might be due to invalid IL or missing references)
			//IL_2554: Unknown result type (might be due to invalid IL or missing references)
			//IL_255f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2564: Unknown result type (might be due to invalid IL or missing references)
			//IL_2574: Unknown result type (might be due to invalid IL or missing references)
			//IL_2584: Unknown result type (might be due to invalid IL or missing references)
			//IL_2594: Unknown result type (might be due to invalid IL or missing references)
			//IL_25a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_260d: Expected O, but got Unknown
			//IL_2608: Unknown result type (might be due to invalid IL or missing references)
			//IL_2612: Expected O, but got Unknown
			//IL_2612: Unknown result type (might be due to invalid IL or missing references)
			//IL_2624: Unknown result type (might be due to invalid IL or missing references)
			//IL_262e: Expected O, but got Unknown
			//IL_2629: Unknown result type (might be due to invalid IL or missing references)
			//IL_2633: Expected O, but got Unknown
			//IL_2638: Expected O, but got Unknown
			//IL_2654: Unknown result type (might be due to invalid IL or missing references)
			//IL_266f: Unknown result type (might be due to invalid IL or missing references)
			//IL_268a: Unknown result type (might be due to invalid IL or missing references)
			//IL_26d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_26de: Unknown result type (might be due to invalid IL or missing references)
			//IL_2726: Unknown result type (might be due to invalid IL or missing references)
			//IL_272b: Unknown result type (might be due to invalid IL or missing references)
			//IL_272e: Expected O, but got Unknown
			//IL_2733: Expected O, but got Unknown
			//IL_2733: Unknown result type (might be due to invalid IL or missing references)
			//IL_2745: Unknown result type (might be due to invalid IL or missing references)
			//IL_2750: Unknown result type (might be due to invalid IL or missing references)
			//IL_2755: Unknown result type (might be due to invalid IL or missing references)
			//IL_2765: Unknown result type (might be due to invalid IL or missing references)
			//IL_2775: Unknown result type (might be due to invalid IL or missing references)
			//IL_2785: Unknown result type (might be due to invalid IL or missing references)
			//IL_2795: Unknown result type (might be due to invalid IL or missing references)
			//IL_27a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_27b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_27c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_27d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_27fe: Expected O, but got Unknown
			//IL_27f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2803: Expected O, but got Unknown
			//IL_2803: Unknown result type (might be due to invalid IL or missing references)
			//IL_2815: Unknown result type (might be due to invalid IL or missing references)
			//IL_281f: Expected O, but got Unknown
			//IL_281a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2824: Expected O, but got Unknown
			//IL_2829: Expected O, but got Unknown
			//IL_2886: Unknown result type (might be due to invalid IL or missing references)
			//IL_28a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_28a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_28e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_28ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_28ed: Expected O, but got Unknown
			//IL_28f2: Expected O, but got Unknown
			//IL_28f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2904: Unknown result type (might be due to invalid IL or missing references)
			//IL_290f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2914: Unknown result type (might be due to invalid IL or missing references)
			//IL_2924: Unknown result type (might be due to invalid IL or missing references)
			//IL_2934: Unknown result type (might be due to invalid IL or missing references)
			//IL_2944: Unknown result type (might be due to invalid IL or missing references)
			//IL_2954: Unknown result type (might be due to invalid IL or missing references)
			//IL_2964: Unknown result type (might be due to invalid IL or missing references)
			//IL_2974: Unknown result type (might be due to invalid IL or missing references)
			//IL_2984: Unknown result type (might be due to invalid IL or missing references)
			//IL_2994: Unknown result type (might be due to invalid IL or missing references)
			//IL_29bd: Expected O, but got Unknown
			//IL_29b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_29c2: Expected O, but got Unknown
			//IL_29c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_29d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_29de: Expected O, but got Unknown
			//IL_29d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_29e3: Expected O, but got Unknown
			//IL_29e8: Expected O, but got Unknown
			//IL_2a16: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_2acb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ad0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b12: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b17: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b1a: Expected O, but got Unknown
			//IL_2b1f: Expected O, but got Unknown
			//IL_2b1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b31: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b41: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b51: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b61: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b71: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b81: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b91: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ba1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bea: Expected O, but got Unknown
			//IL_2be5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bef: Expected O, but got Unknown
			//IL_2bef: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c01: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c0b: Expected O, but got Unknown
			//IL_2c06: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c10: Expected O, but got Unknown
			//IL_2c15: Expected O, but got Unknown
			//IL_2c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c38: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c82: Expected O, but got Unknown
			//IL_2c87: Expected O, but got Unknown
			//IL_2c87: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c99: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ce9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cf9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d09: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d19: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d29: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d52: Expected O, but got Unknown
			//IL_2d4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d57: Expected O, but got Unknown
			//IL_2d57: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d69: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d73: Expected O, but got Unknown
			//IL_2d6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d78: Expected O, but got Unknown
			//IL_2d7d: Expected O, but got Unknown
			//IL_2d99: Unknown result type (might be due to invalid IL or missing references)
			//IL_2daf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e03: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e50: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e53: Expected O, but got Unknown
			//IL_2e58: Expected O, but got Unknown
			//IL_2e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e75: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eaa: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eba: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eca: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eea: Unknown result type (might be due to invalid IL or missing references)
			//IL_2efa: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f23: Expected O, but got Unknown
			//IL_2f1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f28: Expected O, but got Unknown
			//IL_2f28: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f44: Expected O, but got Unknown
			//IL_2f3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f49: Expected O, but got Unknown
			//IL_2f4e: Expected O, but got Unknown
			//IL_2f92: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3026: Unknown result type (might be due to invalid IL or missing references)
			//IL_302b: Unknown result type (might be due to invalid IL or missing references)
			//IL_302e: Expected O, but got Unknown
			//IL_3033: Expected O, but got Unknown
			//IL_3033: Unknown result type (might be due to invalid IL or missing references)
			//IL_3045: Unknown result type (might be due to invalid IL or missing references)
			//IL_3050: Unknown result type (might be due to invalid IL or missing references)
			//IL_3055: Unknown result type (might be due to invalid IL or missing references)
			//IL_3065: Unknown result type (might be due to invalid IL or missing references)
			//IL_3075: Unknown result type (might be due to invalid IL or missing references)
			//IL_3085: Unknown result type (might be due to invalid IL or missing references)
			//IL_3095: Unknown result type (might be due to invalid IL or missing references)
			//IL_30a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_30b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_30c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_30d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_30fe: Expected O, but got Unknown
			//IL_30f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3103: Expected O, but got Unknown
			//IL_3103: Unknown result type (might be due to invalid IL or missing references)
			//IL_3115: Unknown result type (might be due to invalid IL or missing references)
			//IL_311f: Expected O, but got Unknown
			//IL_311a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3124: Expected O, but got Unknown
			//IL_3129: Expected O, but got Unknown
			//IL_314c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3151: Unknown result type (might be due to invalid IL or missing references)
			//IL_319f: Unknown result type (might be due to invalid IL or missing references)
			//IL_31a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_31a7: Expected O, but got Unknown
			//IL_31ac: Expected O, but got Unknown
			//IL_31ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_31be: Unknown result type (might be due to invalid IL or missing references)
			//IL_31c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_31de: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_31fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_320e: Unknown result type (might be due to invalid IL or missing references)
			//IL_321e: Unknown result type (might be due to invalid IL or missing references)
			//IL_322e: Unknown result type (might be due to invalid IL or missing references)
			//IL_323e: Unknown result type (might be due to invalid IL or missing references)
			//IL_324e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3277: Expected O, but got Unknown
			//IL_3272: Unknown result type (might be due to invalid IL or missing references)
			//IL_327c: Expected O, but got Unknown
			//IL_327c: Unknown result type (might be due to invalid IL or missing references)
			//IL_328e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3298: Expected O, but got Unknown
			//IL_3293: Unknown result type (might be due to invalid IL or missing references)
			//IL_329d: Expected O, but got Unknown
			//IL_32a2: Expected O, but got Unknown
			//IL_32e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_333c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3341: Unknown result type (might be due to invalid IL or missing references)
			//IL_3344: Expected O, but got Unknown
			//IL_3349: Expected O, but got Unknown
			//IL_3349: Unknown result type (might be due to invalid IL or missing references)
			//IL_335b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3366: Unknown result type (might be due to invalid IL or missing references)
			//IL_336b: Unknown result type (might be due to invalid IL or missing references)
			//IL_337b: Unknown result type (might be due to invalid IL or missing references)
			//IL_338b: Unknown result type (might be due to invalid IL or missing references)
			//IL_339b: Unknown result type (might be due to invalid IL or missing references)
			//IL_33ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_33bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_33cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_33db: Unknown result type (might be due to invalid IL or missing references)
			//IL_33eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_3414: Expected O, but got Unknown
			//IL_340f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3419: Expected O, but got Unknown
			//IL_3419: Unknown result type (might be due to invalid IL or missing references)
			//IL_342b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3435: Expected O, but got Unknown
			//IL_3430: Unknown result type (might be due to invalid IL or missing references)
			//IL_343a: Expected O, but got Unknown
			//IL_343f: Expected O, but got Unknown
			//IL_3470: Unknown result type (might be due to invalid IL or missing references)
			//IL_3475: Unknown result type (might be due to invalid IL or missing references)
			//IL_34c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_34c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_34cb: Expected O, but got Unknown
			//IL_34d0: Expected O, but got Unknown
			//IL_34d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_34e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_34f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3502: Unknown result type (might be due to invalid IL or missing references)
			//IL_3512: Unknown result type (might be due to invalid IL or missing references)
			//IL_3522: Unknown result type (might be due to invalid IL or missing references)
			//IL_3532: Unknown result type (might be due to invalid IL or missing references)
			//IL_3542: Unknown result type (might be due to invalid IL or missing references)
			//IL_3552: Unknown result type (might be due to invalid IL or missing references)
			//IL_3562: Unknown result type (might be due to invalid IL or missing references)
			//IL_3572: Unknown result type (might be due to invalid IL or missing references)
			//IL_359b: Expected O, but got Unknown
			//IL_3596: Unknown result type (might be due to invalid IL or missing references)
			//IL_35a0: Expected O, but got Unknown
			//IL_35a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_35b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_35bc: Expected O, but got Unknown
			//IL_35b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_35c1: Expected O, but got Unknown
			//IL_35c6: Expected O, but got Unknown
			//IL_360d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3612: Unknown result type (might be due to invalid IL or missing references)
			//IL_3660: Unknown result type (might be due to invalid IL or missing references)
			//IL_3665: Unknown result type (might be due to invalid IL or missing references)
			//IL_3668: Expected O, but got Unknown
			//IL_366d: Expected O, but got Unknown
			//IL_366d: Unknown result type (might be due to invalid IL or missing references)
			//IL_367f: Unknown result type (might be due to invalid IL or missing references)
			//IL_368a: Unknown result type (might be due to invalid IL or missing references)
			//IL_368f: Unknown result type (might be due to invalid IL or missing references)
			//IL_369f: Unknown result type (might be due to invalid IL or missing references)
			//IL_36af: Unknown result type (might be due to invalid IL or missing references)
			//IL_36bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_36cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_36df: Unknown result type (might be due to invalid IL or missing references)
			//IL_36ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_36ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_370f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3738: Expected O, but got Unknown
			//IL_3733: Unknown result type (might be due to invalid IL or missing references)
			//IL_373d: Expected O, but got Unknown
			//IL_373d: Unknown result type (might be due to invalid IL or missing references)
			//IL_374f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3759: Expected O, but got Unknown
			//IL_3754: Unknown result type (might be due to invalid IL or missing references)
			//IL_375e: Expected O, but got Unknown
			//IL_3763: Expected O, but got Unknown
			//IL_377f: Unknown result type (might be due to invalid IL or missing references)
			//IL_37c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_37ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_3818: Unknown result type (might be due to invalid IL or missing references)
			//IL_381d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3820: Expected O, but got Unknown
			//IL_3825: Expected O, but got Unknown
			//IL_3825: Unknown result type (might be due to invalid IL or missing references)
			//IL_3837: Unknown result type (might be due to invalid IL or missing references)
			//IL_3842: Unknown result type (might be due to invalid IL or missing references)
			//IL_3847: Unknown result type (might be due to invalid IL or missing references)
			//IL_3857: Unknown result type (might be due to invalid IL or missing references)
			//IL_3867: Unknown result type (might be due to invalid IL or missing references)
			//IL_3877: Unknown result type (might be due to invalid IL or missing references)
			//IL_3887: Unknown result type (might be due to invalid IL or missing references)
			//IL_3897: Unknown result type (might be due to invalid IL or missing references)
			//IL_38a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_38b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_38c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_38f0: Expected O, but got Unknown
			//IL_38eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_38f5: Expected O, but got Unknown
			//IL_38f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3907: Unknown result type (might be due to invalid IL or missing references)
			//IL_3911: Expected O, but got Unknown
			//IL_390c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3916: Expected O, but got Unknown
			//IL_391b: Expected O, but got Unknown
			//IL_399e: Unknown result type (might be due to invalid IL or missing references)
			//IL_39a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_39e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_39e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_39e8: Expected O, but got Unknown
			//IL_39ed: Expected O, but got Unknown
			//IL_39ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_39ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ab8: Expected O, but got Unknown
			//IL_3ab3: Unknown result type (might be due to invalid IL or missing references)
			//IL_3abd: Expected O, but got Unknown
			//IL_3abd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3acf: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ad9: Expected O, but got Unknown
			//IL_3ad4: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ade: Expected O, but got Unknown
			//IL_3ae3: Expected O, but got Unknown
			//IL_3b3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b41: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b83: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b86: Expected O, but got Unknown
			//IL_3b8b: Expected O, but got Unknown
			//IL_3b8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ba8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bad: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bcd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bdd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bed: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c56: Expected O, but got Unknown
			//IL_3c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c5b: Expected O, but got Unknown
			//IL_3c5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c77: Expected O, but got Unknown
			//IL_3c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c7c: Expected O, but got Unknown
			//IL_3c81: Expected O, but got Unknown
			//IL_3cda: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d21: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d24: Expected O, but got Unknown
			//IL_3d29: Expected O, but got Unknown
			//IL_3d29: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d46: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dab: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_3df4: Expected O, but got Unknown
			//IL_3def: Unknown result type (might be due to invalid IL or missing references)
			//IL_3df9: Expected O, but got Unknown
			//IL_3df9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e15: Expected O, but got Unknown
			//IL_3e10: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e1a: Expected O, but got Unknown
			//IL_3e1f: Expected O, but got Unknown
			//IL_3e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3eba: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ebf: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ec2: Expected O, but got Unknown
			//IL_3ec7: Expected O, but got Unknown
			//IL_3ec7: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ed9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ee4: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ee9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ef9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f09: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f19: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f29: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f39: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f49: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f59: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f69: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f92: Expected O, but got Unknown
			//IL_3f8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f97: Expected O, but got Unknown
			//IL_3f97: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fa9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fb3: Expected O, but got Unknown
			//IL_3fae: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fb8: Expected O, but got Unknown
			//IL_3fbd: Expected O, but got Unknown
			//IL_4016: Unknown result type (might be due to invalid IL or missing references)
			//IL_401b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4058: Unknown result type (might be due to invalid IL or missing references)
			//IL_405d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4060: Expected O, but got Unknown
			//IL_4065: Expected O, but got Unknown
			//IL_4065: Unknown result type (might be due to invalid IL or missing references)
			//IL_4077: Unknown result type (might be due to invalid IL or missing references)
			//IL_4082: Unknown result type (might be due to invalid IL or missing references)
			//IL_4087: Unknown result type (might be due to invalid IL or missing references)
			//IL_4097: Unknown result type (might be due to invalid IL or missing references)
			//IL_40a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4107: Unknown result type (might be due to invalid IL or missing references)
			//IL_4130: Expected O, but got Unknown
			//IL_412b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4135: Expected O, but got Unknown
			//IL_4135: Unknown result type (might be due to invalid IL or missing references)
			//IL_4147: Unknown result type (might be due to invalid IL or missing references)
			//IL_4151: Expected O, but got Unknown
			//IL_414c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4156: Expected O, but got Unknown
			//IL_415b: Expected O, but got Unknown
			//IL_41b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_41b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_41f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_41fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_41fe: Expected O, but got Unknown
			//IL_4203: Expected O, but got Unknown
			//IL_4203: Unknown result type (might be due to invalid IL or missing references)
			//IL_4215: Unknown result type (might be due to invalid IL or missing references)
			//IL_4220: Unknown result type (might be due to invalid IL or missing references)
			//IL_4225: Unknown result type (might be due to invalid IL or missing references)
			//IL_4235: Unknown result type (might be due to invalid IL or missing references)
			//IL_4245: Unknown result type (might be due to invalid IL or missing references)
			//IL_4255: Unknown result type (might be due to invalid IL or missing references)
			//IL_4265: Unknown result type (might be due to invalid IL or missing references)
			//IL_4275: Unknown result type (might be due to invalid IL or missing references)
			//IL_4285: Unknown result type (might be due to invalid IL or missing references)
			//IL_4295: Unknown result type (might be due to invalid IL or missing references)
			//IL_42a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_42ce: Expected O, but got Unknown
			//IL_42c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_42d3: Expected O, but got Unknown
			//IL_42d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_42e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_42ef: Expected O, but got Unknown
			//IL_42ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_42f4: Expected O, but got Unknown
			//IL_42f9: Expected O, but got Unknown
			//IL_439b: Unknown result type (might be due to invalid IL or missing references)
			//IL_43f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_43f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4433: Unknown result type (might be due to invalid IL or missing references)
			//IL_4438: Unknown result type (might be due to invalid IL or missing references)
			//IL_443d: Expected O, but got Unknown
			//IL_4442: Expected O, but got Unknown
			//IL_4442: Unknown result type (might be due to invalid IL or missing references)
			//IL_4456: Unknown result type (might be due to invalid IL or missing references)
			//IL_4461: Unknown result type (might be due to invalid IL or missing references)
			//IL_4466: Unknown result type (might be due to invalid IL or missing references)
			//IL_4476: Unknown result type (might be due to invalid IL or missing references)
			//IL_4486: Unknown result type (might be due to invalid IL or missing references)
			//IL_4496: Unknown result type (might be due to invalid IL or missing references)
			//IL_44a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_44b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_44c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_44d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_44e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_450f: Expected O, but got Unknown
			//IL_450a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4514: Expected O, but got Unknown
			//IL_4514: Unknown result type (might be due to invalid IL or missing references)
			//IL_4526: Unknown result type (might be due to invalid IL or missing references)
			//IL_4530: Expected O, but got Unknown
			//IL_452b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4535: Expected O, but got Unknown
			//IL_453a: Expected O, but got Unknown
			//IL_459e: Unknown result type (might be due to invalid IL or missing references)
			//IL_45a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_45e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_45e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_45ea: Expected O, but got Unknown
			//IL_45ef: Expected O, but got Unknown
			//IL_45ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_4603: Unknown result type (might be due to invalid IL or missing references)
			//IL_460e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4613: Unknown result type (might be due to invalid IL or missing references)
			//IL_4623: Unknown result type (might be due to invalid IL or missing references)
			//IL_4633: Unknown result type (might be due to invalid IL or missing references)
			//IL_4643: Unknown result type (might be due to invalid IL or missing references)
			//IL_4653: Unknown result type (might be due to invalid IL or missing references)
			//IL_4663: Unknown result type (might be due to invalid IL or missing references)
			//IL_4673: Unknown result type (might be due to invalid IL or missing references)
			//IL_4683: Unknown result type (might be due to invalid IL or missing references)
			//IL_4693: Unknown result type (might be due to invalid IL or missing references)
			//IL_46bc: Expected O, but got Unknown
			//IL_46b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_46c1: Expected O, but got Unknown
			//IL_46c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_46d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_46dd: Expected O, but got Unknown
			//IL_46d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_46e2: Expected O, but got Unknown
			//IL_46e7: Expected O, but got Unknown
			//IL_4765: Unknown result type (might be due to invalid IL or missing references)
			//IL_477b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4791: Unknown result type (might be due to invalid IL or missing references)
			//IL_47a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_47c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_47c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4806: Unknown result type (might be due to invalid IL or missing references)
			//IL_480b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4810: Expected O, but got Unknown
			//IL_4815: Expected O, but got Unknown
			//IL_4815: Unknown result type (might be due to invalid IL or missing references)
			//IL_4829: Unknown result type (might be due to invalid IL or missing references)
			//IL_4834: Unknown result type (might be due to invalid IL or missing references)
			//IL_4839: Unknown result type (might be due to invalid IL or missing references)
			//IL_4849: Unknown result type (might be due to invalid IL or missing references)
			//IL_4859: Unknown result type (might be due to invalid IL or missing references)
			//IL_4869: Unknown result type (might be due to invalid IL or missing references)
			//IL_4879: Unknown result type (might be due to invalid IL or missing references)
			//IL_4889: Unknown result type (might be due to invalid IL or missing references)
			//IL_4899: Unknown result type (might be due to invalid IL or missing references)
			//IL_48a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_48b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_48e2: Expected O, but got Unknown
			//IL_48dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_48e7: Expected O, but got Unknown
			//IL_48e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_48f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4903: Expected O, but got Unknown
			//IL_48fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_4908: Expected O, but got Unknown
			//IL_490d: Expected O, but got Unknown
			//IL_493f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4970: Unknown result type (might be due to invalid IL or missing references)
			//IL_49d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a32: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ac6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4acb: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ad0: Expected O, but got Unknown
			//IL_4ad5: Expected O, but got Unknown
			//IL_4ad5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ae9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4af4: Unknown result type (might be due to invalid IL or missing references)
			//IL_4af9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b09: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b29: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b49: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b69: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ba2: Expected O, but got Unknown
			//IL_4b9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ba7: Expected O, but got Unknown
			//IL_4ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bc3: Expected O, but got Unknown
			//IL_4bbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bc8: Expected O, but got Unknown
			//IL_4bcd: Expected O, but got Unknown
			//IL_4be3: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c05: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c52: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c57: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c5c: Expected O, but got Unknown
			//IL_4c61: Expected O, but got Unknown
			//IL_4c61: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c75: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c80: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c85: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c95: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ca5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ce5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d05: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d2e: Expected O, but got Unknown
			//IL_4d29: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d33: Expected O, but got Unknown
			//IL_4d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d45: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d4f: Expected O, but got Unknown
			//IL_4d4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d54: Expected O, but got Unknown
			//IL_4d59: Expected O, but got Unknown
			//IL_4d79: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4df0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4df5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e42: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e47: Expected O, but got Unknown
			//IL_4e4c: Expected O, but got Unknown
			//IL_4e4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e60: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e70: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e80: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e90: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ea0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4eb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ec0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ed0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ee0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ef0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f19: Expected O, but got Unknown
			//IL_4f14: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f1e: Expected O, but got Unknown
			//IL_4f1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f30: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f3a: Expected O, but got Unknown
			//IL_4f35: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f3f: Expected O, but got Unknown
			//IL_4f44: Expected O, but got Unknown
			//IL_4f64: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f86: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fdd: Expected O, but got Unknown
			//IL_4fe2: Expected O, but got Unknown
			//IL_4fe2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5001: Unknown result type (might be due to invalid IL or missing references)
			//IL_5006: Unknown result type (might be due to invalid IL or missing references)
			//IL_5016: Unknown result type (might be due to invalid IL or missing references)
			//IL_5026: Unknown result type (might be due to invalid IL or missing references)
			//IL_5036: Unknown result type (might be due to invalid IL or missing references)
			//IL_5046: Unknown result type (might be due to invalid IL or missing references)
			//IL_5056: Unknown result type (might be due to invalid IL or missing references)
			//IL_5066: Unknown result type (might be due to invalid IL or missing references)
			//IL_5076: Unknown result type (might be due to invalid IL or missing references)
			//IL_5086: Unknown result type (might be due to invalid IL or missing references)
			//IL_50af: Expected O, but got Unknown
			//IL_50aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_50b4: Expected O, but got Unknown
			//IL_50b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_50c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_50d0: Expected O, but got Unknown
			//IL_50cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_50d5: Expected O, but got Unknown
			//IL_50da: Expected O, but got Unknown
			//IL_50fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_5125: Unknown result type (might be due to invalid IL or missing references)
			//IL_512a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5172: Unknown result type (might be due to invalid IL or missing references)
			//IL_5177: Unknown result type (might be due to invalid IL or missing references)
			//IL_517c: Expected O, but got Unknown
			//IL_5181: Expected O, but got Unknown
			//IL_5181: Unknown result type (might be due to invalid IL or missing references)
			//IL_5195: Unknown result type (might be due to invalid IL or missing references)
			//IL_51a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_51a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5205: Unknown result type (might be due to invalid IL or missing references)
			//IL_5215: Unknown result type (might be due to invalid IL or missing references)
			//IL_5225: Unknown result type (might be due to invalid IL or missing references)
			//IL_524e: Expected O, but got Unknown
			//IL_5249: Unknown result type (might be due to invalid IL or missing references)
			//IL_5253: Expected O, but got Unknown
			//IL_5253: Unknown result type (might be due to invalid IL or missing references)
			//IL_5265: Unknown result type (might be due to invalid IL or missing references)
			//IL_526f: Expected O, but got Unknown
			//IL_526a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5274: Expected O, but got Unknown
			//IL_5279: Expected O, but got Unknown
			//IL_528f: Unknown result type (might be due to invalid IL or missing references)
			//IL_52b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_52b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_52fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_5303: Unknown result type (might be due to invalid IL or missing references)
			//IL_5308: Expected O, but got Unknown
			//IL_530d: Expected O, but got Unknown
			//IL_530d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5321: Unknown result type (might be due to invalid IL or missing references)
			//IL_532c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5331: Unknown result type (might be due to invalid IL or missing references)
			//IL_5341: Unknown result type (might be due to invalid IL or missing references)
			//IL_5351: Unknown result type (might be due to invalid IL or missing references)
			//IL_5361: Unknown result type (might be due to invalid IL or missing references)
			//IL_5371: Unknown result type (might be due to invalid IL or missing references)
			//IL_5381: Unknown result type (might be due to invalid IL or missing references)
			//IL_5391: Unknown result type (might be due to invalid IL or missing references)
			//IL_53a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_53b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_53da: Expected O, but got Unknown
			//IL_53d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_53df: Expected O, but got Unknown
			//IL_53df: Unknown result type (might be due to invalid IL or missing references)
			//IL_53f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_53fb: Expected O, but got Unknown
			//IL_53f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5400: Expected O, but got Unknown
			//IL_5405: Expected O, but got Unknown
			//IL_542c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5431: Unknown result type (might be due to invalid IL or missing references)
			//IL_5479: Unknown result type (might be due to invalid IL or missing references)
			//IL_547e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5483: Expected O, but got Unknown
			//IL_5488: Expected O, but got Unknown
			//IL_5488: Unknown result type (might be due to invalid IL or missing references)
			//IL_549c: Unknown result type (might be due to invalid IL or missing references)
			//IL_54a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_54ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_54bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_54cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_54dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_54ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_54fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_550c: Unknown result type (might be due to invalid IL or missing references)
			//IL_551c: Unknown result type (might be due to invalid IL or missing references)
			//IL_552c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5555: Expected O, but got Unknown
			//IL_5550: Unknown result type (might be due to invalid IL or missing references)
			//IL_555a: Expected O, but got Unknown
			//IL_555a: Unknown result type (might be due to invalid IL or missing references)
			//IL_556c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5576: Expected O, but got Unknown
			//IL_5571: Unknown result type (might be due to invalid IL or missing references)
			//IL_557b: Expected O, but got Unknown
			//IL_5580: Expected O, but got Unknown
			//IL_55a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_5608: Unknown result type (might be due to invalid IL or missing references)
			//IL_561e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5634: Unknown result type (might be due to invalid IL or missing references)
			//IL_5651: Unknown result type (might be due to invalid IL or missing references)
			//IL_5656: Unknown result type (might be due to invalid IL or missing references)
			//IL_5693: Unknown result type (might be due to invalid IL or missing references)
			//IL_5698: Unknown result type (might be due to invalid IL or missing references)
			//IL_569d: Expected O, but got Unknown
			//IL_56a2: Expected O, but got Unknown
			//IL_56a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_56b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_56c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_56c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_56d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_56e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_56f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5706: Unknown result type (might be due to invalid IL or missing references)
			//IL_5716: Unknown result type (might be due to invalid IL or missing references)
			//IL_5726: Unknown result type (might be due to invalid IL or missing references)
			//IL_5736: Unknown result type (might be due to invalid IL or missing references)
			//IL_5746: Unknown result type (might be due to invalid IL or missing references)
			//IL_576f: Expected O, but got Unknown
			//IL_576a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5774: Expected O, but got Unknown
			//IL_5774: Unknown result type (might be due to invalid IL or missing references)
			//IL_5786: Unknown result type (might be due to invalid IL or missing references)
			//IL_5790: Expected O, but got Unknown
			//IL_578b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5795: Expected O, but got Unknown
			//IL_579a: Expected O, but got Unknown
			//IL_57c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_57f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_585a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5888: Unknown result type (might be due to invalid IL or missing references)
			//IL_58b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_58fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_5902: Unknown result type (might be due to invalid IL or missing references)
			//IL_594a: Unknown result type (might be due to invalid IL or missing references)
			//IL_594f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5954: Expected O, but got Unknown
			//IL_5959: Expected O, but got Unknown
			//IL_5959: Unknown result type (might be due to invalid IL or missing references)
			//IL_596d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5978: Unknown result type (might be due to invalid IL or missing references)
			//IL_597d: Unknown result type (might be due to invalid IL or missing references)
			//IL_598d: Unknown result type (might be due to invalid IL or missing references)
			//IL_599d: Unknown result type (might be due to invalid IL or missing references)
			//IL_59ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_59bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_59cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_59dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_59ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_59fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a26: Expected O, but got Unknown
			//IL_5a21: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a2b: Expected O, but got Unknown
			//IL_5a2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a47: Expected O, but got Unknown
			//IL_5a42: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a4c: Expected O, but got Unknown
			//IL_5a51: Expected O, but got Unknown
			//IL_5a67: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a89: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ad6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5adb: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ae0: Expected O, but got Unknown
			//IL_5ae5: Expected O, but got Unknown
			//IL_5ae5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5af9: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b04: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b09: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b29: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b49: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b69: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b89: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bb2: Expected O, but got Unknown
			//IL_5bad: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bb7: Expected O, but got Unknown
			//IL_5bb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bd3: Expected O, but got Unknown
			//IL_5bce: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bd8: Expected O, but got Unknown
			//IL_5bdd: Expected O, but got Unknown
			//IL_5bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c13: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c74: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c79: Unknown result type (might be due to invalid IL or missing references)
			//IL_5cc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_5cc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ccb: Expected O, but got Unknown
			//IL_5cd0: Expected O, but got Unknown
			//IL_5cd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ce4: Unknown result type (might be due to invalid IL or missing references)
			//IL_5cef: Unknown result type (might be due to invalid IL or missing references)
			//IL_5cf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d04: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d24: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d34: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d44: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d54: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d64: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d74: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d9d: Expected O, but got Unknown
			//IL_5d98: Unknown result type (might be due to invalid IL or missing references)
			//IL_5da2: Expected O, but got Unknown
			//IL_5da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_5db4: Unknown result type (might be due to invalid IL or missing references)
			//IL_5dbe: Expected O, but got Unknown
			//IL_5db9: Unknown result type (might be due to invalid IL or missing references)
			//IL_5dc3: Expected O, but got Unknown
			//IL_5dc8: Expected O, but got Unknown
			//IL_5de8: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e57: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e61: Expected O, but got Unknown
			//IL_5e66: Expected O, but got Unknown
			//IL_5e66: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e85: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5eaa: Unknown result type (might be due to invalid IL or missing references)
			//IL_5eba: Unknown result type (might be due to invalid IL or missing references)
			//IL_5eca: Unknown result type (might be due to invalid IL or missing references)
			//IL_5eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_5eea: Unknown result type (might be due to invalid IL or missing references)
			//IL_5efa: Unknown result type (might be due to invalid IL or missing references)
			//IL_5f0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5f33: Expected O, but got Unknown
			//IL_5f2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5f38: Expected O, but got Unknown
			//IL_5f38: Unknown result type (might be due to invalid IL or missing references)
			//IL_5f4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5f54: Expected O, but got Unknown
			//IL_5f4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5f59: Expected O, but got Unknown
			//IL_5f5e: Expected O, but got Unknown
			//IL_5f7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5fa9: Unknown result type (might be due to invalid IL or missing references)
			//IL_5fae: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ffb: Unknown result type (might be due to invalid IL or missing references)
			//IL_6000: Expected O, but got Unknown
			//IL_6005: Expected O, but got Unknown
			//IL_6005: Unknown result type (might be due to invalid IL or missing references)
			//IL_6019: Unknown result type (might be due to invalid IL or missing references)
			//IL_6024: Unknown result type (might be due to invalid IL or missing references)
			//IL_6029: Unknown result type (might be due to invalid IL or missing references)
			//IL_6039: Unknown result type (might be due to invalid IL or missing references)
			//IL_6049: Unknown result type (might be due to invalid IL or missing references)
			//IL_6059: Unknown result type (might be due to invalid IL or missing references)
			//IL_6069: Unknown result type (might be due to invalid IL or missing references)
			//IL_6079: Unknown result type (might be due to invalid IL or missing references)
			//IL_6089: Unknown result type (might be due to invalid IL or missing references)
			//IL_6099: Unknown result type (might be due to invalid IL or missing references)
			//IL_60a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_60d2: Expected O, but got Unknown
			//IL_60cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_60d7: Expected O, but got Unknown
			//IL_60d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_60e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_60f3: Expected O, but got Unknown
			//IL_60ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_60f8: Expected O, but got Unknown
			//IL_60fd: Expected O, but got Unknown
			//IL_6113: Unknown result type (might be due to invalid IL or missing references)
			//IL_6135: Unknown result type (might be due to invalid IL or missing references)
			//IL_613a: Unknown result type (might be due to invalid IL or missing references)
			//IL_6182: Unknown result type (might be due to invalid IL or missing references)
			//IL_6187: Unknown result type (might be due to invalid IL or missing references)
			//IL_618c: Expected O, but got Unknown
			//IL_6191: Expected O, but got Unknown
			//IL_6191: Unknown result type (might be due to invalid IL or missing references)
			//IL_61a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_61b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_61b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_61c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_61d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_61e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_61f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_6205: Unknown result type (might be due to invalid IL or missing references)
			//IL_6215: Unknown result type (might be due to invalid IL or missing references)
			//IL_6225: Unknown result type (might be due to invalid IL or missing references)
			//IL_6235: Unknown result type (might be due to invalid IL or missing references)
			//IL_625e: Expected O, but got Unknown
			//IL_6259: Unknown result type (might be due to invalid IL or missing references)
			//IL_6263: Expected O, but got Unknown
			//IL_6263: Unknown result type (might be due to invalid IL or missing references)
			//IL_6275: Unknown result type (might be due to invalid IL or missing references)
			//IL_627f: Expected O, but got Unknown
			//IL_627a: Unknown result type (might be due to invalid IL or missing references)
			//IL_6284: Expected O, but got Unknown
			//IL_6289: Expected O, but got Unknown
			//IL_62b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_62b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_62fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_6302: Unknown result type (might be due to invalid IL or missing references)
			//IL_6307: Expected O, but got Unknown
			//IL_630c: Expected O, but got Unknown
			//IL_630c: Unknown result type (might be due to invalid IL or missing references)
			//IL_6320: Unknown result type (might be due to invalid IL or missing references)
			//IL_632b: Unknown result type (might be due to invalid IL or missing references)
			//IL_6330: Unknown result type (might be due to invalid IL or missing references)
			//IL_6340: Unknown result type (might be due to invalid IL or missing references)
			//IL_6350: Unknown result type (might be due to invalid IL or missing references)
			//IL_6360: Unknown result type (might be due to invalid IL or missing references)
			//IL_6370: Unknown result type (might be due to invalid IL or missing references)
			//IL_6380: Unknown result type (might be due to invalid IL or missing references)
			//IL_6390: Unknown result type (might be due to invalid IL or missing references)
			//IL_63a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_63b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_63d9: Expected O, but got Unknown
			//IL_63d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_63de: Expected O, but got Unknown
			//IL_63de: Unknown result type (might be due to invalid IL or missing references)
			//IL_63f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_63fa: Expected O, but got Unknown
			//IL_63f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_63ff: Expected O, but got Unknown
			//IL_6404: Expected O, but got Unknown
			//IL_6424: Unknown result type (might be due to invalid IL or missing references)
			//IL_648c: Unknown result type (might be due to invalid IL or missing references)
			//IL_64c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_64fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_654e: Unknown result type (might be due to invalid IL or missing references)
			//IL_6553: Unknown result type (might be due to invalid IL or missing references)
			//IL_6590: Unknown result type (might be due to invalid IL or missing references)
			//IL_6595: Unknown result type (might be due to invalid IL or missing references)
			//IL_659a: Expected O, but got Unknown
			//IL_659f: Expected O, but got Unknown
			//IL_659f: Unknown result type (might be due to invalid IL or missing references)
			//IL_65b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_65be: Unknown result type (might be due to invalid IL or missing references)
			//IL_65c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_65d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_65e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_65f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_6603: Unknown result type (might be due to invalid IL or missing references)
			//IL_6613: Unknown result type (might be due to invalid IL or missing references)
			//IL_6623: Unknown result type (might be due to invalid IL or missing references)
			//IL_6633: Unknown result type (might be due to invalid IL or missing references)
			//IL_6643: Unknown result type (might be due to invalid IL or missing references)
			//IL_666c: Expected O, but got Unknown
			//IL_6667: Unknown result type (might be due to invalid IL or missing references)
			//IL_6671: Expected O, but got Unknown
			//IL_6671: Unknown result type (might be due to invalid IL or missing references)
			//IL_6683: Unknown result type (might be due to invalid IL or missing references)
			//IL_668d: Expected O, but got Unknown
			//IL_6688: Unknown result type (might be due to invalid IL or missing references)
			//IL_6692: Expected O, but got Unknown
			//IL_6697: Expected O, but got Unknown
			//IL_66be: Unknown result type (might be due to invalid IL or missing references)
			//IL_66c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_6700: Unknown result type (might be due to invalid IL or missing references)
			//IL_6705: Unknown result type (might be due to invalid IL or missing references)
			//IL_670a: Expected O, but got Unknown
			//IL_670f: Expected O, but got Unknown
			//IL_670f: Unknown result type (might be due to invalid IL or missing references)
			//IL_6723: Unknown result type (might be due to invalid IL or missing references)
			//IL_672e: Unknown result type (might be due to invalid IL or missing references)
			//IL_6733: Unknown result type (might be due to invalid IL or missing references)
			//IL_6743: Unknown result type (might be due to invalid IL or missing references)
			//IL_6753: Unknown result type (might be due to invalid IL or missing references)
			//IL_6763: Unknown result type (might be due to invalid IL or missing references)
			//IL_6773: Unknown result type (might be due to invalid IL or missing references)
			//IL_6783: Unknown result type (might be due to invalid IL or missing references)
			//IL_6793: Unknown result type (might be due to invalid IL or missing references)
			//IL_67a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_67b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_67dc: Expected O, but got Unknown
			//IL_67d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_67e1: Expected O, but got Unknown
			//IL_67e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_67f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_67fd: Expected O, but got Unknown
			//IL_67f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_6802: Expected O, but got Unknown
			//IL_6807: Expected O, but got Unknown
			//IL_6827: Unknown result type (might be due to invalid IL or missing references)
			//IL_6842: Unknown result type (might be due to invalid IL or missing references)
			//IL_687c: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(MainView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/MainView.xaml");
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
			BindingExtension val2 = new BindingExtension();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			BindingExtension val4 = new BindingExtension();
			BindingExtension val5 = new BindingExtension();
			DynamicResourceExtension val6 = new DynamicResourceExtension();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			BindingExtension val8 = new BindingExtension();
			BindingExtension val9 = new BindingExtension();
			TapGestureRecognizer val10 = new TapGestureRecognizer();
			StaticResourceExtension val11 = new StaticResourceExtension();
			Label val12 = new Label();
			string appVersion_NewVersion_Banner = Resources.AppVersion_NewVersion_Banner;
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			Label val14 = new Label();
			StaticResourceExtension val15 = new StaticResourceExtension();
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			Label val17 = new Label();
			StackLayout val18 = new StackLayout();
			DynamicResourceExtension val19 = new DynamicResourceExtension();
			string homePage_NotificationsTitle = Resources.HomePage_NotificationsTitle;
			Label val20 = new Label();
			DynamicResourceExtension val21 = new DynamicResourceExtension();
			DynamicResourceExtension val22 = new DynamicResourceExtension();
			BindingExtension val23 = new BindingExtension();
			Label val24 = new Label();
			StackLayout val25 = new StackLayout();
			string homePage_ViewAll = Resources.HomePage_ViewAll;
			DynamicResourceExtension val26 = new DynamicResourceExtension();
			BindingExtension val27 = new BindingExtension();
			BindingExtension val28 = new BindingExtension();
			TapGestureRecognizer val29 = new TapGestureRecognizer();
			Label val30 = new Label();
			StackLayout val31 = new StackLayout();
			StaticResourceExtension val32 = new StaticResourceExtension();
			BindingExtension val33 = new BindingExtension();
			BindingExtension val34 = new BindingExtension();
			DataTemplate val35 = new DataTemplate();
			StackLayout val36 = new StackLayout();
			ScrollView val37 = new ScrollView();
			DynamicResourceExtension val38 = new DynamicResourceExtension();
			BindingExtension val39 = new BindingExtension();
			DynamicResourceExtension val40 = new DynamicResourceExtension();
			BoxView val41 = new BoxView();
			BindingExtension val42 = new BindingExtension();
			DefaultAnimationExtension val43 = new DefaultAnimationExtension();
			DynamicResourceExtension val44 = new DynamicResourceExtension();
			DynamicResourceExtension val45 = new DynamicResourceExtension();
			string homePage_YouHaveNoNewNotifications = Resources.HomePage_YouHaveNoNewNotifications;
			BindingExtension val46 = new BindingExtension();
			DynamicResourceExtension val47 = new DynamicResourceExtension();
			Label val48 = new Label();
			StackLayout val49 = new StackLayout();
			StackLayout val50 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			DynamicResourceExtension val51 = new DynamicResourceExtension();
			BindingExtension val52 = new BindingExtension();
			DefaultAnimationExtension val53 = new DefaultAnimationExtension();
			DynamicResourceExtension val54 = new DynamicResourceExtension();
			string homePage_ExpectedEndDate = Resources.HomePage_ExpectedEndDate;
			BindingExtension val55 = new BindingExtension();
			DynamicResourceExtension val56 = new DynamicResourceExtension();
			Label val57 = new Label();
			BindingExtension val58 = new BindingExtension();
			DynamicResourceExtension val59 = new DynamicResourceExtension();
			DynamicResourceExtension val60 = new DynamicResourceExtension();
			BindingExtension val61 = new BindingExtension();
			DynamicResourceExtension val62 = new DynamicResourceExtension();
			Label val63 = new Label();
			DynamicResourceExtension val64 = new DynamicResourceExtension();
			BindingExtension val65 = new BindingExtension();
			DynamicResourceExtension val66 = new DynamicResourceExtension();
			BindingExtension val67 = new BindingExtension();
			DynamicResourceExtension val68 = new DynamicResourceExtension();
			Label val69 = new Label();
			StackLayout val70 = new StackLayout();
			StackLayout val71 = new StackLayout();
			ShadowFrame shadowFrame2 = new ShadowFrame();
			Grid val72 = new Grid();
			StaticResourceExtension val73 = new StaticResourceExtension();
			string homePage_SymptomCheck = Resources.HomePage_SymptomCheck;
			BindingExtension val74 = new BindingExtension();
			ButtonMainView buttonMainView = new ButtonMainView();
			StaticResourceExtension val75 = new StaticResourceExtension();
			string homePage_TestingScheduleAndCalendar = Resources.HomePage_TestingScheduleAndCalendar;
			BindingExtension val76 = new BindingExtension();
			ButtonMainView buttonMainView2 = new ButtonMainView();
			StaticResourceExtension val77 = new StaticResourceExtension();
			string homePage_CheckIn = Resources.HomePage_CheckIn;
			BindingExtension val78 = new BindingExtension();
			ButtonMainView buttonMainView3 = new ButtonMainView();
			StaticResourceExtension val79 = new StaticResourceExtension();
			string homePage_SupportResources = Resources.HomePage_SupportResources;
			BindingExtension val80 = new BindingExtension();
			ButtonMainView buttonMainView4 = new ButtonMainView();
			StaticResourceExtension val81 = new StaticResourceExtension();
			string homePage_QuarantineGuidelines = Resources.HomePage_QuarantineGuidelines;
			BindingExtension val82 = new BindingExtension();
			ButtonMainView buttonMainView5 = new ButtonMainView();
			StaticResourceExtension val83 = new StaticResourceExtension();
			string homePage_FAQs = Resources.HomePage_FAQs;
			BindingExtension val84 = new BindingExtension();
			ButtonMainView buttonMainView6 = new ButtonMainView();
			StackLayout val85 = new StackLayout();
			BindingExtension val86 = new BindingExtension();
			StaticResourceExtension val87 = new StaticResourceExtension();
			BindingExtension val88 = new BindingExtension();
			ButtonMainView buttonMainView7 = new ButtonMainView();
			StaticResourceExtension val89 = new StaticResourceExtension();
			BindingExtension val90 = new BindingExtension();
			ButtonMainView buttonMainView8 = new ButtonMainView();
			StackLayout val91 = new StackLayout();
			DynamicResourceExtension val92 = new DynamicResourceExtension();
			BindingExtension val93 = new BindingExtension();
			TapGestureRecognizer val94 = new TapGestureRecognizer();
			ColumnDefinition val95 = new ColumnDefinition();
			ColumnDefinition val96 = new ColumnDefinition();
			ColumnDefinition val97 = new ColumnDefinition();
			StaticResourceExtension val98 = new StaticResourceExtension();
			DynamicResourceExtension val99 = new DynamicResourceExtension();
			Label val100 = new Label();
			string homePage_ControlBranch = Resources.HomePage_ControlBranch;
			DynamicResourceExtension val101 = new DynamicResourceExtension();
			DynamicResourceExtension val102 = new DynamicResourceExtension();
			Label val103 = new Label();
			StaticResourceExtension val104 = new StaticResourceExtension();
			DynamicResourceExtension val105 = new DynamicResourceExtension();
			DynamicResourceExtension val106 = new DynamicResourceExtension();
			Label val107 = new Label();
			Grid val108 = new Grid();
			Frame val109 = new Frame();
			DynamicResourceExtension val110 = new DynamicResourceExtension();
			BindingExtension val111 = new BindingExtension();
			TapGestureRecognizer val112 = new TapGestureRecognizer();
			ColumnDefinition val113 = new ColumnDefinition();
			ColumnDefinition val114 = new ColumnDefinition();
			ColumnDefinition val115 = new ColumnDefinition();
			StaticResourceExtension val116 = new StaticResourceExtension();
			DynamicResourceExtension val117 = new DynamicResourceExtension();
			Label val118 = new Label();
			string homePage_ControlBranchPrivacy = Resources.HomePage_ControlBranchPrivacy;
			DynamicResourceExtension val119 = new DynamicResourceExtension();
			DynamicResourceExtension val120 = new DynamicResourceExtension();
			Label val121 = new Label();
			StaticResourceExtension val122 = new StaticResourceExtension();
			DynamicResourceExtension val123 = new DynamicResourceExtension();
			DynamicResourceExtension val124 = new DynamicResourceExtension();
			Label val125 = new Label();
			Grid val126 = new Grid();
			Frame val127 = new Frame();
			TintedCachedImage tintedCachedImage2 = new TintedCachedImage();
			BindingExtension val128 = new BindingExtension();
			DynamicResourceExtension val129 = new DynamicResourceExtension();
			DynamicResourceExtension val130 = new DynamicResourceExtension();
			Label val131 = new Label();
			StackLayout val132 = new StackLayout();
			StackLayout val133 = new StackLayout();
			StackLayout val134 = new StackLayout();
			ScrollView val135 = new ScrollView();
			RefreshView val136 = new RefreshView();
			MainView mainView;
			NameScope val137 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(mainView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)mainView, (INameScope)(object)val137);
			((INameScope)val137).RegisterName("mainPage", (object)mainView);
			if (((Element)mainView).get_StyleId() == null)
			{
				((Element)mainView).set_StyleId("mainPage");
			}
			((INameScope)val137).RegisterName("containingView", (object)val133);
			if (((Element)val133).get_StyleId() == null)
			{
				((Element)val133).set_StyleId("containingView");
			}
			((INameScope)val137).RegisterName("textMessage", (object)val20);
			if (((Element)val20).get_StyleId() == null)
			{
				((Element)val20).set_StyleId("textMessage");
			}
			((INameScope)val137).RegisterName("notificationCount", (object)val24);
			if (((Element)val24).get_StyleId() == null)
			{
				((Element)val24).set_StyleId("notificationCount");
			}
			((INameScope)val137).RegisterName("viewAllNotificationsLabel", (object)val30);
			if (((Element)val30).get_StyleId() == null)
			{
				((Element)val30).set_StyleId("viewAllNotificationsLabel");
			}
			((INameScope)val137).RegisterName("linkTapGesture", (object)val29);
			if (((Element)val29).get_StyleId() == null)
			{
				((Element)val29).set_StyleId("linkTapGesture");
			}
			((INameScope)val137).RegisterName("border", (object)val41);
			if (((Element)val41).get_StyleId() == null)
			{
				((Element)val41).set_StyleId("border");
			}
			((INameScope)val137).RegisterName("expectedDate", (object)val57);
			if (((Element)val57).get_StyleId() == null)
			{
				((Element)val57).set_StyleId("expectedDate");
			}
			((INameScope)val137).RegisterName("expectedDay", (object)val63);
			if (((Element)val63).get_StyleId() == null)
			{
				((Element)val63).set_StyleId("expectedDay");
			}
			((INameScope)val137).RegisterName("expectedDatedetails", (object)val69);
			if (((Element)val69).get_StyleId() == null)
			{
				((Element)val69).set_StyleId("expectedDatedetails");
			}
			((INameScope)val137).RegisterName("iconLabel", (object)val107);
			if (((Element)val107).get_StyleId() == null)
			{
				((Element)val107).set_StyleId("iconLabel");
			}
			((INameScope)val137).RegisterName("versionNumberLabel", (object)val131);
			if (((Element)val131).get_StyleId() == null)
			{
				((Element)val131).set_StyleId("versionNumberLabel");
			}
			mainPage = mainView;
			containingView = val133;
			textMessage = val20;
			notificationCount = val24;
			viewAllNotificationsLabel = val30;
			linkTapGesture = val29;
			border = val41;
			expectedDate = val57;
			expectedDay = val63;
			expectedDatedetails = val69;
			iconLabel = val107;
			versionNumberLabel = val131;
			((BindableObject)mainView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Path("MainViewTitle");
			BindingBase val138 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)mainView).SetBinding(Page.TitleProperty, val138);
			val3.set_Key("AppLogo");
			XamlServiceProvider val139 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = tintedCachedImage;
			array[1] = mainView;
			SimpleValueTargetProvider val140 = new SimpleValueTargetProvider(array, (object)CachedImage.SourceProperty, (INameScope)(object)val137);
			object obj = (object)val140;
			val139.Add(typeFromHandle, (object)val140);
			val139.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val141 = new XmlNamespaceResolver();
			val141.Add("", "http://xamarin.com/schemas/2014/forms");
			val141.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val141.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val141.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val141.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val141.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val141.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val141.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val141.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val139.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val141, typeof(MainView).GetTypeInfo().Assembly));
			val139.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 13)));
			DynamicResource val142 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val139);
			((IDynamicResourceHandler)tintedCachedImage).SetDynamicResource(CachedImage.SourceProperty, val142.get_Key());
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)tintedCachedImage).SetValue(VisualElement.WidthRequestProperty, (object)200.0);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0, 8.0));
			((BindableObject)mainView).SetValue(NavigationPage.TitleViewProperty, (object)tintedCachedImage);
			((VisualElement)mainView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)mainView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			val4.set_Path("RefreshCommand");
			BindingBase val143 = ((IMarkupExtension<BindingBase>)(object)val4).ProvideValue((IServiceProvider)null);
			((BindableObject)val136).SetBinding(RefreshView.CommandProperty, val143);
			val5.set_Path("IsRefreshing");
			BindingBase val144 = ((IMarkupExtension<BindingBase>)(object)val5).ProvideValue((IServiceProvider)null);
			((BindableObject)val136).SetBinding(RefreshView.IsRefreshingProperty, val144);
			val6.set_Key("SecondaryTextColor");
			XamlServiceProvider val145 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 2];
			array2[0] = val136;
			array2[1] = mainView;
			SimpleValueTargetProvider val146 = new SimpleValueTargetProvider(array2, (object)RefreshView.RefreshColorProperty, (INameScope)(object)val137);
			object obj2 = (object)val146;
			val145.Add(typeFromHandle3, (object)val146);
			val145.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val147 = new XmlNamespaceResolver();
			val147.Add("", "http://xamarin.com/schemas/2014/forms");
			val147.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val147.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val147.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val147.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val147.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val147.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val147.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val147.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val145.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val147, typeof(MainView).GetTypeInfo().Assembly));
			val145.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 13)));
			DynamicResource val148 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val145);
			((IDynamicResourceHandler)val136).SetDynamicResource(RefreshView.RefreshColorProperty, val148.get_Key());
			((BindableObject)val136).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val135).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val134).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val18).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val7.set_Key("SecondaryColor");
			XamlServiceProvider val149 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 5];
			array3[0] = val18;
			array3[1] = val134;
			array3[2] = val135;
			array3[3] = val136;
			array3[4] = mainView;
			SimpleValueTargetProvider val150 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val137);
			object obj3 = (object)val150;
			val149.Add(typeFromHandle5, (object)val150);
			val149.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val151 = new XmlNamespaceResolver();
			val151.Add("", "http://xamarin.com/schemas/2014/forms");
			val151.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val151.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val151.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val151.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val151.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val151.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val151.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val151.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val149.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val151, typeof(MainView).GetTypeInfo().Assembly));
			val149.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 25)));
			DynamicResource val152 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val149);
			((IDynamicResourceHandler)val18).SetDynamicResource(VisualElement.BackgroundColorProperty, val152.get_Key());
			((BindableObject)val18).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			val8.set_Path("AppIsNotLatestVersion");
			BindingBase val153 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)val18).SetBinding(VisualElement.IsVisibleProperty, val153);
			val9.set_Path("OpenVersionUpdateCommand");
			BindingBase val154 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)null);
			((BindableObject)val10).SetBinding(TapGestureRecognizer.CommandProperty, val154);
			((View)val18).get_GestureRecognizers().Add((IGestureRecognizer)(object)val10);
			val11.set_Key("faArrowRight");
			XamlServiceProvider val155 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 6];
			array4[0] = val12;
			array4[1] = val18;
			array4[2] = val134;
			array4[3] = val135;
			array4[4] = val136;
			array4[5] = mainView;
			SimpleValueTargetProvider val156 = new SimpleValueTargetProvider(array4, (object)Label.TextProperty, (INameScope)(object)val137);
			object obj4 = (object)val156;
			val155.Add(typeFromHandle7, (object)val156);
			val155.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val157 = new XmlNamespaceResolver();
			val157.Add("", "http://xamarin.com/schemas/2014/forms");
			val157.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val157.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val157.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val157.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val157.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val157.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val157.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val157.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val155.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val157, typeof(MainView).GetTypeInfo().Assembly));
			val155.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(41, 29)));
			object text = ((IMarkupExtension)val11).ProvideValue((IServiceProvider)val155);
			val12.set_Text((string)text);
			((BindableObject)val12).SetValue(Label.TextColorProperty, (object)Color.Transparent);
			((BindableObject)val12).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val12).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val12).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val12);
			((BindableObject)val14).SetValue(Label.TextProperty, (object)appVersion_NewVersion_Banner);
			val13.set_Key("ButtonTextColor");
			XamlServiceProvider val158 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 6];
			array5[0] = val14;
			array5[1] = val18;
			array5[2] = val134;
			array5[3] = val135;
			array5[4] = val136;
			array5[5] = mainView;
			SimpleValueTargetProvider val159 = new SimpleValueTargetProvider(array5, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj5 = (object)val159;
			val158.Add(typeFromHandle9, (object)val159);
			val158.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val160 = new XmlNamespaceResolver();
			val160.Add("", "http://xamarin.com/schemas/2014/forms");
			val160.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val160.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val160.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val160.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val160.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val160.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val160.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val160.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val158.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val160, typeof(MainView).GetTypeInfo().Assembly));
			val158.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 29)));
			DynamicResource val161 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val158);
			((IDynamicResourceHandler)val14).SetDynamicResource(Label.TextColorProperty, val161.get_Key());
			((BindableObject)val14).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val14).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val14).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val14).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val14);
			val15.set_Key("faArrowRight");
			XamlServiceProvider val162 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 6];
			array6[0] = val17;
			array6[1] = val18;
			array6[2] = val134;
			array6[3] = val135;
			array6[4] = val136;
			array6[5] = mainView;
			SimpleValueTargetProvider val163 = new SimpleValueTargetProvider(array6, (object)Label.TextProperty, (INameScope)(object)val137);
			object obj6 = (object)val163;
			val162.Add(typeFromHandle11, (object)val163);
			val162.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val164 = new XmlNamespaceResolver();
			val164.Add("", "http://xamarin.com/schemas/2014/forms");
			val164.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val164.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val164.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val164.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val164.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val164.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val164.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val164.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val162.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val164, typeof(MainView).GetTypeInfo().Assembly));
			val162.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 29)));
			object text2 = ((IMarkupExtension)val15).ProvideValue((IServiceProvider)val162);
			val17.set_Text((string)text2);
			val16.set_Key("ButtonTextColor");
			XamlServiceProvider val165 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 6];
			array7[0] = val17;
			array7[1] = val18;
			array7[2] = val134;
			array7[3] = val135;
			array7[4] = val136;
			array7[5] = mainView;
			SimpleValueTargetProvider val166 = new SimpleValueTargetProvider(array7, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj7 = (object)val166;
			val165.Add(typeFromHandle13, (object)val166);
			val165.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val167 = new XmlNamespaceResolver();
			val167.Add("", "http://xamarin.com/schemas/2014/forms");
			val167.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val167.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val167.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val167.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val167.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val167.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val167.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val167.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val165.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val167, typeof(MainView).GetTypeInfo().Assembly));
			val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 29)));
			DynamicResource val168 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val165);
			((IDynamicResourceHandler)val17).SetDynamicResource(Label.TextColorProperty, val168.get_Key());
			((BindableObject)val17).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val17).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val17).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val17);
			((Layout<View>)(object)val134).get_Children().Add((View)(object)val18);
			((BindableObject)val133).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val133).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val133).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val31).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val31).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((BindableObject)val25).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val25).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			val19.set_Key("Heading2");
			XamlServiceProvider val169 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 8];
			array8[0] = val20;
			array8[1] = val25;
			array8[2] = val31;
			array8[3] = val133;
			array8[4] = val134;
			array8[5] = val135;
			array8[6] = val136;
			array8[7] = mainView;
			SimpleValueTargetProvider val170 = new SimpleValueTargetProvider(array8, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj8 = (object)val170;
			val169.Add(typeFromHandle15, (object)val170);
			val169.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val171 = new XmlNamespaceResolver();
			val171.Add("", "http://xamarin.com/schemas/2014/forms");
			val171.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val171.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val171.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val171.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val171.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val171.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val171.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val171.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val169.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val171, typeof(MainView).GetTypeInfo().Assembly));
			val169.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(75, 37)));
			DynamicResource val172 = ((IMarkupExtension<DynamicResource>)(object)val19).ProvideValue((IServiceProvider)val169);
			((IDynamicResourceHandler)val20).SetDynamicResource(VisualElement.StyleProperty, val172.get_Key());
			((BindableObject)val20).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val20).SetValue(Label.TextProperty, (object)homePage_NotificationsTitle);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val20);
			val21.set_Key("Heading2");
			XamlServiceProvider val173 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 8];
			array9[0] = val24;
			array9[1] = val25;
			array9[2] = val31;
			array9[3] = val133;
			array9[4] = val134;
			array9[5] = val135;
			array9[6] = val136;
			array9[7] = mainView;
			SimpleValueTargetProvider val174 = new SimpleValueTargetProvider(array9, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj9 = (object)val174;
			val173.Add(typeFromHandle17, (object)val174);
			val173.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val175 = new XmlNamespaceResolver();
			val175.Add("", "http://xamarin.com/schemas/2014/forms");
			val175.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val175.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val175.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val175.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val175.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val175.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val175.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val175.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val173.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val175, typeof(MainView).GetTypeInfo().Assembly));
			val173.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 37)));
			DynamicResource val176 = ((IMarkupExtension<DynamicResource>)(object)val21).ProvideValue((IServiceProvider)val173);
			((IDynamicResourceHandler)val24).SetDynamicResource(VisualElement.StyleProperty, val176.get_Key());
			((BindableObject)val24).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val22.set_Key("PrimaryColor");
			XamlServiceProvider val177 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 8];
			array10[0] = val24;
			array10[1] = val25;
			array10[2] = val31;
			array10[3] = val133;
			array10[4] = val134;
			array10[5] = val135;
			array10[6] = val136;
			array10[7] = mainView;
			SimpleValueTargetProvider val178 = new SimpleValueTargetProvider(array10, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj10 = (object)val178;
			val177.Add(typeFromHandle19, (object)val178);
			val177.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val179 = new XmlNamespaceResolver();
			val179.Add("", "http://xamarin.com/schemas/2014/forms");
			val179.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val179.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val179.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val179.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val179.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val179.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val179.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val179.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val177.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val179, typeof(MainView).GetTypeInfo().Assembly));
			val177.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(82, 37)));
			DynamicResource val180 = ((IMarkupExtension<DynamicResource>)(object)val22).ProvideValue((IServiceProvider)val177);
			((IDynamicResourceHandler)val24).SetDynamicResource(Label.TextColorProperty, val180.get_Key());
			val23.set_Path("NotificationCountLabel");
			BindingBase val181 = ((IMarkupExtension<BindingBase>)(object)val23).ProvideValue((IServiceProvider)null);
			((BindableObject)val24).SetBinding(Label.TextProperty, val181);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val24);
			((Layout<View>)(object)val31).get_Children().Add((View)(object)val25);
			((BindableObject)val30).SetValue(Label.TextProperty, (object)homePage_ViewAll);
			val26.set_Key("SecondaryLinkColor");
			XamlServiceProvider val182 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 7];
			array11[0] = val30;
			array11[1] = val31;
			array11[2] = val133;
			array11[3] = val134;
			array11[4] = val135;
			array11[5] = val136;
			array11[6] = mainView;
			SimpleValueTargetProvider val183 = new SimpleValueTargetProvider(array11, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj11 = (object)val183;
			val182.Add(typeFromHandle21, (object)val183);
			val182.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val184 = new XmlNamespaceResolver();
			val184.Add("", "http://xamarin.com/schemas/2014/forms");
			val184.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val184.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val184.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val184.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val184.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val184.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val184.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val184.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val182.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val184, typeof(MainView).GetTypeInfo().Assembly));
			val182.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 33)));
			DynamicResource val185 = ((IMarkupExtension<DynamicResource>)(object)val26).ProvideValue((IServiceProvider)val182);
			((IDynamicResourceHandler)val30).SetDynamicResource(Label.TextColorProperty, val185.get_Key());
			((BindableObject)val30).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val30).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val30).SetValue(Label.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val27.set_Path("ShowViewAllNotifications");
			BindingBase val186 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)null);
			((BindableObject)val30).SetBinding(VisualElement.IsVisibleProperty, val186);
			val28.set_Path("ViewAllNotificationCommand");
			BindingBase val187 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)null);
			((BindableObject)val29).SetBinding(TapGestureRecognizer.CommandProperty, val187);
			((View)val30).get_GestureRecognizers().Add((IGestureRecognizer)(object)val29);
			((Layout<View>)(object)val31).get_Children().Add((View)(object)val30);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)val31);
			((BindableObject)val37).SetValue(ScrollView.OrientationProperty, (object)(ScrollOrientation)1);
			((BindableObject)val37).SetValue(ScrollView.HorizontalScrollBarVisibilityProperty, (object)(ScrollBarVisibility)2);
			((BindableObject)val37).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.StartAndExpand);
			((BindableObject)val37).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val32.set_Key("InverseBoolConverter");
			XamlServiceProvider val188 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 7];
			array12[0] = val33;
			array12[1] = val37;
			array12[2] = val133;
			array12[3] = val134;
			array12[4] = val135;
			array12[5] = val136;
			array12[6] = mainView;
			SimpleValueTargetProvider val189 = new SimpleValueTargetProvider(array12, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val137);
			object obj12 = (object)val189;
			val188.Add(typeFromHandle23, (object)val189);
			val188.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val190 = new XmlNamespaceResolver();
			val190.Add("", "http://xamarin.com/schemas/2014/forms");
			val190.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val190.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val190.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val190.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val190.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val190.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val190.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val190.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val188.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val190, typeof(MainView).GetTypeInfo().Assembly));
			val188.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(107, 29)));
			object converter = ((IMarkupExtension)val32).ProvideValue((IServiceProvider)val188);
			val33.set_Converter((IValueConverter)converter);
			val33.set_Path("NoUnreadNotifications");
			BindingBase val191 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)null);
			((BindableObject)val37).SetBinding(VisualElement.IsVisibleProperty, val191);
			val34.set_Path("UnreadNotifications");
			BindingBase val192 = ((IMarkupExtension<BindingBase>)(object)val34).ProvideValue((IServiceProvider)null);
			((BindableObject)val36).SetBinding(BindableLayout.ItemsSourceProperty, val192);
			((BindableObject)val36).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			object[] array13 = new object[0 + 8];
			array13[0] = val35;
			array13[1] = val36;
			array13[2] = val37;
			array13[3] = val133;
			array13[4] = val134;
			array13[5] = val135;
			array13[6] = val136;
			array13[7] = mainView;
			object[] parentValues = array13;
			MainView root = mainView;
			((IDataTemplate)val35).set_LoadTemplate((Func<object>)delegate
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
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Expected O, but got Unknown
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Expected O, but got Unknown
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected O, but got Unknown
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Expected O, but got Unknown
				//IL_011a: Expected O, but got Unknown
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Unknown result type (might be due to invalid IL or missing references)
				//IL_013c: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Expected O, but got Unknown
				//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Expected O, but got Unknown
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0203: Expected O, but got Unknown
				//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0208: Expected O, but got Unknown
				//IL_020d: Expected O, but got Unknown
				//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0350: Unknown result type (might be due to invalid IL or missing references)
				//IL_0355: Unknown result type (might be due to invalid IL or missing references)
				//IL_0358: Expected O, but got Unknown
				//IL_035d: Expected O, but got Unknown
				//IL_035d: Unknown result type (might be due to invalid IL or missing references)
				//IL_036f: Unknown result type (might be due to invalid IL or missing references)
				//IL_037a: Unknown result type (might be due to invalid IL or missing references)
				//IL_037f: Unknown result type (might be due to invalid IL or missing references)
				//IL_038f: Unknown result type (might be due to invalid IL or missing references)
				//IL_039f: Unknown result type (might be due to invalid IL or missing references)
				//IL_03af: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_03df: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0428: Expected O, but got Unknown
				//IL_0423: Unknown result type (might be due to invalid IL or missing references)
				//IL_042d: Expected O, but got Unknown
				//IL_042d: Unknown result type (might be due to invalid IL or missing references)
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0446: Expected O, but got Unknown
				//IL_0441: Unknown result type (might be due to invalid IL or missing references)
				//IL_044b: Expected O, but got Unknown
				//IL_0450: Expected O, but got Unknown
				BindingExtension val370 = new BindingExtension();
				ReferenceExtension val371 = new ReferenceExtension();
				BindingExtension val372 = new BindingExtension();
				BindingExtension val373 = new BindingExtension();
				BindingExtension val374 = new BindingExtension();
				BindingExtension val375 = new BindingExtension();
				BindingExtension val376 = new BindingExtension();
				BindingExtension val377 = new BindingExtension();
				ReferenceExtension val378 = new ReferenceExtension();
				BindingExtension val379 = new BindingExtension();
				BindingExtension val380 = new BindingExtension();
				NotificationView notificationView = new NotificationView();
				NameScope val381 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)notificationView, (INameScope)(object)val381);
				((BindableObject)notificationView).SetValue(NotificationView.ShowBorderProperty, (object)true);
				val370.set_Path("Title");
				BindingBase val382 = ((IMarkupExtension<BindingBase>)(object)val370).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TitleProperty, val382);
				((BindableObject)notificationView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
				val371.set_Name("mainPage");
				XamlServiceProvider val383 = new XamlServiceProvider();
				Type typeFromHandle109 = typeof(IProvideValueTarget);
				int length;
				object[] array56 = new object[(length = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array56, 2, length);
				array56[0] = val372;
				array56[1] = notificationView;
				SimpleValueTargetProvider val384 = new SimpleValueTargetProvider(array56, (object)typeof(BindingExtension).GetRuntimeProperty("Source"), (INameScope)(object)val381);
				object obj63 = (object)val384;
				val383.Add(typeFromHandle109, (object)val384);
				val383.Add(typeof(IReferenceProvider), obj63);
				Type typeFromHandle110 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val385 = new XmlNamespaceResolver();
				val385.Add("", "http://xamarin.com/schemas/2014/forms");
				val385.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val385.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
				val385.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val385.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val385.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val385.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val385.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val385.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
				val383.Add(typeFromHandle110, (object)new XamlTypeResolver((IXmlNamespaceResolver)val385, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_6).GetTypeInfo().Assembly));
				val383.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(117, 45)));
				object source = ((IMarkupExtension)val371).ProvideValue((IServiceProvider)val383);
				val372.set_Source(source);
				val372.set_Path("BindingContext.NotificationWidth");
				BindingBase val386 = ((IMarkupExtension<BindingBase>)(object)val372).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(VisualElement.WidthRequestProperty, val386);
				val373.set_Path("DateCreatedLabel");
				BindingBase val387 = ((IMarkupExtension<BindingBase>)(object)val373).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.DateProperty, val387);
				val374.set_Path("Description");
				BindingBase val388 = ((IMarkupExtension<BindingBase>)(object)val374).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.DescriptionProperty, val388);
				val375.set_Path("ActionLabel");
				BindingBase val389 = ((IMarkupExtension<BindingBase>)(object)val375).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.ActionLabelProperty, val389);
				val376.set_Path("IsFirst");
				BindingBase val390 = ((IMarkupExtension<BindingBase>)(object)val376).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.IsFirstProperty, val390);
				val377.set_Path("IsLast");
				BindingBase val391 = ((IMarkupExtension<BindingBase>)(object)val377).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.IsLastProperty, val391);
				val378.set_Name("mainPage");
				XamlServiceProvider val392 = new XamlServiceProvider();
				Type typeFromHandle111 = typeof(IProvideValueTarget);
				int length2;
				object[] array57 = new object[(length2 = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array57, 2, length2);
				array57[0] = val379;
				array57[1] = notificationView;
				SimpleValueTargetProvider val393 = new SimpleValueTargetProvider(array57, (object)typeof(BindingExtension).GetRuntimeProperty("Source"), (INameScope)(object)val381);
				object obj64 = (object)val393;
				val392.Add(typeFromHandle111, (object)val393);
				val392.Add(typeof(IReferenceProvider), obj64);
				Type typeFromHandle112 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val394 = new XmlNamespaceResolver();
				val394.Add("", "http://xamarin.com/schemas/2014/forms");
				val394.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val394.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
				val394.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val394.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val394.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val394.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val394.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val394.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
				val392.Add(typeFromHandle112, (object)new XamlTypeResolver((IXmlNamespaceResolver)val394, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_6).GetTypeInfo().Assembly));
				val392.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(123, 45)));
				object source2 = ((IMarkupExtension)val378).ProvideValue((IServiceProvider)val392);
				val379.set_Source(source2);
				val379.set_Path("BindingContext.NotificationTapCommand");
				BindingBase val395 = ((IMarkupExtension<BindingBase>)(object)val379).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TapCommandProperty, val395);
				val380.set_Path(".");
				BindingBase val396 = ((IMarkupExtension<BindingBase>)(object)val380).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TapCommandParameterProperty, val396);
				return notificationView;
			});
			((BindableObject)val36).SetValue(BindableLayout.ItemTemplateProperty, (object)val35);
			val37.set_Content((View)(object)val36);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)val37);
			((BindableObject)shadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)shadowFrame).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val38.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val193 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array14 = new object[0 + 6];
			array14[0] = shadowFrame;
			array14[1] = val133;
			array14[2] = val134;
			array14[3] = val135;
			array14[4] = val136;
			array14[5] = mainView;
			SimpleValueTargetProvider val194 = new SimpleValueTargetProvider(array14, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val137);
			object obj13 = (object)val194;
			val193.Add(typeFromHandle25, (object)val194);
			val193.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val195 = new XmlNamespaceResolver();
			val195.Add("", "http://xamarin.com/schemas/2014/forms");
			val195.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val195.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val195.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val195.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val195.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val195.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val195.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val195.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val193.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val195, typeof(MainView).GetTypeInfo().Assembly));
			val193.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(136, 29)));
			DynamicResource val196 = ((IMarkupExtension<DynamicResource>)(object)val38).ProvideValue((IServiceProvider)val193);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val196.get_Key());
			val39.set_Path("NoUnreadNotifications");
			BindingBase val197 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)null);
			((BindableObject)shadowFrame).SetBinding(VisualElement.IsVisibleProperty, val197);
			((BindableObject)val50).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val50).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val41).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val40.set_Key("GrayColor");
			XamlServiceProvider val198 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array15 = new object[0 + 8];
			array15[0] = val41;
			array15[1] = val50;
			array15[2] = shadowFrame;
			array15[3] = val133;
			array15[4] = val134;
			array15[5] = val135;
			array15[6] = val136;
			array15[7] = mainView;
			SimpleValueTargetProvider val199 = new SimpleValueTargetProvider(array15, (object)BoxView.ColorProperty, (INameScope)(object)val137);
			object obj14 = (object)val199;
			val198.Add(typeFromHandle27, (object)val199);
			val198.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val200 = new XmlNamespaceResolver();
			val200.Add("", "http://xamarin.com/schemas/2014/forms");
			val200.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val200.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val200.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val200.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val200.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val200.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val200.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val200.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val198.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val200, typeof(MainView).GetTypeInfo().Assembly));
			val198.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(144, 37)));
			DynamicResource val201 = ((IMarkupExtension<DynamicResource>)(object)val40).ProvideValue((IServiceProvider)val198);
			((IDynamicResourceHandler)val41).SetDynamicResource(BoxView.ColorProperty, val201.get_Key());
			((Layout<View>)(object)val50).get_Children().Add((View)(object)val41);
			((BindableObject)val49).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 16.0, 16.0, 24.0));
			((BindableObject)val49).SetValue(StackLayout.SpacingProperty, (object)8.0);
			((BindableObject)val49).SetValue(Skeleton.IsParentProperty, (object)true);
			val42.set_Path("IsDoingInitialLoad");
			BindingBase val202 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)null);
			((BindableObject)val49).SetBinding(Skeleton.IsBusyProperty, val202);
			val43.set_Source((AnimationTypes)2);
			XamlServiceProvider val203 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array16 = new object[0 + 8];
			array16[0] = val49;
			array16[1] = val50;
			array16[2] = shadowFrame;
			array16[3] = val133;
			array16[4] = val134;
			array16[5] = val135;
			array16[6] = val136;
			array16[7] = mainView;
			SimpleValueTargetProvider val204 = new SimpleValueTargetProvider(array16, (object)Skeleton.AnimationProperty, (INameScope)(object)val137);
			object obj15 = (object)val204;
			val203.Add(typeFromHandle29, (object)val204);
			val203.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val205 = new XmlNamespaceResolver();
			val205.Add("", "http://xamarin.com/schemas/2014/forms");
			val205.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val205.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val205.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val205.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val205.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val205.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val205.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val205.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val203.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val205, typeof(MainView).GetTypeInfo().Assembly));
			val203.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(150, 37)));
			BaseAnimation val206 = ((IMarkupExtension<BaseAnimation>)(object)val43).ProvideValue((IServiceProvider)val203);
			((BindableObject)val49).SetValue(Skeleton.AnimationProperty, (object)val206);
			val44.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val207 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array17 = new object[0 + 8];
			array17[0] = val49;
			array17[1] = val50;
			array17[2] = shadowFrame;
			array17[3] = val133;
			array17[4] = val134;
			array17[5] = val135;
			array17[6] = val136;
			array17[7] = mainView;
			SimpleValueTargetProvider val208 = new SimpleValueTargetProvider(array17, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val137);
			object obj16 = (object)val208;
			val207.Add(typeFromHandle31, (object)val208);
			val207.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val209 = new XmlNamespaceResolver();
			val209.Add("", "http://xamarin.com/schemas/2014/forms");
			val209.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val209.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val209.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val209.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val209.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val209.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val209.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val209.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val207.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val209, typeof(MainView).GetTypeInfo().Assembly));
			val207.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(151, 37)));
			DynamicResource val210 = ((IMarkupExtension<DynamicResource>)(object)val44).ProvideValue((IServiceProvider)val207);
			((IDynamicResourceHandler)val49).SetDynamicResource(Skeleton.BackgroundColorProperty, val210.get_Key());
			((BindableObject)val48).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			val45.set_Key("Small");
			XamlServiceProvider val211 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array18 = new object[0 + 9];
			array18[0] = val48;
			array18[1] = val49;
			array18[2] = val50;
			array18[3] = shadowFrame;
			array18[4] = val133;
			array18[5] = val134;
			array18[6] = val135;
			array18[7] = val136;
			array18[8] = mainView;
			SimpleValueTargetProvider val212 = new SimpleValueTargetProvider(array18, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj17 = (object)val212;
			val211.Add(typeFromHandle33, (object)val212);
			val211.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val213 = new XmlNamespaceResolver();
			val213.Add("", "http://xamarin.com/schemas/2014/forms");
			val213.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val213.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val213.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val213.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val213.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val213.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val213.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val213.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val211.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val213, typeof(MainView).GetTypeInfo().Assembly));
			val211.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(154, 41)));
			DynamicResource val214 = ((IMarkupExtension<DynamicResource>)(object)val45).ProvideValue((IServiceProvider)val211);
			((IDynamicResourceHandler)val48).SetDynamicResource(VisualElement.StyleProperty, val214.get_Key());
			((BindableObject)val48).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Italic"));
			((BindableObject)val48).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val48).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)val48).SetValue(Label.TextProperty, (object)homePage_YouHaveNoNewNotifications);
			val46.set_Path("IsDoingInitialLoad");
			BindingBase val215 = ((IMarkupExtension<BindingBase>)(object)val46).ProvideValue((IServiceProvider)null);
			((BindableObject)val48).SetBinding(Skeleton.IsBusyProperty, val215);
			val47.set_Key("GrayColor");
			XamlServiceProvider val216 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array19 = new object[0 + 9];
			array19[0] = val48;
			array19[1] = val49;
			array19[2] = val50;
			array19[3] = shadowFrame;
			array19[4] = val133;
			array19[5] = val134;
			array19[6] = val135;
			array19[7] = val136;
			array19[8] = mainView;
			SimpleValueTargetProvider val217 = new SimpleValueTargetProvider(array19, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val137);
			object obj18 = (object)val217;
			val216.Add(typeFromHandle35, (object)val217);
			val216.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val218 = new XmlNamespaceResolver();
			val218.Add("", "http://xamarin.com/schemas/2014/forms");
			val218.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val218.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val218.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val218.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val218.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val218.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val218.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val218.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val216.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val218, typeof(MainView).GetTypeInfo().Assembly));
			val216.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(160, 41)));
			DynamicResource val219 = ((IMarkupExtension<DynamicResource>)(object)val47).ProvideValue((IServiceProvider)val216);
			((IDynamicResourceHandler)val48).SetDynamicResource(Skeleton.BackgroundColorProperty, val219.get_Key());
			((Layout<View>)(object)val49).get_Children().Add((View)(object)val48);
			((Layout<View>)(object)val50).get_Children().Add((View)(object)val49);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val50);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)shadowFrame);
			((BindableObject)val72).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val51.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val220 = new XamlServiceProvider();
			Type typeFromHandle37 = typeof(IProvideValueTarget);
			object[] array20 = new object[0 + 7];
			array20[0] = shadowFrame2;
			array20[1] = val72;
			array20[2] = val133;
			array20[3] = val134;
			array20[4] = val135;
			array20[5] = val136;
			array20[6] = mainView;
			SimpleValueTargetProvider val221 = new SimpleValueTargetProvider(array20, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val137);
			object obj19 = (object)val221;
			val220.Add(typeFromHandle37, (object)val221);
			val220.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle38 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val222 = new XmlNamespaceResolver();
			val222.Add("", "http://xamarin.com/schemas/2014/forms");
			val222.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val222.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val222.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val222.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val222.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val222.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val222.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val222.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val220.Add(typeFromHandle38, (object)new XamlTypeResolver((IXmlNamespaceResolver)val222, typeof(MainView).GetTypeInfo().Assembly));
			val220.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(169, 33)));
			DynamicResource val223 = ((IMarkupExtension<DynamicResource>)(object)val51).ProvideValue((IServiceProvider)val220);
			((IDynamicResourceHandler)shadowFrame2).SetDynamicResource(VisualElement.BackgroundColorProperty, val223.get_Key());
			((BindableObject)shadowFrame2).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0));
			((BindableObject)shadowFrame2).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((BindableObject)val71).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val71).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val71).SetValue(Skeleton.IsParentProperty, (object)true);
			val52.set_Path("IsDoingInitialLoad");
			BindingBase val224 = ((IMarkupExtension<BindingBase>)(object)val52).ProvideValue((IServiceProvider)null);
			((BindableObject)val71).SetBinding(Skeleton.IsBusyProperty, val224);
			val53.set_Source((AnimationTypes)2);
			XamlServiceProvider val225 = new XamlServiceProvider();
			Type typeFromHandle39 = typeof(IProvideValueTarget);
			object[] array21 = new object[0 + 8];
			array21[0] = val71;
			array21[1] = shadowFrame2;
			array21[2] = val72;
			array21[3] = val133;
			array21[4] = val134;
			array21[5] = val135;
			array21[6] = val136;
			array21[7] = mainView;
			SimpleValueTargetProvider val226 = new SimpleValueTargetProvider(array21, (object)Skeleton.AnimationProperty, (INameScope)(object)val137);
			object obj20 = (object)val226;
			val225.Add(typeFromHandle39, (object)val226);
			val225.Add(typeof(IReferenceProvider), obj20);
			Type typeFromHandle40 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val227 = new XmlNamespaceResolver();
			val227.Add("", "http://xamarin.com/schemas/2014/forms");
			val227.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val227.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val227.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val227.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val227.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val227.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val227.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val227.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val225.Add(typeFromHandle40, (object)new XamlTypeResolver((IXmlNamespaceResolver)val227, typeof(MainView).GetTypeInfo().Assembly));
			val225.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(177, 37)));
			BaseAnimation val228 = ((IMarkupExtension<BaseAnimation>)(object)val53).ProvideValue((IServiceProvider)val225);
			((BindableObject)val71).SetValue(Skeleton.AnimationProperty, (object)val228);
			val54.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val229 = new XamlServiceProvider();
			Type typeFromHandle41 = typeof(IProvideValueTarget);
			object[] array22 = new object[0 + 8];
			array22[0] = val71;
			array22[1] = shadowFrame2;
			array22[2] = val72;
			array22[3] = val133;
			array22[4] = val134;
			array22[5] = val135;
			array22[6] = val136;
			array22[7] = mainView;
			SimpleValueTargetProvider val230 = new SimpleValueTargetProvider(array22, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val137);
			object obj21 = (object)val230;
			val229.Add(typeFromHandle41, (object)val230);
			val229.Add(typeof(IReferenceProvider), obj21);
			Type typeFromHandle42 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val231 = new XmlNamespaceResolver();
			val231.Add("", "http://xamarin.com/schemas/2014/forms");
			val231.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val231.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val231.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val231.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val231.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val231.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val231.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val231.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val229.Add(typeFromHandle42, (object)new XamlTypeResolver((IXmlNamespaceResolver)val231, typeof(MainView).GetTypeInfo().Assembly));
			val229.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(178, 37)));
			DynamicResource val232 = ((IMarkupExtension<DynamicResource>)(object)val54).ProvideValue((IServiceProvider)val229);
			((IDynamicResourceHandler)val71).SetDynamicResource(Skeleton.BackgroundColorProperty, val232.get_Key());
			((BindableObject)val57).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val57).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val57).SetValue(Label.TextProperty, (object)homePage_ExpectedEndDate);
			val55.set_Path("IsDoingInitialLoad");
			BindingBase val233 = ((IMarkupExtension<BindingBase>)(object)val55).ProvideValue((IServiceProvider)null);
			((BindableObject)val57).SetBinding(Skeleton.IsBusyProperty, val233);
			val56.set_Key("TertiaryTextColor");
			XamlServiceProvider val234 = new XamlServiceProvider();
			Type typeFromHandle43 = typeof(IProvideValueTarget);
			object[] array23 = new object[0 + 9];
			array23[0] = val57;
			array23[1] = val71;
			array23[2] = shadowFrame2;
			array23[3] = val72;
			array23[4] = val133;
			array23[5] = val134;
			array23[6] = val135;
			array23[7] = val136;
			array23[8] = mainView;
			SimpleValueTargetProvider val235 = new SimpleValueTargetProvider(array23, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val137);
			object obj22 = (object)val235;
			val234.Add(typeFromHandle43, (object)val235);
			val234.Add(typeof(IReferenceProvider), obj22);
			Type typeFromHandle44 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val236 = new XmlNamespaceResolver();
			val236.Add("", "http://xamarin.com/schemas/2014/forms");
			val236.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val236.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val236.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val236.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val236.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val236.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val236.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val236.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val234.Add(typeFromHandle44, (object)new XamlTypeResolver((IXmlNamespaceResolver)val236, typeof(MainView).GetTypeInfo().Assembly));
			val234.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(185, 41)));
			DynamicResource val237 = ((IMarkupExtension<DynamicResource>)(object)val56).ProvideValue((IServiceProvider)val234);
			((IDynamicResourceHandler)val57).SetDynamicResource(Skeleton.BackgroundColorProperty, val237.get_Key());
			((Layout<View>)(object)val71).get_Children().Add((View)(object)val57);
			((BindableObject)val70).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val70).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.EndAndExpand);
			val58.set_Path("ExpectedEndDayLabel");
			BindingBase val238 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)null);
			((BindableObject)val63).SetBinding(Label.TextProperty, val238);
			val59.set_Key("SecondaryColor");
			XamlServiceProvider val239 = new XamlServiceProvider();
			Type typeFromHandle45 = typeof(IProvideValueTarget);
			object[] array24 = new object[0 + 10];
			array24[0] = val63;
			array24[1] = val70;
			array24[2] = val71;
			array24[3] = shadowFrame2;
			array24[4] = val72;
			array24[5] = val133;
			array24[6] = val134;
			array24[7] = val135;
			array24[8] = val136;
			array24[9] = mainView;
			SimpleValueTargetProvider val240 = new SimpleValueTargetProvider(array24, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj23 = (object)val240;
			val239.Add(typeFromHandle45, (object)val240);
			val239.Add(typeof(IReferenceProvider), obj23);
			Type typeFromHandle46 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val241 = new XmlNamespaceResolver();
			val241.Add("", "http://xamarin.com/schemas/2014/forms");
			val241.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val241.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val241.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val241.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val241.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val241.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val241.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val241.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val239.Add(typeFromHandle46, (object)new XamlTypeResolver((IXmlNamespaceResolver)val241, typeof(MainView).GetTypeInfo().Assembly));
			val239.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(192, 45)));
			DynamicResource val242 = ((IMarkupExtension<DynamicResource>)(object)val59).ProvideValue((IServiceProvider)val239);
			((IDynamicResourceHandler)val63).SetDynamicResource(Label.TextColorProperty, val242.get_Key());
			val60.set_Key("Small");
			XamlServiceProvider val243 = new XamlServiceProvider();
			Type typeFromHandle47 = typeof(IProvideValueTarget);
			object[] array25 = new object[0 + 10];
			array25[0] = val63;
			array25[1] = val70;
			array25[2] = val71;
			array25[3] = shadowFrame2;
			array25[4] = val72;
			array25[5] = val133;
			array25[6] = val134;
			array25[7] = val135;
			array25[8] = val136;
			array25[9] = mainView;
			SimpleValueTargetProvider val244 = new SimpleValueTargetProvider(array25, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj24 = (object)val244;
			val243.Add(typeFromHandle47, (object)val244);
			val243.Add(typeof(IReferenceProvider), obj24);
			Type typeFromHandle48 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val245 = new XmlNamespaceResolver();
			val245.Add("", "http://xamarin.com/schemas/2014/forms");
			val245.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val245.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val245.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val245.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val245.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val245.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val245.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val245.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val243.Add(typeFromHandle48, (object)new XamlTypeResolver((IXmlNamespaceResolver)val245, typeof(MainView).GetTypeInfo().Assembly));
			val243.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(193, 45)));
			DynamicResource val246 = ((IMarkupExtension<DynamicResource>)(object)val60).ProvideValue((IServiceProvider)val243);
			((IDynamicResourceHandler)val63).SetDynamicResource(VisualElement.StyleProperty, val246.get_Key());
			val61.set_Path("IsDoingInitialLoad");
			BindingBase val247 = ((IMarkupExtension<BindingBase>)(object)val61).ProvideValue((IServiceProvider)null);
			((BindableObject)val63).SetBinding(Skeleton.IsBusyProperty, val247);
			val62.set_Key("GrayColor");
			XamlServiceProvider val248 = new XamlServiceProvider();
			Type typeFromHandle49 = typeof(IProvideValueTarget);
			object[] array26 = new object[0 + 10];
			array26[0] = val63;
			array26[1] = val70;
			array26[2] = val71;
			array26[3] = shadowFrame2;
			array26[4] = val72;
			array26[5] = val133;
			array26[6] = val134;
			array26[7] = val135;
			array26[8] = val136;
			array26[9] = mainView;
			SimpleValueTargetProvider val249 = new SimpleValueTargetProvider(array26, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val137);
			object obj25 = (object)val249;
			val248.Add(typeFromHandle49, (object)val249);
			val248.Add(typeof(IReferenceProvider), obj25);
			Type typeFromHandle50 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val250 = new XmlNamespaceResolver();
			val250.Add("", "http://xamarin.com/schemas/2014/forms");
			val250.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val250.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val250.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val250.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val250.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val250.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val250.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val250.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val248.Add(typeFromHandle50, (object)new XamlTypeResolver((IXmlNamespaceResolver)val250, typeof(MainView).GetTypeInfo().Assembly));
			val248.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(195, 45)));
			DynamicResource val251 = ((IMarkupExtension<DynamicResource>)(object)val62).ProvideValue((IServiceProvider)val248);
			((IDynamicResourceHandler)val63).SetDynamicResource(Skeleton.BackgroundColorProperty, val251.get_Key());
			((Layout<View>)(object)val70).get_Children().Add((View)(object)val63);
			val64.set_Key("Heading2");
			XamlServiceProvider val252 = new XamlServiceProvider();
			Type typeFromHandle51 = typeof(IProvideValueTarget);
			object[] array27 = new object[0 + 10];
			array27[0] = val69;
			array27[1] = val70;
			array27[2] = val71;
			array27[3] = shadowFrame2;
			array27[4] = val72;
			array27[5] = val133;
			array27[6] = val134;
			array27[7] = val135;
			array27[8] = val136;
			array27[9] = mainView;
			SimpleValueTargetProvider val253 = new SimpleValueTargetProvider(array27, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj26 = (object)val253;
			val252.Add(typeFromHandle51, (object)val253);
			val252.Add(typeof(IReferenceProvider), obj26);
			Type typeFromHandle52 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val254 = new XmlNamespaceResolver();
			val254.Add("", "http://xamarin.com/schemas/2014/forms");
			val254.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val254.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val254.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val254.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val254.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val254.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val254.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val254.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val252.Add(typeFromHandle52, (object)new XamlTypeResolver((IXmlNamespaceResolver)val254, typeof(MainView).GetTypeInfo().Assembly));
			val252.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(198, 45)));
			DynamicResource val255 = ((IMarkupExtension<DynamicResource>)(object)val64).ProvideValue((IServiceProvider)val252);
			((IDynamicResourceHandler)val69).SetDynamicResource(VisualElement.StyleProperty, val255.get_Key());
			val65.set_Path("ExpectedEndDateLabel");
			BindingBase val256 = ((IMarkupExtension<BindingBase>)(object)val65).ProvideValue((IServiceProvider)null);
			((BindableObject)val69).SetBinding(Label.TextProperty, val256);
			val66.set_Key("SecondaryColor");
			XamlServiceProvider val257 = new XamlServiceProvider();
			Type typeFromHandle53 = typeof(IProvideValueTarget);
			object[] array28 = new object[0 + 10];
			array28[0] = val69;
			array28[1] = val70;
			array28[2] = val71;
			array28[3] = shadowFrame2;
			array28[4] = val72;
			array28[5] = val133;
			array28[6] = val134;
			array28[7] = val135;
			array28[8] = val136;
			array28[9] = mainView;
			SimpleValueTargetProvider val258 = new SimpleValueTargetProvider(array28, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj27 = (object)val258;
			val257.Add(typeFromHandle53, (object)val258);
			val257.Add(typeof(IReferenceProvider), obj27);
			Type typeFromHandle54 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val259 = new XmlNamespaceResolver();
			val259.Add("", "http://xamarin.com/schemas/2014/forms");
			val259.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val259.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val259.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val259.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val259.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val259.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val259.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val259.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val257.Add(typeFromHandle54, (object)new XamlTypeResolver((IXmlNamespaceResolver)val259, typeof(MainView).GetTypeInfo().Assembly));
			val257.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(200, 45)));
			DynamicResource val260 = ((IMarkupExtension<DynamicResource>)(object)val66).ProvideValue((IServiceProvider)val257);
			((IDynamicResourceHandler)val69).SetDynamicResource(Label.TextColorProperty, val260.get_Key());
			((BindableObject)val69).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val67.set_Path("IsDoingInitialLoad");
			BindingBase val261 = ((IMarkupExtension<BindingBase>)(object)val67).ProvideValue((IServiceProvider)null);
			((BindableObject)val69).SetBinding(Skeleton.IsBusyProperty, val261);
			val68.set_Key("TertiaryTextColor");
			XamlServiceProvider val262 = new XamlServiceProvider();
			Type typeFromHandle55 = typeof(IProvideValueTarget);
			object[] array29 = new object[0 + 10];
			array29[0] = val69;
			array29[1] = val70;
			array29[2] = val71;
			array29[3] = shadowFrame2;
			array29[4] = val72;
			array29[5] = val133;
			array29[6] = val134;
			array29[7] = val135;
			array29[8] = val136;
			array29[9] = mainView;
			SimpleValueTargetProvider val263 = new SimpleValueTargetProvider(array29, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val137);
			object obj28 = (object)val263;
			val262.Add(typeFromHandle55, (object)val263);
			val262.Add(typeof(IReferenceProvider), obj28);
			Type typeFromHandle56 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val264 = new XmlNamespaceResolver();
			val264.Add("", "http://xamarin.com/schemas/2014/forms");
			val264.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val264.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val264.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val264.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val264.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val264.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val264.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val264.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val262.Add(typeFromHandle56, (object)new XamlTypeResolver((IXmlNamespaceResolver)val264, typeof(MainView).GetTypeInfo().Assembly));
			val262.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(203, 45)));
			DynamicResource val265 = ((IMarkupExtension<DynamicResource>)(object)val68).ProvideValue((IServiceProvider)val262);
			((IDynamicResourceHandler)val69).SetDynamicResource(Skeleton.BackgroundColorProperty, val265.get_Key());
			((Layout<View>)(object)val70).get_Children().Add((View)(object)val69);
			((Layout<View>)(object)val71).get_Children().Add((View)(object)val70);
			((BindableObject)shadowFrame2).SetValue(ContentView.ContentProperty, (object)val71);
			((ICollection<View>)val72.get_Children()).Add((View)(object)shadowFrame2);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)val72);
			((BindableObject)val85).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val73.set_Key("faStethoscope");
			XamlServiceProvider val266 = new XamlServiceProvider();
			Type typeFromHandle57 = typeof(IProvideValueTarget);
			object[] array30 = new object[0 + 7];
			array30[0] = buttonMainView;
			array30[1] = val85;
			array30[2] = val133;
			array30[3] = val134;
			array30[4] = val135;
			array30[5] = val136;
			array30[6] = mainView;
			SimpleValueTargetProvider val267 = new SimpleValueTargetProvider(array30, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj29 = (object)val267;
			val266.Add(typeFromHandle57, (object)val267);
			val266.Add(typeof(IReferenceProvider), obj29);
			Type typeFromHandle58 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val268 = new XmlNamespaceResolver();
			val268.Add("", "http://xamarin.com/schemas/2014/forms");
			val268.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val268.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val268.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val268.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val268.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val268.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val268.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val268.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val266.Add(typeFromHandle58, (object)new XamlTypeResolver((IXmlNamespaceResolver)val268, typeof(MainView).GetTypeInfo().Assembly));
			val266.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(212, 33)));
			object obj30 = (buttonMainView.Icon = (string)((IMarkupExtension)val73).ProvideValue((IServiceProvider)val266));
			((BindableObject)buttonMainView).SetValue(ButtonMainView.TextProperty, (object)homePage_SymptomCheck);
			val74.set_Path("OpenSymptomCheckCommand");
			BindingBase val269 = ((IMarkupExtension<BindingBase>)(object)val74).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView).SetBinding(ButtonMainView.OnClickCommandProperty, val269);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView);
			val75.set_Key("faVials");
			XamlServiceProvider val270 = new XamlServiceProvider();
			Type typeFromHandle59 = typeof(IProvideValueTarget);
			object[] array31 = new object[0 + 7];
			array31[0] = buttonMainView2;
			array31[1] = val85;
			array31[2] = val133;
			array31[3] = val134;
			array31[4] = val135;
			array31[5] = val136;
			array31[6] = mainView;
			SimpleValueTargetProvider val271 = new SimpleValueTargetProvider(array31, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj31 = (object)val271;
			val270.Add(typeFromHandle59, (object)val271);
			val270.Add(typeof(IReferenceProvider), obj31);
			Type typeFromHandle60 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val272 = new XmlNamespaceResolver();
			val272.Add("", "http://xamarin.com/schemas/2014/forms");
			val272.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val272.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val272.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val272.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val272.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val272.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val272.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val272.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val270.Add(typeFromHandle60, (object)new XamlTypeResolver((IXmlNamespaceResolver)val272, typeof(MainView).GetTypeInfo().Assembly));
			val270.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(219, 33)));
			object obj32 = (buttonMainView2.Icon = (string)((IMarkupExtension)val75).ProvideValue((IServiceProvider)val270));
			((BindableObject)buttonMainView2).SetValue(ButtonMainView.TextProperty, (object)homePage_TestingScheduleAndCalendar);
			val76.set_Path("OpenTestingScheduleCommand");
			BindingBase val273 = ((IMarkupExtension<BindingBase>)(object)val76).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView2).SetBinding(ButtonMainView.OnClickCommandProperty, val273);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView2);
			val77.set_Key("faMapMarkerAlt");
			XamlServiceProvider val274 = new XamlServiceProvider();
			Type typeFromHandle61 = typeof(IProvideValueTarget);
			object[] array32 = new object[0 + 7];
			array32[0] = buttonMainView3;
			array32[1] = val85;
			array32[2] = val133;
			array32[3] = val134;
			array32[4] = val135;
			array32[5] = val136;
			array32[6] = mainView;
			SimpleValueTargetProvider val275 = new SimpleValueTargetProvider(array32, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj33 = (object)val275;
			val274.Add(typeFromHandle61, (object)val275);
			val274.Add(typeof(IReferenceProvider), obj33);
			Type typeFromHandle62 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val276 = new XmlNamespaceResolver();
			val276.Add("", "http://xamarin.com/schemas/2014/forms");
			val276.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val276.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val276.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val276.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val276.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val276.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val276.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val276.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val274.Add(typeFromHandle62, (object)new XamlTypeResolver((IXmlNamespaceResolver)val276, typeof(MainView).GetTypeInfo().Assembly));
			val274.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(226, 33)));
			object obj34 = (buttonMainView3.Icon = (string)((IMarkupExtension)val77).ProvideValue((IServiceProvider)val274));
			((BindableObject)buttonMainView3).SetValue(ButtonMainView.TextProperty, (object)homePage_CheckIn);
			val78.set_Path("CheckInCommand");
			BindingBase val277 = ((IMarkupExtension<BindingBase>)(object)val78).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView3).SetBinding(ButtonMainView.OnClickCommandProperty, val277);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView3);
			val79.set_Key("faHeart");
			XamlServiceProvider val278 = new XamlServiceProvider();
			Type typeFromHandle63 = typeof(IProvideValueTarget);
			object[] array33 = new object[0 + 7];
			array33[0] = buttonMainView4;
			array33[1] = val85;
			array33[2] = val133;
			array33[3] = val134;
			array33[4] = val135;
			array33[5] = val136;
			array33[6] = mainView;
			SimpleValueTargetProvider val279 = new SimpleValueTargetProvider(array33, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj35 = (object)val279;
			val278.Add(typeFromHandle63, (object)val279);
			val278.Add(typeof(IReferenceProvider), obj35);
			Type typeFromHandle64 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val280 = new XmlNamespaceResolver();
			val280.Add("", "http://xamarin.com/schemas/2014/forms");
			val280.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val280.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val280.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val280.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val280.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val280.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val280.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val280.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val278.Add(typeFromHandle64, (object)new XamlTypeResolver((IXmlNamespaceResolver)val280, typeof(MainView).GetTypeInfo().Assembly));
			val278.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(233, 33)));
			object obj36 = (buttonMainView4.Icon = (string)((IMarkupExtension)val79).ProvideValue((IServiceProvider)val278));
			((BindableObject)buttonMainView4).SetValue(ButtonMainView.TextProperty, (object)homePage_SupportResources);
			val80.set_Path("SupportResourcesCommand");
			BindingBase val281 = ((IMarkupExtension<BindingBase>)(object)val80).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView4).SetBinding(ButtonMainView.OnClickCommandProperty, val281);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView4);
			val81.set_Key("faHouseSignal");
			XamlServiceProvider val282 = new XamlServiceProvider();
			Type typeFromHandle65 = typeof(IProvideValueTarget);
			object[] array34 = new object[0 + 7];
			array34[0] = buttonMainView5;
			array34[1] = val85;
			array34[2] = val133;
			array34[3] = val134;
			array34[4] = val135;
			array34[5] = val136;
			array34[6] = mainView;
			SimpleValueTargetProvider val283 = new SimpleValueTargetProvider(array34, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj37 = (object)val283;
			val282.Add(typeFromHandle65, (object)val283);
			val282.Add(typeof(IReferenceProvider), obj37);
			Type typeFromHandle66 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val284 = new XmlNamespaceResolver();
			val284.Add("", "http://xamarin.com/schemas/2014/forms");
			val284.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val284.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val284.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val284.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val284.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val284.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val284.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val284.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val282.Add(typeFromHandle66, (object)new XamlTypeResolver((IXmlNamespaceResolver)val284, typeof(MainView).GetTypeInfo().Assembly));
			val282.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(240, 33)));
			object obj38 = (buttonMainView5.Icon = (string)((IMarkupExtension)val81).ProvideValue((IServiceProvider)val282));
			((BindableObject)buttonMainView5).SetValue(ButtonMainView.TextProperty, (object)homePage_QuarantineGuidelines);
			val82.set_Path("GuidelinesCommand");
			BindingBase val285 = ((IMarkupExtension<BindingBase>)(object)val82).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView5).SetBinding(ButtonMainView.OnClickCommandProperty, val285);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView5);
			val83.set_Key("faQuestion");
			XamlServiceProvider val286 = new XamlServiceProvider();
			Type typeFromHandle67 = typeof(IProvideValueTarget);
			object[] array35 = new object[0 + 7];
			array35[0] = buttonMainView6;
			array35[1] = val85;
			array35[2] = val133;
			array35[3] = val134;
			array35[4] = val135;
			array35[5] = val136;
			array35[6] = mainView;
			SimpleValueTargetProvider val287 = new SimpleValueTargetProvider(array35, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj39 = (object)val287;
			val286.Add(typeFromHandle67, (object)val287);
			val286.Add(typeof(IReferenceProvider), obj39);
			Type typeFromHandle68 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val288 = new XmlNamespaceResolver();
			val288.Add("", "http://xamarin.com/schemas/2014/forms");
			val288.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val288.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val288.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val288.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val288.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val288.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val288.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val288.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val286.Add(typeFromHandle68, (object)new XamlTypeResolver((IXmlNamespaceResolver)val288, typeof(MainView).GetTypeInfo().Assembly));
			val286.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(247, 33)));
			object obj40 = (buttonMainView6.Icon = (string)((IMarkupExtension)val83).ProvideValue((IServiceProvider)val286));
			((BindableObject)buttonMainView6).SetValue(ButtonMainView.TextProperty, (object)homePage_FAQs);
			val84.set_Path("FAQsCommand");
			BindingBase val289 = ((IMarkupExtension<BindingBase>)(object)val84).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView6).SetBinding(ButtonMainView.OnClickCommandProperty, val289);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView6);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)val85);
			((BindableObject)val91).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val91).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			val86.set_Path("IsDebug");
			BindingBase val290 = ((IMarkupExtension<BindingBase>)(object)val86).ProvideValue((IServiceProvider)null);
			((BindableObject)val91).SetBinding(VisualElement.IsVisibleProperty, val290);
			((BindableObject)buttonMainView7).SetValue(ButtonMainView.TextProperty, (object)"Design System");
			val87.set_Key("faDesktop");
			XamlServiceProvider val291 = new XamlServiceProvider();
			Type typeFromHandle69 = typeof(IProvideValueTarget);
			object[] array36 = new object[0 + 7];
			array36[0] = buttonMainView7;
			array36[1] = val91;
			array36[2] = val133;
			array36[3] = val134;
			array36[4] = val135;
			array36[5] = val136;
			array36[6] = mainView;
			SimpleValueTargetProvider val292 = new SimpleValueTargetProvider(array36, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj41 = (object)val292;
			val291.Add(typeFromHandle69, (object)val292);
			val291.Add(typeof(IReferenceProvider), obj41);
			Type typeFromHandle70 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val293 = new XmlNamespaceResolver();
			val293.Add("", "http://xamarin.com/schemas/2014/forms");
			val293.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val293.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val293.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val293.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val293.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val293.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val293.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val293.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val291.Add(typeFromHandle70, (object)new XamlTypeResolver((IXmlNamespaceResolver)val293, typeof(MainView).GetTypeInfo().Assembly));
			val291.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(259, 33)));
			object obj42 = (buttonMainView7.Icon = (string)((IMarkupExtension)val87).ProvideValue((IServiceProvider)val291));
			val88.set_Path("OpenDesignSystemCommmand");
			BindingBase val294 = ((IMarkupExtension<BindingBase>)(object)val88).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView7).SetBinding(ButtonMainView.OnClickCommandProperty, val294);
			((Layout<View>)(object)val91).get_Children().Add((View)(object)buttonMainView7);
			((BindableObject)buttonMainView8).SetValue(ButtonMainView.TextProperty, (object)"Logout");
			val89.set_Key("faSignOutAlt");
			XamlServiceProvider val295 = new XamlServiceProvider();
			Type typeFromHandle71 = typeof(IProvideValueTarget);
			object[] array37 = new object[0 + 7];
			array37[0] = buttonMainView8;
			array37[1] = val91;
			array37[2] = val133;
			array37[3] = val134;
			array37[4] = val135;
			array37[5] = val136;
			array37[6] = mainView;
			SimpleValueTargetProvider val296 = new SimpleValueTargetProvider(array37, (object)ButtonMainView.IconProperty, (INameScope)(object)val137);
			object obj43 = (object)val296;
			val295.Add(typeFromHandle71, (object)val296);
			val295.Add(typeof(IReferenceProvider), obj43);
			Type typeFromHandle72 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val297 = new XmlNamespaceResolver();
			val297.Add("", "http://xamarin.com/schemas/2014/forms");
			val297.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val297.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val297.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val297.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val297.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val297.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val297.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val297.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val295.Add(typeFromHandle72, (object)new XamlTypeResolver((IXmlNamespaceResolver)val297, typeof(MainView).GetTypeInfo().Assembly));
			val295.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(263, 33)));
			object obj44 = (buttonMainView8.Icon = (string)((IMarkupExtension)val89).ProvideValue((IServiceProvider)val295));
			val90.set_Path("LogoutCommand");
			BindingBase val298 = ((IMarkupExtension<BindingBase>)(object)val90).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView8).SetBinding(ButtonMainView.OnClickCommandProperty, val298);
			((Layout<View>)(object)val91).get_Children().Add((View)(object)buttonMainView8);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)val91);
			((BindableObject)val132).SetValue(View.MarginProperty, (object)new Thickness(0.0, 40.0, 0.0, 0.0));
			((BindableObject)val109).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val109).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val109).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val92.set_Key("GrayColor");
			XamlServiceProvider val299 = new XamlServiceProvider();
			Type typeFromHandle73 = typeof(IProvideValueTarget);
			object[] array38 = new object[0 + 7];
			array38[0] = val109;
			array38[1] = val132;
			array38[2] = val133;
			array38[3] = val134;
			array38[4] = val135;
			array38[5] = val136;
			array38[6] = mainView;
			SimpleValueTargetProvider val300 = new SimpleValueTargetProvider(array38, (object)Frame.BorderColorProperty, (INameScope)(object)val137);
			object obj45 = (object)val300;
			val299.Add(typeFromHandle73, (object)val300);
			val299.Add(typeof(IReferenceProvider), obj45);
			Type typeFromHandle74 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val301 = new XmlNamespaceResolver();
			val301.Add("", "http://xamarin.com/schemas/2014/forms");
			val301.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val301.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val301.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val301.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val301.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val301.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val301.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val301.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val299.Add(typeFromHandle74, (object)new XamlTypeResolver((IXmlNamespaceResolver)val301, typeof(MainView).GetTypeInfo().Assembly));
			val299.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(274, 29)));
			DynamicResource val302 = ((IMarkupExtension<DynamicResource>)(object)val92).ProvideValue((IServiceProvider)val299);
			((IDynamicResourceHandler)val109).SetDynamicResource(Frame.BorderColorProperty, val302.get_Key());
			((BindableObject)val109).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val109).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val109).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val93.set_Path("CallHelpCommand");
			BindingBase val303 = ((IMarkupExtension<BindingBase>)(object)val93).ProvideValue((IServiceProvider)null);
			((BindableObject)val94).SetBinding(TapGestureRecognizer.CommandProperty, val303);
			((View)val109).get_GestureRecognizers().Add((IGestureRecognizer)(object)val94);
			((BindableObject)val108).SetValue(Grid.ColumnSpacingProperty, (object)16.0);
			((BindableObject)val95).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val108).GetValue(Grid.ColumnDefinitionsProperty)).Add(val95);
			((BindableObject)val96).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val108).GetValue(Grid.ColumnDefinitionsProperty)).Add(val96);
			((BindableObject)val97).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val108).GetValue(Grid.ColumnDefinitionsProperty)).Add(val97);
			((BindableObject)val100).SetValue(Grid.ColumnProperty, (object)0);
			val98.set_Key("faPhone");
			XamlServiceProvider val304 = new XamlServiceProvider();
			Type typeFromHandle75 = typeof(IProvideValueTarget);
			object[] array39 = new object[0 + 9];
			array39[0] = val100;
			array39[1] = val108;
			array39[2] = val109;
			array39[3] = val132;
			array39[4] = val133;
			array39[5] = val134;
			array39[6] = val135;
			array39[7] = val136;
			array39[8] = mainView;
			SimpleValueTargetProvider val305 = new SimpleValueTargetProvider(array39, (object)Label.TextProperty, (INameScope)(object)val137);
			object obj46 = (object)val305;
			val304.Add(typeFromHandle75, (object)val305);
			val304.Add(typeof(IReferenceProvider), obj46);
			Type typeFromHandle76 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val306 = new XmlNamespaceResolver();
			val306.Add("", "http://xamarin.com/schemas/2014/forms");
			val306.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val306.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val306.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val306.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val306.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val306.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val306.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val306.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val304.Add(typeFromHandle76, (object)new XamlTypeResolver((IXmlNamespaceResolver)val306, typeof(MainView).GetTypeInfo().Assembly));
			val304.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(287, 37)));
			object text11 = ((IMarkupExtension)val98).ProvideValue((IServiceProvider)val304);
			val100.set_Text((string)text11);
			((BindableObject)val100).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val99.set_Key("Small");
			XamlServiceProvider val307 = new XamlServiceProvider();
			Type typeFromHandle77 = typeof(IProvideValueTarget);
			object[] array40 = new object[0 + 9];
			array40[0] = val100;
			array40[1] = val108;
			array40[2] = val109;
			array40[3] = val132;
			array40[4] = val133;
			array40[5] = val134;
			array40[6] = val135;
			array40[7] = val136;
			array40[8] = mainView;
			SimpleValueTargetProvider val308 = new SimpleValueTargetProvider(array40, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj47 = (object)val308;
			val307.Add(typeFromHandle77, (object)val308);
			val307.Add(typeof(IReferenceProvider), obj47);
			Type typeFromHandle78 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val309 = new XmlNamespaceResolver();
			val309.Add("", "http://xamarin.com/schemas/2014/forms");
			val309.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val309.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val309.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val309.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val309.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val309.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val309.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val309.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val307.Add(typeFromHandle78, (object)new XamlTypeResolver((IXmlNamespaceResolver)val309, typeof(MainView).GetTypeInfo().Assembly));
			val307.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(289, 37)));
			DynamicResource val310 = ((IMarkupExtension<DynamicResource>)(object)val99).ProvideValue((IServiceProvider)val307);
			((IDynamicResourceHandler)val100).SetDynamicResource(VisualElement.StyleProperty, val310.get_Key());
			((BindableObject)val100).SetValue(Label.TextColorProperty, (object)Color.Transparent);
			((BindableObject)val100).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val100).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val108.get_Children()).Add((View)(object)val100);
			((BindableObject)val103).SetValue(Label.TextProperty, (object)homePage_ControlBranch);
			((BindableObject)val103).SetValue(Grid.ColumnProperty, (object)1);
			val101.set_Key("Small");
			XamlServiceProvider val311 = new XamlServiceProvider();
			Type typeFromHandle79 = typeof(IProvideValueTarget);
			object[] array41 = new object[0 + 9];
			array41[0] = val103;
			array41[1] = val108;
			array41[2] = val109;
			array41[3] = val132;
			array41[4] = val133;
			array41[5] = val134;
			array41[6] = val135;
			array41[7] = val136;
			array41[8] = mainView;
			SimpleValueTargetProvider val312 = new SimpleValueTargetProvider(array41, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj48 = (object)val312;
			val311.Add(typeFromHandle79, (object)val312);
			val311.Add(typeof(IReferenceProvider), obj48);
			Type typeFromHandle80 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val313 = new XmlNamespaceResolver();
			val313.Add("", "http://xamarin.com/schemas/2014/forms");
			val313.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val313.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val313.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val313.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val313.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val313.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val313.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val313.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val311.Add(typeFromHandle80, (object)new XamlTypeResolver((IXmlNamespaceResolver)val313, typeof(MainView).GetTypeInfo().Assembly));
			val311.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(296, 37)));
			DynamicResource val314 = ((IMarkupExtension<DynamicResource>)(object)val101).ProvideValue((IServiceProvider)val311);
			((IDynamicResourceHandler)val103).SetDynamicResource(VisualElement.StyleProperty, val314.get_Key());
			((BindableObject)val103).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val102.set_Key("SecondaryColor");
			XamlServiceProvider val315 = new XamlServiceProvider();
			Type typeFromHandle81 = typeof(IProvideValueTarget);
			object[] array42 = new object[0 + 9];
			array42[0] = val103;
			array42[1] = val108;
			array42[2] = val109;
			array42[3] = val132;
			array42[4] = val133;
			array42[5] = val134;
			array42[6] = val135;
			array42[7] = val136;
			array42[8] = mainView;
			SimpleValueTargetProvider val316 = new SimpleValueTargetProvider(array42, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj49 = (object)val316;
			val315.Add(typeFromHandle81, (object)val316);
			val315.Add(typeof(IReferenceProvider), obj49);
			Type typeFromHandle82 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val317 = new XmlNamespaceResolver();
			val317.Add("", "http://xamarin.com/schemas/2014/forms");
			val317.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val317.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val317.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val317.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val317.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val317.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val317.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val317.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val315.Add(typeFromHandle82, (object)new XamlTypeResolver((IXmlNamespaceResolver)val317, typeof(MainView).GetTypeInfo().Assembly));
			val315.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(298, 37)));
			DynamicResource val318 = ((IMarkupExtension<DynamicResource>)(object)val102).ProvideValue((IServiceProvider)val315);
			((IDynamicResourceHandler)val103).SetDynamicResource(Label.TextColorProperty, val318.get_Key());
			((BindableObject)val103).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((ICollection<View>)val108.get_Children()).Add((View)(object)val103);
			val104.set_Key("faPhone");
			XamlServiceProvider val319 = new XamlServiceProvider();
			Type typeFromHandle83 = typeof(IProvideValueTarget);
			object[] array43 = new object[0 + 9];
			array43[0] = val107;
			array43[1] = val108;
			array43[2] = val109;
			array43[3] = val132;
			array43[4] = val133;
			array43[5] = val134;
			array43[6] = val135;
			array43[7] = val136;
			array43[8] = mainView;
			SimpleValueTargetProvider val320 = new SimpleValueTargetProvider(array43, (object)Label.TextProperty, (INameScope)(object)val137);
			object obj50 = (object)val320;
			val319.Add(typeFromHandle83, (object)val320);
			val319.Add(typeof(IReferenceProvider), obj50);
			Type typeFromHandle84 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val321 = new XmlNamespaceResolver();
			val321.Add("", "http://xamarin.com/schemas/2014/forms");
			val321.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val321.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val321.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val321.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val321.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val321.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val321.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val321.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val319.Add(typeFromHandle84, (object)new XamlTypeResolver((IXmlNamespaceResolver)val321, typeof(MainView).GetTypeInfo().Assembly));
			val319.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(302, 37)));
			object text12 = ((IMarkupExtension)val104).ProvideValue((IServiceProvider)val319);
			val107.set_Text((string)text12);
			((BindableObject)val107).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val105.set_Key("Small");
			XamlServiceProvider val322 = new XamlServiceProvider();
			Type typeFromHandle85 = typeof(IProvideValueTarget);
			object[] array44 = new object[0 + 9];
			array44[0] = val107;
			array44[1] = val108;
			array44[2] = val109;
			array44[3] = val132;
			array44[4] = val133;
			array44[5] = val134;
			array44[6] = val135;
			array44[7] = val136;
			array44[8] = mainView;
			SimpleValueTargetProvider val323 = new SimpleValueTargetProvider(array44, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj51 = (object)val323;
			val322.Add(typeFromHandle85, (object)val323);
			val322.Add(typeof(IReferenceProvider), obj51);
			Type typeFromHandle86 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val324 = new XmlNamespaceResolver();
			val324.Add("", "http://xamarin.com/schemas/2014/forms");
			val324.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val324.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val324.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val324.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val324.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val324.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val324.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val324.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val322.Add(typeFromHandle86, (object)new XamlTypeResolver((IXmlNamespaceResolver)val324, typeof(MainView).GetTypeInfo().Assembly));
			val322.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(304, 37)));
			DynamicResource val325 = ((IMarkupExtension<DynamicResource>)(object)val105).ProvideValue((IServiceProvider)val322);
			((IDynamicResourceHandler)val107).SetDynamicResource(VisualElement.StyleProperty, val325.get_Key());
			val106.set_Key("SecondaryColor");
			XamlServiceProvider val326 = new XamlServiceProvider();
			Type typeFromHandle87 = typeof(IProvideValueTarget);
			object[] array45 = new object[0 + 9];
			array45[0] = val107;
			array45[1] = val108;
			array45[2] = val109;
			array45[3] = val132;
			array45[4] = val133;
			array45[5] = val134;
			array45[6] = val135;
			array45[7] = val136;
			array45[8] = mainView;
			SimpleValueTargetProvider val327 = new SimpleValueTargetProvider(array45, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj52 = (object)val327;
			val326.Add(typeFromHandle87, (object)val327);
			val326.Add(typeof(IReferenceProvider), obj52);
			Type typeFromHandle88 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val328 = new XmlNamespaceResolver();
			val328.Add("", "http://xamarin.com/schemas/2014/forms");
			val328.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val328.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val328.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val328.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val328.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val328.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val328.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val328.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val326.Add(typeFromHandle88, (object)new XamlTypeResolver((IXmlNamespaceResolver)val328, typeof(MainView).GetTypeInfo().Assembly));
			val326.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(305, 37)));
			DynamicResource val329 = ((IMarkupExtension<DynamicResource>)(object)val106).ProvideValue((IServiceProvider)val326);
			((IDynamicResourceHandler)val107).SetDynamicResource(Label.TextColorProperty, val329.get_Key());
			((BindableObject)val107).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val107).SetValue(Grid.ColumnProperty, (object)2);
			((BindableObject)val107).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val108.get_Children()).Add((View)(object)val107);
			((BindableObject)val109).SetValue(ContentView.ContentProperty, (object)val108);
			((Layout<View>)(object)val132).get_Children().Add((View)(object)val109);
			((BindableObject)val127).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val127).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val127).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val110.set_Key("GrayColor");
			XamlServiceProvider val330 = new XamlServiceProvider();
			Type typeFromHandle89 = typeof(IProvideValueTarget);
			object[] array46 = new object[0 + 7];
			array46[0] = val127;
			array46[1] = val132;
			array46[2] = val133;
			array46[3] = val134;
			array46[4] = val135;
			array46[5] = val136;
			array46[6] = mainView;
			SimpleValueTargetProvider val331 = new SimpleValueTargetProvider(array46, (object)Frame.BorderColorProperty, (INameScope)(object)val137);
			object obj53 = (object)val331;
			val330.Add(typeFromHandle89, (object)val331);
			val330.Add(typeof(IReferenceProvider), obj53);
			Type typeFromHandle90 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val332 = new XmlNamespaceResolver();
			val332.Add("", "http://xamarin.com/schemas/2014/forms");
			val332.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val332.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val332.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val332.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val332.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val332.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val332.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val332.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val330.Add(typeFromHandle90, (object)new XamlTypeResolver((IXmlNamespaceResolver)val332, typeof(MainView).GetTypeInfo().Assembly));
			val330.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(318, 29)));
			DynamicResource val333 = ((IMarkupExtension<DynamicResource>)(object)val110).ProvideValue((IServiceProvider)val330);
			((IDynamicResourceHandler)val127).SetDynamicResource(Frame.BorderColorProperty, val333.get_Key());
			((BindableObject)val127).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val127).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val127).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val111.set_Path("PrivacyPolicyCommand");
			BindingBase val334 = ((IMarkupExtension<BindingBase>)(object)val111).ProvideValue((IServiceProvider)null);
			((BindableObject)val112).SetBinding(TapGestureRecognizer.CommandProperty, val334);
			((View)val127).get_GestureRecognizers().Add((IGestureRecognizer)(object)val112);
			((BindableObject)val126).SetValue(Grid.ColumnSpacingProperty, (object)16.0);
			((BindableObject)val113).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val126).GetValue(Grid.ColumnDefinitionsProperty)).Add(val113);
			((BindableObject)val114).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val126).GetValue(Grid.ColumnDefinitionsProperty)).Add(val114);
			((BindableObject)val115).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val126).GetValue(Grid.ColumnDefinitionsProperty)).Add(val115);
			((BindableObject)val118).SetValue(Grid.ColumnProperty, (object)0);
			val116.set_Key("faExternalLink");
			XamlServiceProvider val335 = new XamlServiceProvider();
			Type typeFromHandle91 = typeof(IProvideValueTarget);
			object[] array47 = new object[0 + 9];
			array47[0] = val118;
			array47[1] = val126;
			array47[2] = val127;
			array47[3] = val132;
			array47[4] = val133;
			array47[5] = val134;
			array47[6] = val135;
			array47[7] = val136;
			array47[8] = mainView;
			SimpleValueTargetProvider val336 = new SimpleValueTargetProvider(array47, (object)Label.TextProperty, (INameScope)(object)val137);
			object obj54 = (object)val336;
			val335.Add(typeFromHandle91, (object)val336);
			val335.Add(typeof(IReferenceProvider), obj54);
			Type typeFromHandle92 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val337 = new XmlNamespaceResolver();
			val337.Add("", "http://xamarin.com/schemas/2014/forms");
			val337.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val337.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val337.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val337.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val337.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val337.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val337.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val337.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val335.Add(typeFromHandle92, (object)new XamlTypeResolver((IXmlNamespaceResolver)val337, typeof(MainView).GetTypeInfo().Assembly));
			val335.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(331, 37)));
			object text13 = ((IMarkupExtension)val116).ProvideValue((IServiceProvider)val335);
			val118.set_Text((string)text13);
			((BindableObject)val118).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val117.set_Key("Small");
			XamlServiceProvider val338 = new XamlServiceProvider();
			Type typeFromHandle93 = typeof(IProvideValueTarget);
			object[] array48 = new object[0 + 9];
			array48[0] = val118;
			array48[1] = val126;
			array48[2] = val127;
			array48[3] = val132;
			array48[4] = val133;
			array48[5] = val134;
			array48[6] = val135;
			array48[7] = val136;
			array48[8] = mainView;
			SimpleValueTargetProvider val339 = new SimpleValueTargetProvider(array48, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj55 = (object)val339;
			val338.Add(typeFromHandle93, (object)val339);
			val338.Add(typeof(IReferenceProvider), obj55);
			Type typeFromHandle94 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val340 = new XmlNamespaceResolver();
			val340.Add("", "http://xamarin.com/schemas/2014/forms");
			val340.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val340.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val340.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val340.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val340.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val340.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val340.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val340.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val338.Add(typeFromHandle94, (object)new XamlTypeResolver((IXmlNamespaceResolver)val340, typeof(MainView).GetTypeInfo().Assembly));
			val338.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(333, 37)));
			DynamicResource val341 = ((IMarkupExtension<DynamicResource>)(object)val117).ProvideValue((IServiceProvider)val338);
			((IDynamicResourceHandler)val118).SetDynamicResource(VisualElement.StyleProperty, val341.get_Key());
			((BindableObject)val118).SetValue(Label.TextColorProperty, (object)Color.Transparent);
			((BindableObject)val118).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val118).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val126.get_Children()).Add((View)(object)val118);
			((BindableObject)val121).SetValue(Label.TextProperty, (object)homePage_ControlBranchPrivacy);
			((BindableObject)val121).SetValue(Grid.ColumnProperty, (object)1);
			val119.set_Key("Small");
			XamlServiceProvider val342 = new XamlServiceProvider();
			Type typeFromHandle95 = typeof(IProvideValueTarget);
			object[] array49 = new object[0 + 9];
			array49[0] = val121;
			array49[1] = val126;
			array49[2] = val127;
			array49[3] = val132;
			array49[4] = val133;
			array49[5] = val134;
			array49[6] = val135;
			array49[7] = val136;
			array49[8] = mainView;
			SimpleValueTargetProvider val343 = new SimpleValueTargetProvider(array49, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj56 = (object)val343;
			val342.Add(typeFromHandle95, (object)val343);
			val342.Add(typeof(IReferenceProvider), obj56);
			Type typeFromHandle96 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val344 = new XmlNamespaceResolver();
			val344.Add("", "http://xamarin.com/schemas/2014/forms");
			val344.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val344.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val344.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val344.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val344.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val344.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val344.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val344.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val342.Add(typeFromHandle96, (object)new XamlTypeResolver((IXmlNamespaceResolver)val344, typeof(MainView).GetTypeInfo().Assembly));
			val342.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(340, 37)));
			DynamicResource val345 = ((IMarkupExtension<DynamicResource>)(object)val119).ProvideValue((IServiceProvider)val342);
			((IDynamicResourceHandler)val121).SetDynamicResource(VisualElement.StyleProperty, val345.get_Key());
			((BindableObject)val121).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val120.set_Key("SecondaryColor");
			XamlServiceProvider val346 = new XamlServiceProvider();
			Type typeFromHandle97 = typeof(IProvideValueTarget);
			object[] array50 = new object[0 + 9];
			array50[0] = val121;
			array50[1] = val126;
			array50[2] = val127;
			array50[3] = val132;
			array50[4] = val133;
			array50[5] = val134;
			array50[6] = val135;
			array50[7] = val136;
			array50[8] = mainView;
			SimpleValueTargetProvider val347 = new SimpleValueTargetProvider(array50, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj57 = (object)val347;
			val346.Add(typeFromHandle97, (object)val347);
			val346.Add(typeof(IReferenceProvider), obj57);
			Type typeFromHandle98 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val348 = new XmlNamespaceResolver();
			val348.Add("", "http://xamarin.com/schemas/2014/forms");
			val348.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val348.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val348.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val348.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val348.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val348.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val348.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val348.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val346.Add(typeFromHandle98, (object)new XamlTypeResolver((IXmlNamespaceResolver)val348, typeof(MainView).GetTypeInfo().Assembly));
			val346.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(342, 37)));
			DynamicResource val349 = ((IMarkupExtension<DynamicResource>)(object)val120).ProvideValue((IServiceProvider)val346);
			((IDynamicResourceHandler)val121).SetDynamicResource(Label.TextColorProperty, val349.get_Key());
			((BindableObject)val121).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((ICollection<View>)val126.get_Children()).Add((View)(object)val121);
			val122.set_Key("faExternalLink");
			XamlServiceProvider val350 = new XamlServiceProvider();
			Type typeFromHandle99 = typeof(IProvideValueTarget);
			object[] array51 = new object[0 + 9];
			array51[0] = val125;
			array51[1] = val126;
			array51[2] = val127;
			array51[3] = val132;
			array51[4] = val133;
			array51[5] = val134;
			array51[6] = val135;
			array51[7] = val136;
			array51[8] = mainView;
			SimpleValueTargetProvider val351 = new SimpleValueTargetProvider(array51, (object)Label.TextProperty, (INameScope)(object)val137);
			object obj58 = (object)val351;
			val350.Add(typeFromHandle99, (object)val351);
			val350.Add(typeof(IReferenceProvider), obj58);
			Type typeFromHandle100 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val352 = new XmlNamespaceResolver();
			val352.Add("", "http://xamarin.com/schemas/2014/forms");
			val352.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val352.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val352.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val352.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val352.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val352.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val352.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val352.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val350.Add(typeFromHandle100, (object)new XamlTypeResolver((IXmlNamespaceResolver)val352, typeof(MainView).GetTypeInfo().Assembly));
			val350.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(345, 37)));
			object text14 = ((IMarkupExtension)val122).ProvideValue((IServiceProvider)val350);
			val125.set_Text((string)text14);
			((BindableObject)val125).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val123.set_Key("Small");
			XamlServiceProvider val353 = new XamlServiceProvider();
			Type typeFromHandle101 = typeof(IProvideValueTarget);
			object[] array52 = new object[0 + 9];
			array52[0] = val125;
			array52[1] = val126;
			array52[2] = val127;
			array52[3] = val132;
			array52[4] = val133;
			array52[5] = val134;
			array52[6] = val135;
			array52[7] = val136;
			array52[8] = mainView;
			SimpleValueTargetProvider val354 = new SimpleValueTargetProvider(array52, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj59 = (object)val354;
			val353.Add(typeFromHandle101, (object)val354);
			val353.Add(typeof(IReferenceProvider), obj59);
			Type typeFromHandle102 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val355 = new XmlNamespaceResolver();
			val355.Add("", "http://xamarin.com/schemas/2014/forms");
			val355.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val355.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val355.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val355.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val355.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val355.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val355.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val355.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val353.Add(typeFromHandle102, (object)new XamlTypeResolver((IXmlNamespaceResolver)val355, typeof(MainView).GetTypeInfo().Assembly));
			val353.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(347, 37)));
			DynamicResource val356 = ((IMarkupExtension<DynamicResource>)(object)val123).ProvideValue((IServiceProvider)val353);
			((IDynamicResourceHandler)val125).SetDynamicResource(VisualElement.StyleProperty, val356.get_Key());
			val124.set_Key("SecondaryColor");
			XamlServiceProvider val357 = new XamlServiceProvider();
			Type typeFromHandle103 = typeof(IProvideValueTarget);
			object[] array53 = new object[0 + 9];
			array53[0] = val125;
			array53[1] = val126;
			array53[2] = val127;
			array53[3] = val132;
			array53[4] = val133;
			array53[5] = val134;
			array53[6] = val135;
			array53[7] = val136;
			array53[8] = mainView;
			SimpleValueTargetProvider val358 = new SimpleValueTargetProvider(array53, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj60 = (object)val358;
			val357.Add(typeFromHandle103, (object)val358);
			val357.Add(typeof(IReferenceProvider), obj60);
			Type typeFromHandle104 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val359 = new XmlNamespaceResolver();
			val359.Add("", "http://xamarin.com/schemas/2014/forms");
			val359.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val359.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val359.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val359.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val359.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val359.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val359.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val359.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val357.Add(typeFromHandle104, (object)new XamlTypeResolver((IXmlNamespaceResolver)val359, typeof(MainView).GetTypeInfo().Assembly));
			val357.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(348, 37)));
			DynamicResource val360 = ((IMarkupExtension<DynamicResource>)(object)val124).ProvideValue((IServiceProvider)val357);
			((IDynamicResourceHandler)val125).SetDynamicResource(Label.TextColorProperty, val360.get_Key());
			((BindableObject)val125).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val125).SetValue(Grid.ColumnProperty, (object)2);
			((BindableObject)val125).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val126.get_Children()).Add((View)(object)val125);
			((BindableObject)val127).SetValue(ContentView.ContentProperty, (object)val126);
			((Layout<View>)(object)val132).get_Children().Add((View)(object)val127);
			((BindableObject)tintedCachedImage2).SetValue(CachedImage.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("SAGov"));
			((BindableObject)tintedCachedImage2).SetValue(VisualElement.HeightRequestProperty, (object)30.0);
			((BindableObject)tintedCachedImage2).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)tintedCachedImage2).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val132).get_Children().Add((View)(object)tintedCachedImage2);
			val128.set_Path("VersionNumber");
			BindingBase val361 = ((IMarkupExtension<BindingBase>)(object)val128).ProvideValue((IServiceProvider)null);
			((BindableObject)val131).SetBinding(Label.TextProperty, val361);
			val129.set_Key("SecondaryTextColor");
			XamlServiceProvider val362 = new XamlServiceProvider();
			Type typeFromHandle105 = typeof(IProvideValueTarget);
			object[] array54 = new object[0 + 7];
			array54[0] = val131;
			array54[1] = val132;
			array54[2] = val133;
			array54[3] = val134;
			array54[4] = val135;
			array54[5] = val136;
			array54[6] = mainView;
			SimpleValueTargetProvider val363 = new SimpleValueTargetProvider(array54, (object)Label.TextColorProperty, (INameScope)(object)val137);
			object obj61 = (object)val363;
			val362.Add(typeFromHandle105, (object)val363);
			val362.Add(typeof(IReferenceProvider), obj61);
			Type typeFromHandle106 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val364 = new XmlNamespaceResolver();
			val364.Add("", "http://xamarin.com/schemas/2014/forms");
			val364.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val364.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val364.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val364.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val364.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val364.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val364.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val364.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val362.Add(typeFromHandle106, (object)new XamlTypeResolver((IXmlNamespaceResolver)val364, typeof(MainView).GetTypeInfo().Assembly));
			val362.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(367, 29)));
			DynamicResource val365 = ((IMarkupExtension<DynamicResource>)(object)val129).ProvideValue((IServiceProvider)val362);
			((IDynamicResourceHandler)val131).SetDynamicResource(Label.TextColorProperty, val365.get_Key());
			val130.set_Key("Small");
			XamlServiceProvider val366 = new XamlServiceProvider();
			Type typeFromHandle107 = typeof(IProvideValueTarget);
			object[] array55 = new object[0 + 7];
			array55[0] = val131;
			array55[1] = val132;
			array55[2] = val133;
			array55[3] = val134;
			array55[4] = val135;
			array55[5] = val136;
			array55[6] = mainView;
			SimpleValueTargetProvider val367 = new SimpleValueTargetProvider(array55, (object)VisualElement.StyleProperty, (INameScope)(object)val137);
			object obj62 = (object)val367;
			val366.Add(typeFromHandle107, (object)val367);
			val366.Add(typeof(IReferenceProvider), obj62);
			Type typeFromHandle108 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val368 = new XmlNamespaceResolver();
			val368.Add("", "http://xamarin.com/schemas/2014/forms");
			val368.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val368.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val368.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val368.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val368.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val368.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val368.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val368.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val366.Add(typeFromHandle108, (object)new XamlTypeResolver((IXmlNamespaceResolver)val368, typeof(MainView).GetTypeInfo().Assembly));
			val366.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(368, 29)));
			DynamicResource val369 = ((IMarkupExtension<DynamicResource>)(object)val130).ProvideValue((IServiceProvider)val366);
			((IDynamicResourceHandler)val131).SetDynamicResource(VisualElement.StyleProperty, val369.get_Key());
			((BindableObject)val131).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val131).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val131).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val132).get_Children().Add((View)(object)val131);
			((Layout<View>)(object)val133).get_Children().Add((View)(object)val132);
			((Layout<View>)(object)val134).get_Children().Add((View)(object)val133);
			val135.set_Content((View)(object)val134);
			((BindableObject)val136).SetValue(ContentView.ContentProperty, (object)val135);
			((BindableObject)mainView).SetValue(ContentPage.ContentProperty, (object)val136);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<MainView>(this, typeof(MainView));
			mainPage = NameScopeExtensions.FindByName<BaseView>((Element)(object)this, "mainPage");
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			textMessage = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textMessage");
			notificationCount = NameScopeExtensions.FindByName<Label>((Element)(object)this, "notificationCount");
			viewAllNotificationsLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "viewAllNotificationsLabel");
			linkTapGesture = NameScopeExtensions.FindByName<TapGestureRecognizer>((Element)(object)this, "linkTapGesture");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			expectedDate = NameScopeExtensions.FindByName<Label>((Element)(object)this, "expectedDate");
			expectedDay = NameScopeExtensions.FindByName<Label>((Element)(object)this, "expectedDay");
			expectedDatedetails = NameScopeExtensions.FindByName<Label>((Element)(object)this, "expectedDatedetails");
			iconLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "iconLabel");
			versionNumberLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "versionNumberLabel");
		}
	}
}
