using System;
using System.CodeDom.Compiler;
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
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
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
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
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
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Expected O, but got Unknown
			//IL_047a: Expected O, but got Unknown
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Expected O, but got Unknown
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Expected O, but got Unknown
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Unknown result type (might be due to invalid IL or missing references)
			//IL_0553: Expected O, but got Unknown
			//IL_054e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0558: Expected O, but got Unknown
			//IL_055d: Expected O, but got Unknown
			//IL_059a: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected O, but got Unknown
			//IL_05e4: Expected O, but got Unknown
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_0626: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_0646: Unknown result type (might be due to invalid IL or missing references)
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_0666: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Unknown result type (might be due to invalid IL or missing references)
			//IL_069f: Expected O, but got Unknown
			//IL_069a: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a4: Expected O, but got Unknown
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Expected O, but got Unknown
			//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Expected O, but got Unknown
			//IL_06c7: Expected O, but got Unknown
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0737: Unknown result type (might be due to invalid IL or missing references)
			//IL_0764: Unknown result type (might be due to invalid IL or missing references)
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e5: Expected O, but got Unknown
			//IL_07ea: Expected O, but got Unknown
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_082c: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_084c: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_086c: Unknown result type (might be due to invalid IL or missing references)
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a5: Expected O, but got Unknown
			//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08aa: Expected O, but got Unknown
			//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c3: Expected O, but got Unknown
			//IL_08be: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c8: Expected O, but got Unknown
			//IL_08cd: Expected O, but got Unknown
			//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0937: Unknown result type (might be due to invalid IL or missing references)
			//IL_093c: Unknown result type (might be due to invalid IL or missing references)
			//IL_093f: Expected O, but got Unknown
			//IL_0944: Expected O, but got Unknown
			//IL_0944: Unknown result type (might be due to invalid IL or missing references)
			//IL_0956: Unknown result type (might be due to invalid IL or missing references)
			//IL_0961: Unknown result type (might be due to invalid IL or missing references)
			//IL_0966: Unknown result type (might be due to invalid IL or missing references)
			//IL_0976: Unknown result type (might be due to invalid IL or missing references)
			//IL_0986: Unknown result type (might be due to invalid IL or missing references)
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ff: Expected O, but got Unknown
			//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a04: Expected O, but got Unknown
			//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1d: Expected O, but got Unknown
			//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a22: Expected O, but got Unknown
			//IL_0a27: Expected O, but got Unknown
			//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b29: Expected O, but got Unknown
			//IL_0b2e: Expected O, but got Unknown
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be9: Expected O, but got Unknown
			//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bee: Expected O, but got Unknown
			//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c07: Expected O, but got Unknown
			//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0c: Expected O, but got Unknown
			//IL_0c11: Expected O, but got Unknown
			//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3a: Expected O, but got Unknown
			//IL_0d3f: Expected O, but got Unknown
			//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dfa: Expected O, but got Unknown
			//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dff: Expected O, but got Unknown
			//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1b: Expected O, but got Unknown
			//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e20: Expected O, but got Unknown
			//IL_0e25: Expected O, but got Unknown
			//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa9: Expected O, but got Unknown
			//IL_0fae: Expected O, but got Unknown
			//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1000: Unknown result type (might be due to invalid IL or missing references)
			//IL_1010: Unknown result type (might be due to invalid IL or missing references)
			//IL_1020: Unknown result type (might be due to invalid IL or missing references)
			//IL_1030: Unknown result type (might be due to invalid IL or missing references)
			//IL_1040: Unknown result type (might be due to invalid IL or missing references)
			//IL_1069: Expected O, but got Unknown
			//IL_1064: Unknown result type (might be due to invalid IL or missing references)
			//IL_106e: Expected O, but got Unknown
			//IL_106e: Unknown result type (might be due to invalid IL or missing references)
			//IL_107d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1087: Expected O, but got Unknown
			//IL_1082: Unknown result type (might be due to invalid IL or missing references)
			//IL_108c: Expected O, but got Unknown
			//IL_1091: Expected O, but got Unknown
			//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1101: Unknown result type (might be due to invalid IL or missing references)
			//IL_1106: Unknown result type (might be due to invalid IL or missing references)
			//IL_1109: Expected O, but got Unknown
			//IL_110e: Expected O, but got Unknown
			//IL_110e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1120: Unknown result type (might be due to invalid IL or missing references)
			//IL_112b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1130: Unknown result type (might be due to invalid IL or missing references)
			//IL_1140: Unknown result type (might be due to invalid IL or missing references)
			//IL_1150: Unknown result type (might be due to invalid IL or missing references)
			//IL_1160: Unknown result type (might be due to invalid IL or missing references)
			//IL_1170: Unknown result type (might be due to invalid IL or missing references)
			//IL_1180: Unknown result type (might be due to invalid IL or missing references)
			//IL_1190: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_11c9: Expected O, but got Unknown
			//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ce: Expected O, but got Unknown
			//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e7: Expected O, but got Unknown
			//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ec: Expected O, but got Unknown
			//IL_11f1: Expected O, but got Unknown
			//IL_120d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1235: Unknown result type (might be due to invalid IL or missing references)
			//IL_126f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1328: Unknown result type (might be due to invalid IL or missing references)
			//IL_132d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1360: Unknown result type (might be due to invalid IL or missing references)
			//IL_1365: Unknown result type (might be due to invalid IL or missing references)
			//IL_1368: Expected O, but got Unknown
			//IL_136d: Expected O, but got Unknown
			//IL_136d: Unknown result type (might be due to invalid IL or missing references)
			//IL_137f: Unknown result type (might be due to invalid IL or missing references)
			//IL_138a: Unknown result type (might be due to invalid IL or missing references)
			//IL_138f: Unknown result type (might be due to invalid IL or missing references)
			//IL_139f: Unknown result type (might be due to invalid IL or missing references)
			//IL_13af: Unknown result type (might be due to invalid IL or missing references)
			//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_13cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_13df: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1428: Expected O, but got Unknown
			//IL_1423: Unknown result type (might be due to invalid IL or missing references)
			//IL_142d: Expected O, but got Unknown
			//IL_142d: Unknown result type (might be due to invalid IL or missing references)
			//IL_143c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1446: Expected O, but got Unknown
			//IL_1441: Unknown result type (might be due to invalid IL or missing references)
			//IL_144b: Expected O, but got Unknown
			//IL_1450: Expected O, but got Unknown
			//IL_1473: Unknown result type (might be due to invalid IL or missing references)
			//IL_1478: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b3: Expected O, but got Unknown
			//IL_14b8: Expected O, but got Unknown
			//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_14da: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_150a: Unknown result type (might be due to invalid IL or missing references)
			//IL_151a: Unknown result type (might be due to invalid IL or missing references)
			//IL_152a: Unknown result type (might be due to invalid IL or missing references)
			//IL_153a: Unknown result type (might be due to invalid IL or missing references)
			//IL_154a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1573: Expected O, but got Unknown
			//IL_156e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1578: Expected O, but got Unknown
			//IL_1578: Unknown result type (might be due to invalid IL or missing references)
			//IL_1587: Unknown result type (might be due to invalid IL or missing references)
			//IL_1591: Expected O, but got Unknown
			//IL_158c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1596: Expected O, but got Unknown
			//IL_159b: Expected O, but got Unknown
			//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_160e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1613: Unknown result type (might be due to invalid IL or missing references)
			//IL_165a: Unknown result type (might be due to invalid IL or missing references)
			//IL_165f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1662: Expected O, but got Unknown
			//IL_1667: Expected O, but got Unknown
			//IL_1667: Unknown result type (might be due to invalid IL or missing references)
			//IL_1679: Unknown result type (might be due to invalid IL or missing references)
			//IL_1684: Unknown result type (might be due to invalid IL or missing references)
			//IL_1689: Unknown result type (might be due to invalid IL or missing references)
			//IL_1699: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1722: Expected O, but got Unknown
			//IL_171d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1727: Expected O, but got Unknown
			//IL_1727: Unknown result type (might be due to invalid IL or missing references)
			//IL_1736: Unknown result type (might be due to invalid IL or missing references)
			//IL_1740: Expected O, but got Unknown
			//IL_173b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1745: Expected O, but got Unknown
			//IL_174a: Expected O, but got Unknown
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
			string loginView_ContentDescriptionSa = Resources.LoginView_ContentDescriptionSa;
			Span val15 = new Span();
			string loginView_ContentDescriptionGov = Resources.LoginView_ContentDescriptionGov;
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			Span val17 = new Span();
			string loginView_ContentDescription2 = Resources.LoginView_ContentDescription2;
			Span val18 = new Span();
			FormattedString val19 = new FormattedString();
			Label val20 = new Label();
			BindingExtension val21 = new BindingExtension();
			Label val22 = new Label();
			string text = "LoginView_MockUsernameEntry";
			BindingExtension val23 = new BindingExtension();
			Entry val24 = new Entry();
			StackLayout val25 = new StackLayout();
			string loginView_LogInButton = Resources.LoginView_LogInButton;
			DynamicResourceExtension val26 = new DynamicResourceExtension();
			DynamicResourceExtension val27 = new DynamicResourceExtension();
			string text2 = "LoginView_SignIn";
			BindingExtension val28 = new BindingExtension();
			Button val29 = new Button();
			StackLayout val30 = new StackLayout();
			StackLayout val31 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			StackLayout val32 = new StackLayout();
			BindingExtension val33 = new BindingExtension();
			DynamicResourceExtension val34 = new DynamicResourceExtension();
			DynamicResourceExtension val35 = new DynamicResourceExtension();
			StaticResourceExtension val36 = new StaticResourceExtension();
			BindingExtension val37 = new BindingExtension();
			Label val38 = new Label();
			StackLayout val39 = new StackLayout();
			ScrollView val40 = new ScrollView();
			StackLayout val41 = new StackLayout();
			LoginView loginView;
			NameScope val42 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(loginView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)loginView, (INameScope)(object)val42);
			((INameScope)val42).RegisterName("scrollView", (object)val40);
			if (((Element)val40).get_StyleId() == null)
			{
				((Element)val40).set_StyleId("scrollView");
			}
			((INameScope)val42).RegisterName("containingView", (object)val39);
			if (((Element)val39).get_StyleId() == null)
			{
				((Element)val39).set_StyleId("containingView");
			}
			((INameScope)val42).RegisterName("mockUsernameEntry", (object)val24);
			if (((Element)val24).get_StyleId() == null)
			{
				((Element)val24).set_StyleId("mockUsernameEntry");
			}
			((INameScope)val42).RegisterName("versionNumberLabel", (object)val38);
			if (((Element)val38).get_StyleId() == null)
			{
				((Element)val38).set_StyleId("versionNumberLabel");
			}
			scrollView = val40;
			containingView = val39;
			mockUsernameEntry = val24;
			versionNumberLabel = val38;
			((BindableObject)loginView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((VisualElement)loginView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val41).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val40).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val40).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)val39).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val39).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val39).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			val2.set_Path("IsBusy");
			BindingBase val43 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)val5).SetBinding(VisualElement.IsVisibleProperty, val43);
			((BindableObject)val5).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)val4).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val4).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			val3.set_Path("IsBusy");
			BindingBase val44 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val4).SetBinding(ActivityIndicator.IsRunningProperty, val44);
			((Layout<View>)(object)val5).get_Children().Add((View)(object)val4);
			((Layout<View>)(object)val39).get_Children().Add((View)(object)val5);
			((BindableObject)val32).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			val6.set_Key("InverseBoolConverter");
			XamlServiceProvider val45 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 6];
			array[0] = val7;
			array[1] = val32;
			array[2] = val39;
			array[3] = val40;
			array[4] = val41;
			array[5] = loginView;
			SimpleValueTargetProvider val46 = new SimpleValueTargetProvider(array, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val42);
			object obj = (object)val46;
			val45.Add(typeFromHandle, (object)val46);
			val45.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val47 = new XmlNamespaceResolver();
			val47.Add("", "http://xamarin.com/schemas/2014/forms");
			val47.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val47.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val47.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val47.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val47.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val47.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val47.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val45.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val47, typeof(LoginView).GetTypeInfo().Assembly));
			val45.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 21)));
			object converter = ((IMarkupExtension)val6).ProvideValue((IServiceProvider)val45);
			val7.set_Converter((IValueConverter)converter);
			val7.set_Path("IsBusy");
			BindingBase val48 = ((IMarkupExtension<BindingBase>)(object)val7).ProvideValue((IServiceProvider)null);
			((BindableObject)val32).SetBinding(VisualElement.IsVisibleProperty, val48);
			val8.set_Key("AppLogo");
			XamlServiceProvider val49 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 6];
			array2[0] = tintedCachedImage;
			array2[1] = val32;
			array2[2] = val39;
			array2[3] = val40;
			array2[4] = val41;
			array2[5] = loginView;
			SimpleValueTargetProvider val50 = new SimpleValueTargetProvider(array2, (object)CachedImage.SourceProperty, (INameScope)(object)val42);
			object obj2 = (object)val50;
			val49.Add(typeFromHandle3, (object)val50);
			val49.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val51 = new XmlNamespaceResolver();
			val51.Add("", "http://xamarin.com/schemas/2014/forms");
			val51.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val51.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val51.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val51.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val51.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val51.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val51.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val49.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val51, typeof(LoginView).GetTypeInfo().Assembly));
			val49.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 25)));
			DynamicResource val52 = ((IMarkupExtension<DynamicResource>)(object)val8).ProvideValue((IServiceProvider)val49);
			((IDynamicResourceHandler)tintedCachedImage).SetDynamicResource(CachedImage.SourceProperty, val52.get_Key());
			((BindableObject)tintedCachedImage).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
			((BindableObject)tintedCachedImage).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 24.0));
			((Layout<View>)(object)val32).get_Children().Add((View)(object)tintedCachedImage);
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			val9.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val53 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 6];
			array3[0] = shadowFrame;
			array3[1] = val32;
			array3[2] = val39;
			array3[3] = val40;
			array3[4] = val41;
			array3[5] = loginView;
			SimpleValueTargetProvider val54 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val42);
			object obj3 = (object)val54;
			val53.Add(typeFromHandle5, (object)val54);
			val53.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val55 = new XmlNamespaceResolver();
			val55.Add("", "http://xamarin.com/schemas/2014/forms");
			val55.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val55.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val55.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val55.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val55.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val55.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val55.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val53.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val55, typeof(LoginView).GetTypeInfo().Assembly));
			val53.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 25)));
			DynamicResource val56 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val53);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val56.get_Key());
			val10.set_Key("QuinaryColor");
			XamlServiceProvider val57 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val11;
			array4[1] = val31;
			array4[2] = shadowFrame;
			array4[3] = val32;
			array4[4] = val39;
			array4[5] = val40;
			array4[6] = val41;
			array4[7] = loginView;
			SimpleValueTargetProvider val58 = new SimpleValueTargetProvider(array4, (object)BoxView.ColorProperty, (INameScope)(object)val42);
			object obj4 = (object)val58;
			val57.Add(typeFromHandle7, (object)val58);
			val57.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val59 = new XmlNamespaceResolver();
			val59.Add("", "http://xamarin.com/schemas/2014/forms");
			val59.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val59.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val59.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val59.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val59.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val59.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val59.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val57.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val59, typeof(LoginView).GetTypeInfo().Assembly));
			val57.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 38)));
			DynamicResource val60 = ((IMarkupExtension<DynamicResource>)(object)val10).ProvideValue((IServiceProvider)val57);
			((IDynamicResourceHandler)val11).SetDynamicResource(BoxView.ColorProperty, val60.get_Key());
			((BindableObject)val11).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val31).get_Children().Add((View)(object)val11);
			((BindableObject)val30).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 32.0));
			((BindableObject)val30).SetValue(StackLayout.SpacingProperty, (object)24.0);
			((BindableObject)val13).SetValue(Label.TextProperty, (object)loginView_ContentTitle);
			val12.set_Key("Heading1");
			XamlServiceProvider val61 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 9];
			array5[0] = val13;
			array5[1] = val30;
			array5[2] = val31;
			array5[3] = shadowFrame;
			array5[4] = val32;
			array5[5] = val39;
			array5[6] = val40;
			array5[7] = val41;
			array5[8] = loginView;
			SimpleValueTargetProvider val62 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val42);
			object obj5 = (object)val62;
			val61.Add(typeFromHandle9, (object)val62);
			val61.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val63 = new XmlNamespaceResolver();
			val63.Add("", "http://xamarin.com/schemas/2014/forms");
			val63.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val63.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val63.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val63.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val63.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val63.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val63.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val61.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val63, typeof(LoginView).GetTypeInfo().Assembly));
			val61.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 102)));
			DynamicResource val64 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val61);
			((IDynamicResourceHandler)val13).SetDynamicResource(VisualElement.StyleProperty, val64.get_Key());
			((BindableObject)val13).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val13);
			((BindableObject)val14).SetValue(Span.TextProperty, (object)loginView_ContentDescription);
			val19.get_Spans().Add(val14);
			((BindableObject)val15).SetValue(Span.TextProperty, (object)loginView_ContentDescriptionSa);
			((BindableObject)val15).SetValue(Span.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val19.get_Spans().Add(val15);
			((BindableObject)val17).SetValue(Span.TextProperty, (object)loginView_ContentDescriptionGov);
			((BindableObject)val17).SetValue(Span.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val16.set_Key("QuartenaryColor");
			XamlServiceProvider val65 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 11];
			array6[0] = val17;
			array6[1] = val19;
			array6[2] = val20;
			array6[3] = val30;
			array6[4] = val31;
			array6[5] = shadowFrame;
			array6[6] = val32;
			array6[7] = val39;
			array6[8] = val40;
			array6[9] = val41;
			array6[10] = loginView;
			SimpleValueTargetProvider val66 = new SimpleValueTargetProvider(array6, (object)Span.TextColorProperty, (INameScope)(object)val42);
			object obj6 = (object)val66;
			val65.Add(typeFromHandle11, (object)val66);
			val65.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val67 = new XmlNamespaceResolver();
			val67.Add("", "http://xamarin.com/schemas/2014/forms");
			val67.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val67.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val67.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val67.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val67.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val67.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val67.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val65.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val67, typeof(LoginView).GetTypeInfo().Assembly));
			val65.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(57, 144)));
			DynamicResource val68 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val65);
			((IDynamicResourceHandler)val17).SetDynamicResource(Span.TextColorProperty, val68.get_Key());
			val19.get_Spans().Add(val17);
			((BindableObject)val18).SetValue(Span.TextProperty, (object)loginView_ContentDescription2);
			val19.get_Spans().Add(val18);
			((BindableObject)val20).SetValue(Label.FormattedTextProperty, (object)val19);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val20);
			val21.set_Path("IsMock");
			BindingBase val69 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)null);
			((BindableObject)val25).SetBinding(VisualElement.IsVisibleProperty, val69);
			((BindableObject)val25).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val22).SetValue(Label.TextProperty, (object)"Username");
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val22);
			((BindableObject)val24).SetValue(Element.AutomationIdProperty, (object)text);
			val23.set_Mode((BindingMode)1);
			val23.set_Path("MockUsername");
			BindingBase val70 = ((IMarkupExtension<BindingBase>)(object)val23).ProvideValue((IServiceProvider)null);
			((BindableObject)val24).SetBinding(Entry.TextProperty, val70);
			((Layout<View>)(object)val25).get_Children().Add((View)(object)val24);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val25);
			((BindableObject)val29).SetValue(Button.TextProperty, (object)loginView_LogInButton);
			val26.set_Key("LargeButtonStyle");
			XamlServiceProvider val71 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 9];
			array7[0] = val29;
			array7[1] = val30;
			array7[2] = val31;
			array7[3] = shadowFrame;
			array7[4] = val32;
			array7[5] = val39;
			array7[6] = val40;
			array7[7] = val41;
			array7[8] = loginView;
			SimpleValueTargetProvider val72 = new SimpleValueTargetProvider(array7, (object)VisualElement.StyleProperty, (INameScope)(object)val42);
			object obj7 = (object)val72;
			val71.Add(typeFromHandle13, (object)val72);
			val71.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val73 = new XmlNamespaceResolver();
			val73.Add("", "http://xamarin.com/schemas/2014/forms");
			val73.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val73.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val73.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val73.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val73.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val73.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val73.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val71.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val73, typeof(LoginView).GetTypeInfo().Assembly));
			val71.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 37)));
			DynamicResource val74 = ((IMarkupExtension<DynamicResource>)(object)val26).ProvideValue((IServiceProvider)val71);
			((IDynamicResourceHandler)val29).SetDynamicResource(VisualElement.StyleProperty, val74.get_Key());
			val27.set_Key("QuinaryColor");
			XamlServiceProvider val75 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 9];
			array8[0] = val29;
			array8[1] = val30;
			array8[2] = val31;
			array8[3] = shadowFrame;
			array8[4] = val32;
			array8[5] = val39;
			array8[6] = val40;
			array8[7] = val41;
			array8[8] = loginView;
			SimpleValueTargetProvider val76 = new SimpleValueTargetProvider(array8, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val42);
			object obj8 = (object)val76;
			val75.Add(typeFromHandle15, (object)val76);
			val75.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val77 = new XmlNamespaceResolver();
			val77.Add("", "http://xamarin.com/schemas/2014/forms");
			val77.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val77.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val77.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val77.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val77.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val77.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val77.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val75.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val77, typeof(LoginView).GetTypeInfo().Assembly));
			val75.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 37)));
			DynamicResource val78 = ((IMarkupExtension<DynamicResource>)(object)val27).ProvideValue((IServiceProvider)val75);
			((IDynamicResourceHandler)val29).SetDynamicResource(VisualElement.BackgroundColorProperty, val78.get_Key());
			((BindableObject)val29).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Start);
			((BindableObject)val29).SetValue(Button.PaddingProperty, (object)new Thickness(64.0, 0.0));
			((BindableObject)val29).SetValue(View.MarginProperty, (object)new Thickness(0.0, 24.0, 0.0, 0.0));
			((BindableObject)val29).SetValue(Element.AutomationIdProperty, (object)text2);
			val28.set_Path("SignInCommand");
			BindingBase val79 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)null);
			((BindableObject)val29).SetBinding(Button.CommandProperty, val79);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val29);
			((Layout<View>)(object)val31).get_Children().Add((View)(object)val30);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val31);
			((Layout<View>)(object)val32).get_Children().Add((View)(object)shadowFrame);
			((Layout<View>)(object)val39).get_Children().Add((View)(object)val32);
			val33.set_Path("VersionNumber");
			BindingBase val80 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)null);
			((BindableObject)val38).SetBinding(Label.TextProperty, val80);
			val34.set_Key("SecondaryTextColor");
			XamlServiceProvider val81 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 5];
			array9[0] = val38;
			array9[1] = val39;
			array9[2] = val40;
			array9[3] = val41;
			array9[4] = loginView;
			SimpleValueTargetProvider val82 = new SimpleValueTargetProvider(array9, (object)Label.TextColorProperty, (INameScope)(object)val42);
			object obj9 = (object)val82;
			val81.Add(typeFromHandle17, (object)val82);
			val81.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val83 = new XmlNamespaceResolver();
			val83.Add("", "http://xamarin.com/schemas/2014/forms");
			val83.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val83.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val83.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val83.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val83.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val83.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val83.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val81.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val83, typeof(LoginView).GetTypeInfo().Assembly));
			val81.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(105, 21)));
			DynamicResource val84 = ((IMarkupExtension<DynamicResource>)(object)val34).ProvideValue((IServiceProvider)val81);
			((IDynamicResourceHandler)val38).SetDynamicResource(Label.TextColorProperty, val84.get_Key());
			val35.set_Key("Small");
			XamlServiceProvider val85 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 5];
			array10[0] = val38;
			array10[1] = val39;
			array10[2] = val40;
			array10[3] = val41;
			array10[4] = loginView;
			SimpleValueTargetProvider val86 = new SimpleValueTargetProvider(array10, (object)VisualElement.StyleProperty, (INameScope)(object)val42);
			object obj10 = (object)val86;
			val85.Add(typeFromHandle19, (object)val86);
			val85.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val87 = new XmlNamespaceResolver();
			val87.Add("", "http://xamarin.com/schemas/2014/forms");
			val87.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val87.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val87.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val87.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val87.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val87.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val87.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val85.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val87, typeof(LoginView).GetTypeInfo().Assembly));
			val85.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(106, 21)));
			DynamicResource val88 = ((IMarkupExtension<DynamicResource>)(object)val35).ProvideValue((IServiceProvider)val85);
			((IDynamicResourceHandler)val38).SetDynamicResource(VisualElement.StyleProperty, val88.get_Key());
			((BindableObject)val38).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val38).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val38).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			val36.set_Key("InverseBoolConverter");
			XamlServiceProvider val89 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 6];
			array11[0] = val37;
			array11[1] = val38;
			array11[2] = val39;
			array11[3] = val40;
			array11[4] = val41;
			array11[5] = loginView;
			SimpleValueTargetProvider val90 = new SimpleValueTargetProvider(array11, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val42);
			object obj11 = (object)val90;
			val89.Add(typeFromHandle21, (object)val90);
			val89.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val91 = new XmlNamespaceResolver();
			val91.Add("", "http://xamarin.com/schemas/2014/forms");
			val91.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val91.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val91.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val91.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val91.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val91.Add("automation", "clr-namespace:HomeQuarantine.Data.Automation;assembly=HomeQuarantine.Data");
			val91.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val89.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val91, typeof(LoginView).GetTypeInfo().Assembly));
			val89.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(110, 21)));
			object converter2 = ((IMarkupExtension)val36).ProvideValue((IServiceProvider)val89);
			val37.set_Converter((IValueConverter)converter2);
			val37.set_Path("IsBusy");
			BindingBase val92 = ((IMarkupExtension<BindingBase>)(object)val37).ProvideValue((IServiceProvider)null);
			((BindableObject)val38).SetBinding(VisualElement.IsVisibleProperty, val92);
			((Layout<View>)(object)val39).get_Children().Add((View)(object)val38);
			val40.set_Content((View)(object)val39);
			((Layout<View>)(object)val41).get_Children().Add((View)(object)val40);
			((BindableObject)loginView).SetValue(ContentPage.ContentProperty, (object)val41);
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
