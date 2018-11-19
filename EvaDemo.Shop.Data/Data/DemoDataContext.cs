using System.Data.Linq;
using System.Linq;
using System.Reflection;

namespace EvaDemo.Shop.Data
{
	public class DemoDataContext : System.Data.Linq.DataContext
	{
		public DemoDataContext(string connectingString)
			: base(connectingString) { }

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.Product$Detail", IsComposable = true)]
		public IQueryable<Product_DetailResult> Product_Detail([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> id)
		{
			return this.CreateMethodCallQuery<Product_DetailResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.Product$List", IsComposable = true)]
		public IQueryable<Product_ListResult> Product_List()
		{
			return this.CreateMethodCallQuery<Product_ListResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.User$Info", IsComposable = true)]
		public IQueryable<User_InfoResult> User_Info([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> id)
		{
			return this.CreateMethodCallQuery<User_InfoResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.User$Login", IsComposable = true)]
		public IQueryable<User_LoginResult> User_Login([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(80)")] string pwd)
		{
			return this.CreateMethodCallQuery<User_LoginResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, pwd);
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.User$Register")]
		public int User_Register([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(80)")] string pwd, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] ref System.Nullable<long> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, pwd, userID);
			userID = ((System.Nullable<long>)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.User$Update")]
		public int User_Update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> userID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string surname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string phone, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(40)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "Char(2)")] string country, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string state, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string city, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(100)")] string address1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(100)")] string address2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID, surname, phone, email, country, state, city, address1, address2);
			return ((int)(result.ReturnValue));
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.Product$Delete")]
		public int Product_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.Product$Edit")]
		public int Product_Edit([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(200)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(200)")] string detailInfo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> price, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "Int")] System.Nullable<int> qty)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, description, detailInfo, price, qty);
			return ((int)(result.ReturnValue));
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.Product$Add")]
		public int Product_Add([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(200)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(200)")] string detailInfo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "BigInt")] System.Nullable<long> price, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "Int")] System.Nullable<int> qty)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), description, detailInfo, price, qty);
			return ((int)(result.ReturnValue));
		}
	}
	public partial class User_LoginResult
	{

		private long _ID;

		private string _Name;

		private string _Surname;

		private byte _Type;

		private string _RoleIDs;

		public User_LoginResult()
		{
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", DbType = "BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Surname", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this._Surname = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Type", DbType = "TinyInt NOT NULL")]
		public byte Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this._Type = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RoleIDs", DbType = "NVarChar(MAX)")]
		public string RoleIDs
		{
			get
			{
				return this._RoleIDs;
			}
			set
			{
				if ((this._RoleIDs != value))
				{
					this._RoleIDs = value;
				}
			}
		}
	}

	public partial class Product_DetailResult
	{

		private long _ID;

		private string _Description;

		private string _DetailInfo;

		private long _Price;

		private int _TotalQty;

		private int _LockedQty;

		private System.DateTime _CreatedOn;

		public Product_DetailResult()
		{
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", DbType = "BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Description", DbType = "NVarChar(200) NOT NULL", CanBeNull = false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DetailInfo", DbType = "NVarChar(200) NOT NULL", CanBeNull = false)]
		public string DetailInfo
		{
			get
			{
				return this._DetailInfo;
			}
			set
			{
				if ((this._DetailInfo != value))
				{
					this._DetailInfo = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Price", DbType = "BigInt NOT NULL")]
		public long Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TotalQty", DbType = "Int NOT NULL")]
		public int TotalQty
		{
			get
			{
				return this._TotalQty;
			}
			set
			{
				if ((this._TotalQty != value))
				{
					this._TotalQty = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LockedQty", DbType = "Int NOT NULL")]
		public int LockedQty
		{
			get
			{
				return this._LockedQty;
			}
			set
			{
				if ((this._LockedQty != value))
				{
					this._LockedQty = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CreatedOn", DbType = "DateTime2 NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
	}

	public partial class Product_ListResult
	{

		private long _ID;

		private string _Description;

		private long _Price;

		private int _TotalQty;

		private int _LockedQty;

		private System.DateTime _CreatedOn;

		public Product_ListResult()
		{
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", DbType = "BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Description", DbType = "NVarChar(200) NOT NULL", CanBeNull = false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Price", DbType = "BigInt NOT NULL")]
		public long Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TotalQty", DbType = "Int NOT NULL")]
		public int TotalQty
		{
			get
			{
				return this._TotalQty;
			}
			set
			{
				if ((this._TotalQty != value))
				{
					this._TotalQty = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LockedQty", DbType = "Int NOT NULL")]
		public int LockedQty
		{
			get
			{
				return this._LockedQty;
			}
			set
			{
				if ((this._LockedQty != value))
				{
					this._LockedQty = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CreatedOn", DbType = "DateTime2 NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
	}

	public partial class User_InfoResult
	{

		private long _ID;

		private string _Name;

		private string _Surname;

		private string _Phone;

		private string _Email;

		private string _Country;

		private string _State;

		private string _City;

		private string _Address1;

		private string _Address2;

		public User_InfoResult()
		{
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", DbType = "BigInt NOT NULL")]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Surname", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this._Surname = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Phone", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Email", DbType = "NVarChar(40) NOT NULL", CanBeNull = false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Country", DbType = "Char(2) NOT NULL", CanBeNull = false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_State", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_City", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Address1", DbType = "NVarChar(100) NOT NULL", CanBeNull = false)]
		public string Address1
		{
			get
			{
				return this._Address1;
			}
			set
			{
				if ((this._Address1 != value))
				{
					this._Address1 = value;
				}
			}
		}

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Address2", DbType = "NVarChar(100) NOT NULL", CanBeNull = false)]
		public string Address2
		{
			get
			{
				return this._Address2;
			}
			set
			{
				if ((this._Address2 != value))
				{
					this._Address2 = value;
				}
			}
		}
	}
}
