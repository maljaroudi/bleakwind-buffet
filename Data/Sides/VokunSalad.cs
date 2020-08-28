/*
 * Author: Moheeb Aljaroudi
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace Data.Sides
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class VokunSalad
    {
        public double Price { get; set; }

        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }

        /// <summary>
        /// Constructor method basically.
        /// Checks the size and change the price and calories accordingly.
        /// </summary>
        public void SpecialEditor()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 0.93;
                Calories = 41;
            }
            else if (Size == Size.Medium)
            {
                Price = 1.28;
                Calories = 52;
            }
            else
            {
                Price = 1.82;
                Calories = 73;
            };
        }

        /// <summary>
        /// Constructor for the class, calls the method to change the price and calories
        /// </summary>
        public VokunSalad()
        {
            SpecialEditor();
        }
    }
}
