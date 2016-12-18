using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaowen.SqlDetach.Basic
{
    public class SqlDetachEventArgs : EventArgs
    {
        private object result;
        private bool isSuccessed = true;
        private bool isError = false;
        private string errorMsg;
        /// <summary>
        /// 数据集
        /// </summary>
        public object Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }
        /// <summary>
        /// 是否成功
        ///     DefaultValue:true
        /// </summary>
        public bool IsSuccessed
        {
            get
            {
                return isSuccessed;
            }

            set
            {
                isSuccessed = value;
            }
        }
        /// <summary>
        /// 是否出错
        /// 
        ///     DefaultValue:false
        /// </summary>
        public bool IsError
        {
            get
            {
                return isError;
            }

            set
            {
                isError = value;
            }
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMsg
        {
            get
            {
                return errorMsg;
            }

            set
            {
                errorMsg = value;
            }
        }
    }
}
