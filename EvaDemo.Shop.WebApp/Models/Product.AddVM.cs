namespace EvaDemo.Shop.WebApp.Models
{
	using EvaDemo.Shop.Models;
	using Model = Shop.Models.Product.CreateSpec;
	partial class Product
	{
		public class AddVM
		{
			public string Description { get; set; }
			public string DetailInfo { get; set; }
			public double Price { get; set; }
			public string Currency { get; set; }
			public int Quantity { get; set; }

			public Model ToModel()
				=> new Model
				{
					Description = Description,
					DetailInfo = DetailInfo,
					Price = Money.Of(Price, Currency.BeEnum<Money.Currencies>()).Value,
					Quantity = Quantity
				};
		}
	}
}
