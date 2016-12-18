using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xiaowen.SqlDetach.BLL.SqlDetachDemo;
using Xiaowen.SqlDetach.DAL;
using Xiaowen.SqlDetach.MvcWebDemo.App_Start;
using Xiaowen.SqlDetach.SQL;

namespace Xiaowen.SqlDetach.MvcWebDemo.Controllers
{
    public class SqlDetachDemoController : PageBase
    {
        private readonly DemoBLL bll = new DemoBLL();
        // GET: SqlDetachDemo
        public ActionResult Index(int id = -1)
        {
            ArrayList whereParams = new ArrayList();
            whereParams.Add(new WhereClauseSchema("Id", 1));
            this.SqlDetach.MvcActionResultEvent += SqlDetach_QueryFirstDemo;
            bll.QueryFirst(this.SqlDetach, whereParams.Cast<WhereClauseSchema>().ToArray());

            return View();
        }

        private ActionResult SqlDetach_QueryFirstDemo(object sender, Basic.SqlDetachEventArgs e)
        {
            return View();
        }
    }
}