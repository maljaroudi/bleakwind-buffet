/*
 * Author: Moheeb Aljaroudi
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent Thugs T-Bone product details
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class ThugsTBone
    {
        public double Price { get; }

        public uint Calories { get; }

        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }


        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public ThugsTBone()
        {
            Price = 6.44;
            Calories = 982;
            SpecialInstructions = new List<string>();
        }
    }
}
