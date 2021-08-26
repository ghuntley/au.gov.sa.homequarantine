using System.Threading.Tasks;

namespace HomeQuarantine.Services.Permissions
{
	public interface IPermissionsService
	{
		Task<bool> AreNotificationsAllowed();

		Task<bool> RequestNotificationsPermissionAndRegister();

		Task RegisterDeviceForNotifications();

		Task<bool> IsLocationPermissionAllowed();

		Task<bool> RequestLocationServicesPermission();

		Task LaunchNotificationHelpAlert();

		Task LaunchLocationHelpAlert();

		Task<bool> IsCameraPermissionAllowed();

		Task LaunchCameraHelpAlert();

		Task<bool> RequestCameraServicesPermission();

		Task<bool> LaunchPermissionAlertsIfDisabled();
	}
}
