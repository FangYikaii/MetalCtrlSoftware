using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.VariantTypes;
using Modbus.Device;
using System.Net.Sockets;

namespace MetalizationSystem.Devices
{
    public class PT100
    {
        ModbusIpMaster master;
        TcpClient client;

        public double[] Temperature = new double[21];
        public PT100(IPAddress iPAddress, short port)
        {

            try
            {
                client = new TcpClient();
                //client.Connect(iPAddress, port);
                master = ModbusIpMaster.CreateIp(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to PT100: {ex.Message}");
            }
            Thread th = new Thread(Update) { IsBackground = true };
            th.Start();
        }

        public bool Connected
        {
            get 
            {
                if (client == null)
                {
                    return false;
                }
                else
                {
                    return client.Connected;
                }
            }
        }
        void Update()
        {
            while (true)
            {
                if (!Connected) continue;
                ushort[] ushorts1 = master.ReadInputRegisters(1, 100, 6);
                for (int i = 0; i < ushorts1.Length; i++) {
                    Temperature[i + 1] = ushorts1[i] / 10;
                }
                Thread.Sleep(1000);        
            }
        }
    }
}
