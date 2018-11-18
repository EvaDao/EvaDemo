using System.Linq;

namespace EvaDemo.Shop.Repos
{
	using EvaDemo.Shop.Data;
	using M = Models.User;
	public class UserRepo : RepoBase, IUserRepo
	{
		public UserRepo(DemoDataContext context) : base(context) { }

		public void Register(M.RegisterSpec spec) => Context.User_Register(spec.UserName, spec.Password);
		public void Update(M.UpdateSpec spec)
			=> Context.User_Update(spec.UserID, spec.Surname, spec.Email, spec.Country, spec.State, spec.City, spec.City, spec.Address1, spec.Address2);

		public M.Context Login(M.LoginSpec spec) => Context.User_Login(spec.UserName, spec.Password).FirstOrDefault().Over(M.Context.From);
	}
}
