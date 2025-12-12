using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2019.Drawing.Chart;
using MetalizationSystem.EnumCollection;

namespace MetalizationSystem.Devices
{
    public class Tank
    {
        int _chargeEnableIO = -1;
        int _drainPumpIO = -1;
        int _drainValveIO = -1;
        int _lowLiquidIO = -1;
        int _tempCtrlAddr = -1;
        int _tempCtrlChannel = -1;
        int _tempCtrlIndex = -1;
        int _blowIO = -1;
        int _chargeTimeoutIO = -1;
        int _allowedLiquidUses = 0;
        int _liquidUses = 0;
        double _tempCtrlSVValue = 0; // 私有字段用于存储值
        Mixer _mixer;
        Scheduler.StationID _stationID;
        bool _isStartDelay = false;
        TimeSpan _startDelayTime = TimeSpan.Zero;
        bool _chargeOnStart = false;
        
        // 存储液位传感器对应的XDi对象
        private XDi _liquidLevelDi = null;



        /// <summary>
        /// 进液超时IO地址
        /// </summary>
        public bool IsChargeTimeout
        {
            get 
            { 
                return XMachine.Instance.Card.FindDo(_chargeTimeoutIO).Sts;
            }
        }

        /// <summary>
        /// 正在进液状态
        /// </summary>
        public bool IsChargingFluid
        {
            get
            {
                return XMachine.Instance.Card.FindDo(_drainValveIO).Sts;
            }
        }

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

        /// <summary>
        /// 液位条件：液位传感器检测到液体
        /// 温度条件：设置温度<=25℃，或设置温度>25℃且温度差小于2℃
        /// </summary>
        public bool IsReady
        {
            get
            {
                return (!XMachine.Instance.Card.FindDo(_lowLiquidIO).Sts &&
                       (Math.Abs(_tempCtrlPV * 10 - _tempCtrlSVValue) <= 20) || (_tempCtrlSVValue <= 250));
            }
        }

        // 检查并触发液位状态变更事件的方法
        public void CheckLiquidLevel()
        {
            bool currentState = IsLowLiquid;
            if (currentState != _lastLowLiquidState)
            {
                _lastLowLiquidState = currentState;
                LiquidLevelChanged?.Invoke(this, currentState);
            }
        }
        
        public bool IsLowLiquid
        {
            get
            {
                return XMachine.Instance.Card.FindDi(_lowLiquidIO).Sts;
            }
        }

        private bool IsChagingFluid = false;
        // 液位状态变更事件
        public event EventHandler<bool> LiquidLevelChanged;
        
        private bool _lastLowLiquidState = false;
        
        public Tank(string IP,
                    EnumInfo.MixerPort MixPort,
                    int ChargeEnableIO,
                    int ChargeTimeoutIO,
                    int DrainPumpIO,
                    int DrainValveIO,
                    int LowLiquidLevelIO,
                    EnumInfo.TempCtrlAddr TempCtrlAddr,
                    EnumInfo.TempCtrlChannel TempCtrlChannel,
                    EnumInfo.TempCtrlIndex TempCtrlIndex,
                    EnumInfo.TempCtrlSV TempCtrlSV,
                    int BlowIO,
                    Scheduler.StationID StationID,
                    int AllowedLiquidUses,
                    bool IsStartDelay,
                    TimeSpan StartDelayTime,
                    bool ChargeOnStart
                    )
        {
            //搅拌器
            if (IP != "-1" & (short)MixPort != -1) _mixer = new Mixer(IP, (short)MixPort);
            //液体
            _chargeEnableIO = ChargeEnableIO;
            _drainPumpIO = DrainPumpIO;
            _drainValveIO = DrainValveIO;
            _lowLiquidIO = LowLiquidLevelIO;
            _chargeTimeoutIO = ChargeTimeoutIO;
            //温度
            _tempCtrlAddr       = (int)TempCtrlAddr;
            _tempCtrlChannel    = (int)TempCtrlChannel;
            _tempCtrlIndex      = (int)TempCtrlIndex;
            _tempCtrlSVValue    = (int)TempCtrlSV;
            //吹气
            _blowIO = BlowIO;
            //其他
            _stationID = StationID;
            _allowedLiquidUses = AllowedLiquidUses;
            _isStartDelay = IsStartDelay;
            _startDelayTime = StartDelayTime;
            _chargeOnStart = ChargeOnStart;
            
            // 订阅液位传感器的状态变化事件
            SubscribeToLiquidLevelSensor();
        }

        /// <summary>
        /// 订阅液位传感器的状态变化事件
        /// </summary>
        private void SubscribeToLiquidLevelSensor()
        {            
            try
            {                
                if (_lowLiquidIO != -1 && XMachine.Instance != null && XMachine.Instance.Card != null)
                {
                    // 获取液位传感器对应的XDi对象
                    _liquidLevelDi = XMachine.Instance.Card.FindDi(_lowLiquidIO);
                    if (_liquidLevelDi != null)
                    {
                        // 订阅状态变化事件
                        _liquidLevelDi.StateChanged += OnLiquidLevelSensorStateChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                // 记录异常但不中断程序
                System.Diagnostics.Debug.WriteLine($"订阅液位传感器事件时出错: {ex.Message}");
            }
        }
        
        /// <summary>
        /// 液位传感器状态变化事件处理程序
        /// </summary>
        private void OnLiquidLevelSensorStateChanged(object sender, bool newState)
        {            
            // 直接从传感器获取的状态就是液位低的状态
            bool isLowLiquid = newState;
            
            if (isLowLiquid != _lastLowLiquidState)
            {
                _lastLowLiquidState = isLowLiquid;
                // 触发液位变化事件
                LiquidLevelChanged?.Invoke(this, isLowLiquid);
            }
        }
        
        /// <summary>
        /// 镀槽：初始化
        /// </summary>
        public bool Initial()
        {            
            // 初始化时保存当前液位状态
            _lastLowLiquidState = IsLowLiquid;
            
            // 搅拌：关闭
            StopMix();
            // 进液：关闭
            StopCharge();
            // 排液：关闭
            StopDrain();
            // 温控：关闭
            StopTempCtrl();
            // 温控：设定SV
            SetSV();
            // 吹气：关闭
            StopBlow();
            // 变量初始化
            _liquidUses = 0;
            return true;
        }
        
        /// <summary>
        /// 清理资源，取消事件订阅
        /// </summary>
        public void Dispose()
        {            
            if (_liquidLevelDi != null)
            {
                _liquidLevelDi.StateChanged -= OnLiquidLevelSensorStateChanged;
                _liquidLevelDi = null;
            }
        }

        /// <summary>
        /// 镀槽：打开
        /// </summary>
        public void Start()
        {
            if (_isStartDelay)
            {
                StartDelay();
            }
            else
            {
                StartNow();
            }
        }

        private void StartNow()
        {
            //搅拌：打开
            StartMix();
            //进液使能
            if (_chargeOnStart)
            {
                StartCharge();
            }
            //排液：关闭
            StopDrain();
            //温控：打开
            StartTempCtrl();
        }

        private void StartDelay()
        {
            var timer = new System.Timers.Timer(_startDelayTime.TotalMilliseconds);
            timer.Elapsed += (s, e) =>
            {
                StartNow();
                timer.Stop();
            };
            timer.Start();
        }

        public bool StartWithoutCharge()
        {
            //搅拌：打开
            StartMix();
            //排液：关闭
            StopDrain();
            //温控：打开
            StartTempCtrl();
            return true;
        }

        /// <summary>
        /// 镀槽：关闭
        /// </summary>
        public bool Stop()
        {
            //搅拌：关闭
            StopMix();
            //进液：关闭
            StopCharge();
            //排液：关闭
            StopDrain();
            //温控：关闭
            StopTempCtrl();
            //吹气：关闭
            StopBlow();
            return true;
        }

        /// <summary>
        /// 获取搅拌器的当前状态
        /// </summary>
        public bool Mixing
        {
            get
            {                
                return _mixer?.Mixing ?? false;
            }
        }

        /// <summary>
        /// 磁力搅拌器：打开
        /// </summary>
        public bool StartMix()
        {
            if (_mixer == null)
            {
                return false;
            }
            try
            {
                bool result = _mixer.Start();
                // 触发状态更新事件
                OnMixerStateChanged?.Invoke(this, new EventArgs());
                return result;
            }
            catch { }
            return true;
        }

        /// <summary>
        /// 磁力搅拌器：关闭
        /// </summary>
        public bool StopMix()
        {
            if (_mixer == null)
            {
                return false;
            }
            try
            {
                bool result = _mixer.Stop();
                // 触发状态更新事件
                OnMixerStateChanged?.Invoke(this, new EventArgs());
                return result;
            }
            catch { }
            return true;
        }

        /// <summary>
        /// 搅拌器状态变化事件
        /// </summary>
        public event EventHandler OnMixerStateChanged;

        /// <summary>进液使能：打开</summary>
        public bool StartCharge()
        {
            //进液使能：打开
            XMachine.Instance.Card.FindDo(_chargeEnableIO).SetDo(true);
            return true;
        }

        /// <summary>
        /// 进液使能：关闭
        /// </summary>
        /// <returns></returns>
        public bool StopCharge()
        {
            //进液使能：关闭
            XMachine.Instance.Card.FindDo(_chargeEnableIO).SetDo(false);
            return true;
        }

        /// <summary>
        /// 排液：打开
        /// </summary>
        public bool StartDrain()
        {
            try
            {
                if (!Globa.Status.CardConnected) return false;
                //排液阀：打开
                XMachine.Instance.Card.FindDo(_drainValveIO).SetDo(true);
            }
            catch { }
            return true;
        }

        /// <summary>
        /// 排液：关闭
        /// </summary>
        public bool StopDrain()
        {
            try
            {
                if (!Globa.Status.CardConnected) return false;
                Thread.Sleep(50);
                //排液阀：关闭
                XMachine.Instance.Card.FindDo(_drainValveIO).SetDo(false);
            }
            catch { }
            return true;
        }

        /// <summary>
        /// 温控：设置目标温度,单位0.1℃
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
        /// 吹气：打开
        /// </summary>
        public bool StartBlow()
        {
            if (_blowIO == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    if (!Globa.Status.CardConnected) return false;
                    //吹气阀：打开
                    XMachine.Instance.Card.FindDo(_blowIO).SetDo(true);
                }
                catch { }
                return true;
            }
        }

        /// <summary>
        /// 吹气：关闭
        /// </summary>
        public bool StopBlow()
        {
            if (_blowIO == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    if (!Globa.Status.CardConnected) return false;
                    //吹气阀：关闭
                    XMachine.Instance.Card.FindDo(_blowIO).SetDo(false);
                }
                catch { }
                return true;
            }
        }

        /// <summary>
        /// 工艺：准备
        /// </summary>
        public void ProcessPreparation()
        {
            //吹气：关闭（工艺开始时才打开）
            StartBlow();
        }

        /// <summary>
        /// 重置工艺准备状态
        /// </summary>
        public void ResetProcessPreparation()
        {
            // 液体使用次数加1
            _liquidUses++;
            // 自动换液
            if (_allowedLiquidUses > 0 && _liquidUses >= _allowedLiquidUses)
            {
                if (IsChagingFluid) { return; }
                Task task = Task.Run(() =>
                {
                    IsChagingFluid = true;
                    ChangeFluid();
                    IsChagingFluid = false;
                });
                _liquidUses = 0;
            }
            //吹气：关闭
            StopBlow();
        }

        /// <summary>
        /// 工艺：开始
        /// </summary>
        /// <param name="ProcessDuration"></param>
        /// <returns></returns>
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
            // 更新调度状态的标志位
            Globa.Device.Scheduler.UpdateWhenProcessDone(stationID);
            return true;
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

        public void ChangeFluid()
        {
            // 关闭进液使能
            StopCharge();
            // 关闭温控
            StopTempCtrl();
            // 打开排液
            StartDrain();
            // 等待排液完成，排液时间约1分钟
            Thread.Sleep(1000 * 90);
            // 关闭排液
            StopDrain();
            // 打开进液使能
            StartCharge();
            // 打开温控
            while (!XMachine.Instance.Card.FindDo(_lowLiquidIO).Sts)
            {
                Thread.Sleep(1000);
                return;
            }
            StartTempCtrl();
        }
    }
}