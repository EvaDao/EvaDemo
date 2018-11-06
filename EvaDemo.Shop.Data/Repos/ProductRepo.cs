using EvaDemo.Shop.Models;
using System;
using System.Collections.Generic;

namespace EvaDemo.Shop.Repos
{
	public class ProductRepo : IProductRepo
	{
		private static readonly IList<Product.List> _products
			= new List<Product.List>
			{
				new Product.List
				{
					ID=1,
					Name="Prod1",
					Price = Money.From(34000005),
					Quantity=100,
					LockedQty=20,
					CreatedOn=DateTime.UtcNow
				},
				new Product.List
				{
					ID=11122,
					Name="Prod123231",
					Price = Money.From(34000005),
					Quantity=3200,
					LockedQty=310,
					CreatedOn=DateTime.UtcNow
				},
			};
		public IEnumerable<Product.List> List() => _products;
		public Product.Detail Detail(long id) => new Product.Detail
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
