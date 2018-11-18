namespace EvaDemo.Shop.Models
{
	using System.Collections.Generic;
	using M = User.Context;
	partial class User
	{
		public sealed class Context
		{
			public static M From(iUserContext ctx) => new M(ctx);

			private Context(iUserContext ctx)
			{
				ID = ctx.ID;
				Name = ctx.Name;
				Surname = ctx.Surname;
				Type = (Types)ctx.Type;
				RoleIDs = ctx.RoleIDs.Split(",").EachTo(System.Convert.ToInt32);
			}

			public long ID { get; }
			public string Name { get; }
			public string Surname { get; }
			public Types Type { get; }
			public IEnumerable<int> RoleIDs { get; }
		}
	}
}
