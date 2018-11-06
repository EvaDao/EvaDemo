using System;

namespace EvaDemo.Shop
{
	public static partial class ext
	{
		public static int ToInt32(this Enum me) => Convert.ToInt32(me);
	}
}
