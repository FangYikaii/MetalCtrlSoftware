using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2016.Excel;
using Modbus.Device;

namespace Xugz
{
    public class XCommModbus : XComm
    {
        ModbusMaster master;
        MySerialPort serialPort;  
        DMTcpClient client;
        bool connected;
        public override bool Connected
        {
            get
            {
                if (serialPort != null) return serialPort.isPortOpen;
                if (client != null) return connected;
                return false;
            }
        }

        public override event Receive OnReceive;

        public override void Close()
        {
            if (serialPort != null) serialPort.ClosePort();           
            else if (client != null)
            {               
                client.PauseConnection();
                client.StopConnection();
            }           
        }

        public override bool Init(XCommInfo info, bool isHex = false)
        {
            try
            {
                if (info.Type == XCommInfo.ModbusType.None | info.Type == XCommInfo.ModbusType.Tcp) return false;
                if ( info is XSerialPortInfo)
                {
                    XSerialPortInfo sInfo = info as XSerialPortInfo;
                    if (sInfo == null) return false;
                    serialPort = new MySerialPort();
                    serialPort.OnReceiveString += SerialPort_OnReceiveString;
                    serialPort.PortName = sInfo.Port.ToUpper();
                    serialPort.BaudRate = sInfo.Baudrate;
                    serialPort.DataBits = sInfo.Databits;
                    serialPort.StopBits = sInfo.StopBits;
                    serialPort.Parity = sInfo.Parity;
                    serialPort.OpenPort();
                    switch (sInfo.Type)
                    {
                        case XCommInfo.ModbusType.Ascii:
                            master = ModbusSerialMaster.CreateAscii(serialPort.ComPort);
                            break;
                        case XCommInfo.ModbusType.Rtu:
                            master = ModbusSerialMaster.CreateRtu(serialPort.ComPort);
                            break;
                        case XCommInfo.ModbusType.Tcp:
                            master = ModbusIpMaster.CreateIp(serialPort.ComPort);
                            break;                    
                    }             
                }
                else if (info is XTcpInfo)
                {
                    XTcpInfo tInfo = info as XTcpInfo;
                    if (tInfo == null) return false;
                    client = new  DMTcpClient();
                    client.OnStateInfo += Client_OnStateInfo;
                    client.OnReceviceByte += Client_OnReceviceByte;
                    client.OnErrorMsg += Client_OnErrorMsg;
                    client.ServerIp = tInfo.IPAddress;
                    client.ServerPort = tInfo.Port;
                    client.StartConnection();
                    switch (tInfo.Type)
                    {
                        case XCommInfo.ModbusType.Ascii:
                            master = ModbusSerialMaster.CreateAscii(client.Tcpclient);
                            break;
                        case XCommInfo.ModbusType.Rtu:
                            master = ModbusSerialMaster.CreateRtu(client.Tcpclient);
                            break;
                        case XCommInfo.ModbusType.Tcp:
                            master = ModbusIpMaster.CreateIp(client.Tcpclient);
                            break;
                    }
                }
                master.Transport.ReadTimeout = 300;
                master.Transport.Retries = 5;
                master.Transport.WriteTimeout = 300;
            }
            catch { return false; }
            return true;

        }

        private void Client_OnErrorMsg(string msg)
        {
           connected = false;
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
                    Log.Info($"已成功连接服务器");
                    break;
                case SocketState.Reconnection:
                    break;
                case SocketState.Disconnect:
                    if (connected == true) connected = false;
                    Log.Info($"已成功连接服务器");
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

        private void SerialPort_OnReceiveString(string str)
        {
            OnReceive?.Invoke(str);
        }
        /// <summary>
        /// 写单个寄存器Bit
        /// </summary>
        /// <param name="slaveAddress"></param>
        /// <param name="registerAdress"></param>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void WriteSingleRegister(byte slaveAddress, ushort registerAdress, ushort id, ushort value)
        {
            if (!Connected) return;
            ushort[] vv = master.ReadHoldingRegisters(slaveAddress, registerAdress, 1);
            value = SetBit(vv[0], id, value);
            master.WriteSingleRegister(slaveAddress, registerAdress, value);
        }
        ushort SetBit(int statu, int pos, int value)
        {
            ushort ret = 0;
            switch (value)
            {
                case 0:
                    ret = (ushort)(statu ^ (1 << pos));
                    break;
                case 1:
                    ret = (ushort)(statu & ((1 << 16 - 1) - (1 << pos)));
                    break;
            }
            return ret;
        }
        public bool[] ReadCoils(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return new bool[numberOfPoints]; 
            return master.ReadCoils(slaveAddress, startAddress, numberOfPoints);          
        }

        public Task<bool[]> ReadCoilsAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
          
            if (!Connected) return Task.Factory.StartNew(() => new bool[numberOfPoints]);
            return master.ReadCoilsAsync(slaveAddress, startAddress, numberOfPoints);           
        }

        public ushort[] ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return new ushort[numberOfPoints];
            return master.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);           
        }

        public Task<ushort[]> ReadHoldingRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return Task.Factory.StartNew(() => new ushort[numberOfPoints]);
            return master.ReadHoldingRegistersAsync(slaveAddress, startAddress, numberOfPoints);       
        }

        public ushort[] ReadInputRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return new ushort[numberOfPoints];
            return master.ReadInputRegisters(slaveAddress, startAddress, numberOfPoints); 
        }

        public Task<ushort[]> ReadInputRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return Task.Factory.StartNew(() => new ushort[numberOfPoints]);
            return master.ReadInputRegistersAsync(slaveAddress, startAddress, numberOfPoints);           
        }

        public bool[] ReadInputs(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return new bool[numberOfPoints];
            return master.ReadInputs(slaveAddress, startAddress, numberOfPoints);
        }

        public Task<bool[]> ReadInputsAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (!Connected) return Task.Factory.StartNew(() => new bool[numberOfPoints]);
            return master.ReadInputsAsync(slaveAddress, startAddress, numberOfPoints);
        }

        public ushort[] ReadWriteMultipleRegisters(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData)
        {
            if (!Connected) return new ushort[numberOfPointsToRead];
            return master.ReadWriteMultipleRegisters(slaveAddress, startReadAddress, numberOfPointsToRead, startWriteAddress, writeData);
        }

        public Task<ushort[]> ReadWriteMultipleRegistersAsync(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData)
        {
            if (!Connected) return Task.Factory.StartNew(() => new ushort[numberOfPointsToRead]);
            return master.ReadWriteMultipleRegistersAsync(slaveAddress, startReadAddress, numberOfPointsToRead, startWriteAddress, writeData);
        }

        public override bool Write(string msg)
        {
            return false;
        }

        public override bool Write(byte[] msg)
        {
            return false;
        }

        public void WriteMultipleCoils(byte slaveAddress, ushort startAddress, bool[] data)
        {
            if (!Connected) return;
           master.WriteMultipleCoils(slaveAddress, startAddress, data);
        }

        public async Task WriteMultipleCoilsAsync(byte slaveAddress, ushort startAddress, bool[] data)
        {
            if (!Connected) return;
            await master.WriteMultipleCoilsAsync(slaveAddress, startAddress, data);
        }

        public void WriteMultipleRegisters(byte slaveAddress, ushort startAddress, ushort[] data)
        {
            if (!Connected) return;
            master.WriteMultipleRegisters(slaveAddress, startAddress, data);
        }

        public async Task WriteMultipleRegistersAsync(byte slaveAddress, ushort startAddress, ushort[] data)
        {
            if (!Connected) return;
            await  master.WriteMultipleRegistersAsync(slaveAddress, startAddress, data); 
        }

        public void WriteSingleCoil(byte slaveAddress, ushort coilAddress, bool value)
        {
            if (!Connected) return;
            master.WriteSingleCoil(slaveAddress, coilAddress, value);
        }

        public async Task WriteSingleCoilAsync(byte slaveAddress, ushort coilAddress, bool value)
        {
            if (!Connected) return;
            await master.WriteSingleCoilAsync(slaveAddress, coilAddress, value);
        }

        public void WriteSingleRegister(byte slaveAddress, ushort registerAddress, ushort value)
        {
            if (!Connected) return;
            master.WriteSingleRegister(slaveAddress, registerAddress, value);
        }

        public async Task WriteSingleRegisterAsync(byte slaveAddress, ushort registerAddress, ushort value)
        {
            if (!Connected) return;
            await master.WriteSingleRegisterAsync(slaveAddress, registerAddress, value);
        }
    }
}
