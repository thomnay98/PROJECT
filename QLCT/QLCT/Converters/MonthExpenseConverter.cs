using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace QLCT
{
    public class MonthExpenseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value as ObservableCollection<TransactionDetail>)?.Where(j => j.Date.Month == 3);
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
