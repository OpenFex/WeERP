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
namespace ERPWPF.Model
{
	/// <summary>
	/// Shangpin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Shangpin
	{
		public Shangpin()
		{}
		#region Model
		private int _gid;
		private string _gcode;
		private string _gname;
		private string _gguige;
		private string _gshuliang;
		private string _gjinjia;
		private string _gshoujia;
		private string _gtime;
		/// <summary>
		/// 
		/// </summary>
		public int Gid
		{
			set{ _gid=value;}
			get{return _gid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GCode
		{
			set{ _gcode=value;}
			get{return _gcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GName
		{
			set{ _gname=value;}
			get{return _gname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GGuige
		{
			set{ _gguige=value;}
			get{return _gguige;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GShuliang
		{
			set{ _gshuliang=value;}
			get{return _gshuliang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJinjia
		{
			set{ _gjinjia=value;}
			get{return _gjinjia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GShoujia
		{
			set{ _gshoujia=value;}
			get{return _gshoujia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GTime
		{
			set{ _gtime=value;}
			get{return _gtime;}
		}
		#endregion Model

	}
}

