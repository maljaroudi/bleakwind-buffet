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
    public class WarriorWater
    {
        public double Price { get;  }

        public uint Calories { get;  }
        public List<String> SpecialInstructions { get;  }
        public Size Size { get; set; } = Size.Small;
        public bool Ice { get; set; } = true;
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
        /// <summary>
        /// Checks the Sizes and sets the calories / prices / Special Instructions accordingly 
        /// </summary>
        public void SpecialEditor()
        {

            if (Ice == false)
            {
                SpecialInstructions.Add("Hold Ice");
            }
            if (Lemon == true)
            {
                SpecialInstructions.Add("Add Lemon");
            }

        }
        /// <summary>
        /// Constructor
        /// </summary>
        public WarriorWater()
        {
            SpecialInstructions = new List<string>();
            Price = 0;
            SpecialEditor();
        }
    }
}
