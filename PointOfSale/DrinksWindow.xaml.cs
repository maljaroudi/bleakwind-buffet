using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinksWindow.xaml
    /// </summary>
    public partial class DrinksWindow : UserControl
    {



        public DrinksWindow()
        {
            InitializeComponent();
          

        }

        void BackButtonClick (object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }


        void ShowDrinkOptions(object sender, RoutedEventArgs e)
        {
            
            DrinkOptions drinkOption = new DrinkOptions();
            drinkOption.StringGetter = (sender as Button).Name;
            if (drinkOption.StringGetter == "candleHearthCoffee")
            {
                drinkOption.decaf.IsEnabled = true;
                drinkOption.cream.IsEnabled = true;
            }

            else if (drinkOption.StringGetter == "sailorSoda")
            {
                drinkOption.blackberry.IsEnabled = true;
                drinkOption.cherry.IsEnabled = true;
                drinkOption.cherry.IsChecked = true;
                drinkOption.lemon.IsEnabled = true;
                drinkOption.watermelon.IsEnabled = true;
                drinkOption.peach.IsEnabled = true;
                drinkOption.grapefruit.IsEnabled = true;
            }
            (this.Parent as Border).Child = drinkOption;






        }
            
    }
}
