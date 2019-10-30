using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for BindingWPF.xaml
    /// </summary>
    public partial class BindingWPF : Window, INotifyPropertyChanged
    {
        private string _buttonName;
        public string ButtonName
        {
            get => _buttonName;
            set
            {
                _buttonName = value;
                OnPropertyChanged("ButtonName");
            }
        }
        public BindingWPF()
        {
            InitializeComponent();
            this.DataContext = this;
            ButtonName = "Binding data from code behind";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(newName));
        }
    }
}
