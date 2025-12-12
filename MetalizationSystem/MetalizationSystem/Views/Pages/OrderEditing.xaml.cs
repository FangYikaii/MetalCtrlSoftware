namespace MetalizationSystem.Views;

/// <summary>
/// OrderEditing.xaml 的交互逻辑
/// </summary>
public partial class OrderEditing : UserControl
{
    public OrderEditing()
    {
        DataContext = new OrderEditingViewModel() { IsActive = true };
        InitializeComponent();
    }
}
