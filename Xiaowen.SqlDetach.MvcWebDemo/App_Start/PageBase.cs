using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xiaowen.SqlDetach.Basic;
using Xiaowen.SqlDetach.DAL;

namespace Xiaowen.SqlDetach.MvcWebDemo.App_Start
{
    public class PageBase : Controller
    {
        private DboEntryBase sqlDetach;
        public DboEntryBase SqlDetach
        {
            get
            {
                if (sqlDetach == null)
                {
                    return sqlDetach = new DboEntryBase();
                }
                return sqlDetach;
            }
            set
            {
                sqlDetach = value;
            }
        }
    }
}