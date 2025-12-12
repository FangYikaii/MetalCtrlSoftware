using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class CharacterizationResult
    {
        /// <summary>镀膜后结果</summary>
        public bool Coating { get; set; } = false;
        /// <summary>镀铜后结果</summary>
        public bool Coppering {  get; set; } = false;
        /// <summary>电镀后结果</summary>
        public bool Plating { get; set; } = false;
    }
}
