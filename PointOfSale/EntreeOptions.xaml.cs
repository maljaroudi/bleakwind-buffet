/*
 * Author: Moheeb Aljaroudi
 * Class name: EntreeOptions.cs
 * Purpose: Show all Entree Options
 */
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for EntreeOptions.xaml
    /// </summary>
    public partial class EntreeOptions : UserControl
    {
        /// <summary>
        /// String to capture what item chosen
        /// </summary>
        public string StringGetter { get; set; }
        /// <summary>
        /// Initializer
        /// </summary>
        public EntreeOptions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Back button to back to all entrees
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void BackToEntrees(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new EntreeWindow();
        }
        /// <summary>
        /// Add item to order list
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void OrderItem(object sender, RoutedEventArgs e)
        {
            switch (StringGetter)
            {
                case "briarheartBurger":
                    BriarheartBurger entree = new BriarheartBurger();
                    if(bun.IsChecked== true) entree.Bun = false;
                    if (ketchup.IsChecked == true) entree.Ketchup = false;
                    if (mustard.IsChecked == true) entree.Mustard = false;
                    if (pickle.IsChecked == true) entree.Pickle = false;
                    if (cheese.IsChecked == true) entree.Cheese = false;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(entree.ToString());

                    (Application.Current.MainWindow as MainWindow).Items.Add(entree);
                    
                    double total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += entree.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "doubleDraugr":
                    DoubleDraugr draugr = new DoubleDraugr();
                    if (bun.IsChecked == true) draugr.Bun = false;
                    if (ketchup.IsChecked == true) draugr.Ketchup = false;
                    if (mustard.IsChecked == true) draugr.Mustard = false;
                    if (pickle.IsChecked == true) draugr.Pickle = false;
                    if (cheese.IsChecked == true) draugr.Cheese = false;
                    if (tomato.IsChecked == true) draugr.Tomato = false;
                    if (lettuce.IsChecked == true) draugr.Lettuce = false;
                    if (mayo.IsChecked == true) draugr.Mayo = false;
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += draugr.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());

                    (Application.Current.MainWindow as MainWindow).Items.Add(draugr);
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(draugr.ToString());
                    return;


                case "gardenOrcOmelette":
                    GardenOrcOmelette omellette = new GardenOrcOmelette();
                    if (broccoli.IsChecked == true) omellette.Broccoli = false;
                    if (mushroom.IsChecked == true) omellette.Mushrooms = false;
                    if (tomato.IsChecked == true) omellette.Tomato = false;
                    if (cheddar.IsChecked == true) omellette.Cheddar = false;
                    


                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(omellette.ToString());
                    (Application.Current.MainWindow as MainWindow).Items.Add(omellette);
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += omellette.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "phillyPoacher":
                    
                    PhillyPoacher philly = new PhillyPoacher();
                    if (sirloin.IsChecked == true) philly.Sirloin = false;
                    if (onion.IsChecked == true) philly.Onion = false;
                    if (roll.IsChecked == true) philly.Roll = false;
                    



                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(philly.ToString());
                    (Application.Current.MainWindow as MainWindow).Items.Add(philly);
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += philly.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;

                case "smokeHouseSkeleton":

                    SmokehouseSkeleton house = new SmokehouseSkeleton();
                    if (hashBrowns.IsChecked == true) house.HashBrowns = false;
                    if (sausage.IsChecked == true) house.SausageLink = false;
                    if (pancakes.IsChecked == true) house.Pancake = false;
                    if (eggs.IsChecked == true) house.Egg = false;


                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += house.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(house.ToString());
                    (Application.Current.MainWindow as MainWindow).Items.Add(house);
                    return;


                case "thalmorTriple":

                    ThalmorTriple thalmor = new ThalmorTriple();
                    if (bun.IsChecked == true) thalmor.Bun = false;
                    if (ketchup.IsChecked == true) thalmor.Ketchup = false;
                    if (mustard.IsChecked == true) thalmor.Mustard = false;
                    if (pickle.IsChecked == true) thalmor.Pickle = false;
                    if (cheese.IsChecked == true) thalmor.Cheese = false;
                    if (tomato.IsChecked == true) thalmor.Tomato = false;
                    if (lettuce.IsChecked == true) thalmor.Lettuce = false;
                    if (mayo.IsChecked == true) thalmor.Mayo = false;
                    if (eggs.IsChecked == true) thalmor.Egg = false;
                    if (bacon.IsChecked == true) thalmor.Bacon = false;

                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += thalmor.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(thalmor.ToString());
                    (Application.Current.MainWindow as MainWindow).Items.Add(thalmor);
                    return;

                case "thugsTbone":
                    ThugsTBone bone = new ThugsTBone();
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += bone.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(bone.ToString());
                    (Application.Current.MainWindow as MainWindow).Items.Add(bone);
                    return;
            }
        }
    }
}
