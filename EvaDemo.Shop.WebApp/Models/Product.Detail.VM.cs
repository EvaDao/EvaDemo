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
				Quantity = model.Quantity;
				LockedQty = model.LockedQty;
				CreatedOn = model.CreatedOn;
			}
			public long ID { get; set; }
			public string Name { get; set; }
			public int Quantity { get; set; }
			public int LockedQty { get; set; }
			public DateTime CreatedOn { get; set; }
		}
	}
}
