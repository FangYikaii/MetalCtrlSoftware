namespace MetalizationSystem.Views;

/// <summary>
/// IOMonitor.xaml 的交互逻辑
/// </summary>
public partial class IOMonitor : UserControl
{
    public IOMonitor()
    {
        DataContext = new IOMonitorViewModel();
        InitializeComponent();
    }
}
