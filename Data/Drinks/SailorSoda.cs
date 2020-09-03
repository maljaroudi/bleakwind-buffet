/*
 * Author: Moheeb Aljaroudi
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Sailor Soda product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Sailor Soda product detail
    /// </summary>
    public class SailorSoda
    {
        public double Price { get;  }

        public uint Calories { get;  }
        public List<String> SpecialInstructions { get; }
        public Size Size { get; set; } = Size.Small;
        public bool Ice { get; set; } = true;
        public SodaFlavor Flavor { get; set;} = SodaFlavor.Cherry;

        /// <summary>
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }


        /// <summary>
        /// Constructor, checks the values of size and puts the respective values for price and calories.
        /// It also checks if the person wants ice.
        /// </summary>
        public SailorSoda()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 1.42;
                Calories = 117;
            }
            else if (Size == Size.Medium)
            {
                Price = 1.74;
                Calories = 153;
            }
            else
            {
                Price = 2.07;
                Calories = 205;
            };
            if (Ice == false)
            {
                SpecialInstructions.Add("Hold Ice");
            }
        }

    }
}
