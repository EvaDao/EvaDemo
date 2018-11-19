namespace EvaDemo.Shop.Models
{
	public sealed partial class User
	{
		public int ID { get; set; }
		public enum Types
		{
			Customer = 1,
			Employee = 2,
			Partner = 3,
			Others = 99
		}
	}
}
