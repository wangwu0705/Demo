using System;
namespace GSSystem.Model
{
	/// <summary>
	/// UndergroundWater:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UndergroundWater
	{
		public UndergroundWater()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _wellnum;
		private string _wewnum;
		private string _rwnum;
		private string _welldepth;
		private string _swwextract;
		private string _heattime;
		private string _cooltime;
		private string _wpdiameter;
		private string _wpipe;
		private string _bwpdiameter;
		private string _bwpipe;
		private string _dmodel;
		private string _wtimodel;
		private string _cpetmodel;
		private string _cpetnum;
		private string _fwtsize;
		private string _wspnum;
		private string _wppower;
		private string _pvfreque;
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
		public string WellNum
		{
			set{ _wellnum=value;}
			get{return _wellnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WEWNum
		{
			set{ _wewnum=value;}
			get{return _wewnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RWNum
		{
			set{ _rwnum=value;}
			get{return _rwnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellDepth
		{
			set{ _welldepth=value;}
			get{return _welldepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWWExtract
		{
			set{ _swwextract=value;}
			get{return _swwextract;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeatTime
		{
			set{ _heattime=value;}
			get{return _heattime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoolTime
		{
			set{ _cooltime=value;}
			get{return _cooltime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPDiameter
		{
			set{ _wpdiameter=value;}
			get{return _wpdiameter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPipe
		{
			set{ _wpipe=value;}
			get{return _wpipe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BWPDiameter
		{
			set{ _bwpdiameter=value;}
			get{return _bwpdiameter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BWPipe
		{
			set{ _bwpipe=value;}
			get{return _bwpipe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DModel
		{
			set{ _dmodel=value;}
			get{return _dmodel;}
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
		public string CPETModel
		{
			set{ _cpetmodel=value;}
			get{return _cpetmodel;}
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
		public string WPPower
		{
			set{ _wppower=value;}
			get{return _wppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PVFreque
		{
			set{ _pvfreque=value;}
			get{return _pvfreque;}
		}
		#endregion Model

	}
}

