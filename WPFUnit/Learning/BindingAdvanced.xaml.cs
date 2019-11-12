using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace WPFUnit.Learning
{
    /// <summary>
    /// Interaction logic for BindingAdvanced.xaml
    /// </summary>
    public partial class BindingAdvanced : Window
    {
        public BindingAdvanced()
        {
            InitializeComponent();
        }
    }
    public class  AgeConvert :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selDate = value as DateTime?;
            return selDate?.Year;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int year = value is int ? (int) value : 0;
            return  new DateTime(year,1,1);
        }
    }
}
