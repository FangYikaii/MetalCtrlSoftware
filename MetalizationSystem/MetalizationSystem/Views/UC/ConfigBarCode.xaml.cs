using DbOperationLibrary;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MetalizationSystem.DataCollection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static Xceed.Wpf.Toolkit.Calculator;




namespace MetalizationSystem.Views.UC
{
    public class ConfigBarCodeInfo
    {
        public string ExpID { get; set; }
        public string FormulaName { get; set; }
        public string FormulaID { get; set; }
        public string BarCode { get; set; }
    }

    //对象
    public class ItemEventArges : EventArgs
    {
        public BindingList<BayesExperData> value;
        public ItemEventArges(BindingList<BayesExperData> v)
        {
            value = v;
        }
    }

    /// <summary>
    /// ConfigBarCode.xaml 的交互逻辑
    /// </summary>
    public partial class ConfigBarCode : UserControl
    {


        private CommonDbOperation mOperation = null;
        public List<ConfigBarCodeInfo> configList = new List<ConfigBarCodeInfo>();
        public BindingList<BayesExperData> BayesData = new BindingList<BayesExperData>();

        public delegate void ItemEventHandler(object sender, ItemEventArges arge);
        public event ItemEventHandler ItemEvent;

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnItemEvent(ItemEventArges e)
        {
            if (ItemEvent != null)
            {
                ItemEvent(this, e);
            }
        }

        public ConfigBarCode(BindingList<BayesExperData> BayesExperData)
        {
            InitializeComponent();

            BayesData = BayesExperData;

            mOperation = new CommonDbOperation(new CommonDbConnectionInfo()
            {
                DbType = SqlSugar.DbType.Sqlite,
                DbPath = Globa.Path.FileAlgoDB,
                DbPassword = ""
            });
            
            foreach (var item in BayesExperData)
            {
                List<FormulaData> list = mOperation.GetInfo<FormulaData>(x => x.FormulaId == item.Formula);
                string FormulaName = "";
                if (list.Count == 1)
                {
                    FormulaName = list[0].FormulaName;
                }
                configList.Add(new ConfigBarCodeInfo() { ExpID = item.ExpID.ToString(), FormulaID = item.Formula.ToString(), FormulaName = FormulaName, BarCode=""});
            }
            ConfigList.ItemsSource = configList;
        }


        private void List_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            Console.WriteLine("Start editing");
        }

        private void List_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Cancel)
            {
                return;
            }
            ContentPresenter cp = e.EditingElement as ContentPresenter;
            if (cp != null && VisualTreeHelper.GetChildrenCount(cp) > 0)
            {
                StackPanel stackPanel = VisualTreeHelper.GetChild(cp, 0) as StackPanel;
                TextBox textBox = VisualTreeHelper.GetChild(stackPanel, 0) as TextBox;
                if (textBox != null)
                {
                    string newValue = textBox.Text;
                    var dataGrid = sender as DataGrid;
                    Regex regex = new Regex(@"^\d{12}$");
                    if (regex.IsMatch(newValue))
                    {
                        textBox.Text = newValue;
                        if (textBox.Name == "BarCode_Edit")
                        {
                            configList[dataGrid.SelectedIndex].BarCode = newValue;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input 12 correct digits", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                        var OLD_textBox = cp.Content as ConfigBarCodeInfo;
                        if (textBox.Name == "BarCode_Edit")
                        {
                            textBox.Text = OLD_textBox.BarCode;
                        }
                        dataGrid.BeginEdit();
                    }

                }
            }
        }
        private void btnCancelEdit_Click(object sender, RoutedEventArgs e)
        {
            this.ConfigList.CancelEdit();
        }

        private void btnConfirmcEdit_Click(object sender, RoutedEventArgs e)
        {
            this.ConfigList.CommitEdit();
        }


        private void btnConfigDone_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Does the bar code configuration been completed?", "Inform", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if(result == MessageBoxResult.No)
            {
                return;
            }
            BindingList <BayesExperData> model = BayesData;
            foreach (var item in configList)
            {
                var data = model.Where(x => x.ExpID.ToString() == item.ExpID).FirstOrDefault();
                if (data != null)
                {
                    if (item.BarCode != null && item.BarCode.Trim() != "")
                    {
                        data.Barcode = item.BarCode;

                    }
                    else
                    {
                        MessageBox.Show("Please complete the bar code configuration!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }
            }
            OnItemEvent(new ItemEventArges(model));

        }
    }
}
