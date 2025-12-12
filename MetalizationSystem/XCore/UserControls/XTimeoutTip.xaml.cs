using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// XTimeoutTip.xaml 的交互逻辑
    /// </summary>
    public partial class XTimeoutTip : Window
    {
        ManualResetEvent _mre = new ManualResetEvent(false);
        public XTimeoutTip(string message)
        {
            InitializeComponent();
            this.rTbox.AppendText(message);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            _mre.Set();
            this.Close();
        }

        private void btnContinu_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            _mre.Set();
            this.Close();
        }
        public bool WaitOne()
        {
            return _mre.WaitOne();
        }

        public bool Reset()
        {
            return _mre.Reset();
        }

        public bool Set()
        {
            return _mre.Set();
        }
    }
}
