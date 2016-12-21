using System;
using System.Data;
using System.Collections.Generic;
using TPR2.Common;
using TPR2.Model.guess;
namespace TPR2.BLL.guess
{
    /// <summary>
    /// 业务逻辑类BaListMe 的摘要说明。
    /// </summary>
    public class BaListMe
    {
        private readonly TPR2.DAL.guess.BaListMe dal = new TPR2.DAL.guess.BaListMe();
        public BaListMe()
        { }
        #region  成员方法

               
        //---------------------------超级投注使用----------------------
        /// <summary>
        /// 更新已确定超级投注会员ID
        /// </summary>
        public void Updatep_usid(int ID, string p_usid)
        {
            dal.Updatep_usid(ID, p_usid);
        }
              
        /// <summary>
        /// 得到超级投注会员ID
        /// </summary>
        public string Getp_usid(int ID)
        {
            return dal.Getp_usid(ID);
        }

        //---------------------------超级投注使用----------------------
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
        /// 是否存在该记录
        /// </summary>
        public bool ExistsByp_id(int p_id)
        {
            return dal.ExistsByp_id(p_id);
        }
               
        /// <summary>
        /// 是否已隐藏大小盘
        /// </summary>
        public bool ExistsDX(int p_id)
        {
            return dal.ExistsDX(p_id);
        }
               
        /// <summary>
        /// 是否已隐藏标准盘
        /// </summary>
        public bool ExistsBZ(int p_id)
        {
            return dal.ExistsBZ(p_id);
        }

        /// <summary>
        /// 得到查询的记录数
        /// </summary>
        public int GetCount(TPR2.Model.guess.BaListMe model)
        {
            return dal.GetCount(model);
        }

        /// <summary>
        /// 得到查询的记录数
        /// </summary>
        public int GetCountByp_title(string p_title)
        {
            return dal.GetCountByp_title(p_title);
        }

        /// <summary>
        /// 根据条件得到赛事总注数
        /// </summary>
        public int GetBaListMeCount(string strWhere)
        {
            return dal.GetBaListMeCount(strWhere);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TPR2.Model.guess.BaListMe model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加足球让球盘一条数据
        /// </summary>
        public int FootAdd(TPR2.Model.guess.BaListMe model)
        {
            return dal.FootAdd(model);
        }

        /// <summary>
        /// 更新赛事隐藏与显示
        /// </summary>
        public void Updatep_del(TPR2.Model.guess.BaListMe model)
        {
            dal.Updatep_del(model);
        }

        /// <summary>
        /// 更新赛事抓取与不抓取
        /// </summary>
        public void Updatep_jc(TPR2.Model.guess.BaListMe model)
        {
            dal.Updatep_jc(model);
        }

        /// <summary>
        /// 更新赛事结果状态
        /// </summary>
        public void Updatep_zd(TPR2.Model.guess.BaListMe model)
        {
            dal.Updatep_zd(model);
        }

        /// <summary>
        /// 更新赛事比分
        /// </summary>
        public void UpdateResult(TPR2.Model.guess.BaListMe model)
        {
            dal.UpdateResult(model);
        }

        /// <summary>
        /// 自动更新赛事比分
        /// </summary>
        public int UpdateZDResult(TPR2.Model.guess.BaList model)
        {
            return dal.UpdateZDResult(model);
        }

        /// <summary>
        /// 更新进球时间集合
        /// </summary>
        public void UpdateOnce(TPR2.Model.guess.BaListMe model)
        {
            dal.UpdateOnce(model);
        }
               
        /// <summary>
        /// 更新进球时间集合
        /// </summary>
        public void UpdateOnce(int p_id, string p_once)
        {
            dal.UpdateOnce(p_id, p_once);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(TPR2.Model.guess.BaListMe model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update2(TPR2.Model.guess.BaListMe model)
        {
            dal.Update2(model);
        }

        /// <summary>
        /// 更新篮球一条数据
        /// </summary>
        public void BasketUpdate(TPR2.Model.guess.BaList model)
        {
            dal.BasketUpdate(model);
        }

        /// <summary>
        /// 更新足球让球盘
        /// </summary>
        public void FootUpdate(TPR2.Model.guess.BaList model)
        {
            dal.FootUpdate(model);
        }

        /// <summary>
        /// 更新足球大小盘
        /// </summary>
        public void FootdxUpdate(TPR2.Model.guess.BaList model)
        {
            dal.FootdxUpdate(model);
        }

        /// <summary>
        /// 更新足球标准盘
        /// </summary>
        public void FootbzUpdate(TPR2.Model.guess.BaList model)
        {
            dal.FootbzUpdate(model);
        }

        /// <summary>
        /// 更新为走地模式
        /// </summary>
        public void FootOnceType(int ID, DateTime dt)
        {
            dal.FootOnceType(ID, dt);
        }
        
        /// <summary>
        /// 更新是否封盘
        /// </summary>
        public void Updatep_isluck(int p_id, int state, int Types)
        {
            dal.Updatep_isluck(p_id, state, Types);
        }

        /// <summary>
        /// 更新是否封盘
        /// </summary>
        public void Updatep_isluck2(int id, int state, int Types)
        {
            dal.Updatep_isluck2(id, state, Types);
        }

        /// <summary>
        /// 更新即时比分（走地使用）
        /// </summary>
        public void FootOnceUpdate(TPR2.Model.guess.BaList model)
        {
            dal.FootOnceUpdate(model);
        }
               
        /// <summary>
        /// 更新即时比分8波
        /// </summary>
        public int UpdateBoResult2(int p_id, int p_result_temp1, int p_result_temp2)
        {
            return dal.UpdateBoResult2(p_id, p_result_temp1, p_result_temp2);
        }
        /// <summary>
        /// 更新即时比分8波
        /// </summary>
        public int UpdateBoResult3(int p_id, int p_result_temp1, int p_result_temp2)
        {
            return dal.UpdateBoResult3(p_id, p_result_temp1, p_result_temp2);
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
        public void DeleteStr(string strWhere)
        {
            dal.DeleteStr(strWhere);
        }
               
        /// <summary>
        /// 得到球类型
        /// </summary>
        public int GetPtype(int ID)
        {
            return dal.GetPtype(ID);
        }

        /// <summary>
        /// 得到联赛时间
        /// </summary>
        public DateTime Getp_TPRtime(int p_id)
        {
            return dal.Getp_TPRtime(p_id);
        }

        /// <summary>
        /// 得到p_id/第二种标准盘更新用
        /// </summary>
        public int Getp_id(DateTime p_TPRtime, string p_one, string p_two)
        {
            return dal.Getp_id(p_TPRtime, p_one, p_two);
        }

        /// <summary>
        /// 得到篮球开奖所需的实体
        /// </summary>
        public TPR2.Model.guess.BaListMe GetBasketOpen(DateTime p_TPRtime, string p_one, string p_two)
        {
            return dal.GetBasketOpen(p_TPRtime, p_one, p_two);
        }

        /// <summary>
        /// 得到足球开奖所需的实体
        /// </summary>
        public TPR2.Model.guess.BaListMe GetFootOpen(string p_title, string p_one, string p_two)
        {
            return dal.GetFootOpen(p_title, p_one, p_two);
        }

        /// <summary>
        /// 得到是否开启走地
        /// </summary>
        public int Getison(int ID)
        {
            return dal.Getison(ID);
        }

        /// <summary>
        /// 得到是否开启走地
        /// </summary>
        public int Getisonht(int ID)
        {
            return dal.Getisonht(ID);
        }

        /// <summary>
        /// 得到走地更新时间集合
        /// </summary>
        public string Getonce(int ID)
        {
            return dal.Getonce(ID);
        }
        
        /// <summary>
        /// 得到比分更新时间集合
        /// </summary>
        public string Getp_temptimes(int ID)
        {
            return dal.Getp_temptimes(ID);
        }

        /// <summary>
        /// 得到最新比分更新时间
        /// </summary>
        public DateTime Getp_temptime(int ID)
        {
            return dal.Getp_temptime(ID);
        }

        /// <summary>
        /// 得到p_temptime_p_id
        /// </summary>
        public TPR2.Model.guess.BaListMe Getp_temptime_p_id(int ID)
        {
            return dal.Getp_temptime_p_id(ID);
        }

        /// <summary>
        /// 得到即时比分
        /// </summary>
        public TPR2.Model.guess.BaListMe GetTemp(int ID)
        {
            return dal.GetTemp(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TPR2.Model.guess.BaListMe GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 取得每页记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList</returns>
        public IList<TPR2.Model.guess.BaListMe> GetBaListMes(int p_pageIndex, int p_pageSize, string strWhere, string strOrder, out int p_recordCount)
        {
            return dal.GetBaListMes(p_pageIndex, p_pageSize, strWhere, strOrder, out p_recordCount);
        }

        /// <summary>
        /// 取得联赛记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList</returns>
        public IList<TPR2.Model.guess.BaListMe> GetBaListMeLX(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
        {
            return dal.GetBaListMeLX(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
        }

        /// <summary>
        /// 取得未开奖赛事记录
        /// </summary>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList</returns>
        public IList<TPR2.Model.guess.BaListMe> GetBaListMeBF(string strWhere, out int p_recordCount)
        {
            return dal.GetBaListMeBF(strWhere, out p_recordCount);
        }

        #endregion  成员方法
    }
}

