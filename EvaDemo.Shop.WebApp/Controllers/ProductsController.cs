using EvaDemo.Shop.Repos;
using EvaDemo.Shop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EvaDemo.Shop.WebApp.Controllers
{
	using M = Product;
	public class ProductsController : BaseController
	{
		private readonly IProductRepo _productRepo;

		public ProductsController(IProductRepo productRepo)
		{
			_productRepo = productRepo;
		}

		public IActionResult Index()
		{
			return View(_productRepo.List().Select(x => M.ListVM.Of(x)));
		}

		public IActionResult Details(long id)
		{
			var product = _productRepo.Detail(id);
			if (product == null)
			{
				return NotFound();
			}

			return View(product.Over(M.DetailVM.Of));
		}

		public IActionResult Create()
		{
			return View();
		}

		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Description,DetailInfo,Price,Currency,Quantity")] M.AddVM product)
		{
			if (ModelState.IsValid)
			{
				_productRepo.Add(product.ToModel());
				return RedirectToAction(nameof(Index));
			}
			return View(product);
		}

		public IActionResult Edit(long id)
		{
			var product = _productRepo.Detail(id);
			if (product == null)
			{
				return NotFound();
			}

			return View(M.EditVM.Of(product));
		}

		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(long id, [Bind("ID,Description,DetailInfo,Price,Currency,Quantity")] M.EditVM product)
		{
			if (ModelState.IsValid)
			{
				_productRepo.Edit(product.ToModel());
				return RedirectToAction(nameof(Index));
			}
			return View(product);
		}

		public IActionResult Delete(long id)
		{
			if (id == 0)
			{
				return NotFound();
			}

			var user = _productRepo.Detail(id);
			if (user == null)
			{
				return NotFound();
			}

			return View(user.Over(M.DetailVM.Of));
		}

		// POST: Users/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(long id)
		{
			_productRepo.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
