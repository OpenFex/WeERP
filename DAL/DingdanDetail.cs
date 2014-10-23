/**
* DingdanDetail.cs
*
* 功 能： N/A
* 类 名： DingdanDetail
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
	/// 数据访问类:DingdanDetail
	/// </summary>
	public partial class DingdanDetail
	{
		public DingdanDetail()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ERPWPF.Model.DingdanDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DingdanDetail(");
			strSql.Append("Gid,Tid,GCode,GName,GGuige,GShuliang,GJinjia,GShoujia,GZhekou,GYouhui,GHeji)");
			strSql.Append(" values (");
			strSql.Append("@Gid,@Tid,@GCode,@GName,@GGuige,@GShuliang,@GJinjia,@GShoujia,@GZhekou,@GYouhui,@GHeji)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Gid", DbType.Int32,8),
					new SQLiteParameter("@Tid", DbType.Int32,8),
					new SQLiteParameter("@GCode", DbType.String),
					new SQLiteParameter("@GName", DbType.String),
					new SQLiteParameter("@GGuige", DbType.String),
					new SQLiteParameter("@GShuliang", DbType.String),
					new SQLiteParameter("@GJinjia", DbType.String),
					new SQLiteParameter("@GShoujia", DbType.String),
					new SQLiteParameter("@GZhekou", DbType.String),
					new SQLiteParameter("@GYouhui", DbType.String),
					new SQLiteParameter("@GHeji", DbType.String)};
			parameters[0].Value = model.Gid;
			parameters[1].Value = model.Tid;
			parameters[2].Value = model.GCode;
			parameters[3].Value = model.GName;
			parameters[4].Value = model.GGuige;
			parameters[5].Value = model.GShuliang;
			parameters[6].Value = model.GJinjia;
			parameters[7].Value = model.GShoujia;
			parameters[8].Value = model.GZhekou;
			parameters[9].Value = model.GYouhui;
			parameters[10].Value = model.GHeji;

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
		public bool Update(ERPWPF.Model.DingdanDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DingdanDetail set ");
			strSql.Append("Gid=@Gid,");
			strSql.Append("Tid=@Tid,");
			strSql.Append("GCode=@GCode,");
			strSql.Append("GName=@GName,");
			strSql.Append("GGuige=@GGuige,");
			strSql.Append("GShuliang=@GShuliang,");
			strSql.Append("GJinjia=@GJinjia,");
			strSql.Append("GShoujia=@GShoujia,");
			strSql.Append("GZhekou=@GZhekou,");
			strSql.Append("GYouhui=@GYouhui,");
			strSql.Append("GHeji=@GHeji");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Gid", DbType.Int32,8),
					new SQLiteParameter("@Tid", DbType.Int32,8),
					new SQLiteParameter("@GCode", DbType.String),
					new SQLiteParameter("@GName", DbType.String),
					new SQLiteParameter("@GGuige", DbType.String),
					new SQLiteParameter("@GShuliang", DbType.String),
					new SQLiteParameter("@GJinjia", DbType.String),
					new SQLiteParameter("@GShoujia", DbType.String),
					new SQLiteParameter("@GZhekou", DbType.String),
					new SQLiteParameter("@GYouhui", DbType.String),
					new SQLiteParameter("@GHeji", DbType.String)};
			parameters[0].Value = model.Gid;
			parameters[1].Value = model.Tid;
			parameters[2].Value = model.GCode;
			parameters[3].Value = model.GName;
			parameters[4].Value = model.GGuige;
			parameters[5].Value = model.GShuliang;
			parameters[6].Value = model.GJinjia;
			parameters[7].Value = model.GShoujia;
			parameters[8].Value = model.GZhekou;
			parameters[9].Value = model.GYouhui;
			parameters[10].Value = model.GHeji;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DingdanDetail ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public ERPWPF.Model.DingdanDetail GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Gid,Tid,GCode,GName,GGuige,GShuliang,GJinjia,GShoujia,GZhekou,GYouhui,GHeji from DingdanDetail ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			ERPWPF.Model.DingdanDetail model=new ERPWPF.Model.DingdanDetail();
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
		public ERPWPF.Model.DingdanDetail DataRowToModel(DataRow row)
		{
			ERPWPF.Model.DingdanDetail model=new ERPWPF.Model.DingdanDetail();
			if (row != null)
			{
				if(row["Gid"]!=null && row["Gid"].ToString()!="")
				{
					model.Gid=int.Parse(row["Gid"].ToString());
				}
				if(row["Tid"]!=null && row["Tid"].ToString()!="")
				{
					model.Tid=int.Parse(row["Tid"].ToString());
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
				if(row["GZhekou"]!=null)
				{
					model.GZhekou=row["GZhekou"].ToString();
				}
				if(row["GYouhui"]!=null)
				{
					model.GYouhui=row["GYouhui"].ToString();
				}
				if(row["GHeji"]!=null)
				{
					model.GHeji=row["GHeji"].ToString();
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
			strSql.Append("select Gid,Tid,GCode,GName,GGuige,GShuliang,GJinjia,GShoujia,GZhekou,GYouhui,GHeji ");
			strSql.Append(" FROM DingdanDetail ");
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
			strSql.Append("select count(1) FROM DingdanDetail ");
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
			strSql.Append(")AS Row, T.*  from DingdanDetail T ");
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
			parameters[0].Value = "DingdanDetail";
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

