/*
 * Author: Moheeb Aljaroudi
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries product details
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace Data.Sides
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class DragonbornWaffleFries
    {
        public double Price { get; set; }

        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
        /// <summary>
        /// Constructor method basically.
        /// Checks the size and change the price and calories accordingly.
        /// </summary>
        public void SpecialEditor()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 0.42;
                Calories = 77;
            }
            else if (Size == Size.Medium)
            {
                Price = 0.76;
                Calories = 89;
            }
            else
            {
                Price = 0.96;
                Calories = 100;
            };
        }
        /// <summary>
        /// Constructor for the class, calls the method to change the price and calories
        /// </summary>
        public DragonbornWaffleFries()
        {
            SpecialEditor();
        }
    }
}
