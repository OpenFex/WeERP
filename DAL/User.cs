﻿/**
* User.cs
*
* 功 能： N/A
* 类 名： User
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
	/// 数据访问类:User
	/// </summary>
	public partial class User
	{
		public User()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Uid", "User"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Uid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from User");
			strSql.Append(" where Uid=@Uid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Uid", DbType.Int32,4)
			};
			parameters[0].Value = Uid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ERPWPF.Model.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into User(");
			strSql.Append("UName,UPassword,UPermisson,ULoginTime)");
			strSql.Append(" values (");
			strSql.Append("@UName,@UPassword,@UPermisson,@ULoginTime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@UName", DbType.String),
					new SQLiteParameter("@UPassword", DbType.String),
					new SQLiteParameter("@UPermisson", DbType.Int32,8),
					new SQLiteParameter("@ULoginTime", DbType.String)};
			parameters[0].Value = model.UName;
			parameters[1].Value = model.UPassword;
			parameters[2].Value = model.UPermisson;
			parameters[3].Value = model.ULoginTime;

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
		public bool Update(ERPWPF.Model.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update User set ");
			strSql.Append("UName=@UName,");
			strSql.Append("UPassword=@UPassword,");
			strSql.Append("UPermisson=@UPermisson,");
			strSql.Append("ULoginTime=@ULoginTime");
			strSql.Append(" where Uid=@Uid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@UName", DbType.String),
					new SQLiteParameter("@UPassword", DbType.String),
					new SQLiteParameter("@UPermisson", DbType.Int32,8),
					new SQLiteParameter("@ULoginTime", DbType.String),
					new SQLiteParameter("@Uid", DbType.Int32,8)};
			parameters[0].Value = model.UName;
			parameters[1].Value = model.UPassword;
			parameters[2].Value = model.UPermisson;
			parameters[3].Value = model.ULoginTime;
			parameters[4].Value = model.Uid;

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
		public bool Delete(int Uid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User ");
			strSql.Append(" where Uid=@Uid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Uid", DbType.Int32,4)
			};
			parameters[0].Value = Uid;

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
		public bool DeleteList(string Uidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User ");
			strSql.Append(" where Uid in ("+Uidlist + ")  ");
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
		public ERPWPF.Model.User GetModel(int Uid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Uid,UName,UPassword,UPermisson,ULoginTime from User ");
			strSql.Append(" where Uid=@Uid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Uid", DbType.Int32,4)
			};
			parameters[0].Value = Uid;

			ERPWPF.Model.User model=new ERPWPF.Model.User();
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
		public ERPWPF.Model.User DataRowToModel(DataRow row)
		{
			ERPWPF.Model.User model=new ERPWPF.Model.User();
			if (row != null)
			{
				if(row["Uid"]!=null && row["Uid"].ToString()!="")
				{
					model.Uid=int.Parse(row["Uid"].ToString());
				}
				if(row["UName"]!=null)
				{
					model.UName=row["UName"].ToString();
				}
				if(row["UPassword"]!=null)
				{
					model.UPassword=row["UPassword"].ToString();
				}
				if(row["UPermisson"]!=null && row["UPermisson"].ToString()!="")
				{
					model.UPermisson=int.Parse(row["UPermisson"].ToString());
				}
				if(row["ULoginTime"]!=null)
				{
					model.ULoginTime=row["ULoginTime"].ToString();
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
			strSql.Append("select Uid,UName,UPassword,UPermisson,ULoginTime ");
			strSql.Append(" FROM User ");
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
			strSql.Append("select count(1) FROM User ");
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
				strSql.Append("order by T.Uid desc");
			}
			strSql.Append(")AS Row, T.*  from User T ");
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
			parameters[0].Value = "User";
			parameters[1].Value = "Uid";
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

