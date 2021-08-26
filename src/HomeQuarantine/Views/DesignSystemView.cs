using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using HomeQuarantine.Controls;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.ViewModels.Base;
using HomeQuarantine.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Views
{
	[XamlFilePath("Views/DesignSystemView.xaml")]
	public class DesignSystemView : BaseView, IChildView
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private StackLayout containingView;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private Button openHelpButton;

		public DesignSystemView()
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
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
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
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Expected O, but got Unknown
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected O, but got Unknown
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected O, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Expected O, but got Unknown
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Expected O, but got Unknown
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Expected O, but got Unknown
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Expected O, but got Unknown
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Expected O, but got Unknown
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected O, but got Unknown
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected O, but got Unknown
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected O, but got Unknown
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected O, but got Unknown
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Expected O, but got Unknown
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Expected O, but got Unknown
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Expected O, but got Unknown
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Expected O, but got Unknown
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected O, but got Unknown
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Expected O, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected O, but got Unknown
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Expected O, but got Unknown
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Expected O, but got Unknown
			//IL_050d: Expected O, but got Unknown
			//IL_050d: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_052a: Unknown result type (might be due to invalid IL or missing references)
			//IL_052f: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_058f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Expected O, but got Unknown
			//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Expected O, but got Unknown
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d6: Expected O, but got Unknown
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05e0: Expected O, but got Unknown
			//IL_060f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0624: Unknown result type (might be due to invalid IL or missing references)
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_0688: Unknown result type (might be due to invalid IL or missing references)
			//IL_068b: Expected O, but got Unknown
			//IL_0690: Expected O, but got Unknown
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Unknown result type (might be due to invalid IL or missing references)
			//IL_0712: Unknown result type (might be due to invalid IL or missing references)
			//IL_073b: Expected O, but got Unknown
			//IL_0736: Unknown result type (might be due to invalid IL or missing references)
			//IL_0740: Expected O, but got Unknown
			//IL_0740: Unknown result type (might be due to invalid IL or missing references)
			//IL_074f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0759: Expected O, but got Unknown
			//IL_0754: Unknown result type (might be due to invalid IL or missing references)
			//IL_075e: Expected O, but got Unknown
			//IL_0763: Expected O, but got Unknown
			//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07de: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0811: Unknown result type (might be due to invalid IL or missing references)
			//IL_0814: Expected O, but got Unknown
			//IL_0819: Expected O, but got Unknown
			//IL_0819: Unknown result type (might be due to invalid IL or missing references)
			//IL_082b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0836: Unknown result type (might be due to invalid IL or missing references)
			//IL_083b: Unknown result type (might be due to invalid IL or missing references)
			//IL_084b: Unknown result type (might be due to invalid IL or missing references)
			//IL_085b: Unknown result type (might be due to invalid IL or missing references)
			//IL_086b: Unknown result type (might be due to invalid IL or missing references)
			//IL_087b: Unknown result type (might be due to invalid IL or missing references)
			//IL_088b: Unknown result type (might be due to invalid IL or missing references)
			//IL_089b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c4: Expected O, but got Unknown
			//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c9: Expected O, but got Unknown
			//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e2: Expected O, but got Unknown
			//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e7: Expected O, but got Unknown
			//IL_08ec: Expected O, but got Unknown
			//IL_093d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0968: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_099b: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a3: Expected O, but got Unknown
			//IL_09a8: Expected O, but got Unknown
			//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_09da: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a53: Expected O, but got Unknown
			//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a58: Expected O, but got Unknown
			//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a71: Expected O, but got Unknown
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a76: Expected O, but got Unknown
			//IL_0a7b: Expected O, but got Unknown
			//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b32: Expected O, but got Unknown
			//IL_0b37: Expected O, but got Unknown
			//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be2: Expected O, but got Unknown
			//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be7: Expected O, but got Unknown
			//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c00: Expected O, but got Unknown
			//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c05: Expected O, but got Unknown
			//IL_0c0a: Expected O, but got Unknown
			//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc1: Expected O, but got Unknown
			//IL_0cc6: Expected O, but got Unknown
			//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d71: Expected O, but got Unknown
			//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d76: Expected O, but got Unknown
			//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8f: Expected O, but got Unknown
			//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d94: Expected O, but got Unknown
			//IL_0d99: Expected O, but got Unknown
			//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e50: Expected O, but got Unknown
			//IL_0e55: Expected O, but got Unknown
			//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f00: Expected O, but got Unknown
			//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f05: Expected O, but got Unknown
			//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1e: Expected O, but got Unknown
			//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f23: Expected O, but got Unknown
			//IL_0f28: Expected O, but got Unknown
			//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff3: Expected O, but got Unknown
			//IL_0ff8: Expected O, but got Unknown
			//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
			//IL_100a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1015: Unknown result type (might be due to invalid IL or missing references)
			//IL_101a: Unknown result type (might be due to invalid IL or missing references)
			//IL_102a: Unknown result type (might be due to invalid IL or missing references)
			//IL_103a: Unknown result type (might be due to invalid IL or missing references)
			//IL_104a: Unknown result type (might be due to invalid IL or missing references)
			//IL_105a: Unknown result type (might be due to invalid IL or missing references)
			//IL_106a: Unknown result type (might be due to invalid IL or missing references)
			//IL_107a: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a3: Expected O, but got Unknown
			//IL_109e: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a8: Expected O, but got Unknown
			//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c1: Expected O, but got Unknown
			//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c6: Expected O, but got Unknown
			//IL_10cb: Expected O, but got Unknown
			//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1111: Unknown result type (might be due to invalid IL or missing references)
			//IL_1141: Unknown result type (might be due to invalid IL or missing references)
			//IL_1146: Unknown result type (might be due to invalid IL or missing references)
			//IL_1179: Unknown result type (might be due to invalid IL or missing references)
			//IL_117e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1181: Expected O, but got Unknown
			//IL_1186: Expected O, but got Unknown
			//IL_1186: Unknown result type (might be due to invalid IL or missing references)
			//IL_1198: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1208: Unknown result type (might be due to invalid IL or missing references)
			//IL_1231: Expected O, but got Unknown
			//IL_122c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1236: Expected O, but got Unknown
			//IL_1236: Unknown result type (might be due to invalid IL or missing references)
			//IL_1245: Unknown result type (might be due to invalid IL or missing references)
			//IL_124f: Expected O, but got Unknown
			//IL_124a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1254: Expected O, but got Unknown
			//IL_1259: Expected O, but got Unknown
			//IL_128e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1293: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ce: Expected O, but got Unknown
			//IL_12d3: Expected O, but got Unknown
			//IL_12d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1305: Unknown result type (might be due to invalid IL or missing references)
			//IL_1315: Unknown result type (might be due to invalid IL or missing references)
			//IL_1325: Unknown result type (might be due to invalid IL or missing references)
			//IL_1335: Unknown result type (might be due to invalid IL or missing references)
			//IL_1345: Unknown result type (might be due to invalid IL or missing references)
			//IL_1355: Unknown result type (might be due to invalid IL or missing references)
			//IL_137e: Expected O, but got Unknown
			//IL_1379: Unknown result type (might be due to invalid IL or missing references)
			//IL_1383: Expected O, but got Unknown
			//IL_1383: Unknown result type (might be due to invalid IL or missing references)
			//IL_1392: Unknown result type (might be due to invalid IL or missing references)
			//IL_139c: Expected O, but got Unknown
			//IL_1397: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a1: Expected O, but got Unknown
			//IL_13a6: Expected O, but got Unknown
			//IL_13db: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1413: Unknown result type (might be due to invalid IL or missing references)
			//IL_1418: Unknown result type (might be due to invalid IL or missing references)
			//IL_141b: Expected O, but got Unknown
			//IL_1420: Expected O, but got Unknown
			//IL_1420: Unknown result type (might be due to invalid IL or missing references)
			//IL_1432: Unknown result type (might be due to invalid IL or missing references)
			//IL_143d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1442: Unknown result type (might be due to invalid IL or missing references)
			//IL_1452: Unknown result type (might be due to invalid IL or missing references)
			//IL_1462: Unknown result type (might be due to invalid IL or missing references)
			//IL_1472: Unknown result type (might be due to invalid IL or missing references)
			//IL_1482: Unknown result type (might be due to invalid IL or missing references)
			//IL_1492: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_14cb: Expected O, but got Unknown
			//IL_14c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d0: Expected O, but got Unknown
			//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14df: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e9: Expected O, but got Unknown
			//IL_14e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ee: Expected O, but got Unknown
			//IL_14f3: Expected O, but got Unknown
			//IL_1528: Unknown result type (might be due to invalid IL or missing references)
			//IL_152d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1560: Unknown result type (might be due to invalid IL or missing references)
			//IL_1565: Unknown result type (might be due to invalid IL or missing references)
			//IL_1568: Expected O, but got Unknown
			//IL_156d: Expected O, but got Unknown
			//IL_156d: Unknown result type (might be due to invalid IL or missing references)
			//IL_157f: Unknown result type (might be due to invalid IL or missing references)
			//IL_158a: Unknown result type (might be due to invalid IL or missing references)
			//IL_158f: Unknown result type (might be due to invalid IL or missing references)
			//IL_159f: Unknown result type (might be due to invalid IL or missing references)
			//IL_15af: Unknown result type (might be due to invalid IL or missing references)
			//IL_15bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_15cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_15df: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1618: Expected O, but got Unknown
			//IL_1613: Unknown result type (might be due to invalid IL or missing references)
			//IL_161d: Expected O, but got Unknown
			//IL_161d: Unknown result type (might be due to invalid IL or missing references)
			//IL_162c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1636: Expected O, but got Unknown
			//IL_1631: Unknown result type (might be due to invalid IL or missing references)
			//IL_163b: Expected O, but got Unknown
			//IL_1640: Expected O, but got Unknown
			//IL_1675: Unknown result type (might be due to invalid IL or missing references)
			//IL_167a: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b5: Expected O, but got Unknown
			//IL_16ba: Expected O, but got Unknown
			//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_16dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_170c: Unknown result type (might be due to invalid IL or missing references)
			//IL_171c: Unknown result type (might be due to invalid IL or missing references)
			//IL_172c: Unknown result type (might be due to invalid IL or missing references)
			//IL_173c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1765: Expected O, but got Unknown
			//IL_1760: Unknown result type (might be due to invalid IL or missing references)
			//IL_176a: Expected O, but got Unknown
			//IL_176a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1779: Unknown result type (might be due to invalid IL or missing references)
			//IL_1783: Expected O, but got Unknown
			//IL_177e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1788: Expected O, but got Unknown
			//IL_178d: Expected O, but got Unknown
			//IL_17da: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1817: Unknown result type (might be due to invalid IL or missing references)
			//IL_181c: Unknown result type (might be due to invalid IL or missing references)
			//IL_181f: Expected O, but got Unknown
			//IL_1824: Expected O, but got Unknown
			//IL_1824: Unknown result type (might be due to invalid IL or missing references)
			//IL_1836: Unknown result type (might be due to invalid IL or missing references)
			//IL_1841: Unknown result type (might be due to invalid IL or missing references)
			//IL_1846: Unknown result type (might be due to invalid IL or missing references)
			//IL_1856: Unknown result type (might be due to invalid IL or missing references)
			//IL_1866: Unknown result type (might be due to invalid IL or missing references)
			//IL_1876: Unknown result type (might be due to invalid IL or missing references)
			//IL_1886: Unknown result type (might be due to invalid IL or missing references)
			//IL_1896: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18cf: Expected O, but got Unknown
			//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d4: Expected O, but got Unknown
			//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ed: Expected O, but got Unknown
			//IL_18e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f2: Expected O, but got Unknown
			//IL_18f7: Expected O, but got Unknown
			//IL_1927: Unknown result type (might be due to invalid IL or missing references)
			//IL_193d: Unknown result type (might be due to invalid IL or missing references)
			//IL_196d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1972: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a8: Expected O, but got Unknown
			//IL_19ad: Expected O, but got Unknown
			//IL_19ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_19cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_19df: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a58: Expected O, but got Unknown
			//IL_1a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a5d: Expected O, but got Unknown
			//IL_1a5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a76: Expected O, but got Unknown
			//IL_1a71: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a7b: Expected O, but got Unknown
			//IL_1a80: Expected O, but got Unknown
			//IL_1aa3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aa8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1adb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ade: Expected O, but got Unknown
			//IL_1ae3: Expected O, but got Unknown
			//IL_1ae3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b00: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b05: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b25: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b35: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b45: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b55: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b65: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8e: Expected O, but got Unknown
			//IL_1b89: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b93: Expected O, but got Unknown
			//IL_1b93: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bac: Expected O, but got Unknown
			//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb1: Expected O, but got Unknown
			//IL_1bb6: Expected O, but got Unknown
			//IL_1c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c32: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c65: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c6d: Expected O, but got Unknown
			//IL_1c72: Expected O, but got Unknown
			//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c94: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ca4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d1d: Expected O, but got Unknown
			//IL_1d18: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d22: Expected O, but got Unknown
			//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d31: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d3b: Expected O, but got Unknown
			//IL_1d36: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d40: Expected O, but got Unknown
			//IL_1d45: Expected O, but got Unknown
			//IL_1d68: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da3: Expected O, but got Unknown
			//IL_1da8: Expected O, but got Unknown
			//IL_1da8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dba: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dca: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dda: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e53: Expected O, but got Unknown
			//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e58: Expected O, but got Unknown
			//IL_1e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e67: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e71: Expected O, but got Unknown
			//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e76: Expected O, but got Unknown
			//IL_1e7b: Expected O, but got Unknown
			//IL_1ecc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ef7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1efc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f32: Expected O, but got Unknown
			//IL_1f37: Expected O, but got Unknown
			//IL_1f37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f49: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f59: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f69: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f79: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fe2: Expected O, but got Unknown
			//IL_1fdd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fe7: Expected O, but got Unknown
			//IL_1fe7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2000: Expected O, but got Unknown
			//IL_1ffb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2005: Expected O, but got Unknown
			//IL_200a: Expected O, but got Unknown
			//IL_202d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2032: Unknown result type (might be due to invalid IL or missing references)
			//IL_2060: Unknown result type (might be due to invalid IL or missing references)
			//IL_2065: Unknown result type (might be due to invalid IL or missing references)
			//IL_2068: Expected O, but got Unknown
			//IL_206d: Expected O, but got Unknown
			//IL_206d: Unknown result type (might be due to invalid IL or missing references)
			//IL_207f: Unknown result type (might be due to invalid IL or missing references)
			//IL_208a: Unknown result type (might be due to invalid IL or missing references)
			//IL_208f: Unknown result type (might be due to invalid IL or missing references)
			//IL_209f: Unknown result type (might be due to invalid IL or missing references)
			//IL_20af: Unknown result type (might be due to invalid IL or missing references)
			//IL_20bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_20cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_20df: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_2118: Expected O, but got Unknown
			//IL_2113: Unknown result type (might be due to invalid IL or missing references)
			//IL_211d: Expected O, but got Unknown
			//IL_211d: Unknown result type (might be due to invalid IL or missing references)
			//IL_212c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2136: Expected O, but got Unknown
			//IL_2131: Unknown result type (might be due to invalid IL or missing references)
			//IL_213b: Expected O, but got Unknown
			//IL_2140: Expected O, but got Unknown
			//IL_2191: Unknown result type (might be due to invalid IL or missing references)
			//IL_21bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_21c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_21ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f7: Expected O, but got Unknown
			//IL_21fc: Expected O, but got Unknown
			//IL_21fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_220e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2219: Unknown result type (might be due to invalid IL or missing references)
			//IL_221e: Unknown result type (might be due to invalid IL or missing references)
			//IL_222e: Unknown result type (might be due to invalid IL or missing references)
			//IL_223e: Unknown result type (might be due to invalid IL or missing references)
			//IL_224e: Unknown result type (might be due to invalid IL or missing references)
			//IL_225e: Unknown result type (might be due to invalid IL or missing references)
			//IL_226e: Unknown result type (might be due to invalid IL or missing references)
			//IL_227e: Unknown result type (might be due to invalid IL or missing references)
			//IL_22a7: Expected O, but got Unknown
			//IL_22a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_22ac: Expected O, but got Unknown
			//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_22bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_22c5: Expected O, but got Unknown
			//IL_22c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_22ca: Expected O, but got Unknown
			//IL_22cf: Expected O, but got Unknown
			//IL_22f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2325: Unknown result type (might be due to invalid IL or missing references)
			//IL_232a: Unknown result type (might be due to invalid IL or missing references)
			//IL_232d: Expected O, but got Unknown
			//IL_2332: Expected O, but got Unknown
			//IL_2332: Unknown result type (might be due to invalid IL or missing references)
			//IL_2344: Unknown result type (might be due to invalid IL or missing references)
			//IL_234f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2354: Unknown result type (might be due to invalid IL or missing references)
			//IL_2364: Unknown result type (might be due to invalid IL or missing references)
			//IL_2374: Unknown result type (might be due to invalid IL or missing references)
			//IL_2384: Unknown result type (might be due to invalid IL or missing references)
			//IL_2394: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_23dd: Expected O, but got Unknown
			//IL_23d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e2: Expected O, but got Unknown
			//IL_23e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_23f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_23fb: Expected O, but got Unknown
			//IL_23f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2400: Expected O, but got Unknown
			//IL_2405: Expected O, but got Unknown
			//IL_2456: Unknown result type (might be due to invalid IL or missing references)
			//IL_253c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2541: Unknown result type (might be due to invalid IL or missing references)
			//IL_256f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2574: Unknown result type (might be due to invalid IL or missing references)
			//IL_2577: Expected O, but got Unknown
			//IL_257c: Expected O, but got Unknown
			//IL_257c: Unknown result type (might be due to invalid IL or missing references)
			//IL_258e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2599: Unknown result type (might be due to invalid IL or missing references)
			//IL_259e: Unknown result type (might be due to invalid IL or missing references)
			//IL_25ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_25be: Unknown result type (might be due to invalid IL or missing references)
			//IL_25ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_25de: Unknown result type (might be due to invalid IL or missing references)
			//IL_25ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_25fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2627: Expected O, but got Unknown
			//IL_2622: Unknown result type (might be due to invalid IL or missing references)
			//IL_262c: Expected O, but got Unknown
			//IL_262c: Unknown result type (might be due to invalid IL or missing references)
			//IL_263b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2645: Expected O, but got Unknown
			//IL_2640: Unknown result type (might be due to invalid IL or missing references)
			//IL_264a: Expected O, but got Unknown
			//IL_264f: Expected O, but got Unknown
			//IL_268f: Unknown result type (might be due to invalid IL or missing references)
			//IL_26ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_26ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_271d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2722: Unknown result type (might be due to invalid IL or missing references)
			//IL_2725: Expected O, but got Unknown
			//IL_272a: Expected O, but got Unknown
			//IL_272a: Unknown result type (might be due to invalid IL or missing references)
			//IL_273c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2747: Unknown result type (might be due to invalid IL or missing references)
			//IL_274c: Unknown result type (might be due to invalid IL or missing references)
			//IL_275c: Unknown result type (might be due to invalid IL or missing references)
			//IL_276c: Unknown result type (might be due to invalid IL or missing references)
			//IL_277c: Unknown result type (might be due to invalid IL or missing references)
			//IL_278c: Unknown result type (might be due to invalid IL or missing references)
			//IL_279c: Unknown result type (might be due to invalid IL or missing references)
			//IL_27ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_27d5: Expected O, but got Unknown
			//IL_27d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_27da: Expected O, but got Unknown
			//IL_27da: Unknown result type (might be due to invalid IL or missing references)
			//IL_27e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_27f3: Expected O, but got Unknown
			//IL_27ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_27f8: Expected O, but got Unknown
			//IL_27fd: Expected O, but got Unknown
			//IL_2822: Unknown result type (might be due to invalid IL or missing references)
			//IL_285e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2863: Unknown result type (might be due to invalid IL or missing references)
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
			//IL_2949: Expected O, but got Unknown
			//IL_2944: Unknown result type (might be due to invalid IL or missing references)
			//IL_294e: Expected O, but got Unknown
			//IL_294e: Unknown result type (might be due to invalid IL or missing references)
			//IL_295d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2967: Expected O, but got Unknown
			//IL_2962: Unknown result type (might be due to invalid IL or missing references)
			//IL_296c: Expected O, but got Unknown
			//IL_2971: Expected O, but got Unknown
			//IL_2996: Unknown result type (might be due to invalid IL or missing references)
			//IL_29c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_29c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_29f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_29f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_29fc: Expected O, but got Unknown
			//IL_2a01: Expected O, but got Unknown
			//IL_2a01: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a13: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a23: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a33: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a43: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a63: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a73: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a83: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aac: Expected O, but got Unknown
			//IL_2aa7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ab1: Expected O, but got Unknown
			//IL_2ab1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ac0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aca: Expected O, but got Unknown
			//IL_2ac5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2acf: Expected O, but got Unknown
			//IL_2ad4: Expected O, but got Unknown
			//IL_2b02: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b30: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b35: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b68: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b70: Expected O, but got Unknown
			//IL_2b75: Expected O, but got Unknown
			//IL_2b75: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b87: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b92: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b97: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2be7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bf7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c20: Expected O, but got Unknown
			//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c25: Expected O, but got Unknown
			//IL_2c25: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c34: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c3e: Expected O, but got Unknown
			//IL_2c39: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c43: Expected O, but got Unknown
			//IL_2c48: Expected O, but got Unknown
			//IL_2c64: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ce4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ce9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cec: Expected O, but got Unknown
			//IL_2cf1: Expected O, but got Unknown
			//IL_2cf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d03: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d13: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d23: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d43: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d53: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d63: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d73: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d9c: Expected O, but got Unknown
			//IL_2d97: Unknown result type (might be due to invalid IL or missing references)
			//IL_2da1: Expected O, but got Unknown
			//IL_2da1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2db0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dba: Expected O, but got Unknown
			//IL_2db5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dbf: Expected O, but got Unknown
			//IL_2dc4: Expected O, but got Unknown
			//IL_2dd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2def: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e24: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e52: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e57: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e5a: Expected O, but got Unknown
			//IL_2e5f: Expected O, but got Unknown
			//IL_2e5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e71: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e81: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e91: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ea1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ec1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ed1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ee1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f0a: Expected O, but got Unknown
			//IL_2f05: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f0f: Expected O, but got Unknown
			//IL_2f0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f28: Expected O, but got Unknown
			//IL_2f23: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f2d: Expected O, but got Unknown
			//IL_2f32: Expected O, but got Unknown
			//IL_2f57: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f76: Unknown result type (might be due to invalid IL or missing references)
			//IL_300c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3016: Unknown result type (might be due to invalid IL or missing references)
			//IL_301b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3049: Unknown result type (might be due to invalid IL or missing references)
			//IL_304e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3051: Expected O, but got Unknown
			//IL_3056: Expected O, but got Unknown
			//IL_3056: Unknown result type (might be due to invalid IL or missing references)
			//IL_3068: Unknown result type (might be due to invalid IL or missing references)
			//IL_3073: Unknown result type (might be due to invalid IL or missing references)
			//IL_3078: Unknown result type (might be due to invalid IL or missing references)
			//IL_3088: Unknown result type (might be due to invalid IL or missing references)
			//IL_3098: Unknown result type (might be due to invalid IL or missing references)
			//IL_30a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_30b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_30c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_30d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3101: Expected O, but got Unknown
			//IL_30fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_3106: Expected O, but got Unknown
			//IL_3106: Unknown result type (might be due to invalid IL or missing references)
			//IL_3115: Unknown result type (might be due to invalid IL or missing references)
			//IL_311f: Expected O, but got Unknown
			//IL_311a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3124: Expected O, but got Unknown
			//IL_3129: Expected O, but got Unknown
			//IL_313e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3154: Unknown result type (might be due to invalid IL or missing references)
			//IL_31a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_3233: Unknown result type (might be due to invalid IL or missing references)
			//IL_323d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3242: Unknown result type (might be due to invalid IL or missing references)
			//IL_3270: Unknown result type (might be due to invalid IL or missing references)
			//IL_3275: Unknown result type (might be due to invalid IL or missing references)
			//IL_3278: Expected O, but got Unknown
			//IL_327d: Expected O, but got Unknown
			//IL_327d: Unknown result type (might be due to invalid IL or missing references)
			//IL_328f: Unknown result type (might be due to invalid IL or missing references)
			//IL_329a: Unknown result type (might be due to invalid IL or missing references)
			//IL_329f: Unknown result type (might be due to invalid IL or missing references)
			//IL_32af: Unknown result type (might be due to invalid IL or missing references)
			//IL_32bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_32cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_32df: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_3328: Expected O, but got Unknown
			//IL_3323: Unknown result type (might be due to invalid IL or missing references)
			//IL_332d: Expected O, but got Unknown
			//IL_332d: Unknown result type (might be due to invalid IL or missing references)
			//IL_333c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3346: Expected O, but got Unknown
			//IL_3341: Unknown result type (might be due to invalid IL or missing references)
			//IL_334b: Expected O, but got Unknown
			//IL_3350: Expected O, but got Unknown
			//IL_3380: Unknown result type (might be due to invalid IL or missing references)
			//IL_3396: Unknown result type (might be due to invalid IL or missing references)
			//IL_33d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_33da: Unknown result type (might be due to invalid IL or missing references)
			//IL_33df: Unknown result type (might be due to invalid IL or missing references)
			//IL_340d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3412: Unknown result type (might be due to invalid IL or missing references)
			//IL_3415: Expected O, but got Unknown
			//IL_341a: Expected O, but got Unknown
			//IL_341a: Unknown result type (might be due to invalid IL or missing references)
			//IL_342c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3437: Unknown result type (might be due to invalid IL or missing references)
			//IL_343c: Unknown result type (might be due to invalid IL or missing references)
			//IL_344c: Unknown result type (might be due to invalid IL or missing references)
			//IL_345c: Unknown result type (might be due to invalid IL or missing references)
			//IL_346c: Unknown result type (might be due to invalid IL or missing references)
			//IL_347c: Unknown result type (might be due to invalid IL or missing references)
			//IL_348c: Unknown result type (might be due to invalid IL or missing references)
			//IL_349c: Unknown result type (might be due to invalid IL or missing references)
			//IL_34c5: Expected O, but got Unknown
			//IL_34c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ca: Expected O, but got Unknown
			//IL_34ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_34d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_34e3: Expected O, but got Unknown
			//IL_34de: Unknown result type (might be due to invalid IL or missing references)
			//IL_34e8: Expected O, but got Unknown
			//IL_34ed: Expected O, but got Unknown
			//IL_351d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3533: Unknown result type (might be due to invalid IL or missing references)
			//IL_356e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3584: Unknown result type (might be due to invalid IL or missing references)
			//IL_35b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3615: Unknown result type (might be due to invalid IL or missing references)
			//IL_3696: Unknown result type (might be due to invalid IL or missing references)
			//IL_36c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_36ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_36fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3702: Unknown result type (might be due to invalid IL or missing references)
			//IL_3705: Expected O, but got Unknown
			//IL_370a: Expected O, but got Unknown
			//IL_370a: Unknown result type (might be due to invalid IL or missing references)
			//IL_371c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3727: Unknown result type (might be due to invalid IL or missing references)
			//IL_372c: Unknown result type (might be due to invalid IL or missing references)
			//IL_373c: Unknown result type (might be due to invalid IL or missing references)
			//IL_374c: Unknown result type (might be due to invalid IL or missing references)
			//IL_375c: Unknown result type (might be due to invalid IL or missing references)
			//IL_376c: Unknown result type (might be due to invalid IL or missing references)
			//IL_377c: Unknown result type (might be due to invalid IL or missing references)
			//IL_378c: Unknown result type (might be due to invalid IL or missing references)
			//IL_37b5: Expected O, but got Unknown
			//IL_37b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_37ba: Expected O, but got Unknown
			//IL_37ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_37c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_37d3: Expected O, but got Unknown
			//IL_37ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_37d8: Expected O, but got Unknown
			//IL_37dd: Expected O, but got Unknown
			//IL_383c: Unknown result type (might be due to invalid IL or missing references)
			//IL_38bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_38ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_38f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3924: Unknown result type (might be due to invalid IL or missing references)
			//IL_3929: Unknown result type (might be due to invalid IL or missing references)
			//IL_392c: Expected O, but got Unknown
			//IL_3931: Expected O, but got Unknown
			//IL_3931: Unknown result type (might be due to invalid IL or missing references)
			//IL_3943: Unknown result type (might be due to invalid IL or missing references)
			//IL_394e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3953: Unknown result type (might be due to invalid IL or missing references)
			//IL_3963: Unknown result type (might be due to invalid IL or missing references)
			//IL_3973: Unknown result type (might be due to invalid IL or missing references)
			//IL_3983: Unknown result type (might be due to invalid IL or missing references)
			//IL_3993: Unknown result type (might be due to invalid IL or missing references)
			//IL_39a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_39b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_39dc: Expected O, but got Unknown
			//IL_39d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_39e1: Expected O, but got Unknown
			//IL_39e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_39f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_39fa: Expected O, but got Unknown
			//IL_39f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_39ff: Expected O, but got Unknown
			//IL_3a04: Expected O, but got Unknown
			//IL_3a63: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ae4: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b13: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b18: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b53: Expected O, but got Unknown
			//IL_3b58: Expected O, but got Unknown
			//IL_3b58: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b75: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bda: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c03: Expected O, but got Unknown
			//IL_3bfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c08: Expected O, but got Unknown
			//IL_3c08: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c17: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c21: Expected O, but got Unknown
			//IL_3c1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c26: Expected O, but got Unknown
			//IL_3c2b: Expected O, but got Unknown
			//IL_3c8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d72: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d77: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d7a: Expected O, but got Unknown
			//IL_3d7f: Expected O, but got Unknown
			//IL_3d7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d91: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3da1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3db1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3de1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3df1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e01: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e2a: Expected O, but got Unknown
			//IL_3e25: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e2f: Expected O, but got Unknown
			//IL_3e2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e48: Expected O, but got Unknown
			//IL_3e43: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e4d: Expected O, but got Unknown
			//IL_3e52: Expected O, but got Unknown
			//IL_3eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f32: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f61: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f66: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f99: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fa1: Expected O, but got Unknown
			//IL_3fa6: Expected O, but got Unknown
			//IL_3fa6: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fe8: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ff8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4008: Unknown result type (might be due to invalid IL or missing references)
			//IL_4018: Unknown result type (might be due to invalid IL or missing references)
			//IL_4028: Unknown result type (might be due to invalid IL or missing references)
			//IL_4051: Expected O, but got Unknown
			//IL_404c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4056: Expected O, but got Unknown
			//IL_4056: Unknown result type (might be due to invalid IL or missing references)
			//IL_4065: Unknown result type (might be due to invalid IL or missing references)
			//IL_406f: Expected O, but got Unknown
			//IL_406a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4074: Expected O, but got Unknown
			//IL_4079: Expected O, but got Unknown
			//IL_40c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_40d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4107: Unknown result type (might be due to invalid IL or missing references)
			//IL_416a: Unknown result type (might be due to invalid IL or missing references)
			//IL_41eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_421a: Unknown result type (might be due to invalid IL or missing references)
			//IL_421f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4252: Unknown result type (might be due to invalid IL or missing references)
			//IL_4257: Unknown result type (might be due to invalid IL or missing references)
			//IL_425a: Expected O, but got Unknown
			//IL_425f: Expected O, but got Unknown
			//IL_425f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4271: Unknown result type (might be due to invalid IL or missing references)
			//IL_427c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4281: Unknown result type (might be due to invalid IL or missing references)
			//IL_4291: Unknown result type (might be due to invalid IL or missing references)
			//IL_42a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_42b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_42c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_42d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_42e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_430a: Expected O, but got Unknown
			//IL_4305: Unknown result type (might be due to invalid IL or missing references)
			//IL_430f: Expected O, but got Unknown
			//IL_430f: Unknown result type (might be due to invalid IL or missing references)
			//IL_431e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4328: Expected O, but got Unknown
			//IL_4323: Unknown result type (might be due to invalid IL or missing references)
			//IL_432d: Expected O, but got Unknown
			//IL_4332: Expected O, but got Unknown
			//IL_4391: Unknown result type (might be due to invalid IL or missing references)
			//IL_4412: Unknown result type (might be due to invalid IL or missing references)
			//IL_4441: Unknown result type (might be due to invalid IL or missing references)
			//IL_4446: Unknown result type (might be due to invalid IL or missing references)
			//IL_4479: Unknown result type (might be due to invalid IL or missing references)
			//IL_447e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4481: Expected O, but got Unknown
			//IL_4486: Expected O, but got Unknown
			//IL_4486: Unknown result type (might be due to invalid IL or missing references)
			//IL_4498: Unknown result type (might be due to invalid IL or missing references)
			//IL_44a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_44a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_44b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_44c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_44d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_44e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_44f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4508: Unknown result type (might be due to invalid IL or missing references)
			//IL_4531: Expected O, but got Unknown
			//IL_452c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4536: Expected O, but got Unknown
			//IL_4536: Unknown result type (might be due to invalid IL or missing references)
			//IL_4545: Unknown result type (might be due to invalid IL or missing references)
			//IL_454f: Expected O, but got Unknown
			//IL_454a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4554: Expected O, but got Unknown
			//IL_4559: Expected O, but got Unknown
			//IL_45b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4639: Unknown result type (might be due to invalid IL or missing references)
			//IL_4668: Unknown result type (might be due to invalid IL or missing references)
			//IL_466d: Unknown result type (might be due to invalid IL or missing references)
			//IL_46a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_46a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_46a8: Expected O, but got Unknown
			//IL_46ad: Expected O, but got Unknown
			//IL_46ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_46bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_46ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_46cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_46df: Unknown result type (might be due to invalid IL or missing references)
			//IL_46ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_46ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_470f: Unknown result type (might be due to invalid IL or missing references)
			//IL_471f: Unknown result type (might be due to invalid IL or missing references)
			//IL_472f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4758: Expected O, but got Unknown
			//IL_4753: Unknown result type (might be due to invalid IL or missing references)
			//IL_475d: Expected O, but got Unknown
			//IL_475d: Unknown result type (might be due to invalid IL or missing references)
			//IL_476f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4779: Expected O, but got Unknown
			//IL_4774: Unknown result type (might be due to invalid IL or missing references)
			//IL_477e: Expected O, but got Unknown
			//IL_4783: Expected O, but got Unknown
			//IL_47e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4863: Unknown result type (might be due to invalid IL or missing references)
			//IL_4892: Unknown result type (might be due to invalid IL or missing references)
			//IL_4897: Unknown result type (might be due to invalid IL or missing references)
			//IL_48ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_48cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_48d2: Expected O, but got Unknown
			//IL_48d7: Expected O, but got Unknown
			//IL_48d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_48e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_48f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_48f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4909: Unknown result type (might be due to invalid IL or missing references)
			//IL_4919: Unknown result type (might be due to invalid IL or missing references)
			//IL_4929: Unknown result type (might be due to invalid IL or missing references)
			//IL_4939: Unknown result type (might be due to invalid IL or missing references)
			//IL_4949: Unknown result type (might be due to invalid IL or missing references)
			//IL_4959: Unknown result type (might be due to invalid IL or missing references)
			//IL_4982: Expected O, but got Unknown
			//IL_497d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4987: Expected O, but got Unknown
			//IL_4987: Unknown result type (might be due to invalid IL or missing references)
			//IL_4999: Unknown result type (might be due to invalid IL or missing references)
			//IL_49a3: Expected O, but got Unknown
			//IL_499e: Unknown result type (might be due to invalid IL or missing references)
			//IL_49a8: Expected O, but got Unknown
			//IL_49ad: Expected O, but got Unknown
			//IL_4a0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4a8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4abc: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ac1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4af4: Unknown result type (might be due to invalid IL or missing references)
			//IL_4af9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4afc: Expected O, but got Unknown
			//IL_4b01: Expected O, but got Unknown
			//IL_4b01: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b13: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b23: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b33: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b43: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b63: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b73: Unknown result type (might be due to invalid IL or missing references)
			//IL_4b83: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bac: Expected O, but got Unknown
			//IL_4ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bb1: Expected O, but got Unknown
			//IL_4bb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bcd: Expected O, but got Unknown
			//IL_4bc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_4bd2: Expected O, but got Unknown
			//IL_4bd7: Expected O, but got Unknown
			//IL_4c36: Unknown result type (might be due to invalid IL or missing references)
			//IL_4cb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ce6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ceb: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d23: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d26: Expected O, but got Unknown
			//IL_4d2b: Expected O, but got Unknown
			//IL_4d2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d48: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dad: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dd6: Expected O, but got Unknown
			//IL_4dd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ddb: Expected O, but got Unknown
			//IL_4ddb: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ded: Unknown result type (might be due to invalid IL or missing references)
			//IL_4df7: Expected O, but got Unknown
			//IL_4df2: Unknown result type (might be due to invalid IL or missing references)
			//IL_4dfc: Expected O, but got Unknown
			//IL_4e01: Expected O, but got Unknown
			//IL_4e4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e54: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e59: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e87: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4e8f: Expected O, but got Unknown
			//IL_4e94: Expected O, but got Unknown
			//IL_4e94: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ea6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_4eb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ec6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ed6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ee6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ef6: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f06: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f16: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f3f: Expected O, but got Unknown
			//IL_4f3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f44: Expected O, but got Unknown
			//IL_4f44: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f56: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f60: Expected O, but got Unknown
			//IL_4f5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_4f65: Expected O, but got Unknown
			//IL_4f6a: Expected O, but got Unknown
			//IL_4f9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_4fb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4feb: Unknown result type (might be due to invalid IL or missing references)
			//IL_5008: Unknown result type (might be due to invalid IL or missing references)
			//IL_500d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5040: Unknown result type (might be due to invalid IL or missing references)
			//IL_5045: Unknown result type (might be due to invalid IL or missing references)
			//IL_5048: Expected O, but got Unknown
			//IL_504d: Expected O, but got Unknown
			//IL_504d: Unknown result type (might be due to invalid IL or missing references)
			//IL_505f: Unknown result type (might be due to invalid IL or missing references)
			//IL_506a: Unknown result type (might be due to invalid IL or missing references)
			//IL_506f: Unknown result type (might be due to invalid IL or missing references)
			//IL_507f: Unknown result type (might be due to invalid IL or missing references)
			//IL_508f: Unknown result type (might be due to invalid IL or missing references)
			//IL_509f: Unknown result type (might be due to invalid IL or missing references)
			//IL_50af: Unknown result type (might be due to invalid IL or missing references)
			//IL_50bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_50cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_50f8: Expected O, but got Unknown
			//IL_50f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_50fd: Expected O, but got Unknown
			//IL_50fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_510f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5119: Expected O, but got Unknown
			//IL_5114: Unknown result type (might be due to invalid IL or missing references)
			//IL_511e: Expected O, but got Unknown
			//IL_5123: Expected O, but got Unknown
			//IL_5190: Unknown result type (might be due to invalid IL or missing references)
			//IL_5195: Unknown result type (might be due to invalid IL or missing references)
			//IL_51c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_51cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_51d0: Expected O, but got Unknown
			//IL_51d5: Expected O, but got Unknown
			//IL_51d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_51e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_51f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_51f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_5207: Unknown result type (might be due to invalid IL or missing references)
			//IL_5217: Unknown result type (might be due to invalid IL or missing references)
			//IL_5227: Unknown result type (might be due to invalid IL or missing references)
			//IL_5237: Unknown result type (might be due to invalid IL or missing references)
			//IL_5247: Unknown result type (might be due to invalid IL or missing references)
			//IL_5257: Unknown result type (might be due to invalid IL or missing references)
			//IL_5280: Expected O, but got Unknown
			//IL_527b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5285: Expected O, but got Unknown
			//IL_5285: Unknown result type (might be due to invalid IL or missing references)
			//IL_5297: Unknown result type (might be due to invalid IL or missing references)
			//IL_52a1: Expected O, but got Unknown
			//IL_529c: Unknown result type (might be due to invalid IL or missing references)
			//IL_52a6: Expected O, but got Unknown
			//IL_52ab: Expected O, but got Unknown
			//IL_5318: Unknown result type (might be due to invalid IL or missing references)
			//IL_531d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5350: Unknown result type (might be due to invalid IL or missing references)
			//IL_5355: Unknown result type (might be due to invalid IL or missing references)
			//IL_5358: Expected O, but got Unknown
			//IL_535d: Expected O, but got Unknown
			//IL_535d: Unknown result type (might be due to invalid IL or missing references)
			//IL_536f: Unknown result type (might be due to invalid IL or missing references)
			//IL_537a: Unknown result type (might be due to invalid IL or missing references)
			//IL_537f: Unknown result type (might be due to invalid IL or missing references)
			//IL_538f: Unknown result type (might be due to invalid IL or missing references)
			//IL_539f: Unknown result type (might be due to invalid IL or missing references)
			//IL_53af: Unknown result type (might be due to invalid IL or missing references)
			//IL_53bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_53cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_53df: Unknown result type (might be due to invalid IL or missing references)
			//IL_5408: Expected O, but got Unknown
			//IL_5403: Unknown result type (might be due to invalid IL or missing references)
			//IL_540d: Expected O, but got Unknown
			//IL_540d: Unknown result type (might be due to invalid IL or missing references)
			//IL_541f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5429: Expected O, but got Unknown
			//IL_5424: Unknown result type (might be due to invalid IL or missing references)
			//IL_542e: Expected O, but got Unknown
			//IL_5433: Expected O, but got Unknown
			//IL_54a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_54a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_54d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_54dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_54e0: Expected O, but got Unknown
			//IL_54e5: Expected O, but got Unknown
			//IL_54e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_54f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_5502: Unknown result type (might be due to invalid IL or missing references)
			//IL_5507: Unknown result type (might be due to invalid IL or missing references)
			//IL_5517: Unknown result type (might be due to invalid IL or missing references)
			//IL_5527: Unknown result type (might be due to invalid IL or missing references)
			//IL_5537: Unknown result type (might be due to invalid IL or missing references)
			//IL_5547: Unknown result type (might be due to invalid IL or missing references)
			//IL_5557: Unknown result type (might be due to invalid IL or missing references)
			//IL_5567: Unknown result type (might be due to invalid IL or missing references)
			//IL_5590: Expected O, but got Unknown
			//IL_558b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5595: Expected O, but got Unknown
			//IL_5595: Unknown result type (might be due to invalid IL or missing references)
			//IL_55a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_55b1: Expected O, but got Unknown
			//IL_55ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_55b6: Expected O, but got Unknown
			//IL_55bb: Expected O, but got Unknown
			//IL_5628: Unknown result type (might be due to invalid IL or missing references)
			//IL_562d: Unknown result type (might be due to invalid IL or missing references)
			//IL_5660: Unknown result type (might be due to invalid IL or missing references)
			//IL_5665: Unknown result type (might be due to invalid IL or missing references)
			//IL_5668: Expected O, but got Unknown
			//IL_566d: Expected O, but got Unknown
			//IL_566d: Unknown result type (might be due to invalid IL or missing references)
			//IL_567f: Unknown result type (might be due to invalid IL or missing references)
			//IL_568a: Unknown result type (might be due to invalid IL or missing references)
			//IL_568f: Unknown result type (might be due to invalid IL or missing references)
			//IL_569f: Unknown result type (might be due to invalid IL or missing references)
			//IL_56af: Unknown result type (might be due to invalid IL or missing references)
			//IL_56bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_56cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_56df: Unknown result type (might be due to invalid IL or missing references)
			//IL_56ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_5718: Expected O, but got Unknown
			//IL_5713: Unknown result type (might be due to invalid IL or missing references)
			//IL_571d: Expected O, but got Unknown
			//IL_571d: Unknown result type (might be due to invalid IL or missing references)
			//IL_572f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5739: Expected O, but got Unknown
			//IL_5734: Unknown result type (might be due to invalid IL or missing references)
			//IL_573e: Expected O, but got Unknown
			//IL_5743: Expected O, but got Unknown
			//IL_57b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_57b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_57e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_57ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_57f0: Expected O, but got Unknown
			//IL_57f5: Expected O, but got Unknown
			//IL_57f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_5807: Unknown result type (might be due to invalid IL or missing references)
			//IL_5812: Unknown result type (might be due to invalid IL or missing references)
			//IL_5817: Unknown result type (might be due to invalid IL or missing references)
			//IL_5827: Unknown result type (might be due to invalid IL or missing references)
			//IL_5837: Unknown result type (might be due to invalid IL or missing references)
			//IL_5847: Unknown result type (might be due to invalid IL or missing references)
			//IL_5857: Unknown result type (might be due to invalid IL or missing references)
			//IL_5867: Unknown result type (might be due to invalid IL or missing references)
			//IL_5877: Unknown result type (might be due to invalid IL or missing references)
			//IL_58a0: Expected O, but got Unknown
			//IL_589b: Unknown result type (might be due to invalid IL or missing references)
			//IL_58a5: Expected O, but got Unknown
			//IL_58a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_58b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_58c1: Expected O, but got Unknown
			//IL_58bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_58c6: Expected O, but got Unknown
			//IL_58cb: Expected O, but got Unknown
			//IL_5948: Unknown result type (might be due to invalid IL or missing references)
			//IL_597f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5984: Unknown result type (might be due to invalid IL or missing references)
			//IL_59bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_59c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_59c4: Expected O, but got Unknown
			//IL_59c9: Expected O, but got Unknown
			//IL_59c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_59db: Unknown result type (might be due to invalid IL or missing references)
			//IL_59e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_59eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_59fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a74: Expected O, but got Unknown
			//IL_5a6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a79: Expected O, but got Unknown
			//IL_5a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a95: Expected O, but got Unknown
			//IL_5a90: Unknown result type (might be due to invalid IL or missing references)
			//IL_5a9a: Expected O, but got Unknown
			//IL_5a9f: Expected O, but got Unknown
			//IL_5ac2: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ac7: Unknown result type (might be due to invalid IL or missing references)
			//IL_5aff: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b04: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b07: Expected O, but got Unknown
			//IL_5b0c: Expected O, but got Unknown
			//IL_5b0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b29: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5b8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bb7: Expected O, but got Unknown
			//IL_5bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bbc: Expected O, but got Unknown
			//IL_5bbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bce: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bd8: Expected O, but got Unknown
			//IL_5bd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_5bdd: Expected O, but got Unknown
			//IL_5be2: Expected O, but got Unknown
			//IL_5c57: Unknown result type (might be due to invalid IL or missing references)
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(DesignSystemView).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Views/DesignSystemView.xaml");
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
			Label val2 = new Label();
			DynamicResourceExtension val3 = new DynamicResourceExtension();
			Label val4 = new Label();
			DynamicResourceExtension val5 = new DynamicResourceExtension();
			Label val6 = new Label();
			DynamicResourceExtension val7 = new DynamicResourceExtension();
			Label val8 = new Label();
			DynamicResourceExtension val9 = new DynamicResourceExtension();
			Label val10 = new Label();
			DynamicResourceExtension val11 = new DynamicResourceExtension();
			Label val12 = new Label();
			DynamicResourceExtension val13 = new DynamicResourceExtension();
			Label val14 = new Label();
			Label val15 = new Label();
			StaticResourceExtension val16 = new StaticResourceExtension();
			string homePage_SymptomCheck = Resources.HomePage_SymptomCheck;
			ButtonMainView buttonMainView = new ButtonMainView();
			StaticResourceExtension val17 = new StaticResourceExtension();
			string homePage_TestingScheduleAndCalendar = Resources.HomePage_TestingScheduleAndCalendar;
			ButtonMainView buttonMainView2 = new ButtonMainView();
			StaticResourceExtension val18 = new StaticResourceExtension();
			string homePage_SupportResources = Resources.HomePage_SupportResources;
			ButtonMainView buttonMainView3 = new ButtonMainView();
			StaticResourceExtension val19 = new StaticResourceExtension();
			string homePage_QuarantineGuidelines = Resources.HomePage_QuarantineGuidelines;
			ButtonMainView buttonMainView4 = new ButtonMainView();
			StaticResourceExtension val20 = new StaticResourceExtension();
			string homePage_FAQs = Resources.HomePage_FAQs;
			ButtonMainView buttonMainView5 = new ButtonMainView();
			StackLayout val21 = new StackLayout();
			Label val22 = new Label();
			DynamicResourceExtension val23 = new DynamicResourceExtension();
			DynamicResourceExtension val24 = new DynamicResourceExtension();
			Button val25 = new Button();
			DynamicResourceExtension val26 = new DynamicResourceExtension();
			DynamicResourceExtension val27 = new DynamicResourceExtension();
			Button val28 = new Button();
			DynamicResourceExtension val29 = new DynamicResourceExtension();
			DynamicResourceExtension val30 = new DynamicResourceExtension();
			Button val31 = new Button();
			DynamicResourceExtension val32 = new DynamicResourceExtension();
			DynamicResourceExtension val33 = new DynamicResourceExtension();
			Button val34 = new Button();
			ResourceLinkView resourceLinkView = new ResourceLinkView();
			ResourceLinkView resourceLinkView2 = new ResourceLinkView();
			ResourceLinkView resourceLinkView3 = new ResourceLinkView();
			StackLayout val35 = new StackLayout();
			DynamicResourceExtension val36 = new DynamicResourceExtension();
			ResourceLinkView resourceLinkView4 = new ResourceLinkView();
			Frame val37 = new Frame();
			DynamicResourceExtension val38 = new DynamicResourceExtension();
			Label val39 = new Label();
			DynamicResourceExtension val40 = new DynamicResourceExtension();
			Label val41 = new Label();
			DynamicResourceExtension val42 = new DynamicResourceExtension();
			DynamicResourceExtension val43 = new DynamicResourceExtension();
			Label val44 = new Label();
			StackLayout val45 = new StackLayout();
			Label val46 = new Label();
			DynamicResourceExtension val47 = new DynamicResourceExtension();
			Entry val48 = new Entry();
			Frame val49 = new Frame();
			Label val50 = new Label();
			TextAreaView textAreaView = new TextAreaView();
			CheckboxLabelView checkboxLabelView = new CheckboxLabelView();
			Label val51 = new Label();
			Label val52 = new Label();
			ColumnDefinition val53 = new ColumnDefinition();
			ColumnDefinition val54 = new ColumnDefinition();
			Label val55 = new Label();
			DynamicResourceExtension val56 = new DynamicResourceExtension();
			Frame val57 = new Frame();
			Label val58 = new Label();
			DynamicResourceExtension val59 = new DynamicResourceExtension();
			Frame val60 = new Frame();
			Label val61 = new Label();
			DynamicResourceExtension val62 = new DynamicResourceExtension();
			Frame val63 = new Frame();
			Label val64 = new Label();
			DynamicResourceExtension val65 = new DynamicResourceExtension();
			Frame val66 = new Frame();
			Label val67 = new Label();
			DynamicResourceExtension val68 = new DynamicResourceExtension();
			Frame val69 = new Frame();
			Grid val70 = new Grid();
			ColumnDefinition val71 = new ColumnDefinition();
			ColumnDefinition val72 = new ColumnDefinition();
			Label val73 = new Label();
			DynamicResourceExtension val74 = new DynamicResourceExtension();
			Frame val75 = new Frame();
			Label val76 = new Label();
			DynamicResourceExtension val77 = new DynamicResourceExtension();
			Frame val78 = new Frame();
			Label val79 = new Label();
			DynamicResourceExtension val80 = new DynamicResourceExtension();
			Frame val81 = new Frame();
			Label val82 = new Label();
			DynamicResourceExtension val83 = new DynamicResourceExtension();
			Frame val84 = new Frame();
			Label val85 = new Label();
			DynamicResourceExtension val86 = new DynamicResourceExtension();
			Frame val87 = new Frame();
			Label val88 = new Label();
			DynamicResourceExtension val89 = new DynamicResourceExtension();
			Frame val90 = new Frame();
			Grid val91 = new Grid();
			Label val92 = new Label();
			StaticResourceExtension val93 = new StaticResourceExtension();
			SymptomView symptomView = new SymptomView();
			StaticResourceExtension val94 = new StaticResourceExtension();
			SymptomView symptomView2 = new SymptomView();
			StaticResourceExtension val95 = new StaticResourceExtension();
			SymptomView symptomView3 = new SymptomView();
			StaticResourceExtension val96 = new StaticResourceExtension();
			SymptomView symptomView4 = new SymptomView();
			StaticResourceExtension val97 = new StaticResourceExtension();
			SymptomView symptomView5 = new SymptomView();
			StaticResourceExtension val98 = new StaticResourceExtension();
			SymptomView symptomView6 = new SymptomView();
			Grid val99 = new Grid();
			DynamicResourceExtension val100 = new DynamicResourceExtension();
			DynamicResourceExtension val101 = new DynamicResourceExtension();
			BindingExtension val102 = new BindingExtension();
			Button val103 = new Button();
			StackLayout val104 = new StackLayout();
			StackLayout val105 = new StackLayout();
			StackLayout val106 = new StackLayout();
			ScrollView val107 = new ScrollView();
			DesignSystemView designSystemView;
			NameScope val108 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(designSystemView = this))) ?? ((object)new NameScope()));
			NameScope.SetNameScope((BindableObject)(object)designSystemView, (INameScope)(object)val108);
			((INameScope)val108).RegisterName("containingView", (object)val106);
			if (((Element)val106).get_StyleId() == null)
			{
				((Element)val106).set_StyleId("containingView");
			}
			((INameScope)val108).RegisterName("openHelpButton", (object)val103);
			if (((Element)val103).get_StyleId() == null)
			{
				((Element)val103).set_StyleId("openHelpButton");
			}
			containingView = val106;
			openHelpButton = val103;
			((BindableObject)designSystemView).SetValue(ViewModelLocator.AutoWireViewModelProperty, (object)true);
			((BindableObject)designSystemView).SetValue(Page.TitleProperty, (object)"Design System");
			((BindableObject)val107).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val106).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.FillAndExpand);
			((BindableObject)val2).SetValue(Label.TextProperty, (object)"Font styles");
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter val109 = new FontSizeConverter();
			XamlServiceProvider val110 = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 4];
			array[0] = val2;
			array[1] = val106;
			array[2] = val107;
			array[3] = designSystemView;
			SimpleValueTargetProvider val111 = new SimpleValueTargetProvider(array, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj = (object)val111;
			val110.Add(typeFromHandle, (object)val111);
			val110.Add(typeof(IReferenceProvider), obj);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val112 = new XmlNamespaceResolver();
			val112.Add("", "http://xamarin.com/schemas/2014/forms");
			val112.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val112.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val112.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val112.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val112.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val112.Add("constants", "clr-namespace:HomeQuarantine");
			val110.Add(typeFromHandle2, (object)new XamlTypeResolver((IXmlNamespaceResolver)val112, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val110.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 39)));
			((BindableObject)val2).SetValue(fontSizeProperty, ((IExtendedTypeConverter)val109).ConvertFromInvariantString("Subtitle", (IServiceProvider)val110));
			((BindableObject)val2).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 8.0));
			((BindableObject)val2).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val2);
			val3.set_Key("Heading1");
			XamlServiceProvider val113 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 4];
			array2[0] = val4;
			array2[1] = val106;
			array2[2] = val107;
			array2[3] = designSystemView;
			SimpleValueTargetProvider val114 = new SimpleValueTargetProvider(array2, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj2 = (object)val114;
			val113.Add(typeFromHandle3, (object)val114);
			val113.Add(typeof(IReferenceProvider), obj2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val115 = new XmlNamespaceResolver();
			val115.Add("", "http://xamarin.com/schemas/2014/forms");
			val115.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val115.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val115.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val115.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val115.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val115.Add("constants", "clr-namespace:HomeQuarantine");
			val113.Add(typeFromHandle4, (object)new XamlTypeResolver((IXmlNamespaceResolver)val115, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val113.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 20)));
			DynamicResource val116 = ((IMarkupExtension<DynamicResource>)(object)val3).ProvideValue((IServiceProvider)val113);
			((IDynamicResourceHandler)val4).SetDynamicResource(VisualElement.StyleProperty, val116.get_Key());
			((BindableObject)val4).SetValue(Label.TextProperty, (object)"Heading 1");
			((BindableObject)val4).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val4);
			val5.set_Key("Heading2");
			XamlServiceProvider val117 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 4];
			array3[0] = val6;
			array3[1] = val106;
			array3[2] = val107;
			array3[3] = designSystemView;
			SimpleValueTargetProvider val118 = new SimpleValueTargetProvider(array3, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj3 = (object)val118;
			val117.Add(typeFromHandle5, (object)val118);
			val117.Add(typeof(IReferenceProvider), obj3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val119 = new XmlNamespaceResolver();
			val119.Add("", "http://xamarin.com/schemas/2014/forms");
			val119.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val119.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val119.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val119.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val119.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val119.Add("constants", "clr-namespace:HomeQuarantine");
			val117.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val119, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val117.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
			DynamicResource val120 = ((IMarkupExtension<DynamicResource>)(object)val5).ProvideValue((IServiceProvider)val117);
			((IDynamicResourceHandler)val6).SetDynamicResource(VisualElement.StyleProperty, val120.get_Key());
			((BindableObject)val6).SetValue(Label.TextProperty, (object)"Heading 2");
			((BindableObject)val6).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val6);
			val7.set_Key("Large");
			XamlServiceProvider val121 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 4];
			array4[0] = val8;
			array4[1] = val106;
			array4[2] = val107;
			array4[3] = designSystemView;
			SimpleValueTargetProvider val122 = new SimpleValueTargetProvider(array4, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj4 = (object)val122;
			val121.Add(typeFromHandle7, (object)val122);
			val121.Add(typeof(IReferenceProvider), obj4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val123 = new XmlNamespaceResolver();
			val123.Add("", "http://xamarin.com/schemas/2014/forms");
			val123.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val123.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val123.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val123.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val123.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val123.Add("constants", "clr-namespace:HomeQuarantine");
			val121.Add(typeFromHandle8, (object)new XamlTypeResolver((IXmlNamespaceResolver)val123, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val121.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 20)));
			DynamicResource val124 = ((IMarkupExtension<DynamicResource>)(object)val7).ProvideValue((IServiceProvider)val121);
			((IDynamicResourceHandler)val8).SetDynamicResource(VisualElement.StyleProperty, val124.get_Key());
			((BindableObject)val8).SetValue(Label.TextProperty, (object)"Large body text");
			((BindableObject)val8).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val8);
			val9.set_Key("Body");
			XamlServiceProvider val125 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 4];
			array5[0] = val10;
			array5[1] = val106;
			array5[2] = val107;
			array5[3] = designSystemView;
			SimpleValueTargetProvider val126 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj5 = (object)val126;
			val125.Add(typeFromHandle9, (object)val126);
			val125.Add(typeof(IReferenceProvider), obj5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val127 = new XmlNamespaceResolver();
			val127.Add("", "http://xamarin.com/schemas/2014/forms");
			val127.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val127.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val127.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val127.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val127.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val127.Add("constants", "clr-namespace:HomeQuarantine");
			val125.Add(typeFromHandle10, (object)new XamlTypeResolver((IXmlNamespaceResolver)val127, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val125.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
			DynamicResource val128 = ((IMarkupExtension<DynamicResource>)(object)val9).ProvideValue((IServiceProvider)val125);
			((IDynamicResourceHandler)val10).SetDynamicResource(VisualElement.StyleProperty, val128.get_Key());
			((BindableObject)val10).SetValue(Label.TextProperty, (object)"Body text (Default)");
			((BindableObject)val10).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val10);
			val11.set_Key("Small");
			XamlServiceProvider val129 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 4];
			array6[0] = val12;
			array6[1] = val106;
			array6[2] = val107;
			array6[3] = designSystemView;
			SimpleValueTargetProvider val130 = new SimpleValueTargetProvider(array6, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj6 = (object)val130;
			val129.Add(typeFromHandle11, (object)val130);
			val129.Add(typeof(IReferenceProvider), obj6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val131 = new XmlNamespaceResolver();
			val131.Add("", "http://xamarin.com/schemas/2014/forms");
			val131.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val131.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val131.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val131.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val131.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val131.Add("constants", "clr-namespace:HomeQuarantine");
			val129.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val131, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val129.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(22, 20)));
			DynamicResource val132 = ((IMarkupExtension<DynamicResource>)(object)val11).ProvideValue((IServiceProvider)val129);
			((IDynamicResourceHandler)val12).SetDynamicResource(VisualElement.StyleProperty, val132.get_Key());
			((BindableObject)val12).SetValue(Label.TextProperty, (object)"Small body text");
			((BindableObject)val12).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val12);
			val13.set_Key("Caption");
			XamlServiceProvider val133 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 4];
			array7[0] = val14;
			array7[1] = val106;
			array7[2] = val107;
			array7[3] = designSystemView;
			SimpleValueTargetProvider val134 = new SimpleValueTargetProvider(array7, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj7 = (object)val134;
			val133.Add(typeFromHandle13, (object)val134);
			val133.Add(typeof(IReferenceProvider), obj7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val135 = new XmlNamespaceResolver();
			val135.Add("", "http://xamarin.com/schemas/2014/forms");
			val135.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val135.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val135.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val135.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val135.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val135.Add("constants", "clr-namespace:HomeQuarantine");
			val133.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val135, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val133.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 20)));
			DynamicResource val136 = ((IMarkupExtension<DynamicResource>)(object)val13).ProvideValue((IServiceProvider)val133);
			((IDynamicResourceHandler)val14).SetDynamicResource(VisualElement.StyleProperty, val136.get_Key());
			((BindableObject)val14).SetValue(Label.TextProperty, (object)"Label text");
			((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(16.0, 16.0, 16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val14);
			((BindableObject)val15).SetValue(Label.TextProperty, (object)"Main menu");
			BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
			FontSizeConverter val137 = new FontSizeConverter();
			XamlServiceProvider val138 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 4];
			array8[0] = val15;
			array8[1] = val106;
			array8[2] = val107;
			array8[3] = designSystemView;
			SimpleValueTargetProvider val139 = new SimpleValueTargetProvider(array8, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj8 = (object)val139;
			val138.Add(typeFromHandle15, (object)val139);
			val138.Add(typeof(IReferenceProvider), obj8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val140 = new XmlNamespaceResolver();
			val140.Add("", "http://xamarin.com/schemas/2014/forms");
			val140.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val140.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val140.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val140.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val140.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val140.Add("constants", "clr-namespace:HomeQuarantine");
			val138.Add(typeFromHandle16, (object)new XamlTypeResolver((IXmlNamespaceResolver)val140, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 37)));
			((BindableObject)val15).SetValue(fontSizeProperty2, ((IExtendedTypeConverter)val137).ConvertFromInvariantString("Subtitle", (IServiceProvider)val138));
			((BindableObject)val15).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 8.0));
			((BindableObject)val15).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val15);
			val16.set_Key("faStethoscope");
			XamlServiceProvider val141 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 5];
			array9[0] = buttonMainView;
			array9[1] = val21;
			array9[2] = val106;
			array9[3] = val107;
			array9[4] = designSystemView;
			SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array9, (object)ButtonMainView.IconProperty, (INameScope)(object)val108);
			object obj9 = (object)val142;
			val141.Add(typeFromHandle17, (object)val142);
			val141.Add(typeof(IReferenceProvider), obj9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val143 = new XmlNamespaceResolver();
			val143.Add("", "http://xamarin.com/schemas/2014/forms");
			val143.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val143.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val143.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val143.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val143.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val143.Add("constants", "clr-namespace:HomeQuarantine");
			val141.Add(typeFromHandle18, (object)new XamlTypeResolver((IXmlNamespaceResolver)val143, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 29)));
			object obj10 = (buttonMainView.Icon = (string)((IMarkupExtension)val16).ProvideValue((IServiceProvider)val141));
			((BindableObject)buttonMainView).SetValue(ButtonMainView.TextProperty, (object)homePage_SymptomCheck);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)buttonMainView);
			val17.set_Key("faVials");
			XamlServiceProvider val144 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 5];
			array10[0] = buttonMainView2;
			array10[1] = val21;
			array10[2] = val106;
			array10[3] = val107;
			array10[4] = designSystemView;
			SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array10, (object)ButtonMainView.IconProperty, (INameScope)(object)val108);
			object obj11 = (object)val145;
			val144.Add(typeFromHandle19, (object)val145);
			val144.Add(typeof(IReferenceProvider), obj11);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val146 = new XmlNamespaceResolver();
			val146.Add("", "http://xamarin.com/schemas/2014/forms");
			val146.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val146.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val146.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val146.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val146.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val146.Add("constants", "clr-namespace:HomeQuarantine");
			val144.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val146, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 29)));
			object obj12 = (buttonMainView2.Icon = (string)((IMarkupExtension)val17).ProvideValue((IServiceProvider)val144));
			((BindableObject)buttonMainView2).SetValue(ButtonMainView.TextProperty, (object)homePage_TestingScheduleAndCalendar);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)buttonMainView2);
			val18.set_Key("faHeart");
			XamlServiceProvider val147 = new XamlServiceProvider();
			Type typeFromHandle21 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 5];
			array11[0] = buttonMainView3;
			array11[1] = val21;
			array11[2] = val106;
			array11[3] = val107;
			array11[4] = designSystemView;
			SimpleValueTargetProvider val148 = new SimpleValueTargetProvider(array11, (object)ButtonMainView.IconProperty, (INameScope)(object)val108);
			object obj13 = (object)val148;
			val147.Add(typeFromHandle21, (object)val148);
			val147.Add(typeof(IReferenceProvider), obj13);
			Type typeFromHandle22 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val149 = new XmlNamespaceResolver();
			val149.Add("", "http://xamarin.com/schemas/2014/forms");
			val149.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val149.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val149.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val149.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val149.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val149.Add("constants", "clr-namespace:HomeQuarantine");
			val147.Add(typeFromHandle22, (object)new XamlTypeResolver((IXmlNamespaceResolver)val149, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 30)));
			object obj14 = (buttonMainView3.Icon = (string)((IMarkupExtension)val18).ProvideValue((IServiceProvider)val147));
			((BindableObject)buttonMainView3).SetValue(ButtonMainView.TextProperty, (object)homePage_SupportResources);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)buttonMainView3);
			val19.set_Key("faHouseSignal");
			XamlServiceProvider val150 = new XamlServiceProvider();
			Type typeFromHandle23 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 5];
			array12[0] = buttonMainView4;
			array12[1] = val21;
			array12[2] = val106;
			array12[3] = val107;
			array12[4] = designSystemView;
			SimpleValueTargetProvider val151 = new SimpleValueTargetProvider(array12, (object)ButtonMainView.IconProperty, (INameScope)(object)val108);
			object obj15 = (object)val151;
			val150.Add(typeFromHandle23, (object)val151);
			val150.Add(typeof(IReferenceProvider), obj15);
			Type typeFromHandle24 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val152 = new XmlNamespaceResolver();
			val152.Add("", "http://xamarin.com/schemas/2014/forms");
			val152.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val152.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val152.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val152.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val152.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val152.Add("constants", "clr-namespace:HomeQuarantine");
			val150.Add(typeFromHandle24, (object)new XamlTypeResolver((IXmlNamespaceResolver)val152, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val150.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(45, 30)));
			object obj16 = (buttonMainView4.Icon = (string)((IMarkupExtension)val19).ProvideValue((IServiceProvider)val150));
			((BindableObject)buttonMainView4).SetValue(ButtonMainView.TextProperty, (object)homePage_QuarantineGuidelines);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)buttonMainView4);
			val20.set_Key("faQuestion");
			XamlServiceProvider val153 = new XamlServiceProvider();
			Type typeFromHandle25 = typeof(IProvideValueTarget);
			object[] array13 = new object[0 + 5];
			array13[0] = buttonMainView5;
			array13[1] = val21;
			array13[2] = val106;
			array13[3] = val107;
			array13[4] = designSystemView;
			SimpleValueTargetProvider val154 = new SimpleValueTargetProvider(array13, (object)ButtonMainView.IconProperty, (INameScope)(object)val108);
			object obj17 = (object)val154;
			val153.Add(typeFromHandle25, (object)val154);
			val153.Add(typeof(IReferenceProvider), obj17);
			Type typeFromHandle26 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val155 = new XmlNamespaceResolver();
			val155.Add("", "http://xamarin.com/schemas/2014/forms");
			val155.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val155.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val155.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val155.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val155.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val155.Add("constants", "clr-namespace:HomeQuarantine");
			val153.Add(typeFromHandle26, (object)new XamlTypeResolver((IXmlNamespaceResolver)val155, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val153.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 30)));
			object obj18 = (buttonMainView5.Icon = (string)((IMarkupExtension)val20).ProvideValue((IServiceProvider)val153));
			((BindableObject)buttonMainView5).SetValue(ButtonMainView.TextProperty, (object)homePage_FAQs);
			((Layout<View>)(object)val21).get_Children().Add((View)(object)buttonMainView5);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val21);
			((BindableObject)val22).SetValue(Label.TextProperty, (object)"Button and link styles");
			BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
			FontSizeConverter val156 = new FontSizeConverter();
			XamlServiceProvider val157 = new XamlServiceProvider();
			Type typeFromHandle27 = typeof(IProvideValueTarget);
			object[] array14 = new object[0 + 4];
			array14[0] = val22;
			array14[1] = val106;
			array14[2] = val107;
			array14[3] = designSystemView;
			SimpleValueTargetProvider val158 = new SimpleValueTargetProvider(array14, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj19 = (object)val158;
			val157.Add(typeFromHandle27, (object)val158);
			val157.Add(typeof(IReferenceProvider), obj19);
			Type typeFromHandle28 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val159 = new XmlNamespaceResolver();
			val159.Add("", "http://xamarin.com/schemas/2014/forms");
			val159.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val159.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val159.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val159.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val159.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val159.Add("constants", "clr-namespace:HomeQuarantine");
			val157.Add(typeFromHandle28, (object)new XamlTypeResolver((IXmlNamespaceResolver)val159, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 50)));
			((BindableObject)val22).SetValue(fontSizeProperty3, ((IExtendedTypeConverter)val156).ConvertFromInvariantString("Subtitle", (IServiceProvider)val157));
			((BindableObject)val22).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 8.0));
			((BindableObject)val22).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val22);
			val23.set_Key("LargeButtonStyle");
			XamlServiceProvider val160 = new XamlServiceProvider();
			Type typeFromHandle29 = typeof(IProvideValueTarget);
			object[] array15 = new object[0 + 4];
			array15[0] = val25;
			array15[1] = val106;
			array15[2] = val107;
			array15[3] = designSystemView;
			SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array15, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj20 = (object)val161;
			val160.Add(typeFromHandle29, (object)val161);
			val160.Add(typeof(IReferenceProvider), obj20);
			Type typeFromHandle30 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val162 = new XmlNamespaceResolver();
			val162.Add("", "http://xamarin.com/schemas/2014/forms");
			val162.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val162.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val162.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val162.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val162.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val162.Add("constants", "clr-namespace:HomeQuarantine");
			val160.Add(typeFromHandle30, (object)new XamlTypeResolver((IXmlNamespaceResolver)val162, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(57, 21)));
			DynamicResource val163 = ((IMarkupExtension<DynamicResource>)(object)val23).ProvideValue((IServiceProvider)val160);
			((IDynamicResourceHandler)val25).SetDynamicResource(VisualElement.StyleProperty, val163.get_Key());
			val24.set_Key("TertiaryColor");
			XamlServiceProvider val164 = new XamlServiceProvider();
			Type typeFromHandle31 = typeof(IProvideValueTarget);
			object[] array16 = new object[0 + 4];
			array16[0] = val25;
			array16[1] = val106;
			array16[2] = val107;
			array16[3] = designSystemView;
			SimpleValueTargetProvider val165 = new SimpleValueTargetProvider(array16, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj21 = (object)val165;
			val164.Add(typeFromHandle31, (object)val165);
			val164.Add(typeof(IReferenceProvider), obj21);
			Type typeFromHandle32 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val166 = new XmlNamespaceResolver();
			val166.Add("", "http://xamarin.com/schemas/2014/forms");
			val166.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val166.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val166.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val166.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val166.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val166.Add("constants", "clr-namespace:HomeQuarantine");
			val164.Add(typeFromHandle32, (object)new XamlTypeResolver((IXmlNamespaceResolver)val166, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val164.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(57, 64)));
			DynamicResource val167 = ((IMarkupExtension<DynamicResource>)(object)val24).ProvideValue((IServiceProvider)val164);
			((IDynamicResourceHandler)val25).SetDynamicResource(VisualElement.BackgroundColorProperty, val167.get_Key());
			((BindableObject)val25).SetValue(Button.TextProperty, (object)"Confirm");
			((BindableObject)val25).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val25);
			val26.set_Key("LargeButtonStyle");
			XamlServiceProvider val168 = new XamlServiceProvider();
			Type typeFromHandle33 = typeof(IProvideValueTarget);
			object[] array17 = new object[0 + 4];
			array17[0] = val28;
			array17[1] = val106;
			array17[2] = val107;
			array17[3] = designSystemView;
			SimpleValueTargetProvider val169 = new SimpleValueTargetProvider(array17, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj22 = (object)val169;
			val168.Add(typeFromHandle33, (object)val169);
			val168.Add(typeof(IReferenceProvider), obj22);
			Type typeFromHandle34 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val170 = new XmlNamespaceResolver();
			val170.Add("", "http://xamarin.com/schemas/2014/forms");
			val170.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val170.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val170.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val170.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val170.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val170.Add("constants", "clr-namespace:HomeQuarantine");
			val168.Add(typeFromHandle34, (object)new XamlTypeResolver((IXmlNamespaceResolver)val170, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val168.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 21)));
			DynamicResource val171 = ((IMarkupExtension<DynamicResource>)(object)val26).ProvideValue((IServiceProvider)val168);
			((IDynamicResourceHandler)val28).SetDynamicResource(VisualElement.StyleProperty, val171.get_Key());
			val27.set_Key("PrimaryColor");
			XamlServiceProvider val172 = new XamlServiceProvider();
			Type typeFromHandle35 = typeof(IProvideValueTarget);
			object[] array18 = new object[0 + 4];
			array18[0] = val28;
			array18[1] = val106;
			array18[2] = val107;
			array18[3] = designSystemView;
			SimpleValueTargetProvider val173 = new SimpleValueTargetProvider(array18, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj23 = (object)val173;
			val172.Add(typeFromHandle35, (object)val173);
			val172.Add(typeof(IReferenceProvider), obj23);
			Type typeFromHandle36 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val174 = new XmlNamespaceResolver();
			val174.Add("", "http://xamarin.com/schemas/2014/forms");
			val174.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val174.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val174.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val174.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val174.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val174.Add("constants", "clr-namespace:HomeQuarantine");
			val172.Add(typeFromHandle36, (object)new XamlTypeResolver((IXmlNamespaceResolver)val174, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val172.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 64)));
			DynamicResource val175 = ((IMarkupExtension<DynamicResource>)(object)val27).ProvideValue((IServiceProvider)val172);
			((IDynamicResourceHandler)val28).SetDynamicResource(VisualElement.BackgroundColorProperty, val175.get_Key());
			((BindableObject)val28).SetValue(Button.TextProperty, (object)"Next");
			((BindableObject)val28).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val28);
			val29.set_Key("LargeButtonStyle");
			XamlServiceProvider val176 = new XamlServiceProvider();
			Type typeFromHandle37 = typeof(IProvideValueTarget);
			object[] array19 = new object[0 + 4];
			array19[0] = val31;
			array19[1] = val106;
			array19[2] = val107;
			array19[3] = designSystemView;
			SimpleValueTargetProvider val177 = new SimpleValueTargetProvider(array19, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj24 = (object)val177;
			val176.Add(typeFromHandle37, (object)val177);
			val176.Add(typeof(IReferenceProvider), obj24);
			Type typeFromHandle38 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val178 = new XmlNamespaceResolver();
			val178.Add("", "http://xamarin.com/schemas/2014/forms");
			val178.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val178.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val178.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val178.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val178.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val178.Add("constants", "clr-namespace:HomeQuarantine");
			val176.Add(typeFromHandle38, (object)new XamlTypeResolver((IXmlNamespaceResolver)val178, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val176.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 21)));
			DynamicResource val179 = ((IMarkupExtension<DynamicResource>)(object)val29).ProvideValue((IServiceProvider)val176);
			((IDynamicResourceHandler)val31).SetDynamicResource(VisualElement.StyleProperty, val179.get_Key());
			val30.set_Key("PrimaryColor");
			XamlServiceProvider val180 = new XamlServiceProvider();
			Type typeFromHandle39 = typeof(IProvideValueTarget);
			object[] array20 = new object[0 + 4];
			array20[0] = val31;
			array20[1] = val106;
			array20[2] = val107;
			array20[3] = designSystemView;
			SimpleValueTargetProvider val181 = new SimpleValueTargetProvider(array20, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj25 = (object)val181;
			val180.Add(typeFromHandle39, (object)val181);
			val180.Add(typeof(IReferenceProvider), obj25);
			Type typeFromHandle40 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val182 = new XmlNamespaceResolver();
			val182.Add("", "http://xamarin.com/schemas/2014/forms");
			val182.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val182.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val182.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val182.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val182.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val182.Add("constants", "clr-namespace:HomeQuarantine");
			val180.Add(typeFromHandle40, (object)new XamlTypeResolver((IXmlNamespaceResolver)val182, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val180.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 64)));
			DynamicResource val183 = ((IMarkupExtension<DynamicResource>)(object)val30).ProvideValue((IServiceProvider)val180);
			((IDynamicResourceHandler)val31).SetDynamicResource(VisualElement.BackgroundColorProperty, val183.get_Key());
			((BindableObject)val31).SetValue(Button.TextProperty, (object)"SUBMIT");
			((BindableObject)val31).SetValue(View.MarginProperty, (object)new Thickness(80.0, 0.0, 80.0, 16.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val31);
			val32.set_Key("LargeButtonStyle");
			XamlServiceProvider val184 = new XamlServiceProvider();
			Type typeFromHandle41 = typeof(IProvideValueTarget);
			object[] array21 = new object[0 + 4];
			array21[0] = val34;
			array21[1] = val106;
			array21[2] = val107;
			array21[3] = designSystemView;
			SimpleValueTargetProvider val185 = new SimpleValueTargetProvider(array21, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj26 = (object)val185;
			val184.Add(typeFromHandle41, (object)val185);
			val184.Add(typeof(IReferenceProvider), obj26);
			Type typeFromHandle42 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val186 = new XmlNamespaceResolver();
			val186.Add("", "http://xamarin.com/schemas/2014/forms");
			val186.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val186.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val186.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val186.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val186.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val186.Add("constants", "clr-namespace:HomeQuarantine");
			val184.Add(typeFromHandle42, (object)new XamlTypeResolver((IXmlNamespaceResolver)val186, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val184.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(60, 21)));
			DynamicResource val187 = ((IMarkupExtension<DynamicResource>)(object)val32).ProvideValue((IServiceProvider)val184);
			((IDynamicResourceHandler)val34).SetDynamicResource(VisualElement.StyleProperty, val187.get_Key());
			val33.set_Key("QuartenaryColor");
			XamlServiceProvider val188 = new XamlServiceProvider();
			Type typeFromHandle43 = typeof(IProvideValueTarget);
			object[] array22 = new object[0 + 4];
			array22[0] = val34;
			array22[1] = val106;
			array22[2] = val107;
			array22[3] = designSystemView;
			SimpleValueTargetProvider val189 = new SimpleValueTargetProvider(array22, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj27 = (object)val189;
			val188.Add(typeFromHandle43, (object)val189);
			val188.Add(typeof(IReferenceProvider), obj27);
			Type typeFromHandle44 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val190 = new XmlNamespaceResolver();
			val190.Add("", "http://xamarin.com/schemas/2014/forms");
			val190.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val190.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val190.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val190.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val190.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val190.Add("constants", "clr-namespace:HomeQuarantine");
			val188.Add(typeFromHandle44, (object)new XamlTypeResolver((IXmlNamespaceResolver)val190, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val188.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(60, 64)));
			DynamicResource val191 = ((IMarkupExtension<DynamicResource>)(object)val33).ProvideValue((IServiceProvider)val188);
			((IDynamicResourceHandler)val34).SetDynamicResource(VisualElement.BackgroundColorProperty, val191.get_Key());
			((BindableObject)val34).SetValue(Button.TextProperty, (object)"TRY AGAIN");
			((BindableObject)val34).SetValue(View.MarginProperty, (object)new Thickness(80.0, 0.0, 80.0, 16.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val34);
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.TextProperty, (object)"<Useful resource link>");
			((BindableObject)resourceLinkView).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)resourceLinkView);
			((BindableObject)val35).SetValue(StackLayout.SpacingProperty, (object)16.0);
			((BindableObject)resourceLinkView2).SetValue(ResourceLinkView.TextProperty, (object)"View more information");
			((Layout<View>)(object)val35).get_Children().Add((View)(object)resourceLinkView2);
			((BindableObject)resourceLinkView3).SetValue(ResourceLinkView.TextProperty, (object)"Vaccination");
			((BindableObject)resourceLinkView3).SetValue(ResourceLinkView.IsUrlProperty, (object)true);
			((Layout<View>)(object)val35).get_Children().Add((View)(object)resourceLinkView3);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val35);
			((BindableObject)val37).SetValue(Frame.HasShadowProperty, (object)false);
			val36.set_Key("SecondaryBackgroundColor");
			XamlServiceProvider val192 = new XamlServiceProvider();
			Type typeFromHandle45 = typeof(IProvideValueTarget);
			object[] array23 = new object[0 + 4];
			array23[0] = val37;
			array23[1] = val106;
			array23[2] = val107;
			array23[3] = designSystemView;
			SimpleValueTargetProvider val193 = new SimpleValueTargetProvider(array23, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj28 = (object)val193;
			val192.Add(typeFromHandle45, (object)val193);
			val192.Add(typeof(IReferenceProvider), obj28);
			Type typeFromHandle46 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val194 = new XmlNamespaceResolver();
			val194.Add("", "http://xamarin.com/schemas/2014/forms");
			val194.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val194.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val194.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val194.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val194.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val194.Add("constants", "clr-namespace:HomeQuarantine");
			val192.Add(typeFromHandle46, (object)new XamlTypeResolver((IXmlNamespaceResolver)val194, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val192.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 38)));
			DynamicResource val195 = ((IMarkupExtension<DynamicResource>)(object)val36).ProvideValue((IServiceProvider)val192);
			((IDynamicResourceHandler)val37).SetDynamicResource(VisualElement.BackgroundColorProperty, val195.get_Key());
			((BindableObject)val37).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0, 16.0, 16.0));
			((BindableObject)resourceLinkView4).SetValue(ResourceLinkView.TextProperty, (object)"View home quarantine guidelines");
			((BindableObject)val37).SetValue(ContentView.ContentProperty, (object)resourceLinkView4);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val37);
			((BindableObject)val39).SetValue(Label.TextProperty, (object)"Read notification");
			val38.set_Key("Link");
			XamlServiceProvider val196 = new XamlServiceProvider();
			Type typeFromHandle47 = typeof(IProvideValueTarget);
			object[] array24 = new object[0 + 4];
			array24[0] = val39;
			array24[1] = val106;
			array24[2] = val107;
			array24[3] = designSystemView;
			SimpleValueTargetProvider val197 = new SimpleValueTargetProvider(array24, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj29 = (object)val197;
			val196.Add(typeFromHandle47, (object)val197);
			val196.Add(typeof(IReferenceProvider), obj29);
			Type typeFromHandle48 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val198 = new XmlNamespaceResolver();
			val198.Add("", "http://xamarin.com/schemas/2014/forms");
			val198.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val198.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val198.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val198.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val198.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val198.Add("constants", "clr-namespace:HomeQuarantine");
			val196.Add(typeFromHandle48, (object)new XamlTypeResolver((IXmlNamespaceResolver)val198, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val196.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 45)));
			DynamicResource val199 = ((IMarkupExtension<DynamicResource>)(object)val38).ProvideValue((IServiceProvider)val196);
			((IDynamicResourceHandler)val39).SetDynamicResource(VisualElement.StyleProperty, val199.get_Key());
			((BindableObject)val39).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val39);
			((BindableObject)val41).SetValue(Label.TextProperty, (object)"Close");
			val40.set_Key("Link");
			XamlServiceProvider val200 = new XamlServiceProvider();
			Type typeFromHandle49 = typeof(IProvideValueTarget);
			object[] array25 = new object[0 + 4];
			array25[0] = val41;
			array25[1] = val106;
			array25[2] = val107;
			array25[3] = designSystemView;
			SimpleValueTargetProvider val201 = new SimpleValueTargetProvider(array25, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj30 = (object)val201;
			val200.Add(typeFromHandle49, (object)val201);
			val200.Add(typeof(IReferenceProvider), obj30);
			Type typeFromHandle50 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val202 = new XmlNamespaceResolver();
			val202.Add("", "http://xamarin.com/schemas/2014/forms");
			val202.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val202.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val202.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val202.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val202.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val202.Add("constants", "clr-namespace:HomeQuarantine");
			val200.Add(typeFromHandle50, (object)new XamlTypeResolver((IXmlNamespaceResolver)val202, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val200.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 33)));
			DynamicResource val203 = ((IMarkupExtension<DynamicResource>)(object)val40).ProvideValue((IServiceProvider)val200);
			((IDynamicResourceHandler)val41).SetDynamicResource(VisualElement.StyleProperty, val203.get_Key());
			((BindableObject)val41).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val41);
			val42.set_Key("TertiaryColor");
			XamlServiceProvider val204 = new XamlServiceProvider();
			Type typeFromHandle51 = typeof(IProvideValueTarget);
			object[] array26 = new object[0 + 4];
			array26[0] = val45;
			array26[1] = val106;
			array26[2] = val107;
			array26[3] = designSystemView;
			SimpleValueTargetProvider val205 = new SimpleValueTargetProvider(array26, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj31 = (object)val205;
			val204.Add(typeFromHandle51, (object)val205);
			val204.Add(typeof(IReferenceProvider), obj31);
			Type typeFromHandle52 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val206 = new XmlNamespaceResolver();
			val206.Add("", "http://xamarin.com/schemas/2014/forms");
			val206.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val206.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val206.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val206.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val206.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val206.Add("constants", "clr-namespace:HomeQuarantine");
			val204.Add(typeFromHandle52, (object)new XamlTypeResolver((IXmlNamespaceResolver)val206, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val204.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(76, 26)));
			DynamicResource val207 = ((IMarkupExtension<DynamicResource>)(object)val42).ProvideValue((IServiceProvider)val204);
			((IDynamicResourceHandler)val45).SetDynamicResource(VisualElement.BackgroundColorProperty, val207.get_Key());
			((BindableObject)val45).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 24.0));
			((BindableObject)val44).SetValue(Label.TextProperty, (object)"Resend");
			val43.set_Key("Link");
			XamlServiceProvider val208 = new XamlServiceProvider();
			Type typeFromHandle53 = typeof(IProvideValueTarget);
			object[] array27 = new object[0 + 5];
			array27[0] = val44;
			array27[1] = val45;
			array27[2] = val106;
			array27[3] = val107;
			array27[4] = designSystemView;
			SimpleValueTargetProvider val209 = new SimpleValueTargetProvider(array27, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj32 = (object)val209;
			val208.Add(typeFromHandle53, (object)val209);
			val208.Add(typeof(IReferenceProvider), obj32);
			Type typeFromHandle54 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val210 = new XmlNamespaceResolver();
			val210.Add("", "http://xamarin.com/schemas/2014/forms");
			val210.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val210.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val210.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val210.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val210.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val210.Add("constants", "clr-namespace:HomeQuarantine");
			val208.Add(typeFromHandle54, (object)new XamlTypeResolver((IXmlNamespaceResolver)val210, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val208.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 38)));
			DynamicResource val211 = ((IMarkupExtension<DynamicResource>)(object)val43).ProvideValue((IServiceProvider)val208);
			((IDynamicResourceHandler)val44).SetDynamicResource(VisualElement.StyleProperty, val211.get_Key());
			((BindableObject)val44).SetValue(Label.TextColorProperty, (object)Color.White);
			((Layout<View>)(object)val45).get_Children().Add((View)(object)val44);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val45);
			((BindableObject)val46).SetValue(Label.TextProperty, (object)"Form fields");
			BindableProperty fontSizeProperty4 = Label.FontSizeProperty;
			FontSizeConverter val212 = new FontSizeConverter();
			XamlServiceProvider val213 = new XamlServiceProvider();
			Type typeFromHandle55 = typeof(IProvideValueTarget);
			object[] array28 = new object[0 + 4];
			array28[0] = val46;
			array28[1] = val106;
			array28[2] = val107;
			array28[3] = designSystemView;
			SimpleValueTargetProvider val214 = new SimpleValueTargetProvider(array28, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj33 = (object)val214;
			val213.Add(typeFromHandle55, (object)val214);
			val213.Add(typeof(IReferenceProvider), obj33);
			Type typeFromHandle56 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val215 = new XmlNamespaceResolver();
			val215.Add("", "http://xamarin.com/schemas/2014/forms");
			val215.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val215.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val215.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val215.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val215.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val215.Add("constants", "clr-namespace:HomeQuarantine");
			val213.Add(typeFromHandle56, (object)new XamlTypeResolver((IXmlNamespaceResolver)val215, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val213.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(82, 39)));
			((BindableObject)val46).SetValue(fontSizeProperty4, ((IExtendedTypeConverter)val212).ConvertFromInvariantString("Subtitle", (IServiceProvider)val213));
			((BindableObject)val46).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val46).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val46);
			val47.set_Key("PrimaryColor");
			XamlServiceProvider val216 = new XamlServiceProvider();
			Type typeFromHandle57 = typeof(IProvideValueTarget);
			object[] array29 = new object[0 + 4];
			array29[0] = val49;
			array29[1] = val106;
			array29[2] = val107;
			array29[3] = designSystemView;
			SimpleValueTargetProvider val217 = new SimpleValueTargetProvider(array29, (object)Frame.BorderColorProperty, (INameScope)(object)val108);
			object obj34 = (object)val217;
			val216.Add(typeFromHandle57, (object)val217);
			val216.Add(typeof(IReferenceProvider), obj34);
			Type typeFromHandle58 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val218 = new XmlNamespaceResolver();
			val218.Add("", "http://xamarin.com/schemas/2014/forms");
			val218.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val218.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val218.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val218.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val218.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val218.Add("constants", "clr-namespace:HomeQuarantine");
			val216.Add(typeFromHandle58, (object)new XamlTypeResolver((IXmlNamespaceResolver)val218, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val216.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(83, 20)));
			DynamicResource val219 = ((IMarkupExtension<DynamicResource>)(object)val47).ProvideValue((IServiceProvider)val216);
			((IDynamicResourceHandler)val49).SetDynamicResource(Frame.BorderColorProperty, val219.get_Key());
			((BindableObject)val49).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
			((BindableObject)val49).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val49).SetValue(Frame.CornerRadiusProperty, (object)4f);
			((BindableObject)val49).SetValue(Frame.HasShadowProperty, (object)false);
			((BindableObject)val48).SetValue(Entry.PlaceholderProperty, (object)"Enter your address");
			((BindableObject)val48).SetValue(VisualElement.HeightRequestProperty, (object)60.0);
			((BindableObject)val49).SetValue(ContentView.ContentProperty, (object)val48);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val49);
			((BindableObject)val50).SetValue(Label.TextProperty, (object)"Text Area");
			BindableProperty fontSizeProperty5 = Label.FontSizeProperty;
			FontSizeConverter val220 = new FontSizeConverter();
			XamlServiceProvider val221 = new XamlServiceProvider();
			Type typeFromHandle59 = typeof(IProvideValueTarget);
			object[] array30 = new object[0 + 4];
			array30[0] = val50;
			array30[1] = val106;
			array30[2] = val107;
			array30[3] = designSystemView;
			SimpleValueTargetProvider val222 = new SimpleValueTargetProvider(array30, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj35 = (object)val222;
			val221.Add(typeFromHandle59, (object)val222);
			val221.Add(typeof(IReferenceProvider), obj35);
			Type typeFromHandle60 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val223 = new XmlNamespaceResolver();
			val223.Add("", "http://xamarin.com/schemas/2014/forms");
			val223.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val223.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val223.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val223.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val223.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val223.Add("constants", "clr-namespace:HomeQuarantine");
			val221.Add(typeFromHandle60, (object)new XamlTypeResolver((IXmlNamespaceResolver)val223, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val221.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 37)));
			((BindableObject)val50).SetValue(fontSizeProperty5, ((IExtendedTypeConverter)val220).ConvertFromInvariantString("Subtitle", (IServiceProvider)val221));
			((BindableObject)val50).SetValue(View.MarginProperty, (object)new Thickness(16.0));
			((BindableObject)val50).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val50);
			((BindableObject)textAreaView).SetValue(TextAreaView.MaxLengthProperty, (object)2000);
			((BindableObject)textAreaView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 0.0));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)textAreaView);
			((BindableObject)checkboxLabelView).SetValue(View.MarginProperty, (object)new Thickness(16.0, 24.0, 16.0, 0.0));
			((BindableObject)checkboxLabelView).SetValue(CheckboxLabelView.TextProperty, (object)"During home quarantine, I agree to:\n• self-quarantine in my house\n• have the required COVID tests\n• respond to notifications within set times\n• check-in through this app as required.");
			((Layout<View>)(object)val106).get_Children().Add((View)(object)checkboxLabelView);
			((BindableObject)val51).SetValue(Label.TextProperty, (object)"Accordions");
			BindableProperty fontSizeProperty6 = Label.FontSizeProperty;
			FontSizeConverter val224 = new FontSizeConverter();
			XamlServiceProvider val225 = new XamlServiceProvider();
			Type typeFromHandle61 = typeof(IProvideValueTarget);
			object[] array31 = new object[0 + 4];
			array31[0] = val51;
			array31[1] = val106;
			array31[2] = val107;
			array31[3] = designSystemView;
			SimpleValueTargetProvider val226 = new SimpleValueTargetProvider(array31, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj36 = (object)val226;
			val225.Add(typeFromHandle61, (object)val226);
			val225.Add(typeof(IReferenceProvider), obj36);
			Type typeFromHandle62 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val227 = new XmlNamespaceResolver();
			val227.Add("", "http://xamarin.com/schemas/2014/forms");
			val227.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val227.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val227.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val227.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val227.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val227.Add("constants", "clr-namespace:HomeQuarantine");
			val225.Add(typeFromHandle62, (object)new XamlTypeResolver((IXmlNamespaceResolver)val227, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val225.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(97, 38)));
			((BindableObject)val51).SetValue(fontSizeProperty6, ((IExtendedTypeConverter)val224).ConvertFromInvariantString("Subtitle", (IServiceProvider)val225));
			((BindableObject)val51).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 8.0));
			((BindableObject)val51).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val51);
			((BindableObject)val52).SetValue(Label.TextProperty, (object)"Colours");
			BindableProperty fontSizeProperty7 = Label.FontSizeProperty;
			FontSizeConverter val228 = new FontSizeConverter();
			XamlServiceProvider val229 = new XamlServiceProvider();
			Type typeFromHandle63 = typeof(IProvideValueTarget);
			object[] array32 = new object[0 + 4];
			array32[0] = val52;
			array32[1] = val106;
			array32[2] = val107;
			array32[3] = designSystemView;
			SimpleValueTargetProvider val230 = new SimpleValueTargetProvider(array32, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj37 = (object)val230;
			val229.Add(typeFromHandle63, (object)val230);
			val229.Add(typeof(IReferenceProvider), obj37);
			Type typeFromHandle64 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val231 = new XmlNamespaceResolver();
			val231.Add("", "http://xamarin.com/schemas/2014/forms");
			val231.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val231.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val231.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val231.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val231.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val231.Add("constants", "clr-namespace:HomeQuarantine");
			val229.Add(typeFromHandle64, (object)new XamlTypeResolver((IXmlNamespaceResolver)val231, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val229.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 35)));
			((BindableObject)val52).SetValue(fontSizeProperty7, ((IExtendedTypeConverter)val228).ConvertFromInvariantString("Subtitle", (IServiceProvider)val229));
			((BindableObject)val52).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 8.0));
			((BindableObject)val52).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val52);
			((BindableObject)val70).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val53).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val70).GetValue(Grid.ColumnDefinitionsProperty)).Add(val53);
			((BindableObject)val54).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("AUTO"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val70).GetValue(Grid.ColumnDefinitionsProperty)).Add(val54);
			((BindableObject)val55).SetValue(Label.TextProperty, (object)"Background");
			((BindableObject)val55).SetValue(Grid.RowProperty, (object)0);
			((BindableObject)val55).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val55).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val70.get_Children()).Add((View)(object)val55);
			((BindableObject)val57).SetValue(Grid.RowProperty, (object)0);
			((BindableObject)val57).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val57).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val57).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val57).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val57).SetValue(Frame.HasShadowProperty, (object)false);
			val56.set_Key("BackgroundColor");
			XamlServiceProvider val232 = new XamlServiceProvider();
			Type typeFromHandle65 = typeof(IProvideValueTarget);
			object[] array33 = new object[0 + 5];
			array33[0] = val57;
			array33[1] = val70;
			array33[2] = val106;
			array33[3] = val107;
			array33[4] = designSystemView;
			SimpleValueTargetProvider val233 = new SimpleValueTargetProvider(array33, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj38 = (object)val233;
			val232.Add(typeFromHandle65, (object)val233);
			val232.Add(typeof(IReferenceProvider), obj38);
			Type typeFromHandle66 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val234 = new XmlNamespaceResolver();
			val234.Add("", "http://xamarin.com/schemas/2014/forms");
			val234.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val234.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val234.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val234.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val234.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val234.Add("constants", "clr-namespace:HomeQuarantine");
			val232.Add(typeFromHandle66, (object)new XamlTypeResolver((IXmlNamespaceResolver)val234, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val232.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(107, 125)));
			DynamicResource val235 = ((IMarkupExtension<DynamicResource>)(object)val56).ProvideValue((IServiceProvider)val232);
			((IDynamicResourceHandler)val57).SetDynamicResource(VisualElement.BackgroundColorProperty, val235.get_Key());
			((ICollection<View>)val70.get_Children()).Add((View)(object)val57);
			((BindableObject)val58).SetValue(Label.TextProperty, (object)"Elevated Background");
			((BindableObject)val58).SetValue(Grid.RowProperty, (object)1);
			((BindableObject)val58).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val58).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val70.get_Children()).Add((View)(object)val58);
			((BindableObject)val60).SetValue(Grid.RowProperty, (object)1);
			((BindableObject)val60).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val60).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val60).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val60).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val60).SetValue(Frame.HasShadowProperty, (object)false);
			val59.set_Key("ElevatedBackgroundColor");
			XamlServiceProvider val236 = new XamlServiceProvider();
			Type typeFromHandle67 = typeof(IProvideValueTarget);
			object[] array34 = new object[0 + 5];
			array34[0] = val60;
			array34[1] = val70;
			array34[2] = val106;
			array34[3] = val107;
			array34[4] = designSystemView;
			SimpleValueTargetProvider val237 = new SimpleValueTargetProvider(array34, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj39 = (object)val237;
			val236.Add(typeFromHandle67, (object)val237);
			val236.Add(typeof(IReferenceProvider), obj39);
			Type typeFromHandle68 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val238 = new XmlNamespaceResolver();
			val238.Add("", "http://xamarin.com/schemas/2014/forms");
			val238.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val238.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val238.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val238.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val238.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val238.Add("constants", "clr-namespace:HomeQuarantine");
			val236.Add(typeFromHandle68, (object)new XamlTypeResolver((IXmlNamespaceResolver)val238, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val236.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(109, 125)));
			DynamicResource val239 = ((IMarkupExtension<DynamicResource>)(object)val59).ProvideValue((IServiceProvider)val236);
			((IDynamicResourceHandler)val60).SetDynamicResource(VisualElement.BackgroundColorProperty, val239.get_Key());
			((ICollection<View>)val70.get_Children()).Add((View)(object)val60);
			((BindableObject)val61).SetValue(Label.TextProperty, (object)"Navigation Bar");
			((BindableObject)val61).SetValue(Grid.RowProperty, (object)2);
			((BindableObject)val61).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val61).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val70.get_Children()).Add((View)(object)val61);
			((BindableObject)val63).SetValue(Grid.RowProperty, (object)2);
			((BindableObject)val63).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val63).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val63).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val63).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val63).SetValue(Frame.HasShadowProperty, (object)false);
			val62.set_Key("NavigationBarColor");
			XamlServiceProvider val240 = new XamlServiceProvider();
			Type typeFromHandle69 = typeof(IProvideValueTarget);
			object[] array35 = new object[0 + 5];
			array35[0] = val63;
			array35[1] = val70;
			array35[2] = val106;
			array35[3] = val107;
			array35[4] = designSystemView;
			SimpleValueTargetProvider val241 = new SimpleValueTargetProvider(array35, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj40 = (object)val241;
			val240.Add(typeFromHandle69, (object)val241);
			val240.Add(typeof(IReferenceProvider), obj40);
			Type typeFromHandle70 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val242 = new XmlNamespaceResolver();
			val242.Add("", "http://xamarin.com/schemas/2014/forms");
			val242.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val242.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val242.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val242.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val242.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val242.Add("constants", "clr-namespace:HomeQuarantine");
			val240.Add(typeFromHandle70, (object)new XamlTypeResolver((IXmlNamespaceResolver)val242, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val240.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(111, 125)));
			DynamicResource val243 = ((IMarkupExtension<DynamicResource>)(object)val62).ProvideValue((IServiceProvider)val240);
			((IDynamicResourceHandler)val63).SetDynamicResource(VisualElement.BackgroundColorProperty, val243.get_Key());
			((ICollection<View>)val70.get_Children()).Add((View)(object)val63);
			((BindableObject)val64).SetValue(Label.TextProperty, (object)"Primary Text");
			((BindableObject)val64).SetValue(Grid.RowProperty, (object)3);
			((BindableObject)val64).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val64).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val70.get_Children()).Add((View)(object)val64);
			((BindableObject)val66).SetValue(Grid.RowProperty, (object)3);
			((BindableObject)val66).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val66).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val66).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val66).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val66).SetValue(Frame.HasShadowProperty, (object)false);
			val65.set_Key("PrimaryTextColor");
			XamlServiceProvider val244 = new XamlServiceProvider();
			Type typeFromHandle71 = typeof(IProvideValueTarget);
			object[] array36 = new object[0 + 5];
			array36[0] = val66;
			array36[1] = val70;
			array36[2] = val106;
			array36[3] = val107;
			array36[4] = designSystemView;
			SimpleValueTargetProvider val245 = new SimpleValueTargetProvider(array36, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj41 = (object)val245;
			val244.Add(typeFromHandle71, (object)val245);
			val244.Add(typeof(IReferenceProvider), obj41);
			Type typeFromHandle72 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val246 = new XmlNamespaceResolver();
			val246.Add("", "http://xamarin.com/schemas/2014/forms");
			val246.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val246.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val246.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val246.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val246.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val246.Add("constants", "clr-namespace:HomeQuarantine");
			val244.Add(typeFromHandle72, (object)new XamlTypeResolver((IXmlNamespaceResolver)val246, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val244.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(113, 125)));
			DynamicResource val247 = ((IMarkupExtension<DynamicResource>)(object)val65).ProvideValue((IServiceProvider)val244);
			((IDynamicResourceHandler)val66).SetDynamicResource(VisualElement.BackgroundColorProperty, val247.get_Key());
			((ICollection<View>)val70.get_Children()).Add((View)(object)val66);
			((BindableObject)val67).SetValue(Grid.RowProperty, (object)4);
			((BindableObject)val67).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val67).SetValue(Label.TextProperty, (object)"Secondary Text");
			((BindableObject)val67).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val70.get_Children()).Add((View)(object)val67);
			((BindableObject)val69).SetValue(Grid.RowProperty, (object)4);
			((BindableObject)val69).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val69).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val69).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val69).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val69).SetValue(Frame.HasShadowProperty, (object)false);
			val68.set_Key("SecondaryTextColor");
			XamlServiceProvider val248 = new XamlServiceProvider();
			Type typeFromHandle73 = typeof(IProvideValueTarget);
			object[] array37 = new object[0 + 5];
			array37[0] = val69;
			array37[1] = val70;
			array37[2] = val106;
			array37[3] = val107;
			array37[4] = designSystemView;
			SimpleValueTargetProvider val249 = new SimpleValueTargetProvider(array37, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj42 = (object)val249;
			val248.Add(typeFromHandle73, (object)val249);
			val248.Add(typeof(IReferenceProvider), obj42);
			Type typeFromHandle74 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val250 = new XmlNamespaceResolver();
			val250.Add("", "http://xamarin.com/schemas/2014/forms");
			val250.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val250.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val250.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val250.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val250.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val250.Add("constants", "clr-namespace:HomeQuarantine");
			val248.Add(typeFromHandle74, (object)new XamlTypeResolver((IXmlNamespaceResolver)val250, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val248.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(115, 125)));
			DynamicResource val251 = ((IMarkupExtension<DynamicResource>)(object)val68).ProvideValue((IServiceProvider)val248);
			((IDynamicResourceHandler)val69).SetDynamicResource(VisualElement.BackgroundColorProperty, val251.get_Key());
			((ICollection<View>)val70.get_Children()).Add((View)(object)val69);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val70);
			((BindableObject)val91).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 0.0));
			((BindableObject)val71).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val91).GetValue(Grid.ColumnDefinitionsProperty)).Add(val71);
			((BindableObject)val72).SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("AUTO"));
			((DefinitionCollection<ColumnDefinition>)((BindableObject)val91).GetValue(Grid.ColumnDefinitionsProperty)).Add(val72);
			((BindableObject)val73).SetValue(Label.TextProperty, (object)"Primary");
			((BindableObject)val73).SetValue(Grid.RowProperty, (object)0);
			((BindableObject)val73).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val73).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val91.get_Children()).Add((View)(object)val73);
			((BindableObject)val75).SetValue(Grid.RowProperty, (object)0);
			((BindableObject)val75).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val75).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val75).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val75).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val75).SetValue(Frame.HasShadowProperty, (object)false);
			val74.set_Key("PrimaryColor");
			XamlServiceProvider val252 = new XamlServiceProvider();
			Type typeFromHandle75 = typeof(IProvideValueTarget);
			object[] array38 = new object[0 + 5];
			array38[0] = val75;
			array38[1] = val91;
			array38[2] = val106;
			array38[3] = val107;
			array38[4] = designSystemView;
			SimpleValueTargetProvider val253 = new SimpleValueTargetProvider(array38, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj43 = (object)val253;
			val252.Add(typeFromHandle75, (object)val253);
			val252.Add(typeof(IReferenceProvider), obj43);
			Type typeFromHandle76 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val254 = new XmlNamespaceResolver();
			val254.Add("", "http://xamarin.com/schemas/2014/forms");
			val254.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val254.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val254.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val254.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val254.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val254.Add("constants", "clr-namespace:HomeQuarantine");
			val252.Add(typeFromHandle76, (object)new XamlTypeResolver((IXmlNamespaceResolver)val254, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val252.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(124, 125)));
			DynamicResource val255 = ((IMarkupExtension<DynamicResource>)(object)val74).ProvideValue((IServiceProvider)val252);
			((IDynamicResourceHandler)val75).SetDynamicResource(VisualElement.BackgroundColorProperty, val255.get_Key());
			((ICollection<View>)val91.get_Children()).Add((View)(object)val75);
			((BindableObject)val76).SetValue(Label.TextProperty, (object)"Primary Background");
			((BindableObject)val76).SetValue(Grid.RowProperty, (object)1);
			((BindableObject)val76).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val76).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val91.get_Children()).Add((View)(object)val76);
			((BindableObject)val78).SetValue(Grid.RowProperty, (object)1);
			((BindableObject)val78).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val78).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val78).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val78).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val78).SetValue(Frame.HasShadowProperty, (object)false);
			val77.set_Key("PrimaryBackgroundColor");
			XamlServiceProvider val256 = new XamlServiceProvider();
			Type typeFromHandle77 = typeof(IProvideValueTarget);
			object[] array39 = new object[0 + 5];
			array39[0] = val78;
			array39[1] = val91;
			array39[2] = val106;
			array39[3] = val107;
			array39[4] = designSystemView;
			SimpleValueTargetProvider val257 = new SimpleValueTargetProvider(array39, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj44 = (object)val257;
			val256.Add(typeFromHandle77, (object)val257);
			val256.Add(typeof(IReferenceProvider), obj44);
			Type typeFromHandle78 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val258 = new XmlNamespaceResolver();
			val258.Add("", "http://xamarin.com/schemas/2014/forms");
			val258.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val258.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val258.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val258.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val258.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val258.Add("constants", "clr-namespace:HomeQuarantine");
			val256.Add(typeFromHandle78, (object)new XamlTypeResolver((IXmlNamespaceResolver)val258, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val256.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(126, 125)));
			DynamicResource val259 = ((IMarkupExtension<DynamicResource>)(object)val77).ProvideValue((IServiceProvider)val256);
			((IDynamicResourceHandler)val78).SetDynamicResource(VisualElement.BackgroundColorProperty, val259.get_Key());
			((ICollection<View>)val91.get_Children()).Add((View)(object)val78);
			((BindableObject)val79).SetValue(Label.TextProperty, (object)"Secondary");
			((BindableObject)val79).SetValue(Grid.RowProperty, (object)2);
			((BindableObject)val79).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val79).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val91.get_Children()).Add((View)(object)val79);
			((BindableObject)val81).SetValue(Grid.RowProperty, (object)2);
			((BindableObject)val81).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val81).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val81).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val81).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val81).SetValue(Frame.HasShadowProperty, (object)false);
			val80.set_Key("SecondaryColor");
			XamlServiceProvider val260 = new XamlServiceProvider();
			Type typeFromHandle79 = typeof(IProvideValueTarget);
			object[] array40 = new object[0 + 5];
			array40[0] = val81;
			array40[1] = val91;
			array40[2] = val106;
			array40[3] = val107;
			array40[4] = designSystemView;
			SimpleValueTargetProvider val261 = new SimpleValueTargetProvider(array40, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj45 = (object)val261;
			val260.Add(typeFromHandle79, (object)val261);
			val260.Add(typeof(IReferenceProvider), obj45);
			Type typeFromHandle80 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val262 = new XmlNamespaceResolver();
			val262.Add("", "http://xamarin.com/schemas/2014/forms");
			val262.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val262.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val262.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val262.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val262.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val262.Add("constants", "clr-namespace:HomeQuarantine");
			val260.Add(typeFromHandle80, (object)new XamlTypeResolver((IXmlNamespaceResolver)val262, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val260.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(128, 125)));
			DynamicResource val263 = ((IMarkupExtension<DynamicResource>)(object)val80).ProvideValue((IServiceProvider)val260);
			((IDynamicResourceHandler)val81).SetDynamicResource(VisualElement.BackgroundColorProperty, val263.get_Key());
			((ICollection<View>)val91.get_Children()).Add((View)(object)val81);
			((BindableObject)val82).SetValue(Label.TextProperty, (object)"Secondary Background");
			((BindableObject)val82).SetValue(Grid.RowProperty, (object)3);
			((BindableObject)val82).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val82).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val91.get_Children()).Add((View)(object)val82);
			((BindableObject)val84).SetValue(Grid.RowProperty, (object)3);
			((BindableObject)val84).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val84).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val84).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val84).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val84).SetValue(Frame.HasShadowProperty, (object)false);
			val83.set_Key("SecondaryBackgroundColor");
			XamlServiceProvider val264 = new XamlServiceProvider();
			Type typeFromHandle81 = typeof(IProvideValueTarget);
			object[] array41 = new object[0 + 5];
			array41[0] = val84;
			array41[1] = val91;
			array41[2] = val106;
			array41[3] = val107;
			array41[4] = designSystemView;
			SimpleValueTargetProvider val265 = new SimpleValueTargetProvider(array41, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj46 = (object)val265;
			val264.Add(typeFromHandle81, (object)val265);
			val264.Add(typeof(IReferenceProvider), obj46);
			Type typeFromHandle82 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val266 = new XmlNamespaceResolver();
			val266.Add("", "http://xamarin.com/schemas/2014/forms");
			val266.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val266.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val266.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val266.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val266.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val266.Add("constants", "clr-namespace:HomeQuarantine");
			val264.Add(typeFromHandle82, (object)new XamlTypeResolver((IXmlNamespaceResolver)val266, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val264.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(130, 125)));
			DynamicResource val267 = ((IMarkupExtension<DynamicResource>)(object)val83).ProvideValue((IServiceProvider)val264);
			((IDynamicResourceHandler)val84).SetDynamicResource(VisualElement.BackgroundColorProperty, val267.get_Key());
			((ICollection<View>)val91.get_Children()).Add((View)(object)val84);
			((BindableObject)val85).SetValue(Grid.RowProperty, (object)4);
			((BindableObject)val85).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val85).SetValue(Label.TextProperty, (object)"Tertiary");
			((BindableObject)val85).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val91.get_Children()).Add((View)(object)val85);
			((BindableObject)val87).SetValue(Grid.RowProperty, (object)4);
			((BindableObject)val87).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val87).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val87).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val87).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val87).SetValue(Frame.HasShadowProperty, (object)false);
			val86.set_Key("TertiaryColor");
			XamlServiceProvider val268 = new XamlServiceProvider();
			Type typeFromHandle83 = typeof(IProvideValueTarget);
			object[] array42 = new object[0 + 5];
			array42[0] = val87;
			array42[1] = val91;
			array42[2] = val106;
			array42[3] = val107;
			array42[4] = designSystemView;
			SimpleValueTargetProvider val269 = new SimpleValueTargetProvider(array42, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj47 = (object)val269;
			val268.Add(typeFromHandle83, (object)val269);
			val268.Add(typeof(IReferenceProvider), obj47);
			Type typeFromHandle84 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val270 = new XmlNamespaceResolver();
			val270.Add("", "http://xamarin.com/schemas/2014/forms");
			val270.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val270.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val270.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val270.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val270.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val270.Add("constants", "clr-namespace:HomeQuarantine");
			val268.Add(typeFromHandle84, (object)new XamlTypeResolver((IXmlNamespaceResolver)val270, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val268.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(132, 125)));
			DynamicResource val271 = ((IMarkupExtension<DynamicResource>)(object)val86).ProvideValue((IServiceProvider)val268);
			((IDynamicResourceHandler)val87).SetDynamicResource(VisualElement.BackgroundColorProperty, val271.get_Key());
			((ICollection<View>)val91.get_Children()).Add((View)(object)val87);
			((BindableObject)val88).SetValue(Grid.RowProperty, (object)5);
			((BindableObject)val88).SetValue(Grid.ColumnProperty, (object)0);
			((BindableObject)val88).SetValue(Label.TextProperty, (object)"Tertiary Background");
			((BindableObject)val88).SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			((ICollection<View>)val91.get_Children()).Add((View)(object)val88);
			((BindableObject)val90).SetValue(Grid.RowProperty, (object)5);
			((BindableObject)val90).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val90).SetValue(VisualElement.HeightRequestProperty, (object)5.0);
			((BindableObject)val90).SetValue(VisualElement.WidthRequestProperty, (object)5.0);
			((BindableObject)val90).SetValue(Frame.BorderColorProperty, (object)Color.Gray);
			((BindableObject)val90).SetValue(Frame.HasShadowProperty, (object)false);
			val89.set_Key("TertiaryBackgroundColor");
			XamlServiceProvider val272 = new XamlServiceProvider();
			Type typeFromHandle85 = typeof(IProvideValueTarget);
			object[] array43 = new object[0 + 5];
			array43[0] = val90;
			array43[1] = val91;
			array43[2] = val106;
			array43[3] = val107;
			array43[4] = designSystemView;
			SimpleValueTargetProvider val273 = new SimpleValueTargetProvider(array43, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj48 = (object)val273;
			val272.Add(typeFromHandle85, (object)val273);
			val272.Add(typeof(IReferenceProvider), obj48);
			Type typeFromHandle86 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val274 = new XmlNamespaceResolver();
			val274.Add("", "http://xamarin.com/schemas/2014/forms");
			val274.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val274.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val274.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val274.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val274.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val274.Add("constants", "clr-namespace:HomeQuarantine");
			val272.Add(typeFromHandle86, (object)new XamlTypeResolver((IXmlNamespaceResolver)val274, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val272.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(134, 125)));
			DynamicResource val275 = ((IMarkupExtension<DynamicResource>)(object)val89).ProvideValue((IServiceProvider)val272);
			((IDynamicResourceHandler)val90).SetDynamicResource(VisualElement.BackgroundColorProperty, val275.get_Key());
			((ICollection<View>)val91.get_Children()).Add((View)(object)val90);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val91);
			((BindableObject)val92).SetValue(Label.TextProperty, (object)"Symptoms");
			BindableProperty fontSizeProperty8 = Label.FontSizeProperty;
			FontSizeConverter val276 = new FontSizeConverter();
			XamlServiceProvider val277 = new XamlServiceProvider();
			Type typeFromHandle87 = typeof(IProvideValueTarget);
			object[] array44 = new object[0 + 4];
			array44[0] = val92;
			array44[1] = val106;
			array44[2] = val107;
			array44[3] = designSystemView;
			SimpleValueTargetProvider val278 = new SimpleValueTargetProvider(array44, (object)Label.FontSizeProperty, (INameScope)(object)val108);
			object obj49 = (object)val278;
			val277.Add(typeFromHandle87, (object)val278);
			val277.Add(typeof(IReferenceProvider), obj49);
			Type typeFromHandle88 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val279 = new XmlNamespaceResolver();
			val279.Add("", "http://xamarin.com/schemas/2014/forms");
			val279.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val279.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val279.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val279.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val279.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val279.Add("constants", "clr-namespace:HomeQuarantine");
			val277.Add(typeFromHandle88, (object)new XamlTypeResolver((IXmlNamespaceResolver)val279, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val277.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(137, 36)));
			((BindableObject)val92).SetValue(fontSizeProperty8, ((IExtendedTypeConverter)val276).ConvertFromInvariantString("Subtitle", (IServiceProvider)val277));
			((BindableObject)val92).SetValue(View.MarginProperty, (object)new Thickness(16.0, 32.0, 16.0, 8.0));
			((BindableObject)val92).SetValue(Label.FontAttributesProperty, new FontAttributesConverter().ConvertFromInvariantString("Bold"));
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val92);
			((BindableObject)val99).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0, 0.0));
			val93.set_Key("faThermometerFull");
			XamlServiceProvider val280 = new XamlServiceProvider();
			Type typeFromHandle89 = typeof(IProvideValueTarget);
			object[] array45 = new object[0 + 5];
			array45[0] = symptomView;
			array45[1] = val99;
			array45[2] = val106;
			array45[3] = val107;
			array45[4] = designSystemView;
			SimpleValueTargetProvider val281 = new SimpleValueTargetProvider(array45, (object)SymptomView.IconProperty, (INameScope)(object)val108);
			object obj50 = (object)val281;
			val280.Add(typeFromHandle89, (object)val281);
			val280.Add(typeof(IReferenceProvider), obj50);
			Type typeFromHandle90 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val282 = new XmlNamespaceResolver();
			val282.Add("", "http://xamarin.com/schemas/2014/forms");
			val282.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val282.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val282.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val282.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val282.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val282.Add("constants", "clr-namespace:HomeQuarantine");
			val280.Add(typeFromHandle90, (object)new XamlTypeResolver((IXmlNamespaceResolver)val282, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val280.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(140, 39)));
			object obj51 = (symptomView.Icon = (string)((IMarkupExtension)val93).ProvideValue((IServiceProvider)val280));
			((BindableObject)symptomView).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			((BindableObject)symptomView).SetValue(SymptomView.TextProperty, (object)"Fever or Chills");
			((BindableObject)symptomView).SetValue(Grid.RowProperty, (object)0);
			((BindableObject)symptomView).SetValue(Grid.ColumnProperty, (object)0);
			((ICollection<View>)val99.get_Children()).Add((View)(object)symptomView);
			val94.set_Key("faLungs");
			XamlServiceProvider val283 = new XamlServiceProvider();
			Type typeFromHandle91 = typeof(IProvideValueTarget);
			object[] array46 = new object[0 + 5];
			array46[0] = symptomView2;
			array46[1] = val99;
			array46[2] = val106;
			array46[3] = val107;
			array46[4] = designSystemView;
			SimpleValueTargetProvider val284 = new SimpleValueTargetProvider(array46, (object)SymptomView.IconProperty, (INameScope)(object)val108);
			object obj52 = (object)val284;
			val283.Add(typeFromHandle91, (object)val284);
			val283.Add(typeof(IReferenceProvider), obj52);
			Type typeFromHandle92 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val285 = new XmlNamespaceResolver();
			val285.Add("", "http://xamarin.com/schemas/2014/forms");
			val285.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val285.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val285.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val285.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val285.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val285.Add("constants", "clr-namespace:HomeQuarantine");
			val283.Add(typeFromHandle92, (object)new XamlTypeResolver((IXmlNamespaceResolver)val285, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val283.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(141, 39)));
			object obj53 = (symptomView2.Icon = (string)((IMarkupExtension)val94).ProvideValue((IServiceProvider)val283));
			((BindableObject)symptomView2).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			((BindableObject)symptomView2).SetValue(SymptomView.TextProperty, (object)"Shortness of breath");
			((BindableObject)symptomView2).SetValue(Grid.RowProperty, (object)0);
			((BindableObject)symptomView2).SetValue(Grid.ColumnProperty, (object)1);
			((ICollection<View>)val99.get_Children()).Add((View)(object)symptomView2);
			val95.set_Key("faTired");
			XamlServiceProvider val286 = new XamlServiceProvider();
			Type typeFromHandle93 = typeof(IProvideValueTarget);
			object[] array47 = new object[0 + 5];
			array47[0] = symptomView3;
			array47[1] = val99;
			array47[2] = val106;
			array47[3] = val107;
			array47[4] = designSystemView;
			SimpleValueTargetProvider val287 = new SimpleValueTargetProvider(array47, (object)SymptomView.IconProperty, (INameScope)(object)val108);
			object obj54 = (object)val287;
			val286.Add(typeFromHandle93, (object)val287);
			val286.Add(typeof(IReferenceProvider), obj54);
			Type typeFromHandle94 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val288 = new XmlNamespaceResolver();
			val288.Add("", "http://xamarin.com/schemas/2014/forms");
			val288.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val288.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val288.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val288.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val288.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val288.Add("constants", "clr-namespace:HomeQuarantine");
			val286.Add(typeFromHandle94, (object)new XamlTypeResolver((IXmlNamespaceResolver)val288, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val286.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(142, 39)));
			object obj55 = (symptomView3.Icon = (string)((IMarkupExtension)val95).ProvideValue((IServiceProvider)val286));
			((BindableObject)symptomView3).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			((BindableObject)symptomView3).SetValue(SymptomView.TextProperty, (object)"Fatigue");
			((BindableObject)symptomView3).SetValue(Grid.RowProperty, (object)1);
			((BindableObject)symptomView3).SetValue(Grid.ColumnProperty, (object)0);
			((ICollection<View>)val99.get_Children()).Add((View)(object)symptomView3);
			val96.set_Key("faFrown");
			XamlServiceProvider val289 = new XamlServiceProvider();
			Type typeFromHandle95 = typeof(IProvideValueTarget);
			object[] array48 = new object[0 + 5];
			array48[0] = symptomView4;
			array48[1] = val99;
			array48[2] = val106;
			array48[3] = val107;
			array48[4] = designSystemView;
			SimpleValueTargetProvider val290 = new SimpleValueTargetProvider(array48, (object)SymptomView.IconProperty, (INameScope)(object)val108);
			object obj56 = (object)val290;
			val289.Add(typeFromHandle95, (object)val290);
			val289.Add(typeof(IReferenceProvider), obj56);
			Type typeFromHandle96 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val291 = new XmlNamespaceResolver();
			val291.Add("", "http://xamarin.com/schemas/2014/forms");
			val291.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val291.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val291.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val291.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val291.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val291.Add("constants", "clr-namespace:HomeQuarantine");
			val289.Add(typeFromHandle96, (object)new XamlTypeResolver((IXmlNamespaceResolver)val291, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val289.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(143, 39)));
			object obj57 = (symptomView4.Icon = (string)((IMarkupExtension)val96).ProvideValue((IServiceProvider)val289));
			((BindableObject)symptomView4).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			((BindableObject)symptomView4).SetValue(SymptomView.TextProperty, (object)"Loss of taste or smell");
			((BindableObject)symptomView4).SetValue(Grid.RowProperty, (object)1);
			((BindableObject)symptomView4).SetValue(Grid.ColumnProperty, (object)1);
			((ICollection<View>)val99.get_Children()).Add((View)(object)symptomView4);
			val97.set_Key("faQuestion");
			XamlServiceProvider val292 = new XamlServiceProvider();
			Type typeFromHandle97 = typeof(IProvideValueTarget);
			object[] array49 = new object[0 + 5];
			array49[0] = symptomView5;
			array49[1] = val99;
			array49[2] = val106;
			array49[3] = val107;
			array49[4] = designSystemView;
			SimpleValueTargetProvider val293 = new SimpleValueTargetProvider(array49, (object)SymptomView.IconProperty, (INameScope)(object)val108);
			object obj58 = (object)val293;
			val292.Add(typeFromHandle97, (object)val293);
			val292.Add(typeof(IReferenceProvider), obj58);
			Type typeFromHandle98 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val294 = new XmlNamespaceResolver();
			val294.Add("", "http://xamarin.com/schemas/2014/forms");
			val294.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val294.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val294.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val294.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val294.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val294.Add("constants", "clr-namespace:HomeQuarantine");
			val292.Add(typeFromHandle98, (object)new XamlTypeResolver((IXmlNamespaceResolver)val294, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val292.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(144, 39)));
			object obj59 = (symptomView5.Icon = (string)((IMarkupExtension)val97).ProvideValue((IServiceProvider)val292));
			((BindableObject)symptomView5).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			((BindableObject)symptomView5).SetValue(SymptomView.TextProperty, (object)"Other");
			((BindableObject)symptomView5).SetValue(Grid.RowProperty, (object)2);
			((BindableObject)symptomView5).SetValue(Grid.ColumnProperty, (object)0);
			((ICollection<View>)val99.get_Children()).Add((View)(object)symptomView5);
			val98.set_Key("faSmile");
			XamlServiceProvider val295 = new XamlServiceProvider();
			Type typeFromHandle99 = typeof(IProvideValueTarget);
			object[] array50 = new object[0 + 5];
			array50[0] = symptomView6;
			array50[1] = val99;
			array50[2] = val106;
			array50[3] = val107;
			array50[4] = designSystemView;
			SimpleValueTargetProvider val296 = new SimpleValueTargetProvider(array50, (object)SymptomView.IconProperty, (INameScope)(object)val108);
			object obj60 = (object)val296;
			val295.Add(typeFromHandle99, (object)val296);
			val295.Add(typeof(IReferenceProvider), obj60);
			Type typeFromHandle100 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val297 = new XmlNamespaceResolver();
			val297.Add("", "http://xamarin.com/schemas/2014/forms");
			val297.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val297.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val297.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val297.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val297.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val297.Add("constants", "clr-namespace:HomeQuarantine");
			val295.Add(typeFromHandle100, (object)new XamlTypeResolver((IXmlNamespaceResolver)val297, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val295.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(145, 39)));
			object obj61 = (symptomView6.Icon = (string)((IMarkupExtension)val98).ProvideValue((IServiceProvider)val295));
			((BindableObject)symptomView6).SetValue(SymptomView.IconFontFamilyProperty, (object)"FA-R");
			((BindableObject)symptomView6).SetValue(SymptomView.TextProperty, (object)"None of the above");
			((BindableObject)symptomView6).SetValue(Grid.RowProperty, (object)2);
			((BindableObject)symptomView6).SetValue(Grid.ColumnProperty, (object)1);
			((ICollection<View>)val99.get_Children()).Add((View)(object)symptomView6);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val99);
			((BindableObject)val105).SetValue(Layout.PaddingProperty, (object)new Thickness(16.0));
			((BindableObject)val104).SetValue(StackLayout.SpacingProperty, (object)0.0);
			val100.set_Key("LargeButtonStyle");
			XamlServiceProvider val298 = new XamlServiceProvider();
			Type typeFromHandle101 = typeof(IProvideValueTarget);
			object[] array51 = new object[0 + 6];
			array51[0] = val103;
			array51[1] = val104;
			array51[2] = val105;
			array51[3] = val106;
			array51[4] = val107;
			array51[5] = designSystemView;
			SimpleValueTargetProvider val299 = new SimpleValueTargetProvider(array51, (object)VisualElement.StyleProperty, (INameScope)(object)val108);
			object obj62 = (object)val299;
			val298.Add(typeFromHandle101, (object)val299);
			val298.Add(typeof(IReferenceProvider), obj62);
			Type typeFromHandle102 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val300 = new XmlNamespaceResolver();
			val300.Add("", "http://xamarin.com/schemas/2014/forms");
			val300.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val300.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val300.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val300.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val300.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val300.Add("constants", "clr-namespace:HomeQuarantine");
			val298.Add(typeFromHandle102, (object)new XamlTypeResolver((IXmlNamespaceResolver)val300, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val298.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(151, 29)));
			DynamicResource val301 = ((IMarkupExtension<DynamicResource>)(object)val100).ProvideValue((IServiceProvider)val298);
			((IDynamicResourceHandler)val103).SetDynamicResource(VisualElement.StyleProperty, val301.get_Key());
			val101.set_Key("TertiaryColor");
			XamlServiceProvider val302 = new XamlServiceProvider();
			Type typeFromHandle103 = typeof(IProvideValueTarget);
			object[] array52 = new object[0 + 6];
			array52[0] = val103;
			array52[1] = val104;
			array52[2] = val105;
			array52[3] = val106;
			array52[4] = val107;
			array52[5] = designSystemView;
			SimpleValueTargetProvider val303 = new SimpleValueTargetProvider(array52, (object)VisualElement.BackgroundColorProperty, (INameScope)(object)val108);
			object obj63 = (object)val303;
			val302.Add(typeFromHandle103, (object)val303);
			val302.Add(typeof(IReferenceProvider), obj63);
			Type typeFromHandle104 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val304 = new XmlNamespaceResolver();
			val304.Add("", "http://xamarin.com/schemas/2014/forms");
			val304.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val304.Add("local", "clr-namespace:HomeQuarantine.Views.Base");
			val304.Add("controls", "clr-namespace:HomeQuarantine.Controls");
			val304.Add("properties", "clr-namespace:HomeQuarantine.Data.Resources.Languages;assembly=HomeQuarantine.Data");
			val304.Add("viewModelBase", "clr-namespace:HomeQuarantine.ViewModels.Base;assembly=HomeQuarantine");
			val304.Add("constants", "clr-namespace:HomeQuarantine");
			val302.Add(typeFromHandle104, (object)new XamlTypeResolver((IXmlNamespaceResolver)val304, typeof(DesignSystemView).GetTypeInfo().Assembly));
			val302.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(152, 29)));
			DynamicResource val305 = ((IMarkupExtension<DynamicResource>)(object)val101).ProvideValue((IServiceProvider)val302);
			((IDynamicResourceHandler)val103).SetDynamicResource(VisualElement.BackgroundColorProperty, val305.get_Key());
			((BindableObject)val103).SetValue(Button.TextProperty, (object)"Open Onboarding Help View");
			val102.set_Path("OpenOnboardingHelpCommand");
			BindingBase val306 = ((IMarkupExtension<BindingBase>)(object)val102).ProvideValue((IServiceProvider)null);
			((BindableObject)val103).SetBinding(Button.CommandProperty, val306);
			((BindableObject)val103).SetValue(View.MarginProperty, (object)new Thickness(0.0, 32.0, 0.0, 16.0));
			((Layout<View>)(object)val104).get_Children().Add((View)(object)val103);
			((Layout<View>)(object)val105).get_Children().Add((View)(object)val104);
			((Layout<View>)(object)val106).get_Children().Add((View)(object)val105);
			val107.set_Content((View)(object)val106);
			((BindableObject)designSystemView).SetValue(ContentPage.ContentProperty, (object)val107);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<DesignSystemView>(this, typeof(DesignSystemView));
			containingView = NameScopeExtensions.FindByName<StackLayout>((Element)(object)this, "containingView");
			openHelpButton = NameScopeExtensions.FindByName<Button>((Element)(object)this, "openHelpButton");
		}
	}
}
