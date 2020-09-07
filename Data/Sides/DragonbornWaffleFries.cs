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
        /// <summary>
        /// Sets the price in relation to the size of the side. 
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.42;

                }

                else if (Size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }

        }
        /// <summary>
        /// sets the calories in terms of the size 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 77;

                }

                else if (Size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
                }
            }
        }
        /// <summary>
        /// special instruction list, there is non for this item, so it's empty.
        /// </summary>
        public List<String> SpecialInstructions { get; } = new List<string>();
        /// <summary>
        /// size of the item in enum Size
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }


    }
}
