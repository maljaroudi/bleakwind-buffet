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
        /// <summary>
        /// Price in relation to the size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.78;

                }

                else if (Size == Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
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
                    return 151;

                }

                else if (Size == Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
                }
            }
        }
        /// <summary>
        /// Special instruction list, there is non. so it's empty.
        /// </summary>
        public List<String> SpecialInstructions { get; } = new List<string>();
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }



    }
}
