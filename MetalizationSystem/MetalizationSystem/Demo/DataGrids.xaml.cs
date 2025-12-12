using MetalizationSystem.Domain;

namespace MetalizationSystem
{
    public partial class DataGrids
    {
        public DataGrids()
        {
            DataContext = new ListsAndGridsViewModel();
            InitializeComponent();
        }
    }
}
