using MetalizationSystem.EnumCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class LinearMotor
    {
        public LinearMotor() { }

        /// <summary>
        /// 直线电机：回零
        /// </summary>
        public bool Home()
        {
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).SetAcc(100);
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).SetDcc(100);
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).SetSpeed(10);
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).GoHome();
            //等待回零完成
            Thread.Sleep(100);
            while (!Globa.Device.LinearMotor.GetHomeStatus())
            {
                Thread.Sleep(100);
            }
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).SetSpeed(100);
            return true;
        }

        /// <summary>
        /// 直线电机：读取回零状态，1-回零完成
        /// </summary>
        /// <returns></returns>
        public bool GetHomeStatus()
        {
            return XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).GetHomeStatus();
        }

        /// <summary>
        /// 直线电机：绝对运动
        /// </summary>
        public void MoveAbs(float targetDpos)
        {
            //机器人：检测是否位于原点
            if (Globa.Device.Roboter.Home & Globa.Device.Roboter.GetHomeRelayStatus())
            {
                //直线电机：当前位置与指令位置一致，返回
                if (XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).Dpos == targetDpos) { return; }
                //直线电机：发送运动指令
                XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).MoveAbs(targetDpos);
                Thread.Sleep(500);
                //直线电机：检测运动是否到位
                while (Math.Abs(XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).Dpos - targetDpos) >= 0.1
                       ||
                       XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).RunState)
                {
                    Thread.Sleep(1000);
                }
                return;
            }
            else
            {
                throw new Exception("机器人不在原点位置，直线电机无法移动");
            } 
        }

        /// <summary>
        /// 直线电机：读取运行状态，1-运动中
        /// </summary>
        public bool GetRunStatus()
        {
            return XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).RunState;
        }

        /// <summary>
        /// 直线电机：停止
        /// </summary>
        public bool Stop()
        {
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.LinearMotor).Stop();
            return true;
        }
    }
}