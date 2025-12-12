using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MetalizationSystem;
using MetalizationSystem.Devices;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public partial class ReactionTankInfo : ObservableObject
    {
        public int Id { get; set; } = -1;
        
        [ObservableProperty]
        string _tankNumber = "";
        
        /// <summary>名称</summary>
        [ObservableProperty]
        string _name = "";
        
        /// <summary>加液IO</summary>
        public int ChargingIo { get; set; } = -1;
        
        /// <summary>排液IO</summary>
        public int DrainageIo { get; set; } = -1;
        
        /// <summary>电磁阀IO</summary>
        public int SolenoidValveIo { get; set; } = -1;
        
        /// <summary>加热IO</summary>
        public int HeatingIo { get; set; } = -1;
        
        /// <summary>液位感应器IO</summary>
        public int LiquidLevelIo { get; set; } = -1;
        
        /// <summary>温度编号</summary>
        public int TemperatureId { get; set; } = -1;
        
        public string IP { get; set; } = "192.168.10.12";
        public short Port { get; set; } = 23;
        
        /// <summary>目标温度 【单位：℃】 </summary>
        public double TargetTemperature
        {
            get
            {
                switch (TankNumber)
                {
                    case "Tank20": return (Globa.Device.Tank20?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank21": return (Globa.Device.Tank21?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank22": return (Globa.Device.Tank22?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank23": return (Globa.Device.Tank23?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank30": return (Globa.Device.AirBox?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank40": return (Globa.Device.Tank40?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank41": return (Globa.Device.Tank41?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank42": return (Globa.Device.Tank42?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank43": return (Globa.Device.Tank43?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank50": return (Globa.Device.Tank50?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank51": return (Globa.Device.Tank51?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank52": return (Globa.Device.Tank52?._tempCtrlSV ?? 0) / 10.0;
                    case "Tank53": return (Globa.Device.Tank53?._tempCtrlSV ?? 0) / 10.0;
                    default: return 0;
                }
            }
            set
            {
                switch (TankNumber)
                {
                    case "Tank20":
                        if (Globa.Device.Tank20 != null)
                        {
                            Globa.Device.Tank20.SetSV((int)(value * 10)); // 注意这里需要乘以10，因为SetSV接受的是0.1℃单位
                        }
                        break;
                    case "Tank21":
                        if (Globa.Device.Tank21 != null)
                        {
                            Globa.Device.Tank21.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank22":
                        if (Globa.Device.Tank22 != null)
                        {
                            Globa.Device.Tank22.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank23":
                        if (Globa.Device.Tank23 != null)
                        {
                            Globa.Device.Tank23.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank30":
                        if (Globa.Device.AirBox != null)
                        {
                            Globa.Device.AirBox.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank40":
                        if (Globa.Device.Tank40 != null)
                        {
                            Globa.Device.Tank40.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank41":
                        if (Globa.Device.Tank41 != null)
                        {
                            Globa.Device.Tank41.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank42":
                        if (Globa.Device.Tank42 != null)
                        {
                            Globa.Device.Tank42.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank43":
                        if (Globa.Device.Tank43 != null)
                        {
                            Globa.Device.Tank43.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank50":
                        if (Globa.Device.Tank50 != null)
                        {
                            Globa.Device.Tank50.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank51":
                        if (Globa.Device.Tank51 != null)
                        {
                            Globa.Device.Tank51.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank52":
                        if (Globa.Device.Tank52 != null)
                        {
                            Globa.Device.Tank52.SetSV((int)(value * 10));
                        }
                        break;
                    case "Tank53":
                        if (Globa.Device.Tank53 != null)
                        {
                            Globa.Device.Tank53.SetSV((int)(value * 10));
                        }
                        break;
                }
            }
        }
        
        /// <summary>温度 【单位：℃】 </summary>
        public double Temperature { get; set; } = 0;
        
        private double _actualTemperature = 0;
        private bool _isLowLiquid = false;
        
        /// <summary>实际温度 【单位：℃】 </summary>
        public double ActualTemperature
        {
            get
            {
                // 每次获取时从设备读取最新值
                double newValue = GetCurrentTemperatureFromDevice();
                if (_actualTemperature != newValue)
                {
                    _actualTemperature = newValue;
                    OnPropertyChanged(nameof(ActualTemperature));
                }
                return _actualTemperature;
            }
        }
        
        /// <summary>液位状态（低液位）</summary>
        public bool IsLowLiquid
        {
            get { return _isLowLiquid; }
            private set
            {
                if (_isLowLiquid != value)
                {
                    _isLowLiquid = value;
                    OnPropertyChanged(nameof(IsLowLiquid));
                }
            }
        }
        
        /// <summary>从设备获取当前温度值</summary>
        private double GetCurrentTemperatureFromDevice()
        {
            switch (TankNumber)
            {
                case "Tank20": return Globa.Device.Tank20?._tempCtrlPV ?? 0;
                case "Tank21": return Globa.Device.Tank21?._tempCtrlPV ?? 0;
                case "Tank22": return Globa.Device.Tank22?._tempCtrlPV ?? 0;
                case "Tank23": return Globa.Device.Tank23?._tempCtrlPV ?? 0;
                case "Tank30": return Globa.Device.AirBox?._tempCtrlPV ?? 0;
                case "Tank40": return Globa.Device.Tank40?._tempCtrlPV ?? 0;
                case "Tank41": return Globa.Device.Tank41?._tempCtrlPV ?? 0;
                case "Tank42": return Globa.Device.Tank42?._tempCtrlPV ?? 0;
                case "Tank43": return Globa.Device.Tank43?._tempCtrlPV ?? 0;
                case "Tank50": return Globa.Device.Tank50?._tempCtrlPV ?? 0;
                case "Tank51": return Globa.Device.Tank51?._tempCtrlPV ?? 0;
                case "Tank52": return Globa.Device.Tank52?._tempCtrlPV ?? 0;
                case "Tank53": return Globa.Device.Tank53?._tempCtrlPV ?? 0;
                default: return 0;
            }
        }
        
        /// <summary>刷新温度数据</summary>
        public void RefreshTemperature()
        {
            double newValue = GetCurrentTemperatureFromDevice();
            if (_actualTemperature != newValue)
            {
                _actualTemperature = newValue;
                OnPropertyChanged(nameof(ActualTemperature));
            }
        }
        
        /// <summary>时间 【单位：min】 </summary>
        public int Time { get; set; } = 0;
        
        /// <summary>时间 【单位：ms】 </summary>
        public int GetTime { get { return Time * 60 * 1000; } }
        
        public int Speed { get; set; } = 100;
        
        /// <summary>搅拌状态</summary>
        [ObservableProperty]
        bool _isMixing = false;
        
        /// <summary>搅拌控制是否可用</summary>
        public bool IsMixingEnabled => TankNumber != "Tank30";
        
        /// <summary>进液控制是否可用</summary>
        public bool IsChargingControlEnabled => TankNumber != "Tank30";
        
        /// <summary>排液控制是否可用</summary>
        public bool IsDrainingControlEnabled => TankNumber != "Tank30";
        
        /// <summary>进液使能状态</summary>
        [ObservableProperty]
        bool _isChargingEnabled = false;
        
        /// <summary>排液使能状态</summary>
        [ObservableProperty]
        bool _isDrainingEnabled = false;
        
        /// <summary>加热使能状态</summary>
        [ObservableProperty]
        bool _isHeatingEnabled = false;
        
        /// <summary>鼓泡使能状态</summary>
        [ObservableProperty]
        bool _isBubblingEnabled = false;
        
        // 订阅液位状态变更事件的方法
        private void SubscribeToLiquidLevelEvents()
        {
            switch (TankNumber)
            {
                case "Tank20":
                    if (Globa.Device.Tank20 != null)
                    {
                        Globa.Device.Tank20.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank21":
                    if (Globa.Device.Tank21 != null)
                    {
                        Globa.Device.Tank21.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank22":
                    if (Globa.Device.Tank22 != null)
                    {
                        Globa.Device.Tank22.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank23":
                    if (Globa.Device.Tank23 != null)
                    {
                        Globa.Device.Tank23.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank40":
                    if (Globa.Device.Tank40 != null)
                    {
                        Globa.Device.Tank40.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank41":
                    if (Globa.Device.Tank41 != null)
                    {
                        Globa.Device.Tank41.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank42":
                    if (Globa.Device.Tank42 != null)
                    {
                        Globa.Device.Tank42.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank43":
                    if (Globa.Device.Tank43 != null)
                    {
                        Globa.Device.Tank43.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank50":
                    if (Globa.Device.Tank50 != null)
                    {
                        Globa.Device.Tank50.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank51":
                    if (Globa.Device.Tank51 != null)
                    {
                        Globa.Device.Tank51.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank52":
                    if (Globa.Device.Tank52 != null)
                    {
                        Globa.Device.Tank52.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
                case "Tank53":
                    if (Globa.Device.Tank53 != null)
                    {
                        Globa.Device.Tank53.LiquidLevelChanged += (sender, isLow) => UpdateLiquidLevelInUIThread(isLow);
                    }
                    break;
            }
        }

        // 订阅搅拌状态变更事件的方法
        private void SubscribeToMixerStateEvents()
        {
            switch (TankNumber)
            {
                case "Tank20":
                    if (Globa.Device.Tank20 != null)
                    {
                        Globa.Device.Tank20.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank21":
                    if (Globa.Device.Tank21 != null)
                    {
                        Globa.Device.Tank21.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank22":
                    if (Globa.Device.Tank22 != null)
                    {
                        Globa.Device.Tank22.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank23":
                    if (Globa.Device.Tank23 != null)
                    {
                        Globa.Device.Tank23.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank40":
                    if (Globa.Device.Tank40 != null)
                    {
                        Globa.Device.Tank40.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank41":
                    if (Globa.Device.Tank41 != null)
                    {
                        Globa.Device.Tank41.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank42":
                    if (Globa.Device.Tank42 != null)
                    {
                        Globa.Device.Tank42.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank43":
                    if (Globa.Device.Tank43 != null)
                    {
                        Globa.Device.Tank43.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank50":
                    if (Globa.Device.Tank50 != null)
                    {
                        Globa.Device.Tank50.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank51":
                    if (Globa.Device.Tank51 != null)
                    {
                        Globa.Device.Tank51.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank52":
                    if (Globa.Device.Tank52 != null)
                    {
                        Globa.Device.Tank52.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
                case "Tank53":
                    if (Globa.Device.Tank53 != null)
                    {
                        Globa.Device.Tank53.OnMixerStateChanged += (sender, e) => UpdateMixingStateInUIThread();
                    }
                    break;
            }
        }

        // 在UI线程中更新搅拌状态
        private void UpdateMixingStateInUIThread()
        {
            // 使用Dispatcher确保在UI线程中更新属性
            if (System.Windows.Application.Current?.Dispatcher != null)
            {
                if (System.Windows.Application.Current.Dispatcher.CheckAccess())
                {
                    UpdateMixingState();
                }
                else
                {
                    System.Windows.Application.Current.Dispatcher.Invoke(() => 
                    {
                        UpdateMixingState();
                    });
                }
            }
            else
            {
                // 如果无法获取Dispatcher，直接更新（可能在非UI线程环境）
                UpdateMixingState();
            }
        }

        // 更新搅拌状态
        private void UpdateMixingState()
        {
            bool actualMixingState = false;
            switch (TankNumber)
            {
                case "Tank20": actualMixingState = Globa.Device.Tank20?.Mixing ?? false; break;
                case "Tank21": actualMixingState = Globa.Device.Tank21?.Mixing ?? false; break;
                case "Tank22": actualMixingState = Globa.Device.Tank22?.Mixing ?? false; break;
                case "Tank23": actualMixingState = Globa.Device.Tank23?.Mixing ?? false; break;
                case "Tank40": actualMixingState = Globa.Device.Tank40?.Mixing ?? false; break;
                case "Tank41": actualMixingState = Globa.Device.Tank41?.Mixing ?? false; break;
                case "Tank42": actualMixingState = Globa.Device.Tank42?.Mixing ?? false; break;
                case "Tank43": actualMixingState = Globa.Device.Tank43?.Mixing ?? false; break;
                case "Tank50": actualMixingState = Globa.Device.Tank50?.Mixing ?? false; break;
                case "Tank51": actualMixingState = Globa.Device.Tank51?.Mixing ?? false; break;
                case "Tank52": actualMixingState = Globa.Device.Tank52?.Mixing ?? false; break;
                case "Tank53": actualMixingState = Globa.Device.Tank53?.Mixing ?? false; break;
            }
            
            if (IsMixing != actualMixingState)
            {
                IsMixing = actualMixingState;
            }
        }
        
        // 在UI线程中更新液位状态
        private void UpdateLiquidLevelInUIThread(bool isLow)
        {
            // 使用Dispatcher确保在UI线程中更新属性
            if (System.Windows.Application.Current?.Dispatcher != null)
            {
                if (System.Windows.Application.Current.Dispatcher.CheckAccess())
                {
                    IsLowLiquid = isLow;
                }
                else
                {
                    System.Windows.Application.Current.Dispatcher.Invoke(() => 
                    {
                        IsLowLiquid = isLow;
                    });
                }
            }
            else
            {
                // 如果无法获取Dispatcher，直接更新（可能在非UI线程环境）
                IsLowLiquid = isLow;
            }
        }
        
        public ReactionTankInfo(int id, int chargingIo, int drainageIo, int solenoidValveIo, int heatingIo, int liquidLevelIo, int temperatureId,string ip, short port)
        {
            Id = id;
            ChargingIo = chargingIo;
            DrainageIo = drainageIo;
            SolenoidValveIo = solenoidValveIo;
            HeatingIo = heatingIo;
            LiquidLevelIo = liquidLevelIo;
            TemperatureId = temperatureId;
            IP = ip;
            Port = port;
        }

        public ReactionTankInfo(int id)
        {
            Id = id;
            // 初始化时读取一次实际温度
            RefreshTemperature();
            
            // 延迟订阅事件，确保TankNumber已设置
            System.Threading.Tasks.Task.Delay(100).ContinueWith(t => 
            {
                SubscribeToLiquidLevelEvents();
                SubscribeToMixerStateEvents();
                // 初始化时获取一次当前液位状态
                InitializeLiquidLevel();
            });
        }
        
        // 初始化液位状态
        private void InitializeLiquidLevel()
        {
            try
            {
                bool initialLevel = false;
                switch (TankNumber)
                {
                    case "Tank20": initialLevel = Globa.Device.Tank20?.IsLowLiquid ?? false; break;
                    case "Tank21": initialLevel = Globa.Device.Tank21?.IsLowLiquid ?? false; break;
                    case "Tank22": initialLevel = Globa.Device.Tank22?.IsLowLiquid ?? false; break;
                    case "Tank23": initialLevel = Globa.Device.Tank23?.IsLowLiquid ?? false; break;
                    case "Tank40": initialLevel = Globa.Device.Tank40?.IsLowLiquid ?? false; break;
                    case "Tank41": initialLevel = Globa.Device.Tank41?.IsLowLiquid ?? false; break;
                    case "Tank42": initialLevel = Globa.Device.Tank42?.IsLowLiquid ?? false; break;
                    case "Tank43": initialLevel = Globa.Device.Tank43?.IsLowLiquid ?? false; break;
                    case "Tank50": initialLevel = Globa.Device.Tank50?.IsLowLiquid ?? false; break;
                    case "Tank51": initialLevel = Globa.Device.Tank51?.IsLowLiquid ?? false; break;
                    case "Tank52": initialLevel = Globa.Device.Tank52?.IsLowLiquid ?? false; break;
                    case "Tank53": initialLevel = Globa.Device.Tank53?.IsLowLiquid ?? false; break;
                }
                UpdateLiquidLevelInUIThread(initialLevel);
            }
            catch (Exception ex)
            {
                // 记录异常但不中断程序
            }
        }
    }
}

// 实现部分
namespace MetalizationSystem.DataCollection
{
    public partial class ReactionTankInfo
    {
        partial void OnIsDrainingEnabledChanged(bool value)
        {
            // 排液使能状态改变时的处理逻辑
            if (TankNumber == "Tank20")
            {
                if (value)
                    Globa.Device.Tank20.StartDrain();
                else
                    Globa.Device.Tank20.StopDrain();
            }
            else if (TankNumber == "Tank21")
            {
                if (value)
                    Globa.Device.Tank21.StartDrain();
                else
                    Globa.Device.Tank21.StopDrain();
            }
            else if (TankNumber == "Tank22")
            {
                if (value)
                    Globa.Device.Tank22.StartDrain();
                else
                    Globa.Device.Tank22.StopDrain();
            }
            else if (TankNumber == "Tank23")
            {
                if (value)
                    Globa.Device.Tank23.StartDrain();
                else
                    Globa.Device.Tank23.StopDrain();
            }
            else if (TankNumber == "Tank40")
            {
                if (value)
                    Globa.Device.Tank40.StartDrain();
                else
                    Globa.Device.Tank40.StopDrain();
            }
            else if (TankNumber == "Tank41")
            {
                if (value)
                    Globa.Device.Tank41.StartDrain();
                else
                    Globa.Device.Tank41.StopDrain();
            }
            else if (TankNumber == "Tank42")
            {
                if (value)
                    Globa.Device.Tank42.StartDrain();
                else
                    Globa.Device.Tank42.StopDrain();
            }
            else if (TankNumber == "Tank43")
            {
                if (value)
                    Globa.Device.Tank43.StartDrain();
                else
                    Globa.Device.Tank43.StopDrain();
            }
            else if (TankNumber == "Tank50")
            {
                if (value)
                    Globa.Device.Tank50.StartDrain();
                else
                    Globa.Device.Tank50.StopDrain();
            }
            else if (TankNumber == "Tank51")
            {
                if (value)
                    Globa.Device.Tank51.StartDrain();
                else
                    Globa.Device.Tank51.StopDrain();
            }
            else if (TankNumber == "Tank52")
            {
                if (value)
                    Globa.Device.Tank52.StartDrain();
                else
                    Globa.Device.Tank52.StopDrain();
            }
            else if (TankNumber == "Tank53")
            {
                if (value)
                    Globa.Device.Tank53.StartDrain();
                else
                    Globa.Device.Tank53.StopDrain();
            }
        }
        
        partial void OnIsChargingEnabledChanged(bool value)
        {
            // 进液使能状态改变时的处理逻辑
            if (TankNumber == "Tank20")
            {
                if (value)
                    Globa.Device.Tank20.StartCharge();
                else
                    Globa.Device.Tank20.StopCharge();
            }
            else if (TankNumber == "Tank21")
            {
                if (value)
                    Globa.Device.Tank21.StartCharge();
                else
                    Globa.Device.Tank21.StopCharge();
            }
            else if (TankNumber == "Tank22")
            {
                if (value)
                    Globa.Device.Tank22.StartCharge();
                else
                    Globa.Device.Tank22.StopCharge();
            }
            else if (TankNumber == "Tank23")
            {
                if (value)
                    Globa.Device.Tank23.StartCharge();
                else
                    Globa.Device.Tank23.StopCharge();
            }
            else if (TankNumber == "Tank40")
            {
                if (value)
                    Globa.Device.Tank40.StartCharge();
                else
                    Globa.Device.Tank40.StopCharge();
            }
            else if (TankNumber == "Tank41")
            {
                if (value)
                    Globa.Device.Tank41.StartCharge();
                else
                    Globa.Device.Tank41.StopCharge();
            }
            else if (TankNumber == "Tank42")
            {
                if (value)
                    Globa.Device.Tank42.StartCharge();
                else
                    Globa.Device.Tank42.StopCharge();
            }
            else if (TankNumber == "Tank43")
            {
                if (value)
                    Globa.Device.Tank43.StartCharge();
                else
                    Globa.Device.Tank43.StopCharge();
            }
            else if (TankNumber == "Tank50")
            {
                if (value)
                    Globa.Device.Tank50.StartCharge();
                else
                    Globa.Device.Tank50.StopCharge();
            }
            else if (TankNumber == "Tank51")
            {
                if (value)
                    Globa.Device.Tank51.StartCharge();
                else
                    Globa.Device.Tank51.StopCharge();
            }
            else if (TankNumber == "Tank52")
            {
                if (value)
                    Globa.Device.Tank52.StartCharge();
                else
                    Globa.Device.Tank52.StopCharge();
            }
            else if (TankNumber == "Tank53")
            {
                if (value)
                    Globa.Device.Tank53.StartCharge();
                else
                    Globa.Device.Tank53.StopCharge();
            }
        }
        
        partial void OnIsBubblingEnabledChanged(bool value)
        {
            // 鼓泡使能状态改变时的处理逻辑
            if (TankNumber == "Tank20")
            {
                if (value)
                    Globa.Device.Tank20.StartBlow();
                else
                    Globa.Device.Tank20.StopBlow();
            }
            else if (TankNumber == "Tank21")
            {
                if (value)
                    Globa.Device.Tank21.StartBlow();
                else
                    Globa.Device.Tank21.StopBlow();
            }
            else if (TankNumber == "Tank22")
            {
                if (value)
                    Globa.Device.Tank22.StartBlow();
                else
                    Globa.Device.Tank22.StopBlow();
            }
            // Tank23、Tank30、Tank40、Tank41、Tank42、Tank43、Tank50、Tank51、Tank53没有鼓泡能力，已禁用鼓泡开关
            else if (TankNumber == "Tank52")
            {
                if (value)
                    Globa.Device.Tank52.StartBlow();
                else
                    Globa.Device.Tank52.StopBlow();
            }
        }
        partial void OnIsHeatingEnabledChanged(bool value)
        {
            // 加热使能状态改变时的处理逻辑
            // Tank20、Tank21和Tank22没有加热能力，已禁用加热开关
            if (TankNumber == "Tank23")
            {
                if (value)
                    Globa.Device.Tank23.StartTempCtrl();
                else
                    Globa.Device.Tank23.StopTempCtrl();
            }
            else if (TankNumber == "Tank30")
            {
                if (value)
                    Globa.Device.AirBox.StartTempCtrl();
                else
                    Globa.Device.AirBox.StopTempCtrl();
            }
            else if (TankNumber == "Tank40")
            {
                if (value)
                    Globa.Device.Tank40.StartTempCtrl();
                else
                    Globa.Device.Tank40.StopTempCtrl();
            }
            else if (TankNumber == "Tank41")
            {
                if (value)
                    Globa.Device.Tank41.StartTempCtrl();
                else
                    Globa.Device.Tank41.StopTempCtrl();
            }
            else if (TankNumber == "Tank42")
            {
                if (value)
                    Globa.Device.Tank42.StartTempCtrl();
                else
                    Globa.Device.Tank42.StopTempCtrl();
            }
            else if (TankNumber == "Tank43")
            {
                if (value)
                    Globa.Device.Tank43.StartTempCtrl();
                else
                    Globa.Device.Tank43.StopTempCtrl();
            }
            else if (TankNumber == "Tank50")
            {
                if (value)
                    Globa.Device.Tank50.StartTempCtrl();
                else
                    Globa.Device.Tank50.StopTempCtrl();
            }
            else if (TankNumber == "Tank51")
            {
                if (value)
                    Globa.Device.Tank51.StartTempCtrl();
                else
                    Globa.Device.Tank51.StopTempCtrl();
            }
            else if (TankNumber == "Tank52")
            {
                if (value)
                    Globa.Device.Tank52.StartTempCtrl();
                else
                    Globa.Device.Tank52.StopTempCtrl();
            }
            else if (TankNumber == "Tank53")
            {
                if (value)
                    Globa.Device.Tank53.StartTempCtrl();
                else
                    Globa.Device.Tank53.StopTempCtrl();
            }
        }
        
        partial void OnIsMixingChanged(bool oldValue, bool newValue)
        {
            if (TankNumber == "Tank20")
            {
                if (newValue)
                    Globa.Device.Tank20.StartMix();
                else
                    Globa.Device.Tank20.StopMix();
            }
            else if (TankNumber == "Tank21")
            {
                if (newValue)
                    Globa.Device.Tank21.StartMix();
                else
                    Globa.Device.Tank21.StopMix();
            }
            else if (TankNumber == "Tank22")
            {
                if (newValue)
                    Globa.Device.Tank22.StartMix();
                else
                    Globa.Device.Tank22.StopMix();
            }
            else if (TankNumber == "Tank23")
            {
                if (newValue)
                    Globa.Device.Tank23.StartMix();
                else
                    Globa.Device.Tank23.StopMix();
            }
            else if (TankNumber == "Tank40")
            {
                if (newValue)
                    Globa.Device.Tank40.StartMix();
                else
                    Globa.Device.Tank40.StopMix();
            }
            else if (TankNumber == "Tank41")
            {
                if (newValue)
                    Globa.Device.Tank41.StartMix();
                else
                    Globa.Device.Tank41.StopMix();
            }
            else if (TankNumber == "Tank42")
            {
                if (newValue)
                    Globa.Device.Tank42.StartMix();
                else
                    Globa.Device.Tank42.StopMix();
            }
            else if (TankNumber == "Tank43")
            {
                if (newValue)
                    Globa.Device.Tank43.StartMix();
                else
                    Globa.Device.Tank43.StopMix();
            }
            else if (TankNumber == "Tank50")
            {
                if (newValue)
                    Globa.Device.Tank50.StartMix();
                else
                    Globa.Device.Tank50.StopMix();
            }
            else if (TankNumber == "Tank51")
            {
                if (newValue)
                    Globa.Device.Tank51.StartMix();
                else
                    Globa.Device.Tank51.StopMix();
            }
            else if (TankNumber == "Tank52")
            {
                if (newValue)
                    Globa.Device.Tank52.StartMix();
                else
                    Globa.Device.Tank52.StopMix();
            }
            else if (TankNumber == "Tank53")
            {
                if (newValue)
                    Globa.Device.Tank53.StartMix();
                else
                    Globa.Device.Tank53.StopMix();
            }
        }
    }
}
