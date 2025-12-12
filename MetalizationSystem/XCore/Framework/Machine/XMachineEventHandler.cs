using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public abstract class XMachineEventHandler : XEventHandler
    {
        public XMachineEventHandler()
        {
            XController.Instance.EventServer.RegisterForNotification(this, XEventID.SIGNAL);
        }
    }
}
