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
    /// IoInputUc.xaml 的交互逻辑
    /// </summary>
    public partial class IoInputUc : UserControl
    {
        IoInputLab[] Lab = new IoInputLab[16];

        [Bindable(true)]
        [Category("IoName")]
        public string[] IoName
        {
            get { return (string[])GetValue(IoNameProperty); }
            set { SetValue(IoNameProperty, value); }
        }
        public static readonly DependencyProperty IoNameProperty =
            DependencyProperty.Register("IoName", typeof(string[]), typeof(IoInputUc), new PropertyMetadata(new string[16] { "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona", "Nona" }, new PropertyChangedCallback(IoNameChanged)));
        private static void IoNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoInputUc us = d as IoInputUc;
            if (us != null) us.Updata();
        }

        public int[] Index
        {
            get { return (int[])GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }
        public static readonly DependencyProperty IndexProperty =
          DependencyProperty.Register("Index", typeof(int[]), typeof(IoInputUc), new PropertyMetadata(new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new PropertyChangedCallback(IndexChanged)));
        static void IndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoInputUc us = d as IoInputUc;
            if (us != null) us.Updata();
        }
        public void Updata()
        {
            for (int i = 0; i < Lab.Length; i++)
            {
                Lab[i].Index = Index[i];
                Lab[i].IoName = IoName[i];
            }


        }
        public IoInputUc()
        {
            InitializeComponent();
            SetLab();
            Thread th = new Thread(Refresh) { IsBackground = true };
            th.Start();
        }
        void SetLab()
        {
            for (int i = 0; i < Lab.Length; i++)
            {
                Lab[i] = new IoInputLab();
            }
            Lab[0] = this.Lab1;
            Lab[1] = this.Lab2;
            Lab[2] = this.Lab3;
            Lab[3] = this.Lab4;
            Lab[4] = this.Lab5;
            Lab[5] = this.Lab6;
            Lab[6] = this.Lab7;
            Lab[7] = this.Lab8;
            Lab[8] = this.Lab9;
            Lab[9] = this.Lab10;
            Lab[10] = this.Lab11;
            Lab[11] = this.Lab12;
            Lab[12] = this.Lab13;
            Lab[13] = this.Lab14;
            Lab[14] = this.Lab15;
            Lab[15] = this.Lab16;
        }
        void Refresh()
        {
            bool value = false;
            while (true)
            {
                value = !value;
                if (Globa.Status.CardConnected)
                {
                    int length = Lab.Length;
                    for (int i = 0; i < length; i++)
                    {                       
                        Lab[i].Dispatcher.Invoke(new Action(() =>
                        {                            

                            if (Lab[i].Index != -1) ChangeColor(Lab[i], XMachine.Instance.Card.FindDi(Lab[i].Index).Sts ? Brushes.Green : Brushes.LightGray);
                        }));
                    }
                }
                Thread.Sleep(200);
            }
        }
        private delegate void inputDelegate(IoInputLab lab, Brush brush);

        void ChangeColor(IoInputLab lab, Brush brush)
        {
            //lab.LabIndex.Foreground = brush;
            //lab.LabName.Foreground = brush;
            lab.LabName.Background = brush;
        }
    }
}
