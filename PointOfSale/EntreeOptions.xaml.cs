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
        public string StringGetter { get; set; }
        public EntreeOptions()
        {
            InitializeComponent();
        }

        private void BackToEntrees(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new EntreeWindow();
        }

        private void OrderItem(object sender, RoutedEventArgs e)
        {
            switch (StringGetter)
            {
                case "briarheartBurger":
                    BriarheartBurger entree = new BriarheartBurger();
                    if(bun.IsChecked== true) entree.Bun = true;
                    if (ketchup.IsChecked == true) entree.Ketchup = true;
                    if (mustard.IsChecked == true) entree.Mustard = true;
                    if (pickle.IsChecked == true) entree.Pickle = true;
                    if (cheese.IsChecked == true) entree.Cheese = true;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(entree.ToString());
                    double total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += entree.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "doubleDraugr":
                    DoubleDraugr draugr = new DoubleDraugr();
                    if (bun.IsChecked == true) draugr.Bun = true;
                    if (ketchup.IsChecked == true) draugr.Ketchup = true;
                    if (mustard.IsChecked == true) draugr.Mustard = true;
                    if (pickle.IsChecked == true) draugr.Pickle = true;
                    if (cheese.IsChecked == true) draugr.Cheese = true;
                    if (tomato.IsChecked == true) draugr.Tomato = true;
                    if (lettuce.IsChecked == true) draugr.Lettuce = true;
                    if (mayo.IsChecked == true) draugr.Mayo = true;
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += draugr.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());

                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(draugr.ToString());
                    return;


                case "gardenOrcOmelette":
                    GardenOrcOmelette omellette = new GardenOrcOmelette();
                    if (broccoli.IsChecked == true) omellette.Broccoli = true;
                    if (mushroom.IsChecked == true) omellette.Mushrooms = true;
                    if (tomato.IsChecked == true) omellette.Tomato = true;
                    if (cheddar.IsChecked == true) omellette.Cheddar = true;
                    


                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(omellette.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += omellette.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "phillyPoacher":
                    
                    PhillyPoacher philly = new PhillyPoacher();
                    if (sirloin.IsChecked == true) philly.Sirloin = true;
                    if (onion.IsChecked == true) philly.Onion = true;
                    if (roll.IsChecked == true) philly.Roll = true;
                    



                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(philly.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += philly.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;

                case "smokeHouseSkeleton":

                    SmokehouseSkeleton house = new SmokehouseSkeleton();
                    if (hashBrowns.IsChecked == true) house.HashBrowns = true;
                    if (sausage.IsChecked == true) house.SausageLink = true;
                    if (pancakes.IsChecked == true) house.Pancake = true;
                    if (eggs.IsChecked == true) house.Egg = true;


                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += house.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(house.ToString());
                    return;


                case "thalmorTriple":

                    ThalmorTriple thalmor = new ThalmorTriple();
                    if (bun.IsChecked == true) thalmor.Bun = true;
                    if (ketchup.IsChecked == true) thalmor.Ketchup = true;
                    if (mustard.IsChecked == true) thalmor.Mustard = true;
                    if (pickle.IsChecked == true) thalmor.Pickle = true;
                    if (cheese.IsChecked == true) thalmor.Cheese = true;
                    if (tomato.IsChecked == true) thalmor.Tomato = true;
                    if (lettuce.IsChecked == true) thalmor.Lettuce = true;
                    if (mayo.IsChecked == true) thalmor.Mayo = true;
                    if (eggs.IsChecked == true) thalmor.Egg = true;
                    if (bacon.IsChecked == true) thalmor.Bacon = true;

                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += thalmor.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(thalmor.ToString());
                    return;

                case "thugsTbone":
                    ThugsTBone bone = new ThugsTBone();
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += bone.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(bone.ToString());
                    return;
            }
        }
    }
}
