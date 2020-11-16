/*
 * Author: Moheeb Aljaroudi
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent Garden Orc Omelette product details
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
    public class GardenOrcOmelette : Entree , INotifyPropertyChanged
    {
        /// <summary>
        /// override for the abstract and IOrderItem property implementation. Shows the description of the item
        /// </summary>
        public override string Description { get; } = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
        /// <summary>
        /// Price initializer and property, set to the price for all options
        /// </summary>
        public override double Price { get;  } = 4.57;
        /// <summary>
        /// Calories property to show how many calories, set to all options
        /// </summary>
        public override uint Calories { get;  } = 404;

        /// <summary>
        /// List of special instructions modified when user doesn't want the boolean properties. If the user doesn't want an option it adds hold to it in the list. Otherwise, it states nothing
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (Broccoli == false) SpecialInstructions.Add("Hold broccoli");
                if (Mushrooms == false) SpecialInstructions.Add("Hold mushrooms");
                if (Tomato == false) SpecialInstructions.Add("Hold tomato");
                if (Cheddar == false) SpecialInstructions.Add("Hold cheddar");
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
            return "Garden Orc Omelette";
        }


        private bool _broccoli = true;

        /// <summary>
        /// Broccoli Option, defaults to true
        /// </summary>
        public bool Broccoli
        {
            get { return _broccoli; }
            set
            {
                _broccoli = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _mushrooms = true;
        /// <summary>
        /// Mushroom option, defaults to true
        /// </summary>
        public bool Mushrooms
        {
            get { return _mushrooms; }
            set
            {
                _mushrooms = value;
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

        private bool _cheddar = true;
        /// <summary>
        /// Cheddar option, defaults to true
        /// </summary>
        public bool Cheddar
        {
            get { return _cheddar; }
            set
            {
                _cheddar = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }


    }
}
