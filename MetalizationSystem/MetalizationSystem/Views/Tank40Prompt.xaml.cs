using MetalizationSystem.ViewModels;
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
using System.Windows.Shapes;

namespace MetalizationSystem.Views
{
    /// <summary>
    /// Tank40Prompt.xaml 的交互逻辑
    /// </summary>
    public partial class Tank40Prompt : Window
    {
        public Tank40Prompt(Tank40PromptViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        // 防止用户通过关闭按钮关闭窗口，只能通过继续运行按钮关闭
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            // 不允许通过标题栏关闭按钮关闭窗口
            // e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
