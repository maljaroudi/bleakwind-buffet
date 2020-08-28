/*
 * Author: Moheeb Aljaroudi
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent Double Draugr product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class DoubleDraugr
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
            return "Double Draugr";
        }

        public bool Bun { get; set; } = true;
        public bool Ketchup { get; set; } = true;
        public bool Mustard { get; set; } = true;
        public bool Pickle { get; set; } = true;
        public bool Cheese { get; set; } = true;
        public bool Tomato { get; set; } = true;
        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Constructor method basically.
        /// Checks the options and add them to the special instructions.
        /// </summary>
        //Unsatisfied with this, pattern matching would have been better.
        public void SpecialEditor()
        {
            if (Bun == false) SpecialInstructions.Add("Hold Bun");
            if (Ketchup == false) SpecialInstructions.Add("Hold Ketchup");
            if (Mustard == false) SpecialInstructions.Add("Hold Mustard");
            if (Pickle == false) SpecialInstructions.Add("Hold Pickle");
            if (Cheese == false) SpecialInstructions.Add("Hold Cheese");
            if (Tomato == false) SpecialInstructions.Add("Hold Tomato");
            if (Lettuce == false) SpecialInstructions.Add("Hold Lettuce");
            if (Mayo == false) SpecialInstructions.Add("Hold Mayo");
        }

        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public DoubleDraugr()
        {
            Price = 7.32;
            Calories = 843;
            SpecialEditor();
        }
    }
}
