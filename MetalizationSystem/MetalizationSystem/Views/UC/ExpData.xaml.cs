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
        public bool Adhension { get; set; } = false;
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
            if (OnAdhensionEvent != null)
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
            var result = MessageBox.Show("Does the adhension value been completed?", "Inform", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            try
            {
                AdensionData value = new AdensionData();
                value.expID = int.Parse((DataContext as ExpDataViewModel).ExpId.Trim());
                if ((DataContext as ExpDataViewModel).ComboxSelectedIndex == 0)
                {
                    value.Adhension = true;
                }
                else
                {
                    value.Adhension = false;
                }
                OnAdhensionEvent(new AdhensionEventArges(value));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("WriteAdhension error: " + ex.Message);
            }

        }


    }
}
