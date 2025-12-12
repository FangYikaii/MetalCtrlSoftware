using System.Threading;
using System.Collections.Concurrent;

namespace XCore
{
    public class XAlarmEventServer : XEventServerBase
    {
        private ConcurrentQueue<XEvent> queue_XEvent_Alarm;
        public XAlarmEventServer()
        {
            InitEventPool(30);
            queue_XEvent_Alarm = new ConcurrentQueue<XEvent>();
        }

        public override void PostEvent(XEventHandler target, XEventID eventID, XEventArgs eventArgs = null, XObject sender = null, bool isPriority = false)
        {
            XEvent xEvent = CreateEvent(target, eventID, eventArgs, sender);
            queue_XEvent_Alarm.Enqueue(xEvent);
        }

        protected override void DispatchEvent()
        {
            if (queue_XEvent_Alarm.Count > 0)
            {
                XEvent xEvent;
                if (queue_XEvent_Alarm.TryDequeue(out xEvent))
                {
                    xEvent.Execute();
                }
                if (xEvent != null)
                {
                    Store(xEvent);
                }
            }
        }

        protected override void ProcessEventQueue(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                DispatchEvent();
                Thread.Sleep(10);
            }
        }
    }
}
