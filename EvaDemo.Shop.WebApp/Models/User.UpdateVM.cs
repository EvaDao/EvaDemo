namespace EvaDemo.Shop.WebApp.Models
{
	using M = Shop.Models.User;
	using Model = Shop.Models.User.UpdateSpec;
	public partial class User
	{
		public class UpdateVM
		{
			public static UpdateVM Of(M.Info model) => new UpdateVM(model);
			public UpdateVM() { }
			private UpdateVM(M.Info model)
			{
				ID = model.ID;
				Surname = model.Surname;
				Phone = model.Phone;
				Email = model.Email;
				CountryCode = model.Country;
				State = model.State;
				City = model.City;
				Address1 = model.Address1;
				Address2 = model.Address2;
			}
			public long ID { get; set; }
			public string Surname { get; set; }
			public string Phone { get; set; }
			public string Email { get; set; }
			public string CountryCode { get; set; }
			public string State { get; set; }
			public string City { get; set; }
			public string Address1 { get; set; }
			public string Address2 { get; set; }

			public Model ToModel()
				=> new Model
				{
					UserID = ID,
					Surname = Surname ?? string.Empty,
					Phone = Phone ?? string.Empty,
					Email = Email ?? string.Empty,
					Country = CountryCode ?? string.Empty,
					State = State ?? string.Empty,
					City = City ?? string.Empty,
					Address1 = Address1 ?? string.Empty,
					Address2 = Address2 ?? string.Empty
				};
		}
	}
}
