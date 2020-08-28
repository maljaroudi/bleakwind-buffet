/*
 * Author: Moheeb Aljaroudi
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Briarheart Burger product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class BriarheartBurger
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<String> SpecialInstructions { get; set; }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

        public bool Bun { get; set; } = true;
        public bool Ketchup { get; set; } = true;
        public bool Mustard { get; set; } = true;
        public bool Pickle { get; set; } = true;
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Constructor method basically.
        /// Checks the options and add them to the special instructions.
        /// </summary>
        //Unsatisfied with this, pattern matching would have been better.
        public void SpecialEditor()
        {
            List<String> SpecialInstructions = new List<string>();
            if (Bun == false) SpecialInstructions.Add("Hold Bun");
            if (Ketchup == false) SpecialInstructions.Add("Hold Ketchup");
            if (Mustard == false) SpecialInstructions.Add("Hold Mustard");
            if (Pickle == false) SpecialInstructions.Add("Hold Pickle");
            if (Cheese == false) SpecialInstructions.Add("Hold Cheese");

        }
        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public BriarheartBurger()
        {
            Price = 6.32;
            Calories = 743;
            SpecialEditor();
        }
        //implement false if for boolean
        



    }
}
