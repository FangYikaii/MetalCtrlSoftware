using MetalizationSystem.EnumCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class AirBox
    {
        int _tempCtrlAddr = -1;
        int _tempCtrlChannel = -1;
        int _tempCtrlIndex = -1;
        double _tempCtrlSVValue = 0; // 私有字段用于存储值
        Scheduler.StationID _stationID;

        /// <summary>
        /// 读取当前温度
        /// </summary>
        public double _tempCtrlPV
        {
            get
            {
                if (_tempCtrlIndex == -1) return 0;
                return Globa.Device.TempCtrl.Temperature[_tempCtrlIndex];
            }
        }

        /// <summary>
        /// 目标温度设定值
        /// </summary>
        public double _tempCtrlSV
        {
            get
            {
                return _tempCtrlSVValue;
            }
        }

        public bool IsReady
        {
            get
            {
                return Math.Abs(_tempCtrlPV * 10 - _tempCtrlSVValue) <= 20 || (_tempCtrlSVValue <= 250);
            }
        }

        public AirBox(  EnumInfo.TempCtrlAddr TempCtrlAddr,
                        EnumInfo.TempCtrlChannel TempCtrlChannel,
                        EnumInfo.TempCtrlIndex TempCtrlIndex,
                        EnumInfo.TempCtrlSV TempCtrlSV, 
                        Scheduler.StationID StationID)
        {
            _tempCtrlAddr       = (int)TempCtrlAddr;
            _tempCtrlChannel    = (int)TempCtrlChannel;
            _tempCtrlIndex      = (int)TempCtrlIndex;
            _tempCtrlSVValue         = (int)TempCtrlSV;
            _stationID          = StationID;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public bool Initial()
        {
            SetSV();
            StopTempCtrl();
            return true;
        }

        /// <summary>
        /// 温控：打开
        /// </summary>
        public bool Start()
        {
            StartTempCtrl();
            return true;
        }

        public bool Stop()
        {
            StopTempCtrl();
            return true;
        }

        /// <summary>
        /// 温控：设置目标温度
        /// </summary>
        public bool SetSV()
        {
            if ((_tempCtrlAddr != -1) & (_tempCtrlIndex != -1))
            {
                //写入SV
                Globa.Device.TempCtrl.WriteSV(_tempCtrlAddr, _tempCtrlChannel, _tempCtrlSVValue);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetSV(int sv)
        {
            _tempCtrlSVValue = sv;
            SetSV();
        }

        /// <summary>
        /// 温控：打开
        /// </summary>
        public bool StartTempCtrl()
        {
            if ((_tempCtrlAddr != -1) & (_tempCtrlIndex != -1))
            {
                //设置为PID状态
                Globa.Device.TempCtrl.SetPIDState(_tempCtrlAddr, _tempCtrlChannel);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 温控：关闭
        /// </summary>
        public bool StopTempCtrl()
        {
            if ((_tempCtrlAddr != -1) & (_tempCtrlIndex != -1))
            {
                //设置为停止状态
                Globa.Device.TempCtrl.SetStopState(_tempCtrlAddr, _tempCtrlChannel);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 进料：机器人放料完成后执行
        /// </summary>
        public bool Load()
        {
            return true;
        }

        /// <summary>
        /// 出料：机器人取料完成后执行
        /// </summary>
        public bool Unload()
        {
            return true;
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