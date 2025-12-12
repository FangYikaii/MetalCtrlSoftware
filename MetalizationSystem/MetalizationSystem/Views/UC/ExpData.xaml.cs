using CommunityToolkit.Mvvm.Input;
using MetalizationSystem.DataCollection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace MetalizationSystem.Views.UC
{
    public class AdensionData
    {
        public int expID { get; set; } = 0;
        public string projName { get; set; } = "";
        public int iterId { get; set; } = 0;
        public string phase { get; set; } = "";
        public double Adhension { get; set; } = 0.0;
        public double Coverage { get; set; } = 0.0;
        public double Uniformity { get; set; } = 0.0;
    }

    public class AdhensionEventArges : EventArgs
    {
        public AdensionData value;
        public AdhensionEventArges(AdensionData v)
        {
            value = v;
        }
    }


    /// <summary>
    /// ExpData.xaml 的交互逻辑
    /// </summary>
    public partial class ExpData : UserControl
    {

        public delegate void AdhensionEventHandler(object sender, AdhensionEventArges arge);
        public event AdhensionEventHandler AdhensionEvent;
        protected virtual void OnAdhensionEvent(AdhensionEventArges e)
        {
            if (AdhensionEvent != null)
            {
                AdhensionEvent(this, e);
            }
        }


        public ExpData(BayesExperData selectedItem)
        {
            InitializeComponent();
            DataContext = new ExpDataViewModel(selectedItem);
        }


        private void btn_Adhension_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Does all values (Adhension, Coverage, Uniformity) been completed?", "Inform", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            try
            {
                AdensionData value = new AdensionData();
                var viewModel = DataContext as ExpDataViewModel;
                value.expID = int.Parse(viewModel.ExpId.Trim());
                value.projName = viewModel.ProjName;
                value.iterId = int.Parse(viewModel.IterId.Trim());
                value.phase = viewModel.Phase;
                
                // 从 TextBox 读取 Adhension 并转换为数值
                string adhensionText = viewModel.AdhensionValue?.Trim();
                if (string.IsNullOrEmpty(adhensionText))
                {
                    MessageBox.Show("Please enter adhension value!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (!double.TryParse(adhensionText, out double adhensionValue))
                {
                    MessageBox.Show("Please enter a valid numeric value for adhension!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                value.Adhension = adhensionValue;

                // 从 TextBox 读取 Coverage 并转换为数值
                string coverageText = viewModel.Coverage?.Trim();
                if (string.IsNullOrEmpty(coverageText))
                {
                    MessageBox.Show("Please enter coverage value!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (!double.TryParse(coverageText, out double coverageValue))
                {
                    MessageBox.Show("Please enter a valid numeric value for coverage!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                value.Coverage = coverageValue;

                // 从 TextBox 读取 Uniformity 并转换为数值
                string uniformityText = viewModel.Uniformity?.Trim();
                if (string.IsNullOrEmpty(uniformityText))
                {
                    MessageBox.Show("Please enter uniformity value!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (!double.TryParse(uniformityText, out double uniformityValue))
                {
                    MessageBox.Show("Please enter a valid numeric value for uniformity!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                value.Uniformity = uniformityValue;

                OnAdhensionEvent(new AdhensionEventArges(value));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("WriteValues error: " + ex.Message);
            }

        }


    }
}
