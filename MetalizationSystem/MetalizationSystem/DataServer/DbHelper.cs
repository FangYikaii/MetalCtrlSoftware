using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using SqlSugar;

namespace MetalizationSystem.DataServer
{
    public class DbHelper
    {
        static DbHelper instance = new DbHelper();
        public static DbHelper Instance {  get { return instance; } }
        public void Init(string ip = "127.0.0.1",string dbName= "metalizationsystem", string password="")
        {           
            SqlSugarClient client = null;
            string _connStr = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";

            try
            {
                //创建连接实体对象
                client = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = _connStr,
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true,//自动释放数据库，如果存在事务，在事务结束之后释放。
                    InitKeyType = InitKeyType.Attribute//从实体特性中读取主键自增列信息
                });
                //执行建表操作
                client.CodeFirst.InitTables(
                                            typeof(ProcessRoute)
                                            );
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LocalDB_InitMysqlDB出错：{ex.Message}");
            }
            finally
            {
                client?.Dispose();
            }
        }

        public SqlSugarClient GetMysqlClient(string ip = "127.0.0.1", string dbName = "metalizationsystem", string password = "")
        {
            SqlSugarClient client = null;
            string _connStr = $"Data Source={ip};port=3306;Database={dbName};User Id=root;Password={password};SslMode=none;";

            try
            {
                //创建连接实体对象
                client = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = _connStr,
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true,//自动释放数据库，如果存在事务，在事务结束之后释放。
                    InitKeyType = InitKeyType.Attribute//从实体特性中读取主键自增列信息
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LocalDB_GetMysqlClient出错：{ex.Message}");
            }
            return client;
        }

        private  void AddColumn(SqlSugarClient client, Type tableType, string columnName, CSharpDataType columnDataType)
        {
            string sTableName = tableType.Name;
            if (!client.DbMaintenance.IsAnyColumn(sTableName, columnName, false))
            {
                DbColumnInfo dbNewCol = new DbColumnInfo();
                dbNewCol.TableName = sTableName;
                dbNewCol.DbColumnName = columnName;

                if (columnDataType == CSharpDataType.@string)
                {
                    dbNewCol.DataType = "varchar";
                    dbNewCol.Length = 255;
                }
                else if (columnDataType == CSharpDataType.@int)
                {
                    dbNewCol.DataType = "integer";
                    dbNewCol.Length = 8;
                }
                else if (columnDataType == CSharpDataType.@double)
                {
                    dbNewCol.DataType = "real";
                    dbNewCol.Length = 8;
                }
                else if (columnDataType == CSharpDataType.@bool)
                {
                    dbNewCol.DataType = "bit";
                    dbNewCol.Length = 1;
                }
                else
                {
                    throw new Exception("不支持的字段类型！");
                }

                client.DbMaintenance.AddColumn(sTableName, dbNewCol);
            }
        }
    }
}
