using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MetalizationSystem.Views.UC
{
    /// <summary>
    /// IoOutputUc.xaml 的交互逻辑
    /// </summary>
    public partial class IoOutputUc : UserControl
    {
        IoOutputBtn[] Btn = new IoOutputBtn[16];

        [Bindable(true)]
        [Category("IoName")]
        public string[] IoName
        {
            get { return (string[])GetValue(IoNameProperty); }
            set { SetValue(IoNameProperty, value); }
        }
        public static readonly DependencyProperty IoNameProperty =
            DependencyProperty.Register("IoName", typeof(string[]), typeof(IoOutputUc), new PropertyMetadata(new string[16] { "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona" }, new PropertyChangedCallback(IoNameChanged)));
        private static void IoNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoOutputUc us = d as IoOutputUc;
            if (us != null) us.Updata();
        }

        public int[] Index
        {
            get { return (int[])GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }
        public static readonly DependencyProperty IndexProperty =
          DependencyProperty.Register("Index", typeof(int[]), typeof(IoOutputUc), new PropertyMetadata(new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new PropertyChangedCallback(IndexChanged)));
        static void IndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoOutputUc us = d as IoOutputUc;
            if (us != null) us.Updata();
        }
        public void Updata()
        {
            for (int i = 0; i < Btn.Length; i++)
            {
                Btn[i].Index = Index[i];
                Btn[i].IoName = IoName[i];
            }


        }
        public IoOutputUc()
        {
            InitializeComponent();
            SetBtn();
            Thread th = new Thread(Refresh) { IsBackground = true };
            th.Start();
        }
        void SetBtn()
        {
            for (int i = 0; i < Btn.Length; i++)
            {
                Btn[i] = new IoOutputBtn();
            }
            Btn[0] = this.Btn1;
            Btn[1] = this.Btn2;
            Btn[2] = this.Btn3;
            Btn[3] = this.Btn4;
            Btn[4] = this.Btn5;
            Btn[5] = this.Btn6;
            Btn[6] = this.Btn7;
            Btn[7] = this.Btn8;
            Btn[8] = this.Btn9;
            Btn[9] = this.Btn10;
            Btn[10] = this.Btn11;
            Btn[11] = this.Btn12;
            Btn[12] = this.Btn13;
            Btn[13] = this.Btn14;
            Btn[14] = this.Btn15;
            Btn[15] = this.Btn16;
        }
        void Refresh()
        {
            bool value = false;
            while (true)
            {
                value = !value;
                if (Globa.Status.CardConnected)
                {
                    int length = Btn.Length;
                    for (int i = 0; i < length; i++)
                    {
                        Btn[i].Dispatcher.Invoke(new Action(() =>
                        {
                            if (Btn[i].Index != -1) ChangeColor(Btn[i], XMachine.Instance.Card.FindDo (Btn[i].Index).Sts ? Brushes.Green : Brushes.LightGray);
                        }));
                    }
                }
                Thread.Sleep(200);
            }
        }
        private delegate void outputDelegate(IoOutputBtn btn, Brush brush);

        void ChangeColor(IoOutputBtn btn, Brush brush)
        {
            btn.Btn.Background = brush;
            //btn.Lab.Background = brush;
        }
    }
}
