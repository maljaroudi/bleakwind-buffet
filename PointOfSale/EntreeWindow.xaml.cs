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
    /// Interaction logic for EntreeWindow.xaml
    /// </summary>
    public partial class EntreeWindow : UserControl
    {
        public EntreeWindow()
        {
            InitializeComponent();
        }

        private void ShowEntreeOptions(object sender, RoutedEventArgs e)
        {
            EntreeOptions entreeOption = new EntreeOptions();
            entreeOption.StringGetter = (sender as Button).Name;
            if (entreeOption.StringGetter == "briarheartBurger")
            {
                entreeOption.bun.IsEnabled = true;
                entreeOption.ketchup.IsEnabled = true;
                entreeOption.mustard.IsEnabled = true;
                entreeOption.pickle.IsEnabled = true;
                entreeOption.cheese.IsEnabled = true;
            }
            else if (entreeOption.StringGetter == "doubleDraugr")
            {
                entreeOption.bun.IsEnabled = true;
                entreeOption.ketchup.IsEnabled = true;
                entreeOption.mustard.IsEnabled = true;
                entreeOption.pickle.IsEnabled = true;
                entreeOption.cheese.IsEnabled = true;
                entreeOption.tomato.IsEnabled = true;
                entreeOption.lettuce.IsEnabled = true;
                entreeOption.mayo.IsEnabled = true;
            }
            else if (entreeOption.StringGetter == "gardenOrcOmelette")
            {
                entreeOption.broccoli.IsEnabled = true;
                entreeOption.mushroom.IsEnabled = true;
                entreeOption.tomato.IsEnabled = true;
                entreeOption.cheddar.IsEnabled = true;
            }
            else if (entreeOption.StringGetter == "phillyPoacher")
            {
                entreeOption.sirloin.IsEnabled = true;
                entreeOption.onion.IsEnabled = true;
                entreeOption.roll.IsEnabled = true;

            }
            else if (entreeOption.StringGetter == "smokeHouseSkeleton")
            {
                entreeOption.sausage.IsEnabled = true;
                entreeOption.hashBrowns.IsEnabled = true;
                entreeOption.pancakes.IsEnabled = true;
                entreeOption.eggs.IsEnabled = true;

            }
            else if (entreeOption.StringGetter == "thalmorTriple")
            {
                entreeOption.bun.IsEnabled = true;
                entreeOption.ketchup.IsEnabled = true;
                entreeOption.mustard.IsEnabled = true;
                entreeOption.pickle.IsEnabled = true;
                entreeOption.cheese.IsEnabled = true;
                entreeOption.tomato.IsEnabled = true;
                entreeOption.lettuce.IsEnabled = true;
                entreeOption.mayo.IsEnabled = true;
                entreeOption.eggs.IsEnabled = true;
                entreeOption.bacon.IsEnabled = true;
            }
            (this.Parent as Border).Child = entreeOption;
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }
    }
}
