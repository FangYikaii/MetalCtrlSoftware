using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace XCore
{
    public enum MachineModeType
    {
        Production,
        Engineering,
        CPK,
        GRR,
        IPQC,
        None
    }
    public sealed class XMachine : XMachineEventHandler
    {
        private XDi signalEStop = null;
        private List<XDi> signalDoor = new List<XDi>();
        private bool m_DoorEnabled;
        private XDi signalReset = null;
        private XDi signalStart = null;
        private XDi signalStop = null;
        private bool eStop;
        private bool lastEStop;
        private MachineModeType machinemode = MachineModeType.None;
        private Thread _thread;
        private static readonly XMachine instance = new XMachine();
        XMachine()
        {

        }
        public static XMachine Instance
        {
            get { return instance; }
        }
        public MachineModeType MachineMode
        {
            get { return machinemode; }
            set { machinemode = value; }
        }
        public override int HandleEvent(XEvent xEvent)
        {
            switch (xEvent.EventID)
            {
                case XEventID.SIGNAL:
                    PrimOnSignal();
                    break;
            }
            return 0;
        }
        public void Start()
        {
            Stop();
            if (signalEStop != null)
            {
                XDevice.Instance.CardMap[signalEStop.CardId].Update();
                signalEStop.Update();
            }
            _thread = new Thread(new ThreadStart(T_PrimOnSignal));
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Stop()
        {
            if (this._thread != null)
            {
                this._thread.Abort();
            }
        }
        private void T_PrimOnSignal()
        {
            while (true)
            {
                if (signalEStop != null)
                {
                    eStop = !signalEStop.STS;
                    if (eStop == true && lastEStop == false)
                    {
                        foreach (XStation station in XStationManager.Instance.Stations.Values)
                        {
                            PostEventEStop(station);
                        }
                        XEventArgs e = new XEventArgs();
                        e.StationId = 0;
                        e.AlarmLevel = (int)XAlarmLevel.STOP;
                        XController.Instance.AlarmEventServer.PostEvent(XAlarmReporter.Instance, XEventID.ESTOP, e, null, true);
                    }
                    else if (eStop == false && lastEStop == true)
                    {
                        foreach (XStation station in XStationManager.Instance.Stations.Values)
                        {
                            PostEvent(station, XEventID.WAITRESET);
                        }
                    }
                    lastEStop = eStop;
                }

                if (eStop == false)
                {
                    if (signalReset != null)
                    {
                        if (signalReset.STS == true)
                        {
                            System.Threading.Thread.Sleep(3000);
                            if (signalReset.STS == true)
                            {

                                foreach (XStation station in XStationManager.Instance.Stations.Values)
                                {
                                    PostEvent(station, XEventID.RST);
                                    PostEvent(station, XEventID.RESET);
                                }
                            }

                        }

                    }
                }
                if (signalStart != null)
                {
                    if (signalStart.STS == true)
                    {
                        foreach (XStation station in XStationManager.Instance.Stations.Values)
                        {
                            PostEvent(station, XEventID.START);
                        }
                    }
                }

                if (this.m_DoorEnabled)
                {
                    foreach (XDi di in signalDoor)
                    {
                        if (di.PLF)
                        {
                            foreach (XStation station in XStationManager.Instance.Stations.Values)
                            {
                                PostEvent(station, XAlarmLevel.STOP, XSysAlarmId.DOOR_OPEN);
                            }
                        }
                    }
                }

                if (signalStop != null)
                {
                    if (signalStop.PLS == true)
                    {
                        foreach (XStation station in XStationManager.Instance.Stations.Values)
                        {
                            PostEvent(station, XEventID.STOPMUSTRESET, true);
                        }
                    }
                }
                Thread.Sleep(10);
            }
            
        }
        private int PrimOnSignal()
        {

            return 0;
        }

        public void SetEStopDi(int setDiId)
        {
            signalEStop = XDevice.Instance.FindDiById(setDiId);
        }

        public void AddDoorDi(int setDiId)
        {
            signalDoor.Add(XDevice.Instance.FindDiById(setDiId));
        }

        public void SetResetDi(int setDiId)
        {
            signalReset = XDevice.Instance.FindDiById(setDiId);
        }

        public void SetStartDi(int setDiId)
        {
            signalStart = XDevice.Instance.FindDiById(setDiId);
        }

        public void SetStopDi(int setDiId)
        {
            signalStop = XDevice.Instance.FindDiById(setDiId);
        }



        public bool DoorEnabled
        {
            get { return this.m_DoorEnabled; }
            set { this.m_DoorEnabled = value; }
        }

    }
}
