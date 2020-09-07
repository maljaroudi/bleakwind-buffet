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
        /// <summary>
        /// Price in relation to the size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.22;

                }

                else if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
                }
            }

        }
        /// <summary>
        /// Calories in relation to the size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 105;

                }

                else if (Size == Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
                }
            }
        }
        /// <summary>
        /// Special instruction list, empty because there is non.
        /// </summary>
        public List<String> SpecialInstructions { get; } = new List<string>();
        /// <summary>
        /// Size as enum Size.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }


    }
}
