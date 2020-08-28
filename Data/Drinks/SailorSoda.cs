/*
 * Author: Moheeb Aljaroudi
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Sailor Soda product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    /// <summary>
    /// Provides the Sailor Soda product detail
    /// </summary>
    public class SailorSoda
    {
        public double Price { get; set; }

        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }
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
        /// Checks the Sizes and sets the calories / prices / Special Instructions accordingly 
        /// </summary>
        public void SpecialEditor()
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
        /// <summary>
        /// Constructor 
        /// </summary>
        public SailorSoda()
        {
            SpecialEditor();
        }

    }
}
