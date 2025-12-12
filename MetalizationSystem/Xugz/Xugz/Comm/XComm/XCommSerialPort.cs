using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace Xugz
{
    public class XCommSerialPort : XComm
    {
        
        bool IxHex = false;
        XSerialPortInfo Info;
        MySerialPort serialPort;

        public override event Receive OnReceive;
        public override bool Init(XCommInfo info, bool isHex = false)
        {
            try
            {
                IxHex = isHex;
                Info = info as XSerialPortInfo;
                if (Info == null) return false;
                serialPort = new MySerialPort();
                serialPort.OnReceiveString += SerialPort_OnReceiveString; ;
                serialPort.PortName = Info.Port.ToUpper();
                serialPort.BaudRate = Info.Baudrate;
                serialPort.DataBits = Info.Databits;
                serialPort.StopBits = Info.StopBits;
                serialPort.Parity = Info.Parity;
                serialPort.OpenPort();
            }
            catch { return false; }
          return true;         
        }

        public override bool Write(string msg)
        {
            return serialPort.WriteData(msg, IxHex);
        }

        public override bool Write(byte[] msg)
        {
            return serialPort.WriteData(msg);
        }
        private void SerialPort_OnReceiveString(string str)
        {
            OnReceive?.Invoke(str);           
        }

        public override bool Connected
        {
            get
            {
                if (serialPort == null) return false;
                return serialPort.isPortOpen;
            }
        }

        public override void Close()
        {
            if (serialPort != null) serialPort.ClosePort();
        }
    }
}
