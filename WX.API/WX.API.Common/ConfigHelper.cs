using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WX.API.Common
{
    public class ConfigHelper
    {
        /// <summary>
        /// Eric连接字符串
        /// </summary>
        public static string ZswConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
            }
        }


        /// <summary>
        /// 樊晓炜连接字符串
        /// </summary>
        public static string FxwConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
            }
        }


        /// <summary>
        /// 刘嘉博连接字符串
        /// </summary>
        public static string LjbConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
            }
        }


        /// <summary>
        /// 郭召欣
        /// </summary>
        public static string GzxConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
            }
        }


        /// <summary>
        /// 刘宏军
        /// </summary>
        public static string LhjConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
            }
        }
    }
}
