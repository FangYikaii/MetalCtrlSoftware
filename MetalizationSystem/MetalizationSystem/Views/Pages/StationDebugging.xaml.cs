using System;
using System.Collections.Generic;
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
using System.Globalization;

namespace MetalizationSystem.Views
{
    /// <summary>
    /// IsLowLiquidConverter转换器 - 将TankNumber转换为对应的Global.Device.TankXX实例的IsLowLiquid属性值
    /// </summary>
    [ValueConversion(typeof(string), typeof(bool))]
    public class IsLowLiquidConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, 
            System.Globalization.CultureInfo culture)
        {
            if (value is string tankNumber)
            {
                // 根据TankNumber获取对应的Device.Tank实例
                // 并返回其IsLowLiquid属性值
                switch (tankNumber)
                {
                    case "Tank20":
                        return Globa.Device.Tank20.IsLowLiquid;
                    case "Tank21":
                        return Globa.Device.Tank21.IsLowLiquid;
                    case "Tank22":
                        return Globa.Device.Tank22.IsLowLiquid;
                    case "Tank23":
                        return Globa.Device.Tank23.IsLowLiquid;
                    case "Tank40":
                        return Globa.Device.Tank40.IsLowLiquid;
                    case "Tank41":
                        return Globa.Device.Tank41.IsLowLiquid;
                    case "Tank42":
                        return Globa.Device.Tank42.IsLowLiquid;
                    case "Tank43":
                        return Globa.Device.Tank43.IsLowLiquid;
                    case "Tank50":
                        return Globa.Device.Tank50.IsLowLiquid;
                    case "Tank51":
                        return Globa.Device.Tank51.IsLowLiquid;
                    case "Tank52":
                        return Globa.Device.Tank52.IsLowLiquid;
                    case "Tank53":
                        return Globa.Device.Tank53.IsLowLiquid;
                    // Tank30没有液位功能，这里不做处理
                    case "Tank30":
                    default:
                        return false;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, 
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
    /// <summary>
    /// StationDebugging.xaml 的交互逻辑
    /// </summary>
    public partial class StationDebugging : UserControl
    {
        public StationDebugging()
        {
            DataContext = new StationDebuggingViewModel();
            InitializeComponent();
        }
    }
}
