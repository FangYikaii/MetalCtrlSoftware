using MetalizationSystem.Domain;

namespace MetalizationSystem
{
    public partial class ThemeSettings
    {
        public ThemeSettings()
        {
            DataContext = new ThemeSettingsViewModel();
            InitializeComponent();
        }
    }
}
