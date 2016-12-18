using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaowen.SqlDetach.SQL
{
    public struct WhereClauseSchema
    {
        /// <summary>
        /// 既有函数 又有单双日
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="conditionContent"></param>
        /// <param name="isSingleDate">是否单日 false：为日期区间</param>
        /// <param name="isExistFlag"></param>
        public WhereClauseSchema(string condition, object conditionContent, Nullable<bool> isSingleDate, Nullable<bool> isExistFlag)
        {
            this.isSingleDate = isSingleDate;
            this.isExistFlag = isExistFlag;
            this.primaryKey = string.Empty;
            this.conditionKey = condition;
            this.conditionValue = conditionContent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="conditionContent"></param>
        /// <param name="isSingleDate">是否单日 false：为日期区间</param>
        public WhereClauseSchema(string condition, object conditionContent, Nullable<bool> isSingleDate)
        {
            this.isSingleDate = isSingleDate;
            isExistFlag = null;
            this.primaryKey = string.Empty;
            this.conditionKey = condition;
            this.conditionValue = conditionContent;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isExistFlag">SQL中是否存在函数或其他标签</param>
        /// <param name="condition"></param>
        /// <param name="conditionContent"></param>
        public WhereClauseSchema(Nullable<bool> isExistFlag, string condition, object conditionContent)
        {
            this.isSingleDate = null;
            this.isExistFlag = isExistFlag;
            this.primaryKey = string.Empty;
            this.conditionKey = condition;
            this.conditionValue = conditionContent;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <param name="condition"></param>
        /// <param name="conditionContent"></param>
        public WhereClauseSchema(string primaryKey, string condition, object conditionContent)
        {
            this.isSingleDate = null;
            isExistFlag = null;
            this.primaryKey = primaryKey;
            this.conditionKey = condition;
            this.conditionValue = conditionContent;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="conditionContent"></param>
        public WhereClauseSchema(string condition, object conditionContent)
        {
            isSingleDate = null;
            isExistFlag = null;
            this.primaryKey = string.Empty;
            this.conditionKey = condition;
            this.conditionValue = conditionContent;
        }

        private Nullable<bool> isExistFlag;
        /// <summary>
        /// SQL条件中是否存在特殊的标签
        ///     如：CAST CONVERT 等Keyword
        /// </summary>
        public Nullable<bool> IsExistFlag
        {
            get { return isExistFlag; }
            set { isExistFlag = value; }
        }

        private Nullable<bool> isSingleDate;

        public Nullable<bool> IsSingleDate
        {
            get { return isSingleDate; }
            set { isSingleDate = value; }
        }
        /// <summary>
        /// 该字段也用于处理包含特殊字符的情况
        /// </summary>
        private string primaryKey;
        /// <summary>
        /// 主要过滤条件之一，所属当前登录账户的数据，而非其账户的信息
        /// 账户之间是否共享数据，这取决于业务需求
        /// </summary>
        public string PrimaryKey
        {
            get { return primaryKey; }
            set { primaryKey = value; }
        }

        private string conditionKey;
        /// <summary>
        /// 表字段名
        /// </summary>
        public string ConditionKey
        {
            get { return conditionKey; }
            set { conditionKey = value; }
        }
        private object conditionValue;

        /// <summary>
        /// 表字段内容
        /// </summary>
        public object ConditionValue
        {
            get { return conditionValue; }
            set { conditionValue = value; }
        }
    }
}
