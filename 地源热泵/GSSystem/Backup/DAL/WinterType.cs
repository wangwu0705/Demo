using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:WinterType
	/// </summary>
	public partial class WinterType
	{
		public WinterType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "WinterType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WinterType");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.WinterType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WinterType(");
			strSql.Append("ProName,WType,WWPWTemp,WWRWTemp,WHSSInWTemp,WHSSBackWTemp,WHSSCWater,WUEWSTemp,WUEBWTemp,WUECircul,WRTempeRange)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@WWPWTemp,@WWRWTemp,@WHSSInWTemp,@WHSSBackWTemp,@WHSSCWater,@WUEWSTemp,@WUEBWTemp,@WUECircul,@WRTempeRange)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@WWPWTemp", SqlDbType.VarChar,5),
					new SqlParameter("@WWRWTemp", SqlDbType.VarChar,5),
					new SqlParameter("@WHSSInWTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WHSSBackWTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WHSSCWater", SqlDbType.VarChar,10),
					new SqlParameter("@WUEWSTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WUEBWTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WUECircul", SqlDbType.VarChar,10),
					new SqlParameter("@WRTempeRange", SqlDbType.VarChar,10)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.WWPWTemp;
			parameters[3].Value = model.WWRWTemp;
			parameters[4].Value = model.WHSSInWTemp;
			parameters[5].Value = model.WHSSBackWTemp;
			parameters[6].Value = model.WHSSCWater;
			parameters[7].Value = model.WUEWSTemp;
			parameters[8].Value = model.WUEBWTemp;
			parameters[9].Value = model.WUECircul;
			parameters[10].Value = model.WRTempeRange;

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
		public bool Update(GSSystem.Model.WinterType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WinterType set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("WWPWTemp=@WWPWTemp,");
			strSql.Append("WWRWTemp=@WWRWTemp,");
			strSql.Append("WHSSInWTemp=@WHSSInWTemp,");
			strSql.Append("WHSSBackWTemp=@WHSSBackWTemp,");
			strSql.Append("WHSSCWater=@WHSSCWater,");
			strSql.Append("WUEWSTemp=@WUEWSTemp,");
			strSql.Append("WUEBWTemp=@WUEBWTemp,");
			strSql.Append("WUECircul=@WUECircul,");
			strSql.Append("WRTempeRange=@WRTempeRange");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@WWPWTemp", SqlDbType.VarChar,5),
					new SqlParameter("@WWRWTemp", SqlDbType.VarChar,5),
					new SqlParameter("@WHSSInWTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WHSSBackWTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WHSSCWater", SqlDbType.VarChar,10),
					new SqlParameter("@WUEWSTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WUEBWTemp", SqlDbType.VarChar,10),
					new SqlParameter("@WUECircul", SqlDbType.VarChar,10),
					new SqlParameter("@WRTempeRange", SqlDbType.VarChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.WWPWTemp;
			parameters[3].Value = model.WWRWTemp;
			parameters[4].Value = model.WHSSInWTemp;
			parameters[5].Value = model.WHSSBackWTemp;
			parameters[6].Value = model.WHSSCWater;
			parameters[7].Value = model.WUEWSTemp;
			parameters[8].Value = model.WUEBWTemp;
			parameters[9].Value = model.WUECircul;
			parameters[10].Value = model.WRTempeRange;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from WinterType ");
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
			strSql.Append("delete from WinterType ");
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
		public GSSystem.Model.WinterType GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,WWPWTemp,WWRWTemp,WHSSInWTemp,WHSSBackWTemp,WHSSCWater,WUEWSTemp,WUEBWTemp,WUECircul,WRTempeRange from WinterType ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.WinterType model=new GSSystem.Model.WinterType();
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
		public GSSystem.Model.WinterType DataRowToModel(DataRow row)
		{
			GSSystem.Model.WinterType model=new GSSystem.Model.WinterType();
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
				if(row["WWPWTemp"]!=null)
				{
					model.WWPWTemp=row["WWPWTemp"].ToString();
				}
				if(row["WWRWTemp"]!=null)
				{
					model.WWRWTemp=row["WWRWTemp"].ToString();
				}
				if(row["WHSSInWTemp"]!=null)
				{
					model.WHSSInWTemp=row["WHSSInWTemp"].ToString();
				}
				if(row["WHSSBackWTemp"]!=null)
				{
					model.WHSSBackWTemp=row["WHSSBackWTemp"].ToString();
				}
				if(row["WHSSCWater"]!=null)
				{
					model.WHSSCWater=row["WHSSCWater"].ToString();
				}
				if(row["WUEWSTemp"]!=null)
				{
					model.WUEWSTemp=row["WUEWSTemp"].ToString();
				}
				if(row["WUEBWTemp"]!=null)
				{
					model.WUEBWTemp=row["WUEBWTemp"].ToString();
				}
				if(row["WUECircul"]!=null)
				{
					model.WUECircul=row["WUECircul"].ToString();
				}
				if(row["WRTempeRange"]!=null)
				{
					model.WRTempeRange=row["WRTempeRange"].ToString();
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
			strSql.Append("select id,ProName,WType,WWPWTemp,WWRWTemp,WHSSInWTemp,WHSSBackWTemp,WHSSCWater,WUEWSTemp,WUEBWTemp,WUECircul,WRTempeRange ");
			strSql.Append(" FROM WinterType ");
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
			strSql.Append(" id,ProName,WType,WWPWTemp,WWRWTemp,WHSSInWTemp,WHSSBackWTemp,WHSSCWater,WUEWSTemp,WUEBWTemp,WUECircul,WRTempeRange ");
			strSql.Append(" FROM WinterType ");
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
			strSql.Append("select count(1) FROM WinterType ");
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
			strSql.Append(")AS Row, T.*  from WinterType T ");
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
			parameters[0].Value = "WinterType";
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

