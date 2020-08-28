/*
 * Author: Moheeb Aljaroudi
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent Smokehouse Skeleton product details
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class SmokehouseSkeleton
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
            return "Smokehouse Skeleton";
        }

        public bool SausageLink { get; set; } = true;
        public bool HashBrowns { get; set; } = true;
        public bool Pancake { get; set; } = true;
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Constructor method basically.
        /// Checks the options and add them to the special instructions.
        /// </summary>
        //Unsatisfied with this, pattern matching would have been better.
        public void SpecialEditor()
        {
            if (SausageLink == false) SpecialInstructions.Add("Hold sausage");
            if (HashBrowns == false) SpecialInstructions.Add("Hold hash browns");
            if (Pancake == false) SpecialInstructions.Add("Hold pancakes");
            if (Egg == false) SpecialInstructions.Add("Hold eggs");
        }
        /// <summary>
        /// Constructor for the class, calls the method and change the price and calories
        /// </summary>
        public SmokehouseSkeleton()
        {
            Price = 5.62;
            Calories = 602;
            SpecialEditor();
        }
    }
}
