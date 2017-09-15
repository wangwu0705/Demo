using System;
namespace GSSystem.Model
{
	/// <summary>
	/// SeaWater:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SeaWater
	{
		public SeaWater()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _type;
		private string _dowtherm;
		private string _swwellnum;
		private string _swwelldep;
		private string _cwpnum;
		private string _cwphead;
		private string _cwpflow;
		private string _cwppower;
		private string _exheattype;
		private string _exheatnum;
		private string _exheatarea;
		private string _swintemp;
		private string _swouttemp;
		private string _seawaterflow;
		private string _desandernum;
		private string _desandertype;
		private string _softwtsize;
		private string _softwtype;
		private string _wpnum;
		private string _wppower;
		private string _pvariablefre;
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
		public string SWWellNum
		{
			set{ _swwellnum=value;}
			get{return _swwellnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWWellDep
		{
			set{ _swwelldep=value;}
			get{return _swwelldep;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CWPNum
		{
			set{ _cwpnum=value;}
			get{return _cwpnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CWPHead
		{
			set{ _cwphead=value;}
			get{return _cwphead;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CWPFlow
		{
			set{ _cwpflow=value;}
			get{return _cwpflow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CWPPower
		{
			set{ _cwppower=value;}
			get{return _cwppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExHeatType
		{
			set{ _exheattype=value;}
			get{return _exheattype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExHeatNum
		{
			set{ _exheatnum=value;}
			get{return _exheatnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExHeatArea
		{
			set{ _exheatarea=value;}
			get{return _exheatarea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWInTemp
		{
			set{ _swintemp=value;}
			get{return _swintemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWOutTemp
		{
			set{ _swouttemp=value;}
			get{return _swouttemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SeaWaterFlow
		{
			set{ _seawaterflow=value;}
			get{return _seawaterflow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DesanderNum
		{
			set{ _desandernum=value;}
			get{return _desandernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DesanderType
		{
			set{ _desandertype=value;}
			get{return _desandertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SoftWTSize
		{
			set{ _softwtsize=value;}
			get{return _softwtsize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SoftWType
		{
			set{ _softwtype=value;}
			get{return _softwtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPNum
		{
			set{ _wpnum=value;}
			get{return _wpnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPpower
		{
			set{ _wppower=value;}
			get{return _wppower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PVariableFre
		{
			set{ _pvariablefre=value;}
			get{return _pvariablefre;}
		}
		#endregion Model

	}
}

