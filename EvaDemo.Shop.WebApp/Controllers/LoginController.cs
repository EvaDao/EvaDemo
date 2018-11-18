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
				UserContext = _userRepo.Login(model.ToModel());
				return Redirect("/Home/Index");
			}
			catch
			{
				return BadRequest("Failed Login");
			}
		}
	}
}