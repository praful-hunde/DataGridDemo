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

            var basketNameData = baskets.Select(x => new { Name = x.Name, RowHeight = rowHeight * x.Count });

            basketNameDataGrid.ItemsSource = basketNameData.ToList();

            itemDataGrid.ItemsSource = baskets.SelectMany(basket => basket).ToList();
        }


        private Baskets GetData()
        {
            var baskets = new Baskets();

            var fruitBasket = new Basket("Fruit");
            fruitBasket.Add(new Item("Alphonso Mango", 80));
            fruitBasket.Add(new Item("Nagpur Orange", 10));
            fruitBasket.Add(new Item("Dragon Fruit", 50));

            var vegetableBasket = new Basket("Vegetable");
            vegetableBasket.Add(new Item("Bringel", 5));
            vegetableBasket.Add(new Item("Broccoli", 5));

            baskets.Add(fruitBasket);
            baskets.Add(vegetableBasket);

            return baskets;
        }
    }
}
