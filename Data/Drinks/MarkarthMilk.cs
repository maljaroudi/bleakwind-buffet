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
        public double Price { get;  }

        public uint Calories { get;  }
        public List<String> SpecialInstructions { get;  }
        public Size Size { get; set; } = Size.Small;
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            
            return $"{Size} Markarth Milk";
        }


        /// <summary>
        /// Constructor, Checks the Sizes and sets the calories / prices / Special Instructions accordingly
        /// </summary>
        public MarkarthMilk()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 1.05;
                Calories = 56;
            }
            else if (Size == Size.Medium)
            {
                Price = 1.11;
                Calories = 72;
            }
            else
            {
                Price = 1.22;
                Calories = 93;
            };
            if (Ice == true)
            {
                SpecialInstructions.Add("Add Ice");
            }
            
        }
    }
}
