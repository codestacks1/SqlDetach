using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaowen.SqlDetach.Basic;
using Xiaowen.SqlDetach.DAL;
using Xiaowen.SqlDetach.DAL.SqlDetachDemo;
using Xiaowen.SqlDetach.SQL;

namespace Xiaowen.SqlDetach.BLL.SqlDetachDemo
{
    public class DemoBLL
    {
        public void QueryFirst(DboEntryBase sqlDetach,params WhereClauseSchema[] whereParams)
        {
            DemoDAL dal = new DemoDAL();
            dal.Demo_QueryFirst(sqlDetach, whereParams);
        }
    }
}
