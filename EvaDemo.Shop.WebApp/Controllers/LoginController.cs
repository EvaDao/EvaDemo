using EvaDemo.Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login(Login.VM model)
		{
			return View();
		}
	}
}