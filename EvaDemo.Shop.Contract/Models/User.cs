namespace EvaDemo.Shop.Models
{
	using M = User.CreateSpec;
	public partial class User
	{
		public partial class CreateSpec
		{
			public static M Of() => new M();
			public CreateSpec()
			{

			}
		}
	}
}
