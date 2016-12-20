using System;
using System.Data;
using System.Collections.Generic;
using BCW.Common;
using BCW.Model;
namespace BCW.BLL
{
	/// <summary>
	/// 业务逻辑类BankUser 的摘要说明。
	/// </summary>
	public class BankUser
	{
		private readonly BCW.DAL.BankUser dal=new BCW.DAL.BankUser();
		public BankUser()
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
        public bool Exists(int UsID)
		{
            return dal.Exists(UsID);
		}
               
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsBankName(string BankName)
        {
            return dal.ExistsBankName(BankName);
        }
   
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsZFBName(string ZFBName)
        {
            return dal.ExistsZFBName(ZFBName);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BCW.Model.BankUser model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BCW.Model.BankUser model)
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
		/// 得到一个对象实体
		/// </summary>
        public BCW.Model.BankUser GetBankUser(int UsID)
		{

            return dal.GetBankUser(UsID);
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
		/// <returns>IList BankUser</returns>
		public IList<BCW.Model.BankUser> GetBankUsers(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			return dal.GetBankUsers(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
		}

		#endregion  成员方法
	}
}

