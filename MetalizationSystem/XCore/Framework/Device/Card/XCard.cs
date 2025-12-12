using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APS_Define_W32;
using APS168_W32;

namespace XCore
{
    public class XCard : XObject
    {
        private int actCardId;
        private string name;
        private XCommandCard commandCard;
        private Dictionary<int, XAxis> axes = new Dictionary<int, XAxis>();
        public XCard(int actCardId, XCommandCard commandCard, string name)
        {
            this.actCardId = actCardId;
            this.commandCard = commandCard;
            this.name = name;
        }
        public int Initial()
        {
            int iRtn = commandCard.Initial();
            if (iRtn < 0)
            {
                string append = "[" + name + "]:" + iRtn;
                XAlarmReporter.Instance.NotifyStations(XAlarmLevel.STOP, (int)XSysAlarmId.CARD_INIT_FAIL, append);
            }
            return iRtn;
        }
        public int Register(int cardId)
        {
            int iRtn = commandCard.Register(cardId);
            if (iRtn != 0)
            {
                string append = "[" + name + "]:" + iRtn;
                XAlarmReporter.Instance.NotifyStations(XAlarmLevel.STOP, (int)XSysAlarmId.CARD_INIT_FAIL, append);
            }
            return iRtn;
        }
        public int LoadParam(string configFn)
        {
            int iRtn = commandCard.LoadParam(configFn);
            if (iRtn != 0)
            {
                string append = "[" + name + "]:" + iRtn;
                XAlarmReporter.Instance.NotifyStations(XAlarmLevel.STOP, (int)XSysAlarmId.CARD_LOAD_PARAM_FAIL, append);
            }
            return iRtn;
        }

        public int ActId
        {
            get { return this.actCardId; }
        }
        public string Name
        {
            get { return this.name; }
        }

        public int Update()
        {
            return commandCard.Update(actCardId);
        }

        public int SetDo(int channel, int index, int sts)
        {
            return commandCard.SetDo(actCardId, channel, index, sts);
        }
        public int GetDo(int channel, int index, ref int sts)
        {
            return commandCard.GetDo(actCardId, channel,index ,ref sts);
        }
        public int GetDi(int channel, int index, ref int sts)
        {
            return commandCard.GetDi(actCardId, channel, index, ref sts);
        }

        public int ReadChannel(int channel, out double value)
        {
            return commandCard.ReadChannel(actCardId, channel, out value);
        }

        public int WriteChannel(int channel, double value)
        {
            return commandCard.WriteChannel(actCardId, channel, value);
        }

        public int SetServo(int axisId, bool on)
        {
            return commandCard.SetServo(actCardId, axisId, on);
        }
        public int GoHome(int axisId)
        {
            return commandCard.GoHome(actCardId, axisId);
        }
        public int MoveAbs(int axisId, int position, int vel)
        {
            return commandCard.MoveAbs(actCardId, axisId, position, vel);
        }
        public int MoveRel(int axisId, int distance, int vel)
        {
            return commandCard.MoveRel(actCardId, axisId, distance, vel);
        }
        public int MoveJog(int axisId, int IsStart)
        {
            return commandCard.MoveJog(actCardId,axisId ,IsStart);
        }
        public int Stop(int axisId)
        {
            return commandCard.Stop(actCardId, axisId);
        }
        public int EStop(int axisId)
        {
            return commandCard.EStop(actCardId, axisId);
        }

        public int GetMotionIo(int axisId, ref int sts)
        {
            return commandCard.GetMotionIo(actCardId, axisId, ref sts);
        }
        public int GetMotionSts(int axisId, ref int sts)
        {
            return commandCard.GetMotionSts(actCardId, axisId, ref sts);
        }
        public int GetMotionPos(int axisId, ref int pos)
        {
            return commandCard.GetMotionPos(actCardId, axisId, ref pos);
        }
        public int GetCommandPos(int axisId, ref int pos)
        {
            return commandCard.GetCommandPos(actCardId, axisId, ref pos);
        }

        public int SetAxisAccAndDec(int axisId, double lead, double acc, double dec)
        {
            return commandCard.SetAxisAccAndDec(actCardId, axisId, lead, acc, dec);
        }
        public int SetStopDec(int axisId, double lead,  double dec)
        {
            return commandCard.SetStopDec(actCardId, axisId, lead, dec);
        }
        public int APS_SetJogParam( int axisId, int mode, int dir, double lead, double acc, double dec, int vel)
        {
            return commandCard.APS_SetJogParam(actCardId, axisId,mode,dir, lead, acc, dec,vel);
        }
        public int APS_SetAxisParam(int axisId, double lead, APS_Define PRA, double value)
        {
            return commandCard.APS_SetAxisParam(actCardId, axisId, lead, PRA, value);
        }
        public int APS_DIO_SetCOSInterrupt32(byte Port, uint ctl, out uint hEvent, bool ManualReset)
        {
            return commandCard.APS_DIO_SetCOSInterrupt32(actCardId, Port, ctl, out hEvent, ManualReset);
        }
        public int APS_DIO_INT1_EventMessage(int index, uint windowHandle, uint message, MulticastDelegate callbackAddr)
        {
            return commandCard.APS_DIO_INT1_EventMessage(actCardId, index, windowHandle, message, callbackAddr);
        }
        public int APS_SetBacklashEnable(int axisId, int on)
        {
            return commandCard.APS_SetBacklashEnable(actCardId, axisId, on);
        }

        public int MoveLineAbs(int[] axisId, double[] pos, double vel)
        {
            return commandCard.MoveLineAbs(axisId, pos, vel);
        }
        public int MoveLineRel(int[] axisId, double[] pos, double vel)
        {
            return commandCard.MoveLineRel(axisId, pos, vel);
        }
        public int MoveArcAbs(int[] axisId, double[] center, double angle, double vel)
        {
            return commandCard.MoveArcAbs(axisId, center, angle, vel);
        }
        public int MoveArcAbs(int[] axisId, double[] center, double[] pos, ArcDir dir, double vel)
        {
            return commandCard.MoveArcAbs(axisId, center, pos, (short)dir, vel);
        }
        public int MoveArcRel(int[] axisId, double[] center, double angle, double vel)
        {
            return commandCard.MoveArcRel(axisId, center, angle, vel);
        }
        public int MoveArcRel(int[] axisId, double[] center, double[] pos, ArcDir dir, double vel)
        {
            return commandCard.MoveArcRel(axisId, center, pos, (short)dir, vel);
        }


        public int APS_pt_start(int ptbId)
        {
            return commandCard.APS_pt_start(actCardId, ptbId);
        }
        public int APS_get_pt_status(int ptbId, ref PTSTS Status)
        {
            return commandCard.APS_get_pt_status(actCardId, ptbId, ref Status);
        }
    }

    
}
