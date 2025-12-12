using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class ProcessRoute
    {     
        /// <summary>SN</summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string Sn { get; set; } = "";
        /// <summary>玻璃信息</summary>
        public string Glass { get; set; } = "";

        /// <summary>工艺参数</summary>
        public string Route { get; set; } = "";
        /// <summary>配方</summary>
        public string Formula { get; set; } = "";
        /// <summary>镀铜烘干</summary>
        public string CopperingBake { get; set; } = "";
        /// <summary>膜镀铜</summary>
        public string CoatingCoppering {  get; set; } = "";
        /// <summary>膜后浸</summary>
        public string CoatingPostImmersion {  get; set; } = "";
        /// <summary>膜活化</summary>
        public string CoatingActivate {  get; set; } = "";
        /// <summary>膜预浸</summary>
        public string CoatingPrepreg {  get; set; } = "";
        /// <summary>膜改性</summary>
        public string CoatingModified {  get; set; } = "";
        /// <summary>玻璃超声波</summary>
        public string GlassUltrasonicCleaner {  get; set; } = "";
        /// <summary>膜烘干</summary>
        public string CoatingBake {  get; set; } = "";

        /// <summary>玻璃除油</summary>
        public string GlassDegreasing {  get; set; } = "";
        /// <summary>玻璃酸洗</summary>
        public string GlassAcidPickling {  get; set; } = "";
        /// <summary>玻璃烘干</summary>
        public string GlassBake {  get; set; } = "";
        /// <summary>玻璃镀膜</summary>
        public string GlassCoating {  get; set; } = "";
        /// <summary>乙醇清洗</summary>
        public string GlassEthanolCleaning {  get; set; } = "";
    }
}
