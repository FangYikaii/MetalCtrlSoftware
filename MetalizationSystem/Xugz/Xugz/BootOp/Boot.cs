using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Xugz.BootOp
{
    /// <summary> 对系统的操作</summary>
    public class Boot
    {
        [DllImport("kernel32")]
        private static extern int GetTickCount();
        /// <summary>
        /// 开机启动设置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="path"></param>
        /// <param name="value"></param>
        public static void BootAutomatically(string key, bool value = true,string path="")
        {
            if (value)
            {
                if (path == "") path = Assembly.GetExecutingAssembly().Location;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.SetValue(key, path);
                rk2.Close();
                rk.Close();
            }
            else //取消开机自启动  
            {
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.DeleteValue(key, false);
                rk2.Close();
                rk.Close();
            }
        }
        /// <summary>
        /// 线程暂停时间
        /// </summary>
        /// <param name="delayTime"></param>
        public static void Sleep(int delayTime)
        {
            int TT = GetTickCount();
            do
            {
                if ((GetTickCount() - TT) < 0) { TT = GetTickCount(); }
            } while (GetTickCount() - TT >= delayTime);
        }
    }
}
