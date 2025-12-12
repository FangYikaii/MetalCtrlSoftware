using SqlSugar;
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

namespace XCore
{
    /// <summary>
    /// XTipDlg.xaml 的交互逻辑
    /// </summary>
    public partial class XTipDlg : Window
    {
        public string output;
        public string _tip;
        public XTipDlg(string str)
        {
            InitializeComponent();
            _tip = str;
            tbox.Text = _tip;
            tbox.SelectAll();
            output = "";
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            output =tbox.Text;
            if (output== _tip)
            {
                this.Close();
                return;
            }
            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
