using MetalizationSystem.EnumCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class MixMotor
    {
        public MixMotor() { }

        /// <summary>
        /// 搅拌电机：开始
        /// </summary>
        public bool Start()
        {
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.MixMotor).MoveContinuous(0);
            return true;
        }

        /// <summary>
        /// 搅拌电机：停止
        /// </summary>
        public bool Stop()
        {
            XMachine.Instance.Card.FindAxis((int)EnumInfo.AxisId.MixMotor).Stop();
            return true;
        }
    }
}
