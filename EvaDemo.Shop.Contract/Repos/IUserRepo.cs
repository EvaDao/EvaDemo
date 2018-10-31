namespace EvaDemo.Shop.Repos
{
	using M = Models.User;
	public interface IUserRepo
	{
		void Register(M.CreateSpec createSpec);
	}
}
