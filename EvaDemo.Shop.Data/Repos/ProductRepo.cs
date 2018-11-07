using EvaDemo.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaDemo.Shop.Repos
{
	using Data;

	using M = Product;
	public class ProductRepo : RepoBase, IProductRepo
	{
		public ProductRepo(DemoDataContext context) : base(context) { }
		public IEnumerable<M.List> List() => Context.Product_List().Select(x => M.List.From(x));
		public M.Detail Detail(long id) => new M.Detail
		{
			ID = id,
			Description = "Prod123231",
			Price = Money.From(34000005),
			Quantity = 3200,
			LockedQty = 310,
			CreatedOn = DateTime.UtcNow
		};

		public void Add(Product product)
		{
			//_products.Add(product);
		}
	}
}
