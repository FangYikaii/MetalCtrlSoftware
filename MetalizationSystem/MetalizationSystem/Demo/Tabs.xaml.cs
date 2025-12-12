using MetalizationSystem.Domain;

namespace MetalizationSystem
{
    /// <summary>
    /// Interaction logic for Tabs.xaml
    /// </summary>
    public partial class Tabs
    {
        public Tabs()
        {
            DataContext = new TabsViewModel();
            InitializeComponent();
        }
    }
}
