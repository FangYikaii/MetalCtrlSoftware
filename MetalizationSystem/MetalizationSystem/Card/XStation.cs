using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using cszmcaux;

namespace MetalizationSystem
{
    public class XStation
    {
        Dictionary<int, PositionInfo> posMap = new Dictionary<int, PositionInfo>();
        IntPtr g_handle;
        public int XId {  get; }
        public int YId { get; }
        public int ZId { get; }
        public int UId { get; }
      

        public XStation(int  xId, int yId, int zId, int uId, IntPtr handle)
        {
            g_handle = handle;
            XId = xId;
            YId = yId;
            ZId = zId;
            UId = uId;
        }
        public PositionInfo CurPosition
        {
            get {
                PositionInfo positionInfo = new PositionInfo();
                if (XId != -1) positionInfo.X = XMachine.Instance.Card.FindAxis(XId).EncoderPosition;
                if (YId != -1) positionInfo.Y = XMachine.Instance.Card.FindAxis(YId).EncoderPosition;
                if (ZId != -1) positionInfo.Z = XMachine.Instance.Card.FindAxis(ZId).EncoderPosition;
                if (UId != -1) positionInfo.U = XMachine.Instance.Card.FindAxis(UId).EncoderPosition;
                return positionInfo;
            }
        }

        public void BindPos(int index, PositionInfo info)
        {
            if (!posMap.ContainsKey(index))
            {
                posMap.Add(index, info);
            }
        }
        public PositionInfo FindPos(int index)
        {
            if (posMap.ContainsKey(index)) return posMap[index];
            return null;
        }
        public bool Move(PositionInfo position, double safePosition = 0)
        {
            try
            {
                if (ZId != -1)
                {
                    XMachine.Instance.Card.FindAxis(ZId).MoveAbs((float)safePosition);                   
                }
                int len = 0;
                if (XId != -1) len++;
                if (YId != -1) len++;
                if (UId != -1) len++;

         
                int[] axisList = new int[len];
                float[] posList = new float[len];
                int id = 0;
                if (XId != -1)
                {
                    axisList[id] = XId;
                    posList[id] = XMachine.Instance.Card.FindAxis(XId).ToPulse((float)position.X);                   
                }
                if (YId != -1)
                {
                    axisList[id] = XId;
                    posList[id] = XMachine.Instance.Card.FindAxis(YId).ToPulse((float)position.X);
                }
                if (UId != -1)
                {
                    axisList[id] = XId;
                    posList[id] = XMachine.Instance.Card.FindAxis(UId).ToPulse((float)position.X);
                }
                zmcaux.ZAux_Direct_MultiMoveAbs(g_handle, 1, len, axisList, posList);
                if (ZId != -1)
                {
                    XMachine.Instance.Card.FindAxis(ZId).MoveAbs((float)position.Z);
                }
            }
            catch { return false; }
            return true;
        }
    }
}
