/*
 * Author: Moheeb Aljaroudi
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent Thugs T-Bone product details
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class ThugsTBone
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<String> SpecialInstructions { get; set; }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

        /// <summary>
        /// Constructor method basically.
        /// </summary>
        //Unsatisfied with this, pattern matching would have been better.
        public void SpecialEditor()
        {
            SpecialInstructions = new List<string>();
        }
        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public ThugsTBone()
        {
            Price = 6.44;
            Calories = 982;
            SpecialEditor();
        }
    }
}
