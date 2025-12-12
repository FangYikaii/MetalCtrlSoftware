using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem
{
    /// <summary>生成指令集</summary>
    public class Instruction
    {
        /// <summary>定量泵指令：设置新的地址</summary>
        public static byte[] FixPumpId(int id, int newId)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x06);
            bytes.Add(0x00);
            bytes.Add(0x0A);
            bytes.Add(0x00);
            bytes.Add((byte)newId);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }
        /// <summary>定量泵指令：设置转圈数</summary>
        public static byte[] FixPumpCapacity(int id, int capacity)
        {

            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x06);
            bytes.Add(0x00);
            bytes.Add(0x14);
            bytes.Add((byte)(capacity / 256));
            bytes.Add((byte)(capacity % 256));
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }
        /// <summary>定量泵指令：设置转速</summary>
        public static byte[] FixPumpSpeed(int id, int speed)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x06);
            bytes.Add(0x00);
            bytes.Add(0x0C);
            bytes.Add((byte)(speed / 256));
            bytes.Add((byte)(speed % 256));
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }
        /// <summary>定量泵指令：检查状态</summary>
        public static byte[] FixPumpStatus(int id)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x03);
            bytes.Add(0x00);
            bytes.Add(0x14);
            bytes.Add(0x00);
            bytes.Add(0x00);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }
        /// <summary>定量泵指令：停止</summary>
        public static byte[] FixPumpStop(int id)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x05);
            bytes.Add(0x01);
            bytes.Add(0x00);
            bytes.Add(0x00);
            bytes.Add(0x00);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }
        /// <summary>定量泵指令：继续</summary>
        public static byte[] FixPumpContinue(int id)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x05);
            bytes.Add(0x01);
            bytes.Add(0x00);
            bytes.Add(0xFF);
            bytes.Add(0x00);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }

        /// <summary>温控仪指令：设置目标温度</summary>
        public static byte[] TempCtrl_WriteSV(int id, int channel, double SV)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x06);
            bytes.Add(0x00);
            switch(channel)
            {
                case 1:
                    bytes.Add(0x20);
                    break;
                case 2:
                    bytes.Add(0x30);
                    break;
                case 3:
                    bytes.Add(0x40);
                    break;
                case 4:
                    bytes.Add(0x50);
                    break;
                default:
                    throw new ArgumentException("Channel must be between 1 and 4.");
            }
            bytes.Add((byte)(SV / 256));
            bytes.Add((byte)(SV % 256));
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }

        /// <summary>温控仪指令：正常PID运行状态</summary>
        public static byte[] TempCtrl_SetPIDState(int id, int channel)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x06);
            bytes.Add(0x00);
            switch (channel)
            {
                case 1:
                    bytes.Add(0x2B);
                    break;
                case 2:
                    bytes.Add(0x3B);
                    break;
                case 3:
                    bytes.Add(0x4B);
                    break;
                case 4:
                    bytes.Add(0x5B);
                    break;
                default:
                    throw new ArgumentException("Channel must be between 1 and 4.");
            }
            bytes.Add(0x00);
            bytes.Add(0x00);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }

        /// <summary>温控仪指令：停止状态</summary>
        public static byte[] TempCtrl_SetStopState(int id, int channel)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x06);
            bytes.Add(0x00);
            switch (channel)
            {
                case 1:
                    bytes.Add(0x2B);
                    break;
                case 2:
                    bytes.Add(0x3B);
                    break;
                case 3:
                    bytes.Add(0x4B);
                    break;
                case 4:
                    bytes.Add(0x5B);
                    break;
                default:
                    throw new ArgumentException("Channel must be between 1 and 4.");
            }
            bytes.Add(0x00);
            bytes.Add(0x0A);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }

        /// <summary>温控仪指令：读取当前温度</summary>
        public static byte[] TempCtrl_ReadPV(int id)
        {
            List<byte> bytes = new List<byte>();
            bytes.Add((byte)id);
            bytes.Add(0x03);
            bytes.Add(0x00);
            bytes.Add(0x80);
            bytes.Add(0x00);
            bytes.Add(0x04);
            byte[] arr = bytes.ToArray();
            int ret = CrcCheck(arr);
            bytes.Add((byte)(ret & 0X00FF));
            bytes.Add((byte)((ret & 0XFF00) >> 8));
            return bytes.ToArray();
        }
        static int CrcCheck(byte[] data) //16 位CRC 校验
        {
            short i, j;
            int len = data.Length;
            int polynom = 0xA001;
            if (len > 0)
            {
                int crc = 0xFFFF;
                for (i = 0; i < len; i++)
                {
                    crc = (int)(crc ^ (data[i]));
                    for (j = 0; j < 8; j++)
                        crc = (crc & 1) != 0 ? (int)((crc >> 1) ^ polynom) : (int)(crc >> 1);
                }
                return crc;
            }
            return 0;
        }
    }
}
