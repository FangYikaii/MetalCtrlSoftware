using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advantech.Motion;

namespace XCore
{
    public class XCommandCard1245L : XCommandCard
    {
        private object obj = new object();
        IntPtr m_DeviceHandle = IntPtr.Zero;
        IntPtr[] m_Axishand = new IntPtr[32];
        public XCommandCard1245L()
        {

        }

        public override int Initial()
        {
            lock (obj)
            {
                uint boardId = 1;

                uint ret = Motion.mAcm_DevOpen(boardId, ref m_DeviceHandle);

                if (ret != 0)
                {
                    return (int)ret;
                }
                return 1;
            }
        }

        public override int LoadParam(string configFn)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_DevLoadConfig(m_DeviceHandle, configFn);
            }
        }

        public override int Close()
        {
            lock (obj)
            {
                return (int)Motion.mAcm_DevClose(ref m_DeviceHandle);
            }
        }

        public override int Update(int actCardId)
        {
            lock (obj)
            {               
                return 0;
            }
        }

        public override int SetServo(int actCardId, int axisId, bool on)
        {
            lock (obj)
            {
                int i = (on) ? 1 : 0;
                return (int)Motion.mAcm_AxSetSvOn(m_Axishand[axisId], (uint)i);
            }
        }

        public override int GoHome(int actCardId, int axisId)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_AxHome(m_Axishand[axisId], 1, 0);
            }
        }

        public override int MoveAbs(int actCardId, int axisId, int position, int vel)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_AxMoveAbs(m_Axishand[axisId], position);
            }
        }

        public override int MoveRel(int actCardId, int axisId, int distance, int vel)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_AxMoveRel(m_Axishand[axisId], distance);
            }
        }

        public override int Stop(int actCardId, int axisId)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_AxStopDec(m_Axishand[axisId]);
            }
        }

        public override int EStop(int actCardId, int axisId)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_AxStopEmg(m_Axishand[axisId]);
            }
        }

        public override int MoveJog(int actCardId, int axisId, int IsStart)
        {
            lock (obj)
            {
                return (int)Motion.mAcm_AxMoveVel(m_Axishand[axisId], 1);
            }
        }
    }

}
