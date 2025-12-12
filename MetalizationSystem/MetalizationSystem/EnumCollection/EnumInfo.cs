using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.EnumCollection
{
    public class EnumInfo
    {
        public static int StationIdTotal = 2;
        public static int DoIdTotal = 16;
        public static int DiIdTotal = 16;
        public static int Axis7PosTotal = 16;

        /// <summary>
        /// Mode: Debug Home MixFluid AutoPrepare Auto Drain Stop
        /// </summary>
        public enum Mode
        {
            Debug,
            Home,
            MixFluid,
            AutoPrepare,
            Auto,
            Drain,
            Stop,
        }
        public enum DoId
        {
            Null = -1,
            //进液泵
            Tank20_ChargePump = 0,
            Tank21_ChargePump = 1,
            Tank22_ChargePump = 2,
            Tank23_ChargePump = 3,
            Tank40_ChargePump = 16,
            Tank41_ChargePump = 17,
            Tank42_ChargePump = 18,
            Tank43_ChargePump = 19,
            Tank50_ChargePump = 32,
            Tank51_ChargePump = 33,
            Tank52_ChargePump = 34,
            Tank53_ChargePump = 35,

            //进液使能：0-Disable,1-Enable
            Tank20_ChargeEnable = 48,
            Tank21_ChargeEnable = 49,
            Tank22_ChargeEnable = 50,
            Tank23_ChargeEnable = 51,
            Tank40_ChargeEnable = 52,
            Tank41_ChargeEnable = 53,
            Tank42_ChargeEnable = 54,
            Tank43_ChargeEnable = 55,
            Tank50_ChargeEnable = 56,
            Tank51_ChargeEnable = 57,
            Tank52_ChargeEnable = 58,
            Tank53_ChargeEnable = 59,

            //进液超时：1-超时
            Tank20_ChargeTimeout = 9,
            Tank21_ChargeTimeout = 10,
            Tank22_ChargeTimeout = 11,
            Tank23_ChargeTimeout = 12,
            Tank40_ChargeTimeout = 13,
            Tank41_ChargeTimeout = 14,
            Tank42_ChargeTimeout = 15,
            Tank43_ChargeTimeout = 25,
            Tank50_ChargeTimeout = 26,
            Tank51_ChargeTimeout = 27,
            Tank52_ChargeTimeout = 28,
            Tank53_ChargeTimeout = 29,

            //排液泵
            Tank2X_DrainPump = 4,
            Tank4X_DrainPump = 20,
            Tank5X_DrainPump = 36,

            //排液阀
            Tank20_DrainValve = 5,
            Tank21_DrainValve = 6,
            Tank22_DrainValve = 7,
            Tank23_DrainValve = 8,
            Tank40_DrainValve = 21,
            Tank41_DrainValve = 22,
            Tank42_DrainValve = 23,
            Tank43_DrainValve = 24,
            Tank50_DrainValve = 37,
            Tank51_DrainValve = 38,
            Tank52_DrainValve = 39,
            Tank53_DrainValve = 40,

            //鼓泡阀使能
            Tank20_BlowEnable  = 30,
            Tank21_BlowEnable  = 31,
            Tank22_BlowEnable  = 41,
            Tank52_BlowEnable  = 42,

            //鼓泡阀
            Tank20_BlowValve  = 71,
            Tank21_BlowValve  = 70,
            Tank22_BlowValve  = 72,
            Tank52_BlowValve  = 73,

            /// <summary>
            /// 压紧气缸(两个单作用)：End-松开
            /// </summary>
            P80_PressCylinder_End = 69,

            /// <summary>
            /// 升降气缸（双作用）：Start-下降；End-上升
            /// </summary>
            P80_LiftCylinder_Start = 67,
            /// <summary>
            /// 升降气缸（双作用）：Start-下降；End-上升
            /// </summary>
            P80_LiftCylinder_End = 68,
        }
        public enum DiId
        {
            Null = -1,
            /// <summary>
            /// 急停按钮：1-按钮按下
            /// </summary>
            EStopButton = 40,

            /// <summary>
            /// 复位按钮：0-按钮按下
            /// </summary>
            RSTButton = 41,

            //液位传感器：1-液位低
            Tank20_LowLiquid = 0,
            Tank21_LowLiquid = 1,
            Tank22_LowLiquid = 2,
            Tank23_LowLiquid = 3,
            Tank40_LowLiquid = 16,
            Tank41_LowLiquid = 17,
            Tank42_LowLiquid = 18,
            Tank43_LowLiquid = 19,
            Tank50_LowLiquid = 32,
            Tank51_LowLiquid = 33,
            Tank52_LowLiquid = 34,
            Tank53_LowLiquid = 35,

            /// <summary>
            /// 压紧气缸（两个单作用）：Start-压紧；End-松开
            /// </summary>
            P80_PressCylinder_EndSensor1 = 67,
            P80_PressCylinder_EndSensor2 = 68,

            /// <summary>
            ///升降气缸（双作用）：Start-下降；End-上升 
            /// </summary>
            P80_LiftCylinder_StartSensor = 71,
            /// <summary>
            ///升降气缸（双作用）：Start-下降；End-上升 
            /// </summary>
            P80_LiftCylinder_EndSensor = 70,

            /// <summary>
            /// 障碍物检测传感器：1-有障碍物
            /// </summary>
            P80_BlockSensor = 69,

            /// <summary>
            /// 传感器原点：1-原点
            /// </summary>
            Robot_HomeSensor = 42,
        }

        public enum AxisId
        {
            MixMotor = 0,
            LinearMotor = 1,
        }

        /// <summary>
        /// 温控：模块Modbus地址
        /// </summary>
        public enum TempCtrlAddr
        {
            None   = -1,
            Tank23 = 1,
            Tank40 = 1,
            Tank41 = 1,
            Tank42 = 2,
            Tank43 = 2,
            Tank50 = 2,
            Tank51 = 3,
            Tank52 = 3,
            Tank53 = 3,
            AirBox = 4,
        }

        /// <summary>
        /// 温控：通道号
        /// </summary>
        public enum TempCtrlChannel
        {
            None   = -1,
            Tank23 = 1,
            Tank40 = 2,
            Tank41 = 3,
            Tank42 = 1,
            Tank43 = 2,
            Tank50 = 3,
            Tank51 = 1,
            Tank52 = 2,
            Tank53 = 3,
            AirBox = 1,
        }

        /// <summary>
        /// 温控：索引
        /// </summary>
        public enum TempCtrlIndex
        {
            None   = -1,
            Tank23 = 0,
            Tank40 = 1,
            Tank41 = 2,
            Tank42 = 4,
            Tank43 = 5,
            Tank50 = 6,
            Tank51 = 8,
            Tank52 = 9,
            Tank53 = 10,
            AirBox = 12,
        }

        /// <summary>
        /// 温控：SV目标温度，单位0.1℃
        /// </summary>
        public enum TempCtrlSV
        {
            None   = 0,
            Tank23 = 600,
            Tank40 = 550,
            Tank41 = 0,
            Tank42 = 250,
            Tank43 = 400,
            Tank50 = 400,
            Tank51 = 250,
            Tank52 = 360,
            Tank53 = 0,
            AirBox = 600,
        }

        /// <summary>
        /// 磁力搅拌器：端口地址
        /// </summary>
        public enum MixerPort
        {
            Tank20 = 35,
            Tank21 = 38,
            Tank22 = 41,
            Tank23 = 44,
            Tank40 = 23,
            Tank41 = 26,
            Tank42 = 29,
            Tank43 = 32,
            Tank50 = 23,
            Tank51 = 26,
            Tank52 = 29,
            Tank53 = 32,
        };

        
        public enum Axis7Id
        {
            /// <summary>直线电机</summary>
            LinearMotor,
            /// <summary>机械手</summary>
            Robot,
            /// <summary>配液</summary>
            LiquidDispensing,
            /// <summary>超声波</summary>
            GlassUltrasonicCleaner,
            /// <summary>除油</summary>
            GlassDegreasing,
            /// <summary>玻璃酸洗</summary>
            GlassAcidPickling,
            /// <summary>玻璃烘干</summary>
            GlassBake,
            /// <summary>玻璃镀膜</summary>
            GlassCoating,
            /// <summary>乙醇清洗</summary>
            GlassEthanolCleaning,
            /// <summary>膜烘干</summary>
            CoatingBake,
            /// <summary>膜改性</summary>
            CoatingModified,
            /// <summary>膜预浸</summary>
            CoatingPrepreg,
            /// <summary>膜活化</summary>
            CoatingActivate,
            /// <summary>膜后浸</summary>
            CoatingPostImmersion,
            /// <summary>膜镀铜</summary>
            CoatingCoppering,
            /// <summary>镀膜烘干</summary>
            CopperingBake,
        }

        public enum TaskId
        {          
            /// <summary>机械手</summary>
            Robot,
            /// <summary>配液</summary>
            LiquidDispensing,
            /// <summary>超声波</summary>
            GlassUltrasonicCleaner,
            /// <summary>除油</summary>
            GlassDegreasing,
            /// <summary>玻璃酸洗</summary>
            GlassAcidPickling,
            /// <summary>玻璃烘干</summary>
            GlassBake,
            /// <summary>玻璃镀膜</summary>
            GlassCoating,
            /// <summary>乙醇清洗</summary>
            GlassEthanolCleaning,
            /// <summary>膜烘干</summary>
            CoatingBake,
            /// <summary>膜改性</summary>
            CoatingModified,
            /// <summary>膜预浸</summary>
            CoatingPrepreg,
            /// <summary>膜活化</summary>
            CoatingActivate,
            /// <summary>膜后浸</summary>
            CoatingPostImmersion,
            /// <summary>膜镀铜</summary>
            CoatingCoppering,
            /// <summary>镀膜烘干</summary>
            CopperingBake,
            /// <summary>直线电机</summary>
            LinearMotor,
            /// <summary>上料盘</summary>
            GlassPallet
        }

        public enum TaskIdCN
        {
            机械手,
            配液,
            超声波,
            除油,
            玻璃酸洗,
            玻璃烘干,
            玻璃镀膜,
            乙醇清洗,
            膜烘干,
            膜改性,
            膜预浸,
            膜活化,
            膜后浸,
            膜镀铜,
            镀膜烘干,
            直线电机,
            上料盘,
        }
        public enum CardId
        {
            Srnd_Io1,
            Srnd_Io2
        }
    }
}
