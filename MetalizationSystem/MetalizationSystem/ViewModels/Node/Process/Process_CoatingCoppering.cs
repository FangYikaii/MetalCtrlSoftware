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
    public class Process_CoatingCoppering : NodeModel
    {
        public override string Key { get; set; }
        public override string Station { get; set; } = "膜镀铜";
        public override string Name { get; set; } = "膜镀铜";
        public override int TaskId { get; set; } = (int)EnumInfo.TaskId.CoatingCoppering;
        public override string Tag { get; set; } = "Process_CoatingCoppering";
        public override double Width { get; set; } = 100;
        public override double Height {  get; set; } = 100;
        public override bool StationLock { get; set; } = false;
        public override DeviceParameter DevicePar { get; set; }
        public override bool NeedRobot { get; set; } = true;
        public override void Execute()
        {
           
        }
    }
}
