namespace EvaDemo.Shop
{
	public interface iUserInfo
	{
		long ID { get; }
		string Name { get; }
		string Surname { get; }
		string Phone { get; }
		string Email { get; }
		string Country { get; }
		string State { get; }
		string City { get; }
		string Address1 { get; }
		string Address2 { get; }
	}
}
