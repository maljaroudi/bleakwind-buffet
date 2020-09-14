/*
 * Author: Moheeb Aljaroudi
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Double Draugr product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class DoubleDraugr : Entree
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
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Ketchup Option, defaults to true
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Mustard option, defaults to true
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Pickle option, defaults to true
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Cheese option, defaults to true
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// Tomato option, defaults to true
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Lettuce option, defaults to true
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Mayo option, defaults to true
        /// </summary>
        public bool Mayo { get; set; } = true;



    }
}
