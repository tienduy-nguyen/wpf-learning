using System;
using System.Collections.Generic;
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
using WPFUnit.ExcelEpplus.HowKteam;

namespace WPFUnit.ExcelEpplus
{
    /// <summary>
    /// Interaction logic for ExcelWithEpplus.xaml
    /// </summary>
    public partial class ExcelWithEpplus : Window
    {
        public ExcelWithEpplus()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            var excelEPPlus = new HowKteam.ExcelEpplus();
            excelEPPlus.CreateExcelFile();

        }
        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            var excelEPPlus = new HowKteam.ExcelEpplus();
            var userList = excelEPPlus.GetListData();
           dtgExcel.ItemsSource = userList;

        }
        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            var userList = dtgExcel.ItemsSource.Cast<User>().ToList();
            var excelEPPlus = new HowKteam.ExcelEpplus();
            excelEPPlus.ExportData(userList);

        }
    }
}
