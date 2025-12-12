using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.ViewModels
{
    public class Tank40PromptViewModel: ViewModelBase
    {
        public event EventHandler RequestClose;
        public string PromptMessage => "请更换Tank40槽有机物过渡层的溶液";

        public ICommand StartDrainCommand { get; }
        public ICommand StopDrainCommand { get; }
        public ICommand StartChargeCommand { get; }
        public ICommand StopChargeCommand { get; }
        public ICommand ContinueCommand {  get; }

        public Tank40PromptViewModel()
        {
            StartDrainCommand = new RelayCommand(HandleStartDrainAction);
            StopDrainCommand = new RelayCommand(HandleStopDrainAction);
            StartChargeCommand = new RelayCommand(HandleStartChargeAction);
            StartChargeCommand = new RelayCommand(HandleStopChargeAction);
            ContinueCommand = new RelayCommand(HandleContinueAction);
        }

        private void HandleStartDrainAction()
        {
            // 停止加热
            Globa.Device.Tank40.StopTempCtrl();
            // 开始排液
            Globa.Device.Tank40.StartDrain();
        }

        private void HandleStopDrainAction() 
        { 
            // 停止排液
            Globa.Device.Tank40.StopDrain(); 
        }

        private void HandleStartChargeAction()
        {
            Globa.Device.Tank40.StartCharge();
        }

        private void HandleStopChargeAction()
        {
            Globa.Device.Tank40.StopCharge();
        }

        private void HandleContinueAction()
        {
            if(Globa.Device.Tank40.IsLowLiquid)
            {
                MessageBox.Show("反应器液位低，请添加溶液后继续");
            }
            else
            {
                //配方索引+1
                Globa.Device.Recipe.Index++;
                //执行新的配方
                Globa.Device.AutoModel.ExecuteRecipe();
                Globa.Device.Tank40.StartTempCtrl();
                Globa.Device.Tank40.StopDrain();
                Globa.Device.Scheduler.Tank40RecipeChanged = true;
                RequestClose.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
