using cszmcaux;

namespace MetalizationSystem
{
    public class XCard: XObject
    {
        IntPtr g_handle;
        Dictionary<int,XAxis> axisMap = new Dictionary<int,XAxis>();
        Dictionary<int, XDi> diMap = new Dictionary<int, XDi>();
        Dictionary<int, XDo> doMap = new Dictionary<int, XDo>();
        Dictionary<int, XAd> adMap = new Dictionary<int, XAd>();
        public bool Connected { get; set; } = false;
        public IntPtr Handel { get { return g_handle; } }
        public XCard() { }
        public bool Initial(string ip)
        {
            try
            {
                if (g_handle != (IntPtr)0)
                {
                    Close();
                }
                int ret = zmcaux.ZAux_FastOpen(2, ip, 1000, out g_handle);
                if (ret != 0)
                {
                    g_handle = (IntPtr)0;
                    Connected = false;
                }
                else
                {
                    zmcaux.ZAux_SetTraceFile(3, "555");
                    double value = 0;
                    float[] arr = new float[100];
                    zmcaux.ZAux_Direct_GetUserVar(g_handle, "test_value", ref value);
                    zmcaux.ZAux_Direct_GetUserArray(g_handle, "st", 0, 100, arr);
                }
            }
            catch (Exception e) { return false; }
            return true;
        }

        public bool Close()
        {
            try
            {
                if (g_handle != (IntPtr)0)
                {
                    zmcaux.ZAux_Close(g_handle);
                    g_handle = (IntPtr)0;
                    Connected = false;
                }
            }
            catch (Exception e) { return false; }
            return true;
        }

        public bool SetDo(int index,bool on)
        {
            try
            {
                zmcaux.ZAux_Direct_SetOp(g_handle, index, (uint)(on ? 1 : 0));
            }
            catch (Exception e) { return false; }
            return true;
        }

        public bool GetDo(int index)
        {
            uint ret = 0;
            try
            {               
                zmcaux.ZAux_Direct_GetOp(g_handle, index, ref ret);
            }
            catch (Exception e) { return false; }
            return ret != 0;
        }
        public bool GetDi(int index)
        {
            uint ret = 0;
            try
            {
                zmcaux.ZAux_Direct_GetIn(g_handle, index, ref ret);

            }
            catch (Exception e) { return false; }
            return ret != 0;
        }
        public bool SetServo(int axis,bool on)
        {
            try
            {
                zmcaux.ZAux_Direct_SetAxisEnable(g_handle, axis, on ? 1 : 0);
                return GetServo(axis) == on;
            }
            catch (Exception e) { return false; }          
        }
        public bool GetServo(int axis)
        {
            try
            {
                int ret = 0;
                zmcaux.ZAux_Direct_GetAxisEnable(g_handle, axis,ref ret);
                return ret == 1;
            }
            catch (Exception e) { return false; }    
        }
        public bool GoHome(int axis)
        {
            try
            {
                zmcaux.ZAux_BusCmd_Datum(g_handle, (uint)axis, 29);
            }
            catch (Exception e) { return false; }
            return true;
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
        public bool SetAxis(int axisId, int lead, float acc, float dcc,float speed,int pulsesPre = 10000)
        {
            try
            {
                if (!axisMap.ContainsKey(axisId))
                {
                    axisMap.Add(axisId, new XAxis());
                }
                axisMap[axisId].Lead = lead;
                axisMap[axisId].Acc = (float)(acc * pulsesPre / lead);
                axisMap[axisId].Dcc = (float)(dcc * pulsesPre / lead);
                axisMap[axisId].Speed = (float)(speed * pulsesPre / lead);
                zmcaux.ZAux_Direct_SetAtype(g_handle, axisId, 1);
                zmcaux.ZAux_Direct_SetUnits(g_handle, axisId, 1);
                zmcaux.ZAux_Direct_SetLspeed(g_handle, axisId, axisMap[axisId].Speed);
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axisId, axisMap[axisId].Speed);
                zmcaux.ZAux_Direct_SetAccel(g_handle, axisId, axisMap[axisId].Acc);
                zmcaux.ZAux_Direct_SetDecel(g_handle, axisId, axisMap[axisId].Dcc);
                zmcaux.ZAux_Direct_SetSramp(g_handle, axisId, 0);
            }
            catch (Exception e) { return false; }
            return true;
        }      
        public bool MoveAbs(int axis,float position,float speed=-1)
        {
            try
            {
                if (speed == -1) speed = axisMap[axis].Speed;
                else speed = XConvert.MM2PULS(speed, axisMap[axis].Lead, axisMap[axis].Lead);
                position = XConvert.MM2PULS(position, axisMap[axis].Lead, axisMap[axis].Lead);
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axis, speed);
                int ret = zmcaux.ZAux_Direct_Single_MoveAbs(g_handle, axis, position);
            }
            catch (Exception e) { return false; }
            return true;
        }
        public bool MoveRel(int axis, float distance, float speed = -1)
        {
            try
            {
                if (speed == -1) speed = axisMap[axis].Speed;
                else speed = XConvert.MM2PULS(speed, axisMap[axis].Lead, axisMap[axis].Lead);
                distance = XConvert.MM2PULS(distance, axisMap[axis].Lead, axisMap[axis].Lead);
                zmcaux.ZAux_Direct_SetSpeed(g_handle, axis, speed);
                int ret = zmcaux.ZAux_Direct_Single_Move(g_handle, axis, distance);
            }
            catch (Exception e) { return false; }
            return true;
        }
        public bool Stop(int axis)
        {
            try
            {
                zmcaux.ZAux_Direct_Single_Cancel(g_handle, axis, 2);
            }
            catch (Exception e) { return false; }
            return true;
        }

        public void Updata()
        {
            lock (this)
            {
                foreach (var axis in axisMap)
                {
                    axis.Value.Update();
                }
                foreach (var d in diMap) { d.Value.Update(); }
                foreach (var d in doMap) { d.Value.Update(); }
                foreach (var d in adMap) { d.Value.Update(); }
            }
        }

        public void BindAxis(int axisId,int lead ,string name)
        {
            if (!axisMap.ContainsKey(axisId))
            {
                axisMap.Add(axisId, new XAxis(axisId, lead, name, g_handle));
            }           
        }
        public XAxis FindAxis(int axisId)
        {
            if (axisMap.ContainsKey(axisId))return axisMap[axisId];
            return null;
        }

        public void BindDi(int index, string name)
        {
            if (!diMap.ContainsKey(index))
            {
                diMap.Add(index, new XDi(index, name, g_handle));
            }
        }
        public XDi FindDi(int index)
        {
            if (diMap.ContainsKey(index)) return diMap[index];
            return null;
        }
        public void BindDo(int index, string name)
        {
            if (!doMap.ContainsKey(index))
            {
                doMap.Add(index, new XDo(index, name, g_handle));
            }
        }
        public XDo FindDo(int index)
        {
            if (doMap.ContainsKey(index)) return doMap[index];
            return null;
        }
        public void BindAd(int index, string name)
        {
            if (!adMap.ContainsKey(index))
            {
                adMap.Add(index, new XAd(index, name, g_handle));
            }
        }
        public XAd FindAd(int index)
        {
            if (adMap.ContainsKey(index)) return adMap[index];
            return null;
        }

    }
}
