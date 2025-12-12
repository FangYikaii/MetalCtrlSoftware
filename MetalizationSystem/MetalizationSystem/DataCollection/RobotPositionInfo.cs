using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class RobotPositionInfo
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double U { get; set; }
        public double V { get; set; }
        public double W { get; set; }
        public RobotPositionInfo(int id,string name, double x, double y, double z, double u, double v, double w)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Z = z;
            U = u;
            V = v;
            W = w;
        }
    }
}
