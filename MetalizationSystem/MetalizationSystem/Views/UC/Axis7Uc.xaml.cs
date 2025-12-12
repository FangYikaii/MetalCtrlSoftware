using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DynamicData;
using MetalizationSystem.DataCollection;
using MetalizationSystem.EnumCollection;

namespace MetalizationSystem.Views.UC
{
    /// <summary>
    /// Axis7Uc.xaml 的交互逻辑
    /// </summary>
    public partial class Axis7Uc : UserControl
    {
        int axisId = (int)EnumInfo.AxisId.LinearMotor;
        int stationId = (int)EnumInfo.AxisId.LinearMotor;
        ObservableCollection<PositionInfo> Positions { get; set; }

        public Axis7Uc()
        {
            InitializeComponent();
            Load();
            Thread thread= new Thread(Updata) { IsBackground = true };
            thread.Start();
        }

        private void btnSvon_Click(object sender, RoutedEventArgs e)
        {
            bool ret = XMachine.Instance.Card.FindAxis(axisId).GetServo;
            XMachine.Instance.Card.FindAxis(axisId).SetServo(!ret);
        }

        private void btnGoHome_Click(object sender, RoutedEventArgs e)
        {
            XMachine.Instance.Card.FindAxis(axisId).GoHome();
        }

        private void btnMoveN_Click(object sender, RoutedEventArgs e)
        {
            float distance = Convert.ToSingle(txtDistance.Text), speed = Convert.ToSingle(txtSpeed.Text); 
            if (rbtnRelMove.IsChecked == true)
            {
                XMachine.Instance.Card.FindAxis(axisId).MoveRel(distance, speed);
            }
            else
            {
                XMachine.Instance.Card.FindAxis(axisId).MoveContinuous(1, speed);
            }
        }

        private void btnMoveP_Click(object sender, RoutedEventArgs e)
        {
            float distance = Convert.ToSingle(txtDistance.Text), speed = Convert.ToSingle(txtSpeed.Text);
            if (rbtnRelMove.IsChecked == true)
            {
                XMachine.Instance.Card.FindAxis(axisId).MoveRel(-distance, speed);
            }
            else
            {
                XMachine.Instance.Card.FindAxis(axisId).MoveContinuous(-1, speed);
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            XMachine.Instance.Card.FindAxis(axisId).Stop();
        }


        void Updata()
        {
            while (true)
            {

                if (Globa.Status.CardConnected)
                {
                    Dispatcher.Invoke(new Action(()=>{
                        labLimitP.Background = XMachine.Instance.Card.FindAxis(axisId).LimitPState? Brushes.Red: Brushes.LightGray;
                        labOrg.Background = XMachine.Instance.Card.FindAxis(axisId).OrgState ? Brushes.Green : Brushes.LightGray;
                        labLimitN.Background = XMachine.Instance.Card.FindAxis(axisId).LimitNState ? Brushes.Red : Brushes.LightGray;
                        labSvon.Background = XMachine.Instance.Card.FindAxis(axisId).GetServo ? Brushes.Red : Brushes.LightGray;
                        labEmg.Background = XMachine.Instance.Card.FindAxis(axisId).Alarm ? Brushes.Red : Brushes.LightGray;

                        labPlanner.Content = Math.Round(XMachine.Instance.Card.FindAxis(axisId).PlannerPosition, 3).ToString();
                        labEncoder.Content = Math.Round(XMachine.Instance.Card.FindAxis(axisId).EncoderPosition, 3).ToString();
                    }));
                }
                Thread.Sleep(100);
            }
        }

        void Load()
        {
            List<PositionInfo> posList = Globa.DataManager.Axis7;
            Positions = new ObservableCollection<PositionInfo>();
            try
            {
                Positions = new ObservableCollection<PositionInfo>();
                for (int i=0; i< EnumInfo.Axis7PosTotal; i++)
                {
                    Positions.Add(XMachine.Instance.FindStation(stationId).FindPos(i));
                }                          
                for (int i = 0; i < Positions.Count; i++) cboxPos.Items.Add(Positions[i].Name);
            }
            catch { }
            dgPos.ItemsSource=new ObservableCollection<PositionInfo>(); 
            dgPos.ItemsSource = Positions;
        }

        private void btnSavePosition_Click(object sender, RoutedEventArgs e)
        {
            Positions[cboxPos.SelectedIndex].X = XMachine.Instance.FindStation(stationId).CurPosition.X;
            Positions[cboxPos.SelectedIndex].Y = XMachine.Instance.FindStation(stationId).CurPosition.Y;
            Positions[cboxPos.SelectedIndex].Z = XMachine.Instance.FindStation(stationId).CurPosition.Z;
            Positions[cboxPos.SelectedIndex].U = XMachine.Instance.FindStation(stationId).CurPosition.U;
            dgPos.ItemsSource=new ObservableCollection<PositionInfo>();
            dgPos.ItemsSource = Positions;
            SavePos();
        }

        private void btnRunPosition_Click(object sender, RoutedEventArgs e)
        {
            XMachine.Instance.FindStation(stationId).Move(Positions[cboxPos.SelectedIndex]);
        }

        private void btnSaveAllPosition_Click(object sender, RoutedEventArgs e)
        {
            SavePos();
        }
        /// <summary>保存点位</summary>
        void SavePos()
        {
            List<PositionInfo> posList = new List<PositionInfo>();         
            for (int i = 0; i < Positions.Count; i++) {
                XMachine.Instance.FindStation(stationId).FindPos(i).X = Positions[i].X;
                XMachine.Instance.FindStation(stationId).FindPos(i).Y = Positions[i].Y;
                XMachine.Instance.FindStation(stationId).FindPos(i).Z = Positions[i].Z;
                XMachine.Instance.FindStation(stationId).FindPos(i).U = Positions[i].U;
                posList.Add(Positions[i]);
            }
            Globa.DataManager.Axis7 = posList;
           
        }

        private void txtSpeed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
