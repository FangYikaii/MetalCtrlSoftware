using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class DryBoxInfo
    {
        public string Port { get; set; } = "COM1";
        /// <summary>时间 【单位：min】 </summary>
        public int Time { get; set; } = 0;
        /// <summary>时间 【单位：ms】 </summary>
        public int GetTime { get { return Time * 60 * 1000; } }
        public double Temperature { get; set; } = 0;

    }
}
