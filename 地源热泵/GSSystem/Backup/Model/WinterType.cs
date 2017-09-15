using System;
namespace GSSystem.Model
{
	/// <summary>
	/// WinterType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WinterType
	{
		public WinterType()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _wwpwtemp;
		private string _wwrwtemp;
		private string _whssinwtemp;
		private string _whssbackwtemp;
		private string _whsscwater;
		private string _wuewstemp;
		private string _wuebwtemp;
		private string _wuecircul;
		private string _wrtemperange;
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
		public string WWPWTemp
		{
			set{ _wwpwtemp=value;}
			get{return _wwpwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WWRWTemp
		{
			set{ _wwrwtemp=value;}
			get{return _wwrwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WHSSInWTemp
		{
			set{ _whssinwtemp=value;}
			get{return _whssinwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WHSSBackWTemp
		{
			set{ _whssbackwtemp=value;}
			get{return _whssbackwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WHSSCWater
		{
			set{ _whsscwater=value;}
			get{return _whsscwater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WUEWSTemp
		{
			set{ _wuewstemp=value;}
			get{return _wuewstemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WUEBWTemp
		{
			set{ _wuebwtemp=value;}
			get{return _wuebwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WUECircul
		{
			set{ _wuecircul=value;}
			get{return _wuecircul;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WRTempeRange
		{
			set{ _wrtemperange=value;}
			get{return _wrtemperange;}
		}
		#endregion Model

	}
}

