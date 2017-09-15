using System;
namespace GSSystem.Model
{
	/// <summary>
	/// ProjectCommonCity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProjectCommonCity
	{
		public ProjectCommonCity()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _proadd;
		private string _protype;
		private string _conunit;
		private string _hpmanufacturer;
		private DateTime _fintime;
		private string _coveredarea;
		private string _hptype;
		private string _engcharacter;
		private string _useformat;
		private string _terminalform;
		private int? _projectthhp;
		private int? _projecttchp;
		private string _hpequipmenttype;
		private int? _hpequipmentnum;
		private string _nominalheat;
		private string _nominalcool;
		private string _heatinputpower;
		private string _coolinputpower;
		private string _wtype;
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
		public string ProAdd
		{
			set{ _proadd=value;}
			get{return _proadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProType
		{
			set{ _protype=value;}
			get{return _protype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConUnit
		{
			set{ _conunit=value;}
			get{return _conunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HpManufacturer
		{
			set{ _hpmanufacturer=value;}
			get{return _hpmanufacturer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FinTime
		{
			set{ _fintime=value;}
			get{return _fintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoveredArea
		{
			set{ _coveredarea=value;}
			get{return _coveredarea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HpType
		{
			set{ _hptype=value;}
			get{return _hptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EngCharacter
		{
			set{ _engcharacter=value;}
			get{return _engcharacter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UseFormat
		{
			set{ _useformat=value;}
			get{return _useformat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TerminalForm
		{
			set{ _terminalform=value;}
			get{return _terminalform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProjectTHHp
		{
			set{ _projectthhp=value;}
			get{return _projectthhp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProjectTCHp
		{
			set{ _projecttchp=value;}
			get{return _projecttchp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HpEquipmentType
		{
			set{ _hpequipmenttype=value;}
			get{return _hpequipmenttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HpEquipmentNum
		{
			set{ _hpequipmentnum=value;}
			get{return _hpequipmentnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NominalHeat
		{
			set{ _nominalheat=value;}
			get{return _nominalheat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NominalCool
		{
			set{ _nominalcool=value;}
			get{return _nominalcool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeatInputPower
		{
			set{ _heatinputpower=value;}
			get{return _heatinputpower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoolInputPower
		{
			set{ _coolinputpower=value;}
			get{return _coolinputpower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WType
		{
			set{ _wtype=value;}
			get{return _wtype;}
		}
		#endregion Model

	}
}

