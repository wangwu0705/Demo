using System;
namespace GSSystem.Model
{
	/// <summary>
	/// HSSCP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HSSCP
	{
		public HSSCP()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private int? _hsscpnum;
		private string _hsscppower;
		private string _hsscphead;
		private string _hsscpflow;
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
		public int? HSSCPNum
		{
			set{ _hsscpnum=value;}
			get{return _hsscpnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HSSCPPower
		{
			set{ _hsscppower=value;}
			get{return _hsscppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HSSCPHead
		{
			set{ _hsscphead=value;}
			get{return _hsscphead;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HSSCPFlow
		{
			set{ _hsscpflow=value;}
			get{return _hsscpflow;}
		}
		#endregion Model

	}
}

