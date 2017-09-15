using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:UndergroundWater
	/// </summary>
	public partial class UndergroundWater
	{
		public UndergroundWater()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.UndergroundWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UndergroundWater(");
			strSql.Append("ProName,WType,WellNum,WEWNum,RWNum,WellDepth,SWWExtract,HeatTime,CoolTime,WPDiameter,WPipe,BWPDiameter,BWPipe,DModel,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WPPower,PVFreque)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@WellNum,@WEWNum,@RWNum,@WellDepth,@SWWExtract,@HeatTime,@CoolTime,@WPDiameter,@WPipe,@BWPDiameter,@BWPipe,@DModel,@WTIModel,@CPETModel,@CPETNum,@FWTSize,@WSPNum,@WPPower,@PVFreque)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@WellNum", SqlDbType.VarChar,5),
					new SqlParameter("@WEWNum", SqlDbType.VarChar,5),
					new SqlParameter("@RWNum", SqlDbType.VarChar,5),
					new SqlParameter("@WellDepth", SqlDbType.VarChar,5),
					new SqlParameter("@SWWExtract", SqlDbType.VarChar,5),
					new SqlParameter("@HeatTime", SqlDbType.VarChar,5),
					new SqlParameter("@CoolTime", SqlDbType.VarChar,5),
					new SqlParameter("@WPDiameter", SqlDbType.VarChar,5),
					new SqlParameter("@WPipe", SqlDbType.VarChar,5),
					new SqlParameter("@BWPDiameter", SqlDbType.VarChar,5),
					new SqlParameter("@BWPipe", SqlDbType.VarChar,5),
					new SqlParameter("@DModel", SqlDbType.VarChar,5),
					new SqlParameter("@WTIModel", SqlDbType.VarChar,5),
					new SqlParameter("@CPETModel", SqlDbType.VarChar,5),
					new SqlParameter("@CPETNum", SqlDbType.VarChar,5),
					new SqlParameter("@FWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,5),
					new SqlParameter("@WPPower", SqlDbType.VarChar,5),
					new SqlParameter("@PVFreque", SqlDbType.VarChar,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.WellNum;
			parameters[3].Value = model.WEWNum;
			parameters[4].Value = model.RWNum;
			parameters[5].Value = model.WellDepth;
			parameters[6].Value = model.SWWExtract;
			parameters[7].Value = model.HeatTime;
			parameters[8].Value = model.CoolTime;
			parameters[9].Value = model.WPDiameter;
			parameters[10].Value = model.WPipe;
			parameters[11].Value = model.BWPDiameter;
			parameters[12].Value = model.BWPipe;
			parameters[13].Value = model.DModel;
			parameters[14].Value = model.WTIModel;
			parameters[15].Value = model.CPETModel;
			parameters[16].Value = model.CPETNum;
			parameters[17].Value = model.FWTSize;
			parameters[18].Value = model.WSPNum;
			parameters[19].Value = model.WPPower;
			parameters[20].Value = model.PVFreque;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GSSystem.Model.UndergroundWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UndergroundWater set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("WellNum=@WellNum,");
			strSql.Append("WEWNum=@WEWNum,");
			strSql.Append("RWNum=@RWNum,");
			strSql.Append("WellDepth=@WellDepth,");
			strSql.Append("SWWExtract=@SWWExtract,");
			strSql.Append("HeatTime=@HeatTime,");
			strSql.Append("CoolTime=@CoolTime,");
			strSql.Append("WPDiameter=@WPDiameter,");
			strSql.Append("WPipe=@WPipe,");
			strSql.Append("BWPDiameter=@BWPDiameter,");
			strSql.Append("BWPipe=@BWPipe,");
			strSql.Append("DModel=@DModel,");
			strSql.Append("WTIModel=@WTIModel,");
			strSql.Append("CPETModel=@CPETModel,");
			strSql.Append("CPETNum=@CPETNum,");
			strSql.Append("FWTSize=@FWTSize,");
			strSql.Append("WSPNum=@WSPNum,");
			strSql.Append("WPPower=@WPPower,");
			strSql.Append("PVFreque=@PVFreque");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@WellNum", SqlDbType.VarChar,5),
					new SqlParameter("@WEWNum", SqlDbType.VarChar,5),
					new SqlParameter("@RWNum", SqlDbType.VarChar,5),
					new SqlParameter("@WellDepth", SqlDbType.VarChar,5),
					new SqlParameter("@SWWExtract", SqlDbType.VarChar,5),
					new SqlParameter("@HeatTime", SqlDbType.VarChar,5),
					new SqlParameter("@CoolTime", SqlDbType.VarChar,5),
					new SqlParameter("@WPDiameter", SqlDbType.VarChar,5),
					new SqlParameter("@WPipe", SqlDbType.VarChar,5),
					new SqlParameter("@BWPDiameter", SqlDbType.VarChar,5),
					new SqlParameter("@BWPipe", SqlDbType.VarChar,5),
					new SqlParameter("@DModel", SqlDbType.VarChar,5),
					new SqlParameter("@WTIModel", SqlDbType.VarChar,5),
					new SqlParameter("@CPETModel", SqlDbType.VarChar,5),
					new SqlParameter("@CPETNum", SqlDbType.VarChar,5),
					new SqlParameter("@FWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,5),
					new SqlParameter("@WPPower", SqlDbType.VarChar,5),
					new SqlParameter("@PVFreque", SqlDbType.VarChar,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.WellNum;
			parameters[3].Value = model.WEWNum;
			parameters[4].Value = model.RWNum;
			parameters[5].Value = model.WellDepth;
			parameters[6].Value = model.SWWExtract;
			parameters[7].Value = model.HeatTime;
			parameters[8].Value = model.CoolTime;
			parameters[9].Value = model.WPDiameter;
			parameters[10].Value = model.WPipe;
			parameters[11].Value = model.BWPDiameter;
			parameters[12].Value = model.BWPipe;
			parameters[13].Value = model.DModel;
			parameters[14].Value = model.WTIModel;
			parameters[15].Value = model.CPETModel;
			parameters[16].Value = model.CPETNum;
			parameters[17].Value = model.FWTSize;
			parameters[18].Value = model.WSPNum;
			parameters[19].Value = model.WPPower;
			parameters[20].Value = model.PVFreque;
			parameters[21].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UndergroundWater ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UndergroundWater ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GSSystem.Model.UndergroundWater GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,WellNum,WEWNum,RWNum,WellDepth,SWWExtract,HeatTime,CoolTime,WPDiameter,WPipe,BWPDiameter,BWPipe,DModel,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WPPower,PVFreque from UndergroundWater ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.UndergroundWater model=new GSSystem.Model.UndergroundWater();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GSSystem.Model.UndergroundWater DataRowToModel(DataRow row)
		{
			GSSystem.Model.UndergroundWater model=new GSSystem.Model.UndergroundWater();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["ProName"]!=null)
				{
					model.ProName=row["ProName"].ToString();
				}
				if(row["WType"]!=null)
				{
					model.WType=row["WType"].ToString();
				}
				if(row["WellNum"]!=null)
				{
					model.WellNum=row["WellNum"].ToString();
				}
				if(row["WEWNum"]!=null)
				{
					model.WEWNum=row["WEWNum"].ToString();
				}
				if(row["RWNum"]!=null)
				{
					model.RWNum=row["RWNum"].ToString();
				}
				if(row["WellDepth"]!=null)
				{
					model.WellDepth=row["WellDepth"].ToString();
				}
				if(row["SWWExtract"]!=null)
				{
					model.SWWExtract=row["SWWExtract"].ToString();
				}
				if(row["HeatTime"]!=null)
				{
					model.HeatTime=row["HeatTime"].ToString();
				}
				if(row["CoolTime"]!=null)
				{
					model.CoolTime=row["CoolTime"].ToString();
				}
				if(row["WPDiameter"]!=null)
				{
					model.WPDiameter=row["WPDiameter"].ToString();
				}
				if(row["WPipe"]!=null)
				{
					model.WPipe=row["WPipe"].ToString();
				}
				if(row["BWPDiameter"]!=null)
				{
					model.BWPDiameter=row["BWPDiameter"].ToString();
				}
				if(row["BWPipe"]!=null)
				{
					model.BWPipe=row["BWPipe"].ToString();
				}
				if(row["DModel"]!=null)
				{
					model.DModel=row["DModel"].ToString();
				}
				if(row["WTIModel"]!=null)
				{
					model.WTIModel=row["WTIModel"].ToString();
				}
				if(row["CPETModel"]!=null)
				{
					model.CPETModel=row["CPETModel"].ToString();
				}
				if(row["CPETNum"]!=null)
				{
					model.CPETNum=row["CPETNum"].ToString();
				}
				if(row["FWTSize"]!=null)
				{
					model.FWTSize=row["FWTSize"].ToString();
				}
				if(row["WSPNum"]!=null)
				{
					model.WSPNum=row["WSPNum"].ToString();
				}
				if(row["WPPower"]!=null)
				{
					model.WPPower=row["WPPower"].ToString();
				}
				if(row["PVFreque"]!=null)
				{
					model.PVFreque=row["PVFreque"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,ProName,WType,WellNum,WEWNum,RWNum,WellDepth,SWWExtract,HeatTime,CoolTime,WPDiameter,WPipe,BWPDiameter,BWPipe,DModel,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WPPower,PVFreque ");
			strSql.Append(" FROM UndergroundWater ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,ProName,WType,WellNum,WEWNum,RWNum,WellDepth,SWWExtract,HeatTime,CoolTime,WPDiameter,WPipe,BWPDiameter,BWPipe,DModel,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WPPower,PVFreque ");
			strSql.Append(" FROM UndergroundWater ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM UndergroundWater ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from UndergroundWater T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "UndergroundWater";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

