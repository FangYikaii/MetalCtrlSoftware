using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using MetalizationSystem.DataServer;
using Xugz;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem
{
    class Task_LiquidDispensing : XTask
    {
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Exit()
        {
            base.Exit();
        }
      
   

        protected override void Running(object runMode)
        {
            Stopwatch stopwatch = new Stopwatch();
            while (true)
            {
                if (XStatus == Status.Start)
                {
                    if (NeedTwoWay)
                    {
                        if (BackTaskId == -1 | BackTaskId == ReadyId) XStatus = Status.Ready;
                        BackTaskId = ReadyId;
                    }
                    if (XStatus != Status.Ready)
                    {
                        Log.Info(SN + " " + Name + " Start", @"D:\Parameter\" + SN);

                        for (int i = 1; i < Globa.DataManager.ParameterList.LiquidDispensing.Solvent.Length; i++)
                        {
                            if ((DevicePar as LiquidDispensingParameter).Solvent[i].Use > 0)
                            {
                                Globa.Device.FixPump.Start(Globa.DataManager.ParameterList.LiquidDispensing.Solvent[i].ModbusId, (DevicePar as LiquidDispensingParameter).Solvent[i].Use);
                                Thread.Sleep(100);
                            }
                        }
                        for (int i = 1; i < Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid.Length; i++)
                        {
                            if ((DevicePar as LiquidDispensingParameter).TransitionFluid[i].Use > 0)
                            {
                                Globa.Device.FixPump.Start(Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid[i].ModbusId, (DevicePar as LiquidDispensingParameter).TransitionFluid[i].Use);
                                Thread.Sleep(100);
                            }
                        }
                        int ret = -1;
                        while (ret != 0)
                        {
                            ret = 0;
                            for (int i = 1; i < Globa.DataManager.ParameterList.LiquidDispensing.Solvent.Length; i++)
                            {
                                if (true)
                                {
                                    ret += Globa.Device.FixPump.GetRunStatus(Globa.DataManager.ParameterList.LiquidDispensing.Solvent[i].ModbusId);
                                    Thread.Sleep(100);
                                }
                            }
                            for (int i = 1; i < Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid.Length; i++)
                            {
                                if (true)
                                {
                                    ret += Globa.Device.FixPump.GetRunStatus(Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid[i].ModbusId);
                                    Thread.Sleep(100);
                                }
                            }
                            if (Globa.OutLine) ret = 0;
                        }
                        ProcessRoute route = MySqlDBOperationEx<ProcessRoute>.GetInfo(SN);

                        route.Route = (DevicePar as LiquidDispensingParameter).Json;
                        MySqlDBOperationEx<ProcessRoute>.UpdateInfo(route);                       
                        XStatus = Status.Working;

                        Thread.Sleep(1000);
                        Log.Info(SN + " " + Name + " Finshed", @"D:\Parameter\" + SN);
                        XStatus = Status.NeedUnload;
                    }
                }
                else if (XStatus == Status.UnloadFinshed)
                {
                    if (StationLock)
                    {
                        ResetSts();
                    }
                    else
                    {
                        ClearData();
                    }
                    XStatus = Status.Ready;
                }
                else
                {
                    ManualResetEvent.WaitOne();
                    ManualResetEvent.Reset();
                }
                Thread.Sleep(1000);
            }
        }

        protected override void Homing()
        {
            XStatus = Status.Ready;
        }
    }
}
