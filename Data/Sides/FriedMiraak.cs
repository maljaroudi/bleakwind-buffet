/*
 * Author: Moheeb Aljaroudi
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class FriedMiraak
    {
        public double Price { get; }

        public uint Calories { get; }
        public List<String> SpecialInstructions { get;  }
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }


        /// <summary>
        /// Constructor method basically.
        /// Checks the size and change the price and calories accordingly.
        /// </summary>
        public FriedMiraak()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 1.78;
                Calories = 151;
            }
            else if (Size == Size.Medium)
            {
                Price = 2.01;
                Calories = 236;
            }
            else
            {
                Price = 2.88;
                Calories = 306;
            };
        }
    }
}
