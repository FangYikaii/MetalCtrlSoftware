using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cszmcaux;

namespace MetalizationSystem
{
    public class XAd
    {
        IntPtr g_handle = (IntPtr)0;
        int index;
        string name;
        float value = -1;
      

        public XAd(int index, string name, IntPtr g_handle)
        {
            this.g_handle = g_handle;
            this.index = index;
            this.name = name;
        }
        public float Value { get => value; }
        public string Name { get => name; }
        public bool Update()
        {
            lock (this)
            {         
                zmcaux.ZAux_Direct_GetAD(g_handle, index, ref value);               
            }
            return true;
        }
    }
}
