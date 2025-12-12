using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xugz.FIleOp;

namespace Xugz
{
    public enum LogLevel
    {
        Debug = 1,
        Info,
        Warn,
        Error,
        Fatal
    }
    public  class Log
    {
        /// <summary>保存文件夹</summary>
        public static string Path { get; set; } = AppContext.BaseDirectory + "Log";
        /// <summary>提示</summary>
        public static void Info(string message,string path="") { Print(LogLevel.Info, message,path); }
        /// <summary>调试</summary>
        public static void Debug(string message, string path = "") { Print(LogLevel.Debug, message,path); }

        /// <summary>警告</summary>
        public static void Warn(string message) { Print(LogLevel.Warn, message); }
        /// <summary>错误</summary>
        public static void Error(string message) { Print(LogLevel.Error, message); }
        /// <summary>异常</summary>
        public static void Fatal(string message) { Print(LogLevel.Fatal, message); }

        public static void Print(LogLevel LogLevel, string message,string path="")
        {
            if (path == string.Empty)
            {
                path = Path;
            }
            CsvHelper.Instance.WriteLine(path + DateTime.Now.ToString("yyyyMMdd") + @"\"+ LogLevel.ToString() + ".txt", DateTime.Now.ToString("HH:mm:ss:fff") + ": " + message);
        }

        /// <summary>删除指定日期前的日志</summary>
        public static void DeleteLog(int dayNum)
        {
            Task.Run(() =>
            {
                try
                {
                    DateTime tempDate;
                    DirectoryInfo dir = new DirectoryInfo(Path);
                    FileInfo[] fileInfo = dir.GetFiles();
                    // 遍历
                    foreach (FileInfo NextFile in fileInfo)
                    {
                        tempDate = NextFile.LastWriteTime;
                        int days = (DateTime.Now - tempDate).Days;
                        if (days > dayNum)// 删除dayNum天前
                            File.Delete(NextFile.FullName);
                    }
                }
                catch (Exception ex)
                {
                    Error("Log:" + ex.Message);
                }
            });
        }      
    }
}
