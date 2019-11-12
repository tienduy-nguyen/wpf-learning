using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WPFUnit.Annotations;

namespace WPFUnit.Learning
{
    /// <summary>
    /// Interaction logic for UpdateSourceTrigger.xaml
    /// </summary>
    public partial class UpdateSourceTrigger : Window, INotifyPropertyChanged
    {
        public UpdateSourceTrigger()
        {
            InitializeComponent();
            DataValue = "www.howkteam.com";
            this.DataContext = this; //update date to form
        }

        private string _datavalue;
        public string DataValue
        {
            get => _datavalue;
            set
            {
                _datavalue = value;
                OnPropertyChanged(nameof(DataValue));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
