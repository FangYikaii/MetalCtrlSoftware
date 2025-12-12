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
using MetalizationSystem.ViewModels;

namespace MetalizationSystem.Views.Pages
{
    /// <summary>
    /// OptimizationPage.xaml 的交互逻辑
    /// </summary>
    public partial class OptimizationPage : UserControl
    {
        private OptimizationPageViewModel viewModel;
        private DataGridTextColumn formulaColumn;
        private DataGridTextColumn concentrationColumn;
        private DataGridTextColumn tempColumn;
        private DataGridTextColumn soakTimeColumn;
        private DataGridTextColumn phColumn;
        private DataGridTextColumn curingTimeColumn;
        private DataGridTextColumn metalATypeColumn;
        private DataGridTextColumn metalAConcColumn;
        private DataGridTextColumn metalBTypeColumn;
        private DataGridTextColumn metalMolarRatioColumn;

        public OptimizationPage()
        {
            InitializeComponent();
            viewModel = new OptimizationPageViewModel();
            DataContext = viewModel;
            
            // 订阅属性变化事件
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            
            // 在 Loaded 事件中获取列引用
            this.Loaded += OptimizationPage_Loaded;
        }

        private void OptimizationPage_Loaded(object sender, RoutedEventArgs e)
        {
            // 使用 x:Name 直接获取列的引用
            formulaColumn = FormulaColumn;
            concentrationColumn = ConcentrationColumn;
            tempColumn = TempColumn;
            soakTimeColumn = SoakTimeColumn;
            phColumn = PHColumn;
            curingTimeColumn = CuringTimeColumn;
            metalATypeColumn = MetalATypeColumn;
            metalAConcColumn = MetalAConcColumn;
            metalBTypeColumn = MetalBTypeColumn;
            metalMolarRatioColumn = MetalMolarRatioColumn;
            
            // 初始化列的可见性
            UpdateColumnVisibility();
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(OptimizationPageViewModel.OrgnicVisibility) || 
                e.PropertyName == nameof(OptimizationPageViewModel.OxideVisibility))
            {
                UpdateColumnVisibility();
            }
        }

        private void UpdateColumnVisibility()
        {
            if (viewModel == null) return;

            // 更新有机列的可见性
            if (formulaColumn != null) formulaColumn.Visibility = viewModel.OrgnicVisibility;
            if (concentrationColumn != null) concentrationColumn.Visibility = viewModel.OrgnicVisibility;
            if (tempColumn != null) tempColumn.Visibility = viewModel.OrgnicVisibility;
            if (soakTimeColumn != null) soakTimeColumn.Visibility = viewModel.OrgnicVisibility;
            if (phColumn != null) phColumn.Visibility = viewModel.OrgnicVisibility;
            if (curingTimeColumn != null) curingTimeColumn.Visibility = viewModel.OrgnicVisibility;

            // 更新氧化物列的可见性
            if (metalATypeColumn != null) metalATypeColumn.Visibility = viewModel.OxideVisibility;
            if (metalAConcColumn != null) metalAConcColumn.Visibility = viewModel.OxideVisibility;
            if (metalBTypeColumn != null) metalBTypeColumn.Visibility = viewModel.OxideVisibility;
            if (metalMolarRatioColumn != null) metalMolarRatioColumn.Visibility = viewModel.OxideVisibility;
        }
    }
}
