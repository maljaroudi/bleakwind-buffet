using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Runtime.CompilerServices;
namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem , INotifyPropertyChanged
    {

        private Size size;
        private Drink drink = null;
        private Side side = null;
        private Entree entree = null;


        public string Description { get; }

        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if (entree != null)
                {
                    entree.PropertyChanged -= PropertyChanged;
                }
                value.PropertyChanged += PropertyChanged;
                entree = value;
                OnPropertyChanged("Entree");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= PropertyChanged;
                }
                value.PropertyChanged += PropertyChanged;
                drink = value;
                OnPropertyChanged("Drink");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }



        public uint Calories
        {
            get
            {
                return Drink.Calories + Entree.Calories + Side.Calories;
            }
        }


        public double Price
        {
            get
            {
                double totalPrice = 0;
                if (Drink != null) totalPrice += Drink.Price;
                if (Entree != null) totalPrice += Entree.Price;
                if (Side != null) totalPrice += Side.Price;
                return totalPrice-1.00;
            }
        }

        public List<String> SpecialInstructions 
        {
            get
            {
                List<String> lister = new List<string>() ;
                if (Drink != null)
                {
                    lister.Add(Drink.ToString());
                    lister.AddRange(Drink.SpecialInstructions);
                }
                if (Entree != null)
                {
                    lister.Add(Entree.ToString());
                    lister.AddRange(Entree.SpecialInstructions);
                }

                if (Side != null)
                {
                    lister.Add(Side.ToString());
                    lister.AddRange(Side.SpecialInstructions);
                }
                   
                    return lister;
                
            }
        }


        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= PropertyChanged;
                }
                value.PropertyChanged += PropertyChanged;
                side = value;
                OnPropertyChanged("Side");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }













    }
}
