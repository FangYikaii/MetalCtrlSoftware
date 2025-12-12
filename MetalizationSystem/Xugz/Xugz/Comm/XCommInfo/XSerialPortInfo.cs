using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Xugz
{
    [Serializable]
    public class XSerialPortInfo: XCommInfo
    {
        public string Port { get; set; } = "COM1";
        public int Baudrate { get; set; } = 9600;
        public int Databits { get; set; } = 8;
        public StopBits StopBits { get; set; } = StopBits.One;
        public Parity Parity { get; set; } = Parity.None;
    }
}
