using cszmcaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem
{
    public class XDo
    {      
        IntPtr g_handle = (IntPtr)0;
        int index;
        string name;  

        bool sts = false;

        public XDo(int index, string name, IntPtr g_handle)
        {           
            this.g_handle = g_handle;
            this.index = index;
            this.name = name;
        }
        public bool Sts { get => sts; }
        public string Name { get => name; }
        public bool Update()
        {
            lock (this)
            {
                sts = GetDo();
            }
            return true;
        }

        bool GetDo()
        {
            uint ret = 0;
            zmcaux.ZAux_Direct_GetOp(g_handle, index, ref ret);
            return ret != 0;
        }

        public bool SetDo(bool on)
        {
            zmcaux.ZAux_Direct_SetOp(g_handle, index, (uint)(on ? 1 : 0));
            return true;         
        }


    }
}
