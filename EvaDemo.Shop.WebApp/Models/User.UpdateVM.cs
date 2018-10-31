namespace EvaDemo.Shop.Models
{
	public partial class User
	{
		public class UpdateVM
		{
			public string Name { get; set; }
			public string Surname { get; set; }
			public string Phone { get; set; }
			public string Email { get; set; }
			public string CountryCode { get; set; }
			public string State { get; set; }
			public string City { get; set; }
			public string Address1 { get; set; }
			public string Address2 { get; set; }
		}
	}
}
