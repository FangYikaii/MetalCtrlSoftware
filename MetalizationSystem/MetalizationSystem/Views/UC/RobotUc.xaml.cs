using MetalizationSystem.DataCollection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// RobotUc.xaml 的交互逻辑
    /// </summary>
    public partial class RobotUc : UserControl
    {
        public RobotUc()
        {
           
            InitializeComponent();
            Load();
        }


        [Bindable(true)]
        [Category("ParName")]
        public string ParName
        {
            get { return (string)GetValue(ParNameProperty); }
            set { SetValue(ParNameProperty, value); }
        }
        public static readonly DependencyProperty ParNameProperty =
            DependencyProperty.Register("ParName", typeof(string), typeof(RobotUc), new PropertyMetadata("Robot", new PropertyChangedCallback(ParNameChanged)));
        private static void ParNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RobotUc us = d as RobotUc;
            if (us != null) us.Updata();
        }

        [Bindable(true)]
        [Category("PlateNum")]
        public int PlateNum
        {
            get { return (int)GetValue(PlateNumProperty); }
            set { SetValue(PlateNumProperty, value); }
        }
        public static readonly DependencyProperty PlateNumProperty =
            DependencyProperty.Register("PlateNum", typeof(int), typeof(RobotUc), new PropertyMetadata(10, new PropertyChangedCallback(PlateNumChanged)));
        private static void PlateNumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RobotUc us = d as RobotUc;
            if (us != null) us.Updata();
        }

        void Updata()
        {
            for (int i = 0; i < PlateNum; i++)
            {
                cboxPlate.Items.Add((i + 1).ToString());
            }
        }

        ObservableCollection<RobotPositionInfo> Positions { get; set; }

        private void btnAxis_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString()) {
                case "X+":
                    break;
                case "X-":
                    break;
                case "Y+":
                    break;
                case "Y-":
                    break;
                case "Z+":
                    break;
                case "Z-":
                    break;
                case "U+":
                    break;
                case "U-":
                    break;
                case "V+":
                    break;
                case "V-":
                    break;
                case "W+":
                    break;
                case "W-":
                    break;
            }
        }   

        private void btnConn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Tag.ToString())
            {
                case "启动":
                    break;
                case "停止":
                    break;
                case "操作权":
                    break;
                case "报警复位":
                    break;
                case "程序复位":
                    break;      
                case "获取当前位置":
                    break;
                case "保存":
                    break;
            }
        }

        void Load()
        {
            Positions = new ObservableCollection<RobotPositionInfo>();
            try
            {
                Positions = (ObservableCollection<RobotPositionInfo>)(Globa.DataManager.Read(new ObservableCollection<RobotPositionInfo>(), AppDomain.CurrentDomain.BaseDirectory + @"Par\" + ParName + ".dat"));
                for (int i = 0; i < Positions.Count; i++) cboxPos.Items.Add(Positions[i].Name);
            }
            catch { }          
            dgPos.ItemsSource = Positions;
        }
        void ShowPosition(double x, double y, double z, double u, double v, double w)
        {
            labXpos.Content = x.ToString("0.000");
            labYpos.Content = y.ToString("0.000");
            labZpos.Content = z.ToString("0.000");
            labUpos.Content = u.ToString("0.000");
            labVpos.Content = v.ToString("0.000");
            labWpos.Content = w.ToString("0.000");
        }
        void ShowStatus(bool permissions,bool svon,bool alarm,bool running)
        {
            labStatusPermissions.Background= permissions ? Brushes.Green : Brushes.White;
            labStatusSvon.Background = svon ? Brushes.Green : Brushes.White;
            labStatusAlarm.Background= alarm ? Brushes.White : Brushes.Red;
            labStatusRunning.Background =running ? Brushes.Green : Brushes.White;
        }
    }
}
