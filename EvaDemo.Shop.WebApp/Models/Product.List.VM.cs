using System;

namespace EvaDemo.Shop.WebApp.Models
{
	using M = Shop.Models.Product.List;
	partial class Product
	{
		public class ListVM
		{
			public static ListVM Of(M model) => new ListVM(model);
			public ListVM() { }
			private ListVM(M model)
			{
				ID = model.ID;
				Name = model.Name;
				Price = model.Price.Amt;
				Currency = model.Price.Currency.ToString();
				Quantity = model.Quantity;
				LockedQty = model.LockedQty;
				CreatedOn = model.CreatedOn;
			}
			public long ID { get; set; }
			public string Name { get; set; }
			public double Price { get; set; }
			public string Currency { get; set; }
			public int Quantity { get; set; }
			public int LockedQty { get; set; }
			public DateTime CreatedOn { get; set; }
		}
	}
}
