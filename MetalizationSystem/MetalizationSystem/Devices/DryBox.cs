using DocumentFormat.OpenXml.Drawing;
using MetalizationSystem.EnumCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xugz;

namespace MetalizationSystem.Devices
{
    public class DryBox
    {
        Scheduler.StationID _stationID;
        public bool DoorOpened { get; set; }
        public bool DoorClosed { get; set; }

        //Xugz.XCommModbus modbusRtu;
        public DryBox(string port,Scheduler.StationID stationID)
        {
            //XSerialPortInfo info = new XSerialPortInfo() { Port = port , StopBits = System.IO.Ports.StopBits.Two};
            //info.Type = XCommInfo.ModbusType.Rtu;
            //modbusRtu.Init(info);
            _stationID = stationID;
        }

       /// <summary>
       /// 干燥箱：初始化
       /// </summary>
        public void Initial()
        {
            CloseDoor();
        }

        /// <summary>
        /// 干燥箱：开始
        /// </summary>
        public void Start()
        {
            ;
        }

        /// <summary>
        /// 干燥箱：停止
        /// </summary>
        public void Stop()
        {
            ;
        }

        /// <summary>
        /// 干燥箱：开门
        /// </summary>
        /// <returns></returns>
        public bool OpenDoor()
        {
            DoorOpened = false;
            DoorClosed = false;
            try
            {
                //压紧气缸：松开
                XMachine.Instance.Card.FindDo((int)EnumInfo.DoId.P80_PressCylinder_End).SetDo(true);
                //压紧气缸：等待松开到位
                while ( !XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_PressCylinder_EndSensor1).Sts ||
                        !XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_PressCylinder_EndSensor2).Sts)
                {
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
                //升降气缸：上升
                XMachine.Instance.Card.FindDo((int)EnumInfo.DoId.P80_LiftCylinder_Start).SetDo(false);
                XMachine.Instance.Card.FindDo((int)EnumInfo.DoId.P80_LiftCylinder_End).SetDo(true);
                //升降气缸：等待上升到位
                while (!XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_LiftCylinder_EndSensor).Sts)
                {
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
                DoorOpened = true;
                DoorClosed = false;
            }
            catch (Exception ex) { return false; }
            return true;
        }

        /// <summary>
        /// 干燥箱：关门
        /// </summary>
        /// <returns></returns>
        public bool CloseDoor()
        {
            DoorOpened = false;
            DoorClosed = false;
            //障碍物检测（传感器损坏，屏蔽障碍物检测功能）
            //if(XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_BlockSensor).Sts)
            //{ 
            //    return false;
            //}
            try
            {
                //升降气缸：下降
                XMachine.Instance.Card.FindDo((int)EnumInfo.DoId.P80_LiftCylinder_Start).SetDo(true);
                XMachine.Instance.Card.FindDo((int)EnumInfo.DoId.P80_LiftCylinder_End).SetDo(false);
                //升降气缸：等待下降到位
                while (!XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_LiftCylinder_StartSensor).Sts)
                {
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
                //压紧气缸：压紧
                XMachine.Instance.Card.FindDo((int)EnumInfo.DoId.P80_PressCylinder_End).SetDo(false);
                //压紧气缸：等待压紧到位
                while ( XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_PressCylinder_EndSensor1).Sts ||
                        XMachine.Instance.Card.FindDi((int)EnumInfo.DiId.P80_PressCylinder_EndSensor2).Sts)
                {
                    Thread.Sleep(100);
                }
                Thread.Sleep(1000);
                DoorOpened = false;
                DoorClosed = true;
            }
            catch (Exception ex) { return false; }
            return true;
        }

/// <summary>
/// 干燥箱：开始
/// </summary>
/// <param name="temperature"></param>
/// <param name="delayTime"></param>
        public void Start(ushort temperature, ushort delayTime)
        {
            //modbusRtu.WriteSingleRegister(1, 1, temperature);
            //modbusRtu.WriteSingleRegister(1, 1, delayTime);

        }

        /// <summary>
        /// 工艺：准备
        /// </summary>
        public void ProcessPreparation()
        {
        }

        /// <summary>
        /// 重置工艺准备状态
        /// </summary>
        public void ResetProcessPreparation()
        {
        }

        public bool ProcessStart(TimeSpan ProcessDuration)
        {
            var timer = new System.Timers.Timer(ProcessDuration.TotalMilliseconds);
            timer.Elapsed += (s, e) =>
            {
                ProcessDone(_stationID);
                timer.Stop();
            };
            timer.Start();
            return true;
        }

        /// <summary>
        /// 工艺：完成
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public bool ProcessDone(Scheduler.StationID stationID)
        {
            Globa.Device.Scheduler.UpdateWhenProcessDone(stationID);
            return true;
        }

        /// <summary>
        /// 调度：计算出料位置
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public int GetStationOutPosNo()
        {
            return (0);
        }

        /// <summary>
        /// 调度：计算进料位置
        /// </summary>
        /// <returns></returns>
        public int GetStationInPosNo()
        {
            return (0);
        }
    }
}
