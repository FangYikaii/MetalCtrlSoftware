using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus;
using System.Reflection;
using System.Threading;
using Xugz;
using System.Net;


namespace XCore
{
    public class XCommandCardIOSrndIO : XCommandCard
    {
        public string Ip= "192.168.2.7";
        XCommModbus modbus = new XCommModbus();
        
        //ModbusRtuOverTcp modbus = new ModbusRtuOverTcp();
        public override int Register(int actCardId)
        {
            try
            {
                XTcpInfo xTcp = new XTcpInfo(IPAddress.Parse(Ip), 23, true);
                xTcp.Type = XCommInfo.ModbusType.Rtu;
                modbus.Init(xTcp, false);
                if (!modbus.Connected) return 0;
            }
            catch { return 0; }
            return 1;
        }

        public override int Update(int actCardId)
        {
           
            bool[] diValue =new bool[16];
            bool[] doValue =new bool[16];
            try
            {
                if (modbus.Connected) diValue = modbus.ReadInputs(1, 0, 16);
                if (modbus.Connected) doValue = modbus.ReadCoils(1, 0, 16);
            }
            catch (Exception ex) { }                     
            DI_Data = new int[16];
            DO_Data = new int[16];
            for (int channel = 0; channel < 16; channel++)
            {
                DI_Data[channel] = diValue[channel] ? 1 : 0;
                DO_Data[channel] = doValue[channel] ? 1 : 0;
            }
            return 0;
        }

        public override int SetDo(int actCardId, int channel, int index, int sts)
        {
            byte portData;
            modbus.WriteSingleCoil(1, (ushort)index, sts == 1);
            int ret = modbus.ReadCoils(1, (ushort)index, 1)[0] ? 1 : 0; ;
            return ret;
        }
        public override int GetDo(int actCardId, int channel, int index, ref int sts)
        {
            sts = DO_Data[index];
            return sts;
        }
        public override int GetDi(int actCardId, int channel, int index, ref int sts)
        {
            sts = DI_Data[index];
            return sts;
        }
    }
}
