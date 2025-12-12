using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Spreadsheet;
using DynamicData;
using MetalizationSystem.DataCollection;
using MetalizationSystem.EnumCollection;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem.Views
{
    /// <summary>
    /// ProductionProcess.xaml 的交互逻辑
    /// </summary>
    public partial class ProductionProcess : UserControl
    {  
        public ProductionProcess()
        {
            DataContext = new ProductionProcessViewModel();
            InitializeComponent();
        }

       
    }
}
