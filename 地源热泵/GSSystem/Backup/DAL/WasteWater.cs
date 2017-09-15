using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:WasteWater
	/// </summary>
	public partial class WasteWater
	{
		public WasteWater()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.WasteWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WasteWater(");
			strSql.Append("ProName,WType,Type,Dowtherm,SPNum,SPHead,SPFlow,SPPower,HEType,HENum,HEHEArea,SInTemp,SOutTemp,SFlow,WTIModel,CPETMode,CPETNum,FWTSize,WSPNum,WSPPower,PVFrequ)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@Type,@Dowtherm,@SPNum,@SPHead,@SPFlow,@SPPower,@HEType,@HENum,@HEHEArea,@SInTemp,@SOutTemp,@SFlow,@WTIModel,@CPETMode,@CPETNum,@FWTSize,@WSPNum,@WSPPower,@PVFrequ)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@Type", SqlDbType.VarChar,4),
					new SqlParameter("@Dowtherm", SqlDbType.VarChar,5),
					new SqlParameter("@SPNum", SqlDbType.VarChar,10),
					new SqlParameter("@SPHead", SqlDbType.VarChar,10),
					new SqlParameter("@SPFlow", SqlDbType.VarChar,10),
					new SqlParameter("@SPPower", SqlDbType.VarChar,10),
					new SqlParameter("@HEType", SqlDbType.VarChar,10),
					new SqlParameter("@HENum", SqlDbType.VarChar,10),
					new SqlParameter("@HEHEArea", SqlDbType.VarChar,10),
					new SqlParameter("@SInTemp", SqlDbType.VarChar,10),
					new SqlParameter("@SOutTemp", SqlDbType.VarChar,10),
					new SqlParameter("@SFlow", SqlDbType.VarChar,10),
					new SqlParameter("@WTIModel", SqlDbType.VarChar,10),
					new SqlParameter("@CPETMode", SqlDbType.VarChar,10),
					new SqlParameter("@CPETNum", SqlDbType.VarChar,10),
					new SqlParameter("@FWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,5),
					new SqlParameter("@WSPPower", SqlDbType.VarChar,5),
					new SqlParameter("@PVFrequ", SqlDbType.VarChar,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Dowtherm;
			parameters[4].Value = model.SPNum;
			parameters[5].Value = model.SPHead;
			parameters[6].Value = model.SPFlow;
			parameters[7].Value = model.SPPower;
			parameters[8].Value = model.HEType;
			parameters[9].Value = model.HENum;
			parameters[10].Value = model.HEHEArea;
			parameters[11].Value = model.SInTemp;
			parameters[12].Value = model.SOutTemp;
			parameters[13].Value = model.SFlow;
			parameters[14].Value = model.WTIModel;
			parameters[15].Value = model.CPETMode;
			parameters[16].Value = model.CPETNum;
			parameters[17].Value = model.FWTSize;
			parameters[18].Value = model.WSPNum;
			parameters[19].Value = model.WSPPower;
			parameters[20].Value = model.PVFrequ;

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
		public bool Update(GSSystem.Model.WasteWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WasteWater set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("Type=@Type,");
			strSql.Append("Dowtherm=@Dowtherm,");
			strSql.Append("SPNum=@SPNum,");
			strSql.Append("SPHead=@SPHead,");
			strSql.Append("SPFlow=@SPFlow,");
			strSql.Append("SPPower=@SPPower,");
			strSql.Append("HEType=@HEType,");
			strSql.Append("HENum=@HENum,");
			strSql.Append("HEHEArea=@HEHEArea,");
			strSql.Append("SInTemp=@SInTemp,");
			strSql.Append("SOutTemp=@SOutTemp,");
			strSql.Append("SFlow=@SFlow,");
			strSql.Append("WTIModel=@WTIModel,");
			strSql.Append("CPETMode=@CPETMode,");
			strSql.Append("CPETNum=@CPETNum,");
			strSql.Append("FWTSize=@FWTSize,");
			strSql.Append("WSPNum=@WSPNum,");
			strSql.Append("WSPPower=@WSPPower,");
			strSql.Append("PVFrequ=@PVFrequ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@Type", SqlDbType.VarChar,4),
					new SqlParameter("@Dowtherm", SqlDbType.VarChar,5),
					new SqlParameter("@SPNum", SqlDbType.VarChar,10),
					new SqlParameter("@SPHead", SqlDbType.VarChar,10),
					new SqlParameter("@SPFlow", SqlDbType.VarChar,10),
					new SqlParameter("@SPPower", SqlDbType.VarChar,10),
					new SqlParameter("@HEType", SqlDbType.VarChar,10),
					new SqlParameter("@HENum", SqlDbType.VarChar,10),
					new SqlParameter("@HEHEArea", SqlDbType.VarChar,10),
					new SqlParameter("@SInTemp", SqlDbType.VarChar,10),
					new SqlParameter("@SOutTemp", SqlDbType.VarChar,10),
					new SqlParameter("@SFlow", SqlDbType.VarChar,10),
					new SqlParameter("@WTIModel", SqlDbType.VarChar,10),
					new SqlParameter("@CPETMode", SqlDbType.VarChar,10),
					new SqlParameter("@CPETNum", SqlDbType.VarChar,10),
					new SqlParameter("@FWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,5),
					new SqlParameter("@WSPPower", SqlDbType.VarChar,5),
					new SqlParameter("@PVFrequ", SqlDbType.VarChar,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Dowtherm;
			parameters[4].Value = model.SPNum;
			parameters[5].Value = model.SPHead;
			parameters[6].Value = model.SPFlow;
			parameters[7].Value = model.SPPower;
			parameters[8].Value = model.HEType;
			parameters[9].Value = model.HENum;
			parameters[10].Value = model.HEHEArea;
			parameters[11].Value = model.SInTemp;
			parameters[12].Value = model.SOutTemp;
			parameters[13].Value = model.SFlow;
			parameters[14].Value = model.WTIModel;
			parameters[15].Value = model.CPETMode;
			parameters[16].Value = model.CPETNum;
			parameters[17].Value = model.FWTSize;
			parameters[18].Value = model.WSPNum;
			parameters[19].Value = model.WSPPower;
			parameters[20].Value = model.PVFrequ;
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
			strSql.Append("delete from WasteWater ");
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
			strSql.Append("delete from WasteWater ");
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
		public GSSystem.Model.WasteWater GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,Type,Dowtherm,SPNum,SPHead,SPFlow,SPPower,HEType,HENum,HEHEArea,SInTemp,SOutTemp,SFlow,WTIModel,CPETMode,CPETNum,FWTSize,WSPNum,WSPPower,PVFrequ from WasteWater ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.WasteWater model=new GSSystem.Model.WasteWater();
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
		public GSSystem.Model.WasteWater DataRowToModel(DataRow row)
		{
			GSSystem.Model.WasteWater model=new GSSystem.Model.WasteWater();
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
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["Dowtherm"]!=null)
				{
					model.Dowtherm=row["Dowtherm"].ToString();
				}
				if(row["SPNum"]!=null)
				{
					model.SPNum=row["SPNum"].ToString();
				}
				if(row["SPHead"]!=null)
				{
					model.SPHead=row["SPHead"].ToString();
				}
				if(row["SPFlow"]!=null)
				{
					model.SPFlow=row["SPFlow"].ToString();
				}
				if(row["SPPower"]!=null)
				{
					model.SPPower=row["SPPower"].ToString();
				}
				if(row["HEType"]!=null)
				{
					model.HEType=row["HEType"].ToString();
				}
				if(row["HENum"]!=null)
				{
					model.HENum=row["HENum"].ToString();
				}
				if(row["HEHEArea"]!=null)
				{
					model.HEHEArea=row["HEHEArea"].ToString();
				}
				if(row["SInTemp"]!=null)
				{
					model.SInTemp=row["SInTemp"].ToString();
				}
				if(row["SOutTemp"]!=null)
				{
					model.SOutTemp=row["SOutTemp"].ToString();
				}
				if(row["SFlow"]!=null)
				{
					model.SFlow=row["SFlow"].ToString();
				}
				if(row["WTIModel"]!=null)
				{
					model.WTIModel=row["WTIModel"].ToString();
				}
				if(row["CPETMode"]!=null)
				{
					model.CPETMode=row["CPETMode"].ToString();
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
				if(row["WSPPower"]!=null)
				{
					model.WSPPower=row["WSPPower"].ToString();
				}
				if(row["PVFrequ"]!=null)
				{
					model.PVFrequ=row["PVFrequ"].ToString();
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
			strSql.Append("select id,ProName,WType,Type,Dowtherm,SPNum,SPHead,SPFlow,SPPower,HEType,HENum,HEHEArea,SInTemp,SOutTemp,SFlow,WTIModel,CPETMode,CPETNum,FWTSize,WSPNum,WSPPower,PVFrequ ");
			strSql.Append(" FROM WasteWater ");
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
			strSql.Append(" id,ProName,WType,Type,Dowtherm,SPNum,SPHead,SPFlow,SPPower,HEType,HENum,HEHEArea,SInTemp,SOutTemp,SFlow,WTIModel,CPETMode,CPETNum,FWTSize,WSPNum,WSPPower,PVFrequ ");
			strSql.Append(" FROM WasteWater ");
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
			strSql.Append("select count(1) FROM WasteWater ");
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
			strSql.Append(")AS Row, T.*  from WasteWater T ");
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
			parameters[0].Value = "WasteWater";
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

