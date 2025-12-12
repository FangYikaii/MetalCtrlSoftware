using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using SqlSugar;
using DbType = SqlSugar.DbType;

namespace Xugz
{
    public class SqlSugarManager
    {
        static SqlSugarManager instance =new SqlSugarManager();
        public static SqlSugarManager Instance {  get { return instance; } }
        string _ip = "127.0.0.1";
        int _port = 3306;
        string _user = "root";
        string _dbName = "metalizationsystem";
        string _password = "";
        DbType _dbType = DbType.MySql;
        SqlSugarClient db;

        public SqlSugarManager(string ip, int port, string user, string dbName, string password, DbType dbType)
        {
            _ip = ip;
            _port = port;
            _user = user;
            _dbName = dbName;
            _password = password;
            _dbType = dbType;
            Connect(ConnectionString, _dbType);
        }

        public SqlSugarManager() { }

        void Connect(string connectionString, DbType dbType)
        {
            //通过这个可以直接连接数据库
            db = new SqlSugarClient(new ConnectionConfig()
            {
                //可以在连接字符串中设置连接池pooling=true;表示开启连接池
                //eg:min pool size=2;max poll size=4;表示最小连接池为2，最大连接池是4；默认是100
                ConnectionString = connectionString,
                DbType = dbType,
                IsAutoCloseConnection = true,//自动关闭连接
                InitKeyType = InitKeyType.Attribute
            });           
        }
        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="entityTypes"></param>
        public void InitTables(params Type[] entityTypes)
        {
            try
            {
                db.CodeFirst.InitTables(entityTypes);
            }
            catch (Exception ex) { Debug.WriteLine($"SqlSugarManager InitTables error：{ex.Message}"); }
            finally { }          
        }

        string ConnectionString
        {
            get
            {
                string connectionString = string.Empty;
                switch (_dbType)
                {
                    case DbType.MySql:
                        connectionString = $"Data Source={_ip};port={_port};Database={_dbName};User Id={_user};Password={_password};SslMode=none;";
                        break;
                    case DbType.SqlServer:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Sqlite:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Oracle:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.PostgreSQL:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Dm:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Kdbndp:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Oscar:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.MySqlConnector:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Access:
                        connectionString = $"Provider=Microsoft.ACE.OleDB.16.0;Data Source={_dbName}";
                        break;
                    case DbType.OpenGauss:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.QuestDB:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.HG:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.ClickHouse:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.GBase:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.Odbc:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.OceanBaseForOracle:
                        connectionString = $"Data Source={_ip};port=3306;Database={_dbName};User Id=root;Password={_password};SslMode=none;";
                        break;
                    case DbType.TDengine:

                        break;
                    case DbType.GaussDB:

                        break;
                    case DbType.OceanBase:

                        break;
                    case DbType.Tidb:

                        break;
                    case DbType.Vastbase:

                        break;
                    case DbType.PolarDB:

                        break;
                    case DbType.Doris:

                        break;
                    case DbType.Xugu:
                        connectionString = $"IP={_ip};DB={_dbName};User={_user};PWD={_password};Port={_port};AUTO_COMMIT=on;CHAR_SET=UTF8";//CHAR_SET=GBK
                        break;
                    case DbType.GoldenDB:

                        break;
                    case DbType.TDSQLForPGODBC:
                        connectionString = "Driver={TDSQL PostgreSQL Unicode(x64)};" + $"Server={_ip};Port={_port};Database={_dbName};Uid={_user};Pwd={_password};ConnSettings=set search_path to XIR_APP;";
                        break;
                    case DbType.TDSQL:

                        break;
                    case DbType.HANA:

                        break;
                    case DbType.Custom:

                        break;

                }
                return connectionString;
            }
           
        }



        public class SqlSugarHelper<T> where T : class, new()
        {
            public SqlSugarClient Db;
            //public static SqlSugarHelper<T> GetInstance(string ip, int port, string user, string dbName, string password, DbType dbType)
            //{
            //    string connectionString = string.Empty;
            //    switch (dbType)
            //    {
            //        case DbType.MySql:
            //            connectionString = $"Data Source={ip};port={port};Database={dbName};User Id={user};Password={password};SslMode=none;";
            //            break;
            //        case DbType.SqlServer:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Sqlite:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Oracle:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.PostgreSQL:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Dm:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Kdbndp:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Oscar:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.MySqlConnector:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Access:
            //            connectionString = $"Provider=Microsoft.ACE.OleDB.16.0;Data Source={dbName}";
            //            break;
            //        case DbType.OpenGauss:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.QuestDB:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.HG:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.ClickHouse:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.GBase:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.Odbc:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.OceanBaseForOracle:
            //            connectionString = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";
            //            break;
            //        case DbType.TDengine:

            //            break;
            //        case DbType.GaussDB:

            //            break;
            //        case DbType.OceanBase:

            //            break;
            //        case DbType.Tidb:

            //            break;
            //        case DbType.Vastbase:

            //            break;
            //        case DbType.PolarDB:

            //            break;
            //        case DbType.Doris:

            //            break;
            //        case DbType.Xugu:
            //            connectionString = $"IP={ip};DB={dbName};User={user};PWD={password};Port={port};AUTO_COMMIT=on;CHAR_SET=UTF8";//CHAR_SET=GBK
            //            break;
            //        case DbType.GoldenDB:

            //            break;
            //        case DbType.TDSQLForPGODBC:
            //            connectionString = "Driver={TDSQL PostgreSQL Unicode(x64)};" + $"Server={ip};Port={port};Database={dbName};Uid={user};Pwd={password};ConnSettings=set search_path to XIR_APP;";
            //            break;
            //        case DbType.TDSQL:

            //            break;
            //        case DbType.HANA:

            //            break;
            //        case DbType.Custom:

            //            break;

            //    }
            //    return new SqlSugarHelper<T>(connectionString, dbType);
            //}

            //public static SqlSugarHelper<T> GetInstance(string connectionString, DbType dbType)
            //{
            //    return new SqlSugarHelper<T>(connectionString, dbType);
            //}
            //protected SqlSugarHelper(string connectionString, DbType dbType)
            //{
            //    //通过这个可以直接连接数据库
            //    Db = new SqlSugarClient(new ConnectionConfig()
            //    {
            //        //可以在连接字符串中设置连接池pooling=true;表示开启连接池
            //        //eg:min pool size=2;max poll size=4;表示最小连接池为2，最大连接池是4；默认是100
            //        ConnectionString = connectionString,
            //        DbType = dbType,
            //        IsAutoCloseConnection = true,//自动关闭连接
            //        InitKeyType = InitKeyType.Attribute
            //    });
            //}

            //public void Dispose()
            //{
            //    if (Db != null)
            //    {
            //        Db.Dispose();
            //    }
            //}
            public SimpleClient<T> CurrentDb { get { return new SimpleClient<T>(Db); } }
            /// <summary>
            /// 创建表
            /// </summary>
            /// <param name="entityTypes"></param>
            public virtual void InitTables(params Type[] entityTypes)
            {
                Db.CodeFirst.InitTables(entityTypes);
            }

            /// <summary>
            /// 获取所有
            /// </summary>
            /// <returns></returns>
            public virtual List<T> GetList()
            {
                return CurrentDb.GetList();
            }

            /// <summary>
            /// 根据表达式查询
            /// </summary>
            /// <returns></returns>
            public virtual List<T> GetList(Expression<Func<T, bool>> whereExpression)
            {            
                return CurrentDb.GetList(whereExpression);
            }


            /// <summary>
            /// 根据表达式查询分页
            /// </summary>
            /// <returns></returns>
            public virtual List<T> GetPageList(Expression<Func<T, bool>> whereExpression, SqlSugar.PageModel pageModel)
            {
                return CurrentDb.GetPageList(whereExpression, pageModel);
            }

            /// <summary>
            /// 根据表达式查询分页并排序
            /// </summary>
            /// <param name="whereExpression">it</param>
            /// <param name="pageModel"></param>
            /// <param name="orderByExpression">it=>it.id或者it=>new{it.id,it.name}</param>
            /// <param name="orderByType">OrderByType.Desc</param>
            /// <returns></returns>
            public virtual List<T> GetPageList(Expression<Func<T, bool>> whereExpression, SqlSugar.PageModel pageModel, Expression<Func<T, object>> orderByExpression = null, SqlSugar.OrderByType orderByType = SqlSugar.OrderByType.Asc)
            {
                return CurrentDb.GetPageList(whereExpression, pageModel, orderByExpression, orderByType);
            }

            /// <summary>
            /// 根据主键查询
            /// </summary>
            /// <returns></returns>
            public virtual List<T> GetById(dynamic id)
            {
                return CurrentDb.GetById(id);
            }

            /// <summary>
            /// 根据主键删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Delete(dynamic id)
            {
                if (string.IsNullOrEmpty(id.ObjToString))
                {
                    Console.WriteLine(string.Format("要删除的主键id不能为空值！"));
                }
                return CurrentDb.Delete(id);
            }


            /// <summary>
            /// 根据实体删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Delete(T data)
            {
                if (data == null)
                {
                    Console.WriteLine(string.Format("要删除的实体对象不能为空值！"));
                }
                return CurrentDb.Delete(data);
            }

            /// <summary>
            /// 根据主键删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Delete(dynamic[] ids)
            {
                if (ids.Count() <= 0)
                {
                    Console.WriteLine(string.Format("要删除的主键ids不能为空值！"));
                }
                return CurrentDb.AsDeleteable().In(ids).ExecuteCommand() > 0;
            }

            /// <summary>
            /// 根据表达式删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Delete(Expression<Func<T, bool>> whereExpression)
            {
                return CurrentDb.Delete(whereExpression);
            }


            /// <summary>
            /// 根据实体更新，实体需要有主键
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Update(T obj)
            {
                if (obj == null)
                {
                    Console.WriteLine(string.Format("要更新的实体不能为空，必须带上主键！"));
                }
                return CurrentDb.Update(obj);
            }

            /// <summary>
            ///批量更新
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Update(List<T> objs)
            {
                if (objs.Count <= 0)
                {
                    Console.WriteLine(string.Format("要批量更新的实体不能为空，必须带上主键！"));
                }
                return CurrentDb.UpdateRange(objs);
            }

            /// <summary>
            /// 插入
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Insert(T obj)
            {
                return CurrentDb.Insert(obj);
            }


            /// <summary>
            /// 批量
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public virtual bool Insert(List<T> objs)
            {
                return CurrentDb.InsertRange(objs);
            }

        }
    }

  
}
