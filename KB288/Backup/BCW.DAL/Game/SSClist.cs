using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BCW.Data;
using BCW.Common;
namespace BCW.DAL.Game
{
    /// <summary>
    /// 数据访问类SSClist。
    /// </summary>
    public class SSClist
    {
        public SSClist()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return SqlHelper.GetMaxID("ID", "tb_SSClist");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_SSClist");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return SqlHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该期
        /// </summary>
        public bool ExistsSSCId(int SSCId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_SSClist");
            strSql.Append(" where SSCId=@SSCId ");
            SqlParameter[] parameters = {
					new SqlParameter("@SSCId", SqlDbType.Int,4)};
            parameters[0].Value = SSCId;

            return SqlHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 是否存在要更新结果的记录
        /// </summary>
        public bool ExistsUpdateResult()
        {
            int Sec = Utils.ParseInt(ub.GetSub("SSCSec", "/Controls/ssc.xml"));

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_SSClist");
            strSql.Append(" where State=0 and EndTime<'" + DateTime.Now.AddSeconds(Sec) + "'");

            return SqlHelper.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BCW.Model.Game.SSClist model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_SSClist(");
            strSql.Append("SSCId,Result,Notes,State,EndTime)");
            strSql.Append(" values (");
            strSql.Append("@SSCId,@Result,@Notes,@State,@EndTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SSCId", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.NVarChar,50),
					new SqlParameter("@Notes", SqlDbType.NVarChar,100),
					new SqlParameter("@State", SqlDbType.TinyInt,1),
					new SqlParameter("@EndTime", SqlDbType.DateTime)};
            parameters[0].Value = model.SSCId;
            parameters[1].Value = model.Result;
            parameters[2].Value = model.Notes;
            parameters[3].Value = model.State;
            parameters[4].Value = model.EndTime;

            object obj = SqlHelper.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BCW.Model.Game.SSClist model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_SSClist set ");
            strSql.Append("SSCId=@SSCId,");
            strSql.Append("Result=@Result,");
            strSql.Append("Notes=@Notes,");
            strSql.Append("EndTime=@EndTime");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SSCId", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.NVarChar,50),
					new SqlParameter("@Notes", SqlDbType.NVarChar,100),
					new SqlParameter("@EndTime", SqlDbType.DateTime)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.SSCId;
            parameters[2].Value = model.Result;
            parameters[3].Value = model.Notes;
            parameters[4].Value = model.EndTime;

            SqlHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 更新开奖结果
        /// </summary>
        public void UpdateResult(int SSCId, string Result)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_SSClist set ");
            strSql.Append("Result=@Result,");
            strSql.Append("State=1");
            strSql.Append(" where SSCId=@SSCId and State=0");
            SqlParameter[] parameters = {
					new SqlParameter("@SSCId", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.NVarChar,50)};
            parameters[0].Value = SSCId;
            parameters[1].Value = Result;

            SqlHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_SSClist ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            SqlHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BCW.Model.Game.SSClist GetSSClist(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SSCId,Result,Notes,State,EndTime from tb_SSClist ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            BCW.Model.Game.SSClist model = new BCW.Model.Game.SSClist();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(strSql.ToString(), parameters))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    model.ID = reader.GetInt32(0);
                    model.SSCId = reader.GetInt32(1);
                    model.Result = reader.GetString(2);
                    model.Notes = reader.GetString(3);
                    model.State = reader.GetByte(4);
                    model.EndTime = reader.GetDateTime(5);
                    return model;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 得到最后一期对象实体
        /// </summary>
        public BCW.Model.Game.SSClist GetSSClistLast()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SSCId,Result,Notes,State,EndTime from tb_SSClist");
            strSql.Append(" Order by id desc ");

            BCW.Model.Game.SSClist model = new BCW.Model.Game.SSClist();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(strSql.ToString()))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    model.ID = reader.GetInt32(0);
                    model.SSCId = reader.GetInt32(1);
                    model.Result = reader.GetString(2);
                    model.Notes = reader.GetString(3);
                    model.State = reader.GetByte(4);
                    model.EndTime = reader.GetDateTime(5);
                    return model;
                }
                else
                {
                    model.ID = 0;
                    model.SSCId = 0;
                    model.Result = "";
                    model.Notes = "";
                    model.State = 0;
                    model.EndTime = DateTime.Now;
                    return model;
                }
            }
        }

        /// <summary>
        /// 得到上期开奖
        /// </summary>
        public BCW.Model.Game.SSClist GetSSClistLast2()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SSCId,Result from tb_SSClist where State=1");
            strSql.Append(" Order by id desc ");

            BCW.Model.Game.SSClist model = new BCW.Model.Game.SSClist();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(strSql.ToString()))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    model.ID = reader.GetInt32(0);
                    model.SSCId = reader.GetInt32(1);
                    model.Result = reader.GetString(2);
                    return model;
                }
                else
                {
                    return null;
                }
            }
        }


        /// <summary>
        /// 根据字段取数据列表
        /// </summary>
        public DataSet GetList(string strField, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  " + strField + " ");
            strSql.Append(" FROM tb_SSClist ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.Query(strSql.ToString());
        }


        /// <summary>
        /// 取得固定列表记录
        /// </summary>
        /// <param name="SizeNum">列表记录数</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns>IList SSClist</returns>
        public IList<BCW.Model.Game.SSClist> GetSSClists(int SizeNum, string strWhere)
        {
            IList<BCW.Model.Game.SSClist> listSSClists = new List<BCW.Model.Game.SSClist>();
            string sTable = "tb_SSClist";
            string sPkey = "id";
            string sField = "ID,SSCId,Result,Notes,State,EndTime";
            string sCondition = strWhere;
            string sOrder = "ID Desc";
            int iSCounts = SizeNum;
            int p_recordCount;
            using (SqlDataReader reader = SqlHelper.RunProcedureMe(sTable, sPkey, sField, 1, SizeNum, sCondition, sOrder, iSCounts, out p_recordCount))
            {
                //计算总页数
                if (p_recordCount == 0)
                {
                    return listSSClists;
                }
                while (reader.Read())
                {
                    BCW.Model.Game.SSClist objSSClist = new BCW.Model.Game.SSClist();
                    objSSClist.ID = reader.GetInt32(0);
                    objSSClist.SSCId = reader.GetInt32(1);
                    objSSClist.Result = reader.GetString(2);
                    objSSClist.Notes = reader.GetString(3);
                    objSSClist.State = reader.GetByte(4);
                    objSSClist.EndTime = reader.GetDateTime(5);
                    listSSClists.Add(objSSClist);
                }
            }
            return listSSClists;
        }


        /// <summary>
        /// 取得每页记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns>IList SSClist</returns>
        public IList<BCW.Model.Game.SSClist> GetSSClists(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
        {
            IList<BCW.Model.Game.SSClist> listSSClists = new List<BCW.Model.Game.SSClist>();
            string sTable = "tb_SSClist";
            string sPkey = "id";
            string sField = "ID,SSCId,Result,Notes,State,EndTime";
            string sCondition = strWhere;
            string sOrder = "ID Desc";
            int iSCounts = 0;
            using (SqlDataReader reader = SqlHelper.RunProcedureMe(sTable, sPkey, sField, p_pageIndex, p_pageSize, sCondition, sOrder, iSCounts, out p_recordCount))
            {
                //计算总页数
                if (p_recordCount > 0)
                {
                    int pageCount = BasePage.CalcPageCount(p_recordCount, p_pageSize, ref p_pageIndex);
                }
                else
                {
                    return listSSClists;
                }
                while (reader.Read())
                {
                    BCW.Model.Game.SSClist objSSClist = new BCW.Model.Game.SSClist();
                    objSSClist.ID = reader.GetInt32(0);
                    objSSClist.SSCId = reader.GetInt32(1);
                    objSSClist.Result = reader.GetString(2);
                    objSSClist.Notes = reader.GetString(3);
                    objSSClist.State = reader.GetByte(4);
                    objSSClist.EndTime = reader.GetDateTime(5);
                    listSSClists.Add(objSSClist);
                }
            }
            return listSSClists;
        }

        #endregion  成员方法
    }
}

