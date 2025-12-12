using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// <summary>
    /// DryBox_UC.xaml 的交互逻辑
    /// </summary>
    public partial class DryBox_UC : UserControl
    {

        [Bindable(true)]
        [Category("Temperature")]
        public double Temperature
        {
            get { return (double)GetValue(TemperatureProperty); }
            set { SetValue(TemperatureProperty, value); }
        }
        public static readonly DependencyProperty TemperatureProperty =
            DependencyProperty.Register("Temperature", typeof(double), typeof(DryBox_UC), new PropertyMetadata(0.0,
                new PropertyChangedCallback(TemperatureChanged)));
        private static void TemperatureChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DryBox_UC us = d as DryBox_UC;
            if (us != null)
            {
                us.Updata();
            }
        }
        public DryBox_UC()
        {
            InitializeComponent();
        }

        void Updata()
        {
            labTemperature.Content= Temperature.ToString();
        }
      
    }
}
