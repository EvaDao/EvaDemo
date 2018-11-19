using System.Linq;

namespace EvaDemo.Shop.Repos
{
	using EvaDemo.Shop.Data;
	using M = Models.User;
	public class UserRepo : RepoBase, IUserRepo
	{
		public UserRepo(DemoDataContext context) : base(context) { }

		public long Register(M.RegisterSpec spec)
		{
			long? userID = 0;
			Context.User_Register(spec.UserName, spec.Password, ref userID);
			return userID ?? 0;
		}
		public void Update(M.UpdateSpec spec)
			=> Context.User_Update(spec.UserID, spec.Surname, spec.Email, spec.Country, spec.State, spec.City, spec.City, spec.Address1, spec.Address2);

		public M.Context Login(M.LoginSpec spec) => Context.User_Login(spec.UserName, spec.Password).FirstOrDefault().Over(M.Context.From);
		public M.Info Info(long id) => Context.User_Info(id).FirstOrDefault().Over(M.Info.From);
	}
}
