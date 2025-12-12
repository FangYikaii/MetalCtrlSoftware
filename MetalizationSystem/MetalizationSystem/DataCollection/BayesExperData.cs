using CommunityToolkit.Mvvm.Messaging.Messages;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xugz;

namespace MetalizationSystem.DataCollection
{
    public class BayesExperData
    {
        // 注意：数据库表的主键是 ExpID, IterId, Phase（复合主键），不是 Id
        public string ProjName { get; set; } = "";

        [SugarColumn(IsPrimaryKey = true)]
        public string Phase { get; set; } = "";
        [SugarColumn(IsPrimaryKey = true)]
        public int IterId { get; set; } = 0;
        [SugarColumn(IsPrimaryKey = true)]
        public int ExpID { get; set; } = 0;
        public int Formula { get; set; } = 0;
        public double Concentration { get; set; } = 0.0;
        public int Temperature { get; set; } = 0;
        public int SoakTime { get; set; } = 0;
        public double PH { get; set; } = 0.0;
        public double CuringTime { get; set; } = 0.0;
        public string MetalAType { get; set; } = "";
        public string MetalBType { get; set; } = "";
        public double MetalAConc { get; set; } = 0.0;
        public double MetalMolarRatio { get; set; } = 0.0;
        public double Coverage { get; set; } = 0.0;
        public double Uniformity { get; set; } = 0.0;
        public double Adhesion { get; set; } = 0.0;
        public bool IsRunning { get; set; } = false;
        public bool DataCheck { get; set; } = false;
        public string Barcode { get; set; }
    }
}
