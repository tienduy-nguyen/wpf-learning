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
    /// Interaction logic for ListViewWithGrid.xaml
    /// </summary>
    public partial class ListvViewWithGridView : Window
    {
        public ListvViewWithGridView()
        {
            InitializeComponent();
            List<Users> items = new List<Users>()
            {
                new Users(){Name = "HowKteam.com", Age =42, Mail = "1@kteam.com", Sex = SexType.Female},
                new Users(){Name = "Free Education", Age = 39, Mail = "2@kteam.com", Sex = SexType.Male},
                new Users(){Name = "Share to be better", Age = 7, Mail = "3@kteam.com", Sex = SexType.Female}
            };
            lsvUsers.ItemsSource = items;

            //Using for properties Name binding in group style of lsvUsers
            CollectionView view = CollectionViewSource.GetDefaultView(lsvUsers.ItemsSource) as CollectionView;
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);

        }
        public enum SexType
        {
            Male,
            Female
        }
        public class Users
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }
            public SexType Sex { get; set; }
        }
    }
}
