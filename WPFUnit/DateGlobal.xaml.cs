using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFUnit
{
    /// <summary>
    /// Interaction logic for DateGlobal.xaml
    /// </summary>
    public partial class DateGlobal : Window
    {
        public DateGlobal()
        {
            InitializeComponent();
        }

        private void CurtureInfoSwitchButton_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button)?.Tag.ToString() ?? throw new InvalidOperationException());
            lblNumber.Content = (123456789.42d).ToString("N2");
            lblDate.Content = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }
    }
}
