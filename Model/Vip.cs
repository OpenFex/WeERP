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
namespace ERPWPF.Model
{
	/// <summary>
	/// Vip:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Vip
	{
		public Vip()
		{}
		#region Model
		private int _vid;
		private string _vname;
		private string _vweixin;
		private string _vtel;
		private string _visdaili;
		private string _vtimerreg;
		/// <summary>
		/// 
		/// </summary>
		public int Vid
		{
			set{ _vid=value;}
			get{return _vid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VName
		{
			set{ _vname=value;}
			get{return _vname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VWeiXin
		{
			set{ _vweixin=value;}
			get{return _vweixin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VTel
		{
			set{ _vtel=value;}
			get{return _vtel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VIsDaili
		{
			set{ _visdaili=value;}
			get{return _visdaili;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VTimerReg
		{
			set{ _vtimerreg=value;}
			get{return _vtimerreg;}
		}
		#endregion Model

	}
}

