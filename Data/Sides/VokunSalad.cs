/*
 * Author: Moheeb Aljaroudi
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad product details
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
    public class VokunSalad
    {
        /// <summary>
        /// Price in relation to the size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.93;

                }

                else if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
                }
            }

        }
        /// <summary>
        /// calories in relation to the size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 41;

                }

                else if (Size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
            }
        }
        /// <summary>
        /// Special instruction, there is non, so it's empty.
        /// </summary>
        public List<String> SpecialInstructions { get; } = new List<string>();
        /// <summary>
        /// Size as Enum Size. defaults to small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }



    }
}
