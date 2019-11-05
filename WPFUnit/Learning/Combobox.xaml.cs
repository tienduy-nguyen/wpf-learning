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
    /// Interaction logic for Combobox.xaml
    /// </summary>
    public partial class Combobox : Window
    {
        public Combobox()
        {
            InitializeComponent();
        }

        List<string> listName;
        List<Food> listFood;
        private void Combobox_OnLoaded(object sender, RoutedEventArgs e)
        {
            //Add source to list name
            listName = new List<string>(){"www.howkteam.com","Free Education","Share to be better"};
            cboListName.ItemsSource = listName;

            //Add source to list food
            listFood = new List<Food>()
            {
                new Food(){Name = "Pizza", Price = "10.00"},
                new Food(){Name = "Bobun", Price = "11.00"},
                new Food(){Name = "Burger", Price = "8.00"}
            };
            cboListFood.ItemsSource = listFood;
            //cboListFood.DisplayMemberPath = nameof(Food.Name);
            cboListFood.SelectedValuePath = nameof(Food.Price);
            cboListFood.SelectionChanged += CboListFood_SelectionChanged;

            //Add source to list color
            cboListColor.ItemsSource = typeof(Colors).GetProperties();

            //Add source to list brushes
            cboListBrush.ItemsSource = typeof(Brushes).GetProperties();
        }

        private void CboListFood_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cboListFood.SelectedValue.ToString());
        }

        public class Food
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }
    }
}
