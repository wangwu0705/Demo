using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:SurfaceWater
	/// </summary>
	public partial class SurfaceWater
	{
		public SurfaceWater()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.SurfaceWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SurfaceWater(");
			strSql.Append("ProName,WType,Type,Dowtherm,WPNum,WPHead,WPFlow,WPPower,HEType,HENum,HEHeatArea,SWITemp,SWOTemp,SWFlow,DNum,DType,SWTSize,SWTType,WSPNum,WSPPower,PVFrequ)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@Type,@Dowtherm,@WPNum,@WPHead,@WPFlow,@WPPower,@HEType,@HENum,@HEHeatArea,@SWITemp,@SWOTemp,@SWFlow,@DNum,@DType,@SWTSize,@SWTType,@WSPNum,@WSPPower,@PVFrequ)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,50),
					new SqlParameter("@WType", SqlDbType.VarChar,50),
					new SqlParameter("@Type", SqlDbType.VarChar,50),
					new SqlParameter("@Dowtherm", SqlDbType.VarChar,50),
					new SqlParameter("@WPNum", SqlDbType.VarChar,50),
					new SqlParameter("@WPHead", SqlDbType.VarChar,50),
					new SqlParameter("@WPFlow", SqlDbType.VarChar,50),
					new SqlParameter("@WPPower", SqlDbType.VarChar,50),
					new SqlParameter("@HEType", SqlDbType.VarChar,50),
					new SqlParameter("@HENum", SqlDbType.VarChar,50),
					new SqlParameter("@HEHeatArea", SqlDbType.VarChar,50),
					new SqlParameter("@SWITemp", SqlDbType.VarChar,50),
					new SqlParameter("@SWOTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SWFlow", SqlDbType.VarChar,50),
					new SqlParameter("@DNum", SqlDbType.VarChar,50),
					new SqlParameter("@DType", SqlDbType.VarChar,50),
					new SqlParameter("@SWTSize", SqlDbType.VarChar,50),
					new SqlParameter("@SWTType", SqlDbType.VarChar,50),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,50),
					new SqlParameter("@WSPPower", SqlDbType.VarChar,50),
					new SqlParameter("@PVFrequ", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Dowtherm;
			parameters[4].Value = model.WPNum;
			parameters[5].Value = model.WPHead;
			parameters[6].Value = model.WPFlow;
			parameters[7].Value = model.WPPower;
			parameters[8].Value = model.HEType;
			parameters[9].Value = model.HENum;
			parameters[10].Value = model.HEHeatArea;
			parameters[11].Value = model.SWITemp;
			parameters[12].Value = model.SWOTemp;
			parameters[13].Value = model.SWFlow;
			parameters[14].Value = model.DNum;
			parameters[15].Value = model.DType;
			parameters[16].Value = model.SWTSize;
			parameters[17].Value = model.SWTType;
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
		public bool Update(GSSystem.Model.SurfaceWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SurfaceWater set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("Type=@Type,");
			strSql.Append("Dowtherm=@Dowtherm,");
			strSql.Append("WPNum=@WPNum,");
			strSql.Append("WPHead=@WPHead,");
			strSql.Append("WPFlow=@WPFlow,");
			strSql.Append("WPPower=@WPPower,");
			strSql.Append("HEType=@HEType,");
			strSql.Append("HENum=@HENum,");
			strSql.Append("HEHeatArea=@HEHeatArea,");
			strSql.Append("SWITemp=@SWITemp,");
			strSql.Append("SWOTemp=@SWOTemp,");
			strSql.Append("SWFlow=@SWFlow,");
			strSql.Append("DNum=@DNum,");
			strSql.Append("DType=@DType,");
			strSql.Append("SWTSize=@SWTSize,");
			strSql.Append("SWTType=@SWTType,");
			strSql.Append("WSPNum=@WSPNum,");
			strSql.Append("WSPPower=@WSPPower,");
			strSql.Append("PVFrequ=@PVFrequ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,50),
					new SqlParameter("@WType", SqlDbType.VarChar,50),
					new SqlParameter("@Type", SqlDbType.VarChar,50),
					new SqlParameter("@Dowtherm", SqlDbType.VarChar,50),
					new SqlParameter("@WPNum", SqlDbType.VarChar,50),
					new SqlParameter("@WPHead", SqlDbType.VarChar,50),
					new SqlParameter("@WPFlow", SqlDbType.VarChar,50),
					new SqlParameter("@WPPower", SqlDbType.VarChar,50),
					new SqlParameter("@HEType", SqlDbType.VarChar,50),
					new SqlParameter("@HENum", SqlDbType.VarChar,50),
					new SqlParameter("@HEHeatArea", SqlDbType.VarChar,50),
					new SqlParameter("@SWITemp", SqlDbType.VarChar,50),
					new SqlParameter("@SWOTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SWFlow", SqlDbType.VarChar,50),
					new SqlParameter("@DNum", SqlDbType.VarChar,50),
					new SqlParameter("@DType", SqlDbType.VarChar,50),
					new SqlParameter("@SWTSize", SqlDbType.VarChar,50),
					new SqlParameter("@SWTType", SqlDbType.VarChar,50),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,50),
					new SqlParameter("@WSPPower", SqlDbType.VarChar,50),
					new SqlParameter("@PVFrequ", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Dowtherm;
			parameters[4].Value = model.WPNum;
			parameters[5].Value = model.WPHead;
			parameters[6].Value = model.WPFlow;
			parameters[7].Value = model.WPPower;
			parameters[8].Value = model.HEType;
			parameters[9].Value = model.HENum;
			parameters[10].Value = model.HEHeatArea;
			parameters[11].Value = model.SWITemp;
			parameters[12].Value = model.SWOTemp;
			parameters[13].Value = model.SWFlow;
			parameters[14].Value = model.DNum;
			parameters[15].Value = model.DType;
			parameters[16].Value = model.SWTSize;
			parameters[17].Value = model.SWTType;
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
			strSql.Append("delete from SurfaceWater ");
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
			strSql.Append("delete from SurfaceWater ");
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
		public GSSystem.Model.SurfaceWater GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,Type,Dowtherm,WPNum,WPHead,WPFlow,WPPower,HEType,HENum,HEHeatArea,SWITemp,SWOTemp,SWFlow,DNum,DType,SWTSize,SWTType,WSPNum,WSPPower,PVFrequ from SurfaceWater ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.SurfaceWater model=new GSSystem.Model.SurfaceWater();
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
		public GSSystem.Model.SurfaceWater DataRowToModel(DataRow row)
		{
			GSSystem.Model.SurfaceWater model=new GSSystem.Model.SurfaceWater();
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
				if(row["WPNum"]!=null)
				{
					model.WPNum=row["WPNum"].ToString();
				}
				if(row["WPHead"]!=null)
				{
					model.WPHead=row["WPHead"].ToString();
				}
				if(row["WPFlow"]!=null)
				{
					model.WPFlow=row["WPFlow"].ToString();
				}
				if(row["WPPower"]!=null)
				{
					model.WPPower=row["WPPower"].ToString();
				}
				if(row["HEType"]!=null)
				{
					model.HEType=row["HEType"].ToString();
				}
				if(row["HENum"]!=null)
				{
					model.HENum=row["HENum"].ToString();
				}
				if(row["HEHeatArea"]!=null)
				{
					model.HEHeatArea=row["HEHeatArea"].ToString();
				}
				if(row["SWITemp"]!=null)
				{
					model.SWITemp=row["SWITemp"].ToString();
				}
				if(row["SWOTemp"]!=null)
				{
					model.SWOTemp=row["SWOTemp"].ToString();
				}
				if(row["SWFlow"]!=null)
				{
					model.SWFlow=row["SWFlow"].ToString();
				}
				if(row["DNum"]!=null)
				{
					model.DNum=row["DNum"].ToString();
				}
				if(row["DType"]!=null)
				{
					model.DType=row["DType"].ToString();
				}
				if(row["SWTSize"]!=null)
				{
					model.SWTSize=row["SWTSize"].ToString();
				}
				if(row["SWTType"]!=null)
				{
					model.SWTType=row["SWTType"].ToString();
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
			strSql.Append("select id,ProName,WType,Type,Dowtherm,WPNum,WPHead,WPFlow,WPPower,HEType,HENum,HEHeatArea,SWITemp,SWOTemp,SWFlow,DNum,DType,SWTSize,SWTType,WSPNum,WSPPower,PVFrequ ");
			strSql.Append(" FROM SurfaceWater ");
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
			strSql.Append(" id,ProName,WType,Type,Dowtherm,WPNum,WPHead,WPFlow,WPPower,HEType,HENum,HEHeatArea,SWITemp,SWOTemp,SWFlow,DNum,DType,SWTSize,SWTType,WSPNum,WSPPower,PVFrequ ");
			strSql.Append(" FROM SurfaceWater ");
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
			strSql.Append("select count(1) FROM SurfaceWater ");
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
			strSql.Append(")AS Row, T.*  from SurfaceWater T ");
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
			parameters[0].Value = "SurfaceWater";
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

