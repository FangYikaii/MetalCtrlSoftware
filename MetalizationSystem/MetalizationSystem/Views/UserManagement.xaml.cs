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
    /// UserManagement.xaml 的交互逻辑
    /// </summary>
    public partial class UserManagement : Window
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (txt_userName.Text == "admin" & pw_Password.Password == "admin")
            {
                this.DialogResult = true;
            }
            this.DialogResult = true;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
