using System;

namespace EvaDemo.Shop.Models
{
	public class Product
	{
		public long ID { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public int LockedQty { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}
