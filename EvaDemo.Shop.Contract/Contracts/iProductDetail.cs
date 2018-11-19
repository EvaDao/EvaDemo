using System;

namespace EvaDemo.Shop
{
	public interface iProductDetail
	{
		long ID { get; }
		string Description { get; }
		string DetailInfo { get; }
		long Price { get; }
		int TotalQty { get; }
		int LockedQty { get; }
		DateTime CreatedOn { get; }
	}
}
