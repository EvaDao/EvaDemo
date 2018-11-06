using EvaDemo.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaDemo.Shop.Repos
{
	public class ProductRepo : IProductRepo
	{
		private static readonly IList<Product> _products
			= new List<Product>
			{
				new Product
				{
					ID=1,
					Name="Prod1",
					Quantity=100,
					LockedQty=20,
					CreatedOn=DateTime.UtcNow
				},
				new Product
				{
					ID=11122,
					Name="Prod123231",
					Quantity=3200,
					LockedQty=310,
					CreatedOn=DateTime.UtcNow
				},
			};
		public IEnumerable<Product> List() => _products;
		public Product Detail(long id) => _products.FirstOrDefault(x => x.ID == id);

		public void Add(Product product)
		{
			_products.Add(product);
		}
	}
}
