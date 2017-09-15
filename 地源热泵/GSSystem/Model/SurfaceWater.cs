using System;
namespace GSSystem.Model
{
	/// <summary>
	/// SurfaceWater:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SurfaceWater
	{
		public SurfaceWater()
		{}
		#region Model
		private int _id;
		private string _proname;
		private string _wtype;
		private string _type;
		private string _dowtherm;
		private string _wpnum;
		private string _wphead;
		private string _wpflow;
		private string _wppower;
		private string _hetype;
		private string _henum;
		private string _heheatarea;
		private string _switemp;
		private string _swotemp;
		private string _swflow;
		private string _dnum;
		private string _dtype;
		private string _swtsize;
		private string _swttype;
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
		public string WPNum
		{
			set{ _wpnum=value;}
			get{return _wpnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPHead
		{
			set{ _wphead=value;}
			get{return _wphead;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPFlow
		{
			set{ _wpflow=value;}
			get{return _wpflow;}
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
		public string HEHeatArea
		{
			set{ _heheatarea=value;}
			get{return _heheatarea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWITemp
		{
			set{ _switemp=value;}
			get{return _switemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWOTemp
		{
			set{ _swotemp=value;}
			get{return _swotemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWFlow
		{
			set{ _swflow=value;}
			get{return _swflow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DNum
		{
			set{ _dnum=value;}
			get{return _dnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DType
		{
			set{ _dtype=value;}
			get{return _dtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWTSize
		{
			set{ _swtsize=value;}
			get{return _swtsize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SWTType
		{
			set{ _swttype=value;}
			get{return _swttype;}
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

