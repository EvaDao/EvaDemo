using Microsoft.AspNetCore.Mvc;

namespace EvaDemo.Shop.WebApp.Controllers
{
	using EvaDemo.Shop.Repos;
	using UserVM = Models.User;
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
		public IActionResult RegisterSubmit(Models.Register.VM model)
		{
			try
			{
				var userID = _userRepo.Register(model.ToModel());
				return Redirect($"Edit/{userID}");
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
		// GET: Users/Edit/5
		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}

			var user = _userRepo.Info(id);
			if (user == null)
			{
				return NotFound();
			}
			return View(user.Over(UserVM.UpdateVM.Of));
		}

		// POST: Users/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("ID,Surname,Phone,Email,CountryCode,State,City,Address1,Address2")] UserVM.UpdateVM user)
		{
			if (id != user.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				_userRepo.Update(user.ToModel());
				return View(nameof(RegisterSuccess));
			}
			return View(user);
		}
	}
}