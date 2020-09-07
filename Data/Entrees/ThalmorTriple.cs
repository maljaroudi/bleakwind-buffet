/*
 * Author: Moheeb Aljaroudi
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent Thalmor Triple product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// Price initalizer sets it across all options
        /// </summary>
        public double Price { get;  } = 8.32;

        /// <summary>
        /// Calories to show how many calories in the dish 
        /// </summary>
        public uint Calories { get;  } = 943;

        /// <summary>
        /// Adds special instructions whenever the costumer doesn't want an item. It adds "hold" and append it to the list.
        /// </summary>
        public List<String> SpecialInstructions
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
                if (Egg == false) SpecialInstructions.Add("Hold eggs");
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
        /// <summary>
        /// Bun option, set to true
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Ketchup option, set to true
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// mustard option, set to true
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// pickles option, set to true
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Cheese option, set to true
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// tomato option, set to true
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// lettuce option, set to true
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// mayo option, set to true
        /// </summary>
        public bool Mayo { get; set; } = true; 
        /// <summary>
        /// bacon option, set to true
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// eggs option, set to true
        /// </summary>
        public bool Egg { get; set; } = true;
        



    }
}
