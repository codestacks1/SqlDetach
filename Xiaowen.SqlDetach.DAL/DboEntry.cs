using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaowen.SqlDetach.Basic;
using Xiaowen.SqlDetach.SQL;

namespace Xiaowen.SqlDetach.DAL
{
    public class DboEntry
    {
        private DboEntryBase SqlDetach;
        public DboEntry(DboEntryBase sqlDetach)
        {
            this.SqlDetach = sqlDetach;
        }

        /// <summary>
        /// 演示代码
        /// </summary>
        public void QueryFirstDemo(params WhereClauseSchema[] whereParams)
        {
            object dbName = new object();
            SimpleSqlDelegate sqlSentence = SQL.SqlDetachDemo.DemoSql.DemoQueryFirst;
            this.SqlDetach.ExecSimpleSql<object>(dbName, sqlSentence, whereParams);
        }
    }
}
