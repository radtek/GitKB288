using System;
using System.Data;
using System.Collections.Generic;
using BCW.Common;
using BCW.Draw.Model;
namespace BCW.Draw.BLL
{
	/// <summary>
	/// 业务逻辑类Drawlist 的摘要说明。
	/// </summary>
	public class Drawlist
	{
		private readonly BCW.Draw.DAL.Drawlist dal=new BCW.Draw.DAL.Drawlist();
		public Drawlist()
		{}
		#region  成员方法

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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BCW.Draw.Model.Drawlist model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BCW.Draw.Model.Drawlist model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// 计算Jifen币值
        /// </summary>
        public int GetJifensum(string  Jifen, string strWhere)
        {
            return dal.GetJifensum(Jifen, strWhere);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BCW.Draw.Model.Drawlist GetDrawlist(int ID)
		{
			
			return dal.GetDrawlist(ID);
		}

		/// <summary>
		/// 根据字段取数据列表
		/// </summary>
		public DataSet GetList(string strField, string strWhere)
		{
			return dal.GetList(strField, strWhere);
		}

		/// <summary>
		/// 取得每页记录
		/// </summary>
		/// <param name="p_pageIndex">当前页</param>
		/// <param name="p_pageSize">分页大小</param>
		/// <param name="p_recordCount">返回总记录数</param>
		/// <param name="strWhere">查询条件</param>
		/// <returns>IList Drawlist</returns>
        public IList<BCW.Draw.Model.Drawlist> GetDrawlists(int p_pageIndex, int p_pageSize, string strWhere, string strOrder, out int p_recordCount)
		{
			return dal.GetDrawlists(p_pageIndex, p_pageSize, strWhere,strOrder, out p_recordCount);
		}

		#endregion  成员方法
	}
}

