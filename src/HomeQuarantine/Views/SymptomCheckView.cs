using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Services.Modals;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/SymptomCheckView.xaml")]
	public class SymptomCheckView : BaseView, IModalPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label symptomTitle;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label symptomSubtitle;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView fever;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView cough;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView shortnessOfBreath;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView soreThroat;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView runnyNose;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView lossOfSmell;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView lossOfTaste;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private SymptomView noneOfTheAbove;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Button submit;

		public bool ShowDismiss => true;

		public SymptomCheckView()
		{
			InitializeComponent();
		}

		public async Task Dismiss()
		{
			await ((NavigableElement)Application.get_Current().get_MainPage()).get_Navigation().PopModalAsync();
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected O, but got Unknown
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got Unknown
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
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected O, but got Unknown
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected O, but got Unknown
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
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
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected O, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected O, but got Unknown
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Expected O, but got Unknown
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_0626: Unknown result type (might be due to invalid IL or missing references)
			//IL_0629: Expected O, but got Unknown
			//IL_062e: Expected O, but got Unknown
			//IL_062e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0650: Unknown result type (might be due to invalid IL or missing references)
			//IL_0660: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0680: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d9: Expected O, but got Unknown
			//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06de: Expected O, but got Unknown
			//IL_06de: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f7: Expected O, but got Unknown
			//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fc: Expected O, but got Unknown
			//IL_0701: Expected O, but got Unknown
			//IL_071d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Unknown result type (might be due to invalid IL or missing references)
			//IL_076f: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0805: Unknown result type (might be due to invalid IL or missing references)
			//IL_080a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0847: Unknown result type (might be due to invalid IL or missing references)
			//IL_084c: Unknown result type (might be due to invalid IL or missing references)
			//IL_084f: Expected O, but got Unknown
			//IL_0854: Expected O, but got Unknown
			//IL_0854: Unknown result type (might be due to invalid IL or missing references)
			//IL_0866: Unknown result type (might be due to invalid IL or missing references)
			//IL_0871: Unknown result type (might be due to invalid IL or missing references)
			//IL_0876: Unknown result type (might be due to invalid IL or missing references)
			//IL_0886: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ff: Expected O, but got Unknown
			//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Expected O, but got Unknown
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0913: Unknown result type (might be due to invalid IL or missing references)
			//IL_091d: Expected O, but got Unknown
			//IL_0918: Unknown result type (might be due to invalid IL or missing references)
			//IL_0922: Expected O, but got Unknown
			//IL_0927: Expected O, but got Unknown
			//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ff: Expected O, but got Unknown
			//IL_0a04: Expected O, but got Unknown
			//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaf: Expected O, but got Unknown
			//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab4: Expected O, but got Unknown
			//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acd: Expected O, but got Unknown
			//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad2: Expected O, but got Unknown
			//IL_0ad7: Expected O, but got Unknown
			//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baf: Expected O, but got Unknown
			//IL_0bb4: Expected O, but got Unknown
			//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5f: Expected O, but got Unknown
			//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c64: Expected O, but got Unknown
			//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c7d: Expected O, but got Unknown
			//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c82: Expected O, but got Unknown
			//IL_0c87: Expected O, but got Unknown
			//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5f: Expected O, but got Unknown
			//IL_0d64: Expected O, but got Unknown
			//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0f: Expected O, but got Unknown
			//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e14: Expected O, but got Unknown
			//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2d: Expected O, but got Unknown
			//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e32: Expected O, but got Unknown
			//IL_0e37: Expected O, but got Unknown
			//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0f: Expected O, but got Unknown
			//IL_0f14: Expected O, but got Unknown
			//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbf: Expected O, but got Unknown
			//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc4: Expected O, but got Unknown
			//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fdd: Expected O, but got Unknown
			//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe2: Expected O, but got Unknown
			//IL_0fe7: Expected O, but got Unknown
			//IL_1075: Unknown result type (might be due to invalid IL or missing references)
			//IL_107a: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_10bf: Expected O, but got Unknown
			//IL_10c4: Expected O, but got Unknown
			//IL_10c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1106: Unknown result type (might be due to invalid IL or missing references)
			//IL_1116: Unknown result type (might be due to invalid IL or missing references)
			//IL_1126: Unknown result type (might be due to invalid IL or missing references)
			//IL_1136: Unknown result type (might be due to invalid IL or missing references)
			//IL_1146: Unknown result type (might be due to invalid IL or missing references)
			//IL_116f: Expected O, but got Unknown
			//IL_116a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1174: Expected O, but got Unknown
			//IL_1174: Unknown result type (might be due to invalid IL or missing references)
			//IL_1183: Unknown result type (might be due to invalid IL or missing references)
			//IL_118d: Expected O, but got Unknown
			//IL_1188: Unknown result type (might be due to invalid IL or missing references)
			//IL_1192: Expected O, but got Unknown
			//IL_1197: Expected O, but got Unknown
			//IL_1225: Unknown result type (might be due to invalid IL or missing references)
			//IL_122a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1267: Unknown result type (might be due to invalid IL or missing references)
			//IL_126c: Unknown result type (might be due to invalid IL or missing references)
			//IL_126f: Expected O, but got Unknown
			//IL_1274: Expected O, but got Unknown
			//IL_1274: Unknown result type (might be due to invalid IL or missing references)
			//IL_1286: Unknown result type (might be due to invalid IL or missing references)
			//IL_1291: Unknown result type (might be due to invalid IL or missing references)
			//IL_1296: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_131f: Expected O, but got Unknown
			//IL_131a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1324: Expected O, but got Unknown
			//IL_1324: Unknown result type (might be due to invalid IL or missing references)
			//IL_1333: Unknown result type (might be due to invalid IL or missing references)
			//IL_133d: Expected O, but got Unknown
			//IL_1338: Unknown result type (might be due to invalid IL or missing references)
			//IL_1342: Expected O, but got Unknown
			//IL_1347: Expected O, but got Unknown
			//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_13da: Unknown result type (might be due to invalid IL or missing references)
			//IL_1417: Unknown result type (might be due to invalid IL or missing references)
			//IL_141c: Unknown result type (might be due to invalid IL or missing references)
			//IL_141f: Expected O, but got Unknown
			//IL_1424: Expected O, but got Unknown
			//IL_1424: Unknown result type (might be due to invalid IL or missing references)
			//IL_1436: Unknown result type (might be due to invalid IL or missing references)
			//IL_1441: Unknown result type (might be due to invalid IL or missing references)
			//IL_1446: Unknown result type (might be due to invalid IL or missing references)
			//IL_1456: Unknown result type (might be due to invalid IL or missing references)
			//IL_1466: Unknown result type (might be due to invalid IL or missing references)
			//IL_1476: Unknown result type (might be due to invalid IL or missing references)
			//IL_1486: Unknown result type (might be due to invalid IL or missing references)
			//IL_1496: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_14cf: Expected O, but got Unknown
			//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d4: Expected O, but got Unknown
			//IL_14d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ed: Expected O, but got Unknown
			//IL_14e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f2: Expected O, but got Unknown
			//IL_14f7: Expected O, but got Unknown
			//IL_15ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f7: Expected O, but got Unknown
			//IL_15fc: Expected O, but got Unknown
			//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_160e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1619: Unknown result type (might be due to invalid IL or missing references)
			//IL_161e: Unknown result type (might be due to invalid IL or missing references)
			//IL_162e: Unknown result type (might be due to invalid IL or missing references)
			//IL_163e: Unknown result type (might be due to invalid IL or missing references)
			//IL_164e: Unknown result type (might be due to invalid IL or missing references)
			//IL_165e: Unknown result type (might be due to invalid IL or missing references)
			//IL_166e: Unknown result type (might be due to invalid IL or missing references)
			//IL_167e: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a7: Expected O, but got Unknown
			//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ac: Expected O, but got Unknown
			//IL_16ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_16bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c5: Expected O, but got Unknown
			//IL_16c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ca: Expected O, but got Unknown
			//IL_16cf: Expected O, but got Unknown
			//IL_1765: Unknown result type (might be due to invalid IL or missing references)
			//IL_17bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1816: Unknown result type (might be due to invalid IL or missing references)
			//IL_1838: Unknown result type (might be due to invalid IL or missing references)
			//IL_183d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1885: Unknown result type (might be due to invalid IL or missing references)
			//IL_188a: Unknown result type (might be due to invalid IL or missing references)
			//IL_188d: Expected O, but got Unknown
			//IL_1892: Expected O, but got Unknown
			//IL_1892: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18af: Unknown result type (might be due to invalid IL or missing references)
			//IL_18b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1904: Unknown result type (might be due to invalid IL or missing references)
			//IL_1914: Unknown result type (might be due to invalid IL or missing references)
			//IL_193d: Expected O, but got Unknown
			//IL_1938: Unknown result type (might be due to invalid IL or missing references)
			//IL_1942: Expected O, but got Unknown
			//IL_1942: Unknown result type (might be due to invalid IL or missing references)
			//IL_1954: Unknown result type (might be due to invalid IL or missing references)
			//IL_195e: Expected O, but got Unknown
			//IL_1959: Unknown result type (might be due to invalid IL or missing references)
			//IL_1963: Expected O, but got Unknown
			//IL_1968: Expected O, but got Unknown
			//IL_1a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a36: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af2: Expected O, but got Unknown
			//IL_1af7: Expected O, but got Unknown
			//IL_1af7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b29: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b49: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b69: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba2: Expected O, but got Unknown
			//IL_1b9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba7: Expected O, but got Unknown
			//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc3: Expected O, but got Unknown
			//IL_1bbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc8: Expected O, but got Unknown
			//IL_1bcd: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(SymptomCheckView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/SymptomCheckView.xaml");
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
			string symptomCheckView_MonitoringSymptoms = Resources.SymptomCheckView_MonitoringSymptoms;
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			string symptomCheckView_AreYouExperiencingAnyNewSymptomsToday = Resources.SymptomCheckView_AreYouExperiencingAnyNewSymptomsToday;
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			Label val3 = new Label();
			string symptomCheckView_SelectAnyOrAllThatApply = Resources.SymptomCheckView_SelectAnyOrAllThatApply;
			Label val4 = new Label();
			StackLayout val5 = new StackLayout();
			StaticResourceExtension val6 = new StaticResourceExtension();
			string symptomType_Fever = Resources.SymptomType_Fever;
			BindingExtension val7 = new BindingExtension();
			BindingExtension val8 = new BindingExtension();
			SymptomView symptomView = new SymptomView();
			StaticResourceExtension val9 = new StaticResourceExtension();
			string symptomType_Cough = Resources.SymptomType_Cough;
			BindingExtension val10 = new BindingExtension();
			BindingExtension val11 = new BindingExtension();
			SymptomView symptomView2 = new SymptomView();
			StaticResourceExtension val12 = new StaticResourceExtension();
			string symptomType_ShortnessOfBreath = Resources.SymptomType_ShortnessOfBreath;
			BindingExtension val13 = new BindingExtension();
			BindingExtension val14 = new BindingExtension();
			SymptomView symptomView3 = new SymptomView();
			StaticResourceExtension val15 = new StaticResourceExtension();
			string symptomType_SoreThroat = Resources.SymptomType_SoreThroat;
			BindingExtension val16 = new BindingExtension();
			BindingExtension val17 = new BindingExtension();
			SymptomView symptomView4 = new SymptomView();
			StaticResourceExtension val18 = new StaticResourceExtension();
			string symptomType_RunnyNose = Resources.SymptomType_RunnyNose;
			BindingExtension val19 = new BindingExtension();
			BindingExtension val20 = new BindingExtension();
			SymptomView symptomView5 = new SymptomView();
			StaticResourceExtension val21 = new StaticResourceExtension();
			string symptomType_LossOfSmell = Resources.SymptomType_LossOfSmell;
			BindingExtension val22 = new BindingExtension();
			BindingExtension val23 = new BindingExtension();
			SymptomView symptomView6 = new SymptomView();
			StaticResourceExtension val24 = new StaticResourceExtension();
			string symptomType_LossOfTaste = Resources.SymptomType_LossOfTaste;
			BindingExtension val25 = new BindingExtension();
			BindingExtension val26 = new BindingExtension();
			SymptomView symptomView7 = new SymptomView();
			StaticResourceExtension val27 = new StaticResourceExtension();
			string symptomCheckView_NoneOfTheAbove = Resources.SymptomCheckView_NoneOfTheAbove;
			BindingExtension val28 = new BindingExtension();
			BindingExtension val29 = new BindingExtension();
			SymptomView symptomView8 = new SymptomView();
			StackLayout val30 = new StackLayout();
			DynamicResourceExtension val31 = new DynamicResourceExtension();
			BindingExtension val32 = new BindingExtension();
			string button_Submit = Resources.Button_Submit;
			BindingExtension val33 = new BindingExtension();
			Button val34 = new Button();
			StackLayout val35 = new StackLayout();
			string monitoringSymptoms_ContactNurse = Resources.MonitoringSymptoms_ContactNurse;
			Span val36 = new Span();
			string monitoringSymptoms_ContactNurseNumber = Resources.MonitoringSymptoms_ContactNurseNumber;
			DynamicResourceExtension val37 = new DynamicResourceExtension();
			Span val38 = new Span();
			string monitoringSymptoms_ContactNurseTime = Resources.MonitoringSymptoms_ContactNurseTime;
			Span val39 = new Span();
			FormattedString val40 = new FormattedString();
			BindingExtension val41 = new BindingExtension();
			TapGestureRecognizer val42 = new TapGestureRecognizer();
			Label val43 = new Label();
			string monitoringSymptoms_SeriouslyUnwell = Resources.MonitoringSymptoms_SeriouslyUnwell;
			Span val44 = new Span();
			string monitoringSymptoms_SeriouslyUnwellNumber = Resources.MonitoringSymptoms_SeriouslyUnwellNumber;
			DynamicResourceExtension val45 = new DynamicResourceExtension();
			Span val46 = new Span();
			string monitoringSymptoms_SeriouslyUnwellDot = Resources.MonitoringSymptoms_SeriouslyUnwellDot;
			Span val47 = new Span();
			FormattedString val48 = new FormattedString();
			BindingExtension val49 = new BindingExtension();
			TapGestureRecognizer val50 = new TapGestureRecognizer();
			Label val51 = new Label();
			StackLayout val52 = new StackLayout();
			StackLayout val53 = new StackLayout();
			ScrollView val54 = new ScrollView();
			StackLayout val55 = new StackLayout();
			BindingExtension val56 = new BindingExtension();
			BindingExtension val57 = new BindingExtension();
			BindingExtension val58 = new BindingExtension();
			ActivityIndicatorView activityIndicatorView = new ActivityIndicatorView();
			Grid val59 = new Grid();
			SymptomCheckView symptomCheckView;
			NameScope val60 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(symptomCheckView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)symptomCheckView, (INameScope)(object)val60);
			((INameScope)val60).RegisterName("containingView", (object)val53);
			if (((Element)val53).get_StyleId() == null)
			{
				((Element)val53).set_StyleId("containingView");
			}
			((INameScope)val60).RegisterName("symptomTitle", (object)val3);
			if (((Element)val3).get_StyleId() == null)
			{
				((Element)val3).set_StyleId("symptomTitle");
			}
			((INameScope)val60).RegisterName("symptomSubtitle", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("symptomSubtitle");
			}
			((INameScope)val60).RegisterName("fever", (object)symptomView);
			if (((Element)symptomView).get_StyleId() == null)
			{
				((Element)symptomView).set_StyleId("fever");
			}
			((INameScope)val60).RegisterName("cough", (object)symptomView2);
			if (((Element)symptomView2).get_StyleId() == null)
			{
				((Element)symptomView2).set_StyleId("cough");
			}
			((INameScope)val60).RegisterName("shortnessOfBreath", (object)symptomView3);
			if (((Element)symptomView3).get_StyleId() == null)
			{
				((Element)symptomView3).set_StyleId("shortnessOfBreath");
			}
			((INameScope)val60).RegisterName("soreThroat", (object)symptomView4);
			if (((Element)symptomView4).get_StyleId() == null)
			{
				((Element)symptomView4).set_StyleId("soreThroat");
			}
			((INameScope)val60).RegisterName("runnyNose", (object)symptomView5);
			if (((Element)symptomView5).get_StyleId() == null)
			{
				((Element)symptomView5).set_StyleId("runnyNose");
			}
			((INameScope)val60).RegisterName("lossOfSmell", (object)symptomView6);
			if (((Element)symptomView6).get_StyleId() == null)
			{
				((Element)symptomView6).set_StyleId("lossOfSmell");
			}
			((INameScope)val60).RegisterName("lossOfTaste", (object)symptomView7);
			if (((Element)symptomView7).get_StyleId() == null)
			{
				((Element)symptomView7).set_StyleId("lossOfTaste");
			}
			((INameScope)val60).RegisterName("noneOfTheAbove", (object)symptomView8);
			if (((Element)symptomView8).get_StyleId() == null)
			{
				((Element)symptomView8).set_StyleId("noneOfTheAbove");
			}
			((INameScope)val60).RegisterName("submit", (object)val34);
			if (((Element)val34).get_StyleId() == null)
			{
				((Element)val34).set_StyleId("submit");
			}
			containingView = val53;
			symptomTitle = val3;
			symptomSubtitle = val4;
			fever = symptomView;
			cough = symptomView2;
			shortnessOfBreath = symptomView3;
			soreThroat = symptomView4;
			runnyNose = symptomView5;
			lossOfSmell = symptomView6;
			lossOfTaste = symptomView7;
			noneOfTheAbove = symptomView8;
			submit = val34;
			((BindableObject)symptomCheckView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)symptomCheckView).SetValue(Page.TitleProperty, (object)symptomCheckView_MonitoringSymptoms);
			((VisualElement)symptomCheckView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)symptomCheckView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val55).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val54).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 16.0));
			((BindableObject)val54).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val5).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val5).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val3).SetValue(Label.TextProperty, (object)symptomCheckView_AreYouExperiencingAnyNewSymptomsToday);
			val2.set_Key("Heading1");
			XamlServiceProvider val61 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 7];
			array[0] = val3;
			array[1] = val5;
			array[2] = val53;
			array[3] = val54;
			array[4] = val55;
			array[5] = val59;
			array[6] = symptomCheckView;
			SimpleValueTargetProvider val62 = new SimpleValueTargetProvider(array, (object)VisualElement.StyleProperty, (INameScope)(object)val60);
			object obj = (object)val62;
			val61.Add(typeFromHandle, (object)val62);
			val61.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val63 = new XmlNamespaceResolver();
			val63.Add("", "http://xamarin.com/schemas/2014/forms");
			val63.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val63.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val63.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val63.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val63.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val63.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val61.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val63, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val61.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 29)));
			DynamicResource val64 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val61);
			((IDynamicResourceHandler)val3).SetDynamicResource(VisualElement.StyleProperty, val64.get_Key());
			((BindableObject)val3).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val3).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val5).get_Children().Add((View)(object)val3);
			((BindableObject)val4).SetValue(Label.TextProperty, (object)symptomCheckView_SelectAnyOrAllThatApply);
			((BindableObject)val4).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val5).get_Children().Add((View)(object)val4);
			((Layout<View>)(object)val53).get_Children().Add((View)(object)val5);
			((BindableObject)val30).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val30).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val30).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 0.0));
			val6.set_Key("faThermometerFull");
			XamlServiceProvider val65 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 7];
			array2[0] = symptomView;
			array2[1] = val30;
			array2[2] = val53;
			array2[3] = val54;
			array2[4] = val55;
			array2[5] = val59;
			array2[6] = symptomCheckView;
			SimpleValueTargetProvider val66 = new SimpleValueTargetProvider(array2, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj2 = (object)val66;
			val65.Add(typeFromHandle3, (object)val66);
			val65.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val67 = new XmlNamespaceResolver();
			val67.Add("", "http://xamarin.com/schemas/2014/forms");
			val67.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val67.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val67.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val67.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val67.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val67.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val65.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val67, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val65.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 29)));
			object obj3 = (symptomView.Icon = (string)((IMarkupExtension)val6).ProvideValue((IServiceProvider)val65));
			((BindableObject)symptomView).SetValue(SymptomView.TextProperty, (object)symptomType_Fever);
			((BindableObject)symptomView).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val7.set_Path("HasFever");
			BindingBase val68 = ((IMarkupExtension<BindingBase>)(object)val7).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView).SetBinding(SymptomView.IsCheckedProperty, val68);
			val8.set_Path("TapFeverCommand");
			BindingBase val69 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView).SetBinding(SymptomView.OnChangeCommandProperty, val69);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView);
			val9.set_Key("faHeadside");
			XamlServiceProvider val70 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 7];
			array3[0] = symptomView2;
			array3[1] = val30;
			array3[2] = val53;
			array3[3] = val54;
			array3[4] = val55;
			array3[5] = val59;
			array3[6] = symptomCheckView;
			SimpleValueTargetProvider val71 = new SimpleValueTargetProvider(array3, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj4 = (object)val71;
			val70.Add(typeFromHandle5, (object)val71);
			val70.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val72 = new XmlNamespaceResolver();
			val72.Add("", "http://xamarin.com/schemas/2014/forms");
			val72.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val72.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val72.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val72.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val72.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val72.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val70.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val72, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val70.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 29)));
			object obj5 = (symptomView2.Icon = (string)((IMarkupExtension)val9).ProvideValue((IServiceProvider)val70));
			((BindableObject)symptomView2).SetValue(SymptomView.TextProperty, (object)symptomType_Cough);
			((BindableObject)symptomView2).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val10.set_Path("HasCough");
			BindingBase val73 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView2).SetBinding(SymptomView.IsCheckedProperty, val73);
			val11.set_Path("TapCoughCommand");
			BindingBase val74 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView2).SetBinding(SymptomView.OnChangeCommandProperty, val74);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView2);
			val12.set_Key("faLungs");
			XamlServiceProvider val75 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 7];
			array4[0] = symptomView3;
			array4[1] = val30;
			array4[2] = val53;
			array4[3] = val54;
			array4[4] = val55;
			array4[5] = val59;
			array4[6] = symptomCheckView;
			SimpleValueTargetProvider val76 = new SimpleValueTargetProvider(array4, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj6 = (object)val76;
			val75.Add(typeFromHandle7, (object)val76);
			val75.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val77 = new XmlNamespaceResolver();
			val77.Add("", "http://xamarin.com/schemas/2014/forms");
			val77.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val77.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val77.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val77.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val77.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val77.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val75.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val77, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val75.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 29)));
			object obj7 = (symptomView3.Icon = (string)((IMarkupExtension)val12).ProvideValue((IServiceProvider)val75));
			((BindableObject)symptomView3).SetValue(SymptomView.TextProperty, (object)symptomType_ShortnessOfBreath);
			((BindableObject)symptomView3).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val13.set_Path("HasShortnessOfBreath");
			BindingBase val78 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView3).SetBinding(SymptomView.IsCheckedProperty, val78);
			val14.set_Path("TapShortnessOfBreathCommand");
			BindingBase val79 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView3).SetBinding(SymptomView.OnChangeCommandProperty, val79);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView3);
			val15.set_Key("faBullseye");
			XamlServiceProvider val80 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 7];
			array5[0] = symptomView4;
			array5[1] = val30;
			array5[2] = val53;
			array5[3] = val54;
			array5[4] = val55;
			array5[5] = val59;
			array5[6] = symptomCheckView;
			SimpleValueTargetProvider val81 = new SimpleValueTargetProvider(array5, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj8 = (object)val81;
			val80.Add(typeFromHandle9, (object)val81);
			val80.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val82 = new XmlNamespaceResolver();
			val82.Add("", "http://xamarin.com/schemas/2014/forms");
			val82.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val82.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val82.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val82.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val82.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val82.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val80.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val82, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val80.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 29)));
			object obj9 = (symptomView4.Icon = (string)((IMarkupExtension)val15).ProvideValue((IServiceProvider)val80));
			((BindableObject)symptomView4).SetValue(SymptomView.TextProperty, (object)symptomType_SoreThroat);
			((BindableObject)symptomView4).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val16.set_Path("HasSoreThroat");
			BindingBase val83 = ((IMarkupExtension<BindingBase>)(object)val16).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView4).SetBinding(SymptomView.IsCheckedProperty, val83);
			val17.set_Path("TapSoreThroatCommand");
			BindingBase val84 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView4).SetBinding(SymptomView.OnChangeCommandProperty, val84);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView4);
			val18.set_Key("faTint");
			XamlServiceProvider val85 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 7];
			array6[0] = symptomView5;
			array6[1] = val30;
			array6[2] = val53;
			array6[3] = val54;
			array6[4] = val55;
			array6[5] = val59;
			array6[6] = symptomCheckView;
			SimpleValueTargetProvider val86 = new SimpleValueTargetProvider(array6, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj10 = (object)val86;
			val85.Add(typeFromHandle11, (object)val86);
			val85.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val87 = new XmlNamespaceResolver();
			val87.Add("", "http://xamarin.com/schemas/2014/forms");
			val87.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val87.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val87.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val87.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val87.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val87.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val85.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val87, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val85.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 29)));
			object obj11 = (symptomView5.Icon = (string)((IMarkupExtension)val18).ProvideValue((IServiceProvider)val85));
			((BindableObject)symptomView5).SetValue(SymptomView.TextProperty, (object)symptomType_RunnyNose);
			((BindableObject)symptomView5).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val19.set_Path("HasRunnyNose");
			BindingBase val88 = ((IMarkupExtension<BindingBase>)(object)val19).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView5).SetBinding(SymptomView.IsCheckedProperty, val88);
			val20.set_Path("TapRunnyNoseCommand");
			BindingBase val89 = ((IMarkupExtension<BindingBase>)(object)val20).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView5).SetBinding(SymptomView.OnChangeCommandProperty, val89);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView5);
			val21.set_Key("faWind");
			XamlServiceProvider val90 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 7];
			array7[0] = symptomView6;
			array7[1] = val30;
			array7[2] = val53;
			array7[3] = val54;
			array7[4] = val55;
			array7[5] = val59;
			array7[6] = symptomCheckView;
			SimpleValueTargetProvider val91 = new SimpleValueTargetProvider(array7, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj12 = (object)val91;
			val90.Add(typeFromHandle13, (object)val91);
			val90.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val92 = new XmlNamespaceResolver();
			val92.Add("", "http://xamarin.com/schemas/2014/forms");
			val92.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val92.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val92.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val92.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val92.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val92.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val90.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val92, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val90.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(82, 29)));
			object obj13 = (symptomView6.Icon = (string)((IMarkupExtension)val21).ProvideValue((IServiceProvider)val90));
			((BindableObject)symptomView6).SetValue(SymptomView.TextProperty, (object)symptomType_LossOfSmell);
			((BindableObject)symptomView6).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val22.set_Path("HasLossOfSmell");
			BindingBase val93 = ((IMarkupExtension<BindingBase>)(object)val22).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView6).SetBinding(SymptomView.IsCheckedProperty, val93);
			val23.set_Path("TapLossOfSmellCommand");
			BindingBase val94 = ((IMarkupExtension<BindingBase>)(object)val23).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView6).SetBinding(SymptomView.OnChangeCommandProperty, val94);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView6);
			val24.set_Key("faUtensils");
			XamlServiceProvider val95 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 7];
			array8[0] = symptomView7;
			array8[1] = val30;
			array8[2] = val53;
			array8[3] = val54;
			array8[4] = val55;
			array8[5] = val59;
			array8[6] = symptomCheckView;
			SimpleValueTargetProvider val96 = new SimpleValueTargetProvider(array8, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj14 = (object)val96;
			val95.Add(typeFromHandle15, (object)val96);
			val95.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val97 = new XmlNamespaceResolver();
			val97.Add("", "http://xamarin.com/schemas/2014/forms");
			val97.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val97.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val97.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val97.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val97.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val97.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val95.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val97, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val95.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(91, 29)));
			object obj15 = (symptomView7.Icon = (string)((IMarkupExtension)val24).ProvideValue((IServiceProvider)val95));
			((BindableObject)symptomView7).SetValue(SymptomView.TextProperty, (object)symptomType_LossOfTaste);
			((BindableObject)symptomView7).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val25.set_Path("HasLossOfTaste");
			BindingBase val98 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView7).SetBinding(SymptomView.IsCheckedProperty, val98);
			val26.set_Path("TapLossOfTasteCommand");
			BindingBase val99 = ((IMarkupExtension<BindingBase>)(object)val26).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView7).SetBinding(SymptomView.OnChangeCommandProperty, val99);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView7);
			val27.set_Key("faSmile");
			XamlServiceProvider val100 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 7];
			array9[0] = symptomView8;
			array9[1] = val30;
			array9[2] = val53;
			array9[3] = val54;
			array9[4] = val55;
			array9[5] = val59;
			array9[6] = symptomCheckView;
			SimpleValueTargetProvider val101 = new SimpleValueTargetProvider(array9, (object)SymptomView.IconProperty, (INameScope)(object)val60);
			object obj16 = (object)val101;
			val100.Add(typeFromHandle17, (object)val101);
			val100.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val102 = new XmlNamespaceResolver();
			val102.Add("", "http://xamarin.com/schemas/2014/forms");
			val102.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val102.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val102.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val102.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val102.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val102.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val100.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val102, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val100.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(100, 29)));
			object obj17 = (symptomView8.Icon = (string)((IMarkupExtension)val27).ProvideValue((IServiceProvider)val100));
			((BindableObject)symptomView8).SetValue(SymptomView.TextProperty, (object)symptomCheckView_NoneOfTheAbove);
			((BindableObject)symptomView8).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			val28.set_Path("HasNoSymptoms");
			BindingBase val103 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView8).SetBinding(SymptomView.IsCheckedProperty, val103);
			val29.set_Path("TapNoSymptomsCommand");
			BindingBase val104 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)null);
			((BindableObject)symptomView8).SetBinding(SymptomView.OnChangeCommandProperty, val104);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)symptomView8);
			((Layout<View>)(object)val53).get_Children().Add((View)(object)val30);
			((BindableObject)val35).SetValue(StackLayout.SpacingProperty, (object)0.0);
			val31.set_Key("LargeButtonStyle");
			XamlServiceProvider val105 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 7];
			array10[0] = val34;
			array10[1] = val35;
			array10[2] = val53;
			array10[3] = val54;
			array10[4] = val55;
			array10[5] = val59;
			array10[6] = symptomCheckView;
			SimpleValueTargetProvider val106 = new SimpleValueTargetProvider(array10, (object)VisualElement.StyleProperty, (INameScope)(object)val60);
			object obj18 = (object)val106;
			val105.Add(typeFromHandle19, (object)val106);
			val105.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val107 = new XmlNamespaceResolver();
			val107.Add("", "http://xamarin.com/schemas/2014/forms");
			val107.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val107.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val107.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val107.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val107.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val107.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val105.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val107, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val105.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(112, 29)));
			DynamicResource val108 = ((IMarkupExtension<DynamicResource>)(object)val31).ProvideValue((IServiceProvider)val105);
			((IDynamicResourceHandler)val34).SetDynamicResource(VisualElement.StyleProperty, val108.get_Key());
			val32.set_Path("ButtonColour");
			BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val32).ProvideValue((IServiceProvider)null);
			((BindableObject)val34).SetBinding(VisualElement.BackgroundColorProperty, val109);
			((BindableObject)val34).SetValue(Button.TextProperty, (object)button_Submit);
			val33.set_Path("SubmitCommand");
			BindingBase val110 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)null);
			((BindableObject)val34).SetBinding(Button.CommandProperty, val110);
			((BindableObject)val34).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val35).get_Children().Add((View)(object)val34);
			((Layout<View>)(object)val53).get_Children().Add((View)(object)val35);
			((BindableObject)val43).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((BindableObject)val43).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val36).SetValue(Span.TextProperty, (object)monitoringSymptoms_ContactNurse);
			val40.get_Spans().Add(val36);
			((BindableObject)val38).SetValue(Span.TextProperty, (object)monitoringSymptoms_ContactNurseNumber);
			((BindableObject)val38).SetValue(Span.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val37.set_Key("SecondaryLinkColor");
			XamlServiceProvider val111 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 9];
			array11[0] = val38;
			array11[1] = val40;
			array11[2] = val43;
			array11[3] = val52;
			array11[4] = val53;
			array11[5] = val54;
			array11[6] = val55;
			array11[7] = val59;
			array11[8] = symptomCheckView;
			SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array11, (object)Span.TextColorProperty, (INameScope)(object)val60);
			object obj19 = (object)val112;
			val111.Add(typeFromHandle21, (object)val112);
			val111.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val113 = new XmlNamespaceResolver();
			val113.Add("", "http://xamarin.com/schemas/2014/forms");
			val113.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val113.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val113.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val113.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val113.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val113.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val111.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val113, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(131, 41)));
			DynamicResource val114 = ((IMarkupExtension<DynamicResource>)(object)val37).ProvideValue((IServiceProvider)val111);
			((IDynamicResourceHandler)val38).SetDynamicResource(Span.TextColorProperty, val114.get_Key());
			val40.get_Spans().Add(val38);
			((BindableObject)val39).SetValue(Span.TextProperty, (object)monitoringSymptoms_ContactNurseTime);
			val40.get_Spans().Add(val39);
			((BindableObject)val43).SetValue(Label.FormattedTextProperty, (object)val40);
			val41.set_Path("CallHelpCommand");
			BindingBase val115 = ((IMarkupExtension<BindingBase>)(object)val41).ProvideValue((IServiceProvider)null);
			((BindableObject)val42).SetBinding(TapGestureRecognizer.CommandProperty, val115);
			((View)val43).get_GestureRecognizers().Add((IGestureRecognizer)(object)val42);
			((Layout<View>)(object)val52).get_Children().Add((View)(object)val43);
			((BindableObject)val51).SetValue(View.MarginProperty, (object)new Thickness(16.0, 8.0, 16.0, 4.0));
			((BindableObject)val51).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val44).SetValue(Span.TextProperty, (object)monitoringSymptoms_SeriouslyUnwell);
			val48.get_Spans().Add(val44);
			((BindableObject)val46).SetValue(Span.TextProperty, (object)monitoringSymptoms_SeriouslyUnwellNumber);
			((BindableObject)val46).SetValue(Span.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val45.set_Key("SecondaryLinkColor");
			XamlServiceProvider val116 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 9];
			array12[0] = val46;
			array12[1] = val48;
			array12[2] = val51;
			array12[3] = val52;
			array12[4] = val53;
			array12[5] = val54;
			array12[6] = val55;
			array12[7] = val59;
			array12[8] = symptomCheckView;
			SimpleValueTargetProvider val117 = new SimpleValueTargetProvider(array12, (object)Span.TextColorProperty, (INameScope)(object)val60);
			object obj20 = (object)val117;
			val116.Add(typeFromHandle23, (object)val117);
			val116.Add(typeof(IReferenceProvider), obj20);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val118 = new XmlNamespaceResolver();
			val118.Add("", "http://xamarin.com/schemas/2014/forms");
			val118.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val118.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val118.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val118.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val118.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val118.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val116.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val118, typeof(SymptomCheckView).GetTypeInfo().Assembly));
			val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(151, 41)));
			DynamicResource val119 = ((IMarkupExtension<DynamicResource>)(object)val45).ProvideValue((IServiceProvider)val116);
			((IDynamicResourceHandler)val46).SetDynamicResource(Span.TextColorProperty, val119.get_Key());
			val48.get_Spans().Add(val46);
			((BindableObject)val47).SetValue(Span.TextProperty, (object)monitoringSymptoms_SeriouslyUnwellDot);
			val48.get_Spans().Add(val47);
			((BindableObject)val51).SetValue(Label.FormattedTextProperty, (object)val48);
			val49.set_Path("CallHelpWhenUnwellCommand");
			BindingBase val120 = ((IMarkupExtension<BindingBase>)(object)val49).ProvideValue((IServiceProvider)null);
			((BindableObject)val50).SetBinding(TapGestureRecognizer.CommandProperty, val120);
			((View)val51).get_GestureRecognizers().Add((IGestureRecognizer)(object)val50);
			((Layout<View>)(object)val52).get_Children().Add((View)(object)val51);
			((Layout<View>)(object)val53).get_Children().Add((View)(object)val52);
			val54.set_Content((View)(object)val53);
			((Layout<View>)(object)val55).get_Children().Add((View)(object)val54);
			((ICollection<View>)val59.get_Children()).Add((View)(object)val55);
			val56.set_Path("IsBusy");
			BindingBase val121 = ((IMarkupExtension<BindingBase>)(object)val56).ProvideValue((IServiceProvider)null);
			((BindableObject)activityIndicatorView).SetBinding(ActivityIndicatorView.IsBusyProperty, val121);
			val57.set_Path("IsBusy");
			BindingBase val122 = ((IMarkupExtension<BindingBase>)(object)val57).ProvideValue((IServiceProvider)null);
			((BindableObject)activityIndicatorView).SetBinding(VisualElement.IsVisibleProperty, val122);
			val58.set_Path("BusyMessage");
			BindingBase val123 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)null);
			((BindableObject)activityIndicatorView).SetBinding(ActivityIndicatorView.BusyMessageProperty, val123);
			((ICollection<View>)val59.get_Children()).Add((View)(object)activityIndicatorView);
			((BindableObject)symptomCheckView).SetValue(ContentPage.ContentProperty, (object)val59);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<SymptomCheckView>(this, typeof(SymptomCheckView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			symptomTitle = NameScopeExtensions.FindByName<Label>((Element)(object)this, "symptomTitle");
			symptomSubtitle = NameScopeExtensions.FindByName<Label>((Element)(object)this, "symptomSubtitle");
			fever = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "fever");
			cough = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "cough");
			shortnessOfBreath = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "shortnessOfBreath");
			soreThroat = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "soreThroat");
			runnyNose = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "runnyNose");
			lossOfSmell = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "lossOfSmell");
			lossOfTaste = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "lossOfTaste");
			noneOfTheAbove = NameScopeExtensions.FindByName<SymptomView>((Element)(object)this, "noneOfTheAbove");
			submit = NameScopeExtensions.FindByName<Button>((Element)(object)this, "submit");
		}
	}
}
