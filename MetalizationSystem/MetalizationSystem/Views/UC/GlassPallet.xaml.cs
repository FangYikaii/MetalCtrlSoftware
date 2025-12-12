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
using MetalizationSystem.Views.Pages;

namespace MetalizationSystem.Views.UC
{
    /// <summary>
    /// GlassPallet.xaml 的交互逻辑
    /// </summary>
    public partial class GlassPallet : UserControl
    {
        [Bindable(true)]
        [Category("IsHave")]
        public bool[] IsHave
        {
            get { return (bool[])GetValue(IsHaveProperty); }
            set { SetValue(IsHaveProperty, value); }
        }
        public static readonly DependencyProperty IsHaveProperty =
            DependencyProperty.Register("IsHave", typeof(bool[]), typeof(GlassPallet), new PropertyMetadata(new bool[61] {true, true, true, true, true, true, true, true, true, true, true,
                                    true, true, true, true, true, true, true, true, true, true,
                                    true, true, true, true, true, true, true, true, true, true,
                                    true, true, true, true, true, true, true, true, true, true,
                                    true, true, true, true, true, true, true, true, true, true,
                                    true, true, true, true, true, true, true, true, true, true},
                new PropertyChangedCallback(IsHaveChanged)));
        private static void IsHaveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GlassPallet us = d as GlassPallet;
            if (us != null)
            {              
                us.Updata();
            }
        }

        [Bindable(true)]
        [Category("IsLoad")]
        public bool IsLoad
        {
            get { return (bool)GetValue(IsLoadProperty); }
            set { SetValue(IsLoadProperty, value); }
        }
        public static readonly DependencyProperty IsLoadProperty =
            DependencyProperty.Register("IsLoad", typeof(bool), typeof(GlassPallet), new PropertyMetadata(true,
                new PropertyChangedCallback(IsLoadChanged)));
        private static void IsLoadChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GlassPallet us = d as GlassPallet;
            if (us != null)
            {
                us.Updata();
            }
        }


        Line[] lines =new Line[61];
        public GlassPallet()
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
            lines[6] = line6;
            lines[7] = line7;
            lines[8] = line8;
            lines[9] = line9;
            lines[10] = line10;
            lines[11] = line11;
            lines[12] = line12;
            lines[13] = line13;
            lines[14] = line14;
            lines[15] = line15;
            lines[16] = line16;
            lines[17] = line17;
            lines[18] = line18;
            lines[19] = line19;
            lines[20] = line20;
            lines[21] = line21;
            lines[22] = line22;
            lines[23] = line23;
            lines[24] = line24;
            lines[25] = line25;
            lines[26] = line26;
            lines[27] = line27;
            lines[28] = line28;
            lines[29] = line29;
            lines[30] = line30;
            lines[31] = line31;
            lines[32] = line32;
            lines[33] = line33;
            lines[34] = line34;   
            lines[35] = line35;
            lines[36] = line36;
            lines[37] = line37;
            lines[38] = line38;
            lines[39] = line39;
            lines[40] = line40;
            lines[41] = line41;
            lines[42] = line42;
            lines[43] = line43;
            lines[44] = line44;
            lines[45] = line45;
            lines[46] = line46;
            lines[47] = line47;
            lines[48] = line48;
            lines[49] = line49;
            lines[50] = line50;
            lines[51] = line51;
            lines[52] = line52;
            lines[53] = line53;
            lines[54] = line54;
            lines[55] = line55;
            lines[56] = line56;
            lines[57] = line57;
            lines[58] = line58;
            lines[59] = line59;
            lines[60] = line60;


        }


        void Updata()
        {       
            for (int i = 1; i < lines.Length; i++)
            {

                if (Width > 0 & Height > 0)
                {
                    lines[i].X1 = (i - 1) / 10 * Width / 6 + 2;
                    lines[i].Y1 = (i - 1) % 10 * Height / 10 + 2;
                    lines[i].X2 = (i - 1) / 10 * Width / 6 + Width / 6 - 2;
                    lines[i].Y2 = (i - 1) % 10 * Height / 10 + 2;
                    //lines[i].Stroke = IsHave[i] ? Brushes.Green : Brushes.White;
                }
            }            
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsLoad) return;
            GlassPalletCheckWindow window = new GlassPalletCheckWindow();
            window.ShowDialog();       
        }
    }
}
