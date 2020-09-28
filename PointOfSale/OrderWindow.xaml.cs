/*
 * Author: Moheeb Aljaroudi
 * Class name: OrderWindow.cs
 * Purpose: Show all menu categories 
 */
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
    /// Interaction logic for OrderWindow.xaml
    /// All Menu categories
    /// </summary>
    public partial class OrderWindow : UserControl
    {
        /// <summary>
        /// Initializer
        /// </summary>
        public OrderWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show entree button to navigate to entree menu
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void ShowEntrees(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new EntreeWindow();
        }
        /// <summary>
        /// Show sides button to navigate to sides menu
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void ShowSides(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new SidesWindow();
        }

        /// <summary>
        /// Show drinks button to navigate to drinks menu
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void ShowDrinks(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new DrinksWindow();
        }
    }
}
