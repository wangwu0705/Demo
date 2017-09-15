using System;
namespace GSSystem.Model
{
	/// <summary>
	/// SoilSource:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SoilSource
	{
		public SoilSource()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _pholenum;
		private string _holedepth;
		private string _holedistance;
		private string _uhematerial;
		private string _uhediameter;
		private string _heattime;
		private string _cooltime;
		private string _bpformat;
		private string _uheutype;
		private string _uhesparallel;
		private string _uhetotallen;
		private string _wtimodel;
		private string _cpetmodel;
		private string _cpetnum;
		private string _fwtsize;
		private string _wspnum;
		private string _wsppower;
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
		public string PHoleNum
		{
			set{ _pholenum=value;}
			get{return _pholenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HoleDepth
		{
			set{ _holedepth=value;}
			get{return _holedepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HoleDistance
		{
			set{ _holedistance=value;}
			get{return _holedistance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UHEMaterial
		{
			set{ _uhematerial=value;}
			get{return _uhematerial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UHEDiameter
		{
			set{ _uhediameter=value;}
			get{return _uhediameter;}
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
		public string BPFormat
		{
			set{ _bpformat=value;}
			get{return _bpformat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UHEUType
		{
			set{ _uheutype=value;}
			get{return _uheutype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UHESparallel
		{
			set{ _uhesparallel=value;}
			get{return _uhesparallel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UHETotalLen
		{
			set{ _uhetotallen=value;}
			get{return _uhetotallen;}
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
		public string WSPPower
		{
			set{ _wsppower=value;}
			get{return _wsppower;}
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

