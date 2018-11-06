using System;

namespace EvaDemo.Shop.Models
{
	partial class Product
	{
		public sealed class List
		{
			public long ID { get; set; }
			public string Name { get; set; }
			public Money Price { get; set; }
			public int Quantity { get; set; }
			public int LockedQty { get; set; }
			public DateTime CreatedOn { get; set; }
		}
	}
}
