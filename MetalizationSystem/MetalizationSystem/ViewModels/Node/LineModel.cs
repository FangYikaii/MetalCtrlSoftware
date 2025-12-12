using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;

namespace MetalizationSystem.ViewModels.Node
{
    [Serializable]
    public  class LineModel : NodeModel
    {
        public override string Key { get; set; }
        public override string Station { get; set; }
        public override int TaskId { get; set; }
        public override string Name { get;set; }
        public override string Tag { get; set; } = "LineModel";
        public override double Width { get; set; } = 0;
        public override double Height { get; set; } = 0;
        public override bool StationLock { get; set; } = false;
        public override DeviceParameter DevicePar { get; set; }
        public override bool NeedRobot { get; set; } = false;
        double _sx;
        public double Sx
        {
            get => _sx;
            set => SetProperty(ref _sx, value);
        }
        double _sy;
        public double Sy
        {
            get => _sy;
            set => SetProperty(ref _sy, value);
        }
        double _ex;
        public double Ex
        {
            get => _ex;
            set => SetProperty(ref _ex, value);
        }
        double _ey;
        public double Ey
        {
            get => _ey;
            set => SetProperty(ref _ey, value);
        }

        double _x1;
        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }
        double _y1;
        public double Y1
        {
            get => _y1;
            set => SetProperty(ref _y1, value);
        }
        double _x2;
        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }
        double _y2;
        public double Y2
        {
            get => _y2;
            set => SetProperty(ref _y2, value);
        }
        double _x3;
        public double X3
        {
            get => _x3;
            set => SetProperty(ref _x3, value);
        }
        double _y3;
        public double Y3
        {
            get => _y3;
            set => SetProperty(ref _y3, value);
        }
        double _x4;
        public double X4
        {
            get => _x4;
            set => SetProperty(ref _x4, value);
        }
        double _y4;
        public double Y4
        {
            get => _y4;
            set => SetProperty(ref _y4, value);
        }

        public string Input { get; set; }
        public string Output { get; set; }
 

        //public NodeModel Input { get; set; }
        //public NodeModel Output { get; set; }


        public override void Execute()
        {
          
        }
    }


}
