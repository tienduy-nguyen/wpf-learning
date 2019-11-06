using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for ListViewSorting.xaml
    /// </summary>
    public partial class ListViewSorting : Window
    {
        public bool IsSort = false;
        public ListViewSorting()
        {
            InitializeComponent();
            List<Users> items = new List<Users>()
            {
                new Users(){Name = "HowKteam.com", Age =42, Mail = "1@kteam.com", Sex = SexType.Female},
                new Users(){Name = "Free Education", Age = 39, Mail = "2@kteam.com", Sex = SexType.Male},
                new Users(){Name = "Share to be better", Age = 7, Mail = "3@kteam.com", Sex = SexType.Female},
                new Users(){Name = "Share every thing", Age = 17, Mail = "3@kteam.com", Sex = SexType.Female},
                new Users(){Name = "Kteam", Age = 30, Mail = "3@kteam.com", Sex = SexType.Male},
                new Users(){Name = "How can I?", Age = 25, Mail = "3@kteam.com", Sex = SexType.Female},
                new Users(){Name = "Share all", Age = 17, Mail = "3@kteam.com", Sex = SexType.Female},
                new Users(){Name = "K is a key", Age = 30, Mail = "3@kteam.com", Sex = SexType.Female}
            };
            lsvUsers.ItemsSource = items;

            ////Using for properties Name binding in group style of lsvUsers
            //CollectionView view = CollectionViewSource.GetDefaultView(lsvUsers.ItemsSource) as CollectionView;
            //PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            //view.GroupDescriptions.Add(groupDescription);

            //Sort list users by age
            //Sort when Initialize component
            CollectionView view = CollectionViewSource.GetDefaultView(lsvUsers.ItemsSource) as CollectionView;
            view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));

            //Now we will sort by clicked column
            //Using event clicked on grid colume header

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

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = sender as GridViewColumnHeader;
            CollectionView view = CollectionViewSource.GetDefaultView(lsvUsers.ItemsSource) as CollectionView;
            string nameSender = header.Content.ToString();
            if (IsSort)
            {
                //Remove for initialize liste
                //Remove only a sorting of column
                //view.SortDescriptions.Remove(new SortDescription(nameSender, ListSortDirection.Descending));
                view.SortDescriptions.Clear();

                //Resort for refreshing list
                view.SortDescriptions.Add(new SortDescription(nameSender, ListSortDirection.Ascending));

            }
            else
            {
                //Remove for initialize liste
                //view.SortDescriptions.Remove(new SortDescription(nameSender, ListSortDirection.Ascending));
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription(nameSender, ListSortDirection.Descending));

            }

            IsSort = !IsSort;
        }

        private void ButtonBase_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
