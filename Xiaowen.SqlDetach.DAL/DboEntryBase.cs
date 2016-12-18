using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaowen.SqlDetach.Basic;
using Xiaowen.SqlDetach.SQL;

namespace Xiaowen.SqlDetach.DAL
{
    public class DboEntryBase : SqlDetachBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName">数据库链接名称：主要用于读写分离的数据库的链接</param>
        /// <param name="sqlSentence">SQL处理器</param>
        /// <param name="whereParams">SQL条件</param>
        internal virtual void ExecSimpleSql<T>(object dbName, SimpleSqlDelegate sqlSentence, params WhereClauseSchema[] whereParams) where T : class, new()
        {
            SqlDetachEventArgs e = new SqlDetachEventArgs();//通过事件返回的数据内容
            SimpleSqlSchema simpleSqlSchema = new SimpleSqlSchema();//简单SQL架构
            ArrayList dataParameter = new ArrayList();//SqlParameter数组
            sqlSentence.Invoke(ref simpleSqlSchema, ref dataParameter, whereParams);//调用委托方法，执行SQL及条件，及参数组装

            try
            {
                //DB链接，执行SQL
                using (SqlDetachEntities dbo = new SqlDetachEntities())
                {
                    //dbo.Database.Connection.Open();
                    dbo.DemoTbs.Add(new DemoTb()
                    {
                        Alias = "Kelvin",
                        Author = "张孝文",
                        Email = "z.xiaowen@foxmail.com",
                        MobilePhone = "185****7012",
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        UpdatedBy = 1,
                        UpdatedOn = DateTime.Now
                    });
                    int actionResult = dbo.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                e.IsSuccessed = false;
                e.IsError = true;
                e.ErrorMsg = ex.Message;
            }
            this.DoSomething(e);
        }
    }
}
