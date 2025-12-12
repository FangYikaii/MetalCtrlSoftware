using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xugz
{
    public delegate void Receive(string str);
    public abstract class XComm :XObject
    {
        public abstract event Receive OnReceive;
        public abstract bool Init(XCommInfo info,bool isHex = false);

        public abstract bool Write(string msg);

        public abstract bool Write(byte[] msg);

        public abstract bool Connected {  get; }

        public abstract void Close();

    }
}
