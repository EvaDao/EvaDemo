using EvaDemo.Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	public abstract class BaseController : Controller
	{
		private static User.Context _userContext;
		public BaseController()
		{
		}
		public static User.Context UserContext
		{
			get { return _userContext; }
			protected set
			{
				_userContext = value;
				//ViewData.Add(nameof(UserContext), _userContext);
			}
		}
	}
}