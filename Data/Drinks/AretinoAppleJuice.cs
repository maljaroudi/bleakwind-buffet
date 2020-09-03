/*
 * Author: Moheeb Aljaroudi
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Aretino Apple Juice product details
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Aretino Apple Juice product detail
    /// </summary>
    public class AretinoAppleJuice
    {
        public double Price { get;  }

        public uint Calories { get;  }
        public List<String> SpecialInstructions { get;  }
        public Size Size { get; set; } = Size.Small;
        public bool Ice { get; set; } = false;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }


        /// <summary>
        /// Constructor method basically.
        /// Checks the size and change the price and calories accordingly.
        /// </summary>
        public AretinoAppleJuice()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 0.62;
                Calories = 44;
            }
            else if (Size == Size.Medium)
            {
                Price = 0.87;
                Calories = 88;
            }
            else
            {
                Price = 1.01;
                Calories = 132;
            };
            if (Ice == true)
            {
                SpecialInstructions.Add("Add Ice");
            }
        }
    }
}
