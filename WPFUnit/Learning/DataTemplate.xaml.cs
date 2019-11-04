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
    /// Interaction logic for DataTemplate.xaml
    /// </summary>
    public partial class DataTemplate : Window
    {
        public DataTemplate()
        {
            InitializeComponent();
        }

        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            string str1 = "HowKteam.com";
            string str2 = "FreeEducation";
            btn1.DataContext = str1;
            btn2.DataContext = str2;
        }
    }
}
