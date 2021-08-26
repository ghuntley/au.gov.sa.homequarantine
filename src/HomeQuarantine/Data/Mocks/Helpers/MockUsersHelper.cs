using HomeQuarantine.Data.Mocks.Interfaces;

namespace HomeQuarantine.Data.Mocks.Helpers
{
	public static class MockUsersHelper
	{
		public static IMockUser GetMockUser(string name)
		{
			return new User1();
		}
	}
}
