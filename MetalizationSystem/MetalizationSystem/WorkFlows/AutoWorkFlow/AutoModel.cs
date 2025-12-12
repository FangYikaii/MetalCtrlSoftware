using CommunityToolkit.Mvvm.Input;
using DocumentFormat.OpenXml.ExtendedProperties;
using MetalizationSystem.Devices;
using MetalizationSystem.Views;
using MetalizationSystem.WorkFlows.Recipe;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MetalizationSystem.WorkFlows.AutoWorkFlow
{
    public partial class AutoModel
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private Task? _motionTask;
        public int ComboxSelectedIndex;
        /// <summary>
        /// 运动开始事件
        /// </summary>
        public event EventHandler? MotionStarted;

        /// <summary>
        /// 运动停止事件
        /// </summary>
        public event EventHandler? MotionStopped;

        public bool IsTankReady
        {
            get
            {
                return (Globa.Device.Tank20.IsReady && Globa.Device.Tank21.IsReady &&
                        Globa.Device.Tank22.IsReady && Globa.Device.Tank23.IsReady &&
                        Globa.Device.Tank40.IsReady &&
                        Globa.Device.Tank42.IsReady && Globa.Device.Tank43.IsReady &&
                        Globa.Device.Tank50.IsReady && Globa.Device.Tank51.IsReady &&
                        Globa.Device.AirBox.IsReady);
            }
        }

        public bool IsInternalRecipe { get; set; } = true;

        public AutoModel()
        {
            LoadRecipe();
        }

        /// <summary>
        /// 开始
        /// </summary>
        public void Start()
        {
            // 复位
            Home();
            // 执行配方
            ExecuteRecipe();
            // 镀槽启动
            Globa.Device.Tank52.Start();
            TankStart();
            // 镀槽：状态检测,液位和温度条件满足后进入下一步
            while (!IsTankReady)
            {
                Thread.Sleep(1000);
            }
            // 流程：启动
            ProcessStart();
            // 镀槽停止
            TankStop();
            MessageBox.Show("自动流程结束");
        }

        /// <summary>
        /// 暂停
        /// </summary>
        private void AutoPause()
        {
            MessageBox.Show("AutoPause!");
        }

        /// <summary>
        /// 停止
        /// </summary>
        private void AutoStop()
        {
            MessageBox.Show("AutoStop!");
        }

        /// <summary>
        /// 回原点
        /// </summary>
        public void Home()
        {
            // 机器人：上电
            if (Globa.Device.Roboter.NoPower)
            {
                Globa.Device.Roboter.Write(Robot.FucCoil.PowerOn);
                while (Globa.Device.Roboter.NoPower)
                {
                    Thread.Sleep(100);
                }
            }
            // 机器人：使能
            if (Globa.Device.Roboter.NoAble)
            {
                Globa.Device.Roboter.Write(Robot.FucCoil.ServoOn);
                while (Globa.Device.Roboter.NoAble)
                {
                    Thread.Sleep(100);
                }
            }
            // 机器人：运行程序
            Globa.Device.Roboter.Write(Robot.FucCoil.RunProgram);
            // 机器人：回零
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Free, (int)Robot.PosId.Home);
            // 机器人：等待回零完成
            Thread.Sleep(100);
            while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
            {
                Thread.Sleep(100);
            }
            // 直线电机：检测是否需要执行回零
            //if (!Globa.Device.LinearMotor.GetHomeStatus())
            //{
            // 直线电机：回零
            Globa.Device.LinearMotor.Home();
            // 直线电机：等待回零完成
            while (!Globa.Device.LinearMotor.GetHomeStatus())
            {
                Thread.Sleep(100);
            }
            //}
            Globa.Device.Inlet.Initial();
            Globa.Device.Tank20.Initial();
            Globa.Device.Tank21.Initial();
            Globa.Device.Tank22.Initial();
            Globa.Device.Tank23.Initial();
            Globa.Device.Tank40.Initial();
            Globa.Device.Tank41.Initial();
            Globa.Device.Tank42.Initial();
            Globa.Device.Tank43.Initial();
            Globa.Device.Tank50.Initial();
            Globa.Device.Tank51.Initial();
            Globa.Device.Tank52.Initial();
            Globa.Device.Tank53.Initial();
            Globa.Device.AirBox.Initial();
            Globa.Device.DryBox.Initial();
            Globa.Device.Outlet.Initial();
        }

        /// <summary>
        /// 加载配方
        /// </summary>
        public void LoadRecipe()
        {
            // 选择配方
            int count = 0;
            ParameterSet[] _parameterSets = new ParameterSet[6];
            _parameterSets[0] = new ParameterSet(20, new TimeSpan(0, 0, 10), 7);
            _parameterSets[1] = new ParameterSet(11, new TimeSpan(0, 0, 20), 7);
            _parameterSets[2] = new ParameterSet(12, new TimeSpan(0, 0, 30), 7);
            _parameterSets[3] = new ParameterSet(13, new TimeSpan(0, 0, 40), 7);
            _parameterSets[4] = new ParameterSet(14, new TimeSpan(0, 0, 50), 7);
            _parameterSets[5] = new ParameterSet(15, new TimeSpan(0, 0, 60), 7);
            if (ComboxSelectedIndex == 0)
            {
                IsInternalRecipe = true;
                // 内部配方
                Globa.Device.Recipe.ParameterSets = _parameterSets;
            }
            else
            {
                IsInternalRecipe = false;
                count = Globa.AIData.AIParameterNumber;
                if (count == 0)
                {
                    MessageBox.Show("未读取到外部配方，请检查AI连接状态及配置");
                    return;
                }
                // 外部配方,读取AI生成的配方
                Globa.Device.Recipe.ParameterSets = Globa.AIData.AIParameterSets;  //调试禁用1107
            }
        }

        /// <summary>
        /// 配方：执行配方
        /// </summary>
        public void ExecuteRecipe()
        {
            Globa.Device.Tank40.SetSV((int)(Globa.Device.Recipe.CurrentParameterSet.Temperature * 10));
        }

        /// <summary>
        /// 镀槽启动
        /// </summary>
        public void TankStart()
        {
            Globa.Device.Inlet.Start();
            Globa.Device.Tank21.Start();
            Globa.Device.Tank22.Start();
            //Globa.Device.Tank23.Start();
            Globa.Device.Tank40.Start();
            Globa.Device.Tank42.Start();
            Globa.Device.Tank43.Start();
            Globa.Device.Tank51.Start();
            Globa.Device.DryBox.Start();
            Globa.Device.Outlet.Start();
            //如果是外部配方，执行配方
            if (!IsInternalRecipe)
            {
                ExecuteRecipe();
            }
            MessageBox.Show("镀槽启动完成!");

            //Globa.Device.Tank20.Start(); // 20250916液位传感器损坏，禁用20槽
            //Globa.Device.Tank41.Start(); // 工艺中无41槽
            //Globa.Device.Tank50.Start();// 50槽延迟启动
            //Globa.Device.Tank52.Start(); // 52槽延迟启动
            //Globa.Device.Tank53.Start(); // 工艺中无53槽
            //Globa.Device.AirBox.Start(); // 工艺中无烘干


        }

        /// <summary>
        /// 镀槽停止
        /// </summary>
        public void TankStop()
        {
            Globa.Device.Inlet.Stop();
            Globa.Device.Tank20.Stop();
            Globa.Device.Tank21.Stop();
            Globa.Device.Tank22.Stop();
            Globa.Device.Tank23.Stop();
            Globa.Device.Tank40.Stop();
            Globa.Device.Tank41.Stop();
            Globa.Device.Tank42.Stop();
            Globa.Device.Tank43.Stop();
            Globa.Device.Tank50.Stop();
            Globa.Device.Tank51.Stop();
            Globa.Device.Tank52.Stop();
            Globa.Device.Tank53.Stop();
            Globa.Device.AirBox.Stop();
            Globa.Device.DryBox.Stop();
            Globa.Device.Outlet.Stop();
            MessageBox.Show("镀槽停止完成!");
        }

        /// <summary>
        /// 镀槽开启排液
        /// </summary>
        public void TankStartDrain()
        {
            Globa.Device.Tank20.StartDrain();
            Globa.Device.Tank21.StartDrain();
            Globa.Device.Tank22.StartDrain();
            Globa.Device.Tank23.StartDrain();
            Globa.Device.Tank40.StartDrain();
            Globa.Device.Tank41.StartDrain();
            Globa.Device.Tank42.StartDrain();
            Globa.Device.Tank43.StartDrain();
            Globa.Device.Tank50.StartDrain();
            Globa.Device.Tank51.StartDrain();
            Globa.Device.Tank52.StartDrain();
            Globa.Device.Tank53.StartDrain();
        }

        /// <summary>
        /// 镀槽停止排液
        /// </summary>
        public void TankStopDrain()
        {
            Globa.Device.Tank20.StopDrain();
            Globa.Device.Tank21.StopDrain();
            Globa.Device.Tank22.StopDrain();
            Globa.Device.Tank23.StopDrain();
            Globa.Device.Tank40.StopDrain();
            Globa.Device.Tank41.StopDrain();
            Globa.Device.Tank42.StopDrain();
            Globa.Device.Tank43.StopDrain();
            Globa.Device.Tank50.StopDrain();
            Globa.Device.Tank51.StopDrain();
            Globa.Device.Tank52.StopDrain();
            Globa.Device.Tank53.StopDrain();
        }

        /// <summary>
        /// 流程启动
        /// </summary>
        public void ProcessStart()
        {
            //初始化
            Globa.Device.Inlet.Initial();
            Globa.Device.Outlet.Initial();
            Globa.Device.Scheduler.Initial();
            //如果是外部配方，执行配方
            if (!IsInternalRecipe)
            {
                ExecuteRecipe();
            }
            // 50槽延迟启动
            Globa.Device.Tank50.Start();
            // 52槽延迟启动
            Globa.Device.Tank52.Start();
            //机器人：运行程序
            Globa.Device.Roboter.Write(Robot.FucCoil.RunProgram);
            //机器人：回零
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Free, (int)Robot.PosId.Home);
            while (true)
            {
                //调度：计算取料和放料工位
                var (IsDone, StationOut, StationIn) = Globa.Device.Scheduler.GetStatus();
                if (IsDone)
                {
                    MessageBox.Show("流程结束!");
                    return;
                }
                if (StationOut == -1 || StationIn == -1 || StationOut == StationIn)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                //调度：读取工位位置
                int StationOutPosNo = Globa.Device.Scheduler.GetStationOutPosNo((Scheduler.StationID)StationOut);
                int StationInPosNo = Globa.Device.Scheduler.GetStationInPosNo((Scheduler.StationID)StationIn);
                if (StationOutPosNo == -1 || StationInPosNo == -1)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                //调度：将工位位置转换为机器人坐标
                var (OutPosID, OutPalletX, OutPalletY, OutPalletZ) = Globa.Device.Scheduler.GetRobotCoord((Scheduler.StationID)StationOut, StationOutPosNo);
                var (InPosID, InPalletX, InPalletY, InPalletZ) = Globa.Device.Scheduler.GetRobotCoord((Scheduler.StationID)StationIn, StationInPosNo);
                if (OutPosID == -1 || OutPalletX == -1 || OutPalletY == -1 || OutPalletZ == -1 || InPosID == -1 || InPalletX == -1 || InPalletY == -1 || InPalletZ == -1)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                //机器人：是否在原点
                while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
                {
                    Thread.Sleep(100);
                }
                //直线电机：运动到取料位置
                Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos((Scheduler.StationID)StationOut));
                //直线电机：等待运动完成
                Thread.Sleep(500);
                while (Globa.Device.LinearMotor.GetRunStatus())
                {
                    Thread.Sleep(100);
                }
                //若取料位置为干燥箱，需要打开箱门
                if (StationOut == (int)Scheduler.StationID.DryBox)
                {
                    //干燥箱：开门标识复位
                    Globa.Device.DryBox.DoorOpened = false;
                    //干燥箱：开门
                    Globa.Device.DryBox.OpenDoor();
                    //干燥箱：等待开门完成
                    while (!Globa.Device.DryBox.DoorOpened)
                    {
                        Thread.Sleep(100);
                    }
                }
                //机器人：取料
                while (true)
                {
                    if (Globa.Device.Roboter.Home & Globa.Device.Roboter.GetHomeRelayStatus())
                    {
                        Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Get, OutPosID, OutPalletX, OutPalletY, OutPalletZ);
                        break;
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                //机器人：等待取料完成
                Thread.Sleep(500);
                while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
                {
                    Thread.Sleep(100);
                }
                //调度程序：取料后更新标识位
                Globa.Device.Scheduler.UpdateWhenStationOut();
                //复位工艺准备
                Globa.Device.Scheduler.ResetProcessPreparation((Scheduler.StationID)StationOut);
                //若取料位置是干燥箱，需要关闭箱门
                if (StationOut == (int)Scheduler.StationID.DryBox)
                {
                    //干燥箱：关门标识复位
                    Globa.Device.DryBox.DoorClosed = false;
                    //干燥箱：关门
                    Globa.Device.DryBox.CloseDoor();
                    //干燥箱：等待关门完成
                    while (!Globa.Device.DryBox.DoorClosed)
                    {
                        Thread.Sleep(100);
                    }
                    //扶正物料
                    Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, (int)Robot.PosId.Modify);
                }
                // 使用外部配方且取料工位是40槽，弹窗提示换液
                if (!Globa.Device.AutoModel.IsInternalRecipe && StationOut == (int)Scheduler.StationID.Tank40)
                {
                    ShowTank40PromptWindow();
                    //Thread thread = new Thread(ShowTank40PromptWindow);
                    Globa.Device.Recipe.Index++;
                    ExecuteRecipe();
                }
                // 若取料工位是水洗槽或者乙醇洗槽，提示手动吹干
                if (StationOut == (int) Scheduler.StationID.Tank20 || StationOut == (int)Scheduler.StationID.Tank21 || StationOut == (int)Scheduler.StationID.Tank22)
                {
                    MessageBox.Show("请手动吹干玻璃");
                }
                //直线电机：运动到放料位置
                Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos((Scheduler.StationID)StationIn));
                //直线电机：等待运动完成
                Thread.Sleep(500);
                while (Globa.Device.LinearMotor.GetRunStatus())
                {
                    Thread.Sleep(100);
                }
                //工艺：准备
                Globa.Device.Scheduler.ProcessPreparation((Scheduler.StationID)StationIn);
                //若放料位置为干燥箱，需要打开箱门
                if (StationIn == (int)Scheduler.StationID.DryBox)
                {
                    //扶正物料
                    Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, (int)Robot.PosId.Modify);
                    //弹窗提示晃动玻璃
                    MessageBox.Show("请晃动玻璃");
                    //干燥箱：开门标识复位
                    Globa.Device.DryBox.DoorOpened = false;
                    //干燥箱：开门
                    Globa.Device.DryBox.OpenDoor();
                    //干燥箱：等待开门完成
                    while (!Globa.Device.DryBox.DoorOpened)
                    {
                        Thread.Sleep(100);
                    }
                }
                //机器人：放料
                while (true)
                {
                    if (Globa.Device.Roboter.Home & Globa.Device.Roboter.GetHomeRelayStatus())
                    {
                        Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, InPosID, InPalletX, InPalletY, InPalletZ);
                        break;
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                //机器人：等待放料完成
                Thread.Sleep(500);
                while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
                {
                    Thread.Sleep(100);
                }
                //工艺开始
                Globa.Device.Scheduler.ProcessStart((Scheduler.StationID)StationIn);
                //调度程序：放料后更新标识位
                Globa.Device.Scheduler.UpdateWhenStationIn();
                //若放料位置为干燥箱，需要关闭箱门
                if (StationIn == (int)Scheduler.StationID.DryBox)
                {
                    //干燥箱：关门标识复位
                    Globa.Device.DryBox.DoorClosed = false;
                    //干燥箱：关门
                    Globa.Device.DryBox.CloseDoor();
                    //干燥箱：等待关门完成
                    while (!Globa.Device.DryBox.DoorClosed)
                    {
                        Thread.Sleep(100);
                    }
                }
            }
        }

        /// <summary>
        /// 流程停止
        /// </summary>
        public void ProcessStop()
        {

        }

        /// <summary>
        /// 40槽换液提示弹窗
        /// </summary>
        static void ShowTank40PromptWindow()
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                var tank40PormptViewModel = new Tank40PromptViewModel();
                var tank40PromptWindow = new Tank40Prompt(tank40PormptViewModel);
                tank40PormptViewModel.RequestClose += (s, e) => tank40PromptWindow.Close();
                tank40PromptWindow.Show();
            });
        }

        /// <summary>
        /// 调试备用代码
        /// </summary>
        private void Debug()
        {
            goto Debug;
            Globa.Device.Tank52.StopMix();
            Globa.Device.Tank52.StopTempCtrl();
            //定量泵1(OK)
            Globa.Device.FixPump.Start(1, 10);
            Globa.Device.FixPump.Stop(1);
            //定量泵2(OK)
            Globa.Device.FixPump.Start(2, 10);
            Globa.Device.FixPump.Stop(2);
            //定量泵3(OK)
            Globa.Device.FixPump.Start(3, 10);
            Globa.Device.FixPump.Stop(3);
            //定量泵4(OK)
            Globa.Device.FixPump.Start(4, 10);
            Globa.Device.FixPump.Stop(4);
            //定量泵5(OK)
            Globa.Device.FixPump.Start(5, 10);
            Globa.Device.FixPump.Stop(5);
            //定量泵：读取运行状态（BUG）
            while (Globa.Device.FixPump.GetRunStatus(1) == 1)
            {
                Thread.Sleep(100);
            }
            return;

            //搅拌电机(OK)
            Globa.Device.MixMotor.Start();
            Globa.Device.MixMotor.Stop();
            return;

            //Tank20(OK)
            Globa.Device.Tank20.StartMix();
            Globa.Device.Tank20.StartCharge();
            Globa.Device.Tank20.StopCharge();
            Globa.Device.Tank20.StartBlow();
            Globa.Device.Tank20.StopBlow();
            Globa.Device.Tank20.StartDrain();
            Globa.Device.Tank20.StopDrain();
            Globa.Device.Tank20.StopMix();
            return;

            //Tank21(OK)
            Globa.Device.Tank21.StartMix();
            Globa.Device.Tank21.StartCharge();
            Globa.Device.Tank21.StopCharge();
            Globa.Device.Tank21.StartBlow();
            Globa.Device.Tank21.StopBlow();
            Globa.Device.Tank21.StartDrain();
            Globa.Device.Tank21.StopDrain();
            Globa.Device.Tank21.StopMix();
            return;

            //Tank22(OK，排液用时约70s)
            Globa.Device.Tank22.StartMix();
            Globa.Device.Tank22.StartCharge();
            Globa.Device.Tank22.StopCharge();
            Globa.Device.Tank22.StartBlow();
            Globa.Device.Tank22.StopBlow();
            Globa.Device.Tank22.StartDrain();
            Globa.Device.Tank22.StopDrain();
            Globa.Device.Tank22.StopMix();
            return;

            //Tank23(温控仪指令待观察)
            Globa.Device.Tank23.StartMix();
            Globa.Device.Tank23.StartCharge();
            Globa.Device.Tank23.StopCharge();
            Globa.Device.Tank23.SetSV();
            Globa.Device.Tank23.StartTempCtrl();
            Globa.Device.Tank23.StopTempCtrl();
            Globa.Device.Tank23.StartDrain();
            Globa.Device.Tank23.StopDrain();
            Globa.Device.Tank23.StopMix();
            return;

            //Tank40(加热通讯有问题，之后测试OK)
            Globa.Device.Tank40.StartMix();
            Globa.Device.Tank40.StartCharge();
            Globa.Device.Tank40.StopCharge();
            Globa.Device.Tank40.SetSV();
            Globa.Device.Tank40.StartTempCtrl();
            Globa.Device.Tank40.StopTempCtrl();
            Globa.Device.Tank40.StartDrain();
            Globa.Device.Tank40.StopDrain();
            Globa.Device.Tank40.StopMix();
            return;

            //Tank41(OK)
            Globa.Device.Tank41.StartMix();
            Globa.Device.Tank41.StartCharge();
            Globa.Device.Tank41.StopCharge();
            Globa.Device.Tank41.SetSV();
            Globa.Device.Tank41.StartTempCtrl();
            Globa.Device.Tank41.StopTempCtrl();
            Globa.Device.Tank41.StartDrain();
            Globa.Device.Tank41.StopDrain();
            Globa.Device.Tank41.StopMix();
            return;

            //Tank42(OK)
            Globa.Device.Tank42.StartMix();
            Globa.Device.Tank42.StartCharge();
            Globa.Device.Tank42.StopCharge();
            Globa.Device.Tank42.SetSV();
            Globa.Device.Tank42.StartTempCtrl();
            Globa.Device.Tank42.StopTempCtrl();
            Globa.Device.Tank42.StartDrain();
            Globa.Device.Tank42.StopDrain();
            Globa.Device.Tank42.StopMix();
            return;

            //Tank43(OK)
            Globa.Device.Tank43.StartMix();
            Globa.Device.Tank43.StartCharge();
            Globa.Device.Tank43.StopCharge();
            Globa.Device.Tank43.SetSV();
            Globa.Device.Tank43.StartTempCtrl();
            Globa.Device.Tank43.StopTempCtrl();
            Globa.Device.Tank43.StartDrain();
            Globa.Device.Tank43.StopDrain();
            Globa.Device.Tank43.StopMix();
            return;

            //Tank50(OK)
            Globa.Device.Tank50.StartMix();
            Globa.Device.Tank50.StartCharge();
            Globa.Device.Tank50.StopCharge();
            Globa.Device.Tank50.SetSV();
            Globa.Device.Tank50.StartTempCtrl();
            Globa.Device.Tank50.StopTempCtrl();
            Globa.Device.Tank50.StartDrain();
            Globa.Device.Tank50.StopDrain();
            Globa.Device.Tank50.StopMix();
            return;

            //Tank51(OK)
            Globa.Device.Tank51.StartMix();
            Globa.Device.Tank51.StartCharge();
            Globa.Device.Tank51.StopCharge();
            Globa.Device.Tank51.SetSV();
            Globa.Device.Tank51.StartTempCtrl();
            Globa.Device.Tank51.StopTempCtrl();
            Globa.Device.Tank51.StartDrain();
            Globa.Device.Tank51.StopDrain();
            Globa.Device.Tank51.StopMix();
            return;

            //Tank52(OK)
            Globa.Device.Tank52.StartMix();
            Globa.Device.Tank52.StartCharge();
            Globa.Device.Tank52.StopCharge();
            Globa.Device.Tank52.SetSV();
            Globa.Device.Tank52.StartTempCtrl();
            Globa.Device.Tank52.StopTempCtrl();
            Globa.Device.Tank52.StartDrain();
            Globa.Device.Tank52.StopDrain();
            Globa.Device.Tank52.StopMix();
            return;

            //Tank53(OK)
            Globa.Device.Tank53.StartMix();
            Globa.Device.Tank53.StartCharge();
            Globa.Device.Tank53.StopCharge();
            Globa.Device.Tank53.SetSV();
            Globa.Device.Tank53.StartTempCtrl();
            Globa.Device.Tank53.StopTempCtrl();
            Globa.Device.Tank53.StartDrain();
            Globa.Device.Tank53.StopDrain();
            Globa.Device.Tank53.StopMix();
            return;

            //AirBox(OK)
            Globa.Device.AirBox.SetSV();
            Globa.Device.AirBox.Start();
            Globa.Device.AirBox.Stop();
            return;

            //直线电机(OK)
            //直线电机：回零
            Globa.Device.LinearMotor.Home();
            //直线电机：等待回零完成
            while (!Globa.Device.LinearMotor.GetHomeStatus())
            {
                Thread.Sleep(100);
            }
            Thread.Sleep(500);
            //直线电机：绝对运动
            Globa.Device.LinearMotor.MoveAbs(500);
            //直线电机：绝对运动
            Globa.Device.LinearMotor.MoveAbs(500);
            //直线电机：等待运动完成
            Thread.Sleep(500);
            while (Globa.Device.LinearMotor.GetRunStatus())
            {
                Thread.Sleep(100);
            }
            //直线电机：停止运动
            Globa.Device.LinearMotor.Stop();
            //直线电机：运动至进料位置
            Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.Inlet));
            //直线电机：等待运动完成
            Thread.Sleep(500);
            while (Globa.Device.LinearMotor.GetRunStatus())
            {
                Thread.Sleep(100);
            }
            //直线电机：运动至出料位置
            Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.Outlet));
            //直线电机：等待运动完成
            Thread.Sleep(500);
            while (Globa.Device.LinearMotor.GetRunStatus())
            {
                Thread.Sleep(100);
            }
            return;

            //干燥箱(OK)
            //干燥箱：开门标识复位
            Globa.Device.DryBox.DoorOpened = false;
            //干燥箱：开门
            Globa.Device.DryBox.OpenDoor();
            //干燥箱：等待开门完成
            while (!Globa.Device.DryBox.DoorOpened)
            {
                Thread.Sleep(100);
            }
            //干燥箱：关门标识复位
            Globa.Device.DryBox.DoorClosed = false;
            //干燥箱：关门
            Globa.Device.DryBox.CloseDoor();
            //干燥箱：等待关门完成
            while (!Globa.Device.DryBox.DoorClosed)
            {
                Thread.Sleep(100);
            }
            return;
        Debug:
            //Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.DryBox));
            //原点
            //Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Free, (int)Robot.PosId.Home);
            //机器人：运行程序
            Globa.Device.Roboter.Write(Robot.FucCoil.RunProgram);
            //机器人：回零
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Free, (int)Robot.PosId.Home);
            //放料
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, (int)Robot.PosId.DryBox, 0, 0, 0);

            //取料
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Get, (int)Robot.PosId.DryBox, 0, 0, 0);
            return;
            //取料
            Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.Inlet));
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Get, (int)Robot.PosId.Inlet0, 0, 0, 0);

            //放料
            Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.Tank50));
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, (int)Robot.PosId.Tank50, 0, 0, 0);

            //取料
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Get, (int)Robot.PosId.Tank23, 0, 0, 0);
            //放料
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, (int)Robot.PosId.Tank22, 0, 0, 0);

            //机器人
            //机器人：运行程序
            Globa.Device.Roboter.Write(Robot.FucCoil.RunProgram);
            //Globa.Device.Roboter.RobotAction(0, 0, 0);
            //机器人：回零
            Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Free, (int)Robot.PosId.Home);
            //机器人：等待回零完成
            Thread.Sleep(500);
            while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
            {
                Thread.Sleep(100);
            }
            //直线电机：运动至取料位置
            Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.Inlet));
            //直线电机：等待运动完成
            Thread.Sleep(500);
            while (Globa.Device.LinearMotor.GetRunStatus())
            {
                Thread.Sleep(100);
            }
            //机器人：取料
            while (true)
            {
                if (Globa.Device.Roboter.Home & Globa.Device.Roboter.GetHomeRelayStatus())
                {
                    Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Get, (int)Robot.PosId.Inlet0);
                    break;
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
            //机器人：等待取料完成
            Thread.Sleep(500);
            while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
            {
                Thread.Sleep(100);
            }
            //直线电机：移动至放料位置
            Globa.Device.LinearMotor.MoveAbs(Globa.Device.Scheduler.GetLinearMotorAbsPos(Scheduler.StationID.Outlet));
            Thread.Sleep(500);
            while (Globa.Device.LinearMotor.GetRunStatus())
            {
                Thread.Sleep(100);
            }
            //机器人：放料
            while (true)
            {
                if (Globa.Device.Roboter.Home & Globa.Device.Roboter.GetHomeRelayStatus())
                {
                    Globa.Device.Roboter.RobotAction(Robot.ModeId.Auto, Robot.ActionId.Put, (int)Robot.PosId.Outlet0, 0, 0, 0);
                    break;
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
            //机器人：等待放料完成
            Thread.Sleep(500);
            while (!Globa.Device.Roboter.Home || !Globa.Device.Roboter.GetHomeRelayStatus())
            {
                Thread.Sleep(100);
            }
            return;

        }
    }
}
