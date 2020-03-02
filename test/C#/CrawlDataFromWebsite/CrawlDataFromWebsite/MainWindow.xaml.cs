using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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
        #region Propertises
        ObservableCollection<MenuTreeItem> TreeItems;

        HttpClient httpClient;
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();

        #endregion
        public MainWindow()
        {
            InitializeComponent();
            InitHttpClient();

            TreeItems = new ObservableCollection<MenuTreeItem>();
            treeMain.ItemsSource = TreeItems;

        }

        #region Method
        void InitHttpClient()
        {
            handler = new HttpClientHandler()
            {
                CookieContainer = cookie,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = true,
                UseDefaultCredentials = false
            };

            httpClient = new HttpClient(handler);
            //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.122 Safari/537.36");
             /*
              * Header :
              * - origin
              * - Host
              * - referer
              * - :scheme
              * - Accept
              * - Accept-Encoding
              * - Accept- Language
              * - Users - Agent
              */
            
            httpClient.BaseAddress = new Uri("https://www.howkteam.vn/");
        }

        void AddItemIntoTreeViewItem(ObservableCollection<MenuTreeItem> root, MenuTreeItem node)
        {
            root.Add(node);
        }

        string CrawlDataFromURL(string url)
        {
            string html = "";
            // Get
            html = httpClient.GetStringAsync(url).Result;
            // Post
            //html = httpClient.PostAsync(url,new StringContent("")).Result.Content.ReadAsStringAsync().Result; 
            return html;
        }

        void Crawl(string url)
        {
            string htmlLearn = CrawlDataFromURL(url);
            //var courseList = Regex.Matches(htmlLearn, "")
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wbMain.Text = CrawlDataFromURL("learn");
        }
    }
}
