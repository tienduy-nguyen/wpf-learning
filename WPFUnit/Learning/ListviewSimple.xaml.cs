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

namespace WPFUnit.Learning
{
    /// <summary>
    /// Interaction logic for Listview.xaml
    /// </summary>
    public partial class ListViewSimple : Window
    {
        private List<string> listData;
        public ListViewSimple()
        {
            InitializeComponent();
            listData = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                listData.Add($"Item {i.ToString()}");
                lsvData.ItemsSource = listData;
            }

        }
    }
}
