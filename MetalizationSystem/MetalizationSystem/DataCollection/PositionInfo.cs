using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.EnumCollection;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class PositionInfo
    {     
        public int Id { get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double U { get; set; }
        public PositionInfo() { }
        public PositionInfo(int id, string name, double x, double y, double z, double u)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Z = z;
            U = u;
        }
              
    }
}
