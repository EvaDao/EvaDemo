using EvaDemo.Shop.Repos;
using EvaDemo.Shop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

			return View(M.DetailVM.Of(product));
		}

		public IActionResult Create()
		{
			return View();
		}

		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("ID,Name,Quantity,LockedQty,CreatedOn")] Product product)
		{
			if (ModelState.IsValid)
			{
				//var model = new Models.Product { };
				//_productRepo.Add(model);
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

			return View(M.DetailVM.Of(product));
		}

		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(long id, [Bind("ID,Name,Quantity,LockedQty,CreatedOn")] Product product)
		{
			return View();
		}
	}
}
