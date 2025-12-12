using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MetalizationSystem.Views
{
    /// <summary>
    /// XMessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class XMessageBox : Window
    {
        private XMessageBox()
        {
            InitializeComponent();
        }

        public new string Title
        {
            get { return this.labTitle.Content.ToString(); }
            set { this.labTitle.Content = value; }
        }
        public string Message
        {
            get { return this.txtMessage.Text; }
            set { this.txtMessage.Text = value; }
        }

        public static bool? Show(string message, string title = "提示")
        {
            var msgBox = new XMessageBox();
            msgBox.Title = title;
            msgBox.Message = message;
            return msgBox.ShowDialog();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
