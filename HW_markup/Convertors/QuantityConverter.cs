using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HW_markup.Convertors
{
    public class QuantityConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;  
            
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString()=="" || int.TryParse(value.ToString(), out int v))
            {
                return value;
            }
            else
            {
                return 1;
            }
        }
    }
}
