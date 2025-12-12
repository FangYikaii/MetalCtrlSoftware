using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.BDaq;

namespace XCore
{
    public class XCommandCard1756 : XCommandCard
    {
        //string deviceDescription = "DemoDevice,BID#0";
        //string profilePath = "../../../../../profile/DemoDevice.xml";    
        string deviceDescription = "PCI-1756,BID#0";
        string profilePath = "../../../../../profile/PCI-1756_1.xml";

        private InstantDiCtrl instantDiCtrl = new InstantDiCtrl();
        private InstantDoCtrl instantDoCtrl = new InstantDoCtrl();

        public override int Register(int actCardId)
        {
            try
            {
                instantDoCtrl.SelectedDevice = new DeviceInformation(deviceDescription);
                instantDoCtrl.LoadProfile(profilePath);//Loads a profile to initialize the device.
                if (instantDiCtrl.Initialized) instantDiCtrl.SelectedDevice = new DeviceInformation(actCardId);
                if (instantDoCtrl.Initialized) instantDoCtrl.SelectedDevice = new DeviceInformation(actCardId);               
            }
            catch { return 0; }
            return 1;
        }

        public override int Update(int actCardId)
        {
            Byte diValue0, doValue0;
            for (int channel = 0; channel < 4; channel++)
            {
                instantDiCtrl.Read(channel, out diValue0);
                DI_Data[channel] = diValue0;
                instantDoCtrl.Read(channel, out doValue0);
                DO_Data[channel] = doValue0;
            }
            return 0;
        }

        public override int SetDo(int actCardId, int channel, int index, int sts)
        {
            byte portData;
            instantDoCtrl.Read(channel, out portData);
            int state = portData;
            state &= ~(0x1 << index);
            state |= sts << index;
            return instantDoCtrl.Write(channel, (byte)state) == ErrorCode.Success ? 0 : 1;
        }
        public override int GetDo(int actCardId, int channel, int index, ref int sts)
        {
            sts = (DO_Data[channel] >> index) & 1;
            return 0;
        }
        public override int GetDi(int actCardId, int channel, int index, ref int sts)
        {
            sts = (DI_Data[channel] >> index) & 1;
            return 0;
        }
    }
}
