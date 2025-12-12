using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xugz
{
    public class XCommInfo:XObject
    {
        public ModbusType Type { get; set; } = ModbusType.None;
        public enum ModbusType
        {
            None,
            Ascii,
            Rtu,
            Tcp
        }
    }
}
