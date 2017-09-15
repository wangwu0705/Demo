using System;
namespace GSSystem.Model
{
	/// <summary>
	/// ProjectAdsClass:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProjectAdsClass
	{
		public ProjectAdsClass()
		{}
		#region Model
		private int _id;
		private string _projectads;
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
		public string ProjectAds
		{
			set{ _projectads=value;}
			get{return _projectads;}
		}
		#endregion Model

	}
}

