/*
 * Author: Moheeb Aljaroudi
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Candlehearth Coffee product detail
    /// </summary>
    public class CandlehearthCoffee
    {
        public double Price { get; }

        public uint Calories { get; }
        public List<String> SpecialInstructions { get;  }
        public Size Size { get; set; } = Size.Small;
        public bool Ice { get; set; } = false;
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            if (Decaf == true) return $"{Size} Decaf Candlehearth Coffee";
            else return $"{Size} Candlehearth Coffee";
        }

        /// <summary>
        /// Constructor method basically.
        /// Checks the size and change the price and calories accordingly.
        /// </summary>
        public CandlehearthCoffee()
        {
            SpecialInstructions = new List<string>();
            if (Size == Size.Small)
            {
                Price = 0.75;
                Calories = 7;
            }
            else if (Size == Size.Medium)
            {
                Price = 1.25;
                Calories = 10;
            }
            else
            {
                Price = 1.75;
                Calories = 20;
            };
            if (Ice == true)
            {
                SpecialInstructions.Add("Add Ice");
            }
            if (RoomForCream == true)
            {
                SpecialInstructions.Add("Add Cream");
            }
            
        }
    }
}
