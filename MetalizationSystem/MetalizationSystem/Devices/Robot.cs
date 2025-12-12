using MetalizationSystem.EnumCollection;
using Modbus.Data;
using Modbus.Device;
using Modbus.Extensions.Enron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetalizationSystem
{
    public class Robot
    {
        ModbusIpMaster master;
        TcpClient client;

        bool[] status = new bool[100];
        ushort[] statusId = new ushort[100];
        bool _isReading = false; 
        bool _isWriting = false;

        /// <summary>空闲状态</summary>
        public bool IdleStatus { get { return status[(int)FucCoil.IdleStatus]; } }

        /// <summary>运行程序中</summary>
        public bool Running { get { return status[(int)FucCoil.Running]; } }
        /// <summary>暂停程序中</summary>
        public bool Paused { get { return status[(int)FucCoil.Paused]; } }
        /// <summary>程序结束</summary>
        public bool Stopping { get { return status[(int)FucCoil.Stopping]; } }
        /// <summary>原点位置</summary>
        public bool Home { get { return status[(int)FucCoil.Home]; } }
        /// <summary>自动模式中</summary>
        public bool Auto { get { return status[(int)FucCoil.Auto]; } }
        /// <summary>机械臂运行中</summary>
        public bool Moving { get { return status[(int)FucCoil.Moving]; } }
        /// <summary>碰撞错误中</summary>
        public bool Collising { get { return status[(int)FucCoil.Collising]; } }
        /// <summary>未上电</summary>
        public bool NoPower { get { return status[(int)FucCoil.NoPower]; } }
        /// <summary>未上使能</summary>
        public bool NoAble { get { return status[(int)FucCoil.NoAble]; } }
        /// <summary>机器人请求动作信号</summary>
        public bool Request { get { return status[(int)FucCoil.IntercationResponse]; } }
        /// <summary>上报当前所在的工作站</summary>
        public StationId Resp_Mode_ID { get { return (StationId)statusId[(int)FucHoling.Resp_Station_ID]; } }
        /// <summary>上报当前用于控制机器人动作</summary>
        public ActionId Resp_Action_ID { get { return (ActionId)statusId[(int)FucHoling.Resp_Action_ID]; } }
        /// <summary>上报当前位置</summary>
        public PosId Resp_Pos_ID { get { return (PosId)statusId[(int)FucHoling.Resp_Pos_ID]; } }
        /// <summary>上报当前料架层数</summary>
        public int Resp_Pallet_Z { get { return (int)statusId[(int)FucHoling.Resp_Pallet_Z]; } }
        /// <summary>上报当前物料X坐标</summary>
        public int Resp_Pallet_X { get { return (int)statusId[(int)FucHoling.Resp_Pallet_X]; } }
        /// <summary>上报当前物料Y坐标</summary>
        public int Resp_Pallet_Y { get { return (int)statusId[(int)FucHoling.Resp_Pallet_Y]; } }
        /// <summary>报警</summary>
        public int Robot_Alarm { get { return (int)statusId[(int)FucHoling.Robot_Alarm]; } }

        public Robot(string iPAddress, short port)
        {
            try
            {
                client = new TcpClient(iPAddress, port);
                master = ModbusIpMaster.CreateIp(client);
            }
            catch (Exception ex)
            {
                //调试时暂时禁用
                //throw new Exception("连接Modbus TCP服务器失败: " + ex.Message);
            }
            Thread th=new Thread(Update) { IsBackground = true };
            th.Start();
        }

        public bool Connected
        {
            get
            {
                if (client == null)
                {
                    return false;
                }
                else
                {
                    return client.Connected;
                }
            }
        }


        
        public bool Write(ModeId modeId,ActionId actionId,int posId, int palletX=0,int palletY=0,int palletZ=0)
        {
            try
            {
                ushort[] cmd = new ushort[9];
                cmd[0] = (ushort)modeId;
                cmd[1] = (ushort)actionId;
                cmd[2] = (ushort)posId;
                cmd[3] = (ushort)palletZ;
                cmd[4] = (ushort)palletX;
                cmd[5] = (ushort)palletY;
                cmd[6] = 0;
                cmd[7] = 0;
                cmd[8] = 0;
                _isWriting = true;
                while (_isReading) { Thread.Sleep(200); }
                master.WriteMultipleRegisters(1, 8, cmd);
                _isWriting = false;
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool Write(FucCoil coil,bool action =true)
        {
            try
            {
                _isWriting = true;
                while (_isReading) { Thread.Sleep(200); }
                master.WriteSingleCoil(1, (ushort)coil, action);
                if (action) {
                    switch (coil)
                    {
                        case FucCoil.SafeSingle:
                        case FucCoil.Run:
                        case FucCoil.Reset:
                            break;
                        default:
                            Thread.Sleep(500);
                            master.WriteSingleCoil(1, (ushort)coil, false);
                            break;                         
                    }
                }  
                _isWriting= false;
            }
            catch { return false; }
            return true;
        }

        public bool RobotAction(ModeId modeId, ActionId actionId, int posId, int palletX = 0, int palletY = 0, int palletZ = 0)
        {
            try
            {
                Globa.Device.Roboter.Write(modeId, actionId, posId, palletX, palletY, palletZ);
                while ((int)Resp_Pos_ID != posId)
                {
                    Thread.Sleep(1000);
                }
                Globa.Device.Roboter.Write(ModeId.Free, ActionId.Free, 0, 0, 0, 0);
                while (Resp_Mode_ID != 0 || Resp_Action_ID != 0 || Resp_Pos_ID != 0)
                {
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex) { return false; }
            return true;
        }

        void Update()
        {
            while (true)
            {
                if (!Connected) continue;
                if (_isWriting) continue;
                _isReading = true;
                status = master.ReadCoils(1, 0, 100);
                Thread.Sleep(100);
                statusId = master.ReadHoldingRegisters(1, 0, 100);
                Thread.Sleep(100);
                _isReading = false;
            }
        }

        public enum StationId
        {
            Free    = 0,
            Source  = 1,
        }

        public enum ModeId
        {
            Free        = 0,
            Auto        = 1,
            Bypass      = 10,
            Simulation  = 99
        }

        public enum ActionId
        {
            Free    = 0,
            Put     = 20,
            Get     = 10
        }
        public enum PosId
        {
            None    = 0,
            Source  = 1,
            Home    = 1,
            Inlet0  = 10,
            Inlet1  = 11,
            Inlet2  = 12,
            Inlet3  = 13,
            Inlet4  = 14,
            Inlet5  = 15,
            Tank20  = 20,
            Tank21  = 21,
            Tank22  = 22,
            Tank23  = 23,
            AirBox  = 30,
            Tank40  = 40,
            Tank41  = 41,
            Tank42  = 42,
            Tank43  = 43,
            Tank50  = 50,
            Tank51  = 51,
            Tank52  = 52,
            Tank53  = 53,
            Cooling = 55,
            Outlet0 = 60,
            Outlet1 = 61,
            Outlet2 = 62,
            Outlet3 = 63,
            Outlet4 = 64,
            Outlet5 = 65,
            DryBox  = 80,
            TBD     = 90,
            Modify = 110,
        }

        public enum FucCoil
        {
            SafeSingle          = 0,
            RunProgram          = 1,
            PauseProgram        = 2,
            StopProgram         = 3,
            Run                 = 6,
            Reset               = 7,
            PowerOn             = 8,
            PowerOff            = 9,
            ServoOn             = 10,
            ServoOff            = 11,
            InteractionRequest  = 32,//请求交互
            //读寄存器
            IdleStatus          = 16,
            Running             = 17,
            Paused              = 18,
            Stopping            = 19,
            Home                = 20,
            Auto                = 21,
            Moving              = 22,
            Collising           = 23,

            NoPower             = 25,
            NoAble              = 27,
            
            /// <summary>动作完成</summary>
            Response            = 32,
            /// <summary>机器手 请求动作信号</summary>
            IntercationResponse = 96, //交互反馈
        }

        public enum FucHoling
        {
            Resp_Station_ID     = 40,
            Resp_Action_ID      = 41,
            Resp_Pos_ID         = 42,
            Resp_Pallet_Z       = 43,
            Resp_Pallet_X       = 44,
            Resp_Pallet_Y       = 45,   
            Robot_Alarm         = 50,
        }

        public bool GetHomeRelayStatus()
        {
            return XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.Robot_HomeSensor).Sts;
        }
    }
}