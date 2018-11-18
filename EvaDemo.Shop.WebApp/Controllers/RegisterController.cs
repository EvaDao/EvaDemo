using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	using EvaDemo.Shop.Repos;
	using Models;
	public class RegisterController : BaseController
	{
		private readonly IUserRepo _userRepo;
		public RegisterController(IUserRepo userRepo)
		{
			_userRepo = userRepo;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult RegisterSubmit(Register.VM model)
		{
			try
			{
				_userRepo.Register(model.ToModel());
				return View(nameof(RegisterSuccess));
			}
			catch
			{
				return BadRequest("Failed Register");
			}
		}
		public IActionResult RegisterSuccess()
		{
			return View();
		}
	}
}