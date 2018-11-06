using System;

namespace EvaDemo.Shop.Models
{
	using C = Money.Currencies;
	using M = Money;
	public class Money
	{
		public enum Currencies
		{
			Nil = 0,
			USD = 1,
			EUR = 2,
			GBP = 3,
			RMB = 4,
			HKD = 5,
			TWD = 6,
			JPY = 7,
		}

		public static M Empty() => new M(0, 0);
		public static M From(long value) => new M(Math.Round(value / 100.0, 0) / 100.0D, (C)Enum.ToObject(typeof(C), Math.Abs(value) % 100));
		public static M Of(double amt, C currency) => new M(amt, currency);

		private Money(double amt, C currency) { Amt = amt; Currency = currency; }

		public double Amt { get; }
		public C Currency { get; }
		public long Value => rawAmt(Amt, Currency);

		private long rawAmt(double amt, C currency) => Convert.ToInt64((amt >= 0 ? 1 : -1) * (Math.Abs(amt * 10000) + currency.ToInt32()));
	}
}
