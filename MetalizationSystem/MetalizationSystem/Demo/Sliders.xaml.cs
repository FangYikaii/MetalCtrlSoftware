using MetalizationSystem.Domain;

namespace MetalizationSystem
{
    public partial class Sliders
    {
        public Sliders()
        {
            DataContext = new SlidersViewModel();
            InitializeComponent();
        }
    }
}
