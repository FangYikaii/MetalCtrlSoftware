using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace XCore
{
    internal class ColorConvertBehavior : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //bool valueTemp = System.Convert.ToBoolean(value);        
            //return new SolidColorBrush(valueTemp ? Colors.Green : Colors.Red);       
            bool valueTemp = System.Convert.ToBoolean(value);
            string parameterTemp = System.Convert.ToString(parameter);
            if (parameterTemp != "")
            {
                try
                {
                    System.Drawing.Color color = System.Drawing.Color.FromName(parameterTemp);
                    System.Windows.Media.Color mColor = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
                    return new SolidColorBrush(valueTemp ? Colors.Green : mColor);
                }
                catch { }
            }
            return new SolidColorBrush(valueTemp ? Colors.Green : Colors.Red);
            //string parameterTemp = System.Convert.ToString(parameter);
            //if ("RedGray" == parameterTemp)
            //{
            //    return new SolidColorBrush(valueTemp ? Colors.Red : Colors.Gray);
            //}
            //else
            //{
            //    return new SolidColorBrush(Colors.White);
            //}
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
