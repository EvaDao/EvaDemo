namespace EvaDemo.Shop.Models
{
	using M = User.RegisterSpec;
	partial class User
	{
		public partial class UpdateSpec
		{
			public static M Of() => new M();

			public long UserID { get; set; }
			public string Surname { get; set; }
			public string Phone { get; set; }
			public string Email { get; set; }
			public string Country { get; set; }
			public string State { get; set; }
			public string City { get; set; }
			public string Address1 { get; set; }
			public string Address2 { get; set; }
		}
	}
}
