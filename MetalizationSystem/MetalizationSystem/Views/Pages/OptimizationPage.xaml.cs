using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MetalizationSystem.Views.Pages
{
    /// <summary>
    /// OptimizationPage.xaml 的交互逻辑
    /// </summary>
    public partial class OptimizationPage : UserControl
    {
        public OptimizationPage()
        {
            DataContext = new OptimizationPageViewModel();
            InitializeComponent();
        }
    }
}
