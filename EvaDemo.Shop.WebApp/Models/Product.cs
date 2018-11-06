using System;

namespace EvaDemo.Shop.WebApp.Models
{
	using M = Shop.Models.Product;
	public class Product
	{
		public class VM
		{
			public static VM Of(M model) => new VM(model);
			public VM() { }
			private VM(M model)
			{
				ID = model.ID;
				Name = model.Name;
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
