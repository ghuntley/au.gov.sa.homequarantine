using System;
using System.Collections.Generic;
using System.Windows.Input;
using HomeQuarantine.Data.Models;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;
using HomeQuarantine.Helpers;
using HomeQuarantine.Interfaces;
using HomeQuarantine.Services.Dependency;
using HomeQuarantine.Services.Navigation;
using HomeQuarantine.Services.OpenUrl;
using HomeQuarantine.Services.Permissions;
using HomeQuarantine.ViewModels;
using HomeQuarantine.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HomeQuarantine
{
	public class Constants
	{
		public const string MainViewTitle = "Home Quarantine";

		public const int TabletHorizontalMargin = 152;

		public const int TabletVerticalMargin = 80;

		public const string APIMEndpoint = "https://public.api.sa.gov.au/home-quarantine";

		public const string SymptomCheckApi = "https://public.api.sa.gov.au/home-quarantine/symptom-check";

		public const string OnboardingValidateUICApi = "https://public.api.sa.gov.au/home-quarantine/onboarding";

		public const string QuarantineStatusApi = "https://public.api.sa.gov.au/home-quarantine/quarantine-status";

		public const string AddressExpApi = "https://public.api.sa.gov.au/home-quarantine/address";

		public const string RegisterDeviceApi = "https://public.api.sa.gov.au/home-quarantine/device-id";

		public const string TestingScheduleApi = "https://public.api.sa.gov.au/home-quarantine/schedule";

		public const string VersionApi = "https://public.api.sa.gov.au/home-quarantine/version";

		public const string NotificationsApi = "https://public.api.sa.gov.au/home-quarantine/notifications";

		public const string ComplianceCheckApi = "https://public.api.sa.gov.au/home-quarantine/compliance";

		public const string IProovVerificationApi = "https://idp-facial-verification.auth.sa.gov.au";

		public const string IProovVerificationUrl = "https://au.rp.secure.iproov.me/";

		public const string ResourceName = "HomeQuarantineApp";

		public const string NotificationHubConnectionString = "Endpoint=sb://dpc-hqt-nhns-prod-aue-001.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=BFmYF54QZyBy6wsNl5iLkz/EQmN1kSCm958uCqqxbnU=";

		public const string NotificationHubName = "dpc-hqt-nh-prod-aue-001";

		public const string AuthRealm = "sagov-idx";

		public const string AuthEndpoint = "https://identity.sa.gov.au/auth";

		public const string AuthClientId = "sagov-home-quarantine-43130474";

		public const int RefreshTimeoutModifer = 1;

		public const int RefreshSecondsExpiry = 10;

		public const int RedirectTimeInMilliSeconds = 2000;

		public const string CallbackUrl = "homequarantine://authorize";

		public const string AppCenteriOSConnection = "d5ae35e6-fa9a-4eca-84b4-dc4dc8482693";

		public const string AppCenterAndroidConnection = "37bf793f-4256-4602-ab11-f1e0e9a4702d";

		public const string MentalHealthSupportUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29#scrollTo-Mentalhealthsupport4";

		public const string UsingTechnologyToStayConnectedUrl = "https://openyourworld.sa.gov.au/connect-with-others/using-technology-to-stay-connected";

		public const string StayingActiveAndHealthyUrl = "https://openyourworld.sa.gov.au/stay-active-and-healthy/staying-active";

		public const string MindfulnessUrl = "https://openyourworld.sa.gov.au/looking-after-you-your-family/mindfulness";

		public const string ServicesAndSupportUrl = "https://openyourworld.sa.gov.au/looking-after-you-your-family/services-and-support";

		public const string TestingLocationsUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/testing+and+tracing/covid-19+clinics+and+testing+centres/covid-19+clinics+and+testing+centres";

		public const string VaccinationUrl = " https://www.covid-19.sa.gov.au/vaccination";

		public const string SACovid19Url = "https://www.covid-19.sa.gov.au/";

		public const string Covid19HealthAlertsUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/latest+updates/latest+updates+on+covid-19";

		public const string Covid19HealthResourcesUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/help+and+advice/translated+covid-19+resources/translated+covid-19+resources?mr-sort=title-asc&mr-pg=1";

		public const string SAhealthAdviceUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29";

		public const string PrivacyPolicyUrl = "https://covid-19.sa.gov.au/hqprivacy";

		public const string TranslatingOrInterpretingServicesUrl = "https://translate.sa.gov.au/";

		public const string HealthDirectUrl = "https://www.healthdirect.gov.au/";

		public const string CrimeStopperUrl = "https://crimestopperssa.com.au/download-the-app/";

		public const string MakeAReportOnlineUrl = "https://crimestopperssa.com.au/";

		public const string LifelineUrl = "https://www.lifeline.org.au/about/our-services/";

		public const string KidsHelplineUrl = "https://kidshelpline.com.au/";

		public const string WhiteRibbonUrl = "https://www.whiteribbon.org.au/";

		public const string HeadspaceUrl = "https://headspace.org.au/";

		public const string BeyondBlueUrl = "https://www.beyondblue.org.au/";

		public const string ASKPEACEUrl = "https://www.rasa.org.au/services/couples-families/askpeace/";

		public const string OnlinechatUrl = "https://www.lifeline.org.au/crisis-text/";

		public const string WebchatBeyondBlueUrl = "https://online.beyondblue.org.au/WebModules/Chat/InitialInformation.aspx";

		public const string EmailBeyondBlueUrl = "https://online.beyondblue.org.au/WebModules/Email/InitialInformation.aspx";

		public const string ThirilliUrl = "https://thirrili.com.au/";

		public const string TripleZeroUrl = "https://www.triplezero.gov.au/";

		public const string KidsQuarantineLinkUrl = "https://kidshelpline.com.au/teens/issues/covid-19-quarantine-isolation-and-lockdown";

		public const string MentalHealthTriageUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/services/mental+health+and+drug+and+alcohol+services/mental+health+services/mental+health+services";

		public const string SwitchOffLocationIphoneUrl = "https://support.apple.com/en-au/HT207092";

		public const string SwitchOffLocationAndroidUrl = "https://support.google.com/accounts/answer/6179507?hl=en";

		public const string SwitchOffNotificationIphoneUrl = "https://support.apple.com/en-au/guide/iphone/iph7c3d96bab/ios";

		public const string SwitchOffNotificationAndroidUrl = "https://support.google.com/android/answer/9079661?hl=en#:~:text=To%20find%20your%20notifications%2C%20from,all%20notifications%2C%20tap%20Notifications%20off";

		public const string SettingUpYourHomeUrl = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29#scrollTo-Wheretoself-isolate/self-quarantine16";

		public const string FinancialEligibilityUrl = "https://www.covid-19.sa.gov.au/school-and-community/financial-support-for-individuals";

		public const string SACovid19MentalHealthSupportLineWebsiteUrl = "https://www.unitingcommunities.org/service/counselling/crisis-support/sa-covid-support-line";

		public const int MinCharactersForOtherDescription = 3;

		public const int MaxCharactersForOtherDescription = 500;

		public const bool HealthReferenceIDSuccess = true;

		public const string SymptomSuccess = "SUCCESS";

		public const int ValidatingTimer = 800;

		public const int ValidatedTimer = 2000;

		public const double NotificationHeight = 180.0;

		public const double NotificationWidth = 600.0;

		public const double NotificationPadding = 56.0;

		public const string AppleStorePage = "https://apps.apple.com/au/app/sa-home-quarantine/id1567354245";

		public const string GoogleStorePage = "https://play.google.com/store/apps/details?id=au.gov.sa.homequarantine";

		public Dictionary<OnboardingType, OnboardingContent> OnboardingContent { get; } = new Dictionary<OnboardingType, OnboardingContent>
		{
			{
				OnboardingType.Address,
				new OnboardingContent
				{
					Header = Resources.OnboardingView_Address_Header,
					Text = Resources.OnboardingView_Address_Description,
					ButtonText = Resources.OnboardingView_Address_Button,
					Colour = ColorHelper.GetResourceValue("PrimaryColor"),
					AddressHelpPage = Resources.OnboardingView_Address_HelpPage,
					ImageSource = "OnBoardingAddress"
				}
			},
			{
				OnboardingType.PushNotifications,
				new OnboardingContent
				{
					Header = Resources.OnboardingView_PushNotifications_Header,
					Text = Resources.OnboardingView_PushNotifications_Description,
					ButtonText = Resources.OnboardingView_PushNotifications_Button,
					Colour = ColorHelper.GetResourceValue("PrimaryColor"),
					ImageSource = "OnBoardingPushNotifications"
				}
			},
			{
				OnboardingType.LocationServices,
				new OnboardingContent
				{
					Header = Resources.OnboardingView_LocationServices_Header,
					Text = Resources.OnboardingView_LocationServices_Description,
					ButtonText = Resources.OnboardingView_LocationServices_Button,
					Colour = ColorHelper.GetResourceValue("PrimaryColor"),
					ImageSource = "OnBoardingLocationServices"
				}
			},
			{
				OnboardingType.CameraServices,
				new OnboardingContent
				{
					Header = Resources.OnboardingView_CameraServices_Header,
					Text = Resources.OnboardingView_CameraServicesContent,
					ButtonText = Resources.OnboardingView_CameraServices_Button,
					Colour = ColorHelper.GetResourceValue("PrimaryColor"),
					ImageSource = "OnboardingCameraAccess"
				}
			},
			{
				OnboardingType.TestResultsAndSchedule,
				new OnboardingContent
				{
					Header = Resources.OnboardingView_TestResults_Header,
					Text = Resources.OnboardingView_TestResults_Description,
					ButtonText = Resources.OnboardingView_TestResults_Button,
					Colour = ColorHelper.GetResourceValue("PrimaryColor"),
					ImageSource = "OnBoardingTestResults"
				}
			},
			{
				OnboardingType.MonitoringSymptoms,
				new OnboardingContent
				{
					Header = Resources.OnboardingView_Monitoring_Header,
					Text = Resources.OnboardingView_Monitoring_Description,
					ButtonText = Resources.OnboardingView_Monitoring_Button,
					Colour = ColorHelper.GetResourceValue("TertiaryColor"),
					ImageSource = "OnBoardingMonitoring"
				}
			}
		};


		public OnboardingHelpViewModel PushNotificationsHelpViewModel { get; } = new OnboardingHelpViewModel(ViewModelLocator.Resolve<INavigationService>())
		{
			Title = Resources.OnboardingHelpView_NotificationsDisabled,
			Descriptions = new List<string>
			{
				Resources.OnboardingHelpView_NotificationsAreAnEssentialPart,
				Resources.OnboardingHelpView_NotificationsToContinueHomeQuarantine
			},
			ImageSource = "OnBoardingHelp",
			ButtonCommand = (ICommand)new Command((Action)delegate
			{
				ViewModelLocator.Resolve<IDependencyService>().Get<IAppSettingsService>().OpenAppSettings();
			}),
			ButtonText = Resources.OnboardingHelpView_ChangeNotificationSettings,
			ButtonColour = ColorHelper.GetResourceValue("QuartenaryColor"),
			IsPermissionGranted = async () => await ViewModelLocator.Resolve<IPermissionsService>().AreNotificationsAllowed(),
			AfterClosed = async () => await ViewModelLocator.Resolve<IPermissionsService>().LaunchPermissionAlertsIfDisabled()
		};


		public OnboardingHelpViewModel LocationServicesHelpViewModel { get; } = new OnboardingHelpViewModel(ViewModelLocator.Resolve<INavigationService>())
		{
			Title = Resources.OnboardingHelpView_LocationServicesDisabled,
			Descriptions = new List<string>
			{
				Resources.OnboardingHelpView_LocationServicesAreAnEssentialPart,
				Resources.OnboardingHelpView_ToContinueHomeQuarantine
			},
			ImageSource = "OnBoardingHelp",
			ButtonCommand = (ICommand)new Command((Action)delegate
			{
				ViewModelLocator.Resolve<IDependencyService>().Get<IAppSettingsService>().OpenAppSettings();
			}),
			ButtonText = Resources.OnboardingHelpView_ChangeLocationSettings,
			ButtonColour = ColorHelper.GetResourceValue("QuartenaryColor"),
			IsPermissionGranted = async () => await ViewModelLocator.Resolve<IPermissionsService>().IsLocationPermissionAllowed(),
			AfterClosed = async () => await ViewModelLocator.Resolve<IPermissionsService>().LaunchPermissionAlertsIfDisabled()
		};


		public OnboardingHelpViewModel CameraServicesHelpViewModel { get; } = new OnboardingHelpViewModel(ViewModelLocator.Resolve<INavigationService>())
		{
			Title = Resources.OnboardingHelpView_CameraServicesDisabled,
			Descriptions = new List<string>
			{
				Resources.OnboardingHelpView_CameraServicesAreAnEssentialPart,
				Resources.OnboardingHelpView_ToContinueCameraHomeQuarantine
			},
			ImageSource = "OnBoardingHelp",
			ButtonCommand = (ICommand)new Command((Action)delegate
			{
				ViewModelLocator.Resolve<IDependencyService>().Get<IAppSettingsService>().OpenAppSettings();
			}),
			ButtonText = Resources.OnboardingHelpView_ChangeCameraSettings,
			ButtonColour = ColorHelper.GetResourceValue("QuartenaryColor"),
			IsPermissionGranted = async () => await ViewModelLocator.Resolve<IPermissionsService>().IsCameraPermissionAllowed(),
			AfterClosed = async () => await ViewModelLocator.Resolve<IPermissionsService>().LaunchPermissionAlertsIfDisabled()
		};


		public NotificationDetailsViewModel WelcomeNotificationViewModel { get; } = new NotificationDetailsViewModel(ViewModelLocator.Resolve<INavigationService>())
		{
			Title = Resources.NotificationDetails_Title,
			Content = new List<string> { Resources.NotificationDetails_SubDetailsDescription },
			Color = ColorHelper.GetResourceValue("PrimaryColor"),
			InformationTitle = Resources.NotificationDetails_Heading,
			InformationContent = new List<string>
			{
				Resources.NotificationDetails_HeadingDescription,
				Resources.NotificationDetails_HeadingSubDescription
			},
			Links = new List<ResourceLinkModel>
			{
				new ResourceLinkModel
				{
					Label = Resources.NotificationDetails_ResourceLinkViewInformationButton,
					IsUrl = false,
					OnTapCommand = new AsyncCommand(async delegate
					{
						await ViewModelLocator.Resolve<INavigationService>().NavigateToAsync(null, App.Constants.GuidelinesPage);
					})
				},
				new ResourceLinkModel
				{
					Label = Resources.NotificationDetails_ResourceLinkViewInterpretingButton,
					IsUrl = true,
					Url = "https://translate.sa.gov.au/"
				},
				new ResourceLinkModel
				{
					Label = Resources.NotificationDetails_ResourceLinkCovid19Button,
					IsUrl = true,
					Url = "https://www.covid-19.sa.gov.au/"
				},
				new ResourceLinkModel
				{
					Label = Resources.NoSymptomView_Mindfulness,
					IsUrl = true,
					Url = "https://openyourworld.sa.gov.au/looking-after-you-your-family/mindfulness"
				},
				new ResourceLinkModel
				{
					Label = Resources.NoSymptomView_ServiceandSupport,
					IsUrl = true,
					Url = "https://openyourworld.sa.gov.au/looking-after-you-your-family/services-and-support"
				}
			}
		};


		public ErrorViewModel ConnectionErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_ConnectionTitle,
			SubTitle = Resources.ErrorHandling_ConnectionDescription,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason
			},
			Suggestion = Resources.ErrorHandling_ConnectionSuggestion
		};


		public ErrorViewModel SymptomErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_SymptomTitle,
			SubTitle = Resources.ErrorHandling_SymptomSubTitle,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason
			}
		};


		public ErrorViewModel LocationCheckInErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_LocationCheckInTitle,
			SubTitle = Resources.ErrorHandling_LocationCheckInSubTitle,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason,
				Resources.ErrorHandling_ReasonLocation
			}
		};


		public ErrorViewModel ReferenceIDErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_ReferenceIDTitle,
			SubTitle = Resources.ErrorHandling_ReferenceIDSubTitle,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason,
				Resources.ErrorHandling_ReferenceIDWrong
			}
		};


		public ErrorViewModel AddressErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_AddressTitle,
			SubTitle = Resources.ErrorHandling_AddressSubTitle,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason
			}
		};


		public ErrorViewModel LoginErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_LoginTitle,
			SubTitle = Resources.ErrorHandling_LoginSubTitle,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason
			}
		};


		public OnboardingHelpViewModel AppVersionExpiredViewModel { get; } = new OnboardingHelpViewModel(ViewModelLocator.Resolve<INavigationService>())
		{
			Title = Resources.AppVersion_Expired_Title,
			Descriptions = new List<string> { Resources.AppVersion_Expired_Message },
			ImageSource = "AppVersionOutdated",
			ButtonCommand = (ICommand)new Command((Action)delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				ViewModelLocator.Resolve<IOpenUrlService>().OpenUrl((ViewModelLocator.Resolve<IDependencyService>().DevicePlatform == DevicePlatform.get_iOS()) ? "https://apps.apple.com/au/app/sa-home-quarantine/id1567354245" : "https://play.google.com/store/apps/details?id=au.gov.sa.homequarantine");
			}),
			ButtonText = ((ViewModelLocator.Resolve<IDependencyService>().DevicePlatform == DevicePlatform.get_iOS()) ? Resources.AppVersion_Button_Apple : Resources.AppVersion_Button_Google),
			ButtonColour = ColorHelper.GetResourceValue("QuartenaryColor"),
			IsPermissionsType = false
		};


		public OnboardingHelpViewModel AppVersionOutdatedViewModel { get; } = new OnboardingHelpViewModel(ViewModelLocator.Resolve<INavigationService>())
		{
			Title = Resources.AppVersion_NewVersion_Title,
			Descriptions = new List<string>
			{
				Resources.AppVersion_NewVersion_Message1,
				Resources.AppVersion_NewVersion_Message2
			},
			ImageSource = "AppVersionOutdated",
			ButtonCommand = (ICommand)new Command((Action)delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				ViewModelLocator.Resolve<IOpenUrlService>().OpenUrl((ViewModelLocator.Resolve<IDependencyService>().DevicePlatform == DevicePlatform.get_iOS()) ? "https://apps.apple.com/au/app/sa-home-quarantine/id1567354245" : "https://play.google.com/store/apps/details?id=au.gov.sa.homequarantine");
			}),
			ButtonText = ((ViewModelLocator.Resolve<IDependencyService>().DevicePlatform == DevicePlatform.get_iOS()) ? Resources.AppVersion_Button_Apple : Resources.AppVersion_Button_Google),
			ButtonColour = ColorHelper.GetResourceValue("QuartenaryColor"),
			ShowDismiss = true,
			IsPermissionsType = false
		};


		public ErrorViewModel LiveFaceCheckInErrorHandlingPage { get; } = new ErrorViewModel(ViewModelLocator.Resolve<IOpenUrlService>(), ViewModelLocator.Resolve<INavigationService>(), ViewModelLocator.Resolve<IDependencyService>())
		{
			Title = Resources.ErrorHandling_LiveFaceCheckInTitle,
			SubTitle = Resources.ErrorHandling_LiveFaceCheckInSubTitle,
			Reasons = new List<string>
			{
				Resources.ErrorHandling_FirstReason,
				Resources.ErrorHandling_SecondReason,
				Resources.ErrorHandling_LiveFaceCheckInReason
			}
		};


		public InformationContentViewModel GuidelinesPage { get; } = new InformationContentViewModel
		{
			Title = Resources.Guidelines_Title,
			SubHeading = Resources.Guidelines_SubTitle,
			ContentGroups = new List<InformationContentGroupModel>
			{
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("PrimaryColor"),
					Title = Resources.Guidelines_YourHomeQuarntine,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.Guidelines_YouMustNotLeave,
							Content = new List<string> { Resources.Guidelines_YouMustNotLeaveContent }
						},
						new AccordionModel
						{
							Heading = Resources.Guidelines_NovistorsAllowed,
							Content = new List<string> { Resources.Guidelines_NovistorsAllowedContent }
						},
						new AccordionModel
						{
							Heading = Resources.Guidelines_AvoidContact,
							Content = new List<string>
							{
								Resources.Guidelines_AvoidContactContent1,
								Resources.Guidelines_AvoidContactContent2,
								Resources.Guidelines_AvoidContactContent3
							}
						},
						new AccordionModel
						{
							Heading = Resources.Guidelines_Checkins,
							Content = new List<string> { Resources.Guidelines_CheckinssContent }
						}
					}
				},
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("ErrorColor"),
					Title = Resources.Guidelines_TestingTitle,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.Guidelines_TestingSchedule,
							Content = new List<string> { Resources.Guidelines_TestingScheduleContent },
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.HasSymptomView_TestingLocations,
									IsUrl = true,
									Url = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/testing+and+tracing/covid-19+clinics+and+testing+centres/covid-19+clinics+and+testing+centres"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Guidelines_WearAMask,
							Content = new List<string> { Resources.Guidelines_WearAMaskContent }
						},
						new AccordionModel
						{
							Heading = Resources.Guidelines_AdviseTestingStaff,
							Content = new List<string> { Resources.Guidelines_AdviseTestingStaffContent }
						}
					}
				},
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("QuinaryColor"),
					Title = Resources.Guidelines_MonitorYourSymptoms,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.Guidelines_DailySymptomCheck,
							Content = new List<string> { Resources.Guidelines_DailySymptomCheckContent }
						},
						new AccordionModel
						{
							Heading = Resources.Guidelines_ReportNewSymptoms,
							Content = new List<string> { Resources.Guidelines_ReportNewSymptomsContent }
						}
					}
				},
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("PrimaryColor"),
					Title = Resources.Guidelines_SAHealthHomeQuarantineGuidelines,
					Description = Resources.Guidelines_SAHomeQuarantineLinkDescription,
					GroupType = InformationContentGroupType.ReferenceLink,
					Links = new List<ResourceLinkModel>
					{
						new ResourceLinkModel
						{
							Label = Resources.Guidelines_SAHealthAdvice,
							IsUrl = true,
							Url = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29"
						},
						new ResourceLinkModel
						{
							Label = Resources.Guidelines_Alerts,
							IsUrl = true,
							Url = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/latest+updates/latest+updates+on+covid-19"
						},
						new ResourceLinkModel
						{
							Label = Resources.Guidelines_TranslatedResources,
							IsUrl = true,
							Url = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/help+and+advice/translated+covid-19+resources/translated+covid-19+resources?mr-sort=title-asc&mr-pg=1"
						},
						new ResourceLinkModel
						{
							Label = Resources.Guidelines_WebSite,
							IsUrl = true,
							Url = "https://www.covid-19.sa.gov.au/"
						}
					}
				}
			}
		};


		public InformationContentViewModel SupportResourcesPage { get; } = new InformationContentViewModel
		{
			Title = Resources.HomePage_SupportResources,
			SubHeading = Resources.Resources_SupportSubTitle,
			ContentGroups = new List<InformationContentGroupModel>
			{
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("ErrorColor"),
					Title = Resources.Resources_MentalHealthAndWellness,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.SupportResources_SACovid19MentalHealthSupportLine,
							Content = new List<string>
							{
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent1,
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent2
							},
							Reasons = new List<string>
							{
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent3,
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent4,
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent5,
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent6
							},
							OtherContent = new List<string>
							{
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent7,
								Resources.SupportResources_SACovid19MentalHealthSupportLineContent8
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.SupportResources_SACovid19MentalHealthSupportLineNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.SupportResources_SACovid19MentalHealthSupportLineWebsite,
									IsUrl = true,
									Url = "https://www.unitingcommunities.org/service/counselling/crisis-support/sa-covid-support-line"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_Lifeline,
							Content = new List<string>
							{
								Resources.Resources_LifelineContent1,
								Resources.Resources_LifelineContent2,
								Resources.Resources_LifelineContent3
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_LifelineNumber,
								ShowCallButton = true
							},
							TextMessageButton = new TextMessageButtonModel
							{
								Number = Resources.Resource_LifelineTextNumber,
								ShowTextMessageButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_CrisisSupporterChat,
									IsUrl = true,
									Url = "https://www.lifeline.org.au/crisis-text/"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_LinelineWebsite,
									IsUrl = true,
									Url = "https://www.lifeline.org.au/about/our-services/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_BeyondBlue,
							Content = new List<string> { Resources.Resources_BeyondBlueContent },
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_BeyondblueNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_SupportServiceChatBeyondBlue,
									IsUrl = true,
									Url = "https://online.beyondblue.org.au/WebModules/Chat/InitialInformation.aspx"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_SupportEmailServiceBeyondBlue,
									IsUrl = true,
									Url = "https://online.beyondblue.org.au/WebModules/Email/InitialInformation.aspx"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_BeyondBlueWebsite,
									IsUrl = true,
									Url = "https://www.beyondblue.org.au/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_Thirilli,
							Content = new List<string>
							{
								Resources.Resources_ThirilliContent1,
								Resources.Resources_ThirilliContent2
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_ThirilliNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_ThirilliWebsite,
									IsUrl = true,
									Url = "https://thirrili.com.au/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_Headspace,
							Content = new List<string> { Resources.Resources_HeadspaceContent },
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_HeadspaceNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_HeadspaceWebsite,
									IsUrl = true,
									Url = "https://headspace.org.au/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_ASKPEACE,
							Content = new List<string>
							{
								Resources.Resources_ASKPEACEContent,
								Resources.Resources_ASKPEACESubContent,
								Resources.Resources_ASKPEACESubContent1
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_ASKPEACENumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_ASKPEACEWebsite,
									IsUrl = true,
									Url = "https://www.rasa.org.au/services/couples-families/askpeace/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_MentalHealthTriage,
							Content = new List<string>
							{
								Resources.Resources_MentalHealthTriageContent,
								Resources.Resources_MentalHealthTriageContent1
							},
							Reasons = new List<string>
							{
								Resources.Resources_MentalHealthTriageContent2,
								Resources.Resources_MentalHealthTriageContent3,
								Resources.Resources_MentalHealthTriageContent4,
								Resources.Resources_MentalHealthTriageContent5
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_MentalHealthNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_MentalHealthTriageWebsite,
									IsUrl = true,
									Url = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/services/mental+health+and+drug+and+alcohol+services/mental+health+services/mental+health+services"
								}
							}
						}
					}
				},
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("PrimaryColor"),
					Title = Resources.Resources_CallCentresAndInforamtion,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.Resources_Emergency,
							Content = new List<string>
							{
								Resources.Resources_EmergencyContent,
								Resources.Resources_EmergencySubContent
							},
							Reasons = new List<string>
							{
								Resources.Resources_EmergencyReason,
								Resources.Resources_EmergencyReason1,
								Resources.Resources_EmergencyReason2,
								Resources.Resources_EmergencyReason3,
								Resources.Resources_EmergencyReason4
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_TriplezerNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_TriplezeroWebsite,
									IsUrl = true,
									Url = "https://www.triplezero.gov.au/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_HealthDirect,
							Content = new List<string> { Resources.Resources_HealthDirectContent },
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_HealthdirectNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_HealthlineHotlineWebsite,
									IsUrl = true,
									Url = "https://www.healthdirect.gov.au/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_CrimeStoppers,
							Content = new List<string> { Resources.Resources_CrimeStoppersContent },
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_CrimeStopperNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_CrimeStoppers,
									IsUrl = true,
									Url = "https://crimestopperssa.com.au/"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_MakeAReportOnline,
									IsUrl = true,
									Url = "https://crimestopperssa.com.au/download-the-app/"
								}
							}
						}
					}
				},
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("QuinaryColor"),
					Title = Resources.Resources_FamilyAndDomestic,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.Resources_WhiteRibbon,
							Content = new List<string>
							{
								Resources.Resources_WhiteRibbonContent,
								Resources.Resources_WhiteRibbonSubContent
							},
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_WhiteRibbonNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_WhiteRibbonWebsite,
									IsUrl = true,
									Url = "https://www.whiteribbon.org.au/"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.Resources_KidsHelpline,
							Content = new List<string> { Resources.Resources_KidsHelplineContent },
							CallButton = new CallButtonModel
							{
								Text = Resources.Resource_KidsHelplineNumber,
								ShowCallButton = true
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resource_KidsHelplineWebsite,
									IsUrl = true,
									Url = "https://kidshelpline.com.au/"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.Resources_KidsHelplineContentQuarantineLink,
									IsUrl = true,
									Url = "https://kidshelpline.com.au/teens/issues/covid-19-quarantine-isolation-and-lockdown"
								}
							}
						}
					}
				}
			}
		};


		public InformationContentViewModel FAQsPage { get; } = new InformationContentViewModel
		{
			Title = Resources.HomePage_FAQs,
			SubHeading = Resources.FAQ_SubTitle,
			ContentGroups = new List<InformationContentGroupModel>
			{
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("PrimaryColor"),
					Title = Resources.FAQs_HomeQuarantineFAQHeading,
					Description = Resources.FAQs_HomeQuarantineFAQDetails,
					GroupType = InformationContentGroupType.ReferenceLink,
					Links = new List<ResourceLinkModel>
					{
						new ResourceLinkModel
						{
							Label = Resources.FAQs_HomeQuarantineFAQLink,
							IsUrl = true,
							Url = "https://www.sahealth.sa.gov.au/wps/wcm/connect/public+content/sa+health+internet/conditions/infectious+diseases/covid-19/about+covid-19/self-isolation+and+quarantine+advice+for+covid-19+%28coronavirus%29"
						}
					}
				},
				new InformationContentGroupModel
				{
					BoxColor = ColorHelper.GetResourceValue("TertiaryColor"),
					Title = Resources.FAQ_FAQsForQuarantine,
					Subtitle = Resources.FAQ_FAQsForQuarantineSubTitle,
					Accordions = new List<AccordionModel>
					{
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion18,
							Content = new List<string>
							{
								Resources.FAQ_FAQsQuestion18Content1,
								Resources.FAQ_FAQsQuestion18Content2
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.FAQs_TurnOfflocationIphone,
									IsUrl = true,
									Url = "https://support.apple.com/en-au/HT207092"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.FAQs_TurnOfflocationAndroid,
									IsUrl = true,
									Url = "https://support.google.com/accounts/answer/6179507?hl=en"
								}
							},
							OtherContent = new List<string> { Resources.FAQ_FAQsQuestion18Content3 }
						},
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion11,
							Content = new List<string> { Resources.FAQ_FAQsQuestion11Content }
						},
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion20,
							Content = new List<string>
							{
								Resources.FAQ_FAQsQuestion20Content1,
								Resources.FAQ_FAQsQuestion20Content2
							},
							LinkGroup = new List<InformationResourceLinkButtonModel>
							{
								new InformationResourceLinkButtonModel
								{
									Label = Resources.FAQs_TurnOffNotificationIphone,
									IsUrl = true,
									Url = "https://support.apple.com/en-au/guide/iphone/iph7c3d96bab/ios"
								},
								new InformationResourceLinkButtonModel
								{
									Label = Resources.FAQs_TurnOffNotificationAndroid,
									IsUrl = true,
									Url = "https://support.google.com/android/answer/9079661?hl=en#:~:text=To%20find%20your%20notifications%2C%20from,all%20notifications%2C%20tap%20Notifications%20off"
								}
							}
						},
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion10,
							Content = new List<string>
							{
								Resources.FAQ_FAQsQuestion10Content1,
								Resources.FAQ_FAQsQuestion10Content2,
								Resources.FAQ_FAQsQuestion10Content3,
								Resources.FAQ_FAQsQuestion10Content4
							}
						},
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion12,
							Content = new List<string> { Resources.FAQ_FAQsQuestion12Content }
						},
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion13,
							Content = new List<string>
							{
								Resources.FAQ_FAQsQuestion13Content1,
								Resources.FAQ_FAQsQuestion13Content2
							}
						},
						new AccordionModel
						{
							Heading = Resources.FAQ_FAQsQuestion14,
							Content = new List<string>
							{
								Resources.FAQ_FAQsQuestion14Content1,
								Resources.FAQ_FAQsQuestion14Content2
							}
						}
					}
				}
			}
		};


		public ComplianceCheckDisabledViewModel ComplianceCheckNotDuePage { get; } = new ComplianceCheckDisabledViewModel
		{
			BorderColor = ColorHelper.GetResourceValue("PrimaryColor"),
			ImageSource = "ComplianceCheckNotDue",
			Title = Resources.ComplianceCheck_NotDueTitle,
			Descriptions = new List<string>
			{
				Resources.ComplianceCheck_NotDueDescription1,
				Resources.ComplianceCheck_NotDueDescription2,
				Resources.ComplianceCheck_NotDueDescription3
			}
		};


		public ComplianceCheckDisabledViewModel ComplianceCheckMissedNotificationPage { get; } = new ComplianceCheckDisabledViewModel
		{
			BorderColor = ColorHelper.GetResourceValue("ErrorColor"),
			ImageSource = "ComplianceCheckMissed",
			Title = Resources.LivenessCheckView_LivenessCheckTitle,
			SubTitle = Resources.ComplianceCheck_MissedSubTitle,
			TextColor = ColorHelper.GetResourceValue("ErrorColor"),
			Descriptions = new List<string>
			{
				Resources.ComplianceCheck_MissedDescription1,
				Resources.ComplianceCheck_MissedDescription2,
				Resources.ComplianceCheck_MissedDescription3
			}
		};

	}
}
