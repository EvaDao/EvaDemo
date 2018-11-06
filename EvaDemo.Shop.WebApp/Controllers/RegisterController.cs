using EvaDemo.Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	public class RegisterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult RegisterSubmit(Register.VM model)
		{
			return View(nameof(RegisterSuccess));
		}
		public IActionResult RegisterSuccess()
		{
			return View();
		}
	}
}