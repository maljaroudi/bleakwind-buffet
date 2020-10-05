/*
 * Author: Moheeb Aljaroudi
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart Burger product details
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
    public class BriarheartBurger : Entree , INotifyPropertyChanged
    {
        /// <summary>
        /// Price same across all options
        /// </summary>
        public override double Price { get;  } = 6.32;
        /// <summary>
        /// Sets calories and keeps it private
        /// </summary>
        public override uint Calories { get;  } = 743;

        /// <summary>
        /// Adds special instructions for removing bun, Ketchup, Mustard, Pickle, Cheese
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
            return "Briarheart Burger";
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






    }
}
