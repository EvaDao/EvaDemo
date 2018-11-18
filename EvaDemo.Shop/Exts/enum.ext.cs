using System;
using System.Linq;

namespace EvaDemo.Shop
{
	public static partial class ext
	{
		public static int ToInt32(this Enum me) => Convert.ToInt32(me);

		public static TEnum BeEnum<TEnum>(this string me) where TEnum : Enum
		{
			Enum.TryParse(typeof(TEnum), me, true, out object units);
			return (TEnum)units;
		}
		public static T BeEnum<T>(this int me) where T : Enum
			=> typeof(T).GetFields()
			.Where(a => a.FieldType.IsEnum)
			.Where(a => Enum.IsDefined(typeof(T), me))
			.Select(a => (T)Enum.ToObject(typeof(T), me)).FirstOrDefault();
		public static T BeEnum<T>(this byte me) where T : Enum
			=> typeof(T).GetFields()
			.Where(a => a.FieldType.IsEnum)
			.Where(a => Enum.IsDefined(typeof(T), me))
			.Select(a => (T)Enum.ToObject(typeof(T), me)).FirstOrDefault();
	}
}
