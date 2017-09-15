using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:SeaWater
	/// </summary>
	public partial class SeaWater
	{
		public SeaWater()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.SeaWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SeaWater(");
			strSql.Append("ProName,WType,Type,Dowtherm,SWWellNum,SWWellDep,CWPNum,CWPHead,CWPFlow,CWPPower,ExHeatType,ExHeatNum,ExHeatArea,SWInTemp,SWOutTemp,SeaWaterFlow,DesanderNum,DesanderType,SoftWTSize,SoftWType,WPNum,WPpower,PVariableFre)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@Type,@Dowtherm,@SWWellNum,@SWWellDep,@CWPNum,@CWPHead,@CWPFlow,@CWPPower,@ExHeatType,@ExHeatNum,@ExHeatArea,@SWInTemp,@SWOutTemp,@SeaWaterFlow,@DesanderNum,@DesanderType,@SoftWTSize,@SoftWType,@WPNum,@WPpower,@PVariableFre)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@Type", SqlDbType.VarChar,4),
					new SqlParameter("@Dowtherm", SqlDbType.VarChar,5),
					new SqlParameter("@SWWellNum", SqlDbType.VarChar,5),
					new SqlParameter("@SWWellDep", SqlDbType.VarChar,5),
					new SqlParameter("@CWPNum", SqlDbType.VarChar,5),
					new SqlParameter("@CWPHead", SqlDbType.VarChar,5),
					new SqlParameter("@CWPFlow", SqlDbType.VarChar,5),
					new SqlParameter("@CWPPower", SqlDbType.VarChar,10),
					new SqlParameter("@ExHeatType", SqlDbType.VarChar,5),
					new SqlParameter("@ExHeatNum", SqlDbType.VarChar,5),
					new SqlParameter("@ExHeatArea", SqlDbType.VarChar,10),
					new SqlParameter("@SWInTemp", SqlDbType.VarChar,5),
					new SqlParameter("@SWOutTemp", SqlDbType.VarChar,5),
					new SqlParameter("@SeaWaterFlow", SqlDbType.VarChar,5),
					new SqlParameter("@DesanderNum", SqlDbType.VarChar,5),
					new SqlParameter("@DesanderType", SqlDbType.VarChar,5),
					new SqlParameter("@SoftWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@SoftWType", SqlDbType.VarChar,5),
					new SqlParameter("@WPNum", SqlDbType.VarChar,5),
					new SqlParameter("@WPpower", SqlDbType.VarChar,5),
					new SqlParameter("@PVariableFre", SqlDbType.VarChar,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Dowtherm;
			parameters[4].Value = model.SWWellNum;
			parameters[5].Value = model.SWWellDep;
			parameters[6].Value = model.CWPNum;
			parameters[7].Value = model.CWPHead;
			parameters[8].Value = model.CWPFlow;
			parameters[9].Value = model.CWPPower;
			parameters[10].Value = model.ExHeatType;
			parameters[11].Value = model.ExHeatNum;
			parameters[12].Value = model.ExHeatArea;
			parameters[13].Value = model.SWInTemp;
			parameters[14].Value = model.SWOutTemp;
			parameters[15].Value = model.SeaWaterFlow;
			parameters[16].Value = model.DesanderNum;
			parameters[17].Value = model.DesanderType;
			parameters[18].Value = model.SoftWTSize;
			parameters[19].Value = model.SoftWType;
			parameters[20].Value = model.WPNum;
			parameters[21].Value = model.WPpower;
			parameters[22].Value = model.PVariableFre;

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
		public bool Update(GSSystem.Model.SeaWater model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SeaWater set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("Type=@Type,");
			strSql.Append("Dowtherm=@Dowtherm,");
			strSql.Append("SWWellNum=@SWWellNum,");
			strSql.Append("SWWellDep=@SWWellDep,");
			strSql.Append("CWPNum=@CWPNum,");
			strSql.Append("CWPHead=@CWPHead,");
			strSql.Append("CWPFlow=@CWPFlow,");
			strSql.Append("CWPPower=@CWPPower,");
			strSql.Append("ExHeatType=@ExHeatType,");
			strSql.Append("ExHeatNum=@ExHeatNum,");
			strSql.Append("ExHeatArea=@ExHeatArea,");
			strSql.Append("SWInTemp=@SWInTemp,");
			strSql.Append("SWOutTemp=@SWOutTemp,");
			strSql.Append("SeaWaterFlow=@SeaWaterFlow,");
			strSql.Append("DesanderNum=@DesanderNum,");
			strSql.Append("DesanderType=@DesanderType,");
			strSql.Append("SoftWTSize=@SoftWTSize,");
			strSql.Append("SoftWType=@SoftWType,");
			strSql.Append("WPNum=@WPNum,");
			strSql.Append("WPpower=@WPpower,");
			strSql.Append("PVariableFre=@PVariableFre");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@Type", SqlDbType.VarChar,4),
					new SqlParameter("@Dowtherm", SqlDbType.VarChar,5),
					new SqlParameter("@SWWellNum", SqlDbType.VarChar,5),
					new SqlParameter("@SWWellDep", SqlDbType.VarChar,5),
					new SqlParameter("@CWPNum", SqlDbType.VarChar,5),
					new SqlParameter("@CWPHead", SqlDbType.VarChar,5),
					new SqlParameter("@CWPFlow", SqlDbType.VarChar,5),
					new SqlParameter("@CWPPower", SqlDbType.VarChar,10),
					new SqlParameter("@ExHeatType", SqlDbType.VarChar,5),
					new SqlParameter("@ExHeatNum", SqlDbType.VarChar,5),
					new SqlParameter("@ExHeatArea", SqlDbType.VarChar,10),
					new SqlParameter("@SWInTemp", SqlDbType.VarChar,5),
					new SqlParameter("@SWOutTemp", SqlDbType.VarChar,5),
					new SqlParameter("@SeaWaterFlow", SqlDbType.VarChar,5),
					new SqlParameter("@DesanderNum", SqlDbType.VarChar,5),
					new SqlParameter("@DesanderType", SqlDbType.VarChar,5),
					new SqlParameter("@SoftWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@SoftWType", SqlDbType.VarChar,5),
					new SqlParameter("@WPNum", SqlDbType.VarChar,5),
					new SqlParameter("@WPpower", SqlDbType.VarChar,5),
					new SqlParameter("@PVariableFre", SqlDbType.VarChar,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Dowtherm;
			parameters[4].Value = model.SWWellNum;
			parameters[5].Value = model.SWWellDep;
			parameters[6].Value = model.CWPNum;
			parameters[7].Value = model.CWPHead;
			parameters[8].Value = model.CWPFlow;
			parameters[9].Value = model.CWPPower;
			parameters[10].Value = model.ExHeatType;
			parameters[11].Value = model.ExHeatNum;
			parameters[12].Value = model.ExHeatArea;
			parameters[13].Value = model.SWInTemp;
			parameters[14].Value = model.SWOutTemp;
			parameters[15].Value = model.SeaWaterFlow;
			parameters[16].Value = model.DesanderNum;
			parameters[17].Value = model.DesanderType;
			parameters[18].Value = model.SoftWTSize;
			parameters[19].Value = model.SoftWType;
			parameters[20].Value = model.WPNum;
			parameters[21].Value = model.WPpower;
			parameters[22].Value = model.PVariableFre;
			parameters[23].Value = model.id;

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
			strSql.Append("delete from SeaWater ");
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
			strSql.Append("delete from SeaWater ");
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
		public GSSystem.Model.SeaWater GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,Type,Dowtherm,SWWellNum,SWWellDep,CWPNum,CWPHead,CWPFlow,CWPPower,ExHeatType,ExHeatNum,ExHeatArea,SWInTemp,SWOutTemp,SeaWaterFlow,DesanderNum,DesanderType,SoftWTSize,SoftWType,WPNum,WPpower,PVariableFre from SeaWater ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.SeaWater model=new GSSystem.Model.SeaWater();
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
		public GSSystem.Model.SeaWater DataRowToModel(DataRow row)
		{
			GSSystem.Model.SeaWater model=new GSSystem.Model.SeaWater();
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
				if(row["SWWellNum"]!=null)
				{
					model.SWWellNum=row["SWWellNum"].ToString();
				}
				if(row["SWWellDep"]!=null)
				{
					model.SWWellDep=row["SWWellDep"].ToString();
				}
				if(row["CWPNum"]!=null)
				{
					model.CWPNum=row["CWPNum"].ToString();
				}
				if(row["CWPHead"]!=null)
				{
					model.CWPHead=row["CWPHead"].ToString();
				}
				if(row["CWPFlow"]!=null)
				{
					model.CWPFlow=row["CWPFlow"].ToString();
				}
				if(row["CWPPower"]!=null)
				{
					model.CWPPower=row["CWPPower"].ToString();
				}
				if(row["ExHeatType"]!=null)
				{
					model.ExHeatType=row["ExHeatType"].ToString();
				}
				if(row["ExHeatNum"]!=null)
				{
					model.ExHeatNum=row["ExHeatNum"].ToString();
				}
				if(row["ExHeatArea"]!=null)
				{
					model.ExHeatArea=row["ExHeatArea"].ToString();
				}
				if(row["SWInTemp"]!=null)
				{
					model.SWInTemp=row["SWInTemp"].ToString();
				}
				if(row["SWOutTemp"]!=null)
				{
					model.SWOutTemp=row["SWOutTemp"].ToString();
				}
				if(row["SeaWaterFlow"]!=null)
				{
					model.SeaWaterFlow=row["SeaWaterFlow"].ToString();
				}
				if(row["DesanderNum"]!=null)
				{
					model.DesanderNum=row["DesanderNum"].ToString();
				}
				if(row["DesanderType"]!=null)
				{
					model.DesanderType=row["DesanderType"].ToString();
				}
				if(row["SoftWTSize"]!=null)
				{
					model.SoftWTSize=row["SoftWTSize"].ToString();
				}
				if(row["SoftWType"]!=null)
				{
					model.SoftWType=row["SoftWType"].ToString();
				}
				if(row["WPNum"]!=null)
				{
					model.WPNum=row["WPNum"].ToString();
				}
				if(row["WPpower"]!=null)
				{
					model.WPpower=row["WPpower"].ToString();
				}
				if(row["PVariableFre"]!=null)
				{
					model.PVariableFre=row["PVariableFre"].ToString();
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
			strSql.Append("select id,ProName,WType,Type,Dowtherm,SWWellNum,SWWellDep,CWPNum,CWPHead,CWPFlow,CWPPower,ExHeatType,ExHeatNum,ExHeatArea,SWInTemp,SWOutTemp,SeaWaterFlow,DesanderNum,DesanderType,SoftWTSize,SoftWType,WPNum,WPpower,PVariableFre ");
			strSql.Append(" FROM SeaWater ");
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
			strSql.Append(" id,ProName,WType,Type,Dowtherm,SWWellNum,SWWellDep,CWPNum,CWPHead,CWPFlow,CWPPower,ExHeatType,ExHeatNum,ExHeatArea,SWInTemp,SWOutTemp,SeaWaterFlow,DesanderNum,DesanderType,SoftWTSize,SoftWType,WPNum,WPpower,PVariableFre ");
			strSql.Append(" FROM SeaWater ");
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
			strSql.Append("select count(1) FROM SeaWater ");
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
			strSql.Append(")AS Row, T.*  from SeaWater T ");
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
			parameters[0].Value = "SeaWater";
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

