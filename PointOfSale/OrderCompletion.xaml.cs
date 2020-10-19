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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using RoundRegister;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderCompletion.xaml
    /// </summary>
    public partial class OrderCompletion : UserControl
    {
        public OrderCompletion()
        {
            InitializeComponent();
        }

        private Order GetOrder => ((Application.Current.MainWindow as MainWindow).curOrder);

        private void CreditCardPayment (object sender, RoutedEventArgs e)
        {
            CardTransactionResult cardStatusResult = CardReader.RunCard(GetOrder.Total);
            switch (cardStatusResult)
            {
                case CardTransactionResult.Approved:
                    cardStatus.Text = "Approved";
                    ReceiptPrinterFunc(e);
                    return;
                case CardTransactionResult.Declined:
                    cardStatus.Text = "Your Card has been Declined";
                    return;
                case CardTransactionResult.IncorrectPin:
                    cardStatus.Text = "The PIN entered is incorrect";
                    return;
                case CardTransactionResult.InsufficientFunds:
                    cardStatus.Text = "Insufficient Funds";
                    return;
                case CardTransactionResult.ReadError:
                    cardStatus.Text = "Error Reading Card";
                    return;
            }
        }

        private void ReceiptPrinterFunc(RoutedEventArgs e)
        {

            StringChecker(GetOrder.Number.ToString());
            StringChecker(DateTime.Now.ToString());
            foreach (IOrderItem orderItem in GetOrder.Orders)
            {
                StringChecker(orderItem.ToString());
                StringChecker(string.Join(",", orderItem.SpecialInstructions));
                StringChecker(orderItem.Price.ToString());
                
            }
            StringChecker($"SubTotal: {GetOrder.Subtotal.ToString()}");
            StringChecker($"Tax: {GetOrder.Tax.ToString()}");
            if (e.OriginalSource is Button button)
            {
                if (button.Name == "creditCardButton") RecieptPrinter.PrintLine("Payment Method: Card");
                else
                {
                    RecieptPrinter.PrintLine("Payment Method: Cash");
                }
            }
            RecieptPrinter.CutTape();

        }
        private void StringChecker(string s)
        {
            string sCut;
            if (s.Length <= 40)
            {
                RecieptPrinter.PrintLine(s);
            }
            else
            {
                int indexo = s.Length;
                 sCut = s.Substring(0, 40);
                RecieptPrinter.PrintLine(s.Substring(0, 40));
                
                StringChecker(sCut);
            }
        }

        private void CashPayment(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new CashPaymentControls();
        }


        private void ReturnToMenu(object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }
    }
}
