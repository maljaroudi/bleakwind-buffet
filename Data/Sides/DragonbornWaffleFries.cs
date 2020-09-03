/*
 * Author: Moheeb Aljaroudi
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries product details
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
    public class DragonbornWaffleFries
    {
        public double Price { get;  }

        public uint Calories { get;  }
        public List<String> SpecialInstructions { get;  }
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
        public DragonbornWaffleFries()
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
    }
}
