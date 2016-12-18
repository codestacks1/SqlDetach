using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaowen.SqlDetach.SQL
{
    public class SimpleSqlSchema
    {
        private string sqlSubject;
        /// <summary>
        /// SQL主体
        ///     如：select * from YSB_Table
        ///         select * from YSB_Table where ID = 1
        ///         update YSB_Table set Column = 2 where ID = 1
        /// </summary>
        public string SqlSubject
        {
            get { return sqlSubject; }
            set { sqlSubject = value; }
        }

        private StringBuilder where = new StringBuilder();
        /// <summary>
        /// 条件可选
        ///     条件可空，
        /// </summary>
        public StringBuilder Where
        {
            get { return where; }
            set { where = value; }
        }
    }
}
