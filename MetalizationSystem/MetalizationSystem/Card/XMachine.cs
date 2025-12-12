using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using MetalizationSystem.EnumCollection;

namespace MetalizationSystem
{
    public class XMachine
    {
        static readonly XMachine instance = new XMachine();
        public static XMachine Instance {  get { return instance; } }
       
        public XCard Card = new XCard();

        Dictionary<int, XStation> stationMap = new Dictionary<int, XStation>();

        Dictionary<int, MSerialPort> serialMap = new Dictionary<int, MSerialPort>();

        public bool Initial(string ip)
        {
            bool ret = Card.Initial(ip);
            if (!ret) return false;
            for (int i = 0; i < 3; i++)
            {
                Card.BindAxis(i, 10, "");
            }
            for (int i = 0; i < 80; i++)
            {
                Card.BindDo(i, i.ToString());
                Card.BindDi(i, i.ToString());
            }

            BindStation((int)EnumInfo.AxisId.LinearMotor, 0, -1, -1, -1);
            List<PositionInfo> posList = Globa.DataManager.Axis7;
            for (int i = 0; i < EnumInfo.Axis7PosTotal; i++)
            {
                foreach (var pos in posList)
                {
                    if (pos.Name == ((EnumInfo.Axis7Id)i).ToString())
                    {
                        FindStation((int)EnumInfo.AxisId.LinearMotor).BindPos(i, pos);
                        continue;
                    }
                }
                FindStation((int)EnumInfo.AxisId.LinearMotor).BindPos(i, new PositionInfo(i, ((EnumInfo.Axis7Id)i).ToString(), 0, 0, 0, 0));      
            }
            
            Start();
            return ret;
        }

        public void Start()
        {
            Thread thread = new Thread(Update) { IsBackground = true };
            thread.Start();
        }

        void Update()
        {
            while (true)
            {
                Card.Updata();
                Thread.Sleep(3);
            }
        }
        


        public void Close()
        {
            Card.Close();
        }

        public void BindStation(int stationId, int xId,int yId,int zId,int uId)
        {
            if (!stationMap.ContainsKey(stationId))
            {
                stationMap.Add(stationId, new XStation(xId, yId,zId,uId,Card.Handel ));
            }
        }
        public XStation FindStation(int stationId)
        {
            if (stationMap.ContainsKey(stationId)) return stationMap[stationId];
            return null;
        }

        public void BindSerial(int serialId, string portName, int baudRate, int dataBits, StopBits stopBits, Parity parity, bool isHex = false)
        {
            if (!serialMap.ContainsKey(serialId))
            {
                serialMap.Add(serialId, new MSerialPort(portName, baudRate, dataBits, stopBits, parity, isHex));
            }
        }
        public MSerialPort FindSerial(int serialId)
        {
            if (serialMap.ContainsKey(serialId)) return serialMap[serialId];
            return null;
        }
    }
}
