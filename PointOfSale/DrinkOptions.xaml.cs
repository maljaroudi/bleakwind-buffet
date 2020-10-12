/*
 * Author: Moheeb Aljaroudi
 * Class name: DrinkOptions.cs
 * Purpose: Show all drink options
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
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkOptions.xaml
    /// Checks the boxes that are necessary
    /// Add all options from the drink that it corrsponds to
    /// </summary>
    public partial class DrinkOptions : UserControl
    {
        /// <summary>
        /// Gets the string from the previous user control and reserve it to identify the product
        /// </summary>
        public string StringGetter { get; set; }
        /// <summary>
        /// unncessary value for drink type
        /// </summary>
        public bool modifier { get; set; } = false;
        /// <summary>
        /// Initializer
        /// </summary>
        public DrinkOptions() 
        {
            InitializeComponent();
            

        }


        public IOrderItem Item { get; set; }


        /// <summary>
        /// Slider method to change value for side in increment of 5
        /// </summary>
        /// <param name="sender"> slider ticks</param>
        /// <param name="e">tick value</param>
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (e.NewValue)
            {
                case 0:
                    sizer.Text = "Small".ToString() ;
                    return;
                case 5:
                    sizer.Text = "Medium".ToString();
                    return;
                case 10:
                    sizer.Text = "Large".ToString();
                    return;
            }
        }

        /// <summary>
        /// Order item method to add to the list and change price
        /// </summary>
        /// <param name="sender">order button</param>
        /// <param name="e">event handler when button pressed</param>
        void OrderTheItem(object sender, RoutedEventArgs e)
        {
            


            switch (StringGetter)
            {
                case "aretinoAppleJuice":
                    AretinoAppleJuice drink = new AretinoAppleJuice();
                    if (this.ice.IsChecked == true) drink.Ice = true;
                    if (this.sizer.Text == "Small") drink.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") drink.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") drink.Size = BleakwindBuffet.Data.Enums.Size.Large;

                    if (modifier == true)
                    {
                        ((AretinoAppleJuice)Item).Size = drink.Size;
                        ((AretinoAppleJuice)Item).Ice = drink.Ice;
                    }

                    (Application.Current.MainWindow as MainWindow).curOrder.Add(drink);
                    
                    return;
                case "candleHearthCoffee":
                    CandlehearthCoffee coffee = new CandlehearthCoffee();
                    if (this.ice.IsChecked == true) coffee.Ice = true;
                    if (this.cream.IsChecked == true) coffee.RoomForCream = true;
                    if (this.decaf.IsChecked == true) coffee.Decaf = true;
                    if (this.sizer.Text == "Small") coffee.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") coffee.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") coffee.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    if (modifier == true)
                    {

                        foreach(IOrderItem item in (Application.Current.MainWindow as MainWindow).curOrder)
                        {
                            if (item.GetType().IsAssignableFrom(coffee.GetType()))
                            {
                                ((CandlehearthCoffee)item).Size = coffee.Size;
                                ((CandlehearthCoffee)item).Ice = coffee.Ice;
                                ((CandlehearthCoffee)item).Decaf = coffee.Decaf;
                                ((CandlehearthCoffee)item).RoomForCream = coffee.RoomForCream;
                            }
                        }
                        
                    }
                    else
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(coffee);
                    
                    return;
                case "markarthMilk":
                    MarkarthMilk milk = new MarkarthMilk();
                    if (this.ice.IsChecked == true) milk.Ice = true;
                    if (this.sizer.Text == "Small") milk.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") milk.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") milk.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    if (modifier == true)
                    {

                        foreach (IOrderItem item in (Application.Current.MainWindow as MainWindow).curOrder)
                        {
                            if (item.GetType().IsAssignableFrom(milk.GetType()))
                            {
                                ((CandlehearthCoffee)item).Size = milk.Size;
                                ((CandlehearthCoffee)item).Ice = milk.Ice;
                                

                            }
                        }

                    }
                    else
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(milk);
                    
                    return;
                case "sailorSoda":
                    SailorSoda soda = new SailorSoda();
                    if (this.ice.IsChecked == false) soda.Ice = false;
                    if (this.blackberry.IsChecked == true) soda.Flavor = SodaFlavor.Blackberry;
                    if (this.cherry.IsChecked == true) soda.Flavor = SodaFlavor.Cherry;
                    if (this.lemon.IsChecked == true) soda.Flavor = SodaFlavor.Lemon;
                    if (this.watermelon.IsChecked == true) soda.Flavor = SodaFlavor.Watermelon;
                    if (this.grapefruit.IsChecked == true) soda.Flavor = SodaFlavor.Grapefruit;
                    if (this.peach.IsChecked == true) soda.Flavor = SodaFlavor.Peach;
                    if (this.sizer.Text == "Small") soda.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") soda.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") soda.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(soda);
                    
                    return;
                case "warriorWater":
                    WarriorWater water = new WarriorWater();
                    if (this.ice.IsChecked == false) water.Ice = false;

                    if (this.sizer.Text == "Small") water.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") water.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") water.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(water);
                    
                    return;
                    

            }


        }
        /// <summary>
        /// Function to allow only 1 value from all options for sailor soda
        /// </summary>
        /// <param name="sender">any checkbox</param>
        /// <param name="e">whether it's checked</param>
        private void CheckboxChecker(object sender, RoutedEventArgs e)
        {
            CheckBox checker = (CheckBox)sender;
            List<CheckBox> checkBoxes = new List<CheckBox>{ blackberry, cherry , lemon, watermelon, grapefruit, peach};
            foreach (CheckBox box in checkBoxes)
            {
                if (box != checker) box.IsChecked = false;
            }
            
            
        }
        /// <summary>
        /// Backs  the user to previous screen
        /// </summary>
        /// <param name="sender">back button</param>
        /// <param name="e">Press Event</param>
        private void BackToDrinks(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new DrinksWindow();
        }
    }
}
