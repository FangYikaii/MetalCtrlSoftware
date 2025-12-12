using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xugz;

namespace MetalizationSystem.DataServer
{
    public class LogServer
    {
        public LogServer() { }  

        public static void Info(string message,string sn="",string path="")
        {
            if (path == "") path = @"D:\" + Globa.Path.SystemName + "\\Log";           
            Log.Info(message,path);
            if (sn != "")
            {
                Log.Info(message, path + sn);
            }
            Globa.LogList.Insert(0,DateTime.Now.ToString("HH:mm:ss:fff") + ": " + message);
        }

    }
}
