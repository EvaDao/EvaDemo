﻿using System.ComponentModel.DataAnnotations;

namespace EvaDemo.Shop.Models
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
		}
	}
}
