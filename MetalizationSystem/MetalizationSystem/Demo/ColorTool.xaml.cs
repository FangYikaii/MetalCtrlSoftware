using MaterialDesignDemo.Shared.Domain;

namespace MetalizationSystem
{
    public partial class ColorTool
    {
        public ColorTool()
        {
            DataContext = new ColorToolViewModel();
            InitializeComponent();
        }
    }
}
