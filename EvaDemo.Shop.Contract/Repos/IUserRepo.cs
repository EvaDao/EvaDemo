namespace EvaDemo.Shop.Repos
{
	using M = Models.User;
	public interface IUserRepo
	{
		long Register(M.RegisterSpec createSpec);
		void Update(M.UpdateSpec spec);
		M.Context Login(M.LoginSpec spec);
		M.Info Info(long id);
	}
}
