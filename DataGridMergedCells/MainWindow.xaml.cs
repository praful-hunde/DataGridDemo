using DataGridMergedCells.ViewModel;
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

namespace DataGridMergedCells
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var baskets = GetData();

            int rowHeight = 20; //// itemDataGrid row height is 20 in xaml

            //// Create a list of annonymous type with properties Name an RowHeight.
            //// RowHeight = Height of one row * number of items in current basket.
            var basketNameData = baskets.Select(x => new { Name = x.Name, RowHeight = rowHeight * x.Count });

            basketNameDataGrid.ItemsSource = basketNameData.ToList();

            //// Get list of  all Items in all baskets and assign as ItemsSource to second datagrid
            itemDataGrid.ItemsSource = baskets.SelectMany(basket => basket).ToList();
        }

        /// <summary>
        /// Gets some data to bind to view
        /// </summary>
        /// <returns>Basket Collection</returns>
        private BasketCollection GetData()
        {
            var baskets = new BasketCollection();

            var fruitBasket = new Basket("Fruit");
            fruitBasket.Add(new Item("Alphonso Mango", 80));
            fruitBasket.Add(new Item("Nagpur Orange", 10));
            fruitBasket.Add(new Item("Dragon Fruit", 50));

            var vegetableBasket = new Basket("Vegetable");
            vegetableBasket.Add(new Item("Brinjal", 5));
            vegetableBasket.Add(new Item("Broccoli", 5));
            vegetableBasket.Add(new Item("Onion", 3)); 

            baskets.Add(fruitBasket);
            baskets.Add(vegetableBasket);

            return baskets;
        }
    }
}
