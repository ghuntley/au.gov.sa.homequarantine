using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Themes
{
	[XamlFilePath("Themes/DesignSystem.xaml")]
	public class DesignSystem : ResourceDictionary
	{
		public DesignSystem()
			: this()
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
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
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
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected O, but got Unknown
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected O, but got Unknown
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected O, but got Unknown
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Expected O, but got Unknown
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected O, but got Unknown
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
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected O, but got Unknown
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Expected O, but got Unknown
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected O, but got Unknown
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Expected O, but got Unknown
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Expected O, but got Unknown
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Expected O, but got Unknown
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Expected O, but got Unknown
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected O, but got Unknown
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected O, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Expected O, but got Unknown
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Expected O, but got Unknown
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected O, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Expected O, but got Unknown
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected O, but got Unknown
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Expected O, but got Unknown
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected O, but got Unknown
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Expected O, but got Unknown
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Expected O, but got Unknown
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected O, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected O, but got Unknown
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Expected O, but got Unknown
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected O, but got Unknown
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Expected O, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Expected O, but got Unknown
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected O, but got Unknown
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Expected O, but got Unknown
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Expected O, but got Unknown
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected O, but got Unknown
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Expected O, but got Unknown
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Expected O, but got Unknown
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected O, but got Unknown
			//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Expected O, but got Unknown
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected O, but got Unknown
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Expected O, but got Unknown
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected O, but got Unknown
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Expected O, but got Unknown
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Expected O, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Expected O, but got Unknown
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected O, but got Unknown
			//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Expected O, but got Unknown
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Expected O, but got Unknown
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected O, but got Unknown
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Expected O, but got Unknown
			//IL_045b: Expected O, but got Unknown
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c6: Expected O, but got Unknown
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Expected O, but got Unknown
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e4: Expected O, but got Unknown
			//IL_04df: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e9: Expected O, but got Unknown
			//IL_04ee: Expected O, but got Unknown
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_052a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Expected O, but got Unknown
			//IL_0564: Expected O, but got Unknown
			//IL_0564: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Expected O, but got Unknown
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d4: Expected O, but got Unknown
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ed: Expected O, but got Unknown
			//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f2: Expected O, but got Unknown
			//IL_05f7: Expected O, but got Unknown
			//IL_0661: Unknown result type (might be due to invalid IL or missing references)
			//IL_0666: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Expected O, but got Unknown
			//IL_06b1: Expected O, but got Unknown
			//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Expected O, but got Unknown
			//IL_0717: Unknown result type (might be due to invalid IL or missing references)
			//IL_0721: Expected O, but got Unknown
			//IL_0721: Unknown result type (might be due to invalid IL or missing references)
			//IL_0730: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Expected O, but got Unknown
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Expected O, but got Unknown
			//IL_0744: Expected O, but got Unknown
			//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0804: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Expected O, but got Unknown
			//IL_080c: Expected O, but got Unknown
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_081e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0829: Unknown result type (might be due to invalid IL or missing references)
			//IL_082e: Unknown result type (might be due to invalid IL or missing references)
			//IL_083e: Unknown result type (might be due to invalid IL or missing references)
			//IL_084e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0877: Expected O, but got Unknown
			//IL_0872: Unknown result type (might be due to invalid IL or missing references)
			//IL_087c: Expected O, but got Unknown
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			//IL_088b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0895: Expected O, but got Unknown
			//IL_0890: Unknown result type (might be due to invalid IL or missing references)
			//IL_089a: Expected O, but got Unknown
			//IL_089f: Expected O, but got Unknown
			//IL_08db: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_091e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0923: Unknown result type (might be due to invalid IL or missing references)
			//IL_0926: Expected O, but got Unknown
			//IL_092b: Expected O, but got Unknown
			//IL_092b: Unknown result type (might be due to invalid IL or missing references)
			//IL_093d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0948: Unknown result type (might be due to invalid IL or missing references)
			//IL_094d: Unknown result type (might be due to invalid IL or missing references)
			//IL_095d: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0996: Expected O, but got Unknown
			//IL_0991: Unknown result type (might be due to invalid IL or missing references)
			//IL_099b: Expected O, but got Unknown
			//IL_099b: Unknown result type (might be due to invalid IL or missing references)
			//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b4: Expected O, but got Unknown
			//IL_09af: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b9: Expected O, but got Unknown
			//IL_09be: Expected O, but got Unknown
			//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a45: Expected O, but got Unknown
			//IL_0a4a: Expected O, but got Unknown
			//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab5: Expected O, but got Unknown
			//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aba: Expected O, but got Unknown
			//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad3: Expected O, but got Unknown
			//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad8: Expected O, but got Unknown
			//IL_0add: Expected O, but got Unknown
			//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5b: Expected O, but got Unknown
			//IL_0b60: Expected O, but got Unknown
			//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c7a: Expected O, but got Unknown
			//IL_0c7f: Expected O, but got Unknown
			//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cea: Expected O, but got Unknown
			//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cef: Expected O, but got Unknown
			//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d08: Expected O, but got Unknown
			//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0d: Expected O, but got Unknown
			//IL_0d12: Expected O, but got Unknown
			//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d99: Expected O, but got Unknown
			//IL_0d9e: Expected O, but got Unknown
			//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e09: Expected O, but got Unknown
			//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0e: Expected O, but got Unknown
			//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e27: Expected O, but got Unknown
			//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2c: Expected O, but got Unknown
			//IL_0e31: Expected O, but got Unknown
			//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eaa: Expected O, but got Unknown
			//IL_0eaf: Expected O, but got Unknown
			//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1a: Expected O, but got Unknown
			//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1f: Expected O, but got Unknown
			//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f38: Expected O, but got Unknown
			//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3d: Expected O, but got Unknown
			//IL_0f42: Expected O, but got Unknown
			//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1001: Unknown result type (might be due to invalid IL or missing references)
			//IL_1004: Expected O, but got Unknown
			//IL_1009: Expected O, but got Unknown
			//IL_1009: Unknown result type (might be due to invalid IL or missing references)
			//IL_101b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1026: Unknown result type (might be due to invalid IL or missing references)
			//IL_102b: Unknown result type (might be due to invalid IL or missing references)
			//IL_103b: Unknown result type (might be due to invalid IL or missing references)
			//IL_104b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1074: Expected O, but got Unknown
			//IL_106f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1079: Expected O, but got Unknown
			//IL_1079: Unknown result type (might be due to invalid IL or missing references)
			//IL_1088: Unknown result type (might be due to invalid IL or missing references)
			//IL_1092: Expected O, but got Unknown
			//IL_108d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1097: Expected O, but got Unknown
			//IL_109c: Expected O, but got Unknown
			//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_10de: Unknown result type (might be due to invalid IL or missing references)
			//IL_110d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1112: Unknown result type (might be due to invalid IL or missing references)
			//IL_1115: Expected O, but got Unknown
			//IL_111a: Expected O, but got Unknown
			//IL_111a: Unknown result type (might be due to invalid IL or missing references)
			//IL_112c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1137: Unknown result type (might be due to invalid IL or missing references)
			//IL_113c: Unknown result type (might be due to invalid IL or missing references)
			//IL_114c: Unknown result type (might be due to invalid IL or missing references)
			//IL_115c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1185: Expected O, but got Unknown
			//IL_1180: Unknown result type (might be due to invalid IL or missing references)
			//IL_118a: Expected O, but got Unknown
			//IL_118a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1199: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a3: Expected O, but got Unknown
			//IL_119e: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a8: Expected O, but got Unknown
			//IL_11ad: Expected O, but got Unknown
			//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_122b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1230: Unknown result type (might be due to invalid IL or missing references)
			//IL_1233: Expected O, but got Unknown
			//IL_1238: Expected O, but got Unknown
			//IL_1238: Unknown result type (might be due to invalid IL or missing references)
			//IL_124a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1255: Unknown result type (might be due to invalid IL or missing references)
			//IL_125a: Unknown result type (might be due to invalid IL or missing references)
			//IL_126a: Unknown result type (might be due to invalid IL or missing references)
			//IL_127a: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a3: Expected O, but got Unknown
			//IL_129e: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a8: Expected O, but got Unknown
			//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c1: Expected O, but got Unknown
			//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c6: Expected O, but got Unknown
			//IL_12cb: Expected O, but got Unknown
			//IL_12fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_1308: Unknown result type (might be due to invalid IL or missing references)
			//IL_130d: Unknown result type (might be due to invalid IL or missing references)
			//IL_133c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1341: Unknown result type (might be due to invalid IL or missing references)
			//IL_1344: Expected O, but got Unknown
			//IL_1349: Expected O, but got Unknown
			//IL_1349: Unknown result type (might be due to invalid IL or missing references)
			//IL_135b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1366: Unknown result type (might be due to invalid IL or missing references)
			//IL_136b: Unknown result type (might be due to invalid IL or missing references)
			//IL_137b: Unknown result type (might be due to invalid IL or missing references)
			//IL_138b: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b4: Expected O, but got Unknown
			//IL_13af: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b9: Expected O, but got Unknown
			//IL_13b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_13c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d2: Expected O, but got Unknown
			//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d7: Expected O, but got Unknown
			//IL_13dc: Expected O, but got Unknown
			//IL_1417: Unknown result type (might be due to invalid IL or missing references)
			//IL_141c: Unknown result type (might be due to invalid IL or missing references)
			//IL_145a: Unknown result type (might be due to invalid IL or missing references)
			//IL_145f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1462: Expected O, but got Unknown
			//IL_1467: Expected O, but got Unknown
			//IL_1467: Unknown result type (might be due to invalid IL or missing references)
			//IL_1479: Unknown result type (might be due to invalid IL or missing references)
			//IL_1484: Unknown result type (might be due to invalid IL or missing references)
			//IL_1489: Unknown result type (might be due to invalid IL or missing references)
			//IL_1499: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d2: Expected O, but got Unknown
			//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d7: Expected O, but got Unknown
			//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f0: Expected O, but got Unknown
			//IL_14eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f5: Expected O, but got Unknown
			//IL_14fa: Expected O, but got Unknown
			//IL_152d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1537: Unknown result type (might be due to invalid IL or missing references)
			//IL_153c: Unknown result type (might be due to invalid IL or missing references)
			//IL_156b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1570: Unknown result type (might be due to invalid IL or missing references)
			//IL_1573: Expected O, but got Unknown
			//IL_1578: Expected O, but got Unknown
			//IL_1578: Unknown result type (might be due to invalid IL or missing references)
			//IL_158a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1595: Unknown result type (might be due to invalid IL or missing references)
			//IL_159a: Unknown result type (might be due to invalid IL or missing references)
			//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_15e3: Expected O, but got Unknown
			//IL_15de: Unknown result type (might be due to invalid IL or missing references)
			//IL_15e8: Expected O, but got Unknown
			//IL_15e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1601: Expected O, but got Unknown
			//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1606: Expected O, but got Unknown
			//IL_160b: Expected O, but got Unknown
			//IL_1646: Unknown result type (might be due to invalid IL or missing references)
			//IL_164b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1689: Unknown result type (might be due to invalid IL or missing references)
			//IL_168e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1691: Expected O, but got Unknown
			//IL_1696: Expected O, but got Unknown
			//IL_1696: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1701: Expected O, but got Unknown
			//IL_16fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1706: Expected O, but got Unknown
			//IL_1706: Unknown result type (might be due to invalid IL or missing references)
			//IL_1715: Unknown result type (might be due to invalid IL or missing references)
			//IL_171f: Expected O, but got Unknown
			//IL_171a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1724: Expected O, but got Unknown
			//IL_1729: Expected O, but got Unknown
			//IL_175c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1766: Unknown result type (might be due to invalid IL or missing references)
			//IL_176b: Unknown result type (might be due to invalid IL or missing references)
			//IL_179a: Unknown result type (might be due to invalid IL or missing references)
			//IL_179f: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a2: Expected O, but got Unknown
			//IL_17a7: Expected O, but got Unknown
			//IL_17a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1812: Expected O, but got Unknown
			//IL_180d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1817: Expected O, but got Unknown
			//IL_1817: Unknown result type (might be due to invalid IL or missing references)
			//IL_1826: Unknown result type (might be due to invalid IL or missing references)
			//IL_1830: Expected O, but got Unknown
			//IL_182b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1835: Expected O, but got Unknown
			//IL_183a: Expected O, but got Unknown
			//IL_18e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1926: Unknown result type (might be due to invalid IL or missing references)
			//IL_192b: Unknown result type (might be due to invalid IL or missing references)
			//IL_192e: Expected O, but got Unknown
			//IL_1933: Expected O, but got Unknown
			//IL_1933: Unknown result type (might be due to invalid IL or missing references)
			//IL_1945: Unknown result type (might be due to invalid IL or missing references)
			//IL_1950: Unknown result type (might be due to invalid IL or missing references)
			//IL_1955: Unknown result type (might be due to invalid IL or missing references)
			//IL_1965: Unknown result type (might be due to invalid IL or missing references)
			//IL_1975: Unknown result type (might be due to invalid IL or missing references)
			//IL_199e: Expected O, but got Unknown
			//IL_1999: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a3: Expected O, but got Unknown
			//IL_19a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_19bc: Expected O, but got Unknown
			//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_19c1: Expected O, but got Unknown
			//IL_19c6: Expected O, but got Unknown
			//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a52: Expected O, but got Unknown
			//IL_1a57: Expected O, but got Unknown
			//IL_1a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a69: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a89: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a99: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac2: Expected O, but got Unknown
			//IL_1abd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac7: Expected O, but got Unknown
			//IL_1ac7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ae0: Expected O, but got Unknown
			//IL_1adb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ae5: Expected O, but got Unknown
			//IL_1aea: Expected O, but got Unknown
			//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b73: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b76: Expected O, but got Unknown
			//IL_1b7b: Expected O, but got Unknown
			//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bad: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1be6: Expected O, but got Unknown
			//IL_1be1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1beb: Expected O, but got Unknown
			//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c04: Expected O, but got Unknown
			//IL_1bff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c09: Expected O, but got Unknown
			//IL_1c0e: Expected O, but got Unknown
			//IL_1c41: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ccc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d12: Expected O, but got Unknown
			//IL_1d17: Expected O, but got Unknown
			//IL_1d17: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d29: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d39: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d49: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d59: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d82: Expected O, but got Unknown
			//IL_1d7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d87: Expected O, but got Unknown
			//IL_1d87: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d96: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da0: Expected O, but got Unknown
			//IL_1d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da5: Expected O, but got Unknown
			//IL_1daa: Expected O, but got Unknown
			//IL_1deb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e33: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e36: Expected O, but got Unknown
			//IL_1e3b: Expected O, but got Unknown
			//IL_1e3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ea6: Expected O, but got Unknown
			//IL_1ea1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eab: Expected O, but got Unknown
			//IL_1eab: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eba: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec4: Expected O, but got Unknown
			//IL_1ebf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec9: Expected O, but got Unknown
			//IL_1ece: Expected O, but got Unknown
			//IL_1f01: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fe6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1feb: Unknown result type (might be due to invalid IL or missing references)
			//IL_201a: Unknown result type (might be due to invalid IL or missing references)
			//IL_201f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2022: Expected O, but got Unknown
			//IL_2027: Expected O, but got Unknown
			//IL_2027: Unknown result type (might be due to invalid IL or missing references)
			//IL_2039: Unknown result type (might be due to invalid IL or missing references)
			//IL_2044: Unknown result type (might be due to invalid IL or missing references)
			//IL_2049: Unknown result type (might be due to invalid IL or missing references)
			//IL_2059: Unknown result type (might be due to invalid IL or missing references)
			//IL_2069: Unknown result type (might be due to invalid IL or missing references)
			//IL_2092: Expected O, but got Unknown
			//IL_208d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2097: Expected O, but got Unknown
			//IL_2097: Unknown result type (might be due to invalid IL or missing references)
			//IL_20a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b0: Expected O, but got Unknown
			//IL_20ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b5: Expected O, but got Unknown
			//IL_20ba: Expected O, but got Unknown
			//IL_20e7: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(DesignSystem).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Themes/DesignSystem.xaml");
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
			DynamicResourceExtension val2 = new DynamicResourceExtension();
			Setter val3 = new Setter();
			Setter val4 = new Setter();
			Style val5 = new Style(typeof(Label));
			Setter val6 = new Setter();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			Setter val8 = new Setter();
			Style val9 = new Style(typeof(Frame));
			Setter val10 = new Setter();
			Style val11 = new Style(typeof(Button));
			DynamicResourceExtension val12 = new DynamicResourceExtension();
			Setter val13 = new Setter();
			Style val14 = new Style(typeof(ShadowFrame));
			DynamicResourceExtension val15 = new DynamicResourceExtension();
			Setter val16 = new Setter();
			Style val17 = new Style(typeof(CheckBox));
			DynamicResourceExtension val18 = new DynamicResourceExtension();
			Setter val19 = new Setter();
			DynamicResourceExtension val20 = new DynamicResourceExtension();
			Setter val21 = new Setter();
			Style val22 = new Style(typeof(Entry));
			DynamicResourceExtension val23 = new DynamicResourceExtension();
			Setter val24 = new Setter();
			Style val25 = new Style(typeof(ActivityIndicator));
			DynamicResourceExtension val26 = new DynamicResourceExtension();
			Setter val27 = new Setter();
			Setter val28 = new Setter();
			Setter val29 = new Setter();
			Style val30 = new Style(typeof(Label));
			DynamicResourceExtension val31 = new DynamicResourceExtension();
			Setter val32 = new Setter();
			Setter val33 = new Setter();
			Style val34 = new Style(typeof(Label));
			DynamicResourceExtension val35 = new DynamicResourceExtension();
			Setter val36 = new Setter();
			Setter val37 = new Setter();
			Style val38 = new Style(typeof(Label));
			DynamicResourceExtension val39 = new DynamicResourceExtension();
			Setter val40 = new Setter();
			Setter val41 = new Setter();
			Style val42 = new Style(typeof(Label));
			DynamicResourceExtension val43 = new DynamicResourceExtension();
			Setter val44 = new Setter();
			Setter val45 = new Setter();
			Setter val46 = new Setter();
			Style val47 = new Style(typeof(Label));
			Setter val48 = new Setter();
			DynamicResourceExtension val49 = new DynamicResourceExtension();
			Setter val50 = new Setter();
			Style val51 = new Style(typeof(Frame));
			DynamicResourceExtension val52 = new DynamicResourceExtension();
			Setter val53 = new Setter();
			Style val54 = new Style(typeof(ShadowFrame));
			DynamicResourceExtension val55 = new DynamicResourceExtension();
			Setter val56 = new Setter();
			Setter val57 = new Setter();
			Setter val58 = new Setter();
			Style val59 = new Style(typeof(Label));
			DynamicResourceExtension val60 = new DynamicResourceExtension();
			Setter val61 = new Setter();
			Style val62 = new Style(typeof(Label));
			DynamicResourceExtension val63 = new DynamicResourceExtension();
			Setter val64 = new Setter();
			Setter val65 = new Setter();
			Setter val66 = new Setter();
			Setter val67 = new Setter();
			Setter val68 = new Setter();
			Setter val69 = new Setter();
			Style val70 = new Style(typeof(Button));
			NameScope val71 = new NameScope();
			NameScope val72 = new NameScope();
			NameScope val73 = new NameScope();
			NameScope val74 = new NameScope();
			NameScope val75 = new NameScope();
			NameScope val76 = new NameScope();
			NameScope val77 = new NameScope();
			NameScope val78 = new NameScope();
			NameScope val79 = new NameScope();
			NameScope val80 = new NameScope();
			NameScope val81 = new NameScope();
			NameScope val82 = new NameScope();
			NameScope val83 = new NameScope();
			NameScope val84 = new NameScope();
			NameScope val85 = new NameScope();
			NameScope val86 = new NameScope();
			NameScope val87 = new NameScope();
			NameScope val88 = new NameScope();
			NameScope val89 = new NameScope();
			NameScope val90 = new NameScope();
			NameScope val91 = new NameScope();
			NameScope val92 = new NameScope();
			NameScope val93 = new NameScope();
			NameScope val94 = new NameScope();
			NameScope val95 = new NameScope();
			NameScope val96 = new NameScope();
			NameScope val97 = new NameScope();
			NameScope val98 = new NameScope();
			NameScope val99 = new NameScope();
			NameScope val100 = new NameScope();
			NameScope val101 = new NameScope();
			NameScope val102 = new NameScope();
			NameScope val103 = new NameScope();
			NameScope val104 = new NameScope();
			NameScope val105 = new NameScope();
			NameScope val106 = new NameScope();
			val3.set_Property(Label.TextColorProperty);
			val2.set_Key("PrimaryTextColor");
			XamlServiceProvider val107 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array;
			int num;
			object[] array2 = (array = new object[(num = 0) + 3]);
			array2[0] = val3;
			array2[1] = val5;
			array2[2] = this;
			SimpleValueTargetProvider val108 = new SimpleValueTargetProvider(array2, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val72);
			object obj = (object)val108;
			val107.Add(typeFromHandle, (object)val108);
			val107.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val109 = new XmlNamespaceResolver();
			val109.Add("", "http://xamarin.com/schemas/2014/forms");
			val109.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val109.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val107.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val109, typeof(DesignSystem).GetTypeInfo().Assembly));
			val107.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 38)));
			DynamicResource value = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val107);
			val3.set_Value((object)value);
			val5.get_Setters().Add(val3);
			val4.set_Property(Label.FontSizeProperty);
			val4.set_Value((object)"Body");
			FontSizeConverter val110 = new FontSizeConverter();
			XamlServiceProvider val111 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array3;
			int num2;
			object[] array4 = (array3 = new object[(num2 = 0) + 3]);
			array4[0] = val4;
			array4[1] = val5;
			array4[2] = this;
			SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array4, (object)Label.FontSizeProperty, (INameScope)(object)val73);
			object obj2 = (object)val112;
			val111.Add(typeFromHandle3, (object)val112);
			val111.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val113 = new XmlNamespaceResolver();
			val113.Add("", "http://xamarin.com/schemas/2014/forms");
			val113.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val113.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val111.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val113, typeof(DesignSystem).GetTypeInfo().Assembly));
			val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 37)));
			val4.set_Value(((IExtendedTypeConverter)val110).ConvertFromInvariantString("Body", (IServiceProvider)val111));
			val5.get_Setters().Add(val4);
			((ResourceDictionary)this).Add(val5);
			val6.set_Property(Frame.CornerRadiusProperty);
			val6.set_Value((object)"7");
			val6.set_Value((object)7f);
			val9.get_Setters().Add(val6);
			val8.set_Property(VisualElement.BackgroundColorProperty);
			val7.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val114 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array5;
			int num3;
			object[] array6 = (array5 = new object[(num3 = 0) + 3]);
			array6[0] = val8;
			array6[1] = val9;
			array6[2] = this;
			SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array6, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val75);
			object obj3 = (object)val115;
			val114.Add(typeFromHandle5, (object)val115);
			val114.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val116 = new XmlNamespaceResolver();
			val116.Add("", "http://xamarin.com/schemas/2014/forms");
			val116.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val116.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val114.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val116, typeof(DesignSystem).GetTypeInfo().Assembly));
			val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(16, 44)));
			DynamicResource value2 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val114);
			val8.set_Value((object)value2);
			val9.get_Setters().Add(val8);
			((ResourceDictionary)this).Add(val9);
			val10.set_Property(Button.CornerRadiusProperty);
			val10.set_Value((object)"7");
			val10.set_Value((object)7);
			val11.get_Setters().Add(val10);
			((ResourceDictionary)this).Add(val11);
			val13.set_Property(VisualElement.BackgroundColorProperty);
			val12.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val117 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array7;
			int num4;
			object[] array8 = (array7 = new object[(num4 = 0) + 3]);
			array8[0] = val13;
			array8[1] = val14;
			array8[2] = this;
			SimpleValueTargetProvider val118 = new SimpleValueTargetProvider(array8, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val77);
			object obj4 = (object)val118;
			val117.Add(typeFromHandle7, (object)val118);
			val117.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val119 = new XmlNamespaceResolver();
			val119.Add("", "http://xamarin.com/schemas/2014/forms");
			val119.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val119.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val117.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val119, typeof(DesignSystem).GetTypeInfo().Assembly));
			val117.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 44)));
			DynamicResource value3 = ((IMarkupExtension<DynamicResource>)(object)val12).ProvideValue((IServiceProvider)val117);
			val13.set_Value((object)value3);
			val14.get_Setters().Add(val13);
			((ResourceDictionary)this).Add(val14);
			val16.set_Property(CheckBox.ColorProperty);
			val15.set_Key("PrimaryTextColor");
			XamlServiceProvider val120 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array9;
			int num5;
			object[] array10 = (array9 = new object[(num5 = 0) + 3]);
			array10[0] = val16;
			array10[1] = val17;
			array10[2] = this;
			SimpleValueTargetProvider val121 = new SimpleValueTargetProvider(array10, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val78);
			object obj5 = (object)val121;
			val120.Add(typeFromHandle9, (object)val121);
			val120.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val122 = new XmlNamespaceResolver();
			val122.Add("", "http://xamarin.com/schemas/2014/forms");
			val122.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val122.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val120.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val122, typeof(DesignSystem).GetTypeInfo().Assembly));
			val120.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 34)));
			DynamicResource value4 = ((IMarkupExtension<DynamicResource>)(object)val15).ProvideValue((IServiceProvider)val120);
			val16.set_Value((object)value4);
			val17.get_Setters().Add(val16);
			((ResourceDictionary)this).Add(val17);
			val19.set_Property(Entry.TextColorProperty);
			val18.set_Key("PrimaryTextColor");
			XamlServiceProvider val123 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array11;
			int num6;
			object[] array12 = (array11 = new object[(num6 = 0) + 3]);
			array12[0] = val19;
			array12[1] = val22;
			array12[2] = this;
			SimpleValueTargetProvider val124 = new SimpleValueTargetProvider(array12, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val79);
			object obj6 = (object)val124;
			val123.Add(typeFromHandle11, (object)val124);
			val123.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val125 = new XmlNamespaceResolver();
			val125.Add("", "http://xamarin.com/schemas/2014/forms");
			val125.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val125.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val123.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val125, typeof(DesignSystem).GetTypeInfo().Assembly));
			val123.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 35)));
			DynamicResource value5 = ((IMarkupExtension<DynamicResource>)(object)val18).ProvideValue((IServiceProvider)val123);
			val19.set_Value((object)value5);
			val22.get_Setters().Add(val19);
			val21.set_Property(VisualElement.BackgroundColorProperty);
			val20.set_Key("BackgroundColor");
			XamlServiceProvider val126 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array13;
			int num7;
			object[] array14 = (array13 = new object[(num7 = 0) + 3]);
			array14[0] = val21;
			array14[1] = val22;
			array14[2] = this;
			SimpleValueTargetProvider val127 = new SimpleValueTargetProvider(array14, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val80);
			object obj7 = (object)val127;
			val126.Add(typeFromHandle13, (object)val127);
			val126.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val128 = new XmlNamespaceResolver();
			val128.Add("", "http://xamarin.com/schemas/2014/forms");
			val128.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val128.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val126.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val128, typeof(DesignSystem).GetTypeInfo().Assembly));
			val126.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 44)));
			DynamicResource value6 = ((IMarkupExtension<DynamicResource>)(object)val20).ProvideValue((IServiceProvider)val126);
			val21.set_Value((object)value6);
			val22.get_Setters().Add(val21);
			((ResourceDictionary)this).Add(val22);
			val24.set_Property(ActivityIndicator.ColorProperty);
			val23.set_Key("SecondaryTextColor");
			XamlServiceProvider val129 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array15;
			int num8;
			object[] array16 = (array15 = new object[(num8 = 0) + 3]);
			array16[0] = val24;
			array16[1] = val25;
			array16[2] = this;
			SimpleValueTargetProvider val130 = new SimpleValueTargetProvider(array16, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val81);
			object obj8 = (object)val130;
			val129.Add(typeFromHandle15, (object)val130);
			val129.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val131 = new XmlNamespaceResolver();
			val131.Add("", "http://xamarin.com/schemas/2014/forms");
			val131.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val131.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val129.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val131, typeof(DesignSystem).GetTypeInfo().Assembly));
			val129.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 31)));
			DynamicResource value7 = ((IMarkupExtension<DynamicResource>)(object)val23).ProvideValue((IServiceProvider)val129);
			val24.set_Value((object)value7);
			val25.get_Setters().Add(val24);
			((ResourceDictionary)this).Add(val25);
			val27.set_Property(Label.TextColorProperty);
			val26.set_Key("PrimaryTextColor");
			XamlServiceProvider val132 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array17;
			int num9;
			object[] array18 = (array17 = new object[(num9 = 0) + 3]);
			array18[0] = val27;
			array18[1] = val30;
			array18[2] = this;
			SimpleValueTargetProvider val133 = new SimpleValueTargetProvider(array18, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val82);
			object obj9 = (object)val133;
			val132.Add(typeFromHandle17, (object)val133);
			val132.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val134 = new XmlNamespaceResolver();
			val134.Add("", "http://xamarin.com/schemas/2014/forms");
			val134.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val134.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val132.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val134, typeof(DesignSystem).GetTypeInfo().Assembly));
			val132.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 38)));
			DynamicResource value8 = ((IMarkupExtension<DynamicResource>)(object)val26).ProvideValue((IServiceProvider)val132);
			val27.set_Value((object)value8);
			val30.get_Setters().Add(val27);
			val28.set_Property(Label.FontSizeProperty);
			val28.set_Value((object)"Title");
			FontSizeConverter val135 = new FontSizeConverter();
			XamlServiceProvider val136 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array19;
			int num10;
			object[] array20 = (array19 = new object[(num10 = 0) + 3]);
			array20[0] = val28;
			array20[1] = val30;
			array20[2] = this;
			SimpleValueTargetProvider val137 = new SimpleValueTargetProvider(array20, (object)Label.FontSizeProperty, (INameScope)(object)val83);
			object obj10 = (object)val137;
			val136.Add(typeFromHandle19, (object)val137);
			val136.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val138 = new XmlNamespaceResolver();
			val138.Add("", "http://xamarin.com/schemas/2014/forms");
			val138.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val138.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val136.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val138, typeof(DesignSystem).GetTypeInfo().Assembly));
			val136.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 37)));
			val28.set_Value(((IExtendedTypeConverter)val135).ConvertFromInvariantString("Title", (IServiceProvider)val136));
			val30.get_Setters().Add(val28);
			val29.set_Property(Label.FontAttributesProperty);
			val29.set_Value((object)"Bold");
			val29.set_Value(new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val30.get_Setters().Add(val29);
			((ResourceDictionary)this).Add("Heading1", (object)val30);
			val32.set_Property(Label.TextColorProperty);
			val31.set_Key("PrimaryTextColor");
			XamlServiceProvider val139 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array21;
			int num11;
			object[] array22 = (array21 = new object[(num11 = 0) + 3]);
			array22[0] = val32;
			array22[1] = val34;
			array22[2] = this;
			SimpleValueTargetProvider val140 = new SimpleValueTargetProvider(array22, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val85);
			object obj11 = (object)val140;
			val139.Add(typeFromHandle21, (object)val140);
			val139.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val141 = new XmlNamespaceResolver();
			val141.Add("", "http://xamarin.com/schemas/2014/forms");
			val141.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val141.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val139.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val141, typeof(DesignSystem).GetTypeInfo().Assembly));
			val139.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 38)));
			DynamicResource value9 = ((IMarkupExtension<DynamicResource>)(object)val31).ProvideValue((IServiceProvider)val139);
			val32.set_Value((object)value9);
			val34.get_Setters().Add(val32);
			val33.set_Property(Label.FontSizeProperty);
			val33.set_Value((object)"Large");
			FontSizeConverter val142 = new FontSizeConverter();
			XamlServiceProvider val143 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array23;
			int num12;
			object[] array24 = (array23 = new object[(num12 = 0) + 3]);
			array24[0] = val33;
			array24[1] = val34;
			array24[2] = this;
			SimpleValueTargetProvider val144 = new SimpleValueTargetProvider(array24, (object)Label.FontSizeProperty, (INameScope)(object)val86);
			object obj12 = (object)val144;
			val143.Add(typeFromHandle23, (object)val144);
			val143.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val145 = new XmlNamespaceResolver();
			val145.Add("", "http://xamarin.com/schemas/2014/forms");
			val145.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val145.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val143.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val145, typeof(DesignSystem).GetTypeInfo().Assembly));
			val143.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 37)));
			val33.set_Value(((IExtendedTypeConverter)val142).ConvertFromInvariantString("Large", (IServiceProvider)val143));
			val34.get_Setters().Add(val33);
			((ResourceDictionary)this).Add("Heading2", (object)val34);
			val36.set_Property(Label.TextColorProperty);
			val35.set_Key("PrimaryTextColor");
			XamlServiceProvider val146 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array25;
			int num13;
			object[] array26 = (array25 = new object[(num13 = 0) + 3]);
			array26[0] = val36;
			array26[1] = val38;
			array26[2] = this;
			SimpleValueTargetProvider val147 = new SimpleValueTargetProvider(array26, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val87);
			object obj13 = (object)val147;
			val146.Add(typeFromHandle25, (object)val147);
			val146.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val148 = new XmlNamespaceResolver();
			val148.Add("", "http://xamarin.com/schemas/2014/forms");
			val148.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val148.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val146.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val148, typeof(DesignSystem).GetTypeInfo().Assembly));
			val146.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(53, 38)));
			DynamicResource value10 = ((IMarkupExtension<DynamicResource>)(object)val35).ProvideValue((IServiceProvider)val146);
			val36.set_Value((object)value10);
			val38.get_Setters().Add(val36);
			val37.set_Property(Label.FontSizeProperty);
			val37.set_Value((object)"Small");
			FontSizeConverter val149 = new FontSizeConverter();
			XamlServiceProvider val150 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array27;
			int num14;
			object[] array28 = (array27 = new object[(num14 = 0) + 3]);
			array28[0] = val37;
			array28[1] = val38;
			array28[2] = this;
			SimpleValueTargetProvider val151 = new SimpleValueTargetProvider(array28, (object)Label.FontSizeProperty, (INameScope)(object)val88);
			object obj14 = (object)val151;
			val150.Add(typeFromHandle27, (object)val151);
			val150.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val152 = new XmlNamespaceResolver();
			val152.Add("", "http://xamarin.com/schemas/2014/forms");
			val152.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val152.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val150.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val152, typeof(DesignSystem).GetTypeInfo().Assembly));
			val150.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 37)));
			val37.set_Value(((IExtendedTypeConverter)val149).ConvertFromInvariantString("Small", (IServiceProvider)val150));
			val38.get_Setters().Add(val37);
			((ResourceDictionary)this).Add("Small", (object)val38);
			val40.set_Property(Label.TextColorProperty);
			val39.set_Key("PrimaryTextColor");
			XamlServiceProvider val153 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array29;
			int num15;
			object[] array30 = (array29 = new object[(num15 = 0) + 3]);
			array30[0] = val40;
			array30[1] = val42;
			array30[2] = this;
			SimpleValueTargetProvider val154 = new SimpleValueTargetProvider(array30, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val89);
			object obj15 = (object)val154;
			val153.Add(typeFromHandle29, (object)val154);
			val153.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val155 = new XmlNamespaceResolver();
			val155.Add("", "http://xamarin.com/schemas/2014/forms");
			val155.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val155.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val153.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val155, typeof(DesignSystem).GetTypeInfo().Assembly));
			val153.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 38)));
			DynamicResource value11 = ((IMarkupExtension<DynamicResource>)(object)val39).ProvideValue((IServiceProvider)val153);
			val40.set_Value((object)value11);
			val42.get_Setters().Add(val40);
			val41.set_Property(Label.FontSizeProperty);
			val41.set_Value((object)"Caption");
			FontSizeConverter val156 = new FontSizeConverter();
			XamlServiceProvider val157 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array31;
			int num16;
			object[] array32 = (array31 = new object[(num16 = 0) + 3]);
			array32[0] = val41;
			array32[1] = val42;
			array32[2] = this;
			SimpleValueTargetProvider val158 = new SimpleValueTargetProvider(array32, (object)Label.FontSizeProperty, (INameScope)(object)val90);
			object obj16 = (object)val158;
			val157.Add(typeFromHandle31, (object)val158);
			val157.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val159 = new XmlNamespaceResolver();
			val159.Add("", "http://xamarin.com/schemas/2014/forms");
			val159.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val159.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val157.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val159, typeof(DesignSystem).GetTypeInfo().Assembly));
			val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 37)));
			val41.set_Value(((IExtendedTypeConverter)val156).ConvertFromInvariantString("Caption", (IServiceProvider)val157));
			val42.get_Setters().Add(val41);
			((ResourceDictionary)this).Add("Micro", (object)val42);
			val44.set_Property(Label.TextColorProperty);
			val43.set_Key("PrimaryTextColor");
			XamlServiceProvider val160 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array33;
			int num17;
			object[] array34 = (array33 = new object[(num17 = 0) + 3]);
			array34[0] = val44;
			array34[1] = val47;
			array34[2] = this;
			SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array34, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val91);
			object obj17 = (object)val161;
			val160.Add(typeFromHandle33, (object)val161);
			val160.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val162 = new XmlNamespaceResolver();
			val162.Add("", "http://xamarin.com/schemas/2014/forms");
			val162.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val162.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val160.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val162, typeof(DesignSystem).GetTypeInfo().Assembly));
			val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 38)));
			DynamicResource value12 = ((IMarkupExtension<DynamicResource>)(object)val43).ProvideValue((IServiceProvider)val160);
			val44.set_Value((object)value12);
			val47.get_Setters().Add(val44);
			val45.set_Property(Label.FontSizeProperty);
			val45.set_Value((object)"15");
			FontSizeConverter val163 = new FontSizeConverter();
			XamlServiceProvider val164 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array35;
			int num18;
			object[] array36 = (array35 = new object[(num18 = 0) + 3]);
			array36[0] = val45;
			array36[1] = val47;
			array36[2] = this;
			SimpleValueTargetProvider val165 = new SimpleValueTargetProvider(array36, (object)Label.FontSizeProperty, (INameScope)(object)val92);
			object obj18 = (object)val165;
			val164.Add(typeFromHandle35, (object)val165);
			val164.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val166 = new XmlNamespaceResolver();
			val166.Add("", "http://xamarin.com/schemas/2014/forms");
			val166.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val166.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val164.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val166, typeof(DesignSystem).GetTypeInfo().Assembly));
			val164.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 37)));
			val45.set_Value(((IExtendedTypeConverter)val163).ConvertFromInvariantString("15", (IServiceProvider)val164));
			val47.get_Setters().Add(val45);
			val46.set_Property(VisualElement.OpacityProperty);
			val46.set_Value((object)"0.6");
			val46.set_Value((object)0.6);
			val47.get_Setters().Add(val46);
			((ResourceDictionary)this).Add("Caption", (object)val47);
			val48.set_Property(Frame.HasShadowProperty);
			val48.set_Value((object)"False");
			val48.set_Value((object)false);
			val51.get_Setters().Add(val48);
			val50.set_Property(VisualElement.BackgroundColorProperty);
			val49.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val167 = new XamlServiceProvider();
			Type typeFromHandle37 = typeof(IProvideValueTarget);
			object[] array37;
			int num19;
			object[] array38 = (array37 = new object[(num19 = 0) + 3]);
			array38[0] = val50;
			array38[1] = val51;
			array38[2] = this;
			SimpleValueTargetProvider val168 = new SimpleValueTargetProvider(array38, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val95);
			object obj19 = (object)val168;
			val167.Add(typeFromHandle37, (object)val168);
			val167.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle38 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val169 = new XmlNamespaceResolver();
			val169.Add("", "http://xamarin.com/schemas/2014/forms");
			val169.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val169.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val167.Add(typeFromHandle38, (object)new XamlTypeResolver((IXmlNamespaceResolver)val169, typeof(DesignSystem).GetTypeInfo().Assembly));
			val167.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(70, 44)));
			DynamicResource value13 = ((IMarkupExtension<DynamicResource>)(object)val49).ProvideValue((IServiceProvider)val167);
			val50.set_Value((object)value13);
			val51.get_Setters().Add(val50);
			((ResourceDictionary)this).Add("ResourceLink", (object)val51);
			val53.set_Property(Frame.BorderColorProperty);
			val52.set_Key("PrimaryColor");
			XamlServiceProvider val170 = new XamlServiceProvider();
			Type typeFromHandle39 = typeof(IProvideValueTarget);
			object[] array39;
			int num20;
			object[] array40 = (array39 = new object[(num20 = 0) + 3]);
			array40[0] = val53;
			array40[1] = val54;
			array40[2] = this;
			SimpleValueTargetProvider val171 = new SimpleValueTargetProvider(array40, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val96);
			object obj20 = (object)val171;
			val170.Add(typeFromHandle39, (object)val171);
			val170.Add(typeof(IReferenceProvider), obj20);
			Type typeFromHandle40 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val172 = new XmlNamespaceResolver();
			val172.Add("", "http://xamarin.com/schemas/2014/forms");
			val172.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val172.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val170.Add(typeFromHandle40, (object)new XamlTypeResolver((IXmlNamespaceResolver)val172, typeof(DesignSystem).GetTypeInfo().Assembly));
			val170.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 40)));
			DynamicResource value14 = ((IMarkupExtension<DynamicResource>)(object)val52).ProvideValue((IServiceProvider)val170);
			val53.set_Value((object)value14);
			val54.get_Setters().Add(val53);
			((ResourceDictionary)this).Add("EntryBorder", (object)val54);
			val56.set_Property(Label.TextColorProperty);
			val55.set_Key("TertiaryColor");
			XamlServiceProvider val173 = new XamlServiceProvider();
			Type typeFromHandle41 = typeof(IProvideValueTarget);
			object[] array41;
			int num21;
			object[] array42 = (array41 = new object[(num21 = 0) + 3]);
			array42[0] = val56;
			array42[1] = val59;
			array42[2] = this;
			SimpleValueTargetProvider val174 = new SimpleValueTargetProvider(array42, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val97);
			object obj21 = (object)val174;
			val173.Add(typeFromHandle41, (object)val174);
			val173.Add(typeof(IReferenceProvider), obj21);
			Type typeFromHandle42 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val175 = new XmlNamespaceResolver();
			val175.Add("", "http://xamarin.com/schemas/2014/forms");
			val175.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val175.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val173.Add(typeFromHandle42, (object)new XamlTypeResolver((IXmlNamespaceResolver)val175, typeof(DesignSystem).GetTypeInfo().Assembly));
			val173.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(78, 38)));
			DynamicResource value15 = ((IMarkupExtension<DynamicResource>)(object)val55).ProvideValue((IServiceProvider)val173);
			val56.set_Value((object)value15);
			val59.get_Setters().Add(val56);
			val57.set_Property(Label.TextDecorationsProperty);
			val57.set_Value((object)"Underline");
			val57.set_Value(new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val59.get_Setters().Add(val57);
			val58.set_Property(Label.FontAttributesProperty);
			val58.set_Value((object)"Bold");
			val58.set_Value(new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val59.get_Setters().Add(val58);
			((ResourceDictionary)this).Add("Link", (object)val59);
			val61.set_Property(Label.TextColorProperty);
			val60.set_Key("Red");
			XamlServiceProvider val176 = new XamlServiceProvider();
			Type typeFromHandle43 = typeof(IProvideValueTarget);
			object[] array43;
			int num22;
			object[] array44 = (array43 = new object[(num22 = 0) + 3]);
			array44[0] = val61;
			array44[1] = val62;
			array44[2] = this;
			SimpleValueTargetProvider val177 = new SimpleValueTargetProvider(array44, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val100);
			object obj22 = (object)val177;
			val176.Add(typeFromHandle43, (object)val177);
			val176.Add(typeof(IReferenceProvider), obj22);
			Type typeFromHandle44 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val178 = new XmlNamespaceResolver();
			val178.Add("", "http://xamarin.com/schemas/2014/forms");
			val178.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val178.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val176.Add(typeFromHandle44, (object)new XamlTypeResolver((IXmlNamespaceResolver)val178, typeof(DesignSystem).GetTypeInfo().Assembly));
			val176.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(84, 38)));
			DynamicResource value16 = ((IMarkupExtension<DynamicResource>)(object)val60).ProvideValue((IServiceProvider)val176);
			val61.set_Value((object)value16);
			val62.get_Setters().Add(val61);
			((ResourceDictionary)this).Add("ErrorTextStyle", (object)val62);
			val64.set_Property(VisualElement.BackgroundColorProperty);
			val63.set_Key("Blue");
			XamlServiceProvider val179 = new XamlServiceProvider();
			Type typeFromHandle45 = typeof(IProvideValueTarget);
			object[] array45;
			int num23;
			object[] array46 = (array45 = new object[(num23 = 0) + 3]);
			array46[0] = val64;
			array46[1] = val70;
			array46[2] = this;
			SimpleValueTargetProvider val180 = new SimpleValueTargetProvider(array46, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val101);
			object obj23 = (object)val180;
			val179.Add(typeFromHandle45, (object)val180);
			val179.Add(typeof(IReferenceProvider), obj23);
			Type typeFromHandle46 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val181 = new XmlNamespaceResolver();
			val181.Add("", "http://xamarin.com/schemas/2014/forms");
			val181.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val181.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val179.Add(typeFromHandle46, (object)new XamlTypeResolver((IXmlNamespaceResolver)val181, typeof(DesignSystem).GetTypeInfo().Assembly));
			val179.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(88, 44)));
			DynamicResource value17 = ((IMarkupExtension<DynamicResource>)(object)val63).ProvideValue((IServiceProvider)val179);
			val64.set_Value((object)value17);
			val70.get_Setters().Add(val64);
			val65.set_Property(Button.TextColorProperty);
			val65.set_Value((object)"White");
			val65.set_Value((object)Color.White);
			val70.get_Setters().Add(val65);
			val66.set_Property(View.MarginProperty);
			val66.set_Value((object)"0,0,0,16");
			val66.set_Value((object)new Thickness(0.0, 0.0, 0.0, 16.0));
			val70.get_Setters().Add(val66);
			val67.set_Property(Button.PaddingProperty);
			val67.set_Value((object)"32,16");
			val67.set_Value((object)new Thickness(32.0, 16.0));
			val70.get_Setters().Add(val67);
			val68.set_Property(Button.FontSizeProperty);
			val68.set_Value((object)"Body");
			FontSizeConverter val182 = new FontSizeConverter();
			XamlServiceProvider val183 = new XamlServiceProvider();
			Type typeFromHandle47 = typeof(IProvideValueTarget);
			object[] array47;
			int num24;
			object[] array48 = (array47 = new object[(num24 = 0) + 3]);
			array48[0] = val68;
			array48[1] = val70;
			array48[2] = this;
			SimpleValueTargetProvider val184 = new SimpleValueTargetProvider(array48, (object)Button.FontSizeProperty, (INameScope)(object)val105);
			object obj24 = (object)val184;
			val183.Add(typeFromHandle47, (object)val184);
			val183.Add(typeof(IReferenceProvider), obj24);
			Type typeFromHandle48 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val185 = new XmlNamespaceResolver();
			val185.Add("", "http://xamarin.com/schemas/2014/forms");
			val185.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val185.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val183.Add(typeFromHandle48, (object)new XamlTypeResolver((IXmlNamespaceResolver)val185, typeof(DesignSystem).GetTypeInfo().Assembly));
			val183.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(92, 37)));
			val68.set_Value(((IExtendedTypeConverter)val182).ConvertFromInvariantString("Body", (IServiceProvider)val183));
			val70.get_Setters().Add(val68);
			val69.set_Property(Button.FontAttributesProperty);
			val69.set_Value((object)"Bold");
			val69.set_Value(new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val70.get_Setters().Add(val69);
			((ResourceDictionary)this).Add("LargeButtonStyle", (object)val70);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<DesignSystem>(this, typeof(DesignSystem));
		}
	}
}
