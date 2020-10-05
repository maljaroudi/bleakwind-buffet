/*
 * Author: Moheeb Aljaroudi
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Double Draugr product details
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Price, set privately across all options
        /// </summary>
        public override double Price { get;  } = 7.32;
        /// <summary>
        /// Initializes the calories across all options
        /// </summary>
        public override uint Calories { get;  } = 843;

        /// <summary>
        /// Adds special instructions in case of removing Bun, Ketchup, Mustard, Pickles, Cheese, Tomato, Lettuce, Mayo. Otherwise, returns empty list.
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
            return "Double Draugr";
        }
        /// <summary>
        /// Bun option, defaults to true
        /// </summary>

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



    }
}
