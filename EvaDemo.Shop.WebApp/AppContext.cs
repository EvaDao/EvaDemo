namespace EvaDemo.Shop.WebApp
{
	using M = AppContext;
	using User = Shop.Models.User.Context;
	public class AppContext
	{
		public static M Instant { get; set; } = new M();

		private AppContext() { }

		public void SetUser(User user) { User = user; }

		public User User { get; private set; }
	}
}
