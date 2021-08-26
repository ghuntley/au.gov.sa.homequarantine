using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Models.Enums;
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
	[XamlFilePath("Views/OnboardingView.xaml")]
	public class OnboardingView : BaseView, IChildView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		public OnboardingView()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			(((BindableObject)this).get_BindingContext() as OnboardingViewModel).RemovePreviousPagesCommand.Execute(null);
			await (((BindableObject)this).get_BindingContext() as OnboardingViewModel).CheckForAppPermissions();
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
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected O, but got Unknown
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected O, but got Unknown
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected O, but got Unknown
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected O, but got Unknown
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected O, but got Unknown
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected O, but got Unknown
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected O, but got Unknown
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Expected O, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected O, but got Unknown
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected O, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected O, but got Unknown
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected O, but got Unknown
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Expected O, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Expected O, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected O, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Expected O, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Expected O, but got Unknown
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected O, but got Unknown
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected O, but got Unknown
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected O, but got Unknown
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Expected O, but got Unknown
			//IL_05fd: Expected O, but got Unknown
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_060f: Unknown result type (might be due to invalid IL or missing references)
			//IL_061a: Unknown result type (might be due to invalid IL or missing references)
			//IL_061f: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_065f: Unknown result type (might be due to invalid IL or missing references)
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_067f: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b8: Expected O, but got Unknown
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Expected O, but got Unknown
			//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d6: Expected O, but got Unknown
			//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06db: Expected O, but got Unknown
			//IL_06e0: Expected O, but got Unknown
			//IL_0859: Unknown result type (might be due to invalid IL or missing references)
			//IL_085e: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bd: Expected O, but got Unknown
			//IL_08c2: Expected O, but got Unknown
			//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0914: Unknown result type (might be due to invalid IL or missing references)
			//IL_0924: Unknown result type (might be due to invalid IL or missing references)
			//IL_0934: Unknown result type (might be due to invalid IL or missing references)
			//IL_0944: Unknown result type (might be due to invalid IL or missing references)
			//IL_0954: Unknown result type (might be due to invalid IL or missing references)
			//IL_097d: Expected O, but got Unknown
			//IL_0978: Unknown result type (might be due to invalid IL or missing references)
			//IL_0982: Expected O, but got Unknown
			//IL_0982: Unknown result type (might be due to invalid IL or missing references)
			//IL_0991: Unknown result type (might be due to invalid IL or missing references)
			//IL_099b: Expected O, but got Unknown
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a0: Expected O, but got Unknown
			//IL_09a5: Expected O, but got Unknown
			//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b82: Expected O, but got Unknown
			//IL_0b87: Expected O, but got Unknown
			//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c42: Expected O, but got Unknown
			//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c47: Expected O, but got Unknown
			//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c60: Expected O, but got Unknown
			//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c65: Expected O, but got Unknown
			//IL_0c6a: Expected O, but got Unknown
			//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e47: Expected O, but got Unknown
			//IL_0e4c: Expected O, but got Unknown
			//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f07: Expected O, but got Unknown
			//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0c: Expected O, but got Unknown
			//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f25: Expected O, but got Unknown
			//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2a: Expected O, but got Unknown
			//IL_0f2f: Expected O, but got Unknown
			//IL_1084: Unknown result type (might be due to invalid IL or missing references)
			//IL_1089: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e8: Expected O, but got Unknown
			//IL_10ed: Expected O, but got Unknown
			//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_110a: Unknown result type (might be due to invalid IL or missing references)
			//IL_110f: Unknown result type (might be due to invalid IL or missing references)
			//IL_111f: Unknown result type (might be due to invalid IL or missing references)
			//IL_112f: Unknown result type (might be due to invalid IL or missing references)
			//IL_113f: Unknown result type (might be due to invalid IL or missing references)
			//IL_114f: Unknown result type (might be due to invalid IL or missing references)
			//IL_115f: Unknown result type (might be due to invalid IL or missing references)
			//IL_116f: Unknown result type (might be due to invalid IL or missing references)
			//IL_117f: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a8: Expected O, but got Unknown
			//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ad: Expected O, but got Unknown
			//IL_11ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_11bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_11c6: Expected O, but got Unknown
			//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_11cb: Expected O, but got Unknown
			//IL_11d0: Expected O, but got Unknown
			//IL_1325: Unknown result type (might be due to invalid IL or missing references)
			//IL_132a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1381: Unknown result type (might be due to invalid IL or missing references)
			//IL_1386: Unknown result type (might be due to invalid IL or missing references)
			//IL_1389: Expected O, but got Unknown
			//IL_138e: Expected O, but got Unknown
			//IL_138e: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1400: Unknown result type (might be due to invalid IL or missing references)
			//IL_1410: Unknown result type (might be due to invalid IL or missing references)
			//IL_1420: Unknown result type (might be due to invalid IL or missing references)
			//IL_1449: Expected O, but got Unknown
			//IL_1444: Unknown result type (might be due to invalid IL or missing references)
			//IL_144e: Expected O, but got Unknown
			//IL_144e: Unknown result type (might be due to invalid IL or missing references)
			//IL_145d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1467: Expected O, but got Unknown
			//IL_1462: Unknown result type (might be due to invalid IL or missing references)
			//IL_146c: Expected O, but got Unknown
			//IL_1471: Expected O, but got Unknown
			//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_150b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1528: Unknown result type (might be due to invalid IL or missing references)
			//IL_152d: Unknown result type (might be due to invalid IL or missing references)
			//IL_156a: Unknown result type (might be due to invalid IL or missing references)
			//IL_156f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1572: Expected O, but got Unknown
			//IL_1577: Expected O, but got Unknown
			//IL_1577: Unknown result type (might be due to invalid IL or missing references)
			//IL_1589: Unknown result type (might be due to invalid IL or missing references)
			//IL_1594: Unknown result type (might be due to invalid IL or missing references)
			//IL_1599: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_15b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_15e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1609: Unknown result type (might be due to invalid IL or missing references)
			//IL_1632: Expected O, but got Unknown
			//IL_162d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1637: Expected O, but got Unknown
			//IL_1637: Unknown result type (might be due to invalid IL or missing references)
			//IL_1646: Unknown result type (might be due to invalid IL or missing references)
			//IL_1650: Expected O, but got Unknown
			//IL_164b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1655: Expected O, but got Unknown
			//IL_165a: Expected O, but got Unknown
			//IL_167d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1682: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_16db: Expected O, but got Unknown
			//IL_16e0: Expected O, but got Unknown
			//IL_16e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1702: Unknown result type (might be due to invalid IL or missing references)
			//IL_1712: Unknown result type (might be due to invalid IL or missing references)
			//IL_1722: Unknown result type (might be due to invalid IL or missing references)
			//IL_1732: Unknown result type (might be due to invalid IL or missing references)
			//IL_1742: Unknown result type (might be due to invalid IL or missing references)
			//IL_1752: Unknown result type (might be due to invalid IL or missing references)
			//IL_1762: Unknown result type (might be due to invalid IL or missing references)
			//IL_1772: Unknown result type (might be due to invalid IL or missing references)
			//IL_179b: Expected O, but got Unknown
			//IL_1796: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a0: Expected O, but got Unknown
			//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_17af: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b9: Expected O, but got Unknown
			//IL_17b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_17be: Expected O, but got Unknown
			//IL_17c3: Expected O, but got Unknown
			//IL_1831: Unknown result type (might be due to invalid IL or missing references)
			//IL_1853: Unknown result type (might be due to invalid IL or missing references)
			//IL_1858: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a8: Expected O, but got Unknown
			//IL_18ad: Expected O, but got Unknown
			//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_18bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_18cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_18df: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_190f: Unknown result type (might be due to invalid IL or missing references)
			//IL_191f: Unknown result type (might be due to invalid IL or missing references)
			//IL_192f: Unknown result type (might be due to invalid IL or missing references)
			//IL_193f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1968: Expected O, but got Unknown
			//IL_1963: Unknown result type (might be due to invalid IL or missing references)
			//IL_196d: Expected O, but got Unknown
			//IL_196d: Unknown result type (might be due to invalid IL or missing references)
			//IL_197f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1989: Expected O, but got Unknown
			//IL_1984: Unknown result type (might be due to invalid IL or missing references)
			//IL_198e: Expected O, but got Unknown
			//IL_1993: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(OnboardingView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/OnboardingView.xaml");
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
			string onboardingView_Title = Resources.OnboardingView_Title;
			EqualityToBooleanConverter equalityToBooleanConverter = new EqualityToBooleanConverter();
			ResourceDictionary val2 = new ResourceDictionary();
			BindingExtension val3 = new BindingExtension();
			BindingExtension val4 = new BindingExtension();
			BindingExtension val5 = new BindingExtension();
			BindingExtension val6 = new BindingExtension();
			BindingExtension val7 = new BindingExtension();
			BindingExtension val8 = new BindingExtension();
			BindingExtension val9 = new BindingExtension();
			BindingExtension val10 = new BindingExtension();
			BindingExtension val11 = new BindingExtension();
			BindingExtension val12 = new BindingExtension();
			StaticResourceExtension val13 = new StaticResourceExtension();
			OnboardingType onboardingType = OnboardingType.Address;
			BindingExtension val14 = new BindingExtension();
			OnboardingContentView onboardingContentView = new OnboardingContentView();
			BindingExtension val15 = new BindingExtension();
			BindingExtension val16 = new BindingExtension();
			BindingExtension val17 = new BindingExtension();
			BindingExtension val18 = new BindingExtension();
			BindingExtension val19 = new BindingExtension();
			BindingExtension val20 = new BindingExtension();
			BindingExtension val21 = new BindingExtension();
			BindingExtension val22 = new BindingExtension();
			StaticResourceExtension val23 = new StaticResourceExtension();
			OnboardingType onboardingType2 = OnboardingType.PushNotifications;
			BindingExtension val24 = new BindingExtension();
			OnboardingContentView onboardingContentView2 = new OnboardingContentView();
			BindingExtension val25 = new BindingExtension();
			BindingExtension val26 = new BindingExtension();
			BindingExtension val27 = new BindingExtension();
			BindingExtension val28 = new BindingExtension();
			BindingExtension val29 = new BindingExtension();
			BindingExtension val30 = new BindingExtension();
			BindingExtension val31 = new BindingExtension();
			BindingExtension val32 = new BindingExtension();
			StaticResourceExtension val33 = new StaticResourceExtension();
			OnboardingType onboardingType3 = OnboardingType.LocationServices;
			BindingExtension val34 = new BindingExtension();
			OnboardingContentView onboardingContentView3 = new OnboardingContentView();
			BindingExtension val35 = new BindingExtension();
			BindingExtension val36 = new BindingExtension();
			BindingExtension val37 = new BindingExtension();
			BindingExtension val38 = new BindingExtension();
			BindingExtension val39 = new BindingExtension();
			BindingExtension val40 = new BindingExtension();
			BindingExtension val41 = new BindingExtension();
			BindingExtension val42 = new BindingExtension();
			StaticResourceExtension val43 = new StaticResourceExtension();
			OnboardingType onboardingType4 = OnboardingType.CameraServices;
			BindingExtension val44 = new BindingExtension();
			OnboardingContentView onboardingContentView4 = new OnboardingContentView();
			BindingExtension val45 = new BindingExtension();
			BindingExtension val46 = new BindingExtension();
			BindingExtension val47 = new BindingExtension();
			BindingExtension val48 = new BindingExtension();
			BindingExtension val49 = new BindingExtension();
			BindingExtension val50 = new BindingExtension();
			BindingExtension val51 = new BindingExtension();
			StaticResourceExtension val52 = new StaticResourceExtension();
			OnboardingType onboardingType5 = OnboardingType.TestResultsAndSchedule;
			BindingExtension val53 = new BindingExtension();
			OnboardingContentView onboardingContentView5 = new OnboardingContentView();
			BindingExtension val54 = new BindingExtension();
			BindingExtension val55 = new BindingExtension();
			BindingExtension val56 = new BindingExtension();
			BindingExtension val57 = new BindingExtension();
			BindingExtension val58 = new BindingExtension();
			BindingExtension val59 = new BindingExtension();
			BindingExtension val60 = new BindingExtension();
			StaticResourceExtension val61 = new StaticResourceExtension();
			OnboardingType onboardingType6 = OnboardingType.MonitoringSymptoms;
			BindingExtension val62 = new BindingExtension();
			OnboardingContentView onboardingContentView6 = new OnboardingContentView();
			StackLayout val63 = new StackLayout();
			DynamicResourceExtension val64 = new DynamicResourceExtension();
			StaticResourceExtension val65 = new StaticResourceExtension();
			OnboardingType onboardingType7 = OnboardingType.Address;
			BindingExtension val66 = new BindingExtension();
			string onBoarding_Address_NotCorrect_ = Resources.OnBoarding_Address_NotCorrect_1;
			Span val67 = new Span();
			string onBoarding_Address_NotCorrect_Phone = Resources.OnBoarding_Address_NotCorrect_Phone;
			DynamicResourceExtension val68 = new DynamicResourceExtension();
			Span val69 = new Span();
			string onBoarding_Address_NotCorrect_2 = Resources.OnBoarding_Address_NotCorrect_2;
			Span val70 = new Span();
			FormattedString val71 = new FormattedString();
			BindingExtension val72 = new BindingExtension();
			TapGestureRecognizer val73 = new TapGestureRecognizer();
			Label val74 = new Label();
			StackLayout val75 = new StackLayout();
			StackLayout val76 = new StackLayout();
			ScrollView val77 = new ScrollView();
			StackLayout val78 = new StackLayout();
			BindingExtension val79 = new BindingExtension();
			BindingExtension val80 = new BindingExtension();
			BindingExtension val81 = new BindingExtension();
			ActivityIndicatorView activityIndicatorView = new ActivityIndicatorView();
			Grid val82 = new Grid();
			OnboardingView onboardingView;
			NameScope val83 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(onboardingView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)onboardingView, (INameScope)(object)val83);
			((INameScope)val83).RegisterName("containingView", (object)val76);
			if (((Element)val76).get_StyleId() == null)
			{
				((Element)val76).set_StyleId("containingView");
			}
			containingView = val76;
			((VisualElement)onboardingView).set_Resources(val2);
			val2.Add("EqualityToBoolean", (object)equalityToBooleanConverter);
			((BindableObject)onboardingView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)onboardingView).SetValue(Page.TitleProperty, (object)onboardingView_Title);
			((VisualElement)onboardingView).set_Resources(val2);
			((BindableObject)val78).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val77).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val75).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 32.0, 16.0, 16.0));
			((BindableObject)val75).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val63).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.StartAndExpand);
			val3.set_Path("Header");
			BindingBase val84 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.HeadingProperty, val84);
			val4.set_Path("Description");
			BindingBase val85 = ((IMarkupExtension<BindingBase>)(object)val4).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.TextProperty, val85);
			val5.set_Path("Address");
			BindingBase val86 = ((IMarkupExtension<BindingBase>)(object)val5).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.AddressProperty, val86);
			val6.set_Path("Colour");
			BindingBase val87 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.ColourProperty, val87);
			val7.set_Path("ImageSource");
			BindingBase val88 = ((IMarkupExtension<BindingBase>)(object)val7).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.ImageSourceProperty, val88);
			val8.set_Path("ButtonText");
			BindingBase val89 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.ButtonTextProperty, val89);
			val9.set_Path("PageType");
			BindingBase val90 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.CurrentPageProperty, val90);
			val10.set_Path("NextCommand");
			BindingBase val91 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.OnClickCommandProperty, val91);
			val11.set_Path("AddressHelpPageDescription");
			BindingBase val92 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.AddressHelpPageProperty, val92);
			val12.set_Path("AddressHelpCommand");
			BindingBase val93 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(OnboardingContentView.OnClickAddressHelpCommandProperty, val93);
			val13.set_Key("EqualityToBoolean");
			XamlServiceProvider val94 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 9];
			array[0] = val14;
			array[1] = onboardingContentView;
			array[2] = val63;
			array[3] = val75;
			array[4] = val76;
			array[5] = val77;
			array[6] = val78;
			array[7] = val82;
			array[8] = onboardingView;
			SimpleValueTargetProvider val95 = new SimpleValueTargetProvider(array, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj = (object)val95;
			val94.Add(typeFromHandle, (object)val95);
			val94.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val96 = new XmlNamespaceResolver();
			val96.Add("", "http://xamarin.com/schemas/2014/forms");
			val96.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val96.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val96.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val96.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val96.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val96.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val96.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val94.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val96, typeof(OnboardingView).GetTypeInfo().Assembly));
			val94.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 33)));
			object converter = ((IMarkupExtension)val13).ProvideValue((IServiceProvider)val94);
			val14.set_Converter((IValueConverter)converter);
			val14.set_ConverterParameter((object)onboardingType);
			val14.set_Path("PageType");
			BindingBase val97 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView).SetBinding(VisualElement.IsVisibleProperty, val97);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)onboardingContentView);
			val15.set_Path("Header");
			BindingBase val98 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.HeadingProperty, val98);
			val16.set_Path("Description");
			BindingBase val99 = ((IMarkupExtension<BindingBase>)(object)val16).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.TextProperty, val99);
			val17.set_Path("Colour");
			BindingBase val100 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.ColourProperty, val100);
			val18.set_Path("PageType");
			BindingBase val101 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.CurrentPageProperty, val101);
			val19.set_Path("ImageSource");
			BindingBase val102 = ((IMarkupExtension<BindingBase>)(object)val19).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.ImageSourceProperty, val102);
			val20.set_Path("ButtonText");
			BindingBase val103 = ((IMarkupExtension<BindingBase>)(object)val20).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.ButtonTextProperty, val103);
			val21.set_Path("PermissionEnabled");
			BindingBase val104 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.PermissionEnabledProperty, val104);
			val22.set_Path("NextCommand");
			BindingBase val105 = ((IMarkupExtension<BindingBase>)(object)val22).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(OnboardingContentView.OnClickCommandProperty, val105);
			val23.set_Key("EqualityToBoolean");
			XamlServiceProvider val106 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 9];
			array2[0] = val24;
			array2[1] = onboardingContentView2;
			array2[2] = val63;
			array2[3] = val75;
			array2[4] = val76;
			array2[5] = val77;
			array2[6] = val78;
			array2[7] = val82;
			array2[8] = onboardingView;
			SimpleValueTargetProvider val107 = new SimpleValueTargetProvider(array2, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj2 = (object)val107;
			val106.Add(typeFromHandle3, (object)val107);
			val106.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val108 = new XmlNamespaceResolver();
			val108.Add("", "http://xamarin.com/schemas/2014/forms");
			val108.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val108.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val108.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val108.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val108.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val108.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val108.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val106.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val108, typeof(OnboardingView).GetTypeInfo().Assembly));
			val106.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 33)));
			object converter2 = ((IMarkupExtension)val23).ProvideValue((IServiceProvider)val106);
			val24.set_Converter((IValueConverter)converter2);
			val24.set_ConverterParameter((object)onboardingType2);
			val24.set_Path("PageType");
			BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val24).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView2).SetBinding(VisualElement.IsVisibleProperty, val109);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)onboardingContentView2);
			val25.set_Path("Header");
			BindingBase val110 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.HeadingProperty, val110);
			val26.set_Path("Description");
			BindingBase val111 = ((IMarkupExtension<BindingBase>)(object)val26).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.TextProperty, val111);
			val27.set_Path("Colour");
			BindingBase val112 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.ColourProperty, val112);
			val28.set_Path("PageType");
			BindingBase val113 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.CurrentPageProperty, val113);
			val29.set_Path("PermissionEnabled");
			BindingBase val114 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.PermissionEnabledProperty, val114);
			val30.set_Path("ImageSource");
			BindingBase val115 = ((IMarkupExtension<BindingBase>)(object)val30).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.ImageSourceProperty, val115);
			val31.set_Path("ButtonText");
			BindingBase val116 = ((IMarkupExtension<BindingBase>)(object)val31).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.ButtonTextProperty, val116);
			val32.set_Path("NextCommand");
			BindingBase val117 = ((IMarkupExtension<BindingBase>)(object)val32).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(OnboardingContentView.OnClickCommandProperty, val117);
			val33.set_Key("EqualityToBoolean");
			XamlServiceProvider val118 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 9];
			array3[0] = val34;
			array3[1] = onboardingContentView3;
			array3[2] = val63;
			array3[3] = val75;
			array3[4] = val76;
			array3[5] = val77;
			array3[6] = val78;
			array3[7] = val82;
			array3[8] = onboardingView;
			SimpleValueTargetProvider val119 = new SimpleValueTargetProvider(array3, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj3 = (object)val119;
			val118.Add(typeFromHandle5, (object)val119);
			val118.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val120 = new XmlNamespaceResolver();
			val120.Add("", "http://xamarin.com/schemas/2014/forms");
			val120.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val120.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val120.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val120.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val120.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val120.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val120.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val118.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val120, typeof(OnboardingView).GetTypeInfo().Assembly));
			val118.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(61, 33)));
			object converter3 = ((IMarkupExtension)val33).ProvideValue((IServiceProvider)val118);
			val34.set_Converter((IValueConverter)converter3);
			val34.set_ConverterParameter((object)onboardingType3);
			val34.set_Path("PageType");
			BindingBase val121 = ((IMarkupExtension<BindingBase>)(object)val34).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView3).SetBinding(VisualElement.IsVisibleProperty, val121);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)onboardingContentView3);
			val35.set_Path("Header");
			BindingBase val122 = ((IMarkupExtension<BindingBase>)(object)val35).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.HeadingProperty, val122);
			val36.set_Path("Description");
			BindingBase val123 = ((IMarkupExtension<BindingBase>)(object)val36).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.TextProperty, val123);
			val37.set_Path("Colour");
			BindingBase val124 = ((IMarkupExtension<BindingBase>)(object)val37).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.ColourProperty, val124);
			val38.set_Path("PageType");
			BindingBase val125 = ((IMarkupExtension<BindingBase>)(object)val38).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.CurrentPageProperty, val125);
			val39.set_Path("PermissionEnabled");
			BindingBase val126 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.PermissionEnabledProperty, val126);
			val40.set_Path("ImageSource");
			BindingBase val127 = ((IMarkupExtension<BindingBase>)(object)val40).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.ImageSourceProperty, val127);
			val41.set_Path("ButtonText");
			BindingBase val128 = ((IMarkupExtension<BindingBase>)(object)val41).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.ButtonTextProperty, val128);
			val42.set_Path("NextCommand");
			BindingBase val129 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(OnboardingContentView.OnClickCommandProperty, val129);
			val43.set_Key("EqualityToBoolean");
			XamlServiceProvider val130 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 9];
			array4[0] = val44;
			array4[1] = onboardingContentView4;
			array4[2] = val63;
			array4[3] = val75;
			array4[4] = val76;
			array4[5] = val77;
			array4[6] = val78;
			array4[7] = val82;
			array4[8] = onboardingView;
			SimpleValueTargetProvider val131 = new SimpleValueTargetProvider(array4, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj4 = (object)val131;
			val130.Add(typeFromHandle7, (object)val131);
			val130.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val132 = new XmlNamespaceResolver();
			val132.Add("", "http://xamarin.com/schemas/2014/forms");
			val132.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val132.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val132.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val132.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val132.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val132.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val132.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val130.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val132, typeof(OnboardingView).GetTypeInfo().Assembly));
			val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 33)));
			object converter4 = ((IMarkupExtension)val43).ProvideValue((IServiceProvider)val130);
			val44.set_Converter((IValueConverter)converter4);
			val44.set_ConverterParameter((object)onboardingType4);
			val44.set_Path("PageType");
			BindingBase val133 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView4).SetBinding(VisualElement.IsVisibleProperty, val133);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)onboardingContentView4);
			val45.set_Path("Header");
			BindingBase val134 = ((IMarkupExtension<BindingBase>)(object)val45).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.HeadingProperty, val134);
			val46.set_Path("Description");
			BindingBase val135 = ((IMarkupExtension<BindingBase>)(object)val46).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.TextProperty, val135);
			val47.set_Path("Colour");
			BindingBase val136 = ((IMarkupExtension<BindingBase>)(object)val47).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.ColourProperty, val136);
			val48.set_Path("PageType");
			BindingBase val137 = ((IMarkupExtension<BindingBase>)(object)val48).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.CurrentPageProperty, val137);
			val49.set_Path("ImageSource");
			BindingBase val138 = ((IMarkupExtension<BindingBase>)(object)val49).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.ImageSourceProperty, val138);
			val50.set_Path("ButtonText");
			BindingBase val139 = ((IMarkupExtension<BindingBase>)(object)val50).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.ButtonTextProperty, val139);
			val51.set_Path("NextCommand");
			BindingBase val140 = ((IMarkupExtension<BindingBase>)(object)val51).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(OnboardingContentView.OnClickCommandProperty, val140);
			val52.set_Key("EqualityToBoolean");
			XamlServiceProvider val141 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 9];
			array5[0] = val53;
			array5[1] = onboardingContentView5;
			array5[2] = val63;
			array5[3] = val75;
			array5[4] = val76;
			array5[5] = val77;
			array5[6] = val78;
			array5[7] = val82;
			array5[8] = onboardingView;
			SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array5, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj5 = (object)val142;
			val141.Add(typeFromHandle9, (object)val142);
			val141.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val143 = new XmlNamespaceResolver();
			val143.Add("", "http://xamarin.com/schemas/2014/forms");
			val143.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val143.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val143.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val143.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val143.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val143.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val143.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val141.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val143, typeof(OnboardingView).GetTypeInfo().Assembly));
			val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(84, 33)));
			object converter5 = ((IMarkupExtension)val52).ProvideValue((IServiceProvider)val141);
			val53.set_Converter((IValueConverter)converter5);
			val53.set_ConverterParameter((object)onboardingType5);
			val53.set_Path("PageType");
			BindingBase val144 = ((IMarkupExtension<BindingBase>)(object)val53).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView5).SetBinding(VisualElement.IsVisibleProperty, val144);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)onboardingContentView5);
			val54.set_Path("Header");
			BindingBase val145 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.HeadingProperty, val145);
			val55.set_Path("Description");
			BindingBase val146 = ((IMarkupExtension<BindingBase>)(object)val55).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.TextProperty, val146);
			val56.set_Path("Colour");
			BindingBase val147 = ((IMarkupExtension<BindingBase>)(object)val56).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.ColourProperty, val147);
			val57.set_Path("PageType");
			BindingBase val148 = ((IMarkupExtension<BindingBase>)(object)val57).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.CurrentPageProperty, val148);
			val58.set_Path("ImageSource");
			BindingBase val149 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.ImageSourceProperty, val149);
			val59.set_Path("ButtonText");
			BindingBase val150 = ((IMarkupExtension<BindingBase>)(object)val59).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.ButtonTextProperty, val150);
			val60.set_Path("NextCommand");
			BindingBase val151 = ((IMarkupExtension<BindingBase>)(object)val60).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(OnboardingContentView.OnClickCommandProperty, val151);
			val61.set_Key("EqualityToBoolean");
			XamlServiceProvider val152 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 9];
			array6[0] = val62;
			array6[1] = onboardingContentView6;
			array6[2] = val63;
			array6[3] = val75;
			array6[4] = val76;
			array6[5] = val77;
			array6[6] = val78;
			array6[7] = val82;
			array6[8] = onboardingView;
			SimpleValueTargetProvider val153 = new SimpleValueTargetProvider(array6, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj6 = (object)val153;
			val152.Add(typeFromHandle11, (object)val153);
			val152.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val154 = new XmlNamespaceResolver();
			val154.Add("", "http://xamarin.com/schemas/2014/forms");
			val154.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val154.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val154.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val154.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val154.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val154.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val154.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val152.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val154, typeof(OnboardingView).GetTypeInfo().Assembly));
			val152.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 33)));
			object converter6 = ((IMarkupExtension)val61).ProvideValue((IServiceProvider)val152);
			val62.set_Converter((IValueConverter)converter6);
			val62.set_ConverterParameter((object)onboardingType6);
			val62.set_Path("PageType");
			BindingBase val155 = ((IMarkupExtension<BindingBase>)(object)val62).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingContentView6).SetBinding(VisualElement.IsVisibleProperty, val155);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)onboardingContentView6);
			((Layout<View>)(object)val75).get_Children().Add((View)(object)val63);
			((BindableObject)val74).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.End);
			((BindableObject)val74).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 32.0));
			val64.set_Key("Small");
			XamlServiceProvider val156 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 7];
			array7[0] = val74;
			array7[1] = val75;
			array7[2] = val76;
			array7[3] = val77;
			array7[4] = val78;
			array7[5] = val82;
			array7[6] = onboardingView;
			SimpleValueTargetProvider val157 = new SimpleValueTargetProvider(array7, (object)VisualElement.StyleProperty, (INameScope)(object)val83);
			object obj7 = (object)val157;
			val156.Add(typeFromHandle13, (object)val157);
			val156.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val158 = new XmlNamespaceResolver();
			val158.Add("", "http://xamarin.com/schemas/2014/forms");
			val158.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val158.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val158.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val158.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val158.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val158.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val158.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val156.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val158, typeof(OnboardingView).GetTypeInfo().Assembly));
			val156.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(101, 29)));
			DynamicResource val159 = ((IMarkupExtension<DynamicResource>)(object)val64).ProvideValue((IServiceProvider)val156);
			((IDynamicResourceHandler)val74).SetDynamicResource(VisualElement.StyleProperty, val159.get_Key());
			val65.set_Key("EqualityToBoolean");
			XamlServiceProvider val160 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 8];
			array8[0] = val66;
			array8[1] = val74;
			array8[2] = val75;
			array8[3] = val76;
			array8[4] = val77;
			array8[5] = val78;
			array8[6] = val82;
			array8[7] = onboardingView;
			SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array8, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val83);
			object obj8 = (object)val161;
			val160.Add(typeFromHandle15, (object)val161);
			val160.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val162 = new XmlNamespaceResolver();
			val162.Add("", "http://xamarin.com/schemas/2014/forms");
			val162.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val162.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val162.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val162.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val162.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val162.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val162.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val160.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val162, typeof(OnboardingView).GetTypeInfo().Assembly));
			val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(102, 29)));
			object converter7 = ((IMarkupExtension)val65).ProvideValue((IServiceProvider)val160);
			val66.set_Converter((IValueConverter)converter7);
			val66.set_ConverterParameter((object)onboardingType7);
			val66.set_Path("PageType");
			BindingBase val163 = ((IMarkupExtension<BindingBase>)(object)val66).ProvideValue((IServiceProvider)null);
			((BindableObject)val74).SetBinding(VisualElement.IsVisibleProperty, val163);
			((BindableObject)val67).SetValue(Span.TextProperty, (object)onBoarding_Address_NotCorrect_);
			val71.get_Spans().Add(val67);
			((BindableObject)val69).SetValue(Span.TextProperty, (object)onBoarding_Address_NotCorrect_Phone);
			((BindableObject)val69).SetValue(Span.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val68.set_Key("SecondaryLinkColor");
			XamlServiceProvider val164 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 9];
			array9[0] = val69;
			array9[1] = val71;
			array9[2] = val74;
			array9[3] = val75;
			array9[4] = val76;
			array9[5] = val77;
			array9[6] = val78;
			array9[7] = val82;
			array9[8] = onboardingView;
			SimpleValueTargetProvider val165 = new SimpleValueTargetProvider(array9, (object)Span.TextColorProperty, (INameScope)(object)val83);
			object obj9 = (object)val165;
			val164.Add(typeFromHandle17, (object)val165);
			val164.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val166 = new XmlNamespaceResolver();
			val166.Add("", "http://xamarin.com/schemas/2014/forms");
			val166.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val166.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val166.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val166.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val166.Add("enums", "clr-namespace:HomeQuarantine.Data.Models.Enums;assembly=HomeQuarantine.Data");
			val166.Add("resources", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val166.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val164.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val166, typeof(OnboardingView).GetTypeInfo().Assembly));
			val164.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(106, 145)));
			DynamicResource val167 = ((IMarkupExtension<DynamicResource>)(object)val68).ProvideValue((IServiceProvider)val164);
			((IDynamicResourceHandler)val69).SetDynamicResource(Span.TextColorProperty, val167.get_Key());
			val71.get_Spans().Add(val69);
			((BindableObject)val70).SetValue(Span.TextProperty, (object)onBoarding_Address_NotCorrect_2);
			val71.get_Spans().Add(val70);
			((BindableObject)val74).SetValue(Label.FormattedTextProperty, (object)val71);
			val72.set_Path("CallHelpCommand");
			BindingBase val168 = ((IMarkupExtension<BindingBase>)(object)val72).ProvideValue((IServiceProvider)null);
			((BindableObject)val73).SetBinding(TapGestureRecognizer.CommandProperty, val168);
			((View)val74).get_GestureRecognizers().Add((IGestureRecognizer)(object)val73);
			((Layout<View>)(object)val75).get_Children().Add((View)(object)val74);
			((Layout<View>)(object)val76).get_Children().Add((View)(object)val75);
			val77.set_Content((View)(object)val76);
			((Layout<View>)(object)val78).get_Children().Add((View)(object)val77);
			((ICollection<View>)val82.get_Children()).Add((View)(object)val78);
			val79.set_Path("IsBusy");
			BindingBase val169 = ((IMarkupExtension<BindingBase>)(object)val79).ProvideValue((IServiceProvider)null);
			((BindableObject)activityIndicatorView).SetBinding(ActivityIndicatorView.IsBusyProperty, val169);
			val80.set_Path("IsBusy");
			BindingBase val170 = ((IMarkupExtension<BindingBase>)(object)val80).ProvideValue((IServiceProvider)null);
			((BindableObject)activityIndicatorView).SetBinding(VisualElement.IsVisibleProperty, val170);
			val81.set_Path("BusyMessage");
			BindingBase val171 = ((IMarkupExtension<BindingBase>)(object)val81).ProvideValue((IServiceProvider)null);
			((BindableObject)activityIndicatorView).SetBinding(ActivityIndicatorView.BusyMessageProperty, val171);
			((ICollection<View>)val82.get_Children()).Add((View)(object)activityIndicatorView);
			((BindableObject)onboardingView).SetValue(ContentPage.ContentProperty, (object)val82);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<OnboardingView>(this, typeof(OnboardingView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
		}
	}
}
