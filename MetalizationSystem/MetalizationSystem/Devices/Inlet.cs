using MetalizationSystem.EnumCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class Inlet
    {
        public int _posNum = 6;
        public bool[] _isWorkpieceInPos;
        public int _currentOutPos;
        Scheduler.StationID _stationID;
        public bool LoadRequest;
        public bool UnloadRequest;
        public int Process;

        

        public Inlet(Scheduler.StationID StationID)
        {

            _posNum = 6;
            _isWorkpieceInPos = new bool[_posNum];
            _stationID = StationID;
        }

        /// <summary>
        /// 上料：初始化
        /// </summary>
        /// <returns></returns>
        public void Initial()
        {
            LoadRequest = false;
            UnloadRequest = true;
            Process = 0;
            //位置是否有件初始化
            _isWorkpieceInPos = [false, false, true, false, false, false];
            _currentOutPos = 0;
        }
            
        /// <summary>
        /// 上料：开始
        /// </summary>
        public bool Start()
        {
            return true;
        }

        /// <summary>
        /// 上料：停止
        /// </summary>
        public void Stop()
        {
            ; 
        }

        /// <summary>
        /// 调度：计算出料位置
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public int GetStationOutPosNo()
        {
            for (int i = 0; i < _posNum; i++)
            {
                if (_isWorkpieceInPos[i])
                {
                    _currentOutPos = i;
                    return _currentOutPos;
                }
            }
            _currentOutPos = -1;
            return _currentOutPos;
        }

        /// <summary>
        /// 调度：计算进料位置
        /// </summary>
        /// <returns></returns>
        public int GetStationInPosNo()
        {
            return (-1);
        }

        /// <summary>
        /// 调度：出料后更新标识位,控制进料间隔，确保不会阻塞
        /// </summary>
        public void UpdateWhenStationOut()
        {
            _isWorkpieceInPos[_currentOutPos] = false;
            for(int i = 0; i < _posNum; i++)
            {
                if (_isWorkpieceInPos[i])
                {
                    UnloadRequest = false;
                    var timer = new System.Timers.Timer((Globa.Device.Scheduler._maxDuration).TotalMilliseconds + 60 * 1000);
                    timer.Elapsed += (s, e) =>
                    {
                        UnloadRequest = true;
                        timer.Stop();
                    };
                    timer.Start();
                    return; 
                }
            }
            UnloadRequest = false;
            Process = -1;
        }
    }
}