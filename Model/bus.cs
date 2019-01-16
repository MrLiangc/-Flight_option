using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// bus:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class bus
	{
		public bus()
		{}
		#region Model
		private int _id;
		private string _start;
		private string _myend;
		private int? _price;
		private DateTime? _time;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string start
		{
			set{ _start=value;}
			get{return _start;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string myend
		{
			set{ _myend=value;}
			get{return _myend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

