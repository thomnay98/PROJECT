using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QLCT
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value.ToString() == "Health & Wellness")
                return "health.png";
            return value.ToString().ToLower() + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
