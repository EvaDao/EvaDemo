namespace EvaDemo.Shop.WebApp.Models
{
	using EvaDemo.Shop.Models;
	using M = Shop.Models.Product;
	using Model = Shop.Models.Product.EditSpec;
	partial class Product
	{
		public class EditVM
		{
			public static EditVM Of(M.Detail model) => new EditVM(model);
			public EditVM() { }
			private EditVM(M.Detail model)
			{
				ID = model.ID;
				Description = model.Description;
				DetailInfo = model.DetailInfo;
				Price = model.Price.Amt;
				Currency = model.Price.Currency.ToString();
				Quantity = model.Quantity;
			}
			public long ID { get; set; }
			public string Description { get; set; }
			public string DetailInfo { get; set; }
			public double Price { get; set; }
			public string Currency { get; set; }
			public int Quantity { get; set; }

			public Model ToModel()
				=> new Model
				{
					ID = ID,
					Description = Description ?? string.Empty,
					DetailInfo = DetailInfo ?? string.Empty,
					Price = Money.Of(Price, Currency.BeEnum<Money.Currencies>()).Value,
					Quantity = Quantity
				};
		}
	}
}
