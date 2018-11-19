using EvaDemo.Shop.Repos;
using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	public class UsersController : Controller
	{
		private readonly IUserRepo _userRepo;
		public UsersController(IUserRepo userRepo)
		{
			_userRepo = userRepo;
		}
	}
}
