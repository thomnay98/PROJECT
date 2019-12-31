using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QLCT
{
    public class CellBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (double.Parse(value.ToString()) > 100)
                return Color.FromHex("#BF4D43");
            return double.Parse(value.ToString()) > 80 ? Color.FromHex("#DDA51E") : Color.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
