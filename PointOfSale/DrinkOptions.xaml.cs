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
    /// </summary>
    public partial class DrinkOptions : UserControl
    {
        public string StringGetter { get; set; } 
        public Drink DrinkType { get; set; }
        public DrinkOptions() 
        {
            InitializeComponent();
            

        }
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
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(drink.ToString());
                    double total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += drink.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "candleHearthCoffee":
                    CandlehearthCoffee coffee = new CandlehearthCoffee();
                    if (this.ice.IsChecked == true) coffee.Ice = true;
                    if (this.cream.IsChecked == true) coffee.RoomForCream = true;
                    if (this.decaf.IsChecked == true) coffee.Decaf = true;
                    if (this.sizer.Text == "Small") coffee.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") coffee.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") coffee.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(coffee.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += coffee.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "markarthMilk":
                    MarkarthMilk milk = new MarkarthMilk();
                    if (this.ice.IsChecked == true) milk.Ice = true;
                    if (this.sizer.Text == "Small") milk.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") milk.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") milk.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(milk.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += milk.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "sailorSoda":
                    SailorSoda soda = new SailorSoda();
                    if (this.ice.IsChecked == true) soda.Ice = true;
                    if (this.blackberry.IsChecked == true) soda.Flavor = SodaFlavor.Blackberry;
                    if (this.cherry.IsChecked == true) soda.Flavor = SodaFlavor.Cherry;
                    if (this.lemon.IsChecked == true) soda.Flavor = SodaFlavor.Lemon;
                    if (this.watermelon.IsChecked == true) soda.Flavor = SodaFlavor.Watermelon;
                    if (this.grapefruit.IsChecked == true) soda.Flavor = SodaFlavor.Grapefruit;
                    if (this.peach.IsChecked == true) soda.Flavor = SodaFlavor.Peach;
                    if (this.sizer.Text == "Small") soda.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") soda.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") soda.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(soda.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += soda.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "warriorWater":
                    WarriorWater water = new WarriorWater();
                    if (this.ice.IsChecked == true) water.Ice = true;

                    if (this.sizer.Text == "Small") water.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") water.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") water.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(water.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += water.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "backButton":
                    return;
            }


        }

        private void CheckboxChecker(object sender, RoutedEventArgs e)
        {
            CheckBox checker = (CheckBox)sender;
            List<CheckBox> checkBoxes = new List<CheckBox>{ blackberry, cherry , lemon, watermelon, grapefruit, peach};
            foreach (CheckBox box in checkBoxes)
            {
                if (box != checker) box.IsChecked = false;
            }
            
            
        }

        private void BackToDrinks(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new DrinksWindow();
        }
    }
}
