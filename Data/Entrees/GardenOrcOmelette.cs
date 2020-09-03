/*
 * Author: Moheeb Aljaroudi
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent Garden Orc Omelette product details
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class GardenOrcOmelette
    {
        public double Price { get;  }

        public uint Calories { get;  }

        public List<String> SpecialInstructions { get;  }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        public bool Broccoli { get; set; } = true;
        public bool Mushrooms { get; set; } = true;
        public bool Tomato { get; set; } = true;
        public bool Cheddar { get; set; } = true;
        
        /// <summary>
        /// Constructor method basically.
        /// Checks the options and add them to the special instructions.
        /// </summary>
        //Unsatisfied with this, pattern matching would have been better.
        public void SpecialEditor()
        {
            if (Broccoli == false) SpecialInstructions.Add("Hold Broccoli");
            if (Mushrooms == false) SpecialInstructions.Add("Hold Mushrooms");
            if (Tomato == false) SpecialInstructions.Add("Hold Tomato");
            if (Cheddar == false) SpecialInstructions.Add("Hold Cheddar");
        }
        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public GardenOrcOmelette()
        {
            Price = 4.57;
            Calories = 404;
            SpecialInstructions = new List<string>();
            SpecialEditor();
        }
    }
}
