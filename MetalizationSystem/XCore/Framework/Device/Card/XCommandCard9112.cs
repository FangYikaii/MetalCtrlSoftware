using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public class XCommandCard9112 : XCommandCard
    {
        private double zeroV = 65535 / 2;
        private double dataV = 32768 / 10;
        private ushort raw = 0;

        public override int Register(int actCardId)
        {
            int ret;
            ret = DASK.Register_Card(DASK.PCI_9112, (ushort)actCardId);
            if (ret != 0)
            {
                return ret;
            }
            return DASK.AI_9112_Config((ushort)actCardId, DASK.TRIG_INT_PACER);
        }

        public override int ReadChannel(int actCardId, int channel, out double value)
        {
            value = 0;
            int ret = DASK.AI_ReadChannel((ushort)actCardId, (ushort)channel, DASK.AD_B_10_V, out raw);
            if (ret != 0)
            {
                return ret;
            }
            value = (raw - zeroV) / dataV;
            return 0;
        }

        //public override int ReadChannel(int actCardId, int channel, out ushort value)
        //{
        //    return DASK.AI_ReadChannel((ushort)actCardId, (ushort)channel, DASK.AD_B_10_V, out value);
        //}

        public override int WriteChannel(int actCardId, int channel, double value)
        {
            return DASK.AO_WriteChannel((ushort)actCardId, (ushort)channel, (short)(value * (4096 / 10)));
        }
    }
}
