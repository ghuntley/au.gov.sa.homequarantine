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
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected O, but got Unknown
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
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0719: Unknown result type (might be due to invalid IL or missing references)
			//IL_071e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0721: Expected O, but got Unknown
			//IL_0726: Expected O, but got Unknown
			//IL_0726: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Unknown result type (might be due to invalid IL or missing references)
			//IL_0743: Unknown result type (might be due to invalid IL or missing references)
			//IL_0748: Unknown result type (might be due to invalid IL or missing references)
			//IL_0758: Unknown result type (might be due to invalid IL or missing references)
			//IL_0768: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_0788: Unknown result type (might be due to invalid IL or missing references)
			//IL_0798: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f1: Expected O, but got Unknown
			//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Expected O, but got Unknown
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0805: Unknown result type (might be due to invalid IL or missing references)
			//IL_080f: Expected O, but got Unknown
			//IL_080a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0814: Expected O, but got Unknown
			//IL_0819: Expected O, but got Unknown
			//IL_0833: Unknown result type (might be due to invalid IL or missing references)
			//IL_0873: Unknown result type (might be due to invalid IL or missing references)
			//IL_090a: Unknown result type (might be due to invalid IL or missing references)
			//IL_090f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0933: Unknown result type (might be due to invalid IL or missing references)
			//IL_0938: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Expected O, but got Unknown
			//IL_0940: Expected O, but got Unknown
			//IL_0940: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_095d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0962: Unknown result type (might be due to invalid IL or missing references)
			//IL_0972: Unknown result type (might be due to invalid IL or missing references)
			//IL_0982: Unknown result type (might be due to invalid IL or missing references)
			//IL_0992: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0b: Expected O, but got Unknown
			//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a10: Expected O, but got Unknown
			//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a29: Expected O, but got Unknown
			//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2e: Expected O, but got Unknown
			//IL_0a33: Expected O, but got Unknown
			//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afb: Expected O, but got Unknown
			//IL_0b00: Expected O, but got Unknown
			//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcb: Expected O, but got Unknown
			//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd0: Expected O, but got Unknown
			//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be9: Expected O, but got Unknown
			//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bee: Expected O, but got Unknown
			//IL_0bf3: Expected O, but got Unknown
			//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Expected O, but got Unknown
			//IL_0cc8: Expected O, but got Unknown
			//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d93: Expected O, but got Unknown
			//IL_0d8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d98: Expected O, but got Unknown
			//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db1: Expected O, but got Unknown
			//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db6: Expected O, but got Unknown
			//IL_0dbb: Expected O, but got Unknown
			//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8d: Expected O, but got Unknown
			//IL_0e92: Expected O, but got Unknown
			//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f5d: Expected O, but got Unknown
			//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f62: Expected O, but got Unknown
			//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7b: Expected O, but got Unknown
			//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f80: Expected O, but got Unknown
			//IL_0f85: Expected O, but got Unknown
			//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
			//IL_1018: Unknown result type (might be due to invalid IL or missing references)
			//IL_101d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1055: Unknown result type (might be due to invalid IL or missing references)
			//IL_105a: Unknown result type (might be due to invalid IL or missing references)
			//IL_105d: Expected O, but got Unknown
			//IL_1062: Expected O, but got Unknown
			//IL_1062: Unknown result type (might be due to invalid IL or missing references)
			//IL_1074: Unknown result type (might be due to invalid IL or missing references)
			//IL_107f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1084: Unknown result type (might be due to invalid IL or missing references)
			//IL_1094: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1104: Unknown result type (might be due to invalid IL or missing references)
			//IL_112d: Expected O, but got Unknown
			//IL_1128: Unknown result type (might be due to invalid IL or missing references)
			//IL_1132: Expected O, but got Unknown
			//IL_1132: Unknown result type (might be due to invalid IL or missing references)
			//IL_1141: Unknown result type (might be due to invalid IL or missing references)
			//IL_114b: Expected O, but got Unknown
			//IL_1146: Unknown result type (might be due to invalid IL or missing references)
			//IL_1150: Expected O, but got Unknown
			//IL_1155: Expected O, but got Unknown
			//IL_116e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1173: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b3: Expected O, but got Unknown
			//IL_11b8: Expected O, but got Unknown
			//IL_11b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_11da: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_120a: Unknown result type (might be due to invalid IL or missing references)
			//IL_121a: Unknown result type (might be due to invalid IL or missing references)
			//IL_122a: Unknown result type (might be due to invalid IL or missing references)
			//IL_123a: Unknown result type (might be due to invalid IL or missing references)
			//IL_124a: Unknown result type (might be due to invalid IL or missing references)
			//IL_125a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1283: Expected O, but got Unknown
			//IL_127e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1288: Expected O, but got Unknown
			//IL_1288: Unknown result type (might be due to invalid IL or missing references)
			//IL_1297: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a1: Expected O, but got Unknown
			//IL_129c: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a6: Expected O, but got Unknown
			//IL_12ab: Expected O, but got Unknown
			//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_1325: Unknown result type (might be due to invalid IL or missing references)
			//IL_133b: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_142d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1432: Unknown result type (might be due to invalid IL or missing references)
			//IL_1435: Expected O, but got Unknown
			//IL_143a: Expected O, but got Unknown
			//IL_143a: Unknown result type (might be due to invalid IL or missing references)
			//IL_144c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1457: Unknown result type (might be due to invalid IL or missing references)
			//IL_145c: Unknown result type (might be due to invalid IL or missing references)
			//IL_146c: Unknown result type (might be due to invalid IL or missing references)
			//IL_147c: Unknown result type (might be due to invalid IL or missing references)
			//IL_148c: Unknown result type (might be due to invalid IL or missing references)
			//IL_149c: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_14bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_14cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1505: Expected O, but got Unknown
			//IL_1500: Unknown result type (might be due to invalid IL or missing references)
			//IL_150a: Expected O, but got Unknown
			//IL_150a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1519: Unknown result type (might be due to invalid IL or missing references)
			//IL_1523: Expected O, but got Unknown
			//IL_151e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1528: Expected O, but got Unknown
			//IL_152d: Expected O, but got Unknown
			//IL_1549: Unknown result type (might be due to invalid IL or missing references)
			//IL_1587: Unknown result type (might be due to invalid IL or missing references)
			//IL_158c: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d6: Expected O, but got Unknown
			//IL_15db: Expected O, but got Unknown
			//IL_15db: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_160d: Unknown result type (might be due to invalid IL or missing references)
			//IL_161d: Unknown result type (might be due to invalid IL or missing references)
			//IL_162d: Unknown result type (might be due to invalid IL or missing references)
			//IL_163d: Unknown result type (might be due to invalid IL or missing references)
			//IL_164d: Unknown result type (might be due to invalid IL or missing references)
			//IL_165d: Unknown result type (might be due to invalid IL or missing references)
			//IL_166d: Unknown result type (might be due to invalid IL or missing references)
			//IL_167d: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a6: Expected O, but got Unknown
			//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ab: Expected O, but got Unknown
			//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c4: Expected O, but got Unknown
			//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c9: Expected O, but got Unknown
			//IL_16ce: Expected O, but got Unknown
			//IL_16ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_170c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1711: Unknown result type (might be due to invalid IL or missing references)
			//IL_1753: Unknown result type (might be due to invalid IL or missing references)
			//IL_1758: Unknown result type (might be due to invalid IL or missing references)
			//IL_175b: Expected O, but got Unknown
			//IL_1760: Expected O, but got Unknown
			//IL_1760: Unknown result type (might be due to invalid IL or missing references)
			//IL_1772: Unknown result type (might be due to invalid IL or missing references)
			//IL_177d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1782: Unknown result type (might be due to invalid IL or missing references)
			//IL_1792: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1802: Unknown result type (might be due to invalid IL or missing references)
			//IL_182b: Expected O, but got Unknown
			//IL_1826: Unknown result type (might be due to invalid IL or missing references)
			//IL_1830: Expected O, but got Unknown
			//IL_1830: Unknown result type (might be due to invalid IL or missing references)
			//IL_183f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1849: Expected O, but got Unknown
			//IL_1844: Unknown result type (might be due to invalid IL or missing references)
			//IL_184e: Expected O, but got Unknown
			//IL_1853: Expected O, but got Unknown
			//IL_18c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1906: Unknown result type (might be due to invalid IL or missing references)
			//IL_190b: Unknown result type (might be due to invalid IL or missing references)
			//IL_190e: Expected O, but got Unknown
			//IL_1913: Expected O, but got Unknown
			//IL_1913: Unknown result type (might be due to invalid IL or missing references)
			//IL_1925: Unknown result type (might be due to invalid IL or missing references)
			//IL_1930: Unknown result type (might be due to invalid IL or missing references)
			//IL_1935: Unknown result type (might be due to invalid IL or missing references)
			//IL_1945: Unknown result type (might be due to invalid IL or missing references)
			//IL_1955: Unknown result type (might be due to invalid IL or missing references)
			//IL_1965: Unknown result type (might be due to invalid IL or missing references)
			//IL_1975: Unknown result type (might be due to invalid IL or missing references)
			//IL_1985: Unknown result type (might be due to invalid IL or missing references)
			//IL_1995: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19de: Expected O, but got Unknown
			//IL_19d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e3: Expected O, but got Unknown
			//IL_19e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_19fc: Expected O, but got Unknown
			//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a01: Expected O, but got Unknown
			//IL_1a06: Expected O, but got Unknown
			//IL_1a22: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a38: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b04: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b90: Expected O, but got Unknown
			//IL_1b95: Expected O, but got Unknown
			//IL_1b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1be7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c17: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c60: Expected O, but got Unknown
			//IL_1c5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c65: Expected O, but got Unknown
			//IL_1c65: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c74: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c7e: Expected O, but got Unknown
			//IL_1c79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c83: Expected O, but got Unknown
			//IL_1c88: Expected O, but got Unknown
			//IL_1d6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ddf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1de4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e24: Expected O, but got Unknown
			//IL_1e29: Expected O, but got Unknown
			//IL_1e29: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e46: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eab: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ecb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ef4: Expected O, but got Unknown
			//IL_1eef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ef9: Expected O, but got Unknown
			//IL_1ef9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f15: Expected O, but got Unknown
			//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f1a: Expected O, but got Unknown
			//IL_1f1f: Expected O, but got Unknown
			//IL_1f5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fac: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ffb: Expected O, but got Unknown
			//IL_2000: Expected O, but got Unknown
			//IL_2000: Unknown result type (might be due to invalid IL or missing references)
			//IL_2012: Unknown result type (might be due to invalid IL or missing references)
			//IL_201d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2022: Unknown result type (might be due to invalid IL or missing references)
			//IL_2032: Unknown result type (might be due to invalid IL or missing references)
			//IL_2042: Unknown result type (might be due to invalid IL or missing references)
			//IL_2052: Unknown result type (might be due to invalid IL or missing references)
			//IL_2062: Unknown result type (might be due to invalid IL or missing references)
			//IL_2072: Unknown result type (might be due to invalid IL or missing references)
			//IL_2082: Unknown result type (might be due to invalid IL or missing references)
			//IL_2092: Unknown result type (might be due to invalid IL or missing references)
			//IL_20a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_20cb: Expected O, but got Unknown
			//IL_20c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20d0: Expected O, but got Unknown
			//IL_20d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_20e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ec: Expected O, but got Unknown
			//IL_20e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20f1: Expected O, but got Unknown
			//IL_20f6: Expected O, but got Unknown
			//IL_2144: Unknown result type (might be due to invalid IL or missing references)
			//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_21b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_21fc: Expected O, but got Unknown
			//IL_2201: Expected O, but got Unknown
			//IL_2201: Unknown result type (might be due to invalid IL or missing references)
			//IL_2213: Unknown result type (might be due to invalid IL or missing references)
			//IL_221e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2223: Unknown result type (might be due to invalid IL or missing references)
			//IL_2233: Unknown result type (might be due to invalid IL or missing references)
			//IL_2243: Unknown result type (might be due to invalid IL or missing references)
			//IL_2253: Unknown result type (might be due to invalid IL or missing references)
			//IL_2263: Unknown result type (might be due to invalid IL or missing references)
			//IL_2273: Unknown result type (might be due to invalid IL or missing references)
			//IL_2283: Unknown result type (might be due to invalid IL or missing references)
			//IL_2293: Unknown result type (might be due to invalid IL or missing references)
			//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_22cc: Expected O, but got Unknown
			//IL_22c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22d1: Expected O, but got Unknown
			//IL_22d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_22e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_22ed: Expected O, but got Unknown
			//IL_22e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f2: Expected O, but got Unknown
			//IL_22f7: Expected O, but got Unknown
			//IL_2315: Unknown result type (might be due to invalid IL or missing references)
			//IL_231a: Unknown result type (might be due to invalid IL or missing references)
			//IL_235c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2361: Unknown result type (might be due to invalid IL or missing references)
			//IL_2364: Expected O, but got Unknown
			//IL_2369: Expected O, but got Unknown
			//IL_2369: Unknown result type (might be due to invalid IL or missing references)
			//IL_237b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2386: Unknown result type (might be due to invalid IL or missing references)
			//IL_238b: Unknown result type (might be due to invalid IL or missing references)
			//IL_239b: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_23bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_23cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_23db: Unknown result type (might be due to invalid IL or missing references)
			//IL_23eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_23fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_240b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2434: Expected O, but got Unknown
			//IL_242f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2439: Expected O, but got Unknown
			//IL_2439: Unknown result type (might be due to invalid IL or missing references)
			//IL_244b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2455: Expected O, but got Unknown
			//IL_2450: Unknown result type (might be due to invalid IL or missing references)
			//IL_245a: Expected O, but got Unknown
			//IL_245f: Expected O, but got Unknown
			//IL_2494: Unknown result type (might be due to invalid IL or missing references)
			//IL_2499: Unknown result type (might be due to invalid IL or missing references)
			//IL_24e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_24e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_24e9: Expected O, but got Unknown
			//IL_24ee: Expected O, but got Unknown
			//IL_24ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_2500: Unknown result type (might be due to invalid IL or missing references)
			//IL_250b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2510: Unknown result type (might be due to invalid IL or missing references)
			//IL_2520: Unknown result type (might be due to invalid IL or missing references)
			//IL_2530: Unknown result type (might be due to invalid IL or missing references)
			//IL_2540: Unknown result type (might be due to invalid IL or missing references)
			//IL_2550: Unknown result type (might be due to invalid IL or missing references)
			//IL_2560: Unknown result type (might be due to invalid IL or missing references)
			//IL_2570: Unknown result type (might be due to invalid IL or missing references)
			//IL_2580: Unknown result type (might be due to invalid IL or missing references)
			//IL_2590: Unknown result type (might be due to invalid IL or missing references)
			//IL_25b9: Expected O, but got Unknown
			//IL_25b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25be: Expected O, but got Unknown
			//IL_25be: Unknown result type (might be due to invalid IL or missing references)
			//IL_25d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_25da: Expected O, but got Unknown
			//IL_25d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_25df: Expected O, but got Unknown
			//IL_25e4: Expected O, but got Unknown
			//IL_2600: Unknown result type (might be due to invalid IL or missing references)
			//IL_261b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2636: Unknown result type (might be due to invalid IL or missing references)
			//IL_2685: Unknown result type (might be due to invalid IL or missing references)
			//IL_268a: Unknown result type (might be due to invalid IL or missing references)
			//IL_26d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_26d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_26da: Expected O, but got Unknown
			//IL_26df: Expected O, but got Unknown
			//IL_26df: Unknown result type (might be due to invalid IL or missing references)
			//IL_26f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_26fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_2701: Unknown result type (might be due to invalid IL or missing references)
			//IL_2711: Unknown result type (might be due to invalid IL or missing references)
			//IL_2721: Unknown result type (might be due to invalid IL or missing references)
			//IL_2731: Unknown result type (might be due to invalid IL or missing references)
			//IL_2741: Unknown result type (might be due to invalid IL or missing references)
			//IL_2751: Unknown result type (might be due to invalid IL or missing references)
			//IL_2761: Unknown result type (might be due to invalid IL or missing references)
			//IL_2771: Unknown result type (might be due to invalid IL or missing references)
			//IL_2781: Unknown result type (might be due to invalid IL or missing references)
			//IL_27aa: Expected O, but got Unknown
			//IL_27a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_27af: Expected O, but got Unknown
			//IL_27af: Unknown result type (might be due to invalid IL or missing references)
			//IL_27c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_27cb: Expected O, but got Unknown
			//IL_27c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_27d0: Expected O, but got Unknown
			//IL_27d5: Expected O, but got Unknown
			//IL_2832: Unknown result type (might be due to invalid IL or missing references)
			//IL_284f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2854: Unknown result type (might be due to invalid IL or missing references)
			//IL_2891: Unknown result type (might be due to invalid IL or missing references)
			//IL_2896: Unknown result type (might be due to invalid IL or missing references)
			//IL_2899: Expected O, but got Unknown
			//IL_289e: Expected O, but got Unknown
			//IL_289e: Unknown result type (might be due to invalid IL or missing references)
			//IL_28b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_28bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_28c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_28d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_28e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_28f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2900: Unknown result type (might be due to invalid IL or missing references)
			//IL_2910: Unknown result type (might be due to invalid IL or missing references)
			//IL_2920: Unknown result type (might be due to invalid IL or missing references)
			//IL_2930: Unknown result type (might be due to invalid IL or missing references)
			//IL_2940: Unknown result type (might be due to invalid IL or missing references)
			//IL_2969: Expected O, but got Unknown
			//IL_2964: Unknown result type (might be due to invalid IL or missing references)
			//IL_296e: Expected O, but got Unknown
			//IL_296e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2980: Unknown result type (might be due to invalid IL or missing references)
			//IL_298a: Expected O, but got Unknown
			//IL_2985: Unknown result type (might be due to invalid IL or missing references)
			//IL_298f: Expected O, but got Unknown
			//IL_2994: Expected O, but got Unknown
			//IL_29c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_29fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a77: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2abe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ac3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ac6: Expected O, but got Unknown
			//IL_2acb: Expected O, but got Unknown
			//IL_2acb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2add: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ae8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aed: Unknown result type (might be due to invalid IL or missing references)
			//IL_2afd: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b96: Expected O, but got Unknown
			//IL_2b91: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b9b: Expected O, but got Unknown
			//IL_2b9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bad: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bb7: Expected O, but got Unknown
			//IL_2bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bbc: Expected O, but got Unknown
			//IL_2bc1: Expected O, but got Unknown
			//IL_2bdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c26: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c2e: Expected O, but got Unknown
			//IL_2c33: Expected O, but got Unknown
			//IL_2c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c45: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c50: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c55: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c65: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c75: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c85: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c95: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cfe: Expected O, but got Unknown
			//IL_2cf9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d03: Expected O, but got Unknown
			//IL_2d03: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d15: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d1f: Expected O, but got Unknown
			//IL_2d1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d24: Expected O, but got Unknown
			//IL_2d29: Expected O, but got Unknown
			//IL_2d45: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2daa: Unknown result type (might be due to invalid IL or missing references)
			//IL_2daf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2df7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dff: Expected O, but got Unknown
			//IL_2e04: Expected O, but got Unknown
			//IL_2e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e16: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e26: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e36: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e46: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e56: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e66: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e76: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e86: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e96: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ea6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ecf: Expected O, but got Unknown
			//IL_2eca: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ed4: Expected O, but got Unknown
			//IL_2ed4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ee6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ef0: Expected O, but got Unknown
			//IL_2eeb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ef5: Expected O, but got Unknown
			//IL_2efa: Expected O, but got Unknown
			//IL_2f3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f84: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fda: Expected O, but got Unknown
			//IL_2fdf: Expected O, but got Unknown
			//IL_2fdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ff1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_3001: Unknown result type (might be due to invalid IL or missing references)
			//IL_3011: Unknown result type (might be due to invalid IL or missing references)
			//IL_3021: Unknown result type (might be due to invalid IL or missing references)
			//IL_3031: Unknown result type (might be due to invalid IL or missing references)
			//IL_3041: Unknown result type (might be due to invalid IL or missing references)
			//IL_3051: Unknown result type (might be due to invalid IL or missing references)
			//IL_3061: Unknown result type (might be due to invalid IL or missing references)
			//IL_3071: Unknown result type (might be due to invalid IL or missing references)
			//IL_3081: Unknown result type (might be due to invalid IL or missing references)
			//IL_30aa: Expected O, but got Unknown
			//IL_30a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_30af: Expected O, but got Unknown
			//IL_30af: Unknown result type (might be due to invalid IL or missing references)
			//IL_30c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_30cb: Expected O, but got Unknown
			//IL_30c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_30d0: Expected O, but got Unknown
			//IL_30d5: Expected O, but got Unknown
			//IL_30f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_30fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_314b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3150: Unknown result type (might be due to invalid IL or missing references)
			//IL_3153: Expected O, but got Unknown
			//IL_3158: Expected O, but got Unknown
			//IL_3158: Unknown result type (might be due to invalid IL or missing references)
			//IL_316a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3175: Unknown result type (might be due to invalid IL or missing references)
			//IL_317a: Unknown result type (might be due to invalid IL or missing references)
			//IL_318a: Unknown result type (might be due to invalid IL or missing references)
			//IL_319a: Unknown result type (might be due to invalid IL or missing references)
			//IL_31aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_31da: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_31fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_3223: Expected O, but got Unknown
			//IL_321e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3228: Expected O, but got Unknown
			//IL_3228: Unknown result type (might be due to invalid IL or missing references)
			//IL_323a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3244: Expected O, but got Unknown
			//IL_323f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3249: Expected O, but got Unknown
			//IL_324e: Expected O, but got Unknown
			//IL_3295: Unknown result type (might be due to invalid IL or missing references)
			//IL_329a: Unknown result type (might be due to invalid IL or missing references)
			//IL_32e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_32f0: Expected O, but got Unknown
			//IL_32f5: Expected O, but got Unknown
			//IL_32f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3307: Unknown result type (might be due to invalid IL or missing references)
			//IL_3312: Unknown result type (might be due to invalid IL or missing references)
			//IL_3317: Unknown result type (might be due to invalid IL or missing references)
			//IL_3327: Unknown result type (might be due to invalid IL or missing references)
			//IL_3337: Unknown result type (might be due to invalid IL or missing references)
			//IL_3347: Unknown result type (might be due to invalid IL or missing references)
			//IL_3357: Unknown result type (might be due to invalid IL or missing references)
			//IL_3367: Unknown result type (might be due to invalid IL or missing references)
			//IL_3377: Unknown result type (might be due to invalid IL or missing references)
			//IL_3387: Unknown result type (might be due to invalid IL or missing references)
			//IL_3397: Unknown result type (might be due to invalid IL or missing references)
			//IL_33c0: Expected O, but got Unknown
			//IL_33bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_33c5: Expected O, but got Unknown
			//IL_33c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_33d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_33e1: Expected O, but got Unknown
			//IL_33dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_33e6: Expected O, but got Unknown
			//IL_33eb: Expected O, but got Unknown
			//IL_341c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3421: Unknown result type (might be due to invalid IL or missing references)
			//IL_346f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3474: Unknown result type (might be due to invalid IL or missing references)
			//IL_3477: Expected O, but got Unknown
			//IL_347c: Expected O, but got Unknown
			//IL_347c: Unknown result type (might be due to invalid IL or missing references)
			//IL_348e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3499: Unknown result type (might be due to invalid IL or missing references)
			//IL_349e: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_34be: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_34de: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_34fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_350e: Unknown result type (might be due to invalid IL or missing references)
			//IL_351e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3547: Expected O, but got Unknown
			//IL_3542: Unknown result type (might be due to invalid IL or missing references)
			//IL_354c: Expected O, but got Unknown
			//IL_354c: Unknown result type (might be due to invalid IL or missing references)
			//IL_355e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3568: Expected O, but got Unknown
			//IL_3563: Unknown result type (might be due to invalid IL or missing references)
			//IL_356d: Expected O, but got Unknown
			//IL_3572: Expected O, but got Unknown
			//IL_35b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_35be: Unknown result type (might be due to invalid IL or missing references)
			//IL_360c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3611: Unknown result type (might be due to invalid IL or missing references)
			//IL_3614: Expected O, but got Unknown
			//IL_3619: Expected O, but got Unknown
			//IL_3619: Unknown result type (might be due to invalid IL or missing references)
			//IL_362b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3636: Unknown result type (might be due to invalid IL or missing references)
			//IL_363b: Unknown result type (might be due to invalid IL or missing references)
			//IL_364b: Unknown result type (might be due to invalid IL or missing references)
			//IL_365b: Unknown result type (might be due to invalid IL or missing references)
			//IL_366b: Unknown result type (might be due to invalid IL or missing references)
			//IL_367b: Unknown result type (might be due to invalid IL or missing references)
			//IL_368b: Unknown result type (might be due to invalid IL or missing references)
			//IL_369b: Unknown result type (might be due to invalid IL or missing references)
			//IL_36ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_36bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_36e4: Expected O, but got Unknown
			//IL_36df: Unknown result type (might be due to invalid IL or missing references)
			//IL_36e9: Expected O, but got Unknown
			//IL_36e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_36fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_3705: Expected O, but got Unknown
			//IL_3700: Unknown result type (might be due to invalid IL or missing references)
			//IL_370a: Expected O, but got Unknown
			//IL_370f: Expected O, but got Unknown
			//IL_372b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3771: Unknown result type (might be due to invalid IL or missing references)
			//IL_3776: Unknown result type (might be due to invalid IL or missing references)
			//IL_37c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_37c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_37cc: Expected O, but got Unknown
			//IL_37d1: Expected O, but got Unknown
			//IL_37d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_37e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_37ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_37f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_3803: Unknown result type (might be due to invalid IL or missing references)
			//IL_3813: Unknown result type (might be due to invalid IL or missing references)
			//IL_3823: Unknown result type (might be due to invalid IL or missing references)
			//IL_3833: Unknown result type (might be due to invalid IL or missing references)
			//IL_3843: Unknown result type (might be due to invalid IL or missing references)
			//IL_3853: Unknown result type (might be due to invalid IL or missing references)
			//IL_3863: Unknown result type (might be due to invalid IL or missing references)
			//IL_3873: Unknown result type (might be due to invalid IL or missing references)
			//IL_389c: Expected O, but got Unknown
			//IL_3897: Unknown result type (might be due to invalid IL or missing references)
			//IL_38a1: Expected O, but got Unknown
			//IL_38a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_38b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_38bd: Expected O, but got Unknown
			//IL_38b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_38c2: Expected O, but got Unknown
			//IL_38c7: Expected O, but got Unknown
			//IL_394a: Unknown result type (might be due to invalid IL or missing references)
			//IL_394f: Unknown result type (might be due to invalid IL or missing references)
			//IL_398c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3991: Unknown result type (might be due to invalid IL or missing references)
			//IL_3994: Expected O, but got Unknown
			//IL_3999: Expected O, but got Unknown
			//IL_3999: Unknown result type (might be due to invalid IL or missing references)
			//IL_39ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_39b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_39bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_39cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_39db: Unknown result type (might be due to invalid IL or missing references)
			//IL_39eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_39fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a64: Expected O, but got Unknown
			//IL_3a5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a69: Expected O, but got Unknown
			//IL_3a69: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a85: Expected O, but got Unknown
			//IL_3a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a8a: Expected O, but got Unknown
			//IL_3a8f: Expected O, but got Unknown
			//IL_3ae8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3aed: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b32: Expected O, but got Unknown
			//IL_3b37: Expected O, but got Unknown
			//IL_3b37: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b49: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b54: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b69: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b89: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b99: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c02: Expected O, but got Unknown
			//IL_3bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c07: Expected O, but got Unknown
			//IL_3c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c19: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c23: Expected O, but got Unknown
			//IL_3c1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c28: Expected O, but got Unknown
			//IL_3c2d: Expected O, but got Unknown
			//IL_3c86: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ccd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cd0: Expected O, but got Unknown
			//IL_3cd5: Expected O, but got Unknown
			//IL_3cd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ce7: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cf2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cf7: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d07: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d17: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d27: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d37: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d47: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d57: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d67: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d77: Unknown result type (might be due to invalid IL or missing references)
			//IL_3da0: Expected O, but got Unknown
			//IL_3d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3da5: Expected O, but got Unknown
			//IL_3da5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3db7: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dc1: Expected O, but got Unknown
			//IL_3dbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dc6: Expected O, but got Unknown
			//IL_3dcb: Expected O, but got Unknown
			//IL_3e24: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e29: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e66: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e6e: Expected O, but got Unknown
			//IL_3e73: Expected O, but got Unknown
			//IL_3e73: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e85: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e90: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e95: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ea5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3eb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ec5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ed5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ee5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f05: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f15: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f3e: Expected O, but got Unknown
			//IL_3f39: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f43: Expected O, but got Unknown
			//IL_3f43: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f55: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f5f: Expected O, but got Unknown
			//IL_3f5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f64: Expected O, but got Unknown
			//IL_3f69: Expected O, but got Unknown
			//IL_3fc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4004: Unknown result type (might be due to invalid IL or missing references)
			//IL_4009: Unknown result type (might be due to invalid IL or missing references)
			//IL_400c: Expected O, but got Unknown
			//IL_4011: Expected O, but got Unknown
			//IL_4011: Unknown result type (might be due to invalid IL or missing references)
			//IL_4023: Unknown result type (might be due to invalid IL or missing references)
			//IL_402e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4033: Unknown result type (might be due to invalid IL or missing references)
			//IL_4043: Unknown result type (might be due to invalid IL or missing references)
			//IL_4053: Unknown result type (might be due to invalid IL or missing references)
			//IL_4063: Unknown result type (might be due to invalid IL or missing references)
			//IL_4073: Unknown result type (might be due to invalid IL or missing references)
			//IL_4083: Unknown result type (might be due to invalid IL or missing references)
			//IL_4093: Unknown result type (might be due to invalid IL or missing references)
			//IL_40a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_40b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_40dc: Expected O, but got Unknown
			//IL_40d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40e1: Expected O, but got Unknown
			//IL_40e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_40f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_40fd: Expected O, but got Unknown
			//IL_40f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4102: Expected O, but got Unknown
			//IL_4107: Expected O, but got Unknown
			//IL_4160: Unknown result type (might be due to invalid IL or missing references)
			//IL_4165: Unknown result type (might be due to invalid IL or missing references)
			//IL_41a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_41a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_41aa: Expected O, but got Unknown
			//IL_41af: Expected O, but got Unknown
			//IL_41af: Unknown result type (might be due to invalid IL or missing references)
			//IL_41c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_41cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_41d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_41e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_41f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4201: Unknown result type (might be due to invalid IL or missing references)
			//IL_4211: Unknown result type (might be due to invalid IL or missing references)
			//IL_4221: Unknown result type (might be due to invalid IL or missing references)
			//IL_4231: Unknown result type (might be due to invalid IL or missing references)
			//IL_4241: Unknown result type (might be due to invalid IL or missing references)
			//IL_4251: Unknown result type (might be due to invalid IL or missing references)
			//IL_427a: Expected O, but got Unknown
			//IL_4275: Unknown result type (might be due to invalid IL or missing references)
			//IL_427f: Expected O, but got Unknown
			//IL_427f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4291: Unknown result type (might be due to invalid IL or missing references)
			//IL_429b: Expected O, but got Unknown
			//IL_4296: Unknown result type (might be due to invalid IL or missing references)
			//IL_42a0: Expected O, but got Unknown
			//IL_42a5: Expected O, but got Unknown
			//IL_4343: Unknown result type (might be due to invalid IL or missing references)
			//IL_4395: Unknown result type (might be due to invalid IL or missing references)
			//IL_439a: Unknown result type (might be due to invalid IL or missing references)
			//IL_43d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_43dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_43df: Expected O, but got Unknown
			//IL_43e4: Expected O, but got Unknown
			//IL_43e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_43f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4401: Unknown result type (might be due to invalid IL or missing references)
			//IL_4406: Unknown result type (might be due to invalid IL or missing references)
			//IL_4416: Unknown result type (might be due to invalid IL or missing references)
			//IL_4426: Unknown result type (might be due to invalid IL or missing references)
			//IL_4436: Unknown result type (might be due to invalid IL or missing references)
			//IL_4446: Unknown result type (might be due to invalid IL or missing references)
			//IL_4456: Unknown result type (might be due to invalid IL or missing references)
			//IL_4466: Unknown result type (might be due to invalid IL or missing references)
			//IL_4476: Unknown result type (might be due to invalid IL or missing references)
			//IL_4486: Unknown result type (might be due to invalid IL or missing references)
			//IL_44af: Expected O, but got Unknown
			//IL_44aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_44b4: Expected O, but got Unknown
			//IL_44b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_44c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_44d0: Expected O, but got Unknown
			//IL_44cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_44d5: Expected O, but got Unknown
			//IL_44da: Expected O, but got Unknown
			//IL_4536: Unknown result type (might be due to invalid IL or missing references)
			//IL_453b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4578: Unknown result type (might be due to invalid IL or missing references)
			//IL_457d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4580: Expected O, but got Unknown
			//IL_4585: Expected O, but got Unknown
			//IL_4585: Unknown result type (might be due to invalid IL or missing references)
			//IL_4597: Unknown result type (might be due to invalid IL or missing references)
			//IL_45a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_45a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_45b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_45c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_45d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_45e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_45f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4607: Unknown result type (might be due to invalid IL or missing references)
			//IL_4617: Unknown result type (might be due to invalid IL or missing references)
			//IL_4627: Unknown result type (might be due to invalid IL or missing references)
			//IL_4650: Expected O, but got Unknown
			//IL_464b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4655: Expected O, but got Unknown
			//IL_4655: Unknown result type (might be due to invalid IL or missing references)
			//IL_4667: Unknown result type (might be due to invalid IL or missing references)
			//IL_4671: Expected O, but got Unknown
			//IL_466c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4676: Expected O, but got Unknown
			//IL_467b: Expected O, but got Unknown
			//IL_46f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4707: Unknown result type (might be due to invalid IL or missing references)
			//IL_471d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4733: Unknown result type (might be due to invalid IL or missing references)
			//IL_4750: Unknown result type (might be due to invalid IL or missing references)
			//IL_4755: Unknown result type (might be due to invalid IL or missing references)
			//IL_4792: Unknown result type (might be due to invalid IL or missing references)
			//IL_4797: Unknown result type (might be due to invalid IL or missing references)
			//IL_479a: Expected O, but got Unknown
			//IL_479f: Expected O, but got Unknown
			//IL_479f: Unknown result type (might be due to invalid IL or missing references)
			//IL_47b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_47bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_47c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_47d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_47e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_47f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4801: Unknown result type (might be due to invalid IL or missing references)
			//IL_4811: Unknown result type (might be due to invalid IL or missing references)
			//IL_4821: Unknown result type (might be due to invalid IL or missing references)
			//IL_4831: Unknown result type (might be due to invalid IL or missing references)
			//IL_4841: Unknown result type (might be due to invalid IL or missing references)
			//IL_486a: Expected O, but got Unknown
			//IL_4865: Unknown result type (might be due to invalid IL or missing references)
			//IL_486f: Expected O, but got Unknown
			//IL_486f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4881: Unknown result type (might be due to invalid IL or missing references)
			//IL_488b: Expected O, but got Unknown
			//IL_4886: Unknown result type (might be due to invalid IL or missing references)
			//IL_4890: Expected O, but got Unknown
			//IL_4895: Expected O, but got Unknown
			//IL_48c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_48f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_4956: Unknown result type (might be due to invalid IL or missing references)
			//IL_4984: Unknown result type (might be due to invalid IL or missing references)
			//IL_49b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_49f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_49fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a46: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a4e: Expected O, but got Unknown
			//IL_4a53: Expected O, but got Unknown
			//IL_4a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a65: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a70: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a75: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a95: Unknown result type (might be due to invalid IL or missing references)
			//IL_4aa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ab5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ac5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ad5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ae5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4af5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b1e: Expected O, but got Unknown
			//IL_4b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b23: Expected O, but got Unknown
			//IL_4b23: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b35: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b3f: Expected O, but got Unknown
			//IL_4b3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b44: Expected O, but got Unknown
			//IL_4b49: Expected O, but got Unknown
			//IL_4b5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b81: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b86: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bce: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bd8: Expected O, but got Unknown
			//IL_4bdd: Expected O, but got Unknown
			//IL_4bdd: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c01: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c11: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c21: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c31: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c41: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c61: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c71: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c81: Unknown result type (might be due to invalid IL or missing references)
			//IL_4caa: Expected O, but got Unknown
			//IL_4ca5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4caf: Expected O, but got Unknown
			//IL_4caf: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ccb: Expected O, but got Unknown
			//IL_4cc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cd0: Expected O, but got Unknown
			//IL_4cd5: Expected O, but got Unknown
			//IL_4cf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d71: Unknown result type (might be due to invalid IL or missing references)
			//IL_4db9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dc3: Expected O, but got Unknown
			//IL_4dc8: Expected O, but got Unknown
			//IL_4dc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ddc: Unknown result type (might be due to invalid IL or missing references)
			//IL_4de7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dec: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e95: Expected O, but got Unknown
			//IL_4e90: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e9a: Expected O, but got Unknown
			//IL_4e9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4eac: Unknown result type (might be due to invalid IL or missing references)
			//IL_4eb6: Expected O, but got Unknown
			//IL_4eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ebb: Expected O, but got Unknown
			//IL_4ec0: Expected O, but got Unknown
			//IL_4ee0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f02: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f07: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f54: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f59: Expected O, but got Unknown
			//IL_4f5e: Expected O, but got Unknown
			//IL_4f5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f72: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f82: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f92: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fe2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ff2: Unknown result type (might be due to invalid IL or missing references)
			//IL_5002: Unknown result type (might be due to invalid IL or missing references)
			//IL_502b: Expected O, but got Unknown
			//IL_5026: Unknown result type (might be due to invalid IL or missing references)
			//IL_5030: Expected O, but got Unknown
			//IL_5030: Unknown result type (might be due to invalid IL or missing references)
			//IL_5042: Unknown result type (might be due to invalid IL or missing references)
			//IL_504c: Expected O, but got Unknown
			//IL_5047: Unknown result type (might be due to invalid IL or missing references)
			//IL_5051: Expected O, but got Unknown
			//IL_5056: Expected O, but got Unknown
			//IL_5076: Unknown result type (might be due to invalid IL or missing references)
			//IL_50a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_50a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_50ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_50f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_50f8: Expected O, but got Unknown
			//IL_50fd: Expected O, but got Unknown
			//IL_50fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_5111: Unknown result type (might be due to invalid IL or missing references)
			//IL_511c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5121: Unknown result type (might be due to invalid IL or missing references)
			//IL_5131: Unknown result type (might be due to invalid IL or missing references)
			//IL_5141: Unknown result type (might be due to invalid IL or missing references)
			//IL_5151: Unknown result type (might be due to invalid IL or missing references)
			//IL_5161: Unknown result type (might be due to invalid IL or missing references)
			//IL_5171: Unknown result type (might be due to invalid IL or missing references)
			//IL_5181: Unknown result type (might be due to invalid IL or missing references)
			//IL_5191: Unknown result type (might be due to invalid IL or missing references)
			//IL_51a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_51ca: Expected O, but got Unknown
			//IL_51c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51cf: Expected O, but got Unknown
			//IL_51cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_51e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_51eb: Expected O, but got Unknown
			//IL_51e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_51f0: Expected O, but got Unknown
			//IL_51f5: Expected O, but got Unknown
			//IL_520b: Unknown result type (might be due to invalid IL or missing references)
			//IL_522d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5232: Unknown result type (might be due to invalid IL or missing references)
			//IL_527a: Unknown result type (might be due to invalid IL or missing references)
			//IL_527f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5284: Expected O, but got Unknown
			//IL_5289: Expected O, but got Unknown
			//IL_5289: Unknown result type (might be due to invalid IL or missing references)
			//IL_529d: Unknown result type (might be due to invalid IL or missing references)
			//IL_52a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_52ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_52bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_52cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_52dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_52ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_52fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_530d: Unknown result type (might be due to invalid IL or missing references)
			//IL_531d: Unknown result type (might be due to invalid IL or missing references)
			//IL_532d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5356: Expected O, but got Unknown
			//IL_5351: Unknown result type (might be due to invalid IL or missing references)
			//IL_535b: Expected O, but got Unknown
			//IL_535b: Unknown result type (might be due to invalid IL or missing references)
			//IL_536d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5377: Expected O, but got Unknown
			//IL_5372: Unknown result type (might be due to invalid IL or missing references)
			//IL_537c: Expected O, but got Unknown
			//IL_5381: Expected O, but got Unknown
			//IL_53a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_53ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_53f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_53fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_53ff: Expected O, but got Unknown
			//IL_5404: Expected O, but got Unknown
			//IL_5404: Unknown result type (might be due to invalid IL or missing references)
			//IL_5418: Unknown result type (might be due to invalid IL or missing references)
			//IL_5423: Unknown result type (might be due to invalid IL or missing references)
			//IL_5428: Unknown result type (might be due to invalid IL or missing references)
			//IL_5438: Unknown result type (might be due to invalid IL or missing references)
			//IL_5448: Unknown result type (might be due to invalid IL or missing references)
			//IL_5458: Unknown result type (might be due to invalid IL or missing references)
			//IL_5468: Unknown result type (might be due to invalid IL or missing references)
			//IL_5478: Unknown result type (might be due to invalid IL or missing references)
			//IL_5488: Unknown result type (might be due to invalid IL or missing references)
			//IL_5498: Unknown result type (might be due to invalid IL or missing references)
			//IL_54a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_54d1: Expected O, but got Unknown
			//IL_54cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_54d6: Expected O, but got Unknown
			//IL_54d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_54e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_54f2: Expected O, but got Unknown
			//IL_54ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_54f7: Expected O, but got Unknown
			//IL_54fc: Expected O, but got Unknown
			//IL_551c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5584: Unknown result type (might be due to invalid IL or missing references)
			//IL_559a: Unknown result type (might be due to invalid IL or missing references)
			//IL_55b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_55cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_55d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_560f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5614: Unknown result type (might be due to invalid IL or missing references)
			//IL_5619: Expected O, but got Unknown
			//IL_561e: Expected O, but got Unknown
			//IL_561e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5632: Unknown result type (might be due to invalid IL or missing references)
			//IL_563d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5642: Unknown result type (might be due to invalid IL or missing references)
			//IL_5652: Unknown result type (might be due to invalid IL or missing references)
			//IL_5662: Unknown result type (might be due to invalid IL or missing references)
			//IL_5672: Unknown result type (might be due to invalid IL or missing references)
			//IL_5682: Unknown result type (might be due to invalid IL or missing references)
			//IL_5692: Unknown result type (might be due to invalid IL or missing references)
			//IL_56a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_56b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_56c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_56eb: Expected O, but got Unknown
			//IL_56e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_56f0: Expected O, but got Unknown
			//IL_56f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_5702: Unknown result type (might be due to invalid IL or missing references)
			//IL_570c: Expected O, but got Unknown
			//IL_5707: Unknown result type (might be due to invalid IL or missing references)
			//IL_5711: Expected O, but got Unknown
			//IL_5716: Expected O, but got Unknown
			//IL_573f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5770: Unknown result type (might be due to invalid IL or missing references)
			//IL_57d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_57d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_5818: Unknown result type (might be due to invalid IL or missing references)
			//IL_581d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5822: Expected O, but got Unknown
			//IL_5827: Expected O, but got Unknown
			//IL_5827: Unknown result type (might be due to invalid IL or missing references)
			//IL_583b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5846: Unknown result type (might be due to invalid IL or missing references)
			//IL_584b: Unknown result type (might be due to invalid IL or missing references)
			//IL_585b: Unknown result type (might be due to invalid IL or missing references)
			//IL_586b: Unknown result type (might be due to invalid IL or missing references)
			//IL_587b: Unknown result type (might be due to invalid IL or missing references)
			//IL_588b: Unknown result type (might be due to invalid IL or missing references)
			//IL_589b: Unknown result type (might be due to invalid IL or missing references)
			//IL_58ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_58bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_58cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_58f4: Expected O, but got Unknown
			//IL_58ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_58f9: Expected O, but got Unknown
			//IL_58f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_590b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5915: Expected O, but got Unknown
			//IL_5910: Unknown result type (might be due to invalid IL or missing references)
			//IL_591a: Expected O, but got Unknown
			//IL_591f: Expected O, but got Unknown
			//IL_5946: Unknown result type (might be due to invalid IL or missing references)
			//IL_594b: Unknown result type (might be due to invalid IL or missing references)
			//IL_598d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5992: Unknown result type (might be due to invalid IL or missing references)
			//IL_5997: Expected O, but got Unknown
			//IL_599c: Expected O, but got Unknown
			//IL_599c: Unknown result type (might be due to invalid IL or missing references)
			//IL_59b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_59bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_59c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_59d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_59e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_59f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a30: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a40: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a69: Expected O, but got Unknown
			//IL_5a64: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a6e: Expected O, but got Unknown
			//IL_5a6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a8a: Expected O, but got Unknown
			//IL_5a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a8f: Expected O, but got Unknown
			//IL_5a94: Expected O, but got Unknown
			//IL_5ab4: Unknown result type (might be due to invalid IL or missing references)
			//IL_5acf: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b30: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b35: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b72: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b77: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b7c: Expected O, but got Unknown
			//IL_5b81: Expected O, but got Unknown
			//IL_5b81: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ba0: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5be5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c05: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c15: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c25: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c4e: Expected O, but got Unknown
			//IL_5c49: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c53: Expected O, but got Unknown
			//IL_5c53: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c65: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c6f: Expected O, but got Unknown
			//IL_5c6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_5c74: Expected O, but got Unknown
			//IL_5c79: Expected O, but got Unknown
			//IL_5ca0: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ca5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ce2: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ce7: Unknown result type (might be due to invalid IL or missing references)
			//IL_5cec: Expected O, but got Unknown
			//IL_5cf1: Expected O, but got Unknown
			//IL_5cf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d05: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d10: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d15: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d25: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d35: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d45: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d55: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d65: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d85: Unknown result type (might be due to invalid IL or missing references)
			//IL_5d95: Unknown result type (might be due to invalid IL or missing references)
			//IL_5dbe: Expected O, but got Unknown
			//IL_5db9: Unknown result type (might be due to invalid IL or missing references)
			//IL_5dc3: Expected O, but got Unknown
			//IL_5dc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_5dd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ddf: Expected O, but got Unknown
			//IL_5dda: Unknown result type (might be due to invalid IL or missing references)
			//IL_5de4: Expected O, but got Unknown
			//IL_5de9: Expected O, but got Unknown
			//IL_5e09: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e24: Unknown result type (might be due to invalid IL or missing references)
			//IL_5e5e: Unknown result type (might be due to invalid IL or missing references)
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
			string homePage_ControlBranchPrivacy = Resources.HomePage_ControlBranchPrivacy;
			DynamicResourceExtension val113 = new DynamicResourceExtension();
			DynamicResourceExtension val114 = new DynamicResourceExtension();
			Label val115 = new Label();
			Frame val116 = new Frame();
			BindingExtension val117 = new BindingExtension();
			DynamicResourceExtension val118 = new DynamicResourceExtension();
			DynamicResourceExtension val119 = new DynamicResourceExtension();
			Label val120 = new Label();
			StackLayout val121 = new StackLayout();
			StackLayout val122 = new StackLayout();
			StackLayout val123 = new StackLayout();
			ScrollView val124 = new ScrollView();
			RefreshView val125 = new RefreshView();
			MainView mainView;
			NameScope val126 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(mainView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)mainView, (INameScope)(object)val126);
			((INameScope)val126).RegisterName("mainPage", (object)mainView);
			if (((Element)mainView).get_StyleId() == null)
			{
				((Element)mainView).set_StyleId("mainPage");
			}
			((INameScope)val126).RegisterName("containingView", (object)val122);
			if (((Element)val122).get_StyleId() == null)
			{
				((Element)val122).set_StyleId("containingView");
			}
			((INameScope)val126).RegisterName("textMessage", (object)val20);
			if (((Element)val20).get_StyleId() == null)
			{
				((Element)val20).set_StyleId("textMessage");
			}
			((INameScope)val126).RegisterName("notificationCount", (object)val24);
			if (((Element)val24).get_StyleId() == null)
			{
				((Element)val24).set_StyleId("notificationCount");
			}
			((INameScope)val126).RegisterName("viewAllNotificationsLabel", (object)val30);
			if (((Element)val30).get_StyleId() == null)
			{
				((Element)val30).set_StyleId("viewAllNotificationsLabel");
			}
			((INameScope)val126).RegisterName("linkTapGesture", (object)val29);
			if (((Element)val29).get_StyleId() == null)
			{
				((Element)val29).set_StyleId("linkTapGesture");
			}
			((INameScope)val126).RegisterName("border", (object)val41);
			if (((Element)val41).get_StyleId() == null)
			{
				((Element)val41).set_StyleId("border");
			}
			((INameScope)val126).RegisterName("expectedDate", (object)val57);
			if (((Element)val57).get_StyleId() == null)
			{
				((Element)val57).set_StyleId("expectedDate");
			}
			((INameScope)val126).RegisterName("expectedDay", (object)val63);
			if (((Element)val63).get_StyleId() == null)
			{
				((Element)val63).set_StyleId("expectedDay");
			}
			((INameScope)val126).RegisterName("expectedDatedetails", (object)val69);
			if (((Element)val69).get_StyleId() == null)
			{
				((Element)val69).set_StyleId("expectedDatedetails");
			}
			((INameScope)val126).RegisterName("iconLabel", (object)val107);
			if (((Element)val107).get_StyleId() == null)
			{
				((Element)val107).set_StyleId("iconLabel");
			}
			((INameScope)val126).RegisterName("versionNumberLabel", (object)val120);
			if (((Element)val120).get_StyleId() == null)
			{
				((Element)val120).set_StyleId("versionNumberLabel");
			}
			mainPage = mainView;
			containingView = val122;
			textMessage = val20;
			notificationCount = val24;
			viewAllNotificationsLabel = val30;
			linkTapGesture = val29;
			border = val41;
			expectedDate = val57;
			expectedDay = val63;
			expectedDatedetails = val69;
			iconLabel = val107;
			versionNumberLabel = val120;
			((BindableObject)mainView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			val2.set_Path("MainViewTitle");
			BindingBase val127 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)mainView).SetBinding(Page.TitleProperty, val127);
			val3.set_Key("AppLogo");
			XamlServiceProvider val128 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = tintedCachedImage;
			array[1] = mainView;
			SimpleValueTargetProvider val129 = new SimpleValueTargetProvider(array, (object)CachedImage.SourceProperty, (INameScope)(object)val126);
			object obj = (object)val129;
			val128.Add(typeFromHandle, (object)val129);
			val128.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val130 = new XmlNamespaceResolver();
			val130.Add("", "http://xamarin.com/schemas/2014/forms");
			val130.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val130.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val130.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val130.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val130.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val130.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val130.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val130.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val128.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val130, typeof(MainView).GetTypeInfo().Assembly));
			val128.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 13)));
			DynamicResource val131 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val128);
			((IDynamicResourceHandler)tintedCachedImage).SetDynamicResource(CachedImage.SourceProperty, val131.get_Key());
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)tintedCachedImage).SetValue(VisualElement.WidthRequestProperty, (object)200.0);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0, 8.0));
			((BindableObject)mainView).SetValue(NavigationPage.TitleViewProperty, (object)tintedCachedImage);
			((VisualElement)mainView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)mainView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			val4.set_Path("RefreshCommand");
			BindingBase val132 = ((IMarkupExtension<BindingBase>)(object)val4).ProvideValue((IServiceProvider)null);
			((BindableObject)val125).SetBinding(RefreshView.CommandProperty, val132);
			val5.set_Path("IsRefreshing");
			BindingBase val133 = ((IMarkupExtension<BindingBase>)(object)val5).ProvideValue((IServiceProvider)null);
			((BindableObject)val125).SetBinding(RefreshView.IsRefreshingProperty, val133);
			val6.set_Key("SecondaryTextColor");
			XamlServiceProvider val134 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 2];
			array2[0] = val125;
			array2[1] = mainView;
			SimpleValueTargetProvider val135 = new SimpleValueTargetProvider(array2, (object)RefreshView.RefreshColorProperty, (INameScope)(object)val126);
			object obj2 = (object)val135;
			val134.Add(typeFromHandle3, (object)val135);
			val134.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val136 = new XmlNamespaceResolver();
			val136.Add("", "http://xamarin.com/schemas/2014/forms");
			val136.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val136.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val136.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val136.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val136.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val136.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val136.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val136.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val134.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val136, typeof(MainView).GetTypeInfo().Assembly));
			val134.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 13)));
			DynamicResource val137 = ((IMarkupExtension<DynamicResource>)(object)val6).ProvideValue((IServiceProvider)val134);
			((IDynamicResourceHandler)val125).SetDynamicResource(RefreshView.RefreshColorProperty, val137.get_Key());
			((BindableObject)val125).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val124).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val123).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val18).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val7.set_Key("SecondaryColor");
			XamlServiceProvider val138 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 5];
			array3[0] = val18;
			array3[1] = val123;
			array3[2] = val124;
			array3[3] = val125;
			array3[4] = mainView;
			SimpleValueTargetProvider val139 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val126);
			object obj3 = (object)val139;
			val138.Add(typeFromHandle5, (object)val139);
			val138.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val140 = new XmlNamespaceResolver();
			val140.Add("", "http://xamarin.com/schemas/2014/forms");
			val140.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val140.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val140.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val140.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val140.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val140.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val140.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val140.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val138.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val140, typeof(MainView).GetTypeInfo().Assembly));
			val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 25)));
			DynamicResource val141 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val138);
			((IDynamicResourceHandler)val18).SetDynamicResource(VisualElement.BackgroundColorProperty, val141.get_Key());
			((BindableObject)val18).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			val8.set_Path("AppIsNotLatestVersion");
			BindingBase val142 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)val18).SetBinding(VisualElement.IsVisibleProperty, val142);
			val9.set_Path("OpenVersionUpdateCommand");
			BindingBase val143 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)null);
			((BindableObject)val10).SetBinding(TapGestureRecognizer.CommandProperty, val143);
			((View)val18).get_GestureRecognizers().Add((IGestureRecognizer)(object)val10);
			val11.set_Key("faArrowRight");
			XamlServiceProvider val144 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 6];
			array4[0] = val12;
			array4[1] = val18;
			array4[2] = val123;
			array4[3] = val124;
			array4[4] = val125;
			array4[5] = mainView;
			SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array4, (object)Label.TextProperty, (INameScope)(object)val126);
			object obj4 = (object)val145;
			val144.Add(typeFromHandle7, (object)val145);
			val144.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val146 = new XmlNamespaceResolver();
			val146.Add("", "http://xamarin.com/schemas/2014/forms");
			val146.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val146.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val146.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val146.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val146.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val146.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val146.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val146.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val144.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val146, typeof(MainView).GetTypeInfo().Assembly));
			val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(41, 29)));
			object text = ((IMarkupExtension)val11).ProvideValue((IServiceProvider)val144);
			val12.set_Text((string)text);
			((BindableObject)val12).SetValue(Label.TextColorProperty, (object)Color.Transparent);
			((BindableObject)val12).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val12).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val12).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val12);
			((BindableObject)val14).SetValue(Label.TextProperty, (object)appVersion_NewVersion_Banner);
			val13.set_Key("ButtonTextColor");
			XamlServiceProvider val147 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 6];
			array5[0] = val14;
			array5[1] = val18;
			array5[2] = val123;
			array5[3] = val124;
			array5[4] = val125;
			array5[5] = mainView;
			SimpleValueTargetProvider val148 = new SimpleValueTargetProvider(array5, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj5 = (object)val148;
			val147.Add(typeFromHandle9, (object)val148);
			val147.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val149 = new XmlNamespaceResolver();
			val149.Add("", "http://xamarin.com/schemas/2014/forms");
			val149.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val149.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val149.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val149.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val149.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val149.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val149.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val149.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val147.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val149, typeof(MainView).GetTypeInfo().Assembly));
			val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 29)));
			DynamicResource val150 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val147);
			((IDynamicResourceHandler)val14).SetDynamicResource(Label.TextColorProperty, val150.get_Key());
			((BindableObject)val14).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val14).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val14).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val14).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val14);
			val15.set_Key("faArrowRight");
			XamlServiceProvider val151 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 6];
			array6[0] = val17;
			array6[1] = val18;
			array6[2] = val123;
			array6[3] = val124;
			array6[4] = val125;
			array6[5] = mainView;
			SimpleValueTargetProvider val152 = new SimpleValueTargetProvider(array6, (object)Label.TextProperty, (INameScope)(object)val126);
			object obj6 = (object)val152;
			val151.Add(typeFromHandle11, (object)val152);
			val151.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val153 = new XmlNamespaceResolver();
			val153.Add("", "http://xamarin.com/schemas/2014/forms");
			val153.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val153.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val153.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val153.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val153.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val153.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val153.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val153.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val151.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val153, typeof(MainView).GetTypeInfo().Assembly));
			val151.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 29)));
			object text2 = ((IMarkupExtension)val15).ProvideValue((IServiceProvider)val151);
			val17.set_Text((string)text2);
			val16.set_Key("ButtonTextColor");
			XamlServiceProvider val154 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 6];
			array7[0] = val17;
			array7[1] = val18;
			array7[2] = val123;
			array7[3] = val124;
			array7[4] = val125;
			array7[5] = mainView;
			SimpleValueTargetProvider val155 = new SimpleValueTargetProvider(array7, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj7 = (object)val155;
			val154.Add(typeFromHandle13, (object)val155);
			val154.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val156 = new XmlNamespaceResolver();
			val156.Add("", "http://xamarin.com/schemas/2014/forms");
			val156.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val156.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val156.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val156.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val156.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val156.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val156.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val156.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val154.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val156, typeof(MainView).GetTypeInfo().Assembly));
			val154.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 29)));
			DynamicResource val157 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val154);
			((IDynamicResourceHandler)val17).SetDynamicResource(Label.TextColorProperty, val157.get_Key());
			((BindableObject)val17).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val17).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val17).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val18).get_Children().Add((View)(object)val17);
			((Layout<View>)(object)val123).get_Children().Add((View)(object)val18);
			((BindableObject)val122).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val122).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val122).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val31).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val31).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((BindableObject)val25).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val25).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			val19.set_Key("Heading2");
			XamlServiceProvider val158 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 8];
			array8[0] = val20;
			array8[1] = val25;
			array8[2] = val31;
			array8[3] = val122;
			array8[4] = val123;
			array8[5] = val124;
			array8[6] = val125;
			array8[7] = mainView;
			SimpleValueTargetProvider val159 = new SimpleValueTargetProvider(array8, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj8 = (object)val159;
			val158.Add(typeFromHandle15, (object)val159);
			val158.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
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
			val158.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val160, typeof(MainView).GetTypeInfo().Assembly));
			val158.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(75, 37)));
			DynamicResource val161 = ((IMarkupExtension<DynamicResource>)(object)val19).ProvideValue((IServiceProvider)val158);
			((IDynamicResourceHandler)val20).SetDynamicResource(VisualElement.StyleProperty, val161.get_Key());
			((BindableObject)val20).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val20).SetValue(Label.TextProperty, (object)homePage_NotificationsTitle);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val20);
			val21.set_Key("Heading2");
			XamlServiceProvider val162 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 8];
			array9[0] = val24;
			array9[1] = val25;
			array9[2] = val31;
			array9[3] = val122;
			array9[4] = val123;
			array9[5] = val124;
			array9[6] = val125;
			array9[7] = mainView;
			SimpleValueTargetProvider val163 = new SimpleValueTargetProvider(array9, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj9 = (object)val163;
			val162.Add(typeFromHandle17, (object)val163);
			val162.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
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
			val162.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val164, typeof(MainView).GetTypeInfo().Assembly));
			val162.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 37)));
			DynamicResource val165 = ((IMarkupExtension<DynamicResource>)(object)val21).ProvideValue((IServiceProvider)val162);
			((IDynamicResourceHandler)val24).SetDynamicResource(VisualElement.StyleProperty, val165.get_Key());
			((BindableObject)val24).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val22.set_Key("PrimaryColor");
			XamlServiceProvider val166 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 8];
			array10[0] = val24;
			array10[1] = val25;
			array10[2] = val31;
			array10[3] = val122;
			array10[4] = val123;
			array10[5] = val124;
			array10[6] = val125;
			array10[7] = mainView;
			SimpleValueTargetProvider val167 = new SimpleValueTargetProvider(array10, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj10 = (object)val167;
			val166.Add(typeFromHandle19, (object)val167);
			val166.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val168 = new XmlNamespaceResolver();
			val168.Add("", "http://xamarin.com/schemas/2014/forms");
			val168.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val168.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val168.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val168.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val168.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val168.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val168.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val168.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val166.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val168, typeof(MainView).GetTypeInfo().Assembly));
			val166.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(82, 37)));
			DynamicResource val169 = ((IMarkupExtension<DynamicResource>)(object)val22).ProvideValue((IServiceProvider)val166);
			((IDynamicResourceHandler)val24).SetDynamicResource(Label.TextColorProperty, val169.get_Key());
			val23.set_Path("NotificationCountLabel");
			BindingBase val170 = ((IMarkupExtension<BindingBase>)(object)val23).ProvideValue((IServiceProvider)null);
			((BindableObject)val24).SetBinding(Label.TextProperty, val170);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val24);
			((Layout<View>)(object)val31).get_Children().Add((View)(object)val25);
			((BindableObject)val30).SetValue(Label.TextProperty, (object)homePage_ViewAll);
			val26.set_Key("SecondaryLinkColor");
			XamlServiceProvider val171 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 7];
			array11[0] = val30;
			array11[1] = val31;
			array11[2] = val122;
			array11[3] = val123;
			array11[4] = val124;
			array11[5] = val125;
			array11[6] = mainView;
			SimpleValueTargetProvider val172 = new SimpleValueTargetProvider(array11, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj11 = (object)val172;
			val171.Add(typeFromHandle21, (object)val172);
			val171.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val173 = new XmlNamespaceResolver();
			val173.Add("", "http://xamarin.com/schemas/2014/forms");
			val173.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val173.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val173.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val173.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val173.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val173.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val173.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val173.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val171.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val173, typeof(MainView).GetTypeInfo().Assembly));
			val171.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 33)));
			DynamicResource val174 = ((IMarkupExtension<DynamicResource>)(object)val26).ProvideValue((IServiceProvider)val171);
			((IDynamicResourceHandler)val30).SetDynamicResource(Label.TextColorProperty, val174.get_Key());
			((BindableObject)val30).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val30).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val30).SetValue(Label.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val27.set_Path("ShowViewAllNotifications");
			BindingBase val175 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)null);
			((BindableObject)val30).SetBinding(VisualElement.IsVisibleProperty, val175);
			val28.set_Path("ViewAllNotificationCommand");
			BindingBase val176 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)null);
			((BindableObject)val29).SetBinding(TapGestureRecognizer.CommandProperty, val176);
			((View)val30).get_GestureRecognizers().Add((IGestureRecognizer)(object)val29);
			((Layout<View>)(object)val31).get_Children().Add((View)(object)val30);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)val31);
			((BindableObject)val37).SetValue(ScrollView.OrientationProperty, (object)(ScrollOrientation)1);
			((BindableObject)val37).SetValue(ScrollView.HorizontalScrollBarVisibilityProperty, (object)(ScrollBarVisibility)2);
			((BindableObject)val37).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.StartAndExpand);
			((BindableObject)val37).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val32.set_Key("InverseBoolConverter");
			XamlServiceProvider val177 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 7];
			array12[0] = val33;
			array12[1] = val37;
			array12[2] = val122;
			array12[3] = val123;
			array12[4] = val124;
			array12[5] = val125;
			array12[6] = mainView;
			SimpleValueTargetProvider val178 = new SimpleValueTargetProvider(array12, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val126);
			object obj12 = (object)val178;
			val177.Add(typeFromHandle23, (object)val178);
			val177.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
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
			val177.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val179, typeof(MainView).GetTypeInfo().Assembly));
			val177.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(107, 29)));
			object converter = ((IMarkupExtension)val32).ProvideValue((IServiceProvider)val177);
			val33.set_Converter((IValueConverter)converter);
			val33.set_Path("NoUnreadNotifications");
			BindingBase val180 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)null);
			((BindableObject)val37).SetBinding(VisualElement.IsVisibleProperty, val180);
			val34.set_Path("UnreadNotifications");
			BindingBase val181 = ((IMarkupExtension<BindingBase>)(object)val34).ProvideValue((IServiceProvider)null);
			((BindableObject)val36).SetBinding(BindableLayout.ItemsSourceProperty, val181);
			((BindableObject)val36).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			object[] array13 = new object[0 + 8];
			array13[0] = val35;
			array13[1] = val36;
			array13[2] = val37;
			array13[3] = val122;
			array13[4] = val123;
			array13[5] = val124;
			array13[6] = val125;
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
				BindingExtension val341 = new BindingExtension();
				ReferenceExtension val342 = new ReferenceExtension();
				BindingExtension val343 = new BindingExtension();
				BindingExtension val344 = new BindingExtension();
				BindingExtension val345 = new BindingExtension();
				BindingExtension val346 = new BindingExtension();
				BindingExtension val347 = new BindingExtension();
				BindingExtension val348 = new BindingExtension();
				ReferenceExtension val349 = new ReferenceExtension();
				BindingExtension val350 = new BindingExtension();
				BindingExtension val351 = new BindingExtension();
				NotificationView notificationView = new NotificationView();
				NameScope val352 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)notificationView, (INameScope)(object)val352);
				((BindableObject)notificationView).SetValue(NotificationView.ShowBorderProperty, (object)true);
				val341.set_Path("Title");
				BindingBase val353 = ((IMarkupExtension<BindingBase>)(object)val341).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TitleProperty, val353);
				((BindableObject)notificationView).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
				val342.set_Name("mainPage");
				XamlServiceProvider val354 = new XamlServiceProvider();
				Type typeFromHandle99 = typeof(IProvideValueTarget);
				int length;
				object[] array51 = new object[(length = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array51, 2, length);
				array51[0] = val343;
				array51[1] = notificationView;
				SimpleValueTargetProvider val355 = new SimpleValueTargetProvider(array51, (object)typeof(BindingExtension).GetRuntimeProperty("Source"), (INameScope)(object)val352);
				object obj58 = (object)val355;
				val354.Add(typeFromHandle99, (object)val355);
				val354.Add(typeof(IReferenceProvider), obj58);
				Type typeFromHandle100 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val356 = new XmlNamespaceResolver();
				val356.Add("", "http://xamarin.com/schemas/2014/forms");
				val356.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val356.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
				val356.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val356.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val356.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val356.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val356.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val356.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
				val354.Add(typeFromHandle100, (object)new XamlTypeResolver((IXmlNamespaceResolver)val356, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_6).GetTypeInfo().Assembly));
				val354.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(117, 45)));
				object source = ((IMarkupExtension)val342).ProvideValue((IServiceProvider)val354);
				val343.set_Source(source);
				val343.set_Path("BindingContext.NotificationWidth");
				BindingBase val357 = ((IMarkupExtension<BindingBase>)(object)val343).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(VisualElement.WidthRequestProperty, val357);
				val344.set_Path("DateCreatedLabel");
				BindingBase val358 = ((IMarkupExtension<BindingBase>)(object)val344).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.DateProperty, val358);
				val345.set_Path("Description");
				BindingBase val359 = ((IMarkupExtension<BindingBase>)(object)val345).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.DescriptionProperty, val359);
				val346.set_Path("ActionLabel");
				BindingBase val360 = ((IMarkupExtension<BindingBase>)(object)val346).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.ActionLabelProperty, val360);
				val347.set_Path("IsFirst");
				BindingBase val361 = ((IMarkupExtension<BindingBase>)(object)val347).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.IsFirstProperty, val361);
				val348.set_Path("IsLast");
				BindingBase val362 = ((IMarkupExtension<BindingBase>)(object)val348).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.IsLastProperty, val362);
				val349.set_Name("mainPage");
				XamlServiceProvider val363 = new XamlServiceProvider();
				Type typeFromHandle101 = typeof(IProvideValueTarget);
				int length2;
				object[] array52 = new object[(length2 = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array52, 2, length2);
				array52[0] = val350;
				array52[1] = notificationView;
				SimpleValueTargetProvider val364 = new SimpleValueTargetProvider(array52, (object)typeof(BindingExtension).GetRuntimeProperty("Source"), (INameScope)(object)val352);
				object obj59 = (object)val364;
				val363.Add(typeFromHandle101, (object)val364);
				val363.Add(typeof(IReferenceProvider), obj59);
				Type typeFromHandle102 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val365 = new XmlNamespaceResolver();
				val365.Add("", "http://xamarin.com/schemas/2014/forms");
				val365.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val365.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
				val365.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val365.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val365.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val365.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val365.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val365.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
				val363.Add(typeFromHandle102, (object)new XamlTypeResolver((IXmlNamespaceResolver)val365, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_6).GetTypeInfo().Assembly));
				val363.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(123, 45)));
				object source2 = ((IMarkupExtension)val349).ProvideValue((IServiceProvider)val363);
				val350.set_Source(source2);
				val350.set_Path("BindingContext.NotificationTapCommand");
				BindingBase val366 = ((IMarkupExtension<BindingBase>)(object)val350).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TapCommandProperty, val366);
				val351.set_Path(".");
				BindingBase val367 = ((IMarkupExtension<BindingBase>)(object)val351).ProvideValue((IServiceProvider)null);
				((BindableObject)notificationView).SetBinding(NotificationView.TapCommandParameterProperty, val367);
				return notificationView;
			});
			((BindableObject)val36).SetValue(BindableLayout.ItemTemplateProperty, (object)val35);
			val37.set_Content((View)(object)val36);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)val37);
			((BindableObject)shadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)shadowFrame).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val38.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val182 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array14 = new object[0 + 6];
			array14[0] = shadowFrame;
			array14[1] = val122;
			array14[2] = val123;
			array14[3] = val124;
			array14[4] = val125;
			array14[5] = mainView;
			SimpleValueTargetProvider val183 = new SimpleValueTargetProvider(array14, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val126);
			object obj13 = (object)val183;
			val182.Add(typeFromHandle25, (object)val183);
			val182.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
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
			val182.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val184, typeof(MainView).GetTypeInfo().Assembly));
			val182.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(136, 29)));
			DynamicResource val185 = ((IMarkupExtension<DynamicResource>)(object)val38).ProvideValue((IServiceProvider)val182);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val185.get_Key());
			val39.set_Path("NoUnreadNotifications");
			BindingBase val186 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)null);
			((BindableObject)shadowFrame).SetBinding(VisualElement.IsVisibleProperty, val186);
			((BindableObject)val50).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val50).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val41).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val40.set_Key("GrayColor");
			XamlServiceProvider val187 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array15 = new object[0 + 8];
			array15[0] = val41;
			array15[1] = val50;
			array15[2] = shadowFrame;
			array15[3] = val122;
			array15[4] = val123;
			array15[5] = val124;
			array15[6] = val125;
			array15[7] = mainView;
			SimpleValueTargetProvider val188 = new SimpleValueTargetProvider(array15, (object)BoxView.ColorProperty, (INameScope)(object)val126);
			object obj14 = (object)val188;
			val187.Add(typeFromHandle27, (object)val188);
			val187.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val189 = new XmlNamespaceResolver();
			val189.Add("", "http://xamarin.com/schemas/2014/forms");
			val189.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val189.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val189.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val189.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val189.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val189.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val189.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val189.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val187.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val189, typeof(MainView).GetTypeInfo().Assembly));
			val187.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(144, 37)));
			DynamicResource val190 = ((IMarkupExtension<DynamicResource>)(object)val40).ProvideValue((IServiceProvider)val187);
			((IDynamicResourceHandler)val41).SetDynamicResource(BoxView.ColorProperty, val190.get_Key());
			((Layout<View>)(object)val50).get_Children().Add((View)(object)val41);
			((BindableObject)val49).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 16.0, 16.0, 24.0));
			((BindableObject)val49).SetValue(StackLayout.SpacingProperty, (object)8.0);
			((BindableObject)val49).SetValue(Skeleton.IsParentProperty, (object)true);
			val42.set_Path("IsDoingInitialLoad");
			BindingBase val191 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)null);
			((BindableObject)val49).SetBinding(Skeleton.IsBusyProperty, val191);
			val43.set_Source((AnimationTypes)2);
			XamlServiceProvider val192 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array16 = new object[0 + 8];
			array16[0] = val49;
			array16[1] = val50;
			array16[2] = shadowFrame;
			array16[3] = val122;
			array16[4] = val123;
			array16[5] = val124;
			array16[6] = val125;
			array16[7] = mainView;
			SimpleValueTargetProvider val193 = new SimpleValueTargetProvider(array16, (object)Skeleton.AnimationProperty, (INameScope)(object)val126);
			object obj15 = (object)val193;
			val192.Add(typeFromHandle29, (object)val193);
			val192.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val194 = new XmlNamespaceResolver();
			val194.Add("", "http://xamarin.com/schemas/2014/forms");
			val194.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val194.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val194.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val194.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val194.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val194.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val194.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val194.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val192.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val194, typeof(MainView).GetTypeInfo().Assembly));
			val192.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(150, 37)));
			BaseAnimation val195 = ((IMarkupExtension<BaseAnimation>)(object)val43).ProvideValue((IServiceProvider)val192);
			((BindableObject)val49).SetValue(Skeleton.AnimationProperty, (object)val195);
			val44.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val196 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array17 = new object[0 + 8];
			array17[0] = val49;
			array17[1] = val50;
			array17[2] = shadowFrame;
			array17[3] = val122;
			array17[4] = val123;
			array17[5] = val124;
			array17[6] = val125;
			array17[7] = mainView;
			SimpleValueTargetProvider val197 = new SimpleValueTargetProvider(array17, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val126);
			object obj16 = (object)val197;
			val196.Add(typeFromHandle31, (object)val197);
			val196.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val198 = new XmlNamespaceResolver();
			val198.Add("", "http://xamarin.com/schemas/2014/forms");
			val198.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val198.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val198.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val198.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val198.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val198.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val198.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val198.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val196.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val198, typeof(MainView).GetTypeInfo().Assembly));
			val196.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(151, 37)));
			DynamicResource val199 = ((IMarkupExtension<DynamicResource>)(object)val44).ProvideValue((IServiceProvider)val196);
			((IDynamicResourceHandler)val49).SetDynamicResource(Skeleton.BackgroundColorProperty, val199.get_Key());
			((BindableObject)val48).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			val45.set_Key("Small");
			XamlServiceProvider val200 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array18 = new object[0 + 9];
			array18[0] = val48;
			array18[1] = val49;
			array18[2] = val50;
			array18[3] = shadowFrame;
			array18[4] = val122;
			array18[5] = val123;
			array18[6] = val124;
			array18[7] = val125;
			array18[8] = mainView;
			SimpleValueTargetProvider val201 = new SimpleValueTargetProvider(array18, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj17 = (object)val201;
			val200.Add(typeFromHandle33, (object)val201);
			val200.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val202 = new XmlNamespaceResolver();
			val202.Add("", "http://xamarin.com/schemas/2014/forms");
			val202.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val202.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val202.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val202.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val202.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val202.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val202.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val202.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val200.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val202, typeof(MainView).GetTypeInfo().Assembly));
			val200.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(154, 41)));
			DynamicResource val203 = ((IMarkupExtension<DynamicResource>)(object)val45).ProvideValue((IServiceProvider)val200);
			((IDynamicResourceHandler)val48).SetDynamicResource(VisualElement.StyleProperty, val203.get_Key());
			((BindableObject)val48).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Italic"));
			((BindableObject)val48).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val48).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)val48).SetValue(Label.TextProperty, (object)homePage_YouHaveNoNewNotifications);
			val46.set_Path("IsDoingInitialLoad");
			BindingBase val204 = ((IMarkupExtension<BindingBase>)(object)val46).ProvideValue((IServiceProvider)null);
			((BindableObject)val48).SetBinding(Skeleton.IsBusyProperty, val204);
			val47.set_Key("GrayColor");
			XamlServiceProvider val205 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array19 = new object[0 + 9];
			array19[0] = val48;
			array19[1] = val49;
			array19[2] = val50;
			array19[3] = shadowFrame;
			array19[4] = val122;
			array19[5] = val123;
			array19[6] = val124;
			array19[7] = val125;
			array19[8] = mainView;
			SimpleValueTargetProvider val206 = new SimpleValueTargetProvider(array19, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val126);
			object obj18 = (object)val206;
			val205.Add(typeFromHandle35, (object)val206);
			val205.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val207 = new XmlNamespaceResolver();
			val207.Add("", "http://xamarin.com/schemas/2014/forms");
			val207.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val207.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val207.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val207.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val207.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val207.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val207.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val207.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val205.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val207, typeof(MainView).GetTypeInfo().Assembly));
			val205.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(160, 41)));
			DynamicResource val208 = ((IMarkupExtension<DynamicResource>)(object)val47).ProvideValue((IServiceProvider)val205);
			((IDynamicResourceHandler)val48).SetDynamicResource(Skeleton.BackgroundColorProperty, val208.get_Key());
			((Layout<View>)(object)val49).get_Children().Add((View)(object)val48);
			((Layout<View>)(object)val50).get_Children().Add((View)(object)val49);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val50);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)shadowFrame);
			((BindableObject)val72).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val51.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val209 = new XamlServiceProvider();
			Type typeFromHandle37 = typeof(IProvideValueTarget);
			object[] array20 = new object[0 + 7];
			array20[0] = shadowFrame2;
			array20[1] = val72;
			array20[2] = val122;
			array20[3] = val123;
			array20[4] = val124;
			array20[5] = val125;
			array20[6] = mainView;
			SimpleValueTargetProvider val210 = new SimpleValueTargetProvider(array20, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val126);
			object obj19 = (object)val210;
			val209.Add(typeFromHandle37, (object)val210);
			val209.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle38 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val211 = new XmlNamespaceResolver();
			val211.Add("", "http://xamarin.com/schemas/2014/forms");
			val211.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val211.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val211.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val211.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val211.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val211.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val211.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val211.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val209.Add(typeFromHandle38, (object)new XamlTypeResolver((IXmlNamespaceResolver)val211, typeof(MainView).GetTypeInfo().Assembly));
			val209.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(169, 33)));
			DynamicResource val212 = ((IMarkupExtension<DynamicResource>)(object)val51).ProvideValue((IServiceProvider)val209);
			((IDynamicResourceHandler)shadowFrame2).SetDynamicResource(VisualElement.BackgroundColorProperty, val212.get_Key());
			((BindableObject)shadowFrame2).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0));
			((BindableObject)shadowFrame2).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((BindableObject)val71).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
			((BindableObject)val71).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val71).SetValue(Skeleton.IsParentProperty, (object)true);
			val52.set_Path("IsDoingInitialLoad");
			BindingBase val213 = ((IMarkupExtension<BindingBase>)(object)val52).ProvideValue((IServiceProvider)null);
			((BindableObject)val71).SetBinding(Skeleton.IsBusyProperty, val213);
			val53.set_Source((AnimationTypes)2);
			XamlServiceProvider val214 = new XamlServiceProvider();
			Type typeFromHandle39 = typeof(IProvideValueTarget);
			object[] array21 = new object[0 + 8];
			array21[0] = val71;
			array21[1] = shadowFrame2;
			array21[2] = val72;
			array21[3] = val122;
			array21[4] = val123;
			array21[5] = val124;
			array21[6] = val125;
			array21[7] = mainView;
			SimpleValueTargetProvider val215 = new SimpleValueTargetProvider(array21, (object)Skeleton.AnimationProperty, (INameScope)(object)val126);
			object obj20 = (object)val215;
			val214.Add(typeFromHandle39, (object)val215);
			val214.Add(typeof(IReferenceProvider), obj20);
			Type typeFromHandle40 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val216 = new XmlNamespaceResolver();
			val216.Add("", "http://xamarin.com/schemas/2014/forms");
			val216.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val216.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val216.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val216.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val216.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val216.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val216.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val216.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val214.Add(typeFromHandle40, (object)new XamlTypeResolver((IXmlNamespaceResolver)val216, typeof(MainView).GetTypeInfo().Assembly));
			val214.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(177, 37)));
			BaseAnimation val217 = ((IMarkupExtension<BaseAnimation>)(object)val53).ProvideValue((IServiceProvider)val214);
			((BindableObject)val71).SetValue(Skeleton.AnimationProperty, (object)val217);
			val54.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val218 = new XamlServiceProvider();
			Type typeFromHandle41 = typeof(IProvideValueTarget);
			object[] array22 = new object[0 + 8];
			array22[0] = val71;
			array22[1] = shadowFrame2;
			array22[2] = val72;
			array22[3] = val122;
			array22[4] = val123;
			array22[5] = val124;
			array22[6] = val125;
			array22[7] = mainView;
			SimpleValueTargetProvider val219 = new SimpleValueTargetProvider(array22, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val126);
			object obj21 = (object)val219;
			val218.Add(typeFromHandle41, (object)val219);
			val218.Add(typeof(IReferenceProvider), obj21);
			Type typeFromHandle42 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val220 = new XmlNamespaceResolver();
			val220.Add("", "http://xamarin.com/schemas/2014/forms");
			val220.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val220.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val220.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val220.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val220.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val220.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val220.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val220.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val218.Add(typeFromHandle42, (object)new XamlTypeResolver((IXmlNamespaceResolver)val220, typeof(MainView).GetTypeInfo().Assembly));
			val218.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(178, 37)));
			DynamicResource val221 = ((IMarkupExtension<DynamicResource>)(object)val54).ProvideValue((IServiceProvider)val218);
			((IDynamicResourceHandler)val71).SetDynamicResource(Skeleton.BackgroundColorProperty, val221.get_Key());
			((BindableObject)val57).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val57).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val57).SetValue(Label.TextProperty, (object)homePage_ExpectedEndDate);
			val55.set_Path("IsDoingInitialLoad");
			BindingBase val222 = ((IMarkupExtension<BindingBase>)(object)val55).ProvideValue((IServiceProvider)null);
			((BindableObject)val57).SetBinding(Skeleton.IsBusyProperty, val222);
			val56.set_Key("TertiaryTextColor");
			XamlServiceProvider val223 = new XamlServiceProvider();
			Type typeFromHandle43 = typeof(IProvideValueTarget);
			object[] array23 = new object[0 + 9];
			array23[0] = val57;
			array23[1] = val71;
			array23[2] = shadowFrame2;
			array23[3] = val72;
			array23[4] = val122;
			array23[5] = val123;
			array23[6] = val124;
			array23[7] = val125;
			array23[8] = mainView;
			SimpleValueTargetProvider val224 = new SimpleValueTargetProvider(array23, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val126);
			object obj22 = (object)val224;
			val223.Add(typeFromHandle43, (object)val224);
			val223.Add(typeof(IReferenceProvider), obj22);
			Type typeFromHandle44 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val225 = new XmlNamespaceResolver();
			val225.Add("", "http://xamarin.com/schemas/2014/forms");
			val225.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val225.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val225.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val225.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val225.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val225.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val225.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val225.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val223.Add(typeFromHandle44, (object)new XamlTypeResolver((IXmlNamespaceResolver)val225, typeof(MainView).GetTypeInfo().Assembly));
			val223.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(185, 41)));
			DynamicResource val226 = ((IMarkupExtension<DynamicResource>)(object)val56).ProvideValue((IServiceProvider)val223);
			((IDynamicResourceHandler)val57).SetDynamicResource(Skeleton.BackgroundColorProperty, val226.get_Key());
			((Layout<View>)(object)val71).get_Children().Add((View)(object)val57);
			((BindableObject)val70).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val70).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.EndAndExpand);
			val58.set_Path("ExpectedEndDayLabel");
			BindingBase val227 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)null);
			((BindableObject)val63).SetBinding(Label.TextProperty, val227);
			val59.set_Key("SecondaryColor");
			XamlServiceProvider val228 = new XamlServiceProvider();
			Type typeFromHandle45 = typeof(IProvideValueTarget);
			object[] array24 = new object[0 + 10];
			array24[0] = val63;
			array24[1] = val70;
			array24[2] = val71;
			array24[3] = shadowFrame2;
			array24[4] = val72;
			array24[5] = val122;
			array24[6] = val123;
			array24[7] = val124;
			array24[8] = val125;
			array24[9] = mainView;
			SimpleValueTargetProvider val229 = new SimpleValueTargetProvider(array24, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj23 = (object)val229;
			val228.Add(typeFromHandle45, (object)val229);
			val228.Add(typeof(IReferenceProvider), obj23);
			Type typeFromHandle46 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val230 = new XmlNamespaceResolver();
			val230.Add("", "http://xamarin.com/schemas/2014/forms");
			val230.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val230.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val230.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val230.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val230.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val230.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val230.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val230.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val228.Add(typeFromHandle46, (object)new XamlTypeResolver((IXmlNamespaceResolver)val230, typeof(MainView).GetTypeInfo().Assembly));
			val228.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(192, 45)));
			DynamicResource val231 = ((IMarkupExtension<DynamicResource>)(object)val59).ProvideValue((IServiceProvider)val228);
			((IDynamicResourceHandler)val63).SetDynamicResource(Label.TextColorProperty, val231.get_Key());
			val60.set_Key("Small");
			XamlServiceProvider val232 = new XamlServiceProvider();
			Type typeFromHandle47 = typeof(IProvideValueTarget);
			object[] array25 = new object[0 + 10];
			array25[0] = val63;
			array25[1] = val70;
			array25[2] = val71;
			array25[3] = shadowFrame2;
			array25[4] = val72;
			array25[5] = val122;
			array25[6] = val123;
			array25[7] = val124;
			array25[8] = val125;
			array25[9] = mainView;
			SimpleValueTargetProvider val233 = new SimpleValueTargetProvider(array25, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj24 = (object)val233;
			val232.Add(typeFromHandle47, (object)val233);
			val232.Add(typeof(IReferenceProvider), obj24);
			Type typeFromHandle48 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val234 = new XmlNamespaceResolver();
			val234.Add("", "http://xamarin.com/schemas/2014/forms");
			val234.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val234.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val234.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val234.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val234.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val234.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val234.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val234.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val232.Add(typeFromHandle48, (object)new XamlTypeResolver((IXmlNamespaceResolver)val234, typeof(MainView).GetTypeInfo().Assembly));
			val232.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(193, 45)));
			DynamicResource val235 = ((IMarkupExtension<DynamicResource>)(object)val60).ProvideValue((IServiceProvider)val232);
			((IDynamicResourceHandler)val63).SetDynamicResource(VisualElement.StyleProperty, val235.get_Key());
			val61.set_Path("IsDoingInitialLoad");
			BindingBase val236 = ((IMarkupExtension<BindingBase>)(object)val61).ProvideValue((IServiceProvider)null);
			((BindableObject)val63).SetBinding(Skeleton.IsBusyProperty, val236);
			val62.set_Key("GrayColor");
			XamlServiceProvider val237 = new XamlServiceProvider();
			Type typeFromHandle49 = typeof(IProvideValueTarget);
			object[] array26 = new object[0 + 10];
			array26[0] = val63;
			array26[1] = val70;
			array26[2] = val71;
			array26[3] = shadowFrame2;
			array26[4] = val72;
			array26[5] = val122;
			array26[6] = val123;
			array26[7] = val124;
			array26[8] = val125;
			array26[9] = mainView;
			SimpleValueTargetProvider val238 = new SimpleValueTargetProvider(array26, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val126);
			object obj25 = (object)val238;
			val237.Add(typeFromHandle49, (object)val238);
			val237.Add(typeof(IReferenceProvider), obj25);
			Type typeFromHandle50 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val239 = new XmlNamespaceResolver();
			val239.Add("", "http://xamarin.com/schemas/2014/forms");
			val239.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val239.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val239.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val239.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val239.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val239.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val239.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val239.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val237.Add(typeFromHandle50, (object)new XamlTypeResolver((IXmlNamespaceResolver)val239, typeof(MainView).GetTypeInfo().Assembly));
			val237.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(195, 45)));
			DynamicResource val240 = ((IMarkupExtension<DynamicResource>)(object)val62).ProvideValue((IServiceProvider)val237);
			((IDynamicResourceHandler)val63).SetDynamicResource(Skeleton.BackgroundColorProperty, val240.get_Key());
			((Layout<View>)(object)val70).get_Children().Add((View)(object)val63);
			val64.set_Key("Heading2");
			XamlServiceProvider val241 = new XamlServiceProvider();
			Type typeFromHandle51 = typeof(IProvideValueTarget);
			object[] array27 = new object[0 + 10];
			array27[0] = val69;
			array27[1] = val70;
			array27[2] = val71;
			array27[3] = shadowFrame2;
			array27[4] = val72;
			array27[5] = val122;
			array27[6] = val123;
			array27[7] = val124;
			array27[8] = val125;
			array27[9] = mainView;
			SimpleValueTargetProvider val242 = new SimpleValueTargetProvider(array27, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj26 = (object)val242;
			val241.Add(typeFromHandle51, (object)val242);
			val241.Add(typeof(IReferenceProvider), obj26);
			Type typeFromHandle52 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val243 = new XmlNamespaceResolver();
			val243.Add("", "http://xamarin.com/schemas/2014/forms");
			val243.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val243.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val243.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val243.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val243.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val243.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val243.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val243.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val241.Add(typeFromHandle52, (object)new XamlTypeResolver((IXmlNamespaceResolver)val243, typeof(MainView).GetTypeInfo().Assembly));
			val241.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(198, 45)));
			DynamicResource val244 = ((IMarkupExtension<DynamicResource>)(object)val64).ProvideValue((IServiceProvider)val241);
			((IDynamicResourceHandler)val69).SetDynamicResource(VisualElement.StyleProperty, val244.get_Key());
			val65.set_Path("ExpectedEndDateLabel");
			BindingBase val245 = ((IMarkupExtension<BindingBase>)(object)val65).ProvideValue((IServiceProvider)null);
			((BindableObject)val69).SetBinding(Label.TextProperty, val245);
			val66.set_Key("SecondaryColor");
			XamlServiceProvider val246 = new XamlServiceProvider();
			Type typeFromHandle53 = typeof(IProvideValueTarget);
			object[] array28 = new object[0 + 10];
			array28[0] = val69;
			array28[1] = val70;
			array28[2] = val71;
			array28[3] = shadowFrame2;
			array28[4] = val72;
			array28[5] = val122;
			array28[6] = val123;
			array28[7] = val124;
			array28[8] = val125;
			array28[9] = mainView;
			SimpleValueTargetProvider val247 = new SimpleValueTargetProvider(array28, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj27 = (object)val247;
			val246.Add(typeFromHandle53, (object)val247);
			val246.Add(typeof(IReferenceProvider), obj27);
			Type typeFromHandle54 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val248 = new XmlNamespaceResolver();
			val248.Add("", "http://xamarin.com/schemas/2014/forms");
			val248.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val248.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val248.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val248.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val248.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val248.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val248.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val248.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val246.Add(typeFromHandle54, (object)new XamlTypeResolver((IXmlNamespaceResolver)val248, typeof(MainView).GetTypeInfo().Assembly));
			val246.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(200, 45)));
			DynamicResource val249 = ((IMarkupExtension<DynamicResource>)(object)val66).ProvideValue((IServiceProvider)val246);
			((IDynamicResourceHandler)val69).SetDynamicResource(Label.TextColorProperty, val249.get_Key());
			((BindableObject)val69).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val67.set_Path("IsDoingInitialLoad");
			BindingBase val250 = ((IMarkupExtension<BindingBase>)(object)val67).ProvideValue((IServiceProvider)null);
			((BindableObject)val69).SetBinding(Skeleton.IsBusyProperty, val250);
			val68.set_Key("TertiaryTextColor");
			XamlServiceProvider val251 = new XamlServiceProvider();
			Type typeFromHandle55 = typeof(IProvideValueTarget);
			object[] array29 = new object[0 + 10];
			array29[0] = val69;
			array29[1] = val70;
			array29[2] = val71;
			array29[3] = shadowFrame2;
			array29[4] = val72;
			array29[5] = val122;
			array29[6] = val123;
			array29[7] = val124;
			array29[8] = val125;
			array29[9] = mainView;
			SimpleValueTargetProvider val252 = new SimpleValueTargetProvider(array29, (object)Skeleton.BackgroundColorProperty, (INameScope)(object)val126);
			object obj28 = (object)val252;
			val251.Add(typeFromHandle55, (object)val252);
			val251.Add(typeof(IReferenceProvider), obj28);
			Type typeFromHandle56 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val253 = new XmlNamespaceResolver();
			val253.Add("", "http://xamarin.com/schemas/2014/forms");
			val253.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val253.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val253.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val253.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val253.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val253.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val253.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val253.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val251.Add(typeFromHandle56, (object)new XamlTypeResolver((IXmlNamespaceResolver)val253, typeof(MainView).GetTypeInfo().Assembly));
			val251.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(203, 45)));
			DynamicResource val254 = ((IMarkupExtension<DynamicResource>)(object)val68).ProvideValue((IServiceProvider)val251);
			((IDynamicResourceHandler)val69).SetDynamicResource(Skeleton.BackgroundColorProperty, val254.get_Key());
			((Layout<View>)(object)val70).get_Children().Add((View)(object)val69);
			((Layout<View>)(object)val71).get_Children().Add((View)(object)val70);
			((BindableObject)shadowFrame2).SetValue(ContentView.ContentProperty, (object)val71);
			((ICollection<View>)val72.get_Children()).Add((View)(object)shadowFrame2);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)val72);
			((BindableObject)val85).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val73.set_Key("faStethoscope");
			XamlServiceProvider val255 = new XamlServiceProvider();
			Type typeFromHandle57 = typeof(IProvideValueTarget);
			object[] array30 = new object[0 + 7];
			array30[0] = buttonMainView;
			array30[1] = val85;
			array30[2] = val122;
			array30[3] = val123;
			array30[4] = val124;
			array30[5] = val125;
			array30[6] = mainView;
			SimpleValueTargetProvider val256 = new SimpleValueTargetProvider(array30, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj29 = (object)val256;
			val255.Add(typeFromHandle57, (object)val256);
			val255.Add(typeof(IReferenceProvider), obj29);
			Type typeFromHandle58 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val257 = new XmlNamespaceResolver();
			val257.Add("", "http://xamarin.com/schemas/2014/forms");
			val257.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val257.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val257.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val257.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val257.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val257.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val257.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val257.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val255.Add(typeFromHandle58, (object)new XamlTypeResolver((IXmlNamespaceResolver)val257, typeof(MainView).GetTypeInfo().Assembly));
			val255.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(212, 33)));
			object obj30 = (buttonMainView.Icon = (string)((IMarkupExtension)val73).ProvideValue((IServiceProvider)val255));
			((BindableObject)buttonMainView).SetValue(ButtonMainView.TextProperty, (object)homePage_SymptomCheck);
			val74.set_Path("OpenSymptomCheckCommand");
			BindingBase val258 = ((IMarkupExtension<BindingBase>)(object)val74).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView).SetBinding(ButtonMainView.OnClickCommandProperty, val258);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView);
			val75.set_Key("faVials");
			XamlServiceProvider val259 = new XamlServiceProvider();
			Type typeFromHandle59 = typeof(IProvideValueTarget);
			object[] array31 = new object[0 + 7];
			array31[0] = buttonMainView2;
			array31[1] = val85;
			array31[2] = val122;
			array31[3] = val123;
			array31[4] = val124;
			array31[5] = val125;
			array31[6] = mainView;
			SimpleValueTargetProvider val260 = new SimpleValueTargetProvider(array31, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj31 = (object)val260;
			val259.Add(typeFromHandle59, (object)val260);
			val259.Add(typeof(IReferenceProvider), obj31);
			Type typeFromHandle60 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val261 = new XmlNamespaceResolver();
			val261.Add("", "http://xamarin.com/schemas/2014/forms");
			val261.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val261.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val261.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val261.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val261.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val261.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val261.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val261.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val259.Add(typeFromHandle60, (object)new XamlTypeResolver((IXmlNamespaceResolver)val261, typeof(MainView).GetTypeInfo().Assembly));
			val259.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(219, 33)));
			object obj32 = (buttonMainView2.Icon = (string)((IMarkupExtension)val75).ProvideValue((IServiceProvider)val259));
			((BindableObject)buttonMainView2).SetValue(ButtonMainView.TextProperty, (object)homePage_TestingScheduleAndCalendar);
			val76.set_Path("OpenTestingScheduleCommand");
			BindingBase val262 = ((IMarkupExtension<BindingBase>)(object)val76).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView2).SetBinding(ButtonMainView.OnClickCommandProperty, val262);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView2);
			val77.set_Key("faMapMarkerAlt");
			XamlServiceProvider val263 = new XamlServiceProvider();
			Type typeFromHandle61 = typeof(IProvideValueTarget);
			object[] array32 = new object[0 + 7];
			array32[0] = buttonMainView3;
			array32[1] = val85;
			array32[2] = val122;
			array32[3] = val123;
			array32[4] = val124;
			array32[5] = val125;
			array32[6] = mainView;
			SimpleValueTargetProvider val264 = new SimpleValueTargetProvider(array32, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj33 = (object)val264;
			val263.Add(typeFromHandle61, (object)val264);
			val263.Add(typeof(IReferenceProvider), obj33);
			Type typeFromHandle62 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val265 = new XmlNamespaceResolver();
			val265.Add("", "http://xamarin.com/schemas/2014/forms");
			val265.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val265.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val265.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val265.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val265.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val265.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val265.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val265.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val263.Add(typeFromHandle62, (object)new XamlTypeResolver((IXmlNamespaceResolver)val265, typeof(MainView).GetTypeInfo().Assembly));
			val263.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(226, 33)));
			object obj34 = (buttonMainView3.Icon = (string)((IMarkupExtension)val77).ProvideValue((IServiceProvider)val263));
			((BindableObject)buttonMainView3).SetValue(ButtonMainView.TextProperty, (object)homePage_CheckIn);
			val78.set_Path("CheckInCommand");
			BindingBase val266 = ((IMarkupExtension<BindingBase>)(object)val78).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView3).SetBinding(ButtonMainView.OnClickCommandProperty, val266);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView3);
			val79.set_Key("faHeart");
			XamlServiceProvider val267 = new XamlServiceProvider();
			Type typeFromHandle63 = typeof(IProvideValueTarget);
			object[] array33 = new object[0 + 7];
			array33[0] = buttonMainView4;
			array33[1] = val85;
			array33[2] = val122;
			array33[3] = val123;
			array33[4] = val124;
			array33[5] = val125;
			array33[6] = mainView;
			SimpleValueTargetProvider val268 = new SimpleValueTargetProvider(array33, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj35 = (object)val268;
			val267.Add(typeFromHandle63, (object)val268);
			val267.Add(typeof(IReferenceProvider), obj35);
			Type typeFromHandle64 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val269 = new XmlNamespaceResolver();
			val269.Add("", "http://xamarin.com/schemas/2014/forms");
			val269.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val269.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val269.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val269.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val269.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val269.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val269.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val269.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val267.Add(typeFromHandle64, (object)new XamlTypeResolver((IXmlNamespaceResolver)val269, typeof(MainView).GetTypeInfo().Assembly));
			val267.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(233, 33)));
			object obj36 = (buttonMainView4.Icon = (string)((IMarkupExtension)val79).ProvideValue((IServiceProvider)val267));
			((BindableObject)buttonMainView4).SetValue(ButtonMainView.TextProperty, (object)homePage_SupportResources);
			val80.set_Path("SupportResourcesCommand");
			BindingBase val270 = ((IMarkupExtension<BindingBase>)(object)val80).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView4).SetBinding(ButtonMainView.OnClickCommandProperty, val270);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView4);
			val81.set_Key("faHouseSignal");
			XamlServiceProvider val271 = new XamlServiceProvider();
			Type typeFromHandle65 = typeof(IProvideValueTarget);
			object[] array34 = new object[0 + 7];
			array34[0] = buttonMainView5;
			array34[1] = val85;
			array34[2] = val122;
			array34[3] = val123;
			array34[4] = val124;
			array34[5] = val125;
			array34[6] = mainView;
			SimpleValueTargetProvider val272 = new SimpleValueTargetProvider(array34, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj37 = (object)val272;
			val271.Add(typeFromHandle65, (object)val272);
			val271.Add(typeof(IReferenceProvider), obj37);
			Type typeFromHandle66 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val273 = new XmlNamespaceResolver();
			val273.Add("", "http://xamarin.com/schemas/2014/forms");
			val273.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val273.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val273.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val273.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val273.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val273.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val273.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val273.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val271.Add(typeFromHandle66, (object)new XamlTypeResolver((IXmlNamespaceResolver)val273, typeof(MainView).GetTypeInfo().Assembly));
			val271.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(240, 33)));
			object obj38 = (buttonMainView5.Icon = (string)((IMarkupExtension)val81).ProvideValue((IServiceProvider)val271));
			((BindableObject)buttonMainView5).SetValue(ButtonMainView.TextProperty, (object)homePage_QuarantineGuidelines);
			val82.set_Path("GuidelinesCommand");
			BindingBase val274 = ((IMarkupExtension<BindingBase>)(object)val82).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView5).SetBinding(ButtonMainView.OnClickCommandProperty, val274);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView5);
			val83.set_Key("faQuestion");
			XamlServiceProvider val275 = new XamlServiceProvider();
			Type typeFromHandle67 = typeof(IProvideValueTarget);
			object[] array35 = new object[0 + 7];
			array35[0] = buttonMainView6;
			array35[1] = val85;
			array35[2] = val122;
			array35[3] = val123;
			array35[4] = val124;
			array35[5] = val125;
			array35[6] = mainView;
			SimpleValueTargetProvider val276 = new SimpleValueTargetProvider(array35, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj39 = (object)val276;
			val275.Add(typeFromHandle67, (object)val276);
			val275.Add(typeof(IReferenceProvider), obj39);
			Type typeFromHandle68 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val277 = new XmlNamespaceResolver();
			val277.Add("", "http://xamarin.com/schemas/2014/forms");
			val277.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val277.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val277.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val277.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val277.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val277.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val277.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val277.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val275.Add(typeFromHandle68, (object)new XamlTypeResolver((IXmlNamespaceResolver)val277, typeof(MainView).GetTypeInfo().Assembly));
			val275.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(247, 33)));
			object obj40 = (buttonMainView6.Icon = (string)((IMarkupExtension)val83).ProvideValue((IServiceProvider)val275));
			((BindableObject)buttonMainView6).SetValue(ButtonMainView.TextProperty, (object)homePage_FAQs);
			val84.set_Path("FAQsCommand");
			BindingBase val278 = ((IMarkupExtension<BindingBase>)(object)val84).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView6).SetBinding(ButtonMainView.OnClickCommandProperty, val278);
			((Layout<View>)(object)val85).get_Children().Add((View)(object)buttonMainView6);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)val85);
			((BindableObject)val91).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val91).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			val86.set_Path("IsDebug");
			BindingBase val279 = ((IMarkupExtension<BindingBase>)(object)val86).ProvideValue((IServiceProvider)null);
			((BindableObject)val91).SetBinding(VisualElement.IsVisibleProperty, val279);
			((BindableObject)buttonMainView7).SetValue(ButtonMainView.TextProperty, (object)"Design System");
			val87.set_Key("faDesktop");
			XamlServiceProvider val280 = new XamlServiceProvider();
			Type typeFromHandle69 = typeof(IProvideValueTarget);
			object[] array36 = new object[0 + 7];
			array36[0] = buttonMainView7;
			array36[1] = val91;
			array36[2] = val122;
			array36[3] = val123;
			array36[4] = val124;
			array36[5] = val125;
			array36[6] = mainView;
			SimpleValueTargetProvider val281 = new SimpleValueTargetProvider(array36, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj41 = (object)val281;
			val280.Add(typeFromHandle69, (object)val281);
			val280.Add(typeof(IReferenceProvider), obj41);
			Type typeFromHandle70 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val282 = new XmlNamespaceResolver();
			val282.Add("", "http://xamarin.com/schemas/2014/forms");
			val282.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val282.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val282.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val282.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val282.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val282.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val282.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val282.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val280.Add(typeFromHandle70, (object)new XamlTypeResolver((IXmlNamespaceResolver)val282, typeof(MainView).GetTypeInfo().Assembly));
			val280.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(259, 33)));
			object obj42 = (buttonMainView7.Icon = (string)((IMarkupExtension)val87).ProvideValue((IServiceProvider)val280));
			val88.set_Path("OpenDesignSystemCommmand");
			BindingBase val283 = ((IMarkupExtension<BindingBase>)(object)val88).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView7).SetBinding(ButtonMainView.OnClickCommandProperty, val283);
			((Layout<View>)(object)val91).get_Children().Add((View)(object)buttonMainView7);
			((BindableObject)buttonMainView8).SetValue(ButtonMainView.TextProperty, (object)"Logout");
			val89.set_Key("faSignOutAlt");
			XamlServiceProvider val284 = new XamlServiceProvider();
			Type typeFromHandle71 = typeof(IProvideValueTarget);
			object[] array37 = new object[0 + 7];
			array37[0] = buttonMainView8;
			array37[1] = val91;
			array37[2] = val122;
			array37[3] = val123;
			array37[4] = val124;
			array37[5] = val125;
			array37[6] = mainView;
			SimpleValueTargetProvider val285 = new SimpleValueTargetProvider(array37, (object)ButtonMainView.IconProperty, (INameScope)(object)val126);
			object obj43 = (object)val285;
			val284.Add(typeFromHandle71, (object)val285);
			val284.Add(typeof(IReferenceProvider), obj43);
			Type typeFromHandle72 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val286 = new XmlNamespaceResolver();
			val286.Add("", "http://xamarin.com/schemas/2014/forms");
			val286.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val286.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val286.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val286.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val286.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val286.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val286.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val286.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val284.Add(typeFromHandle72, (object)new XamlTypeResolver((IXmlNamespaceResolver)val286, typeof(MainView).GetTypeInfo().Assembly));
			val284.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(263, 33)));
			object obj44 = (buttonMainView8.Icon = (string)((IMarkupExtension)val89).ProvideValue((IServiceProvider)val284));
			val90.set_Path("LogoutCommand");
			BindingBase val287 = ((IMarkupExtension<BindingBase>)(object)val90).ProvideValue((IServiceProvider)null);
			((BindableObject)buttonMainView8).SetBinding(ButtonMainView.OnClickCommandProperty, val287);
			((Layout<View>)(object)val91).get_Children().Add((View)(object)buttonMainView8);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)val91);
			((BindableObject)val121).SetValue(View.MarginProperty, (object)new Thickness(0.0, 40.0, 0.0, 0.0));
			((BindableObject)val109).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val109).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val109).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val92.set_Key("GrayColor");
			XamlServiceProvider val288 = new XamlServiceProvider();
			Type typeFromHandle73 = typeof(IProvideValueTarget);
			object[] array38 = new object[0 + 7];
			array38[0] = val109;
			array38[1] = val121;
			array38[2] = val122;
			array38[3] = val123;
			array38[4] = val124;
			array38[5] = val125;
			array38[6] = mainView;
			SimpleValueTargetProvider val289 = new SimpleValueTargetProvider(array38, (object)Frame.BorderColorProperty, (INameScope)(object)val126);
			object obj45 = (object)val289;
			val288.Add(typeFromHandle73, (object)val289);
			val288.Add(typeof(IReferenceProvider), obj45);
			Type typeFromHandle74 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val290 = new XmlNamespaceResolver();
			val290.Add("", "http://xamarin.com/schemas/2014/forms");
			val290.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val290.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val290.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val290.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val290.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val290.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val290.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val290.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val288.Add(typeFromHandle74, (object)new XamlTypeResolver((IXmlNamespaceResolver)val290, typeof(MainView).GetTypeInfo().Assembly));
			val288.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(274, 29)));
			DynamicResource val291 = ((IMarkupExtension<DynamicResource>)(object)val92).ProvideValue((IServiceProvider)val288);
			((IDynamicResourceHandler)val109).SetDynamicResource(Frame.BorderColorProperty, val291.get_Key());
			((BindableObject)val109).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val109).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val109).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val93.set_Path("CallHelpCommand");
			BindingBase val292 = ((IMarkupExtension<BindingBase>)(object)val93).ProvideValue((IServiceProvider)null);
			((BindableObject)val94).SetBinding(TapGestureRecognizer.CommandProperty, val292);
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
			XamlServiceProvider val293 = new XamlServiceProvider();
			Type typeFromHandle75 = typeof(IProvideValueTarget);
			object[] array39 = new object[0 + 9];
			array39[0] = val100;
			array39[1] = val108;
			array39[2] = val109;
			array39[3] = val121;
			array39[4] = val122;
			array39[5] = val123;
			array39[6] = val124;
			array39[7] = val125;
			array39[8] = mainView;
			SimpleValueTargetProvider val294 = new SimpleValueTargetProvider(array39, (object)Label.TextProperty, (INameScope)(object)val126);
			object obj46 = (object)val294;
			val293.Add(typeFromHandle75, (object)val294);
			val293.Add(typeof(IReferenceProvider), obj46);
			Type typeFromHandle76 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val295 = new XmlNamespaceResolver();
			val295.Add("", "http://xamarin.com/schemas/2014/forms");
			val295.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val295.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val295.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val295.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val295.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val295.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val295.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val295.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val293.Add(typeFromHandle76, (object)new XamlTypeResolver((IXmlNamespaceResolver)val295, typeof(MainView).GetTypeInfo().Assembly));
			val293.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(287, 37)));
			object text11 = ((IMarkupExtension)val98).ProvideValue((IServiceProvider)val293);
			val100.set_Text((string)text11);
			((BindableObject)val100).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val99.set_Key("Small");
			XamlServiceProvider val296 = new XamlServiceProvider();
			Type typeFromHandle77 = typeof(IProvideValueTarget);
			object[] array40 = new object[0 + 9];
			array40[0] = val100;
			array40[1] = val108;
			array40[2] = val109;
			array40[3] = val121;
			array40[4] = val122;
			array40[5] = val123;
			array40[6] = val124;
			array40[7] = val125;
			array40[8] = mainView;
			SimpleValueTargetProvider val297 = new SimpleValueTargetProvider(array40, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj47 = (object)val297;
			val296.Add(typeFromHandle77, (object)val297);
			val296.Add(typeof(IReferenceProvider), obj47);
			Type typeFromHandle78 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val298 = new XmlNamespaceResolver();
			val298.Add("", "http://xamarin.com/schemas/2014/forms");
			val298.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val298.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val298.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val298.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val298.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val298.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val298.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val298.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val296.Add(typeFromHandle78, (object)new XamlTypeResolver((IXmlNamespaceResolver)val298, typeof(MainView).GetTypeInfo().Assembly));
			val296.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(289, 37)));
			DynamicResource val299 = ((IMarkupExtension<DynamicResource>)(object)val99).ProvideValue((IServiceProvider)val296);
			((IDynamicResourceHandler)val100).SetDynamicResource(VisualElement.StyleProperty, val299.get_Key());
			((BindableObject)val100).SetValue(Label.TextColorProperty, (object)Color.Transparent);
			((BindableObject)val100).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val100).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val108.get_Children()).Add((View)(object)val100);
			((BindableObject)val103).SetValue(Label.TextProperty, (object)homePage_ControlBranch);
			((BindableObject)val103).SetValue(Grid.ColumnProperty, (object)1);
			val101.set_Key("Small");
			XamlServiceProvider val300 = new XamlServiceProvider();
			Type typeFromHandle79 = typeof(IProvideValueTarget);
			object[] array41 = new object[0 + 9];
			array41[0] = val103;
			array41[1] = val108;
			array41[2] = val109;
			array41[3] = val121;
			array41[4] = val122;
			array41[5] = val123;
			array41[6] = val124;
			array41[7] = val125;
			array41[8] = mainView;
			SimpleValueTargetProvider val301 = new SimpleValueTargetProvider(array41, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj48 = (object)val301;
			val300.Add(typeFromHandle79, (object)val301);
			val300.Add(typeof(IReferenceProvider), obj48);
			Type typeFromHandle80 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val302 = new XmlNamespaceResolver();
			val302.Add("", "http://xamarin.com/schemas/2014/forms");
			val302.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val302.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val302.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val302.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val302.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val302.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val302.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val302.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val300.Add(typeFromHandle80, (object)new XamlTypeResolver((IXmlNamespaceResolver)val302, typeof(MainView).GetTypeInfo().Assembly));
			val300.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(296, 37)));
			DynamicResource val303 = ((IMarkupExtension<DynamicResource>)(object)val101).ProvideValue((IServiceProvider)val300);
			((IDynamicResourceHandler)val103).SetDynamicResource(VisualElement.StyleProperty, val303.get_Key());
			((BindableObject)val103).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val102.set_Key("SecondaryColor");
			XamlServiceProvider val304 = new XamlServiceProvider();
			Type typeFromHandle81 = typeof(IProvideValueTarget);
			object[] array42 = new object[0 + 9];
			array42[0] = val103;
			array42[1] = val108;
			array42[2] = val109;
			array42[3] = val121;
			array42[4] = val122;
			array42[5] = val123;
			array42[6] = val124;
			array42[7] = val125;
			array42[8] = mainView;
			SimpleValueTargetProvider val305 = new SimpleValueTargetProvider(array42, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj49 = (object)val305;
			val304.Add(typeFromHandle81, (object)val305);
			val304.Add(typeof(IReferenceProvider), obj49);
			Type typeFromHandle82 = typeof(IXamlTypeResolver);
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
			val304.Add(typeFromHandle82, (object)new XamlTypeResolver((IXmlNamespaceResolver)val306, typeof(MainView).GetTypeInfo().Assembly));
			val304.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(298, 37)));
			DynamicResource val307 = ((IMarkupExtension<DynamicResource>)(object)val102).ProvideValue((IServiceProvider)val304);
			((IDynamicResourceHandler)val103).SetDynamicResource(Label.TextColorProperty, val307.get_Key());
			((BindableObject)val103).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((ICollection<View>)val108.get_Children()).Add((View)(object)val103);
			val104.set_Key("faPhone");
			XamlServiceProvider val308 = new XamlServiceProvider();
			Type typeFromHandle83 = typeof(IProvideValueTarget);
			object[] array43 = new object[0 + 9];
			array43[0] = val107;
			array43[1] = val108;
			array43[2] = val109;
			array43[3] = val121;
			array43[4] = val122;
			array43[5] = val123;
			array43[6] = val124;
			array43[7] = val125;
			array43[8] = mainView;
			SimpleValueTargetProvider val309 = new SimpleValueTargetProvider(array43, (object)Label.TextProperty, (INameScope)(object)val126);
			object obj50 = (object)val309;
			val308.Add(typeFromHandle83, (object)val309);
			val308.Add(typeof(IReferenceProvider), obj50);
			Type typeFromHandle84 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val310 = new XmlNamespaceResolver();
			val310.Add("", "http://xamarin.com/schemas/2014/forms");
			val310.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val310.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val310.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val310.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val310.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val310.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val310.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val310.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val308.Add(typeFromHandle84, (object)new XamlTypeResolver((IXmlNamespaceResolver)val310, typeof(MainView).GetTypeInfo().Assembly));
			val308.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(302, 37)));
			object text12 = ((IMarkupExtension)val104).ProvideValue((IServiceProvider)val308);
			val107.set_Text((string)text12);
			((BindableObject)val107).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val105.set_Key("Small");
			XamlServiceProvider val311 = new XamlServiceProvider();
			Type typeFromHandle85 = typeof(IProvideValueTarget);
			object[] array44 = new object[0 + 9];
			array44[0] = val107;
			array44[1] = val108;
			array44[2] = val109;
			array44[3] = val121;
			array44[4] = val122;
			array44[5] = val123;
			array44[6] = val124;
			array44[7] = val125;
			array44[8] = mainView;
			SimpleValueTargetProvider val312 = new SimpleValueTargetProvider(array44, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj51 = (object)val312;
			val311.Add(typeFromHandle85, (object)val312);
			val311.Add(typeof(IReferenceProvider), obj51);
			Type typeFromHandle86 = typeof(IXamlTypeResolver);
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
			val311.Add(typeFromHandle86, (object)new XamlTypeResolver((IXmlNamespaceResolver)val313, typeof(MainView).GetTypeInfo().Assembly));
			val311.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(304, 37)));
			DynamicResource val314 = ((IMarkupExtension<DynamicResource>)(object)val105).ProvideValue((IServiceProvider)val311);
			((IDynamicResourceHandler)val107).SetDynamicResource(VisualElement.StyleProperty, val314.get_Key());
			val106.set_Key("SecondaryColor");
			XamlServiceProvider val315 = new XamlServiceProvider();
			Type typeFromHandle87 = typeof(IProvideValueTarget);
			object[] array45 = new object[0 + 9];
			array45[0] = val107;
			array45[1] = val108;
			array45[2] = val109;
			array45[3] = val121;
			array45[4] = val122;
			array45[5] = val123;
			array45[6] = val124;
			array45[7] = val125;
			array45[8] = mainView;
			SimpleValueTargetProvider val316 = new SimpleValueTargetProvider(array45, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj52 = (object)val316;
			val315.Add(typeFromHandle87, (object)val316);
			val315.Add(typeof(IReferenceProvider), obj52);
			Type typeFromHandle88 = typeof(IXamlTypeResolver);
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
			val315.Add(typeFromHandle88, (object)new XamlTypeResolver((IXmlNamespaceResolver)val317, typeof(MainView).GetTypeInfo().Assembly));
			val315.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(305, 37)));
			DynamicResource val318 = ((IMarkupExtension<DynamicResource>)(object)val106).ProvideValue((IServiceProvider)val315);
			((IDynamicResourceHandler)val107).SetDynamicResource(Label.TextColorProperty, val318.get_Key());
			((BindableObject)val107).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val107).SetValue(Grid.ColumnProperty, (object)2);
			((BindableObject)val107).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val108.get_Children()).Add((View)(object)val107);
			((BindableObject)val109).SetValue(ContentView.ContentProperty, (object)val108);
			((Layout<View>)(object)val121).get_Children().Add((View)(object)val109);
			((BindableObject)val116).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val116).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val116).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val110.set_Key("GrayColor");
			XamlServiceProvider val319 = new XamlServiceProvider();
			Type typeFromHandle89 = typeof(IProvideValueTarget);
			object[] array46 = new object[0 + 7];
			array46[0] = val116;
			array46[1] = val121;
			array46[2] = val122;
			array46[3] = val123;
			array46[4] = val124;
			array46[5] = val125;
			array46[6] = mainView;
			SimpleValueTargetProvider val320 = new SimpleValueTargetProvider(array46, (object)Frame.BorderColorProperty, (INameScope)(object)val126);
			object obj53 = (object)val320;
			val319.Add(typeFromHandle89, (object)val320);
			val319.Add(typeof(IReferenceProvider), obj53);
			Type typeFromHandle90 = typeof(IXamlTypeResolver);
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
			val319.Add(typeFromHandle90, (object)new XamlTypeResolver((IXmlNamespaceResolver)val321, typeof(MainView).GetTypeInfo().Assembly));
			val319.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(318, 29)));
			DynamicResource val322 = ((IMarkupExtension<DynamicResource>)(object)val110).ProvideValue((IServiceProvider)val319);
			((IDynamicResourceHandler)val116).SetDynamicResource(Frame.BorderColorProperty, val322.get_Key());
			((BindableObject)val116).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val116).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val116).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val111.set_Path("PrivacyPolicyCommand");
			BindingBase val323 = ((IMarkupExtension<BindingBase>)(object)val111).ProvideValue((IServiceProvider)null);
			((BindableObject)val112).SetBinding(TapGestureRecognizer.CommandProperty, val323);
			((View)val116).get_GestureRecognizers().Add((IGestureRecognizer)(object)val112);
			((BindableObject)val115).SetValue(Label.TextProperty, (object)homePage_ControlBranchPrivacy);
			val113.set_Key("SecondaryColor");
			XamlServiceProvider val324 = new XamlServiceProvider();
			Type typeFromHandle91 = typeof(IProvideValueTarget);
			object[] array47 = new object[0 + 8];
			array47[0] = val115;
			array47[1] = val116;
			array47[2] = val121;
			array47[3] = val122;
			array47[4] = val123;
			array47[5] = val124;
			array47[6] = val125;
			array47[7] = mainView;
			SimpleValueTargetProvider val325 = new SimpleValueTargetProvider(array47, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj54 = (object)val325;
			val324.Add(typeFromHandle91, (object)val325);
			val324.Add(typeof(IReferenceProvider), obj54);
			Type typeFromHandle92 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val326 = new XmlNamespaceResolver();
			val326.Add("", "http://xamarin.com/schemas/2014/forms");
			val326.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val326.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val326.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val326.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val326.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val326.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val326.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val326.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val324.Add(typeFromHandle92, (object)new XamlTypeResolver((IXmlNamespaceResolver)val326, typeof(MainView).GetTypeInfo().Assembly));
			val324.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(324, 33)));
			DynamicResource val327 = ((IMarkupExtension<DynamicResource>)(object)val113).ProvideValue((IServiceProvider)val324);
			((IDynamicResourceHandler)val115).SetDynamicResource(Label.TextColorProperty, val327.get_Key());
			val114.set_Key("Small");
			XamlServiceProvider val328 = new XamlServiceProvider();
			Type typeFromHandle93 = typeof(IProvideValueTarget);
			object[] array48 = new object[0 + 8];
			array48[0] = val115;
			array48[1] = val116;
			array48[2] = val121;
			array48[3] = val122;
			array48[4] = val123;
			array48[5] = val124;
			array48[6] = val125;
			array48[7] = mainView;
			SimpleValueTargetProvider val329 = new SimpleValueTargetProvider(array48, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj55 = (object)val329;
			val328.Add(typeFromHandle93, (object)val329);
			val328.Add(typeof(IReferenceProvider), obj55);
			Type typeFromHandle94 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val330 = new XmlNamespaceResolver();
			val330.Add("", "http://xamarin.com/schemas/2014/forms");
			val330.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val330.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val330.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val330.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val330.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val330.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val330.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val330.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val328.Add(typeFromHandle94, (object)new XamlTypeResolver((IXmlNamespaceResolver)val330, typeof(MainView).GetTypeInfo().Assembly));
			val328.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(325, 33)));
			DynamicResource val331 = ((IMarkupExtension<DynamicResource>)(object)val114).ProvideValue((IServiceProvider)val328);
			((IDynamicResourceHandler)val115).SetDynamicResource(VisualElement.StyleProperty, val331.get_Key());
			((BindableObject)val115).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val115).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val116).SetValue(ContentView.ContentProperty, (object)val115);
			((Layout<View>)(object)val121).get_Children().Add((View)(object)val116);
			val117.set_Path("VersionNumber");
			BindingBase val332 = ((IMarkupExtension<BindingBase>)(object)val117).ProvideValue((IServiceProvider)null);
			((BindableObject)val120).SetBinding(Label.TextProperty, val332);
			val118.set_Key("TertiaryTextColor");
			XamlServiceProvider val333 = new XamlServiceProvider();
			Type typeFromHandle95 = typeof(IProvideValueTarget);
			object[] array49 = new object[0 + 7];
			array49[0] = val120;
			array49[1] = val121;
			array49[2] = val122;
			array49[3] = val123;
			array49[4] = val124;
			array49[5] = val125;
			array49[6] = mainView;
			SimpleValueTargetProvider val334 = new SimpleValueTargetProvider(array49, (object)Label.TextColorProperty, (INameScope)(object)val126);
			object obj56 = (object)val334;
			val333.Add(typeFromHandle95, (object)val334);
			val333.Add(typeof(IReferenceProvider), obj56);
			Type typeFromHandle96 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val335 = new XmlNamespaceResolver();
			val335.Add("", "http://xamarin.com/schemas/2014/forms");
			val335.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val335.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val335.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val335.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val335.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val335.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val335.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val335.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val333.Add(typeFromHandle96, (object)new XamlTypeResolver((IXmlNamespaceResolver)val335, typeof(MainView).GetTypeInfo().Assembly));
			val333.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(335, 29)));
			DynamicResource val336 = ((IMarkupExtension<DynamicResource>)(object)val118).ProvideValue((IServiceProvider)val333);
			((IDynamicResourceHandler)val120).SetDynamicResource(Label.TextColorProperty, val336.get_Key());
			val119.set_Key("Small");
			XamlServiceProvider val337 = new XamlServiceProvider();
			Type typeFromHandle97 = typeof(IProvideValueTarget);
			object[] array50 = new object[0 + 7];
			array50[0] = val120;
			array50[1] = val121;
			array50[2] = val122;
			array50[3] = val123;
			array50[4] = val124;
			array50[5] = val125;
			array50[6] = mainView;
			SimpleValueTargetProvider val338 = new SimpleValueTargetProvider(array50, (object)VisualElement.StyleProperty, (INameScope)(object)val126);
			object obj57 = (object)val338;
			val337.Add(typeFromHandle97, (object)val338);
			val337.Add(typeof(IReferenceProvider), obj57);
			Type typeFromHandle98 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val339 = new XmlNamespaceResolver();
			val339.Add("", "http://xamarin.com/schemas/2014/forms");
			val339.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val339.Add("vm", "clr-namespace:HomeQuarantine.ViewModels");
			val339.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val339.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val339.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val339.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val339.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val339.Add("sk", "clr-namespace:Xamarin.Forms.Skeleton;assembly=Xamarin.Forms.Skeleton");
			val337.Add(typeFromHandle98, (object)new XamlTypeResolver((IXmlNamespaceResolver)val339, typeof(MainView).GetTypeInfo().Assembly));
			val337.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(336, 29)));
			DynamicResource val340 = ((IMarkupExtension<DynamicResource>)(object)val119).ProvideValue((IServiceProvider)val337);
			((IDynamicResourceHandler)val120).SetDynamicResource(VisualElement.StyleProperty, val340.get_Key());
			((BindableObject)val120).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val120).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val120).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val121).get_Children().Add((View)(object)val120);
			((Layout<View>)(object)val122).get_Children().Add((View)(object)val121);
			((Layout<View>)(object)val123).get_Children().Add((View)(object)val122);
			val124.set_Content((View)(object)val123);
			((BindableObject)val125).SetValue(ContentView.ContentProperty, (object)val124);
			((BindableObject)mainView).SetValue(ContentPage.ContentProperty, (object)val125);
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
