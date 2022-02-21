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

namespace Lab14_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum Type
    {
        food, technique
    }

    public class Product
    {
        public string NameProduct { get; set; }
        public string ImageProduct { get; set; }
        public int PriceProduct { get; set; }
        public Type Type { get; set; }
    }


    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Стайлер",
                PriceProduct = 59370,
                Type = Type.technique,
                ImageProduct = "data/styler.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Пицца",
                PriceProduct = 450,
                Type = Type.food,
                ImageProduct = "data/pizza.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Монитор",
                PriceProduct = 375000,
                Type = Type.technique,
                ImageProduct = "data/apple.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Nutella",
                PriceProduct = 347,
                Type = Type.food,
                ImageProduct = "data/nutella.jpg"
            });


            lst.ItemsSource = products;

        }
    }





}
