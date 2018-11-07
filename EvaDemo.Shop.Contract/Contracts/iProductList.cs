using System;

namespace EvaDemo.Shop
{
	public interface iProductList
	{
		long ID { get; }
		string Description { get; }
		long Price { get; }
		int TotalQty { get; }
		int LockedQty { get; }
		DateTime CreatedOn { get; }
	}
}
