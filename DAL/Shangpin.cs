/**
* Shangpin.cs
*
* 功 能： N/A
* 类 名： Shangpin
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/10/23 9:59:27   N/A    初版
*
*/
using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using DBUtility;
namespace ERPWPF.DAL
{
	/// <summary>
	/// 数据访问类:Shangpin
	/// </summary>
	public partial class Shangpin
	{
		public Shangpin()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Gid", "Shangpin"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Gid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Shangpin");
			strSql.Append(" where Gid=@Gid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Gid", DbType.Int32,4)
			};
			parameters[0].Value = Gid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ERPWPF.Model.Shangpin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Shangpin(");
			strSql.Append("GCode,GName,GGuige,GShuliang,GJinjia,GShoujia,GTime)");
			strSql.Append(" values (");
			strSql.Append("@GCode,@GName,@GGuige,@GShuliang,@GJinjia,@GShoujia,@GTime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GCode", DbType.String),
					new SQLiteParameter("@GName", DbType.String),
					new SQLiteParameter("@GGuige", DbType.String),
					new SQLiteParameter("@GShuliang", DbType.String),
					new SQLiteParameter("@GJinjia", DbType.String),
					new SQLiteParameter("@GShoujia", DbType.String),
					new SQLiteParameter("@GTime", DbType.String)};
			parameters[0].Value = model.GCode;
			parameters[1].Value = model.GName;
			parameters[2].Value = model.GGuige;
			parameters[3].Value = model.GShuliang;
			parameters[4].Value = model.GJinjia;
			parameters[5].Value = model.GShoujia;
			parameters[6].Value = model.GTime;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(ERPWPF.Model.Shangpin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Shangpin set ");
			strSql.Append("GCode=@GCode,");
			strSql.Append("GName=@GName,");
			strSql.Append("GGuige=@GGuige,");
			strSql.Append("GShuliang=@GShuliang,");
			strSql.Append("GJinjia=@GJinjia,");
			strSql.Append("GShoujia=@GShoujia,");
			strSql.Append("GTime=@GTime");
			strSql.Append(" where Gid=@Gid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GCode", DbType.String),
					new SQLiteParameter("@GName", DbType.String),
					new SQLiteParameter("@GGuige", DbType.String),
					new SQLiteParameter("@GShuliang", DbType.String),
					new SQLiteParameter("@GJinjia", DbType.String),
					new SQLiteParameter("@GShoujia", DbType.String),
					new SQLiteParameter("@GTime", DbType.String),
					new SQLiteParameter("@Gid", DbType.Int32,8)};
			parameters[0].Value = model.GCode;
			parameters[1].Value = model.GName;
			parameters[2].Value = model.GGuige;
			parameters[3].Value = model.GShuliang;
			parameters[4].Value = model.GJinjia;
			parameters[5].Value = model.GShoujia;
			parameters[6].Value = model.GTime;
			parameters[7].Value = model.Gid;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int Gid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Shangpin ");
			strSql.Append(" where Gid=@Gid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Gid", DbType.Int32,4)
			};
			parameters[0].Value = Gid;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Gidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Shangpin ");
			strSql.Append(" where Gid in ("+Gidlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
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
		public ERPWPF.Model.Shangpin GetModel(int Gid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Gid,GCode,GName,GGuige,GShuliang,GJinjia,GShoujia,GTime from Shangpin ");
			strSql.Append(" where Gid=@Gid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Gid", DbType.Int32,4)
			};
			parameters[0].Value = Gid;

			ERPWPF.Model.Shangpin model=new ERPWPF.Model.Shangpin();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
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
		public ERPWPF.Model.Shangpin DataRowToModel(DataRow row)
		{
			ERPWPF.Model.Shangpin model=new ERPWPF.Model.Shangpin();
			if (row != null)
			{
				if(row["Gid"]!=null && row["Gid"].ToString()!="")
				{
					model.Gid=int.Parse(row["Gid"].ToString());
				}
				if(row["GCode"]!=null)
				{
					model.GCode=row["GCode"].ToString();
				}
				if(row["GName"]!=null)
				{
					model.GName=row["GName"].ToString();
				}
				if(row["GGuige"]!=null)
				{
					model.GGuige=row["GGuige"].ToString();
				}
				if(row["GShuliang"]!=null)
				{
					model.GShuliang=row["GShuliang"].ToString();
				}
				if(row["GJinjia"]!=null)
				{
					model.GJinjia=row["GJinjia"].ToString();
				}
				if(row["GShoujia"]!=null)
				{
					model.GShoujia=row["GShoujia"].ToString();
				}
				if(row["GTime"]!=null)
				{
					model.GTime=row["GTime"].ToString();
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
			strSql.Append("select Gid,GCode,GName,GGuige,GShuliang,GJinjia,GShoujia,GTime ");
			strSql.Append(" FROM Shangpin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Shangpin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQLite.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.Gid desc");
			}
			strSql.Append(")AS Row, T.*  from Shangpin T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "Shangpin";
			parameters[1].Value = "Gid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

