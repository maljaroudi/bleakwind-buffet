/*
 * Author: Moheeb Aljaroudi
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Markarth Milk product detail
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// Price in relation to size of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;

                }

                else if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }

        }
        /// <summary>
        /// Calories in relation to size of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;

                }

                else if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        /// <summary>
        /// Special instructions. 
        /// It adds "Add ice" when ice is needed, otherwise it shows empty list.
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (!Ice) return SpecialInstructions;
                else
                {
                    SpecialInstructions.Add("Add ice");
                }
                return SpecialInstructions;
            }

        }
        /// <summary>
        /// Size, defaults to small
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Ice option, defaults to false.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            
            return $"{Size} Markarth Milk";
        }


    }
}
