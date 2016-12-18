using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaowen.SqlDetach.SQL
{
    public class ComplexSqlSchema
    {
        private string selectShow;

        public string SelectShow
        {
            get { return selectShow; }
            set { selectShow = value; }
        }
        private string selectFrom;

        public string SelectFrom
        {
            get { return selectFrom; }
            set { selectFrom = value; }
        }
        private StringBuilder where;

        public StringBuilder Where
        {
            get { return where; }
            set { where = value; }
        }
        private string groupBy;

        public string GroupBy
        {
            get { return groupBy; }
            set { groupBy = value; }
        }
        private string orderBy;

        public string OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
        }
    }
}
