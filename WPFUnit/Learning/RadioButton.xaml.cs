﻿using System;
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
    /// Interaction logic for RadioButton.xaml
    /// </summary>
    public partial class RadioButton : Window
    {
        public RadioButton()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            brMain.Visibility = brMain.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
