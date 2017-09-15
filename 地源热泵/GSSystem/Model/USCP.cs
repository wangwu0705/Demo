using System;
namespace GSSystem.Model
{
	/// <summary>
	/// USCP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class USCP
	{
		public USCP()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private int? _uscpnum;
		private string _uscppower;
		private string _uscphead;
		private string _uscpflow;
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
		public int? USCPNum
		{
			set{ _uscpnum=value;}
			get{return _uscpnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USCPPower
		{
			set{ _uscppower=value;}
			get{return _uscppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USCPHead
		{
			set{ _uscphead=value;}
			get{return _uscphead;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USCPFlow
		{
			set{ _uscpflow=value;}
			get{return _uscpflow;}
		}
		#endregion Model

	}
}

