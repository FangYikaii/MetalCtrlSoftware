using CommunityToolkit.Mvvm.Input;
using DbOperationLibrary;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using MetalizationSystem.DataCollection;
using MetalizationSystem.DataServer;
using MetalizationSystem.Devices;
using MetalizationSystem.EnumCollection;
using MetalizationSystem.ViewModels.Node;
using MetalizationSystem.Views;
using MetalizationSystem.Views.UC;
using Newtonsoft.Json;
using SqlSugar;
using SqlSugar.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows;

namespace MetalizationSystem.ViewModels;
using static MetalizationSystem.ViewModels.ExpDataViewModel;
using static Xceed.Wpf.Toolkit.Calculator;


public partial class ExpDataViewModel : ObservableObject
{
    #region Data Declaration
        
    private CommonDbOperation mOperation = null;
    public BindingList<FormulaData> FormulaDataList { get; set; }
    public BindingList<Samples> CVDataList { get; set; }
    public BindingList<AlgoProjConfig> AlogProjConfigList { get; set; }

    [ObservableProperty]
    string _projName;
    [ObservableProperty]
    string _expId;
    [ObservableProperty]
    string _iterId;
    [ObservableProperty]
    string _phase;
    [ObservableProperty]
    string _formulaId;
    [ObservableProperty]
    string _formulaName;
    [ObservableProperty]
    string _barCode;
    [ObservableProperty]
    string _concentration;
    [ObservableProperty]
    string _temperature;
    [ObservableProperty]
    string _soakTime;
    [ObservableProperty]
    string _pH;
    [ObservableProperty]
    string _coverage;
    [ObservableProperty]
    string _uniformity;
    [ObservableProperty]
    string _adhensionValue;
    [ObservableProperty]
    string _createTime;
    [ObservableProperty]
    string _updateTime;
    [ObservableProperty]
    string _originalImagePath;
    [ObservableProperty]
    string _processedImagePath;
    [ObservableProperty]
    string _coverageImagePath;

    #endregion

    public ExpDataViewModel(BayesExperData data)
    {
        //Update data
        ProjName = data.ProjName;
        ExpId = data.ExpID.ToString();
        IterId = data.IterId.ToString();
        Phase = data.Phase;
        FormulaId = data.Formula.ToString();
        BarCode = data.Barcode;
        Concentration = data.Concentration.ToString();
        Temperature = data.Temperature.ToString();
        SoakTime = data.SoakTime.ToString();
        PH = data.PH.ToString();
        // 初始化 AdhensionValue，如果已有值则显示数值，否则默认为空
        AdhensionValue = data.Adhesion != 0.0 ? data.Adhesion.ToString() : "";
        // 从 BayesExperData 读取 Coverage 和 Uniformity
        Coverage = data.Coverage != 0.0 ? data.Coverage.ToString() : "";
        Uniformity = data.Uniformity != 0.0 ? data.Uniformity.ToString() : "";

        mOperation = new CommonDbOperation(new CommonDbConnectionInfo()
        {
            DbType = SqlSugar.DbType.Sqlite,
            DbPath = Globa.Path.FileAlgoDB,
            DbPassword = ""
        });
        //Update formula data
        FormulaDataList = new BindingList<FormulaData>();
        List<FormulaData> list = mOperation.GetInfo<FormulaData>(x => x.FormulaId == int.Parse(FormulaId));        
        foreach (var item in list)
        {
            FormulaDataList.Add(item);
        }
        if (list.Count == 1)
        {
            FormulaName = list[0].FormulaName;
        }
        else
        {
            MessageBox.Show("Formula data error, please check formula DB!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        //Update CV Data (for image paths only)
        CVDataList = new BindingList<Samples>();
        List<Samples> cvlist = mOperation.GetInfo<Samples>(x => x.barCode == data.Barcode);
        foreach (var item in cvlist)
        {
            CVDataList.Add(item);
        }
        if (cvlist.Count == 1)
        {
            // 如果 BayesExperData 中没有 Coverage 和 Uniformity，则从 Samples 读取
            if (string.IsNullOrEmpty(Coverage))
            {
                Coverage = cvlist[0].Coverage.ToString();
            }
            if (string.IsNullOrEmpty(Uniformity))
            {
                Uniformity = cvlist[0].Uniformity.ToString();
            }
            CreateTime = cvlist[0].CreatedAt;
            UpdateTime = cvlist[0].UpdatedAt;
            OriginalImagePath = cvlist[0].OriginalImagePath;
            ProcessedImagePath = cvlist[0].ProcessedImagePath;
            CoverageImagePath = cvlist[0].CoverageAnalysisImagePath;
        }
        else
        {          
            MessageBox.Show("CV data error, please check CV DB!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

}
