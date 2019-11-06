using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for TreeviewLazyLoad.xaml
    /// </summary>
    public partial class TreeviewLazyLoad : Window
    {
        public TreeviewLazyLoad()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                trvLazyLoad.Items.Add(CreatetreeItem(drive));
            }
        }
        //RouteEventargs chinh la item chung ta can so ra
        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            
            //Check if item is "Loading..." we will load the folder
            if ((item.Items.Count == 1) && (item.Items[0]) is string)
            {
                item.Items.Clear();
                DirectoryInfo expandedDir = null;
                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;
                if (item.Tag is DirectoryInfo)
                    expandedDir = (item.Tag as DirectoryInfo);
                try
                {
                    foreach (var subDir in expandedDir.GetDirectories())
                    {
                        item.Items.Add(CreatetreeItem(subDir));
                    }
                }
                catch {}
            }
        }

        private object CreatetreeItem(object o)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = o.ToString();
            item.Tag = o;
            //Create one item string "Loading"(de danh dau rang item chua duoc load
            item.Items.Add("Loading ...");
            return item;
        }
    }
}
