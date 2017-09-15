using System;
namespace GSSystem.Model
{
	/// <summary>
	/// WasteWater:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WasteWater
	{
		public WasteWater()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _type;
		private string _dowtherm;
		private string _spnum;
		private string _sphead;
		private string _spflow;
		private string _sppower;
		private string _hetype;
		private string _henum;
		private string _hehearea;
		private string _sintemp;
		private string _souttemp;
		private string _sflow;
		private string _wtimodel;
		private string _cpetmode;
		private string _cpetnum;
		private string _fwtsize;
		private string _wspnum;
		private string _wsppower;
		private string _pvfrequ;
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
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Dowtherm
		{
			set{ _dowtherm=value;}
			get{return _dowtherm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPNum
		{
			set{ _spnum=value;}
			get{return _spnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPHead
		{
			set{ _sphead=value;}
			get{return _sphead;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPFlow
		{
			set{ _spflow=value;}
			get{return _spflow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPPower
		{
			set{ _sppower=value;}
			get{return _sppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEType
		{
			set{ _hetype=value;}
			get{return _hetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HENum
		{
			set{ _henum=value;}
			get{return _henum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEHEArea
		{
			set{ _hehearea=value;}
			get{return _hehearea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SInTemp
		{
			set{ _sintemp=value;}
			get{return _sintemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SOutTemp
		{
			set{ _souttemp=value;}
			get{return _souttemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SFlow
		{
			set{ _sflow=value;}
			get{return _sflow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WTIModel
		{
			set{ _wtimodel=value;}
			get{return _wtimodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPETMode
		{
			set{ _cpetmode=value;}
			get{return _cpetmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPETNum
		{
			set{ _cpetnum=value;}
			get{return _cpetnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FWTSize
		{
			set{ _fwtsize=value;}
			get{return _fwtsize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WSPNum
		{
			set{ _wspnum=value;}
			get{return _wspnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WSPPower
		{
			set{ _wsppower=value;}
			get{return _wsppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PVFrequ
		{
			set{ _pvfrequ=value;}
			get{return _pvfrequ;}
		}
		#endregion Model

	}
}

