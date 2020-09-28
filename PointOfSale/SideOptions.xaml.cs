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
    /// Interaction logic for SideOptions.xaml
    /// </summary>
    public partial class SideOptions : UserControl
    {
        public string StringGetter { get; set; }
        public SideOptions()
        {
            InitializeComponent();
        }

        private void OrderTheItem(object sender, RoutedEventArgs e)
        {
            switch (StringGetter)
            {
                case "dragonbornWaffleFries":
                    DragonbornWaffleFries fries = new DragonbornWaffleFries();
                    if (this.sizer.Text == "Small") fries.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") fries.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") fries.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(fries.ToString());
                    double total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += fries.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "friedMiraak":
                    FriedMiraak fried = new FriedMiraak();
                    if (this.sizer.Text == "Small") fried.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") fried.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") fried.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(fried.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += fried.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "madOtarGrits":
                    MadOtarGrits mad = new MadOtarGrits();
                    if (this.sizer.Text == "Small") mad.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") mad.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") mad.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(mad.ToString());
                     total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += mad.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString());
                    return;
                case "vokunSalad":
                    VokunSalad salad = new VokunSalad();
                    if (this.sizer.Text == "Small") salad.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (this.sizer.Text == "Medium") salad.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (this.sizer.Text == "Large") salad.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    (Application.Current.MainWindow as MainWindow).Lister.Items.Add(salad.ToString());
                    total = double.Parse((Application.Current.MainWindow as MainWindow).priceModifier.Text);
                    total += salad.Price;
                    (Application.Current.MainWindow as MainWindow).priceModifier.Text = (total.ToString()) ;
                    return;
            }
        }

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

        private void BackToDrinks(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new SidesWindow();
        }
    }
}
