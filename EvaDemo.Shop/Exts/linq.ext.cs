using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaDemo.Shop
{
	partial class ext
	{
		public static IEnumerable<R> EachTo<T, R>(this IEnumerable<T> me, Func<T, R> transform)
			=> ((me != null) ? me.Select(transform) : new List<R>());
	}
}
