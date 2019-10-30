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

namespace WPFUnit.WPF
{
    /// <summary>
    /// Interaction logic for ScrollViewer.xaml
    /// </summary>
    public partial class ScrollViewer : Window
    {
        public ScrollViewer()
        {
            InitializeComponent();
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"ScrollBarOffsetValue = {scvMain.VerticalOffset.ToString()}");
            MessageBox.Show($"ViewportWidth = {scvMain.ViewportWidth.ToString()}");
            MessageBox.Show($"ViewportHeight = {scvMain.ViewportHeight.ToString()}");
            MessageBox.Show($"LengthBarScroll = {scvMain.ScrollableHeight.ToString()}");
            scvMain.ScrollToEnd();
        
        }
    }
}
