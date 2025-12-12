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
    /// ToolTip_UC.xaml 的交互逻辑
    /// </summary>
    public partial class ToolTip_UC : UserControl
    {
        public ToolTip_UC()
        {
            InitializeComponent();
        }

        [Bindable(true)]
        [Category("ImagePath")]
        public string ImagePath
        {
            get { return (string)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }
        public static readonly DependencyProperty ImagePathProperty =
            DependencyProperty.Register("ImagePath", typeof(string), typeof(ToolTip_UC), new PropertyMetadata((String)null, new PropertyChangedCallback(ImagePathChanged)));
        private static void ImagePathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ToolTip_UC us = d as ToolTip_UC;
            if (us != null)
            {
                us.UpdataImage(e.NewValue as string);
            }
        }
        void UpdataImage(string path)
        {
            this.img.Source = new BitmapImage(new Uri(path));
        }

        [Bindable(true)]
        [Category("Introduce")]
        public string Introduce
        {
            get { return (string)GetValue(IntroduceProperty); }
            set { SetValue(IntroduceProperty, value); }
        }
        public static readonly DependencyProperty IntroduceProperty =
            DependencyProperty.Register("Introduce", typeof(string), typeof(ToolTip_UC), new PropertyMetadata((String)null, new PropertyChangedCallback(IntroduceChanged)));
        private static void IntroduceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ToolTip_UC us = d as ToolTip_UC;
            if (us != null)
            {
                us.UpdataIntroduce(e.NewValue as string);
            }
        }
        void UpdataIntroduce(string introduce)
        {
            this.tbk.Text = introduce;
        }
    }
}
