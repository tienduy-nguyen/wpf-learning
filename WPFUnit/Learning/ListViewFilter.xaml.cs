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
    /// Interaction logic for ListViewFilter.xaml
    /// </summary>
    public partial class ListViewFilter : Window
    {
        public ListViewFilter()
        {
            InitializeComponent();
            List<User> items = new List<User>()
            {
                new User(){Name = "HowKteam.com", Age =42, Mail = "1@kteam.com", Sex = SexType.Female},
                new User(){Name = "Free Education", Age = 39, Mail = "2@kteam.com", Sex = SexType.Male},
                new User(){Name = "Share to be better", Age = 7, Mail = "3@kteam.com", Sex = SexType.Female},
                new User(){Name = "Share every thing", Age = 17, Mail = "3@kteam.com", Sex = SexType.Female},
                new User(){Name = "Kteam", Age = 30, Mail = "3@kteam.com", Sex = SexType.Male},
                new User(){Name = "How can I?", Age = 25, Mail = "3@kteam.com", Sex = SexType.Female},
                new User(){Name = "Share all", Age = 17, Mail = "3@kteam.com", Sex = SexType.Female},
                new User(){Name = "K is a key", Age = 30, Mail = "3@kteam.com", Sex = SexType.Female}
            };
            lsvUsers.ItemsSource = items;

            CollectionView view = CollectionViewSource.GetDefaultView(lsvUsers.ItemsSource) as CollectionView;
            view.Filter = UserFilter;
        }

        private void txbFilter_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lsvUsers.ItemsSource).Refresh();
        }

        private bool UserFilter(object item)
        {
            if (string.IsNullOrEmpty(txbFilter.Text))
                return true;
            else
            {
                // ReSharper disable once PossibleNullReferenceException
                return ((item as User).Name.IndexOf(txbFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }


        public enum SexType
        {
            Male,
            Female
        }
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }
            public SexType Sex { get; set; }
        }
    }
}
