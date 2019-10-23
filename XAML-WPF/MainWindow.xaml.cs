using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAML_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //var a = txtbl1.Inlines.ElementAt(0) as Hyperlink;
            txtbl3.Inlines.Add(new Run("www.howKteam.com"){ FontSize = 30 });
            //txtbl2.Inlines.Add(new Run "text1");
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.ToString());
        }

            public static int multiply(int a, int b)
            {
                return a*b;

        }
    }
}
