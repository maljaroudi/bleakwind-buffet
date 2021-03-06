﻿/*
 * Author: Moheeb Aljaroudi
 * Class name: SideOptions.cs
 * Purpose: Show all side options
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for SideOptions.xaml shows options for respective side
    /// </summary>
    public partial class SideOptions : UserControl
    {
        /// <summary>
        /// Takes the chosen menu item from button name
        /// </summary>
        public string StringGetter { get; set; }

        
        /// <summary>
        /// Initializer
        /// </summary>
        public SideOptions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Orders the item to the list
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void OrderTheItem(object sender, RoutedEventArgs e)
        {
            
            switch (StringGetter)
            {
                case "dragonbornWaffleFries":
                    DragonbornWaffleFries fries = new DragonbornWaffleFries();
                    if (this.sizer.Text == "Small") fries.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") fries.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") fries.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    if (Combo.IsChecked == true && (Application.Current.MainWindow as MainWindow).Combo.Side != null) (Application.Current.MainWindow as MainWindow).Combo.Side = fries;

                    else (Application.Current.MainWindow as MainWindow).curOrder.Add(fries);

                    return;
                case "friedMiraak":
                    FriedMiraak fried = new FriedMiraak();
                    if (this.sizer.Text == "Small") fried.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") fried.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") fried.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    if (Combo.IsChecked == true && (Application.Current.MainWindow as MainWindow).Combo.Side != null) (Application.Current.MainWindow as MainWindow).Combo.Side = fried;

                   else  (Application.Current.MainWindow as MainWindow).curOrder.Add(fried);
                    return;
                case "madOtarGrits":
                    MadOtarGrits mad = new MadOtarGrits();
                    if (this.sizer.Text == "Small") mad.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") mad.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") mad.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    if (Combo.IsChecked == true && (Application.Current.MainWindow as MainWindow).Combo.Side != null) (Application.Current.MainWindow as MainWindow).Combo.Side = mad;

                    else (Application.Current.MainWindow as MainWindow).curOrder.Add(mad);


                    return;
                case "vokunSalad":
                    VokunSalad salad = new VokunSalad();
                    if (this.sizer.Text == "Small") salad.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") salad.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") salad.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    if (Combo.IsChecked == true && (Application.Current.MainWindow as MainWindow).Combo.Side != null) (Application.Current.MainWindow as MainWindow).Combo.Side = salad;

                    else (Application.Current.MainWindow as MainWindow).curOrder.Add(salad);

                    return;
            }
        }
        /// <summary>
        /// Slider modifier to change the size
        /// </summary>
        /// <param name="sender">slider</param>
        /// <param name="e">tick and drag</param>
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (e.NewValue)
            {
                case 0:
                    sizer.Text = "Small".ToString();
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
        /// back button to back to sides menu
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">press</param>
        private void BackToSides(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new SidesWindow();
        }
    }
}
