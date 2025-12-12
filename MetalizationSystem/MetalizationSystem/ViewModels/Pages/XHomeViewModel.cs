using CommunityToolkit.Mvvm.Input;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using MetalizationSystem.DataCollection;
using MetalizationSystem.DataServer;
using MetalizationSystem.Devices;
using MetalizationSystem.EnumCollection;
using MetalizationSystem.ViewModels.Node;
using MetalizationSystem.Views;
using MetalizationSystem.Views.UC;
using MetalizationSystem.WorkFlows.Recipe;
using Newtonsoft.Json;
using SqlSugar.Extensions;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;


namespace MetalizationSystem.ViewModels;

public partial class XHomeViewModel : ObservableObject
{
    /// <summary>
    /// 开始命令
    /// </summary>
    public ICommand StartCommand { get; }

    /// <summary>
    /// 暂停命令
    /// </summary>
    public ICommand PauseCommand { get; }

    /// <summary>
    /// 停止命令
    /// </summary>
    public ICommand StopCommand { get; }
    public ICommand HomeCommand { get; }
    public ICommand TankStartCommand { get; }
    public ICommand TankStopCommand { get; }
    public ICommand ProcessStartCommand { get; }
    public ICommand ProcessStopCommand { get; }
    public ICommand TankStartDrainCommand { get; }
    public ICommand TankStopDrainCommand { get; }

    public XHomeViewModel()
    {
        StartCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.Start()));
        HomeCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.Home()));
        TankStartCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.TankStart()));
        TankStopCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.TankStop()));
        ProcessStartCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.ProcessStart()));
        ProcessStopCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.ProcessStop()));
        TankStartDrainCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.TankStartDrain()));
        TankStopDrainCommand = new RelayCommand(async () => await Task.Run(() => Globa.Device.AutoModel.TankStopDrain()));
    }

    


    //HomeCommand = new RelayCommand(Home);
    //TankStartCommand = new RelayCommand(TankStart);
    //TankStopCommand = new RelayCommand(TankStop);
    //ProcessStartCommand = new RelayCommand(ProcessStart);
    //ProcessStopCommand = new RelayCommand(ProcessStop);
    //AutoStopCommand = new RelayCommand(AutoStop);


    [ObservableProperty]
    bool[] _isHaveLoad;
    [ObservableProperty]
    bool[] _isHaveUnLoad;
    [ObservableProperty]
    bool _cardConnected = false;
    [ObservableProperty]
    bool _robotConnected = false;
    [ObservableProperty]
    bool _fixPumpConnected = false;
    [ObservableProperty]
    bool _pt100erConnected = false;
    [ObservableProperty]
    bool _dryBoxConnected = false;
    [ObservableProperty]
    bool _mixerConnected = false;
    [ObservableProperty]
    bool _omConnected = false;
    [ObservableProperty]
    bool _aiConnected = false;
    [ObservableProperty]
    string[] _workFlowItem;
    [ObservableProperty]
    string[] _logItem;
    [ObservableProperty]
    double _dryBoxTemperature = 0;
    private int _comboxSelectedIndex;
    
    public int ComboxSelectedIndex
    {
        get => _comboxSelectedIndex;
        set
        {
            if (SetProperty(ref _comboxSelectedIndex, value))
            {
                // 同步更新AutoModel中的ComboxSelectedIndex字段
                if (Globa.Device.AutoModel != null)
                {
                    // 直接访问公有字段
                    Globa.Device.AutoModel.ComboxSelectedIndex = value;
                    // 调用LoadRecipe方法加载对应的配方
                    Globa.Device.AutoModel.LoadRecipe();
                }
            }
        }
    }
}