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
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; } = 0;
        public string ProjName { get; set; } = "";

        public string Phase { get; set; } = "";
        public int IterId { get; set; } = 0;
        public int ExpID { get; set; } = 0;
        public int Formula { get; set; } = 0;
        public int Concentration { get; set; } = 0;
        public int Temperature { get; set; } = 0;
        public int SoakTime { get; set; } = 0;
        public double PH { get; set; } = 0.0;
        public double CuringTime { get; set; } = 0.0;
        public double MetalAConc { get; set; } = 0.0;
        public double MetalBConc { get; set; } = 0.0;
        public double MetalMolarRatio { get; set; } = 0.0;
        public double Coverage { get; set; } = 0.0;
        public double Uniformity { get; set; } = 0.0;
        public bool Adhesion { get; set; } = false;
        public bool IsRunning { get; set; } = false;
        public bool DataCheck { get; set; } = false;
        public string Barcode { get; set; }
    }
}
