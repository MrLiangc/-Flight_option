using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// choose:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class choose
	{
		public choose()
		{}
		#region Model
		private int _id;
		private int? _bus_id;
		private int? _passanger_id;
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
		public int? bus_ID
		{
			set{ _bus_id=value;}
			get{return _bus_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? passanger_ID
		{
			set{ _passanger_id=value;}
			get{return _passanger_id;}
		}
		#endregion Model

	}
}

