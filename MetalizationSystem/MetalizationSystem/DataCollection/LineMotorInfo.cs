using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class LineMotorInfo
    {
        public int Speed { get; set; } = 100;
        public int Acc { get; set; } = 1;
        public int Dcc { get; set; } = 1;
    }
}
