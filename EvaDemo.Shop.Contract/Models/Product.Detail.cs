using System;

namespace EvaDemo.Shop.Models
{
	partial class Product
	{
		public sealed class Detail
		{
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
