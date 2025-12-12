using MetalizationSystem.DataCollection;
using MetalizationSystem.EnumCollection;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xugz;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem
{
    /// <summary>玻璃烘干</summary>
    class Task_GlassBake : XTask 
    {      
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Exit()
        {
        
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
