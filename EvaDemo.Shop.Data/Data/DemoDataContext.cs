using System.Linq;
using System.Reflection;
using Zebra.Data.Linq;

namespace EvaDemo.Shop.Data
{
	public class ConnectionStringOptionsExtension : IDataContextOptionsExtension
	{
		public string ConnectionString { get; private set; }
		public virtual ConnectionStringOptionsExtension WithConnectionString(string connectionString)
		{
			ConnectionString = connectionString;
			return this;
		}
	}
	public class DataContext : System.Data.Linq.DataContext, IDataContext
	{
		protected DataContext(DataContextOptions contextOptions)
			: this(contextOptions.FindExtension<ConnectionStringOptionsExtension>().ConnectionString)
		{

		}
		protected DataContext(string connection) : base(connection)
		{

		}
	}
	public class DemoDataContext : DataContext
	{
		public DemoDataContext(DataContextOptions<DemoDataContext> options)
			: base(options)
		{
		}

		[global::System.Data.Linq.Mapping.FunctionAttribute(Name = "shop.User$Login", IsComposable = true)]
		public IQueryable<User_LoginResult> User_Login([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(20)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(80)")] string pwd)
		{
			return this.CreateMethodCallQuery<User_LoginResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, pwd);
		}

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
	}

	public partial class Product_ListResult
	{

		private long _ID;

		private string _Description;

		private long _Price;

		private int _TotalQty;

		private int _LockedQty;

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
	}
}
