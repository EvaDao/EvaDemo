using EvaDemo.Shop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EvaDemo.Shop.WebApp.Controllers
{
	public class HomeController : BaseController
	{
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
		}
		public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
