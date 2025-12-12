using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;

namespace MetalizationSystem.ViewModels.Node
{
    [Serializable]
    public class NodeSerialze
    {
        public string Key { get; set; }
        public string Station { get; set; }
        public int TaskId { get ; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public double Width { get; set; } = 0;
        public double Height { get; set; } = 0;
        public bool StationLock { get; set; }
        public DeviceParameter DevicePar { get; set; }
        public  bool NeedRobot { get; set; } 
        public double X {  get; set; }
        public double Y { get; set; }
        public double CenterX { get => (double)Width / 2 + X; }
        public double CenterY { get => (double)Height / 2 + Y; }
        public double Scale { get; set; } = 1;
        public int NodeType { get; set; } = 0;
        public double Sx { get; set; }
       
        public double Sy { get; set; }
       
        public double Ex { get; set; }
       
        public double Ey { get; set; }    
        public double X1 { get; set; }
        public double Y1 { get; set; } 
        public double X2 { get; set; }
        public double Y2 { get; set; }  
        public double X3 { get; set; }  
        public double Y3 { get; set; }      
        public double X4 { get; set; }       
        public double Y4 { get; set; }        
        public string Input { get; set; }
        public string Output { get; set; }

    }

 
}
