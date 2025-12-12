using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;

namespace MetalizationSystem.ViewModels.Node
{
    [Serializable]
    public abstract class NodeModel : ObservableObject
    {
        public abstract string Key {  get; set; }
        public abstract int  TaskId { get; set; }
        public abstract string Station { get; set; }
        public abstract string Name { get; set; }
        public abstract string Tag {  get; set; }
        public abstract double Width {  get; set; }
        public abstract double Height { get; set; }
        public abstract bool StationLock { get; set; }     
        public abstract DeviceParameter DevicePar {get;set;}
        public abstract bool NeedRobot { get; set; }

        [NonSerialized]
        double _x;
        public double X
        {
            get => _x;
            set => SetProperty(ref _x, value);
        }
        [NonSerialized]
        double _y;
        public double Y
        {
            get => _y;
            set => SetProperty(ref _y, value);
        }

        public double CenterX { get => (double)Width / 2 + X; }
        public double CenterY { get=> (double)Height / 2 + Y; }
        public double Scale { get; set; } = 1;
        /// <summary>
        /// 类型节点 连线
        /// </summary>
        public int NodeType { get; set; } = 0;
        public NodeModel[] InputLine { get; set; } = new LineModel[2] { null, null };
        public NodeModel[] OutputLine { get; set; } = new LineModel[2] { null, null };
        public abstract void Execute();

    }

    [Serializable]
    public class ParDescribe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public ParDescribe() { }     
    }

 
}
