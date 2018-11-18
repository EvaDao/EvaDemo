using System.ComponentModel.DataAnnotations;

namespace EvaDemo.Shop.WebApp.Models
{
	public partial class Register
	{
		public partial class VM
		{
			[Required]
			public string UserName { get; set; }
			[Required]
			public string Password { get; set; }
			//[Required]
			//public string ConfirmPassword { get; set; }
			public Shop.Models.User.RegisterSpec ToModel()
				=> new Shop.Models.User.RegisterSpec
				{
					UserName = UserName,
					Password = Password.Over(Utils.MD5Crypto)
				};
		}
	}
}
