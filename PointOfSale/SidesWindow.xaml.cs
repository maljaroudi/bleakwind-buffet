/*
 * Author: Moheeb Aljaroudi
 * Class name: DrinkOptions.cs
 * Purpose: Show all Sides Available
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
    /// Interaction logic for SidesWindow.xaml
    /// shows all sides
    /// </summary>
    public partial class SidesWindow : UserControl
    {
        /// <summary>
        /// Initializer
        /// </summary>
        public SidesWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show the side option menu
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void ShowSideOptions(object sender, RoutedEventArgs e)
        {
            SideOptions sideOption = new SideOptions();
            sideOption.StringGetter = (sender as Button).Name;
            if ((Application.Current.MainWindow as MainWindow).ComboChecker)
            {
                sideOption.Combo.IsChecked = true;
                sideOption.Combo.IsEnabled = false;
            }
            (this.Parent as Border).Child = sideOption;
        }
        /// <summary>
        /// back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }
    }
}
