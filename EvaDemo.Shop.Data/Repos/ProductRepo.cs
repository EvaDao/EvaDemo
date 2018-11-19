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
		public IEnumerable<M.List> List() => Context.Product_List().Select(M.List.From);
		public M.Detail Detail(long id) => Context.Product_Detail(id).FirstOrDefault().Over(M.Detail.From);

		public void Add(M.CreateSpec product)
			=> Context.Product_Add(product.Description, product.DetailInfo, product.Price, product.Quantity);

		public void Edit(M.EditSpec product)
			=> Context.Product_Edit(product.ID, product.Description, product.DetailInfo, product.Price, product.Quantity);

		public void Delete(long id) => Context.Product_Delete(id);
	}
}
