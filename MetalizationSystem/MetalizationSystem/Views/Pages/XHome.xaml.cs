using MetalizationSystem.Devices;
using MetalizationSystem.EnumCollection;
using System.Threading;

namespace MetalizationSystem.Views;

/// <summary>
/// XHome.xaml 的交互逻辑
/// </summary>
public partial class XHome : UserControl
{
    public XHome()
    {
        DataContext = new XHomeViewModel();
        InitializeComponent();
    }
}
