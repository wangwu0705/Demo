using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:SummerType
	/// </summary>
	public partial class SummerType
	{
		public SummerType()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.SummerType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SummerType(");
			strSql.Append("ProName,WType,SHSSInWTemp,SHSSBackWTemp,SHSSCWater,SUEWSTemp,SUEBWTemp,SUECircul,SRTempRange)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@SHSSInWTemp,@SHSSBackWTemp,@SHSSCWater,@SUEWSTemp,@SUEBWTemp,@SUECircul,@SRTempRange)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,50),
					new SqlParameter("@WType", SqlDbType.VarChar,50),
					new SqlParameter("@SHSSInWTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SHSSBackWTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SHSSCWater", SqlDbType.VarChar,50),
					new SqlParameter("@SUEWSTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SUEBWTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SUECircul", SqlDbType.VarChar,50),
					new SqlParameter("@SRTempRange", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.SHSSInWTemp;
			parameters[3].Value = model.SHSSBackWTemp;
			parameters[4].Value = model.SHSSCWater;
			parameters[5].Value = model.SUEWSTemp;
			parameters[6].Value = model.SUEBWTemp;
			parameters[7].Value = model.SUECircul;
			parameters[8].Value = model.SRTempRange;

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
		public bool Update(GSSystem.Model.SummerType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SummerType set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("SHSSInWTemp=@SHSSInWTemp,");
			strSql.Append("SHSSBackWTemp=@SHSSBackWTemp,");
			strSql.Append("SHSSCWater=@SHSSCWater,");
			strSql.Append("SUEWSTemp=@SUEWSTemp,");
			strSql.Append("SUEBWTemp=@SUEBWTemp,");
			strSql.Append("SUECircul=@SUECircul,");
			strSql.Append("SRTempRange=@SRTempRange");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,50),
					new SqlParameter("@WType", SqlDbType.VarChar,50),
					new SqlParameter("@SHSSInWTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SHSSBackWTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SHSSCWater", SqlDbType.VarChar,50),
					new SqlParameter("@SUEWSTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SUEBWTemp", SqlDbType.VarChar,50),
					new SqlParameter("@SUECircul", SqlDbType.VarChar,50),
					new SqlParameter("@SRTempRange", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.SHSSInWTemp;
			parameters[3].Value = model.SHSSBackWTemp;
			parameters[4].Value = model.SHSSCWater;
			parameters[5].Value = model.SUEWSTemp;
			parameters[6].Value = model.SUEBWTemp;
			parameters[7].Value = model.SUECircul;
			parameters[8].Value = model.SRTempRange;
			parameters[9].Value = model.id;

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
			strSql.Append("delete from SummerType ");
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
			strSql.Append("delete from SummerType ");
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
		public GSSystem.Model.SummerType GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,SHSSInWTemp,SHSSBackWTemp,SHSSCWater,SUEWSTemp,SUEBWTemp,SUECircul,SRTempRange from SummerType ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.SummerType model=new GSSystem.Model.SummerType();
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
		public GSSystem.Model.SummerType DataRowToModel(DataRow row)
		{
			GSSystem.Model.SummerType model=new GSSystem.Model.SummerType();
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
				if(row["SHSSInWTemp"]!=null)
				{
					model.SHSSInWTemp=row["SHSSInWTemp"].ToString();
				}
				if(row["SHSSBackWTemp"]!=null)
				{
					model.SHSSBackWTemp=row["SHSSBackWTemp"].ToString();
				}
				if(row["SHSSCWater"]!=null)
				{
					model.SHSSCWater=row["SHSSCWater"].ToString();
				}
				if(row["SUEWSTemp"]!=null)
				{
					model.SUEWSTemp=row["SUEWSTemp"].ToString();
				}
				if(row["SUEBWTemp"]!=null)
				{
					model.SUEBWTemp=row["SUEBWTemp"].ToString();
				}
				if(row["SUECircul"]!=null)
				{
					model.SUECircul=row["SUECircul"].ToString();
				}
				if(row["SRTempRange"]!=null)
				{
					model.SRTempRange=row["SRTempRange"].ToString();
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
			strSql.Append("select id,ProName,WType,SHSSInWTemp,SHSSBackWTemp,SHSSCWater,SUEWSTemp,SUEBWTemp,SUECircul,SRTempRange ");
			strSql.Append(" FROM SummerType ");
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
			strSql.Append(" id,ProName,WType,SHSSInWTemp,SHSSBackWTemp,SHSSCWater,SUEWSTemp,SUEBWTemp,SUECircul,SRTempRange ");
			strSql.Append(" FROM SummerType ");
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
			strSql.Append("select count(1) FROM SummerType ");
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
			strSql.Append(")AS Row, T.*  from SummerType T ");
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
			parameters[0].Value = "SummerType";
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

