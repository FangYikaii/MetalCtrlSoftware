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
    /// Plate_UC.xaml 的交互逻辑
    /// </summary>
    public partial class Plate_UC : UserControl
    {
        Label[] labels = new Label[26];
        public Plate_UC()
        {
            InitializeComponent();
            GetLabels();
        }

        public int Index
        {
            get { return (int)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }
        public static readonly DependencyProperty IndexProperty =
          DependencyProperty.Register("Index", typeof(int), typeof(Plate_UC), new PropertyMetadata(1, new PropertyChangedCallback(IndexChanged)));
        static void IndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Plate_UC us = d as Plate_UC;
            if (us != null) us.Updata();
        }

        [Bindable(true)]
        [Category("PlateStatus")]
        public bool[] PlateStaa
        {
            get { return (bool[])GetValue(IoNameProperty); }
            set { SetValue(IoNameProperty, value); }
        }
        public static readonly DependencyProperty IoNameProperty =
            DependencyProperty.Register("PlateStatus", typeof(bool[]), typeof(Plate_UC), new PropertyMetadata(new bool[26] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, new PropertyChangedCallback(IoNameChanged)));
        private static void IoNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Plate_UC us = d as Plate_UC;
            if (us != null) us.Updata();
        }
        public void Updata()
        {
            for (int i = 1; i < labels.Length; i++)
            {
                labels[i].Content = (Index - 1) * 25 + i;
                labels[i].Background = PlateStaa[i] ? Brushes.Green : Brushes.White;
            }
        }
        void GetLabels()
        {
            labels[1] = Cave1;
            labels[2] = Cave2;
            labels[3] = Cave3;
            labels[4] = Cave4;
            labels[5] = Cave5;
            labels[6] = Cave6;
            labels[7] = Cave7;
            labels[8] = Cave8;
            labels[9] = Cave9;
            labels[10] = Cave10;
            labels[11] = Cave11;
            labels[12] = Cave12;
            labels[13] = Cave13;
            labels[14] = Cave14;
            labels[15] = Cave15;
            labels[16] = Cave16;
            labels[17] = Cave17;
            labels[18] = Cave18;
            labels[19] = Cave19;
            labels[20] = Cave20;
            labels[21] = Cave21;
            labels[22] = Cave22;
            labels[23] = Cave23;
            labels[24] = Cave24;
            labels[25] = Cave25;
        }
    }
}
