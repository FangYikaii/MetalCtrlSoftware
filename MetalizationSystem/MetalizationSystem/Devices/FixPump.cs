using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xugz;

namespace MetalizationSystem
{
    /// <summary>
    /// 定量泵
    /// </summary>
    public class FixPump
    {
        ManualResetEvent mre = new ManualResetEvent(false);
        DMTcpClient myClient;
        public bool Connected = false;
        string receiveString=string.Empty;
        byte[] receiveByte;

        public FixPump(string ip,short port)
        {
            myClient=new DMTcpClient();
            myClient.OnStateInfo += MyClient_OnStateInfo;
            myClient.OnReceviceByte += MyClient_OnReceviceByte;
            myClient.OnErrorMsg += MyClient_OnErrorMsg;
            myClient.ServerIp = IPAddress.Parse(ip);
            myClient.ServerPort = port;
            myClient.StartConnection();
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
                    //connected = true;
                    //Log.Info($"已成功连接服务器  {remoteIP}:{remotePort}");
                    break;
                case SocketState.Reconnection:
                    break;
                case SocketState.Disconnect:
                    //if (connected == true)
                    //{
                    //    connected = false;
                    //    //Log.Info($"与服务器的连接断开  {remoteIP} : {remotePort}");
                    //}
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
        /// 定量泵：打开
        /// </summary>
        /// <param name="PumpID"></param>
        /// <param name="Capacity"单位：ml></param>
        /// <returns></returns>
        public bool Start(int PumpID, double Capacity)
        {
            bool ret = false;
            myClient.SendCommand(Instruction.FixPumpCapacity(GetModbusID(PumpID), (int)(Capacity * 1110 / 100))); //1110圈对应100ml
            ret = mre.WaitOne(1000);
            mre.Reset();
            return ret;         
        }

        /// <summary>
        /// 定量泵：读取运行状态，手册中没有相关指令
        /// </summary>
        /// <param name="PumpID"></param>
        /// <returns></returns>
        public int GetRunStatus(int PumpID)
        {
            bool ret = false;
            myClient.SendCommand(Instruction.FixPumpStatus(GetModbusID(PumpID)));
            ret = mre.WaitOne(1000);
            mre.Reset();
            if (ret)
            {
                return receiveByte[4];//需要修改
            }
            else return -1; 
        }

        /// <summary>
        /// 定量泵：关闭
        /// </summary>
        /// <param name="PumpID"></param>
        /// <returns></returns>
        public bool Stop(int PumpID)
        {
            bool ret = false;
            myClient.SendCommand(Instruction.FixPumpStop(GetModbusID(PumpID)));
            ret = mre.WaitOne(1000);
            mre.Reset();
            return ret;
        }

        /// <summary>
        /// 定量泵：读取Modbus地址
        /// </summary>
        /// <param name="PumpID"></param>
        /// <returns></returns>
        public int GetModbusID(int PumpID)
        {
            switch (PumpID)
            {
                case 1: 
                    return Globa.DataManager.ParameterList.LiquidDispensing.Solvent[1].ModbusId;
                case 2: 
                    return Globa.DataManager.ParameterList.LiquidDispensing.Solvent[2].ModbusId;
                case 3: 
                    return Globa.DataManager.ParameterList.LiquidDispensing.Solvent[3].ModbusId;
                case 4: 
                    return Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid[1].ModbusId;
                case 5: 
                    return Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid[2].ModbusId;
                default: 
                    return -1;
            }
        }
    }
}
