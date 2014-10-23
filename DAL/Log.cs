/**
* Log.cs
*
* 功 能： N/A
* 类 名： Log
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
	/// 数据访问类:Log
	/// </summary>
	public partial class Log
	{
		public Log()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Lid", "Log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Lid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Log");
			strSql.Append(" where Lid=@Lid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Lid", DbType.Int32,8)			};
			parameters[0].Value = Lid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERPWPF.Model.Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Log(");
			strSql.Append("Lid,LOperation,Luser,LTime)");
			strSql.Append(" values (");
			strSql.Append("@Lid,@LOperation,@Luser,@LTime)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Lid", DbType.Int32,8),
					new SQLiteParameter("@LOperation", DbType.String),
					new SQLiteParameter("@Luser", DbType.String),
					new SQLiteParameter("@LTime", DbType.String)};
			parameters[0].Value = model.Lid;
			parameters[1].Value = model.LOperation;
			parameters[2].Value = model.Luser;
			parameters[3].Value = model.LTime;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(ERPWPF.Model.Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Log set ");
			strSql.Append("LOperation=@LOperation,");
			strSql.Append("Luser=@Luser,");
			strSql.Append("LTime=@LTime");
			strSql.Append(" where Lid=@Lid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@LOperation", DbType.String),
					new SQLiteParameter("@Luser", DbType.String),
					new SQLiteParameter("@LTime", DbType.String),
					new SQLiteParameter("@Lid", DbType.Int32,8)};
			parameters[0].Value = model.LOperation;
			parameters[1].Value = model.Luser;
			parameters[2].Value = model.LTime;
			parameters[3].Value = model.Lid;

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
		public bool Delete(int Lid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Log ");
			strSql.Append(" where Lid=@Lid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Lid", DbType.Int32,8)			};
			parameters[0].Value = Lid;

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
		public bool DeleteList(string Lidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Log ");
			strSql.Append(" where Lid in ("+Lidlist + ")  ");
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
		public ERPWPF.Model.Log GetModel(int Lid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Lid,LOperation,Luser,LTime from Log ");
			strSql.Append(" where Lid=@Lid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Lid", DbType.Int32,8)			};
			parameters[0].Value = Lid;

			ERPWPF.Model.Log model=new ERPWPF.Model.Log();
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
		public ERPWPF.Model.Log DataRowToModel(DataRow row)
		{
			ERPWPF.Model.Log model=new ERPWPF.Model.Log();
			if (row != null)
			{
				if(row["Lid"]!=null && row["Lid"].ToString()!="")
				{
					model.Lid=int.Parse(row["Lid"].ToString());
				}
				if(row["LOperation"]!=null)
				{
					model.LOperation=row["LOperation"].ToString();
				}
				if(row["Luser"]!=null)
				{
					model.Luser=row["Luser"].ToString();
				}
				if(row["LTime"]!=null)
				{
					model.LTime=row["LTime"].ToString();
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
			strSql.Append("select Lid,LOperation,Luser,LTime ");
			strSql.Append(" FROM Log ");
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
			strSql.Append("select count(1) FROM Log ");
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
				strSql.Append("order by T.Lid desc");
			}
			strSql.Append(")AS Row, T.*  from Log T ");
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
			parameters[0].Value = "Log";
			parameters[1].Value = "Lid";
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

