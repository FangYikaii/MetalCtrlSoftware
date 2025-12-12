using MetalizationSystem.Domain;

namespace MetalizationSystem
{
    public partial class Lists
    {
        public Lists()
        {
            DataContext = new ListsAndGridsViewModel();
            InitializeComponent();
        }
    }
}
