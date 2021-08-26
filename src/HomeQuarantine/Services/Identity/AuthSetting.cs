namespace HomeQuarantine.Services.Identity
{
	public class AuthSetting
	{
		private const string DefaultEndpoint = "https://identity.sa.gov.au/auth";

		private string baseIdentityEndpoint;

		public static AuthSetting Instance { get; } = new AuthSetting();


		public string BaseIdentityEndpoint
		{
			get
			{
				return baseIdentityEndpoint;
			}
			set
			{
				baseIdentityEndpoint = value;
				UpdateEndpoint(baseIdentityEndpoint);
			}
		}

		public string ClientId => "sagov-home-quarantine-43130474";

		public string AuthorizeEndpoint { get; set; }

		public string RegisterEndpoint { get; set; }

		public string UserInfoEndpoint { get; set; }

		public string TokenEndpoint { get; set; }

		public string LogoutEndpoint { get; set; }

		public string Callback { get; set; }

		public string LogoutCallback { get; set; }

		public AuthSetting()
		{
			BaseIdentityEndpoint = "https://identity.sa.gov.au/auth";
		}

		private void UpdateEndpoint(string endpoint)
		{
			string text = "https://identity.sa.gov.au/auth/realms/sagov-idx/protocol/openid-connect";
			AuthorizeEndpoint = text + "/auth";
			UserInfoEndpoint = text + "/userinfo";
			TokenEndpoint = text + "/token";
			LogoutEndpoint = text + "/logout";
			RegisterEndpoint = text + "/registrations";
			Callback = "homequarantine://authorize";
			LogoutCallback = "homequarantine://authorize";
		}
	}
}
