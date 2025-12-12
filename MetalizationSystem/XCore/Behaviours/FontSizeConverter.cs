//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Data;

//namespace MetalizationSystem
//{
//    public class FontSizeConverter : IMultiValueConverter
//    {
//        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
//        {
//            double scale = (double)values[0]; // 假设values[0]是缩放比例
//            double baseFontSize = (double)values[1]; // 基准字体大小
//            return baseFontSize * scale;
//        }

//        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
//        {
//            // 这里实现回传逻辑，如果不需要则直接返回空数组或抛出异常
//            throw new NotImplementedException();
//        }
//    }
//}
