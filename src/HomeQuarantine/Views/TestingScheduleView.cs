using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Converters;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/TestingScheduleView.xaml")]
	public class TestingScheduleView : BaseView, IChildView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label covidTestingLocations;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label testingLocationDetails;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Label testingLocationDetails2;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ResourceLinkView testingLocationsUrl;

		public TestingScheduleView()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			(((BindableObject)this).get_BindingContext() as TestingScheduleViewModel).LoadContentCommand.Execute(null);
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
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
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
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
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
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
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
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
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
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
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected O, but got Unknown
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected O, but got Unknown
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
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
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Expected O, but got Unknown
			//IL_0483: Expected O, but got Unknown
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Expected O, but got Unknown
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Expected O, but got Unknown
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Unknown result type (might be due to invalid IL or missing references)
			//IL_054c: Expected O, but got Unknown
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected O, but got Unknown
			//IL_0556: Expected O, but got Unknown
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_062d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0632: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Expected O, but got Unknown
			//IL_063a: Expected O, but got Unknown
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_064c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0657: Unknown result type (might be due to invalid IL or missing references)
			//IL_065c: Unknown result type (might be due to invalid IL or missing references)
			//IL_066c: Unknown result type (might be due to invalid IL or missing references)
			//IL_067c: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_069c: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e5: Expected O, but got Unknown
			//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ea: Expected O, but got Unknown
			//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0703: Expected O, but got Unknown
			//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0708: Expected O, but got Unknown
			//IL_070d: Expected O, but got Unknown
			//IL_0729: Unknown result type (might be due to invalid IL or missing references)
			//IL_0768: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0824: Unknown result type (might be due to invalid IL or missing references)
			//IL_0829: Unknown result type (might be due to invalid IL or missing references)
			//IL_082c: Expected O, but got Unknown
			//IL_0831: Expected O, but got Unknown
			//IL_0831: Unknown result type (might be due to invalid IL or missing references)
			//IL_0843: Unknown result type (might be due to invalid IL or missing references)
			//IL_084e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0853: Unknown result type (might be due to invalid IL or missing references)
			//IL_0863: Unknown result type (might be due to invalid IL or missing references)
			//IL_0873: Unknown result type (might be due to invalid IL or missing references)
			//IL_0883: Unknown result type (might be due to invalid IL or missing references)
			//IL_0893: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08dc: Expected O, but got Unknown
			//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e1: Expected O, but got Unknown
			//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fa: Expected O, but got Unknown
			//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ff: Expected O, but got Unknown
			//IL_0904: Expected O, but got Unknown
			//IL_0920: Unknown result type (might be due to invalid IL or missing references)
			//IL_095f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5e: Expected O, but got Unknown
			//IL_0a63: Expected O, but got Unknown
			//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0e: Expected O, but got Unknown
			//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b13: Expected O, but got Unknown
			//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2c: Expected O, but got Unknown
			//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b31: Expected O, but got Unknown
			//IL_0b36: Expected O, but got Unknown
			//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0daa: Expected O, but got Unknown
			//IL_0daf: Expected O, but got Unknown
			//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5a: Expected O, but got Unknown
			//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5f: Expected O, but got Unknown
			//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e78: Expected O, but got Unknown
			//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7d: Expected O, but got Unknown
			//IL_0e82: Expected O, but got Unknown
			//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3e: Expected O, but got Unknown
			//IL_0f43: Expected O, but got Unknown
			//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fee: Expected O, but got Unknown
			//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff3: Expected O, but got Unknown
			//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1002: Unknown result type (might be due to invalid IL or missing references)
			//IL_100c: Expected O, but got Unknown
			//IL_1007: Unknown result type (might be due to invalid IL or missing references)
			//IL_1011: Expected O, but got Unknown
			//IL_1016: Expected O, but got Unknown
			//IL_1032: Unknown result type (might be due to invalid IL or missing references)
			//IL_1048: Unknown result type (might be due to invalid IL or missing references)
			//IL_1065: Unknown result type (might be due to invalid IL or missing references)
			//IL_106a: Unknown result type (might be due to invalid IL or missing references)
			//IL_10be: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c6: Expected O, but got Unknown
			//IL_10cb: Expected O, but got Unknown
			//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_110d: Unknown result type (might be due to invalid IL or missing references)
			//IL_111d: Unknown result type (might be due to invalid IL or missing references)
			//IL_112d: Unknown result type (might be due to invalid IL or missing references)
			//IL_113d: Unknown result type (might be due to invalid IL or missing references)
			//IL_114d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1176: Expected O, but got Unknown
			//IL_1171: Unknown result type (might be due to invalid IL or missing references)
			//IL_117b: Expected O, but got Unknown
			//IL_117b: Unknown result type (might be due to invalid IL or missing references)
			//IL_118a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1194: Expected O, but got Unknown
			//IL_118f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1199: Expected O, but got Unknown
			//IL_119e: Expected O, but got Unknown
			//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_1252: Unknown result type (might be due to invalid IL or missing references)
			//IL_1257: Unknown result type (might be due to invalid IL or missing references)
			//IL_125a: Expected O, but got Unknown
			//IL_125f: Expected O, but got Unknown
			//IL_125f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1271: Unknown result type (might be due to invalid IL or missing references)
			//IL_127c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1281: Unknown result type (might be due to invalid IL or missing references)
			//IL_1291: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_130a: Expected O, but got Unknown
			//IL_1305: Unknown result type (might be due to invalid IL or missing references)
			//IL_130f: Expected O, but got Unknown
			//IL_130f: Unknown result type (might be due to invalid IL or missing references)
			//IL_131e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1328: Expected O, but got Unknown
			//IL_1323: Unknown result type (might be due to invalid IL or missing references)
			//IL_132d: Expected O, but got Unknown
			//IL_1332: Expected O, but got Unknown
			//IL_138a: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_1409: Unknown result type (might be due to invalid IL or missing references)
			//IL_1460: Unknown result type (might be due to invalid IL or missing references)
			//IL_1476: Unknown result type (might be due to invalid IL or missing references)
			//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1530: Unknown result type (might be due to invalid IL or missing references)
			//IL_1535: Unknown result type (might be due to invalid IL or missing references)
			//IL_1538: Expected O, but got Unknown
			//IL_153d: Expected O, but got Unknown
			//IL_153d: Unknown result type (might be due to invalid IL or missing references)
			//IL_154f: Unknown result type (might be due to invalid IL or missing references)
			//IL_155a: Unknown result type (might be due to invalid IL or missing references)
			//IL_155f: Unknown result type (might be due to invalid IL or missing references)
			//IL_156f: Unknown result type (might be due to invalid IL or missing references)
			//IL_157f: Unknown result type (might be due to invalid IL or missing references)
			//IL_158f: Unknown result type (might be due to invalid IL or missing references)
			//IL_159f: Unknown result type (might be due to invalid IL or missing references)
			//IL_15af: Unknown result type (might be due to invalid IL or missing references)
			//IL_15bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_15e8: Expected O, but got Unknown
			//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ed: Expected O, but got Unknown
			//IL_15ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1606: Expected O, but got Unknown
			//IL_1601: Unknown result type (might be due to invalid IL or missing references)
			//IL_160b: Expected O, but got Unknown
			//IL_1610: Expected O, but got Unknown
			//IL_1635: Unknown result type (might be due to invalid IL or missing references)
			//IL_1654: Unknown result type (might be due to invalid IL or missing references)
			//IL_1671: Unknown result type (might be due to invalid IL or missing references)
			//IL_1676: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16cc: Expected O, but got Unknown
			//IL_16d1: Expected O, but got Unknown
			//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1703: Unknown result type (might be due to invalid IL or missing references)
			//IL_1713: Unknown result type (might be due to invalid IL or missing references)
			//IL_1723: Unknown result type (might be due to invalid IL or missing references)
			//IL_1733: Unknown result type (might be due to invalid IL or missing references)
			//IL_1743: Unknown result type (might be due to invalid IL or missing references)
			//IL_1753: Unknown result type (might be due to invalid IL or missing references)
			//IL_177c: Expected O, but got Unknown
			//IL_1777: Unknown result type (might be due to invalid IL or missing references)
			//IL_1781: Expected O, but got Unknown
			//IL_1781: Unknown result type (might be due to invalid IL or missing references)
			//IL_1790: Unknown result type (might be due to invalid IL or missing references)
			//IL_179a: Expected O, but got Unknown
			//IL_1795: Unknown result type (might be due to invalid IL or missing references)
			//IL_179f: Expected O, but got Unknown
			//IL_17a4: Expected O, but got Unknown
			//IL_17c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_184c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1851: Unknown result type (might be due to invalid IL or missing references)
			//IL_1854: Expected O, but got Unknown
			//IL_1859: Expected O, but got Unknown
			//IL_1859: Unknown result type (might be due to invalid IL or missing references)
			//IL_186b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1876: Unknown result type (might be due to invalid IL or missing references)
			//IL_187b: Unknown result type (might be due to invalid IL or missing references)
			//IL_188b: Unknown result type (might be due to invalid IL or missing references)
			//IL_189b: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_18bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_18cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_18db: Unknown result type (might be due to invalid IL or missing references)
			//IL_1904: Expected O, but got Unknown
			//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1909: Expected O, but got Unknown
			//IL_1909: Unknown result type (might be due to invalid IL or missing references)
			//IL_1918: Unknown result type (might be due to invalid IL or missing references)
			//IL_1922: Expected O, but got Unknown
			//IL_191d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1927: Expected O, but got Unknown
			//IL_192c: Expected O, but got Unknown
			//IL_194f: Unknown result type (might be due to invalid IL or missing references)
			//IL_196a: Unknown result type (might be due to invalid IL or missing references)
			//IL_198c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1991: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ed: Expected O, but got Unknown
			//IL_19f2: Expected O, but got Unknown
			//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a24: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a64: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a9d: Expected O, but got Unknown
			//IL_1a98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa2: Expected O, but got Unknown
			//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1abb: Expected O, but got Unknown
			//IL_1ab6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac0: Expected O, but got Unknown
			//IL_1ac5: Expected O, but got Unknown
			//IL_1afd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b61: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c10: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c15: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c52: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c57: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c5a: Expected O, but got Unknown
			//IL_1c5f: Expected O, but got Unknown
			//IL_1c5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c71: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c81: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ca1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d0a: Expected O, but got Unknown
			//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d0f: Expected O, but got Unknown
			//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d21: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d2b: Expected O, but got Unknown
			//IL_1d26: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d30: Expected O, but got Unknown
			//IL_1d35: Expected O, but got Unknown
			//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e49: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e51: Expected O, but got Unknown
			//IL_1e56: Expected O, but got Unknown
			//IL_1e56: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e68: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e73: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f01: Expected O, but got Unknown
			//IL_1efc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f06: Expected O, but got Unknown
			//IL_1f06: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f18: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f22: Expected O, but got Unknown
			//IL_1f1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f27: Expected O, but got Unknown
			//IL_1f2c: Expected O, but got Unknown
			//IL_1f48: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f97: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fdc: Expected O, but got Unknown
			//IL_1fe1: Expected O, but got Unknown
			//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2003: Unknown result type (might be due to invalid IL or missing references)
			//IL_2013: Unknown result type (might be due to invalid IL or missing references)
			//IL_2023: Unknown result type (might be due to invalid IL or missing references)
			//IL_2033: Unknown result type (might be due to invalid IL or missing references)
			//IL_2043: Unknown result type (might be due to invalid IL or missing references)
			//IL_2053: Unknown result type (might be due to invalid IL or missing references)
			//IL_2063: Unknown result type (might be due to invalid IL or missing references)
			//IL_208c: Expected O, but got Unknown
			//IL_2087: Unknown result type (might be due to invalid IL or missing references)
			//IL_2091: Expected O, but got Unknown
			//IL_2091: Unknown result type (might be due to invalid IL or missing references)
			//IL_20a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ad: Expected O, but got Unknown
			//IL_20a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b2: Expected O, but got Unknown
			//IL_20b7: Expected O, but got Unknown
			//IL_20da: Unknown result type (might be due to invalid IL or missing references)
			//IL_20df: Unknown result type (might be due to invalid IL or missing references)
			//IL_2117: Unknown result type (might be due to invalid IL or missing references)
			//IL_211c: Unknown result type (might be due to invalid IL or missing references)
			//IL_211f: Expected O, but got Unknown
			//IL_2124: Expected O, but got Unknown
			//IL_2124: Unknown result type (might be due to invalid IL or missing references)
			//IL_2136: Unknown result type (might be due to invalid IL or missing references)
			//IL_2141: Unknown result type (might be due to invalid IL or missing references)
			//IL_2146: Unknown result type (might be due to invalid IL or missing references)
			//IL_2156: Unknown result type (might be due to invalid IL or missing references)
			//IL_2166: Unknown result type (might be due to invalid IL or missing references)
			//IL_2176: Unknown result type (might be due to invalid IL or missing references)
			//IL_2186: Unknown result type (might be due to invalid IL or missing references)
			//IL_2196: Unknown result type (might be due to invalid IL or missing references)
			//IL_21a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_21cf: Expected O, but got Unknown
			//IL_21ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_21d4: Expected O, but got Unknown
			//IL_21d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f0: Expected O, but got Unknown
			//IL_21eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f5: Expected O, but got Unknown
			//IL_21fa: Expected O, but got Unknown
			//IL_2216: Unknown result type (might be due to invalid IL or missing references)
			//IL_2271: Unknown result type (might be due to invalid IL or missing references)
			//IL_22b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_22c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_234d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2352: Unknown result type (might be due to invalid IL or missing references)
			//IL_2385: Unknown result type (might be due to invalid IL or missing references)
			//IL_238a: Unknown result type (might be due to invalid IL or missing references)
			//IL_238d: Expected O, but got Unknown
			//IL_2392: Expected O, but got Unknown
			//IL_2392: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23af: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2404: Unknown result type (might be due to invalid IL or missing references)
			//IL_2414: Unknown result type (might be due to invalid IL or missing references)
			//IL_243d: Expected O, but got Unknown
			//IL_2438: Unknown result type (might be due to invalid IL or missing references)
			//IL_2442: Expected O, but got Unknown
			//IL_2442: Unknown result type (might be due to invalid IL or missing references)
			//IL_2454: Unknown result type (might be due to invalid IL or missing references)
			//IL_245e: Expected O, but got Unknown
			//IL_2459: Unknown result type (might be due to invalid IL or missing references)
			//IL_2463: Expected O, but got Unknown
			//IL_2468: Expected O, but got Unknown
			//IL_248d: Unknown result type (might be due to invalid IL or missing references)
			//IL_24c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_24fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2503: Unknown result type (might be due to invalid IL or missing references)
			//IL_2540: Unknown result type (might be due to invalid IL or missing references)
			//IL_2545: Unknown result type (might be due to invalid IL or missing references)
			//IL_2548: Expected O, but got Unknown
			//IL_254d: Expected O, but got Unknown
			//IL_254d: Unknown result type (might be due to invalid IL or missing references)
			//IL_255f: Unknown result type (might be due to invalid IL or missing references)
			//IL_256a: Unknown result type (might be due to invalid IL or missing references)
			//IL_256f: Unknown result type (might be due to invalid IL or missing references)
			//IL_257f: Unknown result type (might be due to invalid IL or missing references)
			//IL_258f: Unknown result type (might be due to invalid IL or missing references)
			//IL_259f: Unknown result type (might be due to invalid IL or missing references)
			//IL_25af: Unknown result type (might be due to invalid IL or missing references)
			//IL_25bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_25cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_25f8: Expected O, but got Unknown
			//IL_25f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_25fd: Expected O, but got Unknown
			//IL_25fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_260f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2619: Expected O, but got Unknown
			//IL_2614: Unknown result type (might be due to invalid IL or missing references)
			//IL_261e: Expected O, but got Unknown
			//IL_2623: Expected O, but got Unknown
			//IL_2679: Unknown result type (might be due to invalid IL or missing references)
			//IL_26a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_26cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_26d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2712: Unknown result type (might be due to invalid IL or missing references)
			//IL_2717: Unknown result type (might be due to invalid IL or missing references)
			//IL_271a: Expected O, but got Unknown
			//IL_271f: Expected O, but got Unknown
			//IL_271f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2731: Unknown result type (might be due to invalid IL or missing references)
			//IL_273c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2741: Unknown result type (might be due to invalid IL or missing references)
			//IL_2751: Unknown result type (might be due to invalid IL or missing references)
			//IL_2761: Unknown result type (might be due to invalid IL or missing references)
			//IL_2771: Unknown result type (might be due to invalid IL or missing references)
			//IL_2781: Unknown result type (might be due to invalid IL or missing references)
			//IL_2791: Unknown result type (might be due to invalid IL or missing references)
			//IL_27a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_27ca: Expected O, but got Unknown
			//IL_27c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_27cf: Expected O, but got Unknown
			//IL_27cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_27e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_27eb: Expected O, but got Unknown
			//IL_27e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_27f0: Expected O, but got Unknown
			//IL_27f5: Expected O, but got Unknown
			//IL_2835: Unknown result type (might be due to invalid IL or missing references)
			//IL_28f5: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(TestingScheduleView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/TestingScheduleView.xaml");
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
			string testingScheduleView_TestingScheduleAndCalendar = Resources.TestingScheduleView_TestingScheduleAndCalendar;
			FirstValidationErrorConverter firstValidationErrorConverter = new FirstValidationErrorConverter();
			InverseBoolConverter inverseBoolConverter = new InverseBoolConverter();
			BindingExtension val2 = new BindingExtension();
			BindingExtension val3 = new BindingExtension();
			DynamicResourceExtension val4 = new DynamicResourceExtension();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			string testingScheduleView_YourHomeQuarantineSchedule = Resources.TestingScheduleView_YourHomeQuarantineSchedule;
			Label val6 = new Label();
			string testingScheduleView_YourHomeQuarantineScheduleDescription = Resources.TestingScheduleView_YourHomeQuarantineScheduleDescription1;
			Label val7 = new Label();
			string testingScheduleView_YourHomeQuarantineScheduleDescription2 = Resources.TestingScheduleView_YourHomeQuarantineScheduleDescription2;
			Label val8 = new Label();
			string testingScheduleView_WhatIfIMissACheckInOrTest = Resources.TestingScheduleView_WhatIfIMissACheckInOrTest;
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			BindingExtension val10 = new BindingExtension();
			TapGestureRecognizer val11 = new TapGestureRecognizer();
			Label val12 = new Label();
			StackLayout val13 = new StackLayout();
			DynamicResourceExtension val14 = new DynamicResourceExtension();
			ColumnDefinition val15 = new ColumnDefinition();
			ColumnDefinition val16 = new ColumnDefinition();
			ColumnDefinition val17 = new ColumnDefinition();
			string testingScheduleView_Calendar = Resources.TestingScheduleView_Calendar;
			Label val18 = new Label();
			DynamicResourceExtension val19 = new DynamicResourceExtension();
			DynamicResourceExtension val20 = new DynamicResourceExtension();
			StaticResourceExtension val21 = new StaticResourceExtension();
			DynamicResourceExtension val22 = new DynamicResourceExtension();
			Label val23 = new Label();
			TimelineShadowFrame timelineShadowFrame = new TimelineShadowFrame();
			string testingScheduleView_SymptomsCheck = Resources.TestingScheduleView_SymptomsCheck;
			Label val24 = new Label();
			string testingScheduleView_SymptomsCheck2 = Resources.TestingScheduleView_SymptomsCheck1;
			Label val25 = new Label();
			StackLayout val26 = new StackLayout();
			StackLayout val27 = new StackLayout();
			DynamicResourceExtension val28 = new DynamicResourceExtension();
			DynamicResourceExtension val29 = new DynamicResourceExtension();
			StaticResourceExtension val30 = new StaticResourceExtension();
			DynamicResourceExtension val31 = new DynamicResourceExtension();
			Label val32 = new Label();
			TimelineShadowFrame timelineShadowFrame2 = new TimelineShadowFrame();
			string testingScheduleView_GetTested = Resources.TestingScheduleView_GetTested;
			Label val33 = new Label();
			string testingScheduleView_GetTested2 = Resources.TestingScheduleView_GetTested1;
			Label val34 = new Label();
			StackLayout val35 = new StackLayout();
			StackLayout val36 = new StackLayout();
			Grid val37 = new Grid();
			DynamicResourceExtension val38 = new DynamicResourceExtension();
			BoxView val39 = new BoxView();
			StackLayout val40 = new StackLayout();
			ShadowFrame shadowFrame = new ShadowFrame();
			BindingExtension val41 = new BindingExtension();
			BindingExtension val42 = new BindingExtension();
			DynamicResourceExtension val43 = new DynamicResourceExtension();
			ActivityIndicator val44 = new ActivityIndicator();
			BindingExtension val45 = new BindingExtension();
			DynamicResourceExtension val46 = new DynamicResourceExtension();
			DynamicResourceExtension val47 = new DynamicResourceExtension();
			Label val48 = new Label();
			StackLayout val49 = new StackLayout();
			BindingExtension val50 = new BindingExtension();
			DataTemplate val51 = new DataTemplate();
			StackLayout val52 = new StackLayout();
			DynamicResourceExtension val53 = new DynamicResourceExtension();
			DynamicResourceExtension val54 = new DynamicResourceExtension();
			BoxView val55 = new BoxView();
			DynamicResourceExtension val56 = new DynamicResourceExtension();
			string hasSymptomView_CovidTestingLocations = Resources.HasSymptomView_CovidTestingLocations;
			Label val57 = new Label();
			string hasSymptomView_TestingLocationSubtitle = Resources.HasSymptomView_TestingLocationSubtitle1;
			Label val58 = new Label();
			string hasSymptomView_TestingLocationSubtitle2 = Resources.HasSymptomView_TestingLocationSubtitle2;
			Label val59 = new Label();
			string hasSymptomView_TestingLocations = Resources.HasSymptomView_TestingLocations;
			BindingExtension val60 = new BindingExtension();
			ResourceLinkView resourceLinkView = new ResourceLinkView();
			StackLayout val61 = new StackLayout();
			StackLayout val62 = new StackLayout();
			ShadowFrame shadowFrame2 = new ShadowFrame();
			StackLayout val63 = new StackLayout();
			ScrollView val64 = new ScrollView();
			RefreshView val65 = new RefreshView();
			TestingScheduleView testingScheduleView;
			NameScope val66 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(testingScheduleView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)testingScheduleView, (INameScope)(object)val66);
			((INameScope)val66).RegisterName("containingView", (object)val63);
			if (((Element)val63).get_StyleId() == null)
			{
				((Element)val63).set_StyleId("containingView");
			}
			((INameScope)val66).RegisterName("covidTestingLocations", (object)val57);
			if (((Element)val57).get_StyleId() == null)
			{
				((Element)val57).set_StyleId("covidTestingLocations");
			}
			((INameScope)val66).RegisterName("testingLocationDetails", (object)val58);
			if (((Element)val58).get_StyleId() == null)
			{
				((Element)val58).set_StyleId("testingLocationDetails");
			}
			((INameScope)val66).RegisterName("testingLocationDetails2", (object)val59);
			if (((Element)val59).get_StyleId() == null)
			{
				((Element)val59).set_StyleId("testingLocationDetails2");
			}
			((INameScope)val66).RegisterName("testingLocationsUrl", (object)resourceLinkView);
			if (((Element)resourceLinkView).get_StyleId() == null)
			{
				((Element)resourceLinkView).set_StyleId("testingLocationsUrl");
			}
			containingView = val63;
			covidTestingLocations = val57;
			testingLocationDetails = val58;
			testingLocationDetails2 = val59;
			testingLocationsUrl = resourceLinkView;
			((BindableObject)testingScheduleView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)testingScheduleView).SetValue(Page.TitleProperty, (object)testingScheduleView_TestingScheduleAndCalendar);
			((VisualElement)testingScheduleView).get_Resources().Add("FirstValidationErrorConverter", (object)firstValidationErrorConverter);
			((VisualElement)testingScheduleView).get_Resources().Add("InverseBoolConverter", (object)inverseBoolConverter);
			val2.set_Path("RefreshCommand");
			BindingBase val67 = ((IMarkupExtension<BindingBase>)(object)val2).ProvideValue((IServiceProvider)null);
			((BindableObject)val65).SetBinding(RefreshView.CommandProperty, val67);
			val3.set_Path("IsRefreshing");
			BindingBase val68 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)null);
			((BindableObject)val65).SetBinding(RefreshView.IsRefreshingProperty, val68);
			val4.set_Key("SecondaryTextColor");
			XamlServiceProvider val69 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 2];
			array[0] = val65;
			array[1] = testingScheduleView;
			SimpleValueTargetProvider val70 = new SimpleValueTargetProvider(array, (object)RefreshView.RefreshColorProperty, (INameScope)(object)val66);
			object obj = (object)val70;
			val69.Add(typeFromHandle, (object)val70);
			val69.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val71 = new XmlNamespaceResolver();
			val71.Add("", "http://xamarin.com/schemas/2014/forms");
			val71.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val71.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val71.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val71.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val71.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val71.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val69.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val71, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val69.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 9)));
			DynamicResource val72 = ((IMarkupExtension<DynamicResource>)(object)val4).ProvideValue((IServiceProvider)val69);
			((IDynamicResourceHandler)val65).SetDynamicResource(RefreshView.RefreshColorProperty, val72.get_Key());
			((BindableObject)val64).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val64).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 16.0));
			((BindableObject)val13).SetValue(View.MarginProperty, (object)new Thickness(24.0));
			((BindableObject)val13).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val5.set_Key("Heading1");
			XamlServiceProvider val73 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 6];
			array2[0] = val6;
			array2[1] = val13;
			array2[2] = val63;
			array2[3] = val64;
			array2[4] = val65;
			array2[5] = testingScheduleView;
			SimpleValueTargetProvider val74 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val66);
			object obj2 = (object)val74;
			val73.Add(typeFromHandle3, (object)val74);
			val73.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val75 = new XmlNamespaceResolver();
			val75.Add("", "http://xamarin.com/schemas/2014/forms");
			val75.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val75.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val75.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val75.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val75.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val75.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val73.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val75, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val73.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 25)));
			DynamicResource val76 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val73);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val76.get_Key());
			((BindableObject)val6).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0, 0.0, 8.0));
			((BindableObject)val6).SetValue(Label.TextProperty, (object)testingScheduleView_YourHomeQuarantineSchedule);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val6);
			((BindableObject)val7).SetValue(Label.TextProperty, (object)testingScheduleView_YourHomeQuarantineScheduleDescription);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val7);
			((BindableObject)val8).SetValue(Label.TextProperty, (object)testingScheduleView_YourHomeQuarantineScheduleDescription2);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val8);
			((BindableObject)val12).SetValue(Label.TextProperty, (object)testingScheduleView_WhatIfIMissACheckInOrTest);
			val9.set_Key("SecondaryLinkColor");
			XamlServiceProvider val77 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 6];
			array3[0] = val12;
			array3[1] = val13;
			array3[2] = val63;
			array3[3] = val64;
			array3[4] = val65;
			array3[5] = testingScheduleView;
			SimpleValueTargetProvider val78 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope)(object)val66);
			object obj3 = (object)val78;
			val77.Add(typeFromHandle5, (object)val78);
			val77.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val79 = new XmlNamespaceResolver();
			val79.Add("", "http://xamarin.com/schemas/2014/forms");
			val79.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val79.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val79.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val79.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val79.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val79.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val77.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val79, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val77.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 25)));
			DynamicResource val80 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val77);
			((IDynamicResourceHandler)val12).SetDynamicResource(Label.TextColorProperty, val80.get_Key());
			((BindableObject)val12).SetValue(Label.TextDecorationsProperty, new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			((BindableObject)val12).SetValue(View.MarginProperty, (object)new Thickness(0.0, 8.0, 0.0, 0.0));
			val10.set_Path("OpenHelpCommand");
			BindingBase val81 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)null);
			((BindableObject)val11).SetBinding(TapGestureRecognizer.CommandProperty, val81);
			((View)val12).get_GestureRecognizers().Add((IGestureRecognizer)(object)val11);
			((Layout<View>)(object)val13).get_Children().Add((View)(object)val12);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)val13);
			((BindableObject)shadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)shadowFrame).SetValue(Frame.CornerRadiusProperty, (object)0f);
			val14.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val82 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 5];
			array4[0] = shadowFrame;
			array4[1] = val63;
			array4[2] = val64;
			array4[3] = val65;
			array4[4] = testingScheduleView;
			SimpleValueTargetProvider val83 = new SimpleValueTargetProvider(array4, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val66);
			object obj4 = (object)val83;
			val82.Add(typeFromHandle7, (object)val83);
			val82.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val84 = new XmlNamespaceResolver();
			val84.Add("", "http://xamarin.com/schemas/2014/forms");
			val84.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val84.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val84.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val84.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val84.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val84.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val82.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val84, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val82.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 21)));
			DynamicResource val85 = ((IMarkupExtension<DynamicResource>)(object)val14).ProvideValue((IServiceProvider)val82);
			((IDynamicResourceHandler)shadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val85.get_Key());
			((BindableObject)val37).SetValue(Grid.ColumnSpacingProperty, (object)0.0);
			((BindableObject)val37).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val15).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val37).GetValue(Grid.ColumnDefinitionsProperty)).Add(val15);
			((BindableObject)val16).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val37).GetValue(Grid.ColumnDefinitionsProperty)).Add(val16);
			((BindableObject)val17).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val37).GetValue(Grid.ColumnDefinitionsProperty)).Add(val17);
			((BindableObject)val18).SetValue(Label.TextProperty, (object)testingScheduleView_Calendar);
			((BindableObject)val18).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val18).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val18).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val18).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((BindableObject)val18).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val18).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((ICollection<View>)val37.get_Children()).Add((View)(object)val18);
			((BindableObject)val27).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val27).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val26).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)timelineShadowFrame).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
			((BindableObject)timelineShadowFrame).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
			((BindableObject)timelineShadowFrame).SetValue(Frame.CornerRadiusProperty, (object)20f);
			val19.set_Key("GrayColor");
			XamlServiceProvider val86 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 10];
			array5[0] = timelineShadowFrame;
			array5[1] = val26;
			array5[2] = val27;
			array5[3] = val37;
			array5[4] = val40;
			array5[5] = shadowFrame;
			array5[6] = val63;
			array5[7] = val64;
			array5[8] = val65;
			array5[9] = testingScheduleView;
			SimpleValueTargetProvider val87 = new SimpleValueTargetProvider(array5, (object)Frame.BorderColorProperty, (INameScope)(object)val66);
			object obj5 = (object)val87;
			val86.Add(typeFromHandle9, (object)val87);
			val86.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val88 = new XmlNamespaceResolver();
			val88.Add("", "http://xamarin.com/schemas/2014/forms");
			val88.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val88.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val88.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val88.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val88.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val88.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val86.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val88, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val86.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 41)));
			DynamicResource val89 = ((IMarkupExtension<DynamicResource>)(object)val19).ProvideValue((IServiceProvider)val86);
			((IDynamicResourceHandler)timelineShadowFrame).SetDynamicResource(Frame.BorderColorProperty, val89.get_Key());
			((BindableObject)timelineShadowFrame).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)timelineShadowFrame).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val20.set_Key("SecondaryColor");
			XamlServiceProvider val90 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 10];
			array6[0] = timelineShadowFrame;
			array6[1] = val26;
			array6[2] = val27;
			array6[3] = val37;
			array6[4] = val40;
			array6[5] = shadowFrame;
			array6[6] = val63;
			array6[7] = val64;
			array6[8] = val65;
			array6[9] = testingScheduleView;
			SimpleValueTargetProvider val91 = new SimpleValueTargetProvider(array6, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val66);
			object obj6 = (object)val91;
			val90.Add(typeFromHandle11, (object)val91);
			val90.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val92 = new XmlNamespaceResolver();
			val92.Add("", "http://xamarin.com/schemas/2014/forms");
			val92.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val92.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val92.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val92.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val92.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val92.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val90.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val92, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val90.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(75, 41)));
			DynamicResource val93 = ((IMarkupExtension<DynamicResource>)(object)val20).ProvideValue((IServiceProvider)val90);
			((IDynamicResourceHandler)timelineShadowFrame).SetDynamicResource(VisualElement.BackgroundColorProperty, val93.get_Key());
			((BindableObject)timelineShadowFrame).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)timelineShadowFrame).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			val21.set_Key("faStethoscope");
			XamlServiceProvider val94 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 11];
			array7[0] = val23;
			array7[1] = timelineShadowFrame;
			array7[2] = val26;
			array7[3] = val27;
			array7[4] = val37;
			array7[5] = val40;
			array7[6] = shadowFrame;
			array7[7] = val63;
			array7[8] = val64;
			array7[9] = val65;
			array7[10] = testingScheduleView;
			SimpleValueTargetProvider val95 = new SimpleValueTargetProvider(array7, (object)Label.TextProperty, (INameScope)(object)val66);
			object obj7 = (object)val95;
			val94.Add(typeFromHandle13, (object)val95);
			val94.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val96 = new XmlNamespaceResolver();
			val96.Add("", "http://xamarin.com/schemas/2014/forms");
			val96.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val96.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val96.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val96.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val96.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val96.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val94.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val96, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val94.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(79, 41)));
			object text = ((IMarkupExtension)val21).ProvideValue((IServiceProvider)val94);
			val23.set_Text((string)text);
			((BindableObject)val23).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val23).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val23).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			val22.set_Key("ButtonTextColor");
			XamlServiceProvider val97 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 11];
			array8[0] = val23;
			array8[1] = timelineShadowFrame;
			array8[2] = val26;
			array8[3] = val27;
			array8[4] = val37;
			array8[5] = val40;
			array8[6] = shadowFrame;
			array8[7] = val63;
			array8[8] = val64;
			array8[9] = val65;
			array8[10] = testingScheduleView;
			SimpleValueTargetProvider val98 = new SimpleValueTargetProvider(array8, (object)Label.TextColorProperty, (INameScope)(object)val66);
			object obj8 = (object)val98;
			val97.Add(typeFromHandle15, (object)val98);
			val97.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val99 = new XmlNamespaceResolver();
			val99.Add("", "http://xamarin.com/schemas/2014/forms");
			val99.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val99.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val99.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val99.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val99.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val99.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val97.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val99, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val97.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(83, 41)));
			DynamicResource val100 = ((IMarkupExtension<DynamicResource>)(object)val22).ProvideValue((IServiceProvider)val97);
			((IDynamicResourceHandler)val23).SetDynamicResource(Label.TextColorProperty, val100.get_Key());
			((BindableObject)timelineShadowFrame).SetValue(ContentView.ContentProperty, (object)val23);
			((Layout<View>)(object)val26).get_Children().Add((View)(object)timelineShadowFrame);
			((BindableObject)val24).SetValue(Label.TextProperty, (object)testingScheduleView_SymptomsCheck);
			((BindableObject)val24).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val24).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val24).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val26).get_Children().Add((View)(object)val24);
			((BindableObject)val25).SetValue(Label.TextProperty, (object)testingScheduleView_SymptomsCheck2);
			((BindableObject)val25).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
			((BindableObject)val25).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val25).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val26).get_Children().Add((View)(object)val25);
			((Layout<View>)(object)val27).get_Children().Add((View)(object)val26);
			((ICollection<View>)val37.get_Children()).Add((View)(object)val27);
			((BindableObject)val36).SetValue(Grid.ColumnProperty, (object)2);
			((BindableObject)val36).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)val35).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((BindableObject)timelineShadowFrame2).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
			((BindableObject)timelineShadowFrame2).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
			((BindableObject)timelineShadowFrame2).SetValue(Frame.CornerRadiusProperty, (object)20f);
			val28.set_Key("GrayColor");
			XamlServiceProvider val101 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 10];
			array9[0] = timelineShadowFrame2;
			array9[1] = val35;
			array9[2] = val36;
			array9[3] = val37;
			array9[4] = val40;
			array9[5] = shadowFrame;
			array9[6] = val63;
			array9[7] = val64;
			array9[8] = val65;
			array9[9] = testingScheduleView;
			SimpleValueTargetProvider val102 = new SimpleValueTargetProvider(array9, (object)Frame.BorderColorProperty, (INameScope)(object)val66);
			object obj9 = (object)val102;
			val101.Add(typeFromHandle17, (object)val102);
			val101.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val103 = new XmlNamespaceResolver();
			val103.Add("", "http://xamarin.com/schemas/2014/forms");
			val103.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val103.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val103.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val103.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val103.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val103.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val101.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val103, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val101.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(103, 41)));
			DynamicResource val104 = ((IMarkupExtension<DynamicResource>)(object)val28).ProvideValue((IServiceProvider)val101);
			((IDynamicResourceHandler)timelineShadowFrame2).SetDynamicResource(Frame.BorderColorProperty, val104.get_Key());
			((BindableObject)timelineShadowFrame2).SetValue(View.MarginProperty, (object)new Thickness(0.0));
			((BindableObject)timelineShadowFrame2).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			val29.set_Key("PrimaryColor");
			XamlServiceProvider val105 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 10];
			array10[0] = timelineShadowFrame2;
			array10[1] = val35;
			array10[2] = val36;
			array10[3] = val37;
			array10[4] = val40;
			array10[5] = shadowFrame;
			array10[6] = val63;
			array10[7] = val64;
			array10[8] = val65;
			array10[9] = testingScheduleView;
			SimpleValueTargetProvider val106 = new SimpleValueTargetProvider(array10, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val66);
			object obj10 = (object)val106;
			val105.Add(typeFromHandle19, (object)val106);
			val105.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val107 = new XmlNamespaceResolver();
			val107.Add("", "http://xamarin.com/schemas/2014/forms");
			val107.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val107.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val107.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val107.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val107.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val107.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val105.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val107, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val105.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(106, 41)));
			DynamicResource val108 = ((IMarkupExtension<DynamicResource>)(object)val29).ProvideValue((IServiceProvider)val105);
			((IDynamicResourceHandler)timelineShadowFrame2).SetDynamicResource(VisualElement.BackgroundColorProperty, val108.get_Key());
			((BindableObject)timelineShadowFrame2).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			((BindableObject)timelineShadowFrame2).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
			val30.set_Key("faVials");
			XamlServiceProvider val109 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 11];
			array11[0] = val32;
			array11[1] = timelineShadowFrame2;
			array11[2] = val35;
			array11[3] = val36;
			array11[4] = val37;
			array11[5] = val40;
			array11[6] = shadowFrame;
			array11[7] = val63;
			array11[8] = val64;
			array11[9] = val65;
			array11[10] = testingScheduleView;
			SimpleValueTargetProvider val110 = new SimpleValueTargetProvider(array11, (object)Label.TextProperty, (INameScope)(object)val66);
			object obj11 = (object)val110;
			val109.Add(typeFromHandle21, (object)val110);
			val109.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val111 = new XmlNamespaceResolver();
			val111.Add("", "http://xamarin.com/schemas/2014/forms");
			val111.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val111.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val111.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val111.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val111.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val111.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val109.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val111, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val109.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(110, 41)));
			object text2 = ((IMarkupExtension)val30).ProvideValue((IServiceProvider)val109);
			val32.set_Text((string)text2);
			((BindableObject)val32).SetValue(Label.FontFamilyProperty, (object)"FA-R");
			((BindableObject)val32).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val32).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			val31.set_Key("ButtonTextColor");
			XamlServiceProvider val112 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 11];
			array12[0] = val32;
			array12[1] = timelineShadowFrame2;
			array12[2] = val35;
			array12[3] = val36;
			array12[4] = val37;
			array12[5] = val40;
			array12[6] = shadowFrame;
			array12[7] = val63;
			array12[8] = val64;
			array12[9] = val65;
			array12[10] = testingScheduleView;
			SimpleValueTargetProvider val113 = new SimpleValueTargetProvider(array12, (object)Label.TextColorProperty, (INameScope)(object)val66);
			object obj12 = (object)val113;
			val112.Add(typeFromHandle23, (object)val113);
			val112.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val114 = new XmlNamespaceResolver();
			val114.Add("", "http://xamarin.com/schemas/2014/forms");
			val114.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val114.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val114.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val114.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val114.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val114.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val112.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val114, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val112.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(114, 41)));
			DynamicResource val115 = ((IMarkupExtension<DynamicResource>)(object)val31).ProvideValue((IServiceProvider)val112);
			((IDynamicResourceHandler)val32).SetDynamicResource(Label.TextColorProperty, val115.get_Key());
			((BindableObject)timelineShadowFrame2).SetValue(ContentView.ContentProperty, (object)val32);
			((Layout<View>)(object)val35).get_Children().Add((View)(object)timelineShadowFrame2);
			((BindableObject)val33).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val33).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)0);
			((BindableObject)val33).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val33).SetValue(Label.TextProperty, (object)testingScheduleView_GetTested);
			((Layout<View>)(object)val35).get_Children().Add((View)(object)val33);
			((BindableObject)val34).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val34).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)0);
			((BindableObject)val34).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((BindableObject)val34).SetValue(Label.TextProperty, (object)testingScheduleView_GetTested2);
			((Layout<View>)(object)val35).get_Children().Add((View)(object)val34);
			((Layout<View>)(object)val36).get_Children().Add((View)(object)val35);
			((ICollection<View>)val37.get_Children()).Add((View)(object)val36);
			((Layout<View>)(object)val40).get_Children().Add((View)(object)val37);
			((BindableObject)val39).SetValue(VisualElement.HeightRequestProperty, (object)2.0);
			val38.set_Key("GrayColor");
			XamlServiceProvider val116 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array13 = new object[0 + 7];
			array13[0] = val39;
			array13[1] = val40;
			array13[2] = shadowFrame;
			array13[3] = val63;
			array13[4] = val64;
			array13[5] = val65;
			array13[6] = testingScheduleView;
			SimpleValueTargetProvider val117 = new SimpleValueTargetProvider(array13, (object)BoxView.ColorProperty, (INameScope)(object)val66);
			object obj13 = (object)val117;
			val116.Add(typeFromHandle25, (object)val117);
			val116.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val118 = new XmlNamespaceResolver();
			val118.Add("", "http://xamarin.com/schemas/2014/forms");
			val118.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val118.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val118.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val118.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val118.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val118.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val116.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val118, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(131, 29)));
			DynamicResource val119 = ((IMarkupExtension<DynamicResource>)(object)val38).ProvideValue((IServiceProvider)val116);
			((IDynamicResourceHandler)val39).SetDynamicResource(BoxView.ColorProperty, val119.get_Key());
			((Layout<View>)(object)val40).get_Children().Add((View)(object)val39);
			((BindableObject)shadowFrame).SetValue(ContentView.ContentProperty, (object)val40);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)shadowFrame);
			((BindableObject)val49).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0));
			val41.set_Path("IsDoingInitialLoad");
			BindingBase val120 = ((IMarkupExtension<BindingBase>)(object)val41).ProvideValue((IServiceProvider)null);
			((BindableObject)val49).SetBinding(VisualElement.IsVisibleProperty, val120);
			val42.set_Path("IsDoingInitialLoad");
			BindingBase val121 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)null);
			((BindableObject)val44).SetBinding(ActivityIndicator.IsRunningProperty, val121);
			((BindableObject)val44).SetValue(VisualElement.HeightRequestProperty, (object)16.0);
			val43.set_Key("SecondaryTextColor");
			XamlServiceProvider val122 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array14 = new object[0 + 6];
			array14[0] = val44;
			array14[1] = val49;
			array14[2] = val63;
			array14[3] = val64;
			array14[4] = val65;
			array14[5] = testingScheduleView;
			SimpleValueTargetProvider val123 = new SimpleValueTargetProvider(array14, (object)ActivityIndicator.ColorProperty, (INameScope)(object)val66);
			object obj14 = (object)val123;
			val122.Add(typeFromHandle27, (object)val123);
			val122.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val124 = new XmlNamespaceResolver();
			val124.Add("", "http://xamarin.com/schemas/2014/forms");
			val124.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val124.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val124.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val124.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val124.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val124.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val122.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val124, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(142, 25)));
			DynamicResource val125 = ((IMarkupExtension<DynamicResource>)(object)val43).ProvideValue((IServiceProvider)val122);
			((IDynamicResourceHandler)val44).SetDynamicResource(ActivityIndicator.ColorProperty, val125.get_Key());
			((BindableObject)val44).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
			((Layout<View>)(object)val49).get_Children().Add((View)(object)val44);
			val45.set_Path("BusyMessage");
			BindingBase val126 = ((IMarkupExtension<BindingBase>)(object)val45).ProvideValue((IServiceProvider)null);
			((BindableObject)val48).SetBinding(Label.TextProperty, val126);
			val46.set_Key("SecondaryTextColor");
			XamlServiceProvider val127 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array15 = new object[0 + 6];
			array15[0] = val48;
			array15[1] = val49;
			array15[2] = val63;
			array15[3] = val64;
			array15[4] = val65;
			array15[5] = testingScheduleView;
			SimpleValueTargetProvider val128 = new SimpleValueTargetProvider(array15, (object)Label.TextColorProperty, (INameScope)(object)val66);
			object obj15 = (object)val128;
			val127.Add(typeFromHandle29, (object)val128);
			val127.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val129 = new XmlNamespaceResolver();
			val129.Add("", "http://xamarin.com/schemas/2014/forms");
			val129.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val129.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val129.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val129.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val129.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val129.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val127.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val129, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val127.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(146, 25)));
			DynamicResource val130 = ((IMarkupExtension<DynamicResource>)(object)val46).ProvideValue((IServiceProvider)val127);
			((IDynamicResourceHandler)val48).SetDynamicResource(Label.TextColorProperty, val130.get_Key());
			val47.set_Key("Small");
			XamlServiceProvider val131 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array16 = new object[0 + 6];
			array16[0] = val48;
			array16[1] = val49;
			array16[2] = val63;
			array16[3] = val64;
			array16[4] = val65;
			array16[5] = testingScheduleView;
			SimpleValueTargetProvider val132 = new SimpleValueTargetProvider(array16, (object)VisualElement.StyleProperty, (INameScope)(object)val66);
			object obj16 = (object)val132;
			val131.Add(typeFromHandle31, (object)val132);
			val131.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val133 = new XmlNamespaceResolver();
			val133.Add("", "http://xamarin.com/schemas/2014/forms");
			val133.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val133.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val133.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val133.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val133.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val133.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val131.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val133, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val131.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(147, 25)));
			DynamicResource val134 = ((IMarkupExtension<DynamicResource>)(object)val47).ProvideValue((IServiceProvider)val131);
			((IDynamicResourceHandler)val48).SetDynamicResource(VisualElement.StyleProperty, val134.get_Key());
			((BindableObject)val48).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((Layout<View>)(object)val49).get_Children().Add((View)(object)val48);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)val49);
			val50.set_Path("TestingScheduleItems");
			BindingBase val135 = ((IMarkupExtension<BindingBase>)(object)val50).ProvideValue((IServiceProvider)null);
			((BindableObject)val52).SetBinding(BindableLayout.ItemsSourceProperty, val135);
			((BindableObject)val52).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val52).SetValue(StackLayout.SpacingProperty, (object)0.0);
			((BindableObject)val52).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0));
			((BindableObject)val52).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			object[] array17 = new object[0 + 6];
			array17[0] = val51;
			array17[1] = val52;
			array17[2] = val63;
			array17[3] = val64;
			array17[4] = val65;
			array17[5] = testingScheduleView;
			object[] parentValues = array17;
			TestingScheduleView root = testingScheduleView;
			((IDataTemplate)val51).set_LoadTemplate((Func<object>)delegate
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
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected O, but got Unknown
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Expected O, but got Unknown
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected O, but got Unknown
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Expected O, but got Unknown
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Expected O, but got Unknown
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Expected O, but got Unknown
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Expected O, but got Unknown
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Expected O, but got Unknown
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Expected O, but got Unknown
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Expected O, but got Unknown
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Expected O, but got Unknown
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Expected O, but got Unknown
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Expected O, but got Unknown
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Expected O, but got Unknown
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Expected O, but got Unknown
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected O, but got Unknown
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e6: Expected O, but got Unknown
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Expected O, but got Unknown
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Expected O, but got Unknown
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Expected O, but got Unknown
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_011d: Expected O, but got Unknown
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Expected O, but got Unknown
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_012b: Expected O, but got Unknown
				//IL_012b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected O, but got Unknown
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0139: Expected O, but got Unknown
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Expected O, but got Unknown
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0147: Expected O, but got Unknown
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Expected O, but got Unknown
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0155: Expected O, but got Unknown
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected O, but got Unknown
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_016d: Expected O, but got Unknown
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017e: Expected O, but got Unknown
				//IL_017e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Expected O, but got Unknown
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected O, but got Unknown
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Expected O, but got Unknown
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Expected O, but got Unknown
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Expected O, but got Unknown
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Expected O, but got Unknown
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Expected O, but got Unknown
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Expected O, but got Unknown
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bd: Expected O, but got Unknown
				//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c4: Expected O, but got Unknown
				//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cb: Expected O, but got Unknown
				//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Expected O, but got Unknown
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d9: Expected O, but got Unknown
				//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e0: Expected O, but got Unknown
				//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e7: Expected O, but got Unknown
				//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Expected O, but got Unknown
				//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f5: Expected O, but got Unknown
				//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fc: Expected O, but got Unknown
				//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0203: Expected O, but got Unknown
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0214: Expected O, but got Unknown
				//IL_021e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Expected O, but got Unknown
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Expected O, but got Unknown
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Expected O, but got Unknown
				//IL_0233: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Expected O, but got Unknown
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Expected O, but got Unknown
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0248: Expected O, but got Unknown
				//IL_0248: Unknown result type (might be due to invalid IL or missing references)
				//IL_024f: Expected O, but got Unknown
				//IL_024f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0256: Expected O, but got Unknown
				//IL_0256: Unknown result type (might be due to invalid IL or missing references)
				//IL_025d: Expected O, but got Unknown
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0264: Expected O, but got Unknown
				//IL_0264: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Expected O, but got Unknown
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027c: Expected O, but got Unknown
				//IL_0286: Unknown result type (might be due to invalid IL or missing references)
				//IL_028d: Expected O, but got Unknown
				//IL_028d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0294: Expected O, but got Unknown
				//IL_029b: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a2: Expected O, but got Unknown
				//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Expected O, but got Unknown
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b0: Expected O, but got Unknown
				//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b7: Expected O, but got Unknown
				//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02be: Expected O, but got Unknown
				//IL_02be: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Expected O, but got Unknown
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cc: Expected O, but got Unknown
				//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d3: Expected O, but got Unknown
				//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02da: Expected O, but got Unknown
				//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02eb: Expected O, but got Unknown
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fc: Expected O, but got Unknown
				//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0303: Expected O, but got Unknown
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Expected O, but got Unknown
				//IL_030a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0311: Expected O, but got Unknown
				//IL_0311: Unknown result type (might be due to invalid IL or missing references)
				//IL_0318: Expected O, but got Unknown
				//IL_0318: Unknown result type (might be due to invalid IL or missing references)
				//IL_031f: Expected O, but got Unknown
				//IL_031f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0326: Expected O, but got Unknown
				//IL_032d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0334: Expected O, but got Unknown
				//IL_0334: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Expected O, but got Unknown
				//IL_033b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0342: Expected O, but got Unknown
				//IL_0342: Unknown result type (might be due to invalid IL or missing references)
				//IL_0349: Expected O, but got Unknown
				//IL_0353: Unknown result type (might be due to invalid IL or missing references)
				//IL_035a: Expected O, but got Unknown
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_036b: Expected O, but got Unknown
				//IL_036b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0372: Expected O, but got Unknown
				//IL_0372: Unknown result type (might be due to invalid IL or missing references)
				//IL_0379: Expected O, but got Unknown
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_0380: Expected O, but got Unknown
				//IL_0380: Unknown result type (might be due to invalid IL or missing references)
				//IL_0387: Expected O, but got Unknown
				//IL_0387: Unknown result type (might be due to invalid IL or missing references)
				//IL_038e: Expected O, but got Unknown
				//IL_038e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0395: Expected O, but got Unknown
				//IL_0395: Unknown result type (might be due to invalid IL or missing references)
				//IL_039c: Expected O, but got Unknown
				//IL_039c: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a3: Expected O, but got Unknown
				//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03aa: Expected O, but got Unknown
				//IL_041f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0426: Expected O, but got Unknown
				//IL_0453: Unknown result type (might be due to invalid IL or missing references)
				//IL_045a: Expected O, but got Unknown
				//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d6: Expected O, but got Unknown
				//IL_0503: Unknown result type (might be due to invalid IL or missing references)
				//IL_050a: Expected O, but got Unknown
				//IL_055b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0562: Expected O, but got Unknown
				//IL_056b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0572: Expected O, but got Unknown
				//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0600: Unknown result type (might be due to invalid IL or missing references)
				//IL_062c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0658: Unknown result type (might be due to invalid IL or missing references)
				//IL_0685: Unknown result type (might be due to invalid IL or missing references)
				//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0744: Unknown result type (might be due to invalid IL or missing references)
				//IL_0761: Unknown result type (might be due to invalid IL or missing references)
				//IL_0766: Unknown result type (might be due to invalid IL or missing references)
				//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_07b1: Expected O, but got Unknown
				//IL_07b6: Expected O, but got Unknown
				//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0808: Unknown result type (might be due to invalid IL or missing references)
				//IL_0818: Unknown result type (might be due to invalid IL or missing references)
				//IL_0828: Unknown result type (might be due to invalid IL or missing references)
				//IL_0838: Unknown result type (might be due to invalid IL or missing references)
				//IL_0861: Expected O, but got Unknown
				//IL_085c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0866: Expected O, but got Unknown
				//IL_0866: Unknown result type (might be due to invalid IL or missing references)
				//IL_0878: Unknown result type (might be due to invalid IL or missing references)
				//IL_0882: Expected O, but got Unknown
				//IL_087d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0887: Expected O, but got Unknown
				//IL_088c: Expected O, but got Unknown
				//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_094c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0951: Unknown result type (might be due to invalid IL or missing references)
				//IL_0954: Expected O, but got Unknown
				//IL_0959: Expected O, but got Unknown
				//IL_0959: Unknown result type (might be due to invalid IL or missing references)
				//IL_096b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0976: Unknown result type (might be due to invalid IL or missing references)
				//IL_097b: Unknown result type (might be due to invalid IL or missing references)
				//IL_098b: Unknown result type (might be due to invalid IL or missing references)
				//IL_099b: Unknown result type (might be due to invalid IL or missing references)
				//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_09db: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a04: Expected O, but got Unknown
				//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a09: Expected O, but got Unknown
				//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a25: Expected O, but got Unknown
				//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a2a: Expected O, but got Unknown
				//IL_0a2f: Expected O, but got Unknown
				//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
				//IL_0be1: Expected O, but got Unknown
				//IL_0be6: Expected O, but got Unknown
				//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c91: Expected O, but got Unknown
				//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c96: Expected O, but got Unknown
				//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cb2: Expected O, but got Unknown
				//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cb7: Expected O, but got Unknown
				//IL_0cbc: Expected O, but got Unknown
				//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e29: Expected O, but got Unknown
				//IL_0e2e: Expected O, but got Unknown
				//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ed9: Expected O, but got Unknown
				//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ede: Expected O, but got Unknown
				//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0efa: Expected O, but got Unknown
				//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eff: Expected O, but got Unknown
				//IL_0f04: Expected O, but got Unknown
				//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fba: Expected O, but got Unknown
				//IL_0fbf: Expected O, but got Unknown
				//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ff1: Unknown result type (might be due to invalid IL or missing references)
				//IL_1001: Unknown result type (might be due to invalid IL or missing references)
				//IL_1011: Unknown result type (might be due to invalid IL or missing references)
				//IL_1021: Unknown result type (might be due to invalid IL or missing references)
				//IL_1031: Unknown result type (might be due to invalid IL or missing references)
				//IL_1041: Unknown result type (might be due to invalid IL or missing references)
				//IL_106a: Expected O, but got Unknown
				//IL_1065: Unknown result type (might be due to invalid IL or missing references)
				//IL_106f: Expected O, but got Unknown
				//IL_106f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1081: Unknown result type (might be due to invalid IL or missing references)
				//IL_108b: Expected O, but got Unknown
				//IL_1086: Unknown result type (might be due to invalid IL or missing references)
				//IL_1090: Expected O, but got Unknown
				//IL_1095: Expected O, but got Unknown
				//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_1162: Unknown result type (might be due to invalid IL or missing references)
				//IL_1167: Unknown result type (might be due to invalid IL or missing references)
				//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_11d5: Expected O, but got Unknown
				//IL_11da: Expected O, but got Unknown
				//IL_11da: Unknown result type (might be due to invalid IL or missing references)
				//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_11f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_11fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_120c: Unknown result type (might be due to invalid IL or missing references)
				//IL_121c: Unknown result type (might be due to invalid IL or missing references)
				//IL_122c: Unknown result type (might be due to invalid IL or missing references)
				//IL_123c: Unknown result type (might be due to invalid IL or missing references)
				//IL_124c: Unknown result type (might be due to invalid IL or missing references)
				//IL_125c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1285: Expected O, but got Unknown
				//IL_1280: Unknown result type (might be due to invalid IL or missing references)
				//IL_128a: Expected O, but got Unknown
				//IL_128a: Unknown result type (might be due to invalid IL or missing references)
				//IL_129c: Unknown result type (might be due to invalid IL or missing references)
				//IL_12a6: Expected O, but got Unknown
				//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_12ab: Expected O, but got Unknown
				//IL_12b0: Expected O, but got Unknown
				//IL_1301: Unknown result type (might be due to invalid IL or missing references)
				//IL_1306: Unknown result type (might be due to invalid IL or missing references)
				//IL_134e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1353: Unknown result type (might be due to invalid IL or missing references)
				//IL_1356: Expected O, but got Unknown
				//IL_135b: Expected O, but got Unknown
				//IL_135b: Unknown result type (might be due to invalid IL or missing references)
				//IL_136d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1378: Unknown result type (might be due to invalid IL or missing references)
				//IL_137d: Unknown result type (might be due to invalid IL or missing references)
				//IL_138d: Unknown result type (might be due to invalid IL or missing references)
				//IL_139d: Unknown result type (might be due to invalid IL or missing references)
				//IL_13ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_1406: Expected O, but got Unknown
				//IL_1401: Unknown result type (might be due to invalid IL or missing references)
				//IL_140b: Expected O, but got Unknown
				//IL_140b: Unknown result type (might be due to invalid IL or missing references)
				//IL_141d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1427: Expected O, but got Unknown
				//IL_1422: Unknown result type (might be due to invalid IL or missing references)
				//IL_142c: Expected O, but got Unknown
				//IL_1431: Expected O, but got Unknown
				//IL_1443: Unknown result type (might be due to invalid IL or missing references)
				//IL_144d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1452: Unknown result type (might be due to invalid IL or missing references)
				//IL_149a: Unknown result type (might be due to invalid IL or missing references)
				//IL_149f: Unknown result type (might be due to invalid IL or missing references)
				//IL_14a2: Expected O, but got Unknown
				//IL_14a7: Expected O, but got Unknown
				//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_14c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_14f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_1509: Unknown result type (might be due to invalid IL or missing references)
				//IL_1519: Unknown result type (might be due to invalid IL or missing references)
				//IL_1529: Unknown result type (might be due to invalid IL or missing references)
				//IL_1552: Expected O, but got Unknown
				//IL_154d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1557: Expected O, but got Unknown
				//IL_1557: Unknown result type (might be due to invalid IL or missing references)
				//IL_1569: Unknown result type (might be due to invalid IL or missing references)
				//IL_1573: Expected O, but got Unknown
				//IL_156e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1578: Expected O, but got Unknown
				//IL_157d: Expected O, but got Unknown
				//IL_159a: Unknown result type (might be due to invalid IL or missing references)
				//IL_15b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_15d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_1633: Unknown result type (might be due to invalid IL or missing references)
				//IL_1638: Unknown result type (might be due to invalid IL or missing references)
				//IL_163b: Expected O, but got Unknown
				//IL_1640: Expected O, but got Unknown
				//IL_1640: Unknown result type (might be due to invalid IL or missing references)
				//IL_1652: Unknown result type (might be due to invalid IL or missing references)
				//IL_165d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1662: Unknown result type (might be due to invalid IL or missing references)
				//IL_1672: Unknown result type (might be due to invalid IL or missing references)
				//IL_1682: Unknown result type (might be due to invalid IL or missing references)
				//IL_1692: Unknown result type (might be due to invalid IL or missing references)
				//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_16eb: Expected O, but got Unknown
				//IL_16e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_16f0: Expected O, but got Unknown
				//IL_16f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_1702: Unknown result type (might be due to invalid IL or missing references)
				//IL_170c: Expected O, but got Unknown
				//IL_1707: Unknown result type (might be due to invalid IL or missing references)
				//IL_1711: Expected O, but got Unknown
				//IL_1716: Expected O, but got Unknown
				//IL_1753: Unknown result type (might be due to invalid IL or missing references)
				//IL_1758: Unknown result type (might be due to invalid IL or missing references)
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
				//IL_1924: Unknown result type (might be due to invalid IL or missing references)
				//IL_1929: Unknown result type (might be due to invalid IL or missing references)
				//IL_198f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1994: Unknown result type (might be due to invalid IL or missing references)
				//IL_1997: Expected O, but got Unknown
				//IL_199c: Expected O, but got Unknown
				//IL_199c: Unknown result type (might be due to invalid IL or missing references)
				//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_19b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_19be: Unknown result type (might be due to invalid IL or missing references)
				//IL_19ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_19de: Unknown result type (might be due to invalid IL or missing references)
				//IL_19ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_19fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a0e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a1e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a47: Expected O, but got Unknown
				//IL_1a42: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a4c: Expected O, but got Unknown
				//IL_1a4c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a5e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a68: Expected O, but got Unknown
				//IL_1a63: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a6d: Expected O, but got Unknown
				//IL_1a72: Expected O, but got Unknown
				//IL_1ac3: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b18: Expected O, but got Unknown
				//IL_1b1d: Expected O, but got Unknown
				//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b2f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b3a: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b3f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b4f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b5f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b6f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b7f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b8f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b9f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1bc8: Expected O, but got Unknown
				//IL_1bc3: Unknown result type (might be due to invalid IL or missing references)
				//IL_1bcd: Expected O, but got Unknown
				//IL_1bcd: Unknown result type (might be due to invalid IL or missing references)
				//IL_1bdf: Unknown result type (might be due to invalid IL or missing references)
				//IL_1be9: Expected O, but got Unknown
				//IL_1be4: Unknown result type (might be due to invalid IL or missing references)
				//IL_1bee: Expected O, but got Unknown
				//IL_1bf3: Expected O, but got Unknown
				//IL_1c05: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c0f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c14: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c5c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c61: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c64: Expected O, but got Unknown
				//IL_1c69: Expected O, but got Unknown
				//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c9b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1cab: Unknown result type (might be due to invalid IL or missing references)
				//IL_1cbb: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ccb: Unknown result type (might be due to invalid IL or missing references)
				//IL_1cdb: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ceb: Unknown result type (might be due to invalid IL or missing references)
				//IL_1d14: Expected O, but got Unknown
				//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1d19: Expected O, but got Unknown
				//IL_1d19: Unknown result type (might be due to invalid IL or missing references)
				//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1d35: Expected O, but got Unknown
				//IL_1d30: Unknown result type (might be due to invalid IL or missing references)
				//IL_1d3a: Expected O, but got Unknown
				//IL_1d3f: Expected O, but got Unknown
				//IL_1d4b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1d66: Unknown result type (might be due to invalid IL or missing references)
				//IL_1dbd: Unknown result type (might be due to invalid IL or missing references)
				//IL_1dc2: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e0f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e12: Expected O, but got Unknown
				//IL_1e17: Expected O, but got Unknown
				//IL_1e17: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e29: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e34: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e49: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e59: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e69: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e79: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e89: Unknown result type (might be due to invalid IL or missing references)
				//IL_1e99: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ec2: Expected O, but got Unknown
				//IL_1ebd: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ec7: Expected O, but got Unknown
				//IL_1ec7: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ed9: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ee3: Expected O, but got Unknown
				//IL_1ede: Unknown result type (might be due to invalid IL or missing references)
				//IL_1ee8: Expected O, but got Unknown
				//IL_1eed: Expected O, but got Unknown
				//IL_1f2e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1fa6: Unknown result type (might be due to invalid IL or missing references)
				//IL_1fd4: Unknown result type (might be due to invalid IL or missing references)
				//IL_201d: Unknown result type (might be due to invalid IL or missing references)
				//IL_2033: Unknown result type (might be due to invalid IL or missing references)
				//IL_2049: Unknown result type (might be due to invalid IL or missing references)
				//IL_209a: Unknown result type (might be due to invalid IL or missing references)
				//IL_209f: Unknown result type (might be due to invalid IL or missing references)
				//IL_20e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_20ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_20ef: Expected O, but got Unknown
				//IL_20f4: Expected O, but got Unknown
				//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_2106: Unknown result type (might be due to invalid IL or missing references)
				//IL_2111: Unknown result type (might be due to invalid IL or missing references)
				//IL_2116: Unknown result type (might be due to invalid IL or missing references)
				//IL_2126: Unknown result type (might be due to invalid IL or missing references)
				//IL_2136: Unknown result type (might be due to invalid IL or missing references)
				//IL_2146: Unknown result type (might be due to invalid IL or missing references)
				//IL_2156: Unknown result type (might be due to invalid IL or missing references)
				//IL_2166: Unknown result type (might be due to invalid IL or missing references)
				//IL_2176: Unknown result type (might be due to invalid IL or missing references)
				//IL_219f: Expected O, but got Unknown
				//IL_219a: Unknown result type (might be due to invalid IL or missing references)
				//IL_21a4: Expected O, but got Unknown
				//IL_21a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_21b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_21c0: Expected O, but got Unknown
				//IL_21bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_21c5: Expected O, but got Unknown
				//IL_21ca: Expected O, but got Unknown
				//IL_2257: Unknown result type (might be due to invalid IL or missing references)
				//IL_225c: Unknown result type (might be due to invalid IL or missing references)
				//IL_22a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_22a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_22ac: Expected O, but got Unknown
				//IL_22b1: Expected O, but got Unknown
				//IL_22b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_22c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_22ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_22d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_22e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_22f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_2303: Unknown result type (might be due to invalid IL or missing references)
				//IL_2313: Unknown result type (might be due to invalid IL or missing references)
				//IL_2323: Unknown result type (might be due to invalid IL or missing references)
				//IL_2333: Unknown result type (might be due to invalid IL or missing references)
				//IL_235c: Expected O, but got Unknown
				//IL_2357: Unknown result type (might be due to invalid IL or missing references)
				//IL_2361: Expected O, but got Unknown
				//IL_2361: Unknown result type (might be due to invalid IL or missing references)
				//IL_2373: Unknown result type (might be due to invalid IL or missing references)
				//IL_237d: Expected O, but got Unknown
				//IL_2378: Unknown result type (might be due to invalid IL or missing references)
				//IL_2382: Expected O, but got Unknown
				//IL_2387: Expected O, but got Unknown
				//IL_23ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_23cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_23e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_23ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_2435: Unknown result type (might be due to invalid IL or missing references)
				//IL_243a: Unknown result type (might be due to invalid IL or missing references)
				//IL_243d: Expected O, but got Unknown
				//IL_2442: Expected O, but got Unknown
				//IL_2442: Unknown result type (might be due to invalid IL or missing references)
				//IL_2454: Unknown result type (might be due to invalid IL or missing references)
				//IL_245f: Unknown result type (might be due to invalid IL or missing references)
				//IL_2464: Unknown result type (might be due to invalid IL or missing references)
				//IL_2474: Unknown result type (might be due to invalid IL or missing references)
				//IL_2484: Unknown result type (might be due to invalid IL or missing references)
				//IL_2494: Unknown result type (might be due to invalid IL or missing references)
				//IL_24a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_24b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_24c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_24ed: Expected O, but got Unknown
				//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_24f2: Expected O, but got Unknown
				//IL_24f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_2504: Unknown result type (might be due to invalid IL or missing references)
				//IL_250e: Expected O, but got Unknown
				//IL_2509: Unknown result type (might be due to invalid IL or missing references)
				//IL_2513: Expected O, but got Unknown
				//IL_2518: Expected O, but got Unknown
				//IL_2534: Unknown result type (might be due to invalid IL or missing references)
				//IL_254a: Unknown result type (might be due to invalid IL or missing references)
				//IL_25e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_25ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_2650: Unknown result type (might be due to invalid IL or missing references)
				//IL_2655: Unknown result type (might be due to invalid IL or missing references)
				//IL_2658: Expected O, but got Unknown
				//IL_265d: Expected O, but got Unknown
				//IL_265d: Unknown result type (might be due to invalid IL or missing references)
				//IL_266f: Unknown result type (might be due to invalid IL or missing references)
				//IL_267a: Unknown result type (might be due to invalid IL or missing references)
				//IL_267f: Unknown result type (might be due to invalid IL or missing references)
				//IL_268f: Unknown result type (might be due to invalid IL or missing references)
				//IL_269f: Unknown result type (might be due to invalid IL or missing references)
				//IL_26af: Unknown result type (might be due to invalid IL or missing references)
				//IL_26bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_26cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_26df: Unknown result type (might be due to invalid IL or missing references)
				//IL_2708: Expected O, but got Unknown
				//IL_2703: Unknown result type (might be due to invalid IL or missing references)
				//IL_270d: Expected O, but got Unknown
				//IL_270d: Unknown result type (might be due to invalid IL or missing references)
				//IL_271f: Unknown result type (might be due to invalid IL or missing references)
				//IL_2729: Expected O, but got Unknown
				//IL_2724: Unknown result type (might be due to invalid IL or missing references)
				//IL_272e: Expected O, but got Unknown
				//IL_2733: Expected O, but got Unknown
				//IL_2788: Unknown result type (might be due to invalid IL or missing references)
				//IL_278d: Unknown result type (might be due to invalid IL or missing references)
				//IL_27da: Unknown result type (might be due to invalid IL or missing references)
				//IL_27df: Unknown result type (might be due to invalid IL or missing references)
				//IL_27e2: Expected O, but got Unknown
				//IL_27e7: Expected O, but got Unknown
				//IL_27e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_27f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_2804: Unknown result type (might be due to invalid IL or missing references)
				//IL_2809: Unknown result type (might be due to invalid IL or missing references)
				//IL_2819: Unknown result type (might be due to invalid IL or missing references)
				//IL_2829: Unknown result type (might be due to invalid IL or missing references)
				//IL_2839: Unknown result type (might be due to invalid IL or missing references)
				//IL_2849: Unknown result type (might be due to invalid IL or missing references)
				//IL_2859: Unknown result type (might be due to invalid IL or missing references)
				//IL_2869: Unknown result type (might be due to invalid IL or missing references)
				//IL_2892: Expected O, but got Unknown
				//IL_288d: Unknown result type (might be due to invalid IL or missing references)
				//IL_2897: Expected O, but got Unknown
				//IL_2897: Unknown result type (might be due to invalid IL or missing references)
				//IL_28a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_28b3: Expected O, but got Unknown
				//IL_28ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_28b8: Expected O, but got Unknown
				//IL_28bd: Expected O, but got Unknown
				//IL_28cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_28d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_28de: Unknown result type (might be due to invalid IL or missing references)
				//IL_292b: Unknown result type (might be due to invalid IL or missing references)
				//IL_2930: Unknown result type (might be due to invalid IL or missing references)
				//IL_2933: Expected O, but got Unknown
				//IL_2938: Expected O, but got Unknown
				//IL_2938: Unknown result type (might be due to invalid IL or missing references)
				//IL_294a: Unknown result type (might be due to invalid IL or missing references)
				//IL_2955: Unknown result type (might be due to invalid IL or missing references)
				//IL_295a: Unknown result type (might be due to invalid IL or missing references)
				//IL_296a: Unknown result type (might be due to invalid IL or missing references)
				//IL_297a: Unknown result type (might be due to invalid IL or missing references)
				//IL_298a: Unknown result type (might be due to invalid IL or missing references)
				//IL_299a: Unknown result type (might be due to invalid IL or missing references)
				//IL_29aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_29ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_29e3: Expected O, but got Unknown
				//IL_29de: Unknown result type (might be due to invalid IL or missing references)
				//IL_29e8: Expected O, but got Unknown
				//IL_29e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_29fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_2a04: Expected O, but got Unknown
				//IL_29ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_2a09: Expected O, but got Unknown
				//IL_2a0e: Expected O, but got Unknown
				//IL_2a1a: Unknown result type (might be due to invalid IL or missing references)
				//IL_2a35: Unknown result type (might be due to invalid IL or missing references)
				//IL_2a57: Unknown result type (might be due to invalid IL or missing references)
				//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
				//IL_2aa9: Unknown result type (might be due to invalid IL or missing references)
				//IL_2aae: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ab1: Expected O, but got Unknown
				//IL_2ab6: Expected O, but got Unknown
				//IL_2ab6: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ac8: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ad3: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ad8: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ae8: Unknown result type (might be due to invalid IL or missing references)
				//IL_2af8: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b08: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b18: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b28: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b38: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b61: Expected O, but got Unknown
				//IL_2b5c: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b66: Expected O, but got Unknown
				//IL_2b66: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b78: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b82: Expected O, but got Unknown
				//IL_2b7d: Unknown result type (might be due to invalid IL or missing references)
				//IL_2b87: Expected O, but got Unknown
				//IL_2b8c: Expected O, but got Unknown
				//IL_2baf: Unknown result type (might be due to invalid IL or missing references)
				//IL_2bb4: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c15: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c1a: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c1d: Expected O, but got Unknown
				//IL_2c22: Expected O, but got Unknown
				//IL_2c22: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c34: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c3f: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c44: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c54: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c64: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c74: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c84: Unknown result type (might be due to invalid IL or missing references)
				//IL_2c94: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ca4: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ccd: Expected O, but got Unknown
				//IL_2cc8: Unknown result type (might be due to invalid IL or missing references)
				//IL_2cd2: Expected O, but got Unknown
				//IL_2cd2: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ce4: Unknown result type (might be due to invalid IL or missing references)
				//IL_2cee: Expected O, but got Unknown
				//IL_2ce9: Unknown result type (might be due to invalid IL or missing references)
				//IL_2cf3: Expected O, but got Unknown
				//IL_2cf8: Expected O, but got Unknown
				//IL_2dc4: Unknown result type (might be due to invalid IL or missing references)
				//IL_2dc9: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e34: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e39: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e3c: Expected O, but got Unknown
				//IL_2e41: Expected O, but got Unknown
				//IL_2e41: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e53: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e5e: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e63: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e73: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e83: Unknown result type (might be due to invalid IL or missing references)
				//IL_2e93: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ea3: Unknown result type (might be due to invalid IL or missing references)
				//IL_2eb3: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ec3: Unknown result type (might be due to invalid IL or missing references)
				//IL_2eec: Expected O, but got Unknown
				//IL_2ee7: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ef1: Expected O, but got Unknown
				//IL_2ef1: Unknown result type (might be due to invalid IL or missing references)
				//IL_2f03: Unknown result type (might be due to invalid IL or missing references)
				//IL_2f0d: Expected O, but got Unknown
				//IL_2f08: Unknown result type (might be due to invalid IL or missing references)
				//IL_2f12: Expected O, but got Unknown
				//IL_2f17: Expected O, but got Unknown
				//IL_2f88: Unknown result type (might be due to invalid IL or missing references)
				//IL_2f8d: Unknown result type (might be due to invalid IL or missing references)
				//IL_2fd5: Unknown result type (might be due to invalid IL or missing references)
				//IL_2fda: Unknown result type (might be due to invalid IL or missing references)
				//IL_2fdd: Expected O, but got Unknown
				//IL_2fe2: Expected O, but got Unknown
				//IL_2fe2: Unknown result type (might be due to invalid IL or missing references)
				//IL_2ff4: Unknown result type (might be due to invalid IL or missing references)
				//IL_2fff: Unknown result type (might be due to invalid IL or missing references)
				//IL_3004: Unknown result type (might be due to invalid IL or missing references)
				//IL_3014: Unknown result type (might be due to invalid IL or missing references)
				//IL_3024: Unknown result type (might be due to invalid IL or missing references)
				//IL_3034: Unknown result type (might be due to invalid IL or missing references)
				//IL_3044: Unknown result type (might be due to invalid IL or missing references)
				//IL_3054: Unknown result type (might be due to invalid IL or missing references)
				//IL_3064: Unknown result type (might be due to invalid IL or missing references)
				//IL_308d: Expected O, but got Unknown
				//IL_3088: Unknown result type (might be due to invalid IL or missing references)
				//IL_3092: Expected O, but got Unknown
				//IL_3092: Unknown result type (might be due to invalid IL or missing references)
				//IL_30a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_30ae: Expected O, but got Unknown
				//IL_30a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_30b3: Expected O, but got Unknown
				//IL_30b8: Expected O, but got Unknown
				//IL_30ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_30d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_30d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_3121: Unknown result type (might be due to invalid IL or missing references)
				//IL_3126: Unknown result type (might be due to invalid IL or missing references)
				//IL_3129: Expected O, but got Unknown
				//IL_312e: Expected O, but got Unknown
				//IL_312e: Unknown result type (might be due to invalid IL or missing references)
				//IL_3140: Unknown result type (might be due to invalid IL or missing references)
				//IL_314b: Unknown result type (might be due to invalid IL or missing references)
				//IL_3150: Unknown result type (might be due to invalid IL or missing references)
				//IL_3160: Unknown result type (might be due to invalid IL or missing references)
				//IL_3170: Unknown result type (might be due to invalid IL or missing references)
				//IL_3180: Unknown result type (might be due to invalid IL or missing references)
				//IL_3190: Unknown result type (might be due to invalid IL or missing references)
				//IL_31a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_31b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_31d9: Expected O, but got Unknown
				//IL_31d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_31de: Expected O, but got Unknown
				//IL_31de: Unknown result type (might be due to invalid IL or missing references)
				//IL_31f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_31fa: Expected O, but got Unknown
				//IL_31f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_31ff: Expected O, but got Unknown
				//IL_3204: Expected O, but got Unknown
				//IL_3221: Unknown result type (might be due to invalid IL or missing references)
				//IL_323c: Unknown result type (might be due to invalid IL or missing references)
				//IL_3282: Unknown result type (might be due to invalid IL or missing references)
				//IL_3287: Unknown result type (might be due to invalid IL or missing references)
				//IL_32cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_32d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_32d7: Expected O, but got Unknown
				//IL_32dc: Expected O, but got Unknown
				//IL_32dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_32ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_32f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_330e: Unknown result type (might be due to invalid IL or missing references)
				//IL_331e: Unknown result type (might be due to invalid IL or missing references)
				//IL_332e: Unknown result type (might be due to invalid IL or missing references)
				//IL_333e: Unknown result type (might be due to invalid IL or missing references)
				//IL_334e: Unknown result type (might be due to invalid IL or missing references)
				//IL_335e: Unknown result type (might be due to invalid IL or missing references)
				//IL_3387: Expected O, but got Unknown
				//IL_3382: Unknown result type (might be due to invalid IL or missing references)
				//IL_338c: Expected O, but got Unknown
				//IL_338c: Unknown result type (might be due to invalid IL or missing references)
				//IL_339e: Unknown result type (might be due to invalid IL or missing references)
				//IL_33a8: Expected O, but got Unknown
				//IL_33a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_33ad: Expected O, but got Unknown
				//IL_33b2: Expected O, but got Unknown
				//IL_33f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_353c: Unknown result type (might be due to invalid IL or missing references)
				//IL_3552: Unknown result type (might be due to invalid IL or missing references)
				//IL_3574: Unknown result type (might be due to invalid IL or missing references)
				//IL_3579: Unknown result type (might be due to invalid IL or missing references)
				//IL_35c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_35cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_35ce: Expected O, but got Unknown
				//IL_35d3: Expected O, but got Unknown
				//IL_35d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_35e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_35f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_35f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_3605: Unknown result type (might be due to invalid IL or missing references)
				//IL_3615: Unknown result type (might be due to invalid IL or missing references)
				//IL_3625: Unknown result type (might be due to invalid IL or missing references)
				//IL_3635: Unknown result type (might be due to invalid IL or missing references)
				//IL_3645: Unknown result type (might be due to invalid IL or missing references)
				//IL_3655: Unknown result type (might be due to invalid IL or missing references)
				//IL_367e: Expected O, but got Unknown
				//IL_3679: Unknown result type (might be due to invalid IL or missing references)
				//IL_3683: Expected O, but got Unknown
				//IL_3683: Unknown result type (might be due to invalid IL or missing references)
				//IL_3695: Unknown result type (might be due to invalid IL or missing references)
				//IL_369f: Expected O, but got Unknown
				//IL_369a: Unknown result type (might be due to invalid IL or missing references)
				//IL_36a4: Expected O, but got Unknown
				//IL_36a9: Expected O, but got Unknown
				//IL_36cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_36d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_371e: Unknown result type (might be due to invalid IL or missing references)
				//IL_3723: Unknown result type (might be due to invalid IL or missing references)
				//IL_3726: Expected O, but got Unknown
				//IL_372b: Expected O, but got Unknown
				//IL_372b: Unknown result type (might be due to invalid IL or missing references)
				//IL_373d: Unknown result type (might be due to invalid IL or missing references)
				//IL_3748: Unknown result type (might be due to invalid IL or missing references)
				//IL_374d: Unknown result type (might be due to invalid IL or missing references)
				//IL_375d: Unknown result type (might be due to invalid IL or missing references)
				//IL_376d: Unknown result type (might be due to invalid IL or missing references)
				//IL_377d: Unknown result type (might be due to invalid IL or missing references)
				//IL_378d: Unknown result type (might be due to invalid IL or missing references)
				//IL_379d: Unknown result type (might be due to invalid IL or missing references)
				//IL_37ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_37d6: Expected O, but got Unknown
				//IL_37d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_37db: Expected O, but got Unknown
				//IL_37db: Unknown result type (might be due to invalid IL or missing references)
				//IL_37ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_37f7: Expected O, but got Unknown
				//IL_37f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_37fc: Expected O, but got Unknown
				//IL_3801: Expected O, but got Unknown
				//IL_3845: Unknown result type (might be due to invalid IL or missing references)
				//IL_3881: Unknown result type (might be due to invalid IL or missing references)
				//IL_3886: Unknown result type (might be due to invalid IL or missing references)
				//IL_38d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_38d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_38db: Expected O, but got Unknown
				//IL_38e0: Expected O, but got Unknown
				//IL_38e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_38f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_38fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_3902: Unknown result type (might be due to invalid IL or missing references)
				//IL_3912: Unknown result type (might be due to invalid IL or missing references)
				//IL_3922: Unknown result type (might be due to invalid IL or missing references)
				//IL_3932: Unknown result type (might be due to invalid IL or missing references)
				//IL_3942: Unknown result type (might be due to invalid IL or missing references)
				//IL_3952: Unknown result type (might be due to invalid IL or missing references)
				//IL_3962: Unknown result type (might be due to invalid IL or missing references)
				//IL_398b: Expected O, but got Unknown
				//IL_3986: Unknown result type (might be due to invalid IL or missing references)
				//IL_3990: Expected O, but got Unknown
				//IL_3990: Unknown result type (might be due to invalid IL or missing references)
				//IL_39a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_39ac: Expected O, but got Unknown
				//IL_39a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_39b1: Expected O, but got Unknown
				//IL_39b6: Expected O, but got Unknown
				//IL_39ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_39f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_39fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a45: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a4a: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a4d: Expected O, but got Unknown
				//IL_3a52: Expected O, but got Unknown
				//IL_3a52: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a64: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a6f: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a74: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a84: Unknown result type (might be due to invalid IL or missing references)
				//IL_3a94: Unknown result type (might be due to invalid IL or missing references)
				//IL_3aa4: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ab4: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ac4: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ad4: Unknown result type (might be due to invalid IL or missing references)
				//IL_3afd: Expected O, but got Unknown
				//IL_3af8: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b02: Expected O, but got Unknown
				//IL_3b02: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b14: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b1e: Expected O, but got Unknown
				//IL_3b19: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b23: Expected O, but got Unknown
				//IL_3b28: Expected O, but got Unknown
				//IL_3b34: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b4f: Unknown result type (might be due to invalid IL or missing references)
				//IL_3b8e: Unknown result type (might be due to invalid IL or missing references)
				//IL_3bb9: Unknown result type (might be due to invalid IL or missing references)
				//IL_3bbe: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c06: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c0b: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c0e: Expected O, but got Unknown
				//IL_3c13: Expected O, but got Unknown
				//IL_3c13: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c25: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c30: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c35: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c45: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c55: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c65: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c75: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c85: Unknown result type (might be due to invalid IL or missing references)
				//IL_3c95: Unknown result type (might be due to invalid IL or missing references)
				//IL_3cbe: Expected O, but got Unknown
				//IL_3cb9: Unknown result type (might be due to invalid IL or missing references)
				//IL_3cc3: Expected O, but got Unknown
				//IL_3cc3: Unknown result type (might be due to invalid IL or missing references)
				//IL_3cd5: Unknown result type (might be due to invalid IL or missing references)
				//IL_3cdf: Expected O, but got Unknown
				//IL_3cda: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ce4: Expected O, but got Unknown
				//IL_3ce9: Expected O, but got Unknown
				//IL_3d4b: Unknown result type (might be due to invalid IL or missing references)
				//IL_3d50: Unknown result type (might be due to invalid IL or missing references)
				//IL_3dc0: Unknown result type (might be due to invalid IL or missing references)
				//IL_3dc5: Unknown result type (might be due to invalid IL or missing references)
				//IL_3dca: Expected O, but got Unknown
				//IL_3dcf: Expected O, but got Unknown
				//IL_3dcf: Unknown result type (might be due to invalid IL or missing references)
				//IL_3de3: Unknown result type (might be due to invalid IL or missing references)
				//IL_3dee: Unknown result type (might be due to invalid IL or missing references)
				//IL_3df3: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e03: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e13: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e23: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e33: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e43: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e53: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e7c: Expected O, but got Unknown
				//IL_3e77: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e81: Expected O, but got Unknown
				//IL_3e81: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e93: Unknown result type (might be due to invalid IL or missing references)
				//IL_3e9d: Expected O, but got Unknown
				//IL_3e98: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ea2: Expected O, but got Unknown
				//IL_3ea7: Expected O, but got Unknown
				//IL_3f4a: Unknown result type (might be due to invalid IL or missing references)
				//IL_3f67: Unknown result type (might be due to invalid IL or missing references)
				//IL_3f6c: Unknown result type (might be due to invalid IL or missing references)
				//IL_3fcd: Unknown result type (might be due to invalid IL or missing references)
				//IL_3fd2: Unknown result type (might be due to invalid IL or missing references)
				//IL_3fd7: Expected O, but got Unknown
				//IL_3fdc: Expected O, but got Unknown
				//IL_3fdc: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ff0: Unknown result type (might be due to invalid IL or missing references)
				//IL_3ffb: Unknown result type (might be due to invalid IL or missing references)
				//IL_4000: Unknown result type (might be due to invalid IL or missing references)
				//IL_4010: Unknown result type (might be due to invalid IL or missing references)
				//IL_4020: Unknown result type (might be due to invalid IL or missing references)
				//IL_4030: Unknown result type (might be due to invalid IL or missing references)
				//IL_4040: Unknown result type (might be due to invalid IL or missing references)
				//IL_4050: Unknown result type (might be due to invalid IL or missing references)
				//IL_4060: Unknown result type (might be due to invalid IL or missing references)
				//IL_4089: Expected O, but got Unknown
				//IL_4084: Unknown result type (might be due to invalid IL or missing references)
				//IL_408e: Expected O, but got Unknown
				//IL_408e: Unknown result type (might be due to invalid IL or missing references)
				//IL_40a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_40aa: Expected O, but got Unknown
				//IL_40a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_40af: Expected O, but got Unknown
				//IL_40b4: Expected O, but got Unknown
				//IL_40f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_4108: Unknown result type (might be due to invalid IL or missing references)
				//IL_4159: Unknown result type (might be due to invalid IL or missing references)
				//IL_415e: Unknown result type (might be due to invalid IL or missing references)
				//IL_41b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_41b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_41ba: Expected O, but got Unknown
				//IL_41bf: Expected O, but got Unknown
				//IL_41bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_41d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_41de: Unknown result type (might be due to invalid IL or missing references)
				//IL_41e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_41f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_4203: Unknown result type (might be due to invalid IL or missing references)
				//IL_4213: Unknown result type (might be due to invalid IL or missing references)
				//IL_4223: Unknown result type (might be due to invalid IL or missing references)
				//IL_4233: Unknown result type (might be due to invalid IL or missing references)
				//IL_4243: Unknown result type (might be due to invalid IL or missing references)
				//IL_426c: Expected O, but got Unknown
				//IL_4267: Unknown result type (might be due to invalid IL or missing references)
				//IL_4271: Expected O, but got Unknown
				//IL_4271: Unknown result type (might be due to invalid IL or missing references)
				//IL_4283: Unknown result type (might be due to invalid IL or missing references)
				//IL_428d: Expected O, but got Unknown
				//IL_4288: Unknown result type (might be due to invalid IL or missing references)
				//IL_4292: Expected O, but got Unknown
				//IL_4297: Expected O, but got Unknown
				RowDefinition val149 = new RowDefinition();
				RowDefinition val150 = new RowDefinition();
				ColumnDefinition val151 = new ColumnDefinition();
				ColumnDefinition val152 = new ColumnDefinition();
				ColumnDefinition val153 = new ColumnDefinition();
				ColumnDefinition val154 = new ColumnDefinition();
				DynamicResourceExtension val155 = new DynamicResourceExtension();
				BindingExtension val156 = new BindingExtension();
				DynamicResourceExtension val157 = new DynamicResourceExtension();
				Setter val158 = new Setter();
				DataTrigger val159 = new DataTrigger(typeof(BoxView));
				BindingExtension val160 = new BindingExtension();
				BindingCondition val161 = new BindingCondition();
				BindingExtension val162 = new BindingExtension();
				BindingCondition val163 = new BindingCondition();
				Setter val164 = new Setter();
				MultiTrigger val165 = new MultiTrigger(typeof(BoxView));
				Style val166 = new Style(typeof(BoxView));
				BoxView val167 = new BoxView();
				DynamicResourceExtension val168 = new DynamicResourceExtension();
				BindingExtension val169 = new BindingExtension();
				Label val170 = new Label();
				DynamicResourceExtension val171 = new DynamicResourceExtension();
				DynamicResourceExtension val172 = new DynamicResourceExtension();
				BindingExtension val173 = new BindingExtension();
				BindingCondition val174 = new BindingCondition();
				BindingExtension val175 = new BindingExtension();
				BindingCondition val176 = new BindingCondition();
				DynamicResourceExtension val177 = new DynamicResourceExtension();
				Setter val178 = new Setter();
				MultiTrigger val179 = new MultiTrigger(typeof(Frame));
				Style val180 = new Style(typeof(Frame));
				TimelineShadowFrame timelineShadowFrame3 = new TimelineShadowFrame();
				StaticResourceExtension val181 = new StaticResourceExtension();
				StaticResourceExtension val182 = new StaticResourceExtension();
				BindingExtension val183 = new BindingExtension();
				DynamicResourceExtension val184 = new DynamicResourceExtension();
				BindingExtension val185 = new BindingExtension();
				BindingCondition val186 = new BindingCondition();
				BindingExtension val187 = new BindingExtension();
				BindingCondition val188 = new BindingCondition();
				DynamicResourceExtension val189 = new DynamicResourceExtension();
				Setter val190 = new Setter();
				MultiTrigger val191 = new MultiTrigger(typeof(Label));
				Style val192 = new Style(typeof(Label));
				Label val193 = new Label();
				StaticResourceExtension val194 = new StaticResourceExtension();
				BindingExtension val195 = new BindingExtension();
				DynamicResourceExtension val196 = new DynamicResourceExtension();
				Label val197 = new Label();
				Grid val198 = new Grid();
				BindingExtension val199 = new BindingExtension();
				ColumnDefinition val200 = new ColumnDefinition();
				ColumnDefinition val201 = new ColumnDefinition();
				DynamicResourceExtension val202 = new DynamicResourceExtension();
				BoxView val203 = new BoxView();
				DynamicResourceExtension val204 = new DynamicResourceExtension();
				DynamicResourceExtension val205 = new DynamicResourceExtension();
				BindingExtension val206 = new BindingExtension();
				BindingCondition val207 = new BindingCondition();
				BindingExtension val208 = new BindingExtension();
				BindingCondition val209 = new BindingCondition();
				DynamicResourceExtension val210 = new DynamicResourceExtension();
				Setter val211 = new Setter();
				MultiTrigger val212 = new MultiTrigger(typeof(Frame));
				Style val213 = new Style(typeof(Frame));
				StaticResourceExtension val214 = new StaticResourceExtension();
				DynamicResourceExtension val215 = new DynamicResourceExtension();
				StaticResourceExtension val216 = new StaticResourceExtension();
				BindingExtension val217 = new BindingExtension();
				BindingExtension val218 = new BindingExtension();
				BindingCondition val219 = new BindingCondition();
				BindingExtension val220 = new BindingExtension();
				BindingCondition val221 = new BindingCondition();
				DynamicResourceExtension val222 = new DynamicResourceExtension();
				Setter val223 = new Setter();
				MultiTrigger val224 = new MultiTrigger(typeof(Label));
				Style val225 = new Style(typeof(Label));
				Label val226 = new Label();
				TimelineShadowFrame timelineShadowFrame4 = new TimelineShadowFrame();
				StaticResourceExtension val227 = new StaticResourceExtension();
				BindingExtension val228 = new BindingExtension();
				DynamicResourceExtension val229 = new DynamicResourceExtension();
				Label val230 = new Label();
				Grid val231 = new Grid();
				BindingExtension val232 = new BindingExtension();
				BindingExtension val233 = new BindingExtension();
				Setter val234 = new Setter();
				Setter val235 = new Setter();
				DataTrigger val236 = new DataTrigger(typeof(Grid));
				Style val237 = new Style(typeof(Grid));
				DynamicResourceExtension val238 = new DynamicResourceExtension();
				DynamicResourceExtension val239 = new DynamicResourceExtension();
				Polygon val240 = new Polygon();
				DynamicResourceExtension val241 = new DynamicResourceExtension();
				BoxView val242 = new BoxView();
				StackLayout val243 = new StackLayout();
				string testingScheduleView_DueToday = Resources.TestingScheduleView_DueToday;
				DynamicResourceExtension val244 = new DynamicResourceExtension();
				BindingExtension val245 = new BindingExtension();
				DynamicResourceExtension val246 = new DynamicResourceExtension();
				Setter val247 = new Setter();
				DataTrigger val248 = new DataTrigger(typeof(Label));
				Style val249 = new Style(typeof(Label));
				Label val250 = new Label();
				Grid val251 = new Grid();
				StaticResourceExtension val252 = new StaticResourceExtension();
				BindingExtension val253 = new BindingExtension();
				DynamicResourceExtension val254 = new DynamicResourceExtension();
				BoxView val255 = new BoxView();
				StackLayout val256 = new StackLayout();
				Grid val257 = new Grid();
				NameScope val258 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val257, (INameScope)(object)val258);
				((INameScope)val258).RegisterName("backgroundContainer", (object)val167);
				if (((Element)val167).get_StyleId() == null)
				{
					((Element)val167).set_StyleId("backgroundContainer");
				}
				((INameScope)val258).RegisterName("dateLabel", (object)val170);
				if (((Element)val170).get_StyleId() == null)
				{
					((Element)val170).set_StyleId("dateLabel");
				}
				((INameScope)val258).RegisterName("symptomCheckEllipse", (object)timelineShadowFrame3);
				if (((Element)timelineShadowFrame3).get_StyleId() == null)
				{
					((Element)timelineShadowFrame3).set_StyleId("symptomCheckEllipse");
				}
				NameScope val259 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val179, (INameScope)(object)val259);
				((INameScope)val258).RegisterName("symptomCheckIconLabel", (object)val193);
				if (((Element)val193).get_StyleId() == null)
				{
					((Element)val193).set_StyleId("symptomCheckIconLabel");
				}
				NameScope val260 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val191, (INameScope)(object)val260);
				((INameScope)val258).RegisterName("symptomCheckDoneLabel", (object)val197);
				if (((Element)val197).get_StyleId() == null)
				{
					((Element)val197).set_StyleId("symptomCheckDoneLabel");
				}
				((INameScope)val258).RegisterName("covidTestCircle", (object)val231);
				if (((Element)val231).get_StyleId() == null)
				{
					((Element)val231).set_StyleId("covidTestCircle");
				}
				((INameScope)val258).RegisterName("covidTestEllipse", (object)timelineShadowFrame4);
				if (((Element)timelineShadowFrame4).get_StyleId() == null)
				{
					((Element)timelineShadowFrame4).set_StyleId("covidTestEllipse");
				}
				NameScope val261 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val212, (INameScope)(object)val261);
				((INameScope)val258).RegisterName("covidTestIconLabel", (object)val226);
				if (((Element)val226).get_StyleId() == null)
				{
					((Element)val226).set_StyleId("covidTestIconLabel");
				}
				NameScope val262 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val224, (INameScope)(object)val262);
				((INameScope)val258).RegisterName("covidTestDoneLabel", (object)val230);
				if (((Element)val230).get_StyleId() == null)
				{
					((Element)val230).set_StyleId("covidTestDoneLabel");
				}
				((INameScope)val258).RegisterName("dueTodayContainer", (object)val251);
				if (((Element)val251).get_StyleId() == null)
				{
					((Element)val251).set_StyleId("dueTodayContainer");
				}
				NameScope val263 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val236, (INameScope)(object)val263);
				NameScope val264 = new NameScope();
				NameScope.SetNameScope((BindableObject)(object)val248, (INameScope)(object)val264);
				((BindableObject)val257).SetValue(Grid.RowSpacingProperty, (object)0.0);
				((BindableObject)val257).SetValue(Grid.ColumnSpacingProperty, (object)0.0);
				((BindableObject)val257).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)val149).SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
				((DefinitionCollection<RowDefinition>)((BindableObject)val257).GetValue(Grid.RowDefinitionsProperty)).Add(val149);
				((BindableObject)val150).SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
				((DefinitionCollection<RowDefinition>)((BindableObject)val257).GetValue(Grid.RowDefinitionsProperty)).Add(val150);
				((BindableObject)val151).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("130"));
				((DefinitionCollection<ColumnDefinition>)((BindableObject)val257).GetValue(Grid.ColumnDefinitionsProperty)).Add(val151);
				((BindableObject)val152).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
				((DefinitionCollection<ColumnDefinition>)((BindableObject)val257).GetValue(Grid.ColumnDefinitionsProperty)).Add(val152);
				((BindableObject)val153).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
				((DefinitionCollection<ColumnDefinition>)((BindableObject)val257).GetValue(Grid.ColumnDefinitionsProperty)).Add(val153);
				((BindableObject)val154).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
				((DefinitionCollection<ColumnDefinition>)((BindableObject)val257).GetValue(Grid.ColumnDefinitionsProperty)).Add(val154);
				((BindableObject)val167).SetValue(BoxView.CornerRadiusProperty, new CornerRadiusTypeConverter().ConvertFromInvariantString("10,22,10,22"));
				((BindableObject)val167).SetValue(Grid.RowProperty, (object)0);
				((BindableObject)val167).SetValue(Grid.ColumnSpanProperty, (object)2);
				((BindableObject)val167).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 0.0, 0.0));
				val155.set_Key("BoxViewBackgroundColor");
				XamlServiceProvider val265 = new XamlServiceProvider();
				Type typeFromHandle39 = typeof(IProvideValueTarget);
				int length;
				object[] array21 = new object[(length = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array21, 2, length);
				array21[0] = val167;
				array21[1] = val257;
				SimpleValueTargetProvider val266 = new SimpleValueTargetProvider(array21, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val258);
				object obj20 = (object)val266;
				val265.Add(typeFromHandle39, (object)val266);
				val265.Add(typeof(IReferenceProvider), obj20);
				Type typeFromHandle40 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val267 = new XmlNamespaceResolver();
				val267.Add("", "http://xamarin.com/schemas/2014/forms");
				val267.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val267.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val267.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val267.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val267.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val267.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val265.Add(typeFromHandle40, (object)new XamlTypeResolver((IXmlNamespaceResolver)val267, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val265.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(182, 37)));
				DynamicResource val268 = ((IMarkupExtension<DynamicResource>)(object)val155).ProvideValue((IServiceProvider)val265);
				((IDynamicResourceHandler)val167).SetDynamicResource(VisualElement.BackgroundColorProperty, val268.get_Key());
				val156.set_Path("IsActive");
				BindingBase binding = ((IMarkupExtension<BindingBase>)(object)val156).ProvideValue((IServiceProvider)null);
				val159.set_Binding(binding);
				val159.set_Value((object)"True");
				val158.set_Property(VisualElement.BackgroundColorProperty);
				val157.set_Key("ElevatedBackgroundColor");
				XamlServiceProvider val269 = new XamlServiceProvider();
				Type typeFromHandle41 = typeof(IProvideValueTarget);
				int length2;
				object[] array22 = new object[(length2 = parentValues.Length) + 5];
				Array.Copy(parentValues, 0, array22, 5, length2);
				array22[0] = val158;
				array22[1] = val159;
				array22[2] = val166;
				array22[3] = val167;
				array22[4] = val257;
				SimpleValueTargetProvider val270 = new SimpleValueTargetProvider(array22, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val258);
				object obj21 = (object)val270;
				val269.Add(typeFromHandle41, (object)val270);
				val269.Add(typeof(IReferenceProvider), obj21);
				Type typeFromHandle42 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val271 = new XmlNamespaceResolver();
				val271.Add("", "http://xamarin.com/schemas/2014/forms");
				val271.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val271.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val271.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val271.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val271.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val271.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val269.Add(typeFromHandle42, (object)new XamlTypeResolver((IXmlNamespaceResolver)val271, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val269.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(187, 88)));
				DynamicResource value = ((IMarkupExtension<DynamicResource>)(object)val157).ProvideValue((IServiceProvider)val269);
				val158.set_Value((object)value);
				val159.get_Setters().Add(val158);
				val166.get_Triggers().Add((TriggerBase)(object)val159);
				val160.set_Path("ShowCovidTestCircle");
				BindingBase binding2 = ((IMarkupExtension<BindingBase>)(object)val160).ProvideValue((IServiceProvider)null);
				val161.set_Binding(binding2);
				val161.set_Value((object)"True");
				val165.get_Conditions().Add((Condition)(object)val161);
				val162.set_Path("IsActive");
				BindingBase binding3 = ((IMarkupExtension<BindingBase>)(object)val162).ProvideValue((IServiceProvider)null);
				val163.set_Binding(binding3);
				val163.set_Value((object)"False");
				val165.get_Conditions().Add((Condition)(object)val163);
				val164.set_Property(Grid.ColumnSpanProperty);
				val164.set_Value((object)"3");
				val164.set_Value((object)3);
				val165.get_Setters().Add(val164);
				val166.get_Triggers().Add((TriggerBase)(object)val165);
				((BindableObject)val167).SetValue(VisualElement.StyleProperty, (object)val166);
				((ICollection<View>)val257.get_Children()).Add((View)(object)val167);
				((BindableObject)val170).SetValue(Grid.ColumnProperty, (object)0);
				((BindableObject)val170).SetValue(Grid.RowProperty, (object)0);
				((BindableObject)val170).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 0.0));
				val168.set_Key("Small");
				XamlServiceProvider val272 = new XamlServiceProvider();
				Type typeFromHandle43 = typeof(IProvideValueTarget);
				int length3;
				object[] array23 = new object[(length3 = parentValues.Length) + 2];
				Array.Copy(parentValues, 0, array23, 2, length3);
				array23[0] = val170;
				array23[1] = val257;
				SimpleValueTargetProvider val273 = new SimpleValueTargetProvider(array23, (object)VisualElement.StyleProperty, (INameScope)(object)val258);
				object obj22 = (object)val273;
				val272.Add(typeFromHandle43, (object)val273);
				val272.Add(typeof(IReferenceProvider), obj22);
				Type typeFromHandle44 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val274 = new XmlNamespaceResolver();
				val274.Add("", "http://xamarin.com/schemas/2014/forms");
				val274.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val274.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val274.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val274.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val274.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val274.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val272.Add(typeFromHandle44, (object)new XamlTypeResolver((IXmlNamespaceResolver)val274, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val272.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(204, 37)));
				DynamicResource val275 = ((IMarkupExtension<DynamicResource>)(object)val168).ProvideValue((IServiceProvider)val272);
				((IDynamicResourceHandler)val170).SetDynamicResource(VisualElement.StyleProperty, val275.get_Key());
				val169.set_Path("DateLabel");
				BindingBase val276 = ((IMarkupExtension<BindingBase>)(object)val169).ProvideValue((IServiceProvider)null);
				((BindableObject)val170).SetBinding(Label.TextProperty, val276);
				((BindableObject)val170).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
				((BindableObject)val170).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((ICollection<View>)val257.get_Children()).Add((View)(object)val170);
				((BindableObject)val198).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)val198).SetValue(Grid.ColumnProperty, (object)1);
				((BindableObject)val198).SetValue(Grid.RowProperty, (object)0);
				((BindableObject)timelineShadowFrame3).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
				((BindableObject)timelineShadowFrame3).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
				((BindableObject)timelineShadowFrame3).SetValue(Frame.CornerRadiusProperty, (object)20f);
				val171.set_Key("GrayColor");
				XamlServiceProvider val277 = new XamlServiceProvider();
				Type typeFromHandle45 = typeof(IProvideValueTarget);
				int length4;
				object[] array24 = new object[(length4 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array24, 3, length4);
				array24[0] = timelineShadowFrame3;
				array24[1] = val198;
				array24[2] = val257;
				SimpleValueTargetProvider val278 = new SimpleValueTargetProvider(array24, (object)Frame.BorderColorProperty, (INameScope)(object)val258);
				object obj23 = (object)val278;
				val277.Add(typeFromHandle45, (object)val278);
				val277.Add(typeof(IReferenceProvider), obj23);
				Type typeFromHandle46 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val279 = new XmlNamespaceResolver();
				val279.Add("", "http://xamarin.com/schemas/2014/forms");
				val279.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val279.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val279.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val279.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val279.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val279.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val277.Add(typeFromHandle46, (object)new XamlTypeResolver((IXmlNamespaceResolver)val279, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val277.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(219, 41)));
				DynamicResource val280 = ((IMarkupExtension<DynamicResource>)(object)val171).ProvideValue((IServiceProvider)val277);
				((IDynamicResourceHandler)timelineShadowFrame3).SetDynamicResource(Frame.BorderColorProperty, val280.get_Key());
				((BindableObject)timelineShadowFrame3).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)timelineShadowFrame3).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
				val172.set_Key("ElevatedBackgroundColor");
				XamlServiceProvider val281 = new XamlServiceProvider();
				Type typeFromHandle47 = typeof(IProvideValueTarget);
				int length5;
				object[] array25 = new object[(length5 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array25, 3, length5);
				array25[0] = timelineShadowFrame3;
				array25[1] = val198;
				array25[2] = val257;
				SimpleValueTargetProvider val282 = new SimpleValueTargetProvider(array25, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val258);
				object obj24 = (object)val282;
				val281.Add(typeFromHandle47, (object)val282);
				val281.Add(typeof(IReferenceProvider), obj24);
				Type typeFromHandle48 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val283 = new XmlNamespaceResolver();
				val283.Add("", "http://xamarin.com/schemas/2014/forms");
				val283.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val283.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val283.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val283.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val283.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val283.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val281.Add(typeFromHandle48, (object)new XamlTypeResolver((IXmlNamespaceResolver)val283, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val281.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(222, 41)));
				DynamicResource val284 = ((IMarkupExtension<DynamicResource>)(object)val172).ProvideValue((IServiceProvider)val281);
				((IDynamicResourceHandler)timelineShadowFrame3).SetDynamicResource(VisualElement.BackgroundColorProperty, val284.get_Key());
				((BindableObject)timelineShadowFrame3).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
				((BindableObject)timelineShadowFrame3).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
				val173.set_Path("IsToday");
				BindingBase binding4 = ((IMarkupExtension<BindingBase>)(object)val173).ProvideValue((IServiceProvider)null);
				val174.set_Binding(binding4);
				val174.set_Value((object)"True");
				val179.get_Conditions().Add((Condition)(object)val174);
				val175.set_Path("SymptomCheckCompleted");
				BindingBase binding5 = ((IMarkupExtension<BindingBase>)(object)val175).ProvideValue((IServiceProvider)null);
				val176.set_Binding(binding5);
				val176.set_Value((object)"False");
				val179.get_Conditions().Add((Condition)(object)val176);
				val178.set_Property(VisualElement.BackgroundColorProperty);
				val177.set_Key("SecondaryColor");
				XamlServiceProvider val285 = new XamlServiceProvider();
				Type typeFromHandle49 = typeof(IProvideValueTarget);
				int length6;
				object[] array26 = new object[(length6 = parentValues.Length) + 6];
				Array.Copy(parentValues, 0, array26, 6, length6);
				array26[0] = val178;
				array26[1] = val179;
				array26[2] = val180;
				array26[3] = timelineShadowFrame3;
				array26[4] = val198;
				array26[5] = val257;
				SimpleValueTargetProvider val286 = new SimpleValueTargetProvider(array26, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val259);
				object obj25 = (object)val286;
				val285.Add(typeFromHandle49, (object)val286);
				val285.Add(typeof(IReferenceProvider), obj25);
				Type typeFromHandle50 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val287 = new XmlNamespaceResolver();
				val287.Add("", "http://xamarin.com/schemas/2014/forms");
				val287.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val287.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val287.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val287.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val287.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val287.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val285.Add(typeFromHandle50, (object)new XamlTypeResolver((IXmlNamespaceResolver)val287, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val285.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(233, 92)));
				DynamicResource value2 = ((IMarkupExtension<DynamicResource>)(object)val177).ProvideValue((IServiceProvider)val285);
				val178.set_Value((object)value2);
				val179.get_Setters().Add(val178);
				val180.get_Triggers().Add((TriggerBase)(object)val179);
				((BindableObject)timelineShadowFrame3).SetValue(VisualElement.StyleProperty, (object)val180);
				((ICollection<View>)val198.get_Children()).Add((View)(object)timelineShadowFrame3);
				val181.set_Key("faStethoscope");
				XamlServiceProvider val288 = new XamlServiceProvider();
				Type typeFromHandle51 = typeof(IProvideValueTarget);
				int length7;
				object[] array27 = new object[(length7 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array27, 3, length7);
				array27[0] = val193;
				array27[1] = val198;
				array27[2] = val257;
				SimpleValueTargetProvider val289 = new SimpleValueTargetProvider(array27, (object)Label.TextProperty, (INameScope)(object)val258);
				object obj26 = (object)val289;
				val288.Add(typeFromHandle51, (object)val289);
				val288.Add(typeof(IReferenceProvider), obj26);
				Type typeFromHandle52 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val290 = new XmlNamespaceResolver();
				val290.Add("", "http://xamarin.com/schemas/2014/forms");
				val290.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val290.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val290.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val290.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val290.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val290.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val288.Add(typeFromHandle52, (object)new XamlTypeResolver((IXmlNamespaceResolver)val290, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val288.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(240, 41)));
				object text3 = ((IMarkupExtension)val181).ProvideValue((IServiceProvider)val288);
				val193.set_Text((string)text3);
				BindableProperty fontSizeProperty = Label.FontSizeProperty;
				FontSizeConverter val291 = new FontSizeConverter();
				XamlServiceProvider val292 = new XamlServiceProvider();
				Type typeFromHandle53 = typeof(IProvideValueTarget);
				int length8;
				object[] array28 = new object[(length8 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array28, 3, length8);
				array28[0] = val193;
				array28[1] = val198;
				array28[2] = val257;
				SimpleValueTargetProvider val293 = new SimpleValueTargetProvider(array28, (object)Label.FontSizeProperty, (INameScope)(object)val258);
				object obj27 = (object)val293;
				val292.Add(typeFromHandle53, (object)val293);
				val292.Add(typeof(IReferenceProvider), obj27);
				Type typeFromHandle54 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val294 = new XmlNamespaceResolver();
				val294.Add("", "http://xamarin.com/schemas/2014/forms");
				val294.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val294.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val294.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val294.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val294.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val294.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val292.Add(typeFromHandle54, (object)new XamlTypeResolver((IXmlNamespaceResolver)val294, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val292.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(241, 41)));
				((BindableObject)val193).SetValue(fontSizeProperty, ((IExtendedTypeConverter)val291).ConvertFromInvariantString("16", (IServiceProvider)val292));
				((BindableObject)val193).SetValue(Label.FontFamilyProperty, (object)"FA-R");
				((BindableObject)val193).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val193).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
				val182.set_Key("InverseBoolConverter");
				XamlServiceProvider val295 = new XamlServiceProvider();
				Type typeFromHandle55 = typeof(IProvideValueTarget);
				int length9;
				object[] array29 = new object[(length9 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array29, 4, length9);
				array29[0] = val183;
				array29[1] = val193;
				array29[2] = val198;
				array29[3] = val257;
				SimpleValueTargetProvider val296 = new SimpleValueTargetProvider(array29, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val258);
				object obj28 = (object)val296;
				val295.Add(typeFromHandle55, (object)val296);
				val295.Add(typeof(IReferenceProvider), obj28);
				Type typeFromHandle56 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val297 = new XmlNamespaceResolver();
				val297.Add("", "http://xamarin.com/schemas/2014/forms");
				val297.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val297.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val297.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val297.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val297.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val297.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val295.Add(typeFromHandle56, (object)new XamlTypeResolver((IXmlNamespaceResolver)val297, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val295.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(245, 41)));
				object converter = ((IMarkupExtension)val182).ProvideValue((IServiceProvider)val295);
				val183.set_Converter((IValueConverter)converter);
				val183.set_Path("SymptomCheckCompleted");
				BindingBase val298 = ((IMarkupExtension<BindingBase>)(object)val183).ProvideValue((IServiceProvider)null);
				((BindableObject)val193).SetBinding(VisualElement.IsVisibleProperty, val298);
				val184.set_Key("SecondaryColor");
				XamlServiceProvider val299 = new XamlServiceProvider();
				Type typeFromHandle57 = typeof(IProvideValueTarget);
				int length10;
				object[] array30 = new object[(length10 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array30, 3, length10);
				array30[0] = val193;
				array30[1] = val198;
				array30[2] = val257;
				SimpleValueTargetProvider val300 = new SimpleValueTargetProvider(array30, (object)Label.TextColorProperty, (INameScope)(object)val258);
				object obj29 = (object)val300;
				val299.Add(typeFromHandle57, (object)val300);
				val299.Add(typeof(IReferenceProvider), obj29);
				Type typeFromHandle58 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val301 = new XmlNamespaceResolver();
				val301.Add("", "http://xamarin.com/schemas/2014/forms");
				val301.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val301.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val301.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val301.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val301.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val301.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val299.Add(typeFromHandle58, (object)new XamlTypeResolver((IXmlNamespaceResolver)val301, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val299.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(246, 41)));
				DynamicResource val302 = ((IMarkupExtension<DynamicResource>)(object)val184).ProvideValue((IServiceProvider)val299);
				((IDynamicResourceHandler)val193).SetDynamicResource(Label.TextColorProperty, val302.get_Key());
				val185.set_Path("IsToday");
				BindingBase binding6 = ((IMarkupExtension<BindingBase>)(object)val185).ProvideValue((IServiceProvider)null);
				val186.set_Binding(binding6);
				val186.set_Value((object)"True");
				val191.get_Conditions().Add((Condition)(object)val186);
				val187.set_Path("SymptomCheckCompleted");
				BindingBase binding7 = ((IMarkupExtension<BindingBase>)(object)val187).ProvideValue((IServiceProvider)null);
				val188.set_Binding(binding7);
				val188.set_Value((object)"False");
				val191.get_Conditions().Add((Condition)(object)val188);
				val190.set_Property(Label.TextColorProperty);
				val189.set_Key("ButtonTextColor");
				XamlServiceProvider val303 = new XamlServiceProvider();
				Type typeFromHandle59 = typeof(IProvideValueTarget);
				int length11;
				object[] array31 = new object[(length11 = parentValues.Length) + 6];
				Array.Copy(parentValues, 0, array31, 6, length11);
				array31[0] = val190;
				array31[1] = val191;
				array31[2] = val192;
				array31[3] = val193;
				array31[4] = val198;
				array31[5] = val257;
				SimpleValueTargetProvider val304 = new SimpleValueTargetProvider(array31, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val260);
				object obj30 = (object)val304;
				val303.Add(typeFromHandle59, (object)val304);
				val303.Add(typeof(IReferenceProvider), obj30);
				Type typeFromHandle60 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val305 = new XmlNamespaceResolver();
				val305.Add("", "http://xamarin.com/schemas/2014/forms");
				val305.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val305.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val305.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val305.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val305.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val305.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val303.Add(typeFromHandle60, (object)new XamlTypeResolver((IXmlNamespaceResolver)val305, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val303.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(255, 86)));
				DynamicResource value3 = ((IMarkupExtension<DynamicResource>)(object)val189).ProvideValue((IServiceProvider)val303);
				val190.set_Value((object)value3);
				val191.get_Setters().Add(val190);
				val192.get_Triggers().Add((TriggerBase)(object)val191);
				((BindableObject)val193).SetValue(VisualElement.StyleProperty, (object)val192);
				((ICollection<View>)val198.get_Children()).Add((View)(object)val193);
				val194.set_Key("faCheck");
				XamlServiceProvider val306 = new XamlServiceProvider();
				Type typeFromHandle61 = typeof(IProvideValueTarget);
				int length12;
				object[] array32 = new object[(length12 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array32, 3, length12);
				array32[0] = val197;
				array32[1] = val198;
				array32[2] = val257;
				SimpleValueTargetProvider val307 = new SimpleValueTargetProvider(array32, (object)Label.TextProperty, (INameScope)(object)val258);
				object obj31 = (object)val307;
				val306.Add(typeFromHandle61, (object)val307);
				val306.Add(typeof(IReferenceProvider), obj31);
				Type typeFromHandle62 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val308 = new XmlNamespaceResolver();
				val308.Add("", "http://xamarin.com/schemas/2014/forms");
				val308.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val308.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val308.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val308.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val308.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val308.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val306.Add(typeFromHandle62, (object)new XamlTypeResolver((IXmlNamespaceResolver)val308, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val306.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(262, 41)));
				object text4 = ((IMarkupExtension)val194).ProvideValue((IServiceProvider)val306);
				val197.set_Text((string)text4);
				BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
				FontSizeConverter val309 = new FontSizeConverter();
				XamlServiceProvider val310 = new XamlServiceProvider();
				Type typeFromHandle63 = typeof(IProvideValueTarget);
				int length13;
				object[] array33 = new object[(length13 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array33, 3, length13);
				array33[0] = val197;
				array33[1] = val198;
				array33[2] = val257;
				SimpleValueTargetProvider val311 = new SimpleValueTargetProvider(array33, (object)Label.FontSizeProperty, (INameScope)(object)val258);
				object obj32 = (object)val311;
				val310.Add(typeFromHandle63, (object)val311);
				val310.Add(typeof(IReferenceProvider), obj32);
				Type typeFromHandle64 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val312 = new XmlNamespaceResolver();
				val312.Add("", "http://xamarin.com/schemas/2014/forms");
				val312.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val312.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val312.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val312.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val312.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val312.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val310.Add(typeFromHandle64, (object)new XamlTypeResolver((IXmlNamespaceResolver)val312, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val310.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(263, 41)));
				((BindableObject)val197).SetValue(fontSizeProperty2, ((IExtendedTypeConverter)val309).ConvertFromInvariantString("16", (IServiceProvider)val310));
				((BindableObject)val197).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val197).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val197).SetValue(Label.FontFamilyProperty, (object)"FA-R");
				val195.set_Path("SymptomCheckCompleted");
				BindingBase val313 = ((IMarkupExtension<BindingBase>)(object)val195).ProvideValue((IServiceProvider)null);
				((BindableObject)val197).SetBinding(VisualElement.IsVisibleProperty, val313);
				val196.set_Key("TertiaryTextColor");
				XamlServiceProvider val314 = new XamlServiceProvider();
				Type typeFromHandle65 = typeof(IProvideValueTarget);
				int length14;
				object[] array34 = new object[(length14 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array34, 3, length14);
				array34[0] = val197;
				array34[1] = val198;
				array34[2] = val257;
				SimpleValueTargetProvider val315 = new SimpleValueTargetProvider(array34, (object)Label.TextColorProperty, (INameScope)(object)val258);
				object obj33 = (object)val315;
				val314.Add(typeFromHandle65, (object)val315);
				val314.Add(typeof(IReferenceProvider), obj33);
				Type typeFromHandle66 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val316 = new XmlNamespaceResolver();
				val316.Add("", "http://xamarin.com/schemas/2014/forms");
				val316.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val316.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val316.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val316.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val316.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val316.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val314.Add(typeFromHandle66, (object)new XamlTypeResolver((IXmlNamespaceResolver)val316, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val314.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(268, 41)));
				DynamicResource val317 = ((IMarkupExtension<DynamicResource>)(object)val196).ProvideValue((IServiceProvider)val314);
				((IDynamicResourceHandler)val197).SetDynamicResource(Label.TextColorProperty, val317.get_Key());
				((ICollection<View>)val198.get_Children()).Add((View)(object)val197);
				((ICollection<View>)val257.get_Children()).Add((View)(object)val198);
				((BindableObject)val231).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)val231).SetValue(Grid.ColumnProperty, (object)2);
				((BindableObject)val231).SetValue(Grid.RowProperty, (object)0);
				((BindableObject)val231).SetValue(Grid.ColumnSpacingProperty, (object)0.0);
				val199.set_Path("ShowCovidTestCircle");
				BindingBase val318 = ((IMarkupExtension<BindingBase>)(object)val199).ProvideValue((IServiceProvider)null);
				((BindableObject)val231).SetBinding(VisualElement.IsVisibleProperty, val318);
				((BindableObject)val200).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
				((DefinitionCollection<ColumnDefinition>)((BindableObject)val231).GetValue(Grid.ColumnDefinitionsProperty)).Add(val200);
				((BindableObject)val201).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
				((DefinitionCollection<ColumnDefinition>)((BindableObject)val231).GetValue(Grid.ColumnDefinitionsProperty)).Add(val201);
				((BindableObject)val203).SetValue(Grid.ColumnProperty, (object)0);
				((BindableObject)val203).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)val203).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
				((BindableObject)val203).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Fill);
				((BindableObject)val203).SetValue(VisualElement.WidthRequestProperty, (object)30.0);
				((BindableObject)val203).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
				val202.set_Key("GrayColor");
				XamlServiceProvider val319 = new XamlServiceProvider();
				Type typeFromHandle67 = typeof(IProvideValueTarget);
				int length15;
				object[] array35 = new object[(length15 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array35, 3, length15);
				array35[0] = val203;
				array35[1] = val231;
				array35[2] = val257;
				SimpleValueTargetProvider val320 = new SimpleValueTargetProvider(array35, (object)BoxView.ColorProperty, (INameScope)(object)val258);
				object obj34 = (object)val320;
				val319.Add(typeFromHandle67, (object)val320);
				val319.Add(typeof(IReferenceProvider), obj34);
				Type typeFromHandle68 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val321 = new XmlNamespaceResolver();
				val321.Add("", "http://xamarin.com/schemas/2014/forms");
				val321.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val321.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val321.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val321.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val321.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val321.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val319.Add(typeFromHandle68, (object)new XamlTypeResolver((IXmlNamespaceResolver)val321, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val319.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(289, 41)));
				DynamicResource val322 = ((IMarkupExtension<DynamicResource>)(object)val202).ProvideValue((IServiceProvider)val319);
				((IDynamicResourceHandler)val203).SetDynamicResource(BoxView.ColorProperty, val322.get_Key());
				((ICollection<View>)val231.get_Children()).Add((View)(object)val203);
				((BindableObject)timelineShadowFrame4).SetValue(Grid.ColumnProperty, (object)1);
				((BindableObject)timelineShadowFrame4).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
				((BindableObject)timelineShadowFrame4).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
				((BindableObject)timelineShadowFrame4).SetValue(Frame.CornerRadiusProperty, (object)20f);
				val204.set_Key("GrayColor");
				XamlServiceProvider val323 = new XamlServiceProvider();
				Type typeFromHandle69 = typeof(IProvideValueTarget);
				int length16;
				object[] array36 = new object[(length16 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array36, 3, length16);
				array36[0] = timelineShadowFrame4;
				array36[1] = val231;
				array36[2] = val257;
				SimpleValueTargetProvider val324 = new SimpleValueTargetProvider(array36, (object)Frame.BorderColorProperty, (INameScope)(object)val258);
				object obj35 = (object)val324;
				val323.Add(typeFromHandle69, (object)val324);
				val323.Add(typeof(IReferenceProvider), obj35);
				Type typeFromHandle70 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val325 = new XmlNamespaceResolver();
				val325.Add("", "http://xamarin.com/schemas/2014/forms");
				val325.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val325.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val325.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val325.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val325.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val325.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val323.Add(typeFromHandle70, (object)new XamlTypeResolver((IXmlNamespaceResolver)val325, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val323.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(296, 41)));
				DynamicResource val326 = ((IMarkupExtension<DynamicResource>)(object)val204).ProvideValue((IServiceProvider)val323);
				((IDynamicResourceHandler)timelineShadowFrame4).SetDynamicResource(Frame.BorderColorProperty, val326.get_Key());
				((BindableObject)timelineShadowFrame4).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)timelineShadowFrame4).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
				val205.set_Key("ElevatedBackgroundColor");
				XamlServiceProvider val327 = new XamlServiceProvider();
				Type typeFromHandle71 = typeof(IProvideValueTarget);
				int length17;
				object[] array37 = new object[(length17 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array37, 3, length17);
				array37[0] = timelineShadowFrame4;
				array37[1] = val231;
				array37[2] = val257;
				SimpleValueTargetProvider val328 = new SimpleValueTargetProvider(array37, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val258);
				object obj36 = (object)val328;
				val327.Add(typeFromHandle71, (object)val328);
				val327.Add(typeof(IReferenceProvider), obj36);
				Type typeFromHandle72 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val329 = new XmlNamespaceResolver();
				val329.Add("", "http://xamarin.com/schemas/2014/forms");
				val329.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val329.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val329.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val329.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val329.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val329.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val327.Add(typeFromHandle72, (object)new XamlTypeResolver((IXmlNamespaceResolver)val329, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val327.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(299, 41)));
				DynamicResource val330 = ((IMarkupExtension<DynamicResource>)(object)val205).ProvideValue((IServiceProvider)val327);
				((IDynamicResourceHandler)timelineShadowFrame4).SetDynamicResource(VisualElement.BackgroundColorProperty, val330.get_Key());
				((BindableObject)timelineShadowFrame4).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
				((BindableObject)timelineShadowFrame4).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.CenterAndExpand);
				val206.set_Path("IsCovidTestDueToday");
				BindingBase binding8 = ((IMarkupExtension<BindingBase>)(object)val206).ProvideValue((IServiceProvider)null);
				val207.set_Binding(binding8);
				val207.set_Value((object)"True");
				val212.get_Conditions().Add((Condition)(object)val207);
				val208.set_Path("CovidTestPresented");
				BindingBase binding9 = ((IMarkupExtension<BindingBase>)(object)val208).ProvideValue((IServiceProvider)null);
				val209.set_Binding(binding9);
				val209.set_Value((object)"False");
				val212.get_Conditions().Add((Condition)(object)val209);
				val211.set_Property(VisualElement.BackgroundColorProperty);
				val210.set_Key("PrimaryColor");
				XamlServiceProvider val331 = new XamlServiceProvider();
				Type typeFromHandle73 = typeof(IProvideValueTarget);
				int length18;
				object[] array38 = new object[(length18 = parentValues.Length) + 6];
				Array.Copy(parentValues, 0, array38, 6, length18);
				array38[0] = val211;
				array38[1] = val212;
				array38[2] = val213;
				array38[3] = timelineShadowFrame4;
				array38[4] = val231;
				array38[5] = val257;
				SimpleValueTargetProvider val332 = new SimpleValueTargetProvider(array38, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val261);
				object obj37 = (object)val332;
				val331.Add(typeFromHandle73, (object)val332);
				val331.Add(typeof(IReferenceProvider), obj37);
				Type typeFromHandle74 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val333 = new XmlNamespaceResolver();
				val333.Add("", "http://xamarin.com/schemas/2014/forms");
				val333.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val333.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val333.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val333.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val333.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val333.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val331.Add(typeFromHandle74, (object)new XamlTypeResolver((IXmlNamespaceResolver)val333, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val331.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(310, 92)));
				DynamicResource value4 = ((IMarkupExtension<DynamicResource>)(object)val210).ProvideValue((IServiceProvider)val331);
				val211.set_Value((object)value4);
				val212.get_Setters().Add(val211);
				val213.get_Triggers().Add((TriggerBase)(object)val212);
				((BindableObject)timelineShadowFrame4).SetValue(VisualElement.StyleProperty, (object)val213);
				((BindableObject)val226).SetValue(Grid.ColumnProperty, (object)1);
				val214.set_Key("faVials");
				XamlServiceProvider val334 = new XamlServiceProvider();
				Type typeFromHandle75 = typeof(IProvideValueTarget);
				int length19;
				object[] array39 = new object[(length19 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array39, 4, length19);
				array39[0] = val226;
				array39[1] = timelineShadowFrame4;
				array39[2] = val231;
				array39[3] = val257;
				SimpleValueTargetProvider val335 = new SimpleValueTargetProvider(array39, (object)Label.TextProperty, (INameScope)(object)val258);
				object obj38 = (object)val335;
				val334.Add(typeFromHandle75, (object)val335);
				val334.Add(typeof(IReferenceProvider), obj38);
				Type typeFromHandle76 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val336 = new XmlNamespaceResolver();
				val336.Add("", "http://xamarin.com/schemas/2014/forms");
				val336.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val336.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val336.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val336.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val336.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val336.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val334.Add(typeFromHandle76, (object)new XamlTypeResolver((IXmlNamespaceResolver)val336, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val334.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(317, 45)));
				object text5 = ((IMarkupExtension)val214).ProvideValue((IServiceProvider)val334);
				val226.set_Text((string)text5);
				BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
				FontSizeConverter val337 = new FontSizeConverter();
				XamlServiceProvider val338 = new XamlServiceProvider();
				Type typeFromHandle77 = typeof(IProvideValueTarget);
				int length20;
				object[] array40 = new object[(length20 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array40, 4, length20);
				array40[0] = val226;
				array40[1] = timelineShadowFrame4;
				array40[2] = val231;
				array40[3] = val257;
				SimpleValueTargetProvider val339 = new SimpleValueTargetProvider(array40, (object)Label.FontSizeProperty, (INameScope)(object)val258);
				object obj39 = (object)val339;
				val338.Add(typeFromHandle77, (object)val339);
				val338.Add(typeof(IReferenceProvider), obj39);
				Type typeFromHandle78 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val340 = new XmlNamespaceResolver();
				val340.Add("", "http://xamarin.com/schemas/2014/forms");
				val340.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val340.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val340.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val340.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val340.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val340.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val338.Add(typeFromHandle78, (object)new XamlTypeResolver((IXmlNamespaceResolver)val340, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val338.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(318, 45)));
				((BindableObject)val226).SetValue(fontSizeProperty3, ((IExtendedTypeConverter)val337).ConvertFromInvariantString("16", (IServiceProvider)val338));
				((BindableObject)val226).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val226).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				val215.set_Key("PrimaryColor");
				XamlServiceProvider val341 = new XamlServiceProvider();
				Type typeFromHandle79 = typeof(IProvideValueTarget);
				int length21;
				object[] array41 = new object[(length21 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array41, 4, length21);
				array41[0] = val226;
				array41[1] = timelineShadowFrame4;
				array41[2] = val231;
				array41[3] = val257;
				SimpleValueTargetProvider val342 = new SimpleValueTargetProvider(array41, (object)Label.TextColorProperty, (INameScope)(object)val258);
				object obj40 = (object)val342;
				val341.Add(typeFromHandle79, (object)val342);
				val341.Add(typeof(IReferenceProvider), obj40);
				Type typeFromHandle80 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val343 = new XmlNamespaceResolver();
				val343.Add("", "http://xamarin.com/schemas/2014/forms");
				val343.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val343.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val343.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val343.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val343.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val343.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val341.Add(typeFromHandle80, (object)new XamlTypeResolver((IXmlNamespaceResolver)val343, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val341.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(321, 45)));
				DynamicResource val344 = ((IMarkupExtension<DynamicResource>)(object)val215).ProvideValue((IServiceProvider)val341);
				((IDynamicResourceHandler)val226).SetDynamicResource(Label.TextColorProperty, val344.get_Key());
				val216.set_Key("InverseBoolConverter");
				XamlServiceProvider val345 = new XamlServiceProvider();
				Type typeFromHandle81 = typeof(IProvideValueTarget);
				int length22;
				object[] array42 = new object[(length22 = parentValues.Length) + 5];
				Array.Copy(parentValues, 0, array42, 5, length22);
				array42[0] = val217;
				array42[1] = val226;
				array42[2] = timelineShadowFrame4;
				array42[3] = val231;
				array42[4] = val257;
				SimpleValueTargetProvider val346 = new SimpleValueTargetProvider(array42, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val258);
				object obj41 = (object)val346;
				val345.Add(typeFromHandle81, (object)val346);
				val345.Add(typeof(IReferenceProvider), obj41);
				Type typeFromHandle82 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val347 = new XmlNamespaceResolver();
				val347.Add("", "http://xamarin.com/schemas/2014/forms");
				val347.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val347.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val347.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val347.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val347.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val347.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val345.Add(typeFromHandle82, (object)new XamlTypeResolver((IXmlNamespaceResolver)val347, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val345.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(322, 45)));
				object converter2 = ((IMarkupExtension)val216).ProvideValue((IServiceProvider)val345);
				val217.set_Converter((IValueConverter)converter2);
				val217.set_Path("CovidTestPresented");
				BindingBase val348 = ((IMarkupExtension<BindingBase>)(object)val217).ProvideValue((IServiceProvider)null);
				((BindableObject)val226).SetBinding(VisualElement.IsVisibleProperty, val348);
				((BindableObject)val226).SetValue(Label.FontFamilyProperty, (object)"FA-R");
				val218.set_Path("IsToday");
				BindingBase binding10 = ((IMarkupExtension<BindingBase>)(object)val218).ProvideValue((IServiceProvider)null);
				val219.set_Binding(binding10);
				val219.set_Value((object)"True");
				val224.get_Conditions().Add((Condition)(object)val219);
				val220.set_Path("CovidTestPresented");
				BindingBase binding11 = ((IMarkupExtension<BindingBase>)(object)val220).ProvideValue((IServiceProvider)null);
				val221.set_Binding(binding11);
				val221.set_Value((object)"False");
				val224.get_Conditions().Add((Condition)(object)val221);
				val223.set_Property(Label.TextColorProperty);
				val222.set_Key("ButtonTextColor");
				XamlServiceProvider val349 = new XamlServiceProvider();
				Type typeFromHandle83 = typeof(IProvideValueTarget);
				int length23;
				object[] array43 = new object[(length23 = parentValues.Length) + 7];
				Array.Copy(parentValues, 0, array43, 7, length23);
				array43[0] = val223;
				array43[1] = val224;
				array43[2] = val225;
				array43[3] = val226;
				array43[4] = timelineShadowFrame4;
				array43[5] = val231;
				array43[6] = val257;
				SimpleValueTargetProvider val350 = new SimpleValueTargetProvider(array43, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val262);
				object obj42 = (object)val350;
				val349.Add(typeFromHandle83, (object)val350);
				val349.Add(typeof(IReferenceProvider), obj42);
				Type typeFromHandle84 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val351 = new XmlNamespaceResolver();
				val351.Add("", "http://xamarin.com/schemas/2014/forms");
				val351.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val351.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val351.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val351.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val351.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val351.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val349.Add(typeFromHandle84, (object)new XamlTypeResolver((IXmlNamespaceResolver)val351, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val349.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(332, 90)));
				DynamicResource value5 = ((IMarkupExtension<DynamicResource>)(object)val222).ProvideValue((IServiceProvider)val349);
				val223.set_Value((object)value5);
				val224.get_Setters().Add(val223);
				val225.get_Triggers().Add((TriggerBase)(object)val224);
				((BindableObject)val226).SetValue(VisualElement.StyleProperty, (object)val225);
				((BindableObject)timelineShadowFrame4).SetValue(ContentView.ContentProperty, (object)val226);
				((ICollection<View>)val231.get_Children()).Add((View)(object)timelineShadowFrame4);
				((BindableObject)val230).SetValue(Grid.ColumnProperty, (object)1);
				val227.set_Key("faCheck");
				XamlServiceProvider val352 = new XamlServiceProvider();
				Type typeFromHandle85 = typeof(IProvideValueTarget);
				int length24;
				object[] array44 = new object[(length24 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array44, 3, length24);
				array44[0] = val230;
				array44[1] = val231;
				array44[2] = val257;
				SimpleValueTargetProvider val353 = new SimpleValueTargetProvider(array44, (object)Label.TextProperty, (INameScope)(object)val258);
				object obj43 = (object)val353;
				val352.Add(typeFromHandle85, (object)val353);
				val352.Add(typeof(IReferenceProvider), obj43);
				Type typeFromHandle86 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val354 = new XmlNamespaceResolver();
				val354.Add("", "http://xamarin.com/schemas/2014/forms");
				val354.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val354.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val354.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val354.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val354.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val354.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val352.Add(typeFromHandle86, (object)new XamlTypeResolver((IXmlNamespaceResolver)val354, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val352.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(342, 41)));
				object text6 = ((IMarkupExtension)val227).ProvideValue((IServiceProvider)val352);
				val230.set_Text((string)text6);
				BindableProperty fontSizeProperty4 = Label.FontSizeProperty;
				FontSizeConverter val355 = new FontSizeConverter();
				XamlServiceProvider val356 = new XamlServiceProvider();
				Type typeFromHandle87 = typeof(IProvideValueTarget);
				int length25;
				object[] array45 = new object[(length25 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array45, 3, length25);
				array45[0] = val230;
				array45[1] = val231;
				array45[2] = val257;
				SimpleValueTargetProvider val357 = new SimpleValueTargetProvider(array45, (object)Label.FontSizeProperty, (INameScope)(object)val258);
				object obj44 = (object)val357;
				val356.Add(typeFromHandle87, (object)val357);
				val356.Add(typeof(IReferenceProvider), obj44);
				Type typeFromHandle88 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val358 = new XmlNamespaceResolver();
				val358.Add("", "http://xamarin.com/schemas/2014/forms");
				val358.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val358.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val358.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val358.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val358.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val358.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val356.Add(typeFromHandle88, (object)new XamlTypeResolver((IXmlNamespaceResolver)val358, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val356.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(343, 41)));
				((BindableObject)val230).SetValue(fontSizeProperty4, ((IExtendedTypeConverter)val355).ConvertFromInvariantString("16", (IServiceProvider)val356));
				((BindableObject)val230).SetValue(Label.FontFamilyProperty, (object)"FA-R");
				((BindableObject)val230).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val230).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				val228.set_Path("CovidTestPresented");
				BindingBase val359 = ((IMarkupExtension<BindingBase>)(object)val228).ProvideValue((IServiceProvider)null);
				((BindableObject)val230).SetBinding(VisualElement.IsVisibleProperty, val359);
				val229.set_Key("TertiaryTextColor");
				XamlServiceProvider val360 = new XamlServiceProvider();
				Type typeFromHandle89 = typeof(IProvideValueTarget);
				int length26;
				object[] array46 = new object[(length26 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array46, 3, length26);
				array46[0] = val230;
				array46[1] = val231;
				array46[2] = val257;
				SimpleValueTargetProvider val361 = new SimpleValueTargetProvider(array46, (object)Label.TextColorProperty, (INameScope)(object)val258);
				object obj45 = (object)val361;
				val360.Add(typeFromHandle89, (object)val361);
				val360.Add(typeof(IReferenceProvider), obj45);
				Type typeFromHandle90 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val362 = new XmlNamespaceResolver();
				val362.Add("", "http://xamarin.com/schemas/2014/forms");
				val362.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val362.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val362.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val362.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val362.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val362.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val360.Add(typeFromHandle90, (object)new XamlTypeResolver((IXmlNamespaceResolver)val362, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val360.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(348, 41)));
				DynamicResource val363 = ((IMarkupExtension<DynamicResource>)(object)val229).ProvideValue((IServiceProvider)val360);
				((IDynamicResourceHandler)val230).SetDynamicResource(Label.TextColorProperty, val363.get_Key());
				((ICollection<View>)val231.get_Children()).Add((View)(object)val230);
				((ICollection<View>)val257.get_Children()).Add((View)(object)val231);
				((BindableObject)val251).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				((BindableObject)val251).SetValue(Grid.RowProperty, (object)0);
				((BindableObject)val251).SetValue(Grid.ColumnProperty, (object)2);
				((BindableObject)val251).SetValue(Grid.ColumnSpanProperty, (object)2);
				val232.set_Path("IsAnyDueToday");
				BindingBase val364 = ((IMarkupExtension<BindingBase>)(object)val232).ProvideValue((IServiceProvider)null);
				((BindableObject)val251).SetBinding(VisualElement.IsVisibleProperty, val364);
				val233.set_Path("CovidTestRequired");
				BindingBase binding12 = ((IMarkupExtension<BindingBase>)(object)val233).ProvideValue((IServiceProvider)null);
				val236.set_Binding(binding12);
				val236.set_Value((object)"True");
				val234.set_Property(Grid.ColumnProperty);
				val234.set_Value((object)"3");
				val234.set_Value((object)3);
				val236.get_Setters().Add(val234);
				val235.set_Property(Grid.ColumnSpanProperty);
				val235.set_Value((object)"1");
				val235.set_Value((object)1);
				val236.get_Setters().Add(val235);
				val237.get_Triggers().Add((TriggerBase)(object)val236);
				((BindableObject)val251).SetValue(VisualElement.StyleProperty, (object)val237);
				((BindableObject)val243).SetValue(StackLayout.SpacingProperty, (object)0.0);
				((BindableObject)val243).SetValue(StackLayout.OrientationProperty, (object)(StackOrientation)1);
				((BindableObject)val243).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
				((BindableObject)val240).SetValue(Polygon.PointsProperty, new PointCollectionConverter().ConvertFromInvariantString("10,20 20,25 20,15"));
				val238.set_Key("ElevatedBackgroundColorBrush");
				XamlServiceProvider val365 = new XamlServiceProvider();
				Type typeFromHandle91 = typeof(IProvideValueTarget);
				int length27;
				object[] array47 = new object[(length27 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array47, 4, length27);
				array47[0] = val240;
				array47[1] = val243;
				array47[2] = val251;
				array47[3] = val257;
				SimpleValueTargetProvider val366 = new SimpleValueTargetProvider(array47, (object)Shape.FillProperty, (INameScope)(object)val258);
				object obj46 = (object)val366;
				val365.Add(typeFromHandle91, (object)val366);
				val365.Add(typeof(IReferenceProvider), obj46);
				Type typeFromHandle92 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val367 = new XmlNamespaceResolver();
				val367.Add("", "http://xamarin.com/schemas/2014/forms");
				val367.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val367.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val367.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val367.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val367.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val367.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val365.Add(typeFromHandle92, (object)new XamlTypeResolver((IXmlNamespaceResolver)val367, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val365.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(364, 45)));
				DynamicResource val368 = ((IMarkupExtension<DynamicResource>)(object)val238).ProvideValue((IServiceProvider)val365);
				((IDynamicResourceHandler)val240).SetDynamicResource(Shape.FillProperty, val368.get_Key());
				val239.set_Key("ElevatedBackgroundColorBrush");
				XamlServiceProvider val369 = new XamlServiceProvider();
				Type typeFromHandle93 = typeof(IProvideValueTarget);
				int length28;
				object[] array48 = new object[(length28 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array48, 4, length28);
				array48[0] = val240;
				array48[1] = val243;
				array48[2] = val251;
				array48[3] = val257;
				SimpleValueTargetProvider val370 = new SimpleValueTargetProvider(array48, (object)Shape.StrokeProperty, (INameScope)(object)val258);
				object obj47 = (object)val370;
				val369.Add(typeFromHandle93, (object)val370);
				val369.Add(typeof(IReferenceProvider), obj47);
				Type typeFromHandle94 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val371 = new XmlNamespaceResolver();
				val371.Add("", "http://xamarin.com/schemas/2014/forms");
				val371.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val371.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val371.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val371.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val371.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val371.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val369.Add(typeFromHandle94, (object)new XamlTypeResolver((IXmlNamespaceResolver)val371, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val369.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(365, 45)));
				DynamicResource val372 = ((IMarkupExtension<DynamicResource>)(object)val239).ProvideValue((IServiceProvider)val369);
				((IDynamicResourceHandler)val240).SetDynamicResource(Shape.StrokeProperty, val372.get_Key());
				((BindableObject)val240).SetValue(Shape.StrokeThicknessProperty, (object)0.0);
				((Layout<View>)(object)val243).get_Children().Add((View)(object)val240);
				((BindableObject)val242).SetValue(BoxView.CornerRadiusProperty, new CornerRadiusTypeConverter().ConvertFromInvariantString("10"));
				((BindableObject)val242).SetValue(VisualElement.WidthRequestProperty, (object)100.0);
				val241.set_Key("ElevatedBackgroundColor");
				XamlServiceProvider val373 = new XamlServiceProvider();
				Type typeFromHandle95 = typeof(IProvideValueTarget);
				int length29;
				object[] array49 = new object[(length29 = parentValues.Length) + 4];
				Array.Copy(parentValues, 0, array49, 4, length29);
				array49[0] = val242;
				array49[1] = val243;
				array49[2] = val251;
				array49[3] = val257;
				SimpleValueTargetProvider val374 = new SimpleValueTargetProvider(array49, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val258);
				object obj48 = (object)val374;
				val373.Add(typeFromHandle95, (object)val374);
				val373.Add(typeof(IReferenceProvider), obj48);
				Type typeFromHandle96 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val375 = new XmlNamespaceResolver();
				val375.Add("", "http://xamarin.com/schemas/2014/forms");
				val375.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val375.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val375.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val375.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val375.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val375.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val373.Add(typeFromHandle96, (object)new XamlTypeResolver((IXmlNamespaceResolver)val375, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val373.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(370, 45)));
				DynamicResource val376 = ((IMarkupExtension<DynamicResource>)(object)val241).ProvideValue((IServiceProvider)val373);
				((IDynamicResourceHandler)val242).SetDynamicResource(VisualElement.BackgroundColorProperty, val376.get_Key());
				((Layout<View>)(object)val243).get_Children().Add((View)(object)val242);
				((ICollection<View>)val251.get_Children()).Add((View)(object)val243);
				BindableProperty fontSizeProperty5 = Label.FontSizeProperty;
				FontSizeConverter val377 = new FontSizeConverter();
				XamlServiceProvider val378 = new XamlServiceProvider();
				Type typeFromHandle97 = typeof(IProvideValueTarget);
				int length30;
				object[] array50 = new object[(length30 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array50, 3, length30);
				array50[0] = val250;
				array50[1] = val251;
				array50[2] = val257;
				SimpleValueTargetProvider val379 = new SimpleValueTargetProvider(array50, (object)Label.FontSizeProperty, (INameScope)(object)val258);
				object obj49 = (object)val379;
				val378.Add(typeFromHandle97, (object)val379);
				val378.Add(typeof(IReferenceProvider), obj49);
				Type typeFromHandle98 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val380 = new XmlNamespaceResolver();
				val380.Add("", "http://xamarin.com/schemas/2014/forms");
				val380.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val380.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val380.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val380.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val380.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val380.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val378.Add(typeFromHandle98, (object)new XamlTypeResolver((IXmlNamespaceResolver)val380, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val378.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(373, 44)));
				((BindableObject)val250).SetValue(fontSizeProperty5, ((IExtendedTypeConverter)val377).ConvertFromInvariantString("Small", (IServiceProvider)val378));
				((BindableObject)val250).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
				((BindableObject)val250).SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
				((BindableObject)val250).SetValue(View.MarginProperty, (object)new Thickness(38.0, 0.0, 0.0, 0.0));
				((BindableObject)val250).SetValue(Label.TextProperty, (object)testingScheduleView_DueToday);
				val244.set_Key("SecondaryColor");
				XamlServiceProvider val381 = new XamlServiceProvider();
				Type typeFromHandle99 = typeof(IProvideValueTarget);
				int length31;
				object[] array51 = new object[(length31 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array51, 3, length31);
				array51[0] = val250;
				array51[1] = val251;
				array51[2] = val257;
				SimpleValueTargetProvider val382 = new SimpleValueTargetProvider(array51, (object)Label.TextColorProperty, (INameScope)(object)val258);
				object obj50 = (object)val382;
				val381.Add(typeFromHandle99, (object)val382);
				val381.Add(typeof(IReferenceProvider), obj50);
				Type typeFromHandle100 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val383 = new XmlNamespaceResolver();
				val383.Add("", "http://xamarin.com/schemas/2014/forms");
				val383.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val383.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val383.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val383.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val383.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val383.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val381.Add(typeFromHandle100, (object)new XamlTypeResolver((IXmlNamespaceResolver)val383, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val381.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(378, 45)));
				DynamicResource val384 = ((IMarkupExtension<DynamicResource>)(object)val244).ProvideValue((IServiceProvider)val381);
				((IDynamicResourceHandler)val250).SetDynamicResource(Label.TextColorProperty, val384.get_Key());
				val245.set_Path("IsCovidTestDueToday");
				BindingBase binding13 = ((IMarkupExtension<BindingBase>)(object)val245).ProvideValue((IServiceProvider)null);
				val248.set_Binding(binding13);
				val248.set_Value((object)"True");
				val247.set_Property(Label.TextColorProperty);
				val246.set_Key("PrimaryColor");
				XamlServiceProvider val385 = new XamlServiceProvider();
				Type typeFromHandle101 = typeof(IProvideValueTarget);
				int length32;
				object[] array52 = new object[(length32 = parentValues.Length) + 6];
				Array.Copy(parentValues, 0, array52, 6, length32);
				array52[0] = val247;
				array52[1] = val248;
				array52[2] = val249;
				array52[3] = val250;
				array52[4] = val251;
				array52[5] = val257;
				SimpleValueTargetProvider val386 = new SimpleValueTargetProvider(array52, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val264);
				object obj51 = (object)val386;
				val385.Add(typeFromHandle101, (object)val386);
				val385.Add(typeof(IReferenceProvider), obj51);
				Type typeFromHandle102 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val387 = new XmlNamespaceResolver();
				val387.Add("", "http://xamarin.com/schemas/2014/forms");
				val387.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val387.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val387.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val387.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val387.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val387.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val385.Add(typeFromHandle102, (object)new XamlTypeResolver((IXmlNamespaceResolver)val387, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val385.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(383, 86)));
				DynamicResource value6 = ((IMarkupExtension<DynamicResource>)(object)val246).ProvideValue((IServiceProvider)val385);
				val247.set_Value((object)value6);
				val248.get_Setters().Add(val247);
				val249.get_Triggers().Add((TriggerBase)(object)val248);
				((BindableObject)val250).SetValue(VisualElement.StyleProperty, (object)val249);
				((ICollection<View>)val251.get_Children()).Add((View)(object)val250);
				((ICollection<View>)val257.get_Children()).Add((View)(object)val251);
				((BindableObject)val256).SetValue(Grid.RowProperty, (object)1);
				((BindableObject)val256).SetValue(Grid.ColumnProperty, (object)1);
				((BindableObject)val256).SetValue(StackLayout.SpacingProperty, (object)0.0);
				((BindableObject)val256).SetValue(View.MarginProperty, (object)new Thickness(0.0));
				val252.set_Key("InverseBoolConverter");
				XamlServiceProvider val388 = new XamlServiceProvider();
				Type typeFromHandle103 = typeof(IProvideValueTarget);
				int length33;
				object[] array53 = new object[(length33 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array53, 3, length33);
				array53[0] = val253;
				array53[1] = val256;
				array53[2] = val257;
				SimpleValueTargetProvider val389 = new SimpleValueTargetProvider(array53, (object)typeof(BindingExtension).GetRuntimeProperty("Converter"), (INameScope)(object)val258);
				object obj52 = (object)val389;
				val388.Add(typeFromHandle103, (object)val389);
				val388.Add(typeof(IReferenceProvider), obj52);
				Type typeFromHandle104 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val390 = new XmlNamespaceResolver();
				val390.Add("", "http://xamarin.com/schemas/2014/forms");
				val390.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val390.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val390.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val390.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val390.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val390.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val388.Add(typeFromHandle104, (object)new XamlTypeResolver((IXmlNamespaceResolver)val390, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val388.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(407, 37)));
				object converter3 = ((IMarkupExtension)val252).ProvideValue((IServiceProvider)val388);
				val253.set_Converter((IValueConverter)converter3);
				val253.set_Path("IsLastItem");
				BindingBase val391 = ((IMarkupExtension<BindingBase>)(object)val253).ProvideValue((IServiceProvider)null);
				((BindableObject)val256).SetBinding(VisualElement.IsVisibleProperty, val391);
				((BindableObject)val255).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Fill);
				((BindableObject)val255).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
				((BindableObject)val255).SetValue(VisualElement.WidthRequestProperty, (object)1.0);
				((BindableObject)val255).SetValue(VisualElement.HeightRequestProperty, (object)20.0);
				val254.set_Key("GrayColor");
				XamlServiceProvider val392 = new XamlServiceProvider();
				Type typeFromHandle105 = typeof(IProvideValueTarget);
				int length34;
				object[] array54 = new object[(length34 = parentValues.Length) + 3];
				Array.Copy(parentValues, 0, array54, 3, length34);
				array54[0] = val255;
				array54[1] = val256;
				array54[2] = val257;
				SimpleValueTargetProvider val393 = new SimpleValueTargetProvider(array54, (object)BoxView.ColorProperty, (INameScope)(object)val258);
				object obj53 = (object)val393;
				val392.Add(typeFromHandle105, (object)val393);
				val392.Add(typeof(IReferenceProvider), obj53);
				Type typeFromHandle106 = typeof(IXamlTypeResolver);
				XmlNamespaceResolver val394 = new XmlNamespaceResolver();
				val394.Add("", "http://xamarin.com/schemas/2014/forms");
				val394.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
				val394.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
				val394.Add("converters", "clr-namespace:HomeQuarantine.Converters");
				val394.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
				val394.Add("controls", "clr-namespace:HomeQuarantine.Controls");
				val394.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
				val392.Add(typeFromHandle106, (object)new XamlTypeResolver((IXmlNamespaceResolver)val394, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_11).GetTypeInfo().Assembly));
				val392.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(413, 41)));
				DynamicResource val395 = ((IMarkupExtension<DynamicResource>)(object)val254).ProvideValue((IServiceProvider)val392);
				((IDynamicResourceHandler)val255).SetDynamicResource(BoxView.ColorProperty, val395.get_Key());
				((Layout<View>)(object)val256).get_Children().Add((View)(object)val255);
				((ICollection<View>)val257.get_Children()).Add((View)(object)val256);
				return val257;
			});
			((BindableObject)val52).SetValue(BindableLayout.ItemTemplateProperty, (object)val51);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)val52);
			val53.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val136 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array18 = new object[0 + 5];
			array18[0] = shadowFrame2;
			array18[1] = val63;
			array18[2] = val64;
			array18[3] = val65;
			array18[4] = testingScheduleView;
			SimpleValueTargetProvider val137 = new SimpleValueTargetProvider(array18, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val66);
			object obj17 = (object)val137;
			val136.Add(typeFromHandle33, (object)val137);
			val136.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val138 = new XmlNamespaceResolver();
			val138.Add("", "http://xamarin.com/schemas/2014/forms");
			val138.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val138.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val138.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val138.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val138.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val138.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val136.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val138, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val136.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(422, 21)));
			DynamicResource val139 = ((IMarkupExtension<DynamicResource>)(object)val53).ProvideValue((IServiceProvider)val136);
			((IDynamicResourceHandler)shadowFrame2).SetDynamicResource(VisualElement.BackgroundColorProperty, val139.get_Key());
			((BindableObject)shadowFrame2).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)shadowFrame2).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0, 0.0, 0.0, 32.0));
			((BindableObject)val62).SetValue(StackLayout.SpacingProperty, (object)16.0);
			val54.set_Key("PrimaryColor");
			XamlServiceProvider val140 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array19 = new object[0 + 7];
			array19[0] = val55;
			array19[1] = val62;
			array19[2] = shadowFrame2;
			array19[3] = val63;
			array19[4] = val64;
			array19[5] = val65;
			array19[6] = testingScheduleView;
			SimpleValueTargetProvider val141 = new SimpleValueTargetProvider(array19, (object)BoxView.ColorProperty, (INameScope)(object)val66);
			object obj18 = (object)val141;
			val140.Add(typeFromHandle35, (object)val141);
			val140.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val142 = new XmlNamespaceResolver();
			val142.Add("", "http://xamarin.com/schemas/2014/forms");
			val142.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val142.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val142.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val142.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val142.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val142.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val140.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val142, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val140.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(426, 34)));
			DynamicResource val143 = ((IMarkupExtension<DynamicResource>)(object)val54).ProvideValue((IServiceProvider)val140);
			((IDynamicResourceHandler)val55).SetDynamicResource(BoxView.ColorProperty, val143.get_Key());
			((BindableObject)val55).SetValue(VisualElement.HeightRequestProperty, (object)7.0);
			((Layout<View>)(object)val62).get_Children().Add((View)(object)val55);
			((BindableObject)val61).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val61).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)val57).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val56.set_Key("Heading2");
			XamlServiceProvider val144 = new XamlServiceProvider();
			Type typeFromHandle37 = typeof(IProvideValueTarget);
			object[] array20 = new object[0 + 8];
			array20[0] = val57;
			array20[1] = val61;
			array20[2] = val62;
			array20[3] = shadowFrame2;
			array20[4] = val63;
			array20[5] = val64;
			array20[6] = val65;
			array20[7] = testingScheduleView;
			SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array20, (object)VisualElement.StyleProperty, (INameScope)(object)val66);
			object obj19 = (object)val145;
			val144.Add(typeFromHandle37, (object)val145);
			val144.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle38 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val146 = new XmlNamespaceResolver();
			val146.Add("", "http://xamarin.com/schemas/2014/forms");
			val146.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val146.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val146.Add("converters", "clr-namespace:HomeQuarantine.Converters");
			val146.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val146.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val146.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val144.Add(typeFromHandle38, (object)new XamlTypeResolver((IXmlNamespaceResolver)val146, typeof(TestingScheduleView).GetTypeInfo().Assembly));
			val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(431, 33)));
			DynamicResource val147 = ((IMarkupExtension<DynamicResource>)(object)val56).ProvideValue((IServiceProvider)val144);
			((IDynamicResourceHandler)val57).SetDynamicResource(VisualElement.StyleProperty, val147.get_Key());
			((BindableObject)val57).SetValue(View.MarginProperty, (object)new Thickness(0.0, 16.0, 0.0, 0.0));
			((BindableObject)val57).SetValue(Label.TextProperty, (object)hasSymptomView_CovidTestingLocations);
			((Layout<View>)(object)val61).get_Children().Add((View)(object)val57);
			((BindableObject)val58).SetValue(Label.TextProperty, (object)hasSymptomView_TestingLocationSubtitle);
			((Layout<View>)(object)val61).get_Children().Add((View)(object)val58);
			((BindableObject)val59).SetValue(Label.TextProperty, (object)hasSymptomView_TestingLocationSubtitle2);
			((Layout<View>)(object)val61).get_Children().Add((View)(object)val59);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.TextProperty, (object)hasSymptomView_TestingLocations);
			val60.set_Path("TestingLocationsUrl");
			BindingBase val148 = ((IMarkupExtension<BindingBase>)(object)val60).ProvideValue((IServiceProvider)null);
			((BindableObject)resourceLinkView).SetBinding(ResourceLinkView.UrlProperty, val148);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((BindableObject)resourceLinkView).SetValue(View.MarginProperty, (object)new Thickness(0.0, 0.0));
			((Layout<View>)(object)val61).get_Children().Add((View)(object)resourceLinkView);
			((Layout<View>)(object)val62).get_Children().Add((View)(object)val61);
			((BindableObject)shadowFrame2).SetValue(ContentView.ContentProperty, (object)val62);
			((Layout<View>)(object)val63).get_Children().Add((View)(object)shadowFrame2);
			val64.set_Content((View)(object)val63);
			((BindableObject)val65).SetValue(ContentView.ContentProperty, (object)val64);
			((BindableObject)testingScheduleView).SetValue(ContentPage.ContentProperty, (object)val65);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<TestingScheduleView>(this, typeof(TestingScheduleView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			covidTestingLocations = NameScopeExtensions.FindByName<Label>((Element)(object)this, "covidTestingLocations");
			testingLocationDetails = NameScopeExtensions.FindByName<Label>((Element)(object)this, "testingLocationDetails");
			testingLocationDetails2 = NameScopeExtensions.FindByName<Label>((Element)(object)this, "testingLocationDetails2");
			testingLocationsUrl = NameScopeExtensions.FindByName<ResourceLinkView>((Element)(object)this, "testingLocationsUrl");
		}
	}
}
