using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using MetalizationSystem.DataCollection;
using MetalizationSystem.Devices;
using System.Windows.Threading;

namespace MetalizationSystem.ViewModels
{
    public partial class StationDebuggingViewModel : ObservableObject
    {

        public BindingList<ReactionTankInfo> ReactionTankInfos { get; }

        [ObservableProperty]
        string  _reactionTankSelectId = "1";
        [ObservableProperty]
        double _reactionTankTemperature;
        [ObservableProperty]
        string[] _ports = System.IO.Ports.SerialPort.GetPortNames();




        [RelayCommand]
        public void FixPumpTest()
        {
            Globa.Device.FixPump.Start(Globa.DataManager.ParameterList.LiquidDispensing.Solvent[1].ModbusId, 10);
            Thread.Sleep(100);
            Globa.Device.FixPump.Start(Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid[1].ModbusId, 10);
        }




        private DispatcherTimer _temperatureUpdateTimer;
        
        public StationDebuggingViewModel() {
            ReactionTankInfos = new BindingList<ReactionTankInfo>();
            
            // 槽位编号列表
            string[] tankNumbers = {"Tank20", "Tank21", "Tank22", "Tank23", "Tank30", "Tank40", "Tank41", "Tank42", "Tank43", "Tank50", "Tank51", "Tank52", "Tank53"};
            // 槽位名称列表
            string[] tankNames = {"水洗", "水洗", "乙醇洗", "羟基化", "氮气吹干", "有机物过渡层", "金属氧化物过渡层", "预浸", "活化", "减速", "加速", "化铜", "防氧化"};
            
            // 添加模拟数据
            for (int i = 1; i <= 13; i++)
            {
                ReactionTankInfos.Add(new ReactionTankInfo(i)
                {
                    TankNumber = tankNumbers[i-1],
                    Name = tankNames[i-1],
                    ChargingIo = -1,
                    DrainageIo = -1,
                    SolenoidValveIo = -1,
                    HeatingIo = -1,
                    LiquidLevelIo = -1,
                    TemperatureId = -1,
                    IP = "192.168.10.12",
                    Port = 23,
                    Temperature = 0,
                    Time = 0,
                    Speed = i == 1 ? 200 : 100
                });
            }
            
            // 初始化温度更新定时器
            InitializeTemperatureUpdateTimer();
        }
        
        /// <summary>初始化温度更新定时器</summary>
        private void InitializeTemperatureUpdateTimer()
        {
            _temperatureUpdateTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1) // 每秒刷新一次
            };
            _temperatureUpdateTimer.Tick += (sender, e) => UpdateAllTemperatures();
            _temperatureUpdateTimer.Start();
        }
        
        /// <summary>更新所有槽位的温度数据</summary>
        private void UpdateAllTemperatures()
        {
            foreach (var tankInfo in ReactionTankInfos)
            {
                tankInfo.RefreshTemperature();
            }
        }



    }
}
