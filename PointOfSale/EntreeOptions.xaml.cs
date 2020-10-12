/*
 * Author: Moheeb Aljaroudi
 * Class name: EntreeOptions.cs
 * Purpose: Show all Entree Options
 */
using BleakwindBuffet.Data;
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
                   
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(entree);

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

                    (Application.Current.MainWindow as MainWindow).curOrder.Add(draugr);
                    
                    return;


                case "gardenOrcOmelette":
                    GardenOrcOmelette omellette = new GardenOrcOmelette();
                    if (broccoli.IsChecked == true) omellette.Broccoli = false;
                    if (mushroom.IsChecked == true) omellette.Mushrooms = false;
                    if (tomato.IsChecked == true) omellette.Tomato = false;
                    if (cheddar.IsChecked == true) omellette.Cheddar = false;
                    


                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(omellette);

                    return;
                case "phillyPoacher":
                    
                    PhillyPoacher philly = new PhillyPoacher();
                    if (sirloin.IsChecked == true) philly.Sirloin = false;
                    if (onion.IsChecked == true) philly.Onion = false;
                    if (roll.IsChecked == true) philly.Roll = false;
                    



                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(philly);

                    return;

                case "smokeHouseSkeleton":

                    SmokehouseSkeleton house = new SmokehouseSkeleton();
                    if (hashBrowns.IsChecked == true) house.HashBrowns = false;
                    if (sausage.IsChecked == true) house.SausageLink = false;
                    if (pancakes.IsChecked == true) house.Pancake = false;
                    if (eggs.IsChecked == true) house.Egg = false;


                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(house);
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


                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(thalmor);
                    return;

                case "thugsTbone":
                    ThugsTBone bone = new ThugsTBone();

                    
                    (Application.Current.MainWindow as MainWindow).curOrder.Add(bone);
                    return;
            }
        }
    }
}
