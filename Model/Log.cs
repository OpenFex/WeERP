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
namespace ERPWPF.Model
{
	/// <summary>
	/// Log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Log
	{
		public Log()
		{}
		#region Model
		private int _lid;
		private string _loperation;
		private string _luser;
		private string _ltime;
		/// <summary>
		/// 
		/// </summary>
		public int Lid
		{
			set{ _lid=value;}
			get{return _lid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOperation
		{
			set{ _loperation=value;}
			get{return _loperation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Luser
		{
			set{ _luser=value;}
			get{return _luser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LTime
		{
			set{ _ltime=value;}
			get{return _ltime;}
		}
		#endregion Model

	}
}

