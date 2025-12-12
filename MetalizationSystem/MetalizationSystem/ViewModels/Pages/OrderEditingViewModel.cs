using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MetalizationSystem.DataCollection;
using MetalizationSystem.DataServer;
using MetalizationSystem.EnumCollection;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MetalizationSystem.ViewModels;


public partial class OrderEditingViewModel : ObservableRecipient,IRecipient<ValueChangedMessage<OrderInfo>>
{
    DispatcherTimer timer = new DispatcherTimer();
    
    OrderInfo _copyOderInfo;
    public BindingList<OrderInfo> CurOrderList { get; }
    public BindingList<OrderInfo> OrderList { get; }
    [ObservableProperty]
    public OrderInfo _order;
    [ObservableProperty]
    int _selectRowCur = -1;
    [ObservableProperty]
    int _selectRow = -1;
    [ObservableProperty]
    OrderInfo _mOrderInfo;
    public void Receive(ValueChangedMessage<OrderInfo> message)
    {
        MOrderInfo = message.Value;      
    }
    [RelayCommand]
    public void Delete_CurTask()
    {
        if (Globa.SysStatus == SysStatus.Running) return;
        if (SelectRowCur == -1) return;
        if (CurOrderList[SelectRowCur].IsBusy | CurOrderList[SelectRowCur].IsFinish) return;
        CurOrderList.RemoveAt(SelectRowCur);
        SelectRowCur = -1;
    }

    [RelayCommand]
    public void Clear_CurTask()
    {
        if (Globa.SysStatus == SysStatus.Running) return;
        for (int i = CurOrderList.Count - 1; i >= 0; i--)
        {
            if (!CurOrderList[i].IsBusy & !CurOrderList[i].IsFinish)
            {
                CurOrderList.Remove(CurOrderList[i]);
            }
        }
    }
    [RelayCommand]
    public void MoveUp_CurTask()
    {
        if (Globa.SysStatus == SysStatus.Running) return;
        if (SelectRowCur != -1)
        {
            int sIndex = SelectRowCur;
            if (sIndex == 0) return;
            if (CurOrderList[SelectRowCur].IsBusy | CurOrderList[SelectRowCur].IsFinish
                | CurOrderList[SelectRowCur - 1].IsBusy | CurOrderList[SelectRowCur - 1].IsFinish) return;
            OrderInfo orderInfo = CurOrderList[SelectRowCur];
            CurOrderList.RemoveAt(SelectRowCur);
            CurOrderList.Insert(sIndex - 1, orderInfo);
            SelectRowCur = sIndex - 1;
        }

    }
    [RelayCommand]
    public void MoveDown_CurTask()
    {
        if (Globa.SysStatus == SysStatus.Running) return;
        if (SelectRowCur != -1)
        {
            int sIndex = SelectRowCur;
            if (sIndex == CurOrderList.Count - 1) return;
            if (CurOrderList[SelectRowCur].IsBusy | CurOrderList[SelectRowCur].IsFinish
              | CurOrderList[SelectRowCur + 1].IsBusy | CurOrderList[SelectRowCur + 1].IsFinish) return;
            OrderInfo orderInfo = CurOrderList[SelectRowCur];
            CurOrderList.RemoveAt(SelectRowCur);
            CurOrderList.Insert(sIndex + 1, orderInfo);
            SelectRowCur = sIndex + 1;
        }
    }

    [RelayCommand]
    public void CurTaskSave()
    {
        Globa.DataManager.CurOrderList = CurOrderList.ToList();       
    }

    [RelayCommand]
    public void Creat_Task()
    {
        OrderInfo orderInfo = new OrderInfo(DateTime.Now.ToString("HHmmssfff"));
        if (SelectRow != -1) OrderList.Insert(SelectRow, orderInfo);
        else OrderList.Add(orderInfo);
    }
    [RelayCommand]
    public void Delete_Task()
    {
        if (SelectRow == -1) return;
        OrderList.RemoveAt(SelectRow);
        SelectRow = -1;
    }
    [RelayCommand]
    public void Clear_Task()
    {
        OrderList.Clear();
    }
    [RelayCommand]
    public void MoveUp_Task()
    {
        if (SelectRow != -1)
        {
            int sIndex = SelectRow;
            if (sIndex == 0) return;
            OrderInfo orderInfo = OrderList[SelectRow];
            OrderList.RemoveAt(SelectRow);
            OrderList.Insert(sIndex - 1, orderInfo);
            SelectRow = sIndex - 1;
        }

    }
    [RelayCommand]
    public void MoveDown_Task()
    {
        if (SelectRow != -1)
        {
            int sIndex = SelectRow;
            if (sIndex == OrderList.Count - 1) return;
            OrderInfo orderInfo = OrderList[SelectRow];
            OrderList.RemoveAt(SelectRow);
            OrderList.Insert(sIndex + 1, orderInfo);
            SelectRow = sIndex + 1;
        }
    }
    [RelayCommand]
    public void Copy_Task()
    {
        if (SelectRow != -1)
        {
            _copyOderInfo = OrderList[SelectRow];
        }
    }
    [RelayCommand]
    public void Paste_Task()
    {
        if (SelectRow != -1)
        {
            if (_copyOderInfo == null) return;
            if (SelectRow != -1) OrderList.Insert(SelectRow + 1, _copyOderInfo);
            else OrderList.Add(_copyOderInfo);
        }
    }
    [RelayCommand]
    public void ImportExcel()
    {
        System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
        openFileDialog.InitialDirectory = "c:\\"; // 设置初始目录
        openFileDialog.Filter = "表格|*.xlsx";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            OrderList.Clear();
            List<OrderInfo> orderInfos = ExcelHelper.Read(openFileDialog.FileName);
            for (int i = 0; i < orderInfos.Count; i++)
            {
                OrderList.Add(orderInfos[i]);
            }
        }


    }
    [RelayCommand]
    public void ExportExcel()
    {
        System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        saveFileDialog.InitialDirectory = "c:\\"; // 设置初始目录
        saveFileDialog.Filter = "表格|*.xlsx";
        saveFileDialog.FilterIndex = 2;
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            // 获取选中文件的路径

            string filePath = saveFileDialog.FileName;
            if (File.Exists(filePath)) File.Delete(filePath);
            for (int i = 0; i < OrderList.Count; i++)
            {
                string[] header = new string[]
                {
                    "SN",
                    MOrderInfo.LiquidDispensing.Solvent[1].Name,
                    MOrderInfo.LiquidDispensing.Solvent[2].Name,
                    MOrderInfo.LiquidDispensing.Solvent[3].Name,
                    MOrderInfo.LiquidDispensing.Solvent[4].Name,
                    MOrderInfo.LiquidDispensing.TransitionFluid[1].Name,
                    MOrderInfo.LiquidDispensing.TransitionFluid[2].Name,
                    MOrderInfo.LiquidDispensing.TransitionFluid[3].Name,
                    MOrderInfo.LiquidDispensing.TransitionFluid[4].Name,
                    MOrderInfo.LiquidDispensing.TransitionFluid[5].Name,
                    "Count"
                };
                double[] message = new double[] { OrderList[i].LiquidDispensing.Solvent[1].Use,
                    OrderList[i].LiquidDispensing.Solvent[2].Use,
                    OrderList[i].LiquidDispensing.Solvent[3].Use,
                    OrderList[i].LiquidDispensing.Solvent[4].Use,
                    OrderList[i].LiquidDispensing.TransitionFluid[1].Use,
                    OrderList[i].LiquidDispensing.TransitionFluid[2].Use,
                    OrderList[i].LiquidDispensing.TransitionFluid[3].Use,
                    OrderList[i].LiquidDispensing.TransitionFluid[4].Use,
                    OrderList[i].LiquidDispensing.TransitionFluid[5].Use,
                    OrderList[i].Count};
                ExcelHelper.ImportData(OrderList[i].SN, message, filePath, header);
            }
        }

    }

    [RelayCommand]
    public void Save()
    {
        List<OrderInfo> curOderlist = new List<OrderInfo>();
        for (int i = 0; i < OrderList.Count; i++)
        {
            curOderlist.Add(OrderList[i]);                  
        }
        Globa.DataManager.CurOrderList= curOderlist;
        CurOrderList.Clear();
        for (int i = 0; i < (Globa.DataManager.CurOrderList).Count; i++)
        {
            CurOrderList.Add(Globa.DataManager.CurOrderList[i]);
        }
        OrderList.Clear();
    }
    public OrderEditingViewModel()
    {
        MOrderInfo= Globa.DataManager.ParameterList;
        Order = new OrderInfo();
        OrderList = new BindingList<OrderInfo>();
        CurOrderList = new BindingList<OrderInfo>();

        for (int i = 0; i < (Globa.DataManager.CurOrderList).Count; i++)
        {
            CurOrderList.Add((Globa.DataManager.CurOrderList)[i]);
        }
        timer.Tick += timer_Tick;
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Start();      
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        timer.Stop();
        if (Globa.SysStatus != SysStatus.Running) return;
        if (CurOrderList.Count == (Globa.DataManager.CurOrderList).Count)
        {
            for (int i = 0; i < CurOrderList.Count; i++)
            {
                CurOrderList[i] = (Globa.DataManager.CurOrderList)[i];
            }
        }
        else
        {
            CurOrderList.Clear();
            for (int i = 0; i < (Globa.DataManager.CurOrderList).Count; i++)
            {
                CurOrderList.Add((Globa.DataManager.CurOrderList)[i]);
            }
        }
        timer.Start();
    }
}
