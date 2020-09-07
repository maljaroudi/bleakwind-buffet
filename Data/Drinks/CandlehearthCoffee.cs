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
        /// <summary>
        /// Sets price in relation to size of item
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.75;

                }

                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }

        }
        /// <summary>
        /// sets calories in relation to size 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;

                }

                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }
        /// <summary>
        /// sets special instructions when the Ice, RoomForCream are checked.
        /// If ice is needed, it adds ice, if not, it holds it. If cream is ineeded, it add instructions, if not it adds hold.
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (Ice) SpecialInstructions.Add("Add ice");
                if (!Ice) SpecialInstructions.Add("Hold ice");

                if (RoomForCream) SpecialInstructions.Add("Add cream");
                if (!RoomForCream) SpecialInstructions.Add("Hold cream");

                return SpecialInstructions;
            }

        }
        /// <summary>
        /// Size of drink, default to small
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Whether the costumer needs ice default to no.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Whether Cream is wanted, default is false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether the coffee is decaf, default to false.
        /// </summary>
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

        
    }
}
