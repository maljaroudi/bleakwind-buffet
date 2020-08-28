/*
 * Author: Moheeb Aljaroudi
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent Philly Poacher product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class PhillyPoacher
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
            return "Philly Poacher";
        }

        public bool Sirloin { get; set; } = true;
        public bool Onion { get; set; } = true;
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Constructor method basically.
        /// Checks the options and add them to the special instructions.
        /// </summary>
        //Unsatisfied with this, pattern matching would have been better.
        public void SpecialEditor()
        {
            if (Sirloin == false) SpecialInstructions.Add("Hold Sirloin");
            if (Onion == false) SpecialInstructions.Add("Hold Onions");
            if (Roll == false) SpecialInstructions.Add("Hold Roll");
        }

        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public PhillyPoacher()
        {
            Price = 7.23;
            Calories = 784;
            SpecialEditor();
        }
    }
}
