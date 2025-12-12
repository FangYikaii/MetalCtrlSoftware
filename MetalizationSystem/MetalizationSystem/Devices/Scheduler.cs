using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using MetalizationSystem.EnumCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.Devices
{
    public class Scheduler
    {
        int _stationNum;
        int _stationOut;
        int _stationIn;
        int _outProcess;
        int _inProcess;
        public bool Tank40RecipeChanged { get; set; }
        public TimeSpan _maxDuration;
        public struct _process
        {
            public StationID _stationID;
            public TimeSpan _duration; //单位：分钟
        }
        public _process[] _processArr;
        
        public struct _station
        {
            public bool _loadRequest;
            public bool _unloadRequest;
            public int _process;
        }
        public _station[] _stationArr;
              
        public Scheduler() 
        {
            _stationNum = (int)StationID.Num;

            //流程1
            //_processArr = new _process[4];
            //_processArr[00] = new _process { _stationID = StationID.Inlet, _duration = new TimeSpan(0, 0, 0) };
            //_processArr[01] = new _process { _stationID = StationID.Tank22, _duration = new TimeSpan(0, 1, 0) };
            //_processArr[02] = new _process { _stationID = StationID.DryBox, _duration = new TimeSpan(0, 1, 0) };
            //_processArr[03] = new _process { _stationID = StationID.Outlet, _duration = new TimeSpan(0, 0, 0) };


            //全流程快速调试流程
            //_processArr = new _process[17];
            //_processArr[00] = new _process { _stationID = StationID.Inlet, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[01] = new _process { _stationID = StationID.Tank20, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[02] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[03] = new _process { _stationID = StationID.Tank22, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[04] = new _process { _stationID = StationID.Tank23, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[05] = new _process { _stationID = StationID.AirBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[06] = new _process { _stationID = StationID.Tank40, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[07] = new _process { _stationID = StationID.Tank41, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[08] = new _process { _stationID = StationID.Tank42, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[09] = new _process { _stationID = StationID.Tank43, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[10] = new _process { _stationID = StationID.AirBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[11] = new _process { _stationID = StationID.Tank50, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[12] = new _process { _stationID = StationID.Tank51, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[13] = new _process { _stationID = StationID.Tank52, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[14] = new _process { _stationID = StationID.Tank53, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[15] = new _process { _stationID = StationID.AirBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[16] = new _process { _stationID = StationID.Outlet, _duration = new TimeSpan(0, 0, 1) };

            //实际流程快速调试
            //_processArr = new _process[19];
            //_processArr[00] = new _process { _stationID = StationID.Inlet,  _duration = new TimeSpan(0, 0, 1) };
            //_processArr[01] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 1, 1) }; // 20槽液位传感器损坏，改为21槽
            //_processArr[02] = new _process { _stationID = StationID.AirBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[03] = new _process { _stationID = StationID.Tank23, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[04] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 1, 1) }; // 20槽液位传感器损坏，改为21槽
            //_processArr[05] = new _process { _stationID = StationID.AirBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[06] = new _process { _stationID = StationID.Tank40, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[07] = new _process { _stationID = StationID.Tank22, _duration = new TimeSpan(0, 1, 1) };
            //_processArr[08] = new _process { _stationID = StationID.DryBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[09] = new _process { _stationID = StationID.Tank42, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[10] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 1, 1) };
            //_processArr[11] = new _process { _stationID = StationID.Tank43, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[12] = new _process { _stationID = StationID.Tank50, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[13] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 1, 1) };
            //_processArr[14] = new _process { _stationID = StationID.Tank51, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[15] = new _process { _stationID = StationID.Tank52, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[16] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[17] = new _process { _stationID = StationID.AirBox, _duration = new TimeSpan(0, 0, 1) };
            //_processArr[18] = new _process { _stationID = StationID.Outlet, _duration = new TimeSpan(0, 0, 1) };

            ////实际流程
            _processArr = new _process[16];
            _processArr[00] = new _process { _stationID = StationID.Inlet, _duration = new TimeSpan(0, 0, 0) };
            _processArr[01] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 5, 0) }; // 20槽液位传感器损坏，改为21槽
            _processArr[02] = new _process { _stationID = StationID.Tank23, _duration = new TimeSpan(0, 30, 0) };
            _processArr[03] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 5, 0) }; // 20槽液位传感器损坏，改为21槽
            _processArr[04] = new _process { _stationID = StationID.Tank40, _duration = new TimeSpan(0, 10, 0) };
            _processArr[05] = new _process { _stationID = StationID.Tank22, _duration = new TimeSpan(0, 5, 0) };
            _processArr[06] = new _process { _stationID = StationID.DryBox, _duration = new TimeSpan(0, 10, 0) };
            _processArr[07] = new _process { _stationID = StationID.Tank42, _duration = new TimeSpan(0, 2, 0) };
            _processArr[08] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 5, 0) };
            _processArr[09] = new _process { _stationID = StationID.Tank43, _duration = new TimeSpan(0, 5, 0) };
            _processArr[10] = new _process { _stationID = StationID.Tank50, _duration = new TimeSpan(0, 3, 0) };
            _processArr[11] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 5, 0) };
            _processArr[12] = new _process { _stationID = StationID.Tank51, _duration = new TimeSpan(0, 2, 0) };
            _processArr[13] = new _process { _stationID = StationID.Tank52, _duration = new TimeSpan(0, 10, 0) };
            _processArr[14] = new _process { _stationID = StationID.Tank21, _duration = new TimeSpan(0, 5, 0) };
            _processArr[15] = new _process { _stationID = StationID.Outlet, _duration = new TimeSpan(0, 0, 0) };

            //工位：实例化
            _stationArr = new _station[_stationNum];
            //调度：计算最长工艺时间
            _maxDuration = new TimeSpan(0, 0, 0);
            for (int i = 0; i < _processArr.Length; i++)
            {
                if (_processArr[i]._duration > _maxDuration)
                {
                    _maxDuration = _processArr[i]._duration;
                }
            }
        } 

        //public void WriteTank40TimeSpan(TimeSpan time)
        //{
        //    _processArr[02]._duration = time;
        //}

        public bool Initial()
        {
            for (int i = 0; i < _stationNum; i++)
            {
                //进料请求：初始化
                if (i == 0) { _stationArr[i]._loadRequest = false; }    else { _stationArr[i]._loadRequest = true; }
                //出料请求：初始化
                if (i == 0) { _stationArr[i]._unloadRequest = true; }  else { _stationArr[i]._unloadRequest = false; }
                //工位流程：初始化
                if (i == 0) { _stationArr[i]._process = 0; }        else { _stationArr[i]._process = -1; }
            }
            Tank40RecipeChanged = true;
            return true;
        }
            
        /// <summary>
        /// 调度：判断调度是否结束，以及进料和出料工位
        /// </summary>
        /// <returns></returns>
        public (bool IsDone, int StationOut, int StationIn)GetStatus()
        {
            //读取进料工位的请求，进料工位的请求信号由进料工位自己管理，此处需读取
            if (Globa.Device.AutoModel.IsInternalRecipe)
            {
                // 内部配方
                _stationArr[0]._unloadRequest = Globa.Device.Inlet.UnloadRequest;
            }
            else
            {
                // 外部配方
                _stationArr[0]._unloadRequest = Globa.Device.Inlet.UnloadRequest && Tank40RecipeChanged;
            }
            _stationArr[0]._loadRequest = Globa.Device.Inlet.LoadRequest;
            _stationArr[0]._process = Globa.Device.Inlet.Process;
            //检查转运是否结束
            for (int i = 0; i < _stationNum - 1; i++)
            { 
                if (_stationArr[i]._process != -1){ break; }
                if (i == _stationNum - 2) { return (true, -1, -1); }
            }
            //计算进料和出料工位
            for (int i = 0; i < _stationNum - 1; i++)
            {
                if (_stationArr[i]._process >= 0)
                {
                    _stationOut = i;
                    _outProcess = _stationArr[i]._process;
                    _inProcess = _outProcess + 1;
                    _stationIn = (int)_processArr[_inProcess]._stationID;
                    if (_stationArr[_stationOut]._unloadRequest & _stationArr[_stationIn]._loadRequest)
                    {
                        return (false,_stationOut, _stationIn);
                    }
                }
            }
            return (false, -1,-1);
        }
        
        /// <summary>
        /// 标识位：工位出料后更新
        /// </summary>
        /// <returns></returns>
        public void UpdateWhenStationOut()
        {
            switch ((StationID)_stationOut)
            {
                case StationID.Inlet: 
                    Globa.Device.Inlet.UpdateWhenStationOut();
                    if (!Globa.Device.AutoModel.IsInternalRecipe) { Tank40RecipeChanged = false; }
                    return;
            }
            _stationArr[_stationOut]._loadRequest   = true;
            _stationArr[_stationOut]._unloadRequest = false;
            _stationArr[_stationOut]._process       = -1;
        }

        /// <summary>
        /// 标识位：工位进料后更新
        /// </summary>
        /// <returns></returns>
        public void UpdateWhenStationIn()
        {
            switch ((StationID) _stationIn)    
            {
                case StationID.Outlet: Globa.Device.Outlet.UpdateWhenStationIn(); return;
            }
            _stationArr[_stationIn]._loadRequest = false;
            _stationArr[_stationIn]._process     = _inProcess;
        }

        /// <summary>
        /// 标识位：工艺完成后更新
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public bool UpdateWhenProcessDone(StationID stationID)
        {
            _stationArr[(int)stationID]._unloadRequest = true;
            return true; 
        }

        public enum StationID
        {
            Null    = -1,
            Inlet   = 0,
            Tank20  = 1,
            Tank21  = 2,
            Tank22  = 3,
            Tank23  = 4,
            AirBox  = 5,
            Tank40  = 6,
            Tank41  = 7,
            Tank42  = 8,
            Tank43  = 9,
            Tank50  = 10,
            Tank51  = 11,
            Tank52  = 12,
            Tank53  = 13,
            DryBox  = 14,
            Cooling = 15,
            Outlet  = 16,
            Num     = 17, //工位数量发生变化时，需要修改
        }

        /// <summary>
        /// 根据工位编号，查找直线电机的绝对位置
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public float GetLinearMotorAbsPos(StationID stationID)
        {
            return stationID switch
            {
                StationID.Inlet     => 742.0f,
                StationID.Tank20    => 742.0f,
                StationID.Tank21    => 742.0f,
                StationID.Tank22    => 742.0f,
                StationID.Tank23    => 742.0f,
                StationID.AirBox    => 200.0f,
                StationID.Tank40    => 200.0f,
                StationID.Tank41    => 200.0f,
                StationID.Tank42    => 200.0f,
                StationID.Tank43    => 200.0f,
                StationID.Tank50    => 200.0f,
                StationID.Tank51    => 200.0f,
                StationID.Tank52    => 200.0f,
                StationID.Tank53    => 200.0f,
                StationID.DryBox    => 2800.0f,
                StationID.Cooling   => 2800.0f,
                StationID.Outlet    => 742.0f,
                _ => throw new ArgumentOutOfRangeException(nameof(stationID)),
            };
        }

        /// <summary>
        /// 调度：计算机器人坐标
        /// </summary>
        /// <param name="stationID"></param>
        /// <param name="stationPos"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public (int PosID,int PalletX, int PalletY, int PalletZ) GetRobotCoord(StationID stationID,int stationPos)
        {
            switch (stationID)
            {
                case StationID.Inlet: 
                    switch(stationPos)
                    {
                        case 0: return ((int)Robot.PosId.Inlet0, 0, 0, 0);
                        case 1: return ((int)Robot.PosId.Inlet1, 0, 0, 0);
                        case 2: return ((int)Robot.PosId.Inlet2, 0, 0, 0);
                        case 3: return ((int)Robot.PosId.Inlet3, 0, 0, 0);
                        case 4: return ((int)Robot.PosId.Inlet4, 0, 0, 0);
                        case 5: return ((int)Robot.PosId.Inlet5, 0, 0, 0);
                        default: return (-1, -1, -1, -1); throw new ArgumentOutOfRangeException(nameof(stationID));
                    }
                case StationID.Tank20: return ((int)Robot.PosId.Tank20, 0, 0, 0);
                case StationID.Tank21: return ((int)Robot.PosId.Tank21, 0, 0, 0);
                case StationID.Tank22: return ((int)Robot.PosId.Tank22, 0, 0, 0);
                case StationID.Tank23: return ((int)Robot.PosId.Tank23, 0, 0, 0);
                case StationID.Tank40: return ((int)Robot.PosId.Tank40, 0, 0, 0);
                case StationID.Tank41: return ((int)Robot.PosId.Tank41, 0, 0, 0);
                case StationID.Tank42: return ((int)Robot.PosId.Tank42, 0, 0, 0);
                case StationID.Tank43: return ((int)Robot.PosId.Tank43, 0, 0, 0);
                case StationID.Tank50: return ((int)Robot.PosId.Tank50, 0, 0, 0);
                case StationID.Tank51: return ((int)Robot.PosId.Tank51, 0, 0, 0);
                case StationID.Tank52: return ((int)Robot.PosId.Tank52, 0, 0, 0);
                case StationID.Tank53: return ((int)Robot.PosId.Tank53, 0, 0, 0);
                case StationID.AirBox: return ((int)Robot.PosId.AirBox, 0, 0, 0);
                case StationID.DryBox: return ((int)Robot.PosId.DryBox, 0, 0, 0);
                case StationID.Cooling:return ((int)Robot.PosId.Cooling, 0, 0, 0);
                case StationID.Outlet:
                    switch (stationPos)
                    {
                        case 0: return ((int)Robot.PosId.Outlet0, 0, 0, 0);
                        case 1: return ((int)Robot.PosId.Outlet1, 0, 0, 0);
                        case 2: return ((int)Robot.PosId.Outlet2, 0, 0, 0);
                        case 3: return ((int)Robot.PosId.Outlet3, 0, 0, 0);
                        case 4: return ((int)Robot.PosId.Outlet4, 0, 0, 0);
                        case 5: return ((int)Robot.PosId.Outlet5, 0, 0, 0);
                        default: return (-1, -1, -1, -1); throw new ArgumentOutOfRangeException(nameof(stationID));
                    }
                default: return (-1, -1, -1, -1); throw new ArgumentOutOfRangeException(nameof(stationID));
            }
        }
        
        /// <summary>
        /// 调度：计算出料托盘位置
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public int GetStationOutPosNo(StationID stationID)
        {
            switch(stationID)
            {
                case StationID.Tank20: return Globa.Device.Tank20.GetStationOutPosNo();
                case StationID.Tank21: return Globa.Device.Tank21.GetStationOutPosNo();
                case StationID.Tank22: return Globa.Device.Tank22.GetStationOutPosNo();
                case StationID.Tank23: return Globa.Device.Tank23.GetStationOutPosNo();
                case StationID.Tank40: return Globa.Device.Tank40.GetStationOutPosNo();
                case StationID.Tank41: return Globa.Device.Tank41.GetStationOutPosNo();
                case StationID.Tank42: return Globa.Device.Tank42.GetStationOutPosNo();
                case StationID.Tank43: return Globa.Device.Tank43.GetStationOutPosNo();
                case StationID.Tank50: return Globa.Device.Tank50.GetStationOutPosNo();
                case StationID.Tank51: return Globa.Device.Tank51.GetStationOutPosNo();
                case StationID.Tank52: return Globa.Device.Tank52.GetStationOutPosNo();
                case StationID.Tank53: return Globa.Device.Tank53.GetStationOutPosNo();
                case StationID.Inlet:  return Globa.Device.Inlet.GetStationOutPosNo();
                case StationID.AirBox: return Globa.Device.AirBox.GetStationOutPosNo();
                case StationID.DryBox: return Globa.Device.DryBox.GetStationOutPosNo();
                case StationID.Cooling:return Globa.Device.Cooling.GetStationOutPosNo();
                case StationID.Outlet: return Globa.Device.Outlet.GetStationOutPosNo();
                default: return (-1); throw new ArgumentOutOfRangeException(nameof(stationID));
            }
        }
        
        /// <summary>
        /// 调度：计算进料托盘位置
        /// </summary>
        /// <param name="stationID"></param>
        /// <returns></returns>
        public int GetStationInPosNo(StationID stationID)
        {
            switch (stationID)
            {
                case StationID.Inlet:  return Globa.Device.Inlet.GetStationInPosNo();
                case StationID.Tank20: return Globa.Device.Tank20.GetStationInPosNo();
                case StationID.Tank21: return Globa.Device.Tank21.GetStationInPosNo();
                case StationID.Tank22: return Globa.Device.Tank22.GetStationInPosNo();
                case StationID.Tank23: return Globa.Device.Tank23.GetStationInPosNo();
                case StationID.Tank40: return Globa.Device.Tank40.GetStationInPosNo();
                case StationID.Tank41: return Globa.Device.Tank41.GetStationInPosNo();
                case StationID.Tank42: return Globa.Device.Tank42.GetStationInPosNo();
                case StationID.Tank43: return Globa.Device.Tank43.GetStationInPosNo();
                case StationID.Tank50: return Globa.Device.Tank50.GetStationInPosNo();
                case StationID.Tank51: return Globa.Device.Tank51.GetStationInPosNo();
                case StationID.Tank52: return Globa.Device.Tank52.GetStationInPosNo();
                case StationID.Tank53: return Globa.Device.Tank53.GetStationInPosNo();
                case StationID.AirBox: return Globa.Device.AirBox.GetStationInPosNo();
                case StationID.DryBox: return Globa.Device.DryBox.GetStationInPosNo();
                case StationID.Cooling:return Globa.Device.Cooling.GetStationInPosNo();
                case StationID.Outlet: return Globa.Device.Outlet.GetStationInPosNo();
                default: return (-1); throw new ArgumentOutOfRangeException(nameof(stationID));
            }
        }

        /// <summary>
        /// 工艺准备
        /// </summary>
        /// <param name="stationID"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ProcessPreparation(StationID stationID)
        {
            switch(stationID)
            {
                case StationID.Tank20: Globa.Device.Tank20.ProcessPreparation(); break;
                case StationID.Tank21: Globa.Device.Tank21.ProcessPreparation(); break;
                case StationID.Tank22: Globa.Device.Tank22.ProcessPreparation(); break;
                case StationID.Tank23: Globa.Device.Tank23.ProcessPreparation(); break;
                case StationID.Tank40: Globa.Device.Tank40.ProcessPreparation(); break;
                case StationID.Tank41: Globa.Device.Tank41.ProcessPreparation(); break;
                case StationID.Tank42: Globa.Device.Tank42.ProcessPreparation(); break;
                case StationID.Tank43: Globa.Device.Tank43.ProcessPreparation(); break;
                case StationID.Tank50: Globa.Device.Tank50.ProcessPreparation(); break;
                case StationID.Tank51: Globa.Device.Tank51.ProcessPreparation(); break;
                case StationID.Tank52: Globa.Device.Tank52.ProcessPreparation(); break;
                case StationID.Tank53: Globa.Device.Tank53.ProcessPreparation(); break;
                case StationID.AirBox: Globa.Device.AirBox.ProcessPreparation(); break;
                case StationID.DryBox: Globa.Device.DryBox.ProcessPreparation(); break;
                case StationID.Cooling:Globa.Device.Cooling.ProcessPreparation(); break;
                case StationID.Outlet: Globa.Device.Outlet.ProcessPreparation(); break;
                default: throw new ArgumentOutOfRangeException(nameof(stationID));
            }
        }

        /// <summary>
        /// 重置工艺准备状态
        /// </summary>
        /// <param name="stationID"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ResetProcessPreparation(StationID stationID)
        {
            switch(stationID)
            {
                case StationID.Inlet: break;
                case StationID.Tank20: Globa.Device.Tank20.ResetProcessPreparation(); break;
                case StationID.Tank21: Globa.Device.Tank21.ResetProcessPreparation(); break;
                case StationID.Tank22: Globa.Device.Tank22.ResetProcessPreparation(); break;
                case StationID.Tank23: Globa.Device.Tank23.ResetProcessPreparation(); break;
                case StationID.Tank40: Globa.Device.Tank40.ResetProcessPreparation(); break;
                case StationID.Tank41: Globa.Device.Tank41.ResetProcessPreparation(); break;
                case StationID.Tank42: Globa.Device.Tank42.ResetProcessPreparation(); break;
                case StationID.Tank43: Globa.Device.Tank43.ResetProcessPreparation(); break;
                case StationID.Tank50: Globa.Device.Tank50.ResetProcessPreparation(); break;
                case StationID.Tank51: Globa.Device.Tank51.ResetProcessPreparation(); break;
                case StationID.Tank52: Globa.Device.Tank52.ResetProcessPreparation(); break;
                case StationID.Tank53: Globa.Device.Tank53.ResetProcessPreparation(); break;
                case StationID.AirBox: Globa.Device.AirBox.ResetProcessPreparation(); break;
                case StationID.DryBox: Globa.Device.DryBox.ResetProcessPreparation(); break;
                case StationID.Cooling:Globa.Device.Cooling.ResetProcessPreparation(); break;
                case StationID.Outlet: Globa.Device.Outlet.ResetProcessPreparation(); break;
                default: throw new ArgumentOutOfRangeException(nameof(stationID));
            }
        }
        
        /// <summary>
        /// 工艺开始
        /// </summary>
        /// <param name="stationID"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ProcessStart(StationID stationID)
        {
            switch(stationID)
            {
                case StationID.Tank20: Globa.Device.Tank20.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank21: Globa.Device.Tank21.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank22: Globa.Device.Tank22.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank23: Globa.Device.Tank23.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank40: Globa.Device.Tank40.ProcessStart(Globa.Device.Recipe.CurrentParameterSet.Time); break;
                case StationID.Tank41: Globa.Device.Tank41.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank42: Globa.Device.Tank42.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank43: Globa.Device.Tank43.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank50: Globa.Device.Tank50.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank51: Globa.Device.Tank51.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank52: Globa.Device.Tank52.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Tank53: Globa.Device.Tank53.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.AirBox: Globa.Device.AirBox.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.DryBox: Globa.Device.DryBox.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Cooling:Globa.Device.Cooling.ProcessStart(_processArr[_inProcess]._duration); break;
                case StationID.Outlet: Globa.Device.Outlet.ProcessStart(0); break;
                default: throw new ArgumentOutOfRangeException(nameof(stationID));
            }
        }
    }
}