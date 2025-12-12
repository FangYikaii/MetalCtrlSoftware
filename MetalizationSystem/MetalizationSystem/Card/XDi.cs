using cszmcaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem
{
    public class XDi
    {     
        IntPtr g_handle = (IntPtr)0;
        int index;
        string name;
        bool stsLast = false;
        bool pls = false;
        bool plf = false;
        bool sts = false;
        
        // 定义状态变化事件
        public event EventHandler<bool> StateChanged;
        
        // 触发状态变化事件的方法
        protected virtual void OnStateChanged(bool newState)
        {
            StateChanged?.Invoke(this, newState);
        }

        public XDi( int index, string name ,IntPtr g_handle)
        {
            this.g_handle = g_handle;
            this.index = index;
            this.name = name;
        }

        public bool Pls { get => pls; }
        public bool Plf { get => plf; }
        public bool Sts { get => sts; }
        public string Name { get => name; }
        public bool Update()
        {
            sts = GetDi();
            lock (this)
            {
                if (sts & !stsLast)
                {
                    pls = true;
                    plf = false;
                }
                else if(!sts & stsLast)
                {
                    pls = false;
                    plf = true;
                }
                else
                {
                    pls = false;
                    plf = false;
                }               
                // 检查是否需要触发状态变化事件
                bool stateChanged = sts != stsLast;
                stsLast = sts;
                
                if (stateChanged)
                {
                    OnStateChanged(sts);
                }
            }
            return true;
        }

        bool GetDi()
        {
            uint ret = 0;
            zmcaux.ZAux_Direct_GetIn(g_handle, index, ref ret);
            return ret != 0;
        }
    }
}
