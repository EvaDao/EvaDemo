using System;

namespace EvaDemo.Shop.Models
{
	using M = Product.Detail;
	partial class Product
	{
		public sealed class Detail
		{
			public static M From(iProductDetail i) => new M(i);
			private Detail(iProductDetail i)
			{
				ID = i.ID;
				Description = i.Description;
				DetailInfo = i.DetailInfo;
				Price = Money.From(i.Price);
				Quantity = i.TotalQty;
				LockedQty = i.LockedQty;
				CreatedOn = i.CreatedOn;
			}
			public long ID { get; set; }
			public string Description { get; set; }
			public Money Price { get; set; }
			public string DetailInfo { get; set; }
			public int Quantity { get; set; }
			public int LockedQty { get; set; }
			public DateTime CreatedOn { get; set; }
		}
	}
}
