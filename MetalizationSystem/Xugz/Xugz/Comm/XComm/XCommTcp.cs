using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Xugz
{
    public class XCommTcp : XComm
    {            
        XTcpInfo tcpInfo;
        bool IsHex = false;

        DMTcpClient client;
        bool connected;

        DMTcpServer server;
        Socket socket;
        List<string> m_SocketIpPortList = new List<string>();//作为tcp服务端的时候 显示客户端的信息

        public override bool Connected {  get {
                if (tcpInfo.IsClient) return connected;
                else return m_SocketIpPortList.Count > 0;
            } }

        public override event Receive OnReceive;

        public override void Close()
        {
            if (tcpInfo.IsClient)
            {
                if (connected) 
                {
                    connected = false;
                    client.PauseConnection();
                    client.StopConnection();
                }  
            }
            else
            {
                server.Stop();
                m_SocketIpPortList.Clear();
            }               
        }

        public override bool Init(XCommInfo info, bool isHex = false)
        {
            try
            {
                IsHex = isHex;
                tcpInfo = info as XTcpInfo;
                if (tcpInfo == null) return false;
                if (tcpInfo.IsClient)
                {
                    client = new DMTcpClient();
                    client.OnStateInfo += Client_OnStateInfo; ;
                    client.OnReceviceByte += Client_OnReceviceByte;                    
                    client.OnErrorMsg += Client_OnErrorMsg;
                    client.ServerIp = tcpInfo.IPAddress;
                    client.ServerPort = tcpInfo.Port;
                    client.StartConnection();
                }
                else
                {
                    server = new DMTcpServer();
                    server.OnReceviceByte += Server_OnReceviceByte;
                    server.OnOnlineClient += Server_OnOnlineClient;
                    server.OnOfflineClient += Server_OnOfflineClient;
                    server.ServerIp= tcpInfo.IPAddress;
                    server.ServerPort = tcpInfo.Port;
              
                }
            }
            catch { return false; }
            return true;
        }

        private void Server_OnOfflineClient(System.Net.Sockets.Socket temp)
        {
            m_SocketIpPortList.Remove(temp.RemoteEndPoint.ToString());
            Debug.WriteLine($"{temp.RemoteEndPoint.ToString()} 客户端已经下线");
        }

        private void Server_OnOnlineClient(System.Net.Sockets.Socket temp)
        {
            m_SocketIpPortList.Add(temp.RemoteEndPoint.ToString());
            Debug.WriteLine($"{temp.RemoteEndPoint.ToString()} 客户端已经连接");
        }

        private void Server_OnReceviceByte(System.Net.Sockets.Socket temp, byte[] dataBytes)
        {
            throw new NotImplementedException();
        }

        private void Client_OnErrorMsg(string msg)
        {
            throw new NotImplementedException();
        }

        private void Client_OnReceviceByte(byte[] date)
        {
            OnReceive?.Invoke(Encoding.UTF8.GetString(date));
        }

        private void Client_OnStateInfo(string msg, SocketState state)
        {
            switch (state)
            {
                case SocketState.Connecting:
                    break;
                case SocketState.Connected:
                    connected = true;
                    Log.Info($"已成功连接服务器  {tcpInfo.IPAddress.ToString()}:{tcpInfo.Port.ToString()}");
                    break;
                case SocketState.Reconnection:
                    break;
                case SocketState.Disconnect:
                    if (connected == true) connected = false;                   
                    Log.Info($"与服务器的连接断开  {tcpInfo.IPAddress.ToString()}:{tcpInfo.Port.ToString()}");           
                    break;
                case SocketState.StartListening:
                    break;
                case SocketState.StopListening:
                    break;
                case SocketState.ClientOnline:
                    break;
                case SocketState.ClientOnOff:
                    break;
                default:
                    break;
            }
        }

        public override bool Write(string msg)
        {
            if (tcpInfo.IsClient) return client.SendCommand(msg, IsHex);
            else return server.SendData(socket, msg, IsHex); 
          
        }

        public override bool Write(byte[] msg)
        {
            if (tcpInfo.IsClient) return client.SendCommand(msg);
            else return server.SendData(socket, msg); 
        }
    }
}
