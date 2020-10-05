/*
 * Author: Moheeb Aljaroudi
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent Philly Poacher product details
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the Philly Poacher details
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Price initalizer for price set across all options
        /// </summary>
        public override double Price { get; } = 7.23;

        /// <summary>
        /// Calories initializer for all options
        /// </summary>
        public override uint Calories { get;  } = 784;

        /// <summary>
        /// Special instructions list when the costumer doesn't want an option. It adds hold for every option to the list. Otherwise, it doesn't show anything about it.
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (Sirloin == false) SpecialInstructions.Add("Hold sirloin");
                if (Onion == false) SpecialInstructions.Add("Hold onions");
                if (Roll == false) SpecialInstructions.Add("Hold roll");
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
            return "Philly Poacher";
        }


        private bool _sirloin = true;

        /// <summary>
        /// Sirloin option, default to true
        /// </summary>
        public bool Sirloin
        {
            get { return _sirloin; }
            set
            {
                _sirloin = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }


        private bool _onion = true;
        /// <summary>
        /// Onion option, defaults to true
        /// </summary>
        public bool Onion
        {
            get { return _onion; }
            set
            {
                _onion = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _roll = true;
        /// <summary>
        /// Roll option, defaults to true
        /// </summary>
        public bool Roll
        {
            get { return _roll; }
            set
            {
                _roll = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }




    }
}
