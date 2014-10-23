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
namespace ERPWPF.Model
{
	/// <summary>
	/// Dingdan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Dingdan
	{
		public Dingdan()
		{}
		#region Model
		private int _tid;
		private string _tbuyerid;
		private string _tjiage;
		private string _tshuliang;
		private string _tsonghuo;
		private string _tyunfei;
		private string _theji;
		private string _tisfukuan;
		private string _tisfahuo;
		private string _tisqianshou;
		private string _tischedan;
		private string _tistuikuan;
		private string _ttimexiadan;
		private string _ttimefahuo;
		private string _ttimeqianshou;
		private string _ttimechedan;
		private string _ttimetuikuan;
		/// <summary>
		/// 
		/// </summary>
		public int Tid
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TBuyerID
		{
			set{ _tbuyerid=value;}
			get{return _tbuyerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TJiage
		{
			set{ _tjiage=value;}
			get{return _tjiage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TShuliang
		{
			set{ _tshuliang=value;}
			get{return _tshuliang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TSonghuo
		{
			set{ _tsonghuo=value;}
			get{return _tsonghuo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYunFei
		{
			set{ _tyunfei=value;}
			get{return _tyunfei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string THeji
		{
			set{ _theji=value;}
			get{return _theji;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TIsFukuan
		{
			set{ _tisfukuan=value;}
			get{return _tisfukuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TIsFahuo
		{
			set{ _tisfahuo=value;}
			get{return _tisfahuo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TIsQianshou
		{
			set{ _tisqianshou=value;}
			get{return _tisqianshou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TIsChedan
		{
			set{ _tischedan=value;}
			get{return _tischedan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TIsTuikuan
		{
			set{ _tistuikuan=value;}
			get{return _tistuikuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTimeXiadan
		{
			set{ _ttimexiadan=value;}
			get{return _ttimexiadan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTimeFahuo
		{
			set{ _ttimefahuo=value;}
			get{return _ttimefahuo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTimeQianshou
		{
			set{ _ttimeqianshou=value;}
			get{return _ttimeqianshou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTimeChedan
		{
			set{ _ttimechedan=value;}
			get{return _ttimechedan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTimeTuikuan
		{
			set{ _ttimetuikuan=value;}
			get{return _ttimetuikuan;}
		}
		#endregion Model

	}
}

