using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using MySql.Data.MySqlClient.Memcached;
using ReactiveUI;
using Xugz;

namespace MetalizationSystem.Devices
{ 
    /// <summary>磁力搅拌器</summary>
    public class Mixer
    {
        DMTcpClient client;
        bool connected;
        bool _isMixing = false;
        ManualResetEvent mre = new ManualResetEvent(false);

        string receiveString = string.Empty;
        byte[] receiveByte;

        public Mixer(string ip,short port)
        {
            client = new DMTcpClient();
            client.OnStateInfo += Client_OnStateInfo;
            client.OnReceviceByte += Client_OnReceviceByte;
            client.OnErrorMsg += Client_OnErrorMsg;
            client.ServerIp = IPAddress.Parse(ip);
            client.ServerPort = port;
            client.StartConnection();
        }
        public bool Connected
        {
            get
            {
                return connected;
            }
        }

        /// <summary>
        /// 是否在搅拌
        /// </summary>
        public bool Mixing
        {
            get
            {
                return _isMixing;
            }
        }
        private void Client_OnErrorMsg(string msg)
        {
            //throw new NotImplementedException(); 2025-09-16 报错屏蔽
        }

        private void Client_OnReceviceByte(byte[] date)
        {
            receiveString = Encoding.Default.GetString(date);
            receiveByte = date;
            mre.Set();
        }

        private void Client_OnStateInfo(string msg, SocketState state)
        {
            switch (state)
            {
                case SocketState.Connecting:
                    break;
                case SocketState.Connected:
                    connected = true;
                    //Log.Info($"已成功连接服务器  {remoteIP}:{remotePort}");
                    break;
                case SocketState.Reconnection:
                    break;
                case SocketState.Disconnect:
                    if (connected == true)
                    {
                        connected = false;
                        //Log.Info($"与服务器的连接断开  {remoteIP} : {remotePort}");
                    }
                    break;
                case SocketState.StartListening:
                    break;
                case SocketState.StopListening:
                    break;
                case SocketState.ClientOnline:
                    break;
                case SocketState.ClientOnOff:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 开始搅拌
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="dir">0 正转 ，1 反转</param>
        /// <param name="delay"></param>
        //public bool Start(int speed,int dir = 0, int delay = 1000)
        //{
        //    if (!Wait("CMDD " +  speed.ToString() + "\r\n", delay)) return false;
        //    if (!Wait("CMDC " + dir.ToString() + "\r\n", delay)) return false;
        //    return Wait("CMDA\r\n", delay);
        //}
        public bool Start()
        {
            bool result = Wait("CMDA\r\n", 1000);
            if (result)
            {
                _isMixing = true;
            }
            return result;
        }
        public bool Stop()
        {
            bool result = Wait("CMDB\r\n", 1000);
            if (result)
            {
                _isMixing = false;
            }
            return result;
        }

        bool Wait(string cmd,int delay =1000)
        {           
            receiveString = "";
            client.SendCommand(cmd, false);
            mre.WaitOne(delay);
            mre.Reset();            
            return receiveString.Contains("OK");
        }       
    }
}
