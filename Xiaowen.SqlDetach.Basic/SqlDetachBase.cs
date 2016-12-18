using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xiaowen.SqlDetach.SQL;

namespace Xiaowen.SqlDetach.Basic
{
    /// <summary>
    /// 用于MVC UI事件驱动的项目
    /// </summary>
    /// <typeparam name="ActionResult"></typeparam>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public delegate ActionResult MvcActionResultDelegate<out ActionResult>(object sender, SqlDetachEventArgs e);

    /// <summary>
    /// 简单SQL委托
    /// </summary>
    /// <param name="sqlSentence"></param>
    /// <param name="dataParameter"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public delegate StringBuilder SimpleSqlDelegate(ref SimpleSqlSchema sqlSentence, ref ArrayList dataParameter, params WhereClauseSchema[] param);

    /// <summary>
    /// 复杂SQL委托
    /// </summary>
    /// <param name="sqlSentence"></param>
    /// <param name="dataParameter"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public delegate StringBuilder ComplexSqlDelegate(ref SimpleSqlSchema sqlSentence, ref ArrayList dataParameter, params WhereClauseSchema[] param);

    public class SqlDetachBase
    {
        /// <summary>
        /// 
        /// </summary>
        public event MvcActionResultDelegate<ActionResult> MvcActionResultEvent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected virtual void DoSomething(SqlDetachEventArgs e)
        {
            MvcActionResultEvent?.Invoke(this, e);
        }
    }
}
