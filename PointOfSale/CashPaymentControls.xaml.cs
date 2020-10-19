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
using System.Runtime.CompilerServices;
using System.ComponentModel;
using BleakwindBuffet.Data;
using RoundRegister;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentControls.xaml
    /// </summary>
    public partial class CashPaymentControls : UserControl , INotifyPropertyChanged
    {

        private Order GetOrder => ((Application.Current.MainWindow as MainWindow).curOrder);


        private double changeDue;
        public double ChangeDue
        {
            get
            {
                changeDue = Math.Abs((fromCustomer));
                return changeDue;
            }
            set
            {
                changeDue = value;
                OnPropertyChanged("ChangeDue");
            }
        }

        public  double TotalSale { get; set; } = ((double)(Application.Current.MainWindow as MainWindow).curOrder.Total);
        private  double fromCustomer = (Application.Current.MainWindow as MainWindow).curOrder.Total;
        public double FromCustomer
        {
            get
            {
                return Math.Round(fromCustomer,2);
            }
            set
            {
                fromCustomer = value;
                OnPropertyChanged("ChangeDue");
                OnPropertyChanged("FromCustomer");
            }
        }



        private uint _q100 = 0;
        public uint Q100
        {
            get => _q100;
            set
            {
                _q100 = value;
                OnPropertyChanged("Q100");
            }
        }
        private uint _q50 = 0;
        public uint Q50
        {
            get => _q50;
            set
            {
                _q50 = value;
                OnPropertyChanged("Q50");
            }
        }
        private uint _q20 = 0;
        public uint Q20
        {
            get => _q20;
            set
            {
                _q20 = value;
                OnPropertyChanged("Q20");
            }
        }

        private uint _q10 = 0;
        public uint Q10
        {
            get => _q10;
            set
            {
                _q10 = value;
                OnPropertyChanged("Q10");
            }
        }



        private uint _q5 = 0;
        public uint Q5
        {
            get => _q5;
            set
            {
                _q5 = value;
                OnPropertyChanged("Q5");
            }
        }

        private uint _q2 = 0;
        public uint Q2
        {
            get => _q2;
            set
            {
                _q2 = value;
                OnPropertyChanged("Q2");
            }
        }


        private uint _q1 = 0;
        public uint Q1
        {
            get => _q1;
            set
            {
                _q1 = value;
                OnPropertyChanged("Q1");
            }
        }

        private uint _q05 = 0;
        public uint Q05
        {
            get => _q05;
            set
            {
                _q05 = value;
                OnPropertyChanged("Q05");
            }
        }
        private uint _q025 = 0;
        public uint Q025
        {
            get => _q025;
            set
            {
                _q025 = value;
                OnPropertyChanged("Q025");
            }
        }
        private uint _q010 = 0;
        public uint Q010
        {
            get => _q010;
            set
            {
                _q010 = value;
                OnPropertyChanged("Q010");
            }
        }
        private uint _q005 = 0;
        public uint Q005
        {
            get => _q005;
            set
            {
                _q005 = value;
                OnPropertyChanged("Q005");
            }
        }


        public CashPaymentControls()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




        private void PlusMinus (object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Tag)
                {
                    case "+100":
                        Q100 += 1;
                        FromCustomer += 100.00;
                        return;
                    case "-100":
                        FromCustomer -= 100.00;
                        Q100 -= 1;
                        return;
                    case "+50":
                        FromCustomer += 50;
                        Q50 += 1;
                        return;
                    case "-50":
                        FromCustomer -= 50;
                        Q50 -= 1;
                        return;
                    case "+20":
                        FromCustomer += 20;
                        Q20 += 1;
                        return;
                    case "-20":
                        Q20 -= 1;
                        FromCustomer -= 20;
                        return;
                    case "+10":
                        Q10 += 1;
                        FromCustomer += 10;
                        return;
                    case "-10":
                        Q10 -= 1;
                        FromCustomer -= 10;
                        return;
                    case "+5":
                        FromCustomer += 5;
                        Q5 += 1;
                        return;
                    case "-5":
                        FromCustomer -= 5;
                        Q5 -= 1;
                        return;
                    case "+2":
                        FromCustomer += 2;
                        Q2 += 1;
                        return;
                    case "-2":
                        FromCustomer -=2;
                        Q2 -= 1;
                        return;
                    case "+1":
                        FromCustomer += 1;
                        Q1 += 1;
                        return;
                    case "-1":
                        FromCustomer -= 1;
                        Q1 -= 1;
                        return;
                    case "+0.5":
                        Q05 += 1;
                        FromCustomer += 0.5;
                        return;
                    case "-0.5":
                        FromCustomer -= 0.5;
                        Q05 -= 1;
                        return;
                    case "+0.25":
                        FromCustomer += 0.25;
                        Q025 += 1;
                        return;
                    case "-0.25":
                        FromCustomer -= 0.25;
                        Q025 -= 1;
                        return;
                    case "+0.1":
                        FromCustomer += 0.1;
                        Q010 += 1;
                        return;
                    case "-0.1":
                        FromCustomer -= 0.1;
                        Q010 -= 1;
                        return;
                    case "+0.05":
                        FromCustomer += 0.05;
                        Q005 += 1;
                        return;
                    case "-0.05":
                        FromCustomer -= 0.05;
                        Q005 -= 1;
                        return;





                }




            }

        }
        
        private void ReturnBack (object sender, RoutedEventArgs e)
        {
            (this.Parent as Border).Child = new OrderWindow();
        }
        private void FinishOrder(object sender, RoutedEventArgs e)
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
                sCut = s.Substring(0, 40);
                RecieptPrinter.PrintLine(s.Substring(0, 39));
                RecieptPrinter.PrintLine("-");
                StringChecker(sCut);
            }
        }
    }
}
