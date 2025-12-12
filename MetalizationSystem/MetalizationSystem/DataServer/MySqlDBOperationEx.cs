using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using SqlSugar;

namespace MetalizationSystem.DataServer
{
    public class MySqlDBOperationEx<T> where T : class, new()
    {
        private static string _ip = "127.0.0.1";

        private static string _dbname = "metalizationsystem";

        private static string _password = "";

        /// <summary>
        /// 获取表所有记录
        /// </summary>
        /// <returns></returns>
        public static List<T> GetInfos()
        {
            List<T> lstRet = new List<T>();
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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

        public static ProcessRoute GetInfo(string sn)
        {
            List<ProcessRoute> lstRet = new List<ProcessRoute>();
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

            try
            {
                lstRet = db.Queryable<ProcessRoute>().Where(it => it.Sn.Equals(sn)).ToList();
               
            }
            catch { }
            finally
            {
                db?.Dispose();
            }

            return lstRet[0];
        }

        /// <summary>
        /// 添加单条记录
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool AddInfo(T info)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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
        public static bool AddInfo(List<T> lst)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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
        public static bool UpdateInfo(T info)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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
        /// 更新多条记录
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static bool UpdateInfo(List<T> lst)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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
        /// 删除单条记录
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool DeleteInfo(T info)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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
        /// 删除所有记录
        /// </summary>
        /// <param name="sDbPath"></param>
        /// <returns></returns>
        public static bool DeleteInfo(string sDbPath)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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
        public static bool DeleteInfo(List<T> infos)
        {
            SqlSugarClient db = DbHelper.Instance.GetMysqlClient(_ip, _dbname, _password);

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

    }
}
