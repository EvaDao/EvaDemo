using System;

namespace EvaDemo.Shop
{
	partial class ext
	{
		public static R Over<T, R>(this T me, Func<T, R> transform) => transform(me);

		public static T Ensure<T>(this T me) where T : new()
			=> me == null ? new T() : me;
	}
}
