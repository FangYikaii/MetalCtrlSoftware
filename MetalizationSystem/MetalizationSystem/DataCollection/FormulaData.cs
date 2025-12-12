using SqlSugar;

namespace MetalizationSystem.DataCollection
{
    public class FormulaData
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; } = 0;
        public int FormulaId { get; set; } = 0;
        public string FormulaName { get; set; } = "";

    }
}
