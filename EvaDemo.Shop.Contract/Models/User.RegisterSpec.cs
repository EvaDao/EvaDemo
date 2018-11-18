namespace EvaDemo.Shop.Models
{
	using M = User.RegisterSpec;
	partial class User
	{
		public partial class RegisterSpec
		{
			public static M Of() => new M();

			public string UserName { get; set; }
			public string Password { get; set; }
		}
	}
}
