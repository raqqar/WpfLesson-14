using System;
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

namespace WpfLesson_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Title = "Kettle",
                Price = 1500,
                Image = "Data/kettle.png",
                ProductType = ProductTypes.HouseAppliance
            });
            products.Add(new Product()
            {
                Title = "Milk",
                Price = 60,
                Image = "Data/milk.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                Title = "Bread",
                Price = 40,
                Image = "Data/bread.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                Title = "Water",
                Price = 20,
                Image = "Data/water.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                Title = "Hairdryer",
                Price = 2000,
                Image = "Data/hairdryer.png",
                ProductType = ProductTypes.HouseAppliance
            });

            lstBox.ItemsSource = products;
        }
    }
}
