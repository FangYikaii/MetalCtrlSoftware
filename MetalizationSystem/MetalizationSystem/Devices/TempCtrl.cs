using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.VariantTypes;
using Modbus.Device;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xugz;

namespace MetalizationSystem.Devices
{
    public class TempCtrl
    {
        ManualResetEvent mre = new ManualResetEvent(false);
        DMTcpClient myClient;
        public bool Connected = false;
        string receiveString = string.Empty;
        byte[] receiveByte;
        public double[] Temperature = new double[16]; // 单位：℃
        bool _isReading = false;
        bool _isWriting = false;

        public TempCtrl(string ip, short port)
        {
            myClient = new DMTcpClient();
            myClient.OnStateInfo += MyClient_OnStateInfo;
            myClient.OnReceviceByte += MyClient_OnReceviceByte;
            myClient.OnErrorMsg += MyClient_OnErrorMsg;
            myClient.ServerIp = IPAddress.Parse(ip);
            myClient.ServerPort = port;
            myClient.StartConnection();
            Thread th = new Thread(Update) { IsBackground = true };
            th.Start();
        }

        private void MyClient_OnErrorMsg(string msg)
        {
            throw new NotImplementedException();
        }

        private void MyClient_OnReceviceByte(byte[] date)
        {
            receiveString = Encoding.Default.GetString(date);
            receiveByte = date;
            mre.Set();
        }

        private void MyClient_OnStateInfo(string msg, SocketState state)
        {
            switch (state)
            {
                case SocketState.Connecting:
                    break;
                case SocketState.Connected:
                    Connected = true;
                    //Log.Info($"已成功连接服务器  {remoteIP}:{remotePort}");
                    break;
                case SocketState.Reconnection:
                    break;
                case SocketState.Disconnect:
                    if (Connected == true)
                    {
                        Connected = false;
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

        public bool WriteSV(int addr, int channel, double SV)
        {
            _isWriting = true;
            while (_isReading) { Thread.Sleep(200); }
            bool ret = false;
            myClient.SendCommand(Instruction.TempCtrl_WriteSV(addr,channel,SV));
            ret = mre.WaitOne(1000);
            mre.Reset();
            _isWriting = false;
            return ret;
        }

        public bool SetPIDState(int addr, int channel)
        {
            _isWriting = true;
            while (_isReading) { Thread.Sleep(200); }
            bool ret = false;
            myClient.SendCommand(Instruction.TempCtrl_SetPIDState(addr,channel));
            ret = mre.WaitOne(1000);
            mre.Reset();
            _isWriting = false;
            return ret;
        }

        public bool SetStopState(int addr, int channel, int delay = 1000)
        {
            _isWriting = true;
            while (_isReading) { Thread.Sleep(200); }
            bool ret = false;
            myClient.SendCommand(Instruction.TempCtrl_SetStopState(addr, channel));
            ret = mre.WaitOne(delay);
            mre.Reset();
            _isWriting = false;
            return ret;
        }

        public bool ReadPV(int addr, int delay = 1000)
        {
            bool ret = false;
            myClient.SendCommand(Instruction.TempCtrl_ReadPV(addr));
            ret = mre.WaitOne(delay);
            if (ret)
            {
                try
                {
                    // 解析接收到的字节数据，假设每个温度值占用2个字节
                    for (int i = 0; i < 4; i++)
                    {
                        if (receiveByte.Length == 13)
                        {
                            byte[] TempBytes = new byte[2];
                            TempBytes[0] = receiveByte[i * 2 + 4]; // 从第4个字节开始，每个温度值占2个字节
                            TempBytes[1] = receiveByte[i * 2 + 3]; // 数据传输为大端在前，数据解析时修改为小端在前
                            Temperature[(addr - 1) * 4 + i] = BitConverter.ToInt16(TempBytes, 0) / 10.0; // 假设温度值需要除以10转换为实际温度
                        }
                        else
                        {
                            Temperature[i] = double.NaN; // 如果数据不完整，设置为NaN
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing temperature data: {ex.Message}");
                }
            }
            mre.Reset();
            return ret;
        }
        void Update()
        {
            while (true)
            {
                if (!Connected) continue;
                if (_isWriting) continue;
                _isReading = true;
                ReadPV(1, 1000);
                ReadPV(2, 1000);
                ReadPV(3, 1000);
                ReadPV(4, 1000);
                Thread.Sleep(100);
                _isReading = false;
            }
        }
    }
}