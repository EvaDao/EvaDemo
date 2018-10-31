namespace EvaDemo.Shop.Repos
{
	using M = Models.User;
	public class UserRepo : IUserRepo
	{
		public void Register(M.CreateSpec createSpec)
		{
			// CALL DB SP;
		}
	}
}
