using SqlSugar;

namespace MetalizationSystem.DataCollection
{
    public class Samples
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string barCode { get; set; } = "";
        public int BatchID { get; set; } = 0;
        public int InternalNum { get; set; } = 0;
        public float Coverage { get; set; } = 0.0f;
        public string OriginalImagePath { get; set; } = "";
        public string ProcessedImagePath { get; set; } = "";
        public float Uniformity { get; set; } = 0.0f;
        public string AbnormalitiesJson { get; set; } = "";
        public string AbnormalImagePath { get; set; } = "";
        public string UniformityAnalysisImagePath { get; set; } = "";
        public string CoverageAnalysisImagePath { get; set; } = "";
        public string CreatedAt { get; set; } = "";
        public string UpdatedAt { get; set; } = "";

    }
}
