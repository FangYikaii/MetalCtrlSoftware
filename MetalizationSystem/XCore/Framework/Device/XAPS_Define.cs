using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    class XAPS_Define : XObject
    {
        public const int MIO_ALM = 0x01 << 0;
        public const int MIO_PEL = 0x01 << 1;
        public const int MIO_MEL = 0x01 << 2;
        public const int MIO_ORG = 0x01 << 3;
        public const int MIO_EMG = 0x01 << 4;
        public const int MIO_SVON = 0x01 << 5;

        /// <summary>回零中</summary>
        public const int MTS_HMV = 0x01 << 0;
        /// <summary>动作完成  0：运动中； 1：运动完成（可能是异常停止）</summary>
        public const int MTS_MDN = 0x01 << 1;
        /// <summary>报警</summary>
        public const int MTS_ASTP = 0x01 << 2;
    }
    class ZCM_Define : XObject
    {
        public const int MIO_ALM = 0x01 << 2;
        /// <summary>正限位</summary>
        public const int MIO_PEL = 0x01 << 1;
        /// <summary>负限位</summary>
        public const int MIO_MEL = 0x01 << 2;
        /// <summary>原点</summary>
        public const int MIO_ORG = 0x01 << 3;
        /// <summary>急停</summary>
        public const int MIO_EMG = 0x01 << 4;
        public const int MIO_SVON = 0x01 << 5;

        /// <summary>回零中</summary>
        public const int MTS_HMV = 0x01 << 6;
        /// <summary>动作完成  0：运动中； 1：运动完成（可能是异常停止）</summary>
        public const int MTS_MDN = 0x01 << 22;
        /// <summary>报警</summary>
        public const int MTS_ASTP = 0x01 << 2;
    }
}
