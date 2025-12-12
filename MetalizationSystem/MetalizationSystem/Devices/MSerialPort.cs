using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SqlSugar;
using Xugz;

namespace MetalizationSystem
{
    public class MSerialPort
    {
        ManualResetEvent mre = new ManualResetEvent(false);
        MySerialPort mySerial;
        bool _isHex = false;
        public bool Connected = false;
        public int _checkValue = -1;

        public MSerialPort(string portName, int baudRate, int dataBits, StopBits stopBits, Parity parity, bool isHex = false)
        {
            _isHex = isHex;
            mySerial = new MySerialPort();
            mySerial.OnReceiveString += MySerial_OnReceiveString;
            mySerial.PortName = portName;
            mySerial.BaudRate = baudRate;
            mySerial.DataBits = dataBits;
            mySerial.StopBits = stopBits;
            mySerial.Parity = parity;
            Connected = mySerial.OpenPort();
        }

        private void MySerial_OnReceiveString(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            _checkValue = bytes[4];
            mre.Set();
        }
        public bool Wait(byte[] bytes,byte[] checkBytes=null,int checkValue = -1,int delay = 1000)
        {
            bool ret = false;        
            Send(bytes);
            ret = mre.WaitOne(delay);
            mre.Reset();
            if (checkBytes == null) return ret;       
            Send(checkBytes);
            ret = mre.WaitOne(delay);
            mre.Reset();
            _checkValue = -999;
            while (_checkValue != checkValue)
            {
                Send(checkBytes);
                ret = mre.WaitOne(delay);
                mre.Reset();
            }
            return ret;
        }
        public bool Send(byte[] bytes)
        {
            mySerial.WriteData(bytes);
            return true;
        }
        public bool Send(string message)
        {
            mySerial.WriteData(message,_isHex);
            return true;
        }
    }
}
