namespace EvaDemo.Shop
{
	public interface iUserContext
	{
		long ID { get; }
		string Name { get;  }
		string Surname { get;  }
		byte Type { get;  }
		string RoleIDs { get; set; }
	}
}
