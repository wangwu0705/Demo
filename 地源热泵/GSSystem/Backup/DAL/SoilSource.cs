using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:SoilSource
	/// </summary>
	public partial class SoilSource
	{
		public SoilSource()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.SoilSource model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SoilSource(");
			strSql.Append("ProName,WType,PHoleNum,HoleDepth,HoleDistance,UHEMaterial,UHEDiameter,HeatTime,CoolTime,BPFormat,UHEUType,UHESparallel,UHETotalLen,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WSPPower,PVFreque)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@WType,@PHoleNum,@HoleDepth,@HoleDistance,@UHEMaterial,@UHEDiameter,@HeatTime,@CoolTime,@BPFormat,@UHEUType,@UHESparallel,@UHETotalLen,@WTIModel,@CPETModel,@CPETNum,@FWTSize,@WSPNum,@WSPPower,@PVFreque)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@PHoleNum", SqlDbType.VarChar,8),
					new SqlParameter("@HoleDepth", SqlDbType.VarChar,8),
					new SqlParameter("@HoleDistance", SqlDbType.VarChar,8),
					new SqlParameter("@UHEMaterial", SqlDbType.VarChar,8),
					new SqlParameter("@UHEDiameter", SqlDbType.VarChar,8),
					new SqlParameter("@HeatTime", SqlDbType.VarChar,8),
					new SqlParameter("@CoolTime", SqlDbType.VarChar,8),
					new SqlParameter("@BPFormat", SqlDbType.VarChar,8),
					new SqlParameter("@UHEUType", SqlDbType.VarChar,8),
					new SqlParameter("@UHESparallel", SqlDbType.VarChar,8),
					new SqlParameter("@UHETotalLen", SqlDbType.VarChar,8),
					new SqlParameter("@WTIModel", SqlDbType.VarChar,8),
					new SqlParameter("@CPETModel", SqlDbType.VarChar,8),
					new SqlParameter("@CPETNum", SqlDbType.VarChar,6),
					new SqlParameter("@FWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,6),
					new SqlParameter("@WSPPower", SqlDbType.VarChar,6),
					new SqlParameter("@PVFreque", SqlDbType.VarChar,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.PHoleNum;
			parameters[3].Value = model.HoleDepth;
			parameters[4].Value = model.HoleDistance;
			parameters[5].Value = model.UHEMaterial;
			parameters[6].Value = model.UHEDiameter;
			parameters[7].Value = model.HeatTime;
			parameters[8].Value = model.CoolTime;
			parameters[9].Value = model.BPFormat;
			parameters[10].Value = model.UHEUType;
			parameters[11].Value = model.UHESparallel;
			parameters[12].Value = model.UHETotalLen;
			parameters[13].Value = model.WTIModel;
			parameters[14].Value = model.CPETModel;
			parameters[15].Value = model.CPETNum;
			parameters[16].Value = model.FWTSize;
			parameters[17].Value = model.WSPNum;
			parameters[18].Value = model.WSPPower;
			parameters[19].Value = model.PVFreque;

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
		public bool Update(GSSystem.Model.SoilSource model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SoilSource set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("WType=@WType,");
			strSql.Append("PHoleNum=@PHoleNum,");
			strSql.Append("HoleDepth=@HoleDepth,");
			strSql.Append("HoleDistance=@HoleDistance,");
			strSql.Append("UHEMaterial=@UHEMaterial,");
			strSql.Append("UHEDiameter=@UHEDiameter,");
			strSql.Append("HeatTime=@HeatTime,");
			strSql.Append("CoolTime=@CoolTime,");
			strSql.Append("BPFormat=@BPFormat,");
			strSql.Append("UHEUType=@UHEUType,");
			strSql.Append("UHESparallel=@UHESparallel,");
			strSql.Append("UHETotalLen=@UHETotalLen,");
			strSql.Append("WTIModel=@WTIModel,");
			strSql.Append("CPETModel=@CPETModel,");
			strSql.Append("CPETNum=@CPETNum,");
			strSql.Append("FWTSize=@FWTSize,");
			strSql.Append("WSPNum=@WSPNum,");
			strSql.Append("WSPPower=@WSPPower,");
			strSql.Append("PVFreque=@PVFreque");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@PHoleNum", SqlDbType.VarChar,8),
					new SqlParameter("@HoleDepth", SqlDbType.VarChar,8),
					new SqlParameter("@HoleDistance", SqlDbType.VarChar,8),
					new SqlParameter("@UHEMaterial", SqlDbType.VarChar,8),
					new SqlParameter("@UHEDiameter", SqlDbType.VarChar,8),
					new SqlParameter("@HeatTime", SqlDbType.VarChar,8),
					new SqlParameter("@CoolTime", SqlDbType.VarChar,8),
					new SqlParameter("@BPFormat", SqlDbType.VarChar,8),
					new SqlParameter("@UHEUType", SqlDbType.VarChar,8),
					new SqlParameter("@UHESparallel", SqlDbType.VarChar,8),
					new SqlParameter("@UHETotalLen", SqlDbType.VarChar,8),
					new SqlParameter("@WTIModel", SqlDbType.VarChar,8),
					new SqlParameter("@CPETModel", SqlDbType.VarChar,8),
					new SqlParameter("@CPETNum", SqlDbType.VarChar,6),
					new SqlParameter("@FWTSize", SqlDbType.VarChar,5),
					new SqlParameter("@WSPNum", SqlDbType.VarChar,6),
					new SqlParameter("@WSPPower", SqlDbType.VarChar,6),
					new SqlParameter("@PVFreque", SqlDbType.VarChar,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.WType;
			parameters[2].Value = model.PHoleNum;
			parameters[3].Value = model.HoleDepth;
			parameters[4].Value = model.HoleDistance;
			parameters[5].Value = model.UHEMaterial;
			parameters[6].Value = model.UHEDiameter;
			parameters[7].Value = model.HeatTime;
			parameters[8].Value = model.CoolTime;
			parameters[9].Value = model.BPFormat;
			parameters[10].Value = model.UHEUType;
			parameters[11].Value = model.UHESparallel;
			parameters[12].Value = model.UHETotalLen;
			parameters[13].Value = model.WTIModel;
			parameters[14].Value = model.CPETModel;
			parameters[15].Value = model.CPETNum;
			parameters[16].Value = model.FWTSize;
			parameters[17].Value = model.WSPNum;
			parameters[18].Value = model.WSPPower;
			parameters[19].Value = model.PVFreque;
			parameters[20].Value = model.id;

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
			strSql.Append("delete from SoilSource ");
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
			strSql.Append("delete from SoilSource ");
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
		public GSSystem.Model.SoilSource GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,WType,PHoleNum,HoleDepth,HoleDistance,UHEMaterial,UHEDiameter,HeatTime,CoolTime,BPFormat,UHEUType,UHESparallel,UHETotalLen,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WSPPower,PVFreque from SoilSource ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.SoilSource model=new GSSystem.Model.SoilSource();
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
		public GSSystem.Model.SoilSource DataRowToModel(DataRow row)
		{
			GSSystem.Model.SoilSource model=new GSSystem.Model.SoilSource();
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
				if(row["PHoleNum"]!=null)
				{
					model.PHoleNum=row["PHoleNum"].ToString();
				}
				if(row["HoleDepth"]!=null)
				{
					model.HoleDepth=row["HoleDepth"].ToString();
				}
				if(row["HoleDistance"]!=null)
				{
					model.HoleDistance=row["HoleDistance"].ToString();
				}
				if(row["UHEMaterial"]!=null)
				{
					model.UHEMaterial=row["UHEMaterial"].ToString();
				}
				if(row["UHEDiameter"]!=null)
				{
					model.UHEDiameter=row["UHEDiameter"].ToString();
				}
				if(row["HeatTime"]!=null)
				{
					model.HeatTime=row["HeatTime"].ToString();
				}
				if(row["CoolTime"]!=null)
				{
					model.CoolTime=row["CoolTime"].ToString();
				}
				if(row["BPFormat"]!=null)
				{
					model.BPFormat=row["BPFormat"].ToString();
				}
				if(row["UHEUType"]!=null)
				{
					model.UHEUType=row["UHEUType"].ToString();
				}
				if(row["UHESparallel"]!=null)
				{
					model.UHESparallel=row["UHESparallel"].ToString();
				}
				if(row["UHETotalLen"]!=null)
				{
					model.UHETotalLen=row["UHETotalLen"].ToString();
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
				if(row["WSPPower"]!=null)
				{
					model.WSPPower=row["WSPPower"].ToString();
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
			strSql.Append("select id,ProName,WType,PHoleNum,HoleDepth,HoleDistance,UHEMaterial,UHEDiameter,HeatTime,CoolTime,BPFormat,UHEUType,UHESparallel,UHETotalLen,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WSPPower,PVFreque ");
			strSql.Append(" FROM SoilSource ");
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
			strSql.Append(" id,ProName,WType,PHoleNum,HoleDepth,HoleDistance,UHEMaterial,UHEDiameter,HeatTime,CoolTime,BPFormat,UHEUType,UHESparallel,UHETotalLen,WTIModel,CPETModel,CPETNum,FWTSize,WSPNum,WSPPower,PVFreque ");
			strSql.Append(" FROM SoilSource ");
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
			strSql.Append("select count(1) FROM SoilSource ");
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
			strSql.Append(")AS Row, T.*  from SoilSource T ");
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
			parameters[0].Value = "SoilSource";
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

