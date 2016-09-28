using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace UserInterface
{
    public class YearToColorConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Colors.Black;

            float price = (float)value;
            if (price > 270)
            {
                brush.Color = Colors.Red;
            }
            else if (price < 100)
            {
                brush.Color = Colors.Green;
            }

            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
