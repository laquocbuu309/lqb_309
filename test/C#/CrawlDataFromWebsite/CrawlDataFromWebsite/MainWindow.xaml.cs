﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrawlDataFromWebsite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<MenuTreeItem> TreeItems;
        public MainWindow()
        {
            InitializeComponent();

            TreeItems = new ObservableCollection<MenuTreeItem>();
            MenuTreeItem item1 = new MenuTreeItem() { Name = "Item1", URL = "vvv",
                Items = new ObservableCollection<MenuTreeItem>()
                {
                    new MenuTreeItem(){Name = "Sub item 1", URL = "vvv"},
                    new MenuTreeItem(){Name = "Sub item 1", URL = "vvv"},
                    new MenuTreeItem(){Name = "Sub item 1", URL = "vvv"}
                }
            };

            MenuTreeItem item2 = new MenuTreeItem()
            {
                Name = "Item2",
                URL = "vvv",
                Items = new ObservableCollection<MenuTreeItem>()
                {
                    new MenuTreeItem(){Name = "Sub item 2", URL = "vvv"},
                    new MenuTreeItem(){Name = "Sub item 2", URL = "vvv"},
                    new MenuTreeItem(){Name = "Sub item 2", URL = "vvv"}
                }
            };
            AddItemIntoTreeViewItem(TreeItems, item1);
            AddItemIntoTreeViewItem(TreeItems, item2);
            treeMain.ItemsSource = TreeItems;

        }

        #region Method
        void AddItemIntoTreeViewItem(ObservableCollection<MenuTreeItem> root, MenuTreeItem node)
        {
            root.Add(node);
        }
        #endregion
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuTreeItem item3 = new MenuTreeItem()
            {
                Name = "Item3",
                URL = "vvv",
                Items = new ObservableCollection<MenuTreeItem>()
                {
                    new MenuTreeItem(){Name = "Sub item 3", URL = "vvv"},
                    new MenuTreeItem(){Name = "Sub item 3", URL = "vvv"},
                    new MenuTreeItem(){Name = "Sub item 3", URL = "vvv"}
                }
            };
            AddItemIntoTreeViewItem(TreeItems, item3);
        }
    }
}
