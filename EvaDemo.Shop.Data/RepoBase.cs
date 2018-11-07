namespace EvaDemo.Shop
{
	using Data;

	public class RepoBase
	{
		protected DemoDataContext Context;
		public RepoBase(DemoDataContext context)
		{
			Context = context;
		}
	}
}
