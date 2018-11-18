using EvaDemo.Shop.Models;
using System.Collections.Generic;

namespace EvaDemo.Shop.Repos
{
	using M = Product;
	public interface IProductRepo
	{
		IEnumerable<M.List> List();
		M.Detail Detail(long id);
		void Add(M.CreateSpec product);
		void Edit(M.EditSpec product);
		void Delete(long id);
	}
}
