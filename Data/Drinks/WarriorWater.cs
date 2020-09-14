/*
 * Author: Moheeb Aljaroudi
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Warrior Water product detail
    /// </summary>
    public class WarriorWater : Drink
    {
        /// <summary>
        /// Price, set to 0 accross all options.
        /// </summary>
        public override double Price
        {
            get;

        } = 0;
        /// <summary>
        /// Calories, Set to 0 across all options
        /// </summary>
        public override uint Calories { get; } = 0;
        /// <summary>
        /// Water comes with ice, therefore this adds instruction for holding ice and adding lemon option when needed. 
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (Ice && !Lemon) return SpecialInstructions;
                else
                {
                    SpecialInstructions.Add("Hold ice");
                    if (Lemon) SpecialInstructions.Add("Add lemon");
                }
                return SpecialInstructions;
            }

        }


        /// <summary>
        /// Ice, defaults to true
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Lemon, Defaults to false.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }

    }
}
