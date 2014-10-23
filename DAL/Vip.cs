/** 
* Vip.cs
* 
* 功 能： N/A
* 类 名： Vip
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
	/// 数据访问类:Vip
	/// </summary>
	public partial class Vip
	{
		public Vip()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Vid", "Vip"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Vid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Vip");
			strSql.Append(" where Vid=@Vid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Vid", DbType.Int32,4)
			};
			parameters[0].Value = Vid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ERPWPF.Model.Vip model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Vip(");
			strSql.Append("VName,VWeiXin,VTel,VIsDaili,VTimerReg)");
			strSql.Append(" values (");
			strSql.Append("@VName,@VWeiXin,@VTel,@VIsDaili,@VTimerReg)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@VName", DbType.String),
					new SQLiteParameter("@VWeiXin", DbType.String),
					new SQLiteParameter("@VTel", DbType.String),
					new SQLiteParameter("@VIsDaili", DbType.String),
					new SQLiteParameter("@VTimerReg", DbType.String)};
			parameters[0].Value = model.VName;
			parameters[1].Value = model.VWeiXin;
			parameters[2].Value = model.VTel;
			parameters[3].Value = model.VIsDaili;
			parameters[4].Value = model.VTimerReg;

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
		public bool Update(ERPWPF.Model.Vip model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Vip set ");
			strSql.Append("VName=@VName,");
			strSql.Append("VWeiXin=@VWeiXin,");
			strSql.Append("VTel=@VTel,");
			strSql.Append("VIsDaili=@VIsDaili,");
			strSql.Append("VTimerReg=@VTimerReg");
			strSql.Append(" where Vid=@Vid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@VName", DbType.String),
					new SQLiteParameter("@VWeiXin", DbType.String),
					new SQLiteParameter("@VTel", DbType.String),
					new SQLiteParameter("@VIsDaili", DbType.String),
					new SQLiteParameter("@VTimerReg", DbType.String),
					new SQLiteParameter("@Vid", DbType.Int32,8)};
			parameters[0].Value = model.VName;
			parameters[1].Value = model.VWeiXin;
			parameters[2].Value = model.VTel;
			parameters[3].Value = model.VIsDaili;
			parameters[4].Value = model.VTimerReg;
			parameters[5].Value = model.Vid;

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
		public bool Delete(int Vid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Vip ");
			strSql.Append(" where Vid=@Vid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Vid", DbType.Int32,4)
			};
			parameters[0].Value = Vid;

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
		public bool DeleteList(string Vidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Vip ");
			strSql.Append(" where Vid in ("+Vidlist + ")  ");
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
		public ERPWPF.Model.Vip GetModel(int Vid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Vid,VName,VWeiXin,VTel,VIsDaili,VTimerReg from Vip ");
			strSql.Append(" where Vid=@Vid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Vid", DbType.Int32,4)
			};
			parameters[0].Value = Vid;

			ERPWPF.Model.Vip model=new ERPWPF.Model.Vip();
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
		public ERPWPF.Model.Vip DataRowToModel(DataRow row)
		{
			ERPWPF.Model.Vip model=new ERPWPF.Model.Vip();
			if (row != null)
			{
				if(row["Vid"]!=null && row["Vid"].ToString()!="")
				{
					model.Vid=int.Parse(row["Vid"].ToString());
				}
				if(row["VName"]!=null)
				{
					model.VName=row["VName"].ToString();
				}
				if(row["VWeiXin"]!=null)
				{
					model.VWeiXin=row["VWeiXin"].ToString();
				}
				if(row["VTel"]!=null)
				{
					model.VTel=row["VTel"].ToString();
				}
				if(row["VIsDaili"]!=null)
				{
					model.VIsDaili=row["VIsDaili"].ToString();
				}
				if(row["VTimerReg"]!=null)
				{
					model.VTimerReg=row["VTimerReg"].ToString();
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
			strSql.Append("select Vid,VName,VWeiXin,VTel,VIsDaili,VTimerReg ");
			strSql.Append(" FROM Vip ");
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
			strSql.Append("select count(1) FROM Vip ");
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
				strSql.Append("order by T.Vid desc");
			}
			strSql.Append(")AS Row, T.*  from Vip T ");
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
			parameters[0].Value = "Vip";
			parameters[1].Value = "Vid";
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

