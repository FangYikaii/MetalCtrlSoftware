using SqlSugar;

namespace MetalizationSystem.DataCollection
{
    public class AlgoProjConfig
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; } = 0;
        public string Key { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
