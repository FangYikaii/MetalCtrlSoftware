    using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DynamicData;
using MetalizationSystem.DataCollection;
using MetalizationSystem.DataServer;
using MetalizationSystem.EnumCollection;
using MetalizationSystem.ViewModels.Node;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xugz;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem
{
    /// <summary>
    /// 超声波清洗
    /// </summary>
    class Task_Robot : XTask
    {
       
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Exit()
        {
            base.Exit();
        }
        List<List<TreeWorkFlow>> WorkTask = new List<List<TreeWorkFlow>>();
        List<List<TreeWorkFlow>> WorkingTask = new List<List<TreeWorkFlow>>();
        void CreatTask()
        {
            for(int i = 0; i <= 14; i++)
            {
                XTaskManager.Instance.FindTaskById(i).XStatus = Status.Ready;
            }
            List<OrderInfo> orderlist = Globa.DataManager.CurOrderList;
            List<TreeWorkFlow> wf = new List<TreeWorkFlow>();
            
            
            for (int i = 0; i < orderlist.Count; i++) {
                wf = (List<TreeWorkFlow>)Globa.DataManager.Read(Globa.DataManager.WorkFlows, AppDomain.CurrentDomain.BaseDirectory + @"Par\WorkFlow.dat");
                for (int j = 0; j < wf.Count; j++) {
                    if (wf[j].Node.Station == "配液") {
                        ParDescribe[] parDescribes = new ParDescribe[] { };               
                        wf[j].Node.DevicePar= orderlist[i].LiquidDispensing;
                    }
                }               
                WorkTask.Add(new List<TreeWorkFlow>() { NewWorkFlow(wf, orderlist[i].SN) });
            }            
        }

        List<TreeWorkFlow> NewWorkFlow(List<TreeWorkFlow> wf,string sn)
        {
            for (int i = 0; i < wf.Count; i++) {
                wf[i].Node.Sn = sn;
                wf[i].WorkFlows = NewWorkFlow(wf[i].WorkFlows, sn);
            }
            return wf;
        }

        int delay = 100;
        void AutoRun()
        {
            List<List<TreeWorkFlow>> wt = new List<List<TreeWorkFlow>>();
            for (int i = 0; i < WorkTask.Count; i++) {             
                wt.Add(WorkTask[i]);
            }
            
            foreach (var v in wt)
            {
                TreeWorkFlow node = v.First();           
                if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus == Status.Ready)
                {
                    if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).StationLock)
                    {
                        if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN != node.Node.Sn) continue;
                    }
                    if (Globa.DataManager.LoadPallet.FristId == 0) continue; //上料架必须有料

                    List<OrderInfo> orderlist = Globa.DataManager.CurOrderList;
                    foreach (var order in orderlist)
                    {
                        for(int i=1;i< order.LiquidDispensing.Solvent.Length; i++)
                        {
                            order.LiquidDispensing.Solvent[i].Name = Globa.DataManager.ParameterList.LiquidDispensing.Solvent[i].Name;
                        }
                        for (int i = 1; i < order.LiquidDispensing.TransitionFluid.Length; i++)
                        {
                            order.LiquidDispensing.TransitionFluid[i].Name = Globa.DataManager.ParameterList.LiquidDispensing.TransitionFluid[i].Name;
                        }
                        if (order.SN == node.Node.Sn)
                        {
                            order.IsBusy = true;                          
                        }
                    }
                    Globa.DataManager.CurOrderList = orderlist;

                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN = node.Node.Sn;
                    string sn = XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN;

                    LogServer.Info(sn + " " +  "准备取料", sn);
                    UnLoad((int)EnumInfo.TaskId.GlassPallet, true, sn); //下料
                    LogServer.Info(sn + " " + "取料完成", sn);


                    ProcessRoute processRoute = new ProcessRoute() { Sn = sn, Glass = Globa.DataManager.LoadPallet.GetIsHave };
                    MySqlDBOperationEx<ProcessRoute>.AddInfo(processRoute);
                    Globa.DataManager.LoadPallet.Clear(Globa.DataManager.LoadPallet.FristId);
                    Globa.DataManager.LoadPallet = Globa.DataManager.LoadPallet;

                    string StationName = XTaskManager.Instance.FindTaskById(node.Node.TaskId).Name;
                    node.Node.IsWorking = true;            
                  
                    LogServer.Info(sn + " " + StationName + "工站准备上料", sn);

                    Load(node.Node.TaskId, true, sn); //上料
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).Key = node.Node.Key;
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).Name = node.Node.Name;
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).DevicePar = node.Node.DevicePar;

                    LogServer.Info(sn + " " + StationName + "工站上料完成", sn);
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).NeedTwoWay = node.Node.NeedTwoWay;
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).StationLock = node.Node.StationLock;
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus = Status.Start;
                    XTaskManager.Instance.FindTaskById(node.Node.TaskId).ManualResetEvent.Set();
                    WorkingTask.Add(v);
                    WorkTask.Remove(v);
                }
            }
            List<List<TreeWorkFlow>> wt1 = new List<List<TreeWorkFlow>>();
            for (int i = 0; i < WorkingTask.Count; i++)
            {
                wt1.Add(WorkingTask[i]);
            }

            foreach (var v in wt1)
            {
                TreeWorkFlow node = v.First();
                if (!node.Node.IsWorking) continue;
                if (v.Count > 1 & node.WorkFlows.Count == 0)
                {
                    TreeWorkFlow nodeNext = v[1];
                    var st1 = XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus;
                    var st2 = XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).XStatus;
                    if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus == Status.NeedUnload &
                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).XStatus == Status.Ready)
                    {
                        string s = XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).SN;
                        if (XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).StationLock)
                        {
                            if (XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).SN != XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN) continue;
                        }
                        else if (XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).SN != string.Empty && XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).SN != XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN) continue;
                        
                        if (XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).NeedTwoWay)
                        {
                            if (XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).ReadyId == node.Node.TaskId) continue;
                        }
                        string sn = XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN;
                        string StationName = XTaskManager.Instance.FindTaskById(node.Node.TaskId).Name;

                        bool needRobot = node.Node.NeedRobot & nodeNext.Node.NeedRobot;


                        LogServer.Info(sn + " " + StationName + "_Unloading", sn);
                        UnLoad(node.Node.TaskId, needRobot, sn); //下料
                        node.Node.IsWorking = false;                    
                        v.Remove(node); //完成工站后移除任务
                        Thread.Sleep(3000);
                        LogServer.Info(sn + " " + StationName + "_UnloadFinished", sn);                                           
                     
                        string StationName1 = XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).Name;
                        LogServer.Info(sn + " " + StationName1 + "_Loading", sn);
                        Load(nodeNext.Node.TaskId, needRobot, sn);
                        nodeNext.Node.IsWorking = true;
                        Thread.Sleep(3000);
                        LogServer.Info(sn + " " + StationName1 + "_LoadFinished",sn);

                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).SN = sn;
                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).StationLock = nodeNext.Node.StationLock;

                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).Key = nodeNext.Node.Key;
                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).Name = nodeNext.Node.Name;
                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).DevicePar = nodeNext.Node.DevicePar;
                    
                        
                        if (nodeNext.Node.NeedTwoWay)
                        {
                            XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).NeedTwoWay = true;
                            XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).ReadyId = node.Node.TaskId;
                        }                    
                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).XStatus = Status.Start;
                        XTaskManager.Instance.FindTaskById(nodeNext.Node.TaskId).ManualResetEvent.Set();
                        if (!nodeNext.Node.NeedRun)
                        {
                            WorkingTask.Remove(v); continue;
                        }
                    }
                }
                else if (v.Count > 1 & node.WorkFlows.Count > 0)
                {
                   
                    TreeWorkFlow nodeNext1 = v[1];
                    TreeWorkFlow nodeNext2 = node.WorkFlows.First();                  
                    if (XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).StationLock)
                    {
                        if (XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).SN != XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN) continue;
                    }
                    else if (XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).SN != string.Empty) continue;
                    if (XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).StationLock)
                    {
                        if (XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).SN != XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN) continue;
                    }
                    else if (XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).SN != string.Empty) continue;
                    if (XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).NeedTwoWay)
                    {
                        if (XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).ReadyId == node.Node.TaskId) continue;
                    }
                    if (XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).NeedTwoWay)
                    {
                        if (XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).ReadyId == node.Node.TaskId) continue;
                    }

                    var sts1 = XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus;
                    var sts2 = XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).XStatus;
                    var sts3 = XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).XStatus;
                    if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus == Status.NeedUnload &
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).XStatus == Status.Ready &
                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).XStatus == Status.Ready)
                    {
                        string sn = XTaskManager.Instance.FindTaskById(node.Node.TaskId).SN;
                        string StationName = XTaskManager.Instance.FindTaskById(node.Node.TaskId).Name;
                        bool needRobot1 = node.Node.NeedRobot & nodeNext1.Node.NeedRobot;
                        /// 移动第七轴
                        /// 下料指令
                        /// 等待动作完成  
                        LogServer.Info(sn + " " + StationName + "_Unloading",sn);
                        UnLoad(node.Node.TaskId,needRobot1, sn);
                        node.Node.IsWorking = false;
                     
                        v.Remove(node); //完成工站后移除任务
                        Thread.Sleep(delay);
                        LogServer.Info(sn + " " + StationName + "_UnloadFinished",sn);
                        /// 移动第七轴
                        /// 上料指令
                        /// 等待动作完成
                        /// 
                        string StationName1 = XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).Name;
                        LogServer.Info(sn + " " + StationName1 + "_Loading",sn);
                        Load(nodeNext1.Node.TaskId,needRobot1, sn);
                        nodeNext1.Node.IsWorking = true;
                        Thread.Sleep(delay);
                        LogServer.Info(sn + " " + StationName1 + "_LoadFinished", sn);
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).SN = sn;
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).StationLock = nodeNext1.Node.StationLock;
               

                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).Key = nodeNext1.Node.Key;
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).Name = nodeNext1.Node.Name;
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).DevicePar= nodeNext1.Node.DevicePar;
              
                        if (!nodeNext1.Node.NeedRun) { WorkingTask.Remove(v); continue; }
                        if (nodeNext1.Node.NeedTwoWay)
                        {
                            XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).NeedTwoWay = true;
                            XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).ReadyId = node.Node.TaskId;
                        }
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).XStatus = Status.Start;
                        XTaskManager.Instance.FindTaskById(nodeNext1.Node.TaskId).ManualResetEvent.Set();


                         bool needRobot2 = node.Node.NeedRobot & nodeNext2.Node.NeedRobot;
                        /// 移动第七轴
                        /// 下料指令
                        /// 等待动作完成  
                        LogServer.Info(sn + " " + StationName + "_Unloading",  sn);
                        UnLoad(node.Node.TaskId, needRobot2, sn);

                        /// 移动第七轴
                        /// 上料指令
                        /// 等待动作完成

                        string StationName2 = XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).Name;
                        LogServer.Info(sn + " " + StationName2 + "_Loading", sn);
                        Load(nodeNext2.Node.TaskId, needRobot2, sn);
                        nodeNext2.Node.IsWorking = true;
                        WorkingTask.Add(node.WorkFlows);
                        Thread.Sleep(delay);
                        LogServer.Info(sn + " " + StationName2 + "_LoadFinished", sn);
                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).SN = sn;
                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).StationLock = nodeNext2.Node.StationLock;
                

                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).Key = nodeNext2.Node.Key;
                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).Name = nodeNext2.Node.Name;
                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).DevicePar = nodeNext2.Node.DevicePar;
                     

                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).XStatus = Status.Start;
                        XTaskManager.Instance.FindTaskById(nodeNext2.Node.TaskId).ManualResetEvent.Set();
                        if (!nodeNext2.Node.NeedRun)
                        {
                            WorkingTask.Remove(v); continue;
                        }
                    }
                }
                else if (v.Count == 1 & node.WorkFlows.Count == 0)
                {
                    if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus == Status.NeedUnload)
                    {                       

                        WorkingTask.Remove(v);
                        List<OrderInfo> orderlist = new List<OrderInfo>();
                        foreach (var order in Globa.DataManager.CurOrderList)
                        {
                            orderlist.Add(order);
                        }           
                        foreach (OrderInfo order in orderlist)
                        {
                            if (order.SN == node.Node.Sn)
                            {
                                (Globa.DataManager.CurOrderList).Remove(order);
                            }
                        }                         
                        Globa.DataManager.CurOrderList = Globa.DataManager.CurOrderList;


                        XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus = Status.UnloadFinshed;                   
                        XTaskManager.Instance.FindTaskById(node.Node.TaskId).ManualResetEvent.Set();
                    }
                }
            }
        }
        void Find(List<TreeWorkFlow> trees)
        {
           
            lock (this) {
                if (trees.Count > 0)
                {
                    TreeWorkFlow node = trees.First();
                    if (node.Node.IsWorking) { 
                    
                    
                    }
                    else
                    {
                        if (XTaskManager.Instance.FindTaskById(node.Node.TaskId).XStatus == Status.Ready)
                        {
                            /// 玻璃的源头必须是料盘
                            /// 移动第七轴
                            /// 取料指令
                            /// 等待动作完成
                            node.Node.IsWorking = true;
                        }
                    }                   
                    Find(node.WorkFlows);                   
                }
            }
        }
        void Load(int taskId,bool needRobot, string sn)
        {
            LogServer.Info(sn + " " + "_Loading" + (needRobot ? "need robot" : ""),sn);
            if (needRobot)
            {
                switch ((TaskId)taskId)
                {
                    case EnumInfo.TaskId.LiquidDispensing://
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch ((TaskId)taskId)
                {
                    case EnumInfo.TaskId.GlassUltrasonicCleaner:
                        /// 移动第七轴
                        /// 取料指令
                        /// 等待动作完成
                        XTaskManager.Instance.FindTaskById(taskId).XStatus = Status.Ready;
                        break;
                    case EnumInfo.TaskId.LiquidDispensing:
                        break;
                    case EnumInfo.TaskId.GlassDegreasing:
                        /// 移动第七轴
                        /// 取料指令
                        /// 等待动作完成

                        break;
                    case EnumInfo.TaskId.GlassAcidPickling:
                        // 移动第七轴
                        /// 放料料指令
                        /// 等待动作完成  
                        break;
                    case EnumInfo.TaskId.GlassBake:

                        break;
                    case EnumInfo.TaskId.GlassCoating:
                        break;
                    case EnumInfo.TaskId.GlassEthanolCleaning:

                        break;
                    case EnumInfo.TaskId.CoatingBake:
                        break;
                    case EnumInfo.TaskId.CoatingModified:
                        break;
                    case EnumInfo.TaskId.CoatingPrepreg:
                        break;
                    case EnumInfo.TaskId.CoatingActivate:
                        break;
                    case EnumInfo.TaskId.CoatingPostImmersion:
                        break;
                    case EnumInfo.TaskId.CoatingCoppering:
                        break;
                    case EnumInfo.TaskId.CopperingBake:
                        break;
                }

                //XMachine.Instance.Card.MoveAbs((int)EnumInfo.AxisId.LinearMotor, (float)Globa.DataManager.Axis7[taskId].X);
                //Globa.Device.Roboter.Write(Robot.StationId.Source, Robot.ActionId.Get, Robot.PosId.Source, (int)Robot.StationId.Source, Globa.DataManager.UpLoad.X, Globa.DataManager.UpLoad.Y);
                XTaskManager.Instance.FindTaskById(taskId).XStatus = Status.Ready;
            }
        }
        void UnLoad(int taskId, bool needRobot,string sn)
        {
            LogServer.Info(sn + " " + "_UnLoading" + (needRobot ? "need robot" : ""),sn);
            if (needRobot)
            {                
                switch ((TaskId)taskId)
                {
                    case EnumInfo.TaskId.LiquidDispensing://
                        break;
                    default:
                        break;
                }
            }
            else
            {
                float positon = 0;
                Robot.StationId stationId = Robot.StationId.Source;
                Robot.ActionId actionId = Robot.ActionId.Get;
                Robot.PosId posId = Robot.PosId.Source;
                int x = 0, y = 0, z = 0;
                switch ((TaskId)taskId)
                {
                    case EnumInfo.TaskId.GlassPallet:
                        positon = (float)Globa.DataManager.Axis7[taskId].X;
                        stationId = Robot.StationId.Source;
                        posId = Robot.PosId.Source;
                        x = Globa.DataManager.LoadPallet.X;
                        y = Globa.DataManager.LoadPallet.Y;
                        break;
                    case EnumInfo.TaskId.GlassUltrasonicCleaner:
                        /// 移动第七轴
                        /// 取料指令
                        /// 等待动作完成
                        XTaskManager.Instance.FindTaskById(taskId).XStatus = Status.Ready;
                        break;
                    case EnumInfo.TaskId.LiquidDispensing:
                        break;
                    case EnumInfo.TaskId.GlassDegreasing:
                        /// 移动第七轴
                        /// 取料指令
                        /// 等待动作完成                      
                        break;
                    case EnumInfo.TaskId.GlassAcidPickling:
                        // 移动第七轴
                        /// 放料料指令
                        /// 等待动作完成  
                        break;
                    case EnumInfo.TaskId.GlassBake:

                        break;
                    case EnumInfo.TaskId.GlassCoating:
                        break;
                    case EnumInfo.TaskId.GlassEthanolCleaning:

                        break;
                    case EnumInfo.TaskId.CoatingBake:
                        break;
                    case EnumInfo.TaskId.CoatingModified:
                        break;
                    case EnumInfo.TaskId.CoatingPrepreg:
                        break;
                    case EnumInfo.TaskId.CoatingActivate:
                        break;
                    case EnumInfo.TaskId.CoatingPostImmersion:
                        break;
                    case EnumInfo.TaskId.CoatingCoppering:
                        break;
                    case EnumInfo.TaskId.CopperingBake:
                        break;
                }

                XMachine.Instance.Card.MoveAbs((int)EnumInfo.AxisId.LinearMotor, positon);
                //Globa.Device.Roboter.Write(stationId, actionId, posId, (int)posId, x, y);
                XTaskManager.Instance.FindTaskById(taskId).XStatus = Status.Ready;
            }
          
            //XTaskManager.Instance.FindTaskById(taskId).XStatus = Status.UnloadFinshed;
            //XTaskManager.Instance.FindTaskById(taskId).ManualResetEvent.Set();

        }
        protected override void Running(object runMode)
        {
            CreatTask();
            while (true) {
                if (IsPause) { Thread.Sleep(100);continue; }
                AutoRun();
                Thread.Sleep(100);
            }           
        }

        protected override void Homing()
        {

            XStatus = Status.Ready;
            return;
            Globa.Device.Roboter.Write(Robot.FucCoil.PowerOn);
            Thread.Sleep(100);
            Globa.Device.Roboter.Write(Robot.FucCoil.ServoOn);
            Thread.Sleep(100);
            Globa.Device.Roboter.Write(Robot.FucCoil.StopProgram);
            Thread.Sleep(100);
            Globa.Device.Roboter.Write(Robot.FucCoil.RunProgram);


            //Globa.Device.Roboter.Write(Robot.StationId.Free, Robot.ActionId.Free, Robot.PosId.None, 0);
            XStatus = Status.Ready;
        }        
    }
}