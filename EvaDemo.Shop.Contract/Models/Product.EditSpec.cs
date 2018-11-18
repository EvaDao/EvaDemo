namespace EvaDemo.Shop.Models
{
	partial class Product
	{
		public sealed class EditSpec
		{
			public long ID { get; set; }
			public string Description { get; set; }
			public string DetailInfo { get; set; }
			public long Price { get; set; }
			public int Quantity { get; set; }
		}
	}
}
