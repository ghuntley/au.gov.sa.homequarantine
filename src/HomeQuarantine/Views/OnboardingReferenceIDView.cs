using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using FFImageLoading.Forms;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/OnboardingReferenceIDView.xaml")]
	public class OnboardingReferenceIDView : BaseView, IMainView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private BoxView border;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label headingLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private TintedCachedImage image;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label textLabel;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label errorMessage;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Button button;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private OnboardingIndicatorView indicator;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label validatingMessage;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label ShowSuccessMessage;

		public OnboardingReferenceIDView()
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
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
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
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
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
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
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
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Expected O, but got Unknown
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Unknown result type (might be due to invalid IL or missing references)
			//IL_050b: Expected O, but got Unknown
			//IL_0510: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bb: Expected O, but got Unknown
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c0: Expected O, but got Unknown
			//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d9: Expected O, but got Unknown
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Expected O, but got Unknown
			//IL_05e3: Expected O, but got Unknown
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0642: Unknown result type (might be due to invalid IL or missing references)
			//IL_0684: Unknown result type (might be due to invalid IL or missing references)
			//IL_0689: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Expected O, but got Unknown
			//IL_0691: Expected O, but got Unknown
			//IL_0691: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0703: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Expected O, but got Unknown
			//IL_0737: Unknown result type (might be due to invalid IL or missing references)
			//IL_0741: Expected O, but got Unknown
			//IL_0741: Unknown result type (might be due to invalid IL or missing references)
			//IL_0750: Unknown result type (might be due to invalid IL or missing references)
			//IL_075a: Expected O, but got Unknown
			//IL_0755: Unknown result type (might be due to invalid IL or missing references)
			//IL_075f: Expected O, but got Unknown
			//IL_0764: Expected O, but got Unknown
			//IL_0795: Unknown result type (might be due to invalid IL or missing references)
			//IL_079a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e4: Expected O, but got Unknown
			//IL_07e9: Expected O, but got Unknown
			//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0806: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_081b: Unknown result type (might be due to invalid IL or missing references)
			//IL_082b: Unknown result type (might be due to invalid IL or missing references)
			//IL_083b: Unknown result type (might be due to invalid IL or missing references)
			//IL_084b: Unknown result type (might be due to invalid IL or missing references)
			//IL_085b: Unknown result type (might be due to invalid IL or missing references)
			//IL_086b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0894: Expected O, but got Unknown
			//IL_088f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0899: Expected O, but got Unknown
			//IL_0899: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b2: Expected O, but got Unknown
			//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b7: Expected O, but got Unknown
			//IL_08bc: Expected O, but got Unknown
			//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0912: Unknown result type (might be due to invalid IL or missing references)
			//IL_096c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0982: Unknown result type (might be due to invalid IL or missing references)
			//IL_09af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba2: Expected O, but got Unknown
			//IL_0ba7: Expected O, but got Unknown
			//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c52: Expected O, but got Unknown
			//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c57: Expected O, but got Unknown
			//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c70: Expected O, but got Unknown
			//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c75: Expected O, but got Unknown
			//IL_0c7a: Expected O, but got Unknown
			//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d53: Expected O, but got Unknown
			//IL_0d58: Expected O, but got Unknown
			//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e03: Expected O, but got Unknown
			//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e08: Expected O, but got Unknown
			//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e21: Expected O, but got Unknown
			//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e26: Expected O, but got Unknown
			//IL_0e2b: Expected O, but got Unknown
			//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eee: Expected O, but got Unknown
			//IL_0ef3: Expected O, but got Unknown
			//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f9e: Expected O, but got Unknown
			//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa3: Expected O, but got Unknown
			//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbf: Expected O, but got Unknown
			//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc4: Expected O, but got Unknown
			//IL_0fc9: Expected O, but got Unknown
			//IL_1096: Unknown result type (might be due to invalid IL or missing references)
			//IL_109b: Unknown result type (might be due to invalid IL or missing references)
			//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e5: Expected O, but got Unknown
			//IL_10ea: Expected O, but got Unknown
			//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1107: Unknown result type (might be due to invalid IL or missing references)
			//IL_110c: Unknown result type (might be due to invalid IL or missing references)
			//IL_111c: Unknown result type (might be due to invalid IL or missing references)
			//IL_112c: Unknown result type (might be due to invalid IL or missing references)
			//IL_113c: Unknown result type (might be due to invalid IL or missing references)
			//IL_114c: Unknown result type (might be due to invalid IL or missing references)
			//IL_115c: Unknown result type (might be due to invalid IL or missing references)
			//IL_116c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1195: Expected O, but got Unknown
			//IL_1190: Unknown result type (might be due to invalid IL or missing references)
			//IL_119a: Expected O, but got Unknown
			//IL_119a: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b3: Expected O, but got Unknown
			//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b8: Expected O, but got Unknown
			//IL_11bd: Expected O, but got Unknown
			//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_124e: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1304: Unknown result type (might be due to invalid IL or missing references)
			//IL_1309: Unknown result type (might be due to invalid IL or missing references)
			//IL_130c: Expected O, but got Unknown
			//IL_1311: Expected O, but got Unknown
			//IL_1311: Unknown result type (might be due to invalid IL or missing references)
			//IL_1323: Unknown result type (might be due to invalid IL or missing references)
			//IL_132e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1333: Unknown result type (might be due to invalid IL or missing references)
			//IL_1343: Unknown result type (might be due to invalid IL or missing references)
			//IL_1353: Unknown result type (might be due to invalid IL or missing references)
			//IL_1363: Unknown result type (might be due to invalid IL or missing references)
			//IL_1373: Unknown result type (might be due to invalid IL or missing references)
			//IL_1383: Unknown result type (might be due to invalid IL or missing references)
			//IL_1393: Unknown result type (might be due to invalid IL or missing references)
			//IL_13bc: Expected O, but got Unknown
			//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_13c1: Expected O, but got Unknown
			//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13da: Expected O, but got Unknown
			//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_13df: Expected O, but got Unknown
			//IL_13e4: Expected O, but got Unknown
			//IL_1424: Unknown result type (might be due to invalid IL or missing references)
			//IL_1443: Unknown result type (might be due to invalid IL or missing references)
			//IL_148c: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_150b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1510: Unknown result type (might be due to invalid IL or missing references)
			//IL_1539: Unknown result type (might be due to invalid IL or missing references)
			//IL_153e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1541: Expected O, but got Unknown
			//IL_1546: Expected O, but got Unknown
			//IL_1546: Unknown result type (might be due to invalid IL or missing references)
			//IL_1558: Unknown result type (might be due to invalid IL or missing references)
			//IL_1563: Unknown result type (might be due to invalid IL or missing references)
			//IL_1568: Unknown result type (might be due to invalid IL or missing references)
			//IL_1578: Unknown result type (might be due to invalid IL or missing references)
			//IL_1588: Unknown result type (might be due to invalid IL or missing references)
			//IL_1598: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f1: Expected O, but got Unknown
			//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f6: Expected O, but got Unknown
			//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1605: Unknown result type (might be due to invalid IL or missing references)
			//IL_160f: Expected O, but got Unknown
			//IL_160a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1614: Expected O, but got Unknown
			//IL_1619: Expected O, but got Unknown
			//IL_163e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1678: Unknown result type (might be due to invalid IL or missing references)
			//IL_168e: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1726: Unknown result type (might be due to invalid IL or missing references)
			//IL_1772: Unknown result type (might be due to invalid IL or missing references)
			//IL_1777: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a8: Expected O, but got Unknown
			//IL_17ad: Expected O, but got Unknown
			//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_17cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_17df: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_180f: Unknown result type (might be due to invalid IL or missing references)
			//IL_181f: Unknown result type (might be due to invalid IL or missing references)
			//IL_182f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1858: Expected O, but got Unknown
			//IL_1853: Unknown result type (might be due to invalid IL or missing references)
			//IL_185d: Expected O, but got Unknown
			//IL_185d: Unknown result type (might be due to invalid IL or missing references)
			//IL_186f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1879: Expected O, but got Unknown
			//IL_1874: Unknown result type (might be due to invalid IL or missing references)
			//IL_187e: Expected O, but got Unknown
			//IL_1883: Expected O, but got Unknown
			//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_190e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1969: Unknown result type (might be due to invalid IL or missing references)
			//IL_196e: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a9: Expected O, but got Unknown
			//IL_19ae: Expected O, but got Unknown
			//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_19c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_19d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_19f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a30: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a59: Expected O, but got Unknown
			//IL_1a54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a5e: Expected O, but got Unknown
			//IL_1a5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a70: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a7a: Expected O, but got Unknown
			//IL_1a75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a7f: Expected O, but got Unknown
			//IL_1a84: Expected O, but got Unknown
			//IL_1a9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ada: Unknown result type (might be due to invalid IL or missing references)
			//IL_1add: Expected O, but got Unknown
			//IL_1ae2: Expected O, but got Unknown
			//IL_1ae2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b04: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b44: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b64: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8d: Expected O, but got Unknown
			//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b92: Expected O, but got Unknown
			//IL_1b92: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bae: Expected O, but got Unknown
			//IL_1ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb3: Expected O, but got Unknown
			//IL_1bb8: Expected O, but got Unknown
			//IL_1be5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c2f: Expected O, but got Unknown
			//IL_1c34: Expected O, but got Unknown
			//IL_1c34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c56: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c66: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c76: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ca6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cdf: Expected O, but got Unknown
			//IL_1cda: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce4: Expected O, but got Unknown
			//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d00: Expected O, but got Unknown
			//IL_1cfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d05: Expected O, but got Unknown
			//IL_1d0a: Expected O, but got Unknown
			//IL_1d16: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d4d: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/OnboardingReferenceIDView.xaml");
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
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			BoxView val4 = new BoxView();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			string onboardingView_WelcomeToHomeQuarantine = Resources.OnboardingView_WelcomeToHomeQuarantine;
			Label val6 = new Label();
			TintedCachedImage tintedCachedImage = new TintedCachedImage();
			StackLayout val7 = new StackLayout();
			string referenceIDView_EnterYourSAPathologyReferenceNumber = Resources.ReferenceIDView_EnterYourSAPathologyReferenceNumber;
			Label val8 = new Label();
			BindingExtension val9 = new BindingExtension();
			BindingExtension val10 = new BindingExtension();
			Entry val11 = new Entry();
			string referenceIDView_IncorrectReferenceNumber = Resources.ReferenceIDView_IncorrectReferenceNumber;
			BindingExtension val12 = new BindingExtension();
			StaticResourceExtension val13 = new StaticResourceExtension();
			Label val14 = new Label();
			BindingExtension val15 = new BindingExtension();
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			string referenceIDView_PleaseTryAgain = Resources.ReferenceIDView_PleaseTryAgain;
			Span val17 = new Span();
			string referenceIDView_ContactNumber = Resources.ReferenceIDView_ContactNumber;
			DynamicResourceExtension val18 = new DynamicResourceExtension();
			Span val19 = new Span();
			string referenceIDView_ContactTime = Resources.ReferenceIDView_ContactTime;
			Span val20 = new Span();
			FormattedString val21 = new FormattedString();
			BindingExtension val22 = new BindingExtension();
			TapGestureRecognizer val23 = new TapGestureRecognizer();
			Label val24 = new Label();
			BindingExtension val25 = new BindingExtension();
			string button_Next = Resources.Button_Next;
			DynamicResourceExtension val26 = new DynamicResourceExtension();
			BindingExtension val27 = new BindingExtension();
			Button val28 = new Button();
			BindingExtension val29 = new BindingExtension();
			OnboardingIndicatorView onboardingIndicatorView = new OnboardingIndicatorView();
			StackLayout val30 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			string onboardingView_ReferenceID_SentBySms = Resources.OnboardingView_ReferenceID_SentBySms;
			DynamicResourceExtension val31 = new DynamicResourceExtension();
			Label val32 = new Label();
			StackLayout val33 = new StackLayout();
			ScrollView val34 = new ScrollView();
			StackLayout val35 = new StackLayout();
			BindingExtension val36 = new BindingExtension();
			StackLayout val37 = new StackLayout();
			DynamicResourceExtension val38 = new DynamicResourceExtension();
			BindingExtension val39 = new BindingExtension();
			ActivityIndicator val40 = new ActivityIndicator();
			string referenceIDView_ValidatingYourReferenceID = Resources.ReferenceIDView_ValidatingYourReferenceID;
			Label val41 = new Label();
			StackLayout val42 = new StackLayout();
			ShadowFrame shadowFrame2 = new ShadowFrame();
			DynamicResourceExtension val43 = new DynamicResourceExtension();
			BindingExtension val44 = new BindingExtension();
			StaticResourceExtension val45 = new StaticResourceExtension();
			DynamicResourceExtension val46 = new DynamicResourceExtension();
			Label val47 = new Label();
			string referenceIDView_YourReferenceIDIsValid = Resources.ReferenceIDView_YourReferenceIDIsValid;
			Label val48 = new Label();
			StackLayout val49 = new StackLayout();
			ShadowFrame shadowFrame3 = new ShadowFrame();
			Grid val50 = new Grid();
			OnboardingReferenceIDView onboardingReferenceIDView;
			NameScope val51 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(onboardingReferenceIDView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)onboardingReferenceIDView, (INameScope)(object)val51);
			((INameScope)val51).RegisterName("containingView", (object)val33);
			if (((Element)val33).get_StyleId() == null)
			{
				((Element)val33).set_StyleId("containingView");
			}
			((INameScope)val51).RegisterName("border", (object)val4);
			if (((Element)val4).get_StyleId() == null)
			{
				((Element)val4).set_StyleId("border");
			}
			((INameScope)val51).RegisterName("headingLabel", (object)val6);
			if (((Element)val6).get_StyleId() == null)
			{
				((Element)val6).set_StyleId("headingLabel");
			}
			((INameScope)val51).RegisterName("image", (object)tintedCachedImage);
			if (((Element)tintedCachedImage).get_StyleId() == null)
			{
				((Element)tintedCachedImage).set_StyleId("image");
			}
			((INameScope)val51).RegisterName("textLabel", (object)val8);
			if (((Element)val8).get_StyleId() == null)
			{
				((Element)val8).set_StyleId("textLabel");
			}
			((INameScope)val51).RegisterName("errorMessage", (object)val14);
			if (((Element)val14).get_StyleId() == null)
			{
				((Element)val14).set_StyleId("errorMessage");
			}
			((INameScope)val51).RegisterName("button", (object)val28);
			if (((Element)val28).get_StyleId() == null)
			{
				((Element)val28).set_StyleId("button");
			}
			((INameScope)val51).RegisterName("indicator", (object)onboardingIndicatorView);
			if (((Element)onboardingIndicatorView).get_StyleId() == null)
			{
				((Element)onboardingIndicatorView).set_StyleId("indicator");
			}
			((INameScope)val51).RegisterName("validatingMessage", (object)val41);
			if (((Element)val41).get_StyleId() == null)
			{
				((Element)val41).set_StyleId("validatingMessage");
			}
			((INameScope)val51).RegisterName("ShowSuccessMessage", (object)val48);
			if (((Element)val48).get_StyleId() == null)
			{
				((Element)val48).set_StyleId("ShowSuccessMessage");
			}
			containingView = val33;
			border = val4;
			headingLabel = val6;
			image = tintedCachedImage;
			textLabel = val8;
			errorMessage = val14;
			button = val28;
			indicator = onboardingIndicatorView;
			validatingMessage = val41;
			ShowSuccessMessage = val48;
			((BindableObject)onboardingReferenceIDView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)onboardingReferenceIDView).SetValue(Page.TitleProperty, (object)onboardingView_Title);
			((VisualElement)onboardingReferenceIDView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			((BindableObject)val35).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val34).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 0.0));
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			val2.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val52 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 6];
			array[0] = shadowFrame;
			array[1] = val33;
			array[2] = val34;
			array[3] = val35;
			array[4] = val50;
			array[5] = onboardingReferenceIDView;
			SimpleValueTargetProvider val53 = new SimpleValueTargetProvider(array, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val51);
			object obj = (object)val53;
			val52.Add(typeFromHandle, (object)val53);
			val52.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val54 = new XmlNamespaceResolver();
			val54.Add("", "http://xamarin.com/schemas/2014/forms");
			val54.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val54.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val54.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val54.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val54.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val54.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val52.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val54, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val52.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 25)));
			DynamicResource val55 = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val52);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val55.get_Key());
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)val4).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			val3.set_Key("PrimaryColor");
			XamlServiceProvider val56 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 8];
			array2[0] = val4;
			array2[1] = val30;
			array2[2] = shadowFrame;
			array2[3] = val33;
			array2[4] = val34;
			array2[5] = val35;
			array2[6] = val50;
			array2[7] = onboardingReferenceIDView;
			SimpleValueTargetProvider val57 = new SimpleValueTargetProvider(array2, (object)BoxView.ColorProperty, (INameScope)(object)val51);
			object obj2 = (object)val57;
			val56.Add(typeFromHandle3, (object)val57);
			val56.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val58 = new XmlNamespaceResolver();
			val58.Add("", "http://xamarin.com/schemas/2014/forms");
			val58.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val58.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val58.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val58.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val58.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val58.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val56.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val58, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val56.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 33)));
			DynamicResource val59 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val56);
			((IDynamicResourceHandler)val4).SetDynamicResource(BoxView.ColorProperty, val59.get_Key());
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val4);
			val5.set_Key("Heading1");
			XamlServiceProvider val60 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 8];
			array3[0] = val6;
			array3[1] = val30;
			array3[2] = shadowFrame;
			array3[3] = val33;
			array3[4] = val34;
			array3[5] = val35;
			array3[6] = val50;
			array3[7] = onboardingReferenceIDView;
			SimpleValueTargetProvider val61 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val51);
			object obj3 = (object)val61;
			val60.Add(typeFromHandle5, (object)val61);
			val60.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val62 = new XmlNamespaceResolver();
			val62.Add("", "http://xamarin.com/schemas/2014/forms");
			val62.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val62.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val62.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val62.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val62.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val62.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val60.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val62, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val60.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 33)));
			DynamicResource val63 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val60);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val63.get_Key());
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val6).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val6).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val6).SetValue(Label.TextProperty, (object)onboardingView_WelcomeToHomeQuarantine);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val6);
			((BindableObject)val7).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((BindableObject)tintedCachedImage).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("OnBoardingReferenceID"));
			((BindableObject)tintedCachedImage).SetValue(CachedImage.AspectProperty, (object)(Aspect)0);
			((BindableObject)tintedCachedImage).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)tintedCachedImage).SetValue(VisualElement.HeightRequestProperty, (object)200.0);
			((Layout<View>)(object)val7).get_Children().Add((View)(object)tintedCachedImage);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val7);
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(32.0, 16.0));
			((BindableObject)val8).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val8).SetValue(Label.TextProperty, (object)referenceIDView_EnterYourSAPathologyReferenceNumber);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val8);
			((BindableObject)val11).SetValue(View.MarginProperty, (object)new Thickness(32.0, 0.0));
			val9.set_Mode((BindingMode)1);
			val9.set_Path("HealthReferenceID");
			BindingBase val64 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)null);
			((BindableObject)val11).SetBinding(Entry.TextProperty, val64);
			val10.set_Path("NextCommand");
			BindingBase val65 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)val11).SetBinding(Entry.ReturnCommandProperty, val65);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val11);
			((BindableObject)val14).SetValue(Label.TextProperty, (object)referenceIDView_IncorrectReferenceNumber);
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(32.0, 8.0, 32.0, 0.0));
			val12.set_Path("ShowErrorMessage");
			BindingBase val66 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)null);
			((BindableObject)val14).SetBinding(VisualElement.IsVisibleProperty, val66);
			val13.set_Key("QuartenaryColor");
			XamlServiceProvider val67 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 8];
			array4[0] = val14;
			array4[1] = val30;
			array4[2] = shadowFrame;
			array4[3] = val33;
			array4[4] = val34;
			array4[5] = val35;
			array4[6] = val50;
			array4[7] = onboardingReferenceIDView;
			SimpleValueTargetProvider val68 = new SimpleValueTargetProvider(array4, (object)Label.TextColorProperty, (INameScope)(object)val51);
			object obj4 = (object)val68;
			val67.Add(typeFromHandle7, (object)val68);
			val67.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val69 = new XmlNamespaceResolver();
			val69.Add("", "http://xamarin.com/schemas/2014/forms");
			val69.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val69.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val69.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val69.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val69.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val69.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val67.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val69, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val67.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 33)));
			object obj5 = ((IMarkupExtension)val13).ProvideValue((IServiceProvider)val67);
			val14.set_TextColor((Color)obj5);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val14);
			((BindableObject)val24).SetValue(View.MarginProperty, (object)new Thickness(32.0, 8.0, 32.0, 0.0));
			val15.set_Path("ShowErrorMessage");
			BindingBase val70 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)null);
			((BindableObject)val24).SetBinding(VisualElement.IsVisibleProperty, val70);
			val16.set_Key("Small");
			XamlServiceProvider val71 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 8];
			array5[0] = val24;
			array5[1] = val30;
			array5[2] = shadowFrame;
			array5[3] = val33;
			array5[4] = val34;
			array5[5] = val35;
			array5[6] = val50;
			array5[7] = onboardingReferenceIDView;
			SimpleValueTargetProvider val72 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val51);
			object obj6 = (object)val72;
			val71.Add(typeFromHandle9, (object)val72);
			val71.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val73 = new XmlNamespaceResolver();
			val73.Add("", "http://xamarin.com/schemas/2014/forms");
			val73.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val73.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val73.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val73.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val73.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val73.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val71.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val73, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val71.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 33)));
			DynamicResource val74 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val71);
			((IDynamicResourceHandler)val24).SetDynamicResource(VisualElement.StyleProperty, val74.get_Key());
			((BindableObject)val17).SetValue(Span.TextProperty, (object)referenceIDView_PleaseTryAgain);
			val21.get_Spans().Add(val17);
			((BindableObject)val19).SetValue(Span.TextProperty, (object)referenceIDView_ContactNumber);
			((BindableObject)val19).SetValue(Span.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val18.set_Key("SecondaryLinkColor");
			XamlServiceProvider val75 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 10];
			array6[0] = val19;
			array6[1] = val21;
			array6[2] = val24;
			array6[3] = val30;
			array6[4] = shadowFrame;
			array6[5] = val33;
			array6[6] = val34;
			array6[7] = val35;
			array6[8] = val50;
			array6[9] = onboardingReferenceIDView;
			SimpleValueTargetProvider val76 = new SimpleValueTargetProvider(array6, (object)Span.TextColorProperty, (INameScope)(object)val51);
			object obj7 = (object)val76;
			val75.Add(typeFromHandle11, (object)val76);
			val75.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val77 = new XmlNamespaceResolver();
			val77.Add("", "http://xamarin.com/schemas/2014/forms");
			val77.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val77.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val77.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val77.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val77.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val77.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val75.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val77, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val75.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(81, 144)));
			DynamicResource val78 = ((IMarkupExtension<DynamicResource>)(object)val18).ProvideValue((IServiceProvider)val75);
			((IDynamicResourceHandler)val19).SetDynamicResource(Span.TextColorProperty, val78.get_Key());
			val21.get_Spans().Add(val19);
			((BindableObject)val20).SetValue(Span.TextProperty, (object)referenceIDView_ContactTime);
			val21.get_Spans().Add(val20);
			((BindableObject)val24).SetValue(Label.FormattedTextProperty, (object)val21);
			val22.set_Path("CallHelpCommand");
			BindingBase val79 = ((IMarkupExtension<BindingBase>)(object)val22).ProvideValue((IServiceProvider)null);
			((BindableObject)val23).SetBinding(TapGestureRecognizer.CommandProperty, val79);
			((View)val24).get_GestureRecognizers().Add((IGestureRecognizer)(object)val23);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val24);
			val25.set_Path("NextCommand");
			BindingBase val80 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)null);
			((BindableObject)val28).SetBinding(Button.CommandProperty, val80);
			((BindableObject)val28).SetValue(Button.TextProperty, (object)button_Next);
			val26.set_Key("LargeButtonStyle");
			XamlServiceProvider val81 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 8];
			array7[0] = val28;
			array7[1] = val30;
			array7[2] = shadowFrame;
			array7[3] = val33;
			array7[4] = val34;
			array7[5] = val35;
			array7[6] = val50;
			array7[7] = onboardingReferenceIDView;
			SimpleValueTargetProvider val82 = new SimpleValueTargetProvider(array7, (object)VisualElement.StyleProperty, (INameScope)(object)val51);
			object obj8 = (object)val82;
			val81.Add(typeFromHandle13, (object)val82);
			val81.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val83 = new XmlNamespaceResolver();
			val83.Add("", "http://xamarin.com/schemas/2014/forms");
			val83.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val83.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val83.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val83.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val83.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val83.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val81.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val83, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val81.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 33)));
			DynamicResource val84 = ((IMarkupExtension<DynamicResource>)(object)val26).ProvideValue((IServiceProvider)val81);
			((IDynamicResourceHandler)val28).SetDynamicResource(VisualElement.StyleProperty, val84.get_Key());
			((BindableObject)val28).SetValue(View.MarginProperty, (object)new Thickness(32.0));
			val27.set_Path("ButtonColour");
			BindingBase val85 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)null);
			((BindableObject)val28).SetBinding(VisualElement.BackgroundColorProperty, val85);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)val28);
			((BindableObject)onboardingIndicatorView).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 32.0));
			val29.set_Path("IsIndicatorVisible");
			BindingBase val86 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)null);
			((BindableObject)onboardingIndicatorView).SetBinding(VisualElement.IsVisibleProperty, val86);
			((Layout<View>)(object)val30).get_Children().Add((View)(object)onboardingIndicatorView);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val30);
			((Layout<View>)(object)val33).get_Children().Add((View)(object)shadowFrame);
			((BindableObject)val32).SetValue(Label.TextProperty, (object)onboardingView_ReferenceID_SentBySms);
			val31.set_Key("Small");
			XamlServiceProvider val87 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 6];
			array8[0] = val32;
			array8[1] = val33;
			array8[2] = val34;
			array8[3] = val35;
			array8[4] = val50;
			array8[5] = onboardingReferenceIDView;
			SimpleValueTargetProvider val88 = new SimpleValueTargetProvider(array8, (object)VisualElement.StyleProperty, (INameScope)(object)val51);
			object obj9 = (object)val88;
			val87.Add(typeFromHandle15, (object)val88);
			val87.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val89 = new XmlNamespaceResolver();
			val89.Add("", "http://xamarin.com/schemas/2014/forms");
			val89.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val89.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val89.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val89.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val89.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val89.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val87.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val89, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val87.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(109, 25)));
			DynamicResource val90 = ((IMarkupExtension<DynamicResource>)(object)val31).ProvideValue((IServiceProvider)val87);
			((IDynamicResourceHandler)val32).SetDynamicResource(VisualElement.StyleProperty, val90.get_Key());
			((BindableObject)val32).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val32).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val32).SetValue(Label.PaddingProperty, (object)new Thickness(16.0));
			((Layout<View>)(object)val33).get_Children().Add((View)(object)val32);
			val34.set_Content((View)(object)val33);
			((Layout<View>)(object)val35).get_Children().Add((View)(object)val34);
			((ICollection<View>)val50.get_Children()).Add((View)(object)val35);
			((BindableObject)val37).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val37).SetValue(VisualElement.BackgroundColorProperty, (object)Color.Black);
			((BindableObject)val37).SetValue(VisualElement.OpacityProperty, (object)0.4);
			val36.set_Path("ShowBlurBackground");
			BindingBase val91 = ((IMarkupExtension<BindingBase>)(object)val36).ProvideValue((IServiceProvider)null);
			((BindableObject)val37).SetBinding(VisualElement.IsVisibleProperty, val91);
			((ICollection<View>)val50.get_Children()).Add((View)(object)val37);
			val38.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val92 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 3];
			array9[0] = shadowFrame2;
			array9[1] = val50;
			array9[2] = onboardingReferenceIDView;
			SimpleValueTargetProvider val93 = new SimpleValueTargetProvider(array9, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val51);
			object obj10 = (object)val93;
			val92.Add(typeFromHandle17, (object)val93);
			val92.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val94 = new XmlNamespaceResolver();
			val94.Add("", "http://xamarin.com/schemas/2014/forms");
			val94.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val94.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val94.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val94.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val94.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val94.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val92.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val94, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val92.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(127, 13)));
			DynamicResource val95 = ((IMarkupExtension<DynamicResource>)(object)val38).ProvideValue((IServiceProvider)val92);
			((IDynamicResourceHandler)shadowFrame2).SetDynamicResource(VisualElement.BackgroundColorProperty, val95.get_Key());
			((BindableObject)shadowFrame2).SetValue(Layout.PaddingProperty, (object)new Thickness(24.0));
			((BindableObject)shadowFrame2).SetValue(View.MarginProperty, (object)new Thickness(40.0, 40.0, 40.0, 40.0));
			((BindableObject)shadowFrame2).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)shadowFrame2).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			val39.set_Path("ShowValidatingMessage");
			BindingBase val96 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)null);
			((BindableObject)shadowFrame2).SetBinding(VisualElement.IsVisibleProperty, val96);
			((BindableObject)val42).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val40).SetValue(ActivityIndicator.IsRunningProperty, (object)true);
			((Layout<View>)(object)val42).get_Children().Add((View)(object)val40);
			((BindableObject)val41).SetValue(Label.TextProperty, (object)referenceIDView_ValidatingYourReferenceID);
			((BindableObject)val41).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val42).get_Children().Add((View)(object)val41);
			((BindableObject)shadowFrame2).SetValue(ContentView.ContentProperty, (object)val42);
			((ICollection<View>)val50.get_Children()).Add((View)(object)shadowFrame2);
			val43.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val97 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 3];
			array10[0] = shadowFrame3;
			array10[1] = val50;
			array10[2] = onboardingReferenceIDView;
			SimpleValueTargetProvider val98 = new SimpleValueTargetProvider(array10, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val51);
			object obj11 = (object)val98;
			val97.Add(typeFromHandle19, (object)val98);
			val97.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val99 = new XmlNamespaceResolver();
			val99.Add("", "http://xamarin.com/schemas/2014/forms");
			val99.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val99.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val99.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val99.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val99.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val99.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val97.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val99, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val97.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(146, 13)));
			DynamicResource val100 = ((IMarkupExtension<DynamicResource>)(object)val43).ProvideValue((IServiceProvider)val97);
			((IDynamicResourceHandler)shadowFrame3).SetDynamicResource(VisualElement.BackgroundColorProperty, val100.get_Key());
			((BindableObject)shadowFrame3).SetValue(Layout.PaddingProperty, (object)new Thickness(24.0));
			((BindableObject)shadowFrame3).SetValue(View.MarginProperty, (object)new Thickness(40.0, 40.0, 40.0, 40.0));
			((BindableObject)shadowFrame3).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)shadowFrame3).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			val44.set_Path("ShowSuccessMessage");
			BindingBase val101 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)null);
			((BindableObject)shadowFrame3).SetBinding(VisualElement.IsVisibleProperty, val101);
			((BindableObject)val49).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val45.set_Key("faCheckCircle");
			XamlServiceProvider val102 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 5];
			array11[0] = val47;
			array11[1] = val49;
			array11[2] = shadowFrame3;
			array11[3] = val50;
			array11[4] = onboardingReferenceIDView;
			SimpleValueTargetProvider val103 = new SimpleValueTargetProvider(array11, (object)Label.TextProperty, (INameScope)(object)val51);
			object obj12 = (object)val103;
			val102.Add(typeFromHandle21, (object)val103);
			val102.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val104 = new XmlNamespaceResolver();
			val104.Add("", "http://xamarin.com/schemas/2014/forms");
			val104.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val104.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val104.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val104.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val104.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val104.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val102.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val104, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val102.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(155, 21)));
			object text = ((IMarkupExtension)val45).ProvideValue((IServiceProvider)val102);
			val47.set_Text((string)text);
			val46.set_Key("SuccessColor");
			XamlServiceProvider val105 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 5];
			array12[0] = val47;
			array12[1] = val49;
			array12[2] = shadowFrame3;
			array12[3] = val50;
			array12[4] = onboardingReferenceIDView;
			SimpleValueTargetProvider val106 = new SimpleValueTargetProvider(array12, (object)Label.TextColorProperty, (INameScope)(object)val51);
			object obj13 = (object)val106;
			val105.Add(typeFromHandle23, (object)val106);
			val105.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val107 = new XmlNamespaceResolver();
			val107.Add("", "http://xamarin.com/schemas/2014/forms");
			val107.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val107.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val107.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val107.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val107.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val107.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val105.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val107, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val105.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(156, 21)));
			DynamicResource val108 = ((IMarkupExtension<DynamicResource>)(object)val46).ProvideValue((IServiceProvider)val105);
			((IDynamicResourceHandler)val47).SetDynamicResource(Label.TextColorProperty, val108.get_Key());
			((BindableObject)val47).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter val109 = new FontSizeConverter();
			XamlServiceProvider val110 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array13 = new object[0 + 5];
			array13[0] = val47;
			array13[1] = val49;
			array13[2] = shadowFrame3;
			array13[3] = val50;
			array13[4] = onboardingReferenceIDView;
			SimpleValueTargetProvider val111 = new SimpleValueTargetProvider(array13, (object)Label.FontSizeProperty, (INameScope)(object)val51);
			object obj14 = (object)val111;
			val110.Add(typeFromHandle25, (object)val111);
			val110.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val112 = new XmlNamespaceResolver();
			val112.Add("", "http://xamarin.com/schemas/2014/forms");
			val112.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val112.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val112.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val112.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val112.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val112.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val110.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val112, typeof(OnboardingReferenceIDView).GetTypeInfo().Assembly));
			val110.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(158, 21)));
			((BindableObject)val47).SetValue(fontSizeProperty, ((IExtendedTypeConverter)val109).ConvertFromInvariantString("30", (IServiceProvider)val110));
			((BindableObject)val47).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val49).get_Children().Add((View)(object)val47);
			((BindableObject)val48).SetValue(Label.TextProperty, (object)referenceIDView_YourReferenceIDIsValid);
			((BindableObject)val48).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val49).get_Children().Add((View)(object)val48);
			((BindableObject)shadowFrame3).SetValue(ContentView.ContentProperty, (object)val49);
			((ICollection<View>)val50.get_Children()).Add((View)(object)shadowFrame3);
			((BindableObject)onboardingReferenceIDView).SetValue(ContentPage.ContentProperty, (object)val50);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<OnboardingReferenceIDView>(this, typeof(OnboardingReferenceIDView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			border = NameScopeExtensions.FindByName<BoxView>((Element)(object)this, "border");
			headingLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "headingLabel");
			image = NameScopeExtensions.FindByName<TintedCachedImage>((Element)(object)this, "image");
			textLabel = NameScopeExtensions.FindByName<Label>((Element)(object)this, "textLabel");
			errorMessage = NameScopeExtensions.FindByName<Label>((Element)(object)this, "errorMessage");
			button = NameScopeExtensions.FindByName<Button>((Element)(object)this, "button");
			indicator = NameScopeExtensions.FindByName<OnboardingIndicatorView>((Element)(object)this, "indicator");
			validatingMessage = NameScopeExtensions.FindByName<Label>((Element)(object)this, "validatingMessage");
			ShowSuccessMessage = NameScopeExtensions.FindByName<Label>((Element)(object)this, "ShowSuccessMessage");
		}
	}
}
