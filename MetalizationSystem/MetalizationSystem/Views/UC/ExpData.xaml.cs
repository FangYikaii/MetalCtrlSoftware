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
        public double Adhension { get; set; } = 0.0;
    }

    public class AdhensionEventArges : EventArgs
    {
        public AdensionData value;
        public AdhensionEventArges(AdensionData v)
        {
            value = v;
        }
    }

    public class CoverageUniformityData
    {
        public int expID { get; set; } = 0;
        public double Coverage { get; set; } = 0.0;
        public double Uniformity { get; set; } = 0.0;
    }

    public class CoverageUniformityEventArges : EventArgs
    {
        public CoverageUniformityData value;
        public CoverageUniformityEventArges(CoverageUniformityData v)
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

        public delegate void CoverageUniformityEventHandler(object sender, CoverageUniformityEventArges arge);
        public event CoverageUniformityEventHandler CoverageUniformityEvent;
        protected virtual void OnCoverageUniformityEvent(CoverageUniformityEventArges e)
        {
            if (CoverageUniformityEvent != null)
            {
                CoverageUniformityEvent(this, e);
            }
        }

        public ExpData(BayesExperData selectedItem)
        {
            InitializeComponent();
            DataContext = new ExpDataViewModel(selectedItem);
        }


        private void btn_Adhension_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Does the adhension value been completed?", "Inform", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            try
            {
                AdensionData value = new AdensionData();
                value.expID = int.Parse((DataContext as ExpDataViewModel).ExpId.Trim());
                // 从 TextBox 读取文本并转换为数值
                string adhensionText = (DataContext as ExpDataViewModel).AdhensionValue?.Trim();
                if (string.IsNullOrEmpty(adhensionText))
                {
                    MessageBox.Show("Please enter adhension value!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                // 尝试解析为数值
                if (!double.TryParse(adhensionText, out double adhensionValue))
                {
                    MessageBox.Show("Please enter a valid numeric value for adhension!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                value.Adhension = adhensionValue;
                OnAdhensionEvent(new AdhensionEventArges(value));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("WriteAdhension error: " + ex.Message);
            }

        }

        private void btn_CoverageUniformity_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Does the coverage and uniformity values been completed?", "Inform", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            try
            {
                CoverageUniformityData value = new CoverageUniformityData();
                value.expID = int.Parse((DataContext as ExpDataViewModel).ExpId.Trim());
                
                // 从 TextBox 读取 Coverage 并转换为数值
                string coverageText = (DataContext as ExpDataViewModel).Coverage?.Trim();
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
                string uniformityText = (DataContext as ExpDataViewModel).Uniformity?.Trim();
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

                OnCoverageUniformityEvent(new CoverageUniformityEventArges(value));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("WriteCoverageUniformity error: " + ex.Message);
            }
        }


    }
}
