/*
 * Author: Moheeb Aljaroudi
 * Class name: MainMenu.cs
 * Purpose: Main menu skeleton
 */
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Main Menu, It's only a skeleton 
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool ComboChecker { get; set; }
        public Combo Combo { get; set; } = new Combo();

        public Order curOrder
        {
            get => (Order)DataContext;
        }
        /// <summary>
        /// Unnecessary list for orders, not used
        /// </summary>
        public List<string> OrderList { get; set; } = new List<string>();
        /// <summary>
        /// Initializer, it also sets the border to the order menu
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            mainBorder.Child = new OrderWindow();
            

        }

        private void removeFromOrder_Click(object sender, RoutedEventArgs e)
        {
            var sel = Lister.SelectedItem;
            curOrder.Remove((IOrderItem)sel);
        }

        private void newOrder_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

        private void Lister_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
                var sel = Lister.SelectedItem;
            if (sel is Drink)
            {
                DrinksWindow tesso = new DrinksWindow();
                tesso.ShowDrinkOptions(sender, e);
            }
        }

        private void Lister_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int indexGetter = ((ListBox)sender).SelectedIndex;
            if (((ListBox)sender).SelectedItem != null)
            {
                specialInstruct.Text = string.Join(",", curOrder.Orders[indexGetter].SpecialInstructions);
            }
        }

        private void CompleteOrder(object sender, RoutedEventArgs e)
        {
            mainBorder.Child = new OrderCompletion();
        }

        //public void OrderListUpdater()
        //{
        //Items.AddRange(curOrder.Orders);
        //}




    }
}
