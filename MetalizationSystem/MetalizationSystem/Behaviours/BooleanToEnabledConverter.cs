using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MetalizationSystem.Behaviours
{
    public class BooleanToEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool?)
            {
                bool? isChecked = (bool?)value;
                return isChecked.GetValueOrDefault();
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool isEnabled = (bool)value;
                return isEnabled;
            }
            return false;
        }
    }
}
