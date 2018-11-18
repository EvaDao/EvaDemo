namespace EvaDemo.Shop
{
	using Data;
	using System;

	public class RepoBase:IDisposable
	{
		protected DemoDataContext Context;
		public RepoBase(DemoDataContext context)
		{
			Context = context;
		}

		public void Dispose()
		{
			Context.Dispose();
		}
	}
}
