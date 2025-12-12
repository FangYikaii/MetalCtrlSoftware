using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;

namespace MetalizationSystem.ViewModels.Node
{
    [Serializable]
    public class TreeNode
    {
        public int TaskId {  get; set; }
        public string Station {  get; set; }
        public string Name { get; set; }
        public string Key {  get; set; }
        public string Sn {  get; set; }        
        public bool IsWorking { get; set; } = false;
        public DeviceParameter DevicePar { get; set; }
        public bool NeedRun = true;
        public bool NeedTwoWay = false;
        public bool NeedRobot { get; set; }
        public bool StationLock { get; set; } = false;
        public TreeNode() { }  

    }
    [Serializable]
    public class TreeWorkFlow
    {
        public TreeNode Node { get; set; }
        public List<TreeWorkFlow> WorkFlows { get; set; }= new List<TreeWorkFlow>();
    }
}
