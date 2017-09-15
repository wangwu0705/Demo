using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GSSystem.DAL
{
	/// <summary>
	/// 数据访问类:ProjectCommonCity
	/// </summary>
	public partial class ProjectCommonCity
	{
		public ProjectCommonCity()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GSSystem.Model.ProjectCommonCity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ProjectCommonCity(");
			strSql.Append("ProName,ProAdd,ProType,ConUnit,HpManufacturer,FinTime,CoveredArea,HpType,EngCharacter,UseFormat,TerminalForm,ProjectTHHp,ProjectTCHp,HpEquipmentType,HpEquipmentNum,NominalHeat,NominalCool,HeatInputPower,CoolInputPower,WType)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@ProAdd,@ProType,@ConUnit,@HpManufacturer,@FinTime,@CoveredArea,@HpType,@EngCharacter,@UseFormat,@TerminalForm,@ProjectTHHp,@ProjectTCHp,@HpEquipmentType,@HpEquipmentNum,@NominalHeat,@NominalCool,@HeatInputPower,@CoolInputPower,@WType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@ProAdd", SqlDbType.VarChar,10),
					new SqlParameter("@ProType", SqlDbType.VarChar,5),
					new SqlParameter("@ConUnit", SqlDbType.VarChar,18),
					new SqlParameter("@HpManufacturer", SqlDbType.VarChar,10),
					new SqlParameter("@FinTime", SqlDbType.DateTime),
					new SqlParameter("@CoveredArea", SqlDbType.VarChar,15),
					new SqlParameter("@HpType", SqlDbType.VarChar,5),
					new SqlParameter("@EngCharacter", SqlDbType.VarChar,18),
					new SqlParameter("@UseFormat", SqlDbType.VarChar,10),
					new SqlParameter("@TerminalForm", SqlDbType.VarChar,10),
					new SqlParameter("@ProjectTHHp", SqlDbType.Int,4),
					new SqlParameter("@ProjectTCHp", SqlDbType.Int,4),
					new SqlParameter("@HpEquipmentType", SqlDbType.VarChar,15),
					new SqlParameter("@HpEquipmentNum", SqlDbType.Int,4),
					new SqlParameter("@NominalHeat", SqlDbType.VarChar,10),
					new SqlParameter("@NominalCool", SqlDbType.VarChar,10),
					new SqlParameter("@HeatInputPower", SqlDbType.VarChar,10),
					new SqlParameter("@CoolInputPower", SqlDbType.VarChar,10),
					new SqlParameter("@WType", SqlDbType.VarChar,10)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.ProAdd;
			parameters[2].Value = model.ProType;
			parameters[3].Value = model.ConUnit;
			parameters[4].Value = model.HpManufacturer;
			parameters[5].Value = model.FinTime;
			parameters[6].Value = model.CoveredArea;
			parameters[7].Value = model.HpType;
			parameters[8].Value = model.EngCharacter;
			parameters[9].Value = model.UseFormat;
			parameters[10].Value = model.TerminalForm;
			parameters[11].Value = model.ProjectTHHp;
			parameters[12].Value = model.ProjectTCHp;
			parameters[13].Value = model.HpEquipmentType;
			parameters[14].Value = model.HpEquipmentNum;
			parameters[15].Value = model.NominalHeat;
			parameters[16].Value = model.NominalCool;
			parameters[17].Value = model.HeatInputPower;
			parameters[18].Value = model.CoolInputPower;
			parameters[19].Value = model.WType;

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
		public bool Update(GSSystem.Model.ProjectCommonCity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ProjectCommonCity set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("ProAdd=@ProAdd,");
			strSql.Append("ProType=@ProType,");
			strSql.Append("ConUnit=@ConUnit,");
			strSql.Append("HpManufacturer=@HpManufacturer,");
			strSql.Append("FinTime=@FinTime,");
			strSql.Append("CoveredArea=@CoveredArea,");
			strSql.Append("HpType=@HpType,");
			strSql.Append("EngCharacter=@EngCharacter,");
			strSql.Append("UseFormat=@UseFormat,");
			strSql.Append("TerminalForm=@TerminalForm,");
			strSql.Append("ProjectTHHp=@ProjectTHHp,");
			strSql.Append("ProjectTCHp=@ProjectTCHp,");
			strSql.Append("HpEquipmentType=@HpEquipmentType,");
			strSql.Append("HpEquipmentNum=@HpEquipmentNum,");
			strSql.Append("NominalHeat=@NominalHeat,");
			strSql.Append("NominalCool=@NominalCool,");
			strSql.Append("HeatInputPower=@HeatInputPower,");
			strSql.Append("CoolInputPower=@CoolInputPower,");
			strSql.Append("WType=@WType");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,18),
					new SqlParameter("@ProAdd", SqlDbType.VarChar,10),
					new SqlParameter("@ProType", SqlDbType.VarChar,5),
					new SqlParameter("@ConUnit", SqlDbType.VarChar,18),
					new SqlParameter("@HpManufacturer", SqlDbType.VarChar,10),
					new SqlParameter("@FinTime", SqlDbType.DateTime),
					new SqlParameter("@CoveredArea", SqlDbType.VarChar,15),
					new SqlParameter("@HpType", SqlDbType.VarChar,5),
					new SqlParameter("@EngCharacter", SqlDbType.VarChar,18),
					new SqlParameter("@UseFormat", SqlDbType.VarChar,10),
					new SqlParameter("@TerminalForm", SqlDbType.VarChar,10),
					new SqlParameter("@ProjectTHHp", SqlDbType.Int,4),
					new SqlParameter("@ProjectTCHp", SqlDbType.Int,4),
					new SqlParameter("@HpEquipmentType", SqlDbType.VarChar,15),
					new SqlParameter("@HpEquipmentNum", SqlDbType.Int,4),
					new SqlParameter("@NominalHeat", SqlDbType.VarChar,10),
					new SqlParameter("@NominalCool", SqlDbType.VarChar,10),
					new SqlParameter("@HeatInputPower", SqlDbType.VarChar,10),
					new SqlParameter("@CoolInputPower", SqlDbType.VarChar,10),
					new SqlParameter("@WType", SqlDbType.VarChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.ProAdd;
			parameters[2].Value = model.ProType;
			parameters[3].Value = model.ConUnit;
			parameters[4].Value = model.HpManufacturer;
			parameters[5].Value = model.FinTime;
			parameters[6].Value = model.CoveredArea;
			parameters[7].Value = model.HpType;
			parameters[8].Value = model.EngCharacter;
			parameters[9].Value = model.UseFormat;
			parameters[10].Value = model.TerminalForm;
			parameters[11].Value = model.ProjectTHHp;
			parameters[12].Value = model.ProjectTCHp;
			parameters[13].Value = model.HpEquipmentType;
			parameters[14].Value = model.HpEquipmentNum;
			parameters[15].Value = model.NominalHeat;
			parameters[16].Value = model.NominalCool;
			parameters[17].Value = model.HeatInputPower;
			parameters[18].Value = model.CoolInputPower;
			parameters[19].Value = model.WType;
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
			strSql.Append("delete from ProjectCommonCity ");
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
			strSql.Append("delete from ProjectCommonCity ");
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
		public GSSystem.Model.ProjectCommonCity GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ProName,ProAdd,ProType,ConUnit,HpManufacturer,FinTime,CoveredArea,HpType,EngCharacter,UseFormat,TerminalForm,ProjectTHHp,ProjectTCHp,HpEquipmentType,HpEquipmentNum,NominalHeat,NominalCool,HeatInputPower,CoolInputPower,WType from ProjectCommonCity ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			GSSystem.Model.ProjectCommonCity model=new GSSystem.Model.ProjectCommonCity();
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
		public GSSystem.Model.ProjectCommonCity DataRowToModel(DataRow row)
		{
			GSSystem.Model.ProjectCommonCity model=new GSSystem.Model.ProjectCommonCity();
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
				if(row["ProAdd"]!=null)
				{
					model.ProAdd=row["ProAdd"].ToString();
				}
				if(row["ProType"]!=null)
				{
					model.ProType=row["ProType"].ToString();
				}
				if(row["ConUnit"]!=null)
				{
					model.ConUnit=row["ConUnit"].ToString();
				}
				if(row["HpManufacturer"]!=null)
				{
					model.HpManufacturer=row["HpManufacturer"].ToString();
				}
				if(row["FinTime"]!=null && row["FinTime"].ToString()!="")
				{
					model.FinTime=DateTime.Parse(row["FinTime"].ToString());
				}
				if(row["CoveredArea"]!=null)
				{
					model.CoveredArea=row["CoveredArea"].ToString();
				}
				if(row["HpType"]!=null)
				{
					model.HpType=row["HpType"].ToString();
				}
				if(row["EngCharacter"]!=null)
				{
					model.EngCharacter=row["EngCharacter"].ToString();
				}
				if(row["UseFormat"]!=null)
				{
					model.UseFormat=row["UseFormat"].ToString();
				}
				if(row["TerminalForm"]!=null)
				{
					model.TerminalForm=row["TerminalForm"].ToString();
				}
				if(row["ProjectTHHp"]!=null && row["ProjectTHHp"].ToString()!="")
				{
					model.ProjectTHHp=int.Parse(row["ProjectTHHp"].ToString());
				}
				if(row["ProjectTCHp"]!=null && row["ProjectTCHp"].ToString()!="")
				{
					model.ProjectTCHp=int.Parse(row["ProjectTCHp"].ToString());
				}
				if(row["HpEquipmentType"]!=null)
				{
					model.HpEquipmentType=row["HpEquipmentType"].ToString();
				}
				if(row["HpEquipmentNum"]!=null && row["HpEquipmentNum"].ToString()!="")
				{
					model.HpEquipmentNum=int.Parse(row["HpEquipmentNum"].ToString());
				}
				if(row["NominalHeat"]!=null)
				{
					model.NominalHeat=row["NominalHeat"].ToString();
				}
				if(row["NominalCool"]!=null)
				{
					model.NominalCool=row["NominalCool"].ToString();
				}
				if(row["HeatInputPower"]!=null)
				{
					model.HeatInputPower=row["HeatInputPower"].ToString();
				}
				if(row["CoolInputPower"]!=null)
				{
					model.CoolInputPower=row["CoolInputPower"].ToString();
				}
				if(row["WType"]!=null)
				{
					model.WType=row["WType"].ToString();
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
			strSql.Append("select id,ProName,ProAdd,ProType,ConUnit,HpManufacturer,FinTime,CoveredArea,HpType,EngCharacter,UseFormat,TerminalForm,ProjectTHHp,ProjectTCHp,HpEquipmentType,HpEquipmentNum,NominalHeat,NominalCool,HeatInputPower,CoolInputPower,WType ");
			strSql.Append(" FROM ProjectCommonCity ");
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
			strSql.Append(" id,ProName,ProAdd,ProType,ConUnit,HpManufacturer,FinTime,CoveredArea,HpType,EngCharacter,UseFormat,TerminalForm,ProjectTHHp,ProjectTCHp,HpEquipmentType,HpEquipmentNum,NominalHeat,NominalCool,HeatInputPower,CoolInputPower,WType ");
			strSql.Append(" FROM ProjectCommonCity ");
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
			strSql.Append("select count(1) FROM ProjectCommonCity ");
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
			strSql.Append(")AS Row, T.*  from ProjectCommonCity T ");
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
			parameters[0].Value = "ProjectCommonCity";
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

