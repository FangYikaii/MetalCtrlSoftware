using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XCore
{
    public class XCommandCardZMC : XCommandCard
    {
        private object obj = new object();
        IntPtr g_handle;         //链接返回的句柄，可以作为卡号
       
        public XCommandCardZMC()
        {

        }

        public override int Initial()
        {
            lock (obj)
            {
                DI_Data = new int[32];
                DO_Data = new int[32];
                string ip = "";
                int ret = zmcaux.ZAux_FastOpen(2, ip, 1000, out g_handle);
                if (ret != 0)
                {
                    return ret;
                }
                return 0;
            }
        }

        public override int LoadParam(string configFn)
        {
            lock (obj)
            {
                
                return 0;
            }
        }

        public override int Close()
        {
            lock (obj)
            {
                int ret =  zmcaux.ZAux_Close(g_handle);
                g_handle = (IntPtr)0;
                return ret;
            }
        }

        public override int Update(int actCardId)
        {
            lock (obj)
            {         
                for(int i = 0; i< 32; i++)
                {
                    uint ret = 0;
                    zmcaux.ZAux_Direct_GetIn(g_handle, i, ref ret);
                    DI_Data[i] = (int)ret;
                    zmcaux.ZAux_Direct_GetOp(g_handle,i,ref ret);
                    DO_Data[i] = (int)ret;
                }       
                return 0;
            }
        }

        public override int SetDo(int actCardId, int channel, int index, int sts)
        {
            lock (obj)
            {
                return zmcaux.ZAux_Direct_SetOp(g_handle, index, (uint)sts);
            }
        }

        public override int GetDo(int actCardId, int channel, int index, ref int sts)
        {
            lock (obj)
            {
                //return APS168.APS_read_d_channel_output(actCardId, channel, index, ref sts);
                sts = DO_Data[index];
                return 0;
            }
        }

        public override int GetDi(int actCardId, int channel, int index, ref int sts)
        {
            lock (obj)
            {        
                sts = DI_Data[index];
                return 0;
            }
        }

        public override int SetServo(int actCardId, int axisId, bool on)
        {
            lock (obj)
            {
                int i = (on) ? 1 : 0;
                return zmcaux.ZAux_Direct_SetAxisEnable(g_handle,axisId, i);
            }
        }

        public override int GoHome(int actCardId, int axisId)
        {
            lock (obj)
            {
                return zmcaux.ZAux_BusCmd_Datum(g_handle, (uint)axisId, 0);
            }
        }

        public override int MoveAbs(int actCardId, int axisId, int position, int vel)
        {
            lock (obj)
            {
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, vel);
                return zmcaux.ZAux_Direct_Single_MoveAbs (g_handle, axisId, position);
            }
        }

        public override int MoveRel(int actCardId, int axisId, int distance, int vel)
        {
            lock (obj)
            {
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, vel);
                return zmcaux.ZAux_Direct_Single_Move(g_handle,axisId,distance);
            }
        }

        public override int Stop(int actCardId, int axisId)
        {
            lock (obj)
            {
                //zmcaux.ZAux_Direct_SetFastDec(g_handle);
                return zmcaux.ZAux_Direct_Single_Cancel(g_handle, axisId, 2);
            }
        }

        public override int EStop(int actCardId, int axisId)
        {
            lock (obj)
            {
                return zmcaux.ZAux_Direct_Single_Cancel(g_handle, axisId, 2);
            }
        }

        public override int GetMotionIo(int actCardId, int axisId, ref int sts)
        {
            lock (obj)
            {
                int _sts=0, _rSts=0;
                int ret = 0;
                _sts = zmcaux.ZAux_Direct_GetAxisStatus(g_handle,axisId, ref _sts);
                _rSts = 0;
                if (XConvert.BitEnable(_sts, 0x01 << 2))
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MIO_ALM);
                }
                if (XConvert.BitEnable(_sts, 0x01 << 4))
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MIO_PEL);
                }
                if (XConvert.BitEnable(_sts, 0x01 << 5))
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MIO_MEL);
                }
                zmcaux.ZAux_Direct_GetDatumIn(g_handle, axisId, ref ret);
                if (ret == 1) XConvert.SetBits(ref _rSts, ZCM_Define.MIO_ORG);
                else XConvert.ClrBits(ref _rSts, ZCM_Define.MIO_ORG);              
                if (XConvert.BitEnable(_sts, 0x01 << 22))
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MIO_EMG);
                }
                zmcaux.ZAux_Direct_GetAxisEnable(g_handle, axisId, ref ret);
                if (ret==1) XConvert.SetBits(ref _rSts, ZCM_Define.MIO_SVON);
                else XConvert.ClrBits(ref _rSts, ZCM_Define.MIO_SVON);
                sts = _rSts;
                return 0;
            }
        }

        public override int GetMotionSts(int actCardId, int axisId, ref int sts)
        {
            lock (obj)
            {
                int _sts, _rSts = 0;
                _sts =zmcaux.ZAux_Direct_GetAxisStatus(g_handle,axisId,ref _rSts);               
                _rSts = 0;
                if (XConvert.BitEnable(_sts, 0x01 << 22))
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MTS_MDN);
                }
                if (XConvert.BitEnable(_sts, 0x01 << 6))
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MTS_HMV);
                }
                if (XConvert.BitEnable(_sts, 0x01 << 2)) //16
                {
                    XConvert.SetBits(ref _rSts, ZCM_Define.MTS_ASTP);
                }
                sts = _rSts;
                return 0;
            }

        }

        public override int GetMotionPos(int actCardId, int axisId, ref int pos)
        {
            lock (obj)
            {
                float curpos = 0;
                int ret = zmcaux.ZAux_Direct_GetDpos(g_handle, axisId, ref curpos);
                pos = (int)curpos;
                return ret;
            }
        }

        public override int GetCommandPos(int actCardId, int axisId, ref int pos)
        {
            lock (obj)
            {
                float curpos = 0;
                int ret = zmcaux.ZAux_Direct_GetDpos(g_handle, axisId, ref curpos);
                pos = (int)curpos;
                return ret;
            }
        }
        public override int APS_SetJogParam(int actCardId, int axisId, int mode, int dir, double lead, double acc, double dec, int vel)
        {
            lock (obj)
            {
                int ret = 0;
                zmcaux.ZAux_Direct_SetAtype(g_handle, axisId, 1);
                zmcaux.ZAux_Direct_SetUnits(g_handle, axisId, 1);
                zmcaux.ZAux_Direct_SetLspeed(g_handle, axisId, XConvert.MM2PULS(vel, lead));
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, XConvert.MM2PULS(vel, lead));
                zmcaux.ZAux_Direct_SetAccel(g_handle, axisId, XConvert.MM2PULS(acc, lead));
                zmcaux.ZAux_Direct_SetDecel(g_handle, axisId, XConvert.MM2PULS(acc, lead));
                return zmcaux.ZAux_Direct_SetSramp(g_handle, axisId, 0);                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actCardId"></param>
        /// <param name="axisId"></param>
        /// <param name="IsStart">1为正转 -1为反转</param>
        /// <returns></returns>
        public override int MoveJog(int actCardId, int axisId, int IsStart)
        {
            lock (obj)
            {
                int ret = 0;
                //IsStart=1为正转 -1为反转
                ret = zmcaux.ZAux_Direct_Single_Vmove(g_handle, axisId, IsStart);
                return ret;
            }
        }
        public override int SetAxisAccAndDec(int actCardId, int axisId, double lead, double acc, double dec)
        {
            lock (obj)
            {
                int ret = 0;
                ret = zmcaux.ZAux_Direct_SetAccel(g_handle, axisId, (float)XConvert.MM2PULS(acc, lead));                
                if (ret != 0)
                    return ret;
                return zmcaux.ZAux_Direct_SetDecel(g_handle, axisId, (float)XConvert.MM2PULS(dec, lead));
            }
        }
        public override int SetStopDec(int actCardId, int axisId, double lead,  double dec)
        {
            lock (obj)
            {
                int ret = 0;
                //ret = APS168.APS_set_axis_param_f(axisId, (int)APS_Define.PRA_STP_DEC, XConvert.MM2PULS(dec, lead));
                //if (ret != 0)
                //    return ret;
                return ret;
            }
        }
  

      
    }
  
}
