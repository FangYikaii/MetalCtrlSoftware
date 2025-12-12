global using CommunityToolkit.Mvvm.ComponentModel;
global using MetalizationSystem.ViewModels;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using MetalizationSystem.DataCollection;
using MetalizationSystem.DataServer;
using MetalizationSystem.Devices;
using MetalizationSystem.EnumCollection;
using MetalizationSystem.ViewModels.Node;
using MetalizationSystem.Views;
using MetalizationSystem.WorkFlows.AutoWorkFlow;
using MetalizationSystem.WorkFlows.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xugz;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem
{
    public class Globa
    {
        public static DataManage DataManager;
        public static SysStatus SysStatus = SysStatus.Uninitialized;
        public static bool OutLine = true;
        public static List<string> LogList = new List<string>();

        //public static RunningData GetRunningData =new RunningData();

        public class AIData
        {
            public static ParameterSet[] AIParameterSets;
            public static int AIParameterNumber;
        }

        public class Device
        {
            public static FixPump FixPump;
            public static Robot Roboter;
            public static TempCtrl TempCtrl;
            public static AirBox AirBox;
            public static LinearMotor LinearMotor;
            public static MixMotor MixMotor;
            public static DryBox DryBox;
            public static Tank Tank20;
            public static Tank Tank21;
            public static Tank Tank22;
            public static Tank Tank23;
            public static Tank Tank40;
            public static Tank Tank41;
            public static Tank Tank42;
            public static Tank Tank43;
            public static Tank Tank50;
            public static Tank Tank51;
            public static Tank Tank52;
            public static Tank Tank53;
            public static Inlet Inlet;
            public static Outlet Outlet;
            public static Scheduler Scheduler;
            public static EnumInfo.Mode Mode;
            public static Cooling Cooling;
            public static Recipe Recipe;
            public static AutoModel AutoModel;
        }
        public class Path
        {
            /// <summary>
            /// 软件名称
            /// </summary>
            public const string SystemName = "Meta";
            /// <summary>
            /// 软件版本
            /// </summary>
            public static string SystemVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            /// <summary>
            /// 硬件版本
            /// </summary>
            public const string HardwareVer = "1.0.0.0000";
            /// <summary>
            /// 参数文件夹路径
            /// </summary>
            public const string DirConfig = @"D:\Parameter\" + SystemName + @"\Config\";
            /// <summary>
            /// IO表路径
            /// </summary>
            public static string FileIOConfig = AppContext.BaseDirectory + "IO表.xlsx";
            public const string DirData = @"D:\Parameter\" + SystemName + @"\Data\";
            public const string DirResistanceData = DirData + "Resistance\\";
            public string FileResistanceData;
            public const string DirLog = @"D:\Parameter\" + SystemName + @"\Log\";
            public const string DirErrorCode = @"D:\Parameter\" + SystemName + @"\ErrorCode\"; 
            public const string DirDB = @"D:\Parameter\" + SystemName + @"\DB\";
            public const string FileErrorCode = DirErrorCode + "Statistics.xml";
            public const string FileUers = DirConfig + "Login.xml";
            public const string FileAlgoDB = DirDB + "sampleData.db";


            public string FileLog
            {
                get
                {
                    string dir = DirLog + DateTime.Now.ToString("yyyyMM") + "\\";
                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                    return dir + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                }
            }
            /// <summary>
            /// 
            /// </summary>
            public static void Create()
            {
                Log.Path = @"D:\Parameter\";
                CreateDirectory(DirConfig);
                CreateDirectory(DirData);
                CreateDirectory(DirResistanceData);
                CreateDirectory(DirLog);
                CreateDirectory(DirErrorCode);
                CreateDirectory(DirDB);
            }
            public static void CreateDirectory(string path)
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            }
        }

        public class Status
        {
            /// <summary>
            /// 卡连接状态
            /// </summary>
            public static bool CardConnected = false;        
            public static string[] IoInputName;
            public static string[] IoOutputName;
            public static string[] AxisName;
            public static bool BalanceConnected = false;
        }
        public static void InitDevice()
        {
            DataManager = new DataManage();

            DbHelper.Instance.Init();

            //Xugz.FIleOp.CsvHelper.Instance.Write<LiquidDispensingParameter>(lq, @"C:\Users\pc\Desktop\1.csv");
            //Path.Create();

            //Status.CardConnected = XMachine.Instance.Initial("192.168.0.11");

            //Device.FixPump = new FixPump(DataManager.ParameterList.LiquidDispensing.IP,DataManager.ParameterList.LiquidDispensing.Port);

            //Device.TempCtrl = new TempCtrl("192.168.10.11", 26);

            //Device.Scheduler = new Scheduler();

            //Device.LinearMotor = new LinearMotor();

            //Device.MixMotor = new MixMotor();

            //Device.Roboter = new Robot("192.168.1.10", 502);

            //Device.Inlet = new Inlet(Scheduler.StationID.Inlet);

            //Device.Outlet = new Outlet(Scheduler.StationID.Outlet);

            //Device.DryBox = new DryBox("COM1", Scheduler.StationID.DryBox);

            //Device.Cooling = new Cooling(Scheduler.StationID.Cooling);

            //Device.Recipe = new Recipe();

            //Device.AutoModel = new AutoModel();

            //Device.AirBox = new AirBox( EnumInfo.TempCtrlAddr.AirBox,
            //                            EnumInfo.TempCtrlChannel.AirBox,
            //                            EnumInfo.TempCtrlIndex.AirBox,
            //                            EnumInfo.TempCtrlSV.AirBox,
            //                            Scheduler.StationID.AirBox);

            //Device.Tank20 = new Tank(   "192.168.10.11", 
            //                            EnumInfo.MixerPort.Tank20, 
            //                            (int)EnumInfo.DoId.Tank20_ChargeEnable, 
            //                            (int)EnumInfo.DoId.Tank20_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank2X_DrainPump, 
            //                            (int)EnumInfo.DoId.Tank20_DrainValve, 
            //                            (int)EnumInfo.DiId.Tank20_LowLiquid, 
            //                            EnumInfo.TempCtrlAddr.None, 
            //                            EnumInfo.TempCtrlChannel.None, 
            //                            EnumInfo.TempCtrlIndex.None,
            //                            (int)EnumInfo.TempCtrlSV.None,
            //                            (int)EnumInfo.DoId.Tank20_BlowEnable,
            //                            Scheduler.StationID.Tank20,
            //                            1,
            //                            false,
            //                            new TimeSpan(0,0,0),
            //                            true);
            //Device.Tank21 = new Tank(   "192.168.10.11",
            //                            EnumInfo.MixerPort.Tank21,
            //                            (int)EnumInfo.DoId.Tank21_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank21_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank2X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank21_DrainValve,
            //                            (int)EnumInfo.DiId.Tank21_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.None,
            //                            EnumInfo.TempCtrlChannel.None,
            //                            EnumInfo.TempCtrlIndex.None,
            //                            (int)EnumInfo.TempCtrlSV.None,
            //                            (int)EnumInfo.DoId.Tank21_BlowEnable,
            //                            Scheduler.StationID.Tank21,
            //                            1,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            true);
            //Device.Tank22 = new Tank(   "192.168.10.11",
            //                            EnumInfo.MixerPort.Tank22,
            //                            (int)EnumInfo.DoId.Tank22_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank22_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank2X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank22_DrainValve,
            //                            (int)EnumInfo.DiId.Tank22_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.None,
            //                            EnumInfo.TempCtrlChannel.None,
            //                            EnumInfo.TempCtrlIndex.None,
            //                            (int)EnumInfo.TempCtrlSV.None,
            //                            (int)EnumInfo.DoId.Tank22_BlowEnable,
            //                            Scheduler.StationID.Tank22,
            //                            1,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            true);
            //Device.Tank23 = new Tank(   "192.168.10.11",
            //                            EnumInfo.MixerPort.Tank23,
            //                            (int)EnumInfo.DoId.Tank23_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank23_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank2X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank23_DrainValve,
            //                            (int)EnumInfo.DiId.Tank23_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank23,
            //                            EnumInfo.TempCtrlChannel.Tank23,
            //                            (int)EnumInfo.TempCtrlIndex.Tank23,
            //                            EnumInfo.TempCtrlSV.Tank23,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank23,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false);
            //Device.Tank40 = new Tank(   "192.168.10.12",
            //                            EnumInfo.MixerPort.Tank40,
            //                            (int)EnumInfo.DoId.Tank40_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank40_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank4X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank40_DrainValve,
            //                            (int)EnumInfo.DiId.Tank40_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank40,
            //                            EnumInfo.TempCtrlChannel.Tank40,
            //                            EnumInfo.TempCtrlIndex.Tank40,
            //                            EnumInfo.TempCtrlSV.Tank40,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank40,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false);
            //Device.Tank41 = new Tank(   "192.168.10.12",
            //                            EnumInfo.MixerPort.Tank41,
            //                            (int)EnumInfo.DoId.Tank41_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank41_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank4X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank41_DrainValve,
            //                            (int)EnumInfo.DiId.Tank41_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank41,
            //                            EnumInfo.TempCtrlChannel.Tank41,
            //                            EnumInfo.TempCtrlIndex.Tank41,
            //                            EnumInfo.TempCtrlSV.Tank41,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank41,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false);
            //Device.Tank42 = new Tank(   "192.168.10.12",
            //                            EnumInfo.MixerPort.Tank42,
            //                            (int)EnumInfo.DoId.Tank42_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank42_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank4X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank42_DrainValve,
            //                            (int)EnumInfo.DiId.Tank42_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank42,
            //                            EnumInfo.TempCtrlChannel.Tank42,
            //                            EnumInfo.TempCtrlIndex.Tank42,
            //                            EnumInfo.TempCtrlSV.Tank42,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank42,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false);
            //Device.Tank43 = new Tank(   "192.168.10.12",
            //                            EnumInfo.MixerPort.Tank43,
            //                            (int)EnumInfo.DoId.Tank43_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank43_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank4X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank43_DrainValve,
            //                            (int)EnumInfo.DiId.Tank43_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank43,
            //                            EnumInfo.TempCtrlChannel.Tank43,
            //                            EnumInfo.TempCtrlIndex.Tank43,
            //                            EnumInfo.TempCtrlSV.Tank43,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank43,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false);
            //Device.Tank50 = new Tank(   "192.168.10.13",
            //                            EnumInfo.MixerPort.Tank50,
            //                            (int)EnumInfo.DoId.Tank50_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank50_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank5X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank50_DrainValve,
            //                            (int)EnumInfo.DiId.Tank50_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank50,
            //                            EnumInfo.TempCtrlChannel.Tank50,
            //                            EnumInfo.TempCtrlIndex.Tank50,
            //                            EnumInfo.TempCtrlSV.Tank50,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank50,
            //                            0,
            //                            true,
            //                            new TimeSpan(0, 50, 0),
            //                            true); // 流程开始到50槽，需要70分钟，预留20分钟加热时间
            //Device.Tank51 = new Tank(   "192.168.10.13",
            //                            EnumInfo.MixerPort.Tank51,
            //                            (int)EnumInfo.DoId.Tank51_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank51_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank5X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank51_DrainValve,
            //                            (int)EnumInfo.DiId.Tank51_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank51,
            //                            EnumInfo.TempCtrlChannel.Tank51,
            //                            EnumInfo.TempCtrlIndex.Tank51,
            //                            EnumInfo.TempCtrlSV.Tank51,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank51,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false);
            //Device.Tank52 = new Tank(   "192.168.10.13",
            //                            EnumInfo.MixerPort.Tank52,
            //                            (int)EnumInfo.DoId.Tank52_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank52_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank5X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank52_DrainValve,
            //                            (int)EnumInfo.DiId.Tank52_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank52,
            //                            EnumInfo.TempCtrlChannel.Tank52,
            //                            EnumInfo.TempCtrlIndex.Tank52,
            //                            EnumInfo.TempCtrlSV.Tank52,
            //                            (int)EnumInfo.DoId.Tank52_BlowEnable,
            //                            Scheduler.StationID.Tank52,
            //                            5,
            //                            true,
            //                            new TimeSpan(0, 60, 0),
            //                            true); // 流程开始到52槽，需要80分钟，预留20分钟加热时间
            //Device.Tank53 = new Tank(   "192.168.10.13",
            //                            EnumInfo.MixerPort.Tank53,
            //                            (int)EnumInfo.DoId.Tank53_ChargeEnable,
            //                            (int)EnumInfo.DoId.Tank53_ChargeTimeout,
            //                            (int)EnumInfo.DoId.Tank5X_DrainPump,
            //                            (int)EnumInfo.DoId.Tank53_DrainValve,
            //                            (int)EnumInfo.DiId.Tank53_LowLiquid,
            //                            EnumInfo.TempCtrlAddr.Tank53,
            //                            EnumInfo.TempCtrlChannel.Tank53,
            //                            EnumInfo.TempCtrlIndex.Tank53,
            //                            EnumInfo.TempCtrlSV.Tank53,
            //                            (int)EnumInfo.DoId.Null,
            //                            Scheduler.StationID.Tank53,
            //                            0,
            //                            false,
            //                            new TimeSpan(0, 0, 0),
            //                            false); // 流程开始到53槽，需要80分钟，预留20分钟加热时间



            

            
            

            //for(int i= 1; i < 16; i++)
            //{
            //    Device.ReactionTanks[i] = new ReactionTank(DataManager.ParameterList.ReactionTanks[i].ChargingIo, DataManager.ParameterList.ReactionTanks[i].DrainageIo, DataManager.ParameterList.ReactionTanks[i].SolenoidValveIo
            //        , DataManager.ParameterList.ReactionTanks[i].HeatingIo, DataManager.ParameterList.ReactionTanks[i].LiquidLevelIo, DataManager.ParameterList.ReactionTanks[i].TemperatureId, DataManager.ParameterList.ReactionTanks[i].IP, DataManager.ParameterList.ReactionTanks[i].Port);
            //}


            //#region  配置Di 
            //for (int i = 0; i < 16; i++)
            //{
            //    //XDevice.Instance.BindDi((int)CardId.Srnd_Io1, i, i < 8 ? 0 : 1, i, ((DiId)i).ToString(), CardId.Srnd_Io1.ToString());
            //    //XDevice.Instance.BindDi((int)CardId.Srnd_Io2, i + 16, i < 8 ? 0 : 1, i, ((DiId)(i+16)).ToString(), CardId.Srnd_Io2.ToString());
            //}

            //#endregion

            //#region  配置Do  
            //for (int i = 0; i < 16; i++)
            //{
            //    //XDevice.Instance.BindDo((int)CardId.Srnd_Io1, i, i < 8 ? 0 : 1, i, ((DoId)i).ToString(), CardId.Srnd_Io1.ToString());
            //    //XDevice.Instance.BindDo((int)CardId.Srnd_Io2, i + 16, i < 8 ? 0 : 1, i, ((DiId)(i + 16)).ToString(), CardId.Srnd_Io2.ToString());
            //}
            ////XDevice.Instance.BindDo((int)CardId.Srnd_Io1, (int)DoId.RedLight, 0, 0, DoId.RedLight.ToString(), CardId.Srnd_Io1.ToString());
            //#endregion
            //#region 配置任务

            //XTaskManager.Instance.BindTask((int)TaskId.CoatingActivate, new Task_CoatingActivate(), ((TaskIdCN)TaskId.CoatingActivate).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.CoatingBake, new Task_CoatingBake(), ((TaskIdCN)TaskId.CoatingBake).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.CoatingCoppering, new Task_CoatingCoppering(), ((TaskIdCN)TaskId.CoatingCoppering).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.CoatingModified, new Task_CoatingModified(), ((TaskIdCN)TaskId.CoatingModified).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.CoatingPostImmersion, new Task_CoatingPostImmersion(), ((TaskIdCN)TaskId.CoatingPostImmersion).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.CoatingPrepreg, new Task_CoatingPrepreg(), ((TaskIdCN)TaskId.CoatingPrepreg).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.CopperingBake, new Task_CopperingBake(), ((TaskIdCN)TaskId.CopperingBake).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.GlassAcidPickling, new Task_GlassAcidPickling(), ((TaskIdCN)TaskId.GlassAcidPickling).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.GlassBake, new Task_GlassBake(), ((TaskIdCN)TaskId.GlassBake).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.GlassCoating, new Task_GlassCoating(), ((TaskIdCN)TaskId.GlassCoating).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.GlassDegreasing, new Task_GlassDegreasing(), ((TaskIdCN)TaskId.GlassDegreasing).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.GlassEthanolCleaning, new Task_GlassEthanolCleaning(), ((TaskIdCN)TaskId.GlassEthanolCleaning).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.GlassUltrasonicCleaner, new Task_GlassUltrasonicCleaner(), ((TaskIdCN)TaskId.GlassUltrasonicCleaner).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.LiquidDispensing, new Task_LiquidDispensing(), ((TaskIdCN)TaskId.LiquidDispensing).ToString());
            //XTaskManager.Instance.BindTask((int)TaskId.Robot, new Task_Robot(), ((TaskIdCN)TaskId.Robot).ToString());



            


            //#endregion
            //#region 配置工站

            //////XController.Instance.StationID = -1;
            //////for (int i = 0; i < EnumInfo.StationIdTotal; i++) {
            //////    XStationManager.Instance.BindStation(i, ((StationId)i).ToString());

            //////    //分配任务
            //////    XStationManager.Instance.FindStationById(i).BindTask(i);
            //////}

            //#endregion







            ////if (Status.IoCardSConnected) XController.Instance.Start();
            ////XMachine.Instance.Start();
        }
    }
}
