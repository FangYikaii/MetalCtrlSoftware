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
    /// ReactionTank_UC.xaml 的交互逻辑
    /// </summary>
    public partial class ReactionTank_UC : UserControl
    {
        [Bindable(true)]
        [Category("IsHave")]
        public bool[] IsHave
        {
            get { return (bool[])GetValue(IsHaveProperty); }
            set { SetValue(IsHaveProperty, value); }
        }
        public static readonly DependencyProperty IsHaveProperty =
            DependencyProperty.Register("IsHave", typeof(bool[]), typeof(ReactionTank_UC), new PropertyMetadata(new bool[6] {true, true, true, true, true, true},
                new PropertyChangedCallback(IsHaveChanged)));
        private static void IsHaveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ReactionTank_UC us = d as ReactionTank_UC;
            if (us != null)
            {
                us.Updata();
            }
        }

        [Bindable(true)]
        [Category("Id")]
        public int Id
        {
            get { return (int)GetValue(IdProperty); }
            set { SetValue(IdProperty, value); }
        }
        public static readonly DependencyProperty IdProperty =
            DependencyProperty.Register("Id", typeof(int), typeof(ReactionTank_UC), new PropertyMetadata(-1,
                new PropertyChangedCallback(IdChanged)));
        private static void IdChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ReactionTank_UC us = d as ReactionTank_UC;
            if (us != null)
            {
                us.Updata();
            }
        }


        Line[] lines = new Line[6];
        public ReactionTank_UC()
        {
            InitializeComponent();
            InitLine();
        }

        void InitLine()
        {
            lines[1] = line1;
            lines[2] = line2;
            lines[3] = line3;
            lines[4] = line4;
            lines[5] = line5;   
        }

        void Updata()
        {
            for (int i = 1; i < lines.Length; i++) lines[i].Stroke = IsHave[i] ? Brushes.Green : Brushes.White;           
        }
    }
}
