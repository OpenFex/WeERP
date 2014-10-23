/**
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
namespace ERPWPF.Model
{
	/// <summary>
	/// User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class User
	{
		public User()
		{}
		#region Model
		private int _uid;
		private string _uname;
		private string _upassword;
		private int? _upermisson;
		private string _ulogintime;
		/// <summary>
		/// 
		/// </summary>
		public int Uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UName
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPassword
		{
			set{ _upassword=value;}
			get{return _upassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UPermisson
		{
			set{ _upermisson=value;}
			get{return _upermisson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ULoginTime
		{
			set{ _ulogintime=value;}
			get{return _ulogintime;}
		}
		#endregion Model

	}
}

