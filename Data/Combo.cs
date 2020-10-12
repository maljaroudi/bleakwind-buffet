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
        private Drink drink;
        private Side side;
        private Entree entree;

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
                return Drink.Price + Entree.Price + Side.Price - 1.00;
            }
        }

        public List<String> SpecialInstructions 
        {
            get
            {

                    SpecialInstructions.Add(Entree.ToString());
                    SpecialInstructions.AddRange(Entree.SpecialInstructions);
                    SpecialInstructions.Add(side.ToString());
                    SpecialInstructions.AddRange(side.SpecialInstructions);
                    SpecialInstructions.Add(Drink.ToString());
                    SpecialInstructions.AddRange(Drink.SpecialInstructions);
                    return SpecialInstructions;
                
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
