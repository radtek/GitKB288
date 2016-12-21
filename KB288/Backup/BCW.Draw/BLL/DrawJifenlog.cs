using System;
using System.Data;
using System.Collections.Generic;
using BCW.Common;
using BCW.Draw.BLL;
namespace BCW.Draw.BLL
{
	/// <summary>
	/// 业务逻辑类Goldlog 的摘要说明。
	/// </summary>
	public class DrawJifenlog
	{
        private readonly BCW.Draw.DAL.DrawJifenlog dal = new BCW.Draw.DAL.DrawJifenlog();
        public DrawJifenlog()
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
		public int  Add(BCW.Draw.Model.DrawJifenlog model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// N秒内，此ID是否消费过
        /// </summary>
        public bool ExistsUsID(int UsID, int Sec)
        {
            return dal.ExistsUsID(UsID, Sec);
        }

        /// <summary>
        /// 得到一天内某个用户是经过社区生成抽奖点值的值
        /// </summary>
        public int GetJfbyTz(int UsId)
        {
            return dal.GetJfbyTz(UsId);
        }

        /// <summary>
        /// 得到一天内某个用户是经过游戏酷币消费生成抽奖点值的值
        /// </summary>
        public int GetJfbyGame(int UsId)
        {
            return dal.GetJfbyGame(UsId);
        }

        /// <summary>
        /// 得到一天内某个用户是经过网上充值消费生成抽奖点值的值
        /// </summary>
        public int GetJfbyCz(int UsId)
        {
            return dal.GetJfbyCz(UsId);
        }

        /// <summary>
        /// 删除一组数据
        /// </summary>
        public void Delete(string strWhere)
        {

            dal.Delete(strWhere);
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BCW.Draw.Model.DrawJifenlog GetJifenlog(int ID)
		{

            return dal.GetJifenlog(ID);
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
		/// <returns>IList Goldlog</returns>
		public IList<BCW.Draw.Model.DrawJifenlog> GetJifenlogs(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
            return dal.GetJifenlogs(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
		}

        /// <summary>
        /// 消息日志重复查询记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">每页显示记录数</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns>List</returns>
        public IList<BCW.Draw.Model.DrawJifenlog> GetJifenlogsCF(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
        {
            return dal.GetJifenlogsCF(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
        }

		#endregion  成员方法
	}
}

