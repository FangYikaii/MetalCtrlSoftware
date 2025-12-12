using MetalizationSystem.Domain;

namespace MetalizationSystem
{
    public partial class PaletteSelector
    {
        public PaletteSelector()
        {
            DataContext = new PaletteSelectorViewModel();
            InitializeComponent();
        }
    }
}
