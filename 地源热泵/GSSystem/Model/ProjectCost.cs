using System;
namespace GSSystem.Model
{
	/// <summary>
	/// ProjectCost:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProjectCost
	{
		public ProjectCost()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _prototalcost;
		private string _unitcost;
		private string _systemcost;
		private string _protel;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProName
		{
			set{ _proname=value;}
			get{return _proname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WType
		{
			set{ _wtype=value;}
			get{return _wtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProTotalCost
		{
			set{ _prototalcost=value;}
			get{return _prototalcost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnitCost
		{
			set{ _unitcost=value;}
			get{return _unitcost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SystemCost
		{
			set{ _systemcost=value;}
			get{return _systemcost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProTel
		{
			set{ _protel=value;}
			get{return _protel;}
		}
		#endregion Model

	}
}

