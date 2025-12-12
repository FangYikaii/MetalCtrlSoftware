using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class Outlet
    {
        public int _posNum;
        public bool[] _isWorkpieceInPos;
        public int _currentInPos;
        Scheduler.StationID _stationID;

        public Outlet(Scheduler.StationID StationID) 
        {
            _posNum = 6;
            _isWorkpieceInPos = new bool[_posNum];
            _stationID = StationID;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public void Initial()
        {
            //位置是否有件初始化
            for (int i = 0; i < _posNum; i++)
            {
                _isWorkpieceInPos[i] = false;
            }
            _currentInPos = 0;
        }

        /// <summary>
        /// 开始
        /// </summary>
        public bool Start()
        {
            return true;
        }

        /// <summary>
        /// 下料：停止
        /// </summary>
        public bool Stop()
        {
            return true;
        }

        /// <summary>
        /// 调度：计算出料位置
        /// </summary>
        /// <returns></returns>
        public int GetStationOutPosNo()
        {
            return (-1);
        }

        /// <summary>
        /// 调度：计算进料位置
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public int GetStationInPosNo()
        {
            for (int i = 0; i < _posNum; i++)
            {
                if (!_isWorkpieceInPos[i])
                {
                    _currentInPos = i;
                    return _currentInPos;
                }
            }
            _currentInPos = -1;
            return _currentInPos;
        }

        /// <summary>
        /// 调度：进料后更新标识位
        /// </summary>
        public void UpdateWhenStationIn()
        {
            _isWorkpieceInPos[_currentInPos] = true;
            for (int i = 0; i < _posNum; i++)
            {
                if (!_isWorkpieceInPos[i]) return;
            }
            Globa.Device.Scheduler._stationArr[(int)_stationID]._loadRequest = false;
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
            //出口工位无需特殊重置操作
        }

        public bool ProcessStart(int ProcessDuration)
        {
            return true;
        }
    }
}
