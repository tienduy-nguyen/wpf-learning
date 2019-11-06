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
    /// Interaction logic for Listbox.xaml
    /// </summary>
    public partial class Listbox : Window
    {
        private List<string> ListData;

        public Listbox()
        {
            InitializeComponent();
            ListData = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                ListData.Add(i.ToString());
                cboData.ItemsSource = ListData;
                lsbData.ItemsSource = ListData;
            }
        }
    }
}
