using EvaDemo.Shop.Models;
using System.Collections.Generic;

namespace EvaDemo.Shop.Repos
{
	public interface IProductRepo
	{
		IEnumerable<Product> List();
		Product Detail(long id);
		void Add(Product product);
	}
}
