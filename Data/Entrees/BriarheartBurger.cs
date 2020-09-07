/*
 * Author: Moheeb Aljaroudi
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart Burger product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Price same across all options
        /// </summary>
        public double Price { get;  } = 6.32;
        /// <summary>
        /// Sets calories and keeps it private
        /// </summary>
        public uint Calories { get;  } = 743;

        /// <summary>
        /// Adds special instructions for removing bun, Ketchup, Mustard, Pickle, Cheese
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
        /// <summary>
        /// Bun option, default to true
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Ketchup option, defaults to true
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Mustard option, defaults to true    
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Pickle Option, defaults to true
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Cheese option, defaults to true
        /// </summary>
        public bool Cheese { get; set; } = true;






    }
}
