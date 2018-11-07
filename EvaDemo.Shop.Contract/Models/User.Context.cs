namespace EvaDemo.Shop.Models
{
	partial class User
	{
		public sealed class Context
		{
			public long ID { get; set; }
			public string Name { get; set; }
			public string Surname { get; set; }
			public Types Type { get; set; }
			public string RoleIDs { get; set; }
		}
	}
}
