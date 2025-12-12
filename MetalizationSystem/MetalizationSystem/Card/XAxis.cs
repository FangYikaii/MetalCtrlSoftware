using cszmcaux;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem
{
    public class XAxis
    {
        IntPtr g_handle = (IntPtr)0;
        int axisId;
        string name;
        const long bit = 1 << 23;
        const int units = 100;
        public float Dpos = 0;


        /// <summary>导程</summary>   
        public int Lead { get; set; } = 1;
        /// <summary>加速度</summary>   
        public float Acc { get; set; } = 1;
        /// <summary>减速度</summary>   
        public float Dcc { get; set; } = 1;
        /// <summary>速度</summary>   
        public float Speed { get; set; } = 1;     
        public int AlarmIo { get;set; }
        public int LimitP {  get; set; }
        public int LimitN {  get; set; }
        public int Org { get; set; }
        public bool HomeOK { get; set; } = false;
        public bool RunState { get; set; } = false;
        public bool LimitPState {  get; set; } = false;
        public bool LimitNState { get; set; } = false;
        public bool OrgState { get; set; } = false;
        public bool Alarm { get; set; } = false;
        public float PlannerPosition { get; set; } = 0;
        public float EncoderPosition { get; set; } = 0;
        public string Name { get => name; }
        public XAxis() { }
        public XAxis(int axisId, int lead, string name, IntPtr intPtr)
        {          
            g_handle=intPtr; Lead = lead; this.axisId = axisId;this.name = name;
        }
        
        public bool SetServo(bool on)
        {
            try
            {
                zmcaux.ZAux_Direct_SetAxisEnable(g_handle, axisId, on ? 1 : 0);
                return GetServo == on;
            }
            catch (Exception e) { return false; }
        }
        public bool GetServo
        {
            get
            {
                int ret = 0;
                try
                {                   
                    zmcaux.ZAux_Direct_GetAxisEnable(g_handle, axisId, ref ret);                  
                }
                catch (Exception e) { return false; }
                return ret == 1;
            }
           
        }

        // 设置加速度，单位mm/s
        public bool SetAcc(float acc)
        {
            try
            {
                Acc = acc;
                zmcaux.ZAux_Direct_SetAccel(g_handle, axisId, acc);
            }
            catch (Exception e) { return false; }
            return true;
        }

        // 设置减速度，单位mm/s
        public bool SetDcc(float dcc)
        {
            try
            {
                Dcc = dcc;
                zmcaux.ZAux_Direct_SetAccel(g_handle, axisId, dcc);
            }
            catch (Exception e) { return false; }
            return true;
        }

        // 设置运行速度，单位mm/s
        public bool SetSpeed(float speed)
        {
            try
            {
                Speed = speed;
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, speed);
            }
            catch (Exception e) { return false; }
            return true;
        }

        // 速度模式下设置转速
        public bool SetDAC(float fValue)
        {
            try
            {
                zmcaux.ZAux_Direct_SetDAC(g_handle, (uint)axisId, fValue);
            }
            catch (Exception e) { return false; }
            return true;
        }

        public bool GoHome()
        {
            try
            {
                zmcaux.ZAux_Direct_Single_Datum(g_handle, (int)axisId, 14);
                //zmcaux.ZAux_BusCmd_Datum(g_handle, (uint)axisId, 104);
                //zmcaux.ZAux_Direct_SetDpos(g_handle, axisId, 0);
                HomeOK = true;
            }
            catch (Exception e) { return false; }
            return true;
        }

        public bool GetHomeStatus()
        {
            uint HomeStatus = 0;
            try
            {
                zmcaux.ZAux_Direct_GetHomeStatus(g_handle, (int)axisId, ref HomeStatus);
                if (HomeStatus == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e) { return false; }
        }

        /// <summary>
        /// 设置轴的相关参数
        /// </summary>
        /// <param name="axisId"></param>
        /// <param name="lead">导程，单位mm</param>
        /// <param name="acc">加速度，单位mm/s²</param>
        /// <param name="dec">减速度，单位mm/s²</param>
        /// <param name="speed">速度，单位mm/s</param>
        /// <param name="pulsesPre">每圈所需要的脉冲量</param>
        /// <returns></returns>
        public bool SetAccAndDec(float acc, float dcc, float speed)
        {
            try
            {               
                Acc= acc;
                Dcc = dcc;
                Speed = speed;
                zmcaux.ZAux_Direct_SetAtype(g_handle, axisId, 65);
                zmcaux.ZAux_Direct_SetUnits(g_handle, axisId, units);
                zmcaux.ZAux_Direct_SetLspeed(g_handle, axisId,ToPulse(speed));
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, ToPulse(speed));
                zmcaux.ZAux_Direct_SetAccel(g_handle, axisId, ToPulse(acc));
                zmcaux.ZAux_Direct_SetDecel(g_handle, axisId, ToPulse(dcc));
                zmcaux.ZAux_Direct_SetSramp(g_handle, axisId, 0);
            }
            catch (Exception e) { return false; }
            return true;
        }
        /// <summary>
        /// 绝对位置运动
        /// </summary>
        /// <param name="position">位置</param>
        /// <param name="speed">速度</param>
        /// <returns></returns>
        public bool MoveAbs(float position)
        {
            try
            {
                //zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, ToPulse(speed));
                //int ret = zmcaux.ZAux_Direct_Single_MoveAbs(g_handle, axisId, ToPulse(position));
                int ret = zmcaux.ZAux_Direct_Single_MoveAbs(g_handle, axisId, position);
            }
            catch (Exception e) { return false; }
            return true;
        }
        /// <summary>
        /// 相对运动
        /// </summary>
        /// <param name="distance">距离</param>
        /// <param name="speed">速度</param>
        /// <returns></returns>
        public bool MoveRel(float distance, float speed = -1)
        {
            try
            {            
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, ToPulse(speed));
                int ret = zmcaux.ZAux_Direct_Single_Move(g_handle, axisId, ToPulse(distance));
            }
            catch (Exception e) { return false; }
            return true;
        }
        /// <summary>
        /// 连续运动
        /// </summary>
        /// <param name="dir">1为正，-1为负</param>
        /// <param name="speed">速度</param>
        /// <returns></returns>
        public bool MoveContinuous(int dir, float speed = -1)
        {
            try
            {
                //zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, ToPulse(speed));
                int ret = zmcaux.ZAux_Direct_Single_Vmove(g_handle, axisId, dir);
            }
            catch (Exception e) { return false; }
            return true;
        }
        public bool Stop()
        {
            try
            {
                zmcaux.ZAux_Direct_Single_Cancel(g_handle, axisId, 2);
            }
            catch (Exception e) { return false; }
            return true;
        }
        public bool Update()
        {
            lock (this)
            {
                int runstate = 0;
                int axisstate = 0;
                zmcaux.ZAux_Direct_GetIfIdle(g_handle, axisId, ref runstate); //runstate：-1-未运动；0-运行中
                zmcaux.ZAux_Direct_GetAxisStatus(g_handle, 0, ref axisstate);
                float curpos = 0;
                zmcaux.ZAux_Direct_GetDpos(g_handle, axisId, ref curpos);
                Dpos = curpos;
                RunState = runstate == 0; //RunState:0-未运动；1-运动中
                EncoderPosition = Tomm(curpos);
                LimitPState = ((axisstate >> 4) & 1) == 1;
                LimitNState = ((axisstate >> 5) & 1) == 1;
                Alarm = ((axisstate >> 22) & 1) == 1;
                return true;
            }
        }
        public  float Tomm(float value) { return value / bit * Lead * units; }
        
        public float ToPulse(float value) {  return value * bit / Lead / units; }

    }
}
