using System.CodeDom.Compiler;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace HomeQuarantine.Themes
{
	[XamlFilePath("Themes/Icons.xaml")]
	public class Icons : ResourceDictionary
	{
		public Icons()
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
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Expected O, but got Unknown
			if (ResourceLoader.get_IsEnabled())
			{
				ResourceLoadingQuery val = new ResourceLoadingQuery();
				val.set_AssemblyName(typeof(Icons).GetTypeInfo().Assembly.GetName());
				val.set_ResourcePath("Themes/Icons.xaml");
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
			string text = "\uf058";
			string text2 = "\uf057";
			string text3 = "\uf2c2";
			string text4 = "\uf10b";
			string text5 = "\uf084";
			string text6 = "\uf029";
			string text7 = "\uf35d";
			string text8 = "\uf2f6";
			string text9 = "\uf2f5";
			string text10 = "\uf030";
			string text11 = "\uf577";
			string text12 = "\uf133";
			string text13 = "\uf124";
			string text14 = "\uf1ab";
			string text15 = "\uf031";
			string text16 = "\uf028";
			string text17 = "\uf887";
			string text18 = "\uf0f3";
			string text19 = "\uf067";
			string text20 = "\uf068";
			string text21 = "\uf0f1";
			string text22 = "\uf493";
			string text23 = "\uf319";
			string text24 = "\uf023";
			string text25 = "\ue065";
			string text26 = "\uf128";
			string text27 = "\uf054";
			string text28 = "\uf35d";
			string text29 = "\uf111";
			string text30 = "\uf2c7";
			string text31 = "\uf604";
			string text32 = "\uf5c8";
			string text33 = "\uf118";
			string text34 = "\uf119";
			string text35 = "\uf3c5";
			string text36 = "\uf004";
			string text37 = "\ue012";
			string text38 = "\uf059";
			string text39 = "\uf4fc";
			string text40 = "\ue061";
			string text41 = "\uf2e7";
			string text42 = "\uf043";
			string text43 = "\uf72e";
			string text44 = "\uf140";
			string text45 = "\uf095";
			string text46 = "\uf108";
			string text47 = "\uf00c";
			string text48 = "\uf061";
			NameScope val2 = new NameScope();
			((ResourceDictionary)this).Add("faCheckCircle", (object)text);
			((ResourceDictionary)this).Add("faTimesCircle", (object)text2);
			((ResourceDictionary)this).Add("faIdCard", (object)text3);
			((ResourceDictionary)this).Add("faMobile", (object)text4);
			((ResourceDictionary)this).Add("faKey", (object)text5);
			((ResourceDictionary)this).Add("faQrCode", (object)text6);
			((ResourceDictionary)this).Add("faExternalLinkAlt", (object)text7);
			((ResourceDictionary)this).Add("faSignInAlt", (object)text8);
			((ResourceDictionary)this).Add("faSignOutAlt", (object)text9);
			((ResourceDictionary)this).Add("faCamera", (object)text10);
			((ResourceDictionary)this).Add("faFingerprint", (object)text11);
			((ResourceDictionary)this).Add("faCalendar", (object)text12);
			((ResourceDictionary)this).Add("faLocation", (object)text13);
			((ResourceDictionary)this).Add("faLanguage", (object)text14);
			((ResourceDictionary)this).Add("faFont", (object)text15);
			((ResourceDictionary)this).Add("faVolumeUp", (object)text16);
			((ResourceDictionary)this).Add("faVersion", (object)text17);
			((ResourceDictionary)this).Add("faNotify", (object)text18);
			((ResourceDictionary)this).Add("faPlus", (object)text19);
			((ResourceDictionary)this).Add("faMinus", (object)text20);
			((ResourceDictionary)this).Add("faStethoscope", (object)text21);
			((ResourceDictionary)this).Add("faVials", (object)text22);
			((ResourceDictionary)this).Add("faFilePlus", (object)text23);
			((ResourceDictionary)this).Add("faLock", (object)text24);
			((ResourceDictionary)this).Add("faHouseUser", (object)text25);
			((ResourceDictionary)this).Add("faQuestion", (object)text26);
			((ResourceDictionary)this).Add("faChevronRight", (object)text27);
			((ResourceDictionary)this).Add("faExternalLink", (object)text28);
			((ResourceDictionary)this).Add("faCircle", (object)text29);
			((ResourceDictionary)this).Add("faThermometerFull", (object)text30);
			((ResourceDictionary)this).Add("faLungs", (object)text31);
			((ResourceDictionary)this).Add("faTired", (object)text32);
			((ResourceDictionary)this).Add("faSmile", (object)text33);
			((ResourceDictionary)this).Add("faFrown", (object)text34);
			((ResourceDictionary)this).Add("faMapMarkerAlt", (object)text35);
			((ResourceDictionary)this).Add("faHeart", (object)text36);
			((ResourceDictionary)this).Add("faHouseSignal", (object)text37);
			((ResourceDictionary)this).Add("faQuestionCircle", (object)text38);
			((ResourceDictionary)this).Add("faUsercheck", (object)text39);
			((ResourceDictionary)this).Add("faHeadside", (object)text40);
			((ResourceDictionary)this).Add("faUtensils", (object)text41);
			((ResourceDictionary)this).Add("faTint", (object)text42);
			((ResourceDictionary)this).Add("faWind", (object)text43);
			((ResourceDictionary)this).Add("faBullseye", (object)text44);
			((ResourceDictionary)this).Add("faPhone", (object)text45);
			((ResourceDictionary)this).Add("faDesktop", (object)text46);
			((ResourceDictionary)this).Add("faCheck", (object)text47);
			((ResourceDictionary)this).Add("faArrowRight", (object)text48);
		}

		private void __InitComponentRuntime()
		{
			Extensions.LoadFromXaml<Icons>(this, typeof(Icons));
		}
	}
}
