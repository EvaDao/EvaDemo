using System;
using System.Security.Cryptography;
using System.Text;

namespace EvaDemo.Shop
{
	public static class Utils
	{
		public static string MD5Crypto(string content)
			   => content
			   .Over(new UTF8Encoding().GetBytes)
			   .Over(new MD5CryptoServiceProvider().ComputeHash)
			   .Over(BitConverter.ToString)
			   .Over(x => x.Replace("-", ""))
			   .ToLower();
	}
}
