using System;
namespace GSSystem.Model
{
	/// <summary>
	/// SummerType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SummerType
	{
		public SummerType()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _shssinwtemp;
		private string _shssbackwtemp;
		private string _shsscwater;
		private string _suewstemp;
		private string _suebwtemp;
		private string _suecircul;
		private string _srtemprange;
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
		public string SHSSInWTemp
		{
			set{ _shssinwtemp=value;}
			get{return _shssinwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SHSSBackWTemp
		{
			set{ _shssbackwtemp=value;}
			get{return _shssbackwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SHSSCWater
		{
			set{ _shsscwater=value;}
			get{return _shsscwater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUEWSTemp
		{
			set{ _suewstemp=value;}
			get{return _suewstemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUEBWTemp
		{
			set{ _suebwtemp=value;}
			get{return _suebwtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUECircul
		{
			set{ _suecircul=value;}
			get{return _suecircul;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SRTempRange
		{
			set{ _srtemprange=value;}
			get{return _srtemprange;}
		}
		#endregion Model

	}
}

