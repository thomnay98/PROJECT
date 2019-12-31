using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QLCT
{
    public class CellTextColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return double.Parse(value.ToString()) > 100 ? Color.White : Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
