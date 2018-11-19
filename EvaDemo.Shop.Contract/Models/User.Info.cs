namespace EvaDemo.Shop.Models
{
	using M = User.Info;
	partial class User
	{
		public partial class Info
		{
			public static M From(iUserInfo i) => new M(i);
			private Info(iUserInfo i)
			{
				ID = i.ID;
				Name = i.Name;
				Surname = i.Surname;
				Phone = i.Phone;
				Email = i.Email;
				Country = i.Country;
				State = i.State;
				City = i.City;
				Address1 = i.Address1;
				Address2 = i.Address2;
			}
			public long ID { get; set; }
			public string Name { get; set; }
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
