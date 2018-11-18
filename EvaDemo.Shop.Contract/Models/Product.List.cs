using System;

namespace EvaDemo.Shop.Models
{
	using M = Product.List;
	partial class Product
	{
		public sealed class List
		{
			public static M From(iProductList i) => new M(i);
			private List(iProductList i)
			{
				ID = i.ID;
				Name = i.Description;
				Price = Money.From(i.Price);
				Quantity = i.TotalQty;
				LockedQty = i.LockedQty;
				CreatedOn = i.CreatedOn;
			}
			public long ID { get; }
			public string Name { get; }
			public Money Price { get; }
			public int Quantity { get; }
			public int LockedQty { get; }
			public DateTime CreatedOn { get; }
		}
	}
}
