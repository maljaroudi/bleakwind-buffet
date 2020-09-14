/*
 * Author: Moheeb Aljaroudi
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent Smokehouse Skeleton product details
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Price initalizer sets it across all options
        /// </summary>
        public override double Price { get;  } = 5.62;

        /// <summary>
        /// Calories to show how many calories in the dish
        /// </summary>
        public override uint Calories { get; } = 602;

        /// <summary>
        /// Special instructions in case the customer doesn't want an option. it adds "hold [item]" for each item he doesn't want
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (SausageLink == false) SpecialInstructions.Add("Hold sausage");
                if (HashBrowns == false) SpecialInstructions.Add("Hold hash browns");
                if (Pancake == false) SpecialInstructions.Add("Hold pancakes");
                if (Egg == false) SpecialInstructions.Add("Hold eggs");
                return SpecialInstructions;
            }

        }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
        /// <summary>
        /// Sausage option, defaults to true
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// Hash browns option, set to true
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// Pancake option, defaults to true
        /// </summary>
        public bool Pancake { get; set; } = true;
        /// <summary>
        /// egg option, set to true
        /// </summary>
        public bool Egg { get; set; } = true;



    }
}
