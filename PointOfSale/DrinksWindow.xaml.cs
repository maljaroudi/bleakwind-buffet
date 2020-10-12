/*
 * Author: Moheeb Aljaroudi
 * Class name: DrinkWindow.cs
 * Purpose: Show all drinks available
 */
using BleakwindBuffet.Data;
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
    /// window/tab for showing drinks 
    /// </summary>
    public partial class DrinksWindow : UserControl
    {


        /// <summary>
        /// initializer
        /// </summary>
        public DrinksWindow()
        {
            InitializeComponent();
          

        }
        /// <summary>
        /// Back button to back to menu items
        /// </summary>
        /// <param name="sender">back button</param>
        /// <param name="e">press</param>
        void BackButtonClick (object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }

        /// <summary>
        /// Shows chosen drink user control
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        public void ShowDrinkOptions(object sender, RoutedEventArgs e)
        {
            
            DrinkOptions drinkOption = new DrinkOptions();
            string tess = "";
            if (sender is Button) drinkOption.StringGetter = (sender as Button).Name;
            
            else if (sender is ListBox box)
            {
                drinkOption.modifier = true;
                tess = box.SelectedItem.ToString();
                drinkOption.Item = (IOrderItem)(box.SelectedItem);
                drinkOption.ordering.Tag = box.SelectedItem;

            }
            if (drinkOption.StringGetter == "candleHearthCoffee"  || tess.Contains("Coffee")) 
            {
                drinkOption.StringGetter = "candleHearthCoffee";
                drinkOption.decaf.IsEnabled = true;
                drinkOption.cream.IsEnabled = true;
            }

            else if (drinkOption.StringGetter == "sailorSoda" || tess.Contains("Soda"))
            {
                drinkOption.StringGetter = "sailorSoda";
                drinkOption.blackberry.IsEnabled = true;
                drinkOption.cherry.IsEnabled = true;
                drinkOption.cherry.IsChecked = true;
                drinkOption.lemon.IsEnabled = true;
                drinkOption.watermelon.IsEnabled = true;
                drinkOption.peach.IsEnabled = true;
                drinkOption.grapefruit.IsEnabled = true;
                drinkOption.ice.IsChecked = true;
            }
            else if (drinkOption.StringGetter == "warriorWater" || tess.Contains("Water"))
            {
                drinkOption.StringGetter = "warriorWater";
                drinkOption.ice.IsChecked = true;

            }

            if (sender is Button)
                (this.Parent as Border).Child = drinkOption;
            else (Application.Current.MainWindow as MainWindow).mainBorder.Child = drinkOption;





        }
            
    }
}
