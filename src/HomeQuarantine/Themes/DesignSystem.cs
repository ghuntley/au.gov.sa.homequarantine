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
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected O, but got Unknown
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
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected O, but got Unknown
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected O, but got Unknown
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected O, but got Unknown
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected O, but got Unknown
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected O, but got Unknown
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Expected O, but got Unknown
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected O, but got Unknown
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected O, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected O, but got Unknown
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected O, but got Unknown
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected O, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected O, but got Unknown
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected O, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected O, but got Unknown
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected O, but got Unknown
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Expected O, but got Unknown
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected O, but got Unknown
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected O, but got Unknown
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Expected O, but got Unknown
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Expected O, but got Unknown
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected O, but got Unknown
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Expected O, but got Unknown
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Expected O, but got Unknown
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected O, but got Unknown
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0313: Expected O, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Expected O, but got Unknown
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Expected O, but got Unknown
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected O, but got Unknown
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Expected O, but got Unknown
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected O, but got Unknown
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Expected O, but got Unknown
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Expected O, but got Unknown
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Expected O, but got Unknown
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Expected O, but got Unknown
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Expected O, but got Unknown
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Expected O, but got Unknown
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Expected O, but got Unknown
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Expected O, but got Unknown
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected O, but got Unknown
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected O, but got Unknown
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected O, but got Unknown
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_0398: Expected O, but got Unknown
			//IL_0398: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Expected O, but got Unknown
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Expected O, but got Unknown
			//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Expected O, but got Unknown
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected O, but got Unknown
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Expected O, but got Unknown
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected O, but got Unknown
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Expected O, but got Unknown
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Expected O, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d7: Expected O, but got Unknown
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Expected O, but got Unknown
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected O, but got Unknown
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Expected O, but got Unknown
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected O, but got Unknown
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0450: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected O, but got Unknown
			//IL_0458: Expected O, but got Unknown
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected O, but got Unknown
			//IL_04be: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c8: Expected O, but got Unknown
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Expected O, but got Unknown
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Expected O, but got Unknown
			//IL_04eb: Expected O, but got Unknown
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Expected O, but got Unknown
			//IL_0561: Expected O, but got Unknown
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0573: Unknown result type (might be due to invalid IL or missing references)
			//IL_057e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0593: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cc: Expected O, but got Unknown
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Expected O, but got Unknown
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected O, but got Unknown
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Expected O, but got Unknown
			//IL_05f4: Expected O, but got Unknown
			//IL_065e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0663: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a9: Expected O, but got Unknown
			//IL_06ae: Expected O, but got Unknown
			//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0719: Expected O, but got Unknown
			//IL_0714: Unknown result type (might be due to invalid IL or missing references)
			//IL_071e: Expected O, but got Unknown
			//IL_071e: Unknown result type (might be due to invalid IL or missing references)
			//IL_072d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0737: Expected O, but got Unknown
			//IL_0732: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Expected O, but got Unknown
			//IL_0741: Expected O, but got Unknown
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0782: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Expected O, but got Unknown
			//IL_07cd: Expected O, but got Unknown
			//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07df: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_080f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0838: Expected O, but got Unknown
			//IL_0833: Unknown result type (might be due to invalid IL or missing references)
			//IL_083d: Expected O, but got Unknown
			//IL_083d: Unknown result type (might be due to invalid IL or missing references)
			//IL_084c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0856: Expected O, but got Unknown
			//IL_0851: Unknown result type (might be due to invalid IL or missing references)
			//IL_085b: Expected O, but got Unknown
			//IL_0860: Expected O, but got Unknown
			//IL_089c: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e7: Expected O, but got Unknown
			//IL_08ec: Expected O, but got Unknown
			//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0909: Unknown result type (might be due to invalid IL or missing references)
			//IL_090e: Unknown result type (might be due to invalid IL or missing references)
			//IL_091e: Unknown result type (might be due to invalid IL or missing references)
			//IL_092e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0957: Expected O, but got Unknown
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Expected O, but got Unknown
			//IL_095c: Unknown result type (might be due to invalid IL or missing references)
			//IL_096b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0975: Expected O, but got Unknown
			//IL_0970: Unknown result type (might be due to invalid IL or missing references)
			//IL_097a: Expected O, but got Unknown
			//IL_097f: Expected O, but got Unknown
			//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a06: Expected O, but got Unknown
			//IL_0a0b: Expected O, but got Unknown
			//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a76: Expected O, but got Unknown
			//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7b: Expected O, but got Unknown
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a94: Expected O, but got Unknown
			//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a99: Expected O, but got Unknown
			//IL_0a9e: Expected O, but got Unknown
			//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1c: Expected O, but got Unknown
			//IL_0b21: Expected O, but got Unknown
			//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8c: Expected O, but got Unknown
			//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b91: Expected O, but got Unknown
			//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Expected O, but got Unknown
			//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baf: Expected O, but got Unknown
			//IL_0bb4: Expected O, but got Unknown
			//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3b: Expected O, but got Unknown
			//IL_0c40: Expected O, but got Unknown
			//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cab: Expected O, but got Unknown
			//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb0: Expected O, but got Unknown
			//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc9: Expected O, but got Unknown
			//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cce: Expected O, but got Unknown
			//IL_0cd3: Expected O, but got Unknown
			//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5a: Expected O, but got Unknown
			//IL_0d5f: Expected O, but got Unknown
			//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dca: Expected O, but got Unknown
			//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dcf: Expected O, but got Unknown
			//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de8: Expected O, but got Unknown
			//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ded: Expected O, but got Unknown
			//IL_0df2: Expected O, but got Unknown
			//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6b: Expected O, but got Unknown
			//IL_0e70: Expected O, but got Unknown
			//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0edb: Expected O, but got Unknown
			//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee0: Expected O, but got Unknown
			//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef9: Expected O, but got Unknown
			//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efe: Expected O, but got Unknown
			//IL_0f03: Expected O, but got Unknown
			//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc5: Expected O, but got Unknown
			//IL_0fca: Expected O, but got Unknown
			//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_100c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1035: Expected O, but got Unknown
			//IL_1030: Unknown result type (might be due to invalid IL or missing references)
			//IL_103a: Expected O, but got Unknown
			//IL_103a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1049: Unknown result type (might be due to invalid IL or missing references)
			//IL_1053: Expected O, but got Unknown
			//IL_104e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1058: Expected O, but got Unknown
			//IL_105d: Expected O, but got Unknown
			//IL_1090: Unknown result type (might be due to invalid IL or missing references)
			//IL_109a: Unknown result type (might be due to invalid IL or missing references)
			//IL_109f: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d6: Expected O, but got Unknown
			//IL_10db: Expected O, but got Unknown
			//IL_10db: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_110d: Unknown result type (might be due to invalid IL or missing references)
			//IL_111d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1146: Expected O, but got Unknown
			//IL_1141: Unknown result type (might be due to invalid IL or missing references)
			//IL_114b: Expected O, but got Unknown
			//IL_114b: Unknown result type (might be due to invalid IL or missing references)
			//IL_115a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1164: Expected O, but got Unknown
			//IL_115f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1169: Expected O, but got Unknown
			//IL_116e: Expected O, but got Unknown
			//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f4: Expected O, but got Unknown
			//IL_11f9: Expected O, but got Unknown
			//IL_11f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_120b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1216: Unknown result type (might be due to invalid IL or missing references)
			//IL_121b: Unknown result type (might be due to invalid IL or missing references)
			//IL_122b: Unknown result type (might be due to invalid IL or missing references)
			//IL_123b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1264: Expected O, but got Unknown
			//IL_125f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1269: Expected O, but got Unknown
			//IL_1269: Unknown result type (might be due to invalid IL or missing references)
			//IL_1278: Unknown result type (might be due to invalid IL or missing references)
			//IL_1282: Expected O, but got Unknown
			//IL_127d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1287: Expected O, but got Unknown
			//IL_128c: Expected O, but got Unknown
			//IL_12bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1302: Unknown result type (might be due to invalid IL or missing references)
			//IL_1305: Expected O, but got Unknown
			//IL_130a: Expected O, but got Unknown
			//IL_130a: Unknown result type (might be due to invalid IL or missing references)
			//IL_131c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1327: Unknown result type (might be due to invalid IL or missing references)
			//IL_132c: Unknown result type (might be due to invalid IL or missing references)
			//IL_133c: Unknown result type (might be due to invalid IL or missing references)
			//IL_134c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1375: Expected O, but got Unknown
			//IL_1370: Unknown result type (might be due to invalid IL or missing references)
			//IL_137a: Expected O, but got Unknown
			//IL_137a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1389: Unknown result type (might be due to invalid IL or missing references)
			//IL_1393: Expected O, but got Unknown
			//IL_138e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1398: Expected O, but got Unknown
			//IL_139d: Expected O, but got Unknown
			//IL_13d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_141b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1420: Unknown result type (might be due to invalid IL or missing references)
			//IL_1423: Expected O, but got Unknown
			//IL_1428: Expected O, but got Unknown
			//IL_1428: Unknown result type (might be due to invalid IL or missing references)
			//IL_143a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1445: Unknown result type (might be due to invalid IL or missing references)
			//IL_144a: Unknown result type (might be due to invalid IL or missing references)
			//IL_145a: Unknown result type (might be due to invalid IL or missing references)
			//IL_146a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1493: Expected O, but got Unknown
			//IL_148e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1498: Expected O, but got Unknown
			//IL_1498: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b1: Expected O, but got Unknown
			//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b6: Expected O, but got Unknown
			//IL_14bb: Expected O, but got Unknown
			//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_152c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1531: Unknown result type (might be due to invalid IL or missing references)
			//IL_1534: Expected O, but got Unknown
			//IL_1539: Expected O, but got Unknown
			//IL_1539: Unknown result type (might be due to invalid IL or missing references)
			//IL_154b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1556: Unknown result type (might be due to invalid IL or missing references)
			//IL_155b: Unknown result type (might be due to invalid IL or missing references)
			//IL_156b: Unknown result type (might be due to invalid IL or missing references)
			//IL_157b: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a4: Expected O, but got Unknown
			//IL_159f: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a9: Expected O, but got Unknown
			//IL_15a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_15b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c2: Expected O, but got Unknown
			//IL_15bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c7: Expected O, but got Unknown
			//IL_15cc: Expected O, but got Unknown
			//IL_1607: Unknown result type (might be due to invalid IL or missing references)
			//IL_160c: Unknown result type (might be due to invalid IL or missing references)
			//IL_164a: Unknown result type (might be due to invalid IL or missing references)
			//IL_164f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1652: Expected O, but got Unknown
			//IL_1657: Expected O, but got Unknown
			//IL_1657: Unknown result type (might be due to invalid IL or missing references)
			//IL_1669: Unknown result type (might be due to invalid IL or missing references)
			//IL_1674: Unknown result type (might be due to invalid IL or missing references)
			//IL_1679: Unknown result type (might be due to invalid IL or missing references)
			//IL_1689: Unknown result type (might be due to invalid IL or missing references)
			//IL_1699: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c2: Expected O, but got Unknown
			//IL_16bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c7: Expected O, but got Unknown
			//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_16e0: Expected O, but got Unknown
			//IL_16db: Unknown result type (might be due to invalid IL or missing references)
			//IL_16e5: Expected O, but got Unknown
			//IL_16ea: Expected O, but got Unknown
			//IL_171d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1727: Unknown result type (might be due to invalid IL or missing references)
			//IL_172c: Unknown result type (might be due to invalid IL or missing references)
			//IL_175b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1760: Unknown result type (might be due to invalid IL or missing references)
			//IL_1763: Expected O, but got Unknown
			//IL_1768: Expected O, but got Unknown
			//IL_1768: Unknown result type (might be due to invalid IL or missing references)
			//IL_177a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1785: Unknown result type (might be due to invalid IL or missing references)
			//IL_178a: Unknown result type (might be due to invalid IL or missing references)
			//IL_179a: Unknown result type (might be due to invalid IL or missing references)
			//IL_17aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d3: Expected O, but got Unknown
			//IL_17ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d8: Expected O, but got Unknown
			//IL_17d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f1: Expected O, but got Unknown
			//IL_17ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f6: Expected O, but got Unknown
			//IL_17fb: Expected O, but got Unknown
			//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ef: Expected O, but got Unknown
			//IL_18f4: Expected O, but got Unknown
			//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1906: Unknown result type (might be due to invalid IL or missing references)
			//IL_1911: Unknown result type (might be due to invalid IL or missing references)
			//IL_1916: Unknown result type (might be due to invalid IL or missing references)
			//IL_1926: Unknown result type (might be due to invalid IL or missing references)
			//IL_1936: Unknown result type (might be due to invalid IL or missing references)
			//IL_195f: Expected O, but got Unknown
			//IL_195a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1964: Expected O, but got Unknown
			//IL_1964: Unknown result type (might be due to invalid IL or missing references)
			//IL_1973: Unknown result type (might be due to invalid IL or missing references)
			//IL_197d: Expected O, but got Unknown
			//IL_1978: Unknown result type (might be due to invalid IL or missing references)
			//IL_1982: Expected O, but got Unknown
			//IL_1987: Expected O, but got Unknown
			//IL_19c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_19cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a13: Expected O, but got Unknown
			//IL_1a18: Expected O, but got Unknown
			//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a35: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a83: Expected O, but got Unknown
			//IL_1a7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a88: Expected O, but got Unknown
			//IL_1a88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a97: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa1: Expected O, but got Unknown
			//IL_1a9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa6: Expected O, but got Unknown
			//IL_1aab: Expected O, but got Unknown
			//IL_1aec: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b37: Expected O, but got Unknown
			//IL_1b3c: Expected O, but got Unknown
			//IL_1b3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba7: Expected O, but got Unknown
			//IL_1ba2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bac: Expected O, but got Unknown
			//IL_1bac: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc5: Expected O, but got Unknown
			//IL_1bc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bca: Expected O, but got Unknown
			//IL_1bcf: Expected O, but got Unknown
			//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ccb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd3: Expected O, but got Unknown
			//IL_1cd8: Expected O, but got Unknown
			//IL_1cd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d43: Expected O, but got Unknown
			//IL_1d3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d48: Expected O, but got Unknown
			//IL_1d48: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d57: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d61: Expected O, but got Unknown
			//IL_1d5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d66: Expected O, but got Unknown
			//IL_1d6b: Expected O, but got Unknown
			//IL_1dac: Unknown result type (might be due to invalid IL or missing references)
			//IL_1db1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1def: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df7: Expected O, but got Unknown
			//IL_1dfc: Expected O, but got Unknown
			//IL_1dfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e19: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e67: Expected O, but got Unknown
			//IL_1e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e6c: Expected O, but got Unknown
			//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e85: Expected O, but got Unknown
			//IL_1e80: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e8a: Expected O, but got Unknown
			//IL_1e8f: Expected O, but got Unknown
			//IL_1ec2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f66: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_200c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2011: Unknown result type (might be due to invalid IL or missing references)
			//IL_204f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2054: Unknown result type (might be due to invalid IL or missing references)
			//IL_2057: Expected O, but got Unknown
			//IL_205c: Expected O, but got Unknown
			//IL_205c: Unknown result type (might be due to invalid IL or missing references)
			//IL_206e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2079: Unknown result type (might be due to invalid IL or missing references)
			//IL_207e: Unknown result type (might be due to invalid IL or missing references)
			//IL_208e: Unknown result type (might be due to invalid IL or missing references)
			//IL_209e: Unknown result type (might be due to invalid IL or missing references)
			//IL_20c7: Expected O, but got Unknown
			//IL_20c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_20cc: Expected O, but got Unknown
			//IL_20cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_20db: Unknown result type (might be due to invalid IL or missing references)
			//IL_20e5: Expected O, but got Unknown
			//IL_20e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ea: Expected O, but got Unknown
			//IL_20ef: Expected O, but got Unknown
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
			DynamicResourceExtension val10 = new DynamicResourceExtension();
			Setter val11 = new Setter();
			Style val12 = new Style(typeof(ShadowFrame));
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			Setter val14 = new Setter();
			Style val15 = new Style(typeof(CheckBox));
			DynamicResourceExtension val16 = new DynamicResourceExtension();
			Setter val17 = new Setter();
			DynamicResourceExtension val18 = new DynamicResourceExtension();
			Setter val19 = new Setter();
			Style val20 = new Style(typeof(Entry));
			DynamicResourceExtension val21 = new DynamicResourceExtension();
			Setter val22 = new Setter();
			Style val23 = new Style(typeof(ActivityIndicator));
			DynamicResourceExtension val24 = new DynamicResourceExtension();
			Setter val25 = new Setter();
			Setter val26 = new Setter();
			Setter val27 = new Setter();
			Style val28 = new Style(typeof(Label));
			DynamicResourceExtension val29 = new DynamicResourceExtension();
			Setter val30 = new Setter();
			Setter val31 = new Setter();
			Style val32 = new Style(typeof(Label));
			DynamicResourceExtension val33 = new DynamicResourceExtension();
			Setter val34 = new Setter();
			Setter val35 = new Setter();
			Style val36 = new Style(typeof(Label));
			DynamicResourceExtension val37 = new DynamicResourceExtension();
			Setter val38 = new Setter();
			Setter val39 = new Setter();
			Style val40 = new Style(typeof(Label));
			DynamicResourceExtension val41 = new DynamicResourceExtension();
			Setter val42 = new Setter();
			Setter val43 = new Setter();
			Setter val44 = new Setter();
			Style val45 = new Style(typeof(Label));
			Setter val46 = new Setter();
			DynamicResourceExtension val47 = new DynamicResourceExtension();
			Setter val48 = new Setter();
			Style val49 = new Style(typeof(Frame));
			DynamicResourceExtension val50 = new DynamicResourceExtension();
			Setter val51 = new Setter();
			Style val52 = new Style(typeof(ShadowFrame));
			DynamicResourceExtension val53 = new DynamicResourceExtension();
			Setter val54 = new Setter();
			Setter val55 = new Setter();
			Setter val56 = new Setter();
			Style val57 = new Style(typeof(Label));
			DynamicResourceExtension val58 = new DynamicResourceExtension();
			Setter val59 = new Setter();
			Style val60 = new Style(typeof(Label));
			DynamicResourceExtension val61 = new DynamicResourceExtension();
			Setter val62 = new Setter();
			Setter val63 = new Setter();
			Setter val64 = new Setter();
			Setter val65 = new Setter();
			Setter val66 = new Setter();
			OnPlatform<int> val67 = new OnPlatform<int>();
			Setter val68 = new Setter();
			DynamicResourceExtension val69 = new DynamicResourceExtension();
			Setter val70 = new Setter();
			Style val71 = new Style(typeof(Button));
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
			NameScope val107 = new NameScope();
			val3.set_Property(Label.TextColorProperty);
			val2.set_Key("PrimaryTextColor");
			XamlServiceProvider val108 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array;
			int num;
			object[] array2 = (array = new object[(num = 0) + 3]);
			array2[0] = val3;
			array2[1] = val5;
			array2[2] = this;
			SimpleValueTargetProvider val109 = new SimpleValueTargetProvider(array2, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val73);
			object obj = (object)val109;
			val108.Add(typeFromHandle, (object)val109);
			val108.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val110 = new XmlNamespaceResolver();
			val110.Add("", "http://xamarin.com/schemas/2014/forms");
			val110.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val110.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val108.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val110, typeof(DesignSystem).GetTypeInfo().Assembly));
			val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(10, 38)));
			DynamicResource value = ((IMarkupExtension<DynamicResource>)(object)val2).ProvideValue((IServiceProvider)val108);
			val3.set_Value((object)value);
			val5.get_Setters().Add(val3);
			val4.set_Property(Label.FontSizeProperty);
			val4.set_Value((object)"Body");
			FontSizeConverter val111 = new FontSizeConverter();
			XamlServiceProvider val112 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array3;
			int num2;
			object[] array4 = (array3 = new object[(num2 = 0) + 3]);
			array4[0] = val4;
			array4[1] = val5;
			array4[2] = this;
			SimpleValueTargetProvider val113 = new SimpleValueTargetProvider(array4, (object)Label.FontSizeProperty, (INameScope)(object)val74);
			object obj2 = (object)val113;
			val112.Add(typeFromHandle3, (object)val113);
			val112.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val114 = new XmlNamespaceResolver();
			val114.Add("", "http://xamarin.com/schemas/2014/forms");
			val114.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val114.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val112.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val114, typeof(DesignSystem).GetTypeInfo().Assembly));
			val112.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 37)));
			val4.set_Value(((IExtendedTypeConverter)val111).ConvertFromInvariantString("Body", (IServiceProvider)val112));
			val5.get_Setters().Add(val4);
			((ResourceDictionary)this).Add(val5);
			val6.set_Property(Frame.CornerRadiusProperty);
			val6.set_Value((object)"7");
			val6.set_Value((object)7f);
			val9.get_Setters().Add(val6);
			val8.set_Property(VisualElement.BackgroundColorProperty);
			val7.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val115 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array5;
			int num3;
			object[] array6 = (array5 = new object[(num3 = 0) + 3]);
			array6[0] = val8;
			array6[1] = val9;
			array6[2] = this;
			SimpleValueTargetProvider val116 = new SimpleValueTargetProvider(array6, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val76);
			object obj3 = (object)val116;
			val115.Add(typeFromHandle5, (object)val116);
			val115.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val117 = new XmlNamespaceResolver();
			val117.Add("", "http://xamarin.com/schemas/2014/forms");
			val117.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val117.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val115.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val117, typeof(DesignSystem).GetTypeInfo().Assembly));
			val115.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(16, 44)));
			DynamicResource value2 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val115);
			val8.set_Value((object)value2);
			val9.get_Setters().Add(val8);
			((ResourceDictionary)this).Add(val9);
			val11.set_Property(VisualElement.BackgroundColorProperty);
			val10.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val118 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array7;
			int num4;
			object[] array8 = (array7 = new object[(num4 = 0) + 3]);
			array8[0] = val11;
			array8[1] = val12;
			array8[2] = this;
			SimpleValueTargetProvider val119 = new SimpleValueTargetProvider(array8, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val77);
			object obj4 = (object)val119;
			val118.Add(typeFromHandle7, (object)val119);
			val118.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val120 = new XmlNamespaceResolver();
			val120.Add("", "http://xamarin.com/schemas/2014/forms");
			val120.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val120.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val118.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val120, typeof(DesignSystem).GetTypeInfo().Assembly));
			val118.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 44)));
			DynamicResource value3 = ((IMarkupExtension<DynamicResource>)(object)val10).ProvideValue((IServiceProvider)val118);
			val11.set_Value((object)value3);
			val12.get_Setters().Add(val11);
			((ResourceDictionary)this).Add(val12);
			val14.set_Property(CheckBox.ColorProperty);
			val13.set_Key("PrimaryTextColor");
			XamlServiceProvider val121 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array9;
			int num5;
			object[] array10 = (array9 = new object[(num5 = 0) + 3]);
			array10[0] = val14;
			array10[1] = val15;
			array10[2] = this;
			SimpleValueTargetProvider val122 = new SimpleValueTargetProvider(array10, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val78);
			object obj5 = (object)val122;
			val121.Add(typeFromHandle9, (object)val122);
			val121.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val123 = new XmlNamespaceResolver();
			val123.Add("", "http://xamarin.com/schemas/2014/forms");
			val123.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val123.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val121.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val123, typeof(DesignSystem).GetTypeInfo().Assembly));
			val121.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 34)));
			DynamicResource value4 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val121);
			val14.set_Value((object)value4);
			val15.get_Setters().Add(val14);
			((ResourceDictionary)this).Add(val15);
			val17.set_Property(Entry.TextColorProperty);
			val16.set_Key("PrimaryTextColor");
			XamlServiceProvider val124 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array11;
			int num6;
			object[] array12 = (array11 = new object[(num6 = 0) + 3]);
			array12[0] = val17;
			array12[1] = val20;
			array12[2] = this;
			SimpleValueTargetProvider val125 = new SimpleValueTargetProvider(array12, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val79);
			object obj6 = (object)val125;
			val124.Add(typeFromHandle11, (object)val125);
			val124.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val126 = new XmlNamespaceResolver();
			val126.Add("", "http://xamarin.com/schemas/2014/forms");
			val126.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val126.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val124.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val126, typeof(DesignSystem).GetTypeInfo().Assembly));
			val124.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 35)));
			DynamicResource value5 = ((IMarkupExtension<DynamicResource>)(object)val16).ProvideValue((IServiceProvider)val124);
			val17.set_Value((object)value5);
			val20.get_Setters().Add(val17);
			val19.set_Property(VisualElement.BackgroundColorProperty);
			val18.set_Key("BackgroundColor");
			XamlServiceProvider val127 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array13;
			int num7;
			object[] array14 = (array13 = new object[(num7 = 0) + 3]);
			array14[0] = val19;
			array14[1] = val20;
			array14[2] = this;
			SimpleValueTargetProvider val128 = new SimpleValueTargetProvider(array14, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val80);
			object obj7 = (object)val128;
			val127.Add(typeFromHandle13, (object)val128);
			val127.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val129 = new XmlNamespaceResolver();
			val129.Add("", "http://xamarin.com/schemas/2014/forms");
			val129.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val129.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val127.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val129, typeof(DesignSystem).GetTypeInfo().Assembly));
			val127.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 44)));
			DynamicResource value6 = ((IMarkupExtension<DynamicResource>)(object)val18).ProvideValue((IServiceProvider)val127);
			val19.set_Value((object)value6);
			val20.get_Setters().Add(val19);
			((ResourceDictionary)this).Add(val20);
			val22.set_Property(ActivityIndicator.ColorProperty);
			val21.set_Key("SecondaryTextColor");
			XamlServiceProvider val130 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array15;
			int num8;
			object[] array16 = (array15 = new object[(num8 = 0) + 3]);
			array16[0] = val22;
			array16[1] = val23;
			array16[2] = this;
			SimpleValueTargetProvider val131 = new SimpleValueTargetProvider(array16, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val81);
			object obj8 = (object)val131;
			val130.Add(typeFromHandle15, (object)val131);
			val130.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val132 = new XmlNamespaceResolver();
			val132.Add("", "http://xamarin.com/schemas/2014/forms");
			val132.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val132.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val130.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val132, typeof(DesignSystem).GetTypeInfo().Assembly));
			val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 31)));
			DynamicResource value7 = ((IMarkupExtension<DynamicResource>)(object)val21).ProvideValue((IServiceProvider)val130);
			val22.set_Value((object)value7);
			val23.get_Setters().Add(val22);
			((ResourceDictionary)this).Add(val23);
			val25.set_Property(Label.TextColorProperty);
			val24.set_Key("PrimaryTextColor");
			XamlServiceProvider val133 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array17;
			int num9;
			object[] array18 = (array17 = new object[(num9 = 0) + 3]);
			array18[0] = val25;
			array18[1] = val28;
			array18[2] = this;
			SimpleValueTargetProvider val134 = new SimpleValueTargetProvider(array18, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val82);
			object obj9 = (object)val134;
			val133.Add(typeFromHandle17, (object)val134);
			val133.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val135 = new XmlNamespaceResolver();
			val135.Add("", "http://xamarin.com/schemas/2014/forms");
			val135.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val135.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val133.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val135, typeof(DesignSystem).GetTypeInfo().Assembly));
			val133.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 38)));
			DynamicResource value8 = ((IMarkupExtension<DynamicResource>)(object)val24).ProvideValue((IServiceProvider)val133);
			val25.set_Value((object)value8);
			val28.get_Setters().Add(val25);
			val26.set_Property(Label.FontSizeProperty);
			val26.set_Value((object)"Title");
			FontSizeConverter val136 = new FontSizeConverter();
			XamlServiceProvider val137 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array19;
			int num10;
			object[] array20 = (array19 = new object[(num10 = 0) + 3]);
			array20[0] = val26;
			array20[1] = val28;
			array20[2] = this;
			SimpleValueTargetProvider val138 = new SimpleValueTargetProvider(array20, (object)Label.FontSizeProperty, (INameScope)(object)val83);
			object obj10 = (object)val138;
			val137.Add(typeFromHandle19, (object)val138);
			val137.Add(typeof(IReferenceProvider), obj10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val139 = new XmlNamespaceResolver();
			val139.Add("", "http://xamarin.com/schemas/2014/forms");
			val139.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val139.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val137.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val139, typeof(DesignSystem).GetTypeInfo().Assembly));
			val137.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 37)));
			val26.set_Value(((IExtendedTypeConverter)val136).ConvertFromInvariantString("Title", (IServiceProvider)val137));
			val28.get_Setters().Add(val26);
			val27.set_Property(Label.FontAttributesProperty);
			val27.set_Value((object)"Bold");
			val27.set_Value(new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val28.get_Setters().Add(val27);
			((ResourceDictionary)this).Add("Heading1", (object)val28);
			val30.set_Property(Label.TextColorProperty);
			val29.set_Key("PrimaryTextColor");
			XamlServiceProvider val140 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array21;
			int num11;
			object[] array22 = (array21 = new object[(num11 = 0) + 3]);
			array22[0] = val30;
			array22[1] = val32;
			array22[2] = this;
			SimpleValueTargetProvider val141 = new SimpleValueTargetProvider(array22, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val85);
			object obj11 = (object)val141;
			val140.Add(typeFromHandle21, (object)val141);
			val140.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val142 = new XmlNamespaceResolver();
			val142.Add("", "http://xamarin.com/schemas/2014/forms");
			val142.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val142.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val140.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val142, typeof(DesignSystem).GetTypeInfo().Assembly));
			val140.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 38)));
			DynamicResource value9 = ((IMarkupExtension<DynamicResource>)(object)val29).ProvideValue((IServiceProvider)val140);
			val30.set_Value((object)value9);
			val32.get_Setters().Add(val30);
			val31.set_Property(Label.FontSizeProperty);
			val31.set_Value((object)"Large");
			FontSizeConverter val143 = new FontSizeConverter();
			XamlServiceProvider val144 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array23;
			int num12;
			object[] array24 = (array23 = new object[(num12 = 0) + 3]);
			array24[0] = val31;
			array24[1] = val32;
			array24[2] = this;
			SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array24, (object)Label.FontSizeProperty, (INameScope)(object)val86);
			object obj12 = (object)val145;
			val144.Add(typeFromHandle23, (object)val145);
			val144.Add(typeof(IReferenceProvider), obj12);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val146 = new XmlNamespaceResolver();
			val146.Add("", "http://xamarin.com/schemas/2014/forms");
			val146.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val146.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val144.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val146, typeof(DesignSystem).GetTypeInfo().Assembly));
			val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(45, 37)));
			val31.set_Value(((IExtendedTypeConverter)val143).ConvertFromInvariantString("Large", (IServiceProvider)val144));
			val32.get_Setters().Add(val31);
			((ResourceDictionary)this).Add("Heading2", (object)val32);
			val34.set_Property(Label.TextColorProperty);
			val33.set_Key("PrimaryTextColor");
			XamlServiceProvider val147 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array25;
			int num13;
			object[] array26 = (array25 = new object[(num13 = 0) + 3]);
			array26[0] = val34;
			array26[1] = val36;
			array26[2] = this;
			SimpleValueTargetProvider val148 = new SimpleValueTargetProvider(array26, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val87);
			object obj13 = (object)val148;
			val147.Add(typeFromHandle25, (object)val148);
			val147.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val149 = new XmlNamespaceResolver();
			val149.Add("", "http://xamarin.com/schemas/2014/forms");
			val149.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val149.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val147.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val149, typeof(DesignSystem).GetTypeInfo().Assembly));
			val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 38)));
			DynamicResource value10 = ((IMarkupExtension<DynamicResource>)(object)val33).ProvideValue((IServiceProvider)val147);
			val34.set_Value((object)value10);
			val36.get_Setters().Add(val34);
			val35.set_Property(Label.FontSizeProperty);
			val35.set_Value((object)"Small");
			FontSizeConverter val150 = new FontSizeConverter();
			XamlServiceProvider val151 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array27;
			int num14;
			object[] array28 = (array27 = new object[(num14 = 0) + 3]);
			array28[0] = val35;
			array28[1] = val36;
			array28[2] = this;
			SimpleValueTargetProvider val152 = new SimpleValueTargetProvider(array28, (object)Label.FontSizeProperty, (INameScope)(object)val88);
			object obj14 = (object)val152;
			val151.Add(typeFromHandle27, (object)val152);
			val151.Add(typeof(IReferenceProvider), obj14);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val153 = new XmlNamespaceResolver();
			val153.Add("", "http://xamarin.com/schemas/2014/forms");
			val153.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val153.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val151.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val153, typeof(DesignSystem).GetTypeInfo().Assembly));
			val151.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 37)));
			val35.set_Value(((IExtendedTypeConverter)val150).ConvertFromInvariantString("Small", (IServiceProvider)val151));
			val36.get_Setters().Add(val35);
			((ResourceDictionary)this).Add("Small", (object)val36);
			val38.set_Property(Label.TextColorProperty);
			val37.set_Key("PrimaryTextColor");
			XamlServiceProvider val154 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array29;
			int num15;
			object[] array30 = (array29 = new object[(num15 = 0) + 3]);
			array30[0] = val38;
			array30[1] = val40;
			array30[2] = this;
			SimpleValueTargetProvider val155 = new SimpleValueTargetProvider(array30, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val89);
			object obj15 = (object)val155;
			val154.Add(typeFromHandle29, (object)val155);
			val154.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val156 = new XmlNamespaceResolver();
			val156.Add("", "http://xamarin.com/schemas/2014/forms");
			val156.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val156.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val154.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val156, typeof(DesignSystem).GetTypeInfo().Assembly));
			val154.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 38)));
			DynamicResource value11 = ((IMarkupExtension<DynamicResource>)(object)val37).ProvideValue((IServiceProvider)val154);
			val38.set_Value((object)value11);
			val40.get_Setters().Add(val38);
			val39.set_Property(Label.FontSizeProperty);
			val39.set_Value((object)"Caption");
			FontSizeConverter val157 = new FontSizeConverter();
			XamlServiceProvider val158 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array31;
			int num16;
			object[] array32 = (array31 = new object[(num16 = 0) + 3]);
			array32[0] = val39;
			array32[1] = val40;
			array32[2] = this;
			SimpleValueTargetProvider val159 = new SimpleValueTargetProvider(array32, (object)Label.FontSizeProperty, (INameScope)(object)val90);
			object obj16 = (object)val159;
			val158.Add(typeFromHandle31, (object)val159);
			val158.Add(typeof(IReferenceProvider), obj16);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val160 = new XmlNamespaceResolver();
			val160.Add("", "http://xamarin.com/schemas/2014/forms");
			val160.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val160.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val158.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val160, typeof(DesignSystem).GetTypeInfo().Assembly));
			val158.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 37)));
			val39.set_Value(((IExtendedTypeConverter)val157).ConvertFromInvariantString("Caption", (IServiceProvider)val158));
			val40.get_Setters().Add(val39);
			((ResourceDictionary)this).Add("Micro", (object)val40);
			val42.set_Property(Label.TextColorProperty);
			val41.set_Key("PrimaryTextColor");
			XamlServiceProvider val161 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array33;
			int num17;
			object[] array34 = (array33 = new object[(num17 = 0) + 3]);
			array34[0] = val42;
			array34[1] = val45;
			array34[2] = this;
			SimpleValueTargetProvider val162 = new SimpleValueTargetProvider(array34, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val91);
			object obj17 = (object)val162;
			val161.Add(typeFromHandle33, (object)val162);
			val161.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val163 = new XmlNamespaceResolver();
			val163.Add("", "http://xamarin.com/schemas/2014/forms");
			val163.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val163.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val161.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val163, typeof(DesignSystem).GetTypeInfo().Assembly));
			val161.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 38)));
			DynamicResource value12 = ((IMarkupExtension<DynamicResource>)(object)val41).ProvideValue((IServiceProvider)val161);
			val42.set_Value((object)value12);
			val45.get_Setters().Add(val42);
			val43.set_Property(Label.FontSizeProperty);
			val43.set_Value((object)"15");
			FontSizeConverter val164 = new FontSizeConverter();
			XamlServiceProvider val165 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array35;
			int num18;
			object[] array36 = (array35 = new object[(num18 = 0) + 3]);
			array36[0] = val43;
			array36[1] = val45;
			array36[2] = this;
			SimpleValueTargetProvider val166 = new SimpleValueTargetProvider(array36, (object)Label.FontSizeProperty, (INameScope)(object)val92);
			object obj18 = (object)val166;
			val165.Add(typeFromHandle35, (object)val166);
			val165.Add(typeof(IReferenceProvider), obj18);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val167 = new XmlNamespaceResolver();
			val167.Add("", "http://xamarin.com/schemas/2014/forms");
			val167.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val167.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val165.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val167, typeof(DesignSystem).GetTypeInfo().Assembly));
			val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(60, 37)));
			val43.set_Value(((IExtendedTypeConverter)val164).ConvertFromInvariantString("15", (IServiceProvider)val165));
			val45.get_Setters().Add(val43);
			val44.set_Property(VisualElement.OpacityProperty);
			val44.set_Value((object)"0.6");
			val44.set_Value((object)0.6);
			val45.get_Setters().Add(val44);
			((ResourceDictionary)this).Add("Caption", (object)val45);
			val46.set_Property(Frame.HasShadowProperty);
			val46.set_Value((object)"False");
			val46.set_Value((object)false);
			val49.get_Setters().Add(val46);
			val48.set_Property(VisualElement.BackgroundColorProperty);
			val47.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val168 = new XamlServiceProvider();
			Type typeFromHandle37 = typeof(IProvideValueTarget);
			object[] array37;
			int num19;
			object[] array38 = (array37 = new object[(num19 = 0) + 3]);
			array38[0] = val48;
			array38[1] = val49;
			array38[2] = this;
			SimpleValueTargetProvider val169 = new SimpleValueTargetProvider(array38, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val95);
			object obj19 = (object)val169;
			val168.Add(typeFromHandle37, (object)val169);
			val168.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle38 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val170 = new XmlNamespaceResolver();
			val170.Add("", "http://xamarin.com/schemas/2014/forms");
			val170.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val170.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val168.Add(typeFromHandle38, (object)new XamlTypeResolver((IXmlNamespaceResolver)val170, typeof(DesignSystem).GetTypeInfo().Assembly));
			val168.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(66, 44)));
			DynamicResource value13 = ((IMarkupExtension<DynamicResource>)(object)val47).ProvideValue((IServiceProvider)val168);
			val48.set_Value((object)value13);
			val49.get_Setters().Add(val48);
			((ResourceDictionary)this).Add("ResourceLink", (object)val49);
			val51.set_Property(Frame.BorderColorProperty);
			val50.set_Key("PrimaryColor");
			XamlServiceProvider val171 = new XamlServiceProvider();
			Type typeFromHandle39 = typeof(IProvideValueTarget);
			object[] array39;
			int num20;
			object[] array40 = (array39 = new object[(num20 = 0) + 3]);
			array40[0] = val51;
			array40[1] = val52;
			array40[2] = this;
			SimpleValueTargetProvider val172 = new SimpleValueTargetProvider(array40, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val96);
			object obj20 = (object)val172;
			val171.Add(typeFromHandle39, (object)val172);
			val171.Add(typeof(IReferenceProvider), obj20);
			Type typeFromHandle40 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val173 = new XmlNamespaceResolver();
			val173.Add("", "http://xamarin.com/schemas/2014/forms");
			val173.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val173.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val171.Add(typeFromHandle40, (object)new XamlTypeResolver((IXmlNamespaceResolver)val173, typeof(DesignSystem).GetTypeInfo().Assembly));
			val171.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(70, 40)));
			DynamicResource value14 = ((IMarkupExtension<DynamicResource>)(object)val50).ProvideValue((IServiceProvider)val171);
			val51.set_Value((object)value14);
			val52.get_Setters().Add(val51);
			((ResourceDictionary)this).Add("EntryBorder", (object)val52);
			val54.set_Property(Label.TextColorProperty);
			val53.set_Key("TertiaryColor");
			XamlServiceProvider val174 = new XamlServiceProvider();
			Type typeFromHandle41 = typeof(IProvideValueTarget);
			object[] array41;
			int num21;
			object[] array42 = (array41 = new object[(num21 = 0) + 3]);
			array42[0] = val54;
			array42[1] = val57;
			array42[2] = this;
			SimpleValueTargetProvider val175 = new SimpleValueTargetProvider(array42, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val97);
			object obj21 = (object)val175;
			val174.Add(typeFromHandle41, (object)val175);
			val174.Add(typeof(IReferenceProvider), obj21);
			Type typeFromHandle42 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val176 = new XmlNamespaceResolver();
			val176.Add("", "http://xamarin.com/schemas/2014/forms");
			val176.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val176.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val174.Add(typeFromHandle42, (object)new XamlTypeResolver((IXmlNamespaceResolver)val176, typeof(DesignSystem).GetTypeInfo().Assembly));
			val174.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 38)));
			DynamicResource value15 = ((IMarkupExtension<DynamicResource>)(object)val53).ProvideValue((IServiceProvider)val174);
			val54.set_Value((object)value15);
			val57.get_Setters().Add(val54);
			val55.set_Property(Label.TextDecorationsProperty);
			val55.set_Value((object)"Underline");
			val55.set_Value(new TextDecorationConverter().ConvertFromInvariantString("Underline"));
			val57.get_Setters().Add(val55);
			val56.set_Property(Label.FontAttributesProperty);
			val56.set_Value((object)"Bold");
			val56.set_Value(new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val57.get_Setters().Add(val56);
			((ResourceDictionary)this).Add("Link", (object)val57);
			val59.set_Property(Label.TextColorProperty);
			val58.set_Key("Red");
			XamlServiceProvider val177 = new XamlServiceProvider();
			Type typeFromHandle43 = typeof(IProvideValueTarget);
			object[] array43;
			int num22;
			object[] array44 = (array43 = new object[(num22 = 0) + 3]);
			array44[0] = val59;
			array44[1] = val60;
			array44[2] = this;
			SimpleValueTargetProvider val178 = new SimpleValueTargetProvider(array44, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val100);
			object obj22 = (object)val178;
			val177.Add(typeFromHandle43, (object)val178);
			val177.Add(typeof(IReferenceProvider), obj22);
			Type typeFromHandle44 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val179 = new XmlNamespaceResolver();
			val179.Add("", "http://xamarin.com/schemas/2014/forms");
			val179.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val179.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val177.Add(typeFromHandle44, (object)new XamlTypeResolver((IXmlNamespaceResolver)val179, typeof(DesignSystem).GetTypeInfo().Assembly));
			val177.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 38)));
			DynamicResource value16 = ((IMarkupExtension<DynamicResource>)(object)val58).ProvideValue((IServiceProvider)val177);
			val59.set_Value((object)value16);
			val60.get_Setters().Add(val59);
			((ResourceDictionary)this).Add("ErrorTextStyle", (object)val60);
			val62.set_Property(VisualElement.BackgroundColorProperty);
			val61.set_Key("Blue");
			XamlServiceProvider val180 = new XamlServiceProvider();
			Type typeFromHandle45 = typeof(IProvideValueTarget);
			object[] array45;
			int num23;
			object[] array46 = (array45 = new object[(num23 = 0) + 3]);
			array46[0] = val62;
			array46[1] = val71;
			array46[2] = this;
			SimpleValueTargetProvider val181 = new SimpleValueTargetProvider(array46, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val101);
			object obj23 = (object)val181;
			val180.Add(typeFromHandle45, (object)val181);
			val180.Add(typeof(IReferenceProvider), obj23);
			Type typeFromHandle46 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val182 = new XmlNamespaceResolver();
			val182.Add("", "http://xamarin.com/schemas/2014/forms");
			val182.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val182.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val180.Add(typeFromHandle46, (object)new XamlTypeResolver((IXmlNamespaceResolver)val182, typeof(DesignSystem).GetTypeInfo().Assembly));
			val180.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(84, 44)));
			DynamicResource value17 = ((IMarkupExtension<DynamicResource>)(object)val61).ProvideValue((IServiceProvider)val180);
			val62.set_Value((object)value17);
			val71.get_Setters().Add(val62);
			val63.set_Property(Button.TextColorProperty);
			val63.set_Value((object)"White");
			val63.set_Value((object)Color.White);
			val71.get_Setters().Add(val63);
			val64.set_Property(View.MarginProperty);
			val64.set_Value((object)"0,0,0,16");
			val64.set_Value((object)new Thickness(0.0, 0.0, 0.0, 16.0));
			val71.get_Setters().Add(val64);
			val65.set_Property(Button.PaddingProperty);
			val65.set_Value((object)"32,16");
			val65.set_Value((object)new Thickness(32.0, 16.0));
			val71.get_Setters().Add(val65);
			val66.set_Property(Button.FontAttributesProperty);
			val66.set_Value((object)"Bold");
			val66.set_Value(new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			val71.get_Setters().Add(val66);
			val68.set_Property(Button.CornerRadiusProperty);
			val67.set_iOS(4);
			val67.set_Android(4);
			val68.set_Value((object)val67);
			val71.get_Setters().Add(val68);
			val70.set_Property(VisualElement.StyleProperty);
			val69.set_Key("ListItemTextStyle");
			XamlServiceProvider val183 = new XamlServiceProvider();
			Type typeFromHandle47 = typeof(IProvideValueTarget);
			object[] array47;
			int num24;
			object[] array48 = (array47 = new object[(num24 = 0) + 3]);
			array48[0] = val70;
			array48[1] = val71;
			array48[2] = this;
			SimpleValueTargetProvider val184 = new SimpleValueTargetProvider(array48, (object)typeof(Setter).GetRuntimeProperty("Value"), (INameScope)(object)val107);
			object obj24 = (object)val184;
			val183.Add(typeFromHandle47, (object)val184);
			val183.Add(typeof(IReferenceProvider), obj24);
			Type typeFromHandle48 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val185 = new XmlNamespaceResolver();
			val185.Add("", "http://xamarin.com/schemas/2014/forms");
			val185.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val185.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val183.Add(typeFromHandle48, (object)new XamlTypeResolver((IXmlNamespaceResolver)val185, typeof(DesignSystem).GetTypeInfo().Assembly));
			val183.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(94, 34)));
			DynamicResource value18 = ((IMarkupExtension<DynamicResource>)(object)val69).ProvideValue((IServiceProvider)val183);
			val70.set_Value((object)value18);
			val71.get_Setters().Add(val70);
			((ResourceDictionary)this).Add("LargeButtonStyle", (object)val71);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<DesignSystem>(this, typeof(DesignSystem));
		}
	}
}
