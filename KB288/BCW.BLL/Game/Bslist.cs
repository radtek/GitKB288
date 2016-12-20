using System;
using System.Data;
using System.Collections.Generic;
using BCW.Common;
using BCW.Model.Game;
namespace BCW.BLL.Game
{
	/// <summary>
	/// 业务逻辑类Bslist 的摘要说明。
	/// </summary>
	public class Bslist
	{
		private readonly BCW.DAL.Game.Bslist dal=new BCW.DAL.Game.Bslist();
		public Bslist()
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
		public int  Add(BCW.Model.Game.Bslist model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BCW.Model.Game.Bslist model)
		{
			dal.Update(model);
		}
                
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateMoney(int ID, long Money)
        {
            dal.UpdateMoney(ID, Money);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateClick(int ID)
        {
            dal.UpdateClick(ID);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateBasic(BCW.Model.Game.Bslist model)
        {
            dal.UpdateBasic(model);
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
		public BCW.Model.Game.Bslist GetBslist(int ID)
		{
			
			return dal.GetBslist(ID);
		}
        
        /// <summary>
        /// 得到一个GetID
        /// </summary>
        public int GetID(int UsID, int BzType)
        {
            return dal.GetID(UsID, BzType);
        }
                
        /// <summary>
        /// 得到一个Title
        /// </summary>
        public string GetTitle(int ID)
        {
            return dal.GetTitle(ID);
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
        /// <param name="strOrder">排序条件</param>
        /// <returns>IList Bslist</returns>
        public IList<BCW.Model.Game.Bslist> GetBslists(int p_pageIndex, int p_pageSize, string strWhere, string strOrder, out int p_recordCount)
        {
			return dal.GetBslists(p_pageIndex, p_pageSize, strWhere, strOrder, out p_recordCount);
		}

		#endregion  成员方法
	}
}

