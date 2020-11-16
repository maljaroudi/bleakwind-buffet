/*
 * Author: Moheeb Aljaroudi
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent Thalmor Triple product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// override for the abstract and IOrderItem property implementation. Shows the description of the item
        /// </summary>
        public override string Description { get; } = "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

        /// <summary>
        /// Price initalizer sets it across all options
        /// </summary>
        public override double Price { get;  } = 8.32;

        /// <summary>
        /// Calories to show how many calories in the dish 
        /// </summary>
        public override uint Calories { get;  } = 943;

        /// <summary>
        /// Adds special instructions whenever the costumer doesn't want an item. It adds "hold" and append it to the list.
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (Bun == false) SpecialInstructions.Add("Hold bun");
                if (Ketchup == false) SpecialInstructions.Add("Hold ketchup");
                if (Mustard == false) SpecialInstructions.Add("Hold mustard");
                if (Pickle == false) SpecialInstructions.Add("Hold pickle");
                if (Cheese == false) SpecialInstructions.Add("Hold cheese");
                if (Tomato == false) SpecialInstructions.Add("Hold tomato");
                if (Lettuce == false) SpecialInstructions.Add("Hold lettuce");
                if (Mayo == false) SpecialInstructions.Add("Hold mayo");
                if (Bacon == false) SpecialInstructions.Add("Hold bacon");
                if (Egg == false) SpecialInstructions.Add("Hold egg");
                OnPropertyChanged();
                return SpecialInstructions;
            }

        }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }



        private bool _bun = true;

        /// <summary>
        /// Bun option, default to true
        /// </summary>
        public bool Bun
        {
            get { return _bun; }
            set
            {
                _bun = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }


        private bool _ketchup = true;

        /// <summary>
        /// Ketchup option, defaults to true
        /// </summary>
        public bool Ketchup
        {
            get { return _ketchup; }
            set
            {
                _ketchup = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _mustard = true;
        /// <summary>
        /// Mustard option, defaults to true    
        /// </summary>
        public bool Mustard
        {
            get { return _mustard; }
            set
            {
                _mustard = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }


        private bool _pickle = true;


        /// <summary>
        /// Pickle Option, defaults to true
        /// </summary>
        public bool Pickle
        {
            get { return _pickle; }
            set
            {
                _pickle = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _cheese = true;

        /// <summary>
        /// Cheese option, defaults to true
        /// </summary>
        public bool Cheese
        {
            get { return _cheese; }
            set
            {
                _cheese = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _tomato = true;
        /// <summary>
        /// Tomato option, defaults to true
        /// </summary>
        public bool Tomato
        {
            get { return _tomato; }
            set
            {
                _tomato = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _lettuce = true;
        /// <summary>
        /// Lettuce option, defaults to true
        /// </summary>
        public bool Lettuce
        {
            get { return _lettuce; }
            set
            {
                _lettuce = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _mayo = true;

        /// <summary>
        /// Mayo option, defaults to true
        /// </summary>
        public bool Mayo
        {
            get { return _mayo; }
            set
            {
                _mayo = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _bacon = true;
        /// <summary>
        /// bacon option, set to true
        /// </summary>
        public bool Bacon
        {
            get { return _bacon; }
            set
            {
                _bacon = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }
        private bool _egg = true;

        /// <summary>
        /// eggs option, set to true
        /// </summary>
        public bool Egg
        {
            get { return _egg; }
            set
            {
                _egg = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }




    }
}
