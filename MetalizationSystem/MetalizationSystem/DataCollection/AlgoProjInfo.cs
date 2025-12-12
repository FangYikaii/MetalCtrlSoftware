using SqlSugar;

namespace MetalizationSystem.DataCollection
{
    public class AlgoProjInfo
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; } = 0;
        public string ProjName { get; set; } = "";
        public string CreateTime { get; set; } = "";
        public int IterNum { get; set; } = 0;

        public int Phase1MaxNum { get; set; } = 0;

        public int Phase2MaxNum { get; set; } = 0;

        public int IterId { get; set; } = 0;
        public int DisplayId { get; set; } = 0;
        public int UploadId { get; set; } = 0;
        public int DownloadId { get; set; } = 0;
        public int AlgoGenId { get; set; } = 0;
        public int AlgoRecevId { get; set; } = 0;
        public int AlogPlotId { get; set; } = 0;
        public int ConfigBarCodeId { get; set; } = 0;
        public int BatchNum { get; set; } = 0;
        public string SavePath { get; set; } = "";
        public int ExpId { get; set; } = 0;

    }
}
