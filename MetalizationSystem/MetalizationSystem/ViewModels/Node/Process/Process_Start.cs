using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using MetalizationSystem.EnumCollection;

namespace MetalizationSystem.ViewModels.Node
{
    [Serializable]
    public class Process_Start : NodeModel
    {
        public override string Key { get; set; }
        public override string Station { get; set; } = "Start";
        public override int TaskId { get; set; } = -1;
        public override string Name { get; set; } = "Start";
        public override string Tag { get; set; } = "Process_Start";
        public override double Width { get; set; } = 100;
        public override double Height {  get; set; } = 100;
        public override bool StationLock { get; set; } = false;
        public override DeviceParameter DevicePar { get; set; }
        public override bool NeedRobot { get; set; } = false;
        public override void Execute()
        {
           
        }
    }
}
