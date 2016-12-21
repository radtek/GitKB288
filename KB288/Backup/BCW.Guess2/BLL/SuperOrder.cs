using System;
using System.Data;
using System.Collections.Generic;
using BCW.Common;
using TPR2.Model.guess;
namespace TPR2.BLL.guess
{
	/// <summary>
	/// 业务逻辑类SuperOrder 的摘要说明。
	/// </summary>
	public class SuperOrder
	{
		private readonly TPR2.DAL.guess.SuperOrder dal=new TPR2.DAL.guess.SuperOrder();
		public SuperOrder()
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
		public int  Add(TPR2.Model.guess.SuperOrder model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(TPR2.Model.guess.SuperOrder model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 删除一组数据
		/// </summary>
		public void DeleteStr()
		{
			
			dal.DeleteStr();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TPR2.Model.guess.SuperOrder GetSuperOrder(int ID)
		{
			
			return dal.GetSuperOrder(ID);
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
		/// <returns>IList SuperOrder</returns>
		public IList<TPR2.Model.guess.SuperOrder> GetSuperOrders(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			return dal.GetSuperOrders(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
		}

		#endregion  成员方法
	}
}

