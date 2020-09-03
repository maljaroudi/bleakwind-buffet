/*
 * Author: Moheeb Aljaroudi
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits product details
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
    public class MadOtarGrits
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
            return $"{Size} Mad Otar Grits";
        }


        /// <summary>
        /// Constructor method basically.
        /// Checks the size and change the price and calories accordingly.
        /// </summary>
        public MadOtarGrits()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 1.22;
                Calories = 105;
            }
            else if (Size == Size.Medium)
            {
                Price = 1.58;
                Calories = 142;
            }
            else
            {
                Price = 1.93;
                Calories = 179;
            };
        }
    }
}
