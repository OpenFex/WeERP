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
using System.Collections.Generic;
using ERPWPF.Model;
namespace ERPWPF.BLL
{
	/// <summary>
	/// Dingdan
	/// </summary>
	public partial class Dingdan
	{
		private readonly ERPWPF.DAL.Dingdan dal=new ERPWPF.DAL.Dingdan();
		public Dingdan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Tid)
		{
			return dal.Exists(Tid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ERPWPF.Model.Dingdan model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ERPWPF.Model.Dingdan model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Tid)
		{
			
			return dal.Delete(Tid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Tidlist )
		{
			return dal.DeleteList(Tidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPWPF.Model.Dingdan GetModel(int Tid)
		{
			
			return dal.GetModel(Tid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ERPWPF.Model.Dingdan GetModelByCache(int Tid)
		{
			
			string CacheKey = "DingdanModel-" + Tid;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Tid);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ERPWPF.Model.Dingdan)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ERPWPF.Model.Dingdan> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ERPWPF.Model.Dingdan> DataTableToList(DataTable dt)
		{
			List<ERPWPF.Model.Dingdan> modelList = new List<ERPWPF.Model.Dingdan>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ERPWPF.Model.Dingdan model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

