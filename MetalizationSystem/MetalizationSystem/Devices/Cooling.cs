using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class Cooling
    {
        Scheduler.StationID _stationID;
        public Cooling(Scheduler.StationID StationID) 
        {
            _stationID = StationID;
        }

        /// <summary>
        /// 调度：计算出料托盘编号
        /// </summary>
        /// <returns></returns>
        public int GetStationOutPosNo()
        {
            return (0);
        }

        /// <summary>
        /// 调度：计算进料托盘编号
        /// </summary>
        /// <returns></returns>
        public int GetStationInPosNo()
        {
            return (0);
        }

        /// <summary>
        /// 工艺：准备
        /// </summary>
        public void ProcessPreparation()
        {
            //冷却工位无需特殊准备，方法保持简洁
        }

        /// <summary>
        /// 重置工艺准备状态
        /// </summary>
        public void ResetProcessPreparation()
        {
            //冷却工位无需特殊重置操作
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
    }
}
