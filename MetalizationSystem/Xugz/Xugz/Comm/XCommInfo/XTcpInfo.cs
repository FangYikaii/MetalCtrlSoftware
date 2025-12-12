using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Xugz
{
    public class XTcpInfo : XCommInfo
    {
        public IPAddress IPAddress { get; set; } = IPAddress.Any;
        public short Port { get; set; } = 8500;
        public bool IsClient = true;

        public XTcpInfo(IPAddress ipAddress, short port, bool isClient)
        {
            IPAddress = ipAddress;
            Port = port;
            IsClient = isClient;
        }
    }
}
