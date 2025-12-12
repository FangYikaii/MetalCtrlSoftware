using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;

namespace DbOperationLibrary
{
    public class CommonDbConnectionInfo
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public DbType DbType { get; set; } = DbType.Sqlite;

        /// <summary>
        /// 数据库路径(针对sqlite)
        /// </summary>
        public string DbPath { get; set; } = "";

        /// <summary>
        /// 数据库密码(针对sqlite或mysql)
        /// </summary>
        public string DbPassword { get; set; } = "";

        /// <summary>
        /// 数据库IP(针对mysql)
        /// </summary>
        public string DbIP { get; set; } = "127.0.0.1";

        /// <summary>
        /// 数据库名称(针对mysql)
        /// </summary>
        public string DbName { get; set; } = "";

        /// <summary>
        /// 用户名(针对mysql)
        /// </summary>
        public string UserName { get; set; } = "root";

        /// <summary>
        /// 数据库端口(针对mysql)
        /// </summary>
        public int DbPort { get; set; } = 3306;

    }
}
