using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Diagnostics;

using SqlSugar;

namespace DbOperationLibrary
{
    public class CommonDbOperation
    {
        private CommonDbConnectionInfo mConnectInfo = null;

        public CommonDbOperation(CommonDbConnectionInfo connectInfo)
        {
            mConnectInfo = connectInfo;
        }

        private SqlSugarClient GetClient()
        {
            SqlSugarClient client = null;
            string sConnStr = "";

            DbType tDbType = mConnectInfo.DbType;
            string sDbPath = mConnectInfo.DbPath;
            string sPassword = mConnectInfo.DbPassword;
            string sDbIP = mConnectInfo.DbIP;
            string sDbName = mConnectInfo.DbName;
            string sUserName = mConnectInfo.UserName;
            int iDbPort = mConnectInfo.DbPort;

            if (mConnectInfo.DbType == DbType.Sqlite)
            {
                if (!File.Exists(sDbPath)) File.Create(sDbPath).Close();

                if (sPassword != "")
                    sConnStr = $"Data Source={sDbPath};Version=3;Password={sPassword};";
                else
                    sConnStr = $"Data Source={sDbPath};Version=3;";
            }
            else if (mConnectInfo.DbType == DbType.MySql)
            {
                sConnStr = $"Data Source={sDbIP};port={iDbPort};Database={sDbName};User Id={sUserName};Password={sPassword};SslMode=none;";
            }
            else
            {
                //什么也不做(未来扩展)
            }

            client = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = sConnStr,
                DbType = tDbType,
                IsAutoCloseConnection = true,          //自动释放数据库，如果存在事务，在事务结束之后释放。
                InitKeyType = InitKeyType.Attribute    //从实体特性中读取主键自增列信息
            });

            return client;
        }

        /// <summary>
        /// 初始化表，执行建表操作
        /// </summary>
        /// <param name="tables"></param>
        public void InitTables(params Type[] tables)
        {
            SqlSugarClient client = GetClient();

            try
            {
                if (tables.Length > 0) client.CodeFirst.InitTables(tables);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"InitTables出错：{ex.Message}");
            }
            finally
            {
                client?.Dispose();
            }
        }







        /// <summary>
        /// 获取表所有记录
        /// </summary>
        /// <returns></returns>
        public List<T> GetInfo<T>()
        {
            List<T> lstRet = new List<T>();
            SqlSugarClient db = GetClient();

            try
            {
                lstRet = db.Queryable<T>().ToList();
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return lstRet;
        }

        /// <summary>
        /// 获取满足条件的的所有记录
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public List<T> GetInfo<T>(Expression<Func<T, bool>> expression)
        {
            List<T> lstRet = new List<T>();
            SqlSugarClient db = GetClient();

            try
            {
                lstRet = db.Queryable<T>().Where(expression).ToList();
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return lstRet;
        }

        /// <summary>
        /// 添加单条记录
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddInfo<T>(T info) where T:class,new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Insertable(info).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 添加多条记录
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public bool AddInfo<T>(List<T> lst) where T : class, new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Insertable(lst).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 更新单条记录
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool UpdateInfo<T>(T info) where T:class,new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Updateable(info).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 更新单条记录的指定字段
        /// </summary>
        /// <param name="info"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool UpdateInfo<T>(T info, Expression<Func<T, object>> expression) where T:class,new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Updateable(info).UpdateColumns(expression).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 更新多条记录
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public bool UpdateInfo<T>(List<T> lst) where T : class, new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Updateable(lst).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 更新多条记录的指定字段
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool UpdateInfo<T>(List<T> lst, Expression<Func<T, object>> expression) where T : class, new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Updateable(lst).UpdateColumns(expression).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool DeleteInfo<T>(T info) where T:class,new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Deleteable(info).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 删除满足条件的记录
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool DeleteInfo<T>(Expression<Func<T, bool>> expression) where T:class,new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Deleteable<T>(expression).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 删除所有记录
        /// </summary>
        /// <returns></returns>
        public bool DeleteInfo<T>() where T:class,new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Deleteable<T>().ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }



        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <param name="infos"></param>
        /// <returns></returns>
        public bool DeleteInfo<T>(List<T> infos) where T : class, new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Deleteable(infos).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public bool DeleteInfo<T>(List<dynamic> keys) where T : class, new()
        {
            SqlSugarClient db = GetClient();

            try
            {
                db.Deleteable<T>(keys).ExecuteCommand();
                return true;
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return false;
        }
    }
}
