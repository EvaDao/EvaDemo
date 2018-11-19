using System;

namespace EvaDemo.Shop.WebApp.Models
{
	using M = Shop.Models.Product.Detail;
	partial class Product
	{
		public class DetailVM
		{
			public static DetailVM Of(M model) => new DetailVM(model);
			public DetailVM() { }
			private DetailVM(M model)
			{
				ID = model.ID;
				Name = model.Description;
				DetailInfo = model.DetailInfo;
				Price = model.Price.Amt;
				Currency = model.Price.Currency.ToString();
				Quantity = model.Quantity;
				LockedQty = model.LockedQty;
				CreatedOn = model.CreatedOn;
			}
			public long ID { get; set; }
			public string Name { get; set; }
			public string DetailInfo { get; set; }
			public double Price { get; set; }
			public string Currency { get; set; }
			public int Quantity { get; set; }
			public int LockedQty { get; set; }
			public DateTime CreatedOn { get; set; }
		}
	}
}
