using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public  class NodeNetworkInfo
    {
        public List<Node> Nodes { get; set; } = new List<Node>();
        public List<Connection> Connections { get; set; } = new List<Connection>();
        [Serializable]
        public class Node
        {
            public string Name { get; set; }

            public Point Position { get; set; }

            public List<string> Inputs { get; set; } = new List<string>();
            public List<string> Outputs { get; set; } = new List<string>();
        }
        [Serializable]
        public class Connection
        {
            public string Input { get; set; }
            public string Output { get; set; }
        }



    }
}
