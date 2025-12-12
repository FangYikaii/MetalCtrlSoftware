using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using DynamicData;
using MetalizationSystem.DataCollection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetalizationSystem.ViewModels
{
    public partial class ParameterListViewModel : ObservableRecipient
    {
        public BindingList<ReactionTankInfo> ReactionTankInfos { get; }
        public BindingList<ReactionTankInfo> UltrasonicCleanerInfos { get; }
        [ObservableProperty]
        OrderInfo _orderInfo;
        [ObservableProperty]
        string[] _ports= System.IO.Ports.SerialPort.GetPortNames();


        [RelayCommand]
        public void Save()
        {         
            for (int i = 0; i < OrderInfo.ReactionTanks.Length - 1; i++)
            {
                OrderInfo.ReactionTanks[i + 1] = new ReactionTankInfo(ReactionTankInfos[i].Id, ReactionTankInfos[i].ChargingIo, ReactionTankInfos[i].DrainageIo, ReactionTankInfos[i].SolenoidValveIo,
                    ReactionTankInfos[i].HeatingIo, ReactionTankInfos[i].LiquidLevelIo, ReactionTankInfos[i].TemperatureId, ReactionTankInfos[i].IP, ReactionTankInfos[i].Port)
                { TankNumber = ReactionTankInfos[i].TankNumber ,Temperature= ReactionTankInfos[i].Temperature,Speed = ReactionTankInfos[i].Speed };
            }

            OrderInfo.UltrasonicCleaner = new ReactionTankInfo(UltrasonicCleanerInfos[0].Id, UltrasonicCleanerInfos[0].ChargingIo, UltrasonicCleanerInfos[0].DrainageIo, UltrasonicCleanerInfos[0].SolenoidValveIo,
                    UltrasonicCleanerInfos[0].HeatingIo, UltrasonicCleanerInfos[0].LiquidLevelIo, UltrasonicCleanerInfos[0].TemperatureId, UltrasonicCleanerInfos[0].IP, UltrasonicCleanerInfos[0].Port)
            { TankNumber = UltrasonicCleanerInfos[0].TankNumber, Temperature = UltrasonicCleanerInfos[0].Temperature, Speed = UltrasonicCleanerInfos[0].Speed };


            Globa.DataManager.ParameterList = OrderInfo;      
            WeakReferenceMessenger.Default.Send(message: new ValueChangedMessage<OrderInfo>(OrderInfo));


     
        }
        public ParameterListViewModel()
        {          
            OrderInfo = Globa.DataManager.ParameterList;    
            ReactionTankInfos = new BindingList<ReactionTankInfo>();
            UltrasonicCleanerInfos = new BindingList<ReactionTankInfo>();

            for (int i = 1; i < OrderInfo.ReactionTanks.Length; i++)
            {
                ReactionTankInfos.Add(OrderInfo.ReactionTanks[i]);
            }
            UltrasonicCleanerInfos.Add(OrderInfo.UltrasonicCleaner);
        }


    }
}
