using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaowen.SqlDetach.Basic;
using Xiaowen.SqlDetach.SQL;
using Xiaowen.SqlDetach.SQL.SqlDetachDemo;

namespace Xiaowen.SqlDetach.DAL.SqlDetachDemo
{
    public class DemoDAL
    {
        /// <summary>
        /// 演示代码
        /// </summary>
        /// <param name="whereParams"></param>
        public void Demo_QueryFirst(DboEntryBase sqlDetach, params WhereClauseSchema[] whereParams)
        {
            DboEntry dbo = new DboEntry(sqlDetach);
            dbo.QueryFirstDemo(whereParams);
        }
    }
}
