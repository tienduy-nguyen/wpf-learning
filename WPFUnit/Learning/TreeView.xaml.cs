using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for TreeView.xaml
    /// </summary>
    public partial class TreeView : Window
    {


        public TreeView()
        {
            InitializeComponent();
            //Parent 
            MenuItem root = new MenuItem() {Title = "Menu List"};

            //Children 1
            MenuItem childItem1 = new MenuItem() {Title = "Child Item #1"};
            //Children 1.1
            childItem1.Items.Add(new MenuItem() {Title = "Child item #1.1"});
            childItem1.Items.Add(new MenuItem() {Title = "Child item #1.2"});
            childItem1.Items.Add(new MenuItem() {Title = "Child item #1.3"});
            childItem1.Items.Add(new MenuItem() {Title = "Child item #1.4"});
            root.Items.Add(childItem1);

            //Children Item 2
            MenuItem childItem2 = new MenuItem() {Title = "Child item #2"};
            //Children Item 2.1
            childItem2.Items.Add(new MenuItem() {Title = "Child item #2.1"});
            childItem2.Items.Add(new MenuItem() {Title = "Child item #2.2"});


            root.Items.Add(childItem2);
            trvMenu.Items.Add(root);


            //TreeView family
            List<Family> families = new List<Family>();
            Family family1 = new Family(){ Name = "HowKteam.com"};
            family1.Members.Add(new FamilyMember(){Name ="HowKteam",Age = "42"});
            family1.Members.Add(new FamilyMember(){Name = "Kteam", Age = "39"});
            family1.Members.Add(new FamilyMember(){Name = "Free Education", Age = "13"});
            family1.Members.Add(new FamilyMember(){Name = "Share to be better", Age = "34"});
            families.Add(family1);

            //Family 2
            Family family2 = new Family(){Name = "Kteam"};
            family2.Members.Add(new FamilyMember(){Name = "K9", Age = "2"});
            family2.Members.Add(new FamilyMember(){Name = "Mushi",Age = "23"});
            families.Add(family2);

            trvFamily.ItemsSource = families;


        }
    }

    public class MenuItem
    {
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>(); //gan giong list nhuwng no cho phep cap nhat du lieu le serve, dung cho binding
        }
        public string Title { get; set; }
        public ObservableCollection<MenuItem> Items { get; set; }
    }

    public class Family
    {
        public Family()
        {
            this.Members = new ObservableCollection<FamilyMember>();
        }
        public string Name { get; set; }
        public ObservableCollection<FamilyMember> Members { get; set; }
    }
    public class FamilyMember
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
