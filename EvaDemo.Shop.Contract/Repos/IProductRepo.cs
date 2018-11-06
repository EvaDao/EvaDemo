using EvaDemo.Shop.Models;
using System.Collections.Generic;

namespace EvaDemo.Shop.Repos
{
	public interface IProductRepo
	{
		IEnumerable<Product.List> List();
		Product.Detail Detail(long id);
		void Add(Product product);
	}
}
