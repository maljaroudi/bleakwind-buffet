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
    /// </summary>
    public partial class SidesWindow : UserControl
    {
        public SidesWindow()
        {
            InitializeComponent();
        }


        private void ShowSideOptions(object sender, RoutedEventArgs e)
        {
            SideOptions sideOption = new SideOptions();
            sideOption.StringGetter = (sender as Button).Name;
            (this.Parent as Border).Child = sideOption;
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }
    }
}
