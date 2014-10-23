/**
* Dingdan.cs
*
* 功 能： N/A
* 类 名： Dingdan
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/10/23 9:59:26   N/A    初版
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
	/// 数据访问类:Dingdan
	/// </summary>
	public partial class Dingdan
	{
		public Dingdan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Tid", "Dingdan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Tid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Dingdan");
			strSql.Append(" where Tid=@Tid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Tid", DbType.Int32,4)
			};
			parameters[0].Value = Tid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ERPWPF.Model.Dingdan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Dingdan(");
			strSql.Append("TBuyerID,TJiage,TShuliang,TSonghuo,TYunFei,THeji,TIsFukuan,TIsFahuo,TIsQianshou,TIsChedan,TIsTuikuan,TTimeXiadan,TTimeFahuo,TTimeQianshou,TTimeChedan,TTimeTuikuan)");
			strSql.Append(" values (");
			strSql.Append("@TBuyerID,@TJiage,@TShuliang,@TSonghuo,@TYunFei,@THeji,@TIsFukuan,@TIsFahuo,@TIsQianshou,@TIsChedan,@TIsTuikuan,@TTimeXiadan,@TTimeFahuo,@TTimeQianshou,@TTimeChedan,@TTimeTuikuan)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TBuyerID", DbType.String),
					new SQLiteParameter("@TJiage", DbType.String),
					new SQLiteParameter("@TShuliang", DbType.String),
					new SQLiteParameter("@TSonghuo", DbType.String),
					new SQLiteParameter("@TYunFei", DbType.String),
					new SQLiteParameter("@THeji", DbType.String),
					new SQLiteParameter("@TIsFukuan", DbType.String),
					new SQLiteParameter("@TIsFahuo", DbType.String),
					new SQLiteParameter("@TIsQianshou", DbType.String),
					new SQLiteParameter("@TIsChedan", DbType.String),
					new SQLiteParameter("@TIsTuikuan", DbType.String),
					new SQLiteParameter("@TTimeXiadan", DbType.String),
					new SQLiteParameter("@TTimeFahuo", DbType.String),
					new SQLiteParameter("@TTimeQianshou", DbType.String),
					new SQLiteParameter("@TTimeChedan", DbType.String),
					new SQLiteParameter("@TTimeTuikuan", DbType.String)};
			parameters[0].Value = model.TBuyerID;
			parameters[1].Value = model.TJiage;
			parameters[2].Value = model.TShuliang;
			parameters[3].Value = model.TSonghuo;
			parameters[4].Value = model.TYunFei;
			parameters[5].Value = model.THeji;
			parameters[6].Value = model.TIsFukuan;
			parameters[7].Value = model.TIsFahuo;
			parameters[8].Value = model.TIsQianshou;
			parameters[9].Value = model.TIsChedan;
			parameters[10].Value = model.TIsTuikuan;
			parameters[11].Value = model.TTimeXiadan;
			parameters[12].Value = model.TTimeFahuo;
			parameters[13].Value = model.TTimeQianshou;
			parameters[14].Value = model.TTimeChedan;
			parameters[15].Value = model.TTimeTuikuan;

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
		public bool Update(ERPWPF.Model.Dingdan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Dingdan set ");
			strSql.Append("TBuyerID=@TBuyerID,");
			strSql.Append("TJiage=@TJiage,");
			strSql.Append("TShuliang=@TShuliang,");
			strSql.Append("TSonghuo=@TSonghuo,");
			strSql.Append("TYunFei=@TYunFei,");
			strSql.Append("THeji=@THeji,");
			strSql.Append("TIsFukuan=@TIsFukuan,");
			strSql.Append("TIsFahuo=@TIsFahuo,");
			strSql.Append("TIsQianshou=@TIsQianshou,");
			strSql.Append("TIsChedan=@TIsChedan,");
			strSql.Append("TIsTuikuan=@TIsTuikuan,");
			strSql.Append("TTimeXiadan=@TTimeXiadan,");
			strSql.Append("TTimeFahuo=@TTimeFahuo,");
			strSql.Append("TTimeQianshou=@TTimeQianshou,");
			strSql.Append("TTimeChedan=@TTimeChedan,");
			strSql.Append("TTimeTuikuan=@TTimeTuikuan");
			strSql.Append(" where Tid=@Tid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@TBuyerID", DbType.String),
					new SQLiteParameter("@TJiage", DbType.String),
					new SQLiteParameter("@TShuliang", DbType.String),
					new SQLiteParameter("@TSonghuo", DbType.String),
					new SQLiteParameter("@TYunFei", DbType.String),
					new SQLiteParameter("@THeji", DbType.String),
					new SQLiteParameter("@TIsFukuan", DbType.String),
					new SQLiteParameter("@TIsFahuo", DbType.String),
					new SQLiteParameter("@TIsQianshou", DbType.String),
					new SQLiteParameter("@TIsChedan", DbType.String),
					new SQLiteParameter("@TIsTuikuan", DbType.String),
					new SQLiteParameter("@TTimeXiadan", DbType.String),
					new SQLiteParameter("@TTimeFahuo", DbType.String),
					new SQLiteParameter("@TTimeQianshou", DbType.String),
					new SQLiteParameter("@TTimeChedan", DbType.String),
					new SQLiteParameter("@TTimeTuikuan", DbType.String),
					new SQLiteParameter("@Tid", DbType.Int32,8)};
			parameters[0].Value = model.TBuyerID;
			parameters[1].Value = model.TJiage;
			parameters[2].Value = model.TShuliang;
			parameters[3].Value = model.TSonghuo;
			parameters[4].Value = model.TYunFei;
			parameters[5].Value = model.THeji;
			parameters[6].Value = model.TIsFukuan;
			parameters[7].Value = model.TIsFahuo;
			parameters[8].Value = model.TIsQianshou;
			parameters[9].Value = model.TIsChedan;
			parameters[10].Value = model.TIsTuikuan;
			parameters[11].Value = model.TTimeXiadan;
			parameters[12].Value = model.TTimeFahuo;
			parameters[13].Value = model.TTimeQianshou;
			parameters[14].Value = model.TTimeChedan;
			parameters[15].Value = model.TTimeTuikuan;
			parameters[16].Value = model.Tid;

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
		public bool Delete(int Tid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Dingdan ");
			strSql.Append(" where Tid=@Tid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Tid", DbType.Int32,4)
			};
			parameters[0].Value = Tid;

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
		public bool DeleteList(string Tidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Dingdan ");
			strSql.Append(" where Tid in ("+Tidlist + ")  ");
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
		public ERPWPF.Model.Dingdan GetModel(int Tid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Tid,TBuyerID,TJiage,TShuliang,TSonghuo,TYunFei,THeji,TIsFukuan,TIsFahuo,TIsQianshou,TIsChedan,TIsTuikuan,TTimeXiadan,TTimeFahuo,TTimeQianshou,TTimeChedan,TTimeTuikuan from Dingdan ");
			strSql.Append(" where Tid=@Tid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Tid", DbType.Int32,4)
			};
			parameters[0].Value = Tid;

			ERPWPF.Model.Dingdan model=new ERPWPF.Model.Dingdan();
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
		public ERPWPF.Model.Dingdan DataRowToModel(DataRow row)
		{
			ERPWPF.Model.Dingdan model=new ERPWPF.Model.Dingdan();
			if (row != null)
			{
				if(row["Tid"]!=null && row["Tid"].ToString()!="")
				{
					model.Tid=int.Parse(row["Tid"].ToString());
				}
				if(row["TBuyerID"]!=null)
				{
					model.TBuyerID=row["TBuyerID"].ToString();
				}
				if(row["TJiage"]!=null)
				{
					model.TJiage=row["TJiage"].ToString();
				}
				if(row["TShuliang"]!=null)
				{
					model.TShuliang=row["TShuliang"].ToString();
				}
				if(row["TSonghuo"]!=null)
				{
					model.TSonghuo=row["TSonghuo"].ToString();
				}
				if(row["TYunFei"]!=null)
				{
					model.TYunFei=row["TYunFei"].ToString();
				}
				if(row["THeji"]!=null)
				{
					model.THeji=row["THeji"].ToString();
				}
				if(row["TIsFukuan"]!=null)
				{
					model.TIsFukuan=row["TIsFukuan"].ToString();
				}
				if(row["TIsFahuo"]!=null)
				{
					model.TIsFahuo=row["TIsFahuo"].ToString();
				}
				if(row["TIsQianshou"]!=null)
				{
					model.TIsQianshou=row["TIsQianshou"].ToString();
				}
				if(row["TIsChedan"]!=null)
				{
					model.TIsChedan=row["TIsChedan"].ToString();
				}
				if(row["TIsTuikuan"]!=null)
				{
					model.TIsTuikuan=row["TIsTuikuan"].ToString();
				}
				if(row["TTimeXiadan"]!=null)
				{
					model.TTimeXiadan=row["TTimeXiadan"].ToString();
				}
				if(row["TTimeFahuo"]!=null)
				{
					model.TTimeFahuo=row["TTimeFahuo"].ToString();
				}
				if(row["TTimeQianshou"]!=null)
				{
					model.TTimeQianshou=row["TTimeQianshou"].ToString();
				}
				if(row["TTimeChedan"]!=null)
				{
					model.TTimeChedan=row["TTimeChedan"].ToString();
				}
				if(row["TTimeTuikuan"]!=null)
				{
					model.TTimeTuikuan=row["TTimeTuikuan"].ToString();
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
			strSql.Append("select Tid,TBuyerID,TJiage,TShuliang,TSonghuo,TYunFei,THeji,TIsFukuan,TIsFahuo,TIsQianshou,TIsChedan,TIsTuikuan,TTimeXiadan,TTimeFahuo,TTimeQianshou,TTimeChedan,TTimeTuikuan ");
			strSql.Append(" FROM Dingdan ");
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
			strSql.Append("select count(1) FROM Dingdan ");
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
				strSql.Append("order by T.Tid desc");
			}
			strSql.Append(")AS Row, T.*  from Dingdan T ");
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
			parameters[0].Value = "Dingdan";
			parameters[1].Value = "Tid";
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

