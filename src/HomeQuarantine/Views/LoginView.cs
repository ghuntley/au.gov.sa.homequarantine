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
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/LoginView.xaml")]
	public class LoginView : BaseView, IMainView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ScrollView scrollView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Entry mockUsernameEntry;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label versionNumberLabel;

		public LoginView()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			LoginViewModel loginViewModel = ((BindableObject)this).get_BindingContext() as LoginViewModel;
			if (loginViewModel.CheckAuthCommand.CanExecute(null))
			{
				loginViewModel.CheckAuthCommand.Execute(null);
			}
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
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
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
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
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
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got Unknown
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
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected O, but got Unknown
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected O, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected O, but got Unknown
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
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Unknown result type (might be due to invalid IL or missing references)
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Expected O, but got Unknown
			//IL_0524: Expected O, but got Unknown
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected O, but got Unknown
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Expected O, but got Unknown
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Expected O, but got Unknown
			//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Expected O, but got Unknown
			//IL_0607: Expected O, but got Unknown
			//IL_0644: Unknown result type (might be due to invalid IL or missing references)
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_0681: Unknown result type (might be due to invalid IL or missing references)
			//IL_0686: Unknown result type (might be due to invalid IL or missing references)
			//IL_0689: Expected O, but got Unknown
			//IL_068e: Expected O, but got Unknown
			//IL_068e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0720: Unknown result type (might be due to invalid IL or missing references)
			//IL_0749: Expected O, but got Unknown
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected O, but got Unknown
			//IL_074e: Unknown result type (might be due to invalid IL or missing references)
			//IL_075d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0767: Expected O, but got Unknown
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_076c: Expected O, but got Unknown
			//IL_0771: Expected O, but got Unknown
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_080e: Unknown result type (might be due to invalid IL or missing references)
			//IL_082d: Unknown result type (might be due to invalid IL or missing references)
			//IL_084a: Unknown result type (might be due to invalid IL or missing references)
			//IL_084f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_088c: Unknown result type (might be due to invalid IL or missing references)
			//IL_088f: Expected O, but got Unknown
			//IL_0894: Expected O, but got Unknown
			//IL_0894: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0906: Unknown result type (might be due to invalid IL or missing references)
			//IL_0916: Unknown result type (might be due to invalid IL or missing references)
			//IL_0926: Unknown result type (might be due to invalid IL or missing references)
			//IL_094f: Expected O, but got Unknown
			//IL_094a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0954: Expected O, but got Unknown
			//IL_0954: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Expected O, but got Unknown
			//IL_0968: Unknown result type (might be due to invalid IL or missing references)
			//IL_0972: Expected O, but got Unknown
			//IL_0977: Expected O, but got Unknown
			//IL_099a: Unknown result type (might be due to invalid IL or missing references)
			//IL_099f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e9: Expected O, but got Unknown
			//IL_09ee: Expected O, but got Unknown
			//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa9: Expected O, but got Unknown
			//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aae: Expected O, but got Unknown
			//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac7: Expected O, but got Unknown
			//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acc: Expected O, but got Unknown
			//IL_0ad1: Expected O, but got Unknown
			//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd3: Expected O, but got Unknown
			//IL_0bd8: Expected O, but got Unknown
			//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c93: Expected O, but got Unknown
			//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c98: Expected O, but got Unknown
			//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb1: Expected O, but got Unknown
			//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb6: Expected O, but got Unknown
			//IL_0cbb: Expected O, but got Unknown
			//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e91: Expected O, but got Unknown
			//IL_0e96: Expected O, but got Unknown
			//IL_0e96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f51: Expected O, but got Unknown
			//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f56: Expected O, but got Unknown
			//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6f: Expected O, but got Unknown
			//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f74: Expected O, but got Unknown
			//IL_0f79: Expected O, but got Unknown
			//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff1: Expected O, but got Unknown
			//IL_0ff6: Expected O, but got Unknown
			//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1008: Unknown result type (might be due to invalid IL or missing references)
			//IL_1013: Unknown result type (might be due to invalid IL or missing references)
			//IL_1018: Unknown result type (might be due to invalid IL or missing references)
			//IL_1028: Unknown result type (might be due to invalid IL or missing references)
			//IL_1038: Unknown result type (might be due to invalid IL or missing references)
			//IL_1048: Unknown result type (might be due to invalid IL or missing references)
			//IL_1058: Unknown result type (might be due to invalid IL or missing references)
			//IL_1068: Unknown result type (might be due to invalid IL or missing references)
			//IL_1078: Unknown result type (might be due to invalid IL or missing references)
			//IL_1088: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b1: Expected O, but got Unknown
			//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b6: Expected O, but got Unknown
			//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cf: Expected O, but got Unknown
			//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d4: Expected O, but got Unknown
			//IL_10d9: Expected O, but got Unknown
			//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_111d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1157: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_121c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1221: Unknown result type (might be due to invalid IL or missing references)
			//IL_1268: Unknown result type (might be due to invalid IL or missing references)
			//IL_126d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1270: Expected O, but got Unknown
			//IL_1275: Expected O, but got Unknown
			//IL_1275: Unknown result type (might be due to invalid IL or missing references)
			//IL_1287: Unknown result type (might be due to invalid IL or missing references)
			//IL_1292: Unknown result type (might be due to invalid IL or missing references)
			//IL_1297: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1307: Unknown result type (might be due to invalid IL or missing references)
			//IL_1330: Expected O, but got Unknown
			//IL_132b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1335: Expected O, but got Unknown
			//IL_1335: Unknown result type (might be due to invalid IL or missing references)
			//IL_1344: Unknown result type (might be due to invalid IL or missing references)
			//IL_134e: Expected O, but got Unknown
			//IL_1349: Unknown result type (might be due to invalid IL or missing references)
			//IL_1353: Expected O, but got Unknown
			//IL_1358: Expected O, but got Unknown
			//IL_138e: Unknown result type (might be due to invalid IL or missing references)
			//IL_13c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1406: Unknown result type (might be due to invalid IL or missing references)
			//IL_141c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1432: Unknown result type (might be due to invalid IL or missing references)
			//IL_144f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1454: Unknown result type (might be due to invalid IL or missing references)
			//IL_148c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1491: Unknown result type (might be due to invalid IL or missing references)
			//IL_1494: Expected O, but got Unknown
			//IL_1499: Expected O, but got Unknown
			//IL_1499: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_14cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_14db: Unknown result type (might be due to invalid IL or missing references)
			//IL_14eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_150b: Unknown result type (might be due to invalid IL or missing references)
			//IL_151b: Unknown result type (might be due to invalid IL or missing references)
			//IL_152b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1554: Expected O, but got Unknown
			//IL_154f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1559: Expected O, but got Unknown
			//IL_1559: Unknown result type (might be due to invalid IL or missing references)
			//IL_1568: Unknown result type (might be due to invalid IL or missing references)
			//IL_1572: Expected O, but got Unknown
			//IL_156d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1577: Expected O, but got Unknown
			//IL_157c: Expected O, but got Unknown
			//IL_15bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_164f: Unknown result type (might be due to invalid IL or missing references)
			//IL_167d: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1739: Unknown result type (might be due to invalid IL or missing references)
			//IL_173e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1741: Expected O, but got Unknown
			//IL_1746: Expected O, but got Unknown
			//IL_1746: Unknown result type (might be due to invalid IL or missing references)
			//IL_1758: Unknown result type (might be due to invalid IL or missing references)
			//IL_1763: Unknown result type (might be due to invalid IL or missing references)
			//IL_1768: Unknown result type (might be due to invalid IL or missing references)
			//IL_1778: Unknown result type (might be due to invalid IL or missing references)
			//IL_1788: Unknown result type (might be due to invalid IL or missing references)
			//IL_1798: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1801: Expected O, but got Unknown
			//IL_17fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1806: Expected O, but got Unknown
			//IL_1806: Unknown result type (might be due to invalid IL or missing references)
			//IL_1818: Unknown result type (might be due to invalid IL or missing references)
			//IL_1822: Expected O, but got Unknown
			//IL_181d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1827: Expected O, but got Unknown
			//IL_182c: Expected O, but got Unknown
			//IL_183e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1860: Unknown result type (might be due to invalid IL or missing references)
			//IL_1865: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_18af: Expected O, but got Unknown
			//IL_18b4: Expected O, but got Unknown
			//IL_18b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1906: Unknown result type (might be due to invalid IL or missing references)
			//IL_1916: Unknown result type (might be due to invalid IL or missing references)
			//IL_1926: Unknown result type (might be due to invalid IL or missing references)
			//IL_1936: Unknown result type (might be due to invalid IL or missing references)
			//IL_1946: Unknown result type (might be due to invalid IL or missing references)
			//IL_196f: Expected O, but got Unknown
			//IL_196a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1974: Expected O, but got Unknown
			//IL_1974: Unknown result type (might be due to invalid IL or missing references)
			//IL_1986: Unknown result type (might be due to invalid IL or missing references)
			//IL_1990: Expected O, but got Unknown
			//IL_198b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1995: Expected O, but got Unknown
			//IL_199a: Expected O, but got Unknown
			//IL_19b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_19cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a32: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a7c: Expected O, but got Unknown
			//IL_1a81: Expected O, but got Unknown
			//IL_1a81: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a93: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ae3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b03: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b3c: Expected O, but got Unknown
			//IL_1b37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b41: Expected O, but got Unknown
			//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b5d: Expected O, but got Unknown
			//IL_1b58: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b62: Expected O, but got Unknown
			//IL_1b67: Expected O, but got Unknown
			//IL_1b83: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bec: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf4: Expected O, but got Unknown
			//IL_1bf9: Expected O, but got Unknown
			//IL_1bf9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c16: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_1ccb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd5: Expected O, but got Unknown
			//IL_1cd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cda: Expected O, but got Unknown
			//IL_1cdf: Expected O, but got Unknown
			//IL_1cfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d26: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d72: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d75: Expected O, but got Unknown
			//IL_1d7a: Expected O, but got Unknown
			//IL_1d7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d97: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dac: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dcc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ddc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dec: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e35: Expected O, but got Unknown
			//IL_1e30: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e3a: Expected O, but got Unknown
			//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e56: Expected O, but got Unknown
			//IL_1e51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e5b: Expected O, but got Unknown
			//IL_1e60: Expected O, but got Unknown
			//IL_1e72: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e94: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e99: Unknown result type (might be due to invalid IL or missing references)
			//IL_1edb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ee0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ee3: Expected O, but got Unknown
			//IL_1ee8: Expected O, but got Unknown
			//IL_1ee8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1efa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f05: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa3: Expected O, but got Unknown
			//IL_1f9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa8: Expected O, but got Unknown
			//IL_1fa8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fc4: Expected O, but got Unknown
			//IL_1fbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fc9: Expected O, but got Unknown
			//IL_1fce: Expected O, but got Unknown
			//IL_1ff1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2038: Unknown result type (might be due to invalid IL or missing references)
			//IL_203d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2040: Expected O, but got Unknown
			//IL_2045: Expected O, but got Unknown
			//IL_2045: Unknown result type (might be due to invalid IL or missing references)
			//IL_2057: Unknown result type (might be due to invalid IL or missing references)
			//IL_2062: Unknown result type (might be due to invalid IL or missing references)
			//IL_2067: Unknown result type (might be due to invalid IL or missing references)
			//IL_2077: Unknown result type (might be due to invalid IL or missing references)
			//IL_2087: Unknown result type (might be due to invalid IL or missing references)
			//IL_2097: Unknown result type (might be due to invalid IL or missing references)
			//IL_20a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2100: Expected O, but got Unknown
			//IL_20fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2105: Expected O, but got Unknown
			//IL_2105: Unknown result type (might be due to invalid IL or missing references)
			//IL_2117: Unknown result type (might be due to invalid IL or missing references)
			//IL_2121: Expected O, but got Unknown
			//IL_211c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2126: Expected O, but got Unknown
			//IL_212b: Expected O, but got Unknown
			//IL_2147: Unknown result type (might be due to invalid IL or missing references)
			//IL_21da: Unknown result type (might be due to invalid IL or missing references)
			//IL_21df: Unknown result type (might be due to invalid IL or missing references)
			//IL_2217: Unknown result type (might be due to invalid IL or missing references)
			//IL_221c: Unknown result type (might be due to invalid IL or missing references)
			//IL_221f: Expected O, but got Unknown
			//IL_2224: Expected O, but got Unknown
			//IL_2224: Unknown result type (might be due to invalid IL or missing references)
			//IL_2236: Unknown result type (might be due to invalid IL or missing references)
			//IL_2241: Unknown result type (might be due to invalid IL or missing references)
			//IL_2246: Unknown result type (might be due to invalid IL or missing references)
			//IL_2256: Unknown result type (might be due to invalid IL or missing references)
			//IL_2266: Unknown result type (might be due to invalid IL or missing references)
			//IL_2276: Unknown result type (might be due to invalid IL or missing references)
			//IL_2286: Unknown result type (might be due to invalid IL or missing references)
			//IL_2296: Unknown result type (might be due to invalid IL or missing references)
			//IL_22a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_22b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_22df: Expected O, but got Unknown
			//IL_22da: Unknown result type (might be due to invalid IL or missing references)
			//IL_22e4: Expected O, but got Unknown
			//IL_22e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2300: Expected O, but got Unknown
			//IL_22fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2305: Expected O, but got Unknown
			//IL_230a: Expected O, but got Unknown
			//IL_232d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2332: Unknown result type (might be due to invalid IL or missing references)
			//IL_236a: Unknown result type (might be due to invalid IL or missing references)
			//IL_236f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2372: Expected O, but got Unknown
			//IL_2377: Expected O, but got Unknown
			//IL_2377: Unknown result type (might be due to invalid IL or missing references)
			//IL_2389: Unknown result type (might be due to invalid IL or missing references)
			//IL_2394: Unknown result type (might be due to invalid IL or missing references)
			//IL_2399: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_23c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_23d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_23f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2409: Unknown result type (might be due to invalid IL or missing references)
			//IL_2432: Expected O, but got Unknown
			//IL_242d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2437: Expected O, but got Unknown
			//IL_2437: Unknown result type (might be due to invalid IL or missing references)
			//IL_2449: Unknown result type (might be due to invalid IL or missing references)
			//IL_2453: Expected O, but got Unknown
			//IL_244e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2458: Expected O, but got Unknown
			//IL_245d: Expected O, but got Unknown
			//IL_2479: Unknown result type (might be due to invalid IL or missing references)
			//IL_2494: Unknown result type (might be due to invalid IL or missing references)
			//IL_24ce: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(LoginView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/LoginView.xaml");
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
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			BindingExtension val2 = new BindingExtension();
			BindingExtension val3 = new BindingExtension();
			ActivityIndicator val4 = new ActivityIndicator();
			StackLayout val5 = new StackLayout();
			StaticResourceExtension val6 = new StaticResourceExtension();
			BindingExtension val7 = new BindingExtension();
			DynamicResourceExtension val8 = new DynamicResourceExtension();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			DynamicResourceExtension val10 = new DynamicResourceExtension();
			BoxView val11 = new BoxView();
			string loginView_ContentTitle = Resources.LoginView_ContentTitle;
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			Label val13 = new Label();
			string loginView_ContentDescription = Resources.LoginView_ContentDescription1;
			Span val14 = new Span();
			string loginView_ContentDescription2 = Resources.LoginView_ContentDescription2;
			Span val15 = new Span();
			FormattedString val16 = new FormattedString();
			Label val17 = new Label();
			BindingExtension val18 = new BindingExtension();
			Label val19 = new Label();
			string text = "LoginView_MockUsernameEntry";
			BindingExtension val20 = new BindingExtension();
			Entry val21 = new Entry();
			StackLayout val22 = new StackLayout();
			string loginView_LogInButton = Resources.LoginView_LogInButton;
			DynamicResourceExtension val23 = new DynamicResourceExtension();
			DynamicResourceExtension val24 = new DynamicResourceExtension();
			string text2 = "LoginView_SignIn";
			BindingExtension val25 = new BindingExtension();
			Button val26 = new Button();
			StackLayout val27 = new StackLayout();
			StackLayout val28 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val29 = new StackLayout();
			StaticResourceExtension val30 = new StaticResourceExtension();
			BindingExtension val31 = new BindingExtension();
			TintedCachedImage tintedCachedImage2 = new TintedCachedImage();
			DynamicResourceExtension val32 = new DynamicResourceExtension();
			BindingExtension val33 = new BindingExtension();
			TapGestureRecognizer val34 = new TapGestureRecognizer();
			ColumnDefinition val35 = new ColumnDefinition();
			ColumnDefinition val36 = new ColumnDefinition();
			ColumnDefinition val37 = new ColumnDefinition();
			StaticResourceExtension val38 = new StaticResourceExtension();
			DynamicResourceExtension val39 = new DynamicResourceExtension();
			Label val40 = new Label();
			string homePage_ControlBranchPrivacy = Resources.HomePage_ControlBranchPrivacy;
			DynamicResourceExtension val41 = new DynamicResourceExtension();
			DynamicResourceExtension val42 = new DynamicResourceExtension();
			Label val43 = new Label();
			StaticResourceExtension val44 = new StaticResourceExtension();
			DynamicResourceExtension val45 = new DynamicResourceExtension();
			DynamicResourceExtension val46 = new DynamicResourceExtension();
			Label val47 = new Label();
			Grid val48 = new Grid();
			Frame val49 = new Frame();
			BindingExtension val50 = new BindingExtension();
			DynamicResourceExtension val51 = new DynamicResourceExtension();
			DynamicResourceExtension val52 = new DynamicResourceExtension();
			Label val53 = new Label();
			StackLayout val54 = new StackLayout();
			StackLayout val55 = new StackLayout();
			ScrollView val56 = new ScrollView();
			StackLayout val57 = new StackLayout();
			LoginView loginView;
			NameScope val58 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(loginView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)loginView, (INameScope)(object)val58);
			((INameScope)val58).RegisterName("scrollView", (object)val56);
			if (((Element)val56).get_StyleId() == null)
			{
				((Element)val56).set_StyleId("scrollView");
			}
			((INameScope)val58).RegisterName("containingView", (object)val55);
			if (((Element)val55).get_StyleId() == null)
			{
				((Element)val55).set_StyleId("containingView");
			}
			((INameScope)val58).RegisterName("mockUsernameEntry", (object)val21);
			if (((Element)val21).get_StyleId() == null)
			{
				((Element)val21).set_StyleId("mockUsernameEntry");
			}
			((INameScope)val58).RegisterName("versionNumberLabel", (object)val53);
			if (((Element)val53).get_StyleId() == null)
			{
				((Element)val53).set_StyleId("versionNumberLabel");
			}
			scrollView = val56;
			containingView = val55;
			mockUsernameEntry = val21;
			versionNumberLabel = val53;
			((BindableObject)loginView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((VisualElement)loginView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val57).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val56).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val56).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)val55).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val55).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val55).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			val2.set_Path("IsBusy");
			BindingBase val59 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)val5).SetBinding(VisualElement.IsVisibleProperty, val59);
			((BindableObject)val5).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)val4).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val4).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			val3.set_Path("IsBusy");
			BindingBase val60 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(ActivityIndicator.IsRunningProperty, val60);
			((Layout<View>)(object)val5).get_Children().Add((View)(object)val4);
			((Layout<View>)(object)val55).get_Children().Add((View)(object)val5);
			((BindableObject)val29).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val29).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 24.0));
			val6.set_Key("InverseBoolConverter");
			XamlServiceProvider val61 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 6];
			array[0] = val7;
			array[1] = val29;
			array[2] = val55;
			array[3] = val56;
			array[4] = val57;
			array[5] = loginView;
			SimpleValueTargetProvider val62 = new SimpleValueTargetProvider(array, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val58);
			object obj = (object)val62;
			val61.Add(typeFromHandle, (object)val62);
			val61.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val63 = new XmlNamespaceResolver();
			val63.Add("", "http://xamarin.com/schemas/2014/forms");
			val63.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val63.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val63.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val63.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val63.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val63.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val63.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val61.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val63, typeof(LoginView).GetTypeInfo().Assembly));
			val61.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 21)));
			object converter = ((IMarkupExtension)val6).ProvideValue((IServiceProvider)val61);
			val7.set_Converter((IValueConverter)converter);
			val7.set_Path("IsBusy");
			BindingBase val64 = ((IMarkupExtension<BindingBase>)(object)val7).ProvideValue((IServiceProvider)null);
			((BindableObject)val29).SetBinding(VisualElement.IsVisibleProperty, val64);
			val8.set_Key("AppLogo");
			XamlServiceProvider val65 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 6];
			array2[0] = tintedCachedImage;
			array2[1] = val29;
			array2[2] = val55;
			array2[3] = val56;
			array2[4] = val57;
			array2[5] = loginView;
			SimpleValueTargetProvider val66 = new SimpleValueTargetProvider(array2, (object)CachedImage.SourceProperty, (INameScope)(object)val58);
			object obj2 = (object)val66;
			val65.Add(typeFromHandle3, (object)val66);
			val65.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val67 = new XmlNamespaceResolver();
			val67.Add("", "http://xamarin.com/schemas/2014/forms");
			val67.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val67.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val67.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val67.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val67.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val67.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val67.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val65.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val67, typeof(LoginView).GetTypeInfo().Assembly));
			val65.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 25)));
			DynamicResource val68 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val65);
			((IDynamicResourceHandler)tintedCachedImage).SetDynamicResource(CachedImage.SourceProperty, val68.get_Key());
			((BindableObject)tintedCachedImage).SetValue(VisualElement.HeightRequestProperty, (object)50.0);
			((BindableObject)tintedCachedImage).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 24.0));
			((Layout<View>)(object)val29).get_Children().Add((View)(object)tintedCachedImage);
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			val9.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val69 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 6];
			array3[0] = shadowFrame;
			array3[1] = val29;
			array3[2] = val55;
			array3[3] = val56;
			array3[4] = val57;
			array3[5] = loginView;
			SimpleValueTargetProvider val70 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val58);
			object obj3 = (object)val70;
			val69.Add(typeFromHandle5, (object)val70);
			val69.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val71 = new XmlNamespaceResolver();
			val71.Add("", "http://xamarin.com/schemas/2014/forms");
			val71.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val71.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val71.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val71.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val71.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val71.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val71.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val69.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val71, typeof(LoginView).GetTypeInfo().Assembly));
			val69.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 25)));
			DynamicResource val72 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val69);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val72.get_Key());
			val10.set_Key("QuinaryColor");
			XamlServiceProvider val73 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val11;
			array4[1] = val28;
			array4[2] = shadowFrame;
			array4[3] = val29;
			array4[4] = val55;
			array4[5] = val56;
			array4[6] = val57;
			array4[7] = loginView;
			SimpleValueTargetProvider val74 = new SimpleValueTargetProvider(array4, (object)BoxView.ColorProperty, (INameScope)(object)val58);
			object obj4 = (object)val74;
			val73.Add(typeFromHandle7, (object)val74);
			val73.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val75 = new XmlNamespaceResolver();
			val75.Add("", "http://xamarin.com/schemas/2014/forms");
			val75.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val75.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val75.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val75.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val75.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val75.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val75.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val73.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val75, typeof(LoginView).GetTypeInfo().Assembly));
			val73.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 38)));
			DynamicResource val76 = ((IMarkupExtension<DynamicResource>)(object)val10).ProvideValue((IServiceProvider)val73);
			((IDynamicResourceHandler)val11).SetDynamicResource(BoxView.ColorProperty, val76.get_Key());
			((BindableObject)val11).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val11);
			((BindableObject)val27).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 32.0));
			((BindableObject)val27).SetValue(StackLayout.SpacingProperty, (object)24.0);
			((BindableObject)val13).SetValue(Label.TextProperty, (object)loginView_ContentTitle);
			val12.set_Key("Heading1");
			XamlServiceProvider val77 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 9];
			array5[0] = val13;
			array5[1] = val27;
			array5[2] = val28;
			array5[3] = shadowFrame;
			array5[4] = val29;
			array5[5] = val55;
			array5[6] = val56;
			array5[7] = val57;
			array5[8] = loginView;
			SimpleValueTargetProvider val78 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val58);
			object obj5 = (object)val78;
			val77.Add(typeFromHandle9, (object)val78);
			val77.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val79 = new XmlNamespaceResolver();
			val79.Add("", "http://xamarin.com/schemas/2014/forms");
			val79.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val79.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val79.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val79.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val79.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val79.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val79.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val77.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val79, typeof(LoginView).GetTypeInfo().Assembly));
			val77.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(52, 102)));
			DynamicResource val80 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val77);
			((IDynamicResourceHandler)val13).SetDynamicResource(VisualElement.StyleProperty, val80.get_Key());
			((BindableObject)val13).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val13);
			((BindableObject)val14).SetValue(Span.TextProperty, (object)loginView_ContentDescription);
			val16.get_Spans().Add(val14);
			((BindableObject)val15).SetValue(Span.TextProperty, (object)loginView_ContentDescription2);
			((BindableObject)val15).SetValue(Span.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val16.get_Spans().Add(val15);
			((BindableObject)val17).SetValue(Label.FormattedTextProperty, (object)val16);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val17);
			val18.set_Path("IsMock");
			BindingBase val81 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)null);
			((BindableObject)val22).SetBinding(VisualElement.IsVisibleProperty, val81);
			((BindableObject)val22).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val19).SetValue(Label.TextProperty, (object)"Username");
			((Layout<View>)(object)val22).get_Children().Add((View)(object)val19);
			((BindableObject)val21).SetValue(Element.AutomationIdProperty, (object)text);
			val20.set_Mode((BindingMode)1);
			val20.set_Path("MockUsername");
			BindingBase val82 = ((IMarkupExtension<BindingBase>)(object)val20).ProvideValue((IServiceProvider)null);
			((BindableObject)val21).SetBinding(Entry.TextProperty, val82);
			((Layout<View>)(object)val22).get_Children().Add((View)(object)val21);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val22);
			((BindableObject)val26).SetValue(Button.TextProperty, (object)loginView_LogInButton);
			val23.set_Key("LargeButtonStyle");
			XamlServiceProvider val83 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 9];
			array6[0] = val26;
			array6[1] = val27;
			array6[2] = val28;
			array6[3] = shadowFrame;
			array6[4] = val29;
			array6[5] = val55;
			array6[6] = val56;
			array6[7] = val57;
			array6[8] = loginView;
			SimpleValueTargetProvider val84 = new SimpleValueTargetProvider(array6, (object)VisualElement.StyleProperty, (INameScope)(object)val58);
			object obj6 = (object)val84;
			val83.Add(typeFromHandle11, (object)val84);
			val83.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val85 = new XmlNamespaceResolver();
			val85.Add("", "http://xamarin.com/schemas/2014/forms");
			val85.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val85.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val85.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val85.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val85.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val85.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val85.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val83.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val85, typeof(LoginView).GetTypeInfo().Assembly));
			val83.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 37)));
			DynamicResource val86 = ((IMarkupExtension<DynamicResource>)(object)val23).ProvideValue((IServiceProvider)val83);
			((IDynamicResourceHandler)val26).SetDynamicResource(VisualElement.StyleProperty, val86.get_Key());
			val24.set_Key("QuinaryColor");
			XamlServiceProvider val87 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 9];
			array7[0] = val26;
			array7[1] = val27;
			array7[2] = val28;
			array7[3] = shadowFrame;
			array7[4] = val29;
			array7[5] = val55;
			array7[6] = val56;
			array7[7] = val57;
			array7[8] = loginView;
			SimpleValueTargetProvider val88 = new SimpleValueTargetProvider(array7, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val58);
			object obj7 = (object)val88;
			val87.Add(typeFromHandle13, (object)val88);
			val87.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val89 = new XmlNamespaceResolver();
			val89.Add("", "http://xamarin.com/schemas/2014/forms");
			val89.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val89.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val89.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val89.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val89.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val89.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val89.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val87.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val89, typeof(LoginView).GetTypeInfo().Assembly));
			val87.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 37)));
			DynamicResource val90 = ((IMarkupExtension<DynamicResource>)(object)val24).ProvideValue((IServiceProvider)val87);
			((IDynamicResourceHandler)val26).SetDynamicResource(VisualElement.BackgroundColorProperty, val90.get_Key());
			((BindableObject)val26).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)val26).SetValue(Button.PaddingProperty, (object)new Thickness(64.0, 16.0));
			((BindableObject)val26).SetValue(View.MarginProperty, (object)new Thickness(0.0, 24.0, 0.0, 0.0));
			((BindableObject)val26).SetValue(Element.AutomationIdProperty, (object)text2);
			val25.set_Path("SignInCommand");
			BindingBase val91 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)null);
			((BindableObject)val26).SetBinding(Button.CommandProperty, val91);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val26);
			((Layout<View>)(object)val28).get_Children().Add((View)(object)val27);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val28);
			((Layout<View>)(object)val29).get_Children().Add((View)(object)shadowFrame);
			((Layout<View>)(object)val55).get_Children().Add((View)(object)val29);
			((BindableObject)val54).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.EndAndExpand);
			((BindableObject)val54).SetValue(StackLayout.SpacingProperty, (object)0.0);
			val30.set_Key("InverseBoolConverter");
			XamlServiceProvider val92 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 6];
			array8[0] = val31;
			array8[1] = val54;
			array8[2] = val55;
			array8[3] = val56;
			array8[4] = val57;
			array8[5] = loginView;
			SimpleValueTargetProvider val93 = new SimpleValueTargetProvider(array8, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val58);
			object obj8 = (object)val93;
			val92.Add(typeFromHandle15, (object)val93);
			val92.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val94 = new XmlNamespaceResolver();
			val94.Add("", "http://xamarin.com/schemas/2014/forms");
			val94.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val94.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val94.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val94.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val94.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val94.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val94.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val92.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val94, typeof(LoginView).GetTypeInfo().Assembly));
			val92.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(107, 21)));
			object converter2 = ((IMarkupExtension)val30).ProvideValue((IServiceProvider)val92);
			val31.set_Converter((IValueConverter)converter2);
			val31.set_Path("IsBusy");
			BindingBase val95 = ((IMarkupExtension<BindingBase>)(object)val31).ProvideValue((IServiceProvider)null);
			((BindableObject)val54).SetBinding(VisualElement.IsVisibleProperty, val95);
			((BindableObject)tintedCachedImage2).SetValue(CachedImage.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("SAGov"));
			((BindableObject)tintedCachedImage2).SetValue(VisualElement.HeightRequestProperty, (object)30.0);
			((BindableObject)tintedCachedImage2).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)tintedCachedImage2).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((Layout<View>)(object)val54).get_Children().Add((View)(object)tintedCachedImage2);
			((BindableObject)val49).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val49).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val49).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Transparent);
			val32.set_Key("GrayColor");
			XamlServiceProvider val96 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 6];
			array9[0] = val49;
			array9[1] = val54;
			array9[2] = val55;
			array9[3] = val56;
			array9[4] = val57;
			array9[5] = loginView;
			SimpleValueTargetProvider val97 = new SimpleValueTargetProvider(array9, (object)Frame.BorderColorProperty, (INameScope)(object)val58);
			object obj9 = (object)val97;
			val96.Add(typeFromHandle17, (object)val97);
			val96.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val98 = new XmlNamespaceResolver();
			val98.Add("", "http://xamarin.com/schemas/2014/forms");
			val98.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val98.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val98.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val98.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val98.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val98.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val98.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val96.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val98, typeof(LoginView).GetTypeInfo().Assembly));
			val96.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(118, 25)));
			DynamicResource val99 = ((IMarkupExtension<DynamicResource>)(object)val32).ProvideValue((IServiceProvider)val96);
			((IDynamicResourceHandler)val49).SetDynamicResource(Frame.BorderColorProperty, val99.get_Key());
			((BindableObject)val49).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 16.0));
			((BindableObject)val49).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val49).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			val33.set_Path("PrivacyPolicyCommand");
			BindingBase val100 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)null);
			((BindableObject)val34).SetBinding(TapGestureRecognizer.CommandProperty, val100);
			((View)val49).get_GestureRecognizers().Add((IGestureRecognizer)(object)val34);
			((BindableObject)val48).SetValue(Grid.ColumnSpacingProperty, (object)16.0);
			((BindableObject)val35).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val48).GetValue(Grid.ColumnDefinitionsProperty)).Add(val35);
			((BindableObject)val36).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val48).GetValue(Grid.ColumnDefinitionsProperty)).Add(val36);
			((BindableObject)val37).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("auto"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val48).GetValue(Grid.ColumnDefinitionsProperty)).Add(val37);
			((BindableObject)val40).SetValue(Grid.ColumnProperty, (object)0);
			val38.set_Key("faExternalLink");
			XamlServiceProvider val101 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 8];
			array10[0] = val40;
			array10[1] = val48;
			array10[2] = val49;
			array10[3] = val54;
			array10[4] = val55;
			array10[5] = val56;
			array10[6] = val57;
			array10[7] = loginView;
			SimpleValueTargetProvider val102 = new SimpleValueTargetProvider(array10, (object)Label.TextProperty, (INameScope)(object)val58);
			object obj10 = (object)val102;
			val101.Add(typeFromHandle19, (object)val102);
			val101.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val103 = new XmlNamespaceResolver();
			val103.Add("", "http://xamarin.com/schemas/2014/forms");
			val103.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val103.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val103.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val103.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val103.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val103.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val103.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val101.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val103, typeof(LoginView).GetTypeInfo().Assembly));
			val101.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(131, 33)));
			object text3 = ((IMarkupExtension)val38).ProvideValue((IServiceProvider)val101);
			val40.set_Text((string)text3);
			((BindableObject)val40).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val39.set_Key("Small");
			XamlServiceProvider val104 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 8];
			array11[0] = val40;
			array11[1] = val48;
			array11[2] = val49;
			array11[3] = val54;
			array11[4] = val55;
			array11[5] = val56;
			array11[6] = val57;
			array11[7] = loginView;
			SimpleValueTargetProvider val105 = new SimpleValueTargetProvider(array11, (object)VisualElement.StyleProperty, (INameScope)(object)val58);
			object obj11 = (object)val105;
			val104.Add(typeFromHandle21, (object)val105);
			val104.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val106 = new XmlNamespaceResolver();
			val106.Add("", "http://xamarin.com/schemas/2014/forms");
			val106.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val106.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val106.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val106.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val106.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val106.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val106.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val104.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val106, typeof(LoginView).GetTypeInfo().Assembly));
			val104.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(133, 33)));
			DynamicResource val107 = ((IMarkupExtension<DynamicResource>)(object)val39).ProvideValue((IServiceProvider)val104);
			((IDynamicResourceHandler)val40).SetDynamicResource(VisualElement.StyleProperty, val107.get_Key());
			((BindableObject)val40).SetValue(Label.TextColorProperty, (object)Color.Transparent);
			((BindableObject)val40).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val40).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val48.get_Children()).Add((View)(object)val40);
			((BindableObject)val43).SetValue(Label.TextProperty, (object)homePage_ControlBranchPrivacy);
			((BindableObject)val43).SetValue(Grid.ColumnProperty, (object)1);
			val41.set_Key("Small");
			XamlServiceProvider val108 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 8];
			array12[0] = val43;
			array12[1] = val48;
			array12[2] = val49;
			array12[3] = val54;
			array12[4] = val55;
			array12[5] = val56;
			array12[6] = val57;
			array12[7] = loginView;
			SimpleValueTargetProvider val109 = new SimpleValueTargetProvider(array12, (object)VisualElement.StyleProperty, (INameScope)(object)val58);
			object obj12 = (object)val109;
			val108.Add(typeFromHandle23, (object)val109);
			val108.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val110 = new XmlNamespaceResolver();
			val110.Add("", "http://xamarin.com/schemas/2014/forms");
			val110.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val110.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val110.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val110.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val110.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val110.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val110.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val108.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val110, typeof(LoginView).GetTypeInfo().Assembly));
			val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(140, 33)));
			DynamicResource val111 = ((IMarkupExtension<DynamicResource>)(object)val41).ProvideValue((IServiceProvider)val108);
			((IDynamicResourceHandler)val43).SetDynamicResource(VisualElement.StyleProperty, val111.get_Key());
			((BindableObject)val43).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val42.set_Key("SecondaryColor");
			XamlServiceProvider val112 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array13 = new object[0 + 8];
			array13[0] = val43;
			array13[1] = val48;
			array13[2] = val49;
			array13[3] = val54;
			array13[4] = val55;
			array13[5] = val56;
			array13[6] = val57;
			array13[7] = loginView;
			SimpleValueTargetProvider val113 = new SimpleValueTargetProvider(array13, (object)Label.TextColorProperty, (INameScope)(object)val58);
			object obj13 = (object)val113;
			val112.Add(typeFromHandle25, (object)val113);
			val112.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val114 = new XmlNamespaceResolver();
			val114.Add("", "http://xamarin.com/schemas/2014/forms");
			val114.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val114.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val114.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val114.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val114.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val114.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val114.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val112.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val114, typeof(LoginView).GetTypeInfo().Assembly));
			val112.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(142, 33)));
			DynamicResource val115 = ((IMarkupExtension<DynamicResource>)(object)val42).ProvideValue((IServiceProvider)val112);
			((IDynamicResourceHandler)val43).SetDynamicResource(Label.TextColorProperty, val115.get_Key());
			((BindableObject)val43).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((ICollection<View>)val48.get_Children()).Add((View)(object)val43);
			val44.set_Key("faExternalLink");
			XamlServiceProvider val116 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array14 = new object[0 + 8];
			array14[0] = val47;
			array14[1] = val48;
			array14[2] = val49;
			array14[3] = val54;
			array14[4] = val55;
			array14[5] = val56;
			array14[6] = val57;
			array14[7] = loginView;
			SimpleValueTargetProvider val117 = new SimpleValueTargetProvider(array14, (object)Label.TextProperty, (INameScope)(object)val58);
			object obj14 = (object)val117;
			val116.Add(typeFromHandle27, (object)val117);
			val116.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val118 = new XmlNamespaceResolver();
			val118.Add("", "http://xamarin.com/schemas/2014/forms");
			val118.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val118.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val118.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val118.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val118.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val118.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val118.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val116.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val118, typeof(LoginView).GetTypeInfo().Assembly));
			val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(145, 33)));
			object text4 = ((IMarkupExtension)val44).ProvideValue((IServiceProvider)val116);
			val47.set_Text((string)text4);
			((BindableObject)val47).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
			val45.set_Key("Small");
			XamlServiceProvider val119 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array15 = new object[0 + 8];
			array15[0] = val47;
			array15[1] = val48;
			array15[2] = val49;
			array15[3] = val54;
			array15[4] = val55;
			array15[5] = val56;
			array15[6] = val57;
			array15[7] = loginView;
			SimpleValueTargetProvider val120 = new SimpleValueTargetProvider(array15, (object)VisualElement.StyleProperty, (INameScope)(object)val58);
			object obj15 = (object)val120;
			val119.Add(typeFromHandle29, (object)val120);
			val119.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val121 = new XmlNamespaceResolver();
			val121.Add("", "http://xamarin.com/schemas/2014/forms");
			val121.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val121.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val121.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val121.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val121.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val121.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val121.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val119.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val121, typeof(LoginView).GetTypeInfo().Assembly));
			val119.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(147, 33)));
			DynamicResource val122 = ((IMarkupExtension<DynamicResource>)(object)val45).ProvideValue((IServiceProvider)val119);
			((IDynamicResourceHandler)val47).SetDynamicResource(VisualElement.StyleProperty, val122.get_Key());
			val46.set_Key("SecondaryColor");
			XamlServiceProvider val123 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array16 = new object[0 + 8];
			array16[0] = val47;
			array16[1] = val48;
			array16[2] = val49;
			array16[3] = val54;
			array16[4] = val55;
			array16[5] = val56;
			array16[6] = val57;
			array16[7] = loginView;
			SimpleValueTargetProvider val124 = new SimpleValueTargetProvider(array16, (object)Label.TextColorProperty, (INameScope)(object)val58);
			object obj16 = (object)val124;
			val123.Add(typeFromHandle31, (object)val124);
			val123.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val125 = new XmlNamespaceResolver();
			val125.Add("", "http://xamarin.com/schemas/2014/forms");
			val125.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val125.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val125.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val125.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val125.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val125.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val125.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val123.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val125, typeof(LoginView).GetTypeInfo().Assembly));
			val123.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(148, 33)));
			DynamicResource val126 = ((IMarkupExtension<DynamicResource>)(object)val46).ProvideValue((IServiceProvider)val123);
			((IDynamicResourceHandler)val47).SetDynamicResource(Label.TextColorProperty, val126.get_Key());
			((BindableObject)val47).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val47).SetValue(Grid.ColumnProperty, (object)2);
			((BindableObject)val47).SetValue(Label.FontFamilyProperty, (object)"FA-S");
			((ICollection<View>)val48.get_Children()).Add((View)(object)val47);
			((BindableObject)val49).SetValue(ContentView.ContentProperty, (object)val48);
			((Layout<View>)(object)val54).get_Children().Add((View)(object)val49);
			val50.set_Path("VersionNumber");
			BindingBase val127 = ((IMarkupExtension<BindingBase>)(object)val50).ProvideValue((IServiceProvider)null);
			((BindableObject)val53).SetBinding(Label.TextProperty, val127);
			val51.set_Key("SecondaryTextColor");
			XamlServiceProvider val128 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array17 = new object[0 + 6];
			array17[0] = val53;
			array17[1] = val54;
			array17[2] = val55;
			array17[3] = val56;
			array17[4] = val57;
			array17[5] = loginView;
			SimpleValueTargetProvider val129 = new SimpleValueTargetProvider(array17, (object)Label.TextColorProperty, (INameScope)(object)val58);
			object obj17 = (object)val129;
			val128.Add(typeFromHandle33, (object)val129);
			val128.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val130 = new XmlNamespaceResolver();
			val130.Add("", "http://xamarin.com/schemas/2014/forms");
			val130.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val130.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val130.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val130.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val130.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val130.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val130.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val128.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val130, typeof(LoginView).GetTypeInfo().Assembly));
			val128.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(160, 25)));
			DynamicResource val131 = ((IMarkupExtension<DynamicResource>)(object)val51).ProvideValue((IServiceProvider)val128);
			((IDynamicResourceHandler)val53).SetDynamicResource(Label.TextColorProperty, val131.get_Key());
			val52.set_Key("Small");
			XamlServiceProvider val132 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array18 = new object[0 + 6];
			array18[0] = val53;
			array18[1] = val54;
			array18[2] = val55;
			array18[3] = val56;
			array18[4] = val57;
			array18[5] = loginView;
			SimpleValueTargetProvider val133 = new SimpleValueTargetProvider(array18, (object)VisualElement.StyleProperty, (INameScope)(object)val58);
			object obj18 = (object)val133;
			val132.Add(typeFromHandle35, (object)val133);
			val132.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val134 = new XmlNamespaceResolver();
			val134.Add("", "http://xamarin.com/schemas/2014/forms");
			val134.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val134.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val134.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val134.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val134.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val134.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val134.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val132.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val134, typeof(LoginView).GetTypeInfo().Assembly));
			val132.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(161, 25)));
			DynamicResource val135 = ((IMarkupExtension<DynamicResource>)(object)val52).ProvideValue((IServiceProvider)val132);
			((IDynamicResourceHandler)val53).SetDynamicResource(VisualElement.StyleProperty, val135.get_Key());
			((BindableObject)val53).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val53).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val53).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val54).get_Children().Add((View)(object)val53);
			((Layout<View>)(object)val55).get_Children().Add((View)(object)val54);
			val56.set_Content((View)(object)val55);
			((Layout<View>)(object)val57).get_Children().Add((View)(object)val56);
			((BindableObject)loginView).SetValue(ContentPage.ContentProperty, (object)val57);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<LoginView>(this, typeof(LoginView));
			scrollView = NameScopeExtensions.FindByName<ScrollView>((Element)(object)this, "scrollView");
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			mockUsernameEntry = NameScopeExtensions.FindByName<Entry>((Element)(object)this, "mockUsernameEntry");
			versionNumberLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "versionNumberLabel");
		}
	}
}
