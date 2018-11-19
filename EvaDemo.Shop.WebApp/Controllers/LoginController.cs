using EvaDemo.Shop.Models;
using EvaDemo.Shop.Repos;
using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	using Models;
	public class LoginController : BaseController
	{
		private readonly IUserRepo _userRepo;
		public LoginController(IUserRepo userRepo)
		{
			_userRepo = userRepo;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login(Login.VM model)
		{
			try
			{
				AppContext.Instant.SetUser(_userRepo.Login(model.ToModel()));
				return Redirect("/Products/Index");
			}
			catch
			{
				return BadRequest("Failed Login");
			}
		}

		public IActionResult Out()
		{
			AppContext.Instant.SetUser(null);
			return Redirect("/Home/Index");
		}
	}
}