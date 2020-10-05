/*
 * Author: Moheeb Aljaroudi
 * Class name: MainMenu.cs
 * Purpose: Main menu skeleton
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Main Menu, It's only a skeleton 
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<IOrderItem> Items { get; set; } = new List<IOrderItem>();
        /// <summary>
        /// Unnecessary list for orders, not used
        /// </summary>
        public List<string> OrderList { get; set; } = new List<string>();
        /// <summary>
        /// Initializer, it also sets the border to the order menu
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            mainBorder.Child = new OrderWindow();
            

        }

        private void ListerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexGetter = ((ListBox)sender).SelectedIndex;
            if (((ListBox)sender).SelectedItem != null)
            {
                specialInstruct.Text = string.Join(",", Items[indexGetter].SpecialInstructions);
            }
        }
    }
}
