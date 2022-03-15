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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для GoodAddPage.xaml
    /// </summary>
    public partial class GoodAddPage : Page
    {
        private Product _currentGood = new Product();
        private string _filePath = null;
        private string _photoName = null;
        private static string _currentDirectory = Directory.GetCurrentDirectory() + @"\Images\";

        public GoodAddPage(Product selectedGoods)
        {
            InitializeComponent();
            if (selectedGoods != null)
            {
                _currentGood = selectedGoods;
                int x = selectedGoods.ProductID;
                List<Product> products = new List<Product>();
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
