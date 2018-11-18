using System.ComponentModel.DataAnnotations;

namespace EvaDemo.Shop.WebApp.Models
{
	public partial class Login
	{
		public partial class VM
		{
			[Required]
			public string UserName { get; set; }
			[Required]
			public string Password { get; set; }

			public Shop.Models.User.LoginSpec ToModel()
				=> new Shop.Models.User.LoginSpec
				{
					UserName = UserName,
					Password = Password.Over(Utils.MD5Crypto)
				};
		}
	}
}
